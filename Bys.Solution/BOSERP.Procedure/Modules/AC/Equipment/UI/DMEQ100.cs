using BOSComponent;
using System;

namespace BOSERP.Modules.Equipment.UI
{
    /// <summary>
    /// Summary description for DMEQ100
    /// </summary>
    public partial class DMEQ100 : BOSERPScreen
    {

        public DMEQ100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((EquipmentModule)Module).ShowCategoryTree();
        }

        private void FLd_lkeFK_ACEquipmentTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((EquipmentModule)Module).ChangeEquipmentTypeAccountConfig(objectID);
            }
        }
    }
}
