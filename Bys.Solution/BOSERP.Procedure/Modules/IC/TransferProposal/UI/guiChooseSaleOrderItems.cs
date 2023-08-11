using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferProposal
{
    public partial class guiChooseSaleOrderItems : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public List<ARSaleOrderItemsInfo> SaleOrderItemList { get; set; }

        public List<ARSaleOrderItemsInfo> SelectedObjects { get; set; }

        public guiChooseSaleOrderItems(List<ARSaleOrderItemsInfo> saleOrderItemList)
        {
            InitializeComponent();
            SaleOrderItemList = new List<ARSaleOrderItemsInfo>();
            SaleOrderItemList = saleOrderItemList;
            fld_dteARSaleOrderToDate.EditValue = BOSApp.GetCurrentServerDate();
            fld_dteARSaleOrderFromDate.EditValue = BOSUtil.GetMonthBeginDate();
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

        private void guiChooseSaleOrderItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcAPProductsOfProposalItemsGridControl.InvalidateDataSource(SaleOrderItemList);
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = gridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            string acobjectAccessKey = fld_lkeACObjectAccessKey.EditValue == null ? string.Empty : fld_lkeACObjectAccessKey.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acobjectAccessKey);

            ARSaleOrderItemsController objSaleOrdersController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> saleOrderList = objSaleOrdersController.GetARSaleOrderItemsFromTransferProposal(objObjectsInfo.ACObjectID
                                                                                                                       , objObjectsInfo.ACObjectType
                                                                                                                       , (DateTime?)fld_dteARSaleOrderFromDate.EditValue
                                                                                                                       , (DateTime?)fld_dteARSaleOrderToDate.EditValue);

            SaleOrderItemList = saleOrderList;
            fld_dgcAPProductsOfProposalItemsGridControl.InvalidateDataSource(SaleOrderItemList);
        }
    }
}
