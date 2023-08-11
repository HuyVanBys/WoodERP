
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
    public class MMOperationDetailPlanItemChildsGridControl : BOSGridControl
    {
        //private GridControlHelper GridHelper;
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "FK_MMBatchProductID")
                {
                    //column.Group();
                }
                if (column.FieldName == "Selected" ||
                    column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty" ||
                    column.FieldName == "FK_MMWorkShopID" ||
                    column.FieldName == "FK_MMLineID" ||
                    column.FieldName == "FK_HRDepartmentRoomGroupItemID" ||
                    column.FieldName == "MMOperationDetailPlanItemChildExecutionFromDate" ||
                    column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.OptionsColumn.AllowEdit = false;
                //if (column.FieldName == "MMOperationDetailPlanItemChildBlockPerOne" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildTotalBlock" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildPlanBlock" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildProductQty" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildTotalProductQty" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
                //{
                //    column.DisplayFormat.FormatType = FormatType.Numeric;
                //    column.DisplayFormat.FormatString = "{0:n4}";
                //}
                //else if (column.FieldName == "MMOperationDetailPlanItemChildProductLength" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildProductWidth" ||
                //    column.FieldName == "MMOperationDetailPlanItemChildProductHeight" )
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
                    rep1.Click += new EventHandler(ViewEmployeek);
                    column.ColumnEdit = rep1;
                }
                else if (column.FieldName == "Machine")
                {
                    RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
                    rep2.NullText = "Chi tiết";
                    column.OptionsColumn.AllowEdit = true;
                    rep2.Click += new EventHandler(ViewMachine);
                    column.ColumnEdit = rep2;
                }
                if (column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
                {
                    column.AppearanceCell.BackColor = Color.PaleTurquoise;
                    column.AppearanceCell.BackColor2 = Color.PaleTurquoise;
                }
            }
            InitColumnSummary("MMOperationDetailPlanItemChildPlanProductQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMOperationDetailPlanItemChildPlanBlock", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMOperationDetailPlanItemChildTotalBlock", DevExpress.Data.SummaryItemType.Sum);
            gridView.CellValueChanging += new CellValueChangedEventHandler(GridView_CellValueChanging);
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.RowCellStyle += gridView_RowCellStyle;
            //GridHelper = new GridControlHelper(gridView);
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
                    if (e.Column.FieldName == "Selected")
                    {
                        int index = entity.OperationDetailPlanItemChildsList.IndexOf(obj);
                        if (obj != null && index >= 0)
                        {
                            obj.AllowPropertyChangedEvent = false;
                            MMOperationDetailPlanItemChildsInfo objdata = (MMOperationDetailPlanItemChildsInfo)entity.ModuleObjects["MMOperationDetailPlanItemChilds"];
                            if (objdata != null) objdata.AllowPropertyChangedEvent = false;
                        }
                    }
                    else if (e.Column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
                    {
                        ((OperationDetailPlanModule)this.Screen.Module).UpdatePlanMachineCapacity(obj);
                    }
                }
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "MMOperationDetailPlanItemChildStatus")
                {
                    if (obj != null)
                    {
                        if (obj.MMOperationDetailPlanItemChildStatus == Status.New.ToString())
                        {
                            e.Appearance.BackColor = Color.White;
                            e.Appearance.BackColor2 = Color.White;
                        }
                        else if (obj.MMOperationDetailPlanItemChildStatus == Status.Canceled.ToString())
                        {
                            e.Appearance.BackColor = Color.Gainsboro;
                            e.Appearance.BackColor2 = Color.Gainsboro;
                        }
                        else if (obj.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString())
                        {
                            e.Appearance.BackColor = Color.PaleTurquoise;
                            e.Appearance.BackColor2 = Color.PaleTurquoise;
                        }
                        else if (obj.MMOperationDetailPlanItemChildStatus == Status.Closed.ToString())
                        {
                            e.Appearance.BackColor = Color.Blue;
                            e.Appearance.BackColor2 = Color.Blue;
                        }
                    }
                }
                else if (e.Column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate")
                {
                    DateTime serverDate = BOSApp.MainScreen.ServerDate.AddSeconds(BOSApp.MainScreen.tickTimer);

                    if (obj != null && obj.MMOperationDetailPlanItemChildExecutionToDate.Date <= serverDate.Date)
                    {
                        if ((obj.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString() || obj.MMOperationDetailPlanItemChildStatus == Status.New.ToString())
                            && (obj.MMOperationDetailPlanItemChildPlanProductQty > obj.MMOperationDetailPlanItemChildCompletedProductQty))
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_MMWorkShopID")
                {
                    if (obj != null && obj.FK_MMWorkShopID == 0 && obj.IsError)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }
                }
                else if (e.Column.FieldName == "Employee" && obj != null)
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
            }
        }
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OperationDetailPlanItemChildsList;
            this.DataSource = bds;
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            decimal valueQty = 0;
            if (e.Value != null)
                decimal.TryParse(e.Value.ToString(), out valueQty);
            MMOperationDetailPlanItemChildsInfo row = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
            if (row != null && e.Column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
            {
                row.IsError = false;
                if (row.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Canceled.ToString() ||
                    row.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Closed.ToString())
                {
                    BOSApp.ShowMessage("Chi tiết đã đóng/ hủy không thể thay đổi SL!");
                    row.MMOperationDetailPlanItemChildPlanProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                }
                else if (!((OperationDetailPlanModule)this.Screen.Module).CellValueChanged(e.Column.FieldName, valueQty, row))
                {
                    row.MMOperationDetailPlanItemChildPlanProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                }
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
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Machine";
            column.Caption = "SL Máy móc";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;

            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MachineDetail";
            column.Caption = "Chi tiết máy móc";
            column.Visible = true;
            gridView.Columns.Add(column);


        }

        private void ViewEmployeek(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((OperationDetailPlanModule)Screen.Module).ShowDataEmployee(obj, true);
                }
            }
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
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete && gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanItemChildsInfo item = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                    ((OperationDetailPlanModule)Screen.Module).DeleteItemchildList(item);
                gridView.DeleteRow(gridView.FocusedRowHandle);
            }
        }

    }
}
