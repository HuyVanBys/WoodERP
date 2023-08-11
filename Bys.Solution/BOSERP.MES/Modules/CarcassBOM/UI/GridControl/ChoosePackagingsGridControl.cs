using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ChoosePackagingsGridControl : BOSGridControl
    {

        //public override void InitGridControlDataSource()
        //{
        //    CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    BindingSource bds = new BindingSource();
        //    bds.DataSource = entity.ProductItemList;
        //    this.DataSource = bds;
        //}

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();

            string[] colList = new string[] { "Selected"
                                            ,   "ICProductInsideDimensionWidth"
                                            ,   "ICProductInsideDimensionLength"
                                            ,   "ICProductNo"
                                            ,   "ICProductName"
                                            ,   "ICProductDesc"
                                            ,   "FK_ICProdAttPackingMaterialWeightPerVolumeID"
                                            ,   "FK_ICProdAttPackingMaterialSizeID"
                                            ,   "FK_ICProdAttPackingMaterialSpecialityID"
                                            ,   "ICProductInsideDimensionHeight"


                                            };

            ReLocationColumn(colList, gridview);

            gridview.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridview_CellValueChanging);
            return gridview;
        }



        void gridview_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;

            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(e.RowHandle);

            if (item != null)
            {
                if (e.Column.FieldName == "Selected")
                {
                    if (e.Value != null)
                    {
                        bool isCheck = false;
                        if (bool.TryParse(e.Value.ToString(), out isCheck))
                        {
                            if (isCheck)
                            {
                                List<ICProductsInfo> productList = (List<ICProductsInfo>)this.DataSource;

                                foreach (ICProductsInfo p in productList)
                                {
                                    if (p.ICProductID != item.ICProductID)
                                    {
                                        p.Selected = false;
                                    }
                                    else
                                    {
                                        p.Selected = true;
                                    }
                                }

                                this.RefreshDataSource();
                            }
                        }
                    }
                }
            }

        }



        void gridview_DoubleClick(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                ICProductsInfo product = (ICProductsInfo)gridView.GetFocusedRow();
                if (product != null)
                    ((CarcassBOMModule)Screen.Module).ShowProductStructureForm(product);
            }
        }

        void gridview_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                ICProductsInfo product = (ICProductsInfo)gridView.GetFocusedRow();
                if (product != null)
                {
                    //if (string.IsNullOrEmpty(product.ICProductCode.Trim()))
                    //    MessageBox.Show("Mã code không được để trống");
                    if (!product.HasComponent)
                    {
                        bool isUnSpecifications = false;
                        if (product.FK_ICProductAttributeWoodTypeID > 0)
                        {
                            ICProductAttributesInfo obj = (ICProductAttributesInfo)(new ICProductAttributesController()).GetObjectByID(product.FK_ICProductAttributeWoodTypeID);
                            if (obj != null) isUnSpecifications = obj.ICProductAttributeUnSpecifications;
                        }
                        if (isUnSpecifications && (
                            product.ICProductHeight == 0 ||
                            product.ICProductWidth == 0 ||
                            product.ICProductLength == 0))
                            MessageBox.Show("Quy cách BTP không được để trống");
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        public string[] columnArr;
        public void ReLocationColumn(string[] columns, GridView gridView)
        {
            columnArr = columns;
            InitDefaultGridColumnsVisibleIndex(gridView);
        }
        protected override void InitDefaultGridColumnsVisibleIndex(GridView gridView)
        {
            if (columnArr != null && columnArr.Length > 0)
            {
                foreach (GridColumn columnedit1 in gridView.Columns)
                {
                    columnedit1.Visible = false;
                }
                GridColumn columnedit;
                int index = 1;
                foreach (string column in columnArr)
                {
                    columnedit = gridView.Columns[column];
                    if (columnedit != null)
                    {
                        columnedit.Visible = true;
                        columnedit.VisibleIndex = index++;
                    }
                }

                gridView.BestFitColumns();
            }
        }

        void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {

            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController productAttributeController = new ICProductAttributesController();
            List<ICProductAttributesInfo> collection = productAttributeController.GetProductAttributesByProductAttributeGroup("Speciality");
            if (collection != null && collection.Count > 0)
            {
                collection.Insert(0, new ICProductAttributesInfo());
                lookUpEdit.Properties.DataSource = collection;

            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((CarcassBOMModule)Screen.Module).DeleteItemFromProductItemsList();
            }
        }
    }
}
