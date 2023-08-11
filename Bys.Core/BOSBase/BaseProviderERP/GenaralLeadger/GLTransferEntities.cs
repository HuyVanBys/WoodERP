namespace BOSERP.GenaralLeadger
{
    public class GLTransferEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSItemsEntityList<ICTransferItemsInfo> TransferItemList { get; set; }

        #endregion

        #region Constructor
        public GLTransferEntities()
            : base()
        {
            TransferItemList = new BOSItemsEntityList<ICTransferItemsInfo>();
        }
        #endregion
    }
}
