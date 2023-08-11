using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.ElectronicInvoice
{
    public class ElectronicInvoiceEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACEInvoiceDetailsInfo> EInvoiceDetailsList { get; set; }
        public BOSList<ACFileAttachmentsInfo> EInvoiceTemplateList { get; set; }
        public Dictionary<int, string> EInvoiceTemplateURLDic { get; set; }
        #endregion

        #region Constructor
        public ElectronicInvoiceEntities() : base()
        {
            EInvoiceDetailsList = new BOSList<ACEInvoiceDetailsInfo>();
            EInvoiceTemplateList = new BOSList<ACFileAttachmentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACEInvoiceGeneralsInfo();
            SearchObject = new ACEInvoiceGeneralsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACEInvoiceDetailsTableName, new ACEInvoiceDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            EInvoiceDetailsList.InitBOSList(this,
                                            TableName.ACEInvoiceGeneralsTableName,
                                            TableName.ACEInvoiceDetailsTableName,
                                            BOSList<ACEInvoiceDetailsInfo>.cstRelationForeign);

            EInvoiceTemplateList.InitBOSList(this,
                                            TableName.ACEInvoiceGeneralsTableName,
                                            TableName.ACFileAttachmentsTableName,
                                            BOSList<ACFileAttachmentsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            EInvoiceDetailsList.InitBOSListGridControl();
            EInvoiceTemplateList.InitBOSListGridControl(ElectronicInvoiceModule.EInvoiceGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EInvoiceDetailsList.SetDefaultListAndRefreshGridControl();
                EInvoiceTemplateList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            mainObject.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            mainObject.PaymentStatus = string.Empty;
            //mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            EInvoiceDetailsList.Invalidate(iObjectID);
            EInvoiceDetailsList.ForEach(p => p.ACEInvoiceDetailTotalAmount = p.Quantity * p.UnitPrice);
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            ACFileAttachmentsController objFileAttachmentsController = new ACFileAttachmentsController();
            List<ACFileAttachmentsInfo> fileAttachmentList = objFileAttachmentsController.GetFileAttachmentByModuleAndObjectRef(this.Module.Name, BOSUtil.GetTableNameFromBusinessObject(mainObject), mainObject.ACEInvoiceGeneralID, 0);
            EInvoiceTemplateList.Invalidate(fileAttachmentList);

        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            EInvoiceDetailsList.SaveItemObjects();
            EInvoiceTemplateList.SaveItemObjects();
            EInvoiceTemplateURLDic = EInvoiceTemplateList.ToDictionary(o => o.ACFileAttachmentID, o => o.FullPathFile);
        }
        #endregion

        public void GenerateEntityForNewDelete(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            mainObject.SellerAppRecordId = objEInvoiceGeneralsInfo.SellerAppRecordId;
            mainObject.ACEInvoiceGeneralNo = objEInvoiceGeneralsInfo.ACEInvoiceGeneralNo;
            mainObject.InvoiceType = objEInvoiceGeneralsInfo.InvoiceType;
            mainObject.TemplateCode = objEInvoiceGeneralsInfo.TemplateCode;
            mainObject.InvoiceSeries = objEInvoiceGeneralsInfo.InvoiceSeries;
            mainObject.InvoiceNumber = objEInvoiceGeneralsInfo.InvoiceNumber;
            mainObject.InvoiceName = objEInvoiceGeneralsInfo.InvoiceName;
            mainObject.InvoiceIssuedDate = objEInvoiceGeneralsInfo.InvoiceIssuedDate;
            //mainObject.SignedDate =
            //mainObject.submittedDate =
            mainObject.ContractNumber = objEInvoiceGeneralsInfo.ContractNumber;
            mainObject.ContractDate = objEInvoiceGeneralsInfo.ContractDate;
            mainObject.CurrencyCode = objEInvoiceGeneralsInfo.CurrencyCode;
            mainObject.ExchangeRate = objEInvoiceGeneralsInfo.ExchangeRate;
            mainObject.InvoiceNote = objEInvoiceGeneralsInfo.InvoiceNote;
            mainObject.AdjustmentType = (int)EInvoiceGeneralType.Delete;
            mainObject.OriginalInvoiceId = objEInvoiceGeneralsInfo.CertifiedId;
            //mainObject.AdditionalReferenceDesc =
            //mainObject.AdditionalReferenceDate =
            mainObject.SellerLegalName = objEInvoiceGeneralsInfo.SellerLegalName;
            mainObject.SellerTaxCode = objEInvoiceGeneralsInfo.SellerTaxCode;
            mainObject.SellerAddressLine = objEInvoiceGeneralsInfo.SellerAddressLine;
            mainObject.SellerPostalCode = objEInvoiceGeneralsInfo.SellerPostalCode;
            mainObject.SellerDistrictName = objEInvoiceGeneralsInfo.SellerDistrictName;
            mainObject.SellerCityName = objEInvoiceGeneralsInfo.SellerCityName;
            mainObject.SellerCountryCode = objEInvoiceGeneralsInfo.SellerCountryCode;
            mainObject.SellerPhoneNumber = objEInvoiceGeneralsInfo.SellerPhoneNumber;
            mainObject.SellerFaxNumber = objEInvoiceGeneralsInfo.SellerFaxNumber;
            mainObject.SellerBankName = objEInvoiceGeneralsInfo.SellerBankName;
            mainObject.SellerBankAccount = objEInvoiceGeneralsInfo.SellerBankAccount;
            mainObject.SellerContactPersonName = objEInvoiceGeneralsInfo.SellerContactPersonName;
            mainObject.BuyerDisplayName = objEInvoiceGeneralsInfo.BuyerDisplayName;
            mainObject.BuyerLegalName = objEInvoiceGeneralsInfo.BuyerLegalName;
            mainObject.BuyerTaxCode = objEInvoiceGeneralsInfo.BuyerTaxCode;
            mainObject.BuyerAddressLine = objEInvoiceGeneralsInfo.BuyerAddressLine;
            mainObject.BuyerEmail = objEInvoiceGeneralsInfo.BuyerEmail;
            mainObject.BuyerBankName = objEInvoiceGeneralsInfo.BuyerBankName;
            mainObject.BuyerBankAccount = objEInvoiceGeneralsInfo.BuyerBankAccount;
            mainObject.BuyerDistrictName = objEInvoiceGeneralsInfo.BuyerDistrictName;
            mainObject.BuyerCityName = objEInvoiceGeneralsInfo.BuyerCityName;
            mainObject.BuyerCountryCode = objEInvoiceGeneralsInfo.BuyerCountryCode;
            mainObject.BuyerPhoneNumber = objEInvoiceGeneralsInfo.BuyerPhoneNumber;
            mainObject.BuyerFaxNumber = objEInvoiceGeneralsInfo.BuyerFaxNumber;
            mainObject.TotalAmountWithoutVAT = objEInvoiceGeneralsInfo.TotalAmountWithoutVAT;
            mainObject.TotalVATAmount = objEInvoiceGeneralsInfo.TotalVATAmount;
            mainObject.TotalAmountWithVAT = objEInvoiceGeneralsInfo.TotalAmountWithVAT;
            mainObject.TotalAmountWithVATInWords = objEInvoiceGeneralsInfo.TotalAmountWithVATInWords;
            mainObject.SystemCode = objEInvoiceGeneralsInfo.SystemCode;
            //mainObject.TaxOfficeCode = objEInvoiceGeneralsInfo.TaxOfficeCode;
            //mainObject.QRCodeData = objEInvoiceGeneralsInfo.QRCodeData;
            //mainObject.TotalAmount = objEInvoiceGeneralsInfo.TotalAmount;
            //mainObject.IssuedDate = objEInvoiceGeneralsInfo.IssuedDate;
            //mainObject.SellerSignatureHash = objEInvoiceGeneralsInfo.SellerSignatureHash;
            //mainObject.OriginalCertifiedId = objEInvoiceGeneralsInfo.OriginalCertifiedId;
            mainObject.ACEInvoiceGeneralType = EInvoiceGeneralType.Delete.ToString();

            GenerateEntityListForNewDelete(objEInvoiceGeneralsInfo);

            UpdateMainObjectBindingSource();

        }

        public void GenerateEntityListForNewDelete(ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo)
        {
            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            DataSet dataSet = objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", objEInvoiceGeneralsInfo.ACEInvoiceGeneralID);
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = (List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(dataSet);
            eInvoiceDetails.ForEach(o =>
            {
                o.ACEInvoiceDetailID = 0;
                EInvoiceDetailsList.Add(o);
            });
            EInvoiceDetailsList.GridControl.RefreshDataSource();
        }

        public void GenerateEntityForNewReplace(ARInvoicesInfo objInvoicesInfo, List<ARInvoiceItemsInfo> invoiceItems, ACEInvoiceTypesInfo objEInvoiceTypesInfo, String originalInvoiceId)
        {
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            mainObject.SellerAppRecordId = objInvoicesInfo.ARInvoiceNo;
            mainObject.ACEInvoiceGeneralNo = objInvoicesInfo.ARInvoiceNo;
            mainObject.InvoiceType = objEInvoiceTypesInfo.ACEInvoiceTypeNo;
            mainObject.TemplateCode = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
            mainObject.InvoiceSeries = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            mainObject.InvoiceName = objEInvoiceTypesInfo.ACEInvoiceTypeName;
            mainObject.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            mainObject.ContractNumber = objInvoicesInfo.ARInvoicePONo;
            mainObject.ContractDate = objInvoicesInfo.ARInvoiceDate;
            //mainObject.SignedDate = objInvoicesInfo.ARInvoiceDate;
            //mainObject.submittedDate =

            GECurrenciesInfo objCurrenciesInfo =
           (GECurrenciesInfo)(new GECurrenciesController()).GetObjectFromDataRow(
               BOSApp.GetObjectFromCatche("GECurrencies", "GECurrencyID", objInvoicesInfo.FK_GECurrencyID));
            if (objCurrenciesInfo != null)
                mainObject.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
            mainObject.ExchangeRate = objInvoicesInfo.ARInvoiceExchangeRate;
            mainObject.InvoiceNote = objInvoicesInfo.ARInvoiceDesc;
            mainObject.AdjustmentType = (int)EInvoiceGeneralType.Replace;
            mainObject.ACEInvoicePaymentMethodName = ADConfigValueUtility.GetConfigTextByGroupAndValue("PaymentMethod", objInvoicesInfo.ARPaymentMethodCombo);

            if (mainObject.ACEInvoicePaymentMethodName == string.Empty)
                mainObject.ACEInvoicePaymentMethodName = "Tiền mặt";
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                mainObject.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                mainObject.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                mainObject.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                mainObject.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                mainObject.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                mainObject.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                mainObject.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                mainObject.SellerEmail = objCompanysInfo.CSCompanyEmail;
                mainObject.SellerBankName = objCompanysInfo.CSCompanyBankName;
                mainObject.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
            }
            #region Get Customer info
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
            if (objObjectsInfo != null)
            {
                mainObject.BuyerDisplayName = objObjectsInfo.ACObjectName;
                mainObject.BuyerLegalName = objObjectsInfo.ACObjectName;
                mainObject.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                mainObject.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                GEDistrictsInfo objDistrictsInfo =
                (GEDistrictsInfo)(new GEDistrictsController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                if (objDistrictsInfo != null)
                    mainObject.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                GEStateProvincesInfo objStateProvincesInfo =
                (GEStateProvincesInfo)(new GEStateProvincesController()).GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                if (objStateProvincesInfo != null)
                    mainObject.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                mainObject.BuyerCountryCode = "VN";
                mainObject.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                mainObject.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
                mainObject.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                mainObject.BuyerCode = objObjectsInfo.ACObjectNo;
            }
            if (objInvoicesInfo.ARInvoiceSOContactName != string.Empty)
                mainObject.BuyerDisplayName = objInvoicesInfo.ARInvoiceSOContactName;
            if (objInvoicesInfo.ARObjectType == ObjectType.Customer.ToString())
            {
                ARCustomersInfo objCustomersInfo
                    = (ARCustomersInfo)(new ARCustomersController()).GetObjectFromDataRow(
                    BOSApp.GetObjectFromCatche("ARCustomers", "ARCustomerID", objInvoicesInfo.FK_ARCustomerID));
                if (objCustomersInfo != null && objCustomersInfo.ARCustomerTypeCombo != string.Empty)
                {
                    mainObject.BuyerType = ADConfigValueUtility.GetConfigTextByGroupAndValue("CustomerType", objCustomersInfo.ARCustomerTypeCombo);
                }
            }
            #endregion
            #region Get default Customer Bank
            if (objInvoicesInfo.ARInvoiceTaxNumber != string.Empty)
                mainObject.BuyerTaxCode = objInvoicesInfo.ARInvoiceTaxNumber;
            List<ACListAccountBanksInfo> listBank = (new ACListAccountBanksController()).GetListByACObject(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
            if (listBank != null && listBank.Count > 0)
            {
                mainObject.BuyerBankName = listBank[0].ACListAccountBankName;
                mainObject.BuyerBankAccount = listBank[0].ACListAccountBankAccountHolder;
                mainObject.BuyerBankNumber = listBank[0].ACListAccountBankAccount;
            }
            #endregion

            mainObject.SystemCode = "LHD_TEST";

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
                    objEInvoiceDetailsInfo.ItemName = string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName : objProductsInfo.ICProductName2;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                }
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectFromDataRow(BOSApp.GetObjectFromCatche("ICMeasureUnits", "ICMeasureUnitID", o.FK_ICMeasureUnitID));
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = objMeasureUnitsInfo.ICMeasureUnitName.Substring(0, 1).ToUpper();
                    objEInvoiceDetailsInfo.UnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                }
                objEInvoiceDetailsInfo.UnitPrice = o.ARInvoiceItemProductUnitPrice;
                objEInvoiceDetailsInfo.Quantity = o.ARInvoiceItemProductQty;
                //objEInvoiceDetailsInfo.ItemTotalAmountWithoutVat = o.ARInvoiceItemProductBeforeTaxUnitPrice * o.ARInvoiceItemProductQty;
                objEInvoiceDetailsInfo.VatPercentage = o.ARInvoiceItemProductTaxPercent;
                objEInvoiceDetailsInfo.VatAmount = o.ARInvoiceItemTaxAmount;
                objEInvoiceDetailsInfo.Promotion = false;

                EInvoiceDetailsList.Add(objEInvoiceDetailsInfo);
                lineNumber++;
            });

            mainObject.SumOfTotalLineAmountWithoutVAT = objInvoicesInfo.ARInvoiceSubTotalAmount;
            mainObject.TotalAmountWithoutVAT = objInvoicesInfo.ARInvoiceSubTotalAmount - objInvoicesInfo.ARInvoiceDiscountFix;
            mainObject.TotalAmountWithVATFrn = objInvoicesInfo.ARInvoiceTaxPercent;
            mainObject.TotalVATAmount = objInvoicesInfo.ARInvoiceTaxAmount;
            mainObject.TotalAmountWithVAT = objInvoicesInfo.ARInvoiceTotalAmount;
            mainObject.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(mainObject.TotalAmountWithVAT.ToString(), objInvoicesInfo.FK_GECurrencyID);
            mainObject.DiscountAmount = objInvoicesInfo.ARInvoiceDiscountFix;
            mainObject.ACEInvoiceGeneralType = EInvoiceGeneralType.Replace.ToString();

            EInvoiceDetailsList.GridControl.RefreshDataSource();
            UpdateMainObjectBindingSource();
        }

        public void GenerateEntityForNewAdjust(ARInvoicesInfo objInvoicesInfo, List<ARInvoiceItemsInfo> invoiceItems, ACEInvoiceTypesInfo objEInvoiceTypesInfo, String originalInvoiceId, bool isIncrease)
        {
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            mainObject.SellerAppRecordId = objInvoicesInfo.ARInvoiceNo;
            mainObject.ACEInvoiceGeneralNo = objInvoicesInfo.ARInvoiceNo;
            mainObject.InvoiceType = objEInvoiceTypesInfo.ACEInvoiceTypeNo;
            mainObject.TemplateCode = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
            mainObject.InvoiceSeries = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            //mainObject.InvoiceNumber = objEInvoiceTypesInfo.objEInvoiceTypesInfo;
            mainObject.InvoiceName = objEInvoiceTypesInfo.ACEInvoiceTypeName;
            mainObject.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            //mainObject.SignedDate = objInvoicesInfo.ARInvoiceDate;
            //mainObject.submittedDate =
            mainObject.ContractNumber = objInvoicesInfo.ARInvoicePONo;
            mainObject.ContractDate = objInvoicesInfo.ARInvoiceDate;
            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objInvoicesInfo.FK_GECurrencyID);
            if (objCurrenciesInfo != null)
                mainObject.CurrencyCode = objCurrenciesInfo.GECurrencyNo;
            mainObject.ExchangeRate = objInvoicesInfo.ARInvoiceExchangeRate;
            mainObject.InvoiceNote = objInvoicesInfo.ARInvoiceDesc;
            mainObject.AdjustmentType = (int)EInvoiceGeneralType.Adjust;
            mainObject.OriginalInvoiceId = originalInvoiceId;
            //mainObject.AdditionalReferenceDesc =
            //mainObject.AdditionalReferenceDate =

            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.CSCompanyID);
            if (objCompanysInfo != null)
            {
                mainObject.SellerLegalName = objCompanysInfo.CSCompanyDesc;
                mainObject.SellerTaxCode = objCompanysInfo.CSCompanyTaxNumber;
                mainObject.SellerAddressLine = objCompanysInfo.CSCompanyAddressLine1;
                mainObject.SellerPostalCode = objCompanysInfo.CSCompanyAddressPostalCode;
                //mainObject.SellerDistrictName =
                mainObject.SellerCityName = objCompanysInfo.CSCompanyAddressStateProvince;
                //mainObject.SellerCountryCode = "VN";
                mainObject.SellerPhoneNumber = objCompanysInfo.CSCompanyPhone;
                mainObject.SellerFaxNumber = objCompanysInfo.CSCompanyFax;
                mainObject.SellerEmail = objCompanysInfo.CSCompanyEmail;
                mainObject.SellerBankName = objCompanysInfo.CSCompanyBankName;
                mainObject.SellerBankAccount = objCompanysInfo.CSCompanyBankCode;
                //mainObject.SellerContactPersonName
            }

            ACObjectsController objObjectsController = new ACObjectsController();
            GEDistrictsController objDistrictsController = new GEDistrictsController();
            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
            if (objObjectsInfo != null)
            {
                mainObject.BuyerDisplayName = objObjectsInfo.ACObjectName;
                mainObject.BuyerLegalName = objObjectsInfo.ACObjectName;
                mainObject.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                mainObject.BuyerAddressLine = objObjectsInfo.ACObjectDeliveryAddressLine1;
                //objEInvoiceGeneralsInfo.BuyerEmail =
                //objEInvoiceGeneralsInfo.BuyerBankName =
                //objEInvoiceGeneralsInfo.BuyerBankAccount =
                GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)objDistrictsController.GetObjectByID(objObjectsInfo.FK_GEDeliveryDistrictID);
                if (objDistrictsInfo != null)
                    mainObject.BuyerDistrictName = objDistrictsInfo.GEDistrictName;
                GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(objObjectsInfo.FK_GEDeliveryStateProvinceID);
                if (objStateProvincesInfo != null)
                    mainObject.BuyerCityName = objStateProvincesInfo.GEStateProvinceName;
                //mainObject.BuyerCountryCode = "VN";
                mainObject.BuyerPhoneNumber = objObjectsInfo.ACObjectContactPhone;
                mainObject.BuyerFaxNumber = objObjectsInfo.ACObjectContactFax;
            }

            mainObject.SystemCode = "LHD_TEST";

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
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                    objEInvoiceDetailsInfo.ItemName = string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName : objProductsInfo.ICProductName2;
                    objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                }
                objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(o.FK_ICMeasureUnitID);
                if (objMeasureUnitsInfo != null)
                {
                    objEInvoiceDetailsInfo.UnitCode = objMeasureUnitsInfo.ICMeasureUnitName.Substring(0, 1).ToUpper();
                    objEInvoiceDetailsInfo.UnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                }
                objEInvoiceDetailsInfo.UnitPrice = o.ARInvoiceItemProductUnitPrice;
                objEInvoiceDetailsInfo.Quantity = o.ARInvoiceItemProductQty;
                //comment out tam thoi
                //objEInvoiceDetailsInfo.ItemTotalAmountWithoutVat = o.ARInvoiceItemProductBeforeTaxUnitPrice * o.ARInvoiceItemProductQty;
                objEInvoiceDetailsInfo.VatPercentage = o.ARInvoiceItemProductTaxPercent;
                objEInvoiceDetailsInfo.VatAmount = o.ARInvoiceItemTaxAmount;
                objEInvoiceDetailsInfo.Promotion = false;
                objEInvoiceDetailsInfo.IsIncreaseItem = isIncrease;

                EInvoiceDetailsList.Add(objEInvoiceDetailsInfo);
                lineNumber++;
            });

            mainObject.SumOfTotalLineAmountWithoutVAT = objInvoicesInfo.ARInvoiceSubTotalAmount;
            mainObject.TotalAmountWithoutVAT = objInvoicesInfo.ARInvoiceSubTotalAmount - objInvoicesInfo.ARInvoiceDiscountFix;
            //comment out tam thoi
            //mainObject.TotalVATAmount = objInvoicesInfo.ARInvoiceSubTaxAmount;
            mainObject.TotalAmountWithVAT = objInvoicesInfo.ARInvoiceTotalAmount;
            mainObject.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(mainObject.TotalAmountWithVAT.ToString(), objInvoicesInfo.FK_GECurrencyID);
            mainObject.DiscountAmount = objInvoicesInfo.ARInvoiceDiscountFix;
            mainObject.IsTotalAmountPos = isIncrease;
            mainObject.IsTotalAmtWithoutVatPos = isIncrease;
            mainObject.IsTotalVATAmountPos = true;
            mainObject.IsDiscountAmtPos = true;
            mainObject.ACEInvoiceGeneralType = EInvoiceGeneralType.Adjust.ToString();

            EInvoiceDetailsList.GridControl.RefreshDataSource();
            UpdateMainObjectBindingSource();
        }
        public override void DuplicateModuleObjectList()
        {
            EInvoiceDetailsList.Duplicate();
        }
    }
}
