﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Underground_Dungeon {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class TradeSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static TradeSetting defaultInstance = ((TradeSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new TradeSetting())));
        
        public static TradeSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int TradeCoin {
            get {
                return ((int)(this["TradeCoin"]));
            }
            set {
                this["TradeCoin"] = value;
            }
        }
    }
}
