using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public class PMTasksGridControl : BOSGridControl
    {
        private DataTable EmployeeDataTable { get; set; }

        private DataTable DepartmentDataTable { get; set; }

        private DataTable DepartmentRoomDataTable { get; set; }

        public void InvalidateDataSource(List<PMTasksInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        public enum EmployeeColumnName
        {
            HREmployeeID,
            HREmployeeName,
        }

        public enum DepartmentColumnName
        {
            HRDepartmentID,
            HRDepartmentName,
        }

        public enum DepartmentRoomColumnName
        {
            HRDepartmentRoomID,
            HRDepartmentRoomName,

        }

        public enum PNTasksColumnName
        {
            FK_HREmployeeOwnerID,
            FK_HREmployeeID,
            FK_HRDepartmentID,
            FK_HRDepartmentRoomID,
            PMTaskTotalEstimatedDays,
            PMTaskTotalActualDays,
            PMTaskTotalEstimatedHours,
            PMTaskTotalActualHours,
            PMTaskEstimatedExtendDays,
            PMTaskActualExtendDays,
            PMTaskEstimatedExtendHours,
            PMTaskActualExtendHours,
            PMTaskQty,
            PMTaskEstimatedTotalCost,
            PMTaskActualTotalCost,
            PMTaskExtendTotalCost,
            PMTaskEstimatedStartDate,
            PMTaskEstimatedEndDate,
            PMTaskActualStartDate,
            PMTaskActualEndDate,
            PMTaskExtendStartDate,
            PMTaskExtendEndDate,
            PMTaskType,
            PMTaskStatus
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet dsEmployees = objEmployeesController.GetAllObjects();
            if (dsEmployees != null)
                EmployeeDataTable = dsEmployees.Tables[0];

            if (gridView.Columns[PNTasksColumnName.FK_HREmployeeID.ToString()] != null)
            {
                GridColumn column = gridView.Columns[PNTasksColumnName.FK_HREmployeeID.ToString()];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)EmployeeDataTable;
                repositoryItemLookUpEdit.ValueMember = EmployeeColumnName.HREmployeeID.ToString();
                repositoryItemLookUpEdit.DisplayMember = EmployeeColumnName.HREmployeeName.ToString();
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = EmployeeColumnName.HREmployeeName.ToString();
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemEmployeeOwnerLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            DataSet dsDepartments = objDepartmentsController.GetAllObjects();
            if (dsDepartments != null)
                DepartmentDataTable = dsDepartments.Tables[0];

            if (gridView.Columns[PNTasksColumnName.FK_HRDepartmentID.ToString()] != null)
            {
                GridColumn column = gridView.Columns[PNTasksColumnName.FK_HRDepartmentID.ToString()];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)DepartmentDataTable;
                repositoryItemLookUpEdit.ValueMember = DepartmentColumnName.HRDepartmentID.ToString();
                repositoryItemLookUpEdit.DisplayMember = DepartmentColumnName.HRDepartmentName.ToString();
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = DepartmentColumnName.HRDepartmentName.ToString();
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.EditValueChanged += new EventHandler(repositoryItemDepartmentLookupEditDepartmentID__EditValueChanged);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            DataSet dsDepartmentRooms = objDepartmentRoomsController.GetAllObjects();
            if (dsDepartmentRooms != null)
                DepartmentRoomDataTable = dsDepartmentRooms.Tables[0];

            if (gridView.Columns[PNTasksColumnName.FK_HRDepartmentRoomID.ToString()] != null)
            {
                GridColumn column = gridView.Columns[PNTasksColumnName.FK_HRDepartmentRoomID.ToString()];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)DepartmentRoomDataTable;
                repositoryItemLookUpEdit.ValueMember = DepartmentRoomColumnName.HRDepartmentRoomID.ToString();
                repositoryItemLookUpEdit.DisplayMember = DepartmentRoomColumnName.HRDepartmentRoomName.ToString();
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.Name = PNTasksColumnName.FK_HRDepartmentRoomID.ToString();
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = DepartmentRoomColumnName.HRDepartmentRoomName.ToString();
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemDepartmentRoomLookupEdit_QueryPopUp);
                repositoryItemLookUpEdit.EditValueChanged += new EventHandler(repositoryItemDepartmentRoomLookupEdit__EditValueChanged);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            new PNTasksColumnName[]
            {
                PNTasksColumnName.FK_HREmployeeOwnerID,
                PNTasksColumnName.FK_HREmployeeID,
                PNTasksColumnName.FK_HRDepartmentID,
                PNTasksColumnName.FK_HRDepartmentRoomID,
                PNTasksColumnName.PMTaskTotalEstimatedDays,
                PNTasksColumnName.PMTaskTotalActualDays,
                PNTasksColumnName.PMTaskTotalEstimatedHours,
                PNTasksColumnName.PMTaskTotalActualHours,
                PNTasksColumnName.PMTaskEstimatedExtendDays,
                PNTasksColumnName.PMTaskActualExtendDays,
                PNTasksColumnName.PMTaskEstimatedExtendHours,
                PNTasksColumnName.PMTaskActualExtendHours,
                PNTasksColumnName.PMTaskQty,
                PNTasksColumnName.PMTaskEstimatedTotalCost,
                PNTasksColumnName.PMTaskActualTotalCost,
                PNTasksColumnName.PMTaskExtendTotalCost,
                PNTasksColumnName.PMTaskEstimatedStartDate,
                PNTasksColumnName.PMTaskEstimatedEndDate,
                PNTasksColumnName.PMTaskActualStartDate,
                PNTasksColumnName.PMTaskActualEndDate,
                PNTasksColumnName.PMTaskExtendStartDate,
                PNTasksColumnName.PMTaskExtendEndDate,
                PNTasksColumnName.PMTaskType,
                PNTasksColumnName.PMTaskStatus
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            //if (e.KeyCode == Keys.Delete)
            //{
            //    ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
            //}
        }

        private void repositoryItemDepartmentRoomLookupEdit__EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            PMTasksInfo objTasksInfo = (PMTasksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (lke.OldEditValue != lke.EditValue)
            {
                objTasksInfo.FK_HREmployeeID = 0;
            }
            gridview.GridControl.RefreshDataSource();
        }

        private void repositoryItemDepartmentLookupEditDepartmentID__EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            PMTasksInfo objTasksInfo = (PMTasksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (lke.OldEditValue != lke.EditValue)
            {
                objTasksInfo.FK_HRDepartmentRoomID = 0;
            }
            gridview.GridControl.RefreshDataSource();
        }

        private void repositoryItemDepartmentRoomLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            PMTasksInfo objTasksInfo = (PMTasksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (objTasksInfo != null && objTasksInfo.FK_HRDepartmentID != 0)
            {
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> departmentRooms = objDepartmentRoomsController.GetRoomList(objTasksInfo.FK_HRDepartmentID);
                lookUpEdit.Properties.DataSource = departmentRooms;
            }
        }

        private void repositoryItemEmployeeOwnerLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            PMTasksInfo objTasksInfo = (PMTasksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (objTasksInfo != null && objTasksInfo.FK_HRDepartmentRoomID != 0)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                List<HREmployeesInfo> employees = objEmployeesController.GetEmployeeListByDepartmentRoomID(objTasksInfo.FK_HRDepartmentRoomID);
                lookUpEdit.Properties.DataSource = employees;
            }
        }
    }
}
