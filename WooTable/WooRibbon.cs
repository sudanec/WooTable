using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Globalization;

namespace WooTable
{
    public partial class WooTable
    {
        private Resident _resident = null;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            try
            {
                _resident = Resident.Resident_getInstance(this);
                //_resident.setMasterObject(this);
                //_cconvert = CurrencyConverter.CurrencyConverter_getInstance;
                //setButtonStates();        //DO NOT USE, deprecated
                //lab_WooTable_Free.Label = "This is a free version. Please donate!";
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Fatal error: " + E.Message, "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void setButtonStates()
        {
            but_WooTable_Median.Enabled = Properties.Settings.Default.Show_Median;
        }

        private void but_WooTable_Donate_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sudanec.com/donate");
        }

        private void but_WooTable_Home_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sudanec.com/projects/wootable/");
        }

        private void but_WooTable_NewTable_Click(object sender, RibbonControlEventArgs e)
        {
            Form_NewTable newForm = new Form_NewTable();
            newForm.Show();
        }

        private void but_WooTable_Sum_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Math_Sum newForm = new Form_Math_Sum();
            newForm.Show();
        }

        private void sbut_WooTable_XLS1_Click(object sender, RibbonControlEventArgs e)
        {
            ConverterE.AllTablesToExcel(Globals.ThisAddIn.Application.ActiveDocument, "alltables");
        }

        private void but_WooTable_Settings_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Settings newForm = new Form_Settings(this);
            newForm.ShowDialog();
        }

        private void but_WooTable_Min_Click(object sender, RibbonControlEventArgs e)
        {
            Clipboard.SetText(_resident.min.ToString());
            ShowNotif("MIN");
        }

        private void but_WooTable_Max_Click(object sender, RibbonControlEventArgs e)
        {
            Clipboard.SetText(_resident.max.ToString());
            ShowNotif("MAX");
        }

        private void but_WooTable_Avg_Click(object sender, RibbonControlEventArgs e)
        {
            Clipboard.SetText(_resident.average.ToString());
            ShowNotif("AVG");
        }

        private void but_WooTable_Sum_Click_1(object sender, RibbonControlEventArgs e)
        {
            Clipboard.SetText(_resident.sum.ToString());
            ShowNotif("SUM");
        }

        private void but_WooTable_Median_Click(object sender, RibbonControlEventArgs e)
        {
            Clipboard.SetText(_resident.median.ToString());
            ShowNotif("MEDIAN");
        }

        private void ShowNotif(string _value)
        {
            if (Properties.Settings.Default.DialogOnMath)
            {
                System.Windows.Forms.MessageBox.Show("The " + _value + " of the selected cells has been copied to clipboard. Paste it anywhere using CTRL + V.", "WooTable .::. Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        private void but_WooTable_xls1_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Worksheet _sht = null;
            if (tog_WooTable_XLS.Checked)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application _app = (Microsoft.Office.Interop.Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                    _sht = _app.ActiveSheet;
                }
                catch (Exception E)
                {
                    _sht = null;
                    System.Windows.Forms.MessageBox.Show("Could not touch the opened MS Excel document: " + E.Message + ". Will paste to a new document, instead.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            ConverterE.TableToExcel(Globals.ThisAddIn.Application.Selection.Range, "range", _sht);
        }

        private void but_WooTable_xls2_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Worksheet _sht = null;
            if (tog_WooTable_XLS.Checked)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application _app = (Microsoft.Office.Interop.Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                    _sht = _app.ActiveSheet;
                }
                catch (Exception E)
                {
                    _sht = null;
                    System.Windows.Forms.MessageBox.Show("Could not touch the opened MS Excel document: " + E.Message + ". Will paste to a new document, instead.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }

            Globals.ThisAddIn.Application.ScreenUpdating = false;
            try
            {
                Word.Range _oldSel = Globals.ThisAddIn.Application.Selection.Range;
                Globals.ThisAddIn.Application.Selection.Tables[1].Select();
                Word.Table _tab = Globals.ThisAddIn.Application.Selection.Tables[1];
                //Word.Table _tab = Globals.ThisAddIn.Application.ActiveDocument.Tables[Globals.ThisAddIn.Application.ActiveDocument.Range(0, Globals.ThisAddIn.Application.Selection.Tables[1].Range.End).Tables.Count];
                ConverterE.TableToExcel(_tab.Range, "table", _sht);
                _oldSel.Select();
            }
            finally
            {
                Globals.ThisAddIn.Application.ScreenUpdating = true;
            }
        }

        private void tog_WooTable_XLS_Click(object sender, RibbonControlEventArgs e)
        {
            //if (tog_WooTable_XLS.Label == "to new XLS") tog_WooTable_XLS.Label = "to opened XLS"; else tog_WooTable_XLS.Label = "to new XLS";
            if (tog_WooTable_XLS.Label == Resources.Labels.ResourceManager.GetString("Ribbon_Labels_tog_WooTable_XLS")) tog_WooTable_XLS.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_tog_WooTable_XLS1"); else tog_WooTable_XLS.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_tog_WooTable_XLS");
        }

        private void gal_WooTable_Format_ButtonClick(object sender, RibbonControlEventArgs e)
        {
            try
            {
                Microsoft.Office.Tools.Ribbon.RibbonButton _but = (Microsoft.Office.Tools.Ribbon.RibbonButton)sender;
                Converter(_but.Name);
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, this was quite an unexpected error, I don't get what you clicked: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Converter(string _sender, Word.Cells _cells = null, bool other_currency = false, string custom_format = "", double multiplier = 1)
        {
            try
            {
                _cells = Globals.ThisAddIn.Application.Selection.Cells;
                foreach (Word.Cell _cell in _cells)
                {
                    String _text = _cell.Range.Text;
                    String hopefully = "";
                    Converter_Executor(_sender, _text, out hopefully, other_currency, custom_format, multiplier);
                    if (!_text.Equals(hopefully)) _cell.Range.Text = hopefully.Trim();
                }
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, this was quite an unexpected error: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Converter_Executor(string _sender, string _text, out String _target, bool other_currency = false, string custom_format = "", double multiplier = 1)
        {
            try
            {
                String _text_w = _text.Trim();
                String _text_clear = _text_w;
                Double _value = 0;
                _target = _text;
                if (_text_w.Length > 2)
                {
                    _text_w = _text_w.Substring(0, _text_w.Length - 2);
                    _text_clear = _text_w;
                    if (_text_w.Substring(_text_w.Length - 1, 1).Equals("%")) _text_clear = _text_w.Substring(0, _text_w.Length - 1);
                    if (!fcie.IsNumeric(_text_w.Substring(_text_w.Length - 1, 1), System.Globalization.NumberStyles.Any)) _text_clear = _text_w.Substring(0, _text_w.Length - 1);
                    if (fcie.IsNumeric(_text_clear, System.Globalization.NumberStyles.Any))
                    {
                        _value = fcie.GetNumeric(_text_clear, NumberStyles.Any);
                        if (!(_value == double.MinValue))
                        {
                            if (_text_w.Substring(_text_w.Length - 1, 1).Equals("%")) _value = _value / 100;
                            //System.Windows.Forms.MessageBox.Show(_value.ToString());

                            switch (_sender)
                            {
                                case "gal_WooTable_but_String":
                                    // do nothing, muehehehehehehahaha hehe haaaa
                                    _target = _text_clear;
                                    break;
                                case "gal_WooTable_but_Percent":
                                    if (_text_w.Length >= 1 && !_text_w.Substring(_text_w.Length - 1, 1).Equals("%")) _target = (_value * 100) + " %";
                                    break;
                                case "gal_WooTable_but_Float1":
                                    _target = _value.ToString("0.0");
                                    break;
                                case "gal_WooTable_but_Float2":
                                    _target = _value.ToString("0.00");
                                    break;
                                case "gal_WooTable_but_Float3":
                                    _target = _value.ToString("0.000");
                                    break;
                                case "gal_WooTable_but_Float4":
                                    _target = _value.ToString("0.0000");
                                    break;
                                case "gal_WooTable_but_Currency":
                                    _target = _value.ToString("c2");
                                    break;
                                case "CustomFormat":
                                    _target = _value.ToString(custom_format);
                                    break;
                                case "gal_WooTable_but_Other":
                                    Form_NumberFormat newForm = new Form_NumberFormat(this, _value);
                                    newForm.Show();
                                    break;
                                case "toEnglish":
                                    _target = fcie.getTextVariant(_value, other_currency);
                                    break;
                                case "DecSep":
                                    _target = _text_clear.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                                    _target = _text_clear.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                                    break;
                                case "currency_table":
                                    _target = (_value * multiplier).ToString("0.00");
                                    break;
                                default:
                                    System.Windows.Forms.MessageBox.Show("This selection is not handled, yet.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    break;
                            }
                        }
                    }
                    switch (_sender)
                    {
                        case "DecSep":
                            _target = _text_clear.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                            _target = _text_clear.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                            break;
                    }

                }
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, this was quite an unexpected error: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                _target = _text;
            }
        }

        private void gal_WooTable_Format_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void sbut_WooTable_ToEnglish_Click(object sender, RibbonControlEventArgs e)
        {
            Converter("toEnglish");
        }

        private void sbut_WooTable_ToEnglish_Other_Click(object sender, RibbonControlEventArgs e)
        {
            String hopefully = "";
            string _text = Globals.ThisAddIn.Application.Selection.Text + "##";
            Converter_Executor("toEnglish", _text, out hopefully);
            if (!_text.Equals(hopefully)) Globals.ThisAddIn.Application.Selection.Text = hopefully.Trim();
        }

        private void sbut_but_WooTable_ToEnglish_Currency_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                Converter("toEnglish", null, true);
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, cannot convert this value: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void sbut_but_WooTable_Other_ToEnglish_Currency_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                String hopefully = "";
                string _text = Globals.ThisAddIn.Application.Selection.Text + "##";
                Converter_Executor("toEnglish", _text, out hopefully, true);
                if (!_text.Equals(hopefully)) Globals.ThisAddIn.Application.Selection.Text = hopefully.Trim();
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, cannot convert this value: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void sbut_WooTable_Bullets_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void sbut_WooTable_ConvCurrency_Other_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                double ratio = ConvertCurr(fcie.GetNumeric(Globals.ThisAddIn.Application.Selection.Text, NumberStyles.Any), "currency_other");
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, cannot convert this value: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private double ConvertCurr(double _val, string senderLab)
        {
            try
            {
                if (!(_val == double.MinValue))
                {
                    Globals.ThisAddIn.Application.StatusBar = "WooTable .::. Receiving currency conversion rates..";
                    Form_CurrencyConverter newForm = new Form_CurrencyConverter(this, _val);
                    DialogResult dialog_result = newForm.ShowDialog();
                    Globals.ThisAddIn.Application.DisplayStatusBar = false;
                    if (dialog_result == DialogResult.OK)
                    {
                        String hopefully = "";
                        string _text = CurrencyConverter.CurrencyConverter_getInstance.output_val.ToString() + "##";
                        //this should work because CurrencyConverter is singleton
                        if (senderLab == "currency_other") //only selection should be updated
                        {
                            Converter_Executor("gal_WooTable_but_Float2", _text, out hopefully, true);
                            if (!_text.Equals(hopefully)) Globals.ThisAddIn.Application.Selection.Text = hopefully.Trim();
                        }
                        else //currency_table - all selected cells should be updated
                        {
                            Converter(senderLab, null, false, "", CurrencyConverter.CurrencyConverter_getInstance.output_ratio);
                        }
                    }
                    return 0;
                }
                else return 2;
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, cannot convert this value: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return 1;
            }
        }

        private void sbut_WooTable_ConvCurrency_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                double ratio = ConvertCurr(fcie.GetNumeric(Globals.ThisAddIn.Application.Selection.Cells[1].Range.Text.Substring(0, Globals.ThisAddIn.Application.Selection.Cells[1].Range.Text.Length - 2), NumberStyles.Any), "currency_table");
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, cannot convert this value: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void sbut_WooTable_DecSep_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                Converter("DecSep");
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, this was quite an unexpected error, I don't get what you clicked: " + E.Message + ". Sorry for that.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        

        private void sbut_but_WooTable_XLS1_Select_Click(object sender, RibbonControlEventArgs e)
        {
            TablesPane _tabPane;
            Microsoft.Office.Tools.CustomTaskPane _TablesPane;

            _tabPane = new TablesPane(null);
            _TablesPane = Globals.ThisAddIn.CustomTaskPanes.Add(_tabPane, Resources.Labels.ResourceManager.GetString("Panes_Tables"));
            _TablesPane.Visible = true;
            _tabPane.setSysPane(_TablesPane);
        }

        private void sbut_WooTable_Oracle_NewDoc_Click(object sender, RibbonControlEventArgs e)
        {
            DocsPane _docPane = DocsPane.Instance();
        }

        private void sbut_WooTable_Oracle_Icons_Click(object sender, RibbonControlEventArgs e)
        {
            IconsPane _iconPane = IconsPane.Instance();
        }
    }
}
