namespace BOSERP.GenaralLeadger
{
    public class GLShipmentEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSItemsEntityList<ICShipmentItemsInfo> ShipmentItemList { get; set; }

        #endregion

        #region Constructor
        public GLShipmentEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
        }
        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();
            ICImportAndExportReasonsInfo reason = objImportAndExportReasonsController.GetImportAndExportReasonByModuleName(this.Module.Name);
            mainObject.FK_ICImportAndExportReasonID = (reason != null ? reason.ICImportAndExportReasonID : 0);
        }
    }
}
