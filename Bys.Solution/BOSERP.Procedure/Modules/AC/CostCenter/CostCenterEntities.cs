namespace BOSERP.Modules.CostCenter
{
    public class CostCenterEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public CostCenterEntities()
            : base()
        {
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACCostCentersInfo();
            SearchObject = new ACCostCentersInfo();
        }
        #endregion

    }
}
