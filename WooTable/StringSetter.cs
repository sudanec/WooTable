using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

namespace WooTable
{
    public static class StringSetter
    {
        public static void setStringAll(WooTable _mo, string _varianter = "")
        {
            foreach(Microsoft.Office.Tools.Ribbon.RibbonGroup _grp in _mo.tab1.Groups)
            {
                setString(_grp, _varianter);
            }
        }

        public static void setPane(System.Windows.Forms.UserControl _pane)
        {
            try
            {
                foreach (System.Windows.Forms.Control _ctr in _pane.Controls)
                {
                    if (_ctr is System.Windows.Forms.Button)
                    {
                        _ctr.Text = Resources.Labels.ResourceManager.GetString(_ctr.Name);
                    }
                }
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Localization error: " + E.Message + ". I don't know what you did, but it's not funny. Please, contact application administrator.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void setString(Microsoft.Office.Tools.Ribbon.RibbonGroup _group, string _varianter = "")
        {
            try
            {
                int id = 0;
                switch (_group.Id)
                {
                    case "gr_Main":
                        id = 1;
                        break;
                    case "gr_Table":
                        id = 2;
                        break;
                    case "gr_Math":
                        id = 3;
                        break;
                    case "gr_Other":
                        id = 4;
                        break;
                    case "gr_WooTable":
                        id = 5;
                        break;
                    case "gr_Oracle":
                        id = 6;
                        break;
                }
                foreach (Microsoft.Office.Tools.Ribbon.RibbonControl _ctr in _group.Items) setParam(_ctr, _varianter);
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("There is an interface label configuration error: " + E.Message + ". I don't know what you did, but it's funny. Please, contact application administrator.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void setParam(Microsoft.Office.Tools.Ribbon.RibbonControl _ctr, string _opt = "")
        {
            try
            {
                if (_ctr is Microsoft.Office.Tools.Ribbon.RibbonButton)
                {
                    Microsoft.Office.Tools.Ribbon.RibbonButton _tempButton = (Microsoft.Office.Tools.Ribbon.RibbonButton)_ctr;
                    //_tempButton.ScreenTip = Resources.Labels.ResourceManager.GetString("Ribbon_Tips_" + _tempButton.Name);
                    setParamButton(_tempButton, _opt);
                }
                else if (_ctr is Microsoft.Office.Tools.Ribbon.RibbonSplitButton)
                {
                    Microsoft.Office.Tools.Ribbon.RibbonSplitButton _tempButton = (Microsoft.Office.Tools.Ribbon.RibbonSplitButton)_ctr;
                    //_tempButton.ScreenTip = Resources.Labels.ResourceManager.GetString("Ribbon_Tips_" + _tempButton.Name);
                    setParamSButton(_tempButton, _opt);
                }
                else if (_ctr is Microsoft.Office.Tools.Ribbon.RibbonGallery)
                {
                    Microsoft.Office.Tools.Ribbon.RibbonGallery _tempButton = (Microsoft.Office.Tools.Ribbon.RibbonGallery)_ctr;
                    _tempButton.ScreenTip = Resources.Labels.ResourceManager.GetString("Ribbon_Tips_" + _tempButton.Name);
                    setParamGallery(_tempButton, _opt);
                }
                else if (_ctr is Microsoft.Office.Tools.Ribbon.RibbonToggleButton)
                {
                    Microsoft.Office.Tools.Ribbon.RibbonToggleButton _tempButton = (Microsoft.Office.Tools.Ribbon.RibbonToggleButton)_ctr;
                    setParamToggle(_tempButton, _opt);
                }
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("There is an interface label configuration error: " + E.Message + ". I don't know what you did, but it's funny. Please, contact application administrator.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void setParamButton(Microsoft.Office.Tools.Ribbon.RibbonButton _ctr, string _opt = "")
        {
            switch (_opt)
            {
                case "tip":
                    _ctr.ScreenTip = Resources.Labels.ResourceManager.GetString("Ribbon_Tips_" + _ctr.Name);
                    break;
                case "label":
                    _ctr.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_" + _ctr.Name);
                    break;
            }
        }

        public static void setParamToggle(Microsoft.Office.Tools.Ribbon.RibbonToggleButton _ctr, string _opt = "")
        {
            switch (_opt)
            {
                case "tip":
                    _ctr.ScreenTip = Resources.Labels.ResourceManager.GetString("Ribbon_Tips_" + _ctr.Name);
                    break;
                case "label":
                    _ctr.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_" + _ctr.Name);
                    if(_ctr.Checked) _ctr.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_" + _ctr.Name + "1");
                    break;
            }
        }

        public static void setParamSButton(Microsoft.Office.Tools.Ribbon.RibbonSplitButton _ctr, string _opt = "")
        {
            switch (_opt)
            {
                case "tip":
                    _ctr.ScreenTip = Resources.Labels.ResourceManager.GetString("Ribbon_Tips_" + _ctr.Name);
                    foreach(Microsoft.Office.Tools.Ribbon.RibbonButton _btn in _ctr.Items)
                    {
                        _btn.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_" + _ctr.Name + "_" + _btn.Id);
                    }
                    break;
                case "label":
                    _ctr.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_" + _ctr.Name);
                    break;
            }
        }

        public static void setParamGallery(Microsoft.Office.Tools.Ribbon.RibbonGallery _ctr, string _opt = "")
        {
            switch (_opt)
            {
                case "tip":
                    _ctr.ScreenTip = Resources.Labels.ResourceManager.GetString("Ribbon_Tips_" + _ctr.Name);
                    break;
                case "label":
                    _ctr.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_" + _ctr.Name);
                    foreach(Microsoft.Office.Tools.Ribbon.RibbonButton _btn in _ctr.Buttons)
                    {
                        _btn.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Labels_" + _ctr.Name + "_" + _btn.Id);
                    }
                    break;
            }
        }

        public static void setGroupNames(WooTable _mo)
        {
            foreach (Microsoft.Office.Tools.Ribbon.RibbonGroup _grp in _mo.tab1.Groups)
            {
                _grp.Label = Resources.Labels.ResourceManager.GetString("Ribbon_Groups_" + _grp.Name);
            }
        }

        public static bool LocalizeMe(Form _form)
        {
            try
            {
                _form.Text = Resources.Labels.ResourceManager.GetString(_form.Name);
                foreach (Control _ctr in _form.Controls)
                {
                    if (!(_ctr is ComboBox) && !(_ctr is NumericUpDown))
                    {
                        _ctr.Text = Resources.Labels.ResourceManager.GetString(_ctr.Name);
                        if(_ctr.Controls.Count > 0) LocalizeMeCtrl(_ctr);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool LocalizeMeCtrl(Control _ctr)
        {
            try
            {
                foreach (Control _ctrx in _ctr.Controls)
                {
                    if (!(_ctrx is ComboBox) && !(_ctrx is NumericUpDown))
                    {
                        _ctrx.Text = Resources.Labels.ResourceManager.GetString(_ctrx.Name);
                        if (_ctrx.Controls.Count > 0) LocalizeMeCtrl(_ctrx);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool LocalizeGrid(DataGridView _grid)
        {
            try
            {
                foreach(DataGridViewColumn _col in _grid.Columns)
                {
                    _col.Name = Resources.Labels.ResourceManager.GetString(_grid.Name + "_" + _col.Index);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}