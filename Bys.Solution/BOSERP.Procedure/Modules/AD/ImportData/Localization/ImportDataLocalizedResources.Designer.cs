﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
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
    public class ImportDataLocalizedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ImportDataLocalizedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BOSERP.Procedure.Modules.AD.ImportData.Localization.ImportDataLocalizedResources", typeof(ImportDataLocalizedResources).Assembly);
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
        ///   Looks up a localized string similar to Mã nhóm hàng con.
        /// </summary>
        public static string ChildProductGroupNo {
            get {
                return ResourceManager.GetString("ChildProductGroupNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tập tin excel (*.xls;*.xlsx)|*.xls;*.xlsx.
        /// </summary>
        public static string DialogFilter {
            get {
                return ResourceManager.GetString("DialogFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã ngành hàng.
        /// </summary>
        public static string ICDepartmentNo {
            get {
                return ResourceManager.GetString("ICDepartmentNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã nhóm hàng.
        /// </summary>
        public static string ParentProductGroupNo {
            get {
                return ResourceManager.GetString("ParentProductGroupNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Đang import dữ liệu....
        /// </summary>
        public static string ProgressBarMessage {
            get {
                return ResourceManager.GetString("ProgressBarMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bạn có muốn import dữ liệu vào phần mềm ?.
        /// </summary>
        public static string QuestionImportDataMessage {
            get {
                return ResourceManager.GetString("QuestionImportDataMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import thành công {0} dòng dữ liệu excel vào phần mềm..
        /// </summary>
        public static string TotalRecordNumberImportSuccessMessage {
            get {
                return ResourceManager.GetString("TotalRecordNumberImportSuccessMessage", resourceCulture);
            }
        }
    }
}