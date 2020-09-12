using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace WooTable
{
    class CurrencyConverter
    {
        private static CurrencyConverter _inst;
        private string cur_url = Properties.Settings.Default.Curr_Provider;
        private XmlTextReader reader = null;
        public Dictionary<string, double> currencies = null;
        public double output_val = 0;
        public string output_str = "";
        public double output_ratio = 1;
        
        private CurrencyConverter()
        {
            try
            {
                reader = new XmlTextReader(cur_url);
                currencies = new Dictionary<string, double>();

                if (update_ratio() > 0)
                {
                    //System.Windows.Forms.MessageBox.Show("Urgh, could not update currency exchange rates. Please check your internet connection.", "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    Globals.Ribbons.Ribbon1.sbut_WooTable_ConvCurrency_Other.Enabled = false;
                    Globals.Ribbons.Ribbon1.sbut_WooTable_ConvCurrency_Other.ScreenTip = "Could not update currency exchange rates. Please check your internet connection.";
                }
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Urgh, could not perform currency conversion. Error: " + E.Message, "WooTable .::. Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static CurrencyConverter CurrencyConverter_getInstance
        {
            get
            {
                if (_inst == null)
                {
                    _inst = new CurrencyConverter();
                }
                return _inst;
            }
        }

        public double getRatio(string from, string to)
        {
            try
            {
                double ratio1 = currencies[from];
                double ratio2 = currencies[to];
                return ratio2 / ratio1;
            }
            catch //(Exception E)
            {
                return 1;
            }
        }

        private int update_ratio()
        {
            try
            {
                currencies.Add("EUR", 1);
                string key = "";
                double val = 0;
                while(reader.Read())
                {
                    switch(reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            if (reader.Name == "Cube")
                            {
                                while (reader.MoveToNextAttribute()) // Read the attributes.
                                    if(reader.Name == "currency")
                                    {
                                        key = reader.Value;
                                    }
                                if (reader.Name == "rate")
                                {
                                    string _val = reader.Value;
                                    if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ",") _val = _val.Replace(".", ",");
                                    val = fcie.GetNumeric(_val, System.Globalization.NumberStyles.Any);
                                    currencies.Add(key, val);
                                }
                                break;
                            }
                            break;
                    }
                }
                return 0;
            }
            catch// (Exception E)
            {
                return 1;
            }
        }
    }
}
