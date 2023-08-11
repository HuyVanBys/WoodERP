using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ProductItemsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductItemList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridview.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(gridview_ValidateRow);
            //  gridview.DoubleClick += new System.EventHandler(gridview_DoubleClick);
            return gridview;
        }

        void gridview_DoubleClick(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                ICProductsInfo product = (ICProductsInfo)gridView.GetFocusedRow();
                if (product != null)
                    ((ProductModule)Screen.Module).ShowProductStructureForm(product);
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
                    if (string.IsNullOrEmpty(product.ICProductCode.Trim()))
                        MessageBox.Show("Mã code không được để trống");
                    if (!product.HasComponent)
                    {
                        if (product.ICProductHeight == 0 ||
                            product.ICProductWidth == 0 ||
                            product.ICProductLength == 0)
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
            gridView.Columns.Insert(1, column);
            column.VisibleIndex = 1;

            column = new GridColumn();
            column.Caption = "Mã code";
            column.FieldName = "ICProductCode";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Insert(2, column);
            column.VisibleIndex = 2;

            column = new GridColumn();
            column.Caption = "Tên BTP";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(3, column);
            column.VisibleIndex = 3;

            column = new GridColumn();
            column.Caption = "Dày";
            column.FieldName = "ICProductHeight";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Insert(4, column);
            column.VisibleIndex = 4;
            RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = "n2";
            rep.Mask.UseMaskAsDisplayFormat = true;
            column.ColumnEdit = rep;

            column = new GridColumn();
            column.Caption = "Rộng";
            column.FieldName = "ICProductWidth";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Insert(5, column);
            column.VisibleIndex = 5;
            rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = "n2";
            rep.Mask.UseMaskAsDisplayFormat = true;
            column.ColumnEdit = rep;

            column = new GridColumn();
            column.Caption = "Dài";
            column.FieldName = "ICProductLength";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Insert(6, column);
            column.VisibleIndex = 6;
            rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = "n2";
            rep.Mask.UseMaskAsDisplayFormat = true;
            column.ColumnEdit = rep;

            column = new GridColumn();
            column.Caption = "Đặc tính";
            column.FieldName = "FK_ICProductAttributeSemiProductSpecialityID";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Insert(7, column);
            column.VisibleIndex = 7;
            RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
            repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
            repositoryItemLookUpEdit.QueryPopUp += repositoryItemAttributeQualityLookupEdit_QueryPopUp;
            repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
            gridView.Columns["FK_ICProductAttributeSemiProductSpecialityID"].ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns["FK_ICProductAttributeSemiProductSpecialityID"].MinWidth = 150;
            this.RepositoryItems.Add(repositoryItemLookUpEdit);


            column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "ICProductItemQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(8, column);
            column.VisibleIndex = 8;
            rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = "n2";
            rep.Mask.UseMaskAsDisplayFormat = true;
            column.ColumnEdit = rep;

            column = new GridColumn();
            column.Caption = "Thứ tự";
            column.FieldName = "ICProductOrderID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(9, column);
            column.VisibleIndex = 9;
            rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = "n2";
            rep.Mask.UseMaskAsDisplayFormat = true;
            column.ColumnEdit = rep;


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
                ((ProductModule)Screen.Module).DeleteItemFromProductItemsList();
            }
        }
    }
}
