using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class MMBatchProductItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMBatchProductItemList;
            DataSource = bds;
        }
        //protected override GridView InitializeGridView()
        //{
        //    GridView gridView = base.InitializeGridView();
        //    GridColumn column = gridView.Columns["ICProductBranchPrice"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //    }
        //    return gridView;
        //}
        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Mã LSX";
            column.FieldName = "MMBatchProductNo";
            column.Visible = true;
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày sản xuất";
            column.FieldName = "MMBatchProductDate";
            column.Visible = true;
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khách hàng";
            column.FieldName = "ARCustomerName";
            column.Visible = true;
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhân viên";
            column.FieldName = "HREmployeeName";
            column.Visible = true;
            column.VisibleIndex = 4;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
    }
}
