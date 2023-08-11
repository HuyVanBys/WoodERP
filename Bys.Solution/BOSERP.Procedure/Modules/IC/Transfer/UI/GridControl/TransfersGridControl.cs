using System.Windows.Forms;

namespace BOSERP.Modules.Transfer
{
    public class ICTransfersGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            TransferEntities entity = (TransferEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentTransferList;
            this.DataSource = bds;
        }
    }
}
