using System.Windows.Forms;

namespace BOSERP.Modules.TransferOutsourcing
{
    public class ICTransfersGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            TransferOutsourcingEntities entity = (TransferOutsourcingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentTransferList;
            this.DataSource = bds;
        }
    }
}
