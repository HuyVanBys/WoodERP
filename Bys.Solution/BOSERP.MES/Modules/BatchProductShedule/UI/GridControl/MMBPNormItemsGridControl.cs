using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.BatchProductShedule
{
    public class MMBPNormItemsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        List<MMMaterialDepartmentsInfo> MaterialDepartList { get; set; }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "MMBatchProductNo", "Mã LSX");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemNo", "Mã chi tiết");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductName", "Tên chi tiết");
            AddGridColumn(strTableName, "ICProductCode", "Mã code");
            AddGridColumn(strTableName, "ICProductNo", "Mã vật tư");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductName", "Tên vật tư");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductDesc", "Mô tả vật tư");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductHeight", "Dày BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductWidth", "Rộng BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductLength", "Dài BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantity", "Tổng SL BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantityPerOne", "SL CT/ 1SP");
            AddGridColumn(strTableName, "MMBatchProductItemProductQty", "SL Thành phẩm");
            AddGridColumn(strTableName, "MMAllocationPlanItemHeight", "Dày");
            AddGridColumn(strTableName, "MMAllocationPlanItemWidth", "Rộng");
            AddGridColumn(strTableName, "MMAllocationPlanItemLength", "Dài");
            AddGridColumn(strTableName, "FK_ICProductAttributeWoodTypeID", "Loại gỗ", "ICProductAttributes", "ICProductAttributeValue", "ICProductAttributeID");
            AddGridColumn(strTableName, "ICProductFBNo", "Mã thành phẩm");
            AddGridColumn(strTableName, "ICProductFBName", "Tên thành phẩm");
            AddGridColumn(strTableName, "FK_ICProductAttributeTTMTID", "TTMT");
            AddGridColumn(strTableName, "MMAllocationPlanItemBPQty", "KL ĐM");
            AddGridColumn(strTableName, "MMAllocationPlanItemQty", "KL kế hoạch");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            AddGridColumn(strTableName, "MMAllocationPlanItemDeliveryDate", "Thời gian cần");
            AddGridColumn(strTableName, "FK_MMOperationID", "Công đoạn", "MMOperations", "MMOperationName", "MMOperationID");
            AddGridColumn(strTableName, "AllocationTypeText", "Loại cấp phát");
            AddGridColumn(strTableName, "MMAllocationPlanItemComment", "Ghi chú");
            AddGridColumn(strTableName, "MMBatchProductItemProductSerial", "Mã lô LSX");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemTSHH", "Tỉ số tiêu hao BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemKLBTP", "Khối lượng BTP/TP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemTotalKLBTP", "Tổng khối lượng BTP");
            AddGridColumn(strTableName, "MMAllocationPlanItemDepreciationRate", "Tỉ số tiêu hao");
            AddGridColumn(strTableName, "MMAllocationPlanItemAltFactor", "Tỉ lệ (1:?)");
            AddGridColumn(strTableName, "ICProductAlternativeProductQty", "KL thay thế");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            MaterialDepartList = (new MMMaterialDepartmentsController()).GetAllMaterialDepartment();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            GridColumn gridColumn = gridView.Columns["MMBatchProductProductionNormItemMeterialHeigth"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n3");
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemMeterialWidth"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n3");
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemMeterialLength"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n3");
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemMeterialDepreciationQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n5");
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n6");
            }
            gridColumn = gridView.Columns["ICProductAlternativeProductQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, true, "n6");
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemDepreciationRate"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, true, "n2");
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemTSHH"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n2");
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemAltFactor"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, true, "n2");
            }
            gridColumn = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = false;
            }
            GridGroupSummaryItem sum = new GridGroupSummaryItem();
            sum.FieldName = "ICProductAlternativeProductQty";
            sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            sum.DisplayFormat = "{0:n6}";
            sum.ShowInGroupColumnFooter = gridView.Columns["ICProductAlternativeProductQty"];
            gridView.GroupSummary.Add(sum);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMAllocationPlanItemQty"
                    || e.Column.FieldName == "MMAllocationPlanItemBPQty"
                    || e.Column.FieldName == "MMAllocationPlanItemDepreciationRate"
                    || e.Column.FieldName == "MMAllocationPlanItemAltFactor"
                    || e.Column.FieldName == "ICProductAlternativeProductQty") 
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                    e.Appearance.BackColor = Color.PaleTurquoise;
                    e.Appearance.BackColor2 = Color.PaleTurquoise;
                }
            }
        }

        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "", string filteredColumn = "", string filteredValues = "")
        {
            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAFilteredColumn = filteredColumn,
                AAFilteredValues = filteredValues,
                AAAllowDummy = true,
                Visible = true
            });
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(e.ListSourceRowIndex);
            if (item == null)
                return;

            if (e.Column.FieldName == "FK_ICProductAttributeTTMTID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
                }
            }
        }
    }
}
