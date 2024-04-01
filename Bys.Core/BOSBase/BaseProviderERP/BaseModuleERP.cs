using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Extensions;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSLib.Interfaces;
using BOSReport;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP
{
    /// <summary>
    /// Declare some functions and virtual functions for each module manager.
    /// </summary>
    public partial class BaseModuleERP : BaseModule, IBaseModuleERP
    {
        #region Variables
        protected ERPModuleEntities _currentModuleEntity;
        protected ModuleParentScreen _parentScreen;
        protected ModuleSearchScreen _searchScreen;
        protected SortedList<String, ControlCollection> _fieldGroupControls;
        protected String _destinationAction = String.Empty;
        protected object[] _destinationActionParameters;
        protected BaseModuleERP _owner;
        protected String _displayModus;
        protected string _toolbarActionName;
        protected string _toolbarNewActionName;
        protected guiErrorMessage ErrorMessageScreen;
        protected DataTable ErrorTable = new DataTable();
        protected bool IsShowPopup = false;
        public List<ICInventoryStocksInfo> CentralInventoryStocks { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the entity of the module that is responsible for handling business process
        /// </summary>
        public ERPModuleEntities CurrentModuleEntity
        {
            get { return _currentModuleEntity; }
            set { _currentModuleEntity = value; }
        }

        /// <summary>
        /// Gets or sets the screen containing the module's interface
        /// </summary>
        public ModuleParentScreen ParentScreen
        {
            get { return _parentScreen; }
            set { _parentScreen = value; }
        }

        /// <summary>
        /// Gets or sets the screen containing the search criteria of the module
        /// </summary>
        public ModuleSearchScreen SearchScreen
        {
            get { return _searchScreen; }
            set { _searchScreen = value; }
        }

        /// <summary>
        /// Gets or sets the control collection seperated by STFieldGroup
        /// </summary>
        public SortedList<String, ControlCollection> FieldGroupControls
        {
            get
            {
                return _fieldGroupControls;
            }
            set
            {
                _fieldGroupControls = value;
            }
        }

        /// <summary>
        /// Gets or sets the destination action of an action chain that is relative to some modules
        /// </summary>
        public String DestinationAction
        {
            get
            {
                return _destinationAction;
            }
            set
            {
                _destinationAction = value;
            }
        }

        /// <summary>
        /// Gets or sets the parameters that need to be passed to the destination action
        /// </summary>
        public object[] DestinationActionParameters
        {
            get
            {
                return _destinationActionParameters;
            }
            set
            {
                _destinationActionParameters = value;
            }
        }

        /// <summary>
        /// Gets or sets the module calls this one
        /// </summary>
        public BaseModuleERP Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }

        public String DisplayModus
        {
            get { return _displayModus; }
            set { _displayModus = value; }
        }
        public String ToolbarActionName
        {
            get { return _toolbarActionName; }
            set { _toolbarActionName = value; }
        }
        public String ToolbarNewActionName
        {
            get { return _toolbarNewActionName; }
            set { _toolbarNewActionName = value; }
        }
        protected List<String> SerialLookupEditTableNamesList { get; set; }
        #endregion

        #region Constructor
        /// <summary type="Constructor">
        /// Default Constructor
        /// </summary>
        public BaseModuleERP()
        {
            Toolbar = new BaseToolbar();
            Screens = new List<BOSScreen>();
            Controls = new ControlCollection();

            FieldGroupControls = new SortedList<string, ControlCollection>();

            ParentScreen = new ModuleParentScreen();
            ParentScreen.Module = this;
            ParentScreen.MdiParent = BOSApp.MainScreen;

            ParentScreen.ButtonCreateCriteria.DropDownControl = ParentScreen.ModuleUserCriteriaContainer;
            ParentScreen.ButtonCreateCriteria.ShowDropDownControl += new DevExpress.XtraEditors.ShowDropDownControlEventHandler(CreateCriteriaDropDownButton_ShowDropDownControl);
            SearchScreen = new ModuleSearchScreen();
            SearchScreen.Module = this;
            ErrorTable = InitErrorTable();

            //Add code init CurrentModuleObject
            CurrentModuleEntity = new ERPModuleEntities();

            DisplayModus = BaseModule.cstModusNormal;

            CentralInventoryStocks = new List<ICInventoryStocksInfo>();
            SerialLookupEditTableNamesList = new List<string>()
            {
                TableName.ICShipmentItemsTableName,
                TableName.ARSaleOrderItemsTableName,
                TableName.ARInvoiceItemsTableName,
                TableName.ARDeliveryPlanItemsTableName,
                TableName.ICTransferItemsTableName,
                TableName.APReturnSupplierItemsTableName,
                TableName.ACAssetReceiptItemsTableName,
                TableName.ARSaleForecastItemsTableName,
                TableName.ICShipmentItemVMsTableName,
                TableName.ICConversionProposalItemsTableName
            };
        }


        /// <summary type="Initialize">
        /// Initialize Module
        /// </summary>
        public virtual void InitializeModule()
        {
            BOSProgressBar.Start(BaseLocalizedResources.InitModuleMessage);
            //Catch data 
            FieldFormatList = BOSApp.FieldFormatList;
            LstField = BOSApp.LstField;
            LstFieldPermission = BOSApp.LstFieldPermission;
            LstFieldEvent = BOSApp.LstFieldEvent;
            LstColumnAlias = BOSApp.LstColumnAlias;
            LstFieldColumn = BOSApp.LstFieldColumn;

            STModulesController objModulesController = new STModulesController();
            ModuleID = BOSApp.ModuleList.Exists(o => o.STModuleName == Name) ? BOSApp.ModuleList.Where(m => m.STModuleName == Name).FirstOrDefault().STModuleID : 0;
            //Init module
            CurrentModuleEntity.InitModuleEntity();

            GetFormatGroups();

            InitModuleToolbarEvents();
            InitGridCotrolCriteria();

            //Init screen
            InitializeScreens();

            //Init all GridControl in BOSList
            CurrentModuleEntity.InitGridControlInBOSList();

            if (CurrentModuleEntity.MainObject != null)
            {
                CurrentModuleEntity.CreateMainObjectRule();
                CurrentModuleEntity.SubcribeMainObjectEvent();
            }
            BOSProgressBar.Close();

        }
        #endregion

        /// <summary>
        /// Get format group list of table columns of the module
        /// </summary>
        public void GetFormatGroups()
        {
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            FormatGroups = BOSApp.FieldFormatList.Where(f => f.STModuleID == ModuleID).ToList();
        }

        #region Toolbar Manager Functions

        #region "Functions for toolbar action"

        private DataTable InitErrorTable()
        {
            DataTable tblError = new DataTable { TableName = "Error" };

            DataColumn colErrorControl = new DataColumn { ColumnName = "Control", DataType = typeof(String) };
            tblError.Columns.Add(colErrorControl);

            DataColumn colErrorMessage = new DataColumn { ColumnName = "Message", DataType = typeof(String) };
            tblError.Columns.Add(colErrorMessage);

            DataColumn colPosition = new DataColumn { ColumnName = "Position", DataType = typeof(int) };
            tblError.Columns.Add(colPosition);

            DataColumn colComment = new DataColumn { ColumnName = "Comment", DataType = typeof(String) };
            tblError.Columns.Add(colComment);

            return tblError;
        }

        protected virtual DataTable CheckInvalidInputBeforeSave()
        {
            DataTable tblError = InitErrorTable();
            if (CurrentModuleEntity.MainObject != null)
            {
                STFieldsController objFieldsController = new STFieldsController();
                foreach (BusinessRule r in CurrentModuleEntity.MainObject.BusinessRuleCollections)
                {
                    bool isRuleBroken = !r.ValidateRule(CurrentModuleEntity.MainObject);
                    if (isRuleBroken)
                    {
                        String strErrorMessage = r.Description;
                        String strMainObjectName = CurrentModuleEntity.MainObject.GetType().Name;
                        String strFieldDataSource = strMainObjectName.Substring(0, strMainObjectName.Length - 4);
                        STFieldsInfo objSTFieldsInfo = BOSApp.LstField.FirstOrDefault(f => f.STModuleID == ModuleID
                                                                                           && f.STUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID
                                                                                           && f.STFieldDataSource == strFieldDataSource
                                                                                           && f.STFieldDataMember == r.PropertyName
                                                                                           && f.STFieldTag == BOSScreen.DataControl);
                        if (objSTFieldsInfo != null)
                        {
                            if (!String.IsNullOrEmpty(objSTFieldsInfo.STFieldError))
                                strErrorMessage = objSTFieldsInfo.STFieldError;
                            tblError.Rows.Add(new object[] { objSTFieldsInfo.STFieldName, strErrorMessage, -1, String.Empty });
                        }

                    }
                }
            }

            return tblError;
        }

        protected virtual bool IsInvalidInput()
        {
            ErrorTable = InitErrorTable();

            CheckExtraInput();


            if (CurrentModuleEntity.MainObject != null)
            {
                ErrorTable.Rows.Clear();
                string dataSource = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
                foreach (BusinessRule r in CurrentModuleEntity.MainObject.BusinessRuleCollections)
                {
                    bool isRuleBroken = !r.ValidateRule(CurrentModuleEntity.MainObject);
                    if (isRuleBroken)
                    {
                        AddErrorToErrorScreen(r.Description, dataSource, r.PropertyName);
                    }
                }

                //Check from required property of main object
                PropertyInfo[] props = CurrentModuleEntity.MainObject.GetType().GetProperties();
                foreach (PropertyInfo prop in props)
                {
                    //Find property binding to this column then get its required attribute
                    RequiredAttribute requiredAttr = null;
                    object[] attrs = prop.GetCustomAttributes(typeof(RequiredAttribute), true);
                    if (attrs.Length > 0)
                    {
                        requiredAttr = (RequiredAttribute)attrs[0];
                    }
                    if (requiredAttr != null)
                    {
                        if (!CurrentModuleEntity.IsValidNonForeignKeyPropety(prop.Name))
                        {
                            AddErrorToErrorScreen(requiredAttr.ErrorMessage, dataSource, prop.Name);
                        }
                    }
                }
            }

            if (ErrorTable.Rows.Count > 0)
            {
                ErrorMessageScreen = new guiErrorMessage(ErrorTable) { Module = this };
                ErrorMessageScreen.ShowDialog();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Add an error to error screen
        /// </summary>
        /// <param name="errorMessage">Error message is displayed to user</param>
        /// <param name="dataSource">Data source the error occurs at</param>
        /// <param name="dataMember">Data member the error occurs at</param>
        private void AddErrorToErrorScreen(string errorMessage, string dataSource, string dataMember)
        {
            STFieldsInfo objFieldsInfo = null;
            foreach (BOSERPScreen screen in Screens)
            {
                objFieldsInfo = (STFieldsInfo)screen.Fields.Values.Where(f => f.STFieldDataSource == dataSource && f.STFieldDataMember == dataMember && f.STFieldTag == BOSScreen.DataControl).FirstOrDefault();
                if (objFieldsInfo != null)
                {
                    break;
                }
            }
            if (objFieldsInfo != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                if (Controls.Contains(objFieldsInfo.STFieldName))
                {
                    String strCustomErrorMessage = dbUtil.GetPropertyStringValue(Controls[objFieldsInfo.STFieldName], "BOSError");
                    if (!String.IsNullOrEmpty(strCustomErrorMessage))
                    {
                        errorMessage = strCustomErrorMessage;
                    }
                }
                ErrorTable.Rows.Add(new object[] { objFieldsInfo.STFieldName, errorMessage, -1, String.Empty });
            }
        }

        protected virtual void CheckExtraInput()
        {

        }

        protected virtual bool IsInvalidInventory()
        {
            return CurrentModuleEntity.IsInvalidInventory();
        }

        protected void MoveNextErrorControl(Control ctrl)
        {
            String strControlName = ctrl.Name;
            if (ErrorTable.Rows.Count > 0)
            {
                DataRow row = ErrorTable.Rows.Find(new object[] { strControlName, -1, String.Empty });
                if (row != null)
                {

                    int iErrorIndex = ErrorTable.Rows.IndexOf(row);
                    if (iErrorIndex < ErrorTable.Rows.Count - 1)
                    {
                        String strNextErrorControl = ErrorTable.Rows[iErrorIndex + 1][0].ToString();
                        Controls[strNextErrorControl].Focus();
                    }
                    else
                    {
                        String strNextErrorControl = ErrorTable.Rows[0][0].ToString();
                        Controls[strNextErrorControl].Focus();
                    }
                }
            }
        }

        /// <summary>
        /// Function will be called when user create new object in module
        /// </summary>
        public virtual void ActionNew()
        {
            Cursor.Current = Cursors.WaitCursor;

            //Call new delegate from Toolbar
            Toolbar.New();

            //Invalidate toolbar in the module's context
            InvalidateToolbar();

            //Invalidate toolbar after new object
            ParentScreen.InvalidateToolbarAfterActionNew();

            ResetFocus();

            //Save User Audit New action
            SaveUserAudit(cstUserAuditNew);

            //Invalidate controls
            InvalidateFieldGroupControls(BaseToolbar.ModusNew);
            if (ParentScreen.IsObjectListExpanded)
            {
                ParentScreen.CollapseObjectList();
            }

            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);

            Cursor.Current = Cursors.Default;
            SetToolbarActionNameToMainObject();
            ToolbarNewActionName = ToolbarActionName;
        }

        private void SetToolbarActionNameToMainObject()
        {
            if (CurrentModuleEntity.MainObject != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                try
                {
                    string value = (string)dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, "STToolbarActionName");
                    if (ToolbarNewActionName != null && ToolbarNewActionName != string.Empty )
                        dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "STToolbarActionName", ToolbarNewActionName);
                    else
                        dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "STToolbarActionName", ToolbarActionName);
                }
                catch
                { 
                }
            }
        }

        public bool CheckLock()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string MainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            string MainTablePrefix = MainTableName.Substring(0, MainTableName.Length - 1);
            object value = dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, MainTablePrefix + "Date");
            if (value != null)
            {
                STModulePostingsInfo postExit = (new STModulePostingsController()).GetObjectByModuleName(CurrentModuleEntity.Module.Name);
                if (postExit == null || string.IsNullOrEmpty(postExit.STModulePostingStockFunction))
                    return true;

                DateTime transactionDate = Convert.ToDateTime(value);
                ADLocksController objLocksController = new ADLocksController();
                ADLocksInfo lockInfo = objLocksController.GetActiveLockByDate(transactionDate);
                if (lockInfo != null)
                {
                    MessageBox.Show("Ngày chứng từ không hợp lệ, đã khoá dữ liệu đến ngày: " + lockInfo.ADLockToDate.ToShortDateString(),
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    return false;
                }

                TimeSpan interval = transactionDate.Date - BOSApp.GetCurrentServerDate().AddDays(BOSApp.CurrentCompanyInfo.CSCompanyExceededDay).Date;


                if (interval.Days > 0)
                {
                    MessageBox.Show("Ngày chứng từ vượt quá thời gian cho phép!",
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Function will be called when user save the edited object in module
        /// </summary>      
        public virtual int ActionSave()
        {
            int iObjectID = 0;
            if (!Toolbar.IsNullOrNoneAction())
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!IsInvalidInput() && CheckLock())
                {
                    //Call Save delegate of Toolbar

                    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                    {
                        try
                        {
                            iObjectID = Toolbar.Save();
                            if (iObjectID > 0)
                            {
                                scope.Complete();
                                CurrentModuleEntity.MainObject.OldObject = (BusinessObject)CurrentModuleEntity.MainObject.Clone();
                            }
                        }
                        catch (Exception ex)
                        {
                            scope.Dispose();
                            MessageBox.Show(ex.Message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (iObjectID > 0)
                    {
                        ModuleAfterSaved(iObjectID);
                        CurrentModuleEntity.UpdateLookupTableDataSource();
                        //If module's owner exists, activate it
                        if (Owner != null)
                        {
                            ModuleParentScreen ownerParentScreen = Owner.ParentScreen;
                            Owner = null;
                            ownerParentScreen.Activate();
                        }
                    }
                }

                Cursor.Current = Cursors.Default;
            }
            return iObjectID;
        }

        /// <summary>
        /// Complete transaction and update inventory
        /// </summary>
        public virtual bool ActionComplete()
        {
            bool isComplete = false;
            if (ObjectIsEditingByOtherUser(this.Name, Toolbar.CurrentObjectID))
            {
                return false;
            }
            if (!HasCompletePermission())
            {
                MessageBox.Show("Bạn không đủ quyền hạn để duyệt chứng từ này. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!CheckLock())
            {
                return false;
            }
            if (!IsInvalidInventory())
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    try
                    {
                        CurrentModuleEntity.SetPropertyChangeEventLock(false);
                        isComplete = CurrentModuleEntity.CompleteTransaction();
                        scope.Complete();
                    }
                    catch (Exception e)
                    {
                        scope.Dispose();
                        MessageBox.Show(e.Message,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    finally
                    {
                        CurrentModuleEntity.SetPropertyChangeEventLock(true);
                    }
                }
            }

            if (isComplete)
            {
                ModuleAfterCompleted();
            }
            return isComplete;
        }

        protected virtual bool HasCompletePermission()
        {
            return true;
        }

        /// <summary>
        /// Called when the transaction module has been completed,
        /// give a chance to add corresponding behaviours
        /// </summary>
        public virtual void ModuleAfterCompleted()
        {
            CurrentModuleEntity.AfterCompleteTransaction();

            ParentScreen.InvalidateToolbarAfterActionComplete();

            //Invalidate toolbar in the module's context
            InvalidateToolbar();
        }

        /// <summary>
        /// Transfer the current object and relative data to a branch
        /// </summary>
        /// <param name="defaultBranchConfigKey">Key is used to get default branch id from config values</param>
        public virtual void ActionTransfer(string defaultBranchConfigKey)
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByConfigKey(defaultBranchConfigKey);
                int defaultBranchID = 0;
                if (objConfigValuesInfo != null)
                {
                    defaultBranchID = Convert.ToInt32(objConfigValuesInfo.ADConfigKeyValue);
                }

                guiChooseBranch guiChooseBranch = new guiChooseBranch(defaultBranchID);
                guiChooseBranch.Module = this;
                if (guiChooseBranch.ShowDialog() == DialogResult.OK)
                {
                    BOSProgressBar.Start(string.Format(BaseLocalizedResources.TransferringDataToBranchMessage, guiChooseBranch.SelectedBranch.BRBranchName));
                    CurrentModuleEntity.SetPropertyChangeEventLock(false);
                    bool isCompleted = TransferData(guiChooseBranch.SelectedBranch);
                    CurrentModuleEntity.SetPropertyChangeEventLock(true);
                    BOSProgressBar.Close();

                    if (!guiChooseBranch.IsDefaultBranch)
                    {
                        objConfigValuesInfo.ADConfigKeyValue = Convert.ToString(0);
                        objConfigValuesController.UpdateObject(objConfigValuesInfo);
                    }
                    else
                    {
                        objConfigValuesInfo.ADConfigKeyValue = Convert.ToString(guiChooseBranch.SelectedBranch.BRBranchID);
                        objConfigValuesController.UpdateObject(objConfigValuesInfo);
                    }

                    if (isCompleted)
                    {
                        ParentScreen.InvalidateToolbarAfterActionTransfer();

                        //Invalidate toolbar in the module's context
                        InvalidateToolbar();
                    }
                }
            }
        }

        /// <summary>
        /// Transfer the current object and relative data to a branch
        /// </summary>
        /// <param name="objBranchsInfo">Target branch</param>
        protected virtual bool TransferData(BRBranchsInfo objBranchsInfo)
        {
            return true;
        }

        /// <summary>
        /// Called when the module has been saved, give a chance 
        /// to add corresponding behaviours
        /// </summary>
        /// <param name="iObjectID">Main object id</param>
        public virtual void ModuleAfterSaved(int iObjectID)
        {
            CurrentModuleEntity.AfterSaveTransaction();

            ParentScreen.Focus();

            //Invalidate Toolbar button after save
            ParentScreen.InvalidateToolbarAfterActionSave();

            //Invalidate controls
            InvalidateFieldGroupControls(BaseToolbar.ModusNone);

            //Invalidate search result control
            InvalidateSearchResultsControl(null, string.Empty);

            //Save User Audit is Nothing
            SaveUserAudit(cstUserAuditNothing);

            //Set modus action of toolbar to none
            Toolbar.ModusAction = BaseToolbar.ModusNone;

            //Invalidate toolbar in the module's context
            InvalidateToolbar();
        }

        public virtual void ActionDuplicate()
        {
            if (Toolbar.ObjectCollection != null)
            {
                if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    BOSDbUtil dbUtil = new BOSDbUtil();

                    Toolbar.ModusAction = BaseToolbar.ModusNew;

                    //Set number of main object to ERPModuleEntities.cstNewObjectText
                    String strPrimaryColumn = GetTablePrimaryColumn(BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject));
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, strPrimaryColumn, 0);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, strPrimaryColumn.Substring(0, strPrimaryColumn.Length - 2) + "No", ERPModuleEntities.cstNewObjectText);

                    CurrentModuleEntity.DuplicateModuleObjectList();

                    //Invalidate toolbar after new object
                    ParentScreen.InvalidateToolbarAfterActionDuplicate();

                    //Activate Data Main Screen
                    ActivateDataMainScreen();

                    //Invalidate controls
                    InvalidateFieldGroupControls(BaseToolbar.ModusNew);

                    //Save User Audit New action
                    SaveUserAudit(cstUserAuditNew);

                    Cursor.Current = Cursors.Default;
                }
            }

        }

        /// <summary>
        /// Function will be called when user edit object in module
        /// </summary>
        public virtual void ActionEdit()
        {
            if (ObjectIsEditingByOtherUser(this.Name, Toolbar.CurrentObjectID))
            {
                return;
            }

            //Call Edit delegate from Toolbar
            if (Toolbar.Edit())
            {
                //Invalidate toolbar after edit action
                ParentScreen.InvalidateToolbarAfterActionEdit();

                //Activate Main Screen
                if (ActiveScreen.IsSearchMainScreen())
                {
                    BOSERPScreen _guiDataMain = (BOSERPScreen)GetDataMainScreen(null, String.Empty);
                    ActiveScreen = _guiDataMain;
                }

                //Invalidate controls
                InvalidateFieldGroupControls(BaseToolbar.ModusEdit);
                if (ParentScreen.IsObjectListExpanded)
                {
                    ParentScreen.CollapseObjectList();
                }

                //Save User Audit
                SaveUserAudit(cstUserAuditEdit);
            }
            else
            {
                DevExpress.XtraBars.BarButtonItem barbtnEdit = (BarButtonItem)ParentScreen.GetToolbarButton(BaseToolbar.ToolbarButtonEdit);
                barbtnEdit.Down = false;
            }
        }

        public void ActionEdit(String moduleName, int objectID)
        {
            BaseModuleERP module = BOSApp.ShowModule(moduleName);
            String tableName = BOSUtil.GetTableNameFromBusinessObject(module.CurrentModuleEntity.MainObject);
            String primaryKey = BOSApp.GetTablePrimaryColumn(tableName);
            if (module != null)
            {
                for (int i = 0; i < module.Toolbar.ObjectCollection.Tables[0].Rows.Count; i++)
                    if (objectID == Convert.ToInt32(module.Toolbar.ObjectCollection.Tables[0].Rows[i][primaryKey]))
                    {
                        module.Owner = this;
                        module.Toolbar.CurrentIndex = i;
                        module.FocusRowOfGridSearchResultByToolbarCurrentIndex();
                        module.ActionEdit();
                        return;
                    }
            }
        }

        /// <summary>
        /// Focus pointer to the first control of data main screen
        /// </summary>
        public virtual void ResetFocus()
        {
            foreach (XtraTabPage page in ParentScreen.ScreenContainer.TabPages)
            {
                if (page.Name.Contains("DM"))
                {
                    int minIndex = Int32.MaxValue;
                    ResetFocus(page.Controls, 0, ref minIndex);
                    return;
                    //String tableName = BOSUtil.GetTableNameFromBusinessObject(this.CurrentModuleEntity.MainObject);
                    //if (!string.IsNullOrEmpty(tableName))
                    //{
                    //    String primaryKey = BOSApp.GetTablePrimaryColumn(tableName);
                    //    string mainNo = tableName.Substring(0, tableName.Length - 2) + "No"; 
                    //    BOSTextBox mainNoControl = (BOSTextBox)Controls["fld_txt" +mainNo];
                    //    if (mainNoControl != null) mainNoControl.Focus();
                    //}
                }
            }
            
        }

        /// <summary>
        /// Focus pointer to the first control of data main screen
        /// </summary>
        /// <param name="controls">Control collection</param>
        /// <returns>True if find out a focusable control, otherwise false</returns>
        private bool ResetFocus(Control.ControlCollection controls, int parentIndex, ref int minIndex)
        {
            bool focusable = false;
            foreach (Control ctrl in controls)
            {
                if (ctrl is BaseEdit && ctrl.TabIndex > 0 && !ctrl.Name.Contains("No") && ctrl.Enabled)
                {
                    if (parentIndex * 10 + ctrl.TabIndex < minIndex)
                    {
                        ctrl.Focus();
                        minIndex = parentIndex * 10 + ctrl.TabIndex;
                        focusable = true;
                    }
                }

                if (ctrl.Controls.Count > 0)
                {
                    focusable = ResetFocus(ctrl.Controls, parentIndex * 10 + ctrl.TabIndex, ref minIndex);
                }
            }

            return focusable;
        }

        /// <summary>
        /// Function will be called when user delete object in module
        /// </summary>
        public virtual void ActionDelete()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                if (!CheckLock())
                {
                    SaveUserAudit(cstUserAuditNothing);
                    return;
                }
                Toolbar.Delete();
                ParentScreen.InvalidateToolbarAfterActionDelete();
                //Invalidate the toolbar in the module's context
                InvalidateToolbar();
                BOSApp.MainScreen.OpenModulesToolStrip.Enabled = true;

                //Invalidate controls
                InvalidateFieldGroupControls(BaseToolbar.ModusNone);
            }

            //Save User Audit is Nothing
            SaveUserAudit(cstUserAuditNothing);
        }

        public virtual void ActionEditTemplate()
        {

            String strMainTable = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            IBusinessController objBusinessController = BusinessControllerFactory.GetBusinessController(strMainTable + "Controller");
            CurrentModuleEntity.MainObject = (BusinessObject)objBusinessController.GetTemplateObject();
            if (CurrentModuleEntity.MainObject != null)
            {
                CurrentModuleEntity.UpdateMainObjectBindingSource();

                ParentScreen.InvalidateToolbarAfterActionEditTemplate();

                Toolbar.ModusAction = BaseToolbar.ModusEdit;
                ActivateDataMainScreen();
            }
            else
            {
                CurrentModuleEntity.MainObject = BusinessObjectFactory.GetBusinessObject(strMainTable + "Info");
                if (CurrentModuleEntity.MainObject != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();

                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, ERPModuleEntities.AAStatusColumn, BusinessObject.TemplateAAStatus);

                    String strColumnNoName = strMainTable.Substring(0, strMainTable.Length - 1) + "No";
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, strColumnNoName, ERPModuleEntities.cstTemplateObjectText);
                    CurrentModuleEntity.UpdateMainObjectBindingSource();

                    ParentScreen.InvalidateToolbarAfterActionEditTemplate();

                    Toolbar.ModusAction = BaseToolbar.ModusNew;
                    ActivateDataMainScreen();
                }
            }

        }

        /// <summary>
        /// Function will be called when user cancel edit object in module
        /// </summary>
        public virtual void ActionCancel()
        {
            // cal Cancel delegate from toolbar
            Toolbar.Cancel();

            //Invalidate toolbar after Cancel 
            ParentScreen.InvalidateToolbarAfterActionCancel();

            //Invalidate toolbar in the module's context
            InvalidateToolbar();

            //Save User Audit is Nothing
            SaveUserAudit(cstUserAuditNothing);

            //Invalidate controls
            InvalidateFieldGroupControls(BaseToolbar.ModusNone);

            //If module's owner exists, activate it
            if (Owner != null)
            {
                ModuleParentScreen ownerParentScreen = Owner.ParentScreen;
                Owner = null;
                ownerParentScreen.Activate();
            }
        }

        /// <summary>
        /// Function will be called when invalidate module
        /// </summary>
        public virtual void ActionInvalidate()
        {
            Toolbar.Invalidate();
        }

        /// <summary>
        /// Invalidate module by a given object
        /// </summary>
        /// <param name="objectID">Object id</param>
        public virtual void ActionInvalidate(int objectID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string tableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            string primaryKey = BOSApp.GetTablePrimaryColumn(tableName);
            if (Toolbar.ObjectCollection != null)
            {
                for (int i = 0; i < Toolbar.ObjectCollection.Tables[0].Rows.Count; i++)
                {
                    if (objectID == Convert.ToInt32(Toolbar.ObjectCollection.Tables[0].Rows[i][primaryKey]))
                    {
                        Toolbar.CurrentIndex = i;
                        FocusRowOfGridSearchResultByToolbarCurrentIndex();
                        return;
                    }
                }
            }

            //If can't find the object in toolbar's collection
            IBusinessController controller = BusinessControllerFactory.GetBusinessController(tableName + "Controller");
            if (controller != null)
            {
                DataSet ds = controller.GetDataSetByID(objectID);
                Toolbar.SetToolbar(ds);
                BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                InvalidateAfterSearch(null, String.Empty, objectID);
            }
        }

        /// <summary>
        /// Function will be call when user go to previous object 
        /// </summary>
        public virtual void ActionGoPrevious()
        {
            //Toolbar.Previous();
            if (Toolbar.IsNullOrNoneAction())
            {
                if (Toolbar.ObjectCollectionLength > 0)
                {
                    if (Toolbar.CurrentIndex > 0)
                        Toolbar.CurrentIndex--;
                    Toolbar.Invalidate();
                }
            }
            else
                if (Toolbar.ModusAction != BaseToolbar.ModusNone)
            {
                DialogResult dlgResult;
                if (Toolbar.ModusAction == BaseToolbar.ModusNew)
                    dlgResult = MessageBox.Show("Do you want to save the new record?", "Save Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                else
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
                    String strObjectNoColumnName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "No";
                    String strObjectNo = dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, strObjectNoColumnName).ToString();

                    dlgResult = MessageBox.Show("Do you want to save the current record?", "Save Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                if (dlgResult == DialogResult.Yes || dlgResult == DialogResult.No)
                {
                    if (dlgResult == DialogResult.Yes)
                        ActionSave();
                    else
                        ActionCancel();
                    if (Toolbar.ModusAction == BaseToolbar.ModusNone)
                    {
                        if (Toolbar.ObjectCollectionLength > 0)
                        {
                            if (Toolbar.CurrentIndex > 0)
                                Toolbar.CurrentIndex--;
                            Toolbar.Invalidate();
                        }
                    }
                }
            }

            if (Toolbar.ModusAction == BaseToolbar.ModusNone)
                FocusRowOfGridSearchResultByToolbarCurrentIndex();
        }

        public virtual void ActionGoFirst()
        {
            Toolbar.First();
            if (Toolbar.IsNullOrNoneAction())
            {
                FocusRowOfGridSearchResultByToolbarCurrentIndex();
            }

        }

        /// <summary>
        /// Function will be call when user go to next object
        /// </summary>
        public virtual void ActionGoNext()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                if (Toolbar.ObjectCollectionLength > 0)
                {
                    if (Toolbar.CurrentIndex < Toolbar.ObjectCollectionLength - 1)
                        Toolbar.CurrentIndex++;
                    Toolbar.Invalidate();
                }
            }
            else
                if (Toolbar.ModusAction != BaseToolbar.ModusNone)
            {
                DialogResult dlgResult;
                if (Toolbar.ModusAction == BaseToolbar.ModusNew)
                    dlgResult = MessageBox.Show("Do you want to save the new record?", "Save Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                else
                    dlgResult = MessageBox.Show("Do you want to save the current record?", "Save Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes || dlgResult == DialogResult.No)
                {
                    if (dlgResult == DialogResult.Yes)
                        ActionSave();
                    else
                        ActionCancel();
                    if (Toolbar.ModusAction == BaseToolbar.ModusNone)
                    {
                        if (Toolbar.ObjectCollectionLength > 0)
                            if (Toolbar.CurrentIndex < Toolbar.ObjectCollectionLength - 1)
                                Toolbar.CurrentIndex++;
                        Toolbar.Invalidate();
                    }
                }
            }

            if (Toolbar.ModusAction == BaseToolbar.ModusNone)
                FocusRowOfGridSearchResultByToolbarCurrentIndex();
        }

        /// <summary>
        /// Function will be call when user Print.
        /// </summary>
        public virtual void ActionPrint()
        {

        }

        public virtual void ActionExport()
        {
            guiExcelExport _guiExceExport = new guiExcelExport();
            _guiExceExport.Module = this;
            _guiExceExport.ShowDialog();
        }

        public virtual void ActionImport()
        {
            guiExcelImport _guiExcelImport = new guiExcelImport();
            _guiExcelImport.Module = this;
            _guiExcelImport.ShowDialog();
        }


        public virtual void ActionShowError()
        {
            if (ErrorTable.Rows.Count > 0)
            {
                if (ErrorMessageScreen == null)
                {
                    ErrorMessageScreen = new guiErrorMessage(ErrorTable);
                    ErrorMessageScreen.Module = this;
                    ErrorMessageScreen.Show();
                }
                else if (ErrorMessageScreen.IsDisposed)
                {
                    ErrorMessageScreen = new guiErrorMessage(ErrorTable);
                    ErrorMessageScreen.Module = this;
                    ErrorMessageScreen.Show();
                }
                else
                    ErrorMessageScreen.Activate();
            }
        }

        /// <summary>
        /// Function will be call when user click User Audit
        /// </summary>
        public virtual void ActionUserAudit()
        {
            guiUserAudit _guiUserAudit = new guiUserAudit();
            _guiUserAudit.Show();
        }
        #endregion

        #region "Delegate Functions for Toolbar Events"
        /// <summary type="Toolbar">
        /// Initialize the delegate functions and events for toolbar buttons
        /// </summary>
        /// <functiontype>Toolbar Function</functiontype>
        public void InitModuleToolbarEvents()
        {
            Toolbar = new BaseToolbar();
            BaseToolbar.InvalidateHandler InvalidateHandler = new BaseToolbar.InvalidateHandler(Invalidate);
            BaseToolbar.NewHandler NewHandler = new BaseToolbar.NewHandler(New);
            BaseToolbar.SaveHandler SaveHandler = new BaseToolbar.SaveHandler(Save);
            BaseToolbar.DeleteHandler DeleteHandler = new BaseToolbar.DeleteHandler(Delete);
            BaseToolbar.PrintHandler PrintHandler = new BaseToolbar.PrintHandler(Print);

            Toolbar.InvalidateEvent += InvalidateHandler;
            Toolbar.NewEvent += NewHandler;
            Toolbar.SaveEvent += SaveHandler;
            Toolbar.DeleteEvent += DeleteHandler;
            Toolbar.PrintEvent += PrintHandler;
        }

        #region Function For Invalidate action
        /// <summary type="Invalidate">
        /// Invalidate module
        /// </summary>
        /// <param name="iObjectID">Current Object ID</param>        
        public virtual void Invalidate(int iObjectID)
        {
            Type typMainObjectType = CurrentModuleEntity.MainObject.GetType();
            BaseBusinessController objMainObjectController = new BaseBusinessController(typMainObjectType);
            BusinessObject mainObject = (BusinessObject)objMainObjectController.GetObjectByID(iObjectID);
            if (mainObject != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                int CurrencyID = dbUtil.GetPropertyIntValue(mainObject, "FK_GECurrencyID");
                
                CurrentModuleEntity.Invalidate(iObjectID);
                if (CurrencyID > 0)
                    ReInitializeFieldFormat(CurrencyID);
                CurrentModuleEntity.MainObject.OldObject = (BusinessObject)CurrentModuleEntity.MainObject.Clone();

                //ParentScreen.Text = ParentScreen.GetParentScreenTextByLanguage(BOSApp.CurrentLang) + " - " + MessageInfo.ShowInfoForCurrentObject(this.Name, BOSApp.CurrentLang, strAANumberString);

                if (CurrentModuleEntity.MainObject != null)
                {
                    String tablename = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
                    string number = dbUtil.GetPropertyStringValue(CurrentModuleEntity.MainObject, tablename.Substring(0, tablename.Length - 1) + "No");
                    BOSApp.MainScreen.nameItem.Caption = number;
                }

                InvalidateToolbar();
            }
        }
        public override void ReInitializeFieldFormat(int CurrencyID)
        {
            foreach (XtraTabPage page in _parentScreen.ScreenContainer.TabPages)
            {
                ReInitControlFieldFormat(page.Controls, CurrencyID);
            }
        }
        public void ReInitControlFieldFormat(Control.ControlCollection controls, int CurrencyID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string FormatString = BOSApp.GetStringFormatByCurrencyID(CurrencyID,true);
            string MarkString = BOSApp.GetStringFormatByCurrencyID(CurrencyID,false);
            foreach (Control ctrl in controls)
            {
                
                if (ctrl.Tag == null || ctrl.Tag.Equals(BOSScreen.DataControl))
                {
                    var dgc = ctrl as BOSGridControl;
                    var txt = ctrl as BOSTextBox;
                    if (txt != null && txt.Visible)
                    {
                        TextEdit txtE = (TextEdit)ctrl;
                        String tableName = dbUtil.GetPropertyStringValue(ctrl, BOSScreen.cstDataSourcePropertyName);
                        String columnName = dbUtil.GetPropertyStringValue(ctrl, BOSScreen.cstDataMemberPropertyName);
                        STFieldFormatGroupsInfo objFieldFormatGroupsInfo = GetColumnFormat(tableName, columnName, this.ModuleID);
                        if (objFieldFormatGroupsInfo != null  && (objFieldFormatGroupsInfo.STFieldFormatGroupFormatType == "Numeric" || objFieldFormatGroupsInfo.STFieldFormatGroupMaskType == "Numeric") && objFieldFormatGroupsInfo.STChangeByCurrency)
                        {
                            txtE.Properties.MaskSettings.Configure<MaskSettings.Numeric>(settings => {
                                settings.MaskExpression = MarkString;
                                settings.AutoHideDecimalSeparator = false;
                                
                            });
                            txt.Properties.DisplayFormat.FormatString = FormatString;

                        }
                    }
                    else if (dgc != null && dgc.Visible)
                    {
                        dgc.ReInitFormat(FormatString, MarkString);
                    }
                }
                if (ctrl.Controls.Count > 0)
                {
                    ReInitControlFieldFormat(ctrl.Controls, CurrencyID);
                }
            }

        }
        /// <summary>
        /// Invalidate toolbar corresponding to the context of a specific module        
        /// </summary>
        public virtual void InvalidateToolbar()
        {
        }
        #endregion

        #region Functions for New Action

        /// <summary type="New">
        /// New object in module
        /// </summary>
        public virtual void New()
        {
            CurrentModuleEntity.New();

            BOSERPScreen _guiDataMainScreen = GetDataMainScreen(null, String.Empty);
            if (_guiDataMainScreen != null)
            {
                ActiveScreen = _guiDataMainScreen;
            }
        }
        #endregion

        #region Function For Save Action

        public virtual int Save()
        {
            int iObjectID = 0;
            bool isContinue = true;

            BOSDbUtil dbUtil = new BOSDbUtil();
            String strMainTable = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            String strMainTablePrimaryColumn = strMainTable.Substring(0, strMainTable.Length - 1) + "ID";
            String strMainTableNoColumn = strMainTablePrimaryColumn.Substring(0, strMainTablePrimaryColumn.Length - 2) + "No";
            String strObjectNo = dbUtil.GetPropertyStringValue(CurrentModuleEntity.MainObject, strMainTableNoColumn);
            if (Toolbar.IsNewAction())
            {
                SetToolbarActionNameToMainObject();
            }
            isContinue = IsValidObjectNo(strObjectNo);
            if (isContinue)
            {
                iObjectID = CurrentModuleEntity.SaveMainObject();

                if (iObjectID > 0)
                {
                    //Save Module Objects
                    CurrentModuleEntity.SaveModuleObjects();

                    //Save Object History
                    if (Toolbar.ModusAction == BaseToolbar.ModusNew)
                        SaveObjectHistory(cstObjectHistoryActionNew, iObjectID);
                    else
                        SaveObjectHistory(cstObjectHistoryActionChange, iObjectID);
                }
                return iObjectID;
            }
            else
                return 0;
        }

        /// <summary>
        /// Check whether the inputed object no is valid
        /// </summary>
        /// <param name="objectNo">Object no</param>
        protected virtual bool IsValidObjectNo(string objectNo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            IBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(CurrentModuleEntity.MainObject.GetType().Name.Substring(0, CurrentModuleEntity.MainObject.GetType().Name.Length - 4) + "Controller");
            String mainTable = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            String mainTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(mainTable);
            bool isValid = true;
            if (!String.IsNullOrEmpty(objectNo))
            {
                if (this.Toolbar.ModusAction == BaseToolbar.ModusNew)
                {
                    if (objCurrentObjectController.IsExist(objectNo))
                    {
                        MessageBox.Show(BaseLocalizedResources.NumberAlreadyExistsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                    }
                }
                else if (this.Toolbar.ModusAction == BaseToolbar.ModusEdit)
                {
                    BusinessObject objMainObject = (BusinessObject)objCurrentObjectController.GetObjectByNo(objectNo);
                    if (objMainObject != null)
                    {
                        int iMainObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(objMainObject, mainTablePrimaryColumn));
                        if (iMainObjectID != Toolbar.CurrentObjectID)
                        {
                            MessageBox.Show(BaseLocalizedResources.NumberAlreadyExistsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isValid = false;
                        }
                    }
                }
            }
            return isValid;
        }
        #endregion

        #region Function for Delete action
        /// <summary type="Delete">
        /// Delete object in module
        /// </summary>
        /// <param name="iObjectID">Object ID will be deleted</param>
        /// <returns>true if delete successfull, otherwise return false</returns>
        public virtual bool Delete(int iObjectID)
        {
            bool result = false;

            if (MessageBox.Show(BaseLocalizedResources.ConfirmDeleteObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                //Save Object History with action delete 
                SaveObjectHistory(cstObjectHistoryActionDelete, Toolbar.CurrentObjectID);

                //Delete object from CurrentModuleEntity
                CurrentModuleEntity.Delete(iObjectID);

                Search();
                result = true;
            }
            return result;
        }
        #endregion

        /// <summary type="Print">
        /// Print Module
        /// </summary>
        public virtual void Print()
        {

        }
        public virtual bool RefreshData()
        {
            BOSApp.RefreshChangeLookupData();

            foreach (XtraTabPage page in _parentScreen.ScreenContainer.TabPages)
            {
                BindingDataSource(page.Controls);
            }
            return true;
        }
        public void RefreshControlData()
        {
            RefreshData();
        }
        public void BindingDataSource(Control.ControlCollection controls)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (Control ctrl in controls)
            {
                String tableName = dbUtil.GetPropertyStringValue(ctrl, BOSScreen.cstDataSourcePropertyName);
                String columnName = dbUtil.GetPropertyStringValue(ctrl, BOSScreen.cstDataMemberPropertyName);
                if (!String.IsNullOrEmpty(tableName))
                {
                    if (ctrl.Tag == null || ctrl.Tag.Equals(BOSScreen.DataControl))
                    {
                        var lke = ctrl as BOSLookupEdit;
                        var dgc = ctrl as BOSGridControl;
                        string name = string.Empty;
                        if (lke != null)
                        {
                            lke.RefreshBindingDataSource();
                        }
                        else if (dgc != null)
                        {
                            dgc.RefreshBindingDataLookupEdit();
                        }
                    }
                }
                if (ctrl.Controls.Count > 0)
                {
                    BindingDataSource(ctrl.Controls);
                }
            }
        }
        #endregion
        #endregion

        #region Module Functions
        #region Virtual Functions

        #region Init Screen functions
        private static int NummerComparer(STScreensInfo i1, STScreensInfo i2)
        {
            return String.Compare(i1.STScreenNumber, i2.STScreenNumber) * -1;
        }
        /// <summary type="Initialize">
        /// Initialize all screens belong to module
        /// </summary>        
        public virtual void InitializeScreens()
        {
            var screenIDLock = BOSApp.LstScreen.Where(s => s.STModuleName == this.Name && s.FK_ADUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID && s.STScreenPermissionType == 1).Select(x => x.STScreenID).Distinct().ToList();

            var screenID = BOSApp.LstScreen.Where(s => s.STModuleName == this.Name
                                                        && s.STScreenVisible == true
                                                        && (s.FK_ADUserGroupID == 0 || s.FK_ADUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID || s.STUserGroupID == 1) &&
                                                        !screenIDLock.Contains(s.STScreenID))
                                            .Select(x => x.STScreenID).Distinct().ToList();
            foreach (int t in screenID)
            {
                STScreensInfo obj = BOSApp.LstScreen.FirstOrDefault(x => x.STScreenID == t);
                if (obj != null)
                {
                    obj.STScreenPermissionType = 0;
                    if (obj.STScreenVisible)
                    {
                        if (!obj.STScreenNumber.StartsWith("DS"))
                        {
                            InitializeNewScreen(obj);
                        }
                    }
                }
            }
            SaveUserAudit(cstUserAuditNothing);
        }


        //[NUThao] [Improve Speed] [2014-09-09]
        /// <summary>
        /// Initialize a new screen for the module
        /// </summary>
        /// <param name="screen"></param>
        private void InitializeNewScreen(STScreensInfo screen)
        {
            BOSERPScreen scr = BOSERPScreenFactory.GetScreen(screen.STScreenNumber, this.Name);
            scr.ScreenInfo = screen;
            scr.ScreenID = screen.STScreenID;
            scr.Name = screen.STScreenName;
            scr.Module = this;
            scr.Text = screen.STScreenText;
            //Initialize and customize all screens
            scr.InitializeScreen(screen);

            Screens.Add(scr);

            //Add controls of all screens to parent screen
            InitializeScreenControls(scr);
        }

        /// <summary>
        /// Add controls of all screens to parent screen
        /// </summary>
        /// <param name="screen"></param>
        private void InitializeScreenControls(BOSERPScreen screen)
        {
            if (screen.ScreenInfo.STScreenPermissionType == Convert.ToByte(FieldPermissionType.None))
            {
                screen.AddControlsToParentScreen();
            }
        }
        //[NUThao] [Improve Speed] [2014-09-09]

        /// <summary type="Initialize">
        /// Initialize Screen by Screen Name and Screen Number
        /// </summary>        
        /// <param name="objSTScreensInfo"></param>        
        /// <returns></returns>        
        public BOSScreen InitializeScreen(STScreensInfo objSTScreensInfo)
        {
            BOSERPScreen scr = BOSERPScreenFactory.GetScreen(objSTScreensInfo.STScreenNumber, this.Name);
            scr.Name = objSTScreensInfo.STScreenName;
            scr.Module = this;
            scr.Text = objSTScreensInfo.STScreenText;
            scr.InitializeScreen(objSTScreensInfo);
            return scr;
        }

        public BOSScreen InitializeScreen(String strScreenName, String strScreenNumber)
        {
            BOSERPScreen scr = BOSERPScreenFactory.GetScreen(strScreenNumber, this.Name);
            scr.Name = strScreenName;
            scr.Module = this;

            scr.InitializeScreen();
            return scr;
        }

        public BOSScreen InitializeScreen(String strScreenNumber)
        {
            if (ModuleID > 0 && BOSApp.CurrentUserGroupInfo.ADUserGroupID > 0)
            {
                STScreensController objSTScreensController = new STScreensController();
                STScreensInfo objSTScreensInfo = objSTScreensController.GetSTScreensByModuleIDAndUserGroupIDAndScreenNumber(ModuleID, BOSApp.CurrentUserGroupInfo.ADUserGroupID, strScreenNumber);
                if (objSTScreensInfo != null)
                    return InitializeScreen(objSTScreensInfo.STScreenName, strScreenNumber);
            }
            return null;
        }

        #endregion

        #region Search and Invalidate after search functions
        /// <summary>
        /// Search for all objects
        /// </summary>
        /// <param name="query">Query string for getting all objects</param>
        public virtual void SearchAll(string query)
        {
            if (CurrentModuleEntity.SearchObject == null)
            {
                SearchByQuery(query);
            }
            else
            {
                ResetSearch();

                BOSDbUtil dbUtil = new BOSDbUtil();
                PropertyInfo[] props = CurrentModuleEntity.SearchObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in props)
                {
                    if (prop.PropertyType == typeof(DateTime))
                    {
                        if (prop.Name.Contains("From"))
                        {
                            dbUtil.SetPropertyValue(CurrentModuleEntity.SearchObject, prop.Name, new DateTime(1987, 1, 1));
                        }
                        else if (prop.Name.Contains("To"))
                        {
                            dbUtil.SetPropertyValue(CurrentModuleEntity.SearchObject, prop.Name, DateTime.MaxValue);
                        }
                    }
                }
                Search();
                ParentScreen.ModuleUserCriteriaContainer.HidePopup();
                IsShowPopup = false;
            }
        }

        /// <summary>
        /// Search by a query
        /// </summary>
        /// <param name="strQuery">Given query</param>
        public void SearchByQuery(String strQuery)
        {
            DataSet dsSearchResults = GetSearchData(ref strQuery);
            int oldObject = this.Toolbar.CurrentObjectID;
            this.Toolbar.SetToolbar(dsSearchResults);
            InvalidateAfterSearch(null, null, oldObject);
            ParentScreen.ModuleUserCriteriaContainer.HidePopup();
            IsShowPopup = false;
            dsSearchResults.Dispose();
        }

        public virtual void Search()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Get Controller object of Main Object
                String strMainObjectControllerName = BOSUtil.GetBusinessControllerNameFromBusinessObject(CurrentModuleEntity.MainObject);
                String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
                IBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(strMainObjectControllerName);
                Cursor.Current = Cursors.WaitCursor;
                int oldObject = this.Toolbar.CurrentObjectID;
                string searchQuery = string.Empty;
                DataSet ds = GetSearchData(ref searchQuery);
                Toolbar.SetToolbar(ds);
                BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                InvalidateAfterSearch(null, String.Empty, oldObject);
                Cursor.Current = Cursors.Default;

                //Create search criteria
                if (!String.IsNullOrEmpty(searchQuery))
                {
                    if (!String.IsNullOrEmpty(SearchScreen.CriteriaName.Text))
                    {
                        ADCriteriasController objCriteriasController = new ADCriteriasController();
                        ADCriteriasInfo objADCriteriasInfo = new ADCriteriasInfo();
                        objADCriteriasInfo.AACreatedUser = BOSApp.CurrentUser;
                        objADCriteriasInfo.ADCriteriaName = SearchScreen.CriteriaName.Text;
                        objADCriteriasInfo.FK_STModuleID = ModuleID;
                        objADCriteriasInfo.ADCriteriaQueryString = searchQuery;
                        objADCriteriasInfo.FK_ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objADCriteriasInfo.ADCriteriaDesc = SearchScreen.CriteriaDescription.Text;
                        objCriteriasController.CreateObject(objADCriteriasInfo);
                        ParentScreen.GridModuleUserCriteria.InitGridControlDataSource();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        /// <summary>
        /// Get search data based on search criteria
        /// </summary>
        /// <param name="searchQuery">Get out search query generated from criteria</param>
        /// <returns>Search data</returns>
        protected virtual DataSet GetSearchData(ref string searchQuery)
        {
            string mainObjectControllerName = BOSUtil.GetBusinessControllerNameFromBusinessObject(CurrentModuleEntity.MainObject);
            String mainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            if (string.IsNullOrEmpty(searchQuery))
            {
                searchQuery = GenerateSearchQuery(mainObjectTableName);
            }
            IBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(mainObjectControllerName);
            if (objCurrentObjectController != null)
            {
                DataSet ds = objCurrentObjectController.GetDataSet(searchQuery);
                return ds;
            }
            return (new DataSet());
        }

        /// <summary type="Invalidate">
        /// Invalidate module after search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>
        /// <BOSparam name="SearchResultsControlName" type="String"></BOSparam>
        public virtual void InvalidateAfterSearch(object sender, String strEventName, int oldOject)
        {
            Cursor.Current = Cursors.WaitCursor;

            //Binding data to search result control
            Control searchResultControl = null;
            foreach (Control ctrl in Controls.Values)
            {
                if (ctrl.Tag == BOSScreen.SearchResultControl)
                {
                    searchResultControl = ctrl;
                    break;
                }
            }

            if (searchResultControl != null)
            {
                if (searchResultControl is GridControl)
                {
                    BOSSearchResultsGridControl.BindingSearchResultGridControl((DevExpress.XtraGrid.GridControl)searchResultControl, Toolbar.ObjectCollection);
                }
                else if (searchResultControl is TreeList)
                {
                    (searchResultControl as BOSSearchResultsTreeListControl).BindingSearchResult(Toolbar.ObjectCollection);

                }
                if (Toolbar.ObjectCollection != null && Toolbar.ObjectCollectionLength > 0 && !Toolbar.IsNewAction())
                {
                    if (oldOject != Toolbar.CurrentObjectID && oldOject > 0)
                        Invalidate(Toolbar.CurrentObjectID);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary type="Invalidate">
        /// Invalidate Search Results Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>        
        /// <BOSparam name="SearchResultsControlName" type="String"></BOSparam>
        public virtual void InvalidateSearchResultsControl(object sender, String strEventName)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                BOSDbUtil dbUtil = new BOSDbUtil();
                String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
                string mainTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(strMainTableName);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(strMainTableName + "Controller");

                //Invalidate toolbar collection
                PropertyInfo[] properties;
                DataRow newRow;
                String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
                int iObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, SqlDatabaseHelper.GetPrimaryKeyColumn(strMainObjectTableName)));

                if (Toolbar.ObjectCollection == null)
                {
                    DataSet ds = objMainObjectController.GetDataSetByID(iObjectID);
                    Toolbar.SetToolbar(ds);
                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                }
                else
                {
                    //if Toolbar.ModusAction is new, add new object to object collection of toolbar
                    if (Toolbar.ModusAction == BaseToolbar.ModusNew)
                    {
                        newRow = Toolbar.ObjectCollection.Tables[0].NewRow();
                        newRow = objMainObjectController.GetDataRowFromBusinessObject(newRow, CurrentModuleEntity.MainObject);
                        Toolbar.ObjectCollection.Tables[0].Rows.Add(newRow);
                        Toolbar.CurrentIndex = Toolbar.ObjectCollection.Tables[0].Rows.Count - 1;
                    }
                    else
                    {
                        //Update object in object collection of toolbar
                        properties = CurrentModuleEntity.MainObject.GetType().GetProperties();
                        int iCurrIndex = Toolbar.CurrentIndex;
                        for (int i = 0; i < properties.Length; i++)
                        {
                            if (Toolbar.ObjectCollection.Tables[0].Columns[properties[i].Name] != null && !Toolbar.ObjectCollection.Tables[0].Columns[properties[i].Name].ReadOnly)
                            {
                                Toolbar.ObjectCollection.Tables[0].Rows[iCurrIndex][properties[i].Name] = properties[i].GetValue(CurrentModuleEntity.MainObject, null);
                            }
                        }
                    }
                }


                //Invalidate search result control                
                Control searchResultControl = null;
                foreach (Control ctrl in Controls.Values)
                {
                    if (ctrl.Tag == BOSScreen.SearchResultControl)
                    {
                        searchResultControl = ctrl;
                        break;
                    }
                }

                if (searchResultControl != null)
                {
                    if (searchResultControl is GridControl)
                    {
                        BOSSearchResultsGridControl gridControl = searchResultControl as BOSSearchResultsGridControl;
                        GridView gridView = gridControl.Views[0] as GridView;
                        if (gridControl.DataSource == null)
                        {
                            BOSSearchResultsGridControl.BindingSearchResultGridControl(gridControl, Toolbar.ObjectCollection);
                        }
                        //gridControl.InvalidateLookupEditColumns();
                        gridView.RefreshData();
                        gridView.FocusedRowHandle = gridView.GetRowHandle(Toolbar.CurrentIndex);
                    }
                    else if (searchResultControl is TreeList)
                    {
                        BOSSearchResultsTreeListControl treeListControl = searchResultControl as BOSSearchResultsTreeListControl;
                        treeListControl.BindingSearchResult(Toolbar.ObjectCollection);
                        BOSTreeList treeList = (BOSTreeList)treeListControl.DataSource;
                        TreeListNode node = treeListControl.FindNodeByFieldValue(mainTablePrimaryColumn, Toolbar.CurrentObjectID);
                        treeListControl.SetFocusedNode(node);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        #region Search criteria functions
        /// <summary>
        /// Show DropDownControl of button Criteria
        /// </summary>        
        private void CreateCriteriaDropDownButton_ShowDropDownControl(object sender, DevExpress.XtraEditors.ShowDropDownControlEventArgs e)
        {
            ModuleUserCriteriaContainer(e.DropDownControl);
        }

        /// <summary>
        /// Show,hide PopupControlContainer
        /// </summary>
        public void ModuleUserCriteriaContainer(object obj)
        {
            if (IsShowPopup)
            {
                ((DevExpress.XtraBars.PopupControlContainer)obj).HidePopup();
                IsShowPopup = false;
            }
            else
            {
                ((DevExpress.XtraBars.PopupControlContainer)obj).Show();
                IsShowPopup = true;
            }
        }

        public void InitGridCotrolCriteria()
        {
            ((BaseModuleERP)this).ParentScreen.GridModuleUserCriteria.Screen = (BOSERPScreen)this.GetDataMainScreen();
            ((BaseModuleERP)this).ParentScreen.GridModuleUserCriteria.Screen.Module = this;
            ((BaseModuleERP)this).ParentScreen.GridModuleUserCriteria.InitializeControl();
        }

        public void InvalidateModuleUserCriterias()
        {
            ADCriteriasController objCriteriasController = new ADCriteriasController();
            List<ADCriteriasInfo> criteriaList = objCriteriasController.GetAllObjectByModuleAndUser(ModuleID, BOSApp.CurrentUsersInfo.ADUserID);
            ParentScreen.GridModuleUserCriteria.DataSource = criteriaList;
            ParentScreen.GridModuleUserCriteria?.RefreshDataSource();
        }
        #endregion

        #endregion
        #endregion

        #region Public Functions


        #region Funtions to show,activate,close,hibernate module
        /// <summary type="Show">
        /// Show Module
        /// </summary>        
        public virtual void Show()
        {

            //First,show parent screen      
            STModuleDescriptionsInfo obj = BOSApp.ModuleDescriptionList.Where(m => m.STModuleName == this.Name).FirstOrDefault();
            string moduleDesc = this.Name;
            if (obj != null)
                moduleDesc = obj.STModuleDescriptionDescription;
            BOSProgressBar.Start(String.Format(BaseLocalizedResources.LoadModuleMessage, moduleDesc));
            ParentScreen.ShowInTaskbar = false;

            ParentScreen.ModuleParentScreen_Init();
            if (BOSApp.OpenModules.ContainsKey(BOSApp.CurrentModule))
                ((BaseModuleERP)BOSApp.OpenModules[BOSApp.CurrentModule]).ParentScreen.WindowState = FormWindowState.Minimized;
            ParentScreen.Show();
            ParentScreen.Focus();

            //Invalidate module for additional adjustments
            ModuleAfterLoaded();

            ParentScreen.SearchContainer.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;

            //Hide inventory container, just show with transaction module            
            ParentScreen.InventoryContainer.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

            //Show search result panel
            ParentScreen.ShowSearchResultsPanel();
            if (ParentScreen.IsExistsGridSearchResult() && Toolbar.CurrentObjectID <= 0)
            {
                ResetSearch();
                Search();
            }
            BOSProgressBar.Close();
        }

        public void ActivateDataMainScreen()
        {
            BOSERPScreen _guiDataMainScreen = (BOSERPScreen)GetDataMainScreen();
            ActivateScreen(_guiDataMainScreen.ScreenNumber);
        }

        /// <summary>
        /// Activate a screen
        /// </summary>
        /// <param name="screenNumber">Screen number</param>
        public virtual void ActivateScreen(string screenNumber, bool isRefeshDataControl = false)
        {
            XtraTabPage page = ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == screenNumber).FirstOrDefault();
            if (page != null)
            {
                ParentScreen.ScreenContainer.SelectedTabPage = page;
                BOSScreen screen = Screens.Where(s => s.ScreenNumber == screenNumber).FirstOrDefault();
                if (screen != null)
                {
                    ActiveScreen = screen;
                    ((BOSERPScreen)ActiveScreen).Activate();
                }
                if (isRefeshDataControl)
                    RefeshDataControlWithActivateScreen(page.Controls);
            }
        }

        public virtual void RefeshDataControlWithActivateScreen(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is IBOSControl)
                    ctrl.Refresh();

                if (ctrl is GridControl)
                    ((GridControl)ctrl).RefreshDataSource();

                if (ctrl is TreeList)
                    ((TreeList)ctrl).RefreshDataSource();

                if (ctrl.Controls.Count > 0)
                    RefeshDataControlWithActivateScreen(ctrl.Controls);
            }
        }

        public override void ShowScreen(BOSScreen scr, bool bIsChild)
        {
            try
            {
                //Does not show screen if it has no permission or its sort order =-1
                BOSERPScreen screen = (BOSERPScreen)scr;
                if (screen.ScreenInfo != null)
                {
                    if (screen.ScreenInfo.STScreenSortOrder < 0)
                        return;
                }
                Cursor.Current = Cursors.WaitCursor;
                if (bIsChild)
                    screen.MdiParent = ParentScreen;
                if (screen.IsDataSubScreen())
                {
                    if (screen.ScreenInfo != null)
                    {
                        screen.SizeGripStyle = SizeGripStyle.Hide;
                        screen.MinimizeBox = false;
                        screen.MaximizeBox = false;
                        screen.StartPosition = FormStartPosition.Manual;
                        screen.Size = new Size(screen.ScreenInfo.STScreenSizeWidth, screen.ScreenInfo.STScreenSizeHeight);
                        screen.Location = new Point(screen.ScreenInfo.STScreenLocationX, screen.ScreenInfo.STScreenLocationY);
                        screen.TopMost = screen.ScreenInfo.STScreenTopMost;
                        if (screen.ScreenInfo.STScreenShowModal == true)
                            screen.ShowDialog();
                        else
                            screen.Show();
                    }
                }
                else
                    screen.Show();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show(this.GetType().FullName + ".ShowScreen:" + e.Message);
            }
        }

        /// <summary type="Close">
        /// Close Module.Close all screens in module
        /// </summary>
        public virtual void Close()
        {
            //Remove Module in OpenModules
            BOSApp.MainScreen.OpenModulesToolStrip.Items.RemoveByKey(Name);
            BOSApp.RemoveOpenedModule(Name);
            if (BOSApp.CurrentUser != null)
                DeleteUserAudit(Name);

            //Active last open modules
            if (BOSApp.MainScreen.OpenModulesToolStrip.Items.Count > 0)
            {
                int index = BOSApp.MainScreen.OpenModulesToolStrip.Items.Count - 1;
                String strModuleName = BOSApp.MainScreen.OpenModulesToolStrip.Items[index].Name;
                BOSApp.ShowModule(strModuleName);
            }
        }

        /// <summary type="Show">
        /// Show Sub Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>
        /// <BOSparam name="DataSubScreenName" type="String"></BOSparam>
        public void ShowSubScreen(object sender, String strEventName)
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                String strSubScreenNumber = GetBOSParameterValueFromFunctionNameAndParameterName(
                                        sender, strEventName,
                                        "ShowSubScreen", "DataSubScreenName");

                BOSERPScreen scr = (BOSERPScreen)GetScreenByScreenNumber(strSubScreenNumber);
                if (scr != null)
                {
                    if (scr.IsDisposed)
                    {
                        scr = (BOSERPScreen)scr.Recreate();
                        scr.ControlBox = true;
                        ShowScreen(scr, false);
                    }
                    else
                    {

                        scr.ControlBox = true;
                        ShowScreen(scr, false);
                    }
                }
                else
                {
                    BOSProgressBar.Start(BaseLocalizedResources.Loading);
                    scr = (BOSERPScreen)InitializeScreen(strSubScreenNumber);
                    Screens.Add(scr);
                    BOSProgressBar.Close();
                    scr.ControlBox = true;
                    ShowScreen(scr, false);
                }
            }
            else
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectToEditMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary type="Show">
        /// Show Column Selector
        /// </summary>        
        /// <param name="ctrlSearchResults">Search Results Control to show Column</param>
        /// <param name="showForm"></param>
        public void ShowColumnSelector(DevExpress.XtraGrid.GridControl ctrlSearchResults, bool showForm)
        {
            if (showForm)
            {
                ((DevExpress.XtraGrid.Views.Grid.GridView)ctrlSearchResults.ViewCollection[0]).ColumnsCustomization();
            }
            else
            {
                ((DevExpress.XtraGrid.Views.Grid.GridView)ctrlSearchResults.ViewCollection[0]).DestroyCustomization();
            }
        }

        public void GoNextScreen()
        {
            int index = Screens.IndexOf(ActiveScreen);
            if (index >= 0)
            {
                index++;
                if (index >= Screens.Count)
                    index = 0;
                //Just active screen when screen is not data sub screen
                if (Toolbar.IsNullOrNoneAction())
                {
                    while (Screens[index].IsDataSubScreen())
                    {
                        index++;
                        if (index >= Screens.Count)
                            index = 0;
                    }
                }
                else
                {
                    while (Screens[index].IsDataSubScreen() || Screens[index].IsSearchMainScreen())
                    {
                        index++;
                        if (index >= Screens.Count)
                            index = 0;
                    }
                }
                ActiveScreen = Screens[index];
            }

        }

        private int GetIndexOfCurrentScreen(String strScreenNumber, String[] arrScreenKeys)
        {
            for (int i = 0; i < arrScreenKeys.Length; i++)
            {
                if (arrScreenKeys[i] == strScreenNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public virtual void SetDisplaySearchScreen(bool bDisplay)
        {
            BOSERPScreen searchScreen = (BOSERPScreen)GetSearchMainScreen();
            if (searchScreen != null)
                searchScreen.Visible = bDisplay;
        }

        #endregion

        #region Function for Set,Reset,Save Module Search Fields
        public virtual void ResetSearch()
        {
            if (CurrentModuleEntity.SearchObject != null)
            {
                ResetSearchObject();
            }
            else
            {
                ResetSearchControls();
            }

            //Reset Filter on Grid Search Result Control
            String strMainTable = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            STFieldsInfo objGridSearchResultFieldsInfo;

            objGridSearchResultFieldsInfo = BOSApp.LstField.Where(f => f.STModuleID == ModuleID
                                                                    && f.STUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID
                                                                    && f.STFieldDataSource == strMainTable
                                                                    && f.STFieldType == "BOSGridControl"
                                                                    && f.STFieldTag == BOSERPScreen.SearchControl).FirstOrDefault();
            //if(objGridSearchResultFieldsInfo == null)
            //     objGridSearchResultFieldsInfo = (STFieldsInfo)new STFieldsController().GetFirstFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldTypeAndFieldTag(
            //                                                        ModuleID, BOSApp.CurrentUserGroupInfo.ADUserGroupID,
            //                                                        strMainTable, "BOSGridControl", BOSERPScreen.SearchControl);
            if (objGridSearchResultFieldsInfo != null)
            {
                DevExpress.XtraGrid.GridControl gridControl = Controls[objGridSearchResultFieldsInfo.STFieldName] as DevExpress.XtraGrid.GridControl;
                DevExpress.XtraGrid.Views.Grid.GridView gridView = gridControl.Views[0] as DevExpress.XtraGrid.Views.Grid.GridView;
                for (int i = 0; i < gridView.VisibleColumns.Count; i++)
                {
                    String strFieldName = gridView.VisibleColumns[i].FieldName;
                    gridView.Columns[strFieldName].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo();
                }
            }
        }

        public virtual void ResetSearchControls()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (Control ctrl in SearchScreen.CriteriaSection.Controls)
            {
                string dataSource = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataSourcePropertyName);
                string dataMember = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                if (dataMember == "TopResults")
                {
                    ctrl.Text = BOSApp.cstTopResults.ToString();
                }
                else
                {
                    if (ctrl.Enabled)
                    {
                        if (ctrl is DevExpress.XtraEditors.DateEdit)
                        {
                            if (ctrl.Name.Contains("SearchFrom"))
                                (ctrl as DevExpress.XtraEditors.DateEdit).DateTime = DateTime.Now.AddDays(-15);
                            else if (ctrl.Name.Contains("SearchTo"))
                                (ctrl as DevExpress.XtraEditors.DateEdit).DateTime = DateTime.Now;
                            else
                                (ctrl as DevExpress.XtraEditors.DateEdit).EditValue = string.Empty;
                        }
                        else if (ctrl is DevExpress.XtraEditors.LookUpEdit)
                        {
                            String strDataType = dbUtil.GetColumnDataType(dataSource, dataMember);
                            if (strDataType == "int" || strDataType == "float")
                                (ctrl as DevExpress.XtraEditors.LookUpEdit).EditValue = 0;
                            else
                                (ctrl as DevExpress.XtraEditors.LookUpEdit).EditValue = String.Empty;
                        }
                        else if (ctrl is DevExpress.XtraEditors.TextEdit)
                            (ctrl as DevExpress.XtraEditors.TextEdit).EditValue = String.Empty;
                        else if (ctrl is DevExpress.XtraEditors.ComboBoxEdit)
                            (ctrl as DevExpress.XtraEditors.ComboBoxEdit).SelectedIndex = -1;
                    }
                }
            }
        }

        public virtual void ResetSearchObject()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            PropertyInfo[] props = CurrentModuleEntity.SearchObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType == typeof(string))
                {
                    dbUtil.SetPropertyValue(CurrentModuleEntity.SearchObject, prop.Name, string.Empty);
                }
                else if (prop.PropertyType == typeof(int))
                {
                    dbUtil.SetPropertyValue(CurrentModuleEntity.SearchObject, prop.Name, 0);
                    if (prop.Name.Contains("FK_BRBranchID") && BOSApp.CurrentCompanyInfo.CSCompanyIsShowDataByBranch)
                        dbUtil.SetPropertyValue(CurrentModuleEntity.SearchObject, prop.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    if (prop.Name.Contains("From"))
                    {
                        dbUtil.SetPropertyValue(CurrentModuleEntity.SearchObject, prop.Name, DateTime.Now.AddDays(-15));
                    }
                    else if (prop.Name.Contains("To"))
                    {
                        dbUtil.SetPropertyValue(CurrentModuleEntity.SearchObject, prop.Name, DateTime.Now);
                    }
                }
            }
            CurrentModuleEntity.UpdateSearchObjectBindingSource();
        }

        /// <summary>
        /// Called when the module has been loaded,
        /// give a chance to add handling
        /// </summary>
        public virtual void ModuleAfterLoaded()
        {
            //Add extra controls for data screens such as asterisk, search button...
            foreach (BOSERPScreen scr in Screens)
            {
                if (scr.IsDataMainScreen())
                {
                    foreach (DevExpress.XtraTab.XtraTabPage page in ParentScreen.ScreenContainer.TabPages)
                        if (page.Name == scr.ScreenNumber)
                        {
                            scr.AddExtraControls(page.Controls);
                            break;
                        }
                }
            }

            //Reset focus
            ResetFocus();
        }
        #endregion
        #endregion

        #region Functions to Get Screen of Module

        /// <summary>
        /// Get Data Main Screen
        /// </summary>
        /// <returns></returns>
        public BOSScreen GetDataMainScreen()
        {
            BOSERPScreen _guiDataMainScreen = new BOSERPScreen();
            for (int i = 0; i < Screens.Count; i++)
            {
                String strScreenNumber = Screens[i].ScreenNumber;
                if (strScreenNumber.StartsWith("DM") && strScreenNumber.EndsWith("100"))
                {
                    _guiDataMainScreen = (BOSERPScreen)Screens[i];
                    break;
                }
            }
            return _guiDataMainScreen;
        }
        public void SetScreentoForegroundByScreenName(String strScreenName)
        {

            BOSERPScreen _guiDataMainScreen = new BOSERPScreen();
            for (int i = 0; i < Screens.Count; i++)
            {
                if (strScreenName == Screens[i].Name)
                {

                    BOSERPScreen _guiScreen = (BOSERPScreen)Screens[i];
                    _guiScreen.Activate();
                }
            }
        }

        /// <summary type="GetScreen">
        /// Get Main Search Screen of Module
        /// </summary>        
        /// <returns>Main Search Screen</returns>
        public BOSScreen GetSearchMainScreen()
        {
            BOSScreen _guiSearchMainScreen = new BOSERPScreen();
            for (int i = 0; i < Screens.Count; i++)
            {
                String strScreenNumber = Screens[i].ScreenNumber;
                if (strScreenNumber.StartsWith("SM"))
                {
                    _guiSearchMainScreen = (BOSERPScreen)Screens[i];
                    break;
                }
            }
            return _guiSearchMainScreen;
        }

        /// <summary type="GetScreen">
        /// Get Data Main Screen of Module
        /// </summary>
        /// <BOSparam name="DataMainScreenNumber" type="String"></BOSparam>
        /// <returns>Data Main Screen</returns>
        public BOSERPScreen GetDataMainScreen(object sender, String strEventName)
        {
            String strDataMainScreenNumber = GetBOSParameterValueFromFunctionNameAndParameterName(
                                                sender, strEventName,
                                                "GetDataMainScreen", "DataMainScreenNumber");
            BOSERPScreen scr = (BOSERPScreen)GetScreenByScreenNumber(strDataMainScreenNumber);
            if (scr == null)
            {
                for (int i = 0; i < Screens.Count; i++)
                {
                    String strScreenNumber = Screens[i].ScreenNumber;
                    if (strScreenNumber.StartsWith("DM") && strScreenNumber.EndsWith("100"))
                        scr = (BOSERPScreen)Screens[i];
                }
            }
            return (BOSERPScreen)scr;

        }

        /// <summary type="GetScreen">
        /// Get Data Sub Screen of module
        /// </summary>
        /// <returns>Data Sub Screen</returns>
        public BOSScreen GetDataSubScreen()
        {
            BOSERPScreen _guiDataSubScreen = new BOSERPScreen();
            for (int i = 0; i < Screens.Count; i++)
            {

                if (Screens[i].ScreenNumber.StartsWith("DS"))
                {
                    _guiDataSubScreen = (BOSERPScreen)Screens[i];
                    break;
                }
            }
            return _guiDataSubScreen;
        }

        /// <summary type="GetScreen">
        /// Get Search Results Screen of Module
        /// </summary>
        /// <returns>Search Result Screen</returns>
        public BOSScreen GetSearchResultScreen()
        {
            BOSERPScreen _guiSearchResultsScreen = new BOSERPScreen();
            for (int i = 0; i < Screens.Count; i++)
            {
                if (Screens[i].ScreenNumber.StartsWith("SR"))
                {
                    _guiSearchResultsScreen = (BOSERPScreen)Screens[i];
                    break;
                }
            }
            return _guiSearchResultsScreen;
        }
        #endregion

        #region Functions for Control of Module
        public void FocusRowOfGridSearchResultByToolbarCurrentIndex()
        {
            BOSScreen screen = GetSearchMainScreen();
            if (screen != null)
            {
                STFieldsInfo objFieldsInfo = screen.Fields.Where(f => f.Value.STFieldType == typeof(BOSSearchResultsGridControl).Name && f.Value.STFieldTag == "SR").FirstOrDefault().Value;
                if (objFieldsInfo != null && Controls.Contains(objFieldsInfo.STFieldName))
                {
                    GridControl gridControl = (GridControl)Controls[objFieldsInfo.STFieldName];
                    GridView gridView = (GridView)gridControl.MainView;
                    gridView.FocusedRowHandle = gridView.GetRowHandle(Toolbar.CurrentIndex);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>
        /// <BOSparam name="DisplaySearchResultsControlName" type="String"></BOSparam>
        public void ShowSearchResults(object sender, String strEventName)
        {
            String strControlName = GetBOSParameterValueFromFunctionNameAndParameterName(
                                        sender, strEventName,
                                        "ShowSearchResults", "DisplaySearchResultsControlName");
            if (Controls[strControlName] != null)
                Controls[strControlName].Text = this.Toolbar.ObjectCollectionLength.ToString();
        }


        public void RefreshGridControl(String strGridControlDataSource)
        {
            STFieldsInfo objGridControlFieldsInfo = new STFieldsController().GetFirstFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldTypeAndFieldTag(
                                                                ModuleID, BOSApp.CurrentUserGroupInfo.ADUserGroupID, strGridControlDataSource, "BOSGridControl", BOSScreen.DataControl);
            if (objGridControlFieldsInfo != null)
            {
                DevExpress.XtraGrid.GridControl gridControl = Controls[objGridControlFieldsInfo.STFieldName] as DevExpress.XtraGrid.GridControl;
                DevExpress.XtraGrid.Views.Grid.GridView gridView = gridControl.Views[0] as DevExpress.XtraGrid.Views.Grid.GridView;
                gridView.RefreshData();
            }
        }

        #region Functions of invalidating controls after doing action
        public void InvalidateFieldGroupControls(String strAction)
        {
            switch (strAction)
            {
                case BaseToolbar.ModusNew:
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupNonEditable, true);
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupAction, true);
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupNonAction, false);

                    EnableSearchMainScreens(false);
                    break;
                case BaseToolbar.ModusEdit:
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupNonCreatable, true);
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupAction, true);
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupNonAction, false);

                    EnableSearchMainScreens(false);
                    break;
                case BaseToolbar.ModusNone:
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupNonCreatable, false);
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupNonEditable, false);
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupAction, false);
                    EnableFieldGroupControls(BOSERPScreen.cstFieldGroupNonAction, true);

                    EnableSearchMainScreens(true);
                    break;
            }
        }

        public void EnableFieldGroupControls(String strGroup, bool enable)
        {
            if (FieldGroupControls.ContainsKey(strGroup))
            {
                foreach (Control ctrl in FieldGroupControls[strGroup].Values)
                    ctrl.Enabled = enable;
            }
        }

        public void DisplayFieldGroupControls(String strGroup, bool visible)
        {
            if (FieldGroupControls.ContainsKey(strGroup))
            {
                foreach (Control ctrl in FieldGroupControls[strGroup].Values)
                    ctrl.Visible = visible;
            }
        }

        public void EnableSearchMainScreens(bool enable)
        {
            foreach (BOSScreen screen in Screens)
                if (screen.IsSearchMainScreen())
                    screen.Enabled = enable;
        }
        #endregion

        #region Get Parameter Value

        /// <summary type="GetParameterValue">
        /// Get Parameter Value of Module Function by Function Full Name,Function Class and Parameter Name
        /// </summary>
        /// <param name="strModuleFunctionFullName"></param>
        /// <param name="strModuleFunctionClass"></param>
        /// <param name="strModuleFunctionParameterName"></param>
        /// <returns></returns>
        public String GetModuleFunctionParameterValue(String strModuleFunctionFullName, String strModuleFunctionClass, String strModuleFunctionParameterName)
        {
            String strModuleFunctionParameterValue = String.Empty;

            STModuleFunctionsController objSTModuleFunctionsController = new STModuleFunctionsController();
            STModuleFunctionParametersController objSTModuleFunctionParametersController = new STModuleFunctionParametersController();
            //Get Module Function
            STModuleFunctionsInfo objSTModuleFunctionsInfo = BOSApp.ListModuleFunction.Where(mf => mf.STModuleID == ModuleID
                                                                                               && mf.STModuleFunctionFullName.ToUpper() == strModuleFunctionFullName.ToUpper()
                                                                                               && mf.STModuleFunctionClass.ToUpper() == strModuleFunctionClass.ToUpper()).FirstOrDefault();
            if (objSTModuleFunctionsInfo != null)
            {

                //Get Module Function Parameter
                STModuleFunctionParametersInfo objSTModuleFunctionParametersInfo
                    = BOSApp.ListModuleFunctionParam.Where(fp => fp.STModuleFunctionID == objSTModuleFunctionsInfo.STModuleFunctionID
                                                            && fp.STModuleFunctionParameterName.ToUpper() == strModuleFunctionParameterName.ToUpper()).FirstOrDefault();

                if (objSTModuleFunctionParametersInfo != null)
                {
                    //Get Module Function Parameter Value
                    STModuleFunctionParameterValuesInfo objSTModuleFunctionParameterValuesInfo
                        = BOSApp.ListModuleFunctionParamValue.Where(pv => pv.STModuleFunctionParameterID == objSTModuleFunctionParametersInfo.STModuleFunctionParameterID
                                                                        && pv.STUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID).FirstOrDefault();
                    if (objSTModuleFunctionParameterValuesInfo != null)
                        strModuleFunctionParameterValue = objSTModuleFunctionParameterValuesInfo.STModuleFunctionParameterValue;
                }
            }

            return strModuleFunctionParameterValue;
        }

        /// <summary type="GetParameterValue">
        /// Get BOS Parameter Value
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="strEventName"></param>
        /// <param name="strFieldEventFunctionFullName"></param>
        /// <param name="strFieldEventFunctionClass"></param>
        /// <param name="strFieldEventFunctionParameterName"></param>
        /// <returns></returns>
        public String GetBOSParameterValue(Control ctrl, String strEventName, String strFieldEventFunctionFullName, String strFieldEventFunctionClass, String strFieldEventFunctionParameterName)
        {
            String strParameterValue = String.Empty;
            //If Get Parameter Value from Field Event Function
            if ((ctrl != null) && (!String.IsNullOrEmpty(strEventName)))
            {
                int iScreenID = ((BOSERPScreen)ctrl.FindForm()).ScreenID;
                if (iScreenID > 0)
                {
                    STFieldsInfo objSTFieldsInfo = BOSApp.LstField.Where(f => f.STFieldName == ctrl.Name
                                                        && f.STScreenID == iScreenID
                                                        && f.STUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID).FirstOrDefault();
                    if (objSTFieldsInfo != null)
                    {
                        STFieldEventsInfo objSTFieldEventsInfo = BOSApp.LstFieldEvent.Where(fe => fe.STFieldEventName == strEventName
                                                    && fe.STFieldID == objSTFieldsInfo.STFieldID).FirstOrDefault();
                        if (objSTFieldEventsInfo != null)
                        {
                            STFieldEventFunctionsInfo objSTFieldEventFunctionsInfo = BOSApp.LstFieldEventFunc.Where(fc => fc.STFieldEventID == objSTFieldEventsInfo.STFieldEventID
                                    && fc.STFieldEventFunctionFullName.ToUpper() == strFieldEventFunctionFullName.ToUpper()
                                    && fc.STFieldEventFunctionClass.ToUpper() == strFieldEventFunctionClass.ToUpper()).FirstOrDefault();
                            if (objSTFieldEventFunctionsInfo != null)
                            {
                                STFieldEventFunctionParametersInfo objSTFieldEventFunctionParametersInfo = BOSApp.ListFieldEventFuncParam.Where(fp =>
                                            fp.STFieldEventFunctionID == objSTFieldEventFunctionsInfo.STFieldEventFunctionID
                                        && fp.STFieldEventFunctionParameterName.ToUpper() == strFieldEventFunctionParameterName.ToUpper()).FirstOrDefault();
                                if (objSTFieldEventFunctionParametersInfo != null)
                                    strParameterValue = objSTFieldEventFunctionParametersInfo.STFieldEventFunctionParameterValue;
                            }
                        }
                    }
                }
            }
            //if get parameter value from module function
            else
            {
                strParameterValue = GetModuleFunctionParameterValue(
                                        strFieldEventFunctionFullName,
                                        strFieldEventFunctionClass,
                                        strFieldEventFunctionParameterName);
            }

            return strParameterValue;
        }

        /// <summary type="GetParameterValue">
        /// Get BOS Parameter Value with object sender is Bar Manager
        /// </summary>
        /// <param name="barManager"></param>
        /// <param name="strEventName"></param>
        /// <param name="strFieldEventFunctionFullName"></param>
        /// <param name="strFieldEventFunctionClass"></param>
        /// <param name="strFieldEventFunctionParameterName"></param>
        /// <returns></returns>
        public String GetBOSParameterValue(DevExpress.XtraBars.BarManager barManager, String strEventName, String strFieldEventFunctionFullName, String strFieldEventFunctionClass, String strFieldEventFunctionParameterName)
        {
            String strParameterValue = String.Empty;
            //If Get Parameter Value from Field Event Function
            if ((barManager != null) && (!String.IsNullOrEmpty(strEventName)))
            {

                //if Toolbar of Parent Form of Module
                if (barManager.Form.GetType() == typeof(ModuleParentScreen))
                {
                    String strToolbarTag = barManager.PressedLink.Item.Tag.ToString();
                    String strToolbarGroup = barManager.PressedLink.Item.Hint;

                    STToolbarsInfo objSTToolbarsInfo = BOSApp.ListToolbar.Where(t => t.STModuleID == ModuleID
                        && t.STUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID
                        && t.STToolbarTag == strToolbarTag).FirstOrDefault();
                    if (objSTToolbarsInfo != null)
                    {
                        STToolbarFunctionsInfo objSTToolbarFunctionsInfo = BOSApp.ListToolbarFunc.Where(f => f.STToolbarID == objSTToolbarsInfo.STToolbarID
                                                                                    && f.STToolbarFunctionFullName.ToUpper() == strFieldEventFunctionFullName.ToUpper()
                                                                                    && f.STToolbarFunctionClass.ToUpper() == strFieldEventFunctionClass.ToUpper()).FirstOrDefault();
                        if (objSTToolbarFunctionsInfo != null)
                        {
                            STToolbarFunctionParametersInfo objSTToolbarFunctionParametersInfo = BOSApp.ListToolbarFuncParam.Where(fp => fp.STToolbarFunctionID == objSTToolbarFunctionsInfo.STToolbarFunctionID
                                && fp.STToolbarFunctionParameterName.ToUpper() == strFieldEventFunctionParameterName.ToUpper()).FirstOrDefault();
                            if (objSTToolbarFunctionParametersInfo != null)
                                strParameterValue = objSTToolbarFunctionParametersInfo.STToolbarFunctionParameterValue;
                        }
                    }
                }
                //if is toolbar of sub screen
                else
                {
                    int iScreenID = 0;
                    STScreensInfo objScreensInfo = BOSApp.LstScreen.Where(s => s.STModuleID == ModuleID
                                                                            && s.STUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID
                                                                            && s.STScreenName == barManager.Form.Name).FirstOrDefault();

                    if (objScreensInfo != null) iScreenID = objScreensInfo.STScreenID;
                    else
                        iScreenID = new STScreensController().GetScreenIDByModuleIDAndUserGroupIDAndScreenName(ModuleID, BOSApp.CurrentUserGroupInfo.ADUserGroupID, barManager.Form.Name);
                    if (iScreenID > 0)
                    {
                        BOSLib.STFieldsInfo objSTFieldsInfo = BOSApp.LstField.Where(f => f.STFieldName == barManager.PressedLink.Item.Name
                                                        && f.STScreenID == iScreenID
                                                        && f.STUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID).FirstOrDefault();
                        if (objSTFieldsInfo != null)
                        {
                            STFieldEventsInfo objSTFieldEventsInfo = BOSApp.LstFieldEvent.Where(fe => fe.STFieldEventName == strEventName
                                                    && fe.STFieldID == objSTFieldsInfo.STFieldID).FirstOrDefault();
                            if (objSTFieldEventsInfo != null)
                            {
                                STFieldEventFunctionsInfo objSTFieldEventFunctionsInfo = BOSApp.LstFieldEventFunc.Where(fc => fc.STFieldEventID == objSTFieldEventsInfo.STFieldEventID
                                    && fc.STFieldEventFunctionFullName.ToUpper() == strFieldEventFunctionFullName.ToUpper()
                                    && fc.STFieldEventFunctionClass.ToUpper() == strFieldEventFunctionClass.ToUpper()).FirstOrDefault();

                                if (objSTFieldEventFunctionsInfo != null)
                                {
                                    STFieldEventFunctionParametersInfo objSTFieldEventFunctionParametersInfo = BOSApp.ListFieldEventFuncParam.Where(fp =>
                                            fp.STFieldEventFunctionID == objSTFieldEventFunctionsInfo.STFieldEventFunctionID
                                        && fp.STFieldEventFunctionParameterName.ToUpper() == strFieldEventFunctionParameterName.ToUpper()).FirstOrDefault();

                                    if (objSTFieldEventFunctionParametersInfo != null)
                                        strParameterValue = objSTFieldEventFunctionParametersInfo.STFieldEventFunctionParameterValue;
                                }
                            }
                        }
                    }
                }
            }
            //if get parameter value from module function
            else
            {
                strParameterValue = GetModuleFunctionParameterValue(strFieldEventFunctionFullName, strFieldEventFunctionClass, strFieldEventFunctionParameterName);
            }

            return strParameterValue;
        }

        /// <summary>
        /// Get BOS Paramter Value by object sender,Event Name,FieldEventFunction Full Name,Field Event Function Class And Field Event Function Parameter Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>
        /// <param name="strFieldEventFunctionFullName"></param>
        /// <param name="strFieldEventFunctionClass"></param>
        /// <param name="strFieldEventFunctionParameterName"></param>
        /// <returns></returns>
        public String GetBOSParameterValue(object sender, String strEventName, String strFieldEventFunctionFullName, String strFieldEventFunctionClass, String strFieldEventFunctionParameterName)
        {
            if (sender != null)
            {
                if (sender.GetType() == typeof(DevExpress.XtraBars.BarManager))
                {
                    return GetBOSParameterValue((DevExpress.XtraBars.BarManager)sender, strEventName, strFieldEventFunctionFullName, strFieldEventFunctionClass, strFieldEventFunctionParameterName);
                }
                else
                    return GetBOSParameterValue((Control)sender, strEventName, strFieldEventFunctionFullName, strFieldEventFunctionClass, strFieldEventFunctionParameterName);
            }
            else
            {
                return GetModuleFunctionParameterValue(strFieldEventFunctionFullName, strFieldEventFunctionClass, strFieldEventFunctionParameterName);
            }

        }


        public String GetBOSParameterValueFromFunctionNameAndParameterName(
                            object sender, String strEventName,
                            String strFunctionName, String strParameterName)
        {
            MethodInfo method = GetMethodInfoByMethodNameAndParametersType(
                                    strFunctionName,
                                    new Type[2] { typeof(object), typeof(String) });
            String strParameterValue = GetBOSParameterValue(
                                        sender,
                                        strEventName,
                                        method.ToString(),
                                        method.DeclaringType.ToString(),
                                        strParameterName);
            return strParameterValue;
        }
        #endregion

        #region Functions for User Audits, Object History
        public bool ObjectIsEditingByOtherUser(String strModuleName, int iObjectID)
        {
            if (iObjectID > 0)
            {
                GEUserAuditsController objGEUserAuditsController = new GEUserAuditsController();
                GEUserAuditsInfo objGEUserAuditsInfo = objGEUserAuditsController.GetGEUserAuditsByModuleNameAndParameterAndAction(
                                                                                    strModuleName,
                                                                                    iObjectID.ToString(),
                                                                                    BaseToolbar.ModusEdit);
                if (objGEUserAuditsInfo != null)
                {
                    String strEditUser = objGEUserAuditsInfo.ADUserName;
                    MessageBox.Show(string.Format(BaseLocalizedResources.ObjectHasBeenLockedMessage, strEditUser.ToUpper()),
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return true;
                }
            }

            return false;
        }

        public void SaveUserAudit(String strUserAction)
        {
            GEUserAuditsController objGEUserAuditsController = new GEUserAuditsController();
            objGEUserAuditsController.CreateOrUpdate(0, string.Empty
                , 0, "Alive", 0
                , BOSApp.CurrentUser, this.Name, DateTime.Now
                , strUserAction, (strUserAction.Equals(cstUserAuditEdit) ? Toolbar.CurrentObjectID.ToString() : ""));
        }

        public void DeleteUserAudit()
        {
            ADUsersController objADUsersController = new ADUsersController();
            GEUserAuditsController objGEUserAuditsController = new GEUserAuditsController();

            int iADUserID = objADUsersController.GetObjectIDByName(BOSApp.CurrentUser);
            objGEUserAuditsController.DeleteGEUserAuditsByADUserID(iADUserID);
        }

        public void DeleteUserAudit(String strModuleName)
        {
            ADUsersController objADUsersController = new ADUsersController();
            GEUserAuditsController objGEUserAuditsController = new GEUserAuditsController();

            //int iADUserID = objADUsersController.GetObjectIDByName(BOSApp.CurrentUser);
            objGEUserAuditsController.DeleteGEUserAuditsByADUserNameAndModuleName(BOSApp.CurrentUser, this.Name);
        }

        public virtual int SaveObjectHistory(String strUserAction, int iObjectID)
        {
            int iADUserID = BOSApp.CurrentUsersInfo.ADUserID;
            BOSDbUtil dbUtil = new BOSDbUtil();
            string MainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            string MainTablePrefix = MainTableName.Substring(0, MainTableName.Length - 1);
            string strObjectNo = (string)dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, MainTablePrefix + "No");
            GEObjectHistoryController objGEObjectHistoryController = new GEObjectHistoryController();

            //Get Object History Info
            GEObjectHistoryInfo objGEObjectHistoryInfo = new GEObjectHistoryInfo();
            objGEObjectHistoryInfo.ADUserID = iADUserID;
            objGEObjectHistoryInfo.ADUserName = BOSApp.CurrentUser;
            objGEObjectHistoryInfo.GEObjectHistoryAction = strUserAction;
            objGEObjectHistoryInfo.GEObjectHistoryObjectID = iObjectID;
            objGEObjectHistoryInfo.GEObjectHistoryObjectName = this.Name;
            objGEObjectHistoryInfo.GEObjectHistoryObjectNumber = strObjectNo;
            DateTime currentDate = BOSApp.GetCurrentServerDate();
            objGEObjectHistoryInfo.GEObjectHistoryDate = currentDate;

            objGEObjectHistoryController.CreateObject(objGEObjectHistoryInfo);
            return objGEObjectHistoryInfo.GEObjectHistoryID;
        }
        #endregion

        #endregion
        #endregion

        #region Method for get Method Info

        /// <summary>
        /// GetAssembly Name From Method Class
        /// </summary>
        /// <functiontype>Get Method</functiontype>        
        /// <returns></returns>
        public override string GetAssemblyName()
        {
            return "BOSERP";
        }

        public override Type GetClassType(String strClassName)
        {
            return BaseClassFactory.GetClassType(strClassName);
        }
        #endregion

        #region Utilities
        /// <summary>
        /// Get lookup tables through BOSApp
        /// </summary>
        /// <returns></returns>
        public SortedList GetLookupTableCollection()
        {
            return BOSApp.LookupTables;
        }

        /// <summary>
        /// Get the last created/updated date of all lookup tables through BOSApp
        /// </summary>
        /// <returns></returns>
        public SortedList GetLookupTableUpdatedDateCollection()
        {
            return BOSApp.LookupTablesUpdatedDate;
        }

        public void UpdateLookupTableUpdatedDateCollection(string tableName, DateTime datetime)
        {
            if (BOSApp.LookupTablesUpdatedDate != null)
            {
                if (BOSApp.LookupTablesUpdatedDate.ContainsKey(tableName))
                {
                    BOSApp.LookupTablesUpdatedDate[tableName] = GetServerDate();
                }
                else
                {
                    BOSApp.LookupTablesUpdatedDate.Add(tableName, GetServerDate());
                }
            }
        }

        public void UpdateLookupTables(string tableName, DataSet ds)
        {
            if (ds == null || ds.Tables.Count == 0)
                return;

            if (BOSApp.LookupTableObjects != null && !tableName.IsNullOrWhiteSpace())
            {
                if (BOSApp.LookupTables.ContainsKey(tableName))
                {
                    BOSApp.LookupTables[tableName] = ds;
                }
                else
                {
                    BOSApp.LookupTables.Add(tableName, ds);
                }

            }
        }
        public SortedList<string, GELookupTablesInfo> GetLookupTableObjects()
        {
            return BOSApp.LookupTableObjects;
        }
        public List<GELookupTablesInfo> GetLookupTableList()
        {
            return BOSApp.LookupTableList;
        }
        public List<STScreensInfo> GetSystemScreen()
        {
            return BOSApp.LstScreen.Where(f => f.STModuleID == this.ModuleID).ToList(); ;
        }
        public List<STFieldsInfo> GetSystemFields()
        {
            return BOSApp.LstField;
            //return BOSApp.LstField.Where(f => f.STModuleID == this.ModuleID).ToList();
        }
        public List<STFieldColumnsInfo> GetSystemFieldColumns()
        {
            //var listFc = from f in BOSApp.LstField
            //             join fc in BOSApp.LstFieldColumn on f.STFieldID equals fc.STFieldID
            //             where f.STModuleID == this.ModuleID
            //             select fc;

            //return listFc.ToList();
            return BOSApp.LstFieldColumn;
        }
        public void RemoveSystemFieldColumnsByFieldID(int fieldID, string commodityType)
        {
            if (BOSApp.LstFieldColumn != null)
            {
                List<STFieldColumnsInfo> collection = BOSApp.LstFieldColumn.Where(item => item.STFieldID == fieldID && item.STFieldColumnCommodityType == commodityType).ToList();
                if (collection != null && collection.Any())
                {
                    for (int index = collection.Count() - 1; index >= 0; index--)
                    {
                        BOSApp.LstFieldColumn.Remove(collection[index]);
                    }
                }
            }
        }

        public void AddSystemFieldColumns(List<STFieldColumnsInfo> collection)
        {
            if (BOSApp.LstFieldColumn != null && collection != null)
            {
                BOSApp.LstFieldColumn.AddRange(collection);
            }
        }
        public DateTime GetServerDate()
        {
            return BOSApp.MainScreen.ServerDate.AddSeconds(BOSApp.MainScreen.tickTimer);
        }

        public List<STFieldEventsInfo> GetSystemFieldEvents()
        {
            return BOSApp.LstFieldEvent;
        }
        public List<STFieldEventFunctionsInfo> GetSystemFieldEventFunctions()
        {
            return BOSApp.LstFieldEventFunc;
        }
        public List<AAColumnAliasInfo> GetSystemAlias()
        {
            return BOSApp.LstColumnAlias;
        }
        public string GetProductType(int ProductID)
        {
            if (BOSApp.CurrentProductList.Where(o => o.ICProductID == ProductID).FirstOrDefault() != null)
                return BOSApp.CurrentProductList.Where(o => o.ICProductID == ProductID).FirstOrDefault().ICProductType;
            else return string.Empty;
        }
        public List<STFieldPermissionsInfo> GetSystemFieldPermissions()
        {
            return BOSApp.LstFieldPermission;
        }
        public SortedList GetSystemFieldFormatGroup()
        {
            return BOSApp.FieldFormatGroups;
        }
        public SortedList GetSystemFieldColumnPermissions()
        {
            return BOSApp.LstFieldColumnPermissions;
        }
        public List<STFieldFormatGroupsInfo> GetSystemFieldFormatList()
        {
            return BOSApp.FieldFormatList;
        }
        /// <summary>
        /// Get the id of current user group that the logging-in user belongs to
        /// </summary>
        /// <returns>User group id</returns>
        public int GetCurrentUserGroupID()
        {
            return BOSApp.CurrentUserGroupInfo.ADUserGroupID;
        }

        /// <summary>
        /// Get data of a lookup table 
        /// </summary>
        /// <param name="lookupTableName">Lookup table name</param>
        /// <returns>Data of the lookup table</returns>
        public DataSet GetLookupTableData(string lookupTableName)
        {
            return BOSApp.GetLookupTableData(lookupTableName);
        }
        #endregion

        #region Accounting

        #endregion

        /// <summary>
        /// Check whether the module can switch to edit mode
        /// </summary>
        /// <returns>True if can, otherwise false</returns>
        public virtual bool IsEditable()
        {
            BarItem barItem = ParentScreen.GetToolbarButton(BaseToolbar.ToolbarButtonEdit);
            if (barItem != null && barItem.Visibility != BarItemVisibility.Never && barItem.Enabled)
            {
                if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Automatically switch module to edit mode whenever an object is changed
        /// </summary>
        /// <param name="obj">Business object is changed</param>
        /// <param name="strPropertyName">Property name whose value is changed</param>
        /// <returns>True if can switch module to edit mode, otherwise false</returns>
        public virtual bool SwitchToEditMode(BusinessObject obj, String strPropertyName)
        {
            if (IsEditable())
            {
                if (obj.AllowPropertyChangedEvent)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    if (String.IsNullOrEmpty(strPropertyName) || dbUtil.ColumnIsExist(BOSUtil.GetTableNameFromBusinessObject(obj), strPropertyName))
                    {
                        ActionEdit();
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Check whether the selected search objects is valid
        /// in a specified module's context
        /// </summary>
        /// <param name="tableName">Name of the table objects are searched in</param>
        /// <param name="objects">Selected objects</param>
        /// <returns>True if valid, otherwise false</returns>
        public virtual bool CheckSelectedSearchObjects(string tableName, object objects)
        {
            return true;
        }

        /// <summary>
        /// Show module by module name and id of document (receipt)
        /// </summary>
        /// <param name="strModuleName"></param>
        /// <param name="ID"></param>
        public virtual void ShowModule(String strModuleName, int ID)
        {
            BOSApp.ShowModule(strModuleName, ID);
        }
        //[NUThao] [ADD] [16/08/2013] [MultiLanguage for BOSGridControl va BOSLookupEdit], START

        public int GetCurrentLanguageID()
        {
            return BOSApp.CurrentLanguage.GELanguageID;
        }

        public bool IsForeignKey(String strTableName, String strColumnName)
        {
            if (strColumnName.Contains("FK_"))
                return true;

            string primaryTable = GetTreePrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
            if (primaryTable.IsNullOrWhiteSpace())
                return false;

            return true;
        }
        public String GetTreePrimaryTableWhichForeignColumnReferenceTo(String strForeignTableName, String strForeignColumnName)
        {
            return SqlDatabaseHelper.GetPrimaryTableWhichForeignColumnReferenceTo(strForeignTableName, strForeignColumnName);
        }

        public String GetTablePrimaryColumn(String strTableName)
        {
            return SqlDatabaseHelper.GetPrimaryKeyColumn(strTableName);
        }

        #region IBaseModuleERP Members
        public void AddSystemField(STFieldsInfo objFieldsInfo)
        {
            if (BOSApp.LstField != null && objFieldsInfo != null)
            {
                BOSApp.LstField.Add(objFieldsInfo);
            }
        }
        #endregion

        public virtual void ActionPrintTemplate()
        {
            ADTemplateToolbarsController controller = new ADTemplateToolbarsController();
            int toolbarID = BOSApp.ListToolbar.Where(o => o.STModuleID == this.ModuleID && o.STToolbarTag == this.ToolbarActionName).Select(o => o.STToolbarID).FirstOrDefault();
            int templateID = controller.GetTemplateIDByToolbarID(toolbarID);

            if (templateID == 0)
                return;
            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByID(templateID);
            if (objADTemplatesInfo == null)
                return;
            if (string.IsNullOrEmpty(objADTemplatesInfo.ADTemplateStoreProc))
                return;

            string rptFile = System.IO.Path.Combine("Reports", objADTemplatesInfo.ADTemplateNo + ".repx");
            BaseReport report = new BaseReport();
            guiReportPreview reviewer;
            bool bExists = System.IO.File.Exists(rptFile);
            if (!bExists)
            {
                if (MessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bạn có muốn thiết kế ?"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    reviewer = new guiReportPreview(report, rptFile, true);
                    reviewer.Show();
                    return;
                }
            }
            report.LoadLayout(rptFile);
            Utilities.XtraReportHelper.SetFormatField(report);

            String strMainTable = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            String strMainTablePrimaryColumn = strMainTable.Substring(0, strMainTable.Length - 1) + "ID";
            BOSDbUtil dbUtil = new BOSDbUtil();
            int mainObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, strMainTablePrimaryColumn));

            DataSet dataSource = SqlDatabaseHelper.RunStoredProcedure(objADTemplatesInfo.ADTemplateStoreProc, this.Name, mainObjectID);
            report.DataSource = dataSource;
            reviewer = new guiReportPreview(report, rptFile, true);
            reviewer.Show();
        }

        public void InvalidateItemProductPicture(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
            string productPictureColumn = item.GetType().Name.Substring(0, item.GetType().Name.Length - 5) + "ProductPicture";
            byte[] productPicture = (byte[])dbUtil.GetPropertyValue(item, productPictureColumn);
            if (productPicture != null)
                return;
            ApiClientHelper.GetProductPrimaryImage(productID, out productPicture);
            dbUtil.SetPropertyValue(item, productPictureColumn, productPicture);
        }
        /// <summary>
        /// Invalidate serie column with the corresponding item
        /// </summary>
        /// <param name="column">Grid column</param>
        /// <param name="item">Item</param>
        /// <param name="itemTableName">Table name of item</param>
        public virtual void InvalidateSerieColumn(GridColumn column, BusinessObject item, string itemTableName)
        {
            if (!SerialLookupEditTableNamesList.Contains(itemTableName))
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();

            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            String columnName = mainTableName.Substring(0, mainTableName.Length - 1) + "Date";
            DateTime date = Convert.ToDateTime(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, columnName));

            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");

            columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
            string desc = dbUtil.GetPropertyStringValue(item, columnName);

            columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "IsSpecificCalculation";
            bool isSpecificCalculation = Convert.ToBoolean(dbUtil.GetPropertyValue(item, columnName));

            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo == null)
                return;

            //RepositoryItemComboBox rep = new RepositoryItemComboBox();

            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.ValueMember = "ICProductSerieNo";
            rep.DisplayMember = "ICProductSerieNo";
            rep.NullText = String.Empty;
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.SearchMode = SearchMode.AutoFilter;

            LookUpColumnInfo colLKE = new LookUpColumnInfo();
            colLKE.FieldName = "ICProductSerieNo";
            AAColumnAliasInfo columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieNo").FirstOrDefault();
            colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption: "Mã lô/ kiện";
            colLKE.Width = 100;
            rep.Columns.Add(colLKE);

            colLKE = new LookUpColumnInfo();
            colLKE.FieldName = "ICInventoryStockQuantity";
            columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICInventoryStockQuantity").FirstOrDefault();
            colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Số lượng/ khối lượng";
            colLKE.Width = 100;
            rep.Columns.Add(colLKE);

            colLKE = new LookUpColumnInfo();
            colLKE.FieldName = "ICInventoryStockWoodQuantity";
            columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICInventoryStockWoodQuantity").FirstOrDefault();
            colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Số thanh/ tấm";
            colLKE.Width = 100;
            rep.Columns.Add(colLKE);

            colLKE = new LookUpColumnInfo();
            colLKE.FieldName = "ICProductSerieProductHeight";
            columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieProductHeight").FirstOrDefault();
            colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Dày";
            colLKE.Width = 100;
            rep.Columns.Add(colLKE);


            colLKE = new LookUpColumnInfo();
            colLKE.FieldName = "ICProductSerieProductWidth";
            columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieProductWidth").FirstOrDefault();
            colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Rộng";
            colLKE.Width = 100;
            rep.Columns.Add(colLKE);


            colLKE = new LookUpColumnInfo();
            colLKE.FieldName = "ICProductSerieProductLength";
            columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieProductLength").FirstOrDefault();
            colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Dài";
            colLKE.Width = 100;
            rep.Columns.Add(colLKE);

            if ((objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString() && isSpecificCalculation)
                || objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString())
            {
                List<ICProductSeriesInfo> series = objProductSeriesController.GetSeriesByProductIDAndStockID(productID, stockID, desc, date);
                if (series.Count > 0)
                {
                    series.Insert(0, new ICProductSeriesInfo());
                }

                //foreach (ICProductSeriesInfo serie in series)
                //{
                //    //rep.Items.Add(serie.ICProductSerieNo);
                //}
                rep.DataSource = series;
            }
            rep.BestFitMode = BestFitMode.BestFitResizePopup;
            rep.BestFit();
            
            column.ColumnEdit = rep;
        }

        public virtual void InvalidateLotColumn(GridColumn column, BusinessObject item, string itemTableName)
        {
            if (!SerialLookupEditTableNamesList.Contains(itemTableName))
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();

            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            String columnName = mainTableName.Substring(0, mainTableName.Length - 1) + "Date";
            DateTime date = Convert.ToDateTime(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, columnName));

            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");

            columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
            string desc = dbUtil.GetPropertyStringValue(item, columnName);

            columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "IsSpecificCalculation";
            bool isSpecificCalculation = Convert.ToBoolean(dbUtil.GetPropertyValue(item, columnName));

            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo == null)
                return;

            RepositoryItemComboBox rep = new RepositoryItemComboBox();
            if ((objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString() && isSpecificCalculation)
                || objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString())
            {

                List<ICProductSeriesInfo> series = objProductSeriesController.GetSeriesByProductIDAndStockID(productID, stockID, desc, date);
                series = series.Where(o1 => !string.IsNullOrEmpty(o1.ICProductSerieLotNo))
                               .GroupBy(o1 => new { o1.ICProductSerieLotNo })
                               .Select(o1 => new ICProductSeriesInfo()
                               {
                                   ICProductSerieLotNo = o1.Key.ICProductSerieLotNo
                               })
                        .ToList();
                if (series.Count > 0)
                {
                    series.Insert(0, new ICProductSeriesInfo());
                }
                foreach (ICProductSeriesInfo serie in series)
                {
                    rep.Items.Add(serie.ICProductSerieLotNo);
                }
            }
            column.ColumnEdit = rep;
        }

        /// <summary>
        /// Invalidate item serie no
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="itemTableName">Table name of item</param>
        public virtual void InvalidateItemSerieNo(BusinessObject item, string itemTableName, string serieColumnName)
        {
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            BOSDbUtil dbUtil = new BOSDbUtil();
            int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
            dbUtil.SetPropertyValue(item, serieColumnName, string.Empty);
            dbUtil.SetPropertyValue(item, "FK_ICProductSerieID", 0);
        }

        public virtual void InvalidateItemLotNo(BusinessObject item, string itemTableName, string lotColumnName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            dbUtil.SetPropertyValue(item, lotColumnName, string.Empty);
        }

        public virtual void CheckValidateSerieNo(BusinessObject item, string itemTableName, string serieColumnName, bool isCheckInventory = true)
        {
            int userGroupID = BOSApp.CurrentUserGroupInfo.ADUserGroupID;
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            BOSDbUtil dbUtil = new BOSDbUtil();
            int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
            string serieNo = dbUtil.GetPropertyStringValue(item, serieColumnName);
            decimal productQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, itemTablePrefix + "ProductQty"));
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID) as ICProductsInfo;
            if (objProductsInfo == null)
                return;
            ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(productID, serieNo);
            if (serieNo.IsNullOrWhiteSpace())
            {
                dbUtil.SetPropertyValue(item, "FK_ICProductSerieID", 0);
                return;
            }
            if (objProductSeriesInfo == null)
            {
                if (objProductsInfo.ICProductType == ProductType.Verneer.ToString()
                       || objProductsInfo.ICProductType == ProductType.Roundwood.ToString()
                       || objProductsInfo.ICProductType == ProductType.Reuse.ToString()
                       || objProductsInfo.ICProductType == ProductType.Lumber.ToString()
                       || objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                {
                    MessageBox.Show(String.Format(CommonLocalizedResources.SerialNoNotExistMessage, CommonLocalizedResources.SerialNoText), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(String.Format(CommonLocalizedResources.SerialNoNotExistMessage, CommonLocalizedResources.LotNoText), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dbUtil.SetPropertyValue(item, serieColumnName, string.Empty);
                dbUtil.SetPropertyValue(item, "FK_ICProductSerieID", 0);
                return;
            }
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            String columnName = mainTableName.Substring(0, mainTableName.Length - 1) + "Date";
            DateTime date = Convert.ToDateTime(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, columnName));
            if (isCheckInventory)
            {
                ICTransactionsController objTransactionsController = new ICTransactionsController();
                decimal inventoryQty = objTransactionsController.GetInventoryStockQty(stockID, productID, serieNo, date);
                if (inventoryQty < productQty)
                {
                    MessageBox.Show(BaseLocalizedResources.NotEnoughSerialQtyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbUtil.SetPropertyValue(item, serieColumnName, string.Empty);
                    dbUtil.SetPropertyValue(item, "FK_ICProductSerieID", 0);
                    return;
                }
            }
            dbUtil.SetPropertyValue(item, serieColumnName, serieNo);
            dbUtil.SetPropertyValue(item, "FK_ICProductSerieID", objProductSeriesInfo.ICProductSerieID);
        }

        public ACLoanReceiptPaymentPlansInfo UpdateValueLoanReceiptPaymentPlanByIndex(ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo, int index, ACLoanReceiptsInfo mainObject, BOSList<ACLoanReceiptPaymentPlansInfo> LoanReceiptPaymentPlanList, bool actionUpdate)
        {
            //Dư nợ đầu kỳ
            if (!actionUpdate)
            {
                if (mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OriginalPaypal.ToString())
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = Math.Round((index == 0 ? mainObject.ACLoanReceiptAmount - mainObject.ACLoanReceiptOpeningPaidAmount :
                                                                                                  (LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualPaymentDate.Date == DateTime.MaxValue.Date ? LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanRootPayment
                                                                                                    : LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualRootPayment
                                                                                                  )
                                                                                            ), 0, MidpointRounding.AwayFromZero);
                else if (mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OutstandingDebtIncreasing.ToString())
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = Math.Round((index == 0 ? mainObject.ACLoanReceiptAmount - mainObject.ACLoanReceiptOpeningPaidAmount :
                                                                                                  (LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualPaymentDate.Date == DateTime.MaxValue.Date ? LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanRootPayment + LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanProfitsPayment
                                                                                                  : (LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActialProfitsPayment > 0 ? LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualRootPayment
                                                                                                  : LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualRootPayment + LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanProfitsPayment)
                                                                                                  )
                                                                                            ), 0, MidpointRounding.AwayFromZero);
            }
            else if (actionUpdate && index > 0)
            {
                if (mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OriginalPaypal.ToString())
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = Math.Round(((LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualPaymentDate.Date == DateTime.MaxValue.Date ? LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanRootPayment
                                                                                                    : LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualRootPayment
                                                                                                        )
                                                                                                    ), 0, MidpointRounding.AwayFromZero);
                else if (mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OutstandingDebtIncreasing.ToString())
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = Math.Round(((LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualPaymentDate.Date == DateTime.MaxValue.Date ? LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanRootPayment + LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanProfitsPayment
                                                                                                    : (LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActialProfitsPayment > 0 ? LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualRootPayment
                                                                                                    : LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanOpeningBalance - LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanActualRootPayment + LoanReceiptPaymentPlanList[index - 1].ACLoanReceiptPaymentPlanProfitsPayment)
                                                                                                        )
                                                                                                    ), 0, MidpointRounding.AwayFromZero);
            }
            if (index == mainObject.ACLoanReceiptLimit - 1)
                objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance;
            //Số ngày
            TimeSpan sp = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate.Date.Subtract(objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.Date);
            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay = Convert.ToInt32(sp.TotalDays) + 1;
            //Ngày trả kế hoạch
            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate;
            //Lãi nộp
            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment = Math.Round(objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance *
                                                                                    (mainObject.ACLoanReceiptInterestRate / 100) * (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay / 365)
                                                                                    , 2, MidpointRounding.AwayFromZero); ;
            //Số tiền nộp hàng tháng
            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment + objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment;
            return objLoanReceiptPaymentPlansInfo;
        }

        public virtual void FocusItemLookUp()
        {

        }

        public virtual void CallFunctionFromAnotherProject(IList selected, string ProductType)
        {

        }

        public virtual void SwitchBranch()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> objBranchsInfo = objBranchsController.GetAllBranchByUserPermission(BOSApp.CurrentUsersInfo.ADUserID, BOSApp.CurrentCompanyInfo.FK_BRBranchID, ModuleName.Branch, ADDataViewPermissionType.Module);
            if (objBranchsInfo == null)
                return;
            if (objBranchsInfo.Count() == 0)
                return;
            guiChooseBranch guiChooseBranch = new guiChooseBranch(BOSApp.CurrentCompanyInfo.FK_BRBranchID, objBranchsInfo);
            guiChooseBranch.Module = this;
            if (guiChooseBranch.ShowDialog() != DialogResult.OK)
                return;
            if (BOSApp.CurrentCompanyInfo.FK_BRBranchID == guiChooseBranch.SelectedBranch.BRBranchID)
                return;
            BOSApp.CurrentCompanyInfo.FK_BRBranchID = guiChooseBranch.SelectedBranch.BRBranchID;
            BOSApp.InitMainFormTitle();
            if (!BOSApp.CurrentCompanyInfo.CSCompanyIsShowDataByBranch)
                return;

            BOSProgressBar.Start("Hệ thống đang chuyển dữ liệu !");
            try
            {
                STModulesController modulesController = new STModulesController();
                BOSApp.RefreshLookupDataByBranch();
                for (int i = 0; i < BOSApp.OpenModules.Count; i++)
                {
                    BaseModuleERP module = (BaseModuleERP)BOSApp.OpenModules.GetByIndex(i);
                    STModulesInfo modulesInfo = (STModulesInfo)modulesController.GetObjectByName(module.Name);
                    if (modulesInfo.STModuleMain == 0)
                    {
                        module.ResetSearch();
                        module.Search();
                    }
                }
            }
            catch (Exception ex)
            {
                BOSProgressBar.Close();
            }
            BOSProgressBar.Close();
        }

        public virtual bool ActionCancelComplete()
        {
            bool isComplete = false;
            if (ObjectIsEditingByOtherUser(this.Name, Toolbar.CurrentObjectID))
            {
                return false;
            }
            if (!CheckLock())
            {
                return false;
            }
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    CurrentModuleEntity.SetPropertyChangeEventLock(false);
                    isComplete = CurrentModuleEntity.CancelCompleteTransaction();
                    scope.Complete();
                }
                catch (Exception e)
                {
                    scope.Dispose();
                    MessageBox.Show(e.Message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CurrentModuleEntity.SetPropertyChangeEventLock(true);
                }
            }

            if (isComplete)
            {
                ModuleAfterCancelCompleted();
            }

            return isComplete;
        }

        public virtual void ModuleAfterCancelCompleted()
        {

        }
    }
}
