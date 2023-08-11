using BOSCommon;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiAddSalesman : BOSERPScreen
    {
        public List<ARSalesmansInfo> SalesmansList;

        public int FK_ARSellerID = 0;
        public guiAddSalesman()
        {
            InitializeComponent();
        }

        public guiAddSalesman(List<ARSalesmansInfo> salesmansList, int sellerID)
        {
            SalesmansList = salesmansList;
            FK_ARSellerID = sellerID;
            InitializeComponent();
        }

        private void guiChooseSupplier_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ARSalesmansInfo objSalesmansInfo = SalesmansList
                .Where(p => p.ARSalesmanType == SalesmanType.MainSeller.ToString()).FirstOrDefault();

            if (objSalesmansInfo == null)
                fld_lkeARSellerID.EditValue = FK_ARSellerID;
            else
            {
                fld_lkeARSellerID.EditValue = objSalesmansInfo.FK_HREmployeeID;
                fld_lbCommissionPercent.Text = objSalesmansInfo.ARSalesmanCommissionPercent.ToString();
            }

            SalesmansList = SalesmansList.Where(p => p.ARSalesmanType == SalesmanType.SubSeller.ToString()).ToList();
            //if(SalesmansList.GridControl == null)
            //    SalesmansList.GridControl = fld_dgcARSalesmans;
            fld_dgcARSalesmans.InvalidateGridControlDataSource(SalesmansList);
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

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(FK_ARSellerID);
            ARSalesmansInfo objSalesmansInfo = new ARSalesmansInfo();
            objSalesmansInfo.FK_HREmployeeID = FK_ARSellerID;
            objSalesmansInfo.ARSalesmanName = objEmployeesInfo != null ? objEmployeesInfo.HREmployeeName : string.Empty;
            objSalesmansInfo.ARSalesmanCommissionPercent = Convert.ToDecimal(string.IsNullOrWhiteSpace(fld_lbCommissionPercent.Text.ToString()) ? "0" : fld_lbCommissionPercent.Text.ToString());
            objSalesmansInfo.ARSalesmanType = SalesmanType.MainSeller.ToString();
            decimal totalPercent = SalesmansList.Sum(p => p.ARSalesmanCommissionPercent) + objSalesmansInfo.ARSalesmanCommissionPercent;
            if (totalPercent != null && totalPercent != Convert.ToDecimal(100))
            {
                MessageBox.Show("Tổng % Hoa hồng của người bán và người bán phụ phải bằng 100%",
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
            SalesmansList.Insert(0, objSalesmansInfo);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
