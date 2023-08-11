using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSLib.Interfaces;
using BOSReport;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using Localization;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP
{
    public class BaseTransactionModule : BaseModuleERP
    {
        #region Variables
        private String MainTableName;
        private String MainTablePrefix;

        /// <summary>
        /// A variable indicates whether the toolbar is being invalidated
        /// </summary>
        private bool ToolbarIsInvalidated = false;

        /// <summary>
        /// A variable to keep a thread of getting inventory from centre
        /// The thread will be started whenever a transaction module is loaded
        /// </summary>
        private Thread GettingInventoryThread;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the inventory stocks gotten from centre,
        /// is used to view inventory quickly in a transaction
        /// </summary>

        private BOSList<ACDocumentEntrysInfo> DEList { get; set; }
        private BaseTransactionEntities Entity { get; set; }

        #endregion

        public BaseTransactionModule()
        {
            DEList = new BOSList<ACDocumentEntrysInfo>();
        }

        /// <summary>
        /// Call base.InitializeModule() and initialize additional info
        /// </summary>
        public override void InitializeModule()
        {
            base.InitializeModule();

            MainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            MainTablePrefix = MainTableName.Substring(0, MainTableName.Length - 1);

            if (this.Name != "AdvanceRefund")
            {
                InitEmployeeControls();

            }
            InitStatusControls();

            if (this.Name != "AdvanceRefund" && this.Name != "AccountingFormulaReport")
            {
                if (BOSApp.CurrentUsersInfo.FK_HREmployeeID > 0)
                {
                    //Set default employee to the transaction
                    SetDefaultEmployee();
                }
            }

            DisplayLabelText(CurrentModuleEntity.MainObject);

            BaseTransactionEntities entity = (BaseTransactionEntities)CurrentModuleEntity;
            entity.DefaultDocumentTypeID = GetDocumentTypeID();
            entity.DocumentTypeID = entity.DefaultDocumentTypeID;
            if (entity.DocumentEntryList.GridControl != null)
            {
                (entity.DocumentEntryList.GridControl as BaseDocumentEntryGridControl).InvalidateDataSource(entity.DocumentEntryList);
            }
        }

        /// <summary>
        /// Get inventory from centre in the context of another thread.
        /// Leave the main thread run normally 
        /// </summary>
        protected void StartGettingInventoryThread()
        {
            //NUThao [ADD] [08/04/2014] [DB centre] [Update Inventory issue], START
            //GettingInventoryThread = new Thread(new ThreadStart(GetInventoryFromCentre));
            //GettingInventoryThread.Priority = ThreadPriority.Normal;
            //GettingInventoryThread.Start();
            //NUThao [ADD] [08/04/2014] [DB centre] [Update Inventory issue], END
        }

        /// <summary>
        /// Get Employee by username
        /// </summary>
        public HREmployeesInfo GetEmployeeByUsername(string username)
        {
            ADUsersController objUsersController = new ADUsersController();
            ADUsersInfo objUsersInfo = (ADUsersInfo)objUsersController.GetObjectByName(username);
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo == null)
                objEmployeesInfo = new HREmployeesInfo();
            return objEmployeesInfo;
        }

        /// <summary>
        /// Get inventory from centre, allow a branch to be able to see
        /// the inventory of all other branches
        /// </summary>
        private void GetInventoryFromCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo centre = objBranchsController.GetCentre();
            if (centre != null && centre.BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                ICInvAdjustmentsController objInvAdjustmentsController = new ICInvAdjustmentsController();
                List<ICInvAdjustmentsInfo> invAdjustments = new List<ICInvAdjustmentsInfo>();
                try
                {
                    SqlDatabase database = BOSApp.CreateConnectionToBranch(centre.BRBranchID);
                    if (BOSApp.TestConnection(database))
                    {
                        ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                        DataSet ds = dbUtil.GetDataSet(database, "ICInventoryStocks_GetInventoryStocksByUserGroupID", BOSApp.CurrentUserGroupInfo.ADUserGroupID);
                        CentralInventoryStocks.Clear();
                        if (ds.Tables.Count > 0)
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)objInventoryStocksController.GetObjectFromDataRow(row);
                                CentralInventoryStocks.Add(objInventoryStocksInfo);
                            }
                        }

                        //Get inventory adjustments from centre to adjust at branch                        
                        ds = dbUtil.GetDataSet(database, "ICInvAdjustments_GetInvAdjustmentsByBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                        if (ds.Tables.Count > 0)
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                ICInvAdjustmentsInfo invAdjustment = (ICInvAdjustmentsInfo)objInvAdjustmentsController.GetObjectFromDataRow(row);
                                invAdjustments.Add(invAdjustment);
                            }
                        }
                        ds.Dispose();
                    }
                }
                catch (Exception)
                {

                }

                //Create inventory adjustments at branch first, then switch to the centre delete all 
                //the branch's adjustments. This ensures the integrity of the data                
                List<ICInvAdjustmentsInfo> transferredAdjustments = new List<ICInvAdjustmentsInfo>();
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                    ICProductsController objProductsController = new ICProductsController();
                    foreach (ICInvAdjustmentsInfo invAdjustment in invAdjustments)
                    {
                        if (objProductsController.IsExist(invAdjustment.FK_ICProductID))
                        {
                            ICInvAdjustmentsInfo transferredAdjustment = (ICInvAdjustmentsInfo)invAdjustment.Clone();

                            SynProductSerie(invAdjustment);

                            ICInvAdjustmentsInfo existingInvAdjustment = objInvAdjustmentsController.GetInvAdjustmentByStockIDAndProductIDAndSerieID(
                                                                                                            invAdjustment.FK_ICStockID,
                                                                                                            invAdjustment.FK_ICProductID,
                                                                                                            invAdjustment.FK_ICProductSerieID);
                            if (existingInvAdjustment != null)
                            {
                                invAdjustment.ICInvAdjustmentID = existingInvAdjustment.ICInvAdjustmentID;
                                objInvAdjustmentsController.UpdateObject(invAdjustment);
                            }
                            else
                            {
                                objInvAdjustmentsController.CreateObject(invAdjustment);
                            }
                            transferredAdjustments.Add(transferredAdjustment);
                        }
                    }
                    scope.Complete();
                }

                try
                {
                    SqlDatabase database = BOSApp.CreateConnectionToBranch(centre.BRBranchID);
                    if (BOSApp.TestConnection(database))
                    {
                        foreach (ICInvAdjustmentsInfo invAdjustment in transferredAdjustments)
                        {
                            dbUtil.ExecuteNonQuery(database, "ICInvAdjustments_Delete", invAdjustment.ICInvAdjustmentID);
                        }
                    }
                }
                catch (Exception)
                {

                }
                //NUThao [ADD] [08/04/2014] [DB centre] [Update Inventory issue], START
                ////Adjust inventory at branch
                //using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                //{
                //    invAdjustments = objInvAdjustmentsController.GetInvAdjustmentsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                //    foreach (ICInvAdjustmentsInfo invAdjustment in invAdjustments)
                //    {
                //        TransactionUtil.UpdateInventoryStock(
                //                                            invAdjustment.FK_ICProductID,
                //                                            invAdjustment.FK_ICStockID,
                //                                            invAdjustment.FK_ICProductSerieID,
                //                                            invAdjustment.ICInvAdjustmentQty,
                //                                            invAdjustment.ICInvAdjustmentUnitCost,
                //                                            TransactionUtil.cstInventoryReceipt);                        
                //    }                    
                //    objInvAdjustmentsController.DeleteByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                //    scope.Complete();
                //}
                //NUThao [ADD] [08/04/2014] [DB centre] [Update Inventory issue], END
            }
        }

        /// <summary>
        /// Init controls bound to employee info in the transaction's context
        /// </summary>
        private void InitEmployeeControls()
        {
            foreach (XtraTabPage page in ParentScreen.ScreenContainer.TabPages)
            {
                InitEmployeeControls(page.Controls);
            }
        }

        /// <summary>
        /// Init controls bound to employee info in the transaction's context
        /// </summary>
        /// <param name="controls">Given controls</param>
        private void InitEmployeeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                string dataMember = dbUtil.GetPropertyStringValue(ctrl, BOSScreen.cstDataMemberPropertyName);
                if (!string.IsNullOrEmpty(dataMember) && dataMember == "FK_HREmployeeID")
                {
                    if (ctrl.Tag == null || ctrl.Tag.Equals(BOSScreen.DataControl))
                    {
                        BOSLookupEdit lke = ctrl as BOSLookupEdit;
                        lke.Properties.ValueMember = "HREmployeeID";
                        lke.Properties.DisplayMember = "HREmployeeName";
                        if (BOSApp.CurrentUsersInfo.FK_HREmployeeID > 0)
                        {
                            lke.EditValue = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                            lke.Enabled = false;
                        }
                    }
                }

                if (ctrl.Controls.Count > 0)
                {
                    InitEmployeeControls(ctrl.Controls);
                }
            }
        }

        /// <summary>
        /// Init controls bound to the status of the transaction
        /// </summary>
        private void InitStatusControls()
        {
            foreach (XtraTabPage page in ParentScreen.ScreenContainer.TabPages)
            {
                InitStatusControls(page.Controls);
            }
        }

        /// <summary>
        /// Init controls bound to the status of the transaction
        /// </summary>
        /// <param name="controls">Control collection</param>
        private void InitStatusControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                string dataMember = dbUtil.GetPropertyStringValue(ctrl, BOSScreen.cstDataMemberPropertyName);
                if (!string.IsNullOrEmpty(dataMember) && dataMember.Contains("Status"))
                {
                    if (ctrl.Tag == null || ctrl.Tag.Equals(BOSScreen.DataControl))
                    {
                        BOSLookupEdit lke = ctrl as BOSLookupEdit;
                        lke.CloseUp += new CloseUpEventHandler(StatusLookupEdit_CloseUp);
                    }
                }

                if (ctrl.Controls.Count > 0)
                {
                    InitStatusControls(ctrl.Controls);
                }
            }
        }

        protected void StatusLookupEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (MessageBox.Show(CommonLocalizedResources.ConfirmChangeDocumentStatusMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    string dataMember = dbUtil.GetPropertyStringValue(lke, BOSScreen.cstDataMemberPropertyName);
                    ChangeObjectStatus(dataMember, e.Value.ToString());
                }
                else
                {
                    e.AcceptValue = false;
                }
            }
        }

        /// <summary>
        /// Change the status of the current main object
        /// </summary>
        /// <param name="dataMember">Data member represents the status property of the object</param>
        /// <param name="status">Selected status</param>
        protected virtual void ChangeObjectStatus(string dataMember, string status)
        {
            IBusinessController controller = BusinessControllerFactory.GetBusinessController(MainTableName + "Controller");
            if (controller != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                BusinessObject obj = (BusinessObject)CurrentModuleEntity.MainObject;
                dbUtil.SetPropertyValue(obj, dataMember, status);
                controller.UpdateObject(obj);
            }
        }

        /// <summary>
        /// Call base.ActionNew() and set additional info for a new transaction
        /// </summary>
        public override void ActionNew()
        {
            base.ActionNew();

            SetDefaultEmployee();
            GenerateAccountingData();
            DisplayLabelText(CurrentModuleEntity.MainObject);
        }

        public override int ActionSave()
        {
            SetValuesFromAccountingObject();

            BaseTransactionEntities entity = (BaseTransactionEntities)CurrentModuleEntity;

            int documentTypeID = GetDocumentTypeID();
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                if (entry.FK_ACDocumentTypeID == 0)
                {
                    entry.FK_ACDocumentTypeID = documentTypeID;
                }
            }
            ClearDocumentEntryList();

            return base.ActionSave();
        }

        /// <summary>
        /// Set values from the selected accounting object
        /// to the current document
        /// </summary>
        public virtual void SetValuesFromAccountingObject()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string mainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            string mainTablePrefix = mainTableName.Substring(0, 2);
            ACObjectsController objObjectsController = new ACObjectsController();
            string objectKey = dbUtil.GetPropertyStringValue(CurrentModuleEntity.MainObject, "ACObjectAccessKey");
            if (!string.IsNullOrEmpty(objectKey))
            {
                ACObjectsInfo obj = objObjectsController.GetObjectByAccessKey(objectKey);
                obj = objObjectsController.GetObjectByIDAndType(obj.ACObjectID, obj.ACObjectType);
                if (obj != null)
                {
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "FK_ACObjectID", obj.ACObjectID);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, mainTablePrefix + "ObjectType", obj.ACObjectType);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "ACObjectName", obj.ACObjectName);
                }
                else
                {
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "FK_ACObjectID", 0);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, mainTablePrefix + "ObjectType", string.Empty);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "ACObjectName", string.Empty);
                }
            }
            objectKey = dbUtil.GetPropertyStringValue(CurrentModuleEntity.MainObject, "ACAssObjectAccessKey");
            if (!string.IsNullOrEmpty(objectKey))
            {
                ACObjectsInfo obj = objObjectsController.GetObjectByAccessKey(objectKey);
                obj = objObjectsController.GetObjectByIDAndType(obj.ACObjectID, obj.ACObjectType);
                if (obj != null)
                {
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "FK_ACAssObjectID", obj.ACObjectID);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, mainTablePrefix + "AssObjectType", obj.ACObjectType);
                }
                else
                {
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "FK_ACAssObjectID", 0);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, mainTablePrefix + "AssObjectType", string.Empty);
                }
            }
        }

        /// <summary>
        /// Call base.Invalidate() and set additional info for the current transaction
        /// </summary>
        /// <param name="iObjectID"></param>
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            InvalidateEmployee();
            InvalidateAccountingObject();
            InvalidateAccountingEntries();
            DisplayLabelText(CurrentModuleEntity.MainObject);
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public override void InvalidateToolbar()
        {
            if (IsTransactionLocked())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton("EditAfterCompleting", false);
                ParentScreen.SetEnableOfToolbarButton("TakePayment", false);
                ParentScreen.SetEnableOfToolbarButton("EditPayment", false);
                ParentScreen.SetEnableOfToolbarButton("TransferDeposit", false);
            }
            else
            {
                if (!ToolbarIsInvalidated)
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    ParentScreen.SetEnableOfToolbarButton("EditAfterCompleting", true);
                    ParentScreen.SetEnableOfToolbarButton("TakePayment", true);
                    ParentScreen.SetEnableOfToolbarButton("EditPayment", true);
                    ParentScreen.SetEnableOfToolbarButton("TransferDeposit", true);
                    if (!Toolbar.IsNullOrNoneAction())
                    {
                        ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                        ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                    }
                    ToolbarIsInvalidated = true;
                    InvalidateToolbar();
                }
                else
                {
                    ToolbarIsInvalidated = false;
                }
            }
            InvalidateAccountingEntries();
            base.InvalidateToolbar();
        }

        /// <summary>
        /// Set default employee from the current user
        /// </summary>
        protected void SetDefaultEmployee()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "FK_HREmployeeID", BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            //HREmployeesController objEmployeesController = new HREmployeesController();
            //HREmployeesInfo objHREmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (BOSApp.CurrentUsersInfo.FK_HREmployeeID > 0)
            {
                try
                {
                    Image img = ApiClientHelper.GetEmployeeImages(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
                    Byte[] image = ApiClientHelper.ImageToByteArray(img);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, String.Format("{0}EmployeePicture", MainTablePrefix), image);
                    CurrentModuleEntity.UpdateMainObjectBindingSource();
                }
                catch (Exception) { }
            }
        }

        /// <summary>
        /// Invalidate employee
        /// </summary>
        protected void InvalidateEmployee()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int employeeID = dbUtil.GetPropertyIntValue(CurrentModuleEntity.MainObject, "FK_HREmployeeID");
            if (employeeID > 0)
            {
                try
                {
                    Image img = ApiClientHelper.GetEmployeeImages(employeeID);
                    Byte[] image = ApiClientHelper.ImageToByteArray(img);
                    dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, String.Format("{0}EmployeePicture", MainTablePrefix), image);
                    CurrentModuleEntity.UpdateMainObjectBindingSource();
                }
                catch (Exception) { }
            }
        }

        /// <summary>
        /// Show customer info of the current transaction
        /// </summary>
        protected virtual void ShowCustomerInfo()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ARCustomersController objCustomersController = new ARCustomersController();
            int customerID = Convert.ToInt32(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, "FK_ARCustomerID"));
            ARCustomersInfo objCustomersInfo = new ARCustomersInfo();
            if (!BOSApp.LookupTables.Contains("ARCustomers"))
                objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
            else
            {
                DataRow row = BOSApp.GetObjectFromCatche("ARCustomers", "ARCustomerID", customerID);
                if (row != null)
                    objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectFromDataRow(row);
            }
            if (objCustomersInfo != null)
                DisplayLabelText(objCustomersInfo);
        }

        /// <summary>
        /// Called when user changes the staff of the transaction
        /// </summary>
        public void ChangeStaff(object sender, EventArgs e)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
            if (lke != null && lke.EditValue != lke.OldEditValue)
            {
                if (Convert.ToInt32(lke.EditValue) > 0)
                {
                    try
                    {
                        Image img = ApiClientHelper.GetEmployeeImages(Convert.ToInt32(lke.EditValue));
                        Byte[] image = ApiClientHelper.ImageToByteArray(img);
                        dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, String.Format("{0}EmployeePicture", MainTablePrefix), image);
                        CurrentModuleEntity.UpdateMainObjectBindingSource();
                    }
                    catch (Exception) { }
                }
            }
        }

        /// <summary>
        /// Get document type id of the current document
        /// </summary>
        /// <returns>Document type id</returns>
        public virtual int GetDocumentTypeID()
        {
            return 0;
        }

        /// <summary>
        /// Get current document no
        /// </summary>
        /// <returns>The document no</returns>
        public virtual string GetCurrentDocumentNo()
        {
            string documentNo = string.Empty;
            if (Toolbar.CurrentObjectID > 0)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
                String objectNoColumnName = mainTableName.Substring(0, mainTableName.Length - 1) + "No";
                documentNo = dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, objectNoColumnName).ToString();
            }
            return documentNo;
        }

        /// <summary>
        /// Invalidate serie column with the corresponding item
        /// </summary>
        /// <param name="column">Grid column</param>
        /// <param name="item">Item</param>
        /// <param name="itemTableName">Table name of item</param>
        public override void InvalidateSerieColumn(GridColumn column, BusinessObject item, string itemTableName)
        {
            base.InvalidateSerieColumn(column, item, itemTableName);
        }

        /// <summary>
        /// Invalidate item serie no
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="itemTableName">Table name of item</param>
        public override void InvalidateItemSerieNo(BusinessObject item, string itemTableName, string serieColumnName)
        {
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            BOSDbUtil dbUtil = new BOSDbUtil();
            int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
            dbUtil.SetPropertyValue(item, serieColumnName, string.Empty);
            dbUtil.SetPropertyValue(item, "FK_ICProductSerieID", 0);
        }

        public override void CheckValidateSerieNo(BusinessObject item, string itemTableName, string serieColumnName, bool isCheckInventory = true)
        {
            int userGroupID = BOSApp.CurrentUserGroupInfo.ADUserGroupID;
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            BOSDbUtil dbUtil = new BOSDbUtil();
            int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
            string serieNo = dbUtil.GetPropertyStringValue(item, serieColumnName);
            decimal productQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, itemTablePrefix + "ProductQty"));
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductsController objProductController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo == null)
                return;

            ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(productID, serieNo);
            if (serieNo == string.Empty)
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
            String columnName = MainTableName.Substring(0, MainTableName.Length - 1) + "Date";
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

        public void ShowInventory(int productID, bool woodType, bool isRoundWood, string desc, int modelID, int modelDetailID)
        {
            //TNDLoc [ADD][28/12/2015][Popup Inventory],START
            ShowInventory(productID, desc, modelID, modelDetailID);
        }

        public override void ShowInventory(int productID, string desc, int modelID, int modelDetailID)
        {
            base.ShowInventory(productID, desc, modelID, modelDetailID);
        }

        public decimal StockQuantity(List<ICInventoryStocksInfo> inventoryStocks)
        {
            decimal StockQuantity = 0;
            StockQuantity = inventoryStocks.Sum(x => x.ICInventoryStockQuantity);
            return StockQuantity;
        }
        public ICInventoryStocksInfo SetStockQuantity(List<ICInventoryStocksInfo> inventoryStocks)
        {
            ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();
            objInventoryStocksInfo = inventoryStocks.FirstOrDefault();
            objInventoryStocksInfo.ICInventoryStockQuantity = StockQuantity(inventoryStocks);

            return objInventoryStocksInfo;
        }

        /// <summary>
        /// Calculate the quantity of a product based on its inventory components in a stock
        /// </summary>        
        /// <param name="inventory">Inventory data</param>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <returns>On-hand quantity of the product</returns>
        private decimal CalculateProductQtyByComponent(List<ICInventoryStocksInfo> inventoryStocks, int productID, int stockID)
        {
            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(productID);
            decimal productQty = Int32.MaxValue;
            foreach (ICProductComponentsInfo component in components)
            {
                decimal inventoryStockQty = inventoryStocks.Where(inv => inv.FK_ICProductID == component.FK_ICProductComponentChildID && inv.FK_ICStockID == stockID).Sum(inv => inv.ICInventoryStockQuantity);
                if (component.ICProductComponentQty > 0)
                {
                    decimal qty = Math.Floor(inventoryStockQty / component.ICProductComponentQty);
                    if (qty < productQty)
                    {
                        productQty = qty;
                    }
                }
            }
            if (productQty == Int32.MaxValue)
            {
                productQty = 0;
            }
            return productQty;
        }

        #region Accounting
        /// <summary>
        /// Invaldiate accounting object
        /// </summary>
        protected void InvalidateAccountingObject()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string mainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            string mainTablePrefix = mainTableName.Substring(0, 2);
            int objectID = dbUtil.GetPropertyIntValue(CurrentModuleEntity.MainObject, "FK_ACObjectID");
            string objectType = dbUtil.GetPropertyStringValue(CurrentModuleEntity.MainObject, mainTablePrefix + "ObjectType");
            dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "ACObjectAccessKey", string.Format("{0};{1}", objectID, objectType));

            objectID = dbUtil.GetPropertyIntValue(CurrentModuleEntity.MainObject, "FK_ACAssObjectID");
            objectType = dbUtil.GetPropertyStringValue(CurrentModuleEntity.MainObject, mainTablePrefix + "AssObjectType");
            dbUtil.SetPropertyValue(CurrentModuleEntity.MainObject, "ACAssObjectAccessKey", string.Format("{0};{1}", objectID, objectType));
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Invalidate accounting entries of all documents relating to the transaction
        /// </summary>
        protected virtual void InvalidateAccountingEntries()
        {
            BaseTransactionEntities entity = (BaseTransactionEntities)CurrentModuleEntity;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            string documentNo = GetCurrentDocumentNo();

            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            entries = objDocumentEntrysController.GetAccountingEntries(this.Name, 0, documentNo);
            entity.DocumentEntryList.Invalidate(entries);
            entity.DocumentEntryList.GridControl?.RefreshDataSource();
        }

        /// <summary>
        /// Generate accounting data, includes documents, entries relating to
        /// the current transaction
        /// </summary>
        public virtual void GenerateAccountingData()
        {

        }

        /// <summary>
        /// Generate accounting data, includes documents, entries relating to
        /// the current transaction
        /// </summary>
        /// <param name="documentTypes">Types of generated documents</param>
        public void GenerateAccountingData(string[] documentTypes)
        {
            BaseTransactionEntities entity = (BaseTransactionEntities)CurrentModuleEntity;
            entity.DocumentList.Clear();

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            List<ACDocumentEntrysInfo> documentEntries = new List<ACDocumentEntrysInfo>();
            foreach (string documentType in documentTypes)
            {
                int documentTypeID = objDocumentTypesController.GetObjectIDByName(documentType);
                ACDocumentsInfo objDocumentsInfo = new ACDocumentsInfo();
                objDocumentsInfo.FK_ACDocumentTypeID = documentTypeID;
                objDocumentsInfo.ACDocumentTypeName = documentType;
                entity.DocumentList.Add(objDocumentsInfo);

                List<ACDocTypeEntrysInfo> entries = objDocTypeEntrysController.GetEntriesByDocumentType(documentType);
                foreach (ACDocTypeEntrysInfo entry in entries)
                {
                    AccountHelper.AddItemToDocumentEntryList(entry, documentEntries);
                }
            }
            entity.DocumentEntryList.Invalidate(documentEntries);
        }

        /// <summary>
        /// Update all accounting entries relating to the transaction        
        /// </summary>
        protected virtual void UpdateDocumentEntries()
        {

        }
        #endregion

        public override bool IsEditable()
        {
            bool isEditable = base.IsEditable();
            if (isEditable)
            {
                isEditable = !IsTransactionLocked();
            }
            return isEditable;
        }

        /// <summary>
        /// Check whether the transaction is locked
        /// </summary>
        /// <returns>True if the transaction is locked, otherwise false</returns>
        protected virtual bool IsTransactionLocked()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            object value = dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, MainTablePrefix + "Date");
            if (value != null)
            {
                STModulePostingsInfo postExit = (new STModulePostingsController()).GetObjectByModuleName(CurrentModuleEntity.Module.Name);
                if (postExit == null || string.IsNullOrEmpty(postExit.STModulePostingStockFunction))
                    return false;

                DateTime transactionDate = Convert.ToDateTime(value);
                ADLocksController objLocksController = new ADLocksController();
                ADLocksInfo lockInfo = objLocksController.GetActiveLockByDate(transactionDate);
                if (lockInfo != null)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Update Document Entry when add a product
        /// </summary>
        /// <param name="accountID">AccountID of product</param>
        /// <param name="totalAmount">amount</param>
        /// <param name="entity">current entity</param>
        public void UpdateDocumentEntryList(int accountID, decimal totalAmount, BaseTransactionEntities entity, decimal exchangeRate)
        {
            Entity = entity;
            bool swap = false;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objDefaultAccount = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccountDefault.DefaultAccount.ToString());
            if (accountID == 0)
            {
                accountID = objDefaultAccount.ACAccountID;
            }

            ACDocumentEntrysInfo obj = entity.DocumentEntryList.Where(p => p.FK_ACDebitAccountID == accountID).FirstOrDefault();

            if (obj == null)
            {
                obj = entity.DocumentEntryList.Where(p => p.FK_ACCreditAccountID == accountID).FirstOrDefault();
                if (obj == null)
                {
                    obj = entity.DocumentEntryList.Where(p => p.FK_ACCreditAccountID == objDefaultAccount.ACAccountID).FirstOrDefault();
                    ACDocumentEntrysInfo objNewDocumentEntrysInfo = new ACDocumentEntrysInfo();
                    if (obj == null)
                    {
                        obj = entity.DocumentEntryList.Where(p => p.FK_ACDebitAccountID == objDefaultAccount.ACAccountID).FirstOrDefault();
                        BOSUtil.CopyObject(obj, objNewDocumentEntrysInfo);
                        objNewDocumentEntrysInfo.FK_ACDebitAccountID = accountID;
                        objNewDocumentEntrysInfo.FK_ACCreditAccountID = obj.FK_ACCreditAccountID;
                    }
                    else
                    {
                        BOSUtil.CopyObject(obj, objNewDocumentEntrysInfo);
                        objNewDocumentEntrysInfo.FK_ACDebitAccountID = obj.FK_ACDebitAccountID;
                        objNewDocumentEntrysInfo.FK_ACCreditAccountID = accountID;
                    }
                    objNewDocumentEntrysInfo.ACDocumentEntryDesc = obj.ACDocumentEntryDesc;
                    if (!swap)
                    {
                        objNewDocumentEntrysInfo.ACDocumentEntryAmount = totalAmount;
                        objNewDocumentEntrysInfo.ACDocumentEntryExchangeAmount = totalAmount * exchangeRate;
                    }
                    else
                    {
                        objNewDocumentEntrysInfo.ACDocumentEntryAmount = totalAmount / exchangeRate;
                        objNewDocumentEntrysInfo.ACDocumentEntryExchangeAmount = totalAmount;
                    }
                    objNewDocumentEntrysInfo.ACEntryTypeName = obj.ACEntryTypeName;
                    int index = entity.DocumentEntryList.IndexOf(obj);
                    entity.DocumentEntryList.Insert(index, objNewDocumentEntrysInfo);
                }
                else
                {
                    if (!swap)
                    {
                        obj.ACDocumentEntryAmount += totalAmount;
                        obj.ACDocumentEntryExchangeAmount = obj.ACDocumentEntryAmount * exchangeRate;
                    }
                    else
                    {
                        obj.ACDocumentEntryAmount += totalAmount / exchangeRate;
                        obj.ACDocumentEntryExchangeAmount += totalAmount;
                    }
                }
            }
            else
            {
                if (!swap)
                {
                    obj.ACDocumentEntryAmount += totalAmount;
                    obj.ACDocumentEntryExchangeAmount = obj.ACDocumentEntryAmount * exchangeRate;
                }
                else
                {
                    obj.ACDocumentEntryAmount += totalAmount / exchangeRate;
                    obj.ACDocumentEntryExchangeAmount += totalAmount;
                }
            }
            if (DEList.IndexOf(obj) == -1)
            {
                DEList.Add(obj);
            }
        }

        /// <summary>
        /// delete an account with amount = 0
        /// </summary>
        private void ClearDocumentEntryList()
        {
            if (DEList == null || DEList.Count == 0) return;
            bool nullValue = true;
            while (nullValue)
            {
                nullValue = false;
                ACAccountsController objAccountsController = new ACAccountsController();
                ACAccountsInfo objDefaultAccount = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccountDefault.DefaultAccount.ToString());
                foreach (var item in DEList)
                {
                    if (item.ACDocumentEntryAmount == 0)
                    {
                        if (item.FK_ACCreditAccountID == objDefaultAccount.ACAccountID ||
                            item.FK_ACDebitAccountID == objDefaultAccount.ACAccountID)
                            Entity.DocumentEntryList.Remove(item);
                        DEList.Remove(item);
                        nullValue = true;
                        break;
                    }
                }
            }
        }
        public decimal ShowInventoryTotalQty(int productID)
        {
            decimal availableQty = 0;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                int userGroupID = BOSApp.CurrentUserGroupInfo.ADUserGroupID;
                List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndStockID(productID, null, null, userGroupID);
                inventoryStocks = inventoryStocks.Union(objInventoryStocksController.GetInventoryStocksByProductIDAndStockID(productID, null)).ToList();
                if (inventoryStocks == null)
                    return 0;
                decimal onHandQty = inventoryStocks.Where(i => i.ICStockType == StockType.Sale.ToString() || i.ICStockType == StockType.Central.ToString())
                                                    .Sum(i => i.ICInventoryStockQuantity);
                decimal saleOrderQty = inventoryStocks.Where(i => i.ICStockType == StockType.SaleOrder.ToString())
                                                    .Sum(i => i.ICInventoryStockQuantity);
                decimal purchaseOrderQty = inventoryStocks.Where(i => i.ICStockType == StockType.Purchase.ToString())
                                                    .Sum(i => i.ICInventoryStockQuantity);
                decimal woodPlanQty = inventoryStocks.Where(i => i.ICStockType == StockType.AllocationPlan.ToString())
                                                    .Sum(i => i.ICInventoryStockQuantity);
                decimal transitInQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.TransitIn.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
                decimal transitOutQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.TransitOut.ToString())
                                                    .Sum(i => i.ICInventoryStockQuantity);
                availableQty = (onHandQty + purchaseOrderQty + transitInQty + transitOutQty) - (saleOrderQty + woodPlanQty);
            }
            return availableQty;
        }
        public bool CheckQtyInReceiptItem(BOSItemsEntityList<ICShipmentItemsInfo> ListObject)
        {
            bool flag = true;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<string> listItemID = ListObject.Where(o => o.FK_ICReceiptItemID > 0).Select(o => o.FK_ICReceiptItemID.ToString()).Distinct().ToList();
            if (listItemID == null) return flag;
            List<ICReceiptItemsInfo> listReceiptItem = objReceiptItemsController.GetReceiptItemByListItemID(string.Join(",", listItemID.ToArray()));
            string mess = string.Empty;
            foreach (ICShipmentItemsInfo item in ListObject)
            {
                if (item.FK_ICReceiptItemID > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = listReceiptItem.Where(r => r.Id == item.FK_ICReceiptItemID).FirstOrDefault();
                    if (objReceiptItemsInfo != null)
                    {
                        if (item.ICShipmentItemProductQty > objReceiptItemsInfo.ICReceiptItemProductQty)
                        {
                            flag = false;
                            mess += Environment.NewLine + "Sản phẩm: " + item.ICShipmentItemProductDesc + ". Lô:  " + item.ICShipmentItemProductSerialNo + "SL nhập: " + objReceiptItemsInfo.ICReceiptItemProductQty;
                        }
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show(mess + Environment.NewLine + "Số lượng của sản phẩm vượt quá số lượng phiếu nhập kho. Vui lòng kiểm tra lại."
                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return flag;
        }
        public bool CheckQtyInShipmentItem(BOSItemsEntityList<ICReceiptItemsInfo> ListObject)
        {
            bool flag = true;
            decimal qty = 0;
            string messError = string.Empty;
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            List<ICProductGroupsInfo> listProductGroups = objProductGroupsController.GetProductGroupByDepartmentID(DepartmentID.Wood);
            ICProductGroupsInfo objProductGroupsInfo = listProductGroups.Where(o => o.ICProductGroupName == "Gỗ tận dụng").FirstOrDefault();
            foreach (ICReceiptItemsInfo item in ListObject)
            {
                if (item.FK_ICShipmentItemID > 0)
                {
                    objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                    if (objProductGroupsInfo != null)
                    {
                        if (objProductsInfo.FK_ICProductGroupID == objProductGroupsInfo.ICProductGroupID) continue;
                    }    
                    objShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemsController.GetObjectByID(item.FK_ICShipmentItemID);
                    if (objShipmentItemsInfo != null)
                    {
                        qty = objShipmentItemsInfo.ICShipmentItemProductQty;
                        decimal tepm = ListObject.Where(x => x.FK_ICShipmentItemID == item.FK_ICShipmentItemID).Sum(y => y.ICReceiptItemProductQty);

                        if (tepm > qty)
                        {
                            flag = false;
                            MessageBox.Show("Số lượng/khối lượng của sản phẩm  " + item.ICReceiptItemProductDesc
                                + " có mã lô/mã đầu lóng  " + item.ICReceiptItemProductSerialNo
                                + " không thể vượt quá số lượng/khối lượng của phiếu xuất kho." +
                                " Vui lòng kiểm tra lại.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                            && !objProductsInfo.IsAsset
                            && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString())
                        {
                            if ((item.ICReceiptItemProductUnitCost != objShipmentItemsInfo.ICShipmentItemProductUnitCost
                            || item.FK_ICProductAttributeQualityID != objShipmentItemsInfo.FK_ICProductAttributeQualityID)
                            && item.ICReceiptItemProductSerialNo == objShipmentItemsInfo.ICShipmentItemProductSerialNo)
                            {
                                messError += Environment.NewLine + item.ICReceiptItemProductSerialNo + ": " + item.ICReceiptItemProductName;
                            }
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(messError))
            {
                MessageBox.Show("Giá trị hoặc chất lượng đã thay đổi." + Environment.NewLine + "Vui lòng thay đổi mã lô/ mã kiện của các sản phẩm sau:" + messError);
                flag = false;
            }

            return flag;

        }
        public int GetAccountByStock(int stockID, int currentAccount)
        {
            int account = 0;
            ICStocksInfo objStocksInfo = new ICStocksInfo();
            ICStocksController objStocksController = new ICStocksController();
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            DataRow row = BOSApp.GetObjectFromCatche("ICStocks", "ICStockID", stockID);
            if (row != null)
                objStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(row);
            if (objStocksInfo != null)
            {
                if (objStocksInfo.FK_ACAccountID > 0)
                {
                    account = objStocksInfo.FK_ACAccountID;
                    return account;
                }
            }
            if (account > 0)
                return account;
            else
                return currentAccount;

        }

        public void CheckPackNo(ICReceiptsInfo item)
        {
            if (string.IsNullOrEmpty(item.ICReceiptPackNo))
            {
                item.ICReceiptPackNo = App.DefaultPackNo;
            }

        }

        public List<ICProductsInfo> ChooseProductWork()
        {
            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> productWorkList = productController.GetWorkForSaleOrder();
            List<ICProductsInfo> productWorkSelectedList = new List<ICProductsInfo>();
            guiFind<ICProductsInfo> guiFind = new guiFind<ICProductsInfo>(TableName.ICProductsTableName
                                                                            , productWorkList
                                                                            , this
                                                                            , true);
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                productWorkSelectedList.AddRange(guiFind.SelectedObjects);
            }
            return productWorkSelectedList;
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

        protected override bool HasCompletePermission()
        {
            BusinessObject item = CurrentModuleEntity.MainObject as BusinessObject;
            BOSDbUtil dbUtil = new BOSDbUtil();
            string tableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            string strPrimaryColumn = BOSApp.GetTablePrimaryColumn(tableName);
            int iObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(item, strPrimaryColumn));
            return (new ADCompletePermissionConfigsController()).CheckCompletePermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID, this.Name, tableName, strPrimaryColumn, iObjectID);
        }

        public void ViewReportByTemplate(String templateNo, String storeProc, object[] arParam)
        {
            string rptFile = System.IO.Path.Combine("Reports", templateNo + ".repx");
            BaseReport report = new BOSReport.BaseReport();
            if (System.IO.File.Exists(rptFile))
            {
                report.LoadLayout(rptFile);
                Utilities.XtraReportHelper.SetFormatField(report);
                if (!string.IsNullOrEmpty(storeProc))
                {
                    try
                    {
                        report.DataSource = SqlDatabaseHelper.RunStoredProcedure(storeProc, arParam);
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Lỗi thiết lập tham số cho {0}!\n{1}", ex.Message));
                        return;
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Yêu cầu cung cấp store");
                    return;
                }
                guiReportPreview reviewer = new guiReportPreview(report, rptFile, true);
                reviewer.Show();
            }
            else if (DevExpress.XtraEditors.XtraMessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bắt đầu thiết kế mới?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                guiReportDesigner designer = new guiReportDesigner(report, rptFile);
                designer.Show();
            }
        }

        public override void FocusItemLookUp()
        {
            base.FocusItemLookUp();
        }

        public virtual void ChangeDisplayColumnByWoodType(BOSGridControl gridControl, bool isWoodType)
        {
            if (gridControl == null)
                return;
            GridView gridView = (GridView)gridControl.MainView;
            if (gridView == null)
                return;
            GridColumn serialColumn = gridView.Columns.FirstOrDefault(o1 => o1.FieldName.EndsWith("ProductSerialNo"));
            if (serialColumn != null)
            {
                serialColumn.Caption = isWoodType ? CommonLocalizedResources.SerialNoText : BaseLocalizedResources.ProductSerieNo;
            }
            GridColumn column = gridView.Columns.FirstOrDefault(o1 => o1.FieldName.EndsWith("ProductQty"));
            if (column != null)
            {
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = this.GetColumnFormat(gridControl.BOSDataSource, column.FieldName, this.ModuleID);
                
                    column.OptionsColumn.AllowEdit = true;
                if (isWoodType)
                    column.Caption = "Khối lượng";
                else
                    column.Caption = "Số lượng";
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = objFieldFormatGroupsInfo != null && string.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFormatString) ? objFieldFormatGroupsInfo.STFieldFormatGroupFormatString : "{0:n5}";
            }
            column = gridView.Columns.FirstOrDefault(o1 => o1.FieldName.EndsWith("WoodQty"));
            if (column != null)
            {
                if (isWoodType)
                {
                    column.Caption = "Số lượng thanh (tấm)";
                    column.Visible = true;
                }   
                else
                {
                    column.Caption = string.Empty;
                    column.Visible = false;
                }
            }
            GridColumn lotColumn = gridView.Columns.FirstOrDefault(o1 => o1.FieldName.EndsWith("LotNo"));
            if (lotColumn == null)
            {
                string tableName = gridControl.BOSDataSource;
                string lotNoColumnName = tableName.Substring(0, tableName.Length - 1) + "LotNo";
                lotColumn = new GridColumn();
                lotColumn.FieldName = lotNoColumnName;
                lotColumn.Caption = CommonLocalizedResources.LotNoText;
                if (isWoodType)
                {
                    gridView.Columns.Add(lotColumn);
                    lotColumn.VisibleIndex = serialColumn != null ? serialColumn.VisibleIndex : 999;
                }
                else
                    gridView.Columns.Remove(lotColumn);
            }
            if (isWoodType)
            {
                if (BOSApp.ModulesListApplyValidateSerial.Contains(this.Name))
                {
                    lotColumn.OptionsColumn.AllowEdit = false;
                }
                else if (this.Name == ModuleName.ReturnSupplier)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    BaseTransactionEntities entity = (BaseTransactionEntities)CurrentModuleEntity;
                    string createType = dbUtil.GetPropertyStringValue(entity.MainObject, "APReturnSupplierTypeCombo");
                    if (createType != ReturnSupplierType.FromReceipt.ToString())
                    {
                        lotColumn.OptionsColumn.AllowEdit = false;
                    }
                }
                else
                    lotColumn.OptionsColumn.AllowEdit = true;
            }
            if (!isWoodType && lotColumn != null)
            {
                gridView.Columns.Remove(lotColumn);
            }
        }

        public void SetQtyColumnFormat(BOSGridControl gridControl, bool isWoodType, List<string> columnsList)
        {
            //if (gridControl == null)
            //    return;
            //GridView gridView = (GridView)gridControl.MainView;
            //if (gridView == null)
            //    return;

            //columnsList.ForEach(o1 =>
            //{
                //GridColumn column = gridView.Columns[o1];
                //if (column != null)
                //{
                //    STFieldFormatGroupsInfo objFieldFormatGroupsInfo = this.GetColumnFormat(gridControl.BOSDataSource, column.FieldName, this.ModuleID);
                //    if (isWoodType)
                //    {
                //        ChangeQtyColumnFormat(column, objFieldFormatGroupsInfo != null && string.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFormatString) ? objFieldFormatGroupsInfo.STFieldFormatGroupFormatString: "{0:n5}");
                //    }
                //    else
                //    {
                //        ChangeQtyColumnFormat(column, "n3");
                //    }
                //}
            //});
        }

        public void ChangeQtyColumnFormat(GridColumn column, string formatType)
        {
            if (column == null)
                return;

            DevExpress.XtraEditors.Repository.RepositoryItem rep = column.ColumnEdit;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText = (DevExpress.XtraEditors.Repository.RepositoryItemTextEdit)rep;

            repText.Mask.EditMask = formatType;
            repText.Mask.UseMaskAsDisplayFormat = true;

            repText.DisplayFormat.FormatString = formatType;
        }
    }
}
