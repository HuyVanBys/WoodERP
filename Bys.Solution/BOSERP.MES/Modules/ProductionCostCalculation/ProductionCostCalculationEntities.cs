using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.ProductionCostCalculation
{
    public class ProductionCostCalculationEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSList<MMProductionCostCalculationDetailCostsInfo> MMProductionCostCalculationDetailCostsList { get; set; }

        public BOSList<MMProductionCostCalculationItemsInfo> ProductionCostCalculationItemsList { get; set; }

        public BOSList<MMProductionCostCalculationAllocationsInfo> ProductionCostCalculationAllocationsList { get; set; }

        public BOSList<MMProductionCostCalculationAllocationsInfo> ProductionCostCalculationAllocationOthersList { get; set; }

        public BOSList<MMProductionCostCalculationPricesInfo> ProductionCostCalculationPricesList { get; set; }
        #endregion

        #region Constructor
        public ProductionCostCalculationEntities()
            : base()
        {
            MMProductionCostCalculationDetailCostsList = new BOSList<MMProductionCostCalculationDetailCostsInfo>();
            ProductionCostCalculationItemsList = new BOSList<MMProductionCostCalculationItemsInfo>();
            ProductionCostCalculationAllocationsList = new BOSList<MMProductionCostCalculationAllocationsInfo>();
            ProductionCostCalculationAllocationOthersList = new BOSList<MMProductionCostCalculationAllocationsInfo>();
            ProductionCostCalculationPricesList = new BOSList<MMProductionCostCalculationPricesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMProductionCostCalculationsInfo();
            SearchObject = new MMProductionCostCalculationsInfo();
        }

        public override void InitModuleObjectList()
        {
            MMProductionCostCalculationDetailCostsList.InitBOSList(
                                              this,
                                              "MMProductionCostCalculations",
                                              "MMProductionCostCalculationDetailCosts",
                                              BOSList<MMProductionCostCalculationDetailCostsInfo>.cstRelationForeign);
            MMProductionCostCalculationDetailCostsList.ItemTableForeignKey = "FK_MMProductionCostCalculationID";

            ProductionCostCalculationItemsList.InitBOSList(
                                              this,
                                              "MMProductionCostCalculations",
                                              "MMProductionCostCalculationItems",
                                              BOSList<MMProductionCostCalculationItemsInfo>.cstRelationForeign);
            ProductionCostCalculationItemsList.ItemTableForeignKey = "FK_MMProductionCostCalculationID";

            ProductionCostCalculationAllocationsList.InitBOSList(
                                              this,
                                              "MMProductionCostCalculations",
                                              "MMProductionCostCalculationAllocations",
                                              BOSList<MMProductionCostCalculationAllocationsInfo>.cstRelationForeign);
            ProductionCostCalculationAllocationsList.ItemTableForeignKey = "FK_MMProductionCostCalculationID";

            ProductionCostCalculationAllocationOthersList.InitBOSList(
                                              this,
                                              "MMProductionCostCalculations",
                                              "MMProductionCostCalculationAllocations",
                                              BOSList<MMProductionCostCalculationAllocationsInfo>.cstRelationForeign);
            ProductionCostCalculationAllocationOthersList.ItemTableForeignKey = "FK_MMProductionCostCalculationID";

            ProductionCostCalculationPricesList.InitBOSList(
                                              this,
                                              "MMProductionCostCalculations",
                                              "MMProductionCostCalculationPrices",
                                              BOSList<MMProductionCostCalculationPricesInfo>.cstRelationForeign);
            ProductionCostCalculationPricesList.ItemTableForeignKey = "FK_MMProductionCostCalculationID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            MMProductionCostCalculationDetailCostsList.InitBOSListGridControl();
            ProductionCostCalculationItemsList.InitBOSListGridControl();
            ProductionCostCalculationAllocationsList.InitBOSListGridControl();
            ProductionCostCalculationAllocationOthersList.InitBOSListGridControl("fld_dgcMMProductionCostCalculationAllocationOthers");
            ProductionCostCalculationPricesList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                MMProductionCostCalculationDetailCostsList.SetDefaultListAndRefreshGridControl();
                ProductionCostCalculationItemsList.SetDefaultListAndRefreshGridControl();
                ProductionCostCalculationAllocationsList.SetDefaultListAndRefreshGridControl();
                ProductionCostCalculationAllocationOthersList.SetDefaultListAndRefreshGridControl();
                ProductionCostCalculationPricesList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMProductionCostCalculationDetailCostsList.Invalidate(iObjectID);
            ProductionCostCalculationItemsList.SetDefaultListAndRefreshGridControl();
            //MMProductionCostCalculationAllocationsController controller = new MMProductionCostCalculationAllocationsController();
            //List<MMProductionCostCalculationAllocationsInfo> allocations = controller.GetAllocationsByProductionCostCalculationID(iObjectID);
            ProductionCostCalculationAllocationsList.SetDefaultListAndRefreshGridControl();
            ProductionCostCalculationAllocationOthersList.SetDefaultListAndRefreshGridControl();
            ProductionCostCalculationPricesList.SetDefaultListAndRefreshGridControl();
        }
        public void InvalidateFocusModuleObjects(string type)
        {
            MMProductionCostCalculationsInfo ProductionCostCalculationsInfo = (MMProductionCostCalculationsInfo)MainObject;
            if (ProductionCostCalculationsInfo.MMProductionCostCalculationID == 0) return;
            if (!this.Module.Toolbar.IsNullOrNoneAction())
                return;
            if (type == "ReceiptItem")
            {
                if (ProductionCostCalculationItemsList.Count() > 0) return;
                ProductionCostCalculationItemsList.Invalidate(ProductionCostCalculationsInfo.MMProductionCostCalculationID);
            }
            else if (type == "Allocation")
            {
                if (ProductionCostCalculationAllocationsList.Count() > 0) return;
                MMProductionCostCalculationAllocationsController controller = new MMProductionCostCalculationAllocationsController();
                List<MMProductionCostCalculationAllocationsInfo> allocations = controller.GetAllocationsByProductionCostCalculationID(ProductionCostCalculationsInfo.MMProductionCostCalculationID);

                ProductionCostCalculationAllocationsList.Invalidate(allocations.Where(o => o.MMProductionCostCalculationAllocationFactorType != ProductionCostAllocationType.Theoyeutokhac.ToString()).ToList());
                ProductionCostCalculationAllocationOthersList.Invalidate(allocations.Where(o => o.MMProductionCostCalculationAllocationFactorType == ProductionCostAllocationType.Theoyeutokhac.ToString()).ToList());
            }
            else if (type == "Price")
            {
                if (ProductionCostCalculationPricesList.Count() > 0) return;
                MMProductionCostCalculationPricesController controller = new MMProductionCostCalculationPricesController();
                List<MMProductionCostCalculationPricesInfo> allocations = controller.GetPricesByProductionCostCalculationID(ProductionCostCalculationsInfo.MMProductionCostCalculationID);
                ProductionCostCalculationPricesList.Invalidate(allocations);
            }
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMProductionCostCalculationsInfo ProductionCostCalculationsInfo = (MMProductionCostCalculationsInfo)MainObject;
            ProductionCostCalculationsInfo.MMProductionCostCalculationDate = BOSApp.GetCurrentServerDate();
            ProductionCostCalculationsInfo.MMProductionCostCalculationFromDate = BOSUtil.GetMonthBeginDate();
            ProductionCostCalculationsInfo.MMProductionCostCalculationToDate = BOSUtil.GetMonthEndDate();
            UpdateMainObjectBindingSource();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("MMProductionCostCalculationDetailCosts", new MMProductionCostCalculationDetailCostsInfo());
            ModuleObjects.Add("MMProductionCostCalculationItems", new MMProductionCostCalculationDetailCostsInfo());
            ModuleObjects.Add("MMProductionCostCalculationAllocations", new MMProductionCostCalculationAllocationsInfo());
            ModuleObjects.Add("MMProductionCostCalculationPrices", new MMProductionCostCalculationPricesInfo());
        }

        public override bool CompleteTransaction()
        {
            MMProductionCostCalculationsInfo mainObject = (MMProductionCostCalculationsInfo)MainObject;
            mainObject.MMProductionCostCalculationStatus = "Complete";
            UpdateMainObject();
            return true;
        }
    }
}
