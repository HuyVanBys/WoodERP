using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentSaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSOSM100
    /// </summary>
    public partial class DMSOSM100 : BOSERPScreen
    {

        public DMSOSM100()
        {
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ShipmentSaleOrderModule)Module).AddItemToShipmentItemList();
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ShipmentSaleOrderModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (fld_lkeFK_ICStockID.OldEditValue != e.Value)
            {
                int icStockID = 0;
                Int32.TryParse(e.Value.ToString(), out icStockID);
                ((ShipmentSaleOrderModule)Module).UpdateStockForShipmentItems(icStockID);
            }
        }

        private void fld_lkeFK_PMProjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int projectID = 0;
                if (int.TryParse(e.Value.ToString(), out projectID))
                {
                    ((ShipmentSaleOrderModule)Module).ChangeProject(projectID);
                }
            }
        }

        private void Fld_lkeFK_ACCostCenterID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int costCenterID = 0;
                if (int.TryParse(e.Value.ToString(), out costCenterID))
                {
                    ((ShipmentSaleOrderModule)Module).ChangeCostCenter(costCenterID);
                }
            }
        }
        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).ShowGuiPackage(null, null);
        }

        private void Fld_lkeICShipmentProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ShipmentSaleOrderModule)Module).ChangeInputType(e.Value.ToString());
            }
        }

        private void bosTextBox1_Validated(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).ChangeShipmentInfomation();
        }

        private void bosTextBox2_Validated(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).ChangeShipmentInfomation();
        }

        private void bosTextBox3_Validated(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).ChangeShipmentInfomation();
        }

        private void bosTextBox4_Validated(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).ChangeShipmentInfomation();
        }

        private void bosDateEdit1_Validated(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).ChangeShipmentInfomation();
        }

        private void fld_btnAutoSelectProductSerialNo_Click(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).AutoSelectProductSerialNo();
        }

        private void fld_txtICShipmentInternalSeal_Validated(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).ChangeInternalSeal();
        }
    }
}
