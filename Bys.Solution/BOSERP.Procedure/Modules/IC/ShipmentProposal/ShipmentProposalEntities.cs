using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentProposal
{
    class ShipmentProposalEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the shipment proposal item list
        /// </summary>
        public BOSList<ICShipmentProposalItemsInfo> ShipmentProposalItemList { get; set; }


        #endregion

        #region Constructor
        public ShipmentProposalEntities()
            : base()
        {
            ShipmentProposalItemList = new BOSList<ICShipmentProposalItemsInfo>();

        }


        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICShipmentProposalsInfo();
            SearchObject = new ICShipmentProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICShipmentProposalItemsTableName, new ICShipmentProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ShipmentProposalItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentProposalsTableName,
                                        TableName.ICShipmentProposalItemsTableName,
                                        BOSList<ICShipmentProposalItemsInfo>.cstRelationForeign);

            ShipmentProposalItemList.ItemTableForeignKey = "FK_ICShipmentProposalID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentProposalItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICShipmentProposalsInfo objProposalsInfo = (ICShipmentProposalsInfo)MainObject;
            objProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objProposalsInfo.ICShipmentProposalDate = DateTime.Now;
            objProposalsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objProposalsInfo.ICShipmentProposalDeliveryDate = DateTime.Now;
            objProposalsInfo.ICShipmentProposalActualDeliveryDate = DateTime.Now;
            objProposalsInfo.ICShipmentProposalType = ShipmentProposalType.MassProduction.ToString();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentProposalItemList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ShipmentProposalItemList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {

            if (ShipmentProposalItemList.Count > 0)
            {
                int couterror = 0;
                foreach (ICShipmentProposalItemsInfo item in ShipmentProposalItemList)
                {
                    if (item.ICShipmentProposalItemProductQty <= 0)
                    {
                        couterror++;
                    }
                }
                if (couterror <= 0)
                {
                    return base.SaveMainObject();
                }
                else
                {
                    MessageBox.Show(Localization.ShipmentProposalLocalizedResources.ErrorICShipmentProposalItemProductQty, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            return base.SaveMainObject();


        }
        public override void SaveModuleObjects()
        {

            ShipmentProposalItemList.SaveItemObjects();
            //ShipmentProposalEntities entity = (ShipmentProposalEntities)cur;
            ICShipmentProposalsInfo objShipmentProposalsInfo = new ICShipmentProposalsInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            if (objShipmentProposalsInfo.ICShipmentProposalReference != String.Empty && objShipmentProposalsInfo.ICShipmentProposalType == ShipmentProposalStatus.Approved.ToString())
            {
                foreach (ICShipmentProposalItemsInfo item in ShipmentProposalItemList)
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                    if (objSaleOrderItemsInfo != null)
                    {

                        objSaleOrderItemsInfo.ARSaleOrderItemProposedQty += item.ICShipmentProposalItemProductQty;
                        objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);
                        //EnableToolbar();
                        //entity.UpdateMainObject();


                    }
                }
            }
        }
        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            //objShipmentProposalsInfo.ICShipmentProposalNo = String.Empty();


            if (objProductsInfo != null)
            {
                ICShipmentProposalItemsInfo objICShipmentProposalItemsInfo = (ICShipmentProposalItemsInfo)ModuleObjects[TableName.ICShipmentProposalItemsTableName];
                objICShipmentProposalItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);


                objICShipmentProposalItemsInfo.ICShipmentProposalItemProductName = objProductsInfo.ICProductName;

                objICShipmentProposalItemsInfo.ICShipmentProposalItemProductDesc = objProductsInfo.ICProductDesc;

                objICShipmentProposalItemsInfo.FK_ICProductAttributeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                objICShipmentProposalItemsInfo.FK_ICProductAttributeColor = objProductsInfo.FK_ICProductAttributeColorID;
                objICShipmentProposalItemsInfo.FK_ICProductAttributePaintType = objProductsInfo.FK_ICProductAttributeFinishingID;
                objICShipmentProposalItemsInfo.ICShipmentProposalItemProductRemainQty = objICShipmentProposalItemsInfo.ICShipmentProposalItemProductQty;
                objICShipmentProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;

                UpdateModuleObjectBindingSource(TableName.ICShipmentProposalItemsTableName);

            }


        }
        public void GenerateEntitiesFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo, List<ARSaleOrderItemsInfo> saleOrderItemList)
        {
            //Generate SaleOrder            
            GenerateShipmentProposalFromSaleOrder(objSaleOrdersInfo);

            //Generate SaleOrder items
            GenerateSaleOrderItemsFromSaleOrder(saleOrderItemList, objSaleOrdersInfo);

            //UpdateTotalAmount();
        }
        /// <summary>
        /// Generate an SaleOrder from a given sale order and set to main object
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale forecast</param>
        private void GenerateShipmentProposalFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            //Copy ShipmentProposal
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)MainObject;
            ICShipmentProposalsInfo oldShipmentProposalsInfo = (ICShipmentProposalsInfo)MainObject.Clone();
            BOSUtil.CopyObject(objSaleOrdersInfo, objShipmentProposalsInfo);
            objShipmentProposalsInfo.FK_HREmployeeID = oldShipmentProposalsInfo.FK_HREmployeeID;
            //TKChinh Add PO No 
            objShipmentProposalsInfo.ICShipmentProposalPONo = objSaleOrdersInfo.ARSaleOrderPONo;

            objShipmentProposalsInfo.FK_MMBatchProductID = objSaleOrdersInfo.FK_MMBatchProductID;

            if (BOSApp.CurrentCompanyInfo != null)
                objShipmentProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        /// <summary>
        /// Generate invoice items from a given sale order and add them to the current invoice item list        
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale order</param>
        private void GenerateSaleOrderItemsFromSaleOrder(List<ARSaleOrderItemsInfo> saleOrderItemList, ARSaleOrdersInfo objSaleOrdersInfo)
        {
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)MainObject;
            objShipmentProposalsInfo.ICShipmentProposalNo = "***NEW***";

            BOSList<ARSaleOrderItemsInfo> saleOrderItems = new BOSList<ARSaleOrderItemsInfo>();


            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();

            saleOrderItems.InitBOSList(null, TableName.ARSaleOrdersTableName, TableName.ARSaleOrderItemsTableName, BOSList<ARSaleOrderItemsInfo>.cstRelationForeign);
            saleOrderItems.Invalidate(saleOrderItemList);

            ICShipmentProposalItemsController objShipmentProposalItemsController = new ICShipmentProposalItemsController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            objShipmentProposalsInfo.ICShipmentProposalStatus = ShipmentProposalStatus.New.ToString();

            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in saleOrderItems)
            {
                ICShipmentProposalItemsInfo ShipmentProposalItems = new ICShipmentProposalItemsInfo();
                BOSUtil.CopyObject(objSaleOrderItemsInfo, ShipmentProposalItems);
                ShipmentProposalItems.FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID;
                ShipmentProposalItems.FK_ICMeasureUnitID = objSaleOrderItemsInfo.FK_ICMeasureUnitID;
                ShipmentProposalItems.ICShipmentProposalItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty;
                ShipmentProposalItems.ICShipmentProposalItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName;
                ShipmentProposalItems.ICShipmentProposalItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc;
                ShipmentProposalItems.FK_ICProductAttributeID = objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID;
                ShipmentProposalItems.ICShipmentProposalItemPONo = objSaleOrderItemsInfo.ARSaleOrderItemPONo;

                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(ShipmentProposalItems.FK_ICProductID);
                ShipmentProposalItems.FK_ICProductAttributeColor = objProductsInfo.FK_ICProductAttributeColorID;
                ShipmentProposalItems.FK_ICProductAttributePaintType = objProductsInfo.FK_ICProductAttributeFinishingID;
                ShipmentProposalItems.ICShipmentProposalItemProductRemainQty = ShipmentProposalItems.ICShipmentProposalItemProductQty;
                objShipmentProposalsInfo.ICShipmentProposalReference = objSaleOrderItemsInfo.ARSaleOrderNo;
                ShipmentProposalItems.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                ShipmentProposalItems.FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID;
                objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(objSaleOrderItemsInfo.ARSaleOrderNo);
                ShipmentProposalItems.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                ShipmentProposalItems.ICShipmentProposalItemColorText = objSaleOrderItemsInfo.ARSaleOrderItemColorText;
                ShipmentProposalItems.ICShipmentProposalItemHTText = objSaleOrderItemsInfo.ARSaleOrderItemHTText;
                ShipmentProposalItems.FK_MMBatchProductID = objSaleOrderItemsInfo.FK_MMBatchProductID;
                objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetbySaleorderID(objSaleOrderItemsInfo.ARSaleOrderItemID).FirstOrDefault();
                if (objBatchProductItemsInfo != null)
                {
                    ShipmentProposalItems.FK_ICProductAttributeID = objBatchProductItemsInfo.FK_ICProductAttributeWoodTypeID;
                    ShipmentProposalItems.ICShipmentProposalItemProductSerialNo = objBatchProductItemsInfo.MMBatchProductItemProductSerial;
                }
                if (objProductsInfo != null)
                {
                    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                           objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                    {
                        ShipmentProposalItems.ICShipmentProposalItemProductQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                        ShipmentProposalItems.ICShipmentProposalItemProductRemainQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductRemainQty, 4, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        ShipmentProposalItems.ICShipmentProposalItemProductQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductQty, 2, MidpointRounding.AwayFromZero);
                        ShipmentProposalItems.ICShipmentProposalItemProductRemainQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductRemainQty, 2, MidpointRounding.AwayFromZero);
                    }
                }
                ShipmentProposalItems.FK_ICProductSerieID = objSaleOrderItemsInfo.FK_ICProductSerieID;
                ShipmentProposalItemList.Add(ShipmentProposalItems);
            }

        }
        /// <summary>
        /// Approve all items of the proposal
        /// </summary>
        public bool ApproveShipmentProposalItem()
        {
            SetPropertyChangeEventLock(false);
            foreach (ICShipmentProposalItemsInfo objShipmentProposalItemsInfo in ShipmentProposalItemList)
            {
                if (objShipmentProposalItemsInfo.ICShipmentProposalItemStatus == ShipmentProposalItemStatus.New.ToString())
                {
                    objShipmentProposalItemsInfo.ICShipmentProposalItemStatus = ShipmentProposalItemStatus.Approved.ToString();
                    //UpdateInvoiceReferrenceStatus(objShipmentProposalItemsInfo, ShipmentProposalItemStatus.Approved.ToString());
                }
            }
            ShipmentProposalItemList.SaveItemObjects();

            //Update the proposal's status
            ICShipmentProposalsInfo objProposalsInfo = (ICShipmentProposalsInfo)MainObject;
            objProposalsInfo.ICShipmentProposalStatus = ShipmentProposalStatus.Approved.ToString();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);

            return true;
        }
        public bool DiscardProposal()
        {
            SetPropertyChangeEventLock(false);
            foreach (ICShipmentProposalItemsInfo objProposalItemsInfo in ShipmentProposalItemList)
            {
                if (objProposalItemsInfo.ICShipmentProposalItemStatus != ShipmentProposalItemStatus.Finish.ToString())
                {
                    objProposalItemsInfo.ICShipmentProposalItemStatus = ShipmentProposalItemStatus.Canceled.ToString();
                    //UpdateInvoiceReferrenceStatus(objProposalItemsInfo, ShipmentProposalItemStatus.Canceled.ToString());
                }
            }
            ShipmentProposalItemList.SaveItemObjects();

            //Update the proposal's status
            ICShipmentProposalsInfo objProposalsInfo = (ICShipmentProposalsInfo)MainObject;
            objProposalsInfo.ICShipmentProposalStatus = ShipmentProposalStatus.Canceled.ToString();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);

            return true;
        }
        public void UpdateALLProposalItemStatus(string objShipmentProposalItemStatus)
        {
            SetPropertyChangeEventLock(false);
            foreach (ICShipmentProposalItemsInfo objProposalItemsInfo in ShipmentProposalItemList)
            {
                if (objProposalItemsInfo.ICShipmentProposalItemStatus != ShipmentProposalItemStatus.Finish.ToString())
                {
                    objProposalItemsInfo.ICShipmentProposalItemStatus = objShipmentProposalItemStatus;
                    //UpdateInvoiceReferrenceStatus(objProposalItemsInfo, objShipmentProposalItemStatus);
                }
            }
        }

        public override bool CompleteTransaction()
        {
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)MainObject;

            if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalStatus.New.ToString())
            {
                objShipmentProposalsInfo.ICShipmentProposalStatus = ShipmentProposalStatus.Approved.ToString();
                objShipmentProposalsInfo.FK_HRApprovedEmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objShipmentProposalsInfo.ICShipmentProposalApprovedDate = DateTime.Now;
                UpdateALLProposalItemStatus(ShipmentProposalItemStatus.Approved.ToString());
                UpdateMainObject();

            }

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            if (objShipmentProposalsInfo.ICShipmentProposalReference != String.Empty)
            {
                foreach (ICShipmentProposalItemsInfo item in ShipmentProposalItemList)
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                    if (objSaleOrderItemsInfo != null)
                    {
                        objSaleOrderItemsInfo.ARSaleOrderItemProposedQty += item.ICShipmentProposalItemProductQty;
                        objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);

                    }
                }
            }

            ARContainerLoaderItemsController objContainerLoaderItemsController = new ARContainerLoaderItemsController();
            foreach (ICShipmentProposalItemsInfo item in ShipmentProposalItemList)
            {
                ARContainerLoaderItemsInfo objContainerLoaderItemsInfo = (ARContainerLoaderItemsInfo)objContainerLoaderItemsController.GetObjectByID(item.FK_ARContainerLoaderItemID);
                if (objContainerLoaderItemsInfo != null)
                {
                    objContainerLoaderItemsInfo.ARContainerLoaderItemProposedQty += item.ICShipmentProposalItemProductQty;
                    objContainerLoaderItemsController.UpdateObject(objContainerLoaderItemsInfo);

                }
            }


            return true;
        }




    }

    #endregion

}

