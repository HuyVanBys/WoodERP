using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PriceAdjustment

{
    public partial class guiFilter : BOSERPScreen
    {
        public int FK_ICDepartmentID = 0, FK_ICProductGroupID = 0, ICStockID = 0;
        public string ICProductGroupNo = string.Empty, ICProductGroupName = string.Empty;
        public DateTime FromDate, ToDate;
        public guiFilter()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            //FromDate = DateTime.Now;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            int.TryParse(fld_lkeFK_ICStockID1.EditValue.ToString(), out ICStockID);
            FromDate = fld_dteICReceiptFromDate.DateTime;
            ToDate = fld_dteICReceiptToDate.DateTime;
            Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                InitializeFieldFormat(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiChooseDate_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteICReceiptFromDate.DateTime = DateTime.Now;
            fld_dteICReceiptToDate.DateTime = DateTime.Now;

        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(FK_ICDepartmentID, FK_ICProductGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    FK_ICDepartmentID = guiProductGroupTree.ICDepartmentID;
                    FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;
                    ICProductGroupName = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_bedFK_ICProductGroupID.Text = ICProductGroupName;
                }
                else
                {
                    FK_ICProductGroupID = 0;
                    ICProductGroupName = string.Empty;
                }

            }


        }
    }
}
