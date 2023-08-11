using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public partial class guiAddMaterialOverBOM : BOSERPScreen
    {
        public List<MMBatchProductProductionNormItemsInfo> SemiProductList { get; set; }
        public BOSList<MMBatchProductProductionNormItemMeterialsInfo> MaterialProductionNormItemList { get; set; }
        public BOSList<MMBatchProductProductionNormItemsInfo> ProductionNormItemList { get; set; }
        private List<MMOperationsInfo> OperationDataSource { get; set; }
        public MMBatchProductProductionNormItemsInfo CurrentPniObjecs { get; set; }
        private MMBatchProductProductionNormItemsInfo OldPniObjecs { get; set; }

        public int BatchProductID { get; set; }

        List<MMBatchProductProductionNormItemsInfo> HardwareList { get; set; }
        List<MMBatchProductProductionNormItemsInfo> PaintList { get; set; }
        List<MMBatchProductProductionNormItemsInfo> PackagingList { get; set; }
        List<MMBatchProductProductionNormItemsInfo> GeneralMaterialList { get; set; }
        List<MMBatchProductProductionNormItemMeterialsInfo> MaterialList { get; set; }
        List<MMBatchProductProductionNormItemProcesssInfo> ProcessList { get; set; }
        public string ProductGroup { get; set; }
        public guiAddMaterialOverBOM()
        {
            InitializeComponent();

            CurrentPniObjecs = new MMBatchProductProductionNormItemsInfo();
            OldPniObjecs = new MMBatchProductProductionNormItemsInfo();
            MMOperationsController objOperationsController = new MMOperationsController();
            DataSet ds = BOSApp.LookupTables[TableName.MMOperationsTableName] as DataSet;
            if (ds == null)
            {
                BOSApp.GetLookupTableData(TableName.MMOperationsTableName);
            }
            OperationDataSource = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);

            ProductionNormItemList = new BOSList<MMBatchProductProductionNormItemsInfo>();
            HardwareList = new List<MMBatchProductProductionNormItemsInfo>();
            PaintList = new List<MMBatchProductProductionNormItemsInfo>();
            PackagingList = new List<MMBatchProductProductionNormItemsInfo>();
            GeneralMaterialList = new List<MMBatchProductProductionNormItemsInfo>();
            MaterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            ProcessList = new List<MMBatchProductProductionNormItemProcesssInfo>();
        }

        private void guiAddMaterialOverBOM_Load(object sender, EventArgs e)
        {
            fld_dgcItemMaterials.OperationDataSource = OperationDataSource;
            fld_dgcItemHardwares.OperationDataSource = OperationDataSource;
            fld_dgcItemPaint.OperationDataSource = OperationDataSource;
            fld_dgcItemPackagingList.OperationDataSource = OperationDataSource;
            fld_dgcItemGeneralMaterial.OperationDataSource = OperationDataSource;
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BatchProductSheduleModule)Module).CurrentModuleEntity;
            ProductionNormItemList.InitBOSList(entity,
                                               string.Empty,
                                               TableName.MMBatchProductProductionNormItemsTableName,
                                               BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);

            MaterialProductionNormItemList = new BOSList<MMBatchProductProductionNormItemMeterialsInfo>();
            MaterialProductionNormItemList.InitBOSList(entity,
                                               string.Empty,
                                               TableName.MMBatchProductProductionNormItemMeterialsTableName,
                                               BOSList<MMBatchProductProductionNormItemMeterialsInfo>.cstRelationNone);
            MMBatchProductProductionNormItemProcesssController processController = new MMBatchProductProductionNormItemProcesssController();
            ProcessList = processController.GetProcessOperationByBatchProductID(BatchProductID);
            InitializeControls(Controls);
            LoadData();
            fld_trlMMViewChangeSemiBOMs.FocusedNodeChanged += Fld_trlMMViewChangeSemiBOMs_FocusedNodeChanged;
            fld_trlMMViewChangeSemiBOMs.DataSource = SemiProductList;
            fld_trlMMViewChangeSemiBOMs.BestFitColumns();
            fld_trlMMViewChangeSemiBOMs.ExpandAll();
        }

        private void Fld_trlMMViewChangeSemiBOMs_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            BOSTreeListControl treeList = sender as BOSTreeListControl;
            if (treeList == null)
                return;

            TreeListNode node = treeList.GetSelectedNode();
            if (node != null)
            {
                CurrentPniObjecs = (MMBatchProductProductionNormItemsInfo)treeList.GetDataRecordByNode(node);
                if (CurrentPniObjecs == null)
                    return;

                RefreshDataBySemiProduct(CurrentPniObjecs);
                OldPniObjecs = (MMBatchProductProductionNormItemsInfo)CurrentPniObjecs.Clone();
            }
        }

        private void LoadData()
        {
            MMBatchProductProductionNormItemsController pnisController = new MMBatchProductProductionNormItemsController();
            SemiProductList = pnisController.GetBPPNItemByBatchProductIDAndGroup(AllocationPlanItemGroup.SemiProduct.ToString(), BatchProductID);
            MMBatchProductProductionNormItemMeterialsController pinMaterialsController = new MMBatchProductProductionNormItemMeterialsController();
            List<MMBatchProductProductionNormItemMeterialsInfo> itemMaterialList = pinMaterialsController.GetMaterialOverBOMByBatchProductID(BatchProductID);
            itemMaterialList.ForEach(o => o.VirtualId = Guid.NewGuid());
            MaterialProductionNormItemList.Invalidate(itemMaterialList);
            List<MMBatchProductProductionNormItemsInfo> itemList = pnisController.GetItemOverBOMByBatchProductID(BatchProductID);
            itemList.ForEach(o =>
            {
                o.VirtualId = Guid.NewGuid();
                o.MMBatchProductProductionNormItemIsOverBTP = o.MMBatchProductProductionNormItemRef > 0 ? true : false;
            });
            ProductionNormItemList.Invalidate(itemList);
        }

        private void RefreshDataBySemiProduct(MMBatchProductProductionNormItemsInfo itemNote)
        {
            MaterialList.ForEach(o =>
            {
                o.FK_MMBatchProductID = OldPniObjecs.FK_MMBatchProductID;
                o.FK_MMBatchProductItemID = OldPniObjecs.FK_MMBatchProductItemID;
                o.FK_MMBatchProductProductionNormItemID = OldPniObjecs.MMBatchProductProductionNormItemID;
                o.MMBatchProductProductionNormItemMeterialType = "OverBOM";
                o.MMBatchProductProductionNormItemMeterialDepreciationRate = o.MMBatchProductProductionNormItemMeterialDepreciationRate== 0? 1: o.MMBatchProductProductionNormItemMeterialDepreciationRate;
                o.MMBatchProductProductionNormItemMeterialDepreciationQty = o.MMBatchProductProductionNormItemMeterialQty;
                if (o.VirtualId == null || o.VirtualId == Guid.Empty)
                {
                    o.VirtualId = Guid.NewGuid();
                    
                    MaterialProductionNormItemList.Add(o);
                }
            });
            MaterialList = MaterialProductionNormItemList.Where(o => o.FK_MMBatchProductProductionNormItemID == itemNote.MMBatchProductProductionNormItemID).ToList();
            fld_dgcItemMaterials.InvalidateDataSource(MaterialList);

            HardwareList.ForEach(o =>
            {
                if (o.VirtualId == null || o.VirtualId == Guid.Empty)
                {
                    o.VirtualId = Guid.NewGuid();
                    o.FK_MMBatchProductID = OldPniObjecs.FK_MMBatchProductID;
                    o.FK_MMBatchProductItemID = OldPniObjecs.FK_MMBatchProductItemID;
                    o.FK_MMBPSemiProductID = o.MMBatchProductProductionNormItemIsOverBTP ? 0 : OldPniObjecs.MMBatchProductProductionNormItemID;
                    o.MMBatchProductProductionNormItemRef = o.MMBatchProductProductionNormItemIsOverBTP ? OldPniObjecs.MMBatchProductProductionNormItemID : 0;
                    o.FK_ICProductForBatchID = OldPniObjecs.FK_ICProductForBatchID;
                    o.MMBatchProductProductionNormItemType = "OverBOM";
                    o.MMBatchProductProductionNormItemGroup = AllocationPlanItemGroup.Hardware.ToString();
                    ProductionNormItemList.Add(o);
                }
            });
            HardwareList = ProductionNormItemList.Where(o => o.MMBatchProductProductionNormItemGroup == AllocationPlanItemGroup.Hardware.ToString()
                                                             && (o.FK_MMBPSemiProductID == itemNote.MMBatchProductProductionNormItemID || o.MMBatchProductProductionNormItemRef == itemNote.MMBatchProductProductionNormItemID)).ToList();
            fld_dgcItemHardwares.InvalidateDataSource(HardwareList);

            PaintList.ForEach(o =>
            {
                if (o.VirtualId == null || o.VirtualId == Guid.Empty)
                {
                    o.VirtualId = Guid.NewGuid();
                    o.FK_MMBatchProductID = OldPniObjecs.FK_MMBatchProductID;
                    o.FK_MMBatchProductItemID = OldPniObjecs.FK_MMBatchProductItemID;
                    o.FK_MMBPSemiProductID = o.MMBatchProductProductionNormItemIsOverBTP ? 0 : OldPniObjecs.MMBatchProductProductionNormItemID;
                    o.MMBatchProductProductionNormItemRef = o.MMBatchProductProductionNormItemIsOverBTP ? OldPniObjecs.MMBatchProductProductionNormItemID : 0;
                    o.FK_ICProductForBatchID = OldPniObjecs.FK_ICProductForBatchID;
                    o.MMBatchProductProductionNormItemType = "OverBOM";
                    o.MMBatchProductProductionNormItemGroup = AllocationPlanItemGroup.IngredientPaint.ToString();
                    ProductionNormItemList.Add(o);
                }
            });
            PaintList = ProductionNormItemList.Where(o => o.MMBatchProductProductionNormItemGroup == AllocationPlanItemGroup.IngredientPaint.ToString()
                                                          && (o.FK_MMBPSemiProductID == itemNote.MMBatchProductProductionNormItemID || o.MMBatchProductProductionNormItemRef == itemNote.MMBatchProductProductionNormItemID)).ToList();
            fld_dgcItemPaint.InvalidateDataSource(PaintList);

            PackagingList.ForEach(o =>
            {
                if (o.VirtualId == null || o.VirtualId == Guid.Empty)
                {
                    o.VirtualId = Guid.NewGuid();
                    o.FK_MMBatchProductID = OldPniObjecs.FK_MMBatchProductID;
                    o.FK_MMBatchProductItemID = OldPniObjecs.FK_MMBatchProductItemID;
                    o.FK_MMBPSemiProductID = o.MMBatchProductProductionNormItemIsOverBTP ? 0 : OldPniObjecs.MMBatchProductProductionNormItemID;
                    o.MMBatchProductProductionNormItemRef = o.MMBatchProductProductionNormItemIsOverBTP ? OldPniObjecs.MMBatchProductProductionNormItemID : 0;
                    o.FK_ICProductForBatchID = OldPniObjecs.FK_ICProductForBatchID;
                    o.MMBatchProductProductionNormItemType = "OverBOM";
                    o.MMBatchProductProductionNormItemGroup = AllocationPlanItemGroup.IngredientPackaging.ToString();
                    ProductionNormItemList.Add(o);
                }
            });
            PackagingList = ProductionNormItemList.Where(o => o.MMBatchProductProductionNormItemGroup == AllocationPlanItemGroup.IngredientPackaging.ToString()
                                                              && (o.FK_MMBPSemiProductID == itemNote.MMBatchProductProductionNormItemID || o.MMBatchProductProductionNormItemRef == itemNote.MMBatchProductProductionNormItemID)).ToList();
            fld_dgcItemPackagingList.InvalidateDataSource(PackagingList);

            GeneralMaterialList.ForEach(o =>
            {
                if (o.VirtualId == null || o.VirtualId == Guid.Empty)
                {
                    o.VirtualId = Guid.NewGuid();
                    o.FK_MMBatchProductID = OldPniObjecs.FK_MMBatchProductID;
                    o.FK_MMBatchProductItemID = OldPniObjecs.FK_MMBatchProductItemID;
                    o.FK_MMBPSemiProductID = o.MMBatchProductProductionNormItemIsOverBTP ? 0 : OldPniObjecs.MMBatchProductProductionNormItemID;
                    o.MMBatchProductProductionNormItemRef = o.MMBatchProductProductionNormItemIsOverBTP ? OldPniObjecs.MMBatchProductProductionNormItemID : 0;
                    o.FK_ICProductForBatchID = OldPniObjecs.FK_ICProductForBatchID;
                    o.MMBatchProductProductionNormItemType = "OverBOM";
                    o.MMBatchProductProductionNormItemGroup = AllocationPlanItemGroup.GeneralMaterial.ToString();
                    ProductionNormItemList.Add(o);
                }
            });
            GeneralMaterialList = ProductionNormItemList.Where(o => o.MMBatchProductProductionNormItemGroup == AllocationPlanItemGroup.GeneralMaterial.ToString()
                                                                    && (o.FK_MMBPSemiProductID == itemNote.MMBatchProductProductionNormItemID || o.MMBatchProductProductionNormItemRef == itemNote.MMBatchProductProductionNormItemID)).ToList();
            fld_dgcItemGeneralMaterial.InvalidateDataSource(GeneralMaterialList);
        }

        public List<MMOperationsInfo> GetCurrenProcessList(MMBatchProductProductionNormItemsInfo item = null)
        {
            List<MMOperationsInfo> curentProcess = new List<MMOperationsInfo>();
            if (item == null || (item != null && item.MMBatchProductProductionNormItemIsOverBTP))
            {
                curentProcess = OperationDataSource.Where(o => o.MMOperationIsPlan).ToList();
                curentProcess.Insert(0, new MMOperationsInfo());
                return curentProcess;
            }
            List<int> currentProcess = ProcessList.Where(o => o.FK_MMBatchProductProductionNormItemID == CurrentPniObjecs.MMBatchProductProductionNormItemID)
                                                  .Select(o => o.FK_MMOperationID)
                                                  .ToList();

            curentProcess = OperationDataSource.Where(o => currentProcess.Contains(o.MMOperationID)).ToList();
            curentProcess.Insert(0, new MMOperationsInfo());
            return curentProcess;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            RefreshDataBySemiProduct(CurrentPniObjecs);
            ProductionNormItemList.SaveItemCDObjects();
            MaterialProductionNormItemList.SaveItemCDObjects();
            this.DialogResult = DialogResult.OK;
        }

        public bool DeteteItemMaterial(MMBatchProductProductionNormItemMeterialsInfo item)
        {
            MMBatchProductProductionNormItemsController pnisController = new MMBatchProductProductionNormItemsController();
            if (item.FK_MMBatchProductProductionNormItemID != 0)
            {
                bool isExistPlan = pnisController.CheckItemExistPlan(item.FK_MMBatchProductProductionNormItemID, AllocationPlanItemGroup.SemiProduct.ToString(), item.FK_ICProductID, item.MMBatchProductProductionNormItemMeterialID);
                if (isExistPlan)
                    return false;
            }
            MaterialProductionNormItemList.RemoveAll(o => o.VirtualId == item.VirtualId);
            return true;
        }

        public bool DeteteItemMaterial(MMBatchProductProductionNormItemsInfo item)
        {
            MMBatchProductProductionNormItemsController pnisController = new MMBatchProductProductionNormItemsController();
            if (item.MMBatchProductProductionNormItemID != 0)
            {
                bool isExistPlan = pnisController.CheckItemExistPlan(item.MMBatchProductProductionNormItemID, item.MMBatchProductProductionNormItemGroup, item.FK_ICProductID, 0);
                if (isExistPlan)
                    return false;
            }
            ProductionNormItemList.RemoveAll(o => o.VirtualId == item.VirtualId);
            return true;
        }

        public bool CheckIsProduct()
        {
            if (CurrentPniObjecs != null && CurrentPniObjecs.FK_ICProductID == CurrentPniObjecs.FK_ICProductForBatchID)
                return true;

            return false;
        }
    }
}