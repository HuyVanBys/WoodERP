using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSComponent;
using BOSCommon;
using BOSCommon.Enums;
using BOSCommon.Constants;
using System.Data;
using BOSLib;
using BOSERP.Utilities;
using Localization;
using Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BOSERP.Modules.ElectronicInvoiceMInvoice
{
    public class ElectronicInvoiceMInvoiceModule : BaseModuleERP
    {
        #region Constant
        public const string EInvoiceGridControlName = "fld_dgcEInvoiceTemplates";
        public const string FilePathTextBoxName = "fld_txtFilePath";
        public enum ACEInvoiceImportColumns
        {
            ID
            , ACEInvoiceGeneralNo
            , ContractNumber
            , InvoiceAppRecordId
            , ContractDate
            , ACEInvoicePaymentMethodName
            , CurrencyCode
            , ExchangeRate
            , TemplateCode
            , InvoiceSeries
            , InvoiceNote
            , BuyerCode
            , BuyerDisplayName
            , BuyerAddressLine
            , BuyerPhoneNumber
            , BuyerTaxCode
            , BuyerBankName
            , BuyerBankNumber
            , BuyerEmail
            , SumOfTotalLineAmountWithoutVAT
            , DiscountPercent
            , DiscountAmount
            , TaxOfficeCode
            , TotalVATAmount
            , TotalAmountWithVAT
            , ItemCode
            , ItemName
            , UnitCode
            , Quantity
            , UnitPrice
            , ItemDiscountPercent
            , ItemDiscountAmount
            , OrderIndex
        }
        #endregion

        #region Public properties
        private string DocumentFileName = string.Empty;

        private Workbook WorkBook;

        private Worksheet WorkSheet;

        private Microsoft.Office.Interop.Excel.Application App;
        #endregion

        #region Constructor
        public ElectronicInvoiceMInvoiceModule()
        {
            Name = ModuleName.ElectronicInvoiceMInvoice;
            CurrentModuleEntity = new ElectronicInvoiceMInvoiceEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        #endregion

        #region General Function
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public override int ActionSave()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            mainObject.SumOfTotalLineAmountWithoutVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT);
            mainObject.DiscountAmount = Math.Round(mainObject.DiscountAmount);
            mainObject.TotalVATAmount = Math.Round(mainObject.TotalVATAmount);
            mainObject.TotalAmountWithVAT = Math.Round(mainObject.TotalAmountWithVAT);
            foreach (ACEInvoiceDetailsInfo entItem in entity.EInvoiceDetailsList)
            {
                entItem.UnitPrice = Math.Round(entItem.UnitPrice, 2);
                entItem.Quantity = Math.Round(entItem.Quantity, 3);
                entItem.VatPercentage = Math.Round(entItem.VatPercentage);
                entItem.VatAmount = Math.Round(entItem.VatAmount);
            }
            int documentID = base.ActionSave();
            if (documentID > 0)
                SaveDocumentFile();

            return documentID;
        }

        public override void ActionDuplicate()
        {
            ACEInvoiceGeneralsInfo mainObjectOLD = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.MainObject.Clone();
            base.ActionDuplicate();
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.MainObject;
            mainObject.OriginalInvoiceId = mainObject.InvoiceNumber;
            mainObject.SubmittedDate = DateTime.MaxValue;
            mainObject.InvoiceNumber = string.Empty;
            mainObject.SystemCode = string.Empty;
            mainObject.SellerSignatureHash = string.Empty;
            mainObject.ACEInvoiceGeneralID = 0;
            mainObject.ACEInvoiceGeneralStatus = string.Empty;
            mainObject.ACEInvoiceGeneralHDStatus = string.Empty;
            mainObject.ContractDate = DateTime.Now;
            mainObject.ACEInvoiceGeneralIsAdjustmentInv = true;
            mainObject.PublicKey = string.Empty;
            CurrentModuleEntity.UpdateMainObjectBindingSource();
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.MainObject;
            
            #region MInvoice
            string[] invoiceHDStatusArray = new string[] { "Value5", "Value11", "Value17", "Value19", "Value21", "Value13" };

            ParentScreen.SetEnableOfToolbarButton("New", false);
            ParentScreen.SetEnableOfToolbarButton("Edit", false);
            ParentScreen.SetEnableOfToolbarButton("Cancel", false);
            ParentScreen.SetEnableOfToolbarButton("Save", false);
            ParentScreen.SetEnableOfToolbarButton("NewReplace", false);
            ParentScreen.SetEnableOfToolbarButton("ImportInv", false);
            ParentScreen.SetEnableOfToolbarButton("GetStatusInv", false);
            ParentScreen.SetEnableOfToolbarButton("ImportAndSign", false);
            ParentScreen.SetEnableOfToolbarButton("AdjustCustomerInfo", false);
            ParentScreen.SetEnableOfToolbarButton("AdjustIncrease", false);
            ParentScreen.SetEnableOfToolbarButton("AdjustDecrease", false);
            ParentScreen.SetEnableOfToolbarButton("DeleteInv", false);
            ParentScreen.SetEnableOfToolbarButton("SignInv", false);
            ParentScreen.SetEnableOfToolbarButton("UpdateInv", false);
            ParentScreen.SetEnableOfToolbarButton("CancelInv", false);
            ParentScreen.SetEnableOfToolbarButton("DeleteInvNoneKey", false);
            if (mainObject.ACEInvoiceGeneralID == 0)
            {
                ParentScreen.SetEnableOfToolbarButton("Cancel", true);
                ParentScreen.SetEnableOfToolbarButton("Save", true);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(mainObject.PublicKey))
                {
                    ParentScreen.SetEnableOfToolbarButton("New", true);
                    ParentScreen.SetEnableOfToolbarButton("Edit", true);
                    ParentScreen.SetEnableOfToolbarButton("ImportInv", true);
                    ParentScreen.SetEnableOfToolbarButton("ImportAndSign", true);
                    ParentScreen.SetEnableOfToolbarButton("UpdateInv", true);
                    ParentScreen.SetEnableOfToolbarButton("NewReplace", true);
                    ParentScreen.SetEnableOfToolbarButton("DeleteInvNoneKey", true);
                }
                if (!string.IsNullOrWhiteSpace(mainObject.PublicKey)
                    && mainObject.ACEInvoiceGeneralIsAdjustmentInv
                    && mainObject.ACEInvoiceGeneralStatus.Equals(string.Empty))
                {
                    ParentScreen.SetEnableOfToolbarButton("New", true);
                    ParentScreen.SetEnableOfToolbarButton("Edit", true);
                    ParentScreen.SetEnableOfToolbarButton("AdjustCustomerInfo", true);
                    ParentScreen.SetEnableOfToolbarButton("AdjustIncrease", true);
                    ParentScreen.SetEnableOfToolbarButton("AdjustDecrease", true);
                }
                if (mainObject.ACEInvoiceGeneralStatus.Equals("Value1"))
                {
                    ParentScreen.SetEnableOfToolbarButton("New", true);
                    ParentScreen.SetEnableOfToolbarButton("Edit", true);
                    ParentScreen.SetEnableOfToolbarButton("ImportInv", true);
                    ParentScreen.SetEnableOfToolbarButton("SignInv", true);
                    ParentScreen.SetEnableOfToolbarButton("GetStatusInv", true);
                    ParentScreen.SetEnableOfToolbarButton("CancelInv", true);
                }
                if (mainObject.ACEInvoiceGeneralStatus.Equals("Value2"))
                {
                    ParentScreen.SetEnableOfToolbarButton("New", true);
                    ParentScreen.SetEnableOfToolbarButton("Edit", true);
                    ParentScreen.SetEnableOfToolbarButton("GetStatusInv", true);
                    ParentScreen.SetEnableOfToolbarButton("DeleteInv", true);
                    //if (mainObject.ACEInvoiceGeneralIsAdjustmentInv)
                    //{
                    //    ParentScreen.SetEnableOfToolbarButton("AdjustCustomerInfo", true);
                    //    ParentScreen.SetEnableOfToolbarButton("AdjustIncrease", true);
                    //    ParentScreen.SetEnableOfToolbarButton("AdjustDecrease", true);
                    //}
                }
                if (mainObject.ACEInvoiceGeneralStatus.Equals("Value2")
                    && invoiceHDStatusArray.ToList().Contains(mainObject.ACEInvoiceGeneralHDStatus))
                {
                    ParentScreen.SetEnableOfToolbarButton("NewReplace", false);
                    ParentScreen.SetEnableOfToolbarButton("ImportInv", false);
                    ParentScreen.SetEnableOfToolbarButton("GetStatusInv", true);
                    ParentScreen.SetEnableOfToolbarButton("ImportAndSign", false);
                    ParentScreen.SetEnableOfToolbarButton("AdjustCustomerInfo", false);
                    ParentScreen.SetEnableOfToolbarButton("AdjustIncrease", false);
                    ParentScreen.SetEnableOfToolbarButton("AdjustDecrease", false);
                    ParentScreen.SetEnableOfToolbarButton("DeleteInv", true);

                    if (mainObject.ACEInvoiceGeneralHDStatus.Equals("Value13"))
                        ParentScreen.SetEnableOfToolbarButton("DeleteInv", false);
                }
            }
            #endregion
        }

        public List<string> GetPaymentDataSource()
        {
            DataSet ds = (new ACEInvoicePaymentMethodsController()).GetAllObjects();
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows.Cast<DataRow>().Select(x => x["ACEInvoicePaymentMethodName"].ToString()).Distinct().ToList();
            }
            return null;
        }

        public void UpdateTotalAmount()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            mainObject.SumOfTotalLineAmountWithoutVAT = 0;
            mainObject.TotalAmountWithoutVAT = 0;
            foreach (ACEInvoiceDetailsInfo entItem in entity.EInvoiceDetailsList)
            {
                entItem.DiscountAmount = entItem.Quantity * entItem.UnitPrice * entItem.DiscountPercent / 100;
                entItem.ACEInvoiceDetailTotalAmount = entItem.Quantity * entItem.UnitPrice - entItem.DiscountAmount;

                if (entItem.ACEInvoiceDetailFunction == string.Empty)
                {
                    mainObject.SumOfTotalLineAmountWithoutVAT += Math.Round(entItem.ACEInvoiceDetailTotalAmount);
                }
            }

            mainObject.DiscountAmount = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT * mainObject.DiscountPercent / 100);
            decimal taxPercent = 0;
            if (mainObject.TaxOfficeCode == "5%")
                taxPercent = 5;
            else if (mainObject.TaxOfficeCode == "8%")
                taxPercent = 8;
            else if (mainObject.TaxOfficeCode == "10%")
                taxPercent = 10;
            mainObject.TotalVATAmount = Math.Round((mainObject.SumOfTotalLineAmountWithoutVAT - mainObject.DiscountAmount) * taxPercent / 100);
            mainObject.TotalAmountWithoutVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT - mainObject.DiscountAmount);
            mainObject.TotalAmountWithVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT -
                                                    mainObject.DiscountAmount +
                                                    mainObject.TotalVATAmount);
            mainObject.TotalAmount = mainObject.TotalAmountWithVAT;

            //mainObject.TotalVATAmount = entity.EInvoiceDetailsList.Sum(p => Math.Round(p.VatAmount));
            //mainObject.TotalAmountWithoutVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT - mainObject.DiscountAmount);
            //mainObject.TotalAmountWithVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT -
            //                                           mainObject.DiscountAmount +
            //                                           mainObject.TotalVATAmount);
            //mainObject.TotalAmount = mainObject.TotalAmountWithVAT;

            int GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GECurrencyID;
            if (BOSApp.LookupTables.ContainsKey("GECurrencies"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["GECurrencies"];
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<GECurrenciesInfo> listCrr = (new GECurrenciesController()).GetListDataSet(ds);
                    if (listCrr != null)
                    {
                        GECurrenciesInfo obj = listCrr.Where(x => x.GECurrencyNo == mainObject.CurrencyCode).FirstOrDefault();
                        if (obj != null)
                            GECurrencyID = obj.GECurrencyID;
                    }
                }
            }
            mainObject.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(mainObject.TotalAmountWithVAT.ToString(), GECurrencyID);
            entity.EInvoiceDetailsList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            mainObject.ACEInvoiceGeneralStatus = string.Empty;
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeObject(string objectAccessKey)
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            mainObject.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                mainObject.ACObjectType = objObjectsInfo.ACObjectType;
                mainObject.BuyerCode = objObjectsInfo.ACObjectNo;
                mainObject.BuyerLegalName = objObjectsInfo.ACObjectName;
                mainObject.BuyerDisplayName = objObjectsInfo.ACObjectContactName;
                mainObject.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                mainObject.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
                mainObject.BuyerAddressLine = objObjectsInfo.ACObjectContactAddressLine3;
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

                //if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                //{
                //    mainObject.BuyerType = "Cá nhân";
                //}
                //else if (objObjectsInfo.ACObjectType == ObjectType.Supplier.ToString())
                //{
                //    mainObject.BuyerType = "Doanh nghiệp";
                //}

                #region Get default Customer Bank                
                List<ACListAccountBanksInfo> listBank = (new ACListAccountBanksController()).GetListByACObject(mainObject.FK_ACObjectID, mainObject.ACObjectType);
                if (listBank != null && listBank.Count > 0)
                {
                    mainObject.BuyerBankName = listBank[0].ACListAccountBankName;
                    mainObject.BuyerBankAccount = listBank[0].ACListAccountBankAccountHolder;
                    mainObject.BuyerBankNumber = listBank[0].ACListAccountBankAccount;
                }
                #endregion

                //Invalidate ProductItemCustomerCode START
                if (BOSApp.CurrentProductList.Count > 0)
                {
                    entity.EInvoiceDetailsList.ForEach(p =>
                    {
                        p.ProductItemCustomerCode = BOSApp.CurrentProductList.Exists(o => o.ICProductNo == p.ItemCode)
                            ? BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductNo == p.ItemCode).ICProductCustomerNumber
                            : string.Empty;
                    });
                }
                //Invalidate ProductItemCustomerCode END

                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        public void ChangeCurrencyID(int currencyID)
        {
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(currencyID);
            if (currency != null)
            {
                mainObject.CurrencyCode = currency.GECurrencyName;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ChangeItemCode(ACEInvoiceDetailsInfo objEInvoiceDetailsInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByNo(objEInvoiceDetailsInfo.ItemCode);
            if (objProductsInfo != null)
            {
                objEInvoiceDetailsInfo.ItemCode = objProductsInfo.ICProductNo;
                objEInvoiceDetailsInfo.ItemName = string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName : objProductsInfo.ICProductName2;
                objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
                objEInvoiceDetailsInfo.Promotion = objProductsInfo.ICProductPromotionCheck;                
                objEInvoiceDetailsInfo.ProductItemCustomerCode = BOSApp.CurrentProductList.Exists(p => p.ICProductNo == objEInvoiceDetailsInfo.ItemCode)
                    ? BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductNo == objEInvoiceDetailsInfo.ItemCode).ICProductCustomerNumber
                    : string.Empty;
            }
        }

        public void RemoveSelectedItem()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            entity.EInvoiceDetailsList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            ACEInvoiceGeneralsInfo searchObject = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds;
            ds = objEInvoiceGeneralsController.GetEInvoiceGeneralList(searchObject.ACEInvoiceGeneralNo, searchObject.ACEInvoiceGeneralFromDate, searchObject.ACEInvoiceGeneralToDate);
            DataSet result = new DataSet();
            DataView dv = ds.Tables[0].DefaultView;
            dv.Sort = "InvoiceNumber ASC";
            result.Tables.Add(dv.ToTable());
            return ds;
        }
        #endregion

        #region EInvoice M-Invoice
        public void ActionImportInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ImportInv_MInv(mainObject, false, string.IsNullOrWhiteSpace(mainObject.PublicKey) ? true : false))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionImportAndSignInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ImportInv_MInv(mainObject, true, true))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionAdjustInfoInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (string.IsNullOrWhiteSpace(mainObject.AdditionalReferenceDesc))
            {
                MessageBox.Show("Số văn bản thỏa thuận không được để trống", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            entity.SetPropertyChangeEventLock(false);
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.AdjustInfoInv_MInv(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionReplaceInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            List<ACEInvoiceGeneralsInfo> eInvList = (new ACEInvoiceGeneralsController()).GetAllOriginalEInvoiceSigned();
            guiFind<ACEInvoiceGeneralsInfo> guiFind = new guiFind<ACEInvoiceGeneralsInfo>("ACEInvoiceGenerals", eInvList, this, false);
            if (guiFind.ShowDialog() != DialogResult.OK)
                return;

            ACEInvoiceGeneralsInfo result = (ACEInvoiceGeneralsInfo)guiFind.SelectedObjects.FirstOrDefault();
            if (result == null)
                return;

            if (string.IsNullOrWhiteSpace(mainObject.AdditionalReferenceDesc))
            {
                MessageBox.Show("Số văn bản thỏa thuận không được để trống", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            entity.SetPropertyChangeEventLock(false);
            mainObject.PublicKey = result.PublicKey;
            mainObject.OriginalInvoiceId = result.InvoiceNumber;
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ReplaceInv_MInv(mainObject))
            {
                result.ACEInvoiceGeneralHDStatus = "Value17";
                (new ACEInvoiceGeneralsController()).UpdateObject(result);
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionDeleteInv_MInv() //Hủy hóa đơn
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (MessageBox.Show("Bạn muốn Hủy bỏ hóa đơn này?", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            if (string.IsNullOrWhiteSpace(mainObject.AdditionalReferenceDesc))
            {
                MessageBox.Show("Số văn bản thỏa thuận không được để trống", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            entity.SetPropertyChangeEventLock(false);
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ActionDeleteInv_MInv(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionGetInfoInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            DateTime startDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            DateTime endDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            guiChooseReportPeriod guiChooseReportPeriod = new guiChooseReportPeriod(startDate, endDate);
            guiChooseReportPeriod.Module = this;
            if (guiChooseReportPeriod.ShowDialog() != DialogResult.OK)
                return;

            ACEInvoiceGeneralsController controller = new ACEInvoiceGeneralsController();
            List<ACEInvoiceGeneralsInfo> updateList = controller.GetEInvoiceGeneralForUpdateStatus(guiChooseReportPeriod.FromDate, guiChooseReportPeriod.ToDate);
            BOSProgressBar.Start("Hệ thống đang thực hiện !");            
            updateList.ForEach(o =>
            {
                ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(o.FK_ACTaxUnitID);
                mInvoiceHelper.ActionGetInfoInv_MInv(o);
            });
            BOSProgressBar.Close();
            Search();

            //ActionGetInfoCurrentInv_MInv();
        }

        public void ActionGetInfoCurrentInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ActionGetInfoInv_MInv(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionSignInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ActionSignInv_MInv(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionUpdateInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            List<ACEInvoiceGeneralsInfo> eInvList = (new ACEInvoiceGeneralsController()).GetAllEInvoiceNotSigned();
            guiFind<ACEInvoiceGeneralsInfo> guiFind = new guiFind<ACEInvoiceGeneralsInfo>("ACEInvoiceGenerals", eInvList, this, false);
            if (guiFind.ShowDialog() != DialogResult.OK)
                return;

            ACEInvoiceGeneralsInfo result = (ACEInvoiceGeneralsInfo)guiFind.SelectedObjects.FirstOrDefault();
            if (result == null)
                return;

            entity.SetPropertyChangeEventLock(false);
            mainObject.PublicKey = result.PublicKey;
            mainObject.InvoiceNumber = result.InvoiceNumber;
            mainObject.ACEInvoiceGeneralStatus = result.ACEInvoiceGeneralStatus;
            mainObject.ACEInvoiceGeneralHDStatus = result.ACEInvoiceGeneralHDStatus;
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ImportInv_MInv(mainObject, false, false))
            {
                result.PublicKey = string.Empty;
                result.InvoiceNumber = string.Empty;
                result.ACEInvoiceGeneralStatus = string.Empty;
                result.ACEInvoiceGeneralHDStatus = string.Empty;
                (new ACEInvoiceGeneralsController()).UpdateObject(result);
                (new ACEInvoiceGeneralsController()).UpdateObject(mainObject);
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mainObject.PublicKey = string.Empty;
                mainObject.InvoiceNumber = string.Empty;
                mainObject.ACEInvoiceGeneralStatus = string.Empty;
                mainObject.ACEInvoiceGeneralHDStatus = string.Empty;
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionCancelInv_MInv()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            ApiMInvoiceEInvoiceHelper mInvoiceHelper = new ApiMInvoiceEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (mInvoiceHelper.ActionCancelInv_MInv(mainObject))
            {
                ActionDelete();
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.UpdateMainObjectBindingSource();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public override void ActionDelete()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (entity.EInvoiceDetailsList.Count > 0)
            {
                ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
                objEInvoiceDetailsController.DeleteByForeignColumn("FK_ACEInvoiceGeneralID", mainObject.ACEInvoiceGeneralID);
            }
            base.ActionDelete();
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            ParentScreen.SetEnableOfToolbarButton("New", false);
            ParentScreen.SetEnableOfToolbarButton("Edit", false);
            ParentScreen.SetEnableOfToolbarButton("Cancel", true);
            ParentScreen.SetEnableOfToolbarButton("Save", true);
            ParentScreen.SetEnableOfToolbarButton("NewReplace", false);
            ParentScreen.SetEnableOfToolbarButton("ImportInv", false);
            ParentScreen.SetEnableOfToolbarButton("GetStatusInv", false);
            ParentScreen.SetEnableOfToolbarButton("ImportAndSign", false);
            ParentScreen.SetEnableOfToolbarButton("AdjustCustomerInfo", false);
            ParentScreen.SetEnableOfToolbarButton("AdjustIncrease", false);
            ParentScreen.SetEnableOfToolbarButton("AdjustDecrease", false);
            ParentScreen.SetEnableOfToolbarButton("DeleteInv", false);
            ParentScreen.SetEnableOfToolbarButton("SignInv", false);
        }

        public void ChangePaymentMethod(int paymentMethodID)
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;

            ACEInvoicePaymentMethodsInfo objEInvoicePaymentMethodsInfo = (ACEInvoicePaymentMethodsInfo)(new ACEInvoicePaymentMethodsController()).GetPaymentMeThodByID(paymentMethodID);
            if (objEInvoicePaymentMethodsInfo == null)
                return;

            mainObject.FK_ACEInvoicePaymentMethodID = paymentMethodID;
            mainObject.ACEInvoicePaymentMethodName = objEInvoicePaymentMethodsInfo.ACEInvoicePaymentMethodName;

            entity.UpdateMainObjectBindingSource();
        }
        #endregion

        #region Orther func
        public void ExportTemplate()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string filePath = System.Windows.Forms.Application.StartupPath + @"\Template\EInvoice.xlsx";
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);
                // bind dữ liệu
                //ExportExcelInvoice(guiSearchInvoice.SelectedInvoiceItemList, worksheet, 1, "A", "AE");

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = @"Tệp Excel (*.xls)|*.xls|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = @"EInvoice.xls";
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fullFileName = saveDialog.FileName;

                    WorkBook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    WorkBook.Saved = true;

                }
                ReleaseDataImport();
                BOSProgressBar.Close();
            }
            catch (Exception ex)
            {
                ReleaseDataImport();
                BOSProgressBar.Close();
                MessageBox.Show(ex.ToString()
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
            }
        }

        public void ReleaseDataImport()
        {
            WorkBook.Close(false, null, null);
            App.Quit();
            ReleaseObject(WorkSheet);
            ReleaseObject(WorkBook);
            ReleaseObject(App);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public void ImportTemplate()
        {
            List<Range> ranges = InitializeDataImport();
            if (ranges == null)
            {
                return;
            }

            if (ranges.Count() != 1)
            {
                MessageBox.Show(PriceSheetLocalizedResources.TeamplateMalformed, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(ImportDataLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);
            Range woods = ranges[0];
            //ImportEInvoice(woods);
            Search();
            BOSProgressBar.Close();
        }

        public List<Range> InitializeDataImport()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ImportDataLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
                filePath = dialog.FileName;

            if (!String.IsNullOrEmpty(filePath))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                List<Range> result = new List<Range>();
                for (int i = 1; i <= WorkBook.Worksheets.Count; i++)
                {
                    WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(i);
                    Range range = WorkSheet.UsedRange;
                    result.Add(range);
                }
                return result;
            }
            return null;
        }

        //private bool ImportEInvoice(Range range)
        //{
        //    if (range == null)
        //        return false;

        //    ACEInvoiceGeneralsInfo mainObject = new ACEInvoiceGeneralsInfo();
        //    ACEInvoiceDetailsInfo itemObject = new ACEInvoiceDetailsInfo();
        //    ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
        //    ACEInvoicePaymentMethodsInfo objEInvoicePaymentMethodsInfo = new ACEInvoicePaymentMethodsInfo();
        //    ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
        //    List<ACEInvoiceGeneralsInfo> eInvociGenerateList = new List<ACEInvoiceGeneralsInfo>();
        //    string cellValue = string.Empty;
        //    decimal value = 0;
        //    ACEInvoiceGeneralsController controller = new ACEInvoiceGeneralsController();
        //    System.Data.DataTable dtImports = controller.ACEInvoiceImportTables();

        //    dtImports.Clear();
        //    int index = 0;
        //    try
        //    {
        //        for (int row = 5; row <= range.Rows.Count; row++)
        //        {
        //            DataRow dataRow = dtImports.NewRow();
        //            if (!string.IsNullOrWhiteSpace((range.Cells[row, (int)ACEInvoiceImportColumns.ACEInvoiceGeneralNo] as Range).Text.ToString()))
        //            {
        //                index++;
        //                dataRow[ACEInvoiceImportColumns.ACEInvoiceGeneralNo.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.ACEInvoiceGeneralNo] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.ContractNumber.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.ContractNumber] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.InvoiceAppRecordId.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.InvoiceAppRecordId] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.ContractDate.ToString()] = ToDateTime((range.Cells[row, (int)ACEInvoiceImportColumns.ContractDate] as Range).Text.ToString().Trim());
        //                dataRow[ACEInvoiceImportColumns.ACEInvoicePaymentMethodName.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.ACEInvoicePaymentMethodName] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.CurrencyCode.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.CurrencyCode] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.ExchangeRate.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.ExchangeRate] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.TemplateCode.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.TemplateCode] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.InvoiceSeries.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.InvoiceSeries] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.InvoiceNote.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.InvoiceNote] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerCode.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerCode] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerDisplayName.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerDisplayName] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerAddressLine.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerAddressLine] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerPhoneNumber.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerPhoneNumber] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerTaxCode.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerTaxCode] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerBankName.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerBankName] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerBankNumber.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerBankNumber] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.BuyerEmail.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.BuyerEmail] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.SumOfTotalLineAmountWithoutVAT.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.SumOfTotalLineAmountWithoutVAT] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.DiscountPercent.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.DiscountPercent] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.DiscountAmount.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.DiscountAmount] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.TaxOfficeCode.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.TaxOfficeCode] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.TotalVATAmount.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.TotalVATAmount] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.TotalAmountWithVAT.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.TotalAmountWithVAT] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.ItemCode.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.ItemCode] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.ItemName.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.ItemName] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.UnitCode.ToString()] = (range.Cells[row, (int)ACEInvoiceImportColumns.UnitCode] as Range).Text.ToString().Trim();
        //                dataRow[ACEInvoiceImportColumns.Quantity.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.Quantity] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.UnitPrice.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.UnitPrice] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.ItemDiscountPercent.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.ItemDiscountPercent] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.ItemDiscountAmount.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.ItemDiscountAmount] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.ItemDiscountAmount.ToString()] = ToDecimal((range.Cells[row, (int)ACEInvoiceImportColumns.ItemDiscountAmount] as Range).Text.ToString());
        //                dataRow[ACEInvoiceImportColumns.OrderIndex.ToString()] = index;

        //                dtImports.Rows.Add(dataRow);
        //            }
        //            else
        //            {
        //                goto Outer;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Đã xảy ra lỗi trong quá trình Import. Vui lòng xem lại file !!" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //Outer:
        //    SaveImport(dtImports);
        //    return true;
        //}

        private string GetConStr()
        {
            String strDatabase = ConfigurationManager.AppSettings["DatabaseName"];
            String strServer = ConfigurationManager.AppSettings["ServerName"];
            String strUser = ConfigurationManager.AppSettings["UserID"];
            string strPassword = ConfigurationManager.AppSettings["Password"];

            CryptorEngine crypt = new CryptorEngine();
            strPassword = crypt.Decrypt(strPassword, true);
            strUser = crypt.Decrypt(strUser, true);
            return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", strServer, strDatabase, strUser, strPassword);
        }

        public void SaveImport(System.Data.DataTable dsData)
        {
            string conStr = GetConStr();
            using (var conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = null;

                cmd = new SqlCommand();
                cmd.CommandText = "ACEInvoices_Imports";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = conn;

                var param = new SqlParameter();
                param.ParameterName = "@Type_ACEInvoiceImports";
                param.SqlDbType = SqlDbType.Structured;
                cmd.Parameters.Add(param);

                var param2 = new SqlParameter();
                param2.ParameterName = "@UserName";
                param2.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param2);

                var param3 = new SqlParameter();
                param3.ParameterName = "@BranchID";
                param3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param3);

                cmd.Parameters[param.ParameterName].Value = dsData;
                cmd.Parameters[param2.ParameterName].Value = BOSApp.CurrentUsersInfo.ADUserName;
                cmd.Parameters[param3.ParameterName].Value = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private bool IsMatchDecimal(string para)
        {
            Regex rgDecimal = new Regex(@"^-?(([1-9]\d*)|0)(.0*[1-9](0*[1-9])*)?$");
            return rgDecimal.IsMatch(para);
        }

        private decimal ToDecimal(string para)
        {
            string strDecimal = para.Trim().Replace(",", string.Empty).Replace(".", string.Empty);
            return IsMatchDecimal(strDecimal) ? Convert.ToDecimal(strDecimal) : 0;
        }

        private DateTime? ToDateTime(string para)
        {
            Regex r = new Regex(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$");
            if (!r.IsMatch(para.Trim()))
            {
                return null;
            }
            
            string[] partern = para.Split('/');
            return new DateTime(int.Parse(partern[2]), int.Parse(partern[1]), int.Parse(partern[0]));
        }
        #endregion

        #region Đính Kèm File
        public void SaveDocumentFile()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            List<ACFileAttachmentsInfo> documentTemplateList = entity.EInvoiceTemplateList.ToList();

            ACFileAttachmentsController objFileAttachmentsController = new ACFileAttachmentsController();
            ACFileAttachmentsInfo objFileAttachmentsInfo = new ACFileAttachmentsInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            documentTemplateList.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.ACFileAttachmentFileGUID))
                    return;

                entity.EInvoiceTemplateURLDic.TryGetValue(o.ACFileAttachmentID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.ACFileAttachmentFileGUID = ApiClientHelper.UpdateFile(value);
                o.ACFileAttachmentObjectID = mainObject.ACEInvoiceGeneralID;
                objFileAttachmentsController.UpdateObject(o);
            });
            entity.EInvoiceTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.EInvoiceTemplateList.GridControl.RefreshDataSource();
        }

        public void BrowseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
            //dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[ElectronicInvoiceMInvoiceModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddLoanReceiptTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[ElectronicInvoiceMInvoiceModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;

            if (entity.EInvoiceTemplateList.Exists(o => o.ACFileAttachmentName.Equals(DocumentFileName)))
            {
                MessageBox.Show(SaleOrderLocalizedResources.DuplicateFileName,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            ACFileAttachmentsInfo objFileAttachmentsInfo = new ACFileAttachmentsInfo();
            objFileAttachmentsInfo.ACFileAttachmentName = DocumentFileName;
            objFileAttachmentsInfo.ACFileAttachmentTableName = BOSUtil.GetTableNameFromBusinessObject(mainObject);
            objFileAttachmentsInfo.ACFileAttachmentObjectID = mainObject.ACEInvoiceGeneralID;
            objFileAttachmentsInfo.ACFileAttachmentObjectItemID = 0;
            objFileAttachmentsInfo.ACFileAttachmentModuleName = this.Name;
            objFileAttachmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objFileAttachmentsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objFileAttachmentsInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objFileAttachmentsInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.EInvoiceTemplateList.Add(objFileAttachmentsInfo);
            entity.EInvoiceTemplateList.GridControl.RefreshDataSource();
        }

        public void RemoveEInvoiceTemplateList()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            entity.EInvoiceTemplateList.RemoveSelectedRowObjectFromList();
            entity.EInvoiceTemplateList.GridControl.RefreshDataSource();
        }

        public void DownloadDocument()
        {
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)CurrentModuleEntity;
            ACFileAttachmentsInfo objFileAttachmentsInfo = entity.EInvoiceTemplateList[entity.EInvoiceTemplateList.CurrentIndex];
            if (objFileAttachmentsInfo == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(objFileAttachmentsInfo.ACFileAttachmentFileGUID))
            {
                MessageBox.Show(SaleOrderLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objFileAttachmentsInfo.ACFileAttachmentFileGUID, objFileAttachmentsInfo.ACFileAttachmentName);
        }

        internal void ViewFile()
        {
            throw new NotImplementedException();
        }

        internal void DeleteFile()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
