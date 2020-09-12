using System;
using System.Collections.Generic;
using Microsoft.Office.Tools.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Threading;
using System.Globalization;
//using System.Runtime.InteropServices;

namespace WooTable
{
    class Resident
    {
        private static Resident _inst;
        public Word.Application ThisApp = null;
        public Word.Table ThisTable = null;
        private WooTable MasterObject = null;
        public double sum = 0;
        public double average = 0;
        public double count = 0;
        public double min = 0;
        public double max = 0;
        public double median = 0;
        //public HashSet<Word.Range> TotalRange = new HashSet<Word.Range>();


        public static Resident Resident_getInstance(WooTable _MasterObject)
        {
            //get
            {
                if(_inst == null)
                {
                    _inst = new Resident(_MasterObject);
                }
                return _inst;
            }
        }

        private Resident(WooTable _MasterObject)
        {
            try
            {
                ThisApp = Globals.ThisAddIn.Application;
                setMasterObject(_MasterObject);
                
                try
                {
                    if (Properties.Settings.Default.Culture == "")
                    {
                        Properties.Settings.Default.Culture = Thread.CurrentThread.CurrentUICulture.Name;
                        Properties.Settings.Default.CultureString = Thread.CurrentThread.CurrentUICulture.NativeName;
                    }
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Culture);
                }
                catch
                {
                    Properties.Settings.Default.Culture = Thread.CurrentThread.CurrentUICulture.Name;
                    Properties.Settings.Default.CultureString = Thread.CurrentThread.CurrentUICulture.NativeName;
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Thread.CurrentThread.CurrentUICulture.Name);
                }

                StringSetter.setStringAll(MasterObject, "tip");
                StringSetter.setStringAll(MasterObject, "label");
                StringSetter.setGroupNames(MasterObject); //these are the ribbon groups labels

                // start up
                Startup();
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Could not initialize the resident service: " + E.Message + ". Am stopping it.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                _inst = null;
            }
        }

        public void setMasterObject(WooTable _MasterObject)
        {
            MasterObject = _MasterObject;
        }

        private void Startup()
        {
            DocumentOpen();
            NewDocument();
        }

        private void NewDocument()
        {
            ((Word.ApplicationEvents4_Event)ThisApp).NewDocument += new Word.ApplicationEvents4_NewDocumentEventHandler(ThisDocument_NewDocument);
        }

        private void DocumentOpen()
        {
            ThisApp.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler(ThisDocument_DocumentOpen);
        }

        public void RefreshAll()
        {
            DocumentSelectionChange();
            StringSetter.setStringAll(MasterObject, "tip");
            StringSetter.setStringAll(MasterObject, "label");
            StringSetter.setGroupNames(MasterObject); //these are the ribbon groups labels
        }

        private void ThisDocument_NewDocument(Word.Document document)
        {
            DocumentSelectionChange();
        }

        private void ThisDocument_DocumentOpen(Word.Document document)
        {
            DocumentSelectionChange();
        }

        private void DocumentSelectionChange()
        {
            Document vstoDoc = Globals.Factory.GetVstoObject(ThisApp.ActiveDocument);
            try
            {
                vstoDoc.SelectionChange -= ThisDocument_SelectionChange;
            }
            catch { }
            vstoDoc.SelectionChange += new Microsoft.Office.Tools.Word.SelectionEventHandler(ThisDocument_SelectionChange);
        }

        //advanced hooking to get keypress
        private void MagicHooks()
        {
            //maybe in my next life
            //http://stackoverflow.com/questions/8120199/how-to-get-the-keypress-event-from-a-word-2010-addin-developed-in-c
        }

        private void ThisDocument_SelectionChange(object sender, Microsoft.Office.Tools.Word.SelectionEventArgs e)
        {
            selChanged(sender, e);
        }

        private void selChanged(object sender, Microsoft.Office.Tools.Word.SelectionEventArgs e)
        {
            try
            {
                Word.Document doc = ThisApp.ActiveDocument;
                Word.Selection sel = ThisApp.Selection;

                if (sel != null && sel.Range != null)
                {
                    if ((sel.get_Information(Word.WdInformation.wdWithInTable)) && (sel.Tables.Count > 0))
                    {
                        ThisTable = sel.Tables[1];
                        state_in_table();
                        UpdateStatusBar(sel);

                    }
                    else
                    {
                        ThisApp.DisplayStatusBar = false;

                        if (fcie.IsNumeric(sel.Text, System.Globalization.NumberStyles.Any))
                        {
                            state_in_text();
                        }
                        else
                        {
                            state_in_shit();
                        }
                    }
                }
                else
                {
                    state_in_shit();
                }
            }
            catch
            {
                ThisApp.DisplayStatusBar = false;
                state_in_shit();
            }
        }

        private void state_in_shit()
        {
            foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Math.Items)
            {
                _ctr.Enabled = false;
            }
            foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Table.Items)
            {
                _ctr.Enabled = false;
            }
            foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Other.Items)
            {
                _ctr.Enabled = false;
            }
        }

        private bool isAvailable_table()
        {
            try
            {
                return isAvailable(Globals.ThisAddIn.Application.Selection.Cells[1].Range.Text);
            }
            catch
            {
                return false;
            }
        }

        private bool isAvailable(string _text_w = "")
        {
            try
            {
                if (_text_w.Length < 1) _text_w = Globals.ThisAddIn.Application.Selection.Text + "##";

                if (_text_w.Length > 2)
                {
                    _text_w = _text_w.Substring(0, _text_w.Length - 2);
                    string _text_clear = _text_w;
                    if (_text_w.Substring(_text_w.Length - 1, 1).Equals("%")) _text_clear = _text_w.Substring(0, _text_w.Length - 1);
                    if (!fcie.IsNumeric(_text_w.Substring(_text_w.Length - 1, 1), System.Globalization.NumberStyles.Any)) _text_clear = _text_w.Substring(0, _text_w.Length - 1);
                    if (fcie.IsNumeric(_text_clear, System.Globalization.NumberStyles.Any))
                    {
                        if (!(fcie.GetNumeric(_text_clear, NumberStyles.Any) == double.MinValue))
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            catch
            {
                return false;
            }       
        }

        private void state_in_table()
        {
            try
            {
                if (isAvailable_table())
                {
                    foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Math.Items)
                    {
                        if (_ctr.Name.Equals("but_WooTable_Median"))
                        {
                            _ctr.Enabled = Properties.Settings.Default.Show_Median;
                        }
                        else
                        {
                            _ctr.Enabled = true;
                        }
                    }
                    foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Table.Items)
                    {
                        _ctr.Enabled = true;
                    }
                    foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Other.Items)
                    {
                        _ctr.Enabled = false;
                    }
                }
                else
                {
                    state_in_shit();

                    //even though there is no numbers, we can still export the table to excel
                    MasterObject.but_WooTable_xls1.Enabled = true;
                    MasterObject.but_WooTable_xls2.Enabled = true;
                    MasterObject.tog_WooTable_XLS.Enabled = true;
                }
            }
            catch
            {
                state_in_shit();
            }
        }

        private void state_in_text()
        {
            try
            {
                if (isAvailable())
                {
                    foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Math.Items)
                    {
                        _ctr.Enabled = false;
                    }
                    foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Table.Items)
                    {
                        _ctr.Enabled = false;
                    }
                    foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in MasterObject.gr_Other.Items)
                    {
                        _ctr.Enabled = true;
                    }
                }
                else state_in_shit();
            }
            catch
            {
                state_in_shit();
            }
        }

        /*private void updateTableList()
        {
            Microsoft.Office.Tools.Ribbon.RibbonSplitButton _but = MasterObject.sbut_WooTable_XLS1;
            _but.Items.Clear();
            foreach(Word.Table _tab in ThisApp.ActiveDocument.Tables)
            {
                _but.Items.Add(TabPrewFactory.CreateTabPrew(MasterObject, 1));
            }
        }*/

        private void UpdateStatusBar(Word.Selection _sel)
        {
            if (Properties.Settings.Default.StatusBarUpdate)
            {
                string content = "";
                string message = "";
                List<double> lister = null;
                try
                {
                    if (Properties.Settings.Default.Show_Median) lister = new List<double>();

                    count = 0;
                    max = double.MinValue;
                    min = double.MaxValue;
                    sum = 0;

                    foreach (Word.Cell i in _sel.Cells)
                    {
                        content = i.Range.Text.Substring(0, i.Range.Text.Length - 1);
                        if (fcie.IsNumeric(content, System.Globalization.NumberStyles.Any))
                        {
                            //double temp = Convert.ToDouble(content);
                            double temp = fcie.GetNumeric(content);
                            sum = sum + temp;
                            /*if (count == 0) min = temp; else*/
                            min = Math.Min(min, temp);
                            /*if (count == 0) max = temp; else*/
                            max = Math.Max(max, temp);
                            if (Properties.Settings.Default.Show_Median) lister.Add(temp);
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        average = sum / count;
                        if (Properties.Settings.Default.Show_Median) median = fcie.Median(lister);

                        message = "WooTable     .::.     Count: " + count + "  Sum: " + sum + "  Avg: " + average;
                        if (Properties.Settings.Default.Show_Min) message = message + "  Min: " + min;
                        if (Properties.Settings.Default.Show_Max) message = message + "  Max: " + max;
                        if (Properties.Settings.Default.Show_Median) message = message + "  Median: " + median;

                        ThisApp.StatusBar = message;
                    }
                }
                finally
                {

                }
            }
        }
    }
}
