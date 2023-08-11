using BOSCommon.Constants;

namespace BOSERP.Modules.PrintRouting
{
    public class PrintRoutingEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of asset receipt items
        /// </summary>
        /// 
        public BOSList<MMPrintRoutingsInfo> PrintRoutingList { get; set; }

        #endregion

        #region Constructor
        public PrintRoutingEntities()
            : base()
        {
            PrintRoutingList = new BOSList<MMPrintRoutingsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions

        public override void InitModuleObjectList()
        {
            PrintRoutingList.InitBOSList(this,
                                            string.Empty,
                                            TableName.MMPrintRoutingsTablename,
                                            BOSList<MMPrintRoutingsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            PrintRoutingList.InitBOSListGridControl();
        }

        #endregion

    }
}
