using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class PlanItemChildMaterialsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public void InvalidateDataSource(List<MMOperationDetailPlanItemChildsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn gridColumn = gridView.Columns["ItemMeterialPlanProductQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n4");
            }
            gridColumn = gridView.Columns["FK_ICProductID"];
            if (gridColumn != null)
            {
                gridColumn.Group();
            }
            gridColumn = gridView.Columns["ItemMeterialPlanProductNo"];
            if (gridColumn != null)
            {
                gridColumn.Group();
            }
            gridColumn = gridView.Columns["MMOperationDetailPlanItemChildExecutionFromDate"];
            if (gridColumn != null)
            {
                gridColumn.Group();
            }
            GridGroupSummaryItem sum = new GridGroupSummaryItem();
            sum.FieldName = "ItemMeterialPlanProductQty";
            sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            sum.DisplayFormat = "{0:n4}";
            sum.ShowInGroupColumnFooter = gridView.Columns["ItemMeterialPlanProductQty"];
            gridView.GroupSummary.Add(sum);
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            return gridView;
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "FK_MMBatchProductID", "Mã LSX", "MMBatchProducts", "MMBatchProductNo", "MMBatchProductID");
            AddGridColumn(strTableName, "FK_ICProductForBatchID", "Mã thành phẩm", "ICProducts", "ICProductNo", "ICProductID");
            AddGridColumn(strTableName, "ICProductFBName", "Tên thành phẩm");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemNo", "Mã chi tiết");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductName", "Tên chi tiết");
            AddGridColumn(strTableName, "ItemMeterialPlanProductNo", "Mã vật tư");
            AddGridColumn(strTableName, "ItemMeterialPlanProductName", "Tên vật tư");
            AddGridColumn(strTableName, "ItemMeterialPlanProductDesc", "Mô tả vật tư");
            AddGridColumn(strTableName, "MMOperationDetailPlanItemChildExecutionFromDate", "Từ ngày");
            AddGridColumn(strTableName, "MMOperationDetailPlanItemChildExecutionToDate", "Đến ngày");
            AddGridColumn(strTableName, "FK_MMOperationID", "Công đoạn", "MMOperations", "MMOperationName", "MMOperationID");
            AddGridColumn(strTableName, "FK_MMLineID", "Chuyền", "MMLines", "MMLineName", "MMLineID");
            AddGridColumn(strTableName, "FK_MMWorkShopID", "Xưởng", "MMWorkShops", "MMWorkShopName", "MMWorkShopID");
            AddGridColumn(strTableName, "ItemMeterialPlanProductQty", "SL kế hoạch");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
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
