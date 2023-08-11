using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Acceptance
{
    public class AcceptanceEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ARAcceptanceItemsInfo> AcceptanceItemsList { get; set; }

        public BOSList<ARAcceptanceItemWorksInfo> AcceptanceItemCostsList { get; set; }

        #endregion

        #region Constructor
        public AcceptanceEntities()
            : base()
        {
            AcceptanceItemsList = new BOSList<ARAcceptanceItemsInfo>();
            AcceptanceItemCostsList = new BOSList<ARAcceptanceItemWorksInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARAcceptancesInfo();
            SearchObject = new ARAcceptancesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARAcceptanceItemsTableName, new ARAcceptanceItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AcceptanceItemsList.InitBOSList(this,
                                            TableName.ARAcceptancesTableName,
                                            TableName.ARAcceptanceItemsTableName,
                                            BOSList<ARAcceptanceItemsInfo>.cstRelationForeign);
            AcceptanceItemsList.ItemTableForeignKey = "FK_ARAcceptanceID";

            AcceptanceItemCostsList.InitBOSList(this,
                                            TableName.ARAcceptancesTableName,
                                            TableName.ARAcceptanceItemWorksTableName,
                                            BOSList<ARAcceptanceItemWorksInfo>.cstRelationForeign);
            AcceptanceItemCostsList.ItemTableForeignKey = "FK_ARAcceptanceID";
        }

        public override void InitGridControlInBOSList()
        {
            AcceptanceItemsList.InitBOSListGridControl(AcceptanceModule.AcceptanceItemsGridControlName);
            AcceptanceItemCostsList.InitBOSListGridControl(AcceptanceModule.AcceptanceItemCostsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AcceptanceItemsList.SetDefaultListAndRefreshGridControl();
                AcceptanceItemCostsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)MainObject;
            objAcceptancesInfo.ARAcceptanceDate = BOSApp.GetCurrentServerDate();
            objAcceptancesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAcceptancesInfo.ARAcceptanceStatus = BOSCommon.AcceptanceStatus.New.ToString();
            UpdateMainObjectBindingSource();
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARAcceptanceItemsController objAcceptanceItemsController = new ARAcceptanceItemsController();
            List<ARAcceptanceItemsInfo> acceptanceItems = objAcceptanceItemsController.GetAcceptanceItemsByAcceptanceID(iObjectID);
            AcceptanceItemsList.Invalidate(acceptanceItems);
            AcceptanceItemCostsList.Invalidate(iObjectID);
            ValidateItemProductSizeColor();
        }

        public override void SaveModuleObjects()
        {
            AcceptanceItemsList.SaveItemObjects();
            AcceptanceItemCostsList.SaveItemObjects();
        }

        public override bool CompleteTransaction()
        {
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)MainObject;
            objAcceptancesInfo.ARAcceptanceStatus = AcceptanceStatus.Complete.ToString();
            UpdateMainObject();

            return base.CompleteTransaction();
        }

        public void GenerateAcceptanceItemsFromSaleOrderItems(List<ARSaleOrderItemsInfo> saleOrderItems)
        {
            saleOrderItems.ForEach(o => AcceptanceItemsList.Add(ToAcceptanceItemsInfo(o)));
        }

        public ARAcceptanceItemsInfo ToAcceptanceItemsInfo(ARSaleOrderItemsInfo objSaleOrderItemsInfo)
        {
            ARAcceptanceItemsInfo objAcceptanceItemsInfo = new ARAcceptanceItemsInfo()
            {
                FK_ARSaleOrderID = objSaleOrderItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID,
                FK_ICDepartmentID = objSaleOrderItemsInfo.FK_ICDepartmentID,
                FK_ICProductGroupID = objSaleOrderItemsInfo.FK_ICProductGroupID,
                FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objSaleOrderItemsInfo.FK_ICMeasureUnitID,
                ARAcceptanceItemProductType = objSaleOrderItemsInfo.ARSaleOrderItemProductType,
                ARAcceptanceItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName,
                ARAcceptanceItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc,
                ARAcceptanceItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemShippedQty - objSaleOrderItemsInfo.ARAcceptanceItemAcceptancedQty,
                ARAcceptanceItemRemainedQty = objSaleOrderItemsInfo.ARSaleOrderItemShippedQty - objSaleOrderItemsInfo.ARAcceptanceItemAcceptancedQty,
                ARAcceptanceItemSaleOrderQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty,
                ARAcceptanceItemShippedQty = objSaleOrderItemsInfo.ARSaleOrderItemShippedQty,
                ARAcceptanceItemSaleOrderType = objSaleOrderItemsInfo.ARSaleOrderType,
                ICMeasureUnitName = objSaleOrderItemsInfo.ICMeasureUnitName,
                ARAcceptanceItemSOLength = objSaleOrderItemsInfo.ARSaleOrderItemLength,
                ARAcceptanceItemSOWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth,
                ARAcceptanceItemSOHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeight,
                ARAcceptanceItemWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth,
                ARAcceptanceItemHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeight,
                ARAcceptanceItemLength = objSaleOrderItemsInfo.ARSaleOrderItemLength,
                ARAcceptanceItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice,
                ARAcceptanceItemPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice * (objSaleOrderItemsInfo.ARSaleOrderItemShippedQty - objSaleOrderItemsInfo.ARAcceptanceItemAcceptancedQty),
                ARAcceptanceItemProductDiscount = objSaleOrderItemsInfo.ARSaleOrderItemProductDiscount,
                ARAcceptanceItemProductTaxPercent = objSaleOrderItemsInfo.ARSaleOrderItemProductTaxPercent,
                ICDepartmentName = objSaleOrderItemsInfo.ICDepartmentName,
                ARProposalName = objSaleOrderItemsInfo.ARProposalName,
                ARAcceptanceItemOneLevelArea = objSaleOrderItemsInfo.ARSaleOrderItemOneLevelArea,
                ARAcceptanceItemTwoLevelArea = objSaleOrderItemsInfo.ARSaleOrderItemTwoLevelArea,
                ARAcceptanceItemThreeLevelArea = objSaleOrderItemsInfo.ARSaleOrderItemThreeLevelArea,
                FK_ACCostCenterID = objSaleOrderItemsInfo.FK_ACCostCenterID,
                FK_ICSectionProductID = objSaleOrderItemsInfo.FK_ICSectionProductID,
                FK_PMTemplateItemID = objSaleOrderItemsInfo.FK_PMTemplateItemID,
                PMTemplateItemProductName = objSaleOrderItemsInfo.PMTemplateItemProductName,
                FK_ARProposalTemplateItemID = objSaleOrderItemsInfo.FK_ARProposalTemplateItemID,
                ARProposalTemplateItemProductName = objSaleOrderItemsInfo.ARProposalTemplateItemProductName,
            };
            objAcceptanceItemsInfo.ARAcceptanceItemDiscountAmount = (objAcceptanceItemsInfo.ARAcceptanceItemProductDiscount * objAcceptanceItemsInfo.ARAcceptanceItemPrice) / 100;
            objAcceptanceItemsInfo.ARAcceptanceItemTaxAmount = (objAcceptanceItemsInfo.ARAcceptanceItemProductTaxPercent * (objAcceptanceItemsInfo.ARAcceptanceItemPrice - objAcceptanceItemsInfo.ARAcceptanceItemDiscountAmount)) / 100;
            objAcceptanceItemsInfo.ARAcceptanceItemTotalAmount = objAcceptanceItemsInfo.ARAcceptanceItemPrice - objAcceptanceItemsInfo.ARAcceptanceItemDiscountAmount + objAcceptanceItemsInfo.ARAcceptanceItemTaxAmount;
            return objAcceptanceItemsInfo;
        }

        public void GenerateAcceptanceItemCostsFromSaleOrderItemCosts(List<ARSaleOrderItemWorksInfo> costList)
        {
            costList.ForEach(o => AcceptanceItemCostsList.Add(ToAcceptanceItemCostsInfo(o)));
        }

        public ARAcceptanceItemWorksInfo ToAcceptanceItemCostsInfo(ARSaleOrderItemWorksInfo item)
        {
            return new ARAcceptanceItemWorksInfo()
            {
                FK_ICProductID = item.FK_ICProductID,
                FK_ICProductGroupID = item.FK_ICProductGroupID,
                FK_ICDepartmentID = item.FK_ICDepartmentID,
                FK_ICMeasureUnitID = item.FK_ICMeasureUnitID,
                FK_ARSaleOrderItemWorkID = item.ARSaleOrderItemWorkID,
                ARAcceptanceItemWorkProductNo = item.ARSaleOrderItemWorkProductNo,
                ARAcceptanceItemWorkProductName = item.ARSaleOrderItemWorkProductName,
                ARAcceptanceItemWorkProductDesc = item.ARSaleOrderItemWorkProductDesc,
                ARAcceptanceItemWorkProductQty = item.ARSaleOrderItemWorkProductQty,
                ARAcceptanceItemWorkProductType = item.ARSaleOrderItemWorkProductType,
                ARAcceptanceItemWorkProductUnitPrice = item.ARSaleOrderItemWorkProductUnitPrice,
                ARAcceptanceItemWorkTotalAmount = item.ARSaleOrderItemWorkTotalAmount,
                ARAcceptanceItemWorkSubTotalAmount = item.ARSaleOrderItemWorkSubTotalAmount,
                ARAcceptanceItemWorkProductChargeCheck = item.ARSaleOrderItemWorkProductChargeCheck,
                ARAcceptanceItemWorkIsCost = item.ARSaleOrderItemWorkIsCost,
                ARAcceptanceItemWorkComment = item.ARSaleOrderItemWorkComment,
                ARAcceptanceItemWorkDiscountAmount = item.ARSaleOrderItemWorkDiscountAmount,
                ARAcceptanceItemWorkDiscountPercent = item.ARSaleOrderItemWorkDiscountPerCent,
                ARAcceptanceItemWorkTaxAmount = 0,
                ARAcceptanceItemWorkTaxPercent = 0,
            };
        }

        public void GenerateAcceptanceItem(List<ICShipmentItemsInfo> shipmentItems)
        {
            shipmentItems.ForEach(o => AcceptanceItemsList.Add(ToAcceptanceItemsInfo(o)));
        }

        private ARAcceptanceItemsInfo ToAcceptanceItemsInfo(ICShipmentItemsInfo item)
        {
            ARAcceptanceItemsInfo objAcceptanceItemsInfo = new ARAcceptanceItemsInfo()
            {
                FK_ARSaleOrderID = item.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = 0,
                FK_ICDepartmentID = item.FK_ICDepartmentID,
                FK_ICProductGroupID = item.FK_ICProductGroupID,
                FK_ICProductID = item.FK_ICProductID,
                FK_ICMeasureUnitID = item.FK_ICMeasureUnitID,
                ARAcceptanceItemProductType = item.ICShipmentItemProductType,
                ARAcceptanceItemProductName = item.ICShipmentItemProductName,
                ARAcceptanceItemProductDesc = item.ICShipmentItemProductDesc,
                ARAcceptanceItemProductQty = item.ICShipmentItemProductQty,
                ARAcceptanceItemRemainedQty = 0,
                ARAcceptanceItemSaleOrderQty = item.ICShipmentItemSaleOrderQty,
                ARAcceptanceItemShippedQty = item.ICShipmentItemProductQty,
                ARAcceptanceItemSaleOrderType = string.Empty,
                ICMeasureUnitName = item.ICMeasureUnitName,
                ARAcceptanceItemWidth = item.ICShipmentItemWidth,
                ARAcceptanceItemHeight = item.ICShipmentItemHeight,
                ARAcceptanceItemLength = item.ICShipmentItemLength,
                ARAcceptanceItemProductUnitPrice = item.ICShipmentItemProductUnitPrice,
                ARAcceptanceItemPrice = item.ICShipmentItemProductUnitPrice * item.ICShipmentItemProductQty,
                ARAcceptanceItemProductDiscount = item.ICShipmentItemProductDiscount,
                ARAcceptanceItemProductTaxPercent = item.ICShipmentItemProductTaxPercent,
                ICDepartmentName = item.ICDepartmentName,
                ARProposalName = item.ARProposalName,
                FK_ICShipmentID = item.FK_ICShipmentID,
                FK_ICShipmentItemID = item.Id,
                FK_ACCostCenterID = 0,
                FK_ICSectionProductID = item.FK_ICSectionProductID,
            };
            objAcceptanceItemsInfo.ARAcceptanceItemDiscountAmount = (objAcceptanceItemsInfo.ARAcceptanceItemProductDiscount * objAcceptanceItemsInfo.ARAcceptanceItemProductUnitPrice) / 100;
            objAcceptanceItemsInfo.ARAcceptanceItemTaxAmount = (objAcceptanceItemsInfo.ARAcceptanceItemProductTaxPercent * (objAcceptanceItemsInfo.ARAcceptanceItemPrice - objAcceptanceItemsInfo.ARAcceptanceItemDiscountAmount)) / 100;
            objAcceptanceItemsInfo.ARAcceptanceItemTotalAmount = objAcceptanceItemsInfo.ARAcceptanceItemPrice - objAcceptanceItemsInfo.ARAcceptanceItemDiscountAmount + objAcceptanceItemsInfo.ARAcceptanceItemTaxAmount;
            return objAcceptanceItemsInfo;
        }

        public void ValidateItemProductSizeColor()
        {
            AcceptanceItemsList.ForEach(p =>
            {
                p.ARAcceptanceItemColumnChangedNames.Clear();
                if (p.ARAcceptanceItemLength != p.ARAcceptanceItemSOLength)
                    p.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemLength");

                if (p.ARAcceptanceItemWidth != p.ARAcceptanceItemSOWidth)
                    p.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemWidth");

                if (p.ARAcceptanceItemHeight != p.ARAcceptanceItemSOHeight)
                    p.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemHeight");

                if (p.ARAcceptanceItemProductQty != p.ARAcceptanceItemSaleOrderQty)
                    p.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemProductQty");
            });

            AcceptanceItemsList.GridControl.RefreshDataSource();
        }
    }
}
