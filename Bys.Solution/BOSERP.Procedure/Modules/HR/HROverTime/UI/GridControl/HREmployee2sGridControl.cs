using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;

namespace BOSERP.Modules.HROverTime.UI
{
    public partial class HREmployee2sGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = CommonLocalizedResources.Selected;
            column.FieldName = "Selected";
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
            List<string> colList = new List<string>() { "FK_HRDepartmentRoomID",
                                                        "FK_HRLevelID",
                                                        "Selected",
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
            return gridView;
        }
    }
}
