using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AR.SaleCost.Localization;
using BOSLib;
using DevExpress.XtraTab;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleCost
{
    public class SaleCostModule : BaseTransactionModule
    {
        #region Constants
        public const string FeeCommentColumnName = "APFeePaymentFeeConfigComment";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntry1s";
        public const string TotalAmountTextBox = "bosTextBox1";
        public const string ExchangeRateTextBox = "fld_txtACDocumentExchangeRate";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string CreateTypeControlName = "fld_cbbDocumentCreateType";
        public const string DetailTabControlName = "fld_tcDetail";
        public const string InvoiceTabPage = "fld_tpInvoice";
        public const string PaymentCommissionsTabPage = "fld_tpPaymentCommissions";
        public const string FeePaymentInvoiceGridControlName = "fld_dgcAPFeePaymentInvoices";
        public const string FeePaymentCommissionGridControlName = "fld_dgcARFeePaymentCommissions";
        public const string ACVATDocumentTypeFeePaymentControlName = "fld_lkeACVATDocumentTypeFeePayment";
        #endregion

        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSComboBox CreateTypeControl;
        public BOSTabControl DetailTabControl;
        public string FocusTabName = string.Empty;
        public BOSLookupEdit ACVATDocumentTypeFeePaymentLookupEditControl;
        public List<ADConfigValuesInfo> configValueList;
        public SaleCostModule()
        {
            Name = ModuleName.SaleCost;
            CurrentModuleEntity = new SaleCostEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            CreateTypeControl = (BOSComboBox)Controls[CreateTypeControlName];
            DetailTabControl = (BOSTabControl)Controls[DetailTabControlName];
            ACVATDocumentTypeFeePaymentLookupEditControl = (BOSLookupEdit)Controls[SaleCostModule.ACVATDocumentTypeFeePaymentControlName];
            GetVATDocumentType();
            ACVATDocumentTypeFeePaymentLookupEditControl.Properties.DataSource = configValueList;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            XtraTabPage pageInvoice = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceTabPage);
            XtraTabPage pagePaymentCommissions = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == PaymentCommissionsTabPage);
            pageInvoice.PageVisible = true;
            pagePaymentCommissions.PageVisible = false;
            CreateTypeControl.Text = "Chi phí bán hàng";
            mainObject.ACDocumentCreateFrom = "NewNormal";
        }

        public void ActionNewPaymentCommission()
        {
            base.ActionNew();
            XtraTabPage pageInvoice = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceTabPage);
            XtraTabPage pagePaymentCommissions = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == PaymentCommissionsTabPage);
            pageInvoice.PageVisible = false;
            pagePaymentCommissions.PageVisible = true;
            CreateTypeControl.Text = "Hoa hồng";

            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACDocumentCreateFrom = "NewPaymentCommission";
            ARFeePaymentCommissionsController objFeePaymentCommissionsController = new ARFeePaymentCommissionsController();
            List<ARFeePaymentCommissionsInfo> iiList = objFeePaymentCommissionsController.GetFeePaymentCommissionsForSaleCost(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            guiFind<ARFeePaymentCommissionsInfo> guiChoose = new guiFind<ARFeePaymentCommissionsInfo>(TableName.ARFeePaymentCommissionsTableName
                                                                                                        , iiList
                                                                                                        , this
                                                                                                        , true);
        stampp:
            if (guiChoose.ShowDialog() == DialogResult.OK)
            {
                List<ARFeePaymentCommissionsInfo> results = (List<ARFeePaymentCommissionsInfo>)guiChoose.SelectedObjects;
                if (results.Count == 0)
                {
                    MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    goto stampp;
                }
                ARFeePaymentCommissionsInfo invalidFeePaymentCommissions = results.FirstOrDefault(t => t.FK_GECurrencyID != guiChoose.SelectedObjects[0].FK_GECurrencyID);
                if (invalidFeePaymentCommissions != null)
                {
                    MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    goto stampp;
                }
                invalidFeePaymentCommissions = results.FirstOrDefault(t => t.FK_ACObjectID != guiChoose.SelectedObjects[0].FK_ACObjectID || t.ARObjectType != guiChoose.SelectedObjects[0].ARObjectType);
                if (invalidFeePaymentCommissions != null)
                {
                    MessageBox.Show(PaymentVoucherLocalizedResources.ErrorObject,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    goto stampp;
                }

                mainObject.FK_ACObjectID = results[0].FK_ACObjectID;
                mainObject.ACObjectType = results[0].ARObjectType;
                mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                mainObject.FK_GECurrencyID = results[0].FK_GECurrencyID;
                mainObject.ACDocumentExchangeRate = results[0].ARFeePaymentCommissionExchangeRate;
                entity.UpdateMainObjectBindingSource();

                ACObjectsInfo objectsInfo = (new ACObjectsController()).GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.ACObjectType);
                APFeePaymentFeeConfigsInfo objFeePaymentFeeConfigsInfo = new APFeePaymentFeeConfigsInfo();
                objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigComment = SaleCostLocalizedResources.FeeConfigCommentCommissions;
                objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigAmount = results.Sum(o => o.ARFeePaymentCommissionAmount);
                objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigTotalAmount = objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigAmount + objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigTaxAmount;
                objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigType = FeePaymentFeeConfigType.Commission.ToString();
                if (objectsInfo != null)
                {
                    objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigObjectName = objectsInfo.ACObjectName;
                }
                entity.FeePaymentFeeConfigList.Add(objFeePaymentFeeConfigsInfo);
                entity.FeePaymentFeeConfigList.GridControl.RefreshDataSource();

                entity.FeePaymentCommissionList.Invalidate(results);
                entity.FeePaymentCommissionList.GridControl.RefreshDataSource();
            }
            else
                ActionCancel();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.ACVATDocumentTypeFeePayment = mainObject.ACVATDocumentType;
            if (mainObject.ACDocumentCreateFrom == "NewNormal")
            {
                XtraTabPage pageInvoice = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceTabPage);
                XtraTabPage pagePaymentCommissions = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == PaymentCommissionsTabPage);
                pageInvoice.PageVisible = true;
                pagePaymentCommissions.PageVisible = false;
                CreateTypeControl.Text = "Chi phí bán hàng";
            }
            else if (mainObject.ACDocumentCreateFrom == "NewPaymentCommission")
            {
                XtraTabPage pageInvoice = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == InvoiceTabPage);
                XtraTabPage pagePaymentCommissions = DetailTabControl.TabPages.FirstOrDefault(t => t.Name == PaymentCommissionsTabPage);
                pageInvoice.PageVisible = false;
                pagePaymentCommissions.PageVisible = true;
                CreateTypeControl.Text = "Hoa hồng";
            }
            else
            {
                CreateTypeControl.Text = string.Empty;
            }    
            entity.UpdateMainObjectBindingSource();
        }

        public void RemoveSelectedInvoice()
        {
            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            entity.FeePaymentInvoiceList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedPaymentCommission()
        {
            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            entity.FeePaymentCommissionList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedFeeConfig()
        {
            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            entity.FeePaymentFeeConfigList.RemoveSelectedRowObjectFromList();
        }

        public void AddInvoice()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
                ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
                ARInvoicesController invoiceController = new ARInvoicesController();
                List<ARInvoicesInfo> iiList = invoiceController.GetInvoiceInForFeePayment(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                            ModuleName.InvoiceIn,
                                                                                                            ADDataViewPermissionType.Module);

                guiFind<ARInvoicesInfo> guiChoose = new guiFind<ARInvoicesInfo>(TableName.ARInvoicesTableName
                                                                                    , iiList
                                                                                    , this
                                                                                    , true);

                if (guiChoose.ShowDialog() == DialogResult.OK)
                {

                    APFeePaymentInvoicesInfo feePaymentInvoiceIn;

                    foreach (ARInvoicesInfo invoiceIn in guiChoose.SelectedObjects)
                    {
                        feePaymentInvoiceIn = entity.FeePaymentInvoiceList.FirstOrDefault(t => t.FK_ARInvoiceID == invoiceIn.ARInvoiceID);

                        if (feePaymentInvoiceIn == null)
                        {
                            feePaymentInvoiceIn = new APFeePaymentInvoicesInfo();
                            feePaymentInvoiceIn.FK_ARInvoiceID = invoiceIn.ARInvoiceID;
                            feePaymentInvoiceIn.ARInvoiceDate = invoiceIn.ARInvoiceDate;
                            feePaymentInvoiceIn.ARInvoiceNo = invoiceIn.ARInvoiceNo;
                            feePaymentInvoiceIn.ARInvoiceVATInvoiceNo = invoiceIn.ARInvoiceVATInvoiceNo;
                            feePaymentInvoiceIn.ARInvoiceVATFormNo = invoiceIn.ARInvoiceVATFormNo;
                            feePaymentInvoiceIn.ARInvoiceVATSymbol = invoiceIn.ARInvoiceVATSymbol;
                            feePaymentInvoiceIn.ARInvoiceTotalAmount = invoiceIn.ARInvoiceTotalAmount;
                            feePaymentInvoiceIn.ARObjectName = invoiceIn.ARObjectName;
                            feePaymentInvoiceIn.ARSaleOrderNo = invoiceIn.ActionNewFrom;
                            entity.FeePaymentInvoiceList.Add(feePaymentInvoiceIn);
                        }
                        mainObject.FK_PMProjectID = invoiceIn.FK_PMProjectID;
                    }
                    entity.FeePaymentInvoiceList.GridControl.RefreshDataSource();
                }

            }
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        public override int GetDocumentTypeID()
        {
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = 0;
            if (entity.FeePaymentInvoiceList.Count > 0)
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ThanhToanPhiHoaDonBanHang.ToString());
            }
            else
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ThanhToanPhi.ToString());
            }

            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            return documentTypeID;
        }

        public override int ActionSave()
        {
            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (string.IsNullOrEmpty(mainObject.ACObjectAccessKey))
            {
                MessageBox.Show("Vui lòng chọn đối tượng người thanh toán.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            bool isInValidateFeeConfig = entity.FeePaymentFeeConfigList.Where(o => string.IsNullOrEmpty(o.APFeePaymentFeeConfigInvoiceNumber) && o.APFeePaymentFeeConfigVATStatus == "VAT").Count() > 0;
            if (isInValidateFeeConfig)
            {
                MessageBox.Show(FeePaymentLocalizedResources.EnterInvoiceAgreementForFeePayment, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            entity.FeePaymentFeeConfigList.EndCurrentEdit();
            entity.FeePaymentCommissionList.EndCurrentEdit();
            if (mainObject.ACDocumentCreateFrom == "NewNormal")
            {
                mainObject.CreateType = "Chi phí bán hàng";
            }
            else if (mainObject.ACDocumentCreateFrom == "NewPaymentCommission")
            {
                mainObject.CreateType = "Hoa hồng";
            }
            else
            {
                mainObject.CreateType = string.Empty;
            }
            UpdateTotalAmount();

            return base.ActionSave();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
                ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
                foreach (APFeePaymentFeeConfigsInfo item in entity.FeePaymentFeeConfigList)
                {
                    ChangeFeeConfig(item);
                }
                mainObject.ACDocumentTotalAmount = entity.FeePaymentFeeConfigList.Sum(o => o.APFeePaymentFeeConfigTotalAmount);
                mainObject.ACDocumentExchangeAmount = mainObject.ACDocumentTotalAmount * mainObject.ACDocumentExchangeRate;
                entity.UpdateMainObjectBindingSource();
            }
        }

        public override void GenerateAccountingData()
        {
            GenerateAccountingData(new string[] { AccDocumentType.ThanhToanPhiHoaDonBanHang.ToString() });
        }

        public void ChangeExchangeRate()
        {
            BOSTextBox bos = (BOSTextBox)Controls[ExchangeRateTextBox];
            decimal result = 0;
            decimal.TryParse(bos.EditValue.ToString(), out result);
            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACDocumentExchangeAmount = mainObject.ACDocumentTotalAmount * mainObject.ACDocumentExchangeRate;
        }

        public override void ActionEdit()
        {

            SaleCostEntities entity = CurrentModuleEntity as SaleCostEntities;

            ACDocumentsInfo document = (ACDocumentsInfo)entity.MainObject;

            APPaymentProposalItemsController ppiController = new APPaymentProposalItemsController();
            List<APPaymentProposalItemsInfo> ppiList = ppiController.GetPaymentProposalItemByDocumentID(document.ACDocumentID);

            if (ppiList != null && ppiList.Count > 0)
            {
                MessageBox.Show("Chứng từ đã đề nghị thanh toán. Không thể chỉnh sửa."
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return;
            }
            base.ActionEdit();
        }

        public void GetVATDocumentType()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            configValueList = new List<ADConfigValuesInfo>();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("VATDocumentType");
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    configValueList.Add(objConfigValuesInfo);
                }
            }
            configValueList = configValueList.Where(o => o.ADConfigKeyValue.Substring(0, o.ADConfigKeyValue.Length - 1) == "InvoiceInType").ToList();
        }

        public void ChangeFeeConfig(APFeePaymentFeeConfigsInfo item)
        {
            SaleCostEntities entity = CurrentModuleEntity as SaleCostEntities;
            if (item.APFeePaymentFeeConfigType == FeePaymentFeeConfigType.Commission.ToString())
            {
                item.APFeePaymentFeeConfigAmount = entity.FeePaymentCommissionList.Sum(o => o.ARFeePaymentCommissionAmount);
            }

            if (item.APFeePaymentFeeConfigAmount > 0)
            {
                if (item.APFeePaymentFeeConfigTaxPercent > 0)
                {
                    item.APFeePaymentFeeConfigTaxAmount = (item.APFeePaymentFeeConfigAmount * item.APFeePaymentFeeConfigTaxPercent) / 100;
                }
                item.APFeePaymentFeeConfigTotalAmount = item.APFeePaymentFeeConfigAmount + item.APFeePaymentFeeConfigTaxAmount;
            }
            else
            {
                item.APFeePaymentFeeConfigTaxAmount = 0;
                item.APFeePaymentFeeConfigTaxPercent = 0;
                item.APFeePaymentFeeConfigTotalAmount = 0;
            }
        }
        public override void ActionDuplicate()
        {
            base.ActionDuplicate();
        }
        public void ChangeObject()
        {
            SaleCostEntities entity = CurrentModuleEntity as SaleCostEntities;
            ACDocumentsInfo document = (ACDocumentsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo ObjectsInfo = objObjectsController.GetObjectByAccessKey(document.ACObjectAccessKey);
            if (ObjectsInfo != null)
            {
                document.FK_ACObjectID = ObjectsInfo.ACObjectID;
                document.ACObjectType = ObjectsInfo.ACObjectType;
                ACObjectsInfo objectsInfo = objObjectsController.GetObjectByIDAndType(ObjectsInfo.ACObjectID, ObjectsInfo.ACObjectType);
                if (objectsInfo != null)
                {
                    if (entity.FeePaymentFeeConfigList != null && entity.FeePaymentFeeConfigList.Count > 0)
                    {
                        entity.FeePaymentFeeConfigList.ForEach(a => a.APFeePaymentFeeConfigObjectName = objectsInfo.ACObjectName);
                    }
                }
            }
            entity.FeePaymentFeeConfigList.GridControl.RefreshDataSource();
        }
        public void ChangeItemFromFeePaymentFeeConfigsList()
        {
            SaleCostEntities entity = (SaleCostEntities)CurrentModuleEntity;
            entity.FeePaymentFeeConfigList.ChangeObjectFromList();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = new DataSet();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            if (!string.IsNullOrEmpty(searchObject.ACObjectAccessKey))
            {
                objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
                objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            }
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDocumentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objDocumentsController.GetInvoiceListDatasetByListOfBranchIDForSaleCost(
                                                                       searchObject.ACDocumentNo,
                                                        objObjectsInfo.ACObjectID,
                                                        objObjectsInfo.ACObjectType,
                                                        searchObject.FK_HREmployeeID,
                                                        searchObject.DocumentDateFrom,
                                                        searchObject.DocumentDateTo,
                                                        searchObject.ICReceiptPackNo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetDocumentListDatasetForSaleCost(
                                                         searchObject.ACDocumentNo,
                                                        objObjectsInfo.ACObjectID,
                                                        objObjectsInfo.ACObjectType,
                                                        searchObject.FK_HREmployeeID,
                                                        searchObject.DocumentDateFrom,
                                                        searchObject.DocumentDateTo,
                                                        searchObject.FK_BRBranchID,
                                                        searchObject.ICReceiptPackNo);
            }

            return ds;


        }

        public void ChangeProject(int projectID)
        {
            SaleCostEntities entity = CurrentModuleEntity as SaleCostEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.FK_PMProjectID = projectID;
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);
            ActionPosted();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            SaleCostEntities entity = CurrentModuleEntity as SaleCostEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.InvoiceInTrans);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            SaleCostEntities entity = CurrentModuleEntity as SaleCostEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.InvoiceInTrans);
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            SaleCostEntities entity = CurrentModuleEntity as SaleCostEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (mainObject.ACDocumentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit,
                    mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                    mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                    mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString());
            }
            base.InvalidateToolbar();
        }
    }
}
