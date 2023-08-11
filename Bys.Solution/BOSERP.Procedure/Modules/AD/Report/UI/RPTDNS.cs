using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSCommon;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using BOSReport;
using DevExpress.XtraPrinting;
using System.Diagnostics;
using BOSERP.Modules.BudgetTracking;

namespace BOSERP.Modules.Report
{
    public partial class RPTDNS : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        public RPTDNS()
        {
            BudgetTracking.BudgetTrackingModule budgetTrackingModule = (BudgetTracking.BudgetTrackingModule)BOSApp.ShowModule("BudgetTracking");
            if (budgetTrackingModule == null)
                return;

            BudgetTracking.BudgetTrackingEntities budgetTrackingEntities = (BudgetTracking.BudgetTrackingEntities)budgetTrackingModule.CurrentModuleEntity;
            //budgetTrackingModule.ActionNew();
        }
      
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            
        }

        private void RPTDNS_Load(object sender, EventArgs e)
        {
        }     

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}