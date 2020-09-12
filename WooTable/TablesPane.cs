using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WooTable
{
    public partial class TablesPane : UserControl
    {
        private Microsoft.Office.Tools.CustomTaskPane _TablesPane;

        public TablesPane(Microsoft.Office.Tools.CustomTaskPane _tPane)
        {
            InitializeComponent();
            StringSetter.setPane(this);
            _TablesPane = _tPane;
        }

        public void setSysPane(Microsoft.Office.Tools.CustomTaskPane _tPane)
        {
            _TablesPane = _tPane;
        }

        private void TablesPane_but_Apply_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception E)
            {

            }
            finally
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(_TablesPane);
            }
        }

        private void TablesPane_but_Cancel_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception E)
            {

            }
            finally
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(_TablesPane);
            }
        }
    }
}
