using BOSCommon;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public class MMViewChangeProcesssGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<MMBatchProductProductionNormItemProcesssInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            if (gridView.Columns["MMBatchProductProductionNormItemNewQuantity"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemNewQuantity"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMBatchProductProductionNormItemNewQuantity"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMOperationDetailPlanItemChildPlanProductQty"] != null)
            {
                gridView.Columns["MMOperationDetailPlanItemChildPlanProductQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMOperationDetailPlanItemChildPlanProductQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemJobCreateQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemJobCreateQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMBatchProductProductionNormItemJobCreateQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemReceiptQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemReceiptQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMBatchProductProductionNormItemReceiptQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMOperationDetailPlanCapacityItemProductQty"] != null)
            {
                gridView.Columns["MMOperationDetailPlanCapacityItemProductQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMOperationDetailPlanCapacityItemProductQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemApplyQuantity"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemApplyQuantity"].AppearanceCell.BackColor = Color.PaleTurquoise;
                gridView.Columns["MMBatchProductProductionNormItemApplyQuantity"].AppearanceCell.BackColor2 = Color.PaleTurquoise;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemRemainQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemRemainQty"].AppearanceCell.BackColor = Color.PaleTurquoise;
                gridView.Columns["MMBatchProductProductionNormItemRemainQty"].AppearanceCell.BackColor2 = Color.PaleTurquoise;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemQuantity"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemQuantity"].Caption = "SL ĐM (cũ)";
                gridView.Columns["MMBatchProductProductionNormItemQuantity"].AppearanceCell.BackColor = Color.DarkGray;
                gridView.Columns["MMBatchProductProductionNormItemQuantity"].AppearanceCell.BackColor2 = Color.DarkGray;
            }


            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }
        public virtual void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;

            MMBatchProductProductionNormItemProcesssInfo row = (MMBatchProductProductionNormItemProcesssInfo)gridView.GetRow(e.RowHandle);
            if (row != null && e.Column.FieldName == "MMBatchProductProductionNormItemApplyQuantity")
            {
                if (row.MMBatchProductProductionNormItemType == Status.Delete.ToString() || row.MMBatchProductProductionNormItemType == Status.Decrease.ToString())
                {
                    if (row.MMBatchProductProductionNormItemApplyQuantity > row.MMBatchProductProductionNormItemRemainQty)
                    {
                        BOSApp.ShowMessage("Số lượng có thể thay đổi lớn hơn SL được phép thay: " + row.MMBatchProductProductionNormItemRemainQty.ToString());
                        row.MMBatchProductProductionNormItemApplyQuantity = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            MMBatchProductProductionNormItemProcesssInfo item = (MMBatchProductProductionNormItemProcesssInfo)gridView.GetRow(e.RowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "MMBatchProductProductionNormItemType")
            {
                if (item.MMBatchProductProductionNormItemType == Status.Delete.ToString())
                    DrawingCell(e, Color.Red, Color.Red, Color.Black);
                else if (item.MMBatchProductProductionNormItemType == Status.New.ToString())
                    DrawingCell(e, Color.Green, Color.Green, Color.Red);
                else if (item.MMBatchProductProductionNormItemType == Status.Increase.ToString())
                    DrawingCell(e, Color.YellowGreen, Color.YellowGreen, Color.Red);
                else if (item.MMBatchProductProductionNormItemType == Status.Decrease.ToString())
                    DrawingCell(e, Color.OrangeRed, Color.OrangeRed, Color.Red);
            }
            else if (e.Column.FieldName == "MMBatchProductProductionNormItemNewQuantity")
            {
                if (item.MMBatchProductProductionNormItemType == Status.Delete.ToString())
                    DrawingCell(e, Color.Transparent, Color.Transparent, Color.Red);
                else if (item.MMBatchProductProductionNormItemType == Status.New.ToString())
                    DrawingCell(e, Color.Transparent, Color.Transparent, Color.Red);
                else if (item.MMBatchProductProductionNormItemType == Status.Increase.ToString())
                    DrawingCell(e, Color.Transparent, Color.Transparent, Color.Red);
                else if (item.MMBatchProductProductionNormItemType == Status.Decrease.ToString())
                    DrawingCell(e, Color.Transparent, Color.Transparent, Color.Red);
            }
            else if (e.Column.FieldName == "MMBatchProductProductionNormItemApplyQuantity")
                if (item.IsError) DrawingCell(e, Color.Red, Color.Red, Color.Black);
        }
        private void DrawingCell(RowCellStyleEventArgs e, Color BackColor, Color BackColor2, Color ForeColor)
        {
            if (BackColor != Color.Transparent) e.Appearance.BackColor = BackColor;
            if (BackColor2 != Color.Transparent) e.Appearance.BackColor2 = BackColor2;
            e.Appearance.ForeColor = ForeColor;
            e.Appearance.BackColor = BackColor;
        }
    }
}
