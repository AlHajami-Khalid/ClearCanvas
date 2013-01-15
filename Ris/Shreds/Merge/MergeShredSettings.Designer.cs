﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Shreds.Merge {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class MergeShredSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MergeShredSettings defaultInstance = ((MergeShredSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MergeShredSettings())));
        
        public static MergeShredSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Number of items to pull from queue per read
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of items to pull from queue per read")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int BatchSize {
            get {
                return ((int)(this["BatchSize"]));
            }
        }
        
        /// <summary>
        /// Number of seconds to sleep when queue is empty
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of seconds to sleep when queue is empty")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int EmptyQueueSleepTime {
            get {
                return ((int)(this["EmptyQueueSleepTime"]));
            }
        }
        
        /// <summary>
        /// Minimum number of seconds to wait between subsequent actions on the same queue item.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Minimum number of seconds to wait between subsequent actions on the same queue it" +
            "em.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int ThrottleInterval {
            get {
                return ((int)(this["ThrottleInterval"]));
            }
        }
        
        /// <summary>
        /// Number of records to process per transaction.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of records to process per transaction.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int ItemsProcessedPerTransaction {
            get {
                return ((int)(this["ItemsProcessedPerTransaction"]));
            }
        }
    }
}
