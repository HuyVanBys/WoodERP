namespace BOSERP.GenaralLeadger
{
    public class GLReceiptEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSItemsEntityList<ICReceiptItemsInfo> ReceiptItemsList { get; set; }

        #endregion

        #region Constructor
        public GLReceiptEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
        }
        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICReceiptsInfo mainObject = (ICReceiptsInfo)MainObject;
            ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();
            ICImportAndExportReasonsInfo reason = objImportAndExportReasonsController.GetImportAndExportReasonByModuleName(this.Module.Name);
            mainObject.FK_ICImportAndExportReasonID = (reason != null ? reason.ICImportAndExportReasonID : 0);
        }
    }
}
