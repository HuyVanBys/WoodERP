namespace BOSERP.Modules.KPI
{
    public class KPIEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public KPIEntities()
            : base()
        {

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRKPIsInfo();
            SearchObject = new HRKPIsInfo();
        }
        #endregion 
    }
}