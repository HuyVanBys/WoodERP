﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
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
    public class BatchShipmentDryLumberLocalizedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BatchShipmentDryLumberLocalizedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BOSERP.Modules.IC.BatchShipmentDryLumber.Localization.BatchShipmentDryLumberL" +
                            "ocalizedResources", typeof(BatchShipmentDryLumberLocalizedResources).Assembly);
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
        ///   Looks up a localized string similar to Sản phẩm bạn chọn không cùng ReceiptLumber.
        /// </summary>
        public static string ChooseMulltiSaleOrderMessage {
            get {
                return ResourceManager.GetString("ChooseMulltiSaleOrderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã Kiện.
        /// </summary>
        public static string FK_ICProductSerieID {
            get {
                return ResourceManager.GetString("FK_ICProductSerieID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Khối lượng.
        /// </summary>
        public static string ICShipmentItemProductQty {
            get {
                return ResourceManager.GetString("ICShipmentItemProductQty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LSX.
        /// </summary>
        public static string MMBatchProductID {
            get {
                return ResourceManager.GetString("MMBatchProductID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Công đoạn.
        /// </summary>
        public static string MMOperationID {
            get {
                return ResourceManager.GetString("MMOperationID", resourceCulture);
            }
        }
    }
}