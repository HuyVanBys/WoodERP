using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class SemiProductsGridControl : BOSGridControl
    {
        
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SemiProductList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
         
            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductNo"].Visible = true;
                gridView.Columns["ICProductNo"].VisibleIndex = 0;
                gridView.Columns["ICProductNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }

            if (gridView.Columns["ICProductItemQty"] != null)
            {
                gridView.Columns["ICProductNo"].OptionsColumn.AllowEdit = true;
                gridView.Columns["ICProductNo"].Visible = true;                
            }

            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            return gridView;
        }

        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool value = (bool)view.GetRowCellValue(e.RowHandle, "HasComponent");
                if (value != null && (value == true))
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

    
    }
}
