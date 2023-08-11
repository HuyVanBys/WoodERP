using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class HRTimeSheetParamGridControl : BOSGridControl
    {
        private List<ADWorkingShiftsInfo> WorkingShiftList;
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTimeSheetParamList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            ADWorkingShiftsController objWorkingShiftsController = new ADWorkingShiftsController();
            WorkingShiftList = (List<ADWorkingShiftsInfo>)objWorkingShiftsController.GetListFromDataSet(objWorkingShiftsController.GetAllObjects());
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.Columns.Remove(gridView.Columns["HRTimeSheetParamNight"]);
            gridView.Columns.Remove(gridView.Columns["IsOTCalculated"]);
            gridView.Columns.Remove(gridView.Columns["HRTimeSheetParamBonusTimeConfig"]);

            GridColumn column = gridView.Columns["HRTimeSheetParamNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamValue1"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamValue2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsOTCalculated"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRTimeSheetParamBonusTimeConfig"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsAllowedLeave"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsPause"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRWorkingShiftID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckedComboBoxEdit rp = new RepositoryItemCheckedComboBoxEdit();
                rp.DataSource = WorkingShiftList;
                rp.DisplayMember = "HRWorkingShiftName";
                rp.ValueMember = "HRWorkingShiftID";
                rp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rp.NullText = string.Empty;
                //rp.Columns.Add(new LookUpColumnInfo("HRWorkingShiftName", 100, "Ca làm việc"));
                //rp.QueryPopUp += new System.ComponentModel.CancelEventHandler(rp_QueryPopUp);
                column.ColumnEdit = rp;
            }

            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }

        private void rp_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                CheckedComboBoxEdit lookUpEdit = (CheckedComboBoxEdit)sender;
                lookUpEdit.Properties.DataSource = WorkingShiftList;
                lookUpEdit.Properties.DisplayMember = "HRWorkingShiftName";
                lookUpEdit.Properties.ValueMember = "HRWorkingShiftID";
            }
        }


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedTimeSheetParam();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "HRTimeSheetParamNo")
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyTimeSheetParamNoMessage;
                        e.Valid = false;
                    }
                }
                if (gridView.FocusedColumn.FieldName == "HRTimeSheetParamName")
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyTimeSheetParamNameMessage;
                        e.Valid = false;
                    }
                }
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            HRWorkingShiftsInfo objWorkingShiftsInfo = new HRWorkingShiftsInfo();
            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            if (e.Column.FieldName == "FK_HRWorkingShiftID")
            {
                if (e.Value != null)
                {
                    objWorkingShiftsInfo = (HRWorkingShiftsInfo)objWorkingShiftsController.GetWorkingShiftByListID(e.Value.ToString());
                    if (objWorkingShiftsInfo != null)
                    {
                        e.DisplayText = objWorkingShiftsInfo.HRWorkingShiftName;
                    }
                }
            }
        }
    }
}
