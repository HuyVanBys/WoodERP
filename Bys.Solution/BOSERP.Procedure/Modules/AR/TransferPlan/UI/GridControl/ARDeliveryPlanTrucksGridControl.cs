using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    public class ARDeliveryPlanTrucksGridControl : BOSGridControl
    {
        private DataTable EmployeeDataTable { get; set; }

        private DataTable DepartmentDataTable { get; set; }

        private DataTable DepartmentRoomDataTable { get; set; }

        public override void InitGridControlDataSource()
        {
            TransferPlanEntities entity = (TransferPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARDeliveryPlanTrucksList;
            this.DataSource = bds;
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

        public enum ARDeliveryPlanTrucksColumnName
        {
            ARDeliveryPlanTruckNumber,
            ARDeliveryPlanTruckDriver,
            ARDeliveryPlanTruckGrossTon,
            ARDeliveryPlanTruckCapacity,
            ARDeliveryPlanTruckDeliveryPlanItem,
            FK_HREmployeeID,
            ARDeliveryPlanTruckSource,
            ARDeliveryPlanTruckItem,
            ARDeliveryPlanTruckDeliveryEmployee,
            FK_HRDepartmentID,
            FK_HRDepartmentRoomID,
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            new ARDeliveryPlanTrucksColumnName[]
            {
                ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckNumber,
                ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckDriver,
                ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckGrossTon,
                ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckCapacity,
                ARDeliveryPlanTrucksColumnName.FK_HREmployeeID,
                ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckSource,
                ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckDeliveryEmployee,
                ARDeliveryPlanTrucksColumnName.FK_HRDepartmentID,
                ARDeliveryPlanTrucksColumnName.FK_HRDepartmentRoomID,
            }
           .Select(o => gridView.Columns[o.ToString()])
           .Where(o => o != null)
           .ToList()
           .ForEach(o => o.OptionsColumn.AllowEdit = true);

            column = new GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.TruckItemList;
            column.FieldName = ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckItem.ToString();
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "DS sản phẩm";
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;

            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet dsEmployees = objEmployeesController.GetAllObjects();
            if (dsEmployees != null)
                EmployeeDataTable = dsEmployees.Tables[0];

            GridColumn column = gridView.Columns[ARDeliveryPlanTrucksColumnName.ARDeliveryPlanTruckDeliveryEmployee.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckedComboBoxEdit rpDeliveryPlanTruckDeliveryEmployee = new RepositoryItemCheckedComboBoxEdit();
                rpDeliveryPlanTruckDeliveryEmployee.DisplayMember = EmployeeColumnName.HREmployeeName.ToString();
                rpDeliveryPlanTruckDeliveryEmployee.ValueMember = EmployeeColumnName.HREmployeeID.ToString();
                rpDeliveryPlanTruckDeliveryEmployee.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rpDeliveryPlanTruckDeliveryEmployee.NullText = string.Empty;
                rpDeliveryPlanTruckDeliveryEmployee.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpDeliveryPlanTruckDeliveryEmployee_QueryPopUp);
                rpDeliveryPlanTruckDeliveryEmployee.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(rpDeliveryPlanTruckDeliveryEmployee_CloseUp);
                rpDeliveryPlanTruckDeliveryEmployee.DataSource = (object)EmployeeDataTable;
                column.ColumnEdit = rpDeliveryPlanTruckDeliveryEmployee;
            }

            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            DataSet dsDepartments = objDepartmentsController.GetAllObjects();
            if (dsDepartments != null)
                DepartmentDataTable = dsDepartments.Tables[0];

            if (gridView.Columns[ARDeliveryPlanTrucksColumnName.FK_HRDepartmentID.ToString()] != null)
            {
                column = gridView.Columns[ARDeliveryPlanTrucksColumnName.FK_HRDepartmentID.ToString()];
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

            if (gridView.Columns[ARDeliveryPlanTrucksColumnName.FK_HRDepartmentRoomID.ToString()] != null)
            {
                column = gridView.Columns[ARDeliveryPlanTrucksColumnName.FK_HRDepartmentRoomID.ToString()];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)DepartmentRoomDataTable;
                repositoryItemLookUpEdit.ValueMember = DepartmentRoomColumnName.HRDepartmentRoomID.ToString();
                repositoryItemLookUpEdit.DisplayMember = DepartmentRoomColumnName.HRDepartmentRoomName.ToString();
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.Name = ARDeliveryPlanTrucksColumnName.FK_HRDepartmentRoomID.ToString();
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = DepartmentRoomColumnName.HRDepartmentRoomName.ToString();
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemDepartmentRoomLookupEdit_QueryPopUp);
                repositoryItemLookUpEdit.EditValueChanged += new EventHandler(repositoryItemDepartmentRoomLookupEdit__EditValueChanged);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

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
            if (e.Column.FieldName == ARDeliveryPlanTrucksColumnName.FK_HREmployeeID.ToString())
                ((TransferPlanModule)Screen.Module).ChangeTruckDriver();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((TransferPlanModule)Screen.Module).DeleteTruckFromDeliveryPlanTrucksList();
            }
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((TransferPlanModule)Screen.Module).ShowTruckItem();
        }

        private void rpDeliveryPlanTruckDeliveryEmployee_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objDeliveryPlanTrucksInfo != null)
            {
                CheckedComboBoxEdit checkedComboBoxEdit = (CheckedComboBoxEdit)sender;
                if (objDeliveryPlanTrucksInfo.FK_HRDepartmentRoomID != 0)
                {
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    List<HREmployeesInfo> employees = objEmployeesController.GetEmployeeListByDepartmentRoomID(objDeliveryPlanTrucksInfo.FK_HRDepartmentRoomID);
                    checkedComboBoxEdit.Properties.DataSource = employees;
                }
                else
                    checkedComboBoxEdit.Properties.DataSource = (object)EmployeeDataTable;

                checkedComboBoxEdit.Properties.DisplayMember = EmployeeColumnName.HREmployeeName.ToString();
                checkedComboBoxEdit.Properties.ValueMember = EmployeeColumnName.HREmployeeID.ToString();
            }
        }

        private void rpDeliveryPlanTruckDeliveryEmployee_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                CheckedComboBoxEdit checkedComboBoxEdit = (CheckedComboBoxEdit)sender;
                if (checkedComboBoxEdit.EditValue != e.Value)
                {
                    ((TransferPlanModule)Screen.Module).ChangeDeliveryPlanTruckDeliveryEmployee(e.Value.ToString());
                }
            }
        }

        private void repositoryItemDepartmentLookupEditDepartmentID__EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (lke.OldEditValue != lke.EditValue)
            {
                objDeliveryPlanTrucksInfo.FK_HRDepartmentRoomID = 0;
            }
            gridview.GridControl.RefreshDataSource();
        }

        private void repositoryItemDepartmentRoomLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (objDeliveryPlanTrucksInfo != null && objDeliveryPlanTrucksInfo.FK_HRDepartmentID != 0)
            {
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> departmentRooms = objDepartmentRoomsController.GetRoomList(objDeliveryPlanTrucksInfo.FK_HRDepartmentID);
                lookUpEdit.Properties.DataSource = departmentRooms;
            }
        }

        private void repositoryItemDepartmentRoomLookupEdit__EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (lke.OldEditValue != lke.EditValue)
            {
                objDeliveryPlanTrucksInfo.FK_HREmployeeID = 0;
            }
            gridview.GridControl.RefreshDataSource();
        }
    }
}
