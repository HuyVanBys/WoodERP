using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace BOSERP.Modules.ATMCardPayroll
{
    public partial class HREmployeesGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = CommonLocalizedResources.Selected;
            column.FieldName = "Selected";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tăng ca từ ngày";
            column.FieldName = "HREmployeeOTDate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tăng ca từ giờ";
            column.OptionsColumn.AllowEdit = true;
            column.FieldName = "HREmployeeOTFromDate";

            RepositoryItemDateEdit repositoryItemDateEdit = new RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "rpHREmployeeOTFromDate";
            column.ColumnEdit = repositoryItemDateEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tăng ca đến ngày";
            column.OptionsColumn.AllowEdit = true;
            column.FieldName = "HREmployeeOTDateEnd";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tăng ca đến giờ";
            column.OptionsColumn.AllowEdit = true;

            repositoryItemDateEdit = new RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "rpHREmployeeOTToDate";
            column.ColumnEdit = repositoryItemDateEdit;
            column.FieldName = "HREmployeeOTToDate";
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                column.Caption = CommonLocalizedResources.HREmployeeName;
            }
            column = gridView.Columns["FK_HRDepartmentRoomGroupItemID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "HRDepartmentRoomGroupItemName";
                repositoryItemLookUpEdit.ValueMember = "HRDepartmentRoomGroupItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomGroupItemDesc", "Mô tả"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            List<string> colList = new List<string>() { "FK_HRDepartmentRoomID",
                                                        "FK_HRLevelID",
                                                        "Selected",
                                                        "HREmployeeOTDate",
                                                        "HREmployeeOTFromDate",
                                                        "HREmployeeOTToDate",
                                                        "FK_BRBranchID",
                                                        "FK_GENationalityID",
                                                        "HREmployeeTel1",
                                                        "HREmployeeIsUnionMember",
                                                        "HREmployeeUniform",
                                                        "HREmployeeTel2",
                                                        "HREmployeeDesc",
                                                        "HREmployeeGenderCombo",
                                                        "HREmployeeTypeCombo",
                                                        "HREmployeeTaxNumber",
                                                        "HREmployeeCardNumber",
                                                        "HREmployeeNo",
                                                        "HREmployeeDobString",
                                                        "FK_HRDepartmentRoomGroupTeamItemID",
                                                        "FK_HREmployeePayrollFormulaID",
                                                        "FK_HRDepartmentID",
                                                        "HREmployeeName",
                                                        "HREmployeeTrainingCourseValue",
                                                        "HREmployeeStatusCombo",
                                                        "FK_HRDepartmentRoomGroupItemID",
                                                        "FK_MMWorkShopID",
                                                        "FK_GEReligionID",
                                                        "HREmployeeEducation"};

            for (int i = gridView.Columns.Count - 1; i >= 0; i--)
            {
                if (!colList.Contains(gridView.Columns[i].FieldName))
                {
                    gridView.Columns.RemoveAt(i);
                }
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HRDepartmentRoomGroupItemID")
            {
                if (e.Value != null)
                {
                    int assetID = int.Parse(e.Value.ToString());
                    HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
                    HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo = new HRDepartmentRoomGroupItemsInfo();
                    objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)objDepartmentRoomGroupItemsController.GetObjectByID(assetID);
                    if (objDepartmentRoomGroupItemsInfo != null)
                    {
                        e.DisplayText = objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemName;
                    }
                }
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataTable dt = GetDepartmentRoomGroupItemTable();
            lookUpEdit.Properties.DataSource = dt;
            dt.Dispose();
        }
        private DataTable GetDepartmentRoomGroupItemTable()
        {
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            DataSet ds = objDepartmentRoomGroupItemsController.GetAllObjects();
            return ds.Tables[0];
        }
    }
}
