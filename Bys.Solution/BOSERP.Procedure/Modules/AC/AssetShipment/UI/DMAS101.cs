using System;

namespace BOSERP.Modules.AssetShipment.UI
{
    /// <summary>
    /// Summary description for DMAS101
    /// </summary>
    public partial class DMAS101 : BOSERPScreen
    {

        public DMAS101()
        {
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.AssetShipment.AssetShipmentModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.AssetShipment.AssetShipmentModule)this.Module).AddAssetShipmentTemplate();
        }
    }
}
