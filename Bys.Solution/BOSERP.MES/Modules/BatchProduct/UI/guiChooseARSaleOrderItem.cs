using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class guiChooseARSaleOrderItem : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        public List<ARSaleOrderItemsInfo> ARSaleOrderItemList { get; set; }
        public guiChooseARSaleOrderItem()
        {
            InitializeComponent();
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
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            fld_dgcARSaleOrderItems.InitializeControl();
            GridView gridView = (GridView)fld_dgcARSaleOrderItems.MainView;
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.ExpandAllGroups();
            fld_dteSearchFromARSaleOrderDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToARSaleOrderDate.DateTime = DateTime.Now;
            ARSaleOrderItemList = new List<ARSaleOrderItemsInfo>();
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)fld_dgcARSaleOrderItems.MainView;
            ARSaleOrderItemsInfo objProposalItemsInfo = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedSaleOrderItems())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        public bool CheckSelectedSaleOrderItems()
        {
            bool result = true;
            List<ARSaleOrderItemsInfo> saleOrderItemCheckedList = ARSaleOrderItemList.Where(x => x.Selected).ToList();
            if (saleOrderItemCheckedList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần SX!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else
            {
                if (saleOrderItemCheckedList.Any(o => o.ARSaleOrderType != saleOrderItemCheckedList[0].ARSaleOrderType))
                {
                    if (MessageBox.Show("Chi tiết bạn chọn không cùng loại đơn hàng! bạn có muốn tiếp tục không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        result = false;
                    }
                }
            }


            return result;
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelectedAll(fld_chkSelectAll.Checked);
            fld_dgcARSaleOrderItems.RefreshDataSource();
        }
        public void CheckSelectedAll(bool check)
        {
            if (check)
            {
                //   ARSaleOrderItemList.ForEach(o => o.Selected = check);
                GridView gridView = (GridView)fld_dgcARSaleOrderItems.MainView;
                List<ARSaleOrderItemsInfo> listView = new List<ARSaleOrderItemsInfo>();
                List<ARSaleOrderItemsInfo> objects = (List<ARSaleOrderItemsInfo>)gridView.DataSource;
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    ARSaleOrderItemsInfo objDataViewPermissionsInfo = (ARSaleOrderItemsInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = check;
                        }
                    }

                }
            }
            else
                ARSaleOrderItemList.ForEach(o => { if (o.Selected) { o.Selected = check; } });
        }

        private void fld_btnSearchPI_Click(object sender, EventArgs e)
        {

            int customeid = 0, saleorderID = 0;
            if (fld_lkeARCustomerID.EditValue != null)
                int.TryParse(fld_lkeARCustomerID.EditValue.ToString(), out customeid);
            if (fld_lkeARSaleOrderID.EditValue != null)
                int.TryParse(fld_lkeARSaleOrderID.EditValue.ToString(), out saleorderID);

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;


            ARSaleOrderItemList = objSaleOrderItemsController.GetBatchProductRemainQtyBySomeCriteria(customeid
                                                                                                                    , saleorderID
                                                                                                                    , fld_dteSearchFromARSaleOrderDate.DateTime
                                                                                                                    , fld_dteSearchToARSaleOrderDate.DateTime);


            if (entity.BatchProductItemList != null && entity.BatchProductItemList.Count > 0 && ARSaleOrderItemList.Count > 0)
            {
                ARSaleOrderItemList = ARSaleOrderItemList.Where(o => !entity.BatchProductItemList.Any(b => b.FK_ARSaleOrderItemID == o.ARSaleOrderItemID)).ToList();
            }

            fld_dgcARSaleOrderItems.DataSource = ARSaleOrderItemList;
            fld_dgcARSaleOrderItems.RefreshDataSource();
        }
    }
}
