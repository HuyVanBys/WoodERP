using System.ComponentModel;

namespace BOSERP.Modules.StopDepreciationAsset.UI
{
    /// <summary>
    /// Summary description for DMNKH100
    /// </summary>
    public partial class DMNKH100 : BOSERPScreen
    {

        public DMNKH100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACAssetID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((StopDepreciationAssetModule)Module).BindingDataSourceForAssetLookupEdit();
        }
    }
}
