using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class MMBPPNormItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL kế hoạch";
            column.FieldName = "MMOperationDetailPlanItemChildPlanProductQty";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Unit time (Phút)";
            column.FieldName = "MMOperationDetailPlanItemChildUnitTime";
            column.OptionsColumn.AllowEdit = true;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "Selected" ||
                    column.FieldName == "FK_MMWorkShopID" ||
                    column.FieldName == "FK_MMLineID" ||
                    column.FieldName == "MMOperationDetailPlanItemChildExecutionFromDate" ||
                    column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            InitColumnSummary("MMBatchProductProductionNormItemRemainQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMBatchProductProductionNormItemQuantity", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMOperationDetailPlanItemChildPlanProductQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMOperationDetailPlanItemChildPlanBlock", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMBatchProductProductionNormItemBlocks", DevExpress.Data.SummaryItemType.Sum);
            gridView.RowCellStyle += gridView_RowCellStyle;
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.CellValueChanging += GridView_CellValueChanging;
            gridView.OptionsView.ShowAutoFilterRow = true;

            return gridView;
        }

        private void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            guiChooseBPPINormOperation form = (guiChooseBPPINormOperation)this.Screen;
            MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
                item.IsError = false;
            if (e.Column.FieldName == "Selected" && item != null && e.RowHandle >= 0)
            {
                form.InvalidateMachineUnit(item, bool.Parse(e.Value.ToString()));
            }
        }

        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            decimal valueQty = 0;
            guiChooseBPPINormOperation form = (guiChooseBPPINormOperation)this.Screen;
            MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
                item.IsError = false;
            if (item != null && e.Column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
            {
                if (e.Value != null)
                    decimal.TryParse(e.Value.ToString(), out valueQty);
                item.IsError = false;
                if (valueQty > item.MMBatchProductProductionNormItemRemainQty)
                {
                    BOSApp.ShowMessage("Số lượng kế hoạch không thể lớn hơn SL còn lại!");
                    item.MMOperationDetailPlanItemChildPlanProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                }
                else
                    item.MMOperationDetailPlanItemChildPlanBlock = item.MMOperationDetailPlanItemChildPlanProductQty * item.MMBatchProductProductionNormItemBlockPerOne;
            }
            else if (item != null && e.Column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate")
            {
                DateTime toDate = DateTime.Now;
                if (e.Value != null)
                    DateTime.TryParse(e.Value.ToString(), out toDate);
                if (toDate.Date < item.MMOperationDetailPlanItemChildExecutionFromDate.Date)
                {
                    BOSApp.ShowMessage("Giá trị bạn chọn nhỏ hơn \"từ ngày\" !");
                    item.MMOperationDetailPlanItemChildExecutionFromDate = DateTime.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                }
            }

        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                GridView gridView = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(e.RowHandle);
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity" ||
                        e.Column.FieldName == "MMBatchProductProductionNormItemRemainQty")
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                        e.Appearance.BackColor = Color.Orange;
                        e.Appearance.BackColor2 = Color.Orange;
                        if (e.Column.FieldName == "MMBatchProductProductionNormItemRemainQty" && item.IsError)
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;
                        }
                    }
                    if (e.Column.FieldName == "MMBatchProductItemProductSerial" ||
                        e.Column.FieldName == "MMBatchProductProductionNormItemNo" ||
                        e.Column.FieldName == "MMBatchProductProductionNormItemName")
                    {
                        if (item.MMBatchProductProductionNormItemRemainQty < item.MMBatchProductProductionNormItemQuantity)
                        {
                            e.Appearance.BackColor = Color.Yellow;
                            e.Appearance.BackColor2 = Color.Yellow;
                        }
                    }
                    if (e.Column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty" ||
                        e.Column.FieldName == "MMOperationDetailPlanItemChildExecutionFromDate" ||
                        e.Column.FieldName == "FK_MMWorkShopID" ||
                        e.Column.FieldName == "FK_MMLineID" ||
                        e.Column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate")
                    {
                        if (!item.IsError)
                        {
                            e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                            e.Appearance.BackColor = Color.PaleTurquoise;
                            e.Appearance.BackColor2 = Color.PaleTurquoise;
                        }
                        else
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;
                        }
                    }
                    if (e.Column.FieldName == "MMBatchProductItemDeliveryDate" ||
                        e.Column.FieldName == "MMBatchProductItemNeededTime")
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                        e.Appearance.BackColor = Color.Orange;
                        e.Appearance.BackColor2 = Color.Orange;
                        BOSERP.Modules.OperationDetailPlan.guiChooseBPPINormOperation form = (BOSERP.Modules.OperationDetailPlan.guiChooseBPPINormOperation)this.Screen;
                        if (item != null && (e.Column.FieldName == "MMBatchProductItemDeliveryDate"))
                        {
                            if (item.MMBatchProductItemDeliveryDate.Date <= DateTime.Now.Date ||
                                item.MMBatchProductItemDeliveryDate.Date <= (form != null ? form.planFromdate.Date : DateTime.Now.Date))
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                        if (item != null && (e.Column.FieldName == "MMBatchProductItemNeededTime"))
                        {

                            if (item.MMBatchProductItemNeededTime.Date <= DateTime.Now.Date ||
                                item.MMBatchProductItemNeededTime.Date <= (form != null ? form.planFromdate.Date : DateTime.Now.Date))
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
