using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace WooTable
{
    public partial class IconsPane : UserControl
    {
        private Microsoft.Office.Tools.CustomTaskPane _IconsPane;
        private static IconsPane _inst;

        public static IconsPane Instance()
        {
            {
                if (_inst == null)
                {
                    _inst = new IconsPane(null);
                }
                return _inst;
            }
        }

        private IconsPane(Microsoft.Office.Tools.CustomTaskPane _tPane)
        {
            InitializeComponent();
            StringSetter.setPane(this);
            _inst = this;
            setSysPane();
        }

        public void setSysPane()
        {
            _IconsPane = Globals.ThisAddIn.CustomTaskPanes.Add(_inst, Resources.Labels.ResourceManager.GetString("Panes_Icons"));
            _IconsPane.Visible = true;
        }

        private async void DocsPane_Load(object sender, EventArgs e)
        {
            try
            {
                ListViewItem statusItem = new ListViewItem();
                statusItem.Text = "Updating files..";
                FileSync DataManager = new FileSync(Properties.Settings.Default.WooTable_OracleData);
                IconsPane_lView_Docs.Clear();
                IconsPane_lView_Docs.Columns.Add("Icons");
                IconsPane_lView_Docs.Columns[0].Width = -2;
                IconsPane_lView_Docs.Items.Add(statusItem);
                IconsPane_lView_Docs.View = View.Tile;
                IconsPane_lView_Docs.Refresh();
                //Boolean updateStatus = await DataManager.checkUpdates();
                Task<Boolean> updateStatus = DataManager.checkUpdates();

                string localFolder;
                localFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFolder);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.WooTable_OracleData);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFilesFolder);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataIconsFolder);

                updateList(IconsPane_lView_Docs, localFolder);
            }
            catch
            {

            }
        }

        private void updateList(ListView _lst, string _sourceFolder)
        {
            _lst.Clear();

            var imageList = new ImageList();
            
            IconsPane_lView_Docs.View = View.Details;
            IconsPane_lView_Docs.Columns.Add(Resources.Labels.ResourceManager.GetString("Panes_Icons"), 450);
            //fcie.SetWindowTheme(IconsPane_lView_Docs.Handle, "Explorer", null);

            System.IO.DirectoryInfo di = new DirectoryInfo(_sourceFolder);
            
            int count = 0;
            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name != Properties.Settings.Default.UpdateTempFile && file.Name != "checksums.csv")
                {
                    //ListViewItem lst = new ListViewItem();
                    //lst.Text = "test";
                    //lst.ImageIndex = count++;
                    imageList.Images.Add(new Icon(file.FullName));
                    //IconsPane_lView_Docs.Items.Add(lst);
                }
            }
            IconsPane_lView_Docs.LargeImageList = imageList;

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name != Properties.Settings.Default.UpdateTempFile && file.Name != "checksums.csv")
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = "test";
                    lst.ImageIndex = count++;
                    //imageList.Images.Add(new Icon(file.FullName));
                    IconsPane_lView_Docs.Items.Add(lst);
                }
            }
        }

        private void IconsPane_but_Cancel_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.CustomTaskPanes.Remove(_IconsPane);
        }

        private void IconsPane_but_Create_Click(object sender, EventArgs e)
        {
            try
            {
                startApp(IconsPane_lView_Docs.SelectedItems[0].Text);
            }
            catch (Exception E)
            {

            }
            finally
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(_IconsPane);
                _inst = null;
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

        private void IconsPane_Load(object sender, EventArgs e)
        {
            try
            {
                ListViewItem statusItem = new ListViewItem();
                statusItem.Text = "Updating files..";
                FileSync DataManager = new FileSync(Properties.Settings.Default.WooTable_OracleData);
                IconsPane_lView_Docs.Clear();
                IconsPane_lView_Docs.Columns.Add("Icons");
                IconsPane_lView_Docs.Columns[0].Width = -2;
                IconsPane_lView_Docs.Items.Add(statusItem);
                IconsPane_lView_Docs.View = View.Tile;
                IconsPane_lView_Docs.Refresh();
                //Boolean updateStatus = await DataManager.checkUpdates();
                Task<Boolean> updateStatus = DataManager.checkUpdates();

                string localFolder;
                localFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFolder);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.WooTable_OracleData);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataFilesFolder);
                localFolder = Path.Combine(localFolder, Properties.Settings.Default.AppDataIconsFolder);
                updateList(IconsPane_lView_Docs, localFolder);
            }
            catch
            {

            }
        }
    }
}
