using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.HROverTime
{
    public partial class HREmployeeOTsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HROverTimeEntities entity = (HROverTimeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeOTList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();



            column = new GridColumn();
            column.Caption = OverTimeLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = OverTimeLocalizedResources.HREmployeeOTFactor;
            column.FieldName = "HREmployeeOTFactor";
            column.OptionsColumn.AllowEdit = true;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                RepositoryItemBOSLookupEdit item = (RepositoryItemBOSLookupEdit)column.ColumnEdit;
                item.DisplayMember = "HREmployeeNo";
            }


        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            RepositoryItemDateEdit repositoryItemDateEdit = new RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "rpHREmployeeOTFromDate";
            column = gridView.Columns["HREmployeeOTFromDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }


            repositoryItemDateEdit = new RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "rpHREmployeeOTToDate";
            column = gridView.Columns["HREmployeeOTToDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }
            column = gridView.Columns["HREmployeeOTChecked"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HROverTimeModule)Screen.Module).RemoveEmployeeFromOTList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();

            if (e.Column.FieldName == "FK_HREmployeeID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(value);
                        if (objEmployeesInfo != null)
                        {
                            e.DisplayText = objEmployeesInfo.HREmployeeNo;
                        }
                    }
                }
            }
            else if (e.Column.FieldName == "FK_HRDepartmentID")
            {
                HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
                HRDepartmentsInfo objDepartmentsInfo = new HRDepartmentsInfo();
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(value);
                        if (objDepartmentsInfo != null)
                        {
                            e.DisplayText = objDepartmentsInfo.HRDepartmentName;
                        }
                    }
                }
            }
            else if (e.Column.FieldName == "FK_HRDepartmentRoomID")
            {
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                HRDepartmentRoomsInfo objDepartmentRoomsInfo = new HRDepartmentRoomsInfo();

                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(value);
                        if (objDepartmentRoomsInfo != null)
                        {
                            e.DisplayText = objDepartmentRoomsInfo.HRDepartmentRoomName;
                        }
                    }
                }
            }
            else if (e.Column.FieldName == "FK_HRDepartmentRoomGroupItemID")
            {
                HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
                HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo = new HRDepartmentRoomGroupItemsInfo();

                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)objDepartmentRoomGroupItemsController.GetObjectByID(value);
                        if (objDepartmentRoomGroupItemsInfo != null)
                        {
                            e.DisplayText = objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemName;
                        }
                    }
                }
            }
        }
    }
}
