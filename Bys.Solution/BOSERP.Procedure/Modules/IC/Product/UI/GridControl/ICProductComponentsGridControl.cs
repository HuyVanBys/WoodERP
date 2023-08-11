using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ICProductComponentsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductComponentsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["ICProductComponentQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductComponentDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductComponentChildID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ProductEntities entity = (ProductEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (gridView.FocusedColumn.FieldName == "FK_ICProductComponentChildID")
            {
                ICProductComponentsInfo objProductComponentsInfo = (ICProductComponentsInfo)gridView.GetRow(e.RowHandle);
                if (objProductComponentsInfo != null)
                {
                    ((ProductModule)Screen.Module).SetDefaultValuesToComponent(objProductComponentsInfo);
                }
            }
            else if (gridView.FocusedColumn.FieldName == "ICProductComponentQty")
            {
                ICProductComponentsInfo objProductComponentsInfo = (ICProductComponentsInfo)gridView.GetRow(e.RowHandle);
                if (objProductComponentsInfo != null)
                {
                    if (((ProductModule)Screen.Module).CheckExitComponet())
                    {
                        BOSApp.ShowMessage("Sản phẩm này đã được sử dụng. Không được phép thay đổi thông tin thành phần");
                        objProductComponentsInfo.ICProductComponentQty = decimal.Parse( gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICDepartmentName;
            column.FieldName = "ICDepartmentName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductGroupName;
            column.FieldName = "ICProductGroupName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductDesc;
            column.FieldName = "ICProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductAttribute;
            column.FieldName = "ICProductAttribute";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ProductLocalizedResources.ICProductSupplierNo;
            column.FieldName = "ICProductSupplierNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ProductLocalizedResources.APSupplierName;
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (!((ProductModule)Screen.Module).CheckExitComponet())
                    ((ProductModule)Screen.Module).RemoveSelectedItemFromProductComponent();
                else
                    BOSApp.ShowMessage("Sản phẩm này đã được sử dụng. Không được phép thay đổi thông tin thành phần");
            }
        }
    }
}
