using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;

namespace WooTable
{
    public partial class DocsPane : UserControl
    {
        private Microsoft.Office.Tools.CustomTaskPane _DocsPane;
        private static DocsPane _inst;

        public static DocsPane Instance()
        {
            {
                //if (_inst == null)
                //{
                    _inst = new DocsPane(null);
                //} 
                return _inst;
            }
        }

        private DocsPane(Microsoft.Office.Tools.CustomTaskPane _tPane)
        {
            InitializeComponent();
            StringSetter.setPane(this);
            _inst = this;
            setSysPane();
        }

        public void setSysPane()
        {
            _DocsPane = Globals.ThisAddIn.CustomTaskPanes.Add(_inst, Resources.Labels.ResourceManager.GetString("Panes_Docs"));
            _DocsPane.Visible = true;
        }

        private async void DocsPane_Load(object sender, EventArgs e)
        {
            try
            {
                ListViewItem statusItem = new ListViewItem();
                statusItem.Text = "Updating files..";
                FileSync DataManager = new FileSync(Properties.Settings.Default.WooTable_OracleData);
                DocsPane_lView_Docs.Clear();
                DocsPane_lView_Docs.Columns.Add("Documents");
                DocsPane_lView_Docs.Columns[0].Width = -2;
                DocsPane_lView_Docs.Items.Add(statusItem);
                DocsPane_lView_Docs.View = View.Tile;
                DocsPane_lView_Docs.Refresh();
                //Boolean updateStatus = await DataManager.checkUpdates();
                Task<Boolean> updateStatus = DataManager.checkUpdates();

                string localFolder;
                localFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFolder);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.WooTable_OracleData);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFilesFolder);
                updateList(DocsPane_lView_Docs, localFolder);
            }
            catch
            {

            }
        }

        private void updateList(ListView _lst, string _sourceFolder)
        {
            _lst.Clear();

            // Obtain a handle to the system image list.
            fcie.SHFILEINFO shfi = new fcie.SHFILEINFO();
            IntPtr hSysImgList = fcie.SHGetFileInfo("",
                                                             0,
                                                             ref shfi,
                                                             (uint)Marshal.SizeOf(shfi),
                                                             fcie.SHGFI_SYSICONINDEX
                                                              | fcie.SHGFI_SMALLICON);

            // Set the ListView control to use that image list 
            IntPtr hOldImgList = fcie.SendMessage(DocsPane_lView_Docs.Handle,
                                                           fcie.LVM_SETIMAGELIST,
                                                           fcie.LVSIL_SMALL,
                                                           hSysImgList);
            // If the ListView control already had an image list, delete the old one
            if (hOldImgList != IntPtr.Zero)
            {
                fcie.ImageList_Destroy(hOldImgList);
            }

            DocsPane_lView_Docs.View = View.Details;
            DocsPane_lView_Docs.Columns.Add(Resources.Labels.ResourceManager.GetString("Panes_Docs"), 450);
            fcie.SetWindowTheme(DocsPane_lView_Docs.Handle, "Explorer", null);

            System.IO.DirectoryInfo di = new DirectoryInfo(_sourceFolder);
            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name != Properties.Settings.Default.UpdateTempFile && file.Name != "checksums.csv")
                {
                    IntPtr himl = fcie.SHGetFileInfo(file.FullName,
                                                0,
                                                ref shfi,
                                                (uint)Marshal.SizeOf(shfi),
                                                fcie.SHGFI_DISPLAYNAME
                                                  | fcie.SHGFI_SYSICONINDEX
                                                  | fcie.SHGFI_SMALLICON);
                    _lst.Items.Add(shfi.szDisplayName, shfi.iIcon);
                }
                
            }
        }

        private void DocsPane_but_Cancel_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.CustomTaskPanes.Remove(_DocsPane);
            _inst = null;
        }

        private void DocsPane_but_Create_Click(object sender, EventArgs e)
        {
            try
            {
                startApp(DocsPane_lView_Docs.SelectedItems[0].Text);
            }
            catch (Exception E)
            {

            }
            finally
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(_DocsPane);
                _inst = null;
                //_inst.Visible = false;
            }
        }

        private void startApp(String _actFile)
        {
            string localFolder;
            localFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFolder);
            localFolder = Path.Combine(localFolder, Properties.Settings.Default.WooTable_OracleData);
            localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFilesFolder);
            System.Diagnostics.Process.Start(Path.Combine(localFolder, _actFile));
        }

        private void DocsPane_lView_Docs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            startApp(DocsPane_lView_Docs.SelectedItems[0].Text);
        }
    }
}
