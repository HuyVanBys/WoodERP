using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Enums;
using BOSLib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.BatchProductShedule
{
    public class BatchProductSheduleEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<MMAllocationPlanItemsInfo> BPProductionNormItemMaterialList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> BPProductionNormItemHardwareList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> BPProductionNormItemPaintList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> BPProductionNormItemPackagingList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> BPProductionNormItemOtherMaterialList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> BPProductionNormItemInstrumentList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> BPProductionNormItemSemiProductList { get; set; }
        public BOSList<MMBatchProductProductionNormItemsInfo> BPProductionNormItemOutOfNorm { get; set; }
        public BOSList<MMBatchProductProductionNormItemMeterialsInfo> BPProductionNormItemMaterialOutOfNorm { get; set; }
        public List<MMAllocationPlanItemsInfo> MergeRemoveList { get; set; }
        #endregion
        #region Contructors
        public BatchProductSheduleEntities()
            : base()
        {
            BPProductionNormItemMaterialList = new BOSList<MMAllocationPlanItemsInfo>();
            BPProductionNormItemHardwareList = new BOSList<MMAllocationPlanItemsInfo>();
            BPProductionNormItemPaintList = new BOSList<MMAllocationPlanItemsInfo>();
            BPProductionNormItemPackagingList = new BOSList<MMAllocationPlanItemsInfo>();
            BPProductionNormItemOtherMaterialList = new BOSList<MMAllocationPlanItemsInfo>();
            BPProductionNormItemInstrumentList = new BOSList<MMAllocationPlanItemsInfo>();
            BPProductionNormItemSemiProductList = new BOSList<MMAllocationPlanItemsInfo>();
            BPProductionNormItemOutOfNorm = new BOSList<MMBatchProductProductionNormItemsInfo>();
            BPProductionNormItemMaterialOutOfNorm = new BOSList<MMBatchProductProductionNormItemMeterialsInfo>();
            MergeRemoveList = new List<MMAllocationPlanItemsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMAllocationPlansInfo();
            SearchObject = new MMAllocationPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMAllocationPlanItemsTableName, new MMAllocationPlanItemsInfo());
            ModuleObjects.Add(TableName.MMBatchProductProductionNormItemsTableName, new MMBatchProductProductionNormItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            BPProductionNormItemMaterialList.InitBOSList(this,
                                                     string.Empty,
                                                     TableName.MMBatchProductProductionNormItemsTableName,
                                                     BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);

            BPProductionNormItemHardwareList.InitBOSList(this,
                                                         string.Empty,
                                                         TableName.MMBatchProductProductionNormItemsTableName,
                                                         BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);

            BPProductionNormItemPaintList.InitBOSList(this,
                                                         string.Empty,
                                                         TableName.MMBatchProductProductionNormItemsTableName,
                                                         BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);

            BPProductionNormItemPackagingList.InitBOSList(this,
                                                         string.Empty,
                                                         TableName.MMBatchProductProductionNormItemsTableName,
                                                         BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);

            BPProductionNormItemOtherMaterialList.InitBOSList(this,
                                                         string.Empty,
                                                         TableName.MMBatchProductProductionNormItemsTableName,
                                                         BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);

            BPProductionNormItemInstrumentList.InitBOSList(this,
                                                        string.Empty,
                                                        TableName.MMBatchProductProductionNormItemsTableName,
                                                        BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);
            BPProductionNormItemSemiProductList.InitBOSList(this,
                                                        string.Empty,
                                                        TableName.MMBatchProductProductionNormItemsTableName,
                                                        BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);
            BPProductionNormItemOutOfNorm.InitBOSList(this,
                                                      string.Empty,
                                                      TableName.MMBatchProductProductionNormItemsTableName,
                                                      BOSList<MMBatchProductProductionNormItemsInfo>.cstRelationNone);
            BPProductionNormItemMaterialOutOfNorm.InitBOSList(this,
                                                              string.Empty,
                                                              TableName.MMBatchProductProductionNormItemMeterialsTableName,
                                                              BOSList<MMBatchProductProductionNormItemMeterialsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            BPProductionNormItemMaterialList.InitBOSListGridControl(BatchProductSheduleModule.ItemWoodsGridControlName);
            BPProductionNormItemHardwareList.InitBOSListGridControl(BatchProductSheduleModule.ItemHardwaresGridControlName);
            BPProductionNormItemPaintList.InitBOSListGridControl(BatchProductSheduleModule.ItemPaintsGridControlName);
            BPProductionNormItemPackagingList.InitBOSListGridControl(BatchProductSheduleModule.ItemPackagingsGridControlName);
            BPProductionNormItemOtherMaterialList.InitBOSListGridControl(BatchProductSheduleModule.ItemSteelsGridControlName);
            BPProductionNormItemInstrumentList.InitBOSListGridControl(BatchProductSheduleModule.ItemInstrumentsGridControlName);
            BPProductionNormItemSemiProductList.InitBOSListGridControl(BatchProductSheduleModule.ItemSemiProductsGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)MainObject;
            objAllocationPlansInfo.MMAllocationPlanDate = BOSApp.GetCurrentServerDate();
            objAllocationPlansInfo.MMAllocationPlanStatus = AllocationPlanStatus.New.ToString();
            objAllocationPlansInfo.MMAllocationPlanType = AllocationPlanCreateFrom.BatchProduct.ToString();
            objAllocationPlansInfo.MMAllocationPlanPurpose = AllocationPlanPurpose.Production.ToString();
            objAllocationPlansInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BPProductionNormItemMaterialList.SetDefaultListAndRefreshGridControl();
                BPProductionNormItemHardwareList.SetDefaultListAndRefreshGridControl();
                BPProductionNormItemPaintList.SetDefaultListAndRefreshGridControl();
                BPProductionNormItemPackagingList.SetDefaultListAndRefreshGridControl();
                BPProductionNormItemOtherMaterialList.SetDefaultListAndRefreshGridControl();
                BPProductionNormItemInstrumentList.SetDefaultListAndRefreshGridControl();
                BPProductionNormItemSemiProductList.SetDefaultListAndRefreshGridControl();
                MergeRemoveList.Clear();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities
        public override void InvalidateModuleObjects(int iObjectID)
        {
            BPProductionNormItemMaterialList.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemHardwareList.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemPackagingList.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemPaintList.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemInstrumentList.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemOtherMaterialList.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemSemiProductList.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemOutOfNorm.SetDefaultListAndRefreshGridControl();
            BPProductionNormItemMaterialOutOfNorm.SetDefaultListAndRefreshGridControl();
            MergeRemoveList.Clear();
        }

        public override int SaveMainObject()
        {
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)MainObject;
            mainobject.MMAllocationPlanStatus = AllocationPlanStatus.Saved.ToString();
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)MainObject;
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<string> selectedTab = ((BatchProductSheduleModule)Module).SelectionSelectedTabs.Distinct().ToList();
            selectedTab.ForEach(tabName =>
            {
                switch (tabName)
                {
                    case "fld_tabMaterial":
                        SaveAllocationPlanItems(BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                        break;
                    case "fld_tabOtherMaterial":
                        SaveAllocationPlanItems(BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                        break;
                    case "fld_tabHardware":
                        SaveAllocationPlanItems(BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                        break;
                    case "fld_tabIngredientPaint":
                        SaveAllocationPlanItems(BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                        break;
                    case "fld_tabIngredientPackaging":
                        SaveAllocationPlanItems(BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                        break;
                    case "fld_tabGeneralMaterial":
                        SaveAllocationPlanItems(BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                        break;
                    case "fld_tabSemiProduct":
                        SaveAllocationPlanItems(BPProductionNormItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                        break;
                }
            });
            MergeRemoveList.Clear();
            if (BPProductionNormItemOutOfNorm.Count() != 0)
                BPProductionNormItemOutOfNorm.SaveItemCDObjects();
            if (BPProductionNormItemMaterialOutOfNorm.Count() != 0)
                BPProductionNormItemMaterialOutOfNorm.SaveItemCDObjects();
        }

        public void SaveAllocationPlanItems(BOSList<MMAllocationPlanItemsInfo> bpPniList, string itemGroup)
        {
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)MainObject;
            bpPniList.ForEach(o => o.FK_MMAllocationPlanID = mainobject.MMAllocationPlanID);
            bpPniList.InsertOrUpdateObject();
            MergeRemoveList.Where(o => o.MMAllocationPlanItemGroup == itemGroup).DeleteObject();
            MergeRemoveList.RemoveAll(o => o.MMAllocationPlanItemGroup == itemGroup);
        }
        #endregion Override BaseTransactionEntities
    }
}
