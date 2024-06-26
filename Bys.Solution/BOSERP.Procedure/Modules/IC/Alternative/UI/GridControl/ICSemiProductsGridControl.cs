using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Alternative
{
    public class ICSemiProductsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            AlternativeEntities entity = (AlternativeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "FK_ICProductCarcassID", "Mã sản phẩm");
            //AddGridColumn(strTableName, "ICProductParentNo", "Mã hàng hóa");
            AddGridColumn(strTableName, "ICProductParentName", "Tên sản phẩm");
            //AddGridColumn(strTableName, "MMProductionNormNo", "Mã bảng định mức");
            //AddGridColumn(strTableName, "ProductionNormStatus", "Tình trạng BDM");
            AddGridColumn(strTableName, "ICProductNo", "Mã chi tiết");
            AddGridColumn(strTableName, "ICProductName", "Tên chi tiết");
            AddGridColumn(strTableName, "ICProductHeight", "Dày (mm)");
            AddGridColumn(strTableName, "ICProductWidth", "Rộng (mm)");
            AddGridColumn(strTableName, "ICProductLength", "Dài (mm)");
            AddGridColumn(strTableName, "Alternative", "Chi tiết thay thế");
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
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ICProductCarcassID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["Alternative"];
            if (column != null)
            {
                column.VisibleIndex = 2;
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                rep1.NullText = "Thêm chi tiết";
                rep1.Click += new EventHandler(ViewAlternative);
                column.ColumnEdit = rep1;
            }
            column = gridView.Columns["ICProductHeight"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n2");
            }
            column = gridView.Columns["ICProductWidth"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n2");
            }
            column = gridView.Columns["ICProductLength"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n2");
            }
            gridView.BestFitColumns();
            gridView.CustomDrawGroupRow += GridView_CustomDrawGroupRow;
            return gridView;
        }
        private void GridView_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            GridView gridView = sender as GridView;
            GridGroupRowInfo row = e.Info as GridGroupRowInfo;
            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(row.RowHandle);
            if (item == null || row.EditValue == null)
                return;

            if (row.Column.FieldName == "FK_ICProductCarcassID" && item != null)
            {
                string productNo = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(row.EditValue.ToString()), "ICProductNo");
                string productName = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(row.EditValue.ToString()), "ICProductName");
                row.GroupText = productNo + (string.IsNullOrEmpty(productName) ? string.Empty : "(" + productName + ")");
            }
        }
        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductsInfo obj = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((AlternativeModule)Screen.Module).ShowDetailAlternative(obj, false);
                }
            }
        }

        private void ViewAlternative(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductsInfo obj = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((AlternativeModule)Screen.Module).ShowListAlternative(obj, false);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                // ((AlternativeModule)Screen.Module).DeleteItemFromProductAlternativesList();
            }
        }
    }
}
