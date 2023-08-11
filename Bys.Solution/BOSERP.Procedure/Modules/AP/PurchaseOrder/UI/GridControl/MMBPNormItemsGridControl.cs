using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public class MMBPNormItemsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        public void InvalidateDataSource(List<MMBatchProductProductionNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            //AddGridColumn(strTableName, "FK_MMBatchProductID", "Mã LSX", "MMBatchProducts", "MMBatchProductNo", "MMBatchProductID");
            //AddGridColumn(strTableName, "MMBatchProductProductionNormItemNo", "Mã chi tiết");
            AddGridColumn(strTableName, "MMBPSemiProductName", "Thuộc chi tiết");
            AddGridColumn(strTableName, "FK_ICProductID", "Mã vật tư", "ICProducts", "ICProductNo", "ICProductID");
            AddGridColumn(strTableName, "ICProductName", "Tên vật tư");
            AddGridColumn(strTableName, "ICProductDesc", "Mô tả vật tư");
            //AddGridColumn(strTableName, "FK_MMBPSemiProductID", "Thuộc BTP");
            //AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductName", "Tên chi tiết");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductHeight", "Dày");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductWidth", "Rộng");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductLength", "Dài");
            AddGridColumn(strTableName, "FK_ICProductForBatchID", "Mã thành phẩm", "ICProducts", "ICProductNo", "ICProductID");
            AddGridColumn(strTableName, "ICProductFBName", "Tên thành phẩm");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantity", "SL ĐM");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemGroupText", "Loại nguyên liệu");
            AddGridColumn(strTableName, "MMBatchProductNo", "Mã LSX");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            GridColumn gridColumn = gridView.Columns["MMBatchProductNo"];
            if (gridColumn != null)
            {
                gridColumn.Group();
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemGroupText"];
            if (gridColumn != null)
            {
                gridColumn.Group();
            }
            gridView.EndGrouping += GridView_EndGrouping;
            return gridView;
        }

        private void GridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            gridView.ExpandAllGroups();
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
                AAAllowDummy = true,
                Visible = true
            });
        }
    }
}
