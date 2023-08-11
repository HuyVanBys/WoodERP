using BOSComponent;
using System;

namespace BOSERP.Modules.OpeningInProgressStatistic.UI
{
    /// <summary>
    /// Summary description for DMOIPS100
    /// </summary>
    public partial class DMOIPS100 : BOSERPScreen
    {

        public DMOIPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((OpeningInProgressStatisticModule)Module).ChangeBatchProduct(Convert.ToInt32(e.Value));
            }
        }


    }
}
