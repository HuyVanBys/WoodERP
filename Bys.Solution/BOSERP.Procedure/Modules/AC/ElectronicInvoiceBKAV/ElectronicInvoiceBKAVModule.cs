using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ElectronicInvoiceBKAV
{
    public class ElectronicInvoiceBKAVModule : BaseModuleERP
    {
        #region Constant
        public const string EInvoiceGridControlName = "fld_dgcEInvoiceTemplates";
        public const string FilePathTextBoxName = "fld_txtFilePath";
        #endregion

        #region Public properties
        private string DocumentFileName = string.Empty;
        #endregion

        #region Constructor
        public ElectronicInvoiceBKAVModule()
        {
            Name = ModuleName.ElectronicInvoiceBKAV;
            CurrentModuleEntity = new ElectronicInvoiceBKAVEntities();
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
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            entity.EInvoiceDetailsList.EndCurrentEdit();
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (mainObject.FK_ACTaxUnitID <= 0)
            {
                MessageBox.Show(ElectronicInvoiceBKAVLocalizedResources.CheckTaxUnit,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            mainObject.SumOfTotalLineAmountWithoutVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT, 0, MidpointRounding.AwayFromZero);
            mainObject.DiscountAmount = Math.Round(mainObject.DiscountAmount, 0, MidpointRounding.AwayFromZero);
            mainObject.TotalVATAmount = Math.Round(mainObject.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            mainObject.TotalAmountWithVAT = Math.Round(mainObject.TotalAmountWithVAT, 0, MidpointRounding.AwayFromZero);
            foreach (ACEInvoiceDetailsInfo entItem in entity.EInvoiceDetailsList)
            {
                entItem.UnitPrice = Math.Round(entItem.UnitPrice, 2, MidpointRounding.AwayFromZero);
                entItem.Quantity = Math.Round(entItem.Quantity, 3, MidpointRounding.AwayFromZero);
                entItem.VatPercentage = Math.Round(entItem.VatPercentage, 0, MidpointRounding.AwayFromZero);
                entItem.VatAmount = Math.Round(entItem.VatAmount, 0, MidpointRounding.AwayFromZero);
            }
            int documentID = base.ActionSave();
            if (documentID > 0)
                SaveDocumentFile();

            return documentID;
        }

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();

            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.MainObject;
            mainObject.OriginalInvoiceId = mainObject.InvoiceNumber;
            mainObject.SubmittedDate = DateTime.MaxValue;
            mainObject.PublicKey = string.Empty;
            mainObject.ACEInvoiceGeneralStatus = "New";
            mainObject.InvoiceNumber = string.Empty;
            mainObject.SystemCode = string.Empty;
            mainObject.SellerSignatureHash = string.Empty;
            mainObject.ACEInvoiceGeneralID = 0;
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;

            #region BKAV
            ParentScreen.SetEnableOfToolbarButton("ImportInv_Bkav", false);
            ParentScreen.SetEnableOfToolbarButton("NewReplace_Bkav", false);
            ParentScreen.SetEnableOfToolbarButton("ReplaceEInvoiceWaitingForSigning", false);
            ParentScreen.SetEnableOfToolbarButton("GetStatusInv_Bkav", true);
            ParentScreen.SetEnableOfToolbarButton("DeleteInv", true);
            ParentScreen.SetEnableOfToolbarButton("CancelInv_Bkav", true);
            ParentScreen.SetEnableOfToolbarButton("EditInv_Bkav", false);
            if (mainObject.ACEInvoiceGeneralID > 0)
            {
                if (mainObject.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value4.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("DeleteInv", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelInv_Bkav", false);
                }
                else if (mainObject.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("ImportInv_Bkav", true);
                    ParentScreen.SetEnableOfToolbarButton("NewReplace_Bkav", true);
                    ParentScreen.SetEnableOfToolbarButton("EditInv_Bkav", true);
                    ParentScreen.SetEnableOfToolbarButton("ReplaceEInvoiceWaitingForSigning", true);
                }
                else if (mainObject.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value1.ToString()
                    || mainObject.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value11.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("ImportInv_Bkav", true);
                }
                else if (mainObject.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.Value3.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("CancelInv_Bkav", false);
                }
            }
            #endregion
        }

        public void UpdateTotalAmount()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            mainObject.SumOfTotalLineAmountWithoutVAT = 0;
            mainObject.TotalAmountWithoutVAT = 0;
            decimal vatPercen = 0;
            try
            {
                vatPercen = Convert.ToDecimal(mainObject.TaxOfficeCode.Substring(0, mainObject.TaxOfficeCode.Length - 1));
            }
            catch (Exception e)
            {
                vatPercen = 0;
            }
            foreach (ACEInvoiceDetailsInfo entItem in entity.EInvoiceDetailsList)
            {
                entItem.ACEInvoiceDetailTotalAmount = entItem.Quantity * entItem.UnitPrice;
                entItem.VatPercentage = vatPercen;
                entItem.VatAmount = Math.Round((entItem.UnitPrice * entItem.Quantity) * entItem.VatPercentage / 100, 0, MidpointRounding.AwayFromZero);
            }

            mainObject.SumOfTotalLineAmountWithoutVAT = Math.Round(entity.EInvoiceDetailsList.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            mainObject.TotalVATAmount = Math.Round((mainObject.SumOfTotalLineAmountWithoutVAT - mainObject.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            mainObject.TotalAmountWithoutVAT = mainObject.SumOfTotalLineAmountWithoutVAT + mainObject.TotalVATAmount;
            mainObject.TotalAmountWithVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT
                                                                    - mainObject.DiscountAmount
                                                                    + mainObject.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            mainObject.TotalAmount = mainObject.TotalAmountWithVAT;

            int GECurrencyID = 100000;
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
            if (mainObject.TotalAmountWithVAT < 0)
            {
                mainObject.TotalAmountWithVATInWords = String.Format("Âm {0}", ConvertAmountToWord.ReadAmount(Math.Abs(mainObject.TotalAmountWithVAT).ToString(), GECurrencyID));
            }
            else
            {
                mainObject.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(mainObject.TotalAmountWithVAT.ToString(), GECurrencyID);
            }
            entity.EInvoiceDetailsList.GridControl?.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public override void ActionNew()
        {
            base.ActionNew();
        }

        public void ActionNewFromInvoice()
        {
            base.ActionNew();
            
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;            
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;

            ARInvoicesController objInvoicesController = new ARInvoicesController();
            List<ARInvoicesInfo> posItems = objInvoicesController.GetInvoicesForEInvoice();
            guiChooseInvoices guiInvoice = new guiChooseInvoices(posItems);
            guiInvoice.Module = this;
            if (guiInvoice.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARInvoicesInfo> results = (List<ARInvoicesInfo>)guiInvoice.SelectedObjects;
            if (results.Count == 0)
                return;

            ARInvoicesInfo objInvoicesInfo = results.FirstOrDefault();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            List<ARInvoiceItemsInfo> invoiceItems = new List<ARInvoiceItemsInfo>();
            string strListID = string.Join(",", results.Where(p => p.ARInvoiceID > 0).Select(x => x.ARInvoiceID.ToString()).Distinct().ToArray());            
            if (strListID != null)
            {
                invoiceItems = objInvoiceItemsController.GetItemListByListInvoiceID(strListID);
                invoiceItems = invoiceItems.GroupBy(o => new
                {
                    o.FK_ICProductID,
                    o.ARInvoiceItemProductName2,
                    o.FK_ICMeasureUnitID,
                    o.ARInvoiceItemProductUnitPrice,
                    o.FK_ARInvoiceID,
                    o.ARInvoiceNo
                }).Select(o => new ARInvoiceItemsInfo()
                {
                    FK_ICProductID = o.Key.FK_ICProductID,
                    ARInvoiceItemProductName2 = o.Key.ARInvoiceItemProductName2,
                    FK_ICMeasureUnitID = o.Key.FK_ICMeasureUnitID,
                    ARInvoiceItemProductUnitPrice = o.Key.ARInvoiceItemProductUnitPrice,
                    ARInvoiceItemProductQty = o.Sum(item => item.ARInvoiceItemProductQty),
                    FK_ARInvoiceID = o.Key.FK_ARInvoiceID,
                    ARInvoiceNo = o.Key.ARInvoiceNo,
                    ARInvoiceItemID = o.Select(item => item.ARInvoiceItemID).FirstOrDefault()
                }).ToList();
            }

            EInvoiceHelper.GenarateEInvoiceGeneral(mainObject, objInvoicesInfo, false, string.Empty);
            List<ACEInvoiceDetailsInfo> eInvoiceDetails = EInvoiceHelper.GenarateEInvoiceDetail(mainObject, objInvoicesInfo, invoiceItems);
            entity.EInvoiceDetailsList.Invalidate(eInvoiceDetails);

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
            mainObject.SumOfTotalLineAmountWithoutVAT = Math.Round(eInvoiceDetails.Sum(p => p.Quantity * p.UnitPrice), 0, MidpointRounding.AwayFromZero);
            mainObject.DiscountAmount = Math.Round(objInvoicesInfo.ARInvoiceDiscountFix + invoiceItems.Sum(o => o.ARInvoiceItemDiscountAmount), 0, MidpointRounding.AwayFromZero);
            mainObject.TotalVATAmount = Math.Round((mainObject.SumOfTotalLineAmountWithoutVAT - mainObject.DiscountAmount) * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
            mainObject.TotalAmountWithoutVAT = mainObject.SumOfTotalLineAmountWithoutVAT + mainObject.TotalVATAmount;
            mainObject.TotalAmountWithVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT
                                                                    - mainObject.DiscountAmount
                                                                    + mainObject.TotalVATAmount, 0, MidpointRounding.AwayFromZero);
            if (mainObject.TotalAmountWithVAT < 0)
            {
                mainObject.TotalAmountWithVATInWords = String.Format("Âm {0}", ConvertAmountToWord.ReadAmount(Math.Abs(mainObject.TotalAmountWithVAT).ToString(), objInvoicesInfo.FK_GECurrencyID));
            }
            else
            {
                mainObject.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(mainObject.TotalAmountWithVAT.ToString(), objInvoicesInfo.FK_GECurrencyID);
            }
            mainObject.ACEInvoiceGeneralType = EInvoiceGeneralType.Original.ToString();

            entity.EInvoiceDetailsList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeObject(string objectAccessKey)
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
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
                //mainObject.BuyerDisplayName = objObjectsInfo.ACObjectName;
                mainObject.BuyerTaxCode = objObjectsInfo.ACObjectTaxNumber;
                mainObject.BuyerEmail = objObjectsInfo.ACObjectContactEmail;
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

                if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                {
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objObjectsInfo.ACObjectID);
                    if (objCustomersInfo != null)
                    {
                        //mainObject.BuyerLegalName = objCustomersInfo.ARCustomerDesc;
                        mainObject.BuyerAddressLine = objCustomersInfo.ARCustomerInvoiceAddressLine1;
                    }
                }
            }
            #region Get default Customer Bank                
            List<ACListAccountBanksInfo> listBank = (new ACListAccountBanksController()).GetListByACObject(mainObject.FK_ACObjectID, mainObject.ACObjectType);
            if (listBank != null && listBank.Count > 0)
            {
                mainObject.BuyerBankName = listBank[0].ACListAccountBankName;
                mainObject.BuyerBankAccount = listBank[0].ACListAccountBankAccountHolder;
                mainObject.BuyerBankNumber = listBank[0].ACListAccountBankAccount;
            }
            #endregion
            CurrentModuleEntity.UpdateMainObjectBindingSource();
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
                objEInvoiceDetailsInfo.Promotion = objProductsInfo.ICProductPromotionCheck;
                objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
            }
        }

        public void RemoveSelectedItem()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            entity.EInvoiceDetailsList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            ACEInvoiceGeneralsInfo searchObject = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds;
            ds = objEInvoiceGeneralsController.GetEInvoiceGeneralList(
                                                                searchObject.ACEInvoiceGeneralNo,
                                                                searchObject.ACEInvoiceGeneralFromDate,
                                                                searchObject.ACEInvoiceGeneralToDate);
            DataSet result = new DataSet();
            DataView dv = ds.Tables[0].DefaultView;
            dv.Sort = "ACEInvoiceGeneralID ASC";
            result.Tables.Add(dv.ToTable());
            return ds;
        }
        #endregion

        #region EInvoice BKAV
        public void ActionImportInv_BKAV()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
                ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
                entity.SetPropertyChangeEventLock(false);
                if (String.IsNullOrEmpty(mainObject.InvoiceNumber))
                    mainObject.InvoiceNumber = "0";
                try
                {
                    Convert.ToInt32(mainObject.InvoiceNumber);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại Số hóa đơn!",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
                ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
                if (String.IsNullOrEmpty(mainObject.PublicKey))
                    bkavEInvoiceHelper.CreateEInvoiceBKAV(mainObject);
                else
                    bkavEInvoiceHelper.UpdateEInvoiceBKAV(mainObject);
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void ActionGetStatusInv_BKAV()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (mainObject.PublicKey == string.Empty)
            {
                MessageBox.Show(ElectronicInvoiceBKAVLocalizedResources.InputPublicKey, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.SetPropertyChangeEventLock(false);

            ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            if (bkavEInvoiceHelper.GetInfoEInvoiceBKAV(mainObject))
            {
                ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
                objEInvoiceGeneralsController.UpdateVATInvoiceNoEInvoiceGeneralID(mainObject.ACEInvoiceGeneralID);
                MessageBox.Show("Lấy trạng thái hóa đơn thành công!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi! Vui lòng kiểm tra lại", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionGetInfoListInv_BKAV()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            DateTime startDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            DateTime endDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            guiChooseReportPeriod guiChooseReportPeriod = new guiChooseReportPeriod(startDate, endDate);
            guiChooseReportPeriod.Module = this;
            if (guiChooseReportPeriod.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(guiChooseReportPeriod.ResultMessage
                                , CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Search();
            }
        }

        public void NewEInvoiceReplace_BKAV()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
                ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
                entity.SetPropertyChangeEventLock(false);
                ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
                bkavEInvoiceHelper.ReplaceEInvoiceBKAV(mainObject);
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void ActionEditInv_BKAV()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
                ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
                entity.SetPropertyChangeEventLock(false);
                ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
                bkavEInvoiceHelper.AdjustEInvoiceBKAV(mainObject);
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void ActionDeleteInv_BKAV()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
                ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
                entity.SetPropertyChangeEventLock(false);
                ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
                bkavEInvoiceHelper.DeleteEInvoiceBKAVByInvoiceGUID(mainObject);
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void ActionCancelInv_BKAV()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
                ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
                entity.SetPropertyChangeEventLock(false);
                ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
                bkavEInvoiceHelper.CancelEInvoiceBKAVByInvoiceGUID(mainObject);
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void ReplaceEInvoiceWaitingForSigning()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
                List<ACEInvoiceGeneralsInfo> listEInvoiceWaitingForSigning = objEInvoiceGeneralsController.GetListEInvoiceWaitingForSigning();
                guiFind<ACEInvoiceGeneralsInfo> guiFind = new guiFind<ACEInvoiceGeneralsInfo>(TableName.ACEInvoiceGeneralsTableName, listEInvoiceWaitingForSigning, this, false);
            Stampp:
                if (guiFind.ShowDialog() == DialogResult.OK)
                {
                    if (guiFind.SelectedObjects.Count > 0)
                    {
                        ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = (ACEInvoiceGeneralsInfo)guiFind.SelectedObjects[0];
                        ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
                        ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
                        mainObject.PublicKey = objEInvoiceGeneralsInfo.PublicKey;
                        mainObject.InvoiceNumber = objEInvoiceGeneralsInfo.InvoiceNumber;
                        mainObject.TemplateCode = objEInvoiceGeneralsInfo.TemplateCode;
                        mainObject.InvoiceSeries = objEInvoiceGeneralsInfo.InvoiceSeries;
                        ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
                        if (bkavEInvoiceHelper.UpdateEInvoiceBKAV(mainObject))
                        {
                            ActionSave();
                            ActionGetStatusInv_BKAV();
                            objEInvoiceGeneralsInfo.PublicKey = String.Empty;
                            objEInvoiceGeneralsInfo.InvoiceNumber = String.Empty;
                            objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus = EInvoiceGeneralStatus.New.ToString();
                            objEInvoiceGeneralsController.UpdateObject(objEInvoiceGeneralsInfo);
                        }
                    }
                    else
                    {
                        MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        goto Stampp;
                    }
                }
            }
        }
        #endregion

        #region Đính Kèm File
        public void SaveDocumentFile()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
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
            entity.EInvoiceTemplateList.GridControl?.RefreshDataSource();
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
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[ElectronicInvoiceBKAVModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddLoanReceiptTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[ElectronicInvoiceBKAVModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
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
            entity.EInvoiceTemplateList.GridControl?.RefreshDataSource();
        }

        public void RemoveEInvoiceTemplateList()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            entity.EInvoiceTemplateList.RemoveSelectedRowObjectFromList();
            entity.EInvoiceTemplateList.GridControl?.RefreshDataSource();
        }

        public void DownloadDocument()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)CurrentModuleEntity;
            ACFileAttachmentsInfo objFileAttachmentsInfo = entity.EInvoiceTemplateList[entity.EInvoiceTemplateList.CurrentIndex];
            if (objFileAttachmentsInfo == null)
                return;

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
