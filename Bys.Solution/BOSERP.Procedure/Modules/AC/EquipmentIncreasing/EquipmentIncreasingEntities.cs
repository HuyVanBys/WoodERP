using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.EquipmentIncreasing
{
    public class EquipmentIncreasingEntities : BaseTransactionEntities
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
        public EquipmentIncreasingEntities()
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
            ShipmentItemList.InitBOSListGridControl(EquipmentIncreasingModule.ShipmentItemGridControlName);
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
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.EquipmentIncreasing.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objShipmentsInfo.FK_ACObjectID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objShipmentsInfo.ICObjectType = "Branch";
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
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            ICShipmentsInfo shipment = (ICShipmentsInfo)MainObject;
            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                item.ICShipmentItemProductIdentifiedEquipmentNo = GenerateProductIdentifiedEquipmentNo(item);
                ICProductSeriesInfo serie = objProductSeriesController.GetProductSerieForEquipment(item.FK_ICProductID, item.ICShipmentItemProductSerialNo, item.FK_ICModelID, item.FK_ICModelDetailID);
                if (serie == null)
                {
                    serie = new ICProductSeriesInfo();
                    serie.AACreatedDate = shipment.ICShipmentDate;
                    serie.FK_ICProductID = item.FK_ICProductID;
                    serie.ICProductSerieNo = item.ICShipmentItemProductSerialNo;
                    serie.ICProductSerieReceiptDate = shipment.ICShipmentDate;
                    serie.FK_ICModelID = item.FK_ICModelID;
                    serie.FK_ICModelDetailID = item.FK_ICModelDetailID;
                    objProductSeriesController.CreateObject(serie);
                }
                item.FK_ICProductSerieID = serie.ICProductSerieID;
                ICProductIdentifiedEquipmentsInfo objICProductIdentifiedEquipmentsInfo = objProductIdentifiedEquipmentsController.GetIdentifiedByProductIDAndIdentifiedNo(item.FK_ICProductID, item.ICShipmentItemProductIdentifiedEquipmentNo);
                if (objICProductIdentifiedEquipmentsInfo == null)
                {
                    objICProductIdentifiedEquipmentsInfo = new ICProductIdentifiedEquipmentsInfo();
                    objICProductIdentifiedEquipmentsInfo.AACreatedDate = shipment.ICShipmentDate;
                    objICProductIdentifiedEquipmentsInfo.FK_ICProductID = item.FK_ICProductID;
                    objICProductIdentifiedEquipmentsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
                    objICProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                    objICProductIdentifiedEquipmentsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentNo = item.ICShipmentItemProductIdentifiedEquipmentNo;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentOriginalAmount = item.ICShipmentItemProductUnitPrice;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objICProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                    objICProductIdentifiedEquipmentsInfo.FK_MMLineID = item.FK_MMLineID;
                    objICProductIdentifiedEquipmentsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                    objICProductIdentifiedEquipmentsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                    objICProductIdentifiedEquipmentsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                    objICProductIdentifiedEquipmentsInfo.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationMonths = item.ICShipmentItemDepreciationMonths;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationDate = item.ICShipmentItemDepriciationDate;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmenteTotalAmount = item.ICShipmentItemTotalAmount;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.Using.ToString();
                    objProductIdentifiedEquipmentsController.CreateObject(objICProductIdentifiedEquipmentsInfo);
                }
                else
                {
                    objICProductIdentifiedEquipmentsInfo.AACreatedDate = shipment.ICShipmentDate;
                    objICProductIdentifiedEquipmentsInfo.FK_ICProductID = item.FK_ICProductID;
                    objICProductIdentifiedEquipmentsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
                    objICProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                    objICProductIdentifiedEquipmentsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentNo = item.ICShipmentItemProductIdentifiedEquipmentNo;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentOriginalAmount = item.ICShipmentItemProductUnitPrice;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    objICProductIdentifiedEquipmentsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                    objICProductIdentifiedEquipmentsInfo.FK_MMLineID = item.FK_MMLineID;
                    objICProductIdentifiedEquipmentsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                    objICProductIdentifiedEquipmentsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                    objICProductIdentifiedEquipmentsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                    objICProductIdentifiedEquipmentsInfo.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationMonths = item.ICShipmentItemDepreciationMonths;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciationDate = item.ICShipmentItemDepriciationDate;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmenteTotalAmount = item.ICShipmentItemTotalAmount;
                    objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentStatus = ProductIdentifiedEquipmentStatus.Using.ToString();
                    objProductIdentifiedEquipmentsController.UpdateObject(objICProductIdentifiedEquipmentsInfo);
                }
                item.FK_ICProductIdentifiedEquipmentID = objICProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentID;
            }
            ShipmentItemList.SaveItemObjects();
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
                ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)ModuleObjects[TableName.ICShipmentItemsTableName];
                objShipmentItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objShipmentItemsInfo.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                objShipmentItemsInfo.ICShipmentItemProductQty = 1;
                objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                objShipmentItemsInfo.ICProductDepreciationMethod = objProductsInfo.ICProductDepreciationMethod;
                objShipmentItemsInfo.ICShipmentItemProductRemainedQty = objShipmentItemsInfo.ICShipmentItemProductQty;
                ACAccountsController objAccountsController = new ACAccountsController();
                objShipmentItemsInfo.FK_ACDepreciationCostAccountID = objProductsInfo.FK_ACDepreciationCostAccountID;
                objShipmentItemsInfo.ICShipmentItemDepreciatedAmount = 0;
                objShipmentItemsInfo.ICShipmentItemRemainedAmount = 0;
            }
        }
    }
}
