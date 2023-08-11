using BOSCommon.Constants;

namespace BOSERP.Modules.InitializedInventoryStock
{
    public class InitializedInventoryStockEntities : ERPModuleEntities
    {
        #region Public Properties
        public BOSList<ICInitializedInventoryStocksInfo> InitializedInventoryStockList { get; set; }

        #endregion

        #region Constructor
        public InitializedInventoryStockEntities()
            : base()
        {
            InitializedInventoryStockList = new BOSList<ICInitializedInventoryStocksInfo>();
        }

        #endregion

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            ICInitializedInventoryStocksInfo objICInitializedInventoryStocksInfo = (ICInitializedInventoryStocksInfo)MainObject;

            ICProductsController objICProductsController = new ICProductsController();
            ICProductsInfo objICProductsInfo = (ICProductsInfo)objICProductsController.GetObjectByID(objICInitializedInventoryStocksInfo.FK_ICProductID);
            if (objICProductsInfo != null)
            {
                objICInitializedInventoryStocksInfo.ICProductNo = objICProductsInfo.ICProductNo;
                objICInitializedInventoryStocksInfo.ICProductName = objICProductsInfo.ICProductName;
                objICInitializedInventoryStocksInfo.ICProductDesc = objICProductsInfo.ICProductDesc;
            }
            ICProductSeriesController objICProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objICProductSeriesInfo = (ICProductSeriesInfo)objICProductSeriesController.GetObjectByID(objICInitializedInventoryStocksInfo.FK_ICProductSerieID);
            if (objICProductSeriesInfo != null)
            {
                objICInitializedInventoryStocksInfo.ICProductSerieNo = objICProductSeriesInfo.ICProductSerieNo;
            }
            UpdateMainObject();
        }

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICInitializedInventoryStocksInfo();
            SearchObject = new ICInitializedInventoryStocksInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICInitializedInventoryStocksTableName, new ICInitializedInventoryStocksInfo());
        }

        public override void InitModuleObjectList()
        {
            InitializedInventoryStockList.InitBOSList(
                                                        this,
                                                        string.Empty,
                                                        TableName.ICInitializedInventoryStocksTableName,
                                                        BOSList<ICInitializedInventoryStocksInfo>.cstRelationNone);
        }
        public override void InitGridControlInBOSList()
        {
            InitializedInventoryStockList.InitBOSListGridControl();
        }

        #endregion

        public override void SaveModuleObjects()
        {

            InitializedInventoryStockList.ForEach(x => x.ICInitializedInventoryStockStatus = "New");
            InitializedInventoryStockList.SaveItemObjects();
        }
    }
}
