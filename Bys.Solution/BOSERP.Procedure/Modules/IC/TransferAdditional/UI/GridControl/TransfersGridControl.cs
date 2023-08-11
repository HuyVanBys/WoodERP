using System.Windows.Forms;

namespace BOSERP.Modules.TransferAdditional
{
    public class ICTransfersGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            TransferAdditionalEntities entity = (TransferAdditionalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentTransferList;
            this.DataSource = bds;
        }
    }
}
