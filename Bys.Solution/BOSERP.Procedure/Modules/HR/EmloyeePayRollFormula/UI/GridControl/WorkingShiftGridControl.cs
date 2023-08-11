using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.EmloyeePayRollFormula
{
    public partial class WorkingShiftGridControl : BOSComponent.BOSGridControl
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
            bds.DataSource = entity.HRWorkingShiftList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.Columns.Remove(gridView.Columns["FK_HRWorkingShiftID"]);
            gridView.Columns.Remove(gridView.Columns["HRWorkingShiftTimeSession1"]);
            gridView.Columns.Remove(gridView.Columns["HRWorkingShiftTimeSession2"]);

            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            // repositoryItemDateEdit
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.EditFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";

            GridColumn column = gridView.Columns["HRWorkingShiftName"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;

            column = gridView.Columns["HRWorkingShiftDesc"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;

            column = gridView.Columns["HRWorkingShiftFromTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRWorkingShiftDayOffWeek"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRWorkingShiftToTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRWorkingShiftNight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRWorkingShiftTimeBreak"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRWorkingShiftWorkingTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRWorkingShiftIsDefault"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRWorkingShiftTimeSession2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRWorkingShiftTimeSession1"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRWorkingShiftFrameTimeTo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRWorkingShiftFrameTimeFrom"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRWorkingShiftBreakTimeBetweenShiftTo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRWorkingShiftBreakTimeBetweenShiftFrom"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["FK_HRWorkingShiftID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "HRWorkingShiftName";
                repositoryItemLookUpEdit.ValueMember = "HRWorkingShiftID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRWorkingShiftName", "Ca làm việc"));

                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.InvalidRowException += new InvalidRowExceptionEventHandler(GridView_InvalidRowException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HRWorkingShiftID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    HRWorkingShiftsController wsController = new HRWorkingShiftsController();
                    HRWorkingShiftsInfo ws = (HRWorkingShiftsInfo)wsController.GetObjectByID(matchCodeID);
                    if (ws != null)
                    {
                        e.DisplayText = ws.HRWorkingShiftName;
                    }
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;

            HRWorkingShiftsController wsController = new HRWorkingShiftsController();
            List<HRWorkingShiftsInfo> wsList = wsController.GetConfigWorkingShift();

            lookUpEdit.Properties.DataSource = wsList;

            lookUpEdit.Properties.DisplayMember = "HRWorkingShiftName";
            lookUpEdit.Properties.ValueMember = "HRWorkingShiftID";
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((EmloyeePayRollFormulaModule)Screen.Module).RemoveSelectedWorkingShift();
            }
        }

        protected void GridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }


        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.HRWorkingShiftList.CurrentIndex >= 0)
            {
                HRWorkingShiftsInfo item = entity.HRWorkingShiftList[entity.HRWorkingShiftList.CurrentIndex];
                if (e.Column.FieldName == "FK_HRWorkingShiftID")
                {
                    HRWorkingShiftsController wsController = new HRWorkingShiftsController();
                    HRWorkingShiftsInfo ws = (HRWorkingShiftsInfo)wsController.GetObjectByID(item.FK_HRWorkingShiftID);
                    if (ws != null)
                    {
                        item.HRWorkingShiftName = ws.HRWorkingShiftName;
                        item.HRWorkingShiftDesc = ws.HRWorkingShiftDesc;
                        item.HRWorkingShiftFromTime = ws.HRWorkingShiftFromTime;
                        item.HRWorkingShiftToTime = ws.HRWorkingShiftToTime;
                        item.HRWorkingShiftTimeBreak = ws.HRWorkingShiftTimeBreak;
                        item.HRWorkingShiftNight = ws.HRWorkingShiftNight;
                        item.HRWorkingShiftDayOffWeek = ws.HRWorkingShiftDayOffWeek;
                        item.FK_HRTimeSheetParamID = ws.FK_HRTimeSheetParamID;
                        item.HRWorkingShiftWorkingTime = ws.HRWorkingShiftWorkingTime;
                        item.HRWorkingShiftBreakTimeBetweenShiftFrom = ws.HRWorkingShiftBreakTimeBetweenShiftFrom;
                        item.HRWorkingShiftBreakTimeBetweenShiftTo = ws.HRWorkingShiftBreakTimeBetweenShiftTo;
                        item.HRWorkingShiftFrameTimeFrom = ws.HRWorkingShiftFrameTimeFrom;
                        item.HRWorkingShiftFrameTimeTo = ws.HRWorkingShiftFrameTimeTo;
                        item.HRWorkingShiftTimeSession1 = ws.HRWorkingShiftTimeSession1;
                        item.HRWorkingShiftTimeSession2 = ws.HRWorkingShiftTimeSession2;
                    }
                    else
                    {
                        item.HRWorkingShiftName = string.Empty;
                        item.HRWorkingShiftDesc = string.Empty;
                        item.HRWorkingShiftFromTime = DateTime.MaxValue;
                        item.HRWorkingShiftToTime = DateTime.MaxValue;
                        item.HRWorkingShiftTimeBreak = 0;
                        item.HRWorkingShiftBreakTimeBetweenShiftFrom = DateTime.MaxValue;
                        item.HRWorkingShiftBreakTimeBetweenShiftTo = DateTime.MaxValue;
                        item.HRWorkingShiftFrameTimeFrom = DateTime.MaxValue;
                        item.HRWorkingShiftFrameTimeTo = DateTime.MaxValue;
                        item.HRWorkingShiftTimeSession1 = 0;
                        item.HRWorkingShiftTimeSession2 = 0;

                        item.HRWorkingShiftDayOffWeek = string.Empty;
                        item.FK_HRTimeSheetParamID = 0;
                        item.HRWorkingShiftWorkingTime = 0;

                    }
                }

                this.RefreshDataSource();
            }
        }

        protected override void GridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            base.GridView_ValidateRow(sender, e);
            ColumnView view = sender as ColumnView;
            //GridColumn columnWorkingShiftName = view.Columns["HRWorkingShiftName"];
            //GridColumn columnWorkingShiftFromTime = view.Columns["HRWorkingShiftFromTime"];
            //GridColumn columnWorkingShiftToTime = view.Columns["HRWorkingShiftToTime"];
            //GridColumn columnWorkingShiftDayOffWeek = view.Columns["HRWorkingShiftDayOffWeek"];

            ////Get the value of columns
            //string workingShiftName = String.Empty;
            //string workingShiftFromTime = String.Empty;
            //string workingShiftToTime = String.Empty;
            //string workingShiftDayOffWeek = String.Empty;

            //if(columnWorkingShiftName != null)
            //    workingShiftName = view.GetRowCellValue(e.RowHandle, columnWorkingShiftName).ToString();
            //if (columnWorkingShiftFromTime != null)
            //    workingShiftFromTime = view.GetRowCellValue(e.RowHandle, columnWorkingShiftFromTime).ToString();
            //if (columnWorkingShiftToTime != null)
            //    workingShiftToTime = view.GetRowCellValue(e.RowHandle, columnWorkingShiftToTime).ToString();
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

            //if (string.IsNullOrEmpty(workingShiftFromTime) && columnWorkingShiftFromTime != null)
            //{
            //    e.Valid = false;
            //    view.SetColumnError(columnWorkingShiftFromTime, CompanyConstantLocalizedResources.NotNullOrEmptyWorkingShiftFromTimeMessage); 
            //}

            //if (string.IsNullOrEmpty(workingShiftToTime) && columnWorkingShiftToTime != null)
            //{
            //    e.Valid = false;
            //    view.SetColumnError(columnWorkingShiftToTime, CompanyConstantLocalizedResources.NotNullOrEmptyWorkingShiftToTimeMessage); 
            //}

        }
    }
}
