using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WooTable
{
    public partial class Form_CurrencyConverter : Form
    {
        private CurrencyConverter _cconvert = null;
        private WooTable _master = null;
        private double _val = 0;
        private double _result = 0;
        double ratio = 1;
        public Form_CurrencyConverter(WooTable _ribbon, double _value)
        {
            InitializeComponent();

            StringSetter.LocalizeMe((Form)this);

            _cconvert = CurrencyConverter.CurrencyConverter_getInstance;
            _master = _ribbon;
            _val = _value;
            Form_CurrencyConverter_text_risk.Text = Properties.Settings.Default.Curr_Risk.ToString();
        }

        private void Form_CurrencyConverter_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string key in _cconvert.currencies.Keys)
                {
                    Form_CurrencyConverter_list_Source.Items.Add(key);
                    Form_CurrencyConverter_list_Target.Items.Add(key);
                }
                if (Form_CurrencyConverter_list_Source.Items.Count > 0) Form_CurrencyConverter_list_Source.SelectedIndex = 0;
                if (Form_CurrencyConverter_list_Target.Items.Count > 0) Form_CurrencyConverter_list_Target.SelectedIndex = 0;
            }
            catch(Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Error: could not initialize the form: " + E.Message + ".", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Form_CurrencyConverter_but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CurrencyConverter_but_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                _cconvert.output_val = _result;
                _cconvert.output_str = Form_CurrencyConverter_list_Target.SelectedItem.ToString();
                _cconvert.output_ratio = ratio;
            }
            finally
            {
                this.Close();
            }
        }

        private void Form_CurrencyConverter_list_Source_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Form_CurrencyConverter_list_Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Recalculate()
        {
            try
            {
                Form_CurrencyConverter_text_Source.Text = _val.ToString("0.00") + " " + Form_CurrencyConverter_list_Source.SelectedItem.ToString();
                ratio = _cconvert.getRatio(Form_CurrencyConverter_list_Source.SelectedItem.ToString(), Form_CurrencyConverter_list_Target.SelectedItem.ToString()) * (1 + (Convert.ToDouble(Form_CurrencyConverter_text_risk.Text) / 100));
                _result = _val * ratio;
                Form_CurrencyConverter_text_Target.Text = _result.ToString("0.00") + " " + Form_CurrencyConverter_list_Target.SelectedItem.ToString();
            }
            catch { }

       }

        private void Form_CurrencyConverter_text_risk_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Form_CurrencyConverter_text_risk_Validating(object sender, CancelEventArgs e)
        {
            if (fcie.IsNumeric(Form_CurrencyConverter_text_risk.Text, System.Globalization.NumberStyles.Any))
            { }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: entered risk coefficient is not a valid number.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                Form_CurrencyConverter_text_risk.Text = Properties.Settings.Default.Curr_Risk.ToString();
            }
        }
    }
}
