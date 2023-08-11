using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public class HRTimeKeeperHistoryDetailsGridControl : BOSGridControl
    {
        private const string HREmployeePayrollFormulaID = "Mã nhóm chấm công";
        private const string HREmployeeNo = "Mã nhân viên";
        private const string HREmployeeName = "Tên nhân viên";
        private const string HREmployeePayrollFormulaName = "Tên nhóm chấm công";
        private const string HRTimeKeeperHistoryAction = "Thao tác";
        private const string HRTimeKeeperHistoryDate = "Ngày sửa đổi";
        private const string ADUserName = "Người sửa đổi";
        private const string HRTimeKeeperHistoryDetailOldValue = "Giá trị cũ";
        private const string HRTimeKeeperHistoryDetailNewValue = "Giá trị mới";
        private const string HRTimeKeeperHistoryDetailEmployeeCardNumber = "Số thẻ";
        private const string HRTimeKeeperHistoryDetailColumnName = "Trường thay đổi";

        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        public override void InitGridControlDataSource()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTimeKeeperHistoryDetailList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = HRTimeKeeperHistoryDetailsGridControl.HREmployeePayrollFormulaID;
            column.FieldName = "HREmployeePayrollFormulaNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HRTimeKeeperHistoryDetailsGridControl.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HRTimeKeeperHistoryDetailsGridControl.HREmployeeName;
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HRTimeKeeperHistoryDetailsGridControl.HREmployeePayrollFormulaName;
            column.FieldName = "HREmployeePayrollFormulaName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HRTimeKeeperHistoryDetailsGridControl.HRTimeKeeperHistoryAction;
            column.FieldName = "HRTimeKeeperHistoryAction";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HRTimeKeeperHistoryDetailsGridControl.HRTimeKeeperHistoryDate;
            column.FieldName = "HRTimeKeeperHistoryDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HRTimeKeeperHistoryDetailsGridControl.ADUserName;
            column.FieldName = "AACreatedUser";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = HRTimeKeeperHistoryDetailsGridControl.HRTimeKeeperHistoryDetailOldValue;
            //column.FieldName = "HRTimeKeeperHistoryDetailOldValue";
            //column.OptionsColumn.AllowEdit = false;

            //column = new GridColumn();
            //column.Caption = HRTimeKeeperHistoryDetailsGridControl.HRTimeKeeperHistoryDetailNewValue;
            //column.FieldName = "HRTimeKeeperHistoryDetailNewValue";
            //column.OptionsColumn.AllowEdit = false;

            //column = new GridColumn();
            //column.Caption = HRTimeKeeperHistoryDetailsGridControl.HRTimeKeeperHistoryDetailEmployeeCardNumber;
            //column.FieldName = "HRTimeKeeperHistoryDetailEmployeeCardNumber";
            //column.OptionsColumn.AllowEdit = false;

            //column = new GridColumn();
            //column.Caption = HRTimeKeeperHistoryDetailsGridControl.HRTimeKeeperHistoryDetailColumnName;
            //column.FieldName = "HRTimeKeeperHistoryDetailColumnName";
            //column.OptionsColumn.AllowEdit = false;

            //gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.EditFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            HRTimeKeeperHistoryDetailsController objTimeKeeperHistoryDetailsController = new HRTimeKeeperHistoryDetailsController();
            if (e.Column.FieldName == "HRTimeKeeperHistoryDate")
            {
                if (e.RowHandle >= 0)
                {
                    HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo = (HRTimeKeeperHistoryDetailsInfo)gridView.GetRow(e.RowHandle);
                    if (objTimeKeeperHistoryDetailsInfo != null)
                    {
                        bool isThanTwoDays = ((ManagerTimeKeeperModule)Screen.Module).CheckChangedTime(objTimeKeeperHistoryDetailsInfo);
                        if (isThanTwoDays)
                        {
                            e.Appearance.BackColor2 = Color.Red;
                            e.Appearance.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "HRTimeKeeperHistoryAction")
            {
                if (e.Value != null)
                {
                    string strTimeKeeperHistoryAction = e.Value.ToString();
                    e.DisplayText = strTimeKeeperHistoryAction;
                    if (strTimeKeeperHistoryAction.Equals("Change"))
                    {
                        e.DisplayText = "Thay đổi";
                    }
                    else if (strTimeKeeperHistoryAction == "New")
                    {
                        e.DisplayText = "Nhập công nhanh";
                    }
                }
            }
            if (e.Column.FieldName == "HRTimeKeeperHistoryDetailOldValue")
            {
                if (e.Value != null)
                {
                    HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo = (HRTimeKeeperHistoryDetailsInfo)gridView.GetRow(e.ListSourceRowIndex);
                    if (objTimeKeeperHistoryDetailsInfo != null)
                    {
                        string strStringFormat = ((ManagerTimeKeeperModule)Screen.Module).CheckChangedColumn(objTimeKeeperHistoryDetailsInfo);
                        if (strStringFormat == "h:mm:ss tt")
                        {
                            String strdate = Convert.ToDateTime(objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailOldValue).ToString("h:mm:ss tt");
                            e.DisplayText = strdate;
                        }
                        else if (strStringFormat == "dd/MM/yyyy")
                        {
                            String strdate = Convert.ToDateTime(objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailOldValue).ToString("dd/MM/yyyy");
                            e.DisplayText = strdate;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "HRTimeKeeperHistoryDetailNewValue")
            {
                if (e.Value != null)
                {
                    HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo = (HRTimeKeeperHistoryDetailsInfo)gridView.GetRow(e.ListSourceRowIndex);
                    if (objTimeKeeperHistoryDetailsInfo != null)
                    {
                        string strStringFormat = ((ManagerTimeKeeperModule)Screen.Module).CheckChangedColumn(objTimeKeeperHistoryDetailsInfo);
                        if (strStringFormat == "h:mm:ss tt")
                        {
                            String strdate = Convert.ToDateTime(objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailNewValue).ToString("h:mm:ss tt");
                            e.DisplayText = strdate;
                        }
                        else if (strStringFormat == "dd/MM/yyyy")
                        {
                            String strdate = Convert.ToDateTime(objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailNewValue).ToString("dd/MM/yyyy");
                            e.DisplayText = strdate;
                        }
                    }
                }
            }
        }
    }
}
