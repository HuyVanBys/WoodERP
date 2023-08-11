using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.CanceledDeliveryPlan
{
    public class CanceledDeliveryPlanEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ARCanceledDeliveryPlanItemsInfo> CanceledDeliveryPlanItemsList { get; set; }

        #endregion

        #region Constructor
        public CanceledDeliveryPlanEntities()
            : base()
        {
            CanceledDeliveryPlanItemsList = new BOSList<ARCanceledDeliveryPlanItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARCanceledDeliveryPlansInfo();
            SearchObject = new ARCanceledDeliveryPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARCanceledDeliveryPlanItemsTableName, new ARCanceledDeliveryPlanItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            CanceledDeliveryPlanItemsList.InitBOSList(this,
                                            TableName.ARCanceledDeliveryPlansTableName,
                                            TableName.ARCanceledDeliveryPlanItemsTableName,
                                            BOSList<ARCanceledDeliveryPlanItemsInfo>.cstRelationForeign);
            CanceledDeliveryPlanItemsList.ItemTableForeignKey = "FK_ARCanceledDeliveryPlanID";
        }

        public override void InitGridControlInBOSList()
        {
            CanceledDeliveryPlanItemsList.InitBOSListGridControl(CanceledDeliveryPlanModule.ARCanceledDeliveryPlanItemsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CanceledDeliveryPlanItemsList.SetDefaultListAndRefreshGridControl();
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

            ARCanceledDeliveryPlansInfo mainObject = (ARCanceledDeliveryPlansInfo)MainObject;
            mainObject.ARCanceledDeliveryPlanDate = BOSApp.GetCurrentServerDate();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARCanceledDeliveryPlanItemsController objCanceledDeliveryPlanItemsController = new ARCanceledDeliveryPlanItemsController();
            List<ARCanceledDeliveryPlanItemsInfo> CanceledDeliveryPlanItemList = objCanceledDeliveryPlanItemsController.GetCanceledDeliveryPlanItemByCanceledDeliveryPlanID(iObjectID);

            CanceledDeliveryPlanItemsList.Invalidate(CanceledDeliveryPlanItemList);
        }

        public override void SaveModuleObjects()
        {
            CanceledDeliveryPlanItemsList.SaveItemObjects();
        }

        public void GenerateCanceledDeliveryPlanItems(List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            deliveryPlanItems.ForEach(o =>
                {
                    CanceledDeliveryPlanItemsList.Add(ToCanceledDeliveryPlanItemsInfo(o));
                });
        }

        public ARCanceledDeliveryPlanItemsInfo ToCanceledDeliveryPlanItemsInfo(ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objDeliveryPlanItemsInfo.FK_ICProductID);
            return new ARCanceledDeliveryPlanItemsInfo()
            {
                FK_ICProductID = objDeliveryPlanItemsInfo.FK_ICProductID,
                ARCanceledDeliveryPlanItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber,
                ARCanceledDeliveryPlanItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys,
                ARCanceledDeliveryPlanItemProductNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductNo,
                ARCanceledDeliveryPlanItemProductName = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductName,
                ARCanceledDeliveryPlanItemProductDesc = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductDesc,
                ARCanceledDeliveryPlanItemQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemRemainedQty,
                ARCanceledDeliveryPlanItemTotalQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemRemainedQty,
                ARCanceledDeliveryPlanItemSaleOrderNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemSaleOrderNo,
                FK_ARDeliveryPlanItemID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID,
                FK_ARSaleOrderID = objDeliveryPlanItemsInfo.FK_ARSaleOrderID,
                FK_ICMeasureUnitID = objDeliveryPlanItemsInfo.FK_ICMeasureUnitID,
                FK_ICStockID = objDeliveryPlanItemsInfo.FK_ICStockID,
                ARCanceledDeliveryPlanItemWoodQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemWoodQty,
                ACObjectName = objDeliveryPlanItemsInfo.ACObjectName
            };
        }

        public override bool CompleteTransaction()
        {
            ARCanceledDeliveryPlansInfo mainObject = (ARCanceledDeliveryPlansInfo)MainObject;
            if (mainObject.ARCanceledDeliveryPlanStatus == CanceledDeliveryPlanStatus.New.ToString())
            {
                mainObject.ARCanceledDeliveryPlanStatus = CanceledDeliveryPlanStatus.Complete.ToString();
                UpdateMainObject();
            }
            if (mainObject.FK_ARDeliveryPlanID > 0)
            {
                UpdateReferenceDeliveryPlan();
            }
            return base.CompleteTransaction();
        }

        public void UpdateReferenceDeliveryPlan()
        {
            ARCanceledDeliveryPlansInfo mainObject = (ARCanceledDeliveryPlansInfo)MainObject;
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            List<ARDeliveryPlanItemsInfo> deliveryPlanItems = objDeliveryPlanItemsController.GetDeliveryPlanItemByDeliveryPlanID(mainObject.FK_ARDeliveryPlanID);

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            deliveryPlanItems.ForEach(o =>
            {
                ARCanceledDeliveryPlanItemsInfo objCanceledDeliveryPlanItemsInfo = CanceledDeliveryPlanItemsList.FirstOrDefault(x => x.FK_ARDeliveryPlanItemID == o.ARDeliveryPlanItemID);
                if (objCanceledDeliveryPlanItemsInfo == null)
                    return;
                o.ARDeliveryPlanItemCancelQty += objCanceledDeliveryPlanItemsInfo.ARCanceledDeliveryPlanItemQty;
                objDeliveryPlanItemsController.UpdateObject(o);
                if (mainObject.ARCanceledDeliveryPlanType == DeliveryPlanType.Day.ToString())
                {
                    objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(o.FK_ARSaleOrderItemID);
                    if (objSaleOrderItemsInfo == null)
                        return;
                    objSaleOrderItemsInfo.ARSaleOrderItemPlanQty -= objCanceledDeliveryPlanItemsInfo.ARCanceledDeliveryPlanItemQty;
                    objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);
                }
            });
            if (!deliveryPlanItems.Any(o => o.ARDeliveryPlanItemCancelQty < o.ARDeliveryPlanItemProductQty))
            {
                ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)objDeliveryPlansController.GetObjectByID(mainObject.FK_ARDeliveryPlanID);
                objDeliveryPlansInfo.ARDeliveryPlanStatus = DeliveryPlanStatus.Canceled.ToString();
                objDeliveryPlansController.UpdateObject(objDeliveryPlansInfo);
            }
            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
            objDeliveryPlanTruckPointsController.UpdateDeliveryPlanTruckPointsIsCanceledSaleOrder(mainObject.FK_ARDeliveryPlanID);
        }
    }
}
