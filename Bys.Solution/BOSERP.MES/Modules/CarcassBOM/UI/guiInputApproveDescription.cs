using BOSCommon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiInputApproveDescription : BOSERPScreen
    {

        public string Desc = string.Empty;
        public string UpdateType = string.Empty;
        public List<MMBatchProductsInfo> BatchProductList { get; set; }
        public guiInputApproveDescription()
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



        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            bool isApprove = true;
            Desc = fld_medDesc.Text;
            if (string.IsNullOrEmpty(Desc))
            {
                BOSApp.ShowMessage("Vui lòng nhập mô tả");
                isApprove = false;
            }

            UpdateType = string.Empty;
            if (fld_lkeMMProductionNormApproveLogUpdateType.EditValue != null)
            {
                UpdateType = fld_lkeMMProductionNormApproveLogUpdateType.EditValue.ToString();
            }

            if (string.IsNullOrEmpty(UpdateType))
            {
                BOSApp.ShowMessage("Vui lòng chọn loại cập nhật");
                isApprove = false;
            }

            if (isApprove)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void guiInputApproveDescription_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
            MMProductionNormsInfo pn = (MMProductionNormsInfo)entity.MainObject;

            MMBatchProductsController bpCtrl = new MMBatchProductsController();
            BatchProductList = bpCtrl.GetBatchProductByProductionNormID(pn.MMProductionNormID);

            BindingSource bs = new BindingSource();
            bs.DataSource = BatchProductList;
            fld_dgcBatchProductApprove.DataSource = bs;

            GridView view = (GridView)fld_dgcBatchProductApprove.MainView;
            if (view != null)
            {
                view.OptionsView.ShowFooter = false;
                view.OptionsView.ShowAutoFilterRow = false;
            }
        }

        private void fld_lkeMMProductionNormApproveLogUpdateType_EditValueChanged(object sender, EventArgs e)
        {
            bool isAllowEdit = false;

            if (fld_lkeMMProductionNormApproveLogUpdateType.EditValue != null
                && fld_lkeMMProductionNormApproveLogUpdateType.EditValue.ToString() == ProductionNormApproveLogUpdateType.Some.ToString())
            {
                isAllowEdit = true;
            }

            fld_ckeSelectAll.Enabled = isAllowEdit;

            if (!isAllowEdit)
            {
                BatchProductList.ForEach(t => t.Selected = true);
            }

            GridView view = (GridView)fld_dgcBatchProductApprove.MainView;
            if (view != null)
            {
                GridColumn col = view.Columns["Selected"];
                if (col != null)
                {
                    col.OptionsColumn.AllowEdit = isAllowEdit;
                }
            }

            fld_dgcBatchProductApprove?.RefreshDataSource();
        }

        private void fld_ckeSelectAll_CheckedChanged(object sender, EventArgs e)
        {

            CheckedAllByFilterCondition(fld_ckeSelectAll.Checked);
            fld_dgcBatchProductApprove?.RefreshDataSource();

        }

        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcBatchProductApprove.MainView;
            List<MMBatchProductsInfo> listView = new List<MMBatchProductsInfo>();
            BindingSource bs = (BindingSource)fld_dgcBatchProductApprove.DataSource;
            List<MMBatchProductsInfo> objects = (List<MMBatchProductsInfo>)bs.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductsInfo objDataViewPermissionsInfo = (MMBatchProductsInfo)gridView.GetRow(j);
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
                        objects[i].Selected = isChecked;
                    }
                }

            }
        }
    }
}
