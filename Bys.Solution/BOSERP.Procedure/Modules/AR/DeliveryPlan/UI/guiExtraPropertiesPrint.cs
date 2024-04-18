using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSReport;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public partial class guiExtraPropertiesPrint : BOSERPScreen
    {
        #region Variables

        #endregion
        private int DeliveryPlanID;
        public guiExtraPropertiesPrint(int deliveryPlanID)
        {
            InitializeComponent();
            DeliveryPlanID = deliveryPlanID;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void fld_btnAdd_Click_1(object sender, EventArgs e)
        {
            string commodity = fld_medARDeliveryPlanCommodity.EditValue.ToString();
            string specifications = fld_medARDeliveryPlanSpecifications.EditValue.ToString();
            string rptFile = System.IO.Path.Combine("Reports", "RP_CustomsDeclarationContract.repx");
            BaseReport report = new BaseReport();
            guiReportPreview reviewer;
            bool bExists = System.IO.File.Exists(rptFile);
            if (!bExists)
            {
                if (MessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bạn có muốn thiết kế ?"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    reviewer = new guiReportPreview(report, rptFile, true);
                    reviewer.Show();
                    return;
                }
            }
            report.LoadLayout(rptFile);
            Utilities.XtraReportHelper.SetFormatField(report);

            DataSet dataSource = SqlDatabaseHelper.RunStoredProcedure("RP_CustomsDeclarationContract", ModuleName.DeliveryPlan, DeliveryPlanID);
            dataSource.Tables[0].Columns.Add("ARDeliveryPlanCommodity", typeof(string));
            dataSource.Tables[0].Columns.Add("ARDeliveryPlanSpecifications", typeof(string));
            dataSource.Tables[0].Rows[0]["ARDeliveryPlanCommodity"] = commodity;
            dataSource.Tables[0].Rows[0]["ARDeliveryPlanSpecifications"] = specifications;
            report.DataSource = dataSource;
            reviewer = new guiReportPreview(report, rptFile, true);
            reviewer.Show();
            this.Close();
        }

        private void fld_btnClosed_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}