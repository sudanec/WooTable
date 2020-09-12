using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WooTable
{
    public partial class Form_Settings : Form
    {
        private WooTable ThisRibbon = null;

        public Form_Settings(WooTable _ribbon)
        {
            ThisRibbon = _ribbon;
            InitializeComponent();
        }

        private void Form_Settings_but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Settings_but_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.StatusBarUpdate = Form_Settings_check_ModifyStatusBar.Checked;
                Properties.Settings.Default.Show_Min = Form_Settings_check_ShowMin.Checked;
                Properties.Settings.Default.Show_Max = Form_Settings_check_ShowMax.Checked;
                Properties.Settings.Default.Show_Median = Form_Settings_check_ShowMedian.Checked;
                double _temp = fcie.GetNumeric(Form_Settings_text_Ratio.Text, System.Globalization.NumberStyles.Any);
                if (_temp > double.MinValue) Properties.Settings.Default.Curr_Risk = _temp;
                Properties.Settings.Default.Curr_Provider = Form_Settings_combo_Provider.Text;
                Properties.Settings.Default.OracleDataLocation = Form_Settings_combo_OracleDataLocation.Text;
                Properties.Settings.Default.DialogOnMath = Form_Settings_check_DialogOnMath.Checked;
                Properties.Settings.Default.XLSNewLine = Form_Settings_check_ReplaceNLine.Checked;
                String temp = Form_Settings_combo_lang.Text;
                Properties.Settings.Default.Culture = temp.Substring(temp.LastIndexOf("(") + 1, temp.LastIndexOf(")") - temp.LastIndexOf("(") - 1);
                Properties.Settings.Default.CultureString = temp.Substring(0, temp.LastIndexOf("(") - 1);
                Properties.Settings.Default.Save();
                //ThisRibbon.setButtonStates();             // DO NOT USE, deprecated

                //Oracle login and password
                PasswordManager.SavePassword(Properties.Settings.Default.WooTable_OracleData, Form_Settings_text_OracleDataUsername.Text, Form_Settings_text_OracleDataPassword.Text);

                //set language
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Culture);
                Resident _resident = Resident.Resident_getInstance(null);
                _resident.RefreshAll();
            }
            finally
            {
                this.Close();
            }
        }

        private void Form_Settings_gr_StatusBar_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            try
            {
                StringSetter.LocalizeMe((Form)this);

                Form_Settings_check_ModifyStatusBar.Checked = Properties.Settings.Default.StatusBarUpdate;
                Form_Settings_check_ShowMin.Checked = Properties.Settings.Default.Show_Min;
                Form_Settings_check_ShowMax.Checked = Properties.Settings.Default.Show_Max;
                Form_Settings_check_ShowMedian.Checked = Properties.Settings.Default.Show_Median;
                Form_Settings_check_ShowMin.Enabled = Properties.Settings.Default.StatusBarUpdate;
                Form_Settings_check_ShowMax.Enabled = Properties.Settings.Default.StatusBarUpdate;
                Form_Settings_check_ShowMedian.Enabled = Properties.Settings.Default.StatusBarUpdate;
                Form_Settings_combo_Provider.Text = Properties.Settings.Default.Curr_Provider;
                Form_Settings_text_Ratio.Text = Properties.Settings.Default.Curr_Risk.ToString();
                Form_Settings_check_DialogOnMath.Checked = Properties.Settings.Default.DialogOnMath;
                Form_Settings_check_ReplaceNLine.Checked = Properties.Settings.Default.XLSNewLine;
                Form_Settings_combo_OracleDataLocation.Text = Properties.Settings.Default.OracleDataLocation;
                //Form_Settings_check_DialogOnMath.Enabled = Properties.Settings.Default.StatusBarUpdate;

                Form_Settings_combo_lang.Items.Clear();
                foreach (string _str in fcie.Localizations("Labels")) { Form_Settings_combo_lang.Items.Add(_str); }
                Form_Settings_combo_lang.Text = Properties.Settings.Default.CultureString + " (" + Properties.Settings.Default.Culture + ")";

                //Oracle login and password
                Tuple<string, string> OracleLogin = PasswordManager.GetPassword(Properties.Settings.Default.WooTable_OracleData);
                Form_Settings_text_OracleDataUsername.Text = OracleLogin.Item1;
                Form_Settings_text_OracleDataPassword.Text = OracleLogin.Item2;
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Error: property could not be set. Error message: " + E.Message, "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Form_Settings_check_ModifyStatusBar_CheckedChanged(object sender, EventArgs e)
        {
            Form_Settings_check_ShowMin.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
            Form_Settings_check_ShowMax.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
            Form_Settings_check_ShowMedian.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
            //Form_Settings_check_DialogOnMath.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
        }

        private void Form_Settings_check_ModifyStatusBar_CheckStateChanged(object sender, EventArgs e)
        {
            Form_Settings_check_ShowMin.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
            Form_Settings_check_ShowMax.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
            Form_Settings_check_ShowMedian.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
            //Form_Settings_check_DialogOnMath.Enabled = Form_Settings_check_ModifyStatusBar.Checked;
        }

        private void Form_Settings_text_Ratio_Validating(object sender, CancelEventArgs e)
        {
            if (fcie.IsNumeric(Form_Settings_text_Ratio.Text,System.Globalization.NumberStyles.Any))
                { }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: entered risk coefficient is not a valid number.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                Form_Settings_text_Ratio.Text = Properties.Settings.Default.Curr_Risk.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
