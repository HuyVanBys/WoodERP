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

namespace BOSERP.Modules.ElectronicInvoice
{
    public class ElectronicInvoiceModule : BaseModuleERP
    {
        #region Constant
        public const string EInvoiceGridControlName = "fld_dgcEInvoiceTemplates";
        public const string FilePathTextBoxName = "fld_txtFilePath";
        #endregion

        #region Public properties
        private string DocumentFileName = string.Empty;
        #endregion

        #region Constructor
        public ElectronicInvoiceModule()
        {
            Name = "ElectronicInvoice";
            CurrentModuleEntity = new ElectronicInvoiceEntities();
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
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
            base.ActionDuplicate();

            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)CurrentModuleEntity.MainObject;
            mainObject.OriginalInvoiceId = mainObject.InvoiceNumber;
            mainObject.PublicKey = string.Empty;
            mainObject.ACEInvoiceGeneralStatus = "New";
            mainObject.SubmittedDate = DateTime.MaxValue;
            mainObject.InvoiceNumber = string.Empty;
            mainObject.SystemCode = string.Empty;
            mainObject.SellerSignatureHash = string.Empty;
            mainObject.ACEInvoiceGeneralID = 0;
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            #region VNPT
            //ParentScreen.SetEnableOfToolbarButton("UpLoadDataToTCT", false);
            //ParentScreen.SetEnableOfToolbarButton("NewReplace", false);
            //ParentScreen.SetEnableOfToolbarButton("PublishInv", false);
            ////ParentScreen.SetEnableOfToolbarButton("GetHashInv", false);
            ////ParentScreen.SetEnableOfToolbarButton("GetStatusInv", false);
            //ParentScreen.SetEnableOfToolbarButton("ImportInv", false);
            //if (mainObject.ACEInvoiceGeneralID > 0)
            //{
            //    if (mainObject.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.New.ToString())
            //    {
            //        ParentScreen.SetEnableOfToolbarButton("UpLoadDataToTCT", true);
            //        ParentScreen.SetEnableOfToolbarButton("ImportInv", true);
            //        ParentScreen.SetEnableOfToolbarButton("NewReplace", true);
            //    }
            //    if (mainObject.ACEInvoiceGeneralStatus == "Value0")
            //        ParentScreen.SetEnableOfToolbarButton("PublishInv", true);
            //}
            #endregion

            #region BKAV
            ParentScreen.SetEnableOfToolbarButton("ImportInv_Bkav", false);
            ParentScreen.SetEnableOfToolbarButton("NewReplace_Bkav", false);
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
                if (mainObject.ACEInvoiceGeneralStatus == EInvoiceGeneralStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("ImportInv_Bkav", true);
                    ParentScreen.SetEnableOfToolbarButton("NewReplace_Bkav", true);
                    ParentScreen.SetEnableOfToolbarButton("EditInv_Bkav", true);
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

        public List<object> GetPaymentDataSource()
        {
            DataSet ds = (new ACEInvoicePaymentMethodsController()).GetAllObjects();
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows.Cast<DataRow>().Select(x => x["ACEInvoicePaymentMethodName"]).Distinct().ToList();
            }
            return null;
        }

        public void UpdateTotalAmount()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            mainObject.SumOfTotalLineAmountWithoutVAT = 0;
            mainObject.TotalAmountWithoutVAT = 0;
            foreach (ACEInvoiceDetailsInfo entItem in entity.EInvoiceDetailsList)
            {
                entItem.ACEInvoiceDetailTotalAmount = entItem.Quantity * entItem.UnitPrice;
                try
                {
                    entItem.VatPercentage = Convert.ToDecimal(mainObject.TaxOfficeCode.Substring(0, mainObject.TaxOfficeCode.Length - 1));
                }
                catch (Exception e)
                {
                    entItem.VatPercentage = 0;
                }
                entItem.VatAmount = Math.Round((entItem.UnitPrice * entItem.Quantity) * entItem.VatPercentage / 100);
                if (entItem.ACEInvoiceDetailFunction == string.Empty)
                {
                    mainObject.SumOfTotalLineAmountWithoutVAT += Math.Round(entItem.UnitPrice * entItem.Quantity);
                    mainObject.TotalAmountWithoutVAT += Math.Round(entItem.UnitPrice * entItem.Quantity) + entItem.VatAmount;
                }
            }

            decimal taxPercent = 0;
            if (mainObject.TaxOfficeCode == "5%")
                taxPercent = 5;
            else if (mainObject.TaxOfficeCode == "10%")
                taxPercent = 10;
            mainObject.TotalVATAmount = Math.Round((mainObject.SumOfTotalLineAmountWithoutVAT - mainObject.DiscountAmount) * taxPercent / 100);
            mainObject.TotalAmountWithoutVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT - mainObject.DiscountAmount);
            mainObject.TotalAmountWithVAT = Math.Round(mainObject.SumOfTotalLineAmountWithoutVAT -
                                                    mainObject.DiscountAmount +
                                                    mainObject.TotalVATAmount);
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
            mainObject.TotalAmountWithVATInWords = ConvertAmountToWord.ReadAmount(mainObject.TotalAmountWithVAT.ToString(), GECurrencyID);
            entity.EInvoiceDetailsList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public override void ActionNew()
        {
            base.ActionNew();
        }

        public void ChangeObject(string objectAccessKey)
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
                mainObject.BuyerDisplayName = objObjectsInfo.ACObjectName;
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
                objEInvoiceDetailsInfo.Promotion = objProductsInfo.ICProductPromotionCheck;
                objEInvoiceDetailsInfo.ACEInvoiceDetailVATCode = objProductsInfo.ICProductNoOfOldSys;
            }
        }

        public void RemoveSelectedItem()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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

        #region EInvoice VNPT       
        public void ActionImportInv()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            if (ApiEInvoiceHelper.ImportInv(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionGetStatusInv()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (mainObject.PublicKey == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập key", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.SetPropertyChangeEventLock(false);
            if (ApiEInvoiceHelper.GetStatusInv(mainObject, mainObject.PublicKey))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionGetHashInv()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (mainObject.PublicKey == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập key", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.SetPropertyChangeEventLock(false);
            if (ApiEInvoiceHelper.GetHashInv(mainObject, mainObject.PublicKey))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionPublishInv()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (mainObject.SellerSignatureHash == string.Empty)
            {
                MessageBox.Show("Vui lòng lấy hash trước", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.SetPropertyChangeEventLock(false);
            if (ApiEInvoiceHelper.PublishInv(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void UpLoadDataToTCT()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            if (ApiEInvoiceHelper.PublishInvWithToken(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionCancelInv()
        {
            //ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            //base.ActionNew();
            //ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            //List<ACEInvoiceGeneralsInfo> eInvoiceGenerals = objEInvoiceGeneralsController.GetEInvoiceGeneralsForNewDelete();
            //guiFind<ACEInvoiceGeneralsInfo> guiFind = new guiFind<ACEInvoiceGeneralsInfo>(TableName.ACEInvoiceGeneralsTableName, eInvoiceGenerals, this, false, true);
            //guiFind.ShowDialog();
            //if (guiFind.DialogResult == DialogResult.OK)
            //{
            //    ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = guiFind.SelectedObjects[0];
            //    if (objEInvoiceGeneralsInfo == null)
            //    {
            //        ActionCancel();
            //        return;
            //    }
            //    entity.GenerateEntityForNewDelete(objEInvoiceGeneralsInfo);
            //    if (ApiEInvoiceHelper.CancelInvoiceWithToken(objEInvoiceGeneralsInfo))
            //    {
            //        MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
            //                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //    ActionCancel();

            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (mainObject.InvoiceNumber == string.Empty)
            {
                DialogResult result = MessageBox.Show("Hóa đơn chưa phát hành, không thể hủy, bạn muốn xóa chứng từ này không?", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ActionDelete();
                }
                return;
            }
            if (ApiEInvoiceHelper.CancelInvoiceWithToken(mainObject))
            {
                MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InvalidateToolbar();

        }

        public void NewEInvoiceReplace()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            String originalInvoiceId = mainObject.CertifiedId;
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();
            ACEInvoiceGeneralsInfo objEInvoiceGeneralsInfo = objEInvoiceGeneralsController.GetEInvoiceByOriginal(mainObject.OriginalInvoiceId);
            if (objEInvoiceGeneralsInfo != null
                && objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus != "Value0"
                && objEInvoiceGeneralsInfo.ACEInvoiceGeneralStatus != "New")
            {
                if (ApiEInvoiceHelper.AdjustReplaceInvWithToken(mainObject, objEInvoiceGeneralsInfo, 1))
                {
                    MessageBox.Show("Thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(String.Format("Hóa đơn: {0} không tồn tại hoặc chưa phát hành", mainObject.OriginalInvoiceId), CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void NewEInvoiceAdjustIncrease()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            String originalInvoiceId = mainObject.CertifiedId;
            base.ActionNew();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            List<ARInvoicesInfo> invoices = objInvoicesController.GetInvoiceForNewReplace();
            guiFind<ARInvoicesInfo> guiFind = new guiFind<ARInvoicesInfo>(TableName.ARInvoicesTableName, invoices, this, false, true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                ARInvoicesInfo objInvoicesInfo = guiFind.SelectedObjects[0];
                ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objInvoicesInfo.AROutputVATInvoiceNoCombo);
                if (objEInvoiceTypesInfo == null)
                {
                    MessageBox.Show("Mẫu số không hợp lệ. Vui lòng kiểm tra lại hóa đơn!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    return;
                }
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                DataSet ds = objInvoiceItemsController.GetAllDataByForeignColumn("FK_ARInvoiceID", objInvoicesInfo.ARInvoiceID);
                List<ARInvoiceItemsInfo> invoiceItems = (List<ARInvoiceItemsInfo>)objInvoiceItemsController.GetListFromDataSet(ds);
                if (objInvoicesInfo != null)
                    entity.GenerateEntityForNewAdjust(objInvoicesInfo, invoiceItems, objEInvoiceTypesInfo, originalInvoiceId, true);
            }
            else
                ActionCancel();

        }

        public void NewEInvoiceAdjustDecrease()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            String originalInvoiceId = mainObject.CertifiedId;
            base.ActionNew();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            List<ARInvoicesInfo> invoices = objInvoicesController.GetInvoiceForNewReplace();
            guiFind<ARInvoicesInfo> guiFind = new guiFind<ARInvoicesInfo>(TableName.ARInvoicesTableName, invoices, this, false, true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                ARInvoicesInfo objInvoicesInfo = guiFind.SelectedObjects[0];
                ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByNo(objInvoicesInfo.AROutputVATInvoiceNoCombo);
                if (objEInvoiceTypesInfo == null)
                {
                    MessageBox.Show("Mẫu số không hợp lệ. Vui lòng kiểm tra lại hóa đơn!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    return;
                }
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                DataSet ds = objInvoiceItemsController.GetAllDataByForeignColumn("FK_ARInvoiceID", objInvoicesInfo.ARInvoiceID);
                List<ARInvoiceItemsInfo> invoiceItems = (List<ARInvoiceItemsInfo>)objInvoiceItemsController.GetListFromDataSet(ds);
                if (objInvoicesInfo != null)
                    entity.GenerateEntityForNewAdjust(objInvoicesInfo, invoiceItems, objEInvoiceTypesInfo, originalInvoiceId, false);
            }
            else
                ActionCancel();

        }
        #endregion

        #region EInvoice BKAV
        public void ActionImportInv_BKAV()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
                    MessageBox.Show(ElectronicInvoiceLocalizedResources.CheckInvoiceNumber,
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
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
            if (mainObject.PublicKey == string.Empty)
            {
                MessageBox.Show(ElectronicInvoiceLocalizedResources.InputPublicKey, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.SetPropertyChangeEventLock(false);

            ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
            bkavEInvoiceHelper.GetInfoEInvoiceBKAV(mainObject);
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void NewEInvoiceReplace_BKAV()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
                ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
                ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
                ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
                ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)entity.MainObject;
                entity.SetPropertyChangeEventLock(false);
                ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(mainObject.FK_ACTaxUnitID);
                bkavEInvoiceHelper.CancelEInvoiceBKAVByInvoiceGUID(mainObject);
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }
        #endregion

        #region Đính Kèm File
        public void SaveDocumentFile()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[ElectronicInvoiceModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddLoanReceiptTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[ElectronicInvoiceModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
            entity.EInvoiceTemplateList.RemoveSelectedRowObjectFromList();
            entity.EInvoiceTemplateList.GridControl.RefreshDataSource();
        }

        public void DownloadDocument()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)CurrentModuleEntity;
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
