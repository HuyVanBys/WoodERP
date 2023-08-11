using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Transfer
{
    public partial class guiChoosePurchaseOrderItemOutSourcing : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<APPurchaseOrderItemOutSourcingsInfo> SelectedObjects { get; set; }

        public List<APPurchaseOrderItemOutSourcingsInfo> PurchaseOrderItemOutSourcingList { get; set; }

        public string ProposalProductType { get; set; }

        #endregion
        public guiChoosePurchaseOrderItemOutSourcing()
        {
            InitializeComponent();
            PurchaseOrderItemOutSourcingList = new List<APPurchaseOrderItemOutSourcingsInfo>();
            SelectedObjects = new List<APPurchaseOrderItemOutSourcingsInfo>();
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

        private void guiChoosePurchaseOrderItemOutSourcing_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            DateTime toDay = BOSApp.GetCurrentServerDate();
            fld_dteFromDate.EditValue = toDay.AddMonths(-1);
            fld_dteToDate.EditValue = toDay;
            GridView gridView = (GridView)fld_dgcPurchaseOrderItemOutSourcingsGridControl.MainView;
            fld_dgcPurchaseOrderItemOutSourcingsGridControl.InvalidateDataSource(PurchaseOrderItemOutSourcingList);
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcPurchaseOrderItemOutSourcingsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<APPurchaseOrderItemOutSourcingsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Select(o => o.FK_MMBatchProductID).Distinct().Count() > 1)
            {
                MessageBox.Show("Các sản phẩm được chọn không cùng Lệnh sản xuất. Vui lòng kiểm tra lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Fld_btnSearch_Click(object sender, EventArgs e)
        {
            TransferEntities entity = (TransferEntities)((TransferModule)Module).CurrentModuleEntity;
            int purchaseOrderID = fld_lkePurchaseOrderID.EditValue == null ? 0 : Int32.Parse(fld_lkePurchaseOrderID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            APPurchaseOrderItemOutSourcingsController controller = new APPurchaseOrderItemOutSourcingsController();
            PurchaseOrderItemOutSourcingList = controller.GetItemForTransfer(purchaseOrderID, fromDate, toDate);
            fld_dgcPurchaseOrderItemOutSourcingsGridControl.DataSource = PurchaseOrderItemOutSourcingList;
            fld_dgcPurchaseOrderItemOutSourcingsGridControl.RefreshDataSource();
        }
    }
}
