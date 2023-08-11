using BOSERP.Utilities;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class guiShowBatchProductMessage : BOSERPScreen
    {
        public int BatchProductID { get; set; }

        public int BatchProductItemID { get; set; }

        public string MMProductionType { get; set; }

        private List<MMBatchProductMessagesInfo> BatchProductItemList { get; set; }

        private MMBatchProductItemsInfo BatchProductItemsInfo { get; set; }

        public guiShowBatchProductMessage(List<MMBatchProductMessagesInfo> batchProductItemList)
        {
            InitializeComponent();
            BatchProductItemList = batchProductItemList;
            BatchProductItemsInfo = new MMBatchProductItemsInfo();
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

        private void guiChooseProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            fld_dgcBatchProductMessagesGridControl.InvalidateDataSource(BatchProductItemList);
            BatchProductItemsInfo.FK_MMBatchProductID = BatchProductID;
            if (BatchProductItemID > 0)
            {
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                BatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(BatchProductItemID);
            }
            BatchProductItemsInfo.MMProductionType = MMProductionType;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_dgcBatchProductMessagesGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = fld_dgcBatchProductMessagesGridControl.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                XtraReportHelper.ShowRefFromModule(new BOSList<ADTemplateParamsInfo>(), BatchProductItemsInfo, this.Module.Controls, this.Module.Name, this.Module, string.Empty);
            }
        }
    }
}
