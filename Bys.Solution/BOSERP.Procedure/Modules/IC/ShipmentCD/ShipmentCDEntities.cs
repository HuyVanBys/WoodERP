using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.ShipmentCD
{
    public class ShipmentCDEntities : BaseTransactionEntities
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
        public ShipmentCDEntities()
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
            ShipmentItemList.InitBOSListGridControl(ShipmentCDModule.ShipmentItemGridControlName);
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
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.ShipmentCD.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ShipmentItemList.Invalidate(iObjectID);


        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {

            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ShipmentItemList.SaveItemObjects();

        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICShipmentItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICShipmentItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
                ICShipmentItemsInfo shipmentItem = (ICShipmentItemsInfo)item;
                shipmentItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(objProductsInfo.ICProductID, shipmentItem);
                shipmentItem.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                shipmentItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
            }
        }

        public void UpdateTotalAmount()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            foreach (ICShipmentItemsInfo entItem in ShipmentItemList)
            {
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
            }
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            BOSApp.RoundByCurrency(objShipmentsInfo, objShipmentsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }
        public override bool CompleteTransaction()
        {
            return true;
        }
    }
}
