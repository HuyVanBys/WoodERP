using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTrainningCourse
{
    public class HRTrainningClassGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRTrainningCourseEntities entity = (HRTrainningCourseEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTrainningClassList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.KeyUp += new KeyEventHandler(DeleteSelectedTrainningClassItem);
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(InvalidateClassSchedules);
            return gridView;
        }
        /// <summary>
        /// Delete selected item from trainning class grid control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSelectedTrainningClassItem(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((HRTrainningCourseModule)Screen.Module).DeleteSelectedTrainningClassItem();
            }
        }

        /// <summary>
        /// Invalidate Class schedules grid control of an selected trainning class item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvalidateClassSchedules(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            int rowIndex = gridView.FocusedRowHandle;
            HRClassSchedulesGridControl classSchedulesGridControl = (HRClassSchedulesGridControl)Screen.Module.Controls[HRTrainningCourseModule.ClassSchedulesGridControlName];
            GridView classSchedule = (GridView)classSchedulesGridControl.MainView;
            classSchedule.OptionsBehavior.Editable = true;
            HRTrainningCourseEntities entity = (HRTrainningCourseEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            rowIndex = (rowIndex >= 0) ? rowIndex : (entity.HRTrainningClassList.Count - 1);
            HRTrainningClassInfo objTrainningClassInfo = (HRTrainningClassInfo)gridView.GetRow(rowIndex);
            if (objTrainningClassInfo != null)
            {
                if (objTrainningClassInfo.HRClassSchedulesList == null)
                {
                    objTrainningClassInfo.HRClassSchedulesList = new BOSList<HRClassSchedulesInfo>();
                    objTrainningClassInfo.HRClassSchedulesList.InitBOSList(entity,
                                                                                    TableName.HRTrainningClassTableName,
                                                                                    TableName.HRClassSchedulesTableName,
                                                                                    BOSList<HRClassSchedulesInfo>.cstRelationForeign);
                    objTrainningClassInfo.HRClassSchedulesList.ItemTableForeignKey = "FK_HRTrainningClassID";
                    ((BOSList<HRClassSchedulesInfo>)objTrainningClassInfo.HRClassSchedulesList).GridControl = classSchedulesGridControl;
                    if (objTrainningClassInfo.HRTrainningClassID > 0)
                    {
                        objTrainningClassInfo.HRClassSchedulesList.Invalidate(objTrainningClassInfo.HRTrainningClassID);
                    }
                }
                classSchedulesGridControl.InvalidateDataSource(objTrainningClassInfo.HRClassSchedulesList);
            }
        }
    }
}
