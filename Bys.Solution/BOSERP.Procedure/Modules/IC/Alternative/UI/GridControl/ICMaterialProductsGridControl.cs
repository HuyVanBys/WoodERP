using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Alternative
{
    public class ICMaterialProductsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            AlternativeEntities entity = (AlternativeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MaterialList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "ICProductNo", "Mã sản phẩm");
            AddGridColumn(strTableName, "ICProductName", "Tên sản phẩm");
            AddGridColumn(strTableName, "ICProductDesc", "Mô tả");
            AddGridColumn(strTableName, "ICProductHeight", "Dày (mm)");
            AddGridColumn(strTableName, "ICProductWidth", "Rộng (mm)");
            AddGridColumn(strTableName, "ICProductLength", "Dài (mm)");
            //AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT");
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
            GridColumn column = gridView.Columns["Alternative"];
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
            return gridView;
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
                    ((AlternativeModule)Screen.Module).ShowDetailAlternative(obj, true);
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
                    ((AlternativeModule)Screen.Module).ShowListAlternative(obj, true);

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
