using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing;

namespace WooTable
{
    public partial class Form_NumberFormat : Form
    {
        private System.Windows.Forms.DataGridView _grid = null;
        private WooTable ThisRibbon = null;
        private Double ThisSelection = 0;

        public Form_NumberFormat(WooTable _ribbon, double _selection)
        {
            InitializeComponent();
            _grid = Form_NumberFormat_grid_Formats;

            try
            {
                ThisRibbon = _ribbon;
                ThisSelection = _selection;

                for (int i = 0; i < 4; i++) _grid.Rows.Add();
                //_grid[0, 0].Value = "Currency";
                _grid[0, 0].Value = Resources.Labels.ResourceManager.GetString(_grid.Name + "_val1");
                _grid[1, 0].Value = "$#,##0.00;[Red]$#,##0.00";
                //_grid[0, 1].Value = "Accounting";
                _grid[0, 1].Value = Resources.Labels.ResourceManager.GetString(_grid.Name + "_val2");
                _grid[1, 1].Value = "_($* #,##0.00_);_($* (#,##0.00);_($* \" - \"??_);_(@_)";
                //_grid[0, 2].Value = "Scientific";
                _grid[0, 2].Value = Resources.Labels.ResourceManager.GetString(_grid.Name + "_val3");
                _grid[1, 2].Value = "0.00E+00";
                //_grid[0, 3].Value = "Custom..";
                _grid[0, 3].Value = Resources.Labels.ResourceManager.GetString(_grid.Name + "_val4");

                // try to get the examples
                _grid[2, 0].Value = ThisSelection.ToString(_grid[1, 0].Value.ToString());
                _grid[2, 1].Value = ThisSelection.ToString(_grid[1, 1].Value.ToString());
                _grid[2, 2].Value = ThisSelection.ToString(_grid[1, 2].Value.ToString());

                _grid.Update();
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Could not generate data grid: " + E.Message, "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Form_NewTable_but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_NewTable_but_Create_Click(object sender, EventArgs e)
        {
            try
            {
                String _format = "";
                if ((_grid.SelectedRows.Count == 1) && (!_grid.SelectedRows.Contains(_grid.Rows[3])))
                {
                    _format = _grid.SelectedRows[0].Cells[1].Value.ToString();
                }
                if(Form_NumberFormat_Edit_Custom.Visible)
                {
                    _format = Form_NumberFormat_Edit_Custom.Text;
                }
                ThisRibbon.Converter("CustomFormat", null, false, _format);
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Could not apply the selected format: " + E.Message, "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void Form_NumberFormat_grid_Formats_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form_NumberFormat_grid_Formats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_NumberFormat_Load(object sender, EventArgs e)
        {
            StringSetter.LocalizeMe((Form)this);
            StringSetter.LocalizeGrid(Form_NumberFormat_grid_Formats);
        }

        private void Form_NumberFormat_grid_Formats_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_grid.SelectedRows.Count == 1 && _grid.SelectedRows.Contains(_grid.Rows[3]))
                {
                    Form_NumberFormat_lab_Custom.Visible = true;
                    Form_NumberFormat_Edit_Custom.Visible = true;
                    Form_NumberFormat_edit_CustomOut.Visible = true;
                    Form_NumberFormat_Edit_Custom.Select();
                }
                else
                {
                    Form_NumberFormat_lab_Custom.Visible = false;
                    Form_NumberFormat_Edit_Custom.Visible = false;
                    Form_NumberFormat_edit_CustomOut.Visible = false;
                }
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Could not apply the selected format: " + E.Message, "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Form_NumberFormat_Edit_Custom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Form_NumberFormat_edit_CustomOut.Text = ThisSelection.ToString(Form_NumberFormat_Edit_Custom.Text);
            }
            catch// (Exception E)
            { }
        }
    }
}
