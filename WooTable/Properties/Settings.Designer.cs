﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WooTable.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StatusBarUpdate {
            get {
                return ((bool)(this["StatusBarUpdate"]));
            }
            set {
                this["StatusBarUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Show_Min {
            get {
                return ((bool)(this["Show_Min"]));
            }
            set {
                this["Show_Min"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Show_Max {
            get {
                return ((bool)(this["Show_Max"]));
            }
            set {
                this["Show_Max"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Show_Median {
            get {
                return ((bool)(this["Show_Median"]));
            }
            set {
                this["Show_Median"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml")]
        public string Curr_Provider {
            get {
                return ((string)(this["Curr_Provider"]));
            }
            set {
                this["Curr_Provider"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double Curr_Risk {
            get {
                return ((double)(this["Curr_Risk"]));
            }
            set {
                this["Curr_Risk"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DialogOnMath {
            get {
                return ((bool)(this["DialogOnMath"]));
            }
            set {
                this["DialogOnMath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Culture {
            get {
                return ((string)(this["Culture"]));
            }
            set {
                this["Culture"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CultureString {
            get {
                return ((string)(this["CultureString"]));
            }
            set {
                this["CultureString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool XLSNewLine {
            get {
                return ((bool)(this["XLSNewLine"]));
            }
            set {
                this["XLSNewLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("WooTable_OracleData")]
        public string WooTable_OracleData {
            get {
                return ((string)(this["WooTable_OracleData"]));
            }
            set {
                this["WooTable_OracleData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("checksums.csv")]
        public string OracleData_Checksums {
            get {
                return ((string)(this["OracleData_Checksums"]));
            }
            set {
                this["OracleData_Checksums"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("WooTable")]
        public string AppDataFolder {
            get {
                return ((string)(this["AppDataFolder"]));
            }
            set {
                this["AppDataFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Files")]
        public string AppDataFilesFolder {
            get {
                return ((string)(this["AppDataFilesFolder"]));
            }
            set {
                this["AppDataFilesFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://sudanec.com/downloads/WooTable_Oracle/_files")]
        public string OracleDataLocation {
            get {
                return ((string)(this["OracleDataLocation"]));
            }
            set {
                this["OracleDataLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("updatecheck.sud")]
        public string UpdateTempFile {
            get {
                return ((string)(this["UpdateTempFile"]));
            }
            set {
                this["UpdateTempFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Icons")]
        public string AppDataIconsFolder {
            get {
                return ((string)(this["AppDataIconsFolder"]));
            }
            set {
                this["AppDataIconsFolder"] = value;
            }
        }
    }
}
