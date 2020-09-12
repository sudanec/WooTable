using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Resources;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace WooTable
{
    public static class fcie
    {
        public const uint LVM_FIRST = 0x1000;
        public const uint LVM_GETIMAGELIST = (LVM_FIRST + 2);
        public const uint LVM_SETIMAGELIST = (LVM_FIRST + 3);

        public const uint LVSIL_NORMAL = 0;
        public const uint LVSIL_SMALL = 1;
        public const uint LVSIL_STATE = 2;
        public const uint LVSIL_GROUPHEADER = 3;

        [DllImport("user32")]
        public static extern IntPtr SendMessage(IntPtr hWnd,
                                                uint msg,
                                                uint wParam,
                                                IntPtr lParam);

        [DllImport("comctl32")]
        public static extern bool ImageList_Destroy(IntPtr hImageList);

        public const uint SHGFI_DISPLAYNAME = 0x200;
        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0;
        public const uint SHGFI_SMALLICON = 0x1;
        public const uint SHGFI_SYSICONINDEX = 0x4000;

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260 /* MAX_PATH */)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        [DllImport("shell32")]
        public static extern IntPtr SHGetFileInfo(string pszPath,
                                                  uint dwFileAttributes,
                                                  ref SHFILEINFO psfi,
                                                  uint cbSizeFileInfo,
                                                  uint uFlags);

        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd,
                                                string pszSubAppName,
                                                string pszSubIdList);

        public static Boolean IsNumeric(String input, NumberStyles numberStyle)
        {
            Double temp;
            Boolean result = Double.TryParse(input, numberStyle, CultureInfo.CurrentCulture, out temp);
            return result;
        }

        public static double GetNumeric(String input, NumberStyles numberStyle = System.Globalization.NumberStyles.Any)
        {
            if (IsNumeric(input, numberStyle))
            {
                double returner = double.MinValue;
                Double.TryParse(input, numberStyle, CultureInfo.CurrentCulture, out returner);
                return returner;
            }
            else
            {
                return double.MinValue;
            }
        }

        private static int Partition<T>(this IList<T> list, int start, int end, Random rnd = null) where T : IComparable<T>
        {
            if (rnd != null)
                list.Swap(end, rnd.Next(start, end));

            var pivot = list[end];
            var lastLow = start - 1;
            for (var i = start; i < end; i++)
            {
                if (list[i].CompareTo(pivot) <= 0)
                    list.Swap(i, ++lastLow);
            }
            list.Swap(end, ++lastLow);
            return lastLow;
        }

        public static T NthOrderStatistic<T>(this IList<T> list, int n, Random rnd = null) where T : IComparable<T>
        {
            return NthOrderStatistic(list, n, 0, list.Count - 1, rnd);
        }
        private static T NthOrderStatistic<T>(this IList<T> list, int n, int start, int end, Random rnd) where T : IComparable<T>
        {
            while (true)
            {
                var pivotIndex = list.Partition(start, end, rnd);
                if (pivotIndex == n)
                    return list[pivotIndex];

                if (n < pivotIndex)
                    end = pivotIndex - 1;
                else
                    start = pivotIndex + 1;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            if (i == j)   //This check is not required but Partition function may make many calls so its for perf reason
                return;
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }


        public static T Median<T>(this IList<T> list) where T : IComparable<T>
        {
            if (list.Count > 0)
            {
                return list.NthOrderStatistic((list.Count - 1) / 2);
            }
            else
            {
                return default(T);
            }
        }

        public static double Median<T>(this IEnumerable<T> sequence, Func<T, double> getValue)
        {
            var list = sequence.Select(getValue).ToList();
            var mid = (list.Count - 1) / 2;
            return list.NthOrderStatistic(mid);
        }

        public static string getTextVariant(double _input, bool isCurrency = false)
        {
            return NumberToEnglish.changeToWords(_input, isCurrency);
        }

        public static int number_getTens(double _input)
        {
            int returner = 0;
            double _number = _input;

            if (_number < 1) returner = 0;
            while (_number / 10 >= 1)
            {
                _number = _number / 10;
                returner++;
            }
            returner++;
            if (_input.ToString().Length <= returner) return 0;
            return returner;
        }

        public static List<string> Localizations(string _locresource="")
        {
            ResourceManager rm = new ResourceManager(typeof(Resources.Labels));
            List<string> resulter = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo culture in cultures)
            {
                try
                {
                    if (culture.Equals(CultureInfo.InvariantCulture)) continue;

                    ResourceSet rs = rm.GetResourceSet(culture, true, false);
                    // or ResourceSet rs = rm.GetResourceSet(new CultureInfo(culture.TwoLetterISOLanguageName), true, false);
                    if(rs != null) resulter.Add(culture.NativeName + " (" + culture.Name + ")");
                }
                catch (CultureNotFoundException EE)
                {
                    
                }
            }
            return resulter;
        }

        public static Boolean isInternetConnected()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "sudanec.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}