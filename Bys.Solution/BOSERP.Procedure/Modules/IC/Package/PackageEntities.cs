using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Package
{
    public class PackageEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets product list of package
        /// </summary>
        public BOSList<ICProductsInfo> PackageProductList { get; set; }
        #endregion

        #region Constructor
        public PackageEntities()
            : base()
        {
            PackageProductList = new BOSList<ICProductsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICPackagesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICPackageProductsTableName, new ICPackageProductsInfo());
        }

        public override void InitModuleObjectList()
        {
            PackageProductList.InitBOSList(this,
                                            string.Empty,
                                            TableName.ICProductsTableName,
                                            BOSList<ICPackageProductsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            PackageProductList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PackageProductList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            DisplayPackageType();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICPackageProductsController objPackageProductsController = new ICPackageProductsController();
            List<ICProductsInfo> productList = objPackageProductsController.GetProductsByPackageID(iObjectID);
            PackageProductList.Invalidate(productList);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {

        }
        #endregion

        /// <summary>
        /// Display package type
        /// </summary>
        public void DisplayPackageType()
        {
            ICPackagesInfo objPackagesInfo = (ICPackagesInfo)MainObject;
            if (objPackagesInfo.ICPackageCount == 1 && objPackagesInfo.ICPackageProductCount > 1)
                objPackagesInfo.ICPackageType = PackageProductLocalizedResources.MultiProduct;
            else if (objPackagesInfo.ICPackageProductCount == 1 && objPackagesInfo.ICPackageCount > 1)
                objPackagesInfo.ICPackageType = PackageProductLocalizedResources.MultiPackage;
            else
                objPackagesInfo.ICPackageType = PackageProductLocalizedResources.MultiPackageMultiProduct;
            UpdateMainObjectBindingSource();
        }
    }
}
