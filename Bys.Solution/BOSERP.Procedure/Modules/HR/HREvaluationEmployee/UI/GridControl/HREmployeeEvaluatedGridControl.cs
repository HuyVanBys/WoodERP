using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;
namespace BOSERP.Modules.HREvaluationEmployee
{
    public partial class HREmployeeEvaluatedGridControl : BOSGridControl
    {
        #region Public Properties
        /// <summary>
        /// Column allow edit or not
        /// </summary>
        public bool IsAllowEidt { get; set; }
        #endregion

        public override void InitGridControlDataSource()
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeEvaluatedList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["HREmployeeEvaluationResult"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = IsAllowEidt;
            }
            column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridView_CellValueChanged);
            gridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            return gridView;
        }

        private void GridView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "FK_HREmployeeID")
            {
                e.ErrorText = EvaluationEmployeeLocalizedResources.EmployeeIsExist;
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            }
        }

        private void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn == gridView.Columns["FK_HREmployeeID"])
            {
                e.Valid = !((HREvaluationEmployeeModule)Screen.Module).CheckEvaluatedEmployeeExist(Convert.ToInt32(e.Value));
            }
        }

        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn == gridView.Columns["FK_HREmployeeID"])
            {
                ((HREvaluationEmployeeModule)Screen.Module).AddEmployeeToEmployeeEvaluatedList(Convert.ToInt32(e.Value));
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = EvaluationEmployeeLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

    }
}
