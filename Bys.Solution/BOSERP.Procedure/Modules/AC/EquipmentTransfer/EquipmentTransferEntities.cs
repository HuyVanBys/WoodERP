using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.EquipmentTransfer
{
    public class EquipmentTransferEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of equipment transfer items
        /// </summary>
        public BOSList<ACEquipmentTransferItemsInfo> EquipmentTransferItemList { get; set; }
        #endregion

        #region Constructor
        public EquipmentTransferEntities()
            : base()
        {
            EquipmentTransferItemList = new BOSList<ACEquipmentTransferItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACDocumentsInfo();
            SearchObject = new ACDocumentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACEquipmentTransferItemsTableName, new ACEquipmentTransferItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            EquipmentTransferItemList.InitBOSList(this,
                                            TableName.ACDocumentsTableName,
                                            TableName.ACEquipmentTransferItemsTableName,
                                            BOSList<ACEquipmentTransferItemsInfo>.cstRelationForeign);
            EquipmentTransferItemList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            EquipmentTransferItemList.InitBOSListGridControl(EquipmentTransferModule.EquipmentTransferItemGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.FK_ACDocumentTypeID = DefaultDocumentTypeID;
            objDocumentsInfo.ACDocumentDate = DateTime.Now;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EquipmentTransferItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
            List<ACEquipmentTransferItemsInfo> items = objEquipmentTransferItemsController.GetItemsByDocumentID(iObjectID);
            EquipmentTransferItemList.Invalidate(items);
        }

        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentTotalAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryAmount);
            objDocumentsInfo.ACDocumentExchangeAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryExchangeAmount);
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {

            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();

            foreach (ACEquipmentTransferItemsInfo item in EquipmentTransferItemList)
            {
                ICProductIdentifiedEquipmentsInfo objProductIdentifiedEquipmentsInfo = (ICProductIdentifiedEquipmentsInfo)objProductIdentifiedEquipmentsController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                if (objProductIdentifiedEquipmentsInfo != null)
                {
                    item.ACEquipmentTransferItemProductIdentifiedEquipmentNo = objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentNo;

                }
            }
            EquipmentTransferItemList.SaveItemObjects();
            ICShipmentItemsController shipmentItemsController = new ICShipmentItemsController();
            ACEquipmentTransferItemsController equipmentTransferItemController = new ACEquipmentTransferItemsController();
            //rollback remainedQty 
            if (EquipmentTransferItemList.BackupList != null)
            {
                foreach (ACEquipmentTransferItemsInfo item in EquipmentTransferItemList.BackupList)
                {
                    ACEquipmentTransferItemsInfo newItem = EquipmentTransferItemList.FirstOrDefault(i => i.ACEquipmentTransferItemID == item.ACEquipmentTransferItemID);
                    if (newItem != null)
                    {
                        if (item.FK_ACEquipmentTransferItemID != 0)//&& item.FK_ACEquipmentTransferItemID != newItem.FK_ACEquipmentTransferItemID)
                        {
                            ACEquipmentTransferItemsInfo foundItem = equipmentTransferItemController.GetObjectByID(item.FK_ACEquipmentTransferItemID) as ACEquipmentTransferItemsInfo;
                            if (foundItem != null)
                            {
                                foundItem.ACEquipmentTransferItemRemainedQty += item.ACEquipmentTransferItemQty;
                                equipmentTransferItemController.UpdateObject(foundItem);
                            }
                        }

                        if (item.FK_ICEquipmentShipmentItemID != 0)// && item.FK_ICEquipmentShipmentItemID != newItem.FK_ICEquipmentShipmentItemID)
                        {
                            ICShipmentItemsInfo foundItem = shipmentItemsController.GetObjectByID(item.FK_ICEquipmentShipmentItemID) as ICShipmentItemsInfo;
                            if (foundItem != null)
                            {
                                foundItem.ICShipmentItemProductRemainedQty += item.ACEquipmentTransferItemQty;
                                shipmentItemsController.UpdateObject(foundItem);
                            }
                        }

                    }
                }
            }


            //update new remainedQty
            foreach (ACEquipmentTransferItemsInfo item in EquipmentTransferItemList)
            {
                if (item.FK_ICEquipmentShipmentItemID > 0)
                {
                    ICShipmentItemsInfo foundItem = shipmentItemsController.GetObjectByID(item.FK_ICEquipmentShipmentItemID) as ICShipmentItemsInfo;
                    if (foundItem != null)
                    {
                        //foundItem.ICShipmentItemProductRemainedQty = item.EquipmentReceiptedQty;
                        foundItem.ICShipmentItemProductRemainedQty = foundItem.ICShipmentItemProductRemainedQty - item.ACEquipmentTransferItemQty;
                        shipmentItemsController.UpdateObject(foundItem);
                    }
                }
                else if (item.FK_ACEquipmentTransferItemID > 0)
                {
                    ACEquipmentTransferItemsInfo foundItem = equipmentTransferItemController.GetObjectByID(item.FK_ACEquipmentTransferItemID) as ACEquipmentTransferItemsInfo;
                    if (foundItem != null)
                    {
                        //foundItem.ACEquipmentTransferItemRemainedQty = item.EquipmentReceiptedQty;
                        foundItem.ACEquipmentTransferItemRemainedQty = foundItem.ACEquipmentTransferItemRemainedQty - item.ACEquipmentTransferItemQty;
                        equipmentTransferItemController.UpdateObject(foundItem);
                    }
                }

                //TNDLoc [ADD][26/04/2016][Update DepartmentRoom],START
                ICProductIdentifiedEquipmentsInfo objProductIdentifiedEquipmentsInfo = (ICProductIdentifiedEquipmentsInfo)objProductIdentifiedEquipmentsController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                if (objProductIdentifiedEquipmentsInfo != null)
                {
                    if (item.ACEquipmentTransferItemType == EquipmentTransferItemType.Receipt.ToString())
                    {
                        objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.SuspendedUsing.ToString();
                    }
                    else
                    {
                        objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.Using.ToString();
                        objProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomID = item.FK_HRToRoomID;
                        objProductIdentifiedEquipmentsInfo.FK_MMWorkShopID = item.FK_MMToWorkShopID;
                        objProductIdentifiedEquipmentsInfo.FK_MMLineID = item.FK_MMToLineID;
                        objProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRToDepartmentRoomGroupItemID;
                        objProductIdentifiedEquipmentsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                        objProductIdentifiedEquipmentsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                        objProductIdentifiedEquipmentsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                        objProductIdentifiedEquipmentsInfo.FK_ACSegmentID = item.FK_ACSegmentID;
                    }
                    objProductIdentifiedEquipmentsController.UpdateObject(objProductIdentifiedEquipmentsInfo);
                }
                //TNDLoc [ADD][26/04/2016][Update DepartmentRoom],END
            }

        }
        #endregion        

        public override void SetValuesAfterValidateProduct(int productID)
        {
            ACEquipmentTransferItemsInfo equipmentTransferItem = (ACEquipmentTransferItemsInfo)ModuleObjects[TableName.ACEquipmentTransferItemsTableName];
            base.SetValuesAfterValidateProduct(productID, equipmentTransferItem);
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo equipment = objProductsController.GetEquipmentByID(productID);
            if (equipment != null)
            {
                equipmentTransferItem.FK_ICMeasureUnitID = equipment.FK_ICProductBasicUnitID;
            }
            equipmentTransferItem.FK_HRFromRoomID = 0;
            equipmentTransferItem.FK_HRToRoomID = 0;
            equipmentTransferItem.ACEquipmentTransferItemUnitPrice = 0;
            equipmentTransferItem.ACEquipmentTransferItemDepreciatedAmount = 0;
            equipmentTransferItem.EquipmentRemainedAmount = 0;
            equipmentTransferItem.ACEquipmentTransferItemQty = 1;
        }
    }
}
