using BOSCommon.Constants;
using BOSLib;
using System;


namespace BOSERP.Modules.PriceAdjustment
{
    public class PriceAdjustmentEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSItemsEntityList<ICPriceAdjustmentItemsInfo> PriceAdjustmentList { get; set; }

        #endregion

        #region Constructor
        public PriceAdjustmentEntities()
            : base()
        {
            PriceAdjustmentList = new BOSItemsEntityList<ICPriceAdjustmentItemsInfo>();

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICPriceAdjustmentsInfo();
            SearchObject = new ICPriceAdjustmentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICPriceAdjustmentItemsTableName, new ICPriceAdjustmentItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            PriceAdjustmentList.InitBOSList(this,
                                                              TableName.ICPriceAdjustmentsTableName,
                                                              TableName.ICPriceAdjustmentItemsTableName,
                                                              BOSItemsEntityList<ICPriceAdjustmentItemsInfo>.cstRelationForeign);
            PriceAdjustmentList.ItemTableForeignKey = "FK_ICPriceAdjustmentID";


        }

        public override void InitGridControlInBOSList()
        {
            PriceAdjustmentList.InitBOSListGridControl(PriceAdjustmentModule.ReceiptItemGridControlName);

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PriceAdjustmentList.SetDefaultListAndRefreshGridControl();

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

            ICPriceAdjustmentsInfo objReceiptsInfo = (ICPriceAdjustmentsInfo)MainObject;
            objReceiptsInfo.ICPriceAdjustmentDate = DateTime.Now;
            //objReceiptsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            //objReceiptsInfo.ICReceiptCDTypeCombo = ReceiptType.ReceiptDC.ToString();
            //objReceiptsInfo.ICReceiptCDAcceptanceType = ReceiptCDAcceptanceType.RoundWood.ToString();
            //objReceiptsInfo.ICPriceAdjustmentstatus = ReceiptStatus.New.ToString();
            //objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            //objReceiptsInfo.ICReceiptCDExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            PriceAdjustmentList.Invalidate(iObjectID);


        }
        #endregion

        #region Save Module Objects Functions        
        public override void SaveModuleObjects()
        {
            //Update status of stock receipt
            ICPriceAdjustmentsInfo receipt = (ICPriceAdjustmentsInfo)MainObject;
            //receipt.ICPriceAdjustmentstatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            PriceAdjustmentList.SaveItemObjects();
        }

        public void UpdateTotalCost()
        {
            ICPriceAdjustmentsInfo objReceiptsInfo = (ICPriceAdjustmentsInfo)MainObject;
            //objReceiptsInfo.ICPriceAdjustmentsubTotalCost = 0;
            //foreach (ICPriceAdjustmentItemsInfo entItem in PriceAdjustmentList)
            //{
            //    objReceiptsInfo.ICPriceAdjustmentsubTotalCost += entItem.ICReceiptCDItemTotalCost;
            //}
            //objReceiptsInfo.ICReceiptCDTotalCost = objReceiptsInfo.ICPriceAdjustmentsubTotalCost;
            //UpdateMainObjectBindingSource();            
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICPriceAdjustmentItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICPriceAdjustmentItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICPriceAdjustmentsInfo objICPriceAdjustmentsInfo = (ICPriceAdjustmentsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                ICPriceAdjustmentItemsInfo receiptItem = (ICPriceAdjustmentItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(productID, receiptItem);
                SetProductCost(receiptItem);
                //receiptItem.FK_ICStockID = objICPriceAdjustmentsInfo.FK_ICStockID;
                receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
            }
        }
        public override bool CompleteTransaction()
        {
            ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            foreach (ICPriceAdjustmentItemsInfo item in PriceAdjustmentList)
            {
                objInventoryStocksInfo = (ICInventoryStocksInfo)objInventoryStocksController.GetObjectByID(item.FK_ICInventoryStockID);
                if (objInventoryStocksInfo != null)
                {
                    objInventoryStocksInfo.ICInventoryStockUnitCost = item.ICPriceAdjustmentItemInventoryCostNew;
                    objInventoryStocksController.UpdateObject(objInventoryStocksInfo);
                }
            }

            return true;
        }
    }
}
