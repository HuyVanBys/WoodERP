using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.EquipmentDecreasing
{
    public class EquipmentDecreasingEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the item list of the shipment
        /// </summary>
        public BOSItemsEntityList<ICShipmentItemsInfo> ShipmentItemList { get; set; }
        #endregion

        #region Constructor
        public EquipmentDecreasingEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICShipmentsInfo();
            SearchObject = new ICShipmentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICShipmentItemsTableName, new ICShipmentItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(EquipmentDecreasingModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(EquipmentDecreasingModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
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

            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.EquipmentDecreasing.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> items = objShipmentItemsController.GetEquipmentItemsByShipmentID(iObjectID);
            ShipmentItemList.Invalidate(items);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ShipmentItemList.SaveItemObjects();

            SaveAccountingData();

            ICShipmentItemsController shipmentItemsController = new ICShipmentItemsController();
            ACEquipmentTransferItemsController equipmentTransferItemController = new ACEquipmentTransferItemsController();
            ICProductIdentifiedEquipmentsController pieController = new ICProductIdentifiedEquipmentsController();
            //rollback old remainedQty 
            if (ShipmentItemList.BackupList != null)
            {
                foreach (ICShipmentItemsInfo item in ShipmentItemList.BackupList)
                {
                    ICShipmentItemsInfo newItem = ShipmentItemList.FirstOrDefault(i => i.Id == item.Id);
                    if (newItem != null)
                    {
                        if (item.FK_ACEquipmentTransferItemID != 0)// && item.FK_ACEquipmentTransferItemID != newItem.FK_ACEquipmentTransferItemID)
                        {
                            ACEquipmentTransferItemsInfo foundItem = equipmentTransferItemController.GetObjectByID(item.FK_ACEquipmentTransferItemID) as ACEquipmentTransferItemsInfo;
                            if (foundItem != null)
                            {
                                foundItem.ACEquipmentTransferItemRemainedQty += item.ICShipmentItemProductQty;
                                equipmentTransferItemController.UpdateObject(foundItem);
                            }
                        }

                        if (item.FK_ICEquipmentShipmentItemID != 0)// && item.FK_ICEquipmentShipmentItemID != newItem.FK_ICEquipmentShipmentItemID)
                        {
                            ICShipmentItemsInfo foundItem = shipmentItemsController.GetObjectByID(item.FK_ICEquipmentShipmentItemID) as ICShipmentItemsInfo;
                            if (foundItem != null)
                            {
                                foundItem.ICShipmentItemProductRemainedQty += item.ICShipmentItemProductQty;
                                shipmentItemsController.UpdateObject(foundItem);
                            }
                        }
                        if (item.FK_ICProductIdentifiedEquipmentID != 0)
                        {
                            ICProductIdentifiedEquipmentsInfo objProductIdentifiedEquipmentsInfo = (ICProductIdentifiedEquipmentsInfo)pieController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                            if (objProductIdentifiedEquipmentsInfo != null)
                            {
                                objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.Using.ToString();
                                pieController.UpdateObject(objProductIdentifiedEquipmentsInfo);
                            }
                        }
                    }
                }
            }

            //update new remainedQty
            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                if (item.FK_ICEquipmentShipmentItemID > 0)
                {
                    ICShipmentItemsInfo foundItem = shipmentItemsController.GetObjectByID(item.FK_ICEquipmentShipmentItemID) as ICShipmentItemsInfo;
                    //foundItem.ICShipmentItemProductRemainedQty = item.EquipmentReceiptedQty;
                    foundItem.ICShipmentItemProductRemainedQty = foundItem.ICShipmentItemProductRemainedQty - item.ICShipmentItemProductQty;
                    shipmentItemsController.UpdateObject(foundItem);
                }
                else if (item.FK_ACEquipmentTransferItemID > 0)
                {
                    ACEquipmentTransferItemsInfo foundItem = equipmentTransferItemController.GetObjectByID(item.FK_ACEquipmentTransferItemID) as ACEquipmentTransferItemsInfo;
                    //foundItem.ACEquipmentTransferItemRemainedQty = item.EquipmentReceiptedQty;
                    foundItem.ACEquipmentTransferItemRemainedQty = foundItem.ACEquipmentTransferItemRemainedQty - item.ICShipmentItemProductQty;
                    equipmentTransferItemController.UpdateObject(foundItem);
                }
                if (item.FK_ICProductIdentifiedEquipmentID > 0)
                {
                    ICProductIdentifiedEquipmentsInfo objProductIdentifiedEquipmentsInfo = (ICProductIdentifiedEquipmentsInfo)pieController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                    if (objProductIdentifiedEquipmentsInfo != null)
                    {
                        objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.StopUsing.ToString();
                        pieController.UpdateObject(objProductIdentifiedEquipmentsInfo);
                    }
                }
            }
        }
        #endregion       

        #region Accounting
        public override bool SaveAccountingData()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);
                objDocumentsInfo.FK_ACAssObjectID = objShipmentsInfo.FK_ACObjectID;
                objDocumentsInfo.ACObjectType = objShipmentsInfo.ICObjectType;
            }
            return base.SaveAccountingData();
        }
        #endregion
    }
}
