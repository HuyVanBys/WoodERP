﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8933
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ConfigSalesTargetLocalizedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigSalesTargetLocalizedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BOSERP.Procedure.Modules.HR.ConfigSalesTarget.Localization.ConfigSalesTargetLocalizedResour" +
                            "ces", typeof(ConfigSalesTargetLocalizedResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Từ ngày {0} đến ngày {1}.
        /// </summary>
        public static string FomatConfigSalesTargetItemNameForFromDateToDate {
            get {
                return ResourceManager.GetString("FomatConfigSalesTargetItemNameForFromDateToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tháng .
        /// </summary>
        public static string Month {
            get {
                return ResourceManager.GetString("Month", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quý .
        /// </summary>
        public static string Quarterly {
            get {
                return ResourceManager.GetString("Quarterly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tuần .
        /// </summary>
        public static string Week {
            get {
                return ResourceManager.GetString("Week", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Năm .
        /// </summary>
        public static string Year {
            get {
                return ResourceManager.GetString("Year", resourceCulture);
            }
        }
    }
}