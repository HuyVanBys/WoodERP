using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPlan

{
    public partial class guiFilterBatchProduct : BOSERPScreen
    {
        public List<MMBatchProductsInfo> ListBatchProducts = new List<MMBatchProductsInfo>();
        public List<MMBatchProductItemsInfo> ListBatchProductItems = new List<MMBatchProductItemsInfo>();
        public List<ICProductItemMaterialsInfo> ListProductItemMaterial = new List<ICProductItemMaterialsInfo>();
        public guiFilterBatchProduct()
        {
            InitializeComponent();
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

        private void guiFilterBatchProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            AddCollumnForGridView();
        }
        public void AddCollumnForGridView()
        {
            GridColumn col = new GridColumn();
            col.FieldName = "Selected";
            col.Caption = "Chọn";
            col.Visible = true;
            col.VisibleIndex = 0;
            ((GridView)fld_dgcICProducts.MainView).Columns.Insert(0, col);
            ((GridView)fld_dgcICProducts.MainView).OptionsView.ShowAutoFilterRow = true;

            //col = new GridColumn();
            //col.FieldName = "MMBatchProductNo";
            //col.Caption = "Mã LSX";
            //col.OptionsColumn.AllowEdit = false;
            //col.Visible = true;
            //col.VisibleIndex = 1;
            //((GridView)fld_dgcICProducts.MainView).Columns.Insert(1, col);

            col = new GridColumn();
            col.FieldName = "MMBatchProductItemProductNo";
            col.Caption = "Mã thành phẩm";
            col.OptionsColumn.AllowEdit = false;
            col.Visible = true;
            col.VisibleIndex = 1;
            ((GridView)fld_dgcICProducts.MainView).Columns.Insert(2, col);

            col = new GridColumn();
            col.FieldName = "MMBatchProductItemProductName";
            col.Caption = "Tên thành phẩm";
            col.OptionsColumn.AllowEdit = false;
            col.Visible = true;
            col.VisibleIndex = 1;
            ((GridView)fld_dgcICProducts.MainView).Columns.Insert(3, col);

        }
        private void fld_btnSearch_Click_1(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            int collectionID = Convert.ToInt32(fld_lkeICCollections.EditValue);
            int batchProductID = Convert.ToInt32(fld_lkeBatchProductID.EditValue);
            string woodtype = fld_lkeICProductIdentifyWoodType.EditValue.ToString();

            //ICProductsController objPDController = new ICProductsController();
            //List<ICProductsInfo> dataList = objPDController.GetListByCustomerAndCollection(customerID, collectionID, woodtypeID);
            //fld_dgcICProducts.DataSource = dataList;

            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> batchProductItemsList = objBatchProductProductionNormItemsController.GetListBySomeMaterial(customerID, collectionID, woodtype, batchProductID);
            fld_dgcICProducts.DataSource = batchProductItemsList;

        }

        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcICProducts.MainView;
            List<MMBatchProductProductionNormItemsInfo> listView = new List<MMBatchProductProductionNormItemsInfo>();

            List<MMBatchProductProductionNormItemsInfo> objects = new List<MMBatchProductProductionNormItemsInfo>();
            //(List<MMBatchProductItemsInfo>)fld_dgcMMBatchProductItems.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductProductionNormItemsInfo objDataViewPermissionsInfo = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMBatchProductProductionNormItemsInfo objDataViewPermissionsInfo = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(j);
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


        private void fld_chkChecked_CheckedChanged(object sender, EventArgs e)
        {

            CheckedAllByFilterCondition(fld_chkChecked.Checked);
            ((GridView)fld_dgcICProducts.MainView).GridControl.RefreshDataSource();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            List<MMBatchProductProductionNormItemsInfo> dataList = (List<MMBatchProductProductionNormItemsInfo>)fld_dgcICProducts.DataSource;
            dataList = dataList.Where(i => i.Selected == true).ToList();
            ((WoodPlanModule)this.Module).AddListItemFromBatchProduct(dataList);
        }

        private void fld_btnClosed_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
