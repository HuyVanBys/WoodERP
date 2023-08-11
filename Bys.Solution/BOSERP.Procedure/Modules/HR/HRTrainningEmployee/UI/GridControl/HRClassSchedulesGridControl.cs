using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;
namespace BOSERP.Modules.HRTrainningEmployee
{
    public class HRClassSchedulesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRClassSchedulesList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            RepositoryItemDateEdit repositoryItemTimeEdit = new RepositoryItemDateEdit();
            repositoryItemTimeEdit.AutoHeight = false;
            repositoryItemTimeEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemTimeEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemTimeEdit.EditFormat.FormatString = "HH:mm:ss";
            repositoryItemTimeEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemTimeEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemTimeEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemTimeEdit.Name = "repositoryItemTimeEdit1";

            GridColumn columnDateTime = gridView.Columns["HRClassScheduleFromTime"];
            if (columnDateTime != null)
            {
                columnDateTime.ColumnEdit = repositoryItemTimeEdit;
            }
            columnDateTime = gridView.Columns["HRClassScheduleToTime"];
            if (columnDateTime != null)
            {
                columnDateTime.ColumnEdit = repositoryItemTimeEdit;
            }
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            return gridView;
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.FocusedRowHandle >= 0)
            {
                HREmployeeAbsencesGridControl employeeAbsencesGridControl = (HREmployeeAbsencesGridControl)Screen.Module.Controls[HRTrainningEmployeeModule.TrainningEmployeesGridControlName];
                HRClassSchedulesInfo objClassSchedulesInfo = (HRClassSchedulesInfo)gridView.GetRow(e.FocusedRowHandle);
                ((HRTrainningEmployeeModule)Screen.Module).ChosseTrainningEmployee(objClassSchedulesInfo);
                employeeAbsencesGridControl.InitGridControlDataSource();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = TrainningEmployeeLocalizedResources.HRClassSchedulesDate;
            column.FieldName = "HRClassSchedulesDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
