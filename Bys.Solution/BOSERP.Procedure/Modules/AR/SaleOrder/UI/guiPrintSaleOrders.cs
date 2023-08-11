using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiPrintSaleOrders : BOSERPScreen
    {
        #region Variables
        public BOSList<ARSaleOrdersInfo> SaleOrdersList { get; set; }

        public IList<ARSaleOrdersInfo> SelectedObjects { get; set; }

        public string ACObjectAccessKey { get; set; }

        #endregion

        public guiPrintSaleOrders(string acObjectAccessKey)
        {
            InitializeComponent();
            SaleOrdersList = new BOSList<ARSaleOrdersInfo>(TableName.ARSaleOrdersTableName);
            ACObjectAccessKey = acObjectAccessKey;
        }

        private void guiPrintPurchaseOrders_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            InitializeControls(Controls);
            GridView gridView = (GridView)fld_dgcARSaleOrderPrintGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            this.fld_lkeACObjectAccessKey.EditValue = ACObjectAccessKey;
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            SelectedObjects = SaleOrdersList.Where(s => s.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Select(o => o.ACObjectAccessKey).Distinct().Count() > 1)
            {
                MessageBox.Show(SaleOrderLocalizedResources.DuplicateObjectErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void GetDataSearch()
        {
            ACObjectAccessKey = fld_lkeACObjectAccessKey.EditValue == null ? string.Empty : fld_lkeACObjectAccessKey.EditValue.ToString();
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            if (!string.IsNullOrEmpty(ACObjectAccessKey))
                objObjectsInfo = objObjectsController.GetObjectByAccessKey(ACObjectAccessKey);
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            SaleOrdersList.Invalidate(objSaleOrdersController.GetAllSaleOrderForPrintMultiSaleOrer(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, searchFromDate, searchToDate));
            fld_dgcARSaleOrderPrintGridControl.DataSource = SaleOrdersList;
            fld_dgcARSaleOrderPrintGridControl.RefreshDataSource();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }
    }
}
