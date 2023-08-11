using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ClearingDebt
{
    public class ClearingDebtModule : BaseTransactionModule
    {
        #region Constant
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string Object2LookupEditControlName = "fld_lkeObject2";
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
        public BOSLookupEdit Object2LookupEditControl = null;
        #endregion

        #region Constructor
        public ClearingDebtModule()
        {
            Name = "ClearingDebt";
            CurrentModuleEntity = new ClearingDebtEntities();
            CurrentModuleEntity.Module = this;

            // BOSApp.InitLookupTables();
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            Object2LookupEditControl = (BOSLookupEdit)Controls[Object2LookupEditControlName];
            InitObject2ControlDataSource();
        }
        #endregion
        public void InitObject2ControlDataSource()
        {
            List<ACObjectsInfo> objects = BOSApp.AccountingObjects.ToList();
            foreach (ACObjectsInfo obj in objects)
            {
                obj.ACObjectAccessKey2 = obj.ACObjectAccessKey;
            }

            if (Object2LookupEditControl.BOSAllowDummy)
            {
                objects.Insert(0, new ACObjectsInfo());
            }

            LookUpColumnInfo column = new LookUpColumnInfo();
            column.Caption = CommonLocalizedResources.ACObjectNo;
            column.FieldName = "ACObjectNo";
            Object2LookupEditControl.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.Caption = CommonLocalizedResources.ACObjectName;
            column.FieldName = "ACObjectName";
            Object2LookupEditControl.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.Caption = CommonLocalizedResources.ACObjectContactPhone;
            column.FieldName = "ACObjectContactPhone";
            Object2LookupEditControl.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.Caption = CommonLocalizedResources.ACObjectContactAddress;
            column.FieldName = "ACObjectContactAddress";
            Object2LookupEditControl.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.FieldName = "ACObjectAccessKey2";
            column.Visible = false;
            Object2LookupEditControl.Properties.Columns.Add(column);

            Object2LookupEditControl.Properties.ValueMember = "ACObjectAccessKey2";
            Object2LookupEditControl.Properties.DisplayMember = "ACObjectName";
            Object2LookupEditControl.Properties.DataSource = objects;
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
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #region Overrides
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACClearingDebtsController objClearingDebtsController = new ACClearingDebtsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACClearingDebtsInfo searchObject = (ACClearingDebtsInfo)CurrentModuleEntity.SearchObject;
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
                                                                        searchObject.ACClearingDebtNo,
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
                                                                        searchObject.ACClearingDebtNo,
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
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            mainObject.ACObjectAccessKey2 = mainObject.FK_ACObjectID2 + ";" + mainObject.ACObjectType2;
            Object2LookupEditControl.EditValue = mainObject.ACObjectAccessKey2;
            entity.UpdateMainObjectBindingSource();
        }
        #endregion

        #region Methods
        public override void InvalidateToolbar()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            if (mainObject.ACClearingDebtID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                if (mainObject.ACClearingDebtStatus == PurchaseOrderStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                            mainObject.ACClearingDebtPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        mainObject.ACClearingDebtPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
                if (mainObject.ACClearingDebtStatus == PurchaseOrderStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }
            }
            base.InvalidateToolbar();
        }

        public void DeleteSelectedInvoice()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            entity.InvoiceItemList.RemoveSelectedRowObjectFromList();
            //UpdateTotalAmount();
            UpdateDocumentEntries();
        }

        public void DeleteSelectedInvoiceIn()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            entity.InvoiceInItemList.RemoveSelectedRowObjectFromList();
            //UpdateTotalAmount();
            UpdateDocumentEntries();
        }
        #endregion

        #region Accounting
        public void UpdateDocumentEntriesExt()
        {
            UpdateDocumentEntries();
        }

        protected override void UpdateDocumentEntries()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;

            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                               AccDocumentType.BuTruCongNo.ToString(),
                                                               AccEntryType.BuTruCongNo.ToString());

            if (defaultEntry != null)
            {
                List<string> distinctGroups = entity.InvoiceInItemList.Select(t => t.ACClearingDebtInvoiceInItemGroup).Distinct().ToList();

                entity.DocumentEntryList.Clear();
                ACDocumentEntrysInfo entry;
                foreach (string key in distinctGroups)
                {
                    entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);

                    if (entity.InvoiceInItemList.FirstOrDefault(t => t.ACClearingDebtInvoiceInItemGroup == key) != null)
                    {
                        if (entity.InvoiceInItemList.FirstOrDefault(t => t.ACClearingDebtInvoiceInItemGroup == key).FK_ACAccountID != 0)
                            entry.FK_ACDebitAccountID = entity.InvoiceInItemList.FirstOrDefault(t => t.ACClearingDebtInvoiceInItemGroup == key).FK_ACAccountID;
                    }


                    if (entity.InvoiceItemList.FirstOrDefault(t => t.ACClearingDebtInvoiceItemGroup == key) != null)
                    {
                        if (entity.InvoiceItemList.FirstOrDefault(t => t.ACClearingDebtInvoiceItemGroup == key).FK_ACAccountID != 0)
                            entry.FK_ACCreditAccountID = entity.InvoiceItemList.FirstOrDefault(t => t.ACClearingDebtInvoiceItemGroup == key).FK_ACAccountID;
                    }

                    if (entity.InvoiceInItemList.Where(t => t.ACClearingDebtInvoiceInItemGroup == key) != null)
                    {
                        entry.ACDocumentEntryAmount = entity.InvoiceInItemList.Where(t => t.ACClearingDebtInvoiceInItemGroup == key)
                                                        .Sum(t => t.ACClearingDebtInvoiceInItemAmountClearing);
                    }
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * mainObject.ACClearingDebtExchangeRate;

                    entry.FK_ACObjectID = mainObject.FK_ACObjectID;
                    entry.FK_ACAssObjectID = mainObject.FK_ACObjectID2;
                    entry.ACObjectType = mainObject.ACObjectType;
                    entry.ACAssObjectType = mainObject.ACObjectType2;
                }
                entity.DocumentEntryList.GridControl.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Vui lòng cấu hình bút toán cho loại chứng từ này trước"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
        }
        #endregion

        public void ShowInvoiceList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
                ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ACClearingDebtInvoiceItemsController objClearingDebtInvoiceItemsController = new ACClearingDebtInvoiceItemsController();
                //lấy giá trị của invoice
                List<ACClearingDebtInvoiceItemsInfo> listClearingDebtInvoiceItemsInfo = objClearingDebtInvoiceItemsController.GetInvoicesForClearingDebt(mainObject.FK_ACObjectID2, mainObject.ACObjectType2, mainObject.FK_GECurrencyID, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                guiFind<ACClearingDebtInvoiceItemsInfo> guiFind = new guiFind<ACClearingDebtInvoiceItemsInfo>(TableName.ACClearingDebtInvoiceItemsTableName
                                                                                                                  , listClearingDebtInvoiceItemsInfo
                                                                                                                  , this
                                                                                                                  , true
                                                                                                                  , true);
                guiFind.Module = this;
            stampp:
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    ACClearingDebtInvoiceItemsInfo invalidItem = guiFind.SelectedObjects.FirstOrDefault(t => (t.ACObjectID != guiFind.SelectedObjects[0].ACObjectID || t.ARObjectType != guiFind.SelectedObjects[0].ARObjectType));
                    if (invalidItem != null)
                    {
                        MessageBox.Show(PaymentVoucherLocalizedResources.ErrorObject
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                        goto stampp;
                    }
                    invalidItem = guiFind.SelectedObjects.FirstOrDefault();
                    if (invalidItem != null)
                    {
                        ACClearingDebtInvoiceInItemsInfo objClearingDebtInvoiceInItemsInfo = entity.InvoiceInItemList.FirstOrDefault();
                        if (objClearingDebtInvoiceInItemsInfo != null)
                        {
                            if (invalidItem.FK_GECurrencyID != objClearingDebtInvoiceInItemsInfo.FK_GECurrencyID)
                            {
                                MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                                goto stampp;
                            }
                        }
                    }
                    if (mainObject.FK_ACObjectID2 == 0)
                    {
                        mainObject.FK_ACObjectID2 = guiFind.SelectedObjects[0].ACObjectID;
                        mainObject.ACObjectType2 = guiFind.SelectedObjects[0].ARObjectType;
                        mainObject.FK_GECurrencyID = guiFind.SelectedObjects[0].FK_GECurrencyID;
                        mainObject.ACObjectAccessKey2 = mainObject.FK_ACObjectID2 + ";" + mainObject.ACObjectType2;
                        entity.UpdateMainObjectBindingSource();
                    }
                    entity.InvoiceItemList.Invalidate(guiFind.SelectedObjects);
                    entity.InvoiceItemList.GridControl.RefreshDataSource();
                    UpdateDocumentEntries();
                }
            }
        }

        public void ShowInvoiceInList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
                ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
                ACClearingDebtInvoiceInItemsController objClearingDebtInvoiceInItemsController = new ACClearingDebtInvoiceInItemsController();
                //lấy giá trị của invoiceIn
                List<ACClearingDebtInvoiceInItemsInfo> listClearingDebtInvoiceInItemsInfo = objClearingDebtInvoiceInItemsController.GetInvoiceInsForClearingDebt(mainObject.FK_ACObjectID, mainObject.ACObjectType, mainObject.FK_GECurrencyID, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                guiFind<ACClearingDebtInvoiceInItemsInfo> guiFind = new guiFind<ACClearingDebtInvoiceInItemsInfo>(TableName.ACClearingDebtInvoiceInItemsTableName,
                                                                                                                    listClearingDebtInvoiceInItemsInfo,
                                                                                                                    this,
                                                                                                                    true);
                guiFind.Module = this;
            stampp:
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    if (guiFind.SelectedObjects.Count > 0)
                    {
                        ACClearingDebtInvoiceInItemsInfo invalidItem = guiFind.SelectedObjects.FirstOrDefault(t => t.ACObjectID != guiFind.SelectedObjects[0].ACObjectID || t.ACObjectType != guiFind.SelectedObjects[0].ACObjectType);
                        if (invalidItem != null)
                        {
                            MessageBox.Show(PaymentVoucherLocalizedResources.ErrorObject
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Information);
                            goto stampp;
                        }
                        invalidItem = guiFind.SelectedObjects.FirstOrDefault();
                        if (invalidItem != null)
                        {
                            ACClearingDebtInvoiceItemsInfo objClearingDebtInvoiceItemsInfo = entity.InvoiceItemList.FirstOrDefault();
                            if (objClearingDebtInvoiceItemsInfo != null)
                            {
                                if (invalidItem.FK_GECurrencyID != objClearingDebtInvoiceItemsInfo.FK_GECurrencyID)
                                {
                                    MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Information);
                                    goto stampp;
                                }
                            }
                        }
                        if (mainObject.FK_ACObjectID == 0)
                        {
                            mainObject.FK_ACObjectID = guiFind.SelectedObjects[0].ACObjectID;
                            mainObject.ACObjectType = guiFind.SelectedObjects[0].ACObjectType;
                            mainObject.FK_GECurrencyID = guiFind.SelectedObjects[0].FK_GECurrencyID;
                            mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                            entity.UpdateMainObjectBindingSource();
                        }
                        entity.InvoiceInItemList.Invalidate(guiFind.SelectedObjects);
                        entity.InvoiceInItemList.GridControl.RefreshDataSource();
                        UpdateDocumentEntries();
                    }
                }
            }
        }

        public override int ActionSave()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            if (mainObject.ACClearingDebtAmountClearing <= 0)
            {
                MessageBox.Show(ClearingDebtLocalizedResources.ErrorAmount,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return 0;
            }
            if (!UpdateTotalAmount())
                return 0;

            decimal totalInvoiceClearing = 0;
            decimal totalInvoiceInClearing = 0;

            List<string> distinctGroups = entity.InvoiceItemList.Select(t => t.ACClearingDebtInvoiceItemGroup).Distinct().ToList();

            foreach (string group in distinctGroups)
            {
                totalInvoiceClearing = 0;
                if (entity.InvoiceItemList.Where(t => t.ACClearingDebtInvoiceItemGroup == group) != null)
                {
                    totalInvoiceClearing = entity.InvoiceItemList.Where(t => t.ACClearingDebtInvoiceItemGroup == group)
                                            .Sum(i => i.ACClearingDebtInvoiceItemAmountClearing);
                }

                totalInvoiceInClearing = 0;
                if (entity.InvoiceInItemList.Where(t => t.ACClearingDebtInvoiceInItemGroup == group) != null)
                {
                    totalInvoiceInClearing = entity.InvoiceInItemList.Where(t => t.ACClearingDebtInvoiceInItemGroup == group)
                                            .Sum(i => i.ACClearingDebtInvoiceInItemAmountClearing);
                }

                if (totalInvoiceClearing != totalInvoiceInClearing)
                {
                    MessageBox.Show(ClearingDebtLocalizedResources.NotClearing, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }

            distinctGroups = entity.InvoiceInItemList.Select(t => t.ACClearingDebtInvoiceInItemGroup).Distinct().ToList();

            foreach (string group in distinctGroups)
            {
                totalInvoiceClearing = 0;
                if (entity.InvoiceItemList.Where(t => t.ACClearingDebtInvoiceItemGroup == group) != null)
                {
                    totalInvoiceClearing = entity.InvoiceItemList.Where(t => t.ACClearingDebtInvoiceItemGroup == group)
                                            .Sum(i => i.ACClearingDebtInvoiceItemAmountClearing);
                }

                totalInvoiceInClearing = 0;
                if (entity.InvoiceInItemList.Where(t => t.ACClearingDebtInvoiceInItemGroup == group) != null)
                {
                    totalInvoiceInClearing = entity.InvoiceInItemList.Where(t => t.ACClearingDebtInvoiceInItemGroup == group)
                                            .Sum(i => i.ACClearingDebtInvoiceInItemAmountClearing);
                }

                if (totalInvoiceClearing != totalInvoiceInClearing)
                {
                    MessageBox.Show(ClearingDebtLocalizedResources.NotClearing, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }
            List<ACClearingDebtInvoiceItemsInfo> checkCurrencyInvoice = entity.InvoiceItemList.Where(i => i.FK_GECurrencyID != mainObject.FK_GECurrencyID).ToList();
            if (checkCurrencyInvoice.Count > 0)
            {
                MessageBox.Show(ClearingDebtLocalizedResources.CurrencyInvoiceOtherCurrencyClearingDebt, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            List<ACClearingDebtInvoiceInItemsInfo> checkCurrencyInvoiceIn = entity.InvoiceInItemList.Where(i => i.FK_GECurrencyID != mainObject.FK_GECurrencyID).ToList();
            if (checkCurrencyInvoiceIn.Count > 0)
            {
                MessageBox.Show(ClearingDebtLocalizedResources.CurrencyInvoiceInOtherCurrencyClearingDebt, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            for (int i = 0; i < entity.InvoiceInItemList.Count; i++)
            {
                if (entity.InvoiceInItemList[i].ACClearingDebtInvoiceInItemAmountClearing <= 0)
                {
                    entity.InvoiceInItemList.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < entity.InvoiceItemList.Count; i++)
            {
                if (entity.InvoiceItemList[i].ACClearingDebtInvoiceItemAmountClearing <= 0)
                {
                    entity.InvoiceItemList.RemoveAt(i);
                    i--;
                }
            }

            return base.ActionSave();
        }

        public void ChangeObject2(string object2AccessKey)
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            if (!string.IsNullOrEmpty(object2AccessKey))
            {
                string[] object2AccessKeys = object2AccessKey.Split(';');
                int id = int.Parse(object2AccessKeys[0]);
                string type = object2AccessKeys[1];

                mainObject.FK_ACObjectID2 = id;
                mainObject.ACObjectType2 = type;
            }
            else
            {
                mainObject.FK_ACObjectID2 = 0;
                mainObject.ACObjectType2 = "";
            }
            entity.UpdateMainObjectBindingSource();

        }

        public void ChangeFK_ACObjectID(string objectAccessKey)
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                string[] objectAccessKeys = objectAccessKey.Split(';');
                int id = int.Parse(objectAccessKeys[0]);
                string type = objectAccessKeys[1];

                mainObject.FK_ACObjectID = id;
                mainObject.ACObjectType = type;
            }
            else
            {
                mainObject.FK_ACObjectID = 0;
                mainObject.ACObjectType = "";
            }
            entity.UpdateMainObjectBindingSource();
        }

        public override void ModuleAfterCompleted()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACClearingDebtPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            GLHelper.PostedTransactions(this.Name, mainObject.ACClearingDebtID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.InvoiceInTrans);
            entity.SetPropertyChangeEventLock(true);
            base.ModuleAfterCompleted();
            InvalidateAccountingEntries();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            mainObject.ACClearingDebtPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACClearingDebtID, PostedTransactionStatus.Posted.ToString());
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACClearingDebtID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.InvoiceInTrans);
            InvalidateAccountingEntries();
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            mainObject.ACClearingDebtPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACClearingDebtID, PostedTransactionStatus.UnPosted.ToString());
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACClearingDebtID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.InvoiceInTrans);
            InvalidateAccountingEntries();
            InvalidateToolbar();
        }

        public bool UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
                ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;

                decimal totalInvoiceInAmount = entity.InvoiceInItemList.Sum(i => i.ACClearingDebtInvoiceInItemRemainAmount);
                decimal totalInvoiceAmount = entity.InvoiceItemList.Sum(i => i.ACClearingDebtInvoiceItemRemainAmount);
                decimal totalAmountClearing = mainObject.ACClearingDebtAmountClearing;
                if (totalAmountClearing > totalInvoiceInAmount)
                {
                    List<GECurrenciesInfo> listCurrenciesInfo = (List<GECurrenciesInfo>)(new GECurrenciesController()).GetListFromDataSet(BOSApp.LookupTables[TableName.GECurrenyTableName] as DataSet);
                    GECurrenciesInfo objCurrenciesInfo = listCurrenciesInfo.FirstOrDefault(p => p.GECurrencyID == mainObject.FK_GECurrencyID);
                    MessageBox.Show(ClearingDebtLocalizedResources.ErrorAmountClearing + totalInvoiceInAmount.ToString("n2") + " " + objCurrenciesInfo.GECurrencyName
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
                    return false;
                }
                if (totalAmountClearing > totalInvoiceAmount)
                {
                    List<GECurrenciesInfo> listCurrenciesInfo = (List<GECurrenciesInfo>)(new GECurrenciesController()).GetListFromDataSet(BOSApp.LookupTables[TableName.GECurrenyTableName] as DataSet);
                    GECurrenciesInfo objCurrenciesInfo = listCurrenciesInfo.FirstOrDefault(p => p.GECurrencyID == mainObject.FK_GECurrencyID);
                    MessageBox.Show(ClearingDebtLocalizedResources.ErrorAmountClearing + totalInvoiceAmount.ToString("n2") + " " + objCurrenciesInfo.GECurrencyName
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
                    return false;
                }

                foreach (ACClearingDebtInvoiceInItemsInfo itemInvoiceIn in entity.InvoiceInItemList)
                {
                    if (itemInvoiceIn.ACClearingDebtInvoiceInItemRemainAmount <= totalAmountClearing)
                    {
                        itemInvoiceIn.ACClearingDebtInvoiceInItemAmountClearing = itemInvoiceIn.ACClearingDebtInvoiceInItemRemainAmount;
                    }
                    else
                    {
                        itemInvoiceIn.ACClearingDebtInvoiceInItemAmountClearing = totalAmountClearing;
                    }
                    totalAmountClearing -= itemInvoiceIn.ACClearingDebtInvoiceInItemAmountClearing;
                }
                totalAmountClearing = mainObject.ACClearingDebtAmountClearing;
                foreach (ACClearingDebtInvoiceItemsInfo itemInvoice in entity.InvoiceItemList)
                {
                    if (itemInvoice.ACClearingDebtInvoiceItemRemainAmount <= totalAmountClearing)
                    {
                        itemInvoice.ACClearingDebtInvoiceItemAmountClearing = itemInvoice.ACClearingDebtInvoiceItemRemainAmount;
                    }
                    else
                    {
                        itemInvoice.ACClearingDebtInvoiceItemAmountClearing = totalAmountClearing;
                    }
                    totalAmountClearing -= itemInvoice.ACClearingDebtInvoiceItemAmountClearing;
                }
                entity.UpdateMainObjectBindingSource();
                UpdateDocumentEntries();
                entity.InvoiceInItemList.GridControl.RefreshDataSource();
                entity.InvoiceItemList.GridControl.RefreshDataSource();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangeCurrency(int currencyID)
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)CurrentModuleEntity;
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACClearingDebtDate);
            mainObject.ACClearingDebtExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : 1;
            UpdateTotalAmount();
        }
    }
}
