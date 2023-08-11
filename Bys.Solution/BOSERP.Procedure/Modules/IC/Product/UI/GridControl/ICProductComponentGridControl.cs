using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ICProductComponentGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductComponentsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductNo;
            //column.FieldName = "ICProductSerialNo";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductName;
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductDesc;
            column.FieldName = "ICProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = WorkProductLocalizedResources.ICProductComponentQty;
            //column.FieldName = "ICProductComponentQty";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ICProductComponentQty"] != null)
            {
                gridView.Columns["ICProductComponentQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductComponentDesc"] != null)
            {
                gridView.Columns["ICProductComponentDesc"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ProductEntities entity = (ProductEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (gridView.FocusedColumn.FieldName == "ICProductComponentQty")
            {
                ICProductComponentsInfo objProductComponentsInfo = (ICProductComponentsInfo)gridView.GetRow(e.RowHandle);
                if (objProductComponentsInfo != null)
                {
                    if (((ProductModule)Screen.Module).CheckExitComponet())
                    {
                        BOSApp.ShowMessage("Sản phẩm này đã được sử dụng. Không được phép thay đổi thông tin thành phần");
                        objProductComponentsInfo.ICProductComponentQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                if (!((ProductModule)Screen.Module).CheckExitComponet())
                    ((ProductModule)Screen.Module).DeleteItemFromICProductComponentsList();
                else
                    BOSApp.ShowMessage("Sản phẩm này đã được sử dụng. Không được phép thay đổi thông tin thành phần");
            }
        }
    }
}
