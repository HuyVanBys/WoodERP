using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;
using DevExpress.XtraEditors;
namespace BOSERP.Modules.DeviceConfig.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    public partial class DMDEC100 : BOSERPScreen
	{

        public DMDEC100()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}

        private void bosLookupEdit3_QueryPopUp(object sender, CancelEventArgs e)
        {
            
        }

        private void bosLookupEdit3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((DeviceConfigModule)Module).AddItemToDeviceItemPlansList();
            }
        }

        private void fld_lkeACDeviceIdentifierNo_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((DeviceConfigModule)Module).GenerateItemAndMaterial();
        }

        private void fld_lkeICProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke.OldEditValue != e.Value)
            {
                int id = 0;
                if (e.Value != null)
                {
                    int.TryParse(e.Value.ToString(), out id);
                }
                ((DeviceConfigModule)Module).ChangeProduct(id);
            }
        }

       
	}
}
