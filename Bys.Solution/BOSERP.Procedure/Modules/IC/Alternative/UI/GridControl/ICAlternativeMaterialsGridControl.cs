using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.Alternative
{
    public class ICAlternativeMaterialsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            AlternativeEntities entity = (AlternativeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MaterialAlternativeList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Dày (mm)";
            column.FieldName = "ICProductHeight";
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng (mm)";
            column.FieldName = "ICProductWidth";
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài (mm)";
            column.FieldName = "ICProductLength";
            column.Visible = true;
            gridView.Columns.Add(column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICProductAlternativeQty"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n2");
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                FormatNumbericColumn(column, false, "n2");
            }
            column = gridView.Columns["ICProductWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                FormatNumbericColumn(column, false, "n2");
            }
            column = gridView.Columns["ICProductLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                FormatNumbericColumn(column, false, "n2");
            }
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "ICProductAlternativeQty")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                    e.Appearance.BackColor = Color.PaleTurquoise;
                    e.Appearance.BackColor2 = Color.PaleTurquoise;
                }
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {

                if (gridView.FocusedRowHandle >= 0)
                {
                    ICProductAlternativesInfo item = (ICProductAlternativesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        ((AlternativeModule)Screen.Module).DeleteItemFromMaterialAlternativesList(item);
                    }
                    this.RefreshDataSource();
                }
            }
        }
    }
}
