using System;

namespace BOSERP.Modules.ProductionCostCalculation.UI
{
    /// <summary>
    /// Summary description for DMPCC100
    /// </summary>
    public partial class DMPCC100 : BOSERPScreen
    {

        public DMPCC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnLoadFeeByFactor_Click(object sender, EventArgs e)
        {
            ((ProductionCostCalculationModule)Module).Calculate();
        }

        private void bosTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            string type = string.Empty;
            //e.Page.Name
            switch (e.Page.Name)
            {
                case "Statictis":
                case "Cost":
                case "OtherAllocation":
                    type = string.Empty;
                    break;
                case "ReceiptItem":
                    type = "ReceiptItem";
                    break;
                case "Allocation":
                    type = "Allocation";
                    break;
                case "Price":
                    type = "Price";
                    break;
                default:
                    type = string.Empty;
                    break;
            }
            if (!string.IsNullOrEmpty(type))
                ((ProductionCostCalculationModule)Module).InvalidateFocusModuleObjects(type);

        }
    }
}
