using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class MMTicketPlanItemsGridControl : BOSGridControl
    {
        public bool IsEdit { get; set; }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                //if (column.FieldName == "MMOperationDetailPlanItemChildBlockPerOne" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildTotalBlock" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildPlanBlock")
                //{
                //    column.DisplayFormat.FormatType = FormatType.Numeric;
                //    column.DisplayFormat.FormatString = "{0:n4}";
                //}
                //else if (column.FieldName == "MMOperationDetailPlanItemChildProductLength" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildProductWidth" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildProductHeight" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildProductQty" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildTotalProductQty" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
                //{
                //    column.DisplayFormat.FormatType = FormatType.Numeric;
                //    column.DisplayFormat.FormatString = "{0:n2}";
                //}
                //else 
                if (column.FieldName == "Employee")
                {
                    column.VisibleIndex = 2;
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Chi tiết";
                    rep1.Click += new EventHandler(ViewEmployee_Click);
                    column.ColumnEdit = rep1;
                }
                else if (column.FieldName == "Machine")
                {
                    RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
                    rep2.NullText = "Chi tiết";
                    rep2.Click += new EventHandler(ViewMachine_Click);
                    column.ColumnEdit = rep2;
                }
                else if (column.FieldName == "Open")
                {
                    RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
                    rep2.NullText = "Mở thẻ";
                    rep2.Click += new EventHandler(OpenTicket_Click);
                    column.ColumnEdit = rep2;
                }
                else if (column.FieldName == "MMOperationDetailPlanItemChildCompletedProductQty")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit linkEdit = new RepositoryItemHyperLinkEdit();
                    linkEdit.NullText = "0";
                    linkEdit.Click += new EventHandler(ViewHistory_Click);
                    column.ColumnEdit = linkEdit;
                }
            }
            IsEdit = false;
            gridView.CellValueChanging += new CellValueChangedEventHandler(GridView_CellValueChanging);
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        private void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)sender;
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
                if (obj != null)
                {
                    OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    int index = entity.TicketDetailPlanItemsList.IndexOf(obj);
                    if (obj != null && index >= 0)
                    {
                        obj.AllowPropertyChangedEvent = false;
                        MMOperationDetailPlanItemChildsInfo objdata = (MMOperationDetailPlanItemChildsInfo)entity.ModuleObjects["MMOperationDetailPlanItemChilds"];
                        if (objdata != null) objdata.AllowPropertyChangedEvent = false;
                    }
                }
            }
        }

        void ViewHistory_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)entity.MainObject;
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null && obj.MMOperationDetailPlanItemChildCompletedProductQty > 0)
                {
                    guiViewEditCapacity gui = new guiViewEditCapacity();
                    gui.NormID = obj.FK_MMBatchProductProductionNormItemID;
                    gui.OperationID = obj.FK_MMOperationID;
                    gui.Fromdate = obj.MMOperationDetailPlanItemChildExecutionFromDate;
                    gui.Todate = obj.MMOperationDetailPlanItemChildExecutionToDate;
                    gui.BatchID = obj.FK_MMBatchProductID;
                    gui.ProductOfBatchID = obj.FK_ICProductForBatchID;
                    gui.SemiProductNo = obj.MMOperationDetailPlanItemChildProductNo;
                    gui.SemiProductName = obj.MMOperationDetailPlanItemChildProductName;
                    gui.Module = this.Screen.Module;
                    gui.ShowDialog();
                }
            }
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
                else if (e.Column.FieldName == "Machine" && obj != null)
                {
                    if (obj.MachineFocusedList != null && obj.MachineFocusedList.Count > 0)
                    {
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                }
                else if (e.Column.FieldName == "Open" && obj != null)
                {
                    if (obj.MMOperationDetailPlanItemChildStatus == Status.Closed.ToString())
                    {
                        e.Appearance.BackColor = Color.Blue;
                        e.Appearance.BackColor2 = Color.Blue;
                    }
                }
                else if (e.Column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate" && obj != null)
                {
                    DateTime serverDate = BOSApp.MainScreen.ServerDate.AddSeconds(BOSApp.MainScreen.tickTimer);
                    if (obj.MMOperationDetailPlanItemChildExecutionToDate.Date <= serverDate.Date)
                    {
                        if ((obj.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString())
                            && (obj.MMOperationDetailPlanItemChildPlanProductQty > obj.MMOperationDetailPlanItemChildCompletedProductQty))
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;
                        }
                    }
                }
                else if (e.Column.FieldName == "MMOperationDetailPlanItemChildProductName" && obj != null && obj.IsError == true)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
                }
                if (e.Column.FieldName == "MMOperationDetailPlanItemChildCompletedProductQty")
                {
                    if (e.RowHandle >= 0 && obj != null)
                    {
                        if (obj.MMOperationDetailPlanItemChildCompletedProductQty > 0)
                        {
                            e.Appearance.BackColor = Color.LightGoldenrodYellow;
                            e.Appearance.BackColor2 = Color.LightGoldenrodYellow;
                            e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Underline);
                        }
                    }
                }
            }
        }

        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TicketDetailPlanItemsList;
            this.DataSource = bds;
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
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Machine";
            column.Caption = "Máy móc";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Open";
            column.Caption = "Mở thẻ";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);
        }
        void OpenTicket_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null && obj.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Closed.ToString())
                {
                    OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    ((OperationDetailPlanModule)Screen.Module).OpenJobTicket(obj, entity.TicketDetailPlanItemsList);
                }
                else
                {
                    string mess = "Chi tiết đã chọn có trạng thái không phù hợp";
                    BOSApp.ShowMessage(mess);
                }
            }
        }
        void ViewEmployee_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((OperationDetailPlanModule)Screen.Module).ShowTicketEditHuman(false, obj);
                }

            }
        }
        void ViewMachine_Click(object sender, EventArgs e)
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

    }
}
