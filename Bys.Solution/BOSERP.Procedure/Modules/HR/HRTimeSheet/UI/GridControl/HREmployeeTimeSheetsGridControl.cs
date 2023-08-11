using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTimeSheet
{
    public partial class HREmployeeTimeSheetsGridControl : BOSGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }
        public List<HROTFactorsInfo> OTFactorlist { get; set; }
        public string ToolTipText { get; set; }
        /// <summary>
        /// Gets or sets the row hanle of current row selected
        /// </summary>
        public int RowHandle { get; set; }
        public override void InitGridControlDataSource()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeTimeSheetList;
            DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            //Init banded view and make it the main view
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            ShowOnlyPredefinedDetails = true;
            UseEmbeddedNavigator = false;
        }

        /// <summary>
        /// Initialize BandedGridView
        /// </summary>
        /// <param name="gridView"></param>
        /// <returns></returns>
        private BandedGridView InitializeBandedGridView(GridView gridView)
        {
            //Creat a banded grid view
            BandedGridView bandedView = new BandedGridView();
            GridBand gridBand1 = new GridBand();
            GridBand gridBand2 = new GridBand();
            GridBand gridBand3 = new GridBand();
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            gridBand1,
            gridBand2,
            gridBand3});
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedColumn(gridView.Columns[i], false, FormatType.None, string.Empty)});
            }
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = true;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            bandedView.OptionsFilter.AllowFilterEditor = true;
            bandedView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            bandedView.OptionsView.ShowAutoFilterRow = true;

            //GridBand1
            gridBand1.Caption = TimeSheetLocalizedResources.EmployeesInfo;
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.Name = "gridBand1";

            //GridBand2
            gridBand2.Caption = TimeSheetLocalizedResources.DayList;
            gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand2.Name = "gridBand2";

            //GridBand3
            gridBand3.Caption = TimeSheetLocalizedResources.CaculateSheet;
            gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand3.Name = "gridBand3";

            // Assigning columns to bands
            GridColumn column = gridView.Columns["HREmployeeCardNumber"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.None, string.Empty);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 40;
            }
            column = gridView.Columns["HREmployeeNo"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.None, string.Empty);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 150;
            }
            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.None, string.Empty);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 150;
            }

            column = gridView.Columns["HRDepartmentRoomName"];
            if (column != null)
                ConvertToBandedColumn(column, false, FormatType.None, string.Empty).OwnerBand = gridBand1;

            column = gridView.Columns["HRDepartmentName"];
            if (column != null)
                ConvertToBandedColumn(column, false, FormatType.None, string.Empty).OwnerBand = gridBand1;

            column = gridView.Columns["HRDepartmentRoomGroupItemName"];
            if (column != null)
                ConvertToBandedColumn(column, false, FormatType.None, string.Empty).OwnerBand = gridBand1;

            column = gridView.Columns["HRDepartmentRoomGroupTeamItemName"];
            if (column != null)
                ConvertToBandedColumn(column, false, FormatType.None, string.Empty).OwnerBand = gridBand1;

            column = gridView.Columns["HRLevelName"];
            if (column != null)
                ConvertToBandedColumn(column, false, FormatType.None, string.Empty).OwnerBand = gridBand1;

            for (int i = 1; i <= 31; i++)
            {
                column = gridView.Columns[String.Format("{0}{1}", "HREmployeeTimeSheetDate", i.ToString())];
                if (column != null)
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true, FormatType.None, string.Empty);
                    bandedColumn.OwnerBand = gridBand2;
                    bandedColumn.Width = 50;
                }
            }

            column = gridView.Columns["HREmployeeTimeSheetWorkingQty"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n4}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 70;
            }

            column = gridView.Columns["HREmployeeTimeSheetWorkingHour"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n4}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 70;
            }
            column = gridView.Columns["HREmployeeTimeSheetOTQty"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n4}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }

            //column = gridView.Columns["HREmployeeTimeSheetOTSalaryFactor"];
            //if (column != null)
            //{
            //    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:##0,00}");
            //    bandedColumn.OwnerBand = gridBand3;
            //    bandedColumn.Width = 90;
            //}
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            foreach (var item in OTFactorlist)
            {
                column = gridView.Columns[item.HRTimeSheetParamValue2.ToString()];
                if (column != null)
                {
                    column.Caption = "TC HS " + item.HRTimeSheetParamValue2.ToString();
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n4}");
                    bandedColumn.OwnerBand = gridBand3;
                    bandedColumn.Width = 90;
                }
            }

            //column = gridView.Columns["HREmployeeTimeSheetLeaveQty"];
            //if (column != null)
            //{
            //    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n0}");
            //    bandedColumn.OwnerBand = gridBand3;
            //    bandedColumn.Width = 90;
            //}
            column = gridView.Columns["HREmployeeTimeSheetPermissionOTDaysOff"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n2}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetNghiCoPhep"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n2}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetNghiKhongPhep"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n2}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetNghiLe"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n2}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetNghiCheDo"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n2}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetCongTyChoNghi"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n2}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetNghiPhepNam"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false, FormatType.Numeric, "{0:n2}");
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            return bandedView;
        }

        private void BandedView_RowClick(object sender, RowClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }

        private void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((HRTimeSheetModule)Screen.Module).RemoveEmployeeFromTimeSheetList();
            }
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo = (HREmployeeTimeSheetsInfo)gridView.GetRow(e.RowHandle);
                //Update time sheet total quantity
                ((HRTimeSheetModule)Screen.Module).UpdateTimeSheetTotalQty(objEmployeeTimeSheetsInfo);
            }
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (((HRTimeSheetModule)Screen.Module).isCustomDrawCell)
            //    return;
            BandedGridView bandedView = (BandedGridView)MainView;
            if (!bandedView.IsValidRowHandle(e.RowHandle))
                return;

            int focusedRowHandle = e.RowHandle;
            if (focusedRowHandle >= 0)
            {
                HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo = bandedView.GetRow(focusedRowHandle) as HREmployeeTimeSheetsInfo;
                if (objEmployeeTimeSheetsInfo != null)
                {
                    foreach (var item in objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList)
                    {
                        if (e.Column.FieldName == item.HREmployeeTimeSheetOTDetailName)
                        {
                            e.DisplayText = item.HREmployeeTimeSheetOTDetailHours.ToString();
                        }
                    }

                    if (e.Column.FieldName == "HREmployeeTimeSheetWorkingQty")
                    {
                        if (objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty > 0)
                            e.DisplayText = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty.ToString("N4");
                        else
                            e.DisplayText = string.Empty;
                    }
                    else if (e.Column.FieldName == "HREmployeeTimeSheetWorkingHour")
                    {
                        if (objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingHour > 0)
                            e.DisplayText = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingHour.ToString("N4");
                        else
                            e.DisplayText = string.Empty;
                    }
                    else if (e.Column.FieldName == "HREmployeeTimeSheetOTQty")
                    {
                        if (objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTQty > 0)
                            e.DisplayText = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTQty.ToString("N4");
                        else
                            e.DisplayText = string.Empty;
                    }
                    else if (e.Column.FieldName == "HREmployeeTimeSheetLeaveQty")
                    {
                        if (objEmployeeTimeSheetsInfo.HREmployeeTimeSheetLeaveQty > 0)
                            e.DisplayText = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetLeaveQty.ToString("N2");
                        else
                            e.DisplayText = string.Empty;
                    }
                    else if (e.Column.FieldName == "HREmployeeTimeSheetPermissionOTDaysOff")
                    {
                        if (objEmployeeTimeSheetsInfo.HREmployeeTimeSheetPermissionOTDaysOff > 0)
                            e.DisplayText = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetPermissionOTDaysOff.ToString("N2");
                        else
                            e.DisplayText = string.Empty;
                    }
                    else if (e.Column.FieldName == "HREmployeeTimeSheetOTSalaryFactor")
                    {
                        if (objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTSalaryFactor > 0)
                            e.DisplayText = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTSalaryFactor.ToString("N4");
                        else
                            e.DisplayText = string.Empty;
                    }
                }

                List<string> columnFieldNameList = ((HRTimeSheetModule)Screen.Module).GetColumnFieldNameByTypeEndOfWeek();
                if (columnFieldNameList.Count > 0)
                {
                    for (int i = 0; i < columnFieldNameList.Count; i++)
                    {
                        if (e.Column.FieldName.Equals(columnFieldNameList[i]))
                        {
                            e.Appearance.BackColor = Color.Red;
                        }
                    }
                }
            }
            ((HRTimeSheetModule)Screen.Module).isCustomDrawCell = true;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HRDepartmentRoomName;
            column.FieldName = "HRDepartmentRoomName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HRDepartmentName;
            column.FieldName = "HRDepartmentName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổ";
            column.FieldName = "HRDepartmentRoomGroupItemName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm";
            column.FieldName = "HRDepartmentRoomGroupTeamItemName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chức vụ";
            column.FieldName = "HRLevelName";
            gridView.Columns.Add(column);

            int numDays = ((HRTimeSheetModule)Screen.Module).NumOfDayInMonth();
            HRTimeSheetEntities entity = (HRTimeSheetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            for (int i = 1; i <= numDays; i++)
            {
                GridColumn columnDays = new GridColumn();
                DateTime dt = objTimeSheetsInfo.HRTimeSheetFromDate.Date.AddDays(i - 1);
                columnDays.Caption = dt.ToString("dd/MM");
                columnDays.FieldName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", i.ToString());
                gridView.Columns.Add(columnDays);
            }
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            foreach (var item in OTFactorlist)
            {
                column = new GridColumn();
                column.Caption = "TC HS " + item.HRTimeSheetParamValue2.ToString();
                column.FieldName = item.HRTimeSheetParamValue2.ToString();
                column.Tag = item.HRTimeSheetParamValue2;
                gridView.Columns.Add(column);
            }
        }

        /// <summary>
        /// Convert GridColumn to BandedGridColumn
        /// </summary>
        /// <param name="gridColumn">Column of GridView</param>
        /// <param name="isAllowEdit">Allow column edit or not</param>
        /// <returns></returns>
        public BandedGridColumn ConvertToBandedColumn(GridColumn gridColumn, bool isAllowEdit, FormatType type, string format)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = gridColumn.Name;
            bandedColumn.FieldName = gridColumn.FieldName;
            bandedColumn.Caption = gridColumn.Caption;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Visible = true;
            bandedColumn.Width = gridColumn.Width;
            bandedColumn.OptionsFilter.AllowAutoFilter = true;
            if (isAllowEdit)
            {
                RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
                rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                rep.Mask.EditMask = "n2";
                rep.Mask.UseMaskAsDisplayFormat = true;
                bandedColumn.ColumnEdit = rep;
            }
            if (format != string.Empty)
            {
                bandedColumn.DisplayFormat.FormatType = type;
                bandedColumn.DisplayFormat.FormatString = format;
            }
            return bandedColumn;
        }
    }
}
