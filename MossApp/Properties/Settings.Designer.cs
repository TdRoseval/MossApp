﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MossApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public int OptionN {
            get {
                return ((int)(this["OptionN"]));
            }
            set {
                this["OptionN"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OptionC {
            get {
                return ((string)(this["OptionC"]));
            }
            set {
                this["OptionC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int OptionM {
            get {
                return ((int)(this["OptionM"]));
            }
            set {
                this["OptionM"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int UserId {
            get {
                return ((int)(this["UserId"]));
            }
            set {
                this["UserId"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>c,.c,.h</string>
  <string>cc,.cpp,.h,.hpp,.cc</string>
  <string>java,.java</string>
  <string>ml,.ml</string>
  <string>pascal,.pas</string>
  <string>ada,.ada</string>
  <string>lisp,.lisp</string>
  <string>scheme,.scm</string>
  <string>haskell,.hs</string>
  <string>fortran,.f90,.f95,.f03</string>
  <string>ascii,.asc,.txt</string>
  <string>vhdl,.vhdl</string>
  <string>perl,.perl,.pl</string>
  <string>matlab,.matlab</string>
  <string>python,.py</string>
  <string>mips,.s,.asm</string>
  <string>prolog,.pl</string>
  <string>spice,.sp</string>
  <string>vb,.vb</string>
  <string>csharp,.cs</string>
  <string>modula2,.mod</string>
  <string>a8086,.asm</string>
  <string>javascript,.js</string>
  <string>plsql,.json</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Languages {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Languages"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("moss.stanford.edu")]
        public string Server {
            get {
                return ((string)(this["Server"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7690")]
        public int Port {
            get {
                return ((int)(this["Port"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("moss")]
        public string MossOption {
            get {
                return ((string)(this["MossOption"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("directory")]
        public string DirectoryOption {
            get {
                return ((string)(this["DirectoryOption"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("send")]
        public string SendOption {
            get {
                return ((string)(this["SendOption"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("X")]
        public string ExperimentalOption {
            get {
                return ((string)(this["ExperimentalOption"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("maxmatches")]
        public string MaxMatchesOption {
            get {
                return ((string)(this["MaxMatchesOption"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("show")]
        public string ShowOption {
            get {
                return ((string)(this["ShowOption"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("query")]
        public string QueryOption {
            get {
                return ((string)(this["QueryOption"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("end")]
        public string EndOption {
            get {
                return ((string)(this["EndOption"]));
            }
        }
    }
}
