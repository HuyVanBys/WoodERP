using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionPlanning
{
    public partial class guiChooseARSaleOrderItem : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        public List<ARSaleOrderItemsInfo> ARSaleOrderItemList { get; set; }

        private GridControlHelper GridControlHelper;

        public List<ARSaleOrderItemsInfo> SelectedObjects { get; set; }

        public guiChooseARSaleOrderItem(List<ARSaleOrderItemsInfo> saleOrderItemList)
        {
            InitializeComponent();
            ARSaleOrderItemList = saleOrderItemList;
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
            ProductionPlanningEntities entity = (ProductionPlanningEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            fld_dgcARSaleOrderItems.InitializeControl();
            fld_dgcARSaleOrderItems.InvalidateDataSource(ARSaleOrderItemList);
            GridView gridView = (GridView)fld_dgcARSaleOrderItems.MainView;
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.ExpandAllGroups();
            SelectedObjects = new List<ARSaleOrderItemsInfo>();
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)fld_dgcARSaleOrderItems.MainView;
            ARSaleOrderItemsInfo objProposalItemsInfo = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();
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
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần SX!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else
            {
                if (SelectedObjects.Any(o => o.ARSaleOrderType != SelectedObjects[0].ARSaleOrderType))
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
            fld_dgcARSaleOrderItems?.RefreshDataSource();
        }
        public void CheckSelectedAll(bool check)
        {
            if (check)
            {
                //   ARSaleOrderItemList.ForEach(o => o.Selected = check);
                GridView gridView = (GridView)fld_dgcARSaleOrderItems.MainView;
                List<ARSaleOrderItemsInfo> listView = new List<ARSaleOrderItemsInfo>();
                List<ARSaleOrderItemsInfo> objects = (List<ARSaleOrderItemsInfo>)fld_dgcARSaleOrderItems.DataSource;
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
    }
}
