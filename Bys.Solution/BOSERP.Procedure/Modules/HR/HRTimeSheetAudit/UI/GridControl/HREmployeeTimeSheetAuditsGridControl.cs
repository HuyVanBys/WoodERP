using BOSComponent;
using BOSERP.Module.HRTimeSheetAudit;
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

namespace BOSERP.Modules.HRTimeSheetAudit
{
    public partial class HREmployeeTimeSheetAuditsGridControl : BOSGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }
        /// <summary>
        /// Gets or sets the row hanle of current row selected
        /// </summary>
        public int RowHandle { get; set; }
        public override void InitGridControlDataSource()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeTimeSheetAuditList;
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
                        ConvertToBandedColumn(gridView.Columns[i], false)});
            }
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

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
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 40;
            }
            column = gridView.Columns["HREmployeeNo"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 150;
            }
            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 150;
            }

            column = gridView.Columns["HRDepartmentRoomName"];
            if (column != null)
                ConvertToBandedColumn(column, false).OwnerBand = gridBand1;

            column = gridView.Columns["HRDepartmentName"];
            if (column != null)
                ConvertToBandedColumn(column, false).OwnerBand = gridBand1;

            column = gridView.Columns["HRDepartmentRoomGroupItemName"];
            if (column != null)
                ConvertToBandedColumn(column, false).OwnerBand = gridBand1;
            column = gridView.Columns["HRLevelName"];
            if (column != null)
                ConvertToBandedColumn(column, false).OwnerBand = gridBand1;

            for (int i = 1; i <= 31; i++)
            {
                column = gridView.Columns[String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", i.ToString())];
                if (column != null)
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                    bandedColumn.OwnerBand = gridBand2;
                    bandedColumn.Width = 50;
                }
            }

            column = gridView.Columns["HREmployeeTimeSheetAuditWorkingQty"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 70;
            }

            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            foreach (var item in OTFactorlist)
            {
                column = gridView.Columns[item.HRTimeSheetParamValue2.ToString()];
                if (column != null)
                {
                    column.Caption = "TC HS " + item.HRTimeSheetParamValue2.ToString();
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                    bandedColumn.OwnerBand = gridBand3;
                    bandedColumn.Width = 60;
                }
            }
            column = gridView.Columns["HREmployeeTimeSheetAuditHourProductivity"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetAuditOTQty"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }

            //column = gridView.Columns["HREmployeeTimeSheetAuditLeaveQty"];
            //if (column != null)
            //{
            //    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
            //    bandedColumn.OwnerBand = gridBand3;
            //    bandedColumn.Width = 90;
            //}

            column = gridView.Columns["HREmployeeTimeSheetAuditPermissionOTDaysOff"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }

            column = gridView.Columns["HREmployeeTimeSheetAuditNghiCoPhep"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetAuditNghiKhongPhep"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetAuditNghiLe"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetAuditNghiCheDo"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetAuditCongTyChoNghi"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }
            column = gridView.Columns["HREmployeeTimeSheetAuditNghiPhepNam"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand3;
                bandedColumn.Width = 90;
            }

            bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            bandedView.RowCellStyle += new RowCellStyleEventHandler(bandedView_RowCellStyle);

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
                ((HRTimeSheetAuditModule)Screen.Module).RemoveEmployeeFromTimeSheetAuditList();
            }
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = (HREmployeeTimeSheetAuditsInfo)gridView.GetRow(e.RowHandle);
                // kiểm tra tăng ca theo cấu hình
                //string listTimeAudit = e.Value.ToString() + ",";
                //string[] value = listTimeAudit.Split(',');
                //List<string> timeList = new List<string>();
                //List<string> timeOTList = new List<string>();
                //timeList.AddRange(value);
                //HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                //HRTimeSheetParamsInfo objHRTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
                //for (int i = 0; i < timeList.Count; i++)
                //{                
                //    objHRTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByNo(timeList[i].Trim());
                //    if (objHRTimeSheetParamsInfo != null && objHRTimeSheetParamsInfo.IsOTCalculated == true)
                //    {
                //        string pamaNo = timeList[i] + ",";
                //        listTimeAudit = listTimeAudit.Replace(pamaNo, "");
                //        timeOTList.Add(timeList[i]);
                //    }
                //}
                //if (timeOTList.Count > 0)
                //{
                //    string timeSheetParamNo = ((HRTimeSheetAuditModule)Screen.Module).UpdateEmployeeTimeSheetAudit(objEmployeeTimeSheetAuditsInfo, timeOTList);
                //    if (!string.IsNullOrEmpty(timeSheetParamNo))
                //        listTimeAudit += timeSheetParamNo;
                //    if (!string.IsNullOrEmpty(listTimeAudit) && listTimeAudit != ",")
                //        listTimeAudit = listTimeAudit.Substring(0, listTimeAudit.Length - 1);
                //    else {
                //        listTimeAudit = string.Empty;
                //    }
                //    string day = e.Column.FieldName.Substring(e.Column.FieldName.Length - 1);
                //    BOSDbUtil dbUtil = new BOSDbUtil();
                //    dbUtil.SetPropertyValue(objEmployeeTimeSheetAuditsInfo, string.Format("HREmployeeTimeSheetAuditDate{0}", day), listTimeAudit);

                //}
                ((HRTimeSheetAuditModule)Screen.Module).UpdateTimeSheetAuditTotalQty(objEmployeeTimeSheetAuditsInfo);
            }
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {

            BandedGridView bandedView = (BandedGridView)MainView;
            if (!bandedView.IsValidRowHandle(e.RowHandle))
                return;
            int focusedRowHandle = e.RowHandle;
            if (focusedRowHandle >= 0)
            {
                HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = bandedView.GetRow(focusedRowHandle) as HREmployeeTimeSheetAuditsInfo;
                if (objEmployeeTimeSheetAuditsInfo != null)
                {
                    foreach (var item in objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTDetailsList)
                    {
                        if (e.Column.FieldName == item.HREmployeeTimeSheetAuditOTDetailName)
                        {
                            e.DisplayText = item.HREmployeeTimeSheetAuditOTDetailHours.ToString();
                        }
                    }
                }
            }
            ((HRTimeSheetAuditModule)Screen.Module).isCustomDrawCell = true;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            return gridView;
        }

        void bandedView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "HREmployeeTimeSheetAuditHourProductivity")
            {
                e.Appearance.BackColor2 = Color.Yellow;
                e.Appearance.BackColor = Color.Yellow;
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = TimeSheetAuditLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetAuditLocalizedResources.HRDepartmentRoomName;
            column.FieldName = "HRDepartmentRoomName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetAuditLocalizedResources.HRDepartmentName;
            column.FieldName = "HRDepartmentName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetAuditLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổ";
            column.FieldName = "HRDepartmentRoomGroupItemName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chức vụ";
            column.FieldName = "HRLevelName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giờ năng suất";
            column.FieldName = "HREmployeeTimeSheetAuditHourProductivity";
            gridView.Columns.Add(column);

            int numDays = ((HRTimeSheetAuditModule)Screen.Module).NumOfDayInMonth();
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
            for (int i = 1; i <= numDays; i++)
            {
                GridColumn columnDays = new GridColumn();
                DateTime dt = objTimeSheetsInfo.HRTimeSheetAuditFromDate.Date.AddDays(i - 1);
                columnDays.Caption = dt.ToString("dd/MM");
                columnDays.FieldName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", i.ToString());
                gridView.Columns.Add(columnDays);
            }

            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            foreach (var item in OTFactorlist)
            {
                GridColumn column1 = new GridColumn();
                column1.Caption = "TC HS " + item.HRTimeSheetParamValue2.ToString();
                column1.FieldName = item.HRTimeSheetParamValue2.ToString();
                column1.Tag = item.HRTimeSheetParamValue2;
                gridView.Columns.Add(column1);
            }

            column = new GridColumn();
            column.Caption = "Nghỉ có phép";
            column.FieldName = "HREmployeeTimeSheetNghiCoPhep";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nghỉ không phép";
            column.FieldName = "HREmployeeTimeSheetNghiKhongPhep";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nghỉ lễ";
            column.FieldName = "HREmployeeTimeSheetNghiLe";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nghỉ chế độ";
            column.FieldName = "HREmployeeTimeSheetNghiCheDo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Công ty cho nghỉ";
            column.FieldName = "HREmployeeTimeSheetCongTyChoNghi";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nghỉ phép năm";
            column.FieldName = "HREmployeeTimeSheetNghiPhepNam";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Xuống tăng ca";
            column.FieldName = "HREmployeeTimeSheetAuditPermissionOTDaysOff";
            gridView.Columns.Add(column);
        }

        /// <summary>
        /// Convert GridColumn to BandedGridColumn
        /// </summary>
        /// <param name="gridColumn">Column of GridView</param>
        /// <param name="isAllowEdit">Allow column edit or not</param>
        /// <returns></returns>
        public BandedGridColumn ConvertToBandedColumn(GridColumn gridColumn, bool isAllowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = gridColumn.Name;
            bandedColumn.FieldName = gridColumn.FieldName;
            bandedColumn.Caption = gridColumn.Caption;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Visible = true;
            bandedColumn.Width = gridColumn.Width;
            bandedColumn.DisplayFormat.FormatType = FormatType.Numeric;
            bandedColumn.DisplayFormat.FormatString = "#,##0.00";
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask =   "#,##0.00",
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = "#,##0.00";
            bandedColumn.ColumnEdit = repositoryItemTextEdit;

            //if (isAllowEdit)
            //{
            //    RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
            //    rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //    rep.Mask.EditMask = "n2";
            //    rep.Mask.UseMaskAsDisplayFormat = true;
            //    bandedColumn.ColumnEdit = rep;
            //}
            return bandedColumn;
        }
    }
}
