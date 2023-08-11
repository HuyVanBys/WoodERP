using System.Windows.Forms;

namespace BOSERP.Modules.TransferConstruction
{
    public class ICTransfersGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            TransferConstructionEntities entity = (TransferConstructionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentTransferList;
            this.DataSource = bds;
        }
    }
}
