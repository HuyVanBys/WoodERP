using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AverageCost.UI
{
    /// <summary>
    /// Summary description for DMHM100
    /// </summary>
    public partial class DMACIB100 : BOSERPScreen
    {
        Dictionary<string, string> Months = new Dictionary<string, string>()
        {
            { "1", "Tháng 1"},
            { "2", "Tháng 2"},
            { "3", "Tháng 3"},
            { "4", "Tháng 4"},
            { "5", "Tháng 5"},
            { "6", "Tháng 6"},
            { "7", "Tháng 7"},
            { "8", "Tháng 8"},
            { "9", "Tháng 9"},
            { "10", "Tháng 10"},
            { "11", "Tháng 11"},
            { "12", "Tháng 12"},
        };

        public DMACIB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();

            fld_lkeMonth.Properties.DataSource = Months.ToList();
            fld_lkeMonth.Properties.ValueMember = "Key";
            fld_lkeMonth.Properties.DisplayMember = "Value";
            fld_lkeMonth.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Tháng"));
            fld_lkeMonth.EditValue = Months.Keys.ToArray()[DateTime.Now.Month - 1];

            fld_txtYear.EditValue = DateTime.Now.Year;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ((Modules.AverageCost.AverageCostModule)this.Module).CalculatorCost();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((Modules.AverageCost.AverageCostModule)this.Module).ApplyCost();
        }
    }
}
