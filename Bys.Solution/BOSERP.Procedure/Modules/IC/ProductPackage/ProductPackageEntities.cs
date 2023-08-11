using BOSCommon.Constants;
using System.Collections.Generic;

namespace BOSERP.Modules.ProductPackage
{
    public class ProductPackageEntities : BaseTransactionEntities
    {

        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ICProductPackagesInfo> ProductPackageList { get; set; }
        public BOSList<ICProductPackageItemsInfo> ProductPackageItemList { get; set; }
        public List<ICProductPackagesInfo> DeletePackage;
        public List<ICProductPackageItemsInfo> DeletePackageItem;
        #endregion

        #region Constructor
        public ProductPackageEntities()
            : base()
        {
            ProductPackageItemList = new BOSList<ICProductPackageItemsInfo>();
            ProductPackageList = new BOSList<ICProductPackagesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductPackagesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICProductPackagesTableName, new ICProductPackagesInfo());
            ModuleObjects.Add(TableName.ICProductPackageItemsTableName, new ICProductPackageItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductPackageList.InitBOSList(this,
                                              string.Empty,
                                              TableName.ICProductPackagesTableName,
                                              BOSList<ICProductPackagesInfo>.cstRelationNone);
            ProductPackageItemList.InitBOSList(this,
                                               TableName.ICProductPackagesTableName,
                                               TableName.ICProductPackageItemsTableName,
                                               BOSList<ICProductPackageItemsInfo>.cstRelationForeign);
            ProductPackageItemList.ItemTableForeignKey = "FK_ICProductPackageID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductPackageList.InitBOSListGridControl();
            ProductPackageItemList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            ProductPackageList.SetDefaultListAndRefreshGridControl();
            ProductPackageItemList.SetDefaultListAndRefreshGridControl();
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {

        }
        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            ProductPackageList.SaveItemObjects();
            ProductPackageItemList.SaveItemObjects();
            #region Save Package
            ProductPackageList.SaveItemTypeObjects();

            #endregion

            #region Save PackageItem
            ProductPackageItemList.SaveItemTypeObjects();
            #endregion
        }
        #endregion
    }
}