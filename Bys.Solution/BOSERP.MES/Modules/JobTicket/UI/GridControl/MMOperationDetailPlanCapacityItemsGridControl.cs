using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.JobTicket
{
    public class MMOperationDetailPlanCapacityItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            //bds.DataSource = entity.OperationDetailPlanCapacityItemsList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.OptionsView.ShowAutoFilterRow = true;
            foreach (GridColumn col in gridView.Columns)
            {
                if (col.FieldName == "MMJobTicketItemGroup")
                    col.Group();
                col.OptionsColumn.AllowEdit = false;
                col.Visible = true;
                if (col.VisibleIndex == -1)
                    col.VisibleIndex = 0;
                if (col.FieldName == "MMOperationDetailPlanCapacityItemProductQty"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemFailProductQty"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemProcessTime"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemPlanDesc"
                    || col.FieldName == "FK_HREmployeeGiveID"
                    || col.FieldName == "FK_HREmployeeTakeID"
                    || col.FieldName == "FK_HREmployeeQCID"
                    || col.FieldName == "FK_HRToDepartmentRoomGroupItemID"
                    || col.FieldName == "Selected"
                    )
                    col.OptionsColumn.AllowEdit = true;
            }
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.KeyDown += new KeyEventHandler(gridView_KeyDown);
            gridView.KeyUp += new KeyEventHandler(gridView_KeyUp);
            return gridView;
        }

        void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
                {
                    MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null && item.MMOperationDetailPlanCapacityItemProductQty == 0)
                        item.MMOperationDetailPlanCapacityItemProductQty = item.MMOperationDetailPlanCapacityItemRemainProductQty;

                }
            }
        }

        void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
                {
                    MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null && item.MMOperationDetailPlanCapacityItemProductQty == 0)
                        item.MMOperationDetailPlanCapacityItemProductQty = item.MMOperationDetailPlanCapacityItemRemainProductQty;

                }
            }
        }


        public void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
                {
                    if (item != null)
                    {
                        if (item.MMOperationDetailPlanCapacityItemProductQty > (item.MMOperationDetailPlanCapacityItemPlanProductQty - item.MMOperationDetailPlanCapacityItemCompletedProductQty))
                        {
                            BOSApp.ShowMessage("Số lượng cần làm không thể lớn hơn SL kế hoạch còn lại!");
                            item.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        if (item.MMOperationDetailPlanCapacityItemProductQty < 0)
                        {
                            BOSApp.ShowMessage("Số lượng cần làm không thể nhỏ hơn 0!");
                            item.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }

                    }
                }
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemProductQty" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemFailProductQty" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemProcessTime")
                {
                    if (e.RowHandle >= 0)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                        e.Appearance.BackColor = Color.Orange;
                        e.Appearance.BackColor2 = Color.Orange;
                        MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(e.RowHandle);
                        if (obj.IsError)
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;
                        }
                    }

                }

                if (e.Column.FieldName == "FK_MMOperationID")
                {
                    if (e.RowHandle >= 0)
                    {

                        MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(e.RowHandle);
                        if (obj.MMOperationID == obj.FK_MMOperationID)
                        {
                            e.Appearance.BackColor = Color.Coral;
                            e.Appearance.BackColor2 = Color.Coral;
                        }
                    }

                }

                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemPlanProductQty"
                    || e.Column.FieldName == "MMOperationDetailPlanCapacityItemCompletedProductQty"
                    || e.Column.FieldName == "MMOperationDetailPlanCapacityItemFailProductQty"
                    || e.Column.FieldName == "MMOperationDetailPlanCapacityItemProcessTime")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Lịch sử";
            column.FieldName = "History";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
            rep2.NullText = "Xem";
            rep2.Click += new EventHandler(rep2_Click);
            column.ColumnEdit = rep2;
            gridView.Columns.Add(column);
        }

        void rep2_Click(object sender, EventArgs e)
        {
            BOSApp.ShowMessage("Coming soon");
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
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
