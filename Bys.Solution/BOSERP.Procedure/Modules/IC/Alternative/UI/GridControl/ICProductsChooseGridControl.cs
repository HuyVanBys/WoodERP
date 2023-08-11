using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.Alternative
{
    public class ICProductsChooseGridControl : BOSGridControl
    {
        public bool isMaterial { get; set; }
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        public void InvalidateDataSource(BOSList<ICProductsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "ICProductParentNo", "Mã hàng hóa");
            AddGridColumn(strTableName, "ICProductParentName", "Tên hàng hóa");
            //AddGridColumn(strTableName, "MMProductionNormNo", "Mã bảng định mức");
            //AddGridColumn(strTableName, "ProductionNormStatus", "Tình trạng BDM");
            AddGridColumn(strTableName, "ICProductNo", "Mã chi tiết");
            AddGridColumn(strTableName, "ICProductName", "Tên chi tiết");
            AddGridColumn(strTableName, "ICProductItemQty", "Tỉ lệ (1:?)");
            AddGridColumn(strTableName, "ICProductHeight", "Dày (mm)");
            AddGridColumn(strTableName, "ICProductWidth", "Rộng (mm)");
            AddGridColumn(strTableName, "ICProductLength", "Dài (mm)");


            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }
        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "")
        {

            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAAllowDummy = true
            });
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICProductItemQty"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n2");
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
            column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanging += GridView_CellValueChanging;
            return gridView;
        }

        private void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo item = (ICProductsInfo)gridView.GetFocusedRow();

            if (e.Column.FieldName == "Selected" && item != null)
            {
                bool value = false;
                if (e.Value != null)
                    bool.TryParse(e.Value.ToString(), out value);
                if (isMaterial)
                {
                    guiAddMaterial guiAdd = (guiAddMaterial)this.Screen;
                    ((AlternativeModule)Screen.Module).ChangeSelectAlternative(item, value, guiAdd.Parent, isMaterial);
                    guiAdd.fld_dgcICProductAlternatives.RefreshDataSource();
                }
                else
                {
                    guiAddProduct guiAdd = (guiAddProduct)this.Screen;
                    ((AlternativeModule)Screen.Module).ChangeSelectAlternative(item, value, guiAdd.Parent, isMaterial);
                    guiAdd.fld_dgcICProductAlternatives.RefreshDataSource();
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
                return;

            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;
            bool select = item.Selected;
            if (e.Column.FieldName == "ICProductItemQty" && select)
            {

                if (isMaterial)
                {
                    guiAddMaterial guiAdd = (guiAddMaterial)this.Screen;
                    ((AlternativeModule)Screen.Module).ChangeSelectAlternative(item, select, guiAdd.Parent, isMaterial);
                    guiAdd.fld_dgcICProductAlternatives.RefreshDataSource();
                }
                else
                {
                    guiAddProduct guiAdd = (guiAddProduct)this.Screen;
                    ((AlternativeModule)Screen.Module).ChangeSelectAlternative(item, select, guiAdd.Parent, isMaterial);
                    guiAdd.fld_dgcICProductAlternatives.RefreshDataSource();
                }
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "ICProductItemQty")
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

            if (e.KeyCode == Keys.Delete)
            {
                //((AlternativeModule)Screen.Module).DeleteItemFromProductAlternativesList();
            }
        }
    }
}
