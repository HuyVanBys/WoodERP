namespace BOSERP.Modules.UnfinishedConstructionCost
{
    public class UnfinishedConstructionCostEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public UnfinishedConstructionCostEntities()
            : base()
        {

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACUnfinishedConstructionCostsInfo();
            SearchObject = new ACUnfinishedConstructionCostsInfo();
        }
        #endregion 
    }
}