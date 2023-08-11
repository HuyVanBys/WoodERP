using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiSaleOrderWorkItemComponent : BOSERPScreen
    {
        #region Variables

        public BOSList<ARSaleOrderItemWorkItemsInfo> ARSaleOrderItemWorkItemList { get; set; }

        public BOSList<ARSaleOrderItemWorkTasksInfo> ARSaleOrderItemWorkTaskList { get; set; }

        public ARSaleOrderItemWorksInfo SaleOrderItemWorksInfo { get; set; }
        #endregion

        public guiSaleOrderWorkItemComponent(ARSaleOrderItemWorksInfo objSaleOrderItemWorksInfo, List<ARSaleOrderItemWorkItemsInfo> saleOrderItemWorkItemList, List<ARSaleOrderItemWorkTasksInfo> saleOrderItemWorkTaskList)
        {
            InitializeComponent();
            SaleOrderItemWorksInfo = objSaleOrderItemWorksInfo;
            ARSaleOrderItemWorkItemList = new BOSList<ARSaleOrderItemWorkItemsInfo>(TableName.ARSaleOrderItemWorkItemsTableName);
            saleOrderItemWorkItemList.ForEach(o => ARSaleOrderItemWorkItemList.Add(o));

            ARSaleOrderItemWorkTaskList = new BOSList<ARSaleOrderItemWorkTasksInfo>(TableName.ARSaleOrderItemWorkTasksTableName);
            saleOrderItemWorkTaskList.ForEach(o => ARSaleOrderItemWorkTaskList.Add(o));
        }

        private void guiProductWorkItemComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcSaleOrderWorkItemTasksGridControl.DataSource = ARSaleOrderItemWorkTaskList;
            fld_dgcARSaleOrderWorkItemComponentsGridControl.DataSource = ARSaleOrderItemWorkItemList;
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}