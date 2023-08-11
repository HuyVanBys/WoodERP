using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTrainningCourse
{
    public partial class HRClassSchedulesGridControl : BOSGridControl
    {
        /// <summary>
        /// Start time of a schedules
        /// </summary>
        private DateTime FromTime = DateTime.MinValue;
        /// <summary>
        /// End time of a schedules
        /// </summary>
        private DateTime ToTime = DateTime.MaxValue;
        /// <summary>
        /// The error message is showed when [FromTime] > [ToTime]
        /// </summary>
        private string ErrorMessage = string.Empty;

        /// <summary>
        /// Invalidate class schedules gridcontrol
        /// </summary>
        /// <param name="dataSource"></param>
        public void InvalidateDataSource(IBOSList<HRClassSchedulesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            // set all columns are enable
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
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

            gridView.KeyUp += new KeyEventHandler(DeleteSelectedItem);
            gridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(ValidateClassSchedulesEditor);
            gridView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(ShowErrorException);
            return gridView;
        }

        /// <summary>
        /// Show error message if the value of [from time] > [to time]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowErrorException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "HRClassScheduleFromTime")
            {
                ErrorMessage = TrainningCourseLocalizedResources.FromTimeErrorMessage;
            }
            if (gridView.FocusedColumn.FieldName == "HRClassScheduleToTime")
            {
                ErrorMessage = TrainningCourseLocalizedResources.ToTimeErrorMessage;
            }
            e.ErrorText = ErrorMessage;
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }
        /// <summary>
        /// Check valid from time and to time of trainning schedules
        /// [from time] must be less than [to time]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateClassSchedulesEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            int rowIndex = gridView.FocusedRowHandle;
            HRTrainningCourseEntities entity = (HRTrainningCourseEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            rowIndex = (rowIndex >= 0) ? rowIndex : (entity.HRClassSchedulesList.Count - 1);
            ColumnView colView = (ColumnView)sender;
            GridColumn colFromTime = colView.Columns["HRClassScheduleFromTime"];
            GridColumn colToTime = colView.Columns["HRClassScheduleToTime"];
            HRClassSchedulesInfo objClassSchedulesInfo = new HRClassSchedulesInfo();
            objClassSchedulesInfo = (HRClassSchedulesInfo)gridView.GetRow(rowIndex);
            if (objClassSchedulesInfo != null)
            {
                if (gridView.FocusedColumn == colFromTime)
                {
                    FromTime = Convert.ToDateTime(e.Value);
                    ToTime = objClassSchedulesInfo.HRClassScheduleToTime;
                    if (FromTime > ToTime)
                    {
                        e.Valid = false;
                    }
                }
                if (gridView.FocusedColumn == colToTime)
                {
                    ToTime = Convert.ToDateTime(e.Value);
                    FromTime = objClassSchedulesInfo.HRClassScheduleFromTime;
                    if (FromTime > ToTime)
                    {
                        e.Valid = false;
                    }
                }
            }
        }
        /// <summary>
        /// Delete selected item from trainning schedules grid control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSelectedItem(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((HRTrainningCourseModule)Screen.Module).DelectSelectedClassScheduleItem();
            }
        }
    }
}
