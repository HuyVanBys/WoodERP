﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8922
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
    public class MaterialShipmentConstructionLocalizedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MaterialShipmentConstructionLocalizedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BOSERP.Procedure.Modules.IC.MaterialShipmentConstruction.Localization.MaterialShipmentConst" +
                            "ructionLocalizedResources", typeof(MaterialShipmentConstructionLocalizedResources).Assembly);
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
        ///   Looks up a localized string similar to Sản phẩm của bạn không được cùng mã cấp phát.
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
        ///   Looks up a localized string similar to Số lượng xuất kho không được lớn hơn số lượng trong kế hoạch !.
        /// </summary>
        public static string DeliveryMaxProductQtyErrorMessages {
            get {
                return ResourceManager.GetString("DeliveryMaxProductQtyErrorMessages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sản phẩn không không cùng hợp đồng!.
        /// </summary>
        public static string DuplicateSaleOrderMessages {
            get {
                return ResourceManager.GetString("DuplicateSaleOrderMessages", resourceCulture);
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
        ///   Looks up a localized string similar to Số lượng xuất kho không được lớn hơn số lượng chuyển kho!
        /// </summary>
        public static string ShipmentItemMaxProductQtyErrorMessages
        {
            get {
                return ResourceManager.GetString("ShipmentItemMaxProductQtyErrorMessages", resourceCulture);
            }
        }
    }
}