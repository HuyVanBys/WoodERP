﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MaterialShipmentLocalizedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MaterialShipmentLocalizedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BOSERP.Procedure.Modules.IC.MaterialShipment.Localization.MaterialShipmentLocalizedResource" +
                            "s", typeof(MaterialShipmentLocalizedResources).Assembly);
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
        ///   Looks up a localized string similar to Sản phẩm đã chọn không cùng công đoạn. Vui lòng kiểm tra lại !.
        /// </summary>
        public static string ChooseMulltiOperationMessage {
            get {
                return ResourceManager.GetString("ChooseMulltiOperationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sản phẩm của bạn không cùng lệnh sản xuất. Vui lòng chọn lại !.
        /// </summary>
        public static string ChooseMulltiSaleOrderMessage {
            get {
                return ResourceManager.GetString("ChooseMulltiSaleOrderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bạn có muốn thay đổi lý do cho những mặt hàng đã chọn?.
        /// </summary>
        public static string ConfirmChangeItemReasonMessage {
            get {
                return ResourceManager.GetString("ConfirmChangeItemReasonMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thành phẩm không được bỏ trống.
        /// </summary>
        public static string ICProductID {
            get {
                return ResourceManager.GetString("ICProductID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vui lòng chọn lý do nhập xuất!.
        /// </summary>
        public static string ImportAndExportReasonIsRequier {
            get {
                return ResourceManager.GetString("ImportAndExportReasonIsRequier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Các sản phẩm sau chưa chọn kho hoặc mã lô : {0} . Vui lòng kiểm tra lại!.
        /// </summary>
        public static string InvalidStoreAndProductSeriel {
            get {
                return ResourceManager.GetString("InvalidStoreAndProductSeriel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lệnh sản xuất không được bỏ trống.
        /// </summary>
        public static string MMBatchProductID {
            get {
                return ResourceManager.GetString("MMBatchProductID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product;Component;SemiProduct;ByProduct;Ingredient;Lumber;Reuse;Fuel;Verneer;ArtificialBoard;CCDC;VVP;MMTB;Car;Service.
        /// </summary>
        public static string ProductType {
            get {
                return ResourceManager.GetString("ProductType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Không được nhập quá số lượng cấp phát.
        /// </summary>
        public static string QtyAllocationProposal {
            get {
                return ResourceManager.GetString("QtyAllocationProposal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số lượng xuất kho lớn hơn số lượng cấp phát. Số lượng có thể xuất kho là {0}.
        /// </summary>
        public static string QtyMax {
            get {
                return ResourceManager.GetString("QtyMax", resourceCulture);
            }
        }
    }
}
