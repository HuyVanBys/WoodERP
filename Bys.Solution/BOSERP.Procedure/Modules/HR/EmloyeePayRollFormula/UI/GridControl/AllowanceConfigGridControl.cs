using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.EmloyeePayRollFormula
{
    public partial class AllowanceConfigGridControl : BOSComponent.BOSGridControl
    {
        #region Private variables
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private string WorkingShiftName = String.Empty;
        private string WorkingShiftFromTime = String.Empty;
        private string WorkingShiftToTime = String.Empty;
        #endregion

        public override void InitGridControlDataSource()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRAllowanceConfigList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["HRAllowanceConfigName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Tên phụ cấp"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditComponent_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["HRAllowanceConfigFromDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRAllowanceConfigToDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRAllowanceConfigPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRAllowanceConfigAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRAllowanceConfigIsTimeKeeping"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRAllowanceConfigPermiYearAndHoliday"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

            }

            column = gridView.Columns["HRAllowanceConfigContdifferenceWithReality"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

            }

            gridView.InvalidRowException += new InvalidRowExceptionEventHandler(GridView_InvalidRowException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.FocusedColumnChanged += new FocusedColumnChangedEventHandler(gridView_FocusedColumnChanged);
            gridView.FocusedRowChanged += new FocusedRowChangedEventHandler(gridView_FocusedRowChanged);

            return gridView;
        }

        void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            GridView view = (GridView)sender;

            HRAllowanceConfigsInfo config = (HRAllowanceConfigsInfo)view.GetFocusedRow();
            if (config != null)
            {
                if (!config.HRAllowanceConfigIsTimeKeeping)
                {
                    GridColumn column = view.Columns["HRAllowanceConfigContdifferenceWithReality"];
                    if (column != null)
                    {
                        column.OptionsColumn.AllowEdit = true;

                    }

                }
                else
                {
                    GridColumn column = view.Columns["HRAllowanceConfigContdifferenceWithReality"];
                    if (column != null)
                    {
                        column.OptionsColumn.AllowEdit = false;

                    }
                }
            }
        }

        void gridView_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            GridView view = (GridView)sender;

            HRAllowanceConfigsInfo config = (HRAllowanceConfigsInfo)view.GetFocusedRow();
            if (config != null)
            {
                if (!config.HRAllowanceConfigIsTimeKeeping)
                {
                    GridColumn column = view.Columns["HRAllowanceConfigContdifferenceWithReality"];
                    if (column != null)
                    {
                        column.OptionsColumn.AllowEdit = true;

                    }

                }
                else
                {
                    GridColumn column = view.Columns["HRAllowanceConfigContdifferenceWithReality"];
                    if (column != null)
                    {
                        column.OptionsColumn.AllowEdit = false;

                    }
                }
            }
        }

        void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "HRAllowanceConfigName")
            {
                if (e.Value != null)
                {
                    string configKeyValue = e.Value.ToString();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("AllowanceConfigName", configKeyValue);
                    if (objConfigValuesInfo != null)
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((EmloyeePayRollFormulaModule)Screen.Module).RemoveSelectedAllowanceConfig();
            }
        }

        protected void GridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        public void repositoryItemLookUpEditComponent_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("AllowanceConfigName");
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ADConfigValuesInfo obj = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                        configValuesList.Add(obj);
                    }
                }
            }
            if (configValuesList != null)
            {
                configValuesList.Insert(0, objConfigValuesInfo);
                lookUpEdit.Properties.DataSource = configValuesList;
            }
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        protected override void GridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            base.GridView_ValidateRow(sender, e);
            ColumnView view = sender as ColumnView;
            //GridColumn columnWorkingShiftName = view.Columns["HRWorkingShiftName"];
            //GridColumn columnWorkingShiftDayOffWeek = view.Columns["HRWorkingShiftDayOffWeek"];

            ////Get the value of columns
            //string workingShiftName = String.Empty;
            //string workingShiftDayOffWeek = String.Empty;

            //if (columnWorkingShiftName != null)
            //    workingShiftName = view.GetRowCellValue(e.RowHandle, columnWorkingShiftName).ToString();          
            //if (columnWorkingShiftDayOffWeek != null)
            //    workingShiftDayOffWeek = view.GetRowCellValue(e.RowHandle, columnWorkingShiftDayOffWeek).ToString();


            //if (string.IsNullOrEmpty(workingShiftDayOffWeek) && columnWorkingShiftDayOffWeek != null)
            //{
            //    view.SetRowCellValue(e.RowHandle, columnWorkingShiftDayOffWeek, BOSCommon.WorkingShiftDayOffWeek.All.ToString());
            //}

            //if (string.IsNullOrEmpty(workingShiftName) && columnWorkingShiftName != null)
            //{
            //    e.Valid = false;
            //    view.SetColumnError(columnWorkingShiftName, CompanyConstantLocalizedResources.NotNullOrEmptyWorkingShiftNameMessage);
            //}

        }
    }
}
