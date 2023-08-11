using BOSCommon;
using BOSCommon.Constants;
using BOSLib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AllocationProposal
{
    public class AllocationProposalEntities : BaseTransactionEntities
    {
        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemMaterialList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemHardwareList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemPaintList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemPackagingList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemOtherMaterialList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemInstrumentList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemSemiProductList { get; set; }
        public List<MMAllocationPlanItemsInfo> CurrentItemList { get; set; }
        public List<MMAllocationPlanItemsInfo> DeletedItemsList { get; set; }

        public AllocationProposalEntities()
            : base()
        {
            AllocationPlanItemMaterialList = new BOSList<MMAllocationPlanItemsInfo>();
            AllocationPlanItemHardwareList = new BOSList<MMAllocationPlanItemsInfo>();
            AllocationPlanItemPaintList = new BOSList<MMAllocationPlanItemsInfo>();
            AllocationPlanItemPackagingList = new BOSList<MMAllocationPlanItemsInfo>();
            AllocationPlanItemOtherMaterialList = new BOSList<MMAllocationPlanItemsInfo>();
            AllocationPlanItemInstrumentList = new BOSList<MMAllocationPlanItemsInfo>();
            AllocationPlanItemSemiProductList = new BOSList<MMAllocationPlanItemsInfo>();

            CurrentItemList = new List<MMAllocationPlanItemsInfo>();
            DeletedItemsList = new List<MMAllocationPlanItemsInfo>();
        }

        public override void InitMainObject()
        {
            MainObject = new MMAllocationPlansInfo();
            SearchObject = new MMAllocationPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMAllocationPlanItemsTableName, new MMAllocationPlanItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AllocationPlanItemMaterialList.InitBOSList(this,
                                                       TableName.MMAllocationPlansTableName,
                                                       TableName.MMAllocationPlanItemsTableName,
                                                       BOSList<MMAllocationPlanItemsInfo>.cstRelationForeign);
            AllocationPlanItemMaterialList.ItemTableForeignKey = "FK_MMAllocationPlanID";

            AllocationPlanItemOtherMaterialList.InitBOSList(this,
                                                       TableName.MMAllocationPlansTableName,
                                                       TableName.MMAllocationPlanItemsTableName,
                                                       BOSList<MMAllocationPlanItemsInfo>.cstRelationForeign);
            AllocationPlanItemOtherMaterialList.ItemTableForeignKey = "FK_MMAllocationPlanID";

            AllocationPlanItemHardwareList.InitBOSList(this,
                                                       TableName.MMAllocationPlansTableName,
                                                       TableName.MMAllocationPlanItemsTableName,
                                                       BOSList<MMAllocationPlanItemsInfo>.cstRelationForeign);
            AllocationPlanItemHardwareList.ItemTableForeignKey = "FK_MMAllocationPlanID";

            AllocationPlanItemPaintList.InitBOSList(this,
                                                       TableName.MMAllocationPlansTableName,
                                                       TableName.MMAllocationPlanItemsTableName,
                                                       BOSList<MMAllocationPlanItemsInfo>.cstRelationForeign);
            AllocationPlanItemPaintList.ItemTableForeignKey = "FK_MMAllocationPlanID";

            AllocationPlanItemPackagingList.InitBOSList(this,
                                                       TableName.MMAllocationPlansTableName,
                                                       TableName.MMAllocationPlanItemsTableName,
                                                       BOSList<MMAllocationPlanItemsInfo>.cstRelationForeign);
            AllocationPlanItemPackagingList.ItemTableForeignKey = "FK_MMAllocationPlanID";

            AllocationPlanItemInstrumentList.InitBOSList(this,
                                                       TableName.MMAllocationPlansTableName,
                                                       TableName.MMAllocationPlanItemsTableName,
                                                       BOSList<MMAllocationPlanItemsInfo>.cstRelationForeign);
            AllocationPlanItemInstrumentList.ItemTableForeignKey = "FK_MMAllocationPlanID";

            AllocationPlanItemSemiProductList.InitBOSList(this,
                                                       TableName.MMAllocationPlansTableName,
                                                       TableName.MMAllocationPlanItemsTableName,
                                                       BOSList<MMAllocationPlanItemsInfo>.cstRelationForeign);
            AllocationPlanItemSemiProductList.ItemTableForeignKey = "FK_MMAllocationPlanID";
        }

        public override void InitGridControlInBOSList()
        {
            AllocationPlanItemMaterialList.InitBOSListGridControl(AllocationProposalModule.AllocationPlanItemMaterialList);
            AllocationPlanItemOtherMaterialList.InitBOSListGridControl(AllocationProposalModule.AllocationPlanItemOtherMaterialList);
            AllocationPlanItemHardwareList.InitBOSListGridControl(AllocationProposalModule.AllocationPlanItemHardwareList);
            AllocationPlanItemPaintList.InitBOSListGridControl(AllocationProposalModule.AllocationPlanItemPaintList);
            AllocationPlanItemPackagingList.InitBOSListGridControl(AllocationProposalModule.AllocationPlanItemPackagingList);
            AllocationPlanItemInstrumentList.InitBOSListGridControl(AllocationProposalModule.AllocationPlanItemInstrumentList);
            AllocationPlanItemSemiProductList.InitBOSListGridControl(AllocationProposalModule.AllocationPlanItemSemiProductList);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)MainObject;
            objAllocationPlansInfo.MMAllocationPlanDate = Module.GetServerDate();
            objAllocationPlansInfo.MMAllocationPlanStatus = AllocationPlanStatus.New.ToString();
            objAllocationPlansInfo.MMAllocationPlanType = AllocationPlanCreateFrom.Normal.ToString();
            objAllocationPlansInfo.MMAllocationPlanPurpose = AllocationPlanPurpose.Production.ToString();
            objAllocationPlansInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AllocationPlanItemMaterialList.SetDefaultListAndRefreshGridControl();
                AllocationPlanItemOtherMaterialList.SetDefaultListAndRefreshGridControl();
                AllocationPlanItemHardwareList.SetDefaultListAndRefreshGridControl();
                AllocationPlanItemPaintList.SetDefaultListAndRefreshGridControl();
                AllocationPlanItemPackagingList.SetDefaultListAndRefreshGridControl();
                AllocationPlanItemInstrumentList.SetDefaultListAndRefreshGridControl();
                AllocationPlanItemSemiProductList.SetDefaultListAndRefreshGridControl();
                CurrentItemList.Clear();
                DeletedItemsList.Clear();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            DeletedItemsList.Clear();
        }

        public override int SaveMainObject()
        {
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)MainObject;
            mainobject.MMAllocationPlanStatus = AllocationPlanStatus.Saved.ToString();
            return base.SaveMainObject();
        }

        public void SaveAllocationPlanItems(BOSList<MMAllocationPlanItemsInfo> bpPniList, string itemGroup)
        {
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)MainObject;
            bpPniList.ForEach(o => o.FK_MMAllocationPlanID = mainobject.MMAllocationPlanID);
            bpPniList.InsertOrUpdateObject();
            DeletedItemsList.Where(o => o.MMAllocationPlanItemGroup == itemGroup).DeleteObject();
            DeletedItemsList.RemoveAll(o => o.MMAllocationPlanItemGroup == itemGroup);
        }

        public override void SaveModuleObjects()
        {
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)MainObject;
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<string> selectedTab = ((AllocationProposalModule)Module).SelectionSelectedTabs.Distinct().ToList();
            selectedTab.ForEach(tabName =>
            {
                switch (tabName)
                {
                    case "fld_tabMaterial":
                        SaveAllocationPlanItems(AllocationPlanItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                        break;
                    case "fld_tabOtherMaterial":
                        SaveAllocationPlanItems(AllocationPlanItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                        break;
                    case "fld_tabHardware":
                        SaveAllocationPlanItems(AllocationPlanItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                        break;
                    case "fld_tabIngredientPaint":
                        SaveAllocationPlanItems(AllocationPlanItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                        break;
                    case "fld_tabIngredientPackaging":
                        SaveAllocationPlanItems(AllocationPlanItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                        break;
                    case "fld_tabGeneralMaterial":
                        SaveAllocationPlanItems(AllocationPlanItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                        break;
                }
            });
            DeletedItemsList.Clear();
        }
    }
}

