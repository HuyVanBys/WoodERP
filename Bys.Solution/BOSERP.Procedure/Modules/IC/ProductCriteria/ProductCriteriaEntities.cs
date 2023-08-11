using BOSCommon;
using BOSCommon.Constants;
using System.Collections.Generic;

namespace BOSERP.Modules.ProductCriteria
{
    public class ProductCriteriaEntities : BaseTransactionEntities
    {

        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ICProductCriteriaItemsInfo> ProductCriteriaItemList { get; set; }
        #endregion

        #region Constructor
        public ProductCriteriaEntities()
            : base()
        {
            ProductCriteriaItemList = new BOSList<ICProductCriteriaItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductCriteriasInfo();
            SearchObject = new ICProductCriteriasInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICProductCriteriaItemsTableName, new ICProductCriteriaItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductCriteriaItemList.InitBOSList(this,
                                               TableName.ICProductCriteriasTableName,
                                               TableName.ICProductCriteriaItemsTableName,
                                               BOSList<ICProductCriteriaItemsInfo>.cstRelationForeign);
            ProductCriteriaItemList.ItemTableForeignKey = "FK_ICProductCriteriaID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductCriteriaItemList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            ProductCriteriaItemList.SetDefaultListAndRefreshGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICProductCriteriasInfo objProductsInfo = (ICProductCriteriasInfo)MainObject;
            objProductsInfo.ICProductCriteriaDiscountType = ProductCriteriaDiscountType.Percent.ToString();
            objProductsInfo.ICProductCriteriaIsIncrease = false;
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ProductCriteriaItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            ProductCriteriaItemList.SaveItemObjects();
        }
        #endregion

        public void GenarateProductCriteriaItems(ICCollectionsInfo objCollectionsInfo)
        {
            ICCollectionItemsController objCollectionItemController = new ICCollectionItemsController();
            List<ICCollectionItemsInfo> collectionItems = new List<ICCollectionItemsInfo>();
            collectionItems = objCollectionItemController.GetCollectionItemListByCollectionID(objCollectionsInfo.ICCollectionID);
            collectionItems.ForEach(o => ProductCriteriaItemList.Add(ToProductCriteriaItemsInfo(o)));
        }

        private ICProductCriteriaItemsInfo ToProductCriteriaItemsInfo(ICCollectionItemsInfo objCollectionItemsInfo)
        {
            return new ICProductCriteriaItemsInfo
            {
                FK_ICProductID = objCollectionItemsInfo.FK_ICProductID,
                ICProductCriteriaItemProductNo = objCollectionItemsInfo.ICCollectionItemProductNo,
                ICProductCriteriaItemProductName = objCollectionItemsInfo.ICCollectionItemProductName,
                ICProductCriteriaItemProductDesc = objCollectionItemsInfo.ICCollectionItemProductDesc,
                ICProductCriteriaItemType = ((ICProductCriteriasInfo)MainObject).ICProductCriteriaDiscountType,
                ICProductCriteriaItemsDiscountAmount = ((ICProductCriteriasInfo)MainObject).ICProductCriteriaDiscountAmount,
                ICProductCriteriaItemPercent = ((ICProductCriteriasInfo)MainObject).ICProductCriteriaDiscountPercent,
                ICProductCriteriaItemUnitPrice = objCollectionItemsInfo.ICCollectionItemProductUnitPrice,
                ICProductCriteriaItemProductUnitPrice = objCollectionItemsInfo.ICCollectionItemProductUnitPrice,
                ICProductCriteriaItemIsIncrease = false,
            };
        }

        public void GenarateProductCriteriaItems(List<ICProductsInfo> productsList)
        {

            productsList.ForEach(o => ProductCriteriaItemList.Add(ToProductCriteriaItemsInfo(o)));
        }

        private ICProductCriteriaItemsInfo ToProductCriteriaItemsInfo(ICProductsInfo objICProductsInfo)
        {
            return new ICProductCriteriaItemsInfo
            {
                FK_ICProductID = objICProductsInfo.ICProductID,
                ICProductCriteriaItemProductNo = objICProductsInfo.ICProductNo,
                ICProductCriteriaItemProductName = objICProductsInfo.ICProductName,
                ICProductCriteriaItemProductDesc = objICProductsInfo.ICProductDesc,
                ICProductCriteriaItemUnitPrice = objICProductsInfo.ICProductPrice01,
                ICProductCriteriaItemProductUnitPrice = objICProductsInfo.ICProductPrice01,
                ICProductCriteriaItemType = ((ICProductCriteriasInfo)MainObject).ICProductCriteriaDiscountType,
                ICProductCriteriaItemsDiscountAmount = ((ICProductCriteriasInfo)MainObject).ICProductCriteriaDiscountAmount,
                ICProductCriteriaItemPercent = ((ICProductCriteriasInfo)MainObject).ICProductCriteriaDiscountPercent,
                ICProductCriteriaItemIsIncrease = false,
            };
        }
    }
}