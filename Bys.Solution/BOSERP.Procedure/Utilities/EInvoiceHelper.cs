using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Utilities
{
    public static class EInvoiceHelper
    {
        #region ARInvoices
        public static void ToEInvoice(ARInvoicesInfo objInvoicesInfo, List<ARInvoiceItemsInfo> invoiceItems)
        {
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = objEInvoiceGeneralsController.CheckExistsInvoiceGeneralByInvoiceID(objInvoicesInfo.ARInvoiceID);
            if(objEInvoiceGeneralsInfo != null)
            {
                MessageBox.Show(string.Format("Hóa đơn này đã được gộp trong Hóa đơn điện tử [{0}] nên không thể chuyển dữ liệu!", objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo)
                                + Environment.NewLine + "Vui lòng kiểm tra lại!",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            objEInvoiceGeneralsInfo = objEInvoiceGeneralsController.GetEInvoiceGeneralByNo(objInvoicesInfo.ARInvoiceNo);
            if (objEInvoiceGeneralsInfo != null)
            {
                if (String.IsNullOrEmpty(objEInvoiceGeneralsInfo.PublicKey))
                {
                    //Cập nhật hóa đơn điện tử
                    UpdateEInvoice(objEInvoiceGeneralsInfo, objInvoicesInfo, invoiceItems);
                    return;
                }
                else
                {
                    // Hóa đơn đã xóa hoặc hủy
                    if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value4.ToString()
                        || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value3.ToString())
                    {
                        if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionCreateEInvoice,
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã hủy)";
                            objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                            CreateEInvoice(objInvoicesInfo, invoiceItems, false, null);
                        }
                        return;
                    }
                    else
                    {
                        //Lấy trạng thái hóa đơn
                        ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(objEInvoiceGeneralsInfo.FK_ACTaxUnitID);
                        bkavEInvoiceHelper.GetInfoEInvoiceBKAV(objEInvoiceGeneralsInfo);

                        //Hóa đơn đã xóa hoặc hủy
                        if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value4.ToString()
                            || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value3.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionCreateEInvoice,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã hủy)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objInvoicesInfo, invoiceItems, false, null);
                            }
                            return;
                        }
                        //Hóa đơn Chờ ký / Mới Tạo
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value11.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value1.ToString())
                        {
                            UpdateEInvoice(objEInvoiceGeneralsInfo, objInvoicesInfo, invoiceItems);
                            return;
                        }
                        // Không cho cập nhật 
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value5.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value7.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value9.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value10.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value12.ToString())
                        {
                            MessageBox.Show(ElectronicInvoiceLocalizedResources.NotUpdateEInvoice,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Hóa đơn đã phát hành
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value2.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue2,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã thay thế)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objInvoicesInfo, invoiceItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value6.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue6,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã thay thế)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objInvoicesInfo, invoiceItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value8.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue8,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã điều chỉnh)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objInvoicesInfo, invoiceItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                    }
                }
            }
            else
            {
                CreateEInvoice(objInvoicesInfo, invoiceItems, false, null);
            }
        }

        public static void CreateEInvoice(ARInvoicesInfo objInvoicesInfo, List<ARInvoiceItemsInfo> invoiceItems, bool isDuplicate, string oldInvoiceNumber)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objInvoicesInfo.FK_ACEInvoiceTypeID);
            if (objEInvoiceTypesInfo == null)
            {
                MessageBox.Show(ElectronicInvoiceLocalizedResources.ErrorVATInvoiceNoCombo, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = new ACEInvoiceGeneralsInfo();
            GenarateEInvoiceGeneral(objEInvoiceGeneralsInfo, objInvoicesInfo, isDuplicate, oldInvoiceNumber);
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = GenarateEInvoiceDetail(objEInvoiceGeneralsInfo, objInvoicesInfo, invoiceItems);
            decimal vatPercen = 0;
            if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType3.ToString())
            {
                vatPercen = 5;             
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType4.ToString())
            {
                vatPercen = 8;                
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType6.ToString())
            {
                vatPercen = 10;                
            }
            else
            {
                vatPercen = 0;
            }
            objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT = Math.Round(eInvoiceDetails.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.DiscountAmount = Math.Round((objInvoicesInfo.ARInvoiceDiscountFix + invoiceItems.Sum(o => o.ARInvoiceItemDiscountAmount) * objInvoicesInfo.ARInvoiceExchangeRate), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalVATAmount = Math.Round((objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT - objEInvoiceGeneralsInfo.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithoutVAT = objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT + objEInvoiceGeneralsInfo.TotalVATAmount;
            objEInvoiceGeneralsInfo.TotalAmountWithVAT = Math.Round(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT
                                                                    - objEInvoiceGeneralsInfo.DiscountAmount
                                                                    + objEInvoiceGeneralsInfo.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(objEInvoiceGeneralsInfo.TotalAmountWithVAT.ToString(), objEInvoiceGeneralsInfo.FK_GECurrencyID);
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralType = EInvoiceGeneralType.Original.ToString();

            #region Save
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            objEInvoiceGeneralsController.CreateObject(objEInvoiceGeneralsInfo);

            if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralID > 0)
            {
                eInvoiceDetails.ForEach(o =>
                    {
                        o.FK_ACEInvoiceGeneralID = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID;
                        objEInvoiceDetailsController.CreateObject(o);
                    });
            }
            #endregion

            MessageBox.Show(ElectronicInvoiceLocalizedResources.CreateSuccess,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowElectronicInvoiceScreen(objEInvoiceGeneralsInfo);
        }

        public static void UpdateEInvoice(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, ARInvoicesInfo objInvoicesInfo, List<ARInvoiceItemsInfo> invoiceItems)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objInvoicesInfo.FK_ACEInvoiceTypeID);
            if (objEInvoiceTypesInfo == null)
            {
                MessageBox.Show(ElectronicInvoiceLocalizedResources.ErrorVATInvoiceNoCombo,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #region Create EInvoiceGenerals
            objEInvoiceGeneralsInfo.SellerAppRecordId = objInvoicesInfo.ARInvoiceNo;
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objInvoicesInfo.ARInvoiceNo;
            objEInvoiceGeneralsInfo.InvoiceType = objEInvoiceTypesInfo.ACEInvoiceTypeNo;
            objEInvoiceGeneralsInfo.TemplateCode = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
            objEInvoiceGeneralsInfo.InvoiceSeries = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            objEInvoiceGeneralsInfo.InvoiceName = objEInvoiceTypesInfo.ACEInvoiceTypeName;
            objEInvoiceGeneralsInfo.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            objEInvoiceGeneralsInfo.ContractNumber = objInvoicesInfo.ARInvoicePONo;
            objEInvoiceGeneralsInfo.ContractDate = objInvoicesInfo.ARInvoiceDate;
            objEInvoiceGeneralsInfo.FK_ACObjectID = objInvoicesInfo.FK_ACObjectID;
            objEInvoiceGeneralsInfo.ACObjectType = objInvoicesInfo.ARObjectType;
            objEInvoiceGeneralsInfo.FK_GECurrencyID = GECurrencyID.VND;
            objEInvoiceGeneralsInfo.FK_ACTaxUnitID = objInvoicesInfo.FK_ACTaxUnitID;
            if(objEInvoiceGeneralsInfo.FK_ACTaxUnitID <= 0)
            {
                ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
                List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
                if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
                {
                    objEInvoiceGeneralsInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
                }
            }    
            //objEInvoiceGeneralsInfo.InvoiceNumber = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objEInvoiceGeneralsInfo.ReferModuleName = "Invoice";
            objEInvoiceGeneralsInfo.PaymentStatus = "Hóa đơn chưa thanh toán";

            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objInvoicesInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeCreateInvoiceName = objEmployeesInfo.HREmployeeName;
            }
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeUpLoadDataToEInvoiceName = objEmployeesInfo.HREmployeeName;
            }

            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)(new GECurrenciesController()).GetObjectByID(GECurrencyID.VND);
            if (objCurrenciesInfo != null)
            {
                objEInvoiceGeneralsInfo.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
                objEInvoiceGeneralsInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
            }
            objEInvoiceGeneralsInfo.ExchangeRate = 1;
            objEInvoiceGeneralsInfo.InvoiceNote = objInvoicesInfo.ARInvoiceDesc;
            objEInvoiceGeneralsInfo.AdjustmentType = 1;
            objEInvoiceGeneralsInfo.BuyerTaxCode = objInvoicesInfo.ARInvoiceTaxNumber;

            ACEInvoicePaymentMethodsInfo objEConfig = (ACEInvoicePaymentMethodsInfo)(new ACEInvoicePaymentMethodsController()).GetObjectByNo(objInvoicesInfo.ARPaymentMethodCombo);
            if (objEConfig != null)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = objEConfig.ACEInvoicePaymentMethodName;

            if (objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName == string.Empty)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = "Thanh toán tiền mặt";
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                objEInvoiceGeneralsInfo.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                objEInvoiceGeneralsInfo.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                objEInvoiceGeneralsInfo.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                objEInvoiceGeneralsInfo.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                objEInvoiceGeneralsInfo.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                objEInvoiceGeneralsInfo.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                objEInvoiceGeneralsInfo.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                objEInvoiceGeneralsInfo.SellerEmail = objCompanysInfo.CSCompanyEmail;
                objEInvoiceGeneralsInfo.SellerBankName = objCompanysInfo.CSCompanyBankName;
                objEInvoiceGeneralsInfo.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
            }

            #region Get Customer info            
            if (objInvoicesInfo.ARObjectType == ObjectType.Customer.ToString())
            {
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objInvoicesInfo.FK_ACObjectID);
                if (objCustomersInfo != null)
                {
                    if (objCustomersInfo.ARCustomerTypeCombo != string.Empty)
                    {
                        objEInvoiceGeneralsInfo.BuyerType = ADConfigValueUtility.GetConfigTextByGroupAndValue("CustomerType", objCustomersInfo.ARCustomerTypeCombo);
                    }
                    objEInvoiceGeneralsInfo.BuyerLegalName = objCustomersInfo.ARCustomerName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objCustomersInfo.ARCustomerTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objCustomersInfo.ARCustomerInvoiceAddressLine1;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objCustomersInfo.ARCustomerContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objCustomersInfo.ARCustomerContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objCustomersInfo.ARCustomerContactEmail1;
                    objEInvoiceGeneralsInfo.BuyerCode = objCustomersInfo.ARCustomerNo;
                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    }
                }
            }
            else
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
                if (objObjectsInfo != null)
                {
                    //objEInvoiceGeneralsInfo.BuyerDisplayName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerLegalName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                    GEDistrictsInfo objDistrictsInfo =
                    (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    GEStateProvincesInfo objStateProvincesInfo =
                    (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                    objEInvoiceGeneralsInfo.BuyerCode = objObjectsInfo.ACObjectNo;
                }
            }
            #endregion
            #endregion

            #region Create Details
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            objEInvoiceDetailsController.DeleteByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = new List<ACEInvoiceDetailsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo;
            ICMeasureUnitsInfo objMeasureUnitsInfo;
            ICProductsInfo objProductsInfo;
            int lineNumber = 1;
            invoiceItems.ForEach(o =>
            {
                objEInvoiceDetailsInfo = new ACEInvoiceDetailsInfo();
                objEInvoiceDetailsInfo.LineNumber = lineNumber;
                objEInvoiceDetailsInfo.OrderIndex = lineNumber;
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                }
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)(objMeasureUnitsController.GetObjectByID(o.FK_ICMeasureUnitID));
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = string.IsNullOrWhiteSpace(objMeasureUnitsInfo.ICMeasureUnitDesc)? objMeasureUnitsInfo.ICMeasureUnitName: objMeasureUnitsInfo.ICMeasureUnitDesc;
                    objEInvoiceDetailsInfo.UnitName = string.IsNullOrWhiteSpace(objMeasureUnitsInfo.ICMeasureUnitDesc) ? objMeasureUnitsInfo.ICMeasureUnitName : objMeasureUnitsInfo.ICMeasureUnitDesc;
                }
                objEInvoiceDetailsInfo.ItemName = o.ARInvoiceItemProductName2;
                //objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARInvoiceItemProductUnitPrice * (1 - o.ARInvoiceItemProductDiscount / 100), 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARInvoiceItemProductUnitPrice * objInvoicesInfo.ARInvoiceExchangeRate, 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.Quantity = Math.Round(o.ARInvoiceItemProductQty, 3, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.VatPercentage = objInvoicesInfo.ARInvoiceTaxPercent;
                objEInvoiceDetailsInfo.VatAmount = (objEInvoiceDetailsInfo.UnitPrice * objEInvoiceDetailsInfo.Quantity) * objEInvoiceDetailsInfo.VatPercentage / 100;
                objEInvoiceDetailsInfo.Promotion = false;
                objEInvoiceDetailsInfo.ACEInvoiceDetailModuleName = ModuleName.Invoice;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceID = o.FK_ARInvoiceID;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceNo = string.IsNullOrWhiteSpace(o.ARInvoiceNo) ? objInvoicesInfo.ARInvoiceNo : o.ARInvoiceNo;
                objEInvoiceDetailsInfo.ACEInvoiceDetailRefItemID = o.ARInvoiceItemID;

                //ACEInvoiceDetailsInfo checkEInvoiceDetailsInfo = eInvoiceDetails.Where(p => p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //                                                                             && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //                                                                             && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //                                                                             && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //                                                                             && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent).FirstOrDefault();
                //if (checkEInvoiceDetailsInfo != null)
                //{
                //    eInvoiceDetails.ForEach(p =>
                //    {
                //        if (p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //            && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //            && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //            && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //            && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent)
                //        {
                //            p.Quantity += objEInvoiceDetailsInfo.Quantity;
                //            p.VatAmount = (p.UnitPrice * p.Quantity) * p.VatPercentage / 100;
                //        }
                //    });
                //}
                //else
                //{
                    eInvoiceDetails.Add(objEInvoiceDetailsInfo);
                //}
                lineNumber++;
            });

            decimal vatPercen = 0;
            if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType2.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType3.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
                vatPercen = 5;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 5;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType4.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
                vatPercen = 8;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 8;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType6.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
                vatPercen = 10;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 10;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "Không thuế GTGT";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT = Math.Round(eInvoiceDetails.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.DiscountAmount = Math.Round((objInvoicesInfo.ARInvoiceDiscountFix + invoiceItems.Sum(o => o.ARInvoiceItemDiscountAmount)) * objInvoicesInfo.ARInvoiceExchangeRate, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalVATAmount = Math.Round((objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT - objEInvoiceGeneralsInfo.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithoutVAT = objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT + objEInvoiceGeneralsInfo.TotalVATAmount;
            objEInvoiceGeneralsInfo.TotalAmountWithVAT = Math.Round(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT
                                                                    - objEInvoiceGeneralsInfo.DiscountAmount
                                                                    + objEInvoiceGeneralsInfo.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(objEInvoiceGeneralsInfo.TotalAmountWithVAT.ToString(), objEInvoiceGeneralsInfo.FK_GECurrencyID);
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralType = EInvoiceGeneralType.Original.ToString();
            #endregion

            #region Save
            objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);

            if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralID > 0)
            {
                eInvoiceDetails.ForEach(o =>
                {
                    o.FK_ACEInvoiceGeneralID = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID;
                    objEInvoiceDetailsController.CreateObject(o);
                });
            }
            #endregion

            MessageBox.Show(ElectronicInvoiceLocalizedResources.UpdateSuccess,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowElectronicInvoiceScreen(objEInvoiceGeneralsInfo);
        }
        #endregion

        #region ACRetailVATs
        public static void ToEInvoice(ACRetailVATsInfo objRetailVATsInfo, List<ACRetailVATItemsInfo> retailVATItems)
        {
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = objEInvoiceGeneralsController.GetEInvoiceGeneralByNo(objRetailVATsInfo.ACRetailVATNo);
            if (objEInvoiceGeneralsInfo != null)
            {
                if (String.IsNullOrEmpty(objEInvoiceGeneralsInfo.PublicKey))
                {
                    //Cập nhật hóa đơn điện tử
                    UpdateEInvoice(objEInvoiceGeneralsInfo, objRetailVATsInfo, retailVATItems);
                    return;
                }
                else
                {
                    // Hóa đơn đã xóa hoặc hủy
                    if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value4.ToString()
                        || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value3.ToString())
                    {
                        if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionCreateEInvoice,
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã hủy)";
                            objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                            CreateEInvoice(objRetailVATsInfo, retailVATItems, false, null);
                        }
                        return;
                    }
                    else
                    {
                        //Lấy trạng thái hóa đơn
                        ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(objEInvoiceGeneralsInfo.FK_ACTaxUnitID);
                        bkavEInvoiceHelper.GetInfoEInvoiceBKAV(objEInvoiceGeneralsInfo);

                        //Hóa đơn đã xóa hoặc hủy
                        if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value4.ToString()
                            || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value3.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionCreateEInvoice,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã hủy)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objRetailVATsInfo, retailVATItems, false, null);
                            }
                            return;
                        }
                        //Hóa đơn Chờ ký / Mới Tạo
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value11.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value1.ToString())
                        {
                            UpdateEInvoice(objEInvoiceGeneralsInfo, objRetailVATsInfo, retailVATItems);
                            return;
                        }
                        // Không cho cập nhật 
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value5.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value7.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value9.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value10.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value12.ToString())
                        {
                            MessageBox.Show(ElectronicInvoiceLocalizedResources.NotUpdateEInvoice,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Hóa đơn đã phát hành
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value2.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue2,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã thay thế)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objRetailVATsInfo, retailVATItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value6.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue6,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã thay thế)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objRetailVATsInfo, retailVATItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value8.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue8,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã điều chỉnh)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objRetailVATsInfo, retailVATItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                    }
                }
            }
            else
            {
                CreateEInvoice(objRetailVATsInfo, retailVATItems, false, null);
            }
        }

        public static void CreateEInvoice(ACRetailVATsInfo objRetailVATsInfo, List<ACRetailVATItemsInfo> retailVATItems, bool isDuplicate, string oldInvoiceNumber)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objRetailVATsInfo.FK_ACEInvoiceTypeID);
            if (objEInvoiceTypesInfo == null)
            {
                MessageBox.Show(ElectronicInvoiceLocalizedResources.ErrorVATInvoiceNoCombo, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #region Create EInvoiceGenerals
            ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = new ACEInvoiceGeneralsInfo();
            objEInvoiceGeneralsInfo.SellerAppRecordId = objRetailVATsInfo.ACRetailVATNo;
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objRetailVATsInfo.ACRetailVATNo;
            objEInvoiceGeneralsInfo.InvoiceType = objEInvoiceTypesInfo.ACEInvoiceTypeNo;
            objEInvoiceGeneralsInfo.TemplateCode = string.IsNullOrEmpty(objRetailVATsInfo.ACRetailVATVATFormNo) ? objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode : objRetailVATsInfo.ACRetailVATVATFormNo;
            objEInvoiceGeneralsInfo.InvoiceSeries = string.IsNullOrEmpty(objRetailVATsInfo.ACRetailVATVATSymbol) ? objEInvoiceTypesInfo.ACEInvoiceTypeSeries : objRetailVATsInfo.ACRetailVATVATSymbol;
            objEInvoiceGeneralsInfo.InvoiceName = objEInvoiceTypesInfo.ACEInvoiceTypeName;
            objEInvoiceGeneralsInfo.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            objEInvoiceGeneralsInfo.ContractNumber = string.Empty;
            objEInvoiceGeneralsInfo.ContractDate = objRetailVATsInfo.ACRetailVATDate;
            objEInvoiceGeneralsInfo.FK_ACObjectID = objRetailVATsInfo.FK_ACObjectID;
            objEInvoiceGeneralsInfo.ACObjectType = objRetailVATsInfo.ARObjectType;
            objEInvoiceGeneralsInfo.FK_GECurrencyID = objRetailVATsInfo.FK_GECurrencyID;
            objEInvoiceGeneralsInfo.FK_ACTaxUnitID = objRetailVATsInfo.FK_ACTaxUnitID;
            if (objEInvoiceGeneralsInfo.FK_ACTaxUnitID <= 0)
            {
                ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
                List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
                if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
                {
                    objEInvoiceGeneralsInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
                }
            }
            //objEInvoiceGeneralsInfo.InvoiceNumber = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objEInvoiceGeneralsInfo.AdditionalReferenceDate = (DateTime)SqlDateTime.MinValue;
            objEInvoiceGeneralsInfo.ReferModuleName = ModuleName.RetailVAT;
            objEInvoiceGeneralsInfo.PaymentStatus = "Hóa đơn bán lẻ";

            if (isDuplicate)
            {
                objEInvoiceGeneralsInfo.OriginalInvoiceId = oldInvoiceNumber;
                objEInvoiceGeneralsInfo.PublicKey = string.Empty;
                objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "New";
                objEInvoiceGeneralsInfo.SubmittedDate = DateTime.MaxValue;
                objEInvoiceGeneralsInfo.InvoiceNumber = string.Empty;
                objEInvoiceGeneralsInfo.SystemCode = string.Empty;
                objEInvoiceGeneralsInfo.SellerSignatureHash = string.Empty;
            }

            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objRetailVATsInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeCreateInvoiceName = objEmployeesInfo.HREmployeeName;
            }
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeUpLoadDataToEInvoiceName = objEmployeesInfo.HREmployeeName;
            }

            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)(new GECurrenciesController()).GetObjectByID(objRetailVATsInfo.FK_GECurrencyID);
            if (objCurrenciesInfo != null)
            {
                objEInvoiceGeneralsInfo.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
                objEInvoiceGeneralsInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
            }
            objEInvoiceGeneralsInfo.ExchangeRate = objRetailVATsInfo.ACRetailVATExchangeRate;
            objEInvoiceGeneralsInfo.InvoiceNote = objRetailVATsInfo.ACRetailVATDesc;
            objEInvoiceGeneralsInfo.AdjustmentType = 1;
            objEInvoiceGeneralsInfo.BuyerTaxCode = objRetailVATsInfo.ACRetailVATTaxNumber;

            ACEInvoicePaymentMethodsInfo objEConfig = (ACEInvoicePaymentMethodsInfo)(new ACEInvoicePaymentMethodsController()).GetObjectByNo(objRetailVATsInfo.ARPaymentMethodCombo);
            if (objEConfig != null)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = objEConfig.ACEInvoicePaymentMethodName;

            if (objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName == string.Empty)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = "Thanh toán tiền mặt";
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                objEInvoiceGeneralsInfo.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                objEInvoiceGeneralsInfo.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                objEInvoiceGeneralsInfo.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                objEInvoiceGeneralsInfo.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                objEInvoiceGeneralsInfo.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                objEInvoiceGeneralsInfo.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                objEInvoiceGeneralsInfo.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                objEInvoiceGeneralsInfo.SellerEmail = objCompanysInfo.CSCompanyEmail;
                objEInvoiceGeneralsInfo.SellerBankName = objCompanysInfo.CSCompanyBankName;
                objEInvoiceGeneralsInfo.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
            }
            #region Get Customer info            
            if (objRetailVATsInfo.ARObjectType == ObjectType.Customer.ToString())
            {
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objRetailVATsInfo.FK_ACObjectID);
                if (objCustomersInfo != null)
                {
                    if (objCustomersInfo.ARCustomerTypeCombo != string.Empty)
                    {
                        objEInvoiceGeneralsInfo.BuyerType = ADConfigValueUtility.GetConfigTextByGroupAndValue("CustomerType", objCustomersInfo.ARCustomerTypeCombo);
                    }
                    objEInvoiceGeneralsInfo.BuyerLegalName = objCustomersInfo.ARCustomerName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objCustomersInfo.ARCustomerTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objCustomersInfo.ARCustomerInvoiceAddressLine1;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objCustomersInfo.ARCustomerContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objCustomersInfo.ARCustomerContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objCustomersInfo.ARCustomerContactEmail1;
                    objEInvoiceGeneralsInfo.BuyerCode = objCustomersInfo.ARCustomerNo;
                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    }
                }
            }
            else
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objRetailVATsInfo.FK_ACObjectID, objRetailVATsInfo.ARObjectType);
                if (objObjectsInfo != null)
                {
                    //objEInvoiceGeneralsInfo.BuyerDisplayName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerLegalName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                    GEDistrictsInfo objDistrictsInfo =
                    (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    GEStateProvincesInfo objStateProvincesInfo =
                    (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                    objEInvoiceGeneralsInfo.BuyerCode = objObjectsInfo.ACObjectNo;
                }
            }
            #endregion

            #region Get default Customer Bank
            if (objRetailVATsInfo.ACRetailVATTaxNumber != string.Empty)
                objEInvoiceGeneralsInfo.BuyerTaxCode = objRetailVATsInfo.ACRetailVATTaxNumber;
            List<ACListAccountBanksInfo> listBank = (new ACListAccountBanksController()).GetListByACObject(objRetailVATsInfo.FK_ACObjectID, objRetailVATsInfo.ARObjectType);
            if (listBank != null && listBank.Count > 0)
            {
                objEInvoiceGeneralsInfo.BuyerBankName = listBank[0].ACListAccountBankName;
                objEInvoiceGeneralsInfo.BuyerBankAccount = listBank[0].ACListAccountBankAccountHolder;
                objEInvoiceGeneralsInfo.BuyerBankNumber = listBank[0].ACListAccountBankAccount;
            }
            #endregion
            #endregion

            #region Create Details
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = new List<ACEInvoiceDetailsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo;
            ICMeasureUnitsInfo objMeasureUnitsInfo;
            ICProductsInfo objProductsInfo;
            int lineNumber = 1;
            retailVATItems.ForEach(o =>
            {
                objEInvoiceDetailsInfo = new ACEInvoiceDetailsInfo();
                objEInvoiceDetailsInfo.LineNumber = lineNumber;
                objEInvoiceDetailsInfo.OrderIndex = lineNumber;
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                }
                objEInvoiceDetailsInfo.ItemName = o.ACRetailVATItemProductName2;
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)(objMeasureUnitsController.GetObjectByID(o.FK_ICMeasureUnitID));
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = objMeasureUnitsInfo.ICMeasureUnitName.Substring(0, 1).ToUpper();
                    objEInvoiceDetailsInfo.UnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                }
                //objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARInvoiceItemProductUnitPrice * (1 - o.ARInvoiceItemProductDiscount / 100), 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ACRetailVATItemProductUnitPrice, 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.Quantity = Math.Round(o.ACRetailVATItemProductQty, 3, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.VatPercentage = objRetailVATsInfo.ACRetailVATTaxPercent;
                if(objEInvoiceDetailsInfo.VatPercentage == 0)
                {
                    objEInvoiceDetailsInfo.VatPercentage = o.ACRetailVATItemProductTaxPercent;
                }    
                objEInvoiceDetailsInfo.VatAmount = (objEInvoiceDetailsInfo.UnitPrice * objEInvoiceDetailsInfo.Quantity) * objEInvoiceDetailsInfo.VatPercentage / 100;
                objEInvoiceDetailsInfo.Promotion = false;
                objEInvoiceDetailsInfo.ACEInvoiceDetailModuleName = ModuleName.RetailVAT;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceID = objRetailVATsInfo.ACRetailVATID;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceNo = objRetailVATsInfo.ACRetailVATNo;
                objEInvoiceDetailsInfo.ACEInvoiceDetailRefItemID = o.ACRetailVATItemID;

                //ACEInvoiceDetailsInfo checkEInvoiceDetailsInfo = eInvoiceDetails.Where(p => p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //                                                                         && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //                                                                         && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //                                                                         && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //                                                                         && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent).FirstOrDefault();
                //if (checkEInvoiceDetailsInfo != null)
                //{
                //    eInvoiceDetails.ForEach(p =>
                //    {
                //        if (p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //            && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //            && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //            && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //            && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent)
                //        {
                //            p.Quantity += objEInvoiceDetailsInfo.Quantity;
                //            p.VatAmount = (p.UnitPrice * p.Quantity) * p.VatPercentage / 100;
                //        }
                //    });
                //}
                //else
                //{
                    eInvoiceDetails.Add(objEInvoiceDetailsInfo);
                //}
                lineNumber++;
            });

            decimal vatPercen = 0;
            if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType2.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType3.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
                vatPercen = 5;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 5;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType4.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
                vatPercen = 8;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 8;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType6.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
                vatPercen = 10;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 10;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "Không thuế GTGT";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT = Math.Round(eInvoiceDetails.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.DiscountAmount = Math.Round(objRetailVATsInfo.ACRetailVATDiscountAmount + retailVATItems.Sum(o => o.ACRetailVATItemDiscountAmount), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalVATAmount = Math.Round((objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT - objEInvoiceGeneralsInfo.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithoutVAT = objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT + objEInvoiceGeneralsInfo.TotalVATAmount;
            objEInvoiceGeneralsInfo.TotalAmountWithVAT = Math.Round(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT
                                                                    - objEInvoiceGeneralsInfo.DiscountAmount
                                                                    + objEInvoiceGeneralsInfo.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(objEInvoiceGeneralsInfo.TotalAmountWithVAT.ToString(), objRetailVATsInfo.FK_GECurrencyID);
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralType = EInvoiceGeneralType.Original.ToString();
            #endregion

            #region Save
            objEInvoiceGeneralsController.CreateObject(objEInvoiceGeneralsInfo);

            if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralID > 0)
            {
                eInvoiceDetails.ForEach(o =>
                {
                    o.FK_ACEInvoiceGeneralID = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID;
                    objEInvoiceDetailsController.CreateObject(o);
                });
            }
            #endregion

            MessageBox.Show(ElectronicInvoiceLocalizedResources.CreateSuccess,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowElectronicInvoiceScreen(objEInvoiceGeneralsInfo);
        }

        public static void UpdateEInvoice(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, ACRetailVATsInfo objRetailVATsInfo, List<ACRetailVATItemsInfo> retailVATItems)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objRetailVATsInfo.FK_ACEInvoiceTypeID);
            if (objEInvoiceTypesInfo == null)
            {
                MessageBox.Show(ElectronicInvoiceLocalizedResources.ErrorVATInvoiceNoCombo,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #region Create EInvoiceGenerals
            objEInvoiceGeneralsInfo.SellerAppRecordId = objRetailVATsInfo.ACRetailVATNo;
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objRetailVATsInfo.ACRetailVATNo;
            objEInvoiceGeneralsInfo.InvoiceType = objEInvoiceTypesInfo.ACEInvoiceTypeNo;
            objEInvoiceGeneralsInfo.TemplateCode = string.IsNullOrEmpty(objRetailVATsInfo.ACRetailVATVATFormNo) ? objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode : objRetailVATsInfo.ACRetailVATVATFormNo;
            objEInvoiceGeneralsInfo.InvoiceSeries = string.IsNullOrEmpty(objRetailVATsInfo.ACRetailVATVATSymbol) ? objEInvoiceTypesInfo.ACEInvoiceTypeSeries : objRetailVATsInfo.ACRetailVATVATSymbol;
            objEInvoiceGeneralsInfo.InvoiceName = objEInvoiceTypesInfo.ACEInvoiceTypeName;
            objEInvoiceGeneralsInfo.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            objEInvoiceGeneralsInfo.ContractNumber = string.Empty;
            objEInvoiceGeneralsInfo.ContractDate = objRetailVATsInfo.ACRetailVATDate;
            objEInvoiceGeneralsInfo.FK_ACObjectID = objRetailVATsInfo.FK_ACObjectID;
            objEInvoiceGeneralsInfo.ACObjectType = objRetailVATsInfo.ARObjectType;
            objEInvoiceGeneralsInfo.FK_GECurrencyID = objRetailVATsInfo.FK_GECurrencyID;
            objEInvoiceGeneralsInfo.FK_ACTaxUnitID = objRetailVATsInfo.FK_ACTaxUnitID;
            if (objEInvoiceGeneralsInfo.FK_ACTaxUnitID <= 0)
            {
                ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
                List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
                if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
                {
                    objEInvoiceGeneralsInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
                }
            }
            //objEInvoiceGeneralsInfo.InvoiceNumber = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objEInvoiceGeneralsInfo.ReferModuleName = "Invoice";
            objEInvoiceGeneralsInfo.PaymentStatus = "Hóa đơn chưa thanh toán";

            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objRetailVATsInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeCreateInvoiceName = objEmployeesInfo.HREmployeeName;
            }
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeUpLoadDataToEInvoiceName = objEmployeesInfo.HREmployeeName;
            }

            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)(new GECurrenciesController()).GetObjectByID(objRetailVATsInfo.FK_GECurrencyID);
            if (objCurrenciesInfo != null)
            {
                objEInvoiceGeneralsInfo.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
                objEInvoiceGeneralsInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
            }
            objEInvoiceGeneralsInfo.ExchangeRate = objRetailVATsInfo.ACRetailVATExchangeRate;
            objEInvoiceGeneralsInfo.InvoiceNote = objRetailVATsInfo.ACRetailVATDesc;
            objEInvoiceGeneralsInfo.AdjustmentType = 1;
            objEInvoiceGeneralsInfo.BuyerTaxCode = objRetailVATsInfo.ACRetailVATTaxNumber;

            ACEInvoicePaymentMethodsInfo objEConfig = (ACEInvoicePaymentMethodsInfo)(new ACEInvoicePaymentMethodsController()).GetObjectByNo(objRetailVATsInfo.ARPaymentMethodCombo);
            if (objEConfig != null)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = objEConfig.ACEInvoicePaymentMethodName;

            if (objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName == string.Empty)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = "Thanh toán tiền mặt";
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                objEInvoiceGeneralsInfo.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                objEInvoiceGeneralsInfo.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                objEInvoiceGeneralsInfo.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                objEInvoiceGeneralsInfo.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                objEInvoiceGeneralsInfo.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                objEInvoiceGeneralsInfo.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                objEInvoiceGeneralsInfo.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                objEInvoiceGeneralsInfo.SellerEmail = objCompanysInfo.CSCompanyEmail;
                objEInvoiceGeneralsInfo.SellerBankName = objCompanysInfo.CSCompanyBankName;
                objEInvoiceGeneralsInfo.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
            }

            #region Get Customer info            
            if (objRetailVATsInfo.ARObjectType == ObjectType.Customer.ToString())
            {
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objRetailVATsInfo.FK_ACObjectID);
                if (objCustomersInfo != null)
                {
                    if (objCustomersInfo.ARCustomerTypeCombo != string.Empty)
                    {
                        objEInvoiceGeneralsInfo.BuyerType = ADConfigValueUtility.GetConfigTextByGroupAndValue("CustomerType", objCustomersInfo.ARCustomerTypeCombo);
                    }
                    objEInvoiceGeneralsInfo.BuyerLegalName = objCustomersInfo.ARCustomerName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objCustomersInfo.ARCustomerTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objCustomersInfo.ARCustomerInvoiceAddressLine1;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objCustomersInfo.ARCustomerContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objCustomersInfo.ARCustomerContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objCustomersInfo.ARCustomerContactEmail1;
                    objEInvoiceGeneralsInfo.BuyerCode = objCustomersInfo.ARCustomerNo;
                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    }
                }
            }
            else
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objRetailVATsInfo.FK_ACObjectID, objRetailVATsInfo.ARObjectType);
                if (objObjectsInfo != null)
                {
                    //objEInvoiceGeneralsInfo.BuyerDisplayName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerLegalName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                    GEDistrictsInfo objDistrictsInfo =
                    (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    GEStateProvincesInfo objStateProvincesInfo =
                    (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                    objEInvoiceGeneralsInfo.BuyerCode = objObjectsInfo.ACObjectNo;
                }
            }
            #endregion
            #endregion

            #region Create Details
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            objEInvoiceDetailsController.DeleteByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = new List<ACEInvoiceDetailsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo;
            ICMeasureUnitsInfo objMeasureUnitsInfo;
            ICProductsInfo objProductsInfo;
            int lineNumber = 1;
            retailVATItems.ForEach(o =>
            {
                objEInvoiceDetailsInfo = new ACEInvoiceDetailsInfo();
                objEInvoiceDetailsInfo.LineNumber = lineNumber;
                objEInvoiceDetailsInfo.OrderIndex = lineNumber;
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                }
                objEInvoiceDetailsInfo.ItemName = o.ACRetailVATItemProductName2;
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)(objMeasureUnitsController.GetObjectByID(o.FK_ICMeasureUnitID));
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = objMeasureUnitsInfo.ICMeasureUnitName;
                    objEInvoiceDetailsInfo.UnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                }
                //objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARInvoiceItemProductUnitPrice * (1 - o.ARInvoiceItemProductDiscount / 100), 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ACRetailVATItemProductUnitPrice, 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.Quantity = Math.Round(o.ACRetailVATItemProductQty, 3, MidpointRounding.AwayFromZero);                
                objEInvoiceDetailsInfo.VatPercentage = objRetailVATsInfo.ACRetailVATTaxPercent;
                if (objEInvoiceDetailsInfo.VatPercentage == 0)
                {
                    objEInvoiceDetailsInfo.VatPercentage = o.ACRetailVATItemProductTaxPercent;
                }
                objEInvoiceDetailsInfo.VatAmount = (objEInvoiceDetailsInfo.UnitPrice * objEInvoiceDetailsInfo.Quantity) * objEInvoiceDetailsInfo.VatPercentage / 100;
                objEInvoiceDetailsInfo.Promotion = false;
                objEInvoiceDetailsInfo.ACEInvoiceDetailModuleName = ModuleName.RetailVAT;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceID = objRetailVATsInfo.ACRetailVATID;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceNo = objRetailVATsInfo.ACRetailVATNo;
                objEInvoiceDetailsInfo.ACEInvoiceDetailRefItemID = o.ACRetailVATItemID;

                //ACEInvoiceDetailsInfo checkEInvoiceDetailsInfo = eInvoiceDetails.Where(p => p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //                                                                            && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //                                                                            && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //                                                                            && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //                                                                            && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent).FirstOrDefault();
                //if (checkEInvoiceDetailsInfo != null)
                //{
                //    eInvoiceDetails.ForEach(p =>
                //    {
                //        if (p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //            && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //            && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //            && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //            && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent)
                //        {
                //            p.Quantity += objEInvoiceDetailsInfo.Quantity;
                //            p.VatAmount = (p.UnitPrice * p.Quantity) * p.VatPercentage / 100;
                //        }
                //    });
                //}
                //else
                //{
                    eInvoiceDetails.Add(objEInvoiceDetailsInfo);
                //}
                lineNumber++;
            });

            decimal vatPercen = 0;
            if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType2.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType3.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
                vatPercen = 5;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 5;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType4.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
                vatPercen = 8;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 8;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else if (objRetailVATsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType6.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
                vatPercen = 10;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 10;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            else
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "Không thuế GTGT";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
                });
            }
            objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT = Math.Round(eInvoiceDetails.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.DiscountAmount = Math.Round(objRetailVATsInfo.ACRetailVATDiscountAmount + retailVATItems.Sum(o => o.ACRetailVATItemDiscountAmount), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalVATAmount = Math.Round((objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT - objEInvoiceGeneralsInfo.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithoutVAT = objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT + objEInvoiceGeneralsInfo.TotalVATAmount;
            objEInvoiceGeneralsInfo.TotalAmountWithVAT = Math.Round(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT
                                                                    - objEInvoiceGeneralsInfo.DiscountAmount
                                                                    + objEInvoiceGeneralsInfo.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(objEInvoiceGeneralsInfo.TotalAmountWithVAT.ToString(), objRetailVATsInfo.FK_GECurrencyID);
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralType = EInvoiceGeneralType.Original.ToString();
            #endregion

            #region Save
            objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);

            if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralID > 0)
            {
                eInvoiceDetails.ForEach(o =>
                {
                    o.FK_ACEInvoiceGeneralID = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID;
                    objEInvoiceDetailsController.CreateObject(o);
                });
            }
            #endregion

            MessageBox.Show(ElectronicInvoiceLocalizedResources.UpdateSuccess,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowElectronicInvoiceScreen(objEInvoiceGeneralsInfo);
        }
        #endregion
        #region SaleReturn
        public static void ToEInvoice(ARSaleReturnsInfo objSaleReturnsInfo, List<ARSaleReturnItemsInfo> saleReturnItems)
        {
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = objEInvoiceGeneralsController.GetEInvoiceGeneralByNo(objSaleReturnsInfo.ARSaleReturnNo);
            if (objEInvoiceGeneralsInfo != null)
            {
                if (String.IsNullOrEmpty(objEInvoiceGeneralsInfo.PublicKey))
                {
                    //Cập nhật hóa đơn điện tử
                    UpdateEInvoice(objEInvoiceGeneralsInfo, objSaleReturnsInfo, saleReturnItems);
                    return;
                }
                else
                {
                    // Hóa đơn đã xóa hoặc hủy
                    if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value4.ToString()
                        || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value3.ToString())
                    {
                        if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionCreateEInvoice,
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã hủy)";
                            objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                            CreateEInvoice(objSaleReturnsInfo, saleReturnItems, false, null);
                        }
                        return;
                    }
                    else
                    {
                        //Lấy trạng thái hóa đơn
                        ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(objEInvoiceGeneralsInfo.FK_ACTaxUnitID);
                        bkavEInvoiceHelper.GetInfoEInvoiceBKAV(objEInvoiceGeneralsInfo);

                        //Hóa đơn đã xóa hoặc hủy
                        if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value4.ToString()
                            || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value3.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionCreateEInvoice,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã hủy)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objSaleReturnsInfo, saleReturnItems, false, null);
                            }
                            return;
                        }
                        //Hóa đơn Chờ ký / Mới Tạo
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value11.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value1.ToString())
                        {
                            UpdateEInvoice(objEInvoiceGeneralsInfo, objSaleReturnsInfo, saleReturnItems);
                            return;
                        }
                        // Không cho cập nhật 
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value5.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value7.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value9.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value10.ToString()
                                || objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value12.ToString())
                        {
                            MessageBox.Show(ElectronicInvoiceLocalizedResources.NotUpdateEInvoice,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Hóa đơn đã phát hành
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value2.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue2,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã thay thế)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objSaleReturnsInfo, saleReturnItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value6.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue6,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã thay thế)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objSaleReturnsInfo, saleReturnItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                        else if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value8.ToString())
                        {
                            if (MessageBox.Show(ElectronicInvoiceLocalizedResources.QuestionEInvoiceValue8,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo + " (Đã điều chỉnh)";
                                objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                                CreateEInvoice(objSaleReturnsInfo, saleReturnItems, true, objEInvoiceGeneralsInfo.InvoiceNumber);
                            }
                            return;
                        }
                    }
                }
            }
            else
            {
                CreateEInvoice(objSaleReturnsInfo, saleReturnItems, false, null);
            }
        }
        public static void CreateEInvoice(ARSaleReturnsInfo objSaleReturnsInfo, List<ARSaleReturnItemsInfo> saleReturnItemsInfo, bool isDuplicate, string oldInvoiceNumber)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            //ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objSaleReturnsInfo.FK_ACEInvoiceTypeID);
            //if (objEInvoiceTypesInfo == null)
            //{
            //    MessageBox.Show(ElectronicInvoiceLocalizedResources.ErrorVATInvoiceNoCombo, CommonLocalizedResources.MessageBoxDefaultCaption,
            //                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            #region Create EInvoiceGenerals
            ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = new ACEInvoiceGeneralsInfo();
            objEInvoiceGeneralsInfo.SellerAppRecordId = objSaleReturnsInfo.ARSaleReturnNo;
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objSaleReturnsInfo.ARSaleReturnNo;
            objEInvoiceGeneralsInfo.InvoiceType = string.Empty;
            objEInvoiceGeneralsInfo.TemplateCode = string.Empty;
            objEInvoiceGeneralsInfo.InvoiceSeries = string.Empty;
            objEInvoiceGeneralsInfo.InvoiceName = string.Empty;
            objEInvoiceGeneralsInfo.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            objEInvoiceGeneralsInfo.ContractNumber = string.Empty;
            objEInvoiceGeneralsInfo.ContractDate = objSaleReturnsInfo.ARSaleReturnTransferredDate;
            objEInvoiceGeneralsInfo.FK_ACObjectID = objSaleReturnsInfo.FK_ACObjectID;
            objEInvoiceGeneralsInfo.ACObjectType = objSaleReturnsInfo.ARObjectType;
            objEInvoiceGeneralsInfo.FK_GECurrencyID = objSaleReturnsInfo.FK_GECurrencyID;
            if (objEInvoiceGeneralsInfo.FK_ACTaxUnitID <= 0)
            {
                ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
                List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
                if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
                {
                    objEInvoiceGeneralsInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
                }
            }
            //objEInvoiceGeneralsInfo.InvoiceNumber = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objEInvoiceGeneralsInfo.AdditionalReferenceDate = (DateTime)SqlDateTime.MinValue;
            objEInvoiceGeneralsInfo.ReferModuleName = ModuleName.SaleReturn;
            objEInvoiceGeneralsInfo.PaymentStatus = "Hàng bán trả lại";

            if (isDuplicate)
            {
                objEInvoiceGeneralsInfo.OriginalInvoiceId = oldInvoiceNumber;
                objEInvoiceGeneralsInfo.PublicKey = string.Empty;
                objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "New";
                objEInvoiceGeneralsInfo.SubmittedDate = DateTime.MaxValue;
                objEInvoiceGeneralsInfo.InvoiceNumber = string.Empty;
                objEInvoiceGeneralsInfo.SystemCode = string.Empty;
                objEInvoiceGeneralsInfo.SellerSignatureHash = string.Empty;
            }

            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objSaleReturnsInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeCreateInvoiceName = objEmployeesInfo.HREmployeeName;
            }
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeUpLoadDataToEInvoiceName = objEmployeesInfo.HREmployeeName;
            }

            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)(new GECurrenciesController()).GetObjectByID(objSaleReturnsInfo.FK_GECurrencyID);
            if (objCurrenciesInfo != null)
            {
                objEInvoiceGeneralsInfo.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
                objEInvoiceGeneralsInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
            }
            objEInvoiceGeneralsInfo.ExchangeRate = objSaleReturnsInfo.ARSaleReturnExchangeRate;
            objEInvoiceGeneralsInfo.InvoiceNote = objSaleReturnsInfo.ARSaleReturnDesc;
            objEInvoiceGeneralsInfo.AdjustmentType = 1;
            objEInvoiceGeneralsInfo.BuyerTaxCode = objSaleReturnsInfo.ARSaleReturnTaxNumber;

            ACEInvoicePaymentMethodsInfo objEConfig = (ACEInvoicePaymentMethodsInfo)(new ACEInvoicePaymentMethodsController()).GetObjectByNo(objSaleReturnsInfo.ARPaymentMethodCombo);
            if (objEConfig != null)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = objEConfig.ACEInvoicePaymentMethodName;

            if (objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName == string.Empty)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = "Thanh toán tiền mặt";
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                objEInvoiceGeneralsInfo.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                objEInvoiceGeneralsInfo.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                objEInvoiceGeneralsInfo.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                objEInvoiceGeneralsInfo.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                objEInvoiceGeneralsInfo.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                objEInvoiceGeneralsInfo.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                objEInvoiceGeneralsInfo.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                objEInvoiceGeneralsInfo.SellerEmail = objCompanysInfo.CSCompanyEmail;
                objEInvoiceGeneralsInfo.SellerBankName = objCompanysInfo.CSCompanyBankName;
                objEInvoiceGeneralsInfo.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
            }
            #region Get Customer info            
            if (objSaleReturnsInfo.ARObjectType == ObjectType.Customer.ToString())
            {
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objSaleReturnsInfo.FK_ACObjectID);
                if (objCustomersInfo != null)
                {
                    if (objCustomersInfo.ARCustomerTypeCombo != string.Empty)
                    {
                        objEInvoiceGeneralsInfo.BuyerType = ADConfigValueUtility.GetConfigTextByGroupAndValue("CustomerType", objCustomersInfo.ARCustomerTypeCombo);
                    }
                    objEInvoiceGeneralsInfo.BuyerLegalName = objCustomersInfo.ARCustomerName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objCustomersInfo.ARCustomerTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objCustomersInfo.ARCustomerInvoiceAddressLine1;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objCustomersInfo.ARCustomerContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objCustomersInfo.ARCustomerContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objCustomersInfo.ARCustomerContactEmail1;
                    objEInvoiceGeneralsInfo.BuyerCode = objCustomersInfo.ARCustomerNo;
                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    }
                }
            }
            else
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objSaleReturnsInfo.FK_ACObjectID, objSaleReturnsInfo.ARObjectType);
                if (objObjectsInfo != null)
                {
                    //objEInvoiceGeneralsInfo.BuyerDisplayName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerLegalName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                    GEDistrictsInfo objDistrictsInfo =
                    (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    GEStateProvincesInfo objStateProvincesInfo =
                    (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                    objEInvoiceGeneralsInfo.BuyerCode = objObjectsInfo.ACObjectNo;
                }
            }
            #endregion

            #region Get default Customer Bank
            if (objSaleReturnsInfo.ARSaleReturnTaxNumber != string.Empty)
                objEInvoiceGeneralsInfo.BuyerTaxCode = objSaleReturnsInfo.ARSaleReturnTaxNumber;
            List<ACListAccountBanksInfo> listBank = (new ACListAccountBanksController()).GetListByACObject(objSaleReturnsInfo.FK_ACObjectID, objSaleReturnsInfo.ARObjectType);
            if (listBank != null && listBank.Count > 0)
            {
                objEInvoiceGeneralsInfo.BuyerBankName = listBank[0].ACListAccountBankName;
                objEInvoiceGeneralsInfo.BuyerBankAccount = listBank[0].ACListAccountBankAccountHolder;
                objEInvoiceGeneralsInfo.BuyerBankNumber = listBank[0].ACListAccountBankAccount;
            }
            #endregion
            #endregion

            #region Create Details
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = new List<ACEInvoiceDetailsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo;
            ICMeasureUnitsInfo objMeasureUnitsInfo;
            ICProductsInfo objProductsInfo;
            int lineNumber = 1;
            saleReturnItemsInfo.ForEach(o =>
            {
                objEInvoiceDetailsInfo = new ACEInvoiceDetailsInfo();
                objEInvoiceDetailsInfo.LineNumber = lineNumber;
                objEInvoiceDetailsInfo.OrderIndex = lineNumber;
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                    objEInvoiceDetailsInfo.ItemName = !string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName2 : o.ARSaleReturnItemProductName;
                }
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)(objMeasureUnitsController.GetObjectByID(o.FK_ICMeasureUnitID));
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = objMeasureUnitsInfo.ICMeasureUnitName.Substring(0, 1).ToUpper();
                    objEInvoiceDetailsInfo.UnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                }
                //objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARInvoiceItemProductUnitPrice * (1 - o.ARInvoiceItemProductDiscount / 100), 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARSaleReturnItemProductUnitPrice, 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.Quantity = Math.Round(-o.ARSaleReturnItemProductQty, 3, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.VatPercentage = objSaleReturnsInfo.ARSaleReturnTaxPercent;
                if (objEInvoiceDetailsInfo.VatPercentage == 0)
                {
                    objEInvoiceDetailsInfo.VatPercentage = o.ARSaleReturnItemProductTaxPercent;
                }
                objEInvoiceDetailsInfo.VatAmount = (objEInvoiceDetailsInfo.UnitPrice * objEInvoiceDetailsInfo.Quantity) * objEInvoiceDetailsInfo.VatPercentage / 100;
                objEInvoiceDetailsInfo.Promotion = false;
                objEInvoiceDetailsInfo.ACEInvoiceDetailModuleName = ModuleName.RetailVAT;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceID = objSaleReturnsInfo.ARSaleReturnID;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceNo = objSaleReturnsInfo.ARSaleReturnNo;
                objEInvoiceDetailsInfo.ACEInvoiceDetailRefItemID = o.ARSaleReturnItemID;

                //ACEInvoiceDetailsInfo checkEInvoiceDetailsInfo = eInvoiceDetails.Where(p => p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //                                                                         && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //                                                                         && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //                                                                         && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //                                                                         && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent).FirstOrDefault();
                //if (checkEInvoiceDetailsInfo != null)
                //{
                //    eInvoiceDetails.ForEach(p =>
                //    {
                //        if (p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //            && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //            && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //            && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //            && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent)
                //        {
                //            p.Quantity += objEInvoiceDetailsInfo.Quantity;
                //            p.VatAmount = (p.UnitPrice * p.Quantity) * p.VatPercentage / 100;
                //        }
                //    });
                //}
                //else
                //{
                eInvoiceDetails.Add(objEInvoiceDetailsInfo);
                //}
                lineNumber++;
            });

            //decimal vatPercen = 0;
            //if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType2.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
            //    vatPercen = 0;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 0;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType3.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
            //    vatPercen = 5;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 5;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType4.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
            //    vatPercen = 8;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 8;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType6.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
            //    vatPercen = 10;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 10;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "Không thuế GTGT";
            //    vatPercen = 0;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 0;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            decimal vatPercen = objSaleReturnsInfo.ARSaleReturnTaxPercent;
            if (vatPercen == 0)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
            }
            else if (vatPercen == 5)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
            }
            else if (vatPercen == 8)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
            }
            else if (vatPercen == 10)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
            }
            eInvoiceDetails.ForEach(p =>
            {
                p.VatPercentage = vatPercen;
                p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            });
            objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT = Math.Round(eInvoiceDetails.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.DiscountAmount = Math.Round(-objSaleReturnsInfo.ARSaleReturnDiscountFix - saleReturnItemsInfo.Sum(o => o.ARSaleReturnItemDiscountAmount), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalVATAmount = Math.Round((objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT - objEInvoiceGeneralsInfo.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithoutVAT = objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT + objEInvoiceGeneralsInfo.TotalVATAmount;
            objEInvoiceGeneralsInfo.TotalAmountWithVAT = Math.Round(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT
                                                                    - objEInvoiceGeneralsInfo.DiscountAmount
                                                                    + objEInvoiceGeneralsInfo.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithVATInWords = String.Format("Âm {0}", ConvertAmountToWord.ReadAmount(Math.Abs(objEInvoiceGeneralsInfo.TotalAmountWithVAT).ToString(), objSaleReturnsInfo.FK_GECurrencyID));
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralType = EInvoiceGeneralType.Original.ToString();
            #endregion

            #region Save
            objEInvoiceGeneralsController.CreateObject(objEInvoiceGeneralsInfo);

            if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralID > 0)
            {
                eInvoiceDetails.ForEach(o =>
                {
                    o.FK_ACEInvoiceGeneralID = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID;
                    objEInvoiceDetailsController.CreateObject(o);
                });
            }
            #endregion

            MessageBox.Show(ElectronicInvoiceLocalizedResources.CreateSuccess,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowElectronicInvoiceScreen(objEInvoiceGeneralsInfo);
        }
        public static void UpdateEInvoice(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, ARSaleReturnsInfo objSaleReturnsInfo, List<ARSaleReturnItemsInfo> saleReturnItemsInfo)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            //ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objSaleReturnsInfo.FK_ACEInvoiceTypeID);
            //if (objEInvoiceTypesInfo == null)
            //{
            //    MessageBox.Show(ElectronicInvoiceLocalizedResources.ErrorVATInvoiceNoCombo,
            //                    CommonLocalizedResources.MessageBoxDefaultCaption,
            //                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            #region Create EInvoiceGenerals
            objEInvoiceGeneralsInfo.SellerAppRecordId = objSaleReturnsInfo.ARSaleReturnNo;
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objSaleReturnsInfo.ARSaleReturnNo;
            //objEInvoiceGeneralsInfo.InvoiceType = objEInvoiceTypesInfo.ACEInvoiceTypeNo;
            //objEInvoiceGeneralsInfo.TemplateCode = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
            //objEInvoiceGeneralsInfo.InvoiceSeries = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            //objEInvoiceGeneralsInfo.InvoiceName = objEInvoiceTypesInfo.ACEInvoiceTypeName;
            objEInvoiceGeneralsInfo.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            objEInvoiceGeneralsInfo.ContractNumber = string.Empty;
            objEInvoiceGeneralsInfo.ContractDate = objSaleReturnsInfo.ARSaleReturnTransferredDate;
            objEInvoiceGeneralsInfo.FK_ACObjectID = objSaleReturnsInfo.FK_ACObjectID;
            objEInvoiceGeneralsInfo.ACObjectType = objSaleReturnsInfo.ARObjectType;
            objEInvoiceGeneralsInfo.FK_GECurrencyID = objSaleReturnsInfo.FK_GECurrencyID;
            if (objEInvoiceGeneralsInfo.FK_ACTaxUnitID <= 0)
            {
                ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
                List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
                if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
                {
                    objEInvoiceGeneralsInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
                }
            }
            //objEInvoiceGeneralsInfo.InvoiceNumber = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objEInvoiceGeneralsInfo.ReferModuleName = "Invoice";
            objEInvoiceGeneralsInfo.PaymentStatus = "Hóa đơn chưa thanh toán";

            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objSaleReturnsInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeCreateInvoiceName = objEmployeesInfo.HREmployeeName;
            }
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeUpLoadDataToEInvoiceName = objEmployeesInfo.HREmployeeName;
            }

            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)(new GECurrenciesController()).GetObjectByID(objSaleReturnsInfo.FK_GECurrencyID);
            if (objCurrenciesInfo != null)
            {
                objEInvoiceGeneralsInfo.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
                objEInvoiceGeneralsInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
            }
            objEInvoiceGeneralsInfo.ExchangeRate = objSaleReturnsInfo.ARSaleReturnExchangeRate;
            objEInvoiceGeneralsInfo.InvoiceNote = objSaleReturnsInfo.ARSaleReturnDesc;
            objEInvoiceGeneralsInfo.AdjustmentType = 1;
            objEInvoiceGeneralsInfo.BuyerTaxCode = objSaleReturnsInfo.ARSaleReturnTaxNumber;

            ACEInvoicePaymentMethodsInfo objEConfig = (ACEInvoicePaymentMethodsInfo)(new ACEInvoicePaymentMethodsController()).GetObjectByNo(objSaleReturnsInfo.ARPaymentMethodCombo);
            if (objEConfig != null)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = objEConfig.ACEInvoicePaymentMethodName;

            if (objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName == string.Empty)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = "Thanh toán tiền mặt";
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                objEInvoiceGeneralsInfo.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                objEInvoiceGeneralsInfo.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                objEInvoiceGeneralsInfo.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                objEInvoiceGeneralsInfo.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                objEInvoiceGeneralsInfo.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                objEInvoiceGeneralsInfo.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                objEInvoiceGeneralsInfo.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                objEInvoiceGeneralsInfo.SellerEmail = objCompanysInfo.CSCompanyEmail;
                objEInvoiceGeneralsInfo.SellerBankName = objCompanysInfo.CSCompanyBankName;
                objEInvoiceGeneralsInfo.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
            }

            #region Get Customer info            
            if (objSaleReturnsInfo.ARObjectType == ObjectType.Customer.ToString())
            {
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objSaleReturnsInfo.FK_ACObjectID);
                if (objCustomersInfo != null)
                {
                    if (objCustomersInfo.ARCustomerTypeCombo != string.Empty)
                    {
                        objEInvoiceGeneralsInfo.BuyerType = ADConfigValueUtility.GetConfigTextByGroupAndValue("CustomerType", objCustomersInfo.ARCustomerTypeCombo);
                    }
                    objEInvoiceGeneralsInfo.BuyerLegalName = objCustomersInfo.ARCustomerName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objCustomersInfo.ARCustomerTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objCustomersInfo.ARCustomerInvoiceAddressLine1;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objCustomersInfo.ARCustomerContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objCustomersInfo.ARCustomerContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objCustomersInfo.ARCustomerContactEmail1;
                    objEInvoiceGeneralsInfo.BuyerCode = objCustomersInfo.ARCustomerNo;
                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    }
                }
            }
            else
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objSaleReturnsInfo.FK_ACObjectID, objSaleReturnsInfo.ARObjectType);
                if (objObjectsInfo != null)
                {
                    //objEInvoiceGeneralsInfo.BuyerDisplayName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerLegalName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                    GEDistrictsInfo objDistrictsInfo =
                    (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    GEStateProvincesInfo objStateProvincesInfo =
                    (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                    objEInvoiceGeneralsInfo.BuyerCode = objObjectsInfo.ACObjectNo;
                }
            }
            #endregion
            #endregion

            #region Create Details
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            objEInvoiceDetailsController.DeleteByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = new List<ACEInvoiceDetailsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo;
            ICMeasureUnitsInfo objMeasureUnitsInfo;
            ICProductsInfo objProductsInfo;
            int lineNumber = 1;
            saleReturnItemsInfo.ForEach(o =>
            {
                objEInvoiceDetailsInfo = new ACEInvoiceDetailsInfo();
                objEInvoiceDetailsInfo.LineNumber = lineNumber;
                objEInvoiceDetailsInfo.OrderIndex = lineNumber;
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                    objEInvoiceDetailsInfo.ItemName = !string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName2 : o.ARSaleReturnItemProductName;
                }
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)(objMeasureUnitsController.GetObjectByID(o.FK_ICMeasureUnitID));
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = objMeasureUnitsInfo.ICMeasureUnitName;
                    objEInvoiceDetailsInfo.UnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                }
                //objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARInvoiceItemProductUnitPrice * (1 - o.ARInvoiceItemProductDiscount / 100), 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARSaleReturnItemProductUnitPrice, 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.Quantity = Math.Round(-o.ARSaleReturnItemProductQty, 3, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.VatPercentage = objSaleReturnsInfo.ARSaleReturnTaxPercent;
                if (objEInvoiceDetailsInfo.VatPercentage == 0)
                {
                    objEInvoiceDetailsInfo.VatPercentage = o.ARSaleReturnItemProductTaxPercent;
                }
                objEInvoiceDetailsInfo.VatAmount = (objEInvoiceDetailsInfo.UnitPrice * objEInvoiceDetailsInfo.Quantity) * objEInvoiceDetailsInfo.VatPercentage / 100;
                objEInvoiceDetailsInfo.Promotion = false;
                objEInvoiceDetailsInfo.ACEInvoiceDetailModuleName = ModuleName.RetailVAT;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceID = objSaleReturnsInfo.ARSaleReturnID;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceNo = objSaleReturnsInfo.ARSaleReturnNo;
                objEInvoiceDetailsInfo.ACEInvoiceDetailRefItemID = o.ARSaleReturnItemID;

                //ACEInvoiceDetailsInfo checkEInvoiceDetailsInfo = eInvoiceDetails.Where(p => p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //                                                                            && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //                                                                            && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //                                                                            && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //                                                                            && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent).FirstOrDefault();
                //if (checkEInvoiceDetailsInfo != null)
                //{
                //    eInvoiceDetails.ForEach(p =>
                //    {
                //        if (p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //            && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //            && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //            && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //            && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent)
                //        {
                //            p.Quantity += objEInvoiceDetailsInfo.Quantity;
                //            p.VatAmount = (p.UnitPrice * p.Quantity) * p.VatPercentage / 100;
                //        }
                //    });
                //}
                //else
                //{
                eInvoiceDetails.Add(objEInvoiceDetailsInfo);
                //}
                lineNumber++;
            });

            //decimal vatPercen = 0;
            //if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType2.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
            //    vatPercen = 0;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 0;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType3.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
            //    vatPercen = 5;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 5;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType4.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
            //    vatPercen = 8;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 8;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else if (objSaleReturnsInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType6.ToString())
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
            //    vatPercen = 10;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 10;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            //else
            //{
            //    objEInvoiceGeneralsInfo.TaxOfficeCode = "Không thuế GTGT";
            //    vatPercen = 0;
            //    eInvoiceDetails.ForEach(p =>
            //    {
            //        p.VatPercentage = 0;
            //        p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            //    });
            //}
            decimal vatPercen = objSaleReturnsInfo.ARSaleReturnTaxPercent;
            if (vatPercen == 0)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
            }
            else if (vatPercen == 5)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
            }
            else if (vatPercen == 8)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
            }
            else if (vatPercen == 10)
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
            }
            eInvoiceDetails.ForEach(p =>
            {
                p.VatPercentage = vatPercen;
                p.VatAmount = Math.Round((p.UnitPrice * p.Quantity) * p.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            });
            objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT = Math.Round(eInvoiceDetails.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.DiscountAmount = Math.Round(-objSaleReturnsInfo.ARSaleReturnDiscountFix - saleReturnItemsInfo.Sum(o => o.ARSaleReturnItemDiscountAmount), 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalVATAmount = Math.Round((objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT - objEInvoiceGeneralsInfo.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithoutVAT = (objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT + objEInvoiceGeneralsInfo.TotalVATAmount);
            objEInvoiceGeneralsInfo.TotalAmountWithVAT = Math.Round(objEInvoiceGeneralsInfo.SumOfTotalLineAmountWithoutVAT
                                                                    - objEInvoiceGeneralsInfo.DiscountAmount
                                                                    + objEInvoiceGeneralsInfo.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            objEInvoiceGeneralsInfo.TotalAmountWithVATInWords = String.Format("Âm {0}", ConvertAmountToWord.ReadAmount(Math.Abs(objEInvoiceGeneralsInfo.TotalAmountWithVAT).ToString(), objSaleReturnsInfo.FK_GECurrencyID));
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralType = EInvoiceGeneralType.Original.ToString();
            #endregion

            #region Save
            objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);

            if (objEInvoiceGeneralsInfo.ACEInvoiceGeneralID > 0)
            {
                eInvoiceDetails.ForEach(o =>
                {
                    o.FK_ACEInvoiceGeneralID = objEInvoiceGeneralsInfo.ACEInvoiceGeneralID;
                    objEInvoiceDetailsController.CreateObject(o);
                });
            }
            #endregion

            MessageBox.Show(ElectronicInvoiceLocalizedResources.UpdateSuccess,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowElectronicInvoiceScreen(objEInvoiceGeneralsInfo);
        }
        #endregion
        public static void ShowElectronicInvoiceScreen(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            ACEInvoiceConfigsInfo objEInvoiceConfigsInfo = objEInvoiceConfigsController.GetLastEInvoiceConfigByTaxUnitID(objEInvoiceGeneralsInfo.FK_ACTaxUnitID);
            if(objEInvoiceConfigsInfo != null && objEInvoiceConfigsInfo.ACEInvoiceConfigPartnerType == EInvoiceConfigPartnerType.MInvoice.ToString())
            {
                Modules.ElectronicInvoiceMInvoice.ElectronicInvoiceMInvoiceModule electronicInvoiceModule;
                if (BOSApp.IsOpenedModule(ModuleName.ElectronicInvoiceBKAV))
                {
                    electronicInvoiceModule = ((Modules.ElectronicInvoiceMInvoice.ElectronicInvoiceMInvoiceModule)BOSApp.OpenModules[ModuleName.ElectronicInvoiceMInvoice]);
                }
                else
                {
                    electronicInvoiceModule = (Modules.ElectronicInvoiceMInvoice.ElectronicInvoiceMInvoiceModule)BOSApp.ShowModule(ModuleName.ElectronicInvoiceMInvoice);
                }
                if (electronicInvoiceModule == null)
                {
                    return;
                }
                                
                electronicInvoiceModule.ActionInvalidate(objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
                electronicInvoiceModule.Invalidate(objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
                electronicInvoiceModule.ParentScreen.Activate();
            }
            else
            {
                Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule electronicInvoiceModule;
                if (BOSApp.IsOpenedModule(ModuleName.ElectronicInvoiceBKAV))
                {
                    electronicInvoiceModule = ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)BOSApp.OpenModules[ModuleName.ElectronicInvoiceBKAV]);
                }
                else
                {
                    electronicInvoiceModule = (Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)BOSApp.ShowModule(ModuleName.ElectronicInvoiceBKAV);
                }
                if (electronicInvoiceModule == null)
                {
                    return;
                }

                electronicInvoiceModule.ActionInvalidate(objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
                electronicInvoiceModule.Invalidate(objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
                electronicInvoiceModule.ParentScreen.Activate();
            }
        }

        public static void GenarateEInvoiceGeneral(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, ARInvoicesInfo objInvoicesInfo, bool isDuplicate, string oldInvoiceNumber)
        {
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            
            #region Create EInvoiceGenerals
            objEInvoiceGeneralsInfo.SellerAppRecordId = objInvoicesInfo.ARInvoiceNo;
            objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo = objInvoicesInfo.ARInvoiceNo;            
            objEInvoiceGeneralsInfo.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            objEInvoiceGeneralsInfo.ContractNumber = objInvoicesInfo.ARInvoicePONo;
            objEInvoiceGeneralsInfo.ContractDate = objInvoicesInfo.ARInvoiceDate;
            objEInvoiceGeneralsInfo.FK_ACObjectID = objInvoicesInfo.FK_ACObjectID;
            objEInvoiceGeneralsInfo.ACObjectType = objInvoicesInfo.ARObjectType;
            objEInvoiceGeneralsInfo.FK_GECurrencyID = GECurrencyID.VND;
            objEInvoiceGeneralsInfo.FK_ACTaxUnitID = objInvoicesInfo.FK_ACTaxUnitID;
            if (objEInvoiceGeneralsInfo.FK_ACTaxUnitID <= 0)
            {
                ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
                List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
                if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
                {
                    objEInvoiceGeneralsInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
                }
            }
            //objEInvoiceGeneralsInfo.InvoiceNumber = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objEInvoiceGeneralsInfo.AdditionalReferenceDate = (DateTime)SqlDateTime.MinValue;
            objEInvoiceGeneralsInfo.ReferModuleName = "Invoice";
            objEInvoiceGeneralsInfo.PaymentStatus = "Hóa đơn chưa thanh toán";

            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(objInvoicesInfo.FK_ACEInvoiceTypeID);
            if (objEInvoiceTypesInfo != null)
            {
                objEInvoiceGeneralsInfo.InvoiceType = objEInvoiceTypesInfo.ACEInvoiceTypeNo;
                objEInvoiceGeneralsInfo.TemplateCode = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                objEInvoiceGeneralsInfo.InvoiceSeries = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
                objEInvoiceGeneralsInfo.InvoiceName = objEInvoiceTypesInfo.ACEInvoiceTypeName;
            }

            if (isDuplicate)
            {
                objEInvoiceGeneralsInfo.OriginalInvoiceId = oldInvoiceNumber;
                objEInvoiceGeneralsInfo.PublicKey = string.Empty;
                objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = "New";
                objEInvoiceGeneralsInfo.SubmittedDate = DateTime.MaxValue;
                objEInvoiceGeneralsInfo.InvoiceNumber = string.Empty;
                objEInvoiceGeneralsInfo.SystemCode = string.Empty;
                objEInvoiceGeneralsInfo.SellerSignatureHash = string.Empty;
            }

            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objInvoicesInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeCreateInvoiceName = objEmployeesInfo.HREmployeeName;
            }
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                objEInvoiceGeneralsInfo.EmployeeUpLoadDataToEInvoiceName = objEmployeesInfo.HREmployeeName;
            }
            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)(new GECurrenciesController()).GetObjectByID(objEInvoiceGeneralsInfo.FK_GECurrencyID);
            if (objCurrenciesInfo != null)
            {
                objEInvoiceGeneralsInfo.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
                objEInvoiceGeneralsInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
            }
            objEInvoiceGeneralsInfo.ExchangeRate = 1;
            objEInvoiceGeneralsInfo.InvoiceNote = objInvoicesInfo.ARInvoiceDesc;
            objEInvoiceGeneralsInfo.AdjustmentType = 1;
            objEInvoiceGeneralsInfo.BuyerTaxCode = objInvoicesInfo.ARInvoiceTaxNumber;

            ACEInvoicePaymentMethodsInfo objEConfig = (ACEInvoicePaymentMethodsInfo)(new ACEInvoicePaymentMethodsController()).GetObjectByNo(objInvoicesInfo.ARPaymentMethodCombo);
            if (objEConfig != null)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = objEConfig.ACEInvoicePaymentMethodName;

            if (objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName == string.Empty)
                objEInvoiceGeneralsInfo.ACEInvoicePaymentMethodName = "Thanh toán tiền mặt";
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                objEInvoiceGeneralsInfo.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                objEInvoiceGeneralsInfo.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                objEInvoiceGeneralsInfo.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                objEInvoiceGeneralsInfo.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                objEInvoiceGeneralsInfo.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                objEInvoiceGeneralsInfo.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                objEInvoiceGeneralsInfo.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                objEInvoiceGeneralsInfo.SellerEmail = objCompanysInfo.CSCompanyEmail;
                objEInvoiceGeneralsInfo.SellerBankName = objCompanysInfo.CSCompanyBankName;
                objEInvoiceGeneralsInfo.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
            }

            #region Get Customer info            
            if (objInvoicesInfo.ARObjectType == ObjectType.Customer.ToString())
            {
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objInvoicesInfo.FK_ACObjectID);
                if (objCustomersInfo != null)
                {
                    if (objCustomersInfo.ARCustomerTypeCombo != string.Empty)
                    {
                        objEInvoiceGeneralsInfo.BuyerType = ADConfigValueUtility.GetConfigTextByGroupAndValue("CustomerType", objCustomersInfo.ARCustomerTypeCombo);
                    }
                    objEInvoiceGeneralsInfo.BuyerLegalName = objCustomersInfo.ARCustomerName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objCustomersInfo.ARCustomerTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objCustomersInfo.ARCustomerInvoiceAddressLine1;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objCustomersInfo.ARCustomerContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objCustomersInfo.ARCustomerContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objCustomersInfo.ARCustomerContactEmail1;
                    objEInvoiceGeneralsInfo.BuyerCode = objCustomersInfo.ARCustomerNo;
                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objCustomersInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    }
                }
            }
            else
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
                if (objObjectsInfo != null)
                {
                    //objEInvoiceGeneralsInfo.BuyerDisplayName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerLegalName = objObjectsInfo.ACObjectName;
                    objEInvoiceGeneralsInfo.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                    objEInvoiceGeneralsInfo.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                    GEDistrictsInfo objDistrictsInfo =
                    (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                    if (objDistrictsInfo != null)
                        objEInvoiceGeneralsInfo.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                    GEStateProvincesInfo objStateProvincesInfo =
                    (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                    if (objStateProvincesInfo != null)
                        objEInvoiceGeneralsInfo.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                    objEInvoiceGeneralsInfo.BuyerCountryCode = "VN";
                    objEInvoiceGeneralsInfo.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                    objEInvoiceGeneralsInfo.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
                    objEInvoiceGeneralsInfo.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                    objEInvoiceGeneralsInfo.BuyerCode = objObjectsInfo.ACObjectNo;
                }
            }
            #endregion

            #region Get default Customer Bank
            if (objInvoicesInfo.ARInvoiceTaxNumber != string.Empty)
                objEInvoiceGeneralsInfo.BuyerTaxCode = objInvoicesInfo.ARInvoiceTaxNumber;
            List<ACListAccountBanksInfo> listBank = (new ACListAccountBanksController()).GetListByACObject(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
            if (listBank != null && listBank.Count > 0)
            {
                objEInvoiceGeneralsInfo.BuyerBankName = listBank[0].ACListAccountBankName;
                objEInvoiceGeneralsInfo.BuyerBankAccount = listBank[0].ACListAccountBankAccountHolder;
                objEInvoiceGeneralsInfo.BuyerBankNumber = listBank[0].ACListAccountBankAccount;
            }
            #endregion
            #endregion
        }

        public static List<ACEInvoiceDetailsInfo> GenarateEInvoiceDetail(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo, ARInvoicesInfo objInvoicesInfo, List<ARInvoiceItemsInfo> invoiceItems)
        {
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = new List<ACEInvoiceDetailsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo;
            ICMeasureUnitsInfo objMeasureUnitsInfo;
            ICProductsInfo objProductsInfo;
            int lineNumber = 1;
            invoiceItems.ForEach(o =>
            {
                objEInvoiceDetailsInfo = new ACEInvoiceDetailsInfo();
                objEInvoiceDetailsInfo.LineNumber = lineNumber;
                objEInvoiceDetailsInfo.OrderIndex = lineNumber;
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                }
                objEInvoiceDetailsInfo.ItemName = o.ARInvoiceItemProductName2;
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)(objMeasureUnitsController.GetObjectByID(o.FK_ICMeasureUnitID));
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = string.IsNullOrWhiteSpace(objMeasureUnitsInfo.ICMeasureUnitDesc)?  objMeasureUnitsInfo.ICMeasureUnitName.Substring(0, 1).ToUpper() : objMeasureUnitsInfo.ICMeasureUnitDesc.Substring(0, 1).ToUpper();
                    objEInvoiceDetailsInfo.UnitName = string.IsNullOrWhiteSpace(objMeasureUnitsInfo.ICMeasureUnitDesc)?objMeasureUnitsInfo.ICMeasureUnitName : objMeasureUnitsInfo.ICMeasureUnitDesc;
                }
                objEInvoiceDetailsInfo.UnitPrice = Math.Round(o.ARInvoiceItemProductUnitPrice * objInvoicesInfo.ARInvoiceExchangeRate, 2, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.Quantity = Math.Round(o.ARInvoiceItemProductQty, 3, MidpointRounding.AwayFromZero);
                objEInvoiceDetailsInfo.VatPercentage = objInvoicesInfo.ARInvoiceTaxPercent;
                objEInvoiceDetailsInfo.VatAmount = (objEInvoiceDetailsInfo.UnitPrice * objEInvoiceDetailsInfo.Quantity) * objEInvoiceDetailsInfo.VatPercentage / 100;
                objEInvoiceDetailsInfo.Promotion = false;
                objEInvoiceDetailsInfo.ACEInvoiceDetailModuleName = ModuleName.Invoice;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceID = o.FK_ARInvoiceID;
                objEInvoiceDetailsInfo.ACEInvoiceDetailReferenceNo = string.IsNullOrWhiteSpace(o.ARInvoiceNo) ? objInvoicesInfo.ARInvoiceNo : o.ARInvoiceNo;
                objEInvoiceDetailsInfo.ACEInvoiceDetailRefItemID = o.ARInvoiceItemID;

                //ACEInvoiceDetailsInfo checkEInvoiceDetailsInfo = eInvoiceDetails.Where(p => p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //                                                                         && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //                                                                         && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //                                                                         && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //                                                                         && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent).FirstOrDefault();
                //if (checkEInvoiceDetailsInfo != null)
                //{
                //    eInvoiceDetails.ForEach(p =>
                //    {
                //        if (p.ItemCode == objEInvoiceDetailsInfo.ItemCode
                //             && p.ItemName == objEInvoiceDetailsInfo.ItemName
                //             && p.UnitPrice == objEInvoiceDetailsInfo.UnitPrice
                //             && p.VatPercentage == objEInvoiceDetailsInfo.VatPercentage
                //             && p.DiscountPercent == objEInvoiceDetailsInfo.DiscountPercent)
                //        {
                //            p.Quantity += objEInvoiceDetailsInfo.Quantity;
                //            p.VatAmount = (p.UnitPrice * p.Quantity) * p.VatPercentage / 100;
                //        }
                //    });
                //}
                //else
                //{
                    eInvoiceDetails.Add(objEInvoiceDetailsInfo);
                //}
                lineNumber++;
            });

            decimal vatPercen = 0;
            if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType2.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "0%";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Truncate((p.UnitPrice * p.Quantity) * p.VatPercentage / 100);
                });
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType3.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "5%";
                vatPercen = 5;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 5;
                    p.VatAmount = Math.Truncate((p.UnitPrice * p.Quantity) * p.VatPercentage / 100);
                });
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType4.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "8%";
                vatPercen = 8;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 8;
                    p.VatAmount = Math.Truncate((p.UnitPrice * p.Quantity) * p.VatPercentage / 100);
                });
            }
            else if (objInvoicesInfo.AROutputVATDocumentType == OutputVATDocumentType.InvoiceType6.ToString())
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "10%";
                vatPercen = 10;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 10;
                    p.VatAmount = Math.Truncate((p.UnitPrice * p.Quantity) * p.VatPercentage / 100);
                });
            }
            else
            {
                objEInvoiceGeneralsInfo.TaxOfficeCode = "Không thuế GTGT";
                vatPercen = 0;
                eInvoiceDetails.ForEach(p =>
                {
                    p.VatPercentage = 0;
                    p.VatAmount = Math.Truncate((p.UnitPrice * p.Quantity) * p.VatPercentage / 100);
                });
            }
            return eInvoiceDetails;
        }
    }
}
