namespace WooTable
{
    partial class WooTable : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WooTable()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.gr_Main = this.Factory.CreateRibbonGroup();
            this.but_WooTable_NewTable = this.Factory.CreateRibbonButton();
            this.sbut_WooTable_XLS1 = this.Factory.CreateRibbonSplitButton();
            this.sbut_but_WooTable_XLS1_Select = this.Factory.CreateRibbonButton();
            this.gr_Table = this.Factory.CreateRibbonGroup();
            this.sbut_WooTable_Bullets = this.Factory.CreateRibbonSplitButton();
            this.sbut_WooTable_Numbering = this.Factory.CreateRibbonSplitButton();
            this.sbut_WooTable_ToEnglish = this.Factory.CreateRibbonSplitButton();
            this.sbut_but_WooTable_ToEnglish_Currency = this.Factory.CreateRibbonButton();
            this.but_WooTable_xls2 = this.Factory.CreateRibbonButton();
            this.but_WooTable_xls1 = this.Factory.CreateRibbonButton();
            this.tog_WooTable_XLS = this.Factory.CreateRibbonToggleButton();
            this.gal_WooTable_Format = this.Factory.CreateRibbonGallery();
            this.gal_WooTable_but_String = this.Factory.CreateRibbonButton();
            this.gal_WooTable_but_Percent = this.Factory.CreateRibbonButton();
            this.gal_WooTable_but_Float1 = this.Factory.CreateRibbonButton();
            this.gal_WooTable_but_Float2 = this.Factory.CreateRibbonButton();
            this.gal_WooTable_but_Float3 = this.Factory.CreateRibbonButton();
            this.gal_WooTable_but_Float4 = this.Factory.CreateRibbonButton();
            this.gal_WooTable_but_Currency = this.Factory.CreateRibbonButton();
            this.gal_WooTable_but_Other = this.Factory.CreateRibbonButton();
            this.sbut_WooTable_ConvCurrency = this.Factory.CreateRibbonButton();
            this.sbut_WooTable_DecSep = this.Factory.CreateRibbonButton();
            this.gr_Math = this.Factory.CreateRibbonGroup();
            this.but_WooTable_Min = this.Factory.CreateRibbonButton();
            this.but_WooTable_Max = this.Factory.CreateRibbonButton();
            this.but_WooTable_SumCreate = this.Factory.CreateRibbonButton();
            this.but_WooTable_Avg = this.Factory.CreateRibbonButton();
            this.but_WooTable_Sum = this.Factory.CreateRibbonButton();
            this.but_WooTable_Median = this.Factory.CreateRibbonButton();
            this.gr_Other = this.Factory.CreateRibbonGroup();
            this.sbut_WooTable_ToEnglish_Other = this.Factory.CreateRibbonSplitButton();
            this.sbut_but_WooTable_Other_ToEnglish_Currency = this.Factory.CreateRibbonButton();
            this.sbut_WooTable_ConvCurrency_Other = this.Factory.CreateRibbonButton();
            this.gr_Oracle = this.Factory.CreateRibbonGroup();
            this.sbut_WooTable_Oracle_NewDoc = this.Factory.CreateRibbonButton();
            this.sbut_WooTable_Oracle_Format = this.Factory.CreateRibbonSplitButton();
            this.gr_WooTable = this.Factory.CreateRibbonGroup();
            this.but_WooTable_Settings = this.Factory.CreateRibbonButton();
            this.but_WooTable_Donate = this.Factory.CreateRibbonButton();
            this.but_WooTable_Home = this.Factory.CreateRibbonButton();
            this.sbut_WooTable_Oracle_Icons = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.gr_Main.SuspendLayout();
            this.gr_Table.SuspendLayout();
            this.gr_Math.SuspendLayout();
            this.gr_Other.SuspendLayout();
            this.gr_Oracle.SuspendLayout();
            this.gr_WooTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.gr_Main);
            this.tab1.Groups.Add(this.gr_Table);
            this.tab1.Groups.Add(this.gr_Math);
            this.tab1.Groups.Add(this.gr_Other);
            this.tab1.Groups.Add(this.gr_Oracle);
            this.tab1.Groups.Add(this.gr_WooTable);
            this.tab1.Label = "WooTable";
            this.tab1.Name = "tab1";
            // 
            // gr_Main
            // 
            this.gr_Main.Items.Add(this.but_WooTable_NewTable);
            this.gr_Main.Items.Add(this.sbut_WooTable_XLS1);
            this.gr_Main.Label = "Main";
            this.gr_Main.Name = "gr_Main";
            // 
            // but_WooTable_NewTable
            // 
            this.but_WooTable_NewTable.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.but_WooTable_NewTable.Label = "Create new";
            this.but_WooTable_NewTable.Name = "but_WooTable_NewTable";
            this.but_WooTable_NewTable.OfficeImageId = "AccessFormDatasheet";
            this.but_WooTable_NewTable.ScreenTip = "Create a new structure table (with no borders)";
            this.but_WooTable_NewTable.ShowImage = true;
            this.but_WooTable_NewTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_NewTable_Click);
            // 
            // sbut_WooTable_XLS1
            // 
            this.sbut_WooTable_XLS1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sbut_WooTable_XLS1.Items.Add(this.sbut_but_WooTable_XLS1_Select);
            this.sbut_WooTable_XLS1.Label = "Convert to Excel";
            this.sbut_WooTable_XLS1.Name = "sbut_WooTable_XLS1";
            this.sbut_WooTable_XLS1.OfficeImageId = "ExportExcel";
            this.sbut_WooTable_XLS1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_XLS1_Click);
            // 
            // sbut_but_WooTable_XLS1_Select
            // 
            this.sbut_but_WooTable_XLS1_Select.Label = "Select";
            this.sbut_but_WooTable_XLS1_Select.Name = "sbut_but_WooTable_XLS1_Select";
            this.sbut_but_WooTable_XLS1_Select.OfficeImageId = "PropertySheet";
            this.sbut_but_WooTable_XLS1_Select.ShowImage = true;
            this.sbut_but_WooTable_XLS1_Select.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_but_WooTable_XLS1_Select_Click);
            // 
            // gr_Table
            // 
            this.gr_Table.Items.Add(this.sbut_WooTable_Bullets);
            this.gr_Table.Items.Add(this.sbut_WooTable_Numbering);
            this.gr_Table.Items.Add(this.sbut_WooTable_ToEnglish);
            this.gr_Table.Items.Add(this.but_WooTable_xls2);
            this.gr_Table.Items.Add(this.but_WooTable_xls1);
            this.gr_Table.Items.Add(this.tog_WooTable_XLS);
            this.gr_Table.Items.Add(this.gal_WooTable_Format);
            this.gr_Table.Items.Add(this.sbut_WooTable_ConvCurrency);
            this.gr_Table.Items.Add(this.sbut_WooTable_DecSep);
            this.gr_Table.Label = "Table";
            this.gr_Table.Name = "gr_Table";
            // 
            // sbut_WooTable_Bullets
            // 
            this.sbut_WooTable_Bullets.Label = "Bullets";
            this.sbut_WooTable_Bullets.Name = "sbut_WooTable_Bullets";
            this.sbut_WooTable_Bullets.OfficeImageId = "Bullets";
            this.sbut_WooTable_Bullets.ScreenTip = "Bullets";
            this.sbut_WooTable_Bullets.ShowLabel = false;
            this.sbut_WooTable_Bullets.Visible = false;
            this.sbut_WooTable_Bullets.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_Bullets_Click);
            // 
            // sbut_WooTable_Numbering
            // 
            this.sbut_WooTable_Numbering.Label = "splitButton1";
            this.sbut_WooTable_Numbering.Name = "sbut_WooTable_Numbering";
            this.sbut_WooTable_Numbering.OfficeImageId = "Numbering";
            this.sbut_WooTable_Numbering.ScreenTip = "Numbering";
            this.sbut_WooTable_Numbering.ShowLabel = false;
            this.sbut_WooTable_Numbering.Visible = false;
            // 
            // sbut_WooTable_ToEnglish
            // 
            this.sbut_WooTable_ToEnglish.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sbut_WooTable_ToEnglish.Enabled = false;
            this.sbut_WooTable_ToEnglish.Items.Add(this.sbut_but_WooTable_ToEnglish_Currency);
            this.sbut_WooTable_ToEnglish.Label = "To English";
            this.sbut_WooTable_ToEnglish.Name = "sbut_WooTable_ToEnglish";
            this.sbut_WooTable_ToEnglish.OfficeImageId = "FormControlLabel";
            this.sbut_WooTable_ToEnglish.Position = this.Factory.RibbonPosition.AfterOfficeId("gal_WooTable_Format");
            this.sbut_WooTable_ToEnglish.ScreenTip = "Convert number to written english";
            this.sbut_WooTable_ToEnglish.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_ToEnglish_Click);
            // 
            // sbut_but_WooTable_ToEnglish_Currency
            // 
            this.sbut_but_WooTable_ToEnglish_Currency.Label = "As currency";
            this.sbut_but_WooTable_ToEnglish_Currency.Name = "sbut_but_WooTable_ToEnglish_Currency";
            this.sbut_but_WooTable_ToEnglish_Currency.OfficeImageId = "AccountingFormat";
            this.sbut_but_WooTable_ToEnglish_Currency.ScreenTip = "Convert amount to written english as currency";
            this.sbut_but_WooTable_ToEnglish_Currency.ShowImage = true;
            this.sbut_but_WooTable_ToEnglish_Currency.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_but_WooTable_ToEnglish_Currency_Click);
            // 
            // but_WooTable_xls2
            // 
            this.but_WooTable_xls2.Enabled = false;
            this.but_WooTable_xls2.Label = "ConvertTableToExcel";
            this.but_WooTable_xls2.Name = "but_WooTable_xls2";
            this.but_WooTable_xls2.OfficeImageId = "TableExcelSpreadsheetInsert";
            this.but_WooTable_xls2.Position = this.Factory.RibbonPosition.BeforeOfficeId("but_WooTable_xls1");
            this.but_WooTable_xls2.ScreenTip = "Convert selected table to a new MS Excel document";
            this.but_WooTable_xls2.ShowImage = true;
            this.but_WooTable_xls2.ShowLabel = false;
            this.but_WooTable_xls2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_xls2_Click);
            // 
            // but_WooTable_xls1
            // 
            this.but_WooTable_xls1.Enabled = false;
            this.but_WooTable_xls1.Label = "ConvertRangeToExcel";
            this.but_WooTable_xls1.Name = "but_WooTable_xls1";
            this.but_WooTable_xls1.OfficeImageId = "MicrosoftExcel";
            this.but_WooTable_xls1.Position = this.Factory.RibbonPosition.AfterOfficeId("but_WooTable_xls2");
            this.but_WooTable_xls1.ScreenTip = "Convert selected range to a new MS Excel document";
            this.but_WooTable_xls1.ShowImage = true;
            this.but_WooTable_xls1.ShowLabel = false;
            this.but_WooTable_xls1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_xls1_Click);
            // 
            // tog_WooTable_XLS
            // 
            this.tog_WooTable_XLS.Enabled = false;
            this.tog_WooTable_XLS.Label = "to new XLS";
            this.tog_WooTable_XLS.Name = "tog_WooTable_XLS";
            this.tog_WooTable_XLS.Position = this.Factory.RibbonPosition.AfterOfficeId("but_WooTable_xls1");
            this.tog_WooTable_XLS.ScreenTip = "Sets the target for the Excel table - either creates a new document, or copies to" +
    " the current opened document";
            this.tog_WooTable_XLS.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tog_WooTable_XLS_Click);
            // 
            // gal_WooTable_Format
            // 
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_String);
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_Percent);
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_Float1);
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_Float2);
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_Float3);
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_Float4);
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_Currency);
            this.gal_WooTable_Format.Buttons.Add(this.gal_WooTable_but_Other);
            this.gal_WooTable_Format.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.gal_WooTable_Format.Enabled = false;
            this.gal_WooTable_Format.Label = "Cell format";
            this.gal_WooTable_Format.Name = "gal_WooTable_Format";
            this.gal_WooTable_Format.OfficeImageId = "BevelTextGallery";
            this.gal_WooTable_Format.Position = this.Factory.RibbonPosition.AfterOfficeId("tog_WooTable_XLS");
            this.gal_WooTable_Format.ScreenTip = "Set the number format of selected cells";
            this.gal_WooTable_Format.ShowImage = true;
            this.gal_WooTable_Format.ShowItemSelection = true;
            this.gal_WooTable_Format.ButtonClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gal_WooTable_Format_ButtonClick);
            this.gal_WooTable_Format.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gal_WooTable_Format_Click);
            // 
            // gal_WooTable_but_String
            // 
            this.gal_WooTable_but_String.Label = "String";
            this.gal_WooTable_but_String.Name = "gal_WooTable_but_String";
            this.gal_WooTable_but_String.OfficeImageId = "FormatCellsFontDialog";
            this.gal_WooTable_but_String.ScreenTip = "Convert value to a string";
            this.gal_WooTable_but_String.ShowImage = true;
            // 
            // gal_WooTable_but_Percent
            // 
            this.gal_WooTable_but_Percent.Label = "Percentage";
            this.gal_WooTable_but_Percent.Name = "gal_WooTable_but_Percent";
            this.gal_WooTable_but_Percent.OfficeImageId = "FormatCellsNumberDialog";
            this.gal_WooTable_but_Percent.ScreenTip = "Convert value to percents";
            this.gal_WooTable_but_Percent.ShowImage = true;
            // 
            // gal_WooTable_but_Float1
            // 
            this.gal_WooTable_but_Float1.Label = "Float 1";
            this.gal_WooTable_but_Float1.Name = "gal_WooTable_but_Float1";
            this.gal_WooTable_but_Float1.OfficeImageId = "_1";
            this.gal_WooTable_but_Float1.ScreenTip = "Convert value to number with 1 floating point";
            this.gal_WooTable_but_Float1.ShowImage = true;
            // 
            // gal_WooTable_but_Float2
            // 
            this.gal_WooTable_but_Float2.Label = "Float 2";
            this.gal_WooTable_but_Float2.Name = "gal_WooTable_but_Float2";
            this.gal_WooTable_but_Float2.OfficeImageId = "_2";
            this.gal_WooTable_but_Float2.ScreenTip = "Convert value to number with 2 floating points";
            this.gal_WooTable_but_Float2.ShowImage = true;
            // 
            // gal_WooTable_but_Float3
            // 
            this.gal_WooTable_but_Float3.Label = "Float 3";
            this.gal_WooTable_but_Float3.Name = "gal_WooTable_but_Float3";
            this.gal_WooTable_but_Float3.OfficeImageId = "_3";
            this.gal_WooTable_but_Float3.ScreenTip = "Convert value to number with 3 floating points";
            this.gal_WooTable_but_Float3.ShowImage = true;
            // 
            // gal_WooTable_but_Float4
            // 
            this.gal_WooTable_but_Float4.Label = "Float 4";
            this.gal_WooTable_but_Float4.Name = "gal_WooTable_but_Float4";
            this.gal_WooTable_but_Float4.OfficeImageId = "_4";
            this.gal_WooTable_but_Float4.ScreenTip = "Convert value to number with 4 floating points";
            this.gal_WooTable_but_Float4.ShowImage = true;
            // 
            // gal_WooTable_but_Currency
            // 
            this.gal_WooTable_but_Currency.Label = "Currency";
            this.gal_WooTable_but_Currency.Name = "gal_WooTable_but_Currency";
            this.gal_WooTable_but_Currency.OfficeImageId = "DollarSign";
            this.gal_WooTable_but_Currency.ScreenTip = "Convert value to local currency";
            this.gal_WooTable_but_Currency.ShowImage = true;
            // 
            // gal_WooTable_but_Other
            // 
            this.gal_WooTable_but_Other.Label = "Other";
            this.gal_WooTable_but_Other.Name = "gal_WooTable_but_Other";
            this.gal_WooTable_but_Other.OfficeImageId = "AccessReportMore";
            this.gal_WooTable_but_Other.ScreenTip = "Opens a dialog to set conversion type";
            this.gal_WooTable_but_Other.ShowImage = true;
            // 
            // sbut_WooTable_ConvCurrency
            // 
            this.sbut_WooTable_ConvCurrency.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sbut_WooTable_ConvCurrency.Enabled = false;
            this.sbut_WooTable_ConvCurrency.Label = "Convert currency";
            this.sbut_WooTable_ConvCurrency.Name = "sbut_WooTable_ConvCurrency";
            this.sbut_WooTable_ConvCurrency.OfficeImageId = "FileStartWorkflow";
            this.sbut_WooTable_ConvCurrency.ShowImage = true;
            this.sbut_WooTable_ConvCurrency.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_ConvCurrency_Click);
            // 
            // sbut_WooTable_DecSep
            // 
            this.sbut_WooTable_DecSep.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sbut_WooTable_DecSep.Enabled = false;
            this.sbut_WooTable_DecSep.Label = "Decimal separator";
            this.sbut_WooTable_DecSep.Name = "sbut_WooTable_DecSep";
            this.sbut_WooTable_DecSep.OfficeImageId = "FormattingUnique";
            this.sbut_WooTable_DecSep.ScreenTip = "Replace all . and , in numbers with the current culture decimal separator";
            this.sbut_WooTable_DecSep.ShowImage = true;
            this.sbut_WooTable_DecSep.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_DecSep_Click);
            // 
            // gr_Math
            // 
            this.gr_Math.Items.Add(this.but_WooTable_Min);
            this.gr_Math.Items.Add(this.but_WooTable_Max);
            this.gr_Math.Items.Add(this.but_WooTable_SumCreate);
            this.gr_Math.Items.Add(this.but_WooTable_Avg);
            this.gr_Math.Items.Add(this.but_WooTable_Sum);
            this.gr_Math.Items.Add(this.but_WooTable_Median);
            this.gr_Math.Label = "Math";
            this.gr_Math.Name = "gr_Math";
            // 
            // but_WooTable_Min
            // 
            this.but_WooTable_Min.Enabled = false;
            this.but_WooTable_Min.Label = "MIN";
            this.but_WooTable_Min.Name = "but_WooTable_Min";
            this.but_WooTable_Min.ScreenTip = "Copy MIN to clipboard";
            this.but_WooTable_Min.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Min_Click);
            // 
            // but_WooTable_Max
            // 
            this.but_WooTable_Max.Enabled = false;
            this.but_WooTable_Max.Label = "MAX";
            this.but_WooTable_Max.Name = "but_WooTable_Max";
            this.but_WooTable_Max.Position = this.Factory.RibbonPosition.AfterOfficeId("but_WooTable_Min");
            this.but_WooTable_Max.ScreenTip = "Copy MAX to clipboard";
            this.but_WooTable_Max.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Max_Click);
            // 
            // but_WooTable_SumCreate
            // 
            this.but_WooTable_SumCreate.Enabled = false;
            this.but_WooTable_SumCreate.Label = "Sum";
            this.but_WooTable_SumCreate.Name = "but_WooTable_SumCreate";
            this.but_WooTable_SumCreate.OfficeImageId = "AutoSum";
            this.but_WooTable_SumCreate.ScreenTip = "Sum";
            this.but_WooTable_SumCreate.ShowImage = true;
            this.but_WooTable_SumCreate.ShowLabel = false;
            this.but_WooTable_SumCreate.Visible = false;
            this.but_WooTable_SumCreate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Sum_Click);
            // 
            // but_WooTable_Avg
            // 
            this.but_WooTable_Avg.Enabled = false;
            this.but_WooTable_Avg.Label = "AVG";
            this.but_WooTable_Avg.Name = "but_WooTable_Avg";
            this.but_WooTable_Avg.Position = this.Factory.RibbonPosition.AfterOfficeId("but_WooTable_Max");
            this.but_WooTable_Avg.ScreenTip = "Copy AVERAGE to clipboard";
            this.but_WooTable_Avg.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Avg_Click);
            // 
            // but_WooTable_Sum
            // 
            this.but_WooTable_Sum.Enabled = false;
            this.but_WooTable_Sum.Label = "SUM";
            this.but_WooTable_Sum.Name = "but_WooTable_Sum";
            this.but_WooTable_Sum.Position = this.Factory.RibbonPosition.AfterOfficeId("but_WooTable_Avg");
            this.but_WooTable_Sum.ScreenTip = "Copy SUM to clipboard";
            this.but_WooTable_Sum.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Sum_Click_1);
            // 
            // but_WooTable_Median
            // 
            this.but_WooTable_Median.Enabled = false;
            this.but_WooTable_Median.Label = "MED";
            this.but_WooTable_Median.Name = "but_WooTable_Median";
            this.but_WooTable_Median.Position = this.Factory.RibbonPosition.AfterOfficeId("but_WooTable_Sum");
            this.but_WooTable_Median.ScreenTip = "Copy MEDIAN to clipboard";
            this.but_WooTable_Median.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Median_Click);
            // 
            // gr_Other
            // 
            this.gr_Other.Items.Add(this.sbut_WooTable_ToEnglish_Other);
            this.gr_Other.Items.Add(this.sbut_WooTable_ConvCurrency_Other);
            this.gr_Other.Label = "Extras";
            this.gr_Other.Name = "gr_Other";
            // 
            // sbut_WooTable_ToEnglish_Other
            // 
            this.sbut_WooTable_ToEnglish_Other.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sbut_WooTable_ToEnglish_Other.Enabled = false;
            this.sbut_WooTable_ToEnglish_Other.Items.Add(this.sbut_but_WooTable_Other_ToEnglish_Currency);
            this.sbut_WooTable_ToEnglish_Other.Label = "To English";
            this.sbut_WooTable_ToEnglish_Other.Name = "sbut_WooTable_ToEnglish_Other";
            this.sbut_WooTable_ToEnglish_Other.OfficeImageId = "FormControlLabel";
            this.sbut_WooTable_ToEnglish_Other.Position = this.Factory.RibbonPosition.AfterOfficeId("gal_WooTable_Format");
            this.sbut_WooTable_ToEnglish_Other.ScreenTip = "Convert number to written english";
            this.sbut_WooTable_ToEnglish_Other.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_ToEnglish_Other_Click);
            // 
            // sbut_but_WooTable_Other_ToEnglish_Currency
            // 
            this.sbut_but_WooTable_Other_ToEnglish_Currency.Label = "As currency";
            this.sbut_but_WooTable_Other_ToEnglish_Currency.Name = "sbut_but_WooTable_Other_ToEnglish_Currency";
            this.sbut_but_WooTable_Other_ToEnglish_Currency.OfficeImageId = "AccountingFormat";
            this.sbut_but_WooTable_Other_ToEnglish_Currency.ScreenTip = "Convert amount to written english as currency";
            this.sbut_but_WooTable_Other_ToEnglish_Currency.ShowImage = true;
            this.sbut_but_WooTable_Other_ToEnglish_Currency.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_but_WooTable_Other_ToEnglish_Currency_Click);
            // 
            // sbut_WooTable_ConvCurrency_Other
            // 
            this.sbut_WooTable_ConvCurrency_Other.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sbut_WooTable_ConvCurrency_Other.Enabled = false;
            this.sbut_WooTable_ConvCurrency_Other.Label = "Convert currency";
            this.sbut_WooTable_ConvCurrency_Other.Name = "sbut_WooTable_ConvCurrency_Other";
            this.sbut_WooTable_ConvCurrency_Other.OfficeImageId = "FileStartWorkflow";
            this.sbut_WooTable_ConvCurrency_Other.ShowImage = true;
            this.sbut_WooTable_ConvCurrency_Other.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_ConvCurrency_Other_Click);
            // 
            // gr_Oracle
            // 
            this.gr_Oracle.Items.Add(this.sbut_WooTable_Oracle_NewDoc);
            this.gr_Oracle.Items.Add(this.sbut_WooTable_Oracle_Icons);
            this.gr_Oracle.Items.Add(this.sbut_WooTable_Oracle_Format);
            this.gr_Oracle.Label = "Oracle";
            this.gr_Oracle.Name = "gr_Oracle";
            // 
            // sbut_WooTable_Oracle_NewDoc
            // 
            this.sbut_WooTable_Oracle_NewDoc.Label = "New document";
            this.sbut_WooTable_Oracle_NewDoc.Name = "sbut_WooTable_Oracle_NewDoc";
            this.sbut_WooTable_Oracle_NewDoc.OfficeImageId = "FileSaveAsWordOpenDocumentText";
            this.sbut_WooTable_Oracle_NewDoc.ShowImage = true;
            this.sbut_WooTable_Oracle_NewDoc.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_Oracle_NewDoc_Click);
            // 
            // sbut_WooTable_Oracle_Format
            // 
            this.sbut_WooTable_Oracle_Format.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sbut_WooTable_Oracle_Format.Label = "Format document";
            this.sbut_WooTable_Oracle_Format.Name = "sbut_WooTable_Oracle_Format";
            this.sbut_WooTable_Oracle_Format.OfficeImageId = "_3DBevelOptionsDialog";
            // 
            // gr_WooTable
            // 
            this.gr_WooTable.Items.Add(this.but_WooTable_Settings);
            this.gr_WooTable.Items.Add(this.but_WooTable_Donate);
            this.gr_WooTable.Items.Add(this.but_WooTable_Home);
            this.gr_WooTable.Label = "WooTable";
            this.gr_WooTable.Name = "gr_WooTable";
            // 
            // but_WooTable_Settings
            // 
            this.but_WooTable_Settings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.but_WooTable_Settings.Label = "Settings";
            this.but_WooTable_Settings.Name = "but_WooTable_Settings";
            this.but_WooTable_Settings.OfficeImageId = "ControlsGallery";
            this.but_WooTable_Settings.ScreenTip = "WooTable Settings";
            this.but_WooTable_Settings.ShowImage = true;
            this.but_WooTable_Settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Settings_Click);
            // 
            // but_WooTable_Donate
            // 
            this.but_WooTable_Donate.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.but_WooTable_Donate.Enabled = false;
            this.but_WooTable_Donate.Label = "Donate";
            this.but_WooTable_Donate.Name = "but_WooTable_Donate";
            this.but_WooTable_Donate.OfficeImageId = "HappyFace";
            this.but_WooTable_Donate.ShowImage = true;
            this.but_WooTable_Donate.Visible = false;
            this.but_WooTable_Donate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Donate_Click);
            // 
            // but_WooTable_Home
            // 
            this.but_WooTable_Home.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.but_WooTable_Home.Label = "Project Home";
            this.but_WooTable_Home.Name = "but_WooTable_Home";
            this.but_WooTable_Home.OfficeImageId = "BlogHomePage";
            this.but_WooTable_Home.ShowImage = true;
            this.but_WooTable_Home.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.but_WooTable_Home_Click);
            // 
            // sbut_WooTable_Oracle_Icons
            // 
            this.sbut_WooTable_Oracle_Icons.Label = "Icons";
            this.sbut_WooTable_Oracle_Icons.Name = "sbut_WooTable_Oracle_Icons";
            this.sbut_WooTable_Oracle_Icons.OfficeImageId = "StarRatedFull";
            this.sbut_WooTable_Oracle_Icons.ShowImage = true;
            this.sbut_WooTable_Oracle_Icons.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sbut_WooTable_Oracle_Icons_Click);
            // 
            // WooTable
            // 
            this.Name = "WooTable";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.gr_Main.ResumeLayout(false);
            this.gr_Main.PerformLayout();
            this.gr_Table.ResumeLayout(false);
            this.gr_Table.PerformLayout();
            this.gr_Math.ResumeLayout(false);
            this.gr_Math.PerformLayout();
            this.gr_Other.ResumeLayout(false);
            this.gr_Other.PerformLayout();
            this.gr_Oracle.ResumeLayout(false);
            this.gr_Oracle.PerformLayout();
            this.gr_WooTable.ResumeLayout(false);
            this.gr_WooTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gr_WooTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Donate;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Home;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gr_Main;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gr_Math;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_NewTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_SumCreate;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_xls1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gr_Table;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton sbut_WooTable_XLS1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Min;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Max;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Avg;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Sum;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_Median;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton but_WooTable_xls2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton tog_WooTable_XLS;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery gal_WooTable_Format;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_String;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_Percent;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_Float1;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_Float2;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_Float3;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_Float4;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_Currency;
        private Microsoft.Office.Tools.Ribbon.RibbonButton gal_WooTable_but_Other;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton sbut_WooTable_ToEnglish;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gr_Other;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton sbut_WooTable_ToEnglish_Other;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_but_WooTable_ToEnglish_Currency;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_but_WooTable_Other_ToEnglish_Currency;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton sbut_WooTable_Bullets;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton sbut_WooTable_Numbering;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_WooTable_ConvCurrency_Other;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_WooTable_ConvCurrency;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_WooTable_DecSep;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_but_WooTable_XLS1_Select;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gr_Oracle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_WooTable_Oracle_NewDoc;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton sbut_WooTable_Oracle_Format;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sbut_WooTable_Oracle_Icons;
    }

    partial class ThisRibbonCollection
    {
        internal WooTable Ribbon1
        {
            get { return this.GetRibbon<WooTable>(); }
        }
    }
}
