using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.Asset
{
    public class AssetEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public AssetEntities()
            : base()
        {

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACAssetsInfo();
            SearchObject = new ACAssetsInfo();
        }

        public override void InitModuleObjects()
        {

        }

        public override void InitModuleObjectList()
        {

        }

        public override void InitGridControlInBOSList()
        {

        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)MainObject;
            objAssetsInfo.ACAssetStatus = AssetStatus.Purchased.ToString();
            objAssetsInfo.ACAssetDepreciationMethod = AssetDepreciationMethod.StraightLine.ToString();
            objAssetsInfo.ACAssetPurchasedDate = DateTime.Now;
            objAssetsInfo.ACAssetUsedDate = DateTime.Now;
            objAssetsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAssetsInfo.ACAssetDepreciationDate = BOSApp.GetCurrentServerDate();

            ACAccountsController objAccountsController = new ACAccountsController();
            int accountID = objAccountsController.GetObjectIDByNo(AccAccount.Acc6424);
            objAssetsInfo.FK_ACDepreciationCostAccountID = accountID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {

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
            base.InvalidateModuleObjects(iObjectID);
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            ACAssetsInfo mainObject = (ACAssetsInfo)MainObject;
            SetPropertyChangeEventLock(false);
            ACAssetsInfo assetsInfo = (new ACAssetsController()).GetAssetByID(iObjectID);
            if(assetsInfo != null)
            {
                mainObject.ACAssetDepreciatedAmount = assetsInfo.ACAssetDepreciatedAmount;
                mainObject.ACAssetRemainedAmount = mainObject.ACAssetOriginalAmount - assetsInfo.ACAssetDepreciatedAmount;
            }
            UpdateMainObjectBindingSource();
            SetPropertyChangeEventLock(true);
        }
        #endregion

        #region Save Module Objects functions        

        public override void SaveModuleObjects()
        {

        }

        public override int SaveMainObject()
        {
            int result = base.SaveMainObject();
            if (result > 0)
            {
                ACAssetsInfo mainObject = (ACAssetsInfo)MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(mainObject.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    string ProductType = objProductsInfo.ICProductType;
                    string ProductNo = objProductsInfo.ICProductNo;
                    string ProductName = objProductsInfo.ICProductName;
                    int FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                    int FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                    BOSUtil.CopyObject(mainObject, objProductsInfo);
                    objProductsInfo.ICProductID = mainObject.FK_ICProductID;
                    objProductsInfo.ICProductType = ProductType;
                    objProductsInfo.FK_ICProductGroupID = FK_ICProductGroupID;
                    objProductsInfo.ICProductNo = ProductNo;
                    objProductsInfo.ICProductName = ProductName;
                    objProductsController.UpdateObject(objProductsInfo);
                }
                else
                {
                    objProductsInfo = new ICProductsInfo();
                    BOSUtil.CopyObject(mainObject, objProductsInfo);
                    objProductsInfo.ICProductType = ProductType.Asset.ToString();
                    objProductsInfo.ICProductUsingMethod = ProductUsingMethod.SpecificAsset.ToString();
                    mainObject.FK_ICProductID = objProductsController.CreateObject(objProductsInfo);
                    UpdateMainObject();
                }
            }
            return result;
        }
        #endregion

    }
}
