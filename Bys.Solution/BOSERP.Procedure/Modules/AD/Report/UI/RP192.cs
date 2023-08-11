using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP192 : ReportForm
    {
        #region Constructor
        public RP192()
        {
            InitializeComponent();
        }
        #endregion

        #region Override
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
        #endregion

        #region Events
        private void RP192_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            int productGroupID = Convert.ToInt32(fld_lkeICProductGroupID.EditValue);
            ICProductsController objProductsController = new ICProductsController();
            fld_dgcICRP192Products.DataSource = objProductsController.GetProductListForRP192(departmentID, productGroupID);
            fld_dgcICRP192Products.RefreshDataSource();
        }
    }
}
