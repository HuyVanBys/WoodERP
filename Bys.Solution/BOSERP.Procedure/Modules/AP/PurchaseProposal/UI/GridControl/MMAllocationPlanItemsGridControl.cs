using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class MMAllocationPlanItemsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public void InvalidateDataSource(List<MMAllocationPlanItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "FK_MMBatchProductID", "Mã LSX", "MMBatchProducts", "MMBatchProductNo", "MMBatchProductID");
            AddGridColumn(strTableName, "FK_ICProductID", "Mã vật tư");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductName", "Tên vật tư");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductDesc", "Mô tả");
            AddGridColumn(strTableName, "MMAllocationPlanItemLength", "Dài");
            AddGridColumn(strTableName, "MMAllocationPlanItemWidth", "Rộng");
            AddGridColumn(strTableName, "MMAllocationPlanItemHeight", "Cao");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            AddGridColumn(strTableName, "ICProductMeasureUnitFactor", "Hệ số");
            AddGridColumn(strTableName, "MMAllocationPlanItemBPQty", "SL định mức");
            AddGridColumn(strTableName, "APProposalItemProductQty", "SL đã đề nghị");
            AddGridColumn(strTableName, "ICInventoryStockQty", "SL tồn kho");
            AddGridColumn(strTableName, "MMAllocationPlanItemQty", "SL cần mua");
            AddGridColumn(strTableName, "MMAllocationPlanItemDeliveryDate", "Ngày cần");
            AddGridColumn(strTableName, "ICProductSemiProductNo", "Mã chi tiết");
            AddGridColumn(strTableName, "ICProductSemiProductName", "Tên chi tiết");
            AddGridColumn(strTableName, "ICProductFBNo", "Mã thành phẩm");
            AddGridColumn(strTableName, "ICProductFBName", "Tên thành phẩm");
            AddGridColumn(strTableName, "MMBatchProductItemProductSerial", "Mã lô SX");
            AddGridColumn(strTableName, "MMAllocationPlanNo", "Mã KHSD");
            AddGridColumn(strTableName, "MMAllocationPlanItemComment", "Ghi chú");
            AddGridColumn(strTableName, "MMBatchProductItemSOName", BaseLocalizedResources.SaleOrderName);
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

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["MMAllocationPlanItemQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["MMAllocationPlanItemBPQty"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["APProposalItemProductQty"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["ICInventoryStockQty"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n5");
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (gridView.FocusedRowHandle < 0)
                return;

            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "MMAllocationPlanItemQty" && item.MMAllocationPlanItemQty > item.MMAllocationPlanItemBPQty - item.APProposalItemProductQty)
            {
                MessageBox.Show("SL cần mua không được lớn hơn số lượng định mức.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbUtil.SetPropertyValue(item, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                gridView.ActiveEditor.EditValue = gridView.ActiveEditor.OldEditValue;
                gridView.RefreshData();
                return;
            }
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
                else
                    e.DisplayText = "";
            }
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
                return;

            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(e.RowHandle);
            if (e.Column.FieldName == "ICInventoryStockQty" && e.CellValue != null)
            {
                if (item.IsCheckInventory)
                {
                    if (item.MMAllocationPlanItemBPQty - item.APProposalItemProductQty > item.ICInventoryStockQty)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.BackColor2 = Color.Yellow;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.BackColor2 = Color.Green;
                    }
                }
            }
        }
    }
}
