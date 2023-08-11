using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.EquipmentShipment
{
    public class EquipmentShipmentEntities : GLShipmentEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public EquipmentShipmentEntities()
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
            ShipmentItemList.InitBOSListGridControl(EquipmentShipmentModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(EquipmentShipmentModule.DocumentEntryGridControlName);
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
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.EquipmentShipment.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            //objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> items = objShipmentItemsController.GetEquipmentByShipmentID(iObjectID);
            int index = 0;
            items.ForEach(o =>
            {
                o.STT = ++index;
            });
            ShipmentItemList.Invalidate(items);
        }
        #endregion

        public void GenerateProductIdentifiedEquipment()
        {
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                ICProductIdentifiedEquipmentsInfo objProductIdentifiedEquipmentsInfo = (ICProductIdentifiedEquipmentsInfo)objProductIdentifiedEquipmentsController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                if (objProductIdentifiedEquipmentsInfo == null)
                {
                    objProductIdentifiedEquipmentsInfo = new ICProductIdentifiedEquipmentsInfo();
                    objProductIdentifiedEquipmentsInfo.FK_ICProductID = item.FK_ICProductID;
                    objProductIdentifiedEquipmentsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
                    objProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentNo = item.ICShipmentItemProductIdentifiedEquipmentNo;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentOriginalAmount = item.ICShipmentItemTotalCost;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                    objProductIdentifiedEquipmentsInfo.FK_MMLineID = item.FK_MMLineID;
                    objProductIdentifiedEquipmentsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                    objProductIdentifiedEquipmentsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                    objProductIdentifiedEquipmentsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                    objProductIdentifiedEquipmentsInfo.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationMonths = item.ICShipmentItemDepreciationMonths;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationDate = item.ICShipmentItemDepriciationDate;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmenteTotalAmount = item.ICShipmentItemTotalCost;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.Using.ToString();
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDesc = item.ICShipmentItemComment;
                    objProductIdentifiedEquipmentsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                    objProductIdentifiedEquipmentsInfo.FK_ACSegmentID = item.FK_ACSegmentID;
                    objProductIdentifiedEquipmentsController.CreateObject(objProductIdentifiedEquipmentsInfo);

                }
                else
                {
                    objProductIdentifiedEquipmentsInfo.FK_ICProductID = item.FK_ICProductID;
                    objProductIdentifiedEquipmentsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
                    objProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentNo = item.ICShipmentItemProductIdentifiedEquipmentNo;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentOriginalAmount = item.ICShipmentItemTotalCost;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                    objProductIdentifiedEquipmentsInfo.FK_MMLineID = item.FK_MMLineID;
                    objProductIdentifiedEquipmentsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                    objProductIdentifiedEquipmentsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                    objProductIdentifiedEquipmentsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                    objProductIdentifiedEquipmentsInfo.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationMonths = item.ICShipmentItemDepreciationMonths;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationDate = item.ICShipmentItemDepriciationDate;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmenteTotalAmount = item.ICShipmentItemTotalCost;
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.Using.ToString();
                    objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDesc = item.ICShipmentItemComment;
                    objProductIdentifiedEquipmentsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                    objProductIdentifiedEquipmentsInfo.FK_ACSegmentID = item.FK_ACSegmentID;
                    objProductIdentifiedEquipmentsController.UpdateObject(objProductIdentifiedEquipmentsInfo);
                }
                item.FK_ICProductIdentifiedEquipmentID = objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentID;
                item.ICShipmentItemProductIdentifiedEquipmentNo = objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentNo;
            }

        }
        #region Save Module Objects functions
        public string GenerateProductIdentifiedEquipmentNo(ICShipmentItemsInfo objShipmentItemsInfo)
        {

            if (objShipmentItemsInfo.ICShipmentItemProductIdentifiedEquipmentNo != string.Empty)
                return objShipmentItemsInfo.ICShipmentItemProductIdentifiedEquipmentNo;

            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(o1 => o1.ICProductID == objShipmentItemsInfo.FK_ICProductID);
            if (objProductsInfo == null)
                return string.Empty;

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> currentIdentifiedShipmentItemsList = objShipmentItemsController.GetCurrentProductIdentifiedEquipmentNo(objShipmentItemsInfo.FK_ICProductID);
            int tempNumber = 0;
            List<string> tempList = ShipmentItemList.Union(currentIdentifiedShipmentItemsList)
                                                    .Where(o1 => o1.FK_ICProductID == objShipmentItemsInfo.FK_ICProductID
                                                                        && o1.ICShipmentItemProductIdentifiedEquipmentNo.StartsWith(objProductsInfo.ICProductNo))
                                                    .Select(o1 => o1.ICShipmentItemProductIdentifiedEquipmentNo.Substring(objProductsInfo.ICProductNo.Length + 1))
                                                    .ToList();

            int newIdentifiedNo = tempList.Where(o1 => int.TryParse(o1, out tempNumber))
                                                               .Select(o1 => tempNumber)
                                                               .OrderByDescending(o1 => o1)
                                                               .FirstOrDefault();
            return string.Format("{0}.{1}", objProductsInfo.ICProductNo, newIdentifiedNo + 1 < 10 ? "0" + (newIdentifiedNo + 1).ToString() : (newIdentifiedNo + 1).ToString());
        }
        public override void SaveModuleObjects()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ShipmentItemList.ForEach(o =>
            {
                o.ICShipmentItemProductIdentifiedEquipmentNo = GenerateProductIdentifiedEquipmentNo(o);
            });
            ShipmentItemList.SaveItemObjects();
        }
        #endregion

        public override bool IsInvalidInventory()
        {
            //comments out the code for updating old data
            return ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment);
            //return false;
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
                ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)ModuleObjects[TableName.ICShipmentItemsTableName];
                objShipmentItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(objProductsInfo.ICProductID);
                objShipmentItemsInfo.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                objShipmentItemsInfo.ICProductDepreciationMethod = objProductsInfo.ICProductDepreciationMethod;
                objShipmentItemsInfo.ICShipmentItemProductRemainedQty = objShipmentItemsInfo.ICShipmentItemProductQty;
                objShipmentItemsInfo.ICProductNo = objProductsInfo.ICProductNo;
                objShipmentItemsInfo.ICShipmentItemDepreciationMonths = objProductsInfo.ICProductDepreciationMonths;
                ACAccountsController objAccountsController = new ACAccountsController();
                objShipmentItemsInfo.FK_ACDepreciationCostAccountID = objProductsInfo.FK_ACDepreciationCostAccountID;
                UpdateModuleObjectBindingSource(TableName.ICShipmentItemsTableName);
            }
        }

        #region Accounting
        #endregion

        public override bool CompleteTransaction()
        {
            //Update shipment status
            SetPropertyChangeEventLock(false);
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            UpdateMainObject();

            GenerateProductIdentifiedEquipment();
            ShipmentItemList.SaveItemObjects();
            SetPropertyChangeEventLock(true);

            UpdateAAlocationProposalItemQty();
            return true;
        }

        public void UpdateAAlocationProposalItemQty()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            if (objShipmentsInfo.FK_MMAllocationProposalID > 0)
            {
                ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                List<ICShipmentItemsInfo> ShipmentItemList = objShipmentItemsController.GetItemByShipmentID(objShipmentsInfo.ICShipmentID);
                foreach (ICShipmentItemsInfo item in ShipmentItemList)
                {
                    MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
                    MMAllocationProposalItemsInfo objAllocationProposalItemsInfo = (MMAllocationProposalItemsInfo)objAllocationProposalItemsController.GetObjectByID(item.FK_MMAllocationProposalItemID);
                    if (objAllocationProposalItemsInfo != null)
                    {
                        objAllocationProposalItemsInfo.MMAllocationProposalItemShippedQty += item.ICShipmentItemProductQty;
                        objAllocationProposalItemsInfo.MMAllocationProposalItemShippedWoodQty += item.ICShipmentItemWoodQty;
                        objAllocationProposalItemsController.UpdateObject(objAllocationProposalItemsInfo);

                    }
                }
            }
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            //Xóa mã định danh
            ICProductIdentifiedEquipmentsController controller = new ICProductIdentifiedEquipmentsController();
            controller.DeleteProductIdentifiedEquipmentsByEquipmentShipmentID(mainObject.ICShipmentID);

            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ShipmentItemList.DeleteItemObjects();
            }
        }

        public override bool CancelCompleteTransaction()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            //Xóa mã định danh
            ICProductIdentifiedEquipmentsController controller = new ICProductIdentifiedEquipmentsController();
            controller.DeleteProductIdentifiedEquipmentsByEquipmentShipmentID(mainObject.ICShipmentID);
            return base.CancelCompleteTransaction();
        }
    }
}
