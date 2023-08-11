using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.MergeBOMChange
{
    public class MergeBOMChangeModule : BaseTransactionModule
    {
        #region Constants
        public const string ChangeLogLookUpEditControlName = "fld_lkeFK_MMProductionNormApproveLogID";
        public const string BatchProductLookUpEditControlName = "fld_lkeMMBatchProductID";
        public const string ItemBOMGridControlName = "fld_dgcMMMergeBOMChangeItemBOMLogs";
        public const string ItemBPGridControlName = "fld_dgcMMMergeBOMChangeItemBPLogs";
        #endregion Constants

        #region Private Properties
        public BOSLookupEdit ChangeLogLookUpEdit;
        public BOSLookupEdit BatchProductLookUpEdit;
        public BOSGridControl ItemBOMGridControl;
        public BOSGridControl ItemBPGridControl;
        List<MMMergeBOMChangeColumnsInfo> ColumnList;
        Dictionary<string, GridColumn> ColumnDefaultList;
        #endregion Private Properties

        public MergeBOMChangeModule()
        {
            Name = "MergeBOMChange";
            CurrentModuleEntity = new MergeBOMChangeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            ChangeLogLookUpEdit = (BOSLookupEdit)Controls[ChangeLogLookUpEditControlName];
            ChangeLogLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(ChangeLogLookUpEdit_QueryPopUp);

            BatchProductLookUpEdit = (BOSLookupEdit)Controls[BatchProductLookUpEditControlName];
            BatchProductLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(BatchProductLookUpEdit_QueryPopUp);

            ItemBOMGridControl = (BOSGridControl)Controls[ItemBOMGridControlName];
            ItemBPGridControl = (BOSGridControl)Controls[ItemBPGridControlName];

            InitGridColumnDic();
            InitColumnDefaultList();
        }

        public void InitColumnDefaultList()
        {
            ColumnDefaultList = new Dictionary<string, GridColumn>();

            Dictionary<string, List<BusinessObject>> tableLookUp = new Dictionary<string, List<BusinessObject>>();

            GridColumn col;
            RepositoryItemBOSLookupEdit repositoryItemLookUpEdit;
            List<BusinessObject> objectList;

            foreach (MMMergeBOMChangeColumnsInfo colInfo in ColumnList)
            {
                if (!ColumnDefaultList.Keys.Contains(colInfo.MMColumnName))
                {
                    col = new GridColumn();

                    if (!string.IsNullOrEmpty(colInfo.MMTableLookUp))
                    {
                        repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                        repositoryItemLookUpEdit.DisplayMember = colInfo.MMTableLookUpDisplayColumn;
                        repositoryItemLookUpEdit.ValueMember = colInfo.MMTableLookUpValueColumn;
                        repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                        repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                        repositoryItemLookUpEdit.NullText = string.Empty;
                        repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(colInfo.MMTableLookUpDisplayColumn, colInfo.MMColumnCaption));

                        if (tableLookUp.Keys.Contains(colInfo.MMTableLookUp))
                        {
                            objectList = tableLookUp[colInfo.MMTableLookUp];
                        }
                        else
                        {
                            IBusinessController objItemController = BusinessControllerFactory.GetBusinessController(colInfo.MMTableLookUp + "Controller");
                            DataSet ds = objItemController.GetAllAliveObjects();
                            objectList = new List<BusinessObject>();
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[0].Rows)
                                {
                                    BusinessObject obj = new BusinessObject();
                                    obj = (BusinessObject)objItemController.GetObjectFromDataRow(dr);
                                    objectList.Add(obj);
                                }
                            }
                        }

                        repositoryItemLookUpEdit.DataSource = objectList;

                        col.ColumnEdit = repositoryItemLookUpEdit;
                    }

                    col.OptionsColumn.AllowEdit = false;
                    col.FieldName = colInfo.MMColumnName;
                    col.Caption = colInfo.MMColumnCaption;
                    col.Visible = true;

                    ColumnDefaultList.Add(colInfo.MMColumnName, col);
                }
            }
        }

        public void CopyGridColumn(GridColumn colFrom, GridColumn colTo)
        {
            colTo.ColumnEdit = colFrom.ColumnEdit;
            colTo.OptionsColumn.AllowEdit = colFrom.OptionsColumn.AllowEdit;
            colTo.Caption = colFrom.Caption;
            colTo.FieldName = colFrom.FieldName;
            colTo.Visible = colFrom.Visible;
        }

        private void InitViewColumn(BOSGridControl gridControl, List<MMMergeBOMChangeColumnsInfo> colList)
        {
            GridView view = (GridView)gridControl.MainView;
            if (view != null)
            {
                view.Columns.Clear();

                GridColumn col;
                colList.ForEach(c =>
                {
                    col = new GridColumn();
                    if (ColumnDefaultList.Keys.Contains(c.MMColumnName))
                    {
                        CopyGridColumn(ColumnDefaultList[c.MMColumnName], col);

                    }
                    else
                    {
                        col.FieldName = c.MMColumnName;
                        col.Caption = c.MMColumnCaption;
                        col.Visible = true;
                    }
                    col.OptionsColumn.AllowEdit = false;
                    col.VisibleIndex = c.MMColumnIndex;

                    view.Columns.Add(col);
                    if (c.MMFormatType == MMFormatType.Group.ToString())
                    {
                        col.Group();
                    }
                });
            }
        }

        public void InitGridColumnByType(string type)
        {
            if (ColumnList != null)
            {
                MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
                MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)entity.MainObject;

                List<MMMergeBOMChangeColumnsInfo> colList = ColumnList.Where(t => t.MMMergeBOMChangeType == type).ToList();

                if (type == MergeBOMChangeType.WoodStatus.ToString()
                    || type == MergeBOMChangeType.HardwareStatus.ToString()
                    || type == MergeBOMChangeType.PaintStatus.ToString()
                    || type == MergeBOMChangeType.PackingMaterialStatus.ToString()
                    || type == MergeBOMChangeType.GeneralMaterialStatus.ToString())
                {
                    if (ItemBOMGridControl != null)
                    {
                        InitViewColumn(ItemBOMGridControl, colList);
                    }

                    if (ItemBPGridControl != null)
                    {
                        InitViewColumn(ItemBPGridControl, colList);
                    }

                }
            }
        }

        public void InitGridColumnDic()
        {
            ColumnList = new List<MMMergeBOMChangeColumnsInfo>();

            MMMergeBOMChangeColumnsController columnCtrl = new MMMergeBOMChangeColumnsController();
            ColumnList = columnCtrl.GetAllColumn();
        }

        void BatchProductLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)entity.MainObject;

            MMBatchProductsController bpCtrl = new MMBatchProductsController();
            List<MMBatchProductsInfo> bpList = bpCtrl.GetByBOMMergeChangeTypeAndBOMID(mainObject.FK_MMProductionNormID, mainObject.MMMergeBOMChangeType);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = bpList;
        }

        void ChangeLogLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)entity.MainObject;

            MMProductionNormApproveLogsController approveLog = new MMProductionNormApproveLogsController();
            List<MMProductionNormApproveLogsInfo> logList = approveLog.GetByProductionNormIDAndType(mainObject.FK_MMProductionNormID, mainObject.MMMergeBOMChangeType);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = logList;
        }

        public void AddBatchProductToItemList(int batchProductID)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            MMMergeBOMChangeBatchProductsInfo bp = entity.BatchProductList.FirstOrDefault(t => t.FK_MMBatchProductID == batchProductID);
            if (bp == null)
            {
                bp = new MMMergeBOMChangeBatchProductsInfo();
                bp.FK_MMBatchProductID = batchProductID;
                bp.MMMergeBOMChangeBatchProductStatus = Status.New.ToString();
                entity.BatchProductList.Add(bp);
                entity.BatchProductList.GridControl?.RefreshDataSource();
            }
        }

        public void RemoveBatchProduct()
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            entity.BatchProductList.RemoveSelectedRowObjectFromList();
        }

        public void ApproveBPChange(MMMergeBOMChangeBatchProductsInfo bp)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)entity.MainObject;

            if (mainObject.MMMergeBOMChangeStatus != Status.Complete.ToString())
            {
                BOSApp.ShowMessage("Vui lòng hoàn tất chứng từ trước!");
                return;
            }

            if (bp.MMMergeBOMChangeBatchProductStatus != Status.New.ToString())
                return;

            MMBatchProductItemsController bpiCtrl = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> bpiList = bpiCtrl.GetItemByBatchProductIDAndMergeBOMTypeAndProductionNormID(bp.FK_MMBatchProductID, mainObject.MMMergeBOMChangeType, mainObject.FK_MMProductionNormID);

            if (bpiList == null || !bpiList.Any())
            {
                BOSApp.ShowMessage("Vui lòng xác định sản phẩm cần cập nhật ở Lệnh sản xuất");
                return;
            }

            ////
            // code change bom
            ///

            MMMergeBOMChangesController changeCtrl = new MMMergeBOMChangesController();
            changeCtrl.CreateNewItemBatchProductByMergeBOMChange(mainObject.MMMergeBOMChangeID, bp.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);

            changeCtrl.UpdateItemBatchProductByMergeBOMChange(mainObject.MMMergeBOMChangeID, bp.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);

            changeCtrl.DeleteItemBatchProductByMergeBOMChange(mainObject.MMMergeBOMChangeID, bp.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);

            if (mainObject.MMMergeBOMChangeType == MergeBOMChangeType.WoodStatus.ToString())
            {
                // update block per one of product
                changeCtrl.UpdateProductItemByMergeBOMChange(mainObject.MMMergeBOMChangeID, bp.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
            }

            changeCtrl.UpdateBatchProductItemByMergeBOMChange(mainObject.MMMergeBOMChangeID, bp.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);


            bp.FK_HREmployeeApproveID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            bp.MMMergeBOMChangeBatchProductApproveDate = DateTime.Now;
            bp.MMMergeBOMChangeBatchProductStatus = Status.Approved.ToString();

            MMMergeBOMChangeBatchProductsController bpCtrl = new MMMergeBOMChangeBatchProductsController();
            bpCtrl.UpdateObject(bp);

            entity.BatchProductList.GridControl?.RefreshDataSource();
            BOSApp.ShowMessage("Cập nhật thành công");
        }

        public override void InvalidateToolbar()
        {
            MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)CurrentModuleEntity.MainObject;
            if (mainObject.MMMergeBOMChangeID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (mainObject.MMMergeBOMChangeStatus == Status.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }

            base.InvalidateToolbar();
        }

        public void ClearItem(bool isClearBatchProduct)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            if (isClearBatchProduct)
            {
                entity.BatchProductList.Clear();
            }
            entity.ItemBOMLogList.Clear();
            entity.ItemBPLogList.Clear();
            entity.ItemMaterialBOMLogList.Clear();
            entity.ItemMaterialBPLogList.Clear();
            entity.ItemProcessBOMLogList.Clear();
            entity.ItemProcessBPLogList.Clear();

            if (isClearBatchProduct)
            {
                entity.BatchProductList.GridControl?.RefreshDataSource();
            }

            entity.ItemBOMLogList.GridControl?.RefreshDataSource();
            entity.ItemBPLogList.GridControl?.RefreshDataSource();
            entity.ItemMaterialBOMLogList.GridControl?.RefreshDataSource();
            entity.ItemMaterialBPLogList.GridControl?.RefreshDataSource();
            entity.ItemProcessBOMLogList.GridControl?.RefreshDataSource();
            entity.ItemProcessBPLogList.GridControl?.RefreshDataSource();
        }


        public void LoadChange()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return;
            }
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)entity.MainObject;

            if (mainObject.MMMergeBOMChangeStatus == Status.Complete.ToString())
            {
                return;
            }

            ClearItem(false);


            List<MMMergeBOMChangeColumnsInfo> columnList = ColumnList.Where(t => t.MMMergeBOMChangeType == mainObject.MMMergeBOMChangeType).ToList();
            List<string> colNameList = columnList.Select(t => t.MMColumnName).Distinct().ToList();

            List<string> materialColList = GetColumnNameListFromGridControl(entity.ItemMaterialBOMLogList.GridControl);
            List<string> processColList = GetColumnNameListFromGridControl(entity.ItemProcessBOMLogList.GridControl);

            foreach (MMMergeBOMChangeBatchProductsInfo bp in entity.BatchProductList)
            {
                if (mainObject.MMMergeBOMChangeType == MergeBOMChangeType.WoodStatus.ToString()
                    || mainObject.MMMergeBOMChangeType == MergeBOMChangeType.HardwareStatus.ToString()
                    || mainObject.MMMergeBOMChangeType == MergeBOMChangeType.PaintStatus.ToString()
                    || mainObject.MMMergeBOMChangeType == MergeBOMChangeType.PackingMaterialStatus.ToString()
                    || mainObject.MMMergeBOMChangeType == MergeBOMChangeType.GeneralMaterialStatus.ToString())
                {
                    GetItemChange(bp.FK_MMBatchProductID, mainObject.FK_MMProductionNormID, mainObject.MMMergeBOMChangeType, mainObject.FK_MMProductionNormApproveLogID, colNameList);

                    if (mainObject.MMMergeBOMChangeType == MergeBOMChangeType.WoodStatus.ToString())
                    {
                        GetItemMaterialChange(bp.FK_MMBatchProductID, mainObject.FK_MMProductionNormID, mainObject.FK_MMProductionNormApproveLogID, materialColList);
                    }
                }
                else if (mainObject.MMMergeBOMChangeType == MergeBOMChangeType.ColorProccessStatus.ToString()
                    || mainObject.MMMergeBOMChangeType == MergeBOMChangeType.CarcassProccessStatus.ToString())
                {
                    GetItemProcessChange(bp.FK_MMBatchProductID, mainObject.FK_MMProductionNormID, mainObject.FK_MMProductionNormApproveLogID, processColList, mainObject.MMMergeBOMChangeType);
                }

            }

            entity.ItemBOMLogList.GridControl?.RefreshDataSource();
            entity.ItemBPLogList.GridControl?.RefreshDataSource();
            entity.ItemMaterialBOMLogList.GridControl?.RefreshDataSource();
            entity.ItemMaterialBPLogList.GridControl?.RefreshDataSource();
            entity.ItemProcessBOMLogList.GridControl?.RefreshDataSource();
            entity.ItemProcessBPLogList.GridControl?.RefreshDataSource();

        }

        public MMMergeBOMChangeItemBOMLogsInfo GenerateBOMItem(MMProductionNormItemLogsInfo bomLog, string status, int batchProductID)
        {
            MMMergeBOMChangeItemBOMLogsInfo item = new MMMergeBOMChangeItemBOMLogsInfo();
            BOSUtil.CopyObject(bomLog, item);
            item.MMMergeBOMChangeActionType = status;
            item.FK_MMBatchProductID = batchProductID;
            item.FK_MMProductionNormItemLogID = bomLog.MMProductionNormItemLogID;

            return item;
        }

        public MMMergeBOMChangeItemMaterialBOMLogsInfo GenerateBOMItemMaterial(ICProductItemMaterialLogsInfo bomLog, string status, int batchProductID)
        {
            MMMergeBOMChangeItemMaterialBOMLogsInfo item = new MMMergeBOMChangeItemMaterialBOMLogsInfo();
            BOSUtil.CopyObject(bomLog, item);
            item.MMMergeBOMChangeActionType = status;
            item.FK_MMBatchProductID = batchProductID;
            item.ICProductItemMaterialLogID = bomLog.ICProductItemMaterialLogID;

            return item;
        }

        public MMMergeBOMChangeItemProcessBOMLogsInfo GenerateBOMItemProcess(ICProductItemProcessLogsInfo bomLog, string status, int batchProductID)
        {
            MMMergeBOMChangeItemProcessBOMLogsInfo item = new MMMergeBOMChangeItemProcessBOMLogsInfo();
            BOSUtil.CopyObject(bomLog, item);
            item.MMMergeBOMChangeActionType = status;
            item.FK_MMBatchProductID = batchProductID;
            item.ICProductItemProcessLogID = bomLog.ICProductItemProcessLogID;

            return item;
        }


        public MMMergeBOMChangeItemMaterialBPLogsInfo GenerateBPItemMaterial(ICProductItemMaterialLogsInfo bomLog, string status, int batchProductID)
        {
            MMMergeBOMChangeItemMaterialBPLogsInfo item = new MMMergeBOMChangeItemMaterialBPLogsInfo();
            BOSUtil.CopyObject(bomLog, item);
            item.MMMergeBOMChangeActionType = status;
            item.FK_MMBatchProductID = batchProductID;
            item.ICProductItemMaterialLogID = bomLog.ICProductItemMaterialLogID;

            return item;
        }

        public MMMergeBOMChangeItemProcessBPLogsInfo GenerateBPItemProcess(ICProductItemProcessLogsInfo bomLog, string status, int batchProductID)
        {
            MMMergeBOMChangeItemProcessBPLogsInfo item = new MMMergeBOMChangeItemProcessBPLogsInfo();
            BOSUtil.CopyObject(bomLog, item);
            item.MMMergeBOMChangeActionType = status;
            item.FK_MMBatchProductID = batchProductID;
            item.ICProductItemProcessLogID = bomLog.ICProductItemProcessLogID;

            return item;
        }

        public MMMergeBOMChangeItemBPLogsInfo GenerateBPItem(MMProductionNormItemLogsInfo bomLog, string status, int batchProductID)
        {
            MMMergeBOMChangeItemBPLogsInfo item = new MMMergeBOMChangeItemBPLogsInfo();
            BOSUtil.CopyObject(bomLog, item);
            item.MMMergeBOMChangeActionType = status;
            item.FK_MMBatchProductID = batchProductID;
            item.FK_MMProductionNormItemLogID = bomLog.MMProductionNormItemLogID;

            return item;
        }


        private void GetItemChange(int batchProductID, int productionNormID, string type, int newApproveLogID, List<string> colNameList)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            MMProductionNormItemLogsController pnilCtrl = new MMProductionNormItemLogsController();
            List<MMProductionNormItemLogsInfo> pnilBPList = pnilCtrl.GetBySomeConditions(batchProductID, productionNormID, type);
            List<MMProductionNormItemLogsInfo> pnilBOMList = pnilCtrl.GetByApproveID(newApproveLogID);

            MMMergeBOMChangeItemBOMLogsInfo bomItem;
            MMMergeBOMChangeItemBPLogsInfo bpItem;
            MMProductionNormItemLogsInfo filterItem;

            foreach (MMProductionNormItemLogsInfo bomLog in pnilBOMList)
            {
                filterItem = pnilBPList.FirstOrDefault(t => t.MMProductionNormItemID == bomLog.MMProductionNormItemID);

                if (filterItem != null)
                {

                    if (bomLog.AAStatus == Status.Delete.ToString())
                    {
                        if (filterItem.AAStatus != Status.Delete.ToString())
                        {
                            bomItem = GenerateBOMItem(bomLog, MergeBOMChangeActionType.Delete.ToString(), batchProductID);
                            bomItem.AAStatus = Status.Alive.ToString();
                            entity.ItemBOMLogList.Add(bomItem);

                            bpItem = GenerateBPItem(bomLog, MergeBOMChangeActionType.Delete.ToString(), batchProductID);
                            bpItem.AAStatus = Status.Alive.ToString();
                            entity.ItemBPLogList.Add(bpItem);
                        }
                    }
                    else
                    {
                        if (!BOSApp.IsEqualObjects(bomLog, filterItem, colNameList))
                        {
                            bomItem = GenerateBOMItem(bomLog, MergeBOMChangeActionType.Update.ToString(), batchProductID);
                            entity.ItemBOMLogList.Add(bomItem);

                            bpItem = GenerateBPItem(filterItem, MergeBOMChangeActionType.Update.ToString(), batchProductID);
                            entity.ItemBPLogList.Add(bpItem);
                        }
                    }
                }
                else
                {
                    if (bomLog.AAStatus == Status.Alive.ToString())
                    {
                        bomItem = GenerateBOMItem(bomLog, MergeBOMChangeActionType.New.ToString(), batchProductID);
                        entity.ItemBOMLogList.Add(bomItem);
                    }
                }

            }

        }

        public List<string> GetColumnNameListFromGridControl(BOSGridControl gridControl)
        {
            List<string> compareColumnNameList = new List<string>();
            GridView gridView = (GridView)gridControl.MainView;

            if (gridView != null)
            {
                foreach (GridColumn column in gridView.Columns)
                {
                    compareColumnNameList.Add(column.FieldName);
                }
            }

            return compareColumnNameList;
        }

        private void GetItemMaterialChange(int batchProductID, int productionNormID, int newApproveLogID, List<string> colNameList)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;

            ICProductItemMaterialLogsController pnilCtrl = new ICProductItemMaterialLogsController();
            List<ICProductItemMaterialLogsInfo> logBPList = pnilCtrl.GetBySomeConditions(batchProductID, productionNormID);
            List<ICProductItemMaterialLogsInfo> logBOMList = pnilCtrl.GetByApproveLogID(newApproveLogID);

            MMMergeBOMChangeItemMaterialBOMLogsInfo bomItem;
            MMMergeBOMChangeItemMaterialBPLogsInfo bpItem;
            ICProductItemMaterialLogsInfo filterItem;

            foreach (ICProductItemMaterialLogsInfo bomLog in logBOMList)
            {
                filterItem = logBPList.FirstOrDefault(t => t.ICProductItemMaterialID == bomLog.ICProductItemMaterialID);

                if (filterItem != null)
                {

                    if (bomLog.AAStatus == Status.Delete.ToString())
                    {
                        if (filterItem.AAStatus != Status.Delete.ToString())
                        {
                            bomItem = GenerateBOMItemMaterial(bomLog, MergeBOMChangeActionType.Delete.ToString(), batchProductID);
                            bomItem.AAStatus = Status.Alive.ToString();
                            entity.ItemMaterialBOMLogList.Add(bomItem);

                            bpItem = GenerateBPItemMaterial(bomLog, MergeBOMChangeActionType.Delete.ToString(), batchProductID);
                            bpItem.AAStatus = Status.Alive.ToString();
                            entity.ItemMaterialBPLogList.Add(bpItem);
                        }
                    }
                    else
                    {
                        if (!BOSApp.IsEqualObjects(bomLog, filterItem, colNameList))
                        {
                            bomItem = GenerateBOMItemMaterial(bomLog, MergeBOMChangeActionType.Update.ToString(), batchProductID);
                            entity.ItemMaterialBOMLogList.Add(bomItem);

                            bpItem = GenerateBPItemMaterial(filterItem, MergeBOMChangeActionType.Update.ToString(), batchProductID);
                            entity.ItemMaterialBPLogList.Add(bpItem);
                        }
                    }
                }
                else
                {
                    if (bomLog.AAStatus == Status.Alive.ToString())
                    {
                        bomItem = GenerateBOMItemMaterial(bomLog, MergeBOMChangeActionType.New.ToString(), batchProductID);
                        entity.ItemMaterialBOMLogList.Add(bomItem);
                    }
                }

            }

        }

        public List<ICProductsInfo> GetWoodIngredient()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsInfoList = new List<ICProductsInfo>();
            objProductsInfoList.Add(new ICProductsInfo());
            objProductsInfoList.AddRange(objProductsController.GetProductByDepartmentID(DepartmentID.Wood));
            return objProductsInfoList;
        }

        private void GetItemProcessChange(int batchProductID, int productionNormID, int newApproveLogID, List<string> colNameList, string type)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;

            ICProductItemProcessLogsController pnilCtrl = new ICProductItemProcessLogsController();
            List<ICProductItemProcessLogsInfo> logBPList = pnilCtrl.GetBySomeConditions(batchProductID, productionNormID, type);
            List<ICProductItemProcessLogsInfo> logBOMList = pnilCtrl.GetByApproveLogID(newApproveLogID);

            MMMergeBOMChangeItemProcessBOMLogsInfo bomItem;
            MMMergeBOMChangeItemProcessBPLogsInfo bpItem;
            ICProductItemProcessLogsInfo filterItem;

            foreach (ICProductItemProcessLogsInfo bomLog in logBOMList)
            {
                filterItem = logBPList.FirstOrDefault(t => t.ICProductItemProcessID == bomLog.ICProductItemProcessID);

                if (filterItem != null)
                {

                    if (bomLog.AAStatus == Status.Delete.ToString())
                    {
                        if (filterItem.AAStatus != Status.Delete.ToString())
                        {
                            bomItem = GenerateBOMItemProcess(bomLog, MergeBOMChangeActionType.Delete.ToString(), batchProductID);
                            bomItem.AAStatus = Status.Alive.ToString();
                            entity.ItemProcessBOMLogList.Add(bomItem);

                            bpItem = GenerateBPItemProcess(bomLog, MergeBOMChangeActionType.Delete.ToString(), batchProductID);
                            bpItem.AAStatus = Status.Alive.ToString();
                            entity.ItemProcessBPLogList.Add(bpItem);
                        }
                    }
                    else
                    {
                        if (!BOSApp.IsEqualObjects(bomLog, filterItem, colNameList))
                        {
                            bomItem = GenerateBOMItemProcess(bomLog, MergeBOMChangeActionType.Update.ToString(), batchProductID);
                            entity.ItemProcessBOMLogList.Add(bomItem);

                            bpItem = GenerateBPItemProcess(filterItem, MergeBOMChangeActionType.Update.ToString(), batchProductID);
                            entity.ItemProcessBPLogList.Add(bpItem);
                        }
                    }
                }
                else
                {
                    if (bomLog.AAStatus == Status.Alive.ToString())
                    {
                        bomItem = GenerateBOMItemProcess(bomLog, MergeBOMChangeActionType.New.ToString(), batchProductID);
                        entity.ItemProcessBOMLogList.Add(bomItem);
                    }
                }

            }

        }

        public void ChangeApproveLog(int approveLogID)
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)CurrentModuleEntity;
            MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)entity.MainObject;

            mainObject.FK_MMProductionNormApproveLogID = approveLogID;

            MMProductionNormApproveLogsController approveLogCtrl = new MMProductionNormApproveLogsController();
            MMProductionNormApproveLogsInfo approveLog = (MMProductionNormApproveLogsInfo)approveLogCtrl.GetObjectByID(approveLogID);

            if (approveLog != null)
            {
                MMBatchProductsController bpCtrl = new MMBatchProductsController();
                List<MMBatchProductsInfo> bpList = bpCtrl.GetBatchProductByIDList(approveLog.MMProductionNormApproveLogBPIDReference);

                if (bpList != null)
                {
                    foreach (MMBatchProductsInfo bp in bpList)
                    {
                        AddBatchProductToItemList(bp.MMBatchProductID);
                    }
                }
            }
        }
    }
}
