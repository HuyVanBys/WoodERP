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
    public class MMViewChangeGeneralsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<MMBatchProductProductionNormItemMeterialsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["MMBatchProductProductionNormItemMeterialAllocationQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemMeterialAllocationQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMBatchProductProductionNormItemMeterialAllocationQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemMeterialAllocatedQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemMeterialAllocatedQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMBatchProductProductionNormItemMeterialAllocatedQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemMeterialProposalQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemMeterialProposalQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMBatchProductProductionNormItemMeterialProposalQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemMeterialApplyQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemMeterialApplyQty"].AppearanceCell.BackColor = Color.PaleTurquoise;
                gridView.Columns["MMBatchProductProductionNormItemMeterialApplyQty"].AppearanceCell.BackColor2 = Color.PaleTurquoise;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemMeterialCanApplyQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemMeterialCanApplyQty"].AppearanceCell.BackColor = Color.PaleTurquoise;
                gridView.Columns["MMBatchProductProductionNormItemMeterialCanApplyQty"].AppearanceCell.BackColor2 = Color.PaleTurquoise;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemMeterialNewDepreciationQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemMeterialNewDepreciationQty"].AppearanceCell.BackColor = Color.AntiqueWhite;
                gridView.Columns["MMBatchProductProductionNormItemMeterialNewDepreciationQty"].AppearanceCell.BackColor2 = Color.AntiqueWhite;

            }
            if (gridView.Columns["MMBatchProductProductionNormItemMeterialDepreciationQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemMeterialDepreciationQty"].Caption = "SL ĐM (cũ)";
                gridView.Columns["MMBatchProductProductionNormItemMeterialDepreciationQty"].AppearanceCell.BackColor = Color.DarkGray;
                gridView.Columns["MMBatchProductProductionNormItemMeterialDepreciationQty"].AppearanceCell.BackColor2 = Color.DarkGray;
            }

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;

            MMBatchProductProductionNormItemMeterialsInfo row = (MMBatchProductProductionNormItemMeterialsInfo)gridView.GetRow(e.RowHandle);
            if (row != null && e.Column.FieldName == "MMBatchProductProductionNormItemMeterialChangeQty")
            {
                if (row.MMBatchProductProductionNormItemType == Status.Delete.ToString() || row.MMBatchProductProductionNormItemType == Status.Decrease.ToString())
                {
                    if (row.MMBatchProductProductionNormItemMeterialApplyQty > row.MMBatchProductProductionNormItemMeterialCanApplyQty)
                    {
                        BOSApp.ShowMessage("Số lượng có thể thay đổi lớn hơn SL được phép thay: " + row.MMBatchProductProductionNormItemMeterialCanApplyQty.ToString());
                        row.MMBatchProductProductionNormItemMeterialCanApplyQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
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

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            MMBatchProductProductionNormItemMeterialsInfo item = (MMBatchProductProductionNormItemMeterialsInfo)gridView.GetRow(e.RowHandle);
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
                    DrawingCell(e, Color.Orange, Color.Orange, Color.Red);
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
            else if (e.Column.FieldName == "MMBatchProductProductionNormItemMeterialApplyQty")
                if (item.IsError) DrawingCell(e, Color.Red, Color.Red, Color.Black);

        }
        private void DrawingCell(RowCellStyleEventArgs e, Color BackColor, Color BackColor2, Color ForeColor)
        {
            if (BackColor != Color.Transparent) e.Appearance.BackColor = BackColor;
            if (BackColor2 != Color.Transparent) e.Appearance.BackColor2 = BackColor2;
            e.Appearance.ForeColor = ForeColor;
        }
    }
}
