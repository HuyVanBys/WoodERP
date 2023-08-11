using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTrainningEmployee
{
    public class HRTrainningEmployeesGridControl : BOSGridControl
    {
        /// <summary>
        /// Check current employee is teacher or existed
        /// </summary>
        private int CheckEmployee = -1;

        public override void InitGridControlDataSource()
        {
            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTrainningEmployeesList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(gridView_ValidatingEditor);
            gridView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(gridView_InvalidValueException);
            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            return gridView;
        }

        private void gridView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            string ErrorMessage = string.Empty;
            if (CheckEmployee == 0)
                ErrorMessage = TrainningEmployeeLocalizedResources.TrainningEmployeeNameErrorMessage;
            else if (CheckEmployee == 1)
                ErrorMessage = TrainningEmployeeLocalizedResources.TrainningEmployeeTeacherNameErrorMessage;
            else if (CheckEmployee == 2)
                ErrorMessage = TrainningEmployeeLocalizedResources.TrainningClassIsNull;
            e.ErrorText = ErrorMessage;
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void gridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn == gridView.Columns["FK_HREmployeeID"])
            {
                CheckEmployee = ((HRTrainningEmployeeModule)Screen.Module).CheckListExistTrainningEmployeeName(Convert.ToInt32(e.Value));
                e.Valid = (CheckEmployee < 0);
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn == gridView.Columns["FK_HREmployeeID"])
                ((HRTrainningEmployeeModule)Screen.Module).AddItemToTrainningEmloyeeList(Convert.ToInt32(e.Value));
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
