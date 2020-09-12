using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace WooTable
{
    class TabPrewFactory
    {
        private static Word.Application ThisApp;
        private static Microsoft.Office.Tools.Ribbon.RibbonControl _obj = null;

        /*public TabPrewFactory(WooTable _mo, int _tableIndex)
        {
            ThisApp = Globals.ThisAddIn.Application;
            ThisApp.ActiveDocument.Tables[_tableIndex].Range.CopyAsPicture();
            System.Drawing.Image _img = Clipboard.GetImage();

            Microsoft.Office.Tools.Ribbon.RibbonButton _lab = _mo.Factory.CreateRibbonButton();
            _lab.ShowLabel = false;
            _lab.Enabled = false;
            _lab.Image = _img;
            _obj = _lab;
        }*/

        public static Microsoft.Office.Tools.Ribbon.RibbonControl CreateTabPrew(WooTable _mo, int _tableIndex)
        {
            ThisApp = Globals.ThisAddIn.Application;
            ThisApp.ActiveDocument.Tables[_tableIndex].Range.CopyAsPicture();
            System.Drawing.Image _img = Clipboard.GetImage();

            Microsoft.Office.Tools.Ribbon.RibbonButton _lab = _mo.Factory.CreateRibbonButton();
            _lab.ShowLabel = false;
            _lab.Enabled = false;
            _lab.Image = _img;
            _obj = _lab;
            return _obj;
        }
    }
}
