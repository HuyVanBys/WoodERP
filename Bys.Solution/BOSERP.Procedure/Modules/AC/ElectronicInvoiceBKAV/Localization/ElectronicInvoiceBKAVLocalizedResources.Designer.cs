﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9148
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
    public class ElectronicInvoiceBKAVLocalizedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ElectronicInvoiceBKAVLocalizedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BOSERP.Procedure.Modules.AC.ElectronicInvoiceBKAV.Localization.ElectronicInvoiceBKAVLocalizedResour" +
                            "ces", typeof(ElectronicInvoiceBKAVLocalizedResources).Assembly);
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
        ///   Looks up a localized string similar to Tạo hóa đơn thành công.
        /// </summary>
        public static string CreateSuccess {
            get {
                return ResourceManager.GetString("CreateSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mẫu số không hợp lệ!.
        /// </summary>
        public static string ErrorVATInvoiceNoCombo {
            get {
                return ResourceManager.GetString("ErrorVATInvoiceNoCombo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Không thể cập nhật cho hóa đơn này. Vui lòng kiểm tra lại Trạng thái của hóa đơn điện tử!.
        /// </summary>
        public static string NotUpdateEInvoice {
            get {
                return ResourceManager.GetString("NotUpdateEInvoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hóa đơn đã chuyển dữ liệu lên hệ thống và cấp số, bạn có muốn Hủy hóa đơn đã chuyển và tạo lại Hóa đơn mới?.
        /// </summary>
        public static string QuestionCancelEInvoice {
            get {
                return ResourceManager.GetString("QuestionCancelEInvoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hóa đơn điện tử này đã bị xóa hoặc hủy, bạn có muốn tạo Hóa đơn mới?.
        /// </summary>
        public static string QuestionCreateEInvoice {
            get {
                return ResourceManager.GetString("QuestionCreateEInvoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hóa đơn đã chuyển dữ liệu lên hệ thống, bạn có muốn Xóa hóa đơn đã chuyển và tạo lại Hóa đơn mới?.
        /// </summary>
        public static string QuestionDeleteEInvoice {
            get {
                return ResourceManager.GetString("QuestionDeleteEInvoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hóa đơn này đã được phát hành. Bạn có muốn tạo hóa đơn Thay thế?.
        /// </summary>
        public static string QuestionEInvoiceValue2 {
            get {
                return ResourceManager.GetString("QuestionEInvoiceValue2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Đây là hóa đơn Thay thế, bạn có muốn tạo hóa đơn Thay thế khác?.
        /// </summary>
        public static string QuestionEInvoiceValue6 {
            get {
                return ResourceManager.GetString("QuestionEInvoiceValue6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Đây là hóa đơn Điều chỉnh, bạn có muốn tạo hóa đơn Điều chỉnh khác?.
        /// </summary>
        public static string QuestionEInvoiceValue8 {
            get {
                return ResourceManager.GetString("QuestionEInvoiceValue8", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cập nhật hóa đơn thành công.
        /// </summary>
        public static string UpdateSuccess {
            get {
                return ResourceManager.GetString("UpdateSuccess", resourceCulture);
            }
        }
        
        public static string CheckInvoiceNumber
        {
            get
            {
                return ResourceManager.GetString("CheckInvoiceNumber", resourceCulture);
            }
        }
        
        public static string InputPublicKey
        {
            get
            {
                return ResourceManager.GetString("InputPublicKey", resourceCulture);
            }
        }

        public static string CheckTaxUnit
        {
            get
            {
                return ResourceManager.GetString("CheckTaxUnit", resourceCulture);
            }
        }
    }
}
