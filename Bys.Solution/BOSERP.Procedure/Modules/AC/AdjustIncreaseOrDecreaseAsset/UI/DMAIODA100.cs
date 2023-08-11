using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AdjustIncreaseOrDecreaseAsset.UI
{
    /// <summary>
    /// Summary description for DMII100
    /// </summary>
    public partial class DMAIODA100 : BOSERPScreen
    {

        public DMAIODA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();

            BaseModuleERP module = (BaseModuleERP)Module;
            XtraTabPage page = module.ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == ScreenNumber).FirstOrDefault();
            if (page != null)
            {
                page.AutoScrollMinSize = new Size(Width, Height);
            }
        }

        private void fld_lkeAPInvoiceInType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AdjustIncreaseOrDecreaseAssetModule)Module).ChangeDocumentEntrys(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AdjustIncreaseOrDecreaseAssetModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeAssetID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AdjustIncreaseOrDecreaseAssetModule)Module).AddItemToAdjustIncreaseOrDecreaseAssetItemsList();
            }
        }

        private void fld_lkeAssetID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ACAssetsController controller = new ACAssetsController();
            List<ACAssetsInfo> assets = controller.GetAssetsForStopDepreciationAsset();
            this.fld_lkeAssetID.Properties.DataSource = assets;
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AdjustIncreaseOrDecreaseAssetModule)Module).ChangeCurrency(currencyID);
                }
            }
        }
    }
}
