using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.Asset.UI
{
    /// <summary>
    /// Summary description for DMAS100
    /// </summary>
    public partial class DMAS100 : BOSERPScreen
    {

        public DMAS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtACAssetExpiryMonths_Validated(object sender, EventArgs e)
        {
            ((AssetModule)Module).ChangeExpiryMonths();
        }

        private void fld_txtACAssetDepreciationPercent_Validated(object sender, EventArgs e)
        {
            ((AssetModule)Module).ChangeDepreciationPercent();
        }

        private void fld_txtACAssetDepreciationAmount_Validated(object sender, EventArgs e)
        {
            ((AssetModule)Module).ChangeDepreciationPercent();
        }

        private void fld_lkeFK_HRDepartmentRoomID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AssetModule)Module).ChangeRoom(Convert.ToInt32(e.Value));
            }
        }
        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((AssetModule)Module).ShowCategoryTree();
        }

        private void fld_lkeFK_ACUnfinishedConstructionCostID_Validated(object sender, EventArgs e)
        {
            ((AssetModule)Module).ChangeOriginalAmount();
        }

        private void fld_lkeFK_ACAssetTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((AssetModule)Module).ChangeAssetTypeAccountConfig(objectID);
            }
        }

        private void fld_lkeACAssetType1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AssetModule)Module).ChangeAssetTypeDepreciationConfig(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACUnfinishedConstructionCostID_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void fld_lkeFK_HRDepartmentRoomID1_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;            
            lke.Properties.DataSource = ((AssetModule)Module).GetListDepartmentRoomsByDepartmentID();
        }

        private void bosLookupEdit3_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            lke.Properties.DataSource = ((AssetModule)Module).GetListDepartmentRoomGroupItemsByDepartmentRoomID();
        }

        private void bosLookupEdit2_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            lke.Properties.DataSource = ((AssetModule)Module).GetListLinesByWorkShopID();
        }
    }
}
