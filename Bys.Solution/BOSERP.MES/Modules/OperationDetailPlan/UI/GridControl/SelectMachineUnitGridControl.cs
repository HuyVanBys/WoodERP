using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class SelectMachineUnitGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            guiChooseBPPINormOperation form = (guiChooseBPPINormOperation)this.Screen;
            BindingSource bds = new BindingSource();
            bds.DataSource = form.SelectMachineUnitList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["FK_ADWorkingShiftID"];
            if (column != null)
            {
                RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
                rep.DisplayMember = "ADWorkingShiftName";
                rep.ValueMember = "ADWorkingShiftID";
                rep.ShowHeader = false;
                rep.TextEditStyle = TextEditStyles.Standard;
                rep.NullText = string.Empty;
                LookUpColumnInfo lookupColumn = new LookUpColumnInfo();
                lookupColumn.FieldName = "ADWorkingShiftName";
                rep.Columns.Add(lookupColumn);
                rep.DataSource = GetWorkingShiftData();
                column.ColumnEdit = rep;
            }
            column = gridView.Columns["MMMachineUnitCapacity"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMCapacityUnit"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMMachineUnitQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMMachineUnitSetupTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMMachineUnitPlanFinishedDate"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }
            column = gridView.Columns["MMMachineUnitUnloading"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
            }
            column = gridView.Columns["MMMachineUnitJobTotalQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
            }
            return gridView;
        }
        public List<ADWorkingShiftsInfo> GetWorkingShiftData()
        {
            ADWorkingShiftsController objWorkingShiftsController = new ADWorkingShiftsController();
            List<ADWorkingShiftsInfo> commonParams = (List<ADWorkingShiftsInfo>)objWorkingShiftsController.GetListFromDataSet(objWorkingShiftsController.GetAllObjects());
            commonParams.Insert(0, new ADWorkingShiftsInfo());
            return commonParams;
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

            column = new GridColumn();
            column.FieldName = "FK_ADWorkingShiftID";
            column.Caption = "Ca làm việc";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMMachineUnitType";
            column.Caption = "Loại";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }
    }
}
