using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace WooTable
{
    public partial class ThisAddIn
    {
        //private TablesPane _tabPane;
        //private Microsoft.Office.Tools.CustomTaskPane _TablesPane;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //_tabPane = new TablesPane();
            //_TablesPane = CustomTaskPanes.Add(_tabPane, "Tables");
            //_TablesPane.Visible = false;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
