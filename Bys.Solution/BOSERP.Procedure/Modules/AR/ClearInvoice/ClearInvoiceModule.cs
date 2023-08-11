using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ClearInvoice
{
    public class ClearInvoiceModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
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
        public ClearInvoiceModule()
        {
            Name = "ClearInvoice";
            CurrentModuleEntity = new ClearInvoiceEntities();
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

        #region Overrides
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARClearInvoicesController objClearInvoicesController = new ARClearInvoicesController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ARClearInvoicesInfo searchObject = (ARClearInvoicesInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue != null
                && (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0"))
            {
                if (BranchList.Count == 0)
                {
                    ds = objClearInvoicesController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objClearInvoicesController.GetClearingDebtListByListOfBranchID(
                                                                        searchObject.ARClearInvoiceNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.ClearInvoiceDateFrom,
                                                                        searchObject.ClearInvoiceDebtDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objClearInvoicesController.GetClearingDebtListByBranchID(
                                                                        searchObject.ARClearInvoiceNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.ClearInvoiceDateFrom,
                                                                        searchObject.ClearInvoiceDebtDateTo,
                                                                        searchObject.FK_BRBranchID);
            }
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            entity.UpdateMainObjectBindingSource();
        }
        #endregion

        #region Methods  
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)entity.MainObject;
            if (mainObject.ARClearInvoiceID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
                if (mainObject.ARClearInvoiceStatus == SaleOrderStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                if (mainObject.ARClearInvoiceStatus == SaleOrderStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }
            }
        }

        public void DeleteSelectedInvoice()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            entity.DocumentList.RemoveSelectedRowObjectFromList();
            UpdateDocumentEntries();
        }

        public void DeleteSelectedInvoiceIn()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            entity.InvoiceItemList.RemoveSelectedRowObjectFromList();
            UpdateDocumentEntries();
        }
        #endregion        

        public void ShowInvoiceList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
                ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)entity.MainObject;
                if (string.IsNullOrEmpty(mainObject.ARObjectType) || mainObject.FK_ACObjectID == 0)
                {
                    MessageBox.Show(ClearInvoiceLocalizedResources.NoSelectObject, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (mainObject.FK_GECurrencyID == 0)
                //{
                //    MessageBox.Show(ClearInvoiceLocalizedResources.NoSelectFK_GECurrency, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                List<ACDocumentsInfo> documentList = objDocumentsController.GetDocumentForInvoiceClear(mainObject.FK_ACObjectID, mainObject.ARObjectType);
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
                            ARClearInvoiceDocumentsInfo objClearInvoiceDocumentsInfo = new ARClearInvoiceDocumentsInfo();
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentNo = objDocumentsInfo.ACDocumentNo;
                            objClearInvoiceDocumentsInfo.FK_GECurrencyID = objDocumentsInfo.FK_GECurrencyID;
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentExchangeRate = objDocumentsInfo.ACDocumentExchangeRate;
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentAmount = objDocumentsInfo.ACDocumentTotalAmount;
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentRemainAmount = objDocumentsInfo.ACDocumentRemainAmount;
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentAllocatedAmount = objDocumentsInfo.ACDocumentTotalAmount - objDocumentsInfo.ACDocumentRemainAmount;
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentAllocationAmount = objDocumentsInfo.ACDocumentRemainAmount;
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentExchangeAmount = objDocumentsInfo.ACDocumentTotalAmount * objDocumentsInfo.ACDocumentExchangeRate / (mainObject.ARClearInvoiceExchangeRate == 0? 1: mainObject.ARClearInvoiceExchangeRate);
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentExchangeAllocatedAmount = (objDocumentsInfo.ACDocumentTotalAmount - objDocumentsInfo.ACDocumentRemainAmount)
                                                                                                                * objDocumentsInfo.ACDocumentExchangeRate / (mainObject.ARClearInvoiceExchangeRate == 0 ? 1 : mainObject.ARClearInvoiceExchangeRate);
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentReferenceID = objDocumentsInfo.APClearInvoiceInDocumentReferenceID;
                            objClearInvoiceDocumentsInfo.ARClearInvoiceDocumentReferenceModuleName = objDocumentsInfo.APClearInvoiceInDocumentReferenceModuleName;

                            mainObject.FK_GECurrencyID = objDocumentsInfo.FK_GECurrencyID;
                            mainObject.ARClearInvoiceExchangeRate = objDocumentsInfo.ACDocumentExchangeRate;
                            entity.DocumentList.Add(objClearInvoiceDocumentsInfo);
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
                ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
                ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)entity.MainObject;
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                if (string.IsNullOrEmpty(mainObject.ARObjectType) || mainObject.FK_ACObjectID == 0)
                {
                    MessageBox.Show(ClearInvoiceLocalizedResources.NoSelectObject, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (mainObject.FK_GECurrencyID == 0)
                {
                    MessageBox.Show(ClearInvoiceLocalizedResources.NoSelectFK_GECurrency, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ARClearInvoiceInvoicesController objClearInvoiceInvoicesController = new ARClearInvoiceInvoicesController();
                List<ARClearInvoiceInvoicesInfo> listInvoiceTransactions = objClearInvoiceInvoicesController.GetInvoiceTransactionsForClearInvoiceByObjectIDAndTypeAndCurrencyID(mainObject.FK_ACObjectID, mainObject.ARObjectType, mainObject.FK_GECurrencyID);
                guiFind<ARClearInvoiceInvoicesInfo> guiFind = new guiFind<ARClearInvoiceInvoicesInfo>(TableName.ARClearInvoiceInvoicesTableName
                                                                                                        , listInvoiceTransactions
                                                                                                        , this
                                                                                                        , true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                    {
                        foreach (ARClearInvoiceInvoicesInfo objClearInvoiceInvoicesInfo in guiFind.SelectedObjects)
                        {
                            objClearInvoiceInvoicesInfo.ARClearInvoiceInvoiceExchangeAllocationAmount = objClearInvoiceInvoicesInfo.ARClearInvoiceInvoiceRemainAmount;
                            objClearInvoiceInvoicesInfo.ARClearInvoiceInvoiceExchangeAmount = objClearInvoiceInvoicesInfo.ARClearInvoiceInvoiceAmount * mainObject.ARClearInvoiceExchangeRate;
                            objClearInvoiceInvoicesInfo.ARClearInvoiceInvoiceExchangeAllocationAmount = objClearInvoiceInvoicesInfo.ARClearInvoiceInvoiceRemainAmount * mainObject.ARClearInvoiceExchangeRate;
                            if (entity.InvoiceItemList.Count > 0)
                            {
                                ARClearInvoiceInvoicesInfo objExist = entity.InvoiceItemList.FirstOrDefault(a => a.ARClearInvoiceInvoiceNo == objClearInvoiceInvoicesInfo.ARClearInvoiceInvoiceNo);
                                if (objExist == null)
                                {
                                    entity.InvoiceItemList.Add(objClearInvoiceInvoicesInfo);
                                }
                            }
                            else
                            {
                                entity.InvoiceItemList.Add(objClearInvoiceInvoicesInfo);
                            }
                        }
                        entity.InvoiceItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        public override int ActionSave()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)entity.MainObject;
            entity.DocumentList.EndCurrentEdit();
            entity.InvoiceItemList.EndCurrentEdit();
            UpdateEvaluateExchangeRate();

            decimal totalDocumentAmount = 0;
            decimal totalInvoiceInClearing = 0;
            if (entity.DocumentList != null && entity.DocumentList.Count > 0)
            {
                totalDocumentAmount = entity.DocumentList.Sum(a => a.ARClearInvoiceDocumentAllocationAmount);
            }
            if (entity.InvoiceItemList != null && entity.InvoiceItemList.Count > 0)
            {
                totalInvoiceInClearing = entity.InvoiceItemList.Sum(a => a.ARClearInvoiceInvoiceAllocationAmount);
            }
            if (totalInvoiceInClearing != totalDocumentAmount)
            {
                MessageBox.Show("Vui lòng chạy phân bổ trước khi lưu!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            return base.ActionSave();
        }
        
        public void ChangeFK_ACObjectID(string objectAccessKey)
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                string[] objectAccessKeys = objectAccessKey.Split(';');
                int id = int.Parse(objectAccessKeys[0]);
                string type = objectAccessKeys[1];

                mainObject.FK_ACObjectID = id;
                mainObject.ARObjectType = type;
                ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(id, type);
                if (objObjectsInfo != null)
                {
                    mainObject.FK_ACAccountSaleID = objObjectsInfo.FK_ACAccountSaleID;
                    mainObject.ARClearInvoiceObjectName = objObjectsInfo.ACObjectName;
                }
            }
            else
            {
                mainObject.FK_ACObjectID = 0;
                mainObject.ARObjectType = "";
                mainObject.FK_ACAccountSaleID = 0;
                mainObject.ARClearInvoiceObjectName = "";
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void RunAllocation()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)entity.MainObject;
            decimal totalAllocationAmount = 0;
            if (entity.DocumentList != null && entity.DocumentList.Count > 0)
            {
                totalAllocationAmount = entity.DocumentList.Sum(a => a.ARClearInvoiceDocumentAllocationAmount);
                entity.InvoiceItemList.ForEach(a =>
                    {
                        if (totalAllocationAmount > 0)
                        {
                            if ((totalAllocationAmount - a.ARClearInvoiceInvoiceRemainAmount) > 0)
                            {
                                a.ARClearInvoiceInvoiceAllocationAmount = a.ARClearInvoiceInvoiceRemainAmount;
                                totalAllocationAmount -= a.ARClearInvoiceInvoiceRemainAmount;
                            }
                            else
                            {
                                a.ARClearInvoiceInvoiceAllocationAmount = totalAllocationAmount;
                                totalAllocationAmount = 0;
                            }
                        }
                        else
                        {
                            a.ARClearInvoiceInvoiceAllocationAmount = 0;
                        }
                    });
                totalAllocationAmount = entity.InvoiceItemList.Sum(o => o.ARClearInvoiceInvoiceAllocationAmount);
                entity.DocumentList[0].ARClearInvoiceDocumentAllocationAmount = totalAllocationAmount;
            }
            else
            {
                entity.InvoiceItemList.ForEach(a => a.ARClearInvoiceInvoiceAllocationAmount = 0);
            }
            entity.InvoiceItemList.GridControl.RefreshDataSource();
            MessageBox.Show("Đã phân bổ " + totalAllocationAmount.ToString("n3")
                           , CommonLocalizedResources.MessageBoxDefaultCaption
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override bool ActionComplete()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)entity.MainObject;

            bool isSuccess = base.ActionComplete();
            if (isSuccess)
            {
                GLHelper.PostedTransactions(this.Name, mainObject.ARClearInvoiceID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans);
                InvalidateToolbar();
            }
            return isSuccess;
        }

        public void ChangeCurrency(int currencyID)
        {
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_GECurrencyID = currencyID;
            GECurrencyExchangeRatesController objCurrencyExchangeRatesController = new GECurrencyExchangeRatesController();
            decimal exchangeRateValue = objCurrencyExchangeRatesController.GetCurrencyExchangeRateTransferByCurrencyIDAndDate(currencyID, mainObject.ARClearInvoiceDate);
            if (exchangeRateValue > 0)
            {
                mainObject.ARClearInvoiceExchangeRate = exchangeRateValue;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ChangeAllocationAmount()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)CurrentModuleEntity.MainObject;
            entity.InvoiceItemList.EndCurrentEdit();
            decimal totalAllocationAmount = 0;
            if (entity.InvoiceItemList != null && entity.InvoiceItemList.Count > 0)
            {
                totalAllocationAmount = entity.InvoiceItemList.Sum(a => a.ARClearInvoiceInvoiceAllocationAmount * a.ARClearInvoiceInvoiceExchangeRate);
            }
            if (entity.DocumentList.Count > 0)
            {
                if (entity.DocumentList[0].ARClearInvoiceDocumentRemainAmount < totalAllocationAmount)
                {
                    MessageBox.Show(ClearInvoiceInLocalizedResources.ErrorAllocationAmount2,
                                            BaseLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    entity.DocumentList[0].ARClearInvoiceDocumentAllocationAmount = totalAllocationAmount;
                }
            }
            entity.DocumentList.EndCurrentEdit();
            entity.InvoiceItemList.GridControl.RefreshDataSource();
            entity.DocumentList.GridControl.RefreshDataSource();
        }

        public override void ActionDelete()
        {
            base.ActionDelete();
        }

        public override bool ActionCancelComplete()
        {
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)CurrentModuleEntity.MainObject;
            if (!base.ActionCancelComplete()) return false;
            GLHelper.UnPostedTransactions(this.Name, mainObject.ARClearInvoiceID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans);
            InvalidateToolbar();
            return true;
        }

        private void UpdateEvaluateExchangeRate()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)CurrentModuleEntity;
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)CurrentModuleEntity.MainObject;

            if (entity.DocumentList != null && entity.DocumentList.Count > 0)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.ARObjectType);

                ARClearInvoiceDocumentsInfo payDocuments = entity.DocumentList[0];
                if(payDocuments != null)
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
                                                            || payDocuments.ARClearInvoiceDocumentExchangeRate != 1))
                    {
                        ARInvoicesController objInvoicesController = new ARInvoicesController();
                        List<ARClearInvoiceInvoicesInfo> invoiceList = entity.InvoiceItemList.Where(a => !string.IsNullOrWhiteSpace(a.ARClearInvoiceInvoiceNo)).ToList();

                        ARInvoiceTransactionsController objSOPTIDController = new ARInvoiceTransactionsController();
                        List<ARInvoiceTransactionsInfo> sOPaymentTimeInvoiceDetails = null;
                        ARInvoiceTransactionsInfo objSOPaymentTimeInvoiceDetailsInfo = null;
                        if (invoiceList != null && invoiceList.Count > 0)
                        {
                            ARInvoiceTransactionsController ptiController = new ARInvoiceTransactionsController();
                            invoiceList.ForEach(a =>
                            {
                                tienlo = 0;
                                tienlai = 0;
                                sOPaymentTimeInvoiceDetails = objSOPTIDController.GetClearingInfoByInvoiceID(a.FK_ARInvoiceID, a.ARClearInvoiceInvoiceNo, mainObject.FK_ACObjectID, mainObject.ARObjectType);
                                objSOPaymentTimeInvoiceDetailsInfo = objSOPTIDController.GetInvoiceInfoByInvoiceID(a.FK_ARInvoiceID, a.ARClearInvoiceInvoiceNo, mainObject.FK_ACObjectID, mainObject.ARObjectType) as ARInvoiceTransactionsInfo;

                                if (objSOPaymentTimeInvoiceDetailsInfo != null)
                                {
                                    tienConLai = objSOPaymentTimeInvoiceDetailsInfo.ARInvoiceAmount - sOPaymentTimeInvoiceDetails.Sum(o => o.ARInvoicePaymentAmount);
                                    tienConLaiQD = objSOPaymentTimeInvoiceDetailsInfo.ARInvoiceAmountExchange - sOPaymentTimeInvoiceDetails.Sum(o => o.ARInvoicePaymentAmountExchange);
                                    if (tienConLai > 0)
                                    {
                                        tyGiaTB = tienConLaiQD / tienConLai;
                                    }
                                    tyGiaTT = Math.Min(tyGiaTB, payDocuments.ARClearInvoiceDocumentExchangeRate);
                                }

                                if (tyGiaTB > payDocuments.ARClearInvoiceDocumentExchangeRate)
                                {
                                    tienlo = a.ARClearInvoiceInvoiceAllocationAmount * (tyGiaTB - payDocuments.ARClearInvoiceDocumentExchangeRate);
                                }
                                if (tyGiaTB < payDocuments.ARClearInvoiceDocumentExchangeRate)
                                {
                                    tienlai = a.ARClearInvoiceInvoiceAllocationAmount * (payDocuments.ARClearInvoiceDocumentExchangeRate - tyGiaTB);
                                }

                                if (tienlai > 0)
                                {
                                    a.ARClearInvoiceInvoiceRateVariance = tienlai;
                                }
                                else if (tienlo > 0)
                                {
                                    a.ARClearInvoiceInvoiceRateVariance = -tienlo;
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
