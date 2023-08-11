using BOSCommon;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class MMHumanPlanItemsGridControl : BOSGridControl
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
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.CustomDrawCell += GridView_CustomDrawCell;
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "Employee" && obj != null)
                {
                    if (obj.HumanFocusedList != null && obj.HumanFocusedList.Count > 0)
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
        protected override void GridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);
            GridView gridView = sender as GridView;
            if (e.Column.FieldName == "Selected" && e.RowHandle >= 0 && !IsEdit)
            {
                try
                {
                    MMOperationDetailPlanItemChildsInfo item = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
                    CheckEditViewInfo info = (e.Cell as GridCellInfo).ViewInfo as CheckEditViewInfo;

                    int stase = ((OperationDetailPlanModule)this.Screen.Module).CheckTicketMergeMultiHuman(item);
                    if (stase == 0)
                        info.EditValue = false;
                    else if (stase == 1)
                        info.EditValue = true;
                    else
                        info.EditValue = null;
                }
                catch (Exception ex)
                {
                }
            }



        }
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HumanDetailPlanItemsList;
            this.DataSource = bds;
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMOperationDetailPlanItemChildsInfo row = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
            if (row != null && e.Column.FieldName == "Selected" && e.RowHandle >= 0)
            {
                IsEdit = true;
                ((OperationDetailPlanModule)this.Screen.Module).EnableCancelHumanButton(true);
                ((OperationDetailPlanModule)this.Screen.Module).SetHumanTotalQty();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "Selected";
            column.Caption = "Chọn";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Nhân công";
            column.FieldName = "Employee";
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
            rep2.NullText = "Chi tiết";
            rep2.Click += new EventHandler(ViewEmployee_Click);
            column.ColumnEdit = rep2;
            gridView.Columns.Add(column);
        }
        void ViewEmployee_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null && obj.MMOperationDetailPlanItemChildStatus == Status.New.ToString())
                {
                    ((OperationDetailPlanModule)Screen.Module).ShowDataEmployee(obj, false);
                    gridView.RefreshData();
                }
                else if (obj != null && obj.MMOperationDetailPlanItemChildStatus != Status.New.ToString())
                {
                    ((OperationDetailPlanModule)Screen.Module).ShowDataEmployee(obj, true);
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
