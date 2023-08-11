using BSECUS;
using System;
using BOSLib;
using System.Net;
using System.Linq;
using System.Text;
using System.Data;
using Localization;
using BOSCommon.Constants;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
//using Newtonsoft.Json;

namespace BOSERP.Utilities
{
    public class ApiMInvoiceEInvoiceHelper
    {
        RemoteCommand remoteCommand = null;

        #region Private properties
        private static List<ADConfigValuesInfo> listTinhTrang = (new ADConfigValuesController()).GetADConfigValuesByKeyGroup("EInvoiceGeneralHDStatus");
        private static List<ADConfigValuesInfo> listTrangThai = (new ADConfigValuesController()).GetADConfigValuesByKeyGroup("EInvoiceGeneralStatus");
        private ACEInvoiceConfigsInfo EInvoiceConfigsInfo { get; set; }
        #endregion

        #region Constructor
        public ApiMInvoiceEInvoiceHelper(int taxUnitID)
        {
            ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
            ACTaxUnitsInfo objTaxUnitsInfo = (ACTaxUnitsInfo)objTaxUnitsController.GetObjectByID(taxUnitID);
            if(objTaxUnitsInfo == null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Đơn vị chịu thuế cho chứng từ này!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            EInvoiceConfigsInfo = objEInvoiceConfigsController.GetLastEInvoiceConfigByTaxUnitID(taxUnitID);
            if (EInvoiceConfigsInfo == null)
            {
                MessageBox.Show(string.Format("Vui lòng cấu hình Hóa đơn điện tử cho đơn vị chịu thuế {0}!", objTaxUnitsInfo.ACTaxUnitName)
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(String.IsNullOrWhiteSpace(EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber))
            {
                MessageBox.Show(string.Format("Vui lòng Kiểm tra lại Mã số thuế trong cấu hình thông tin tài khoản M-Invoice của đơn vị chịu thuế {0}!", objTaxUnitsInfo.ACTaxUnitName)
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }
        #endregion

        #region Login MInvoice
        public WebClient LoginMInvoice()
        {
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.Encoding = System.Text.Encoding.UTF8;
            string json = "{\"username\":\"" + EInvoiceConfigsInfo.ACEInvoiceConfigAccount + "\",\"password\":\"" + EInvoiceConfigsInfo.ACEInvoiceConfigACpass + "\",\"ma_dvcs\":\"VP\"}";

            string address = "https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/Account/Login";
            string reslt = client.UploadString(address, json);
            if (reslt.Contains("error"))
            {
                MessageBox.Show(reslt, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            JObject tk = JObject.Parse(reslt);
            string token = "Bear " + tk["token"].ToString() + ";VP";
            WebClient client2 = new WebClient();
            client2.Encoding = Encoding.UTF8;
            client2.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client2.Headers.Add(HttpRequestHeader.Authorization, token);

            return client2;
        }
        #endregion

        #region M-Invoice API
        public bool ImportInv_MInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, bool isSign, bool isCreate)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objEInvoiceGeneralsInfo.InvoiceType);
            if (EInvoiceConfigsInfo == null)
                return false;

            WebClient client2 = LoginMInvoice();
            if (client2 == null)
                return false;

            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = ((List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID))).OrderBy(o => o.ProductItemCustomerCode).ToList();

            Guid inv_InvoiceAuth_id = Guid.NewGuid();
            string inv_invoiceSeries = objEInvoiceGeneralsInfo.InvoiceSeries;

            JArray jarr = new JArray();
            JObject jsdatadetail = new JObject();
            jsdatadetail.Add("data", jarr);

            decimal totalAmountWithoutVat = 0;
            decimal discountAmount = 0;

            int index = 0;
            decimal taxPercent = 0;
            if (objEInvoiceGeneralsInfo.TaxOfficeCode == "5%")
                taxPercent = 5;
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "8%")
                taxPercent = 8;
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "10%")
                taxPercent = 10;

            //Tạo item cho hóa đơn
            eInvoiceDetails.ForEach(o =>
            {
                index++;
                JObject detail = new JObject();
                detail.Add("inv_InvoiceAuth_id", isCreate ? inv_InvoiceAuth_id.ToString() : objEInvoiceGeneralsInfo.PublicKey);
                detail.Add("tchat", 1);
                detail.Add("stt_rec0", index);                                          //Số thứ tự
                detail.Add("inv_itemCode", o.ACEInvoiceDetailVATCode);                  //Mã hàng hóa
                detail.Add("inv_itemName", o.ItemName);                                 //Tên hàng hóa
                detail.Add("inv_quantity", FomatQuantity(o.Quantity));                  //Số lượng
                detail.Add("inv_unitPrice", o.UnitPrice);                               //Đơn giá
                detail.Add("inv_discountPercentage", FomatPrice(o.DiscountPercent));    //Tỷ lệ chiết khấu 
                detail.Add("inv_discountAmount", FomatPrice(o.DiscountAmount));         //Số tiền chiết khấu
                detail.Add("inv_TotalAmountWithoutVat", FomatPrice(o.Quantity * o.UnitPrice - o.DiscountAmount));   //Thành tiền trước thuế (sau CK)
                detail.Add("ma_thue", taxPercent);                                               //Thuế suất item
                detail.Add("inv_vatAmount", 0);                                         //Tiền thuế item
                detail.Add("inv_TotalAmount", FomatPrice(o.Quantity * o.UnitPrice - o.DiscountAmount));             //Thành tiền sau thuế
                detail.Add("inv_unitCode", o.UnitCode);
                detail.Add("inv_unitName", o.UnitName);
                detail.Add("masp_kh", o.ProductItemCustomerCode);
                detail.Add("inv_promotion", o.Promotion);

                jarr.Add(detail);
                //totalAmountWithoutVat += o.Quantity * o.UnitPrice;
                //discountAmount += o.DiscountAmount;
            });

            jsdatadetail.Add("tab_id", string.Empty);
            jsdatadetail.Add("tab_table", "inv_InvoiceAuthDetail");

            JObject js = new JObject();
            js.Add("windowid", string.Empty);
            if (isCreate)
                js.Add("editmode", "1");
            else
                js.Add("editmode", "2");

            JArray jarrDP = new JArray();
            JObject jsDP = new JObject();
            jsDP.Add("inv_InvoiceAuth_id", isCreate ? inv_InvoiceAuth_id.ToString() : objEInvoiceGeneralsInfo.PublicKey);
            jsDP.Add("inv_invoiceIssuedDate", objEInvoiceGeneralsInfo.ContractDate.ToString("yyyy-MM-dd"));                 //Ngày hóa đơn
            jsDP.Add("inv_invoiceSeries", inv_invoiceSeries.Trim());                                                        //Ký hiệu hóa đơn
            jsDP.Add("inv_invoiceNumber", isCreate ? string.Empty : objEInvoiceGeneralsInfo.InvoiceNumber.Trim());          //Số hóa đơn
            jsDP.Add("so_benh_an", objEInvoiceGeneralsInfo.ContractNumber);                                                 //Số đơn hàng
            jsDP.Add("inv_currencyCode", objEInvoiceGeneralsInfo.CurrencyCode);                                             //Code tiền tệ
            jsDP.Add("inv_exchangeRate", objEInvoiceGeneralsInfo.ExchangeRate);                                             //Tỷ giá
            jsDP.Add("inv_paymentMethodName", objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName);                         //Hình thức thanh toán
            jsDP.Add("inv_buyerDisplayName", objEInvoiceGeneralsInfo.BuyerDisplayName);                                     //Tên người mua
            jsDP.Add("ma_dt", objEInvoiceGeneralsInfo.BuyerCode);                                                           //Mã khách hàng
            jsDP.Add("inv_buyerLegalName", objEInvoiceGeneralsInfo.BuyerLegalName);                                         //Tên đơn vị mua (Tên khách hàng)
            jsDP.Add("inv_buyerTaxCode", objEInvoiceGeneralsInfo.BuyerTaxCode);                                             //Mã số thuế khách mua hàng
            jsDP.Add("inv_buyerAddressLine", objEInvoiceGeneralsInfo.BuyerAddressLine);                                     //Địa chỉ người mua hàng
            jsDP.Add("inv_buyerEmail", objEInvoiceGeneralsInfo.BuyerEmail);                                                 //Email người mua hàng
            jsDP.Add("inv_buyerBankAccount", objEInvoiceGeneralsInfo.BuyerBankAccount);                                     //Số tài khoản người mua hàng
            jsDP.Add("inv_buyerBankName", objEInvoiceGeneralsInfo.BuyerBankName);                                           //Ngân hàng người mua hàng
            jsDP.Add("inv_TotalAmountWithoutVat", FomatPrice(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT));      //Tổng tiền trước thuế GTGT
            jsDP.Add("inv_discountAmount", FomatPrice(objEInvoiceGeneralsInfo.DiscountAmount));                             //Tổng tiền chiết khấu
            jsDP.Add("inv_vatAmount", FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount));                                  //Tổng tiền thuế GTGT
            jsDP.Add("inv_TotalAmount", FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT));                            //Tổng tiền bằng số
            jsDP.Add("amount_to_word", objEInvoiceGeneralsInfo.TotalAmountWithVATInWords);                                  //Tổng tiền bằng chữ

            jsDP.Add("inv_invoiceName", "Hóa đơn giá trị gia tăng");
            jsDP.Add("inv_sellerBankAccount", objEInvoiceGeneralsInfo.SellerBankAccount);
            jsDP.Add("inv_sellerBankName", objEInvoiceGeneralsInfo.SellerBankName);
            jsDP.Add("inv_invoiceType", objEInvoiceTypesInfo != null ? objEInvoiceTypesInfo.ACEInvoiceTypeNo : string.Empty);

            //jsDP.Add("inv_TotalAmountWithoutVat", FomatPrice(totalAmountWithoutVat));
            //jsDP.Add("inv_discountAmount", FomatPrice(discountAmount));
            //jsDP.Add("inv_vatAmount", 0);
            //jsDP.Add("inv_TotalAmount", FomatPrice(totalAmountWithoutVat - discountAmount));

            //=============
            jsDP.Add("PTCK", FomatPrice(objEInvoiceGeneralsInfo.DiscountPercent));
            jsDP.Add("TIENCK", FomatPrice(objEInvoiceGeneralsInfo.DiscountAmount));

            jsDP.Add("PTTHUE", FomatPrice(taxPercent));
            jsDP.Add("TIENTHUE", FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount));
            jsDP.Add("TONGTIEN", FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT));
            //=============
            jsDP.Add("inv_adjustmentType", 1);
            jsDP.Add("mau_hd", objEInvoiceGeneralsInfo.TemplateCode);
            jsDP.Add("ma_ct", "HDDT");


            JArray arrdetail = new JArray();
            arrdetail.Add(jsdatadetail);
            jsDP.Add("details", arrdetail);

            jarrDP.Add(jsDP);

            js.Add("data", jarrDP);

            string invoice = js.ToString();
            string ketqua;
            if (!isSign)
                ketqua = client2.UploadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/Save", invoice);
            else
                ketqua = client2.UploadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/SaveSign", invoice);

            try
            {
                JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(ketqua);
                if (jObject != null && (string)jObject["code"] == "00")
                {
                    if (isCreate)
                    {
                        objEInvoiceGeneralsInfo.PublicKey = (string)jObject["data"]["id"];
                        objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = "Value0";
                        objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = (!isSign) ? "Value1" : "Value2";
                        objEInvoiceGeneralsInfo.InvoiceNumber = (string)jObject["data"]["shdon"];

                        ADConfigValuesInfo objConfigValuesInfo1 = listTinhTrang.FirstOrDefault(o => o.ADConfigKeyValue == string.Format("Value{0}", (string)jObject["tthdon"]));
                        objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = objConfigValuesInfo1 != null ? objConfigValuesInfo1.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus;
                        ADConfigValuesInfo objConfigValuesInfo2 = listTrangThai.FirstOrDefault(o => o.ADConfigKeyValue == (string)jObject["tthai"]);
                        objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = objConfigValuesInfo2 != null ? objConfigValuesInfo2.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus;

                        (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                        MessageBox.Show("Đã chuyển dữ liệu thành công nhưng chưa phát hành HD", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if (jObject != null && (string)jObject["code"] != "00")
                {
                    MessageBox.Show((string)jObject["message"], CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình tạo hóa đơn", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        public bool ActionSignInv_MInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            if (EInvoiceConfigsInfo == null)
                return false;

            WebClient client2 = LoginMInvoice();
            if (client2 == null)
                return false;

            try
            {
                JArray jarr = new JArray();
                JObject jObj = new JObject();
                jObj.Add("hoadon68_id", objEInvoiceGeneralsInfo.PublicKey);
                jarr.Add(jObj);

                JObject js = new JObject();
                js.Add("data", jarr);

                string invoice = js.ToString();
                string ketqua = client2.UploadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/Sign", invoice);

                JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(ketqua);
                if (jObject != null && (string)jObject["code"] == "00")
                {
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "Value2";
                    objEInvoiceGeneralsInfo.SubmittedDate = DateTime.Now;
                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);

                    return true;
                }
                else if (jObject != null && (string)jObject["code"] != "00")
                {
                    MessageBox.Show((string)jObject["message"], CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình ký", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        public bool ActionGetInfoInv_MInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            if (EInvoiceConfigsInfo == null)
                return false;

            WebClient client2 = LoginMInvoice();
            if (client2 == null)
                return false;

            try
            {
                //string ketqua = client2.DownloadString("https://" + objEInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/Invoice/GetById?id={" + objEInvoiceGeneralsInfo.PublicKey + "}");
                string ketqua = client2.DownloadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/GetInfoInvoice?id={" + objEInvoiceGeneralsInfo.PublicKey + "}");

                JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(ketqua);
                if (jObject != null && (string)jObject["code"] == "00")
                {
                    ADConfigValuesInfo objConfigValuesInfo1 = listTinhTrang.FirstOrDefault(o => o.ADConfigKeyValue == string.Format("Value{0}", (string)jObject["tthdon"]));
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = objConfigValuesInfo1 != null ? objConfigValuesInfo1.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus;
                    ADConfigValuesInfo objConfigValuesInfo2 = listTrangThai.FirstOrDefault(o => o.ADConfigText == (string)jObject["tthai"]);
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = objConfigValuesInfo2 != null ? objConfigValuesInfo2.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus;
                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);

                    return true;
                }
                else if (jObject != null && (string)jObject["code"] != "00")
                {
                    MessageBox.Show((string)jObject["message"], CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật thông tin", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        public bool ActionDeleteInv_MInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            if (EInvoiceConfigsInfo == null)
                return false;

            WebClient client2 = LoginMInvoice();
            if (client2 == null)
                return false;

            JObject jsDP = new JObject();
            jsDP.Add("inv_InvoiceAuth_id", objEInvoiceGeneralsInfo.PublicKey);
            //jsDP.Add("sovb", objEInvoiceGeneralsInfo.AdditionalReferenceDesc);
            jsDP.Add("ngayvb", objEInvoiceGeneralsInfo.AdditionalReferenceDate.ToString("yyyy-MM-dd"));
            jsDP.Add("ghi_chu", objEInvoiceGeneralsInfo.InvoiceNote);

            string invoice = jsDP.ToString();

            try
            {
                string ketqua = client2.UploadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/HuyHoaDon", invoice);

                JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(ketqua);
                if (jObject != null && (string)jObject["code"] == "00")
                {
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = "Value1";
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "Value0";
                    ADConfigValuesInfo objConfigValuesInfo2 = listTrangThai.FirstOrDefault(o => o.ADConfigText == (string)jObject["tthai"]);
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = objConfigValuesInfo2 != null ? objConfigValuesInfo2.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus;
                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                    return true;
                }
                else if (jObject != null && (string)jObject["code"] != "00")
                {
                    MessageBox.Show((string)jObject["message"], CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình hủy hóa đơn", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        public bool AdjustInfoInv_MInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            if (EInvoiceConfigsInfo == null)
                return false;

            WebClient client2 = LoginMInvoice();
            if (client2 == null)
                return false;

            JObject jsDP = new JObject();
            jsDP.Add("inv_InvoiceAuth_id", objEInvoiceGeneralsInfo.PublicKey);
            jsDP.Add("inv_invoiceIssuedDate", objEInvoiceGeneralsInfo.ContractDate.ToString("yyyy-MM-dd"));
            jsDP.Add("sovb", objEInvoiceGeneralsInfo.AdditionalReferenceDesc);
            jsDP.Add("ngayvb", objEInvoiceGeneralsInfo.AdditionalReferenceDate);
            jsDP.Add("ghi_chu", objEInvoiceGeneralsInfo.InvoiceNote);
            jsDP.Add("inv_buyerDisplayName", objEInvoiceGeneralsInfo.BuyerDisplayName);
            jsDP.Add("ma_dt", objEInvoiceGeneralsInfo.BuyerCode);
            jsDP.Add("inv_buyerLegalName", objEInvoiceGeneralsInfo.BuyerLegalName);
            jsDP.Add("inv_buyerAddressLine", objEInvoiceGeneralsInfo.BuyerAddressLine);
            jsDP.Add("inv_buyerEmail", objEInvoiceGeneralsInfo.BuyerEmail);
            jsDP.Add("inv_buyerBankAccount", objEInvoiceGeneralsInfo.BuyerBankAccount);
            jsDP.Add("inv_buyerBankName", objEInvoiceGeneralsInfo.BuyerBankName);

            int index = 0;
            decimal taxPercent = 0;
            if (objEInvoiceGeneralsInfo.TaxOfficeCode == "5%")
                taxPercent = 5;
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "8%")
                taxPercent = 8;
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "10%")
                taxPercent = 10;

            JArray jarr = new JArray();
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = ((List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID))).OrderBy(o => o.ProductItemCustomerCode).ToList();
            eInvoiceDetails.ForEach(o =>
            {
                index++;
                JObject detail = new JObject();
                detail.Add("tchat", 1);
                detail.Add("stt", index);                                          //Số thứ tự
                detail.Add("ma", o.ACEInvoiceDetailVATCode);                  //Mã hàng hóa
                detail.Add("inv_itemName", o.ItemName);                                 //Tên hàng hóa
                detail.Add("inv_unitCode", o.UnitCode);
                detail.Add("inv_unitName", o.UnitName);
                detail.Add("inv_unitPrice", o.UnitPrice);                               //Đơn giá
                detail.Add("inv_quantity", FomatQuantity(o.Quantity));                  //Số lượng
                detail.Add("inv_TotalAmountWithoutVat", FomatPrice(o.Quantity * o.UnitPrice - o.DiscountAmount));   //Thành tiền trước thuế (sau CK)
                detail.Add("inv_vatAmount", 0);                                         //Tiền thuế item
                detail.Add("inv_TotalAmount", FomatPrice(o.Quantity * o.UnitPrice - o.DiscountAmount));             //Thành tiền sau thuế
                detail.Add("inv_discountPercentage", FomatPrice(o.DiscountPercent));    //Tỷ lệ chiết khấu 
                detail.Add("inv_discountAmount", FomatPrice(o.DiscountAmount));         //Số tiền chiết khấu                
                detail.Add("ma_thue", taxPercent);                                               //Thuế suất item
                detail.Add("masp_kh", o.ProductItemCustomerCode);
                detail.Add("inv_promotion", o.Promotion);
                jarr.Add(detail);
            });

            jsDP.Add("data", jarr);
            string invoice = jsDP.ToString();

            try
            {
                string ketqua = client2.UploadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/DieuChinh", invoice);

                JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(ketqua);
                if (jObject != null && (string)jObject["code"] == "00")
                {
                    objEInvoiceGeneralsInfo.PublicKey = (string)jObject["data"]["id"];
                    objEInvoiceGeneralsInfo.InvoiceNumber = (string)jObject["data"]["shdon"];

                    ADConfigValuesInfo objConfigValuesInfo1 = listTinhTrang.FirstOrDefault(o => o.ADConfigKeyValue == string.Format("Value{0}", (string)jObject["tthdon"]));
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = objConfigValuesInfo1 != null ? objConfigValuesInfo1.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus;
                    ADConfigValuesInfo objConfigValuesInfo2 = listTrangThai.FirstOrDefault(o => o.ADConfigKeyValue == (string)jObject["tthai"]);
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = objConfigValuesInfo2 != null ? objConfigValuesInfo2.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus;
                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                    return true;
                }
                else if (jObject != null && (string)jObject["code"] != "00")
                {
                    MessageBox.Show((string)jObject["message"], CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình điều chỉnh hóa đơn", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

        public bool ActionCancelInv_MInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            if (EInvoiceConfigsInfo == null)
                return false;

            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)(new ACEInvoiceTypesController()).GetObjectByNo(objEInvoiceGeneralsInfo.InvoiceType);
            if (objEInvoiceTypesInfo == null)
                return false;

            WebClient client2 = LoginMInvoice();
            if (client2 == null)
                return false;

            try
            {
                JArray jarr = new JArray();
                JObject jObj = new JObject();
                jObj.Add("inv_InvoiceAuth_id", objEInvoiceGeneralsInfo.PublicKey);
                jObj.Add("inv_invoiceSeries", objEInvoiceGeneralsInfo.InvoiceSeries.Trim());
                jObj.Add("inv_invoiceNumber", objEInvoiceGeneralsInfo.InvoiceNumber.Trim());
                jarr.Add(jObj);

                JObject js = new JObject();
                js.Add("windowid", string.Empty);
                js.Add("editmode", "3");
                js.Add("data", jarr);

                string invoice = js.ToString();
                string ketqua = client2.UploadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/Save", invoice);

                JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(ketqua);
                if (jObject != null && (string)jObject["code"] == "00")
                {
                    ADConfigValuesInfo objConfigValuesInfo1 = listTinhTrang.FirstOrDefault(o => o.ADConfigKeyValue == string.Format("Value{0}", (string)jObject["tthdon"]));
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = objConfigValuesInfo1 != null ? objConfigValuesInfo1.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus;
                    ADConfigValuesInfo objConfigValuesInfo2 = listTrangThai.FirstOrDefault(o => o.ADConfigKeyValue == (string)jObject["tthai"]);
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = objConfigValuesInfo2 != null ? objConfigValuesInfo2.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus;
                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);

                    return true;
                }
                else if (jObject != null && (string)jObject["code"] != "00")
                {
                    MessageBox.Show((string)jObject["message"], CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        public bool ReplaceInv_MInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();            
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objEInvoiceGeneralsInfo.InvoiceType);
            if (EInvoiceConfigsInfo == null)
                return false;

            WebClient client2 = LoginMInvoice();
            if (client2 == null)
                return false;

            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = ((List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID))).OrderBy(o => o.ACEInvoiceDetailVATCode).ToList();

            Guid inv_InvoiceAuth_id = Guid.NewGuid();
            string inv_invoiceSeries = objEInvoiceGeneralsInfo.InvoiceSeries;

            JArray jarr = new JArray();
            JObject jsdatadetail = new JObject();
            jsdatadetail.Add("data", jarr);

            decimal totalAmountWithoutVat = 0;
            decimal discountAmount = 0;
            decimal taxPercent = 0;
            if (objEInvoiceGeneralsInfo.TaxOfficeCode == "5%")
                taxPercent = 5;
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "8%")
                taxPercent = 8;
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "10%")
                taxPercent = 10;

            int index = 0;
            eInvoiceDetails.ForEach(o =>
            {
                index++;
                JObject detail = new JObject();
                detail.Add("inv_InvoiceAuthDetail_id", Guid.NewGuid());
                detail.Add("inv_InvoiceAuth_id", inv_InvoiceAuth_id);
                detail.Add("tchat", 1);
                detail.Add("stt", index);
                detail.Add("ma", o.ACEInvoiceDetailVATCode);
                detail.Add("inv_itemName", o.ItemName);
                detail.Add("inv_unitCode", o.UnitCode);
                detail.Add("inv_unitPrice", o.UnitPrice);
                detail.Add("inv_quantity", FomatQuantity(o.Quantity));
                detail.Add("inv_TotalAmountWithoutVat", FomatPrice(o.Quantity * o.UnitPrice - o.DiscountAmount));
                detail.Add("inv_vatAmount", 0);
                detail.Add("inv_TotalAmount", FomatPrice(o.Quantity * o.UnitPrice - o.DiscountAmount));
                detail.Add("inv_promotion", o.Promotion);
                detail.Add("inv_discountPercentage", FomatPrice(o.DiscountPercent));
                detail.Add("inv_discountAmount", FomatPrice(o.DiscountAmount));
                detail.Add("ma_thue", taxPercent);
                detail.Add("inv_unitName", o.UnitName);
                detail.Add("inv_itemCode", o.ACEInvoiceDetailVATCode);
                detail.Add("masp_kh", o.ProductItemCustomerCode);
                jarr.Add(detail);
                totalAmountWithoutVat += o.Quantity * o.UnitPrice;
                discountAmount += o.DiscountAmount;
            });

            jsdatadetail.Add("tab_id", string.Empty);
            jsdatadetail.Add("tab_table", "inv_InvoiceAuthDetail");

            JObject js = new JObject();
            js.Add("windowid", string.Empty);
            js.Add("editmode", "1");

            JArray jarrDP = new JArray();

            JObject jsDP = new JObject();
            jsDP.Add("inv_originalId", objEInvoiceGeneralsInfo.PublicKey);                                                  //ID hóa đơn cần thay thế
            jsDP.Add("ngayvb", objEInvoiceGeneralsInfo.AdditionalReferenceDate.ToString("yyyy-MM-dd"));                     //Ngày làm thay thế
            jsDP.Add("ghi_chu", objEInvoiceGeneralsInfo.InvoiceNote);                                                       //Lý do thay thế
            jsDP.Add("sovb", objEInvoiceGeneralsInfo.AdditionalReferenceDesc);                                              //Số văn bản
            jsDP.Add("inv_invoiceSeries", inv_invoiceSeries);                                                               //Ký hiệu
            jsDP.Add("inv_invoiceIssuedDate", objEInvoiceGeneralsInfo.ContractDate.ToString("yyyy-MM-dd"));                 //Ngày hóa đơn
            jsDP.Add("inv_currencyCode", objEInvoiceGeneralsInfo.CurrencyCode);                                             //Mã tiền tệ
            jsDP.Add("inv_exchangeRate", objEInvoiceGeneralsInfo.ExchangeRate);                                             //Tỷ giá
            jsDP.Add("inv_buyerDisplayName", objEInvoiceGeneralsInfo.BuyerDisplayName);                                     //Tên người mua
            jsDP.Add("inv_buyerLegalName", objEInvoiceGeneralsInfo.BuyerLegalName);                                         //Tên đơn vị mua
            jsDP.Add("inv_buyerTaxCode", objEInvoiceGeneralsInfo.BuyerTaxCode);                                             //Mã số thuế bên mua
            jsDP.Add("inv_buyerAddressLine", objEInvoiceGeneralsInfo.BuyerAddressLine);                                     //Địa chỉ bên mua
            jsDP.Add("inv_buyerEmail", objEInvoiceGeneralsInfo.BuyerEmail);                                                 //Email bên mua
            jsDP.Add("inv_buyerBankAccount", objEInvoiceGeneralsInfo.BuyerBankAccount);                                     //TK ngân hàng
            jsDP.Add("inv_buyerBankName", objEInvoiceGeneralsInfo.BuyerBankName);                                           //Tên ngân hàng
            jsDP.Add("inv_paymentMethodName", objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName);                         //Hình thức thanh toán

            jsDP.Add("inv_InvoiceAuth_id", inv_InvoiceAuth_id);
            jsDP.Add("inv_invoiceNumber", "");
            jsDP.Add("inv_TotalAmountWithoutVat", FomatPrice(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT));      //Tổng tiền trước thuế GTGT
            jsDP.Add("inv_discountAmount", FomatPrice(objEInvoiceGeneralsInfo.DiscountAmount));                             //Tổng tiền chiết khấu
            jsDP.Add("inv_vatAmount", FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount));                                  //Tổng tiền thuế GTGT
            jsDP.Add("inv_TotalAmount", FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT));                            //Tổng tiền bằng số
            jsDP.Add("amount_to_word", objEInvoiceGeneralsInfo.TotalAmountWithVATInWords);                                  //Tổng tiền bằng chữ

            jsDP.Add("inv_invoiceName", "Hóa đơn giá trị gia tăng");
            jsDP.Add("inv_sellerBankAccount", objEInvoiceGeneralsInfo.SellerBankAccount);
            jsDP.Add("inv_sellerBankName", objEInvoiceGeneralsInfo.SellerBankName);
            jsDP.Add("inv_invoiceType", objEInvoiceTypesInfo != null ? objEInvoiceTypesInfo.ACEInvoiceTypeNo : string.Empty);

            //=============
            jsDP.Add("PTCK", FomatPrice(objEInvoiceGeneralsInfo.DiscountPercent));
            jsDP.Add("TIENCK", FomatPrice(objEInvoiceGeneralsInfo.DiscountAmount));

            jsDP.Add("PTTHUE", FomatPrice(taxPercent));
            jsDP.Add("TIENTHUE", FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount));
            jsDP.Add("TONGTIEN", FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT));
            //=============
            jsDP.Add("inv_adjustmentType", 1);
            jsDP.Add("mau_hd", objEInvoiceGeneralsInfo.TemplateCode);
            jsDP.Add("ma_ct", "HDDT");
            jsDP.Add("ma_dt", objEInvoiceGeneralsInfo.BuyerCode);
            jsDP.Add("so_benh_an", objEInvoiceGeneralsInfo.ContractNumber);

            JArray arrdetail = new JArray();
            arrdetail.Add(jsdatadetail);
            jsDP.Add("details", arrdetail);

            jarrDP.Add(jsDP);

            js.Add("data", jarrDP);

            string invoice = js.ToString();

            try
            {
                string ketqua = client2.UploadString("https://" + EInvoiceConfigsInfo.ACEInvoiceConfigTaxNumber + ".minvoice.com.vn/api/InvoiceAPI78/ThayThe", invoice);

                JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(ketqua);
                if (jObject != null && (string)jObject["code"] == "00")
                {
                    objEInvoiceGeneralsInfo.PublicKey = (string)jObject["data"]["id"];
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = "Value3";
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "Value1";
                    objEInvoiceGeneralsInfo.InvoiceNumber = (string)jObject["data"]["shdon"];

                    ADConfigValuesInfo objConfigValuesInfo1 = listTinhTrang.FirstOrDefault(o => o.ADConfigKeyValue == string.Format("Value{0}", (string)jObject["tthdon"]));
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus = objConfigValuesInfo1 != null ? objConfigValuesInfo1.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralHDStatus;
                    ADConfigValuesInfo objConfigValuesInfo2 = listTrangThai.FirstOrDefault(o => o.ADConfigKeyValue == (string)jObject["tthai"]);
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = objConfigValuesInfo2 != null ? objConfigValuesInfo2.ADConfigKeyValue : objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus;
                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);

                    return true;
                }
                else if (jObject != null && (string)jObject["code"] != "00")
                {
                    MessageBox.Show((string)jObject["message"], CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thay thế hóa đơn", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }
        #endregion

        #region Private function
        private static string FomatQuantity(decimal value)
        {
            return String.Format("{0:0}", value);
        }

        private static string FomatPrice(decimal value)
        {
            return String.Format("{0:0}", value);
        }

        private static string FomatVatPercentage(decimal value)
        {
            return String.Format("{0:0}", value);
        }

        private static string FomatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }
        #endregion
    }
}
