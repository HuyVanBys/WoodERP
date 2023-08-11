using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using DevExpress.Utils;
using System.Linq;
using System.Web.Configuration;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using BOSCommon;
using BOSReport;
using DevExpress.XtraEditors.Repository;

namespace BOSERP.Modules.Report
{
    public partial class RPTongHopBHXH : ReportForm
    {

        List<ADReportsInfo> ReportList;

        public RPTongHopBHXH()
        {
            InitializeComponent();
        }
        private void RPTongHopBHXH_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = DateTime.Now;
            fld_dteSearchToDate.DateTime = DateTime.Now;
        }

        public DataTable CreateDataTable(List<string> monthStrList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("STT", typeof(string)));
            dt.Columns.Add(new DataColumn("EmployeeID", typeof(int)));
            dt.Columns.Add(new DataColumn("EmployeeNo", typeof(string)));
            dt.Columns.Add(new DataColumn("EmployeeName", typeof(string)));
            dt.Columns.Add(new DataColumn("EmployeeInsContractNo", typeof(string)));

            monthStrList.ForEach(t => {
                dt.Columns.Add(new DataColumn(t+"_Amount", typeof(string)));
                dt.Columns.Add(new DataColumn(t + "_Type", typeof(string)));
            });

            return dt;
        }

        public List<string> GetMonthStringList(DateTime fromMonth, DateTime toMonth)
        {
            List<string> resultList = new List<string>();

            DateTime stampDate = fromMonth.Date;

            while ((stampDate.Month <= toMonth.Month
                    && stampDate.Year == toMonth.Year) || (stampDate.Year < toMonth.Year))
            {
                if (!resultList.Contains(stampDate.ToString("MM/yyyy")))
                {
                    resultList.Add(stampDate.ToString("MM/yyyy"));
                }
              stampDate=  stampDate.AddMonths(1);
            }


            return resultList;
        }

        public void FillData(DataTable dt, List<ADReportsInfo> dataList, List<string> monthList)
        {
            List<int> distinctEmployeeIDList = dataList.Select(t => t.EmployeeID).Distinct().ToList();

            ADReportsInfo defEmployee = new ADReportsInfo();
            int stt = 1;
            distinctEmployeeIDList.ForEach(id => {

                DataRow dr = dt.NewRow();

                defEmployee = dataList.FirstOrDefault(t => t.EmployeeID == id);
                dr["STT"] = stt++.ToString();
                dr["EmployeeID"] = defEmployee.EmployeeID;
                dr["EmployeeNo"] = defEmployee.EmployeeNo;
                dr["EmployeeName"] = defEmployee.EmployeeName;
                dr["EmployeeInsContractNo"] = defEmployee.EmployeeInsContractNo;

                string initAmount = defEmployee.InitIns.ToString("N0");
                string initType = (defEmployee.InitType == EmployeeSocialInsuranceType.Maternity.ToString())?defEmployee.InitType:string.Empty;
                if (initType == EmployeeSocialInsuranceType.Maternity.ToString())
                {
                    initAmount = "TS";
                }


                monthList.ForEach(month => {
                    defEmployee = dataList.FirstOrDefault(t => t.EmployeeID == id
                                                                && t.InsDate.ToString("MM/yyyy") == month);

                    if (defEmployee != null)
                    {
                        initAmount = (defEmployee.InsAmount == 0)?string.Empty:defEmployee.InsAmount.ToString("N0");
                        initType = defEmployee.InStatus;
                        if (initType == EmployeeSocialInsuranceType.Maternity.ToString())
                        {
                            initAmount = "TS";
                        }
                    }

                    dr[month + "_Amount"] = initAmount;
                    dr[month + "_Type"] = initType;

                    initType = (initType == EmployeeSocialInsuranceType.Maternity.ToString()) ? initType : string.Empty;

                    if (initType == EmployeeSocialInsuranceType.DecreaseLabor.ToString())
                    {
                        initType = string.Empty;
                        initAmount = string.Empty;
                    }
                });

                dt.Rows.Add(dr);
            });
        }

        public void ShowData()
        {
            DateTime fromMonth = fld_dteSearchFromDate.DateTime;
            DateTime toMonth = fld_dteSearchToDate.DateTime;
            ADReportsController reportController = new ADReportsController();
            List<ADReportsInfo> dataList = reportController.GetDataForReportSocialIns(fromMonth, toMonth);


            List<string> monthList = GetMonthStringList(fromMonth, toMonth);
            DataTable dt = CreateDataTable(monthList);

            FillData(dt, dataList, monthList);

            GridView gridView = (GridView)fld_dgcARNormFeeConfigItems.MainView;
            fld_dgcARNormFeeConfigItems.MainView = InitializeCustomerBandedGridView(gridView, monthList);


            fld_dgcARNormFeeConfigItems.DataSource = dt;
        }

        public void RefreshGridControl()
        {

            for (int i = ReportList.Count - 1; i >= 0; i--)
            {
                if (ReportList[i].ADReportType == "sumRow"
                    || ReportList[i].ADReportType == "sumCompanyRow"
                    || ReportList[i].ADReportType == "sumEmployeeRow"
                    || ReportList[i].ADReportType == "sumCERow")
                {
                    ReportList.RemoveAt(i);
                }
            }

            ADReportsInfo sumRow = new ADReportsInfo();
            sumRow.EmployeeName = "TỔNG CỘNG";
            sumRow.ADReportType = "sumRow";
            ReportList.Add(sumRow);

            ADReportsInfo sumCompanyRow = new ADReportsInfo();
            sumCompanyRow.EmployeeNo = "CÔNG TY";
            sumCompanyRow.ADReportType = "sumCompanyRow";
            ReportList.Add(sumCompanyRow);


            ADReportsInfo sumEmployeeRow = new ADReportsInfo();
            sumEmployeeRow.EmployeeNo = "NHÂN VIÊN";
            sumEmployeeRow.ADReportType = "sumEmployeeRow";
            ReportList.Add(sumEmployeeRow);

            ADReportsInfo sumCERow = new ADReportsInfo();
            sumCERow.EmployeeNo = "TỔNG CỘNG";
            sumCERow.ADReportType = "sumCERow";
            ReportList.Add(sumCERow);


          
           sumRow.EmployeeBasicSalary
                = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeBasicSalary);

           sumRow.EmployeeCompanyBHXH
               = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeCompanyBHXH);

           sumRow.EmployeeCompanyBHTLD
               = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeCompanyBHTLD);

           sumRow.EmployeeCompanyBHYT
               = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeCompanyBHYT);

           sumRow.EmployeeCompanyBHTN
              = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeCompanyBHTN);

           sumRow.EmployeeCompanyPayment
              = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeCompanyPayment);

           sumRow.EmployeeEmployeeBHXH
              = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeEmployeeBHXH);

           sumRow.EmployeeEmployeeBHYT
               = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeEmployeeBHYT);

           sumRow.EmployeeEmployeeBHTN
              = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeEmployeeBHTN);

           sumRow.EmployeeEmployeePayment
              = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeEmployeePayment);
           

           sumCompanyRow.EmployeeName
              = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeCompanyBHXH
                                                                        + t.EmployeeCompanyBHTLD
                                                                        + t.EmployeeCompanyBHYT
                                                                        + t.EmployeeCompanyBHTN
                                                                        + t.EmployeeCompanyBSBHXH).ToString("n0");

           sumEmployeeRow.EmployeeName
             = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeEmployeeBHXH
                                                                       + t.EmployeeEmployeeBHYT
                                                                       + t.EmployeeEmployeeBHTN
                                                                       + t.EmployeeEmployeeBSBHXH).ToString("n0");

           sumCERow.EmployeeName
             = ReportList.Where(t => t.FK_HREmployeeID > 0).Sum(t => t.EmployeeEmployeeBHXH
                                                                       + t.EmployeeEmployeeBHYT
                                                                       + t.EmployeeEmployeeBHTN
                                                                       + t.EmployeeEmployeeBSBHXH
                                                                       + t.EmployeeCompanyBHXH
                                                                        + t.EmployeeCompanyBHTLD
                                                                        + t.EmployeeCompanyBHYT
                                                                        + t.EmployeeCompanyBHTN
                                                                        + t.EmployeeCompanyBSBHXH).ToString("n0");


            fld_dgcARNormFeeConfigItems.RefreshDataSource();
        }

        public BandedGridView InitializeCustomerBandedGridView(GridView gridView, List<string> monthList)
        {


            BandedGridView bandedView = new BandedGridView();

            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowChildrenInGroupPanel = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;
            bandedView.OptionsView.ShowColumnHeaders = false;
            bandedView.OptionsView.AllowHtmlDrawHeaders = true;
            

            List<GridBand> GridBandList = new List<GridBand>();



            //1. Lot No
            GridBand sttBand = CreateGridBand("TỔNG HỢP DANH SÁCH THAM GIA BHXH", GridBandList);


            CreateBandedGridColumn("STT", "STT", sttBand, bandedView, 20, false);
            CreateBandedGridColumn("EmployeeNo", "MSNV", sttBand, bandedView, 100, false);
            CreateBandedGridColumn("EmployeeName", "HỌ VÀ TÊN", sttBand, bandedView, 150, false);
            CreateBandedGridColumn("EmployeeInsContractNo", "SỐ SỔ BẢO HIỂM", sttBand, bandedView, 150, false);

            monthList.ForEach(month => {
                CreateBandedGridColumn(month + "_Amount", month, sttBand, bandedView, 60, false);
            });
            

            

            bandedView.Bands.AddRange(GridBandList.ToArray());
            bandedView.RowCellStyle += new RowCellStyleEventHandler(bandedView_RowCellStyle);
            bandedView.KeyUp += new KeyEventHandler(bandedView_KeyUp);
            bandedView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(bandedView_CustomColumnDisplayText);
            bandedView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(bandedView_CellValueChanged);
            
            bandedView.BestFitColumns();
            return bandedView;
        }

        

        void bandedView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            BandedGridView view = (BandedGridView)fld_dgcARNormFeeConfigItems.MainView;
            if (view != null)
            {

                DataRow dr =view.GetDataRow(e.RowHandle);
                if (dr != null)
                {
                    if (e.Column.FieldName.Contains("_Amount"))
                    {
                        string[] strArr = e.Column.FieldName.Split('_');
                        if (dr[strArr[0] + "_Type"].ToString() == EmployeeSocialInsuranceType.IncreaseLabor.ToString())
                        {
                            e.Appearance.BackColor = Color.Yellow;
                            e.Appearance.BackColor2 = Color.Yellow;
                        }
                        else if (dr[strArr[0] + "_Type"].ToString() == EmployeeSocialInsuranceType.IncreaseRate.ToString())
                        {
                            e.Appearance.BackColor = Color.Blue;
                            e.Appearance.BackColor2 = Color.Blue;
                        }
                    }
                    
                }
            }
        }

        void bandedView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BandedGridView bandedView = (BandedGridView)sender;
                ADReportsInfo item = (ADReportsInfo)bandedView.GetFocusedRow();
                if (item != null && item.FK_HREmployeeID > 0)
                {
                    ReportList.Remove(item);
                    int stt = 1;
                    ReportList.ForEach(t => {
                        if (t.FK_HREmployeeID > 0)
                        {
                            t.STT = stt++.ToString();
                        }
                    });

                    RefreshGridControl();
                }
            }
        }

        void bandedView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            ADReportsInfo item = (ADReportsInfo)view.GetFocusedRow();
            if (item != null)
            {
                RefreshEmployeeInfo(item);
                RefreshGridControl();
            }
        }

        void bandedView_DoubleClick(object sender, EventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            view.BestFitColumns();
        }


        void bandedView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                double value = 0;
                if (double.TryParse(e.Value.ToString(), out value))
                {
                    if (value == 0)
                    {
                        e.DisplayText = string.Empty;
                    }
                }


                BandedGridView view = (BandedGridView)fld_dgcARNormFeeConfigItems.MainView;
                if (view != null)
                {

                    DataRow dr = view.GetDataRow(e.ListSourceRowIndex);
                    if (dr != null)
                    {
                        if (e.Column.FieldName.Contains("_Amount"))
                        {
                            string[] strArr = e.Column.FieldName.Split('_');
                            if (dr[strArr[0] + "_Type"].ToString() == EmployeeSocialInsuranceType.Maternity.ToString())
                            {
                                e.DisplayText = "TS";
                            }
                            else if (dr[strArr[0] + "_Type"].ToString() == EmployeeSocialInsuranceType.DecreaseLabor.ToString())
                            {
                                e.DisplayText = "-";
                            }
                        }

                    }
                }
            }
        }


        public GridBand CreateGridBand(string caption, List<GridBand> GridBandList)
        {
            GridBand gridBand = new GridBand();
            gridBand.Caption = caption;
            gridBand.Name = "";
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            gridBand.AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;
            
            GridBandList.Add(gridBand);
            return gridBand;
        }


        public GridBand CreateGridBand(string caption)
        {
            GridBand gridBand = new GridBand();
            gridBand.Caption = caption;
            gridBand.Name = "";
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            gridBand.AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;
            return gridBand;
        }


        public void CreateBandedGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, int minWidth, bool allowEdit)
        {
            GridBand companyBand = CreateGridBand(caption);
            ownerBand.Children.Add(companyBand);

            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = allowEdit;
            bandedLocation.OwnerBand = companyBand;
            bandedLocation.MinWidth = minWidth;
            bandedLocation.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            bandedLocation.OptionsColumn.ShowCaption = false;
            bandedView.Columns.Add(bandedLocation);

        }




        public void CreateBandedNumbericN0GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, bool allowEdit)
        {

            GridBand companyBand = CreateGridBand(caption);
            ownerBand.Children.Add(companyBand);

            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = allowEdit;
            bandedLocation.OwnerBand = companyBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n0}";
            RepositoryItemTextEdit edit = new RepositoryItemTextEdit();
            edit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            edit.Mask.EditMask = "n0";
            bandedLocation.ColumnEdit = edit;
            bandedLocation.OptionsColumn.ShowCaption = false;
            bandedLocation.MinWidth = 80;
            bandedView.Columns.Add(bandedLocation);

        }





      
        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    fld_dgcARNormFeeConfigItems.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void bosButton1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        public void RefreshEmployeeInfo(ADReportsInfo item)
        {
            item.EmployeeCompanyBHXH = item.EmployeeBasicSalary / 100 * 17;
            item.EmployeeCompanyBHTLD = item.EmployeeBasicSalary / 100 * (decimal)0.5;
            item.EmployeeCompanyBHYT = item.EmployeeBasicSalary / 100 * 3;
            item.EmployeeCompanyBHTN = item.EmployeeBasicSalary / 100 * 1;
            item.EmployeeCompanyPayment = item.EmployeeCompanyBHXH
                                        + item.EmployeeCompanyBHTLD
                                        + item.EmployeeCompanyBHYT
                                        + item.EmployeeCompanyBHTN
                                        + item.EmployeeCompanyBSBHXH;

            item.EmployeeEmployeeBHXH = item.EmployeeBasicSalary / 100 * 8;
            item.EmployeeEmployeeBHYT = item.EmployeeBasicSalary / 100 * (decimal)1.5;
            item.EmployeeEmployeeBHTN = item.EmployeeBasicSalary / 100 * 1;
            item.EmployeeEmployeePayment = item.EmployeeEmployeeBHXH
                                        + item.EmployeeEmployeeBHYT
                                        + item.EmployeeEmployeeBHTN
                                        + item.EmployeeEmployeeBSBHXH;

           

            
        }

    }

}
