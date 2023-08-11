using BOSLib;
using System;

namespace BOSERP.Modules.BonusSales.UI
{
    /// <summary>
    /// Summary description for DMBNS100
    /// </summary>
    public partial class DMBNS100 : BOSERPScreen
    {

        public DMBNS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((BonusSalesModule)Module).AddEmployee();
        }

        private void fld_dteHRBonusSaleDate1_Validated(object sender, EventArgs e)
        {
            int n1 = fld_dteHRBonusSaleDate1.DateTime.Year;
            int n2 = fld_dteHRBonusSaleDate1.DateTime.Month;
            DateTime date = new DateTime(n1, n2, 1);
            DateTime dateEndMonth = BOSUtil.GetMonthEndDate(date);

            fld_dteHRBonusSaleToDate.DateTime = dateEndMonth;
            fld_dteHRBonusSaleFromDate.DateTime = date;
        }
    }
}
