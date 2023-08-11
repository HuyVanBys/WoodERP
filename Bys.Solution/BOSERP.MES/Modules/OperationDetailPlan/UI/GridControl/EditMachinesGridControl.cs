using BOSCommon;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class EditMachinesGridControl : BOSGridControl
    {
        public bool IsEdit { get; set; }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMOperationDetailPlanItemChildBlockPerOne" ||
                    column.FieldName == "MMOperationDetailPlanItemChildTotalBlock" ||
                    column.FieldName == "MMOperationDetailPlanItemChildPlanBlock")
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (column.FieldName == "MMOperationDetailPlanItemChildProductLength" ||
                    column.FieldName == "MMOperationDetailPlanItemChildProductWidth" ||
                    column.FieldName == "MMOperationDetailPlanItemChildProductHeight" ||
                    column.FieldName == "MMOperationDetailPlanItemChildProductQty" ||
                    column.FieldName == "MMOperationDetailPlanItemChildTotalProductQty" ||
                    column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                }
            }
            InitColumnSummary("MMOperationDetailPlanItemChildPlanProductQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMOperationDetailPlanItemChildPlanBlock", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMOperationDetailPlanItemChildTotalBlock", DevExpress.Data.SummaryItemType.Sum);

            IsEdit = false;
            //gridView.CustomDrawCell += GridView_CustomDrawCell;
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "Machine" && obj != null)
                {
                    if (obj.MachineFocusedList != null && obj.MachineFocusedList.Count > 0)
                    {
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                }
                else if (e.Column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate")
                {
                    DateTime serverDate = BOSApp.MainScreen.ServerDate.AddSeconds(BOSApp.MainScreen.tickTimer);
                    if (obj.MMOperationDetailPlanItemChildExecutionToDate.Date <= serverDate.Date)
                    {
                        if ((obj.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString() || obj.MMOperationDetailPlanItemChildStatus == Status.New.ToString())
                            && (obj.MMOperationDetailPlanItemChildPlanProductQty > obj.MMOperationDetailPlanItemChildCompletedProductQty))
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;
                        }
                    }
                }
            }
        }

        public override void InitGridControlDataSource()
        {
            guiEditMachine form = (guiEditMachine)this.Screen;
            BindingSource bds = new BindingSource();
            bds.DataSource = form.MachineDetailPlanItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Máy móc";
            column.FieldName = "Machine";
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
            rep2.NullText = "Chi tiết";
            rep2.Click += new EventHandler(ViewMachine);
            column.ColumnEdit = rep2;
            gridView.Columns.Add(column);
        }
        private void ViewMachine(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((OperationDetailPlanModule)Screen.Module).ShowDataMachine(obj, true);
                }
            }
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

    }
}
