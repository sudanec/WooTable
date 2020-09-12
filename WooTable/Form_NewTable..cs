using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Tools.Word;
using System.Reflection;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;

namespace WooTable
{
    public partial class Form_NewTable : Form
    {
        private Resident res_inst = Resident.Resident_getInstance(null);

        public Form_NewTable()
        {
            InitializeComponent();
        }

        private void Form_NewTable_but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_NewTable_but_Create_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Range tab_location = res_inst.ThisApp.Selection.Range;
                res_inst.ThisApp.ActiveDocument.Tables.Add(tab_location, decimal.ToInt32(Math.Truncate(Form_NewTable_sel_Rows.Value)), decimal.ToInt32(Math.Truncate(Form_NewTable_sel_Columns.Value)));
            }
            finally
            {
                this.Close();
            }
        }

        private void Form_NewTable_Load(object sender, EventArgs e)
        {
            StringSetter.LocalizeMe((Form)this);
        }
    }
}
