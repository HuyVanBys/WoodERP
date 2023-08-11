using BOSComponent;
using BOSERP.Modules.OperationDetailPlanCapacity.UI;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    public class MMOperationDetailPlanCapacityItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OperationDetailPlanCapacityItemsList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.OptionsView.ShowAutoFilterRow = true;

            //foreach (GridColumn column in gridView.Columns)
            //{

            //    if (column.FieldName == "MMOperationDetailPlanCapacityItemProductSerial")
            //    {
            //        column.Group();
            //        column.GroupIndex = 0;
            //    }
            //    if (column.FieldName == "MMOperationDetailPlanCapacityItemCompletedProductQty")
            //    {
            //        column.OptionsColumn.AllowEdit = true;
            //        column.Visible = true;
            //    }
            //    if (column.FieldName == "MMOperationDetailPlanCapacityItemPlanDesc")
            //    {
            //        column.OptionsColumn.AllowEdit = true;
            //        column.Visible = true;
            //    }
            //    if (column.FieldName == "MMOperationDetailPlanCapacityItemFailProductQty")
            //    {
            //        column.OptionsColumn.AllowEdit = true;
            //        column.Visible = true;
            //    }
            //    if (column.FieldName == "MMOperationDetailPlanCapacityItemProcessTime")
            //    {
            //        column.OptionsColumn.AllowEdit = true;
            //        column.Visible = true;
            //    }
            //    if (column.FieldName == "MMOperationDetailPlanCapacityItemDate")
            //    {
            //        column.OptionsColumn.AllowEdit = true;
            //        column.Visible = true;
            //    }
            //}

            GridColumn column = gridView.Columns["MMOperationDetailPlanCapacityItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["MMOperationDetailPlanCapacityItemPlanDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMOperationDetailPlanCapacityItemDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HREmployeeGiveID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HREmployeeTakeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HREmployeeQCID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["MMOperationDetailPlanCapacityItemIsBeginOperation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            return gridView;
        }


        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(e.RowHandle);
                            if (item.ItemStatus == "Invalid")
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;

            MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "FK_HREmployeeGiveID")
                {
                    int roomID = 0;
                    string empName = string.Empty;

                    HREmployeesController empCtrl = new HREmployeesController();
                    HREmployeesInfo emp = (HREmployeesInfo)empCtrl.GetObjectByID(item.FK_HREmployeeGiveID);
                    if (emp != null)
                    {
                        roomID = emp.FK_HRDepartmentRoomGroupItemID;
                        empName = emp.HREmployeeName;
                    }

                    if (roomID == 0)
                    {
                        BOSApp.ShowMessage(string.Format("Vui lòng xác định Tổ cho Người giao {0}", empName));
                        item.FK_HREmployeeGiveID = (int)gridView.ActiveEditor.OldEditValue;
                    }
                    else
                    {
                        item.FK_HRDepartmentRoomGroupItemID = roomID;
                    }
                }
                else if (e.Column.FieldName == "FK_HREmployeeTakeID")
                {
                    int roomID = 0;
                    string empName = string.Empty;

                    HREmployeesController empCtrl = new HREmployeesController();
                    HREmployeesInfo emp = (HREmployeesInfo)empCtrl.GetObjectByID(item.FK_HREmployeeTakeID);
                    if (emp != null)
                    {
                        roomID = emp.FK_HRDepartmentRoomGroupItemID;
                        empName = emp.HREmployeeName;
                    }

                    if (emp != null && roomID == 0)
                    {
                        BOSApp.ShowMessage(string.Format("Vui lòng xác định Tổ cho Người nhận {0}", empName));
                        item.FK_HREmployeeTakeID = (int)gridView.ActiveEditor.OldEditValue;
                    }
                    else
                    {
                        item.FK_HRToDepartmentRoomGroupItemID = roomID;
                    }
                }

            }


        }


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            //column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = OperationDetailPlanCapacityLocalizedResources.MMOperationDetailPlanNoMessage;
            //column.FieldName = "MMOperationDetailPlanNo";
            //column.OptionsColumn.AllowEdit = true;
            //column.Group();
            //column.GroupIndex = 1;
            //gridView.Columns.Add(column);

            //column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = "Lệnh sản xuất";
            //column.FieldName = "MMBatchProductNo";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Add(column);

            //column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = "Xưởng";
            //column.FieldName = "MMWorkShopName";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã carcass";
            column.FieldName = "ICProductCarcassNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên carcass";
            column.FieldName = "ICProductCarcassName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    int OperationPlanID = item.FK_MMOperationDetailPlanID;
                    int ProductForBatchID = item.FK_ICProductForBatchID;
                    string barcodeID = item.BarcodeID.ToString();
                    barcodeID = item.MMOperationDetailPlanItemChildBarcode.ToString().PadLeft(2, '0');

                    if (OperationPlanID > 0 && ProductForBatchID > 0)
                    {
                        //ReportModule reportModule = (ReportModule)BOSApp.ShowModule("Report");
                        //RP197 RP197 = new RP197(OperationPlanID, ProductForBatchID, barcodeID, item.FromDate
                        //    , item.ToDate, reportModule);
                        //RP197.Show();
                        //GridView grvRP197 = (GridView)RP197.fld_dgcSynchronousData.MainView;
                        //grvRP197.ExpandAllGroups();
                        //grvRP197.BestFitColumns();
                    }
                }
            }
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {

                if (gridView.FocusedRowHandle >= 0)
                {
                    MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        ((OperationDetailPlanCapacityModule)Screen.Module).DeleteItemFromOperationDetailPlanCapacityItemList(item);
                    }
                }
            }
            else if (e.KeyCode == Keys.PrintScreen)
            {
                DMODPC100 mainScreen = (DMODPC100)this.Screen;
                if (mainScreen != null)
                {
                    MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetFocusedRow();
                    if (item != null)
                    {
                        mainScreen.SetControlValueByItem(item);
                    }
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
