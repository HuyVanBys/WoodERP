namespace BOSERP.Modules.StopDepreciationAsset
{
    public class StopDepreciationAssetEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public StopDepreciationAssetEntities()
            : base()
        {

        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACStopDepreciationAssetsInfo();
            SearchObject = new ACStopDepreciationAssetsInfo();
        }
        #endregion

        #region SetDefault
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACStopDepreciationAssetsInfo objStopDepreciationAssetsInfo = (ACStopDepreciationAssetsInfo)MainObject;
            objStopDepreciationAssetsInfo.ACStopDepreciationAssetDate = BOSApp.GetCurrentServerDate();
            objStopDepreciationAssetsInfo.ACStopDepreciationAssetDateStop = BOSApp.GetCurrentServerDate();
            objStopDepreciationAssetsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        #endregion
    }
}