using System;

namespace BOSERP.Modules.BusinessResult.UI
{
    /// <summary>
    /// Summary description for DMBR100
    /// </summary>
    public partial class DMBR100 : BOSERPScreen
    {

        public DMBR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((BusinessResultModule)Module).GetData(fld_dteACBusinessResultFromDate.DateTime, fld_dteACBusinessResultToDate.DateTime);
        }
    }
}
