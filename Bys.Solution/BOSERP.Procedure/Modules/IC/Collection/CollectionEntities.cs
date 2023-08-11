using BOSCommon;
using BOSCommon.Constants;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Collection
{
    public class CollectionEntities : BaseTransactionEntities
    {

        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ICCollectionItemsInfo> ICCollectionItemList { get; set; }

        public BOSList<ICCollectionItemsInfo> ICCollectionItemWorkList { get; set; }

        public BOSList<ICCollectionItemsInfo> ICCollectionItemMaterialList { get; set; }

        #endregion

        #region Constructor
        public CollectionEntities()
            : base()
        {
            ICCollectionItemList = new BOSList<ICCollectionItemsInfo>();
            ICCollectionItemWorkList = new BOSList<ICCollectionItemsInfo>();
            ICCollectionItemMaterialList = new BOSList<ICCollectionItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICCollectionsInfo();
            SearchObject = new ICCollectionsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICCollectionItemsTableName, new ICCollectionItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ICCollectionItemList.InitBOSList(this,
                                               TableName.ICCollectionsTableName,
                                               TableName.ICCollectionItemsTableName,
                                               BOSList<ICCollectionItemsInfo>.cstRelationForeign);
            ICCollectionItemList.ItemTableForeignKey = "FK_ICCollectionID";

            ICCollectionItemWorkList.InitBOSList(this,
                                               TableName.ICCollectionsTableName,
                                               TableName.ICCollectionItemsTableName,
                                               BOSList<ICCollectionItemsInfo>.cstRelationForeign);
            ICCollectionItemWorkList.ItemTableForeignKey = "FK_ICCollectionID";

            ICCollectionItemMaterialList.InitBOSList(this,
                                               TableName.ICCollectionsTableName,
                                               TableName.ICCollectionItemsTableName,
                                               BOSList<ICCollectionItemsInfo>.cstRelationForeign);
            ICCollectionItemMaterialList.ItemTableForeignKey = "FK_ICCollectionID";
        }

        public override void InitGridControlInBOSList()
        {
            ICCollectionItemList.InitBOSListGridControl("fld_dgcICCollectionItems");
            ICCollectionItemWorkList.InitBOSListGridControl("fld_dgcICCollectionItemWorks");
            ICCollectionItemMaterialList.InitBOSListGridControl("fld_dgcICCollectionItemMaterials");
        }

        public override void SetDefaultModuleObjectsList()
        {
            ICCollectionItemList.SetDefaultListAndRefreshGridControl();
            ICCollectionItemWorkList.SetDefaultListAndRefreshGridControl();
            ICCollectionItemMaterialList.SetDefaultListAndRefreshGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICCollectionsInfo objCollectionsInfo = (ICCollectionsInfo)MainObject;
            objCollectionsInfo.ICCollectionDate = BOSApp.GetCurrentServerDate();
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICCollectionItemsController collectionItemController = new ICCollectionItemsController();
            List<ICCollectionItemsInfo> collectionList = collectionItemController.GetCollectionItemListByCollectionID(iObjectID);
            ICCollectionItemList.Invalidate(collectionList.Where(o => o.ICCollectionItemProductType == CollectionItemType.Product.ToString()).ToList());
            ICCollectionItemWorkList.Invalidate(collectionList.Where(o => o.ICCollectionItemProductType == CollectionItemType.Work.ToString()).ToList());
            ICCollectionItemMaterialList.Invalidate(collectionList.Where(o => o.ICCollectionItemProductType == CollectionItemType.Material.ToString()).ToList());
        }
        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            ICCollectionItemList.SaveItemObjects();
            ICCollectionItemWorkList.SaveItemObjects();
            ICCollectionItemMaterialList.SaveItemObjects();
        }
        #endregion
    }
}