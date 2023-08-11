using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSERP.Modules.Report;
using BOSERP.Utilities;
using Localization;
using DevExpress.XtraReports.UI;
using BOSReport;
using BOSLib;
using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.Utils;
using DevExpress.XtraGrid;
namespace BOSERP.Modules.Report
{
    public partial class RP244 : ReportForm
    {
        public DataTable vehicleDataTable;
        public DataSet dsCustomer;
        public List<ACSegmentsInfo> SegmentLists;

        public RP244()
        {
            InitializeComponent();
            SegmentLists = new List<ACSegmentsInfo>();
        }
        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
        private void RP233_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();

            BRBranchsInfo objBranchsInfo = new BRBranchsInfo();
            List<BRBranchsInfo> listBranch = new List<BRBranchsInfo>();
            listBranch.AddRange(BranchList);
            listBranch.Insert(0, objBranchsInfo);
            bosLookupEdit2.Properties.DataSource = listBranch;

            VMVehiclesController objVehiclesController = new VMVehiclesController();
            List<VMVehiclesInfo> vehiclesList = objVehiclesController.GetAllVehicleList();
            //List<int> branchIDs = BranchList.Select(o => o.BRBranchID).ToList();
            //vehiclesList = vehiclesList.Where(o => branchIDs.Contains(o.FK_BRBranchID)).ToList();
            vehiclesList.Insert(0, new VMVehiclesInfo());
            fld_lkeVehicleID.Properties.DataSource = vehiclesList;
        }       

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ShowReportData()
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int branchID = Convert.ToInt32(bosLookupEdit2.EditValue);
            int vehicleID = Convert.ToInt32(fld_lkeVehicleID.EditValue);
            string vehicleStatus = fld_VMVehicleStatus.EditValue != null ? fld_VMVehicleStatus.EditValue.ToString() : string.Empty;

            
            ADReportsController objReportsController = new ADReportsController();
            List<VMVehiclesInfo> list = objReportsController.GetRP244(dateFrom, dateTo, branchID, vehicleID, vehicleStatus);
            List<int> segmentList = list.Select(o => o.FK_ACSegmentID).Distinct().ToList();
            SegmentLists.Clear();
            ACSegmentsController objSegmentsController = new ACSegmentsController();
            segmentList.ForEach(o =>
                {
                    ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(o);
                    if (objSegmentsInfo != null)
                    {
                        if (objSegmentsInfo.ACSegmentNo == SegmentNo.Fuel)
                            objSegmentsInfo.Order = 0;
                        else if (objSegmentsInfo.ACSegmentNo == SegmentNo.OutsourcedServices)
                            objSegmentsInfo.Order = 1;
                        else
                            objSegmentsInfo.Order = 2;
                        SegmentLists.Add(objSegmentsInfo);
                    }
                });
            SegmentLists = SegmentLists.OrderBy(o => o.Order).ToList();
            fld_dgcReport233.MainView = GenerateBandedGridView();

            InitinvoiceDataRow(list);
            fld_dgcReport233.DataSource = vehicleDataTable;
            GridView gridView = (GridView)fld_dgcReport233.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
        }
        public BandedGridView GenerateBandedGridView()
        {
            
            BandedGridView banded = new BandedGridView();
            banded.OptionsCustomization.AllowFilter = false;
            banded.OptionsView.ColumnAutoWidth = false;
            banded.OptionsView.ShowGroupPanel = false;
            banded.OptionsView.ShowFooter = true;

            vehicleDataTable = new DataTable();

            #region Thông tin chung
            GridBand generalBand = new GridBand();
            generalBand.Caption = "Thông tin chung";
            banded.Bands.Add(generalBand);

            //STT
            CreateBandedColumn("STT", "STT", true, false, generalBand, banded, false);
            vehicleDataTable.Columns.Add("STT", typeof(string));

            //Mã xe
            CreateBandedColumn("Mã xe", "VMVehicleNo", true, false, generalBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleNo", typeof(string));

            //Tên xe
            CreateBandedColumn("Tên xe", "VMVehicleName", true, false, generalBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleName", typeof(string));

            //Biển số xe
            CreateBandedColumn("Biển số xe", "VMVehicleNoPlate", true, false, generalBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleNoPlate", typeof(string));

            generalBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            #endregion

            #region Thông tin chi tiết
            GridBand detailBand = new GridBand();
            detailBand.Caption = "Thông tin chi tiết";
            banded.Bands.Add(detailBand);

            //Phân loại xe
            CreateBandedColumn("Phân loại xe", "VMDeliveryPlanTruckType", true, false, detailBand, banded, false);
            vehicleDataTable.Columns.Add("VMDeliveryPlanTruckType", typeof(string));

            //Đời xe
            CreateBandedColumn("Đời xe", "VMVehicleCarLife", true, false, detailBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleCarLife", typeof(string));

            //Hiệu xe
            CreateBandedColumn("Hiệu xe", "VMVehicleCar", true, false, detailBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleCar", typeof(string));

            //Thuộc công ty
            CreateBandedColumn("Thuộc công ty", "VMVehicleCompanyName", true, false, detailBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleCompanyName", typeof(string));

            //Tình trạng xe
            CreateBandedColumn("Tình trạng xe", "VMVehicleStatus", true, false, detailBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleStatus", typeof(string));

            //Trọng tải xe(kg)
            CreateBandedColumnGroupN2("Trọng tải xe(kg)", "VMVehicleTruckLoad", true, false, detailBand, banded, false);
            vehicleDataTable.Columns.Add("VMVehicleTruckLoad", typeof(decimal));

            generalBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            #endregion

            #region KMCP

            GridBand segmentBand = new GridBand();
            segmentBand.Caption = "Khoản mục chi phí";
            banded.Bands.Add(segmentBand);

            //CreateBandedColumnQuantity("Số lượng chở thực tế", "RealQuantity", true, false, segmentBand, banded, false);
            //vehicleDataTable.Columns.Add("RealQuantity", typeof(decimal));

            SegmentLists.ForEach(o =>
                {
                    CreateBandedColumnAmount(o.ACSegmentName, o.ACSegmentNo, true, false, segmentBand, banded, false);
                    vehicleDataTable.Columns.Add(o.ACSegmentNo, typeof(decimal));
                });
            
            #endregion          
            return banded;
        }
        public void CreateBandedColumn(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool group)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            if (group)
            {
                column.Group();                    
            }
            banded.Columns.Add(column);
        }
        public void CreateBandedColumnAmount(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool group)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:n0}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n0}";
            banded.Columns.Add(column);
        }
        public void CreateBandedColumnQuantity(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool group)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:n0}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            banded.Columns.Add(column);
        }

        public void CreateBandedColumnGroupN2(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool group)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:n2}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            banded.Columns.Add(column);
        }
        public void InitinvoiceDataRow(List<VMVehiclesInfo> ListItem)
        {
            if (vehicleDataTable == null)
            {
                vehicleDataTable = new DataTable();
            }
            if (ListItem != null && ListItem.Count > 0)
            {
                List<VMVehiclesInfo> groupList = ListItem.GroupBy(a => new { a.VMVehicleNo, a.VMVehicleName, a.VMVehicleNoPlate, a.VMDeliveryPlanTruckType, a.VMVehicleCarLife, a.VMVehicleCar, a.VMVehicleCompanyName, a.VMVehicleStatus, a.VMVehicleTruckLoad, a.RealQuantity })
                                                        .Select(a => new VMVehiclesInfo
                                                        {
                                                            VMVehicleNo = a.Key.VMVehicleNo,
                                                            VMVehicleName = a.Key.VMVehicleName,
                                                            VMVehicleNoPlate = a.Key.VMVehicleNoPlate,
                                                            VMDeliveryPlanTruckType = a.Key.VMDeliveryPlanTruckType,
                                                            VMVehicleCarLife = a.Key.VMVehicleCarLife,
                                                            VMVehicleCar = a.Key.VMVehicleCar,
                                                            VMVehicleCompanyName = a.Key.VMVehicleCompanyName,
                                                            VMVehicleStatus = a.Key.VMVehicleStatus,
                                                            VMVehicleTruckLoad = a.Key.VMVehicleTruckLoad,
                                                            RealQuantity = a.Key.RealQuantity
                                                        }).ToList();
                int index = 1;
                groupList.ForEach(a =>
                    {
                        DataRow row = vehicleDataTable.NewRow();
                        row["STT"] = index++; ;
                        row["VMVehicleNo"] = a.VMVehicleNo;
                        row["VMVehicleName"] = a.VMVehicleName;
                        row["VMVehicleNoPlate"] = a.VMVehicleNoPlate;
                        row["VMDeliveryPlanTruckType"] = a.VMDeliveryPlanTruckType;
                        row["VMVehicleCarLife"] = a.VMVehicleCarLife;
                        row["VMVehicleCar"] = a.VMVehicleCar;
                        row["VMVehicleCompanyName"] = a.VMVehicleCompanyName;
                        row["VMVehicleStatus"] = a.VMVehicleStatus;
                        row["VMVehicleTruckLoad"] = a.VMVehicleTruckLoad;
                        row["RealQuantity"] = a.RealQuantity;
                            SegmentLists.ForEach(s =>
                            {
                                decimal amount = ListItem.Where(i => i.ACSegmentNo == s.ACSegmentNo
                                                                && a.VMVehicleNo == i.VMVehicleNo)
                                                         .Sum(i => i.SegmentAmount);
                                row[s.ACSegmentNo] = Math.Round(amount, 0);
                            });

                        vehicleDataTable.Rows.Add(row);
                    });
            }
        }
        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }
        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcReport233.MainView;
            if (gridView != null)
            {
                ExportToXls(gridView);
            }            
        }

        private void bosLookupEdit2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            bosLookupEdit2.EditValue = e.Value;
            LoadVehicleDataByBranchAndStatus();
        }

        private void fld_VMVehicleStatus_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            fld_VMVehicleStatus.EditValue = e.Value;
            LoadVehicleDataByBranchAndStatus();
            
        }

        private void LoadVehicleDataByBranchAndStatus()
        {
            int branchID = Convert.ToInt32(bosLookupEdit2.EditValue);
            string status = fld_VMVehicleStatus.EditValue != null ? fld_VMVehicleStatus.EditValue.ToString() : string.Empty;

            VMVehiclesController objVehiclesController = new VMVehiclesController();
            List<VMVehiclesInfo> vehiclesList = objVehiclesController.GetAllVehicleList();
            List<int> branchIDs = new List<int>();
            if (branchID == 0)
                branchIDs = BranchList.Select(o => o.BRBranchID).ToList();
            else
                branchIDs.Add(branchID);
            vehiclesList = vehiclesList.Where(o => (branchIDs.Contains(o.FK_BRBranchID) || o.FK_BRBranchID == 0)
                                                    && (o.VMVehicleStatus == status || string.IsNullOrEmpty(status))).ToList();
            vehiclesList.Insert(0, new VMVehiclesInfo());
            fld_lkeVehicleID.Properties.DataSource = vehiclesList;
        }
    }
}