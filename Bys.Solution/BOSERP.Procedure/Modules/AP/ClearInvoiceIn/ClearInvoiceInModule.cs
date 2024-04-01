using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ClearInvoiceIn
{
    public class ClearInvoiceInModule : BaseTransactionModule
    {
        #region Constant
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END                      
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the document type id
        /// </summary>
        public int DocumentTypeID { get; set; }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END        
        #endregion

        #region Constructor
        public ClearInvoiceInModule()
        {
            Name = "ClearInvoiceIn";
            CurrentModuleEntity = new ClearInvoiceInEntities();
            CurrentModuleEntity.Module = this;

            // BOSApp.InitLookupTables();
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END       
        }
        #endregion        
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
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #region Overrides
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            APClearInvoiceInsController objClearingDebtsController = new APClearInvoiceInsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            APClearInvoiceInsInfo searchObject = (APClearInvoiceInsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue != null
                && (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0"))
            {
                if (BranchList.Count == 0)
                {
                    ds = objClearingDebtsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objClearingDebtsController.GetClearingDebtListByListOfBranchID(
                                                                        searchObject.APClearInvoiceInNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.ClearingDebtDateFrom,
                                                                        searchObject.ClearingDebtDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objClearingDebtsController.GetClearingDebtListByBranchID(
                                                                        searchObject.APClearInvoiceInNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.ClearingDebtDateFrom,
                                                                        searchObject.ClearingDebtDateTo,
                                                                        searchObject.FK_BRBranchID);
            }
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            entity.UpdateMainObjectBindingSource();
        }
        #endregion

        #region Methods  
        public override void InvalidateToolbar()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            if (mainObject.APClearInvoiceInID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
                if (mainObject.APClearInvoiceInStatus == PurchaseOrderStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                if (mainObject.APClearInvoiceInStatus == PurchaseOrderStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
                }
            }
        }

        public void DeleteSelectedInvoice()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            entity.DocumentList.RemoveSelectedRowObjectFromList();
            UpdateDocumentEntries();
        }

        public void DeleteSelectedInvoiceIn()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            entity.InvoiceInItemList.RemoveSelectedRowObjectFromList();
            UpdateDocumentEntries();
        }
        #endregion        

        public void ShowInvoiceList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
                APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
                if (string.IsNullOrEmpty(mainObject.APObjectType) || mainObject.FK_ACObjectID == 0)
                {
                    MessageBox.Show(ClearInvoiceInLocalizedResources.NoSelectObject, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (mainObject.FK_GECurrencyID == 0)
                {
                    MessageBox.Show(ClearInvoiceInLocalizedResources.NoSelectFK_GECurrency, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                List<ACDocumentsInfo> documentList = objDocumentsController.GetDocumentForInvoiceClearing(mainObject.FK_ACObjectID, mainObject.APObjectType, mainObject.FK_GECurrencyID);
                guiFind<ACDocumentsInfo> guiFind = new guiFind<ACDocumentsInfo>(TableName.ACDocumentsTableName
                                                                                , documentList
                                                                                , this
                                                                                , false);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                    {
                        entity.DocumentList.Clear();
                        ACDocumentsInfo objDocumentsInfo = guiFind.SelectedObjects.FirstOrDefault();
                        if (objDocumentsInfo != null)
                        {
                            APClearInvoiceInDocumentsInfo objClearInvoiceInDocumentsInfo = new APClearInvoiceInDocumentsInfo();
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentNo = objDocumentsInfo.ACDocumentNo;
                            objClearInvoiceInDocumentsInfo.FK_GECurrencyID = mainObject.FK_GECurrencyID;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentExchangeRate = mainObject.APClearInvoiceInExchangeRate;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentAmount = objDocumentsInfo.ACDocumentTotalAmount;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentRemainAmount = objDocumentsInfo.ACDocumentRemainAmount;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentAllocatedAmount = objDocumentsInfo.ACDocumentTotalAmount - objDocumentsInfo.ACDocumentRemainAmount;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentAllocationAmount = objDocumentsInfo.ACDocumentRemainAmount;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentExchangeAmount = objDocumentsInfo.ACDocumentTotalAmount * mainObject.APClearInvoiceInExchangeRate;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentExchangeAllocatedAmount = (objDocumentsInfo.ACDocumentTotalAmount - objDocumentsInfo.ACDocumentRemainAmount)
                                                                                                                * mainObject.APClearInvoiceInExchangeRate;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentReferenceID = objDocumentsInfo.APClearInvoiceInDocumentReferenceID;
                            objClearInvoiceInDocumentsInfo.APClearInvoiceInDocumentReferenceModuleName = objDocumentsInfo.APClearInvoiceInDocumentReferenceModuleName;

                            mainObject.FK_GECurrencyID = objDocumentsInfo.FK_GECurrencyID;
                            mainObject.APClearInvoiceInExchangeRate = objDocumentsInfo.ACDocumentExchangeRate;
                            entity.DocumentList.Add(objClearInvoiceInDocumentsInfo);
                        }
                        entity.DocumentList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        public void ShowInvoiceInList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
                APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
                APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                if (string.IsNullOrEmpty(mainObject.APObjectType) || mainObject.FK_ACObjectID == 0)
                {
                    MessageBox.Show(ClearInvoiceInLocalizedResources.NoSelectObject, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (mainObject.FK_GECurrencyID == 0)
                {
                    MessageBox.Show(ClearInvoiceInLocalizedResources.NoSelectFK_GECurrency, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                APClearInvoiceInInvoiceInsController objAPClearInvoiceInInvoiceInsController = new APClearInvoiceInInvoiceInsController();
                List<APClearInvoiceInInvoiceInsInfo> listInvoiceInTransactions = objAPClearInvoiceInInvoiceInsController.GetInvoiceInTransactionsForClearInvoiceInByObjectIDAndCurencyID(mainObject.FK_ACObjectID, mainObject.APObjectType, mainObject.FK_GECurrencyID);
                guiFind<APClearInvoiceInInvoiceInsInfo> guiFind = new guiFind<APClearInvoiceInInvoiceInsInfo>(TableName.APClearInvoiceInInvoiceInsTableName
                                                                                                            , listInvoiceInTransactions
                                                                                                            , this
                                                                                                            , true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                    {
                        foreach (APClearInvoiceInInvoiceInsInfo item in guiFind.SelectedObjects)
                        {
                            item.APClearInvoiceInInvoiceInAllocationAmount = item.APClearInvoiceInInvoiceInRemainAmount;
                            item.APClearInvoiceInInvoiceInExchangeAmount = item.APClearInvoiceInInvoiceInAmount * mainObject.APClearInvoiceInExchangeRate;
                            item.APClearInvoiceInInvoiceInExchangeAllocationAmount = item.APClearInvoiceInInvoiceInRemainAmount * mainObject.APClearInvoiceInExchangeRate;

                            if (entity.InvoiceInItemList.Count > 0)
                            {
                                APClearInvoiceInInvoiceInsInfo objExist = entity.InvoiceInItemList.FirstOrDefault(a => a.APClearInvoiceInInvoiceInNo == item.APClearInvoiceInInvoiceInNo);
                                if (objExist == null)
                                {
                                    entity.InvoiceInItemList.Add(item);
                                }
                            }
                            else
                            {
                                entity.InvoiceInItemList.Add(item);
                            }
                        }
                        entity.InvoiceInItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        public override int ActionSave()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            entity.DocumentList.EndCurrentEdit();
            entity.InvoiceInItemList.EndCurrentEdit();
            UpdateEvaluateExchangeRate();

            decimal totalDocumentAmount = 0;
            decimal totalInvoiceInClearing = 0;
            if (entity.DocumentList != null && entity.DocumentList.Count > 0)
            {
                totalDocumentAmount = entity.DocumentList.Sum(a => a.APClearInvoiceInDocumentAllocationAmount);
            }
            if (entity.InvoiceInItemList != null && entity.InvoiceInItemList.Count > 0)
            {
                totalInvoiceInClearing = entity.InvoiceInItemList.Sum(a => a.APClearInvoiceInInvoiceInAllocationAmount);
            }
            if (totalInvoiceInClearing > totalDocumentAmount)
            {
                MessageBox.Show("", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return base.ActionSave();
        }
        //Change object       

        public void ChangeFK_ACObjectID(string objectAccessKey)
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                string[] objectAccessKeys = objectAccessKey.Split(';');
                int id = int.Parse(objectAccessKeys[0]);
                string type = objectAccessKeys[1];

                mainObject.FK_ACObjectID = id;
                mainObject.APObjectType = type;
                ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(id, type);
                if (objObjectsInfo != null)
                {
                    mainObject.FK_ACAccountPurchaseID = objObjectsInfo.FK_ACAccountPurchaseID;
                    mainObject.APClearInvoiceInObjectName = objObjectsInfo.ACObjectName;
                }
            }
            else
            {
                mainObject.FK_ACObjectID = 0;
                mainObject.APObjectType = "";
                mainObject.FK_ACAccountPurchaseID = 0;
                mainObject.APClearInvoiceInObjectName = "";
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void RunAllocation()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            decimal totalAllocationAmount = 0;
            if (entity.DocumentList != null && entity.DocumentList.Count > 0)
            {
                totalAllocationAmount = entity.DocumentList.Sum(a => a.APClearInvoiceInDocumentAllocationAmount);
                entity.InvoiceInItemList.ForEach(a =>
                    {
                        if (totalAllocationAmount > 0)
                        {
                            if ((totalAllocationAmount - a.APClearInvoiceInInvoiceInRemainAmount) > 0)
                            {
                                a.APClearInvoiceInInvoiceInAllocationAmount = a.APClearInvoiceInInvoiceInRemainAmount;
                                totalAllocationAmount -= a.APClearInvoiceInInvoiceInRemainAmount;
                            }
                            else
                            {
                                a.APClearInvoiceInInvoiceInAllocationAmount = totalAllocationAmount;
                                totalAllocationAmount = 0;
                            }
                        }
                        else
                        {
                            a.APClearInvoiceInInvoiceInAllocationAmount = 0;
                        }
                    });
                totalAllocationAmount = entity.InvoiceInItemList.Sum(o => o.APClearInvoiceInInvoiceInAllocationAmount);
                entity.DocumentList[0].APClearInvoiceInDocumentAllocationAmount = totalAllocationAmount;
            }
            else
            {
                entity.InvoiceInItemList.ForEach(a => a.APClearInvoiceInInvoiceInAllocationAmount = 0);
            }
            entity.InvoiceInItemList.GridControl.RefreshDataSource();
        }

        public override bool ActionComplete()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            if (!CheckValid())
                return false;
            bool isSuccess = base.ActionComplete();
            if (isSuccess)
            {
                APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                APInvoiceInsInfo objInvoiceInsInfo = null;
                entity.InvoiceInItemList.ForEach(o =>
                {
                    if (o.FK_APInvoiceInID > 0)
                    {
                        objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(o.FK_APInvoiceInID);
                        if (objInvoiceInsInfo != null)
                        {
                            objInvoiceInsInfo.APInvoiceInDepositBalance += o.APClearInvoiceInInvoiceInAllocationAmount;
                            objInvoiceInsInfo.APInvoiceInBalanceDue = objInvoiceInsInfo.APInvoiceInTotalCost - objInvoiceInsInfo.APInvoiceInDepositBalance;
                            objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
                        }
                    }
                });
                GLHelper.PostedTransactions(this.Name, mainObject.APClearInvoiceInID, ModulePostingType.Accounting, ModulePostingType.InvoiceInTrans);
            }
            return isSuccess;
        }

        public void ChangeCurrency(int currencyID)
        {
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_GECurrencyID = currencyID;
            GECurrencyExchangeRatesController objCurrencyExchangeRatesController = new GECurrencyExchangeRatesController();
            decimal exchangeRateValue = objCurrencyExchangeRatesController.GetCurrencyExchangeRateByCurrencyIDAndDate(currencyID, mainObject.APClearInvoiceInDate);
            if (exchangeRateValue > 0)
            {
                mainObject.APClearInvoiceInExchangeRate = exchangeRateValue;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ChangeAllocationAmount()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            entity.InvoiceInItemList.EndCurrentEdit();
            decimal totalAllocationAmount = 0;
            if (entity.InvoiceInItemList != null && entity.InvoiceInItemList.Count > 0)
            {
                totalAllocationAmount = entity.InvoiceInItemList.Sum(a => a.APClearInvoiceInInvoiceInAllocationAmount);
            }
            if (entity.DocumentList.Count > 0)
            {
                if (entity.DocumentList[0].APClearInvoiceInDocumentRemainAmount < totalAllocationAmount)
                {
                    MessageBox.Show(ClearInvoiceInLocalizedResources.ErrorAllocationAmount2,
                                            BaseLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    entity.DocumentList[0].APClearInvoiceInDocumentAllocationAmount = totalAllocationAmount;
                }
            }
            entity.DocumentList.EndCurrentEdit();
            entity.InvoiceInItemList.GridControl.RefreshDataSource();
            entity.DocumentList.GridControl.RefreshDataSource();
        }
        public override void ActionDelete()
        {
            base.ActionDelete();
        }

        public override bool ActionCancelComplete()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            APInvoiceInsInfo objInvoiceInsInfo = null;
            if (!base.ActionCancelComplete()) return false;
            entity.InvoiceInItemList.ForEach(o =>
            {
                if (o.FK_APInvoiceInID > 0)
                {
                    objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(o.FK_APInvoiceInID);
                    if (objInvoiceInsInfo != null)
                    {
                        objInvoiceInsInfo.APInvoiceInDepositBalance -= o.APClearInvoiceInInvoiceInAllocationAmount;
                        objInvoiceInsInfo.APInvoiceInBalanceDue = objInvoiceInsInfo.APInvoiceInTotalCost - objInvoiceInsInfo.APInvoiceInDepositBalance;
                        objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
                    }
                }
            });
            GLHelper.UnPostedTransactions(this.Name, mainObject.APClearInvoiceInID, ModulePostingType.Accounting, ModulePostingType.InvoiceInTrans);
            InvalidateToolbar();
            return true;
        }
        public bool CheckValid()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)entity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            decimal documentAmount = 0;
            decimal invoiceInAmount = 0;
            List<decimal> InvalidAmount = new List<decimal>();
            entity.DocumentList.ForEach(o =>
            {
                documentAmount = objDocumentsController.GetDocumentAmountBySomeCriteria(o.APClearInvoiceInDocumentID, o.FK_APClearInvoiceInID, o.APClearInvoiceInDocumentNo);
                documentAmount = Math.Round(documentAmount, BOSApp.GetDecimalNumberByCurrencyID(mainObject.FK_GECurrencyID), MidpointRounding.AwayFromZero);
                if (o.APClearInvoiceInDocumentAllocationAmount > documentAmount)
                {
                    InvalidAmount.Add(documentAmount);
                }
            });
            entity.InvoiceInItemList.ForEach(o =>
            {
                invoiceInAmount = objInvoiceInsController.GetInvoiceInAmountBySomeCriteria(o.APClearInvoiceInInvoiceInID, o.FK_APClearInvoiceInID, o.APClearInvoiceInInvoiceInNo);
                invoiceInAmount = Math.Round(invoiceInAmount, BOSApp.GetDecimalNumberByCurrencyID(mainObject.FK_GECurrencyID), MidpointRounding.AwayFromZero);
                if (o.APClearInvoiceInInvoiceInAllocationAmount > invoiceInAmount)
                {
                    InvalidAmount.Add(invoiceInAmount);
                }
            });
            if (InvalidAmount != null && InvalidAmount.Count() > 0)
            {
                MessageBox.Show(String.Format("Số tiền phân bổ vượt quá số tiền còn lại trên chứng từ/hóa đơn. Số tiền được phép phân bổ là: {0}", InvalidAmount.Min()),
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void UpdateEvaluateExchangeRate()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)CurrentModuleEntity;
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)CurrentModuleEntity.MainObject;

            if (entity.DocumentList != null && entity.DocumentList.Count > 0)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.APObjectType);

                APClearInvoiceInDocumentsInfo payDocuments = entity.DocumentList[0];
                if (payDocuments != null)
                {
                    GECurrenciesController objCurrenciesController = new GECurrenciesController();
                    GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(payDocuments.FK_GECurrencyID);

                    #region Tinh chenh lech ti gia
                    ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                    ACAccountsController objAccountsController = new ACAccountsController();
                    decimal tienlai = 0;
                    decimal tienlo = 0;
                    decimal tienConLai = 0;
                    decimal tienConLaiQD = 0;
                    decimal tyGiaTB = 0;
                    decimal tyGiaTT = 0;
                    if (objCurrenciesInfo != null && (objCurrenciesInfo.GECurrencyNo != CurrencyNo.VND.ToString()
                                                            || payDocuments.APClearInvoiceInDocumentExchangeRate != 1))
                    {
                        List<APClearInvoiceInInvoiceInsInfo> invoiceinList = entity.InvoiceInItemList.Where(a => !string.IsNullOrWhiteSpace(a.APClearInvoiceInInvoiceInNo)).ToList();
                        APInvoiceInTransactionsController objPOPTIIDController = new APInvoiceInTransactionsController();
                        List<APInvoiceInTransactionsInfo> pOPaymentTimeInvoiceInDetails = null;
                        APInvoiceInTransactionsInfo objPOPaymentTimeInvoiceInDetailsInfo = null;

                        if (invoiceinList != null && invoiceinList.Count > 0)
                        {
                            ARInvoiceTransactionsController ptiController = new ARInvoiceTransactionsController();
                            invoiceinList.ForEach(a =>
                            {
                                pOPaymentTimeInvoiceInDetails = objPOPTIIDController.GetClearingInfoByInvoiceInID(a.FK_APInvoiceInID, a.APClearInvoiceInInvoiceInNo, mainObject.FK_ACObjectID, mainObject.APObjectType);
                                objPOPaymentTimeInvoiceInDetailsInfo = objPOPTIIDController.GetInvoiceInInfoByInvoiceInID(a.FK_APInvoiceInID, a.APClearInvoiceInInvoiceInNo, mainObject.FK_ACObjectID, mainObject.APObjectType) as APInvoiceInTransactionsInfo;

                                if (objPOPaymentTimeInvoiceInDetailsInfo != null)
                                {
                                    tienConLai = objPOPaymentTimeInvoiceInDetailsInfo.APInvoiceInAmount - pOPaymentTimeInvoiceInDetails.Sum(o => o.APInvoiceInPaymentAmount);
                                    tienConLaiQD = objPOPaymentTimeInvoiceInDetailsInfo.APInvoiceInAmountExchange - pOPaymentTimeInvoiceInDetails.Sum(o => o.APInvoiceInPaymentAmountExchange);
                                    if (tienConLai > 0)
                                    {
                                        tyGiaTB = tienConLaiQD / tienConLai;
                                    }
                                    tyGiaTT = Math.Min(tyGiaTB, payDocuments.APClearInvoiceInDocumentExchangeRate);
                                    if (tyGiaTB > payDocuments.APClearInvoiceInDocumentExchangeRate)
                                    {
                                        tienlai += a.APClearInvoiceInInvoiceInAllocationAmount * Math.Abs(tyGiaTB - payDocuments.APClearInvoiceInDocumentExchangeRate);
                                    }
                                    if (tyGiaTB < payDocuments.APClearInvoiceInDocumentExchangeRate)
                                    {
                                        tienlo += a.APClearInvoiceInInvoiceInAllocationAmount * Math.Abs(tyGiaTB - payDocuments.APClearInvoiceInDocumentExchangeRate);
                                    }
                                }
                                if (tienlai > 0)
                                {
                                    a.APClearInvoiceInInvoiceInRateVariance = tienlai;
                                }
                                else if (tienlo > 0)
                                {
                                    a.APClearInvoiceInInvoiceInRateVariance = -tienlo;
                                }
                            });
                        }
                    }
                    #endregion
                }
            }
        }
    }
}
