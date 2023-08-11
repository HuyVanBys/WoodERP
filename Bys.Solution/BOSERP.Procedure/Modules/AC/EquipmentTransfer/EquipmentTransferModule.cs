using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentTransfer
{
    public class EquipmentTransferModule : BaseTransactionModule
    {
        #region Constants
        public const string EquipmentTransferItemGridControlName = "fld_dgcEquipmentTransferItems";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END


        #endregion
        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion
        public EquipmentTransferModule()
        {
            Name = ModuleName.EquipmentTransfer;
            CurrentModuleEntity = new EquipmentTransferEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[EquipmentTransferModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

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
        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    string query = base.GenerateSearchQuery(strTableName);
        //    int documentTypeID = GetDocumentTypeID();
        //    query += string.Format(" and FK_ACDocumentTypeID = {0}", documentTypeID);
        //    return query;
        //}
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
            int documentTypeID = GetDocumentTypeID();
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDocumentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objDocumentsController.GetDocumentListDataSetByListOfBranchIDForEquipmentTransfer(searchObject.ACDocumentNo,
                                                                                documentTypeID,
                                                                                searchObject.FK_HREmployeeID,
                                                                                searchObject.DocumentDateFrom,
                                                                                searchObject.DocumentDateTo,
                                                                                BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetDocumentListDataSetForEquipmentTransfer(searchObject.ACDocumentNo,
                                                            documentTypeID,
                                                            searchObject.FK_HREmployeeID,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.DocumentDateFrom,
                                                            searchObject.DocumentDateTo);
            }

            return ds;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.DieuChuyenCCDC.ToString());
            return documentTypeID;
        }

        /// <summary>
        /// Add an item to its list
        /// </summary>
        public void AddItemToList()
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)entity.ModuleObjects[TableName.ACEquipmentTransferItemsTableName];
            if (item.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                //ICProductsController objProductsController = new ICProductsController();
                //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                //if (objProductsInfo != null)
                //{
                //    item.FK_HREmployeeUserID= objProductsInfo.
                //}
                entity.EquipmentTransferItemList.AddObjectToList();
            }
        }

        /// <summary>
        /// Remove the selected item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            entity.EquipmentTransferItemList.RemoveSelectedRowObjectFromList();
        }

        /// <summary>
        /// Called when the user changes the serie of an equipment
        /// </summary>        
        /// <param name="item">Item contains the equipment</param>
        public void ChangeEquipmentSerie(ACEquipmentTransferItemsInfo currentItem, ACEquipmentTransferItemsInfo selectedProductSerie)
        {
            if (currentItem != null && selectedProductSerie != null)
            {
                EquipmentTransferEntities entity = CurrentModuleEntity as EquipmentTransferEntities;
                currentItem.FK_ICProductSerieID = selectedProductSerie.FK_ICProductSerieID;
                currentItem.ICProductSerieNo = selectedProductSerie.ICProductSerieNo;
                currentItem.ACEquipmentTransferItemQty = selectedProductSerie.ACEquipmentTransferItemRemainedQty;
                currentItem.ACEquipmentTransferItemRemainedQty = currentItem.ACEquipmentTransferItemQty;
                currentItem.EquipmentReceiptedQty = 0;
                //currentItem.EquipmentShippedQty = 0;
                currentItem.ACEquipmentTransferItemUnitPrice = selectedProductSerie.ACEquipmentTransferItemUnitPrice;
                currentItem.ACEquipmentTransferItemDepreciatedAmount = selectedProductSerie.ACEquipmentTransferItemDepreciatedAmount;
                currentItem.EquipmentRemainedAmount = selectedProductSerie.EquipmentRemainedAmount;
                currentItem.ItemKey = selectedProductSerie.ItemKey;
                currentItem.FK_ACEquipmentTransferItemID = selectedProductSerie.FK_ACEquipmentTransferItemID;
                currentItem.FK_ICEquipmentShipmentItemID = selectedProductSerie.FK_ICEquipmentShipmentItemID;
                currentItem.FK_ICProductIdentifiedEquipmentID = 0;

                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                ICProductSeriesController productSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo productSeriesInfo = (ICProductSeriesInfo)productSeriesController.GetObjectByID(selectedProductSerie.FK_ICProductSerieID);
                if (productSeriesInfo != null)
                {
                    currentItem.FK_ICModelID = productSeriesInfo.FK_ICModelID;
                    currentItem.FK_ICModelDetailID = productSeriesInfo.FK_ICModelDetailID;
                }
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */

                entity.EquipmentTransferItemList.GridControl.RefreshDataSource();
            }
            //ICProductsController objProductsController = new ICProductsController();
            //ICProductsInfo objProductsInfo = objProductsController.GetEquipmentByEquipmentIDAndSerieIDAndRoomID(item.FK_ICProductID, item.FK_ICProductSerieID, item.FK_HRFromRoomID);
            //if (objProductsInfo != null)
            //{
            //    item.ACEquipmentTransferItemQty = objProductsInfo.EquipmentReceiptedQty - objProductsInfo.EquipmentShippedQty;
            //    item.EquipmentReceiptedQty = objProductsInfo.EquipmentReceiptedQty;
            //    item.EquipmentShippedQty = objProductsInfo.EquipmentShippedQty;
            //    entity.EquipmentTransferItemList.GridControl.RefreshDataSource();
            //}
        }

        /// <summary>
        /// Check for valid shipped quantity of an item
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="qty">Shipped quantity</param>
        /// <returns>Empty string if valid, otherwise the error description</returns>
        public string CheckForValidShippedQty(ACEquipmentTransferItemsInfo item, decimal qty)
        {
            string errorMsg = string.Empty;
            if (qty > item.EquipmentReceiptedQty + item.ACEquipmentTransferItemQty)
            {
                errorMsg = EquipmentTransferLocalizedResources.ShippedQtyCannotBeGreaterThanReceiptedQtyMessage;
            }
            else
            {
                item.EquipmentReceiptedQty = item.EquipmentReceiptedQty + item.ACEquipmentTransferItemQty - qty;
                //item.ACEquipmentTransferItemRemainedQty = qty;
            }
            return errorMsg;
        }

        /// Change the selected item to the item list
        /// </summary>
        public void ChangeEquipmentQty(decimal newQty)
        {
            EquipmentTransferEntities entity = CurrentModuleEntity as EquipmentTransferEntities;
            ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)entity.ModuleObjects[TableName.ACEquipmentTransferItemsTableName];

            ACEquipmentTransferItemsInfo oldObj = null;
            ACEquipmentTransferItemsInfo currentObj = null;
            if (entity.EquipmentTransferItemList.BackupList != null)
                oldObj = entity.EquipmentTransferItemList.BackupList.FirstOrDefault(si => si.ACEquipmentTransferItemID == item.ACEquipmentTransferItemID);

            currentObj = entity.EquipmentTransferItemList.FirstOrDefault(et => et.ACEquipmentTransferItemID == item.ACEquipmentTransferItemID);
            if (currentObj != null)
            {
                if (oldObj == null)
                    currentObj.ACEquipmentTransferItemRemainedQty = newQty;
                else
                    currentObj.ACEquipmentTransferItemRemainedQty = oldObj.ACEquipmentTransferItemRemainedQty + (newQty - oldObj.ACEquipmentTransferItemQty);
            }
        }

        public override int ActionSave()
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            entity.EquipmentTransferItemList.EndCurrentEdit();
            foreach (ACEquipmentTransferItemsInfo item in entity.EquipmentTransferItemList)
            {

                if (item.FK_ICProductIdentifiedEquipmentID == 0)
                {
                    MessageBox.Show("Vui lòng chọn Mã định danh cho " + item.ICProductName, "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
                if (item.ACEquipmentTransferItemType == EquipmentTransferItemType.Receipt.ToString() || item.ACEquipmentTransferItemType == EquipmentTransferItemType.Shipment.ToString())
                {
                    if (item.FK_ICStockID == 0)
                    {
                        MessageBox.Show("Vui lòng chọn kho cho sản phẩm", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return 0;
                    }
                }
            }

            //ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            //ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            //foreach (ACEquipmentTransferItemsInfo item in entity.EquipmentTransferItemList)
            //{
            //    item.ACEquipmentTransferItemUnitPrice = objShipmentItemsController.GetEquipmentOriginalAmount(item.FK_ICProductID, item.FK_ICProductSerieID, item.FK_HRFromRoomID);
            //    item.ACEquipmentTransferItemDepreciatedAmount = objShipmentItemsController.GetEquipmentDepreciatedAmount(item.FK_ICProductID, item.FK_ICProductSerieID, item.FK_HRFromRoomID);
            //    item.EquipmentRemainedAmount = item.ACEquipmentTransferItemUnitPrice - item.ACEquipmentTransferItemDepreciatedAmount;
            //}
            return base.ActionSave();
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPEquipmentTransfer report = new RPEquipmentTransfer();
                InitEquipmentTransferReport(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            if (entity.EquipmentTransferItemList.Where(o => o.ACEquipmentTransferItemType == EquipmentTransferItemType.Shipment.ToString() || o.ACEquipmentTransferItemType == EquipmentTransferItemType.Receipt.ToString()).Count() > 0)
            {
                if (mainObject.ACDocumentID > 0)
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, true);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                    if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                    {
                        ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                                mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                        ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                                mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString());
                    }
                }
            }
        }
        /// <summary>
        /// Init an equipment transfer report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        /// <param name="equipmentTransferID">Equipment transfer id</param>
        private void InitEquipmentTransferReport(RPEquipmentTransfer report, int equipmentTransferID)
        {
            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            List<ACEquipmentTransferItemsInfo> items = objReportsController.GetItemsByEquipmentTransferID(equipmentTransferID);
            report.DataSource = items;
        }

        public List<ICProductIdentifiedEquipmentsInfo> GetIdentifiedEquipmentList()
        {
            List<ICProductIdentifiedEquipmentsInfo> identifiedEquipmentList = new List<ICProductIdentifiedEquipmentsInfo>();
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            EquipmentTransferEntities entity = CurrentModuleEntity as EquipmentTransferEntities;
            ACEquipmentTransferItemsInfo item = entity.EquipmentTransferItemList[entity.EquipmentTransferItemList.CurrentIndex];
            if (item != null)
            {
                identifiedEquipmentList = objProductIdentifiedEquipmentsController.GetItemByProductIDAndIdentifiedEquipmentStatus(item.FK_ICProductID, ProductIdentifiedEquipmentStatus.Using.ToString());

            }
            return identifiedEquipmentList;
        }
        public void ResetModelDetail(ACEquipmentTransferItemsInfo item)
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            List<ICModelDetailsInfo> ModelDetailsList = new List<ICModelDetailsInfo>();
            if (item != null)
            {
                ModelDetailsList = objModelDetailsController.GetModelDetailByModelID(item.FK_ICModelID);
            }
            if (ModelDetailsList.Count > 0)
            {
                item.FK_ICModelDetailID = ModelDetailsList.FirstOrDefault().ICModelDetailID;
            }
            else
            {
                item.FK_ICModelDetailID = 0;
            }
            entity.EquipmentTransferItemList.GridControl.RefreshDataSource();
        }
        public void ChangeIdentifiedEquipment(ACEquipmentTransferItemsInfo item)
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            if (item.FK_ICProductIdentifiedEquipmentID > 0)
            {
                ICProductIdentifiedEquipmentsController pieController = new ICProductIdentifiedEquipmentsController();
                ICProductIdentifiedEquipmentsInfo objProductIdentifiedEquipmentsInfo = (ICProductIdentifiedEquipmentsInfo)pieController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                if (objProductIdentifiedEquipmentsInfo != null)
                {
                    item.ACEquipmentTransferItemUnitPrice = objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentOriginalAmount;
                    item.EquipmentRemainedAmount = item.ACEquipmentTransferItemUnitPrice - objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount;
                    item.FK_HRFromRoomID = objProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomID;
                    item.FK_HRFromDepartmentID = objProductIdentifiedEquipmentsInfo.FK_HRDepartmentID;
                    item.FK_ACDepreciationCostAccountID = objProductIdentifiedEquipmentsInfo.FK_ACDepreciationCostAccountID;
                    item.FK_HREmployeeUserID = objProductIdentifiedEquipmentsInfo.FK_HREmployeeUserID;
                    item.FK_ICProductSerieID = objProductIdentifiedEquipmentsInfo.FK_ICProductSerieID;
                    item.FK_ACCostCenterID = objProductIdentifiedEquipmentsInfo.FK_ACCostCenterID;
                    item.FK_ACSegmentID = objProductIdentifiedEquipmentsInfo.FK_ACSegmentID;
                    item.ACEquipmentTransferItemDepreciatedAmount = objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount;
                }
            }
            entity.EquipmentTransferItemList.GridControl.RefreshDataSource();
        }

        public string GetDisplayTextForItemByItemKey(string itemKey)
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ACEquipmentTransferItemsInfo objEquipmentTransferItemsInfo = entity.EquipmentTransferItemList.FirstOrDefault(o => o.ItemKey == itemKey);
            if (objEquipmentTransferItemsInfo != null)
                return objEquipmentTransferItemsInfo.ICProductSerieNo;
            return string.Empty;
        }

        public void ActionNewFromEquipmentReceipt()
        {
            base.ActionNew();
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            List<ICProductIdentifiedEquipmentsInfo> dataList = objProductIdentifiedEquipmentsController.GetListByEquipmentTransferForReceipt();
            guiFind<ICProductIdentifiedEquipmentsInfo> guiFind = new guiFind<ICProductIdentifiedEquipmentsInfo>(TableName.ICProductIdentifiedEquipmentTableName, dataList, this, true);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                foreach (ICProductIdentifiedEquipmentsInfo item in guiFind.SelectedObjects)
                {
                    ACEquipmentTransferItemsInfo equipmentTransferItem = new ACEquipmentTransferItemsInfo();
                    entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                    equipmentTransferItem.FK_HRToRoomID = 0;
                    equipmentTransferItem.ACEquipmentTransferItemDepreciatedAmount = 0;
                    equipmentTransferItem.EquipmentRemainedAmount = 0;
                    equipmentTransferItem.ACEquipmentTransferItemQty = 1;
                    equipmentTransferItem.FK_ICProductIdentifiedEquipmentID = item.ICProductIdentifiedEquipmentID;
                    equipmentTransferItem.FK_ICProductID = item.FK_ICProductID;
                    equipmentTransferItem.ICProductNo = item.ICProductNo;
                    equipmentTransferItem.ICProductName = item.ICProductName;
                    equipmentTransferItem.FK_HRFromRoomID = item.FK_HRDepartmentRoomID;
                    equipmentTransferItem.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                    equipmentTransferItem.FK_ICProductSerieID = item.FK_ICProductSerieID;
                    equipmentTransferItem.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    equipmentTransferItem.ACEquipmentTransferItemUnitPrice = item.ICProductIdentifiedEquipmentOriginalAmount;
                    equipmentTransferItem.ACEquipmentTransferItemDepreciatedAmount = item.ICProductIdentifiedEquipmentDepriciatedAmount;
                    equipmentTransferItem.EquipmentRemainedAmount = item.ICProductIdentifiedEquipmentRemainAmount;
                    equipmentTransferItem.ACEquipmentTransferItemType = EquipmentTransferItemType.Receipt.ToString();
                    entity.EquipmentTransferItemList.Add(equipmentTransferItem);
                }
                entity.EquipmentTransferItemList.GridControl.RefreshDataSource();
            }
            else
                base.ActionCancel();
        }
        public void ActionNewFromEquipmentShipment()
        {
            base.ActionNew();
            EquipmentTransferEntities entity = (EquipmentTransferEntities)CurrentModuleEntity;
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            List<ICProductIdentifiedEquipmentsInfo> dataList = objProductIdentifiedEquipmentsController.GetListByEquipmentTransferForShipment();
            guiFind<ICProductIdentifiedEquipmentsInfo> guiFind = new guiFind<ICProductIdentifiedEquipmentsInfo>(TableName.ICProductIdentifiedEquipmentTableName, dataList, this, true);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                foreach (ICProductIdentifiedEquipmentsInfo item in guiFind.SelectedObjects)
                {
                    ACEquipmentTransferItemsInfo equipmentTransferItem = new ACEquipmentTransferItemsInfo();
                    entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                    equipmentTransferItem.FK_HRToRoomID = 0;
                    equipmentTransferItem.ACEquipmentTransferItemDepreciatedAmount = 0;
                    equipmentTransferItem.EquipmentRemainedAmount = 0;
                    equipmentTransferItem.ACEquipmentTransferItemQty = 1;
                    equipmentTransferItem.FK_ICProductIdentifiedEquipmentID = item.ICProductIdentifiedEquipmentID;
                    equipmentTransferItem.FK_ICProductID = item.FK_ICProductID;
                    equipmentTransferItem.FK_ICProductSerieID = item.FK_ICProductSerieID;
                    equipmentTransferItem.ICProductNo = item.ICProductNo;
                    equipmentTransferItem.ICProductName = item.ICProductName;
                    equipmentTransferItem.FK_HRFromRoomID = item.FK_HRDepartmentRoomID;
                    equipmentTransferItem.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                    equipmentTransferItem.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    equipmentTransferItem.ACEquipmentTransferItemUnitPrice = item.ICProductIdentifiedEquipmentOriginalAmount;
                    equipmentTransferItem.ACEquipmentTransferItemDepreciatedAmount = item.ICProductIdentifiedEquipmentDepriciatedAmount;
                    equipmentTransferItem.EquipmentRemainedAmount = item.ICProductIdentifiedEquipmentRemainAmount;
                    equipmentTransferItem.ACEquipmentTransferItemType = EquipmentTransferItemType.Shipment.ToString();
                    entity.EquipmentTransferItemList.Add(equipmentTransferItem);
                }
                entity.EquipmentTransferItemList.GridControl.RefreshDataSource();
            }
            else
                base.ActionCancel();
        }
    }
}
