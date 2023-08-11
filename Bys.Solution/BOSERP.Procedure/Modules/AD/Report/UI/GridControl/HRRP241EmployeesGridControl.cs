using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using BOSCommon;

namespace BOSERP.Modules.Report
{
    public partial class HRRP241EmployeesGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsBehavior.Editable = true;
            gridView.OptionsCustomization.AllowSort = false;
            gridView.Appearance.HeaderPanel.Options.UseFont = true;
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            gridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gridView.OptionsView.ShowViewCaption = true;
            gridView.OptionsView.RowAutoHeight = true;
            gridView.ViewCaption = "";
            gridView.OptionsView.RowAutoHeight = true;

            GridColumn column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "HREmployeeDiaChiThuongTru";
            column.Caption = "Địa chỉ thường trú";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeDiaChiTamTru";
            column.Caption = "Địa chỉ tạm trú";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeApprenticeStartDate";
            column.Caption = "Ngày bắt đầu học việc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeApprenticeSalaryAmount";
            column.Caption = "Lương học việc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeProbationaryStartDate";
            column.Caption = "Ngày bắt đầu thử việc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeProbationarySalaryAmount";
            column.Caption = "Lương thử việc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        public void LoadBandedGridViewByTitle(string title, string type)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = new GridColumn();
            gridView.ViewCaption = title;

            if (type == EmployeeControllerType.Working.ToString())
            {
                column = gridView.Columns["FK_BRBranchID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 1;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 2;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeCardNumber"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 3;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 4;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeDob"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 5;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeGenderCombo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 6;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeIDNumber"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 7;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeIDCardDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeDiaChiThuongTru"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 9;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeDiaChiTamTru"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 10;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeTel1"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 11;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeEmail1"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 12;
                    column.MinWidth = 160;
                }

                column = gridView.Columns["HREmployeeBankAccount1"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 13;
                    column.MinWidth = 160;
                }

                column = gridView.Columns["HREmployeeBankName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 14;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeTaxNumber"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 15;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeStatusCombo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 16;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeWorkingForm"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 17;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeApprenticeStartDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 18;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeApprenticeSalaryAmount"];
                if (column != null)
                {
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n0}";
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 19;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeProbationaryStartDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 20;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeProbationarySalaryAmount"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n0}";
                    column.Visible = true;
                    column.VisibleIndex = 21;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeStartWorkingDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 22;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["FK_HRDepartmentID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 23;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["FK_HRDepartmentRoomID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 24;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["FK_HRLevelID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 25;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeStartFormalDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 26;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeContractSlrAmt"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 27;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeWorkingSlrAmt"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 28;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeSocialInsNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 29;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeSocialInsRegisteredDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 30;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HRPayRollCalculatedSalaryType"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 31;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeSocialInsPaymentPercent"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 32;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeHealthInsPaymentPercent"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 33;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeOutOfWorkInsPaymentPercent"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 34;
                    column.MinWidth = 100;
                }
            }
            else if(type == EmployeeControllerType.Resigned.ToString())
            {
                column = gridView.Columns["FK_BRBranchID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 1;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 2;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeCardNumber"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 3;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 4;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeDob"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 5;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeGenderCombo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 6;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeIDNumber"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 7;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeIDCardDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeDiaChiThuongTru"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 9;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeDiaChiTamTru"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 10;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeTel1"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 11;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeEmail1"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 12;
                    column.MinWidth = 160;
                }

                column = gridView.Columns["HREmployeeBankAccount1"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 13;
                    column.MinWidth = 160;
                }

                column = gridView.Columns["HREmployeeBankName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 14;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeTaxNumber"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 15;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeStatusCombo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 16;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeWorkingForm"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 17;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeApprenticeStartDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 18;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeApprenticeSalaryAmount"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 19;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeProbationaryStartDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 20;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeProbationarySalaryAmount"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 21;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["HREmployeeStartWorkingDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 22;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeStopWorkingDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 23;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["FK_HRDepartmentID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 24;
                    column.MinWidth = 160;
                }
                column = gridView.Columns["FK_HRDepartmentRoomID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 25;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["FK_HRLevelID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 26;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeStartFormalDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 27;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeContractSlrAmt"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 28;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeWorkingSlrAmt"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 29;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeSocialInsNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 30;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeSocialInsRegisteredDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 31;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HRPayRollCalculatedSalaryType"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 32;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeSocialInsPaymentPercent"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 33;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeHealthInsPaymentPercent"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 34;
                    column.MinWidth = 100;
                }
                column = gridView.Columns["HREmployeeOutOfWorkInsPaymentPercent"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 35;
                    column.MinWidth = 100;
                }
            }
        }
    }
}
