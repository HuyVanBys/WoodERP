using BOSCommon;
using BOSLib;
using HeiswayiNrird.Utility.Common;
using Localization;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace BOSERP.Utilities
{
    public class ApiEInvoiceHelper
    {
        public static ACEInvoiceConfigsInfo GetAccountConfig()
        {
            ACEInvoiceConfigsInfo obj = (ACEInvoiceConfigsInfo)(new ACEInvoiceConfigsController()).GetFirstObject();
            return obj;
        }
        public static bool AddInvoice(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = (List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID));

            InvoiceModel objInvoiceModel = new InvoiceModel();
            item objitem;
            List<item> items = new List<item>();
            eInvoiceDetails.ForEach(o =>
            {
                objitem = new item();
                objitem.lineNumber = o.LineNumber.ToString();
                objitem.itemCode = o.ItemCode;
                objitem.itemName = o.ItemName;
                objitem.unitCode = o.UnitCode;
                objitem.unitName = o.UnitName;
                objitem.quantity = FomatQuantity(o.Quantity);
                objitem.itemTotalAmountWithoutVat = FomatPrice(o.ItemTotalAmountWithoutVat);
                objitem.unitPrice = FomatPrice(o.UnitPrice);
                objitem.vatPercentage = FomatVatPercentage(o.VatPercentage);
                objitem.vatAmount = FomatPrice(o.VatAmount);
                if (objEInvoiceGeneralsInfo.AdjustmentType == 5)
                    objitem.isIncreaseItem = o.IsIncreaseItem == true ? "true" : "false";
                items.Add(objitem);
            });

            List<payment> payments = new List<payment>();
            payment objpayment = new payment();
            objpayment.paymentMethodName = "Tiền mặt";
            payments.Add(objpayment);

            invoiceTaxBreakdown objinvoiceTaxBreakdown;
            List<invoiceTaxBreakdown> invoiceTaxBreakdowns = new List<invoiceTaxBreakdown>();
            //eInvoiceTaxLevelAndAmounts.ForEach(o =>
            //{
            //    objinvoiceTaxBreakdown = new invoiceTaxBreakdown();
            //    objinvoiceTaxBreakdown.vatPercentage = String.Format("{0:0}", o.VatPercentage);
            //    objinvoiceTaxBreakdown.vatTaxableAmount = FomatPrice(o.VatTaxableAmount);
            //    objinvoiceTaxBreakdown.vatTaxAmount = FomatPrice(o.VatTaxAmount);
            //    invoiceTaxBreakdowns.Add(objinvoiceTaxBreakdown);
            //});

            invoiceData objinvoiceData = new invoiceData();
            objinvoiceData.sellerAppRecordId = objEInvoiceGeneralsInfo.SellerAppRecordId;
            objinvoiceData.invoiceAppRecordId = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo;
            objinvoiceData.invoiceType = objEInvoiceGeneralsInfo.InvoiceType;
            objinvoiceData.templateCode = objEInvoiceGeneralsInfo.TemplateCode;
            objinvoiceData.invoiceSeries = objEInvoiceGeneralsInfo.InvoiceSeries;
            if (objEInvoiceGeneralsInfo.AdjustmentType == 7)
                objinvoiceData.invoiceNumber = objEInvoiceGeneralsInfo.InvoiceNumber;
            else
                objinvoiceData.invoiceNumber = GetInvoiceNumber(objinvoiceData.invoiceType);
            objinvoiceData.invoiceName = objEInvoiceGeneralsInfo.InvoiceName;
            objinvoiceData.invoiceIssuedDate = FomatDateTime(objEInvoiceGeneralsInfo.InvoiceIssuedDate);
            objinvoiceData.currencyCode = objEInvoiceGeneralsInfo.CurrencyCode;
            objinvoiceData.adjustmentType = objEInvoiceGeneralsInfo.AdjustmentType.ToString();
            if (objEInvoiceGeneralsInfo.AdjustmentType != 1)
                objinvoiceData.originalInvoiceId = objEInvoiceGeneralsInfo.OriginalInvoiceId;
            objinvoiceData.payments = payments.ToArray();

            delivery objdelivery = new delivery();
            objdelivery.deliveryOrderNumber = objEInvoiceGeneralsInfo.DeliveryOrderNumber;
            objdelivery.deliveryOrderDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
            objinvoiceData.delivery = objdelivery;

            //objinvoiceData.sellerLegalName = objEInvoiceSellersInfo.SellerLegalName;
            objinvoiceData.sellerLegalName = "CÔNG TY TNHH MỘT THÀNH VIÊN THỰC PHẨM NĂM MỤC TIÊU";
            //objinvoiceData.sellerTaxCode = objEInvoiceSellersInfo.SellerTaxCode;
            objinvoiceData.sellerTaxCode = "0401695863";
            objinvoiceData.sellerAddressLine = objEInvoiceGeneralsInfo.SellerAddressLine;
            objinvoiceData.sellerPhoneNumber = objEInvoiceGeneralsInfo.SellerPhoneNumber;
            objinvoiceData.sellerFaxNumber = objEInvoiceGeneralsInfo.SellerFaxNumber;
            objinvoiceData.sellerEmail = objEInvoiceGeneralsInfo.SellerEmail;
            objinvoiceData.sellerContactPersonName = objEInvoiceGeneralsInfo.SellerContactPersonName;
            //objinvoiceData.sellerCreatedInvoicePersonName = objEInvoiceSellersInfo.SellerCreatedInvoicePersonName;
            objinvoiceData.sellerSignedPersonName = objEInvoiceGeneralsInfo.SellerSignedPersonName;
            objinvoiceData.sellerSubmittedPersonName = objEInvoiceGeneralsInfo.SellerSubmittedPersonName;
            objinvoiceData.buyerLegalName = objEInvoiceGeneralsInfo.BuyerLegalName;
            objinvoiceData.buyerTaxCode = objEInvoiceGeneralsInfo.BuyerTaxCode;
            objinvoiceData.buyerFaxNumber = objEInvoiceGeneralsInfo.BuyerFaxNumber;
            objinvoiceData.buyerEmail = objEInvoiceGeneralsInfo.BuyerEmail;

            objinvoiceData.items = items.ToArray();

            objinvoiceData.invoiceTaxBreakdowns = invoiceTaxBreakdowns.ToArray();

            objinvoiceData.sumOfTotalLineAmountWithoutVAT = FomatPrice(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT);
            objinvoiceData.totalAmountWithoutVAT = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            objinvoiceData.totalVATAmount = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
            objinvoiceData.totalAmountWithVAT = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT);
            objinvoiceData.totalAmountWithVATInWords = objEInvoiceGeneralsInfo.TotalAmountWithVATInWords;
            objinvoiceData.buyerTaxCode = "0107001729";
            if (objEInvoiceGeneralsInfo.AdjustmentType == 5)
            {
                objinvoiceData.isTotalAmountPos = objEInvoiceGeneralsInfo.IsTotalAmountPos == true ? "true" : "false";
                objinvoiceData.isTotalAmtWithoutVatPos = objEInvoiceGeneralsInfo.IsTotalAmtWithoutVatPos == true ? "true" : "false";
                objinvoiceData.isTotalVATAmountPos = objEInvoiceGeneralsInfo.IsTotalVATAmountPos == true ? "true" : "false";
                objinvoiceData.isDiscountAmtPos = objEInvoiceGeneralsInfo.IsDiscountAmtPos == true ? "true" : "false";
            }

            objInvoiceModel.invoiceData = objinvoiceData;
            controlData objcontrolData = new controlData();
            objcontrolData.systemCode = "LHD_TEST";
            objInvoiceModel.controlData = objcontrolData;

            objinvoiceData.signedDate = FomatDateTime(DateTime.Now);
            objinvoiceData.submittedDate = FomatDateTime(DateTime.Now);

            string invoiceXml = XmlHelper.ObjectToXml(objInvoiceModel);

            string signature = GetSignature(invoiceXml);
            //string signature = System.IO.File.ReadAllText(@"E:\Signature.txt");

            invoiceXml = invoiceXml.Replace("</inv:controlData>", "</inv:controlData>" + signature);

            string xmlOut = string.Format(CommonLocalizedResources.EInvoiceXmlTemplate, 0, invoiceXml);

            var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrlEInvoice"]);
            var request = new RestRequest("/van-service/services/invoice/certify/v1", Method.POST);
            request.AddHeader("Accept", "text/html;charset=UTF-8");
            request.AddHeader("Content-Type", "text/html;charset=UTF-8");
            request.AddHeader("Authorization", "Basic TEhEMDQwMTY5NTg2Mzp4eCMjQExIRDA0MDE2OTU4NjNAMjAxODEwMTIxMDIwNTc=");
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback
            (
                delegate { return true; }
            );
            //string xmlstr = System.IO.File.ReadAllText(@"E:\EInvoice.txt");
            xmlOut = XmlHelper.StripXmlWhitespace(xmlOut);
            request.AddParameter("text/xml;charset=utf-8", xmlOut, RestSharp.ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response.Content);
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.GetElementsByTagName("inv:error");
                if (nodes[0] != null)
                {
                    nodes = root.GetElementsByTagName("inv:code");
                    MessageBox.Show("Mã lỗi:" + nodes[0].InnerXml, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    nodes = root.GetElementsByTagName("inv:certifiedData");
                    String certifiedData = nodes[0].OuterXml;

                    certifiedData = Regex.Replace(certifiedData, @"(<\s*\/?)\s*(\w+):(\w+)", "$1$3");
                    certifiedData objcertifiedData = XmlHelper.XmlToObject<certifiedData>(certifiedData);

                    ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();

                    objEInvoiceGeneralsInfo.SellerTaxCode = objcertifiedData.sellerTaxCode;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objcertifiedData.buyerTaxCode;
                    objEInvoiceGeneralsInfo.TotalAmount = decimal.Parse(objcertifiedData.totalAmount);
                    objEInvoiceGeneralsInfo.TotalVATAmount = decimal.Parse(objcertifiedData.totalVATAmount);
                    objEInvoiceGeneralsInfo.IssuedDate = ParseStringDateTimeToDateTime(objcertifiedData.issuedDate);
                    objEInvoiceGeneralsInfo.SellerSignatureHash = objcertifiedData.sellerSignatureHash;
                    objEInvoiceGeneralsInfo.OriginalCertifiedId = objcertifiedData.originalCertifiedId;
                    objEInvoiceGeneralsInfo.CertifiedId = objcertifiedData.certifiedId;
                    objEInvoiceGeneralsInfo.CertifiedDate = ParseStringDateTimeToDateTime(objcertifiedData.certifiedDate);
                    objEInvoiceGeneralsInfo.Signature = objcertifiedData.signature;
                    objEInvoiceGeneralsInfo.PublicKey = objcertifiedData.publicKey;

                    nodes = root.GetElementsByTagName("inv:invoiceNumber");
                    objEInvoiceGeneralsInfo.InvoiceNumber = nodes[0].InnerXml;
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = EInvoiceGeneralStatus.Completed.ToString();

                    objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                    if (objEInvoiceGeneralsInfo.AdjustmentType != 7)
                    {
                        ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                        ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objEInvoiceGeneralsInfo.InvoiceType);
                        objEInvoiceTypesInfo.ACEInvoiceTypeStart += 1;
                        objEInvoiceTypesController.UpdateObject(objEInvoiceTypesInfo);
                        return true;
                    }
                }
            }
            return false;
        }

        public static String GetInvoiceNumber(String eInvoiceTypeNo)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(eInvoiceTypeNo);
            if (objEInvoiceTypesInfo == null)
                return String.Empty;

            return objEInvoiceTypesInfo.ACEInvoiceTypeStart.ToString().PadLeft(objEInvoiceTypesInfo.ACEInvoiceTypeLength, '0');
        }

        public static String GetSignature(String invoiceXml)
        {
            string xmlOut = string.Format(CommonLocalizedResources.EInvoiceXmlTemplate, 0, invoiceXml);

            string seriralNumber = SmartSignSignFile.GetCertification.GetSerial();
            string xmlout = SmartSignSignFile.SignXml.SignXMLFileBy(seriralNumber, invoiceXml, "seller", "#data");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlout);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.GetElementsByTagName("Signature");
            return nodes[0].OuterXml;
        }
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
        private static DateTime ParseStringDateTimeToDateTime(String strDateTime)
        {
            DateTime dateTime = DateTime.ParseExact(strDateTime, "yyyy-MM-ddTHH:mm:ss", null);

            return dateTime;
        }
        public static bool PublishInvWithToken(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = (List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID));

            string result = string.Empty;
            Invoices ImportInv = new Invoices();
            Inv objInvoiceModel = new Inv();
            Product objitem;
            List<Product> items = new List<Product>();
            eInvoiceDetails.ForEach(o =>
            {
                objitem = new Product();
                objitem.ProdName = o.ItemName;
                objitem.ProdUnit = o.UnitName;
                objitem.ProdQuantity = FomatQuantity(o.Quantity);
                objitem.ProdPrice = FomatPrice(o.UnitPrice);
                objitem.Amount = FomatPrice((o.Quantity * o.UnitPrice) + o.VatAmount);
                items.Add(objitem);
            });

            Invoice objinvoiceData = new Invoice();
            objinvoiceData.CusCode = objEInvoiceGeneralsInfo.BuyerCode;
            objinvoiceData.CusName = objEInvoiceGeneralsInfo.BuyerLegalName;
            objinvoiceData.CusAddress = objEInvoiceGeneralsInfo.BuyerAddressLine;
            objinvoiceData.CusPhone = objEInvoiceGeneralsInfo.BuyerPhoneNumber;
            objinvoiceData.CusTaxCode = objEInvoiceGeneralsInfo.BuyerTaxCode;
            objinvoiceData.PaymentMethod = objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName;
            objinvoiceData.PaymentStatus = objEInvoiceGeneralsInfo.PaymentStatus;
            objinvoiceData.KindOfService = objEInvoiceGeneralsInfo.CurrencyCode;
            objinvoiceData.Products = items.ToArray();
            objinvoiceData.Total = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            objinvoiceData.DiscountAmount = FomatPrice(objEInvoiceGeneralsInfo.DiscountAmount);
            objinvoiceData.VATAmount = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
            objinvoiceData.Amount = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT);
            objinvoiceData.AmountInWords = objEInvoiceGeneralsInfo.TotalAmountWithVATInWords;
            objinvoiceData.EmailDeliver = objEInvoiceGeneralsInfo.BuyerEmail;
            objinvoiceData.SMSDeliver = objEInvoiceGeneralsInfo.BuyerPhoneNumber;
            objInvoiceModel.Invoice = objinvoiceData;
            objInvoiceModel.key = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID.ToString();
            ImportInv.Inv = objInvoiceModel;
            string invoiceXml = XmlHelper.ObjectToXml(ImportInv);
            invoiceXml = XmlHelper.StripXmlWhitespace(invoiceXml);
            ACEInvoiceConfigsInfo obj = GetAccountConfig();

            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objEInvoiceGeneralsInfo.InvoiceType);
            int lenght = 7;
            if (objEInvoiceTypesInfo != null) lenght = objEInvoiceTypesInfo.ACEInvoiceTypeLength;
            if (obj != null)
            {
                result = SignTokenCore.VNPTEInvoiceSignToken.PublishInvWithToken(
                      obj.ACEInvoiceConfigAccount
                    , obj.ACEInvoiceConfigACpass
                    , invoiceXml
                    , obj.ACEInvoiceConfigUsername
                    , obj.ACEInvoiceConfigPassword
                    , obj.ACEInvoiceConfigCertStr
                    , objEInvoiceGeneralsInfo.TemplateCode
                    , objEInvoiceGeneralsInfo.InvoiceSeries
                    , obj.ACEInvoiceConfigLinkWS);

                if (!result.Contains("ERR:") && result.Contains("OK:"))
                {
                    string[] inv1 = result.Split(',');
                    if (inv1 != null && inv1.Length > 0)
                    {
                        string[] rep = inv1[0].Split('-');
                        if (rep != null && rep.Length > 0)
                        {

                            string[] InvoiceNo = rep[1].Split('_');
                            if (InvoiceNo != null && InvoiceNo.Length > 0)
                            {
                                objEInvoiceGeneralsInfo.PublicKey = InvoiceNo[0];
                                if (InvoiceNo.Length > 1)
                                    objEInvoiceGeneralsInfo.InvoiceNumber = InvoiceNo[1] != null ? InvoiceNo[1].PadLeft(lenght, '0') : InvoiceNo[1];
                                objEInvoiceGeneralsInfo.SubmittedDate = DateTime.Now;
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "Value1";
                                (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    string mes = GetErrorMessage(result);
                    MessageBox.Show(mes, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
        public static bool AdjustReplaceInvWithToken(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, ACEInvoiceGeneralsInfo replaceInv, int type)
        {
            bool result = false;
            //int type = 1; //thay thế= 1, điều chỉnh tăng = 2, điều chỉnh giảm = 3, điều chỉnh thông tin = 4
            string xmlInvData = string.Empty; //chuỗi xml hóa đơn mới
            string invToken = string.Empty; //chuỗi token hóa đơn = mẫu số;kýhiệu;sốhóa đơn (ví dụ: 01GTKT0/001;AA/17E;1)
            invToken = replaceInv.TemplateCode + ";" + replaceInv.InvoiceSeries + ";" + replaceInv.InvoiceNumber;

            #region Info Invoice
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = (List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID));
            Invoices ImportInv = new Invoices();
            Inv objInvoiceModel = new Inv();
            Product objitem;
            List<Product> items = new List<Product>();
            eInvoiceDetails.ForEach(o =>
            {
                objitem = new Product();
                objitem.ProdName = o.ItemName;
                objitem.ProdUnit = o.UnitName;
                objitem.ProdQuantity = FomatQuantity(o.Quantity);
                objitem.ProdPrice = FomatPrice(o.UnitPrice);
                objitem.Amount = FomatPrice((o.Quantity * o.UnitPrice) + o.VatAmount);
                items.Add(objitem);
            });

            Invoice objinvoiceData = new Invoice();
            objinvoiceData.CusCode = objEInvoiceGeneralsInfo.BuyerCode;
            objinvoiceData.CusName = objEInvoiceGeneralsInfo.BuyerLegalName;
            objinvoiceData.CusAddress = objEInvoiceGeneralsInfo.BuyerAddressLine;
            objinvoiceData.CusPhone = objEInvoiceGeneralsInfo.BuyerPhoneNumber;
            objinvoiceData.CusTaxCode = objEInvoiceGeneralsInfo.BuyerTaxCode;
            objinvoiceData.PaymentMethod = objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName;
            objinvoiceData.PaymentStatus = objEInvoiceGeneralsInfo.PaymentStatus;
            objinvoiceData.KindOfService = objEInvoiceGeneralsInfo.CurrencyCode;
            objinvoiceData.Products = items.ToArray();
            objinvoiceData.Total = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            objinvoiceData.DiscountAmount = FomatPrice(objEInvoiceGeneralsInfo.DiscountAmount);
            objinvoiceData.VATAmount = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
            objinvoiceData.Amount = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT);
            objinvoiceData.AmountInWords = objEInvoiceGeneralsInfo.TotalAmountWithVATInWords;
            objinvoiceData.EmailDeliver = objEInvoiceGeneralsInfo.BuyerEmail;
            objinvoiceData.SMSDeliver = objEInvoiceGeneralsInfo.BuyerPhoneNumber;
            objInvoiceModel.Invoice = objinvoiceData;
            objInvoiceModel.key = objEInvoiceGeneralsInfo.PublicKey;
            ImportInv.Inv = objInvoiceModel;
            string invoiceXml = XmlHelper.ObjectToXml(ImportInv);
            xmlInvData = XmlHelper.StripXmlWhitespace(invoiceXml);
            #endregion

            ACEInvoiceConfigsInfo obj = GetAccountConfig();
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objEInvoiceGeneralsInfo.InvoiceType);
            int lenght = 7;
            if (objEInvoiceTypesInfo != null) lenght = objEInvoiceTypesInfo.ACEInvoiceTypeLength;
            if (obj != null)
            {
                string rv = SignTokenCore.VNPTEInvoiceSignToken.AdjustReplaceInvWithToken( //Account, ACpass, xmlInvData, username, password, serialCert, type, invToken, pattern, serial, linkWS);
                    obj.ACEInvoiceConfigAccount
                    , obj.ACEInvoiceConfigACpass
                    , xmlInvData
                    , obj.ACEInvoiceConfigUsername
                    , obj.ACEInvoiceConfigPassword
                    , obj.ACEInvoiceConfigCertStr
                    , type
                    , invToken
                    , objEInvoiceGeneralsInfo.TemplateCode
                    , objEInvoiceGeneralsInfo.InvoiceSeries
                    , obj.ACEInvoiceConfigLinkWS);
                if (!rv.Contains("ERR:") && rv.Contains("OK:"))
                {
                    string[] inv1 = rv.Split(',');
                    if (inv1 != null && inv1.Length > 0)
                    {
                        string[] rep = inv1[0].Split(';');
                        if (rep != null && rep.Length > 1)
                        {

                            string[] InvoiceNo = rep[2].Split('_');
                            if (InvoiceNo != null && InvoiceNo.Length > 0)
                            {
                                objEInvoiceGeneralsInfo.PublicKey = InvoiceNo[0];
                                if (InvoiceNo.Length > 1)
                                    objEInvoiceGeneralsInfo.InvoiceNumber = InvoiceNo[1] != null ? InvoiceNo[1].PadLeft(lenght, '0') : InvoiceNo[1];
                                string status = "Value4";
                                if (type == 1)
                                    status = "Value3";
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = status;
                                (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    string mes = GetErrorMessage(rv);
                    MessageBox.Show(mes, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return result;
        }
        public static bool CancelInvoiceWithToken(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            bool result = false;
            //int type = 1; //thay thế= 1, điều chỉnh tăng = 2, điều chỉnh giảm = 3, điều chỉnh thông tin = 4
            //string xmlInvData = string.Empty; //chuỗi xml hóa đơn mới
            //string invToken = string.Empty; //chuỗi token hóa đơn = mẫu số;kýhiệu;sốhóa đơn (ví dụ: 01GTKT0/001;AA/17E;1)

            #region Info Invoice
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = (List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID));
            CInvoices ImportInv = new CInvoices();
            InvC objInvoiceModel = new InvC();
            objInvoiceModel.Serial = objEInvoiceGeneralsInfo.InvoiceSeries;
            objInvoiceModel.InvNo = objEInvoiceGeneralsInfo.InvoiceNumber;

            ImportInv.Inv = objInvoiceModel;
            string invoiceXml = XmlHelper.ObjectToXml(ImportInv);
            string xmlInvData = XmlHelper.StripXmlWhitespace(invoiceXml);
            #endregion

            ACEInvoiceConfigsInfo obj = GetAccountConfig();
            if (obj != null)
            {
                string rv = SignTokenCore.VNPTEInvoiceSignToken.CancelInvoiceWithToken( //Account, ACpass, xmlInvData, username, password, serialCert, type, invToken, pattern, serial, linkWS);
                    obj.ACEInvoiceConfigAccount
                    , obj.ACEInvoiceConfigACpass
                    , xmlInvData
                    , obj.ACEInvoiceConfigUsername
                    , obj.ACEInvoiceConfigPassword
                    , objEInvoiceGeneralsInfo.TemplateCode
                    , obj.ACEInvoiceConfigLinkWS);
                if (!rv.Contains("ERR:") && rv.Contains("OK"))
                {
                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "Value5";
                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                    return true;
                }
                else
                {
                    string mes = GetErrorMessage(rv);
                    MessageBox.Show(mes, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return result;
        }
        public static string GetErrorMessage(string result)
        {
            string error = string.Empty;

            if (result.Contains("ERR:"))
            {
                //string errorNo = rep[1];
                string errorNo = result;

                if (result.Contains("ERR:-3"))
                    error = "Có lỗi trong quá trình lấy chứng thư";
                else if (result.Contains("ERR:-2"))
                    error = "Chứng thư không có private key";
                else if (result.Contains("ERR:-1"))
                    error = "Ấn nút hủy khi nhập mã pin của chứng thư";
                else if (result.Contains("ERR:1"))
                    error = "Không có quyền truy cập webservice";
                else if (result.Contains("ERR:2"))
                    error = "Không tồn tại hoá đơn cần thay thế/điều chỉnh";
                else if (result.Contains("ERR:3"))
                    error = "Định dạng file xml hóa đơn không đúng";
                else if (result.Contains("ERR:4"))
                    error = "Token hóa đơn sai định dạng";
                else if (result.Contains("ERR:5"))
                    error = "Có lỗi xảy ra";
                else if (result.Contains("ERR:6"))
                    error = "Không còn đủ số hóa đơn cho lô phát hành";
                else if (result.Contains("ERR:7"))
                    error = "Không tìm thấy chứng thư trong máy. Hãy cắm token";
                else if (result.Contains("ERR:8"))
                    error = "Hoá đơn đã được điều chỉnh, thay thế";
                else if (result.Contains("ERR:10"))
                    error = "Số lượng hóa đơn truyền vào lớn hơn maxBlockInv";
                else if (result.Contains("ERR:19"))
                    error = "pattern truyền vào không giống với pattern của hoá đơn cần điều chỉnh/thay thế";
                else if (result.Contains("ERR:20"))
                    error = "Tham số mẫu số và ký hiệu truyền vào không hợp lệ";
                else if (result.Contains("ERR:21"))
                    error = "Không tìm thấy công ty trên hệ thống";
                else if (result.Contains("ERR:22"))
                    error = "Công ty chưa đăng ký thông tin keystore";
                else if (result.Contains("ERR:23"))
                    error = "Chứng thư truyền lên không đúng định dạng";
                else if (result.Contains("ERR:24"))
                    error = "Chứng thư truyền lên không đúng với chứng thư công ty đăng ký trên hệ thống";
                else if (result.Contains("ERR:26"))
                    error = "Chứng thư đã hết hạn";
                else if (result.Contains("ERR:27"))
                    error = "Chứng thư chưa đến thời điểm sử dụng";
                else if (result.Contains("ERR:28"))
                    error = "Thông tin chứng thư chưa có trong hệ thống";
                else if (result.Contains("ERR:30"))
                    error = "Tạo mới lô hóa đơn lỗi (fkey trùng,...)";
                else
                    error = result;
            }
            else
                error = result;
            return error;
        }
        public static bool ImportInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = (List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID));

            string result = string.Empty;
            BOSERP.Utilities.IPInvoices.IPInvoices ImportInv = new BOSERP.Utilities.IPInvoices.IPInvoices();
            BOSERP.Utilities.IPInvoices.IPInv objInvoiceModel = new BOSERP.Utilities.IPInvoices.IPInv();
            BOSERP.Utilities.IPInvoices.Product objitem;
            List<BOSERP.Utilities.IPInvoices.Product> items = new List<BOSERP.Utilities.IPInvoices.Product>();
            //Products product = new Products();
            eInvoiceDetails.ForEach(o =>
            {
                objitem = new BOSERP.Utilities.IPInvoices.Product();
                objitem.Code = o.ItemCode;
                objitem.ProdName = o.ItemName;
                objitem.ProdUnit = o.UnitName;
                objitem.ProdQuantity = FomatQuantity(o.Quantity);
                objitem.ProdPrice = FomatPrice(o.UnitPrice);
                objitem.Total = FomatPrice(o.Quantity * o.UnitPrice);
                objitem.VATRate = FomatPrice(o.VatPercentage);
                objitem.VATAmount = FomatPrice(o.VatAmount);
                objitem.Amount = FomatPrice((o.Quantity * o.UnitPrice) + o.VatAmount);
                items.Add(objitem);
            });

            //product.Product = items.ToArray();

            BOSERP.Utilities.IPInvoices.IPInvoice objinvoiceData = new BOSERP.Utilities.IPInvoices.IPInvoice();
            objinvoiceData.OrderNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo;
            objinvoiceData.OrderDate = FomatDateTime(objEInvoiceGeneralsInfo.InvoiceIssuedDate);
            objinvoiceData.CusCode = objEInvoiceGeneralsInfo.BuyerCode;
            objinvoiceData.CusCom = objEInvoiceGeneralsInfo.BuyerDisplayName;
            objinvoiceData.CusName = objEInvoiceGeneralsInfo.BuyerLegalName;
            objinvoiceData.CusAddress = objEInvoiceGeneralsInfo.BuyerAddressLine;
            objinvoiceData.CusPhone = objEInvoiceGeneralsInfo.BuyerPhoneNumber;
            objinvoiceData.CusTaxCode = objEInvoiceGeneralsInfo.BuyerTaxCode;
            objinvoiceData.PaymentMethod = objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName;

            objinvoiceData.Products = items.ToArray();

            objinvoiceData.GrossValue = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            if (objEInvoiceGeneralsInfo.TaxOfficeCode == "0%")
            {
                objinvoiceData.VatAmount0 = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
                objinvoiceData.GrossValue0 = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            }
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "5%")
            {
                objinvoiceData.VatAmount5 = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
                objinvoiceData.GrossValue5 = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            }
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "10%")
            {
                objinvoiceData.VatAmount10 = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
                objinvoiceData.GrossValue10 = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            }
            else if (objEInvoiceGeneralsInfo.TaxOfficeCode == "8%")
            {
                objinvoiceData.VatAmount8 = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
                objinvoiceData.GrossValue8 = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            }
            else
            {
                objinvoiceData.VatAmount0 = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
                objinvoiceData.GrossValue0 = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            }
            objinvoiceData.Total = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithoutVAT);
            objinvoiceData.VATAmount = FomatPrice(objEInvoiceGeneralsInfo.TotalVATAmount);
            objinvoiceData.Amount = FomatPrice(objEInvoiceGeneralsInfo.TotalAmountWithVAT);
            objinvoiceData.AmountInWords = objEInvoiceGeneralsInfo.TotalAmountWithVATInWords;
            objinvoiceData.EmailDeliver = objEInvoiceGeneralsInfo.BuyerEmail;
            objinvoiceData.SMSDeliver = objEInvoiceGeneralsInfo.BuyerPhoneNumber;
            objInvoiceModel.Invoice = objinvoiceData;
            objInvoiceModel.key = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID.ToString();
            ImportInv.Inv = objInvoiceModel;
            string invoiceXml = XmlHelper.ObjectToXml(ImportInv);
            invoiceXml = XmlHelper.StripXmlWhitespace(invoiceXml);
            ACEInvoiceConfigsInfo obj = GetAccountConfig();
            if (obj != null)
            {
                result = SignTokenCore.VNPTEInvoiceSignToken.importInv(
                      obj.ACEInvoiceConfigUsername
                    , obj.ACEInvoiceConfigPassword
                    , invoiceXml
                    , obj.ACEInvoiceConfigLinkWS);

                if (!result.Contains("ERR:") && result.Contains("OK:"))
                {
                    string[] rep = result.Split(';');
                    if (rep != null && rep.Length > 0)
                    {

                        for (int i = 0; i < rep.Length; i++)
                        {
                            if (rep[i] != null && !rep[i].Contains("OK"))
                            {
                                string[] InvoiceNo = rep[i].Split('-');
                                if (InvoiceNo != null && InvoiceNo.Length > 0)
                                {
                                    if (InvoiceNo.Length > 1)
                                        objEInvoiceGeneralsInfo.PublicKey = InvoiceNo[1];

                                    objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "Value0";
                                    (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);

                                    if (InvoiceNo.Length == 1)
                                    {
                                        MessageBox.Show("Đã chuyển dữ liệu thành công nhưng chưa phát hành HD: " + result, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //return false;
                                    }

                                }

                            }
                        }
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi:" + result, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
        public static bool GetHashInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, string fkey)
        {
            string result = string.Empty;

            HashInv hashInv = new HashInv();
            Haskey key = new Haskey();
            key.key = fkey;
            hashInv.Inv = key;
            string invoiceXml = XmlHelper.ObjectToXml(hashInv);
            string xmlInvData = XmlHelper.StripXmlWhitespace(invoiceXml);
            ACEInvoiceConfigsInfo obj = GetAccountConfig();
            if (obj != null)
            {
                result = SignTokenCore.VNPTEInvoiceSignToken.getHashInv(
                      obj.ACEInvoiceConfigAccount
                    , obj.ACEInvoiceConfigACpass
                    , obj.ACEInvoiceConfigUsername
                    , obj.ACEInvoiceConfigPassword
                    , obj.ACEInvoiceConfigCertStr
                    , xmlInvData
                    , objEInvoiceGeneralsInfo.TemplateCode
                    , obj.ACEInvoiceConfigLinkWS);
                if (!result.Contains("ERR:"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(result);
                    XmlElement root = doc.DocumentElement;
                    XmlNodeList nodes = root.GetElementsByTagName("Inv");

                    //Result:
                    //    <Invoices>
                    //    <Inv>
                    //    <key>123</key>
                    //    <idInv>128668</idInv>
                    //    <hashValue>J2k7CsSN9Gb6PmsHD9yDJS1/j3s=</hashValue>
                    //    <pattern>01GTKT0/001</pattern>
                    //    <serial>AA/17E</serial>
                    //    </Inv>
                    //    </Invoices>

                    if (nodes[0] != null)
                    {
                        String hashInvData = string.Empty;
                        for (int i = 0; i < nodes[0].ChildNodes.Count; i++)
                        {
                            if (nodes[0].ChildNodes.Item(i).Name == "key")
                            {
                                objEInvoiceGeneralsInfo.PublicKey = nodes[0].ChildNodes.Item(i).InnerText;
                            }
                            if (nodes[0].ChildNodes.Item(i).Name == "idInv")
                            {
                                objEInvoiceGeneralsInfo.SystemCode = nodes[0].ChildNodes.Item(i).InnerText;
                            }
                            if (nodes[0].ChildNodes.Item(i).Name == "hashValue")
                            {
                                objEInvoiceGeneralsInfo.SellerSignatureHash = nodes[0].ChildNodes.Item(i).InnerText;
                            }
                        }
                        //hashInvData = Regex.Replace(hashInvData, @"(<\s*\/?)\s*(\w+):(\w+)", "$1$3");
                        //HashInvData objData = XmlHelper.XmlToObject<HashInvData>(hashInvData);
                        //if (objData != null)
                        //{
                        //    objEInvoiceGeneralsInfo.InvoiceNumber = objData.idInv;
                        //    objEInvoiceGeneralsInfo.PublicKey = objData.key;
                        //    objEInvoiceGeneralsInfo.SellerSignatureHash = objData.hashValue;

                        //}
                        (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                    }
                    else
                    {
                        MessageBox.Show("Không lấy được dữ liệu hash", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    string mes = GetErrorMessage(result);
                    MessageBox.Show(mes, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
        public static bool GetStatusInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, string fkey)
        {
            string result = string.Empty;

            HashInv hashInv = new HashInv();
            Haskey key = new Haskey();
            key.key = fkey;
            hashInv.Inv = key;
            string invoiceXml = XmlHelper.ObjectToXml(hashInv);
            string xmlInvData = XmlHelper.StripXmlWhitespace(invoiceXml);
            ACEInvoiceConfigsInfo obj = GetAccountConfig();
            if (obj != null)
            {
                result = SignTokenCore.VNPTEInvoiceSignToken.getStatusInv(
                      obj.ACEInvoiceConfigAccount
                    , obj.ACEInvoiceConfigACpass
                    , obj.ACEInvoiceConfigUsername
                    , obj.ACEInvoiceConfigPassword
                    //, obj.ACEInvoiceConfigCertStr
                    , xmlInvData
                    , objEInvoiceGeneralsInfo.TemplateCode
                    , obj.ACEInvoiceConfigLinkWS);
                if (!result.Contains("ERR:"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(result);
                    XmlElement root = doc.DocumentElement;
                    XmlNodeList nodes = root.GetElementsByTagName("Inv");

                    //Result:
                    //    <Invoices>
                    //    <Inv>
                    //    <key>123</key>
                    //    <idInv>128668</idInv>
                    //    <hashValue>J2k7CsSN9Gb6PmsHD9yDJS1/j3s=</hashValue>
                    //    <pattern>01GTKT0/001</pattern>
                    //    <serial>AA/17E</serial>
                    //    </Inv>
                    //    </Invoices>

                    if (nodes[0] != null)
                    {
                        //String hashInvData = nodes[0].InnerText;

                        //hashInvData = Regex.Replace(hashInvData, @"(<\s*\/?)\s*(\w+):(\w+)", "$1$3");
                        //StatusInvData objData = XmlHelper.XmlToObject<StatusInvData>(hashInvData);
                        for (int i = 0; i < nodes[0].ChildNodes.Count; i++)
                        {
                            if (nodes[0].ChildNodes.Item(i).Name == "key")
                            {
                                objEInvoiceGeneralsInfo.PublicKey = nodes[0].ChildNodes.Item(i).InnerText;
                            }
                            if (nodes[0].ChildNodes.Item(i).Name == "Status")
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = GetStringStatus(nodes[0].ChildNodes.Item(i).InnerText);
                            }

                        }
                        (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                    }
                    else
                    {
                        MessageBox.Show("Không lấy được trạng thái!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    string mes = GetErrorMessage(result);
                    MessageBox.Show(mes, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
        public static string GetStringStatus(string value)
        {
            string result = "New";
            switch (value)
            {
                // 0: hóa đơn mới tạo, chưa phát hành (những hóa đơn cần lấy lại hash)1: hóa đơn đã phát hành2: hóa đơn đã được kê khai thuếcũng như đưa vào các phần mêm kếtoán3: hóa đơn bịthay thế4: hóa đơn bịđiều chỉnh5: hóa đơn hủy
                case "0":
                    result = "Value0";
                    break;
                case "1":
                    result = "Value1";
                    break;
                case "2":
                    result = "Value2";
                    break;
                case "3":
                    result = "Value3";
                    break;
                case "4":
                    result = "Value4";
                    break;
                case "5":
                    result = "Value5";
                    break;

                default:
                    break;
            }
            return result;
        }
        public static string GetKindOfService(string curencyNo)
        {
            string result = string.Empty;
            switch (curencyNo)
            {
                case "VND":
                    result = "Hoá đơn Việt Nam đồng";
                    break;
                case "USD":
                    result = "Hoá đơn Đô-la Mỹ";
                    break;
                case "EURO":
                    result = "Hoá đơn EURO";
                    break;
                default:
                    result = "Hoá đơn Việt Nam đồng";
                    break;
            }
            return result;
        }
        public static bool PublishInv(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            string result = string.Empty;
            //stringrv = SignTokenCore.VNPTEInvoiceSignToken.PublishInv(Account, ACpass, xmlHash, username, password, serialCert, pattern, serial, linkWS);
            PublicInv pubInv = new PublicInv();
            HashInvData key = new HashInvData();
            key.key = objEInvoiceGeneralsInfo.PublicKey;
            key.idInv = objEInvoiceGeneralsInfo.SystemCode;
            key.hashValue = objEInvoiceGeneralsInfo.SellerSignatureHash;
            pubInv.Inv = key;
            string invoiceXml = XmlHelper.ObjectToXml(pubInv);
            string xmlHash = XmlHelper.StripXmlWhitespace(invoiceXml);
            ACEInvoiceConfigsInfo obj = GetAccountConfig();
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objEInvoiceGeneralsInfo.InvoiceType);
            int lenght = 7;
            if (objEInvoiceTypesInfo != null) lenght = objEInvoiceTypesInfo.ACEInvoiceTypeLength;
            if (obj != null)
            {
                result = SignTokenCore.VNPTEInvoiceSignToken.PublishInv(
                      obj.ACEInvoiceConfigAccount
                    , obj.ACEInvoiceConfigACpass
                    , xmlHash
                    , obj.ACEInvoiceConfigUsername
                    , obj.ACEInvoiceConfigPassword
                    , obj.ACEInvoiceConfigCertStr
                    , objEInvoiceGeneralsInfo.TemplateCode
                    , objEInvoiceGeneralsInfo.InvoiceSeries
                    , obj.ACEInvoiceConfigLinkWS);
                if (!result.Contains("ERR:") && result.Contains("OK:"))
                {
                    string[] inv1 = result.Split(',');
                    if (inv1 != null && inv1.Length > 0)
                    {
                        string[] rep = inv1[0].Split('-');
                        if (rep != null && rep.Length > 0)
                        {

                            string[] InvoiceNo = rep[1].Split('_');
                            if (InvoiceNo != null && InvoiceNo.Length > 0)
                            {
                                objEInvoiceGeneralsInfo.PublicKey = InvoiceNo[0];
                                if (InvoiceNo.Length > 1)
                                    objEInvoiceGeneralsInfo.InvoiceNumber = InvoiceNo[1] != null ? InvoiceNo[1].PadLeft(lenght, '0') : InvoiceNo[1];
                                objEInvoiceGeneralsInfo.SubmittedDate = DateTime.Now;
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "Value1";
                                (new ACEInvoiceGeneralsController()).UpdateObject(objEInvoiceGeneralsInfo);
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    string mes = GetErrorMessage(result);
                    MessageBox.Show(mes, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
    }
}