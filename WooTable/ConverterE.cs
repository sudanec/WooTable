using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools.Excel;
using System.Reflection;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace WooTable
{
    class ConverterE
    {
        public ConverterE()
        {

        }

        public static bool AllTablesToExcel(Word.Document _doc, string _rngonly = "table", Excel.Application _excel = null, bool force = false)
        {
            bool resulter = true;
            Excel.Worksheet _sht = null;
            Excel.Workbook _book = null;

            try
            {

                if (_excel == null)
                {
                    _excel = new Excel.Application();
                    _excel.Visible = true;
                    _book = _excel.Workbooks.Add();
                }

                foreach (Word.Table _tab in _doc.Tables)
                {
                    _sht = _book.Sheets.Add(Type.Missing, _book.Sheets[_book.Sheets.Count], Type.Missing, Type.Missing);
                    bool temp = TableToExcel(_tab.Range, _rngonly, _sht);
                    resulter = resulter && temp;
                    if (!(force) && !(resulter))
                    {
                        return resulter;
                    }
                }
                if(_book.Sheets.Count > 1) _book.Sheets[1].Delete();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("An error occured: " + e.Message, "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool TableToExcel(Word.Range _ran, string RangeOnly = "table", Excel.Worksheet _sht = null)
        {
            Excel.Application _excel = null;
            Excel.Workbook _book = null;
            try
            {
                if (_sht == null)
                {
                    _excel = new Excel.Application();
                    _excel.Visible = true;
                    _book = _excel.Workbooks.Add();
                    if (_book.Sheets.Count > 0) _sht = _book.Sheets[_book.Sheets.Count]; else _sht = _book.Sheets.Add(Type.Missing, _book.Sheets[_book.Sheets.Count], Type.Missing, Type.Missing);
                }

                /*foreach (Word.Cell _cell in _ran.Cells)
                {

                }*/
                if (Properties.Settings.Default.XLSNewLine && RangeOnly != "range")
                {
                    long row_count = _ran.Rows.Count;
                    long col_count = _ran.Columns.Count;
                    long i = 1; //row
                    long j = 1; //col
                    foreach(Word.Cell _cel in _ran.Cells)
                    {
                        String _val = String.Concat(_cel.Range.Text.Substring(0, _cel.Range.Text.Length - 1));
                        //_val.Replace(Environment.NewLine.ToCharArray()[0], '\v');
                        string _temp = (char)10 + "";
                        _val = _val.Replace(Environment.NewLine.ToCharArray()[0].ToString(), _temp);
                        _sht.Cells[i, j] = _val.Substring(0, _val.Length - 1);
                        if (j == col_count) { j = 1; i++; }
                        else j++;
                    }
                }
                else
                {
                    _ran.Copy();
                    _sht.Paste();
                }
                _sht.get_Range("A1", "A1").Select();
            }
            catch
            {
                return false;
            }
            finally
            {
                if (_book != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(_book);
                if (_excel != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(_excel);
                GC.Collect();
            }
            return true;
        }
    }
}
