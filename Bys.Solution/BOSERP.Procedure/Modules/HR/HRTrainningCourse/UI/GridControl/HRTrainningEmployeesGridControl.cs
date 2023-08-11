using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTrainningCourse
{
    public class HRTrainningEmployeesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRTrainningCourseEntities entity = (HRTrainningCourseEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTrainningEmployeesList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            gridView.KeyUp += new KeyEventHandler(DeleteSelectedItem);
            gridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            return gridView;
        }

        private void GridView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = TrainningCourseLocalizedResources.TrainningEmployeeNameErrorMessage;
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn == gridView.Columns["FK_HREmployeeID"])
                e.Valid = !((HRTrainningCourseModule)Screen.Module).CheckExistEmployeeInGridControl(Convert.ToInt32(e.Value));
        }
        /// <summary>
        /// Delete selected item from trainning emloyees grid control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSelectedItem(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((HRTrainningCourseModule)Screen.Module).DeleteSelectedTrainningEmployeeItem();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ((HRTrainningCourseModule)Screen.Module).InvalidateTrainningEmployeeGridControl(Convert.ToInt32(e.Value));
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = TrainningCourseLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
