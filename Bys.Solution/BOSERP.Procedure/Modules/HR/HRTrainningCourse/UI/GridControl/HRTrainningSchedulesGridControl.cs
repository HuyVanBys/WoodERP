using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTrainningCourse
{
    public partial class HRTrainningSchedulesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRTrainningCourseEntities entity = (HRTrainningCourseEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTrainningSchedulesList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemDateEdit repositoryItemTimeEdit = new RepositoryItemDateEdit();
            // repositoryItemDateEdit
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
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = TrainningCourseLocalizedResources.HRTrainningClassName;
            column.FieldName = "HRTrainningClassName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TrainningCourseLocalizedResources.HRDayOfWeek;
            column.FieldName = "HRDayOfWeek";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TrainningCourseLocalizedResources.HRTrainningScheduleDay;
            column.FieldName = "HRTrainningScheduleDay";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TrainningCourseLocalizedResources.HRClassScheduleFromTime;
            column.FieldName = "HRClassScheduleFromTime";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TrainningCourseLocalizedResources.HRClassScheduleToTime;
            column.FieldName = "HRClassScheduleToTime";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
