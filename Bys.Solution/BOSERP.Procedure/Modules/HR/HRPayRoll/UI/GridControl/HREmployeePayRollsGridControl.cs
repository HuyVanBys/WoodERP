using BOSComponent;
using BOSLib;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRoll
{
    public partial class HREmployeePayRollsGridControl : BOSGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }

        public override void InitGridControlDataSource()
        {
            HRPayRollEntities entity = (HRPayRollEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeePayRollList;
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
            GridBand gridBand4 = new GridBand();
            GridBand gridBand5 = new GridBand();
            GridBand gridBand6 = new GridBand();
            GridBand gridBand7 = new GridBand();
            GridBand gridBand8 = new GridBand();
            GridBand gridBand9 = new GridBand();
            GridBand gridBand10 = new GridBand();
            GridBand gridBand11 = new GridBand();
            GridBand gridBand12 = new GridBand();
            GridBand gridBand13 = new GridBand();
            GridBand gridBand15 = new GridBand();
            GridBand gridBand16 = new GridBand();
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            gridBand1,
            gridBand2,
            gridBand8,
            gridBand9,
            gridBand11,
            gridBand12,
            gridBand15,
            gridBand13,
            gridBand3,
            gridBand4,
            gridBand7,
            gridBand5,
            gridBand16,
            gridBand10,
            gridBand6});
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedGridColumn(gridView.Columns[i], false)});
            }
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = true;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            bandedView.OptionsFilter.AllowFilterEditor = true;
            bandedView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            bandedView.OptionsView.ShowAutoFilterRow = true;
            bandedView.OptionsView.ShowFooter = true;

            //GridBand1
            gridBand1.Caption = "Thông tin nhân viên";
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.Name = "gridBand1";

            //GridBand2
            gridBand2.Caption = "Thông tin lương";
            gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand2.Name = "gridBand2";

            //GridBand3
            gridBand3.Caption = "Phụ cấp";
            gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand3.Name = "gridBand3";

            //GridBand4
            gridBand4.Caption = "Khen thưởng";
            gridBand4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand4.Name = "gridBand4";

            gridBand7.Caption = String.Empty;
            gridBand7.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand7.Name = "gridBand7";

            //GridBand5
            gridBand5.Caption = "Các khoản trừ";
            gridBand5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand5.Name = "gridBand5";

            //GridBand6
            gridBand6.Caption = "Không tính trong khoản thu nhập";
            gridBand6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand6.Name = "gridBand6";

            //GridBand8
            gridBand8.Caption = "Thưởng hiệu quả công việc";
            gridBand8.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand8.Name = "gridBand8";

            //GridBand9
            gridBand9.Caption = "Ngày công";
            gridBand9.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand9.Name = "gridBand9";

            //GridBand9
            gridBand10.Caption = String.Empty;
            gridBand10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand10.Name = "gridBand10";

            //gridBand11
            gridBand11.Caption = "Nghỉ hưởng lương";
            gridBand11.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand11.Name = "gridBand11";

            //gridBand12
            gridBand12.Caption = "Nghỉ không lương";
            gridBand12.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand12.Name = "gridBand12";

            //gridBand13
            gridBand13.Caption = "Lương tăng ca";
            gridBand13.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand13.Name = "gridBand13";

            //GridBand16
            gridBand10.Caption = String.Empty;
            gridBand10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand10.Name = "gridBand16";

            // Assigning columns to bands
            GridColumn column;

            //Thông tin nhân viên-------------------------------------------------
            column = gridView.Columns["HREmployeeNo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HRLevelNo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HREmployeeBankAccount1"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HRDepartmentName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HRDepartmentRoomName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HRDepartmentRoomGroupItemName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HRLevelName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }
            //------------------------------------------------------------------

            //Thông tin lương-----------------------------------------------------
            // Mức lương tổng
            column = gridView.Columns["HREmployeeWorkingSlrAmtFull"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, true, "n0", true);
            }

            //Lương cơ bản
            column = gridView.Columns["HREmployeeContractSlrAmt"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, true, "n0", true);
            }

            // Mức lương
            column = gridView.Columns["HREmployeePayRollWorkingSalary"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, true, "n0", true);
            }

            //Lương thử việc
            column = gridView.Columns["HREmployeePayRollProWorkingSalary"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, true, "n0", true);
            }

            //Thưởng doanh số
            column = gridView.Columns["HREmployeePayRollBonusSale"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, true, "n0", true);
            }

            //-------------------------------------------------------------------

            // Ngày công nhật
            column = gridView.Columns["HREmployeeRealDaysPerMonth"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand9, false, "n4", true);
            }

            // Ngày công đi ca 2
            column = gridView.Columns["HREmployeeRealNightsPerMonth"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand9, false, "n4", true);
            }

            // Ngày công qui định
            //column = gridView.Columns["HREmployeeDaysPerMonth"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand2, false);
            //}

            column = gridView.Columns["HREmployeePayrollNghiPhepNam"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand11, false, "n2", true);
            }
            column = gridView.Columns["HREmployeePayrollNghiLe"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand11, false, "n2", true);
            }
            column = gridView.Columns["HREmployeePayrollNghiCheDo"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand11, false, "n2", true);
            }
            //column = gridView.Columns["HREmployeePayrollNghiCupDien"];
            //if (column != null)
            //{
            //    CreateNewColumn(column, gridBand2, false);
            //}
            column = gridView.Columns["HREmployeePayrollNghiPhep"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand12, false, "n2", true);
            }
            column = gridView.Columns["HREmployeePayrollCtyChoNghi"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand11, false, "n2", true);
            }
            column = gridView.Columns["HREmployeePayrollNghiKPhep"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand12, false, "n2", true);
            }

            HROTFactorsController objOTFactorsController = new HROTFactorsController();
            List<HROTFactorsInfo> list = (List<HROTFactorsInfo>)objOTFactorsController.GetAllDistinctFactors();
            //HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            //List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            foreach (var item in list)
            {
                column = gridView.Columns[item.HROTFactorType.ToString() + item.HROTFactorValue.ToString()];
                if (column != null)
                {
                    column.AppearanceCell.Options.UseTextOptions = true;
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    string ot = "";
                    if (!string.IsNullOrEmpty(item.HROTFactorType))
                    {
                        ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                        ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("OTFactorType", item.HROTFactorType);
                        if (objConfigValuesInfo != null)
                        {
                            ot = objConfigValuesInfo.ADConfigText;
                        }
                    }
                    column.Caption = "TC " + ot + " hs " + item.HROTFactorValue.ToString();
                    CreateNumericColumn(column, gridBand15, false, "n4", false);
                }
            }

            //Hệ số tay nghề
            column = gridView.Columns["HREmployeePayRollSkillCoefficient"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, false, "n2", true);
            }

            //Hệ số tay nghề * tổng thời gian làm việc
            column = gridView.Columns["HREmployeePayRollSkillCoefficientAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, false, "n1", true);
            }

            //Lương/ CP hỗ trợ học nghề
            column = gridView.Columns["HREmployeePayRollTotalWorkingSalary"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, false, "n0", true);
            }

            //Thưởng doanh số
            column = gridView.Columns["HREmployeePayRollBonusSaleAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, false, "n0", true);
            }

            // Lương tăng ca
            foreach (var item in list)
            {
                column = gridView.Columns["Luong" + item.HROTFactorType.ToString() + item.HROTFactorValue.ToString()];
                if (column != null)
                {
                    column.AppearanceCell.Options.UseTextOptions = true;
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    string ot = "";
                    if (!string.IsNullOrEmpty(item.HROTFactorType))
                    {
                        ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                        ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("OTFactorType", item.HROTFactorType);
                        if (objConfigValuesInfo != null)
                        {
                            ot = objConfigValuesInfo.ADConfigText;
                        }
                    }
                    column.Caption = "Lương TC " + ot + " hs " + item.HROTFactorValue.ToString();
                    CreateNumericColumn(column, gridBand13, false, "n0", false);
                }
            }

            //------------------------------------------------------------

            //Thưởng hiệu quả công việc
            //Mức thưởng cụ thể
            column = gridView.Columns["HREmployeePayRollJobPerformanceAmt"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand8, false, "n0", true);
            }

            //Năng suất
            column = gridView.Columns["HREmployeePayRollProductivity"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand8, false, "n0", true);
            }

            //Chất lượng
            column = gridView.Columns["HREmployeePayRollQuality"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand8, false, "n0", true);
            }

            //Quản lý
            column = gridView.Columns["HREmployeePayRollManagement"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand8, false, "n0", true);
            }

            //Chính xác
            column = gridView.Columns["HREmployeePayRollExactly"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand8, false, "n0", true);
            }
            //-----------------------------------------------------------

            // Phụ cấp-------------------------------------------------
            //Hỗ trợ ĐT/Nhà ở VP/Xăng xe
            column = gridView.Columns["HREmployeePayRollFixedAllowance"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false, "n0", true);
            }

            //Nhà ở
            //column = gridView.Columns["HREmployeePayRollLodgingHouseAllowance"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand3, false);
            //}

            //Thâm niên
            column = gridView.Columns["HREmployeePayRollPerennialAllowance"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false, "n0", true);
            }

            //Nuôi con nhỏ
            column = gridView.Columns["HREmployeePayRollNuoiConNho"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false, "n0", true);
            }

            //Nặng nhọc/ độc hại
            column = gridView.Columns["HREmployeePayRollHeavyToxicAllowance"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false, "n0", true);
            }

            //Công tác phí
            column = gridView.Columns["HREmployeePayRollBonusDiLai"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false, "n0", true);
            }

            //Truy lãnh
            column = gridView.Columns["HREmployeePayRollTruyLanh"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false, "n0", true);
            }

            //Ốm đau thai sản
            //column = gridView.Columns["HREmployeePayRollMaternityAndSickLeaveAmount"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand3, true);
            //}

            //Hình thức khác
            column = gridView.Columns["HREmployeePayRollOtherAllowance"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, true, "n0", true);
            }
            //------------------------------------------------------------------------------------------------

            // Khen thưởng
            //Thưởng KPI
            //column = gridView.Columns["HREmployeePayRollThuongKPI"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand4, true);
            //}

            //Hiệu quả công việc
            //column = gridView.Columns["HREmployeePayRollEffectiveAllowance"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand4, true);
            //}

            //chuyên cần
            column = gridView.Columns["HREmployeePayRollDiligenceAllowance"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, true, "n0", true);
            }

            //Năng suất
            column = gridView.Columns["HREmployeePayRollAllowanceNangSuat"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, true, "n0", true);
            }

            //Thưởng khác
            column = gridView.Columns["HREmployeePayRollReward"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, true, "n0", true);
            }
            //---------------------------------------------------------------------------------------

            //-------------------------------------------------------------------------------------------
            column = gridView.Columns["HREmployeePayrollTongThuNhap"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand7, true, "n0", true);
            }
            //-------------------------------------------------------------------------------------------

            //Các khoản trừ--------------------------------------------------------------------------------
            // Tạm ứng
            column = gridView.Columns["HREmployeePayRollAdvance"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }

            // Kỷ luật
            column = gridView.Columns["HREmployeePayRollDiscipline"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }

            // BHXH
            column = gridView.Columns["HREmployeePayRollTotalInsAmt"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }

            column = gridView.Columns["HREmployeePayRollSyndicateFee"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }

            column = gridView.Columns["HREmployeePayrollPhiTheTu"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }
            column = gridView.Columns["HREmployeePayrollPhiTheATM"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }
            column = gridView.Columns["HREmployeePayrollPhiAo"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }
            column = gridView.Columns["HREmployeePayrollTruKhac"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }
            column = gridView.Columns["HREmployeePayrollTongCacKhoanTru"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, true, "n0", true);
            }
            //-----------------------------------------------------------------------------------------------

            //Tổng cộng--------------------------------------------------------------------------------------
            //Thu nhập chịu thuế sau khi trừ BHXH
            column = gridView.Columns["HREmployeePayRollThuNhapChiuThue"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand6, true, "n0", true);
            }

            //Số người phụ thuộc
            column = gridView.Columns["HREmployeePayRollSoNguoiPhuThuoc"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand6, true, "n0", true);
            }

            //THU NHẬP CHỊU THUẾ SAU KHI TRỪ NGƯỜI PHỤ THUỘC
            column = gridView.Columns["HREmployeePayrollTruThueTNCN"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand6, true, "n0", true);
            }

            //Thuế TNCN
            column = gridView.Columns["HREmployeePayRollIncomeTaxAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand6, true, "n0", true);
            }

            // Lương đã trừ

            //column = gridView.Columns["HREmployeeLuongDaTru"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand6, false);
            //}

            //Doanh số
            //column = gridView.Columns["HREmployeePayRollCommission"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand6, true);
            //}

            //Tiền cơm
            column = gridView.Columns["HREmployeePayRollMealAllowance"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand6, false, "n0", true);
            }

            //Lương thực nhận
            column = gridView.Columns["HREmployeePayRollTotalSalary"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand10, false, "n0", true);
            }

            //-----------------------------------------------------------------------------------------------
            //Tiền ốm đau thai sản
            column = gridView.Columns["HREmployeePayRollMaternityAndSickLeaveAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand16, false, "n0", true);
            }

            column = gridView.Columns["HREmployeePayRollComment"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = CreateNewColumn(column, gridBand6, true);
                bandedColumn.Width = 150;
            }
            //==========================================================================================

            bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            return bandedView;
        }

        private void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BandedGridView bandedView = (BandedGridView)MainView;
                if (bandedView.FocusedRowHandle >= 0)
                {
                    ((HRPayRollModule)Screen.Module).RemoveEmployeeFromPayRollList();
                }
            }
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

            HRPayRollEntities entity = (HRPayRollEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {

                HREmployeePayRollsInfo objEmployeePayRollsInfo = (HREmployeePayRollsInfo)bandedView.GetRow(bandedView.FocusedRowHandle);

                List<HRAllowanceConfigsInfo> listAllowanceConfig = ((HRPayRollModule)Screen.Module).GetAllowanceConfigList();
                List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();

                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)employeeController.GetObjectByID(objEmployeePayRollsInfo.FK_HREmployeeID);

                if (objEmployeesInfo != null)
                {
                    listAllowanceConfigEmployee = listAllowanceConfig.Where(t => t.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();
                }

                ((HRPayRollModule)Screen.Module).CalculatePayRollTotalAmounts(objEmployeePayRollsInfo, listAllowanceConfigEmployee);
            }
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;
            if (!bandedView.IsValidRowHandle(e.RowHandle))
                return;
            int parent = bandedView.GetParentRowHandle(e.RowHandle);
            if (bandedView.IsGroupRow(parent))
            {
                for (int i = 0; i < bandedView.GetChildRowCount(parent); i++)
                    if (bandedView.GetChildRowHandle(parent, i) == e.RowHandle)
                        e.Appearance.BackColor = i % 2 == 0 ? Color.White : Color.WhiteSmoke;
            }
            else e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.White : Color.WhiteSmoke;
            e.Appearance.ForeColor = Color.Black;
            int focusedRowHandle = e.RowHandle;
            if (focusedRowHandle >= 0)
            {
                HREmployeePayRollsInfo objEmployeePayRollsInfo = bandedView.GetRow(focusedRowHandle) as HREmployeePayRollsInfo;
                if (objEmployeePayRollsInfo != null && objEmployeePayRollsInfo.HREmployeePayrollDetailsList != null)
                {
                    foreach (var item in objEmployeePayRollsInfo.HREmployeePayrollDetailsList)
                    {
                        if (e.Column.FieldName == item.HREmployeeTimeSheetOTDetailName)
                        {
                            e.DisplayText = String.Format("{0:n2}", item.HREmployeePayrollHours);
                        }
                        if (e.Column.FieldName == ("Luong" + item.HREmployeeTimeSheetOTDetailName))
                        {
                            e.DisplayText = String.Format("{0:n2}", item.HREmployeePayrollSalaryFactor);
                        }
                    }
                }
            }
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
            column.Caption = "Mã nhân viên";
            column.FieldName = "HREmployeeNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên nhân viên";
            column.FieldName = "HREmployeeName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeeSalaryFactor;
            column.FieldName = "HREmployeeSalaryFactor";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lương cơ bản";
            column.FieldName = "HREmployeeContractSlrAmt";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeeWorkingSlrAmt;
            column.FieldName = "HREmployeeWorkingSlrAmt";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeePayRollTotalWorkingSalary;
            column.FieldName = "HREmployeePayRollTotalWorkingSalary";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeePayRollTotalAddAmt;
            column.FieldName = "HREmployeePayRollTotalAddAmt";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeePayRollTotalDeductedAmt;
            column.FieldName = "HREmployeePayRollTotalDeductedAmt";
            gridView.Columns.Add(column);

            HROTFactorsController objOTFactorsController = new HROTFactorsController();
            List<HROTFactorsInfo> list = (List<HROTFactorsInfo>)objOTFactorsController.GetAllDistinctFactors();
            //HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            //List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            foreach (var item in list)
            {
                column = new GridColumn();
                column.Caption = "TC hs " + item.HROTFactorValue.ToString();
                column.FieldName = item.HROTFactorType.ToString() + item.HROTFactorValue.ToString();
                column.Tag = item.HROTFactorType.ToString() + item.HROTFactorValue;
                gridView.Columns.Add(column);
            }
            foreach (var item in list)
            {
                column = new GridColumn();
                column.Caption = "Lương TC hs " + item.HROTFactorValue.ToString();
                column.FieldName = "Luong" + item.HROTFactorType.ToString() + item.HROTFactorValue.ToString();
                column.Tag = "Luong" + item.HROTFactorType.ToString() + item.HROTFactorValue;
                gridView.Columns.Add(column);
            }

            column = new GridColumn();
            column.Caption = "Mã chức vụ";
            column.FieldName = "HRLevelNo";
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Thưởng doanh số";
            //column.FieldName = "HREmployeePayRollBonusSale";
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Công tác phí";
            column.FieldName = "HREmployeePayRollBonusDiLai";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hỗ trợ con nhỏ";
            column.FieldName = "HREmployeePayRollNuoiConNho";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Truy lãnh";
            column.FieldName = "HREmployeePayRollTruyLanh";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thưởng KPI";
            column.FieldName = "HREmployeePayRollThuongKPI";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ốm đau, thai sản";
            column.FieldName = "HREmployeePayRollMaternityAndSickLeaveAmount";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thu nhập chịu thuế";
            column.FieldName = "HREmployeePayRollThuNhapChiuThue";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số người phụ thuộc";
            column.FieldName = "HREmployeePayRollSoNguoiPhuThuoc";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lương/ CP hỗ trợ học nghề";
            column.FieldName = "HREmployeePayRollTotalWorkingSalary";
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Thưởng doanh số";
            //column.FieldName = "HREmployeePayRollBonusSaleAmount";
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thưởng năng suất";
            column.FieldName = "HREmployeePayRollAllowanceNangSuat";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hỗ trợ ĐT/Nhà ở VP/Xăng xe";
            column.FieldName = "HREmployeePayRollFixedAllowance";
            gridView.Columns.Add(column);

        }

        /// <summary>
        /// Create a new banded column from a grid one
        /// </summary>
        /// <param name="column">Given grid column</param>
        /// <param name="owner">The grid band</param>
        /// <param name="allowEdit">A variable indicates whether the column is editable</param>
        /// <returns>The banded grid column</returns>
        private BandedGridColumn CreateNewColumn(GridColumn column, GridBand owner, bool allowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.Width = column.Width;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        /// <summary>
        /// Create a new banded column from a grid one in numeric format
        /// </summary>
        /// <param name="column">Given grid column</param>
        /// <param name="owner">The grid band</param>
        /// <param name="allowEdit">A variable indicates whether the column is editable</param>
        /// <returns>The banded grid column</returns>
        private BandedGridColumn CreateNumericColumn(GridColumn column, GridBand owner, bool allowEdit, string format, bool sumGroup)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.Width = 100;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.AppearanceCell.Options.UseTextOptions = true;
            bandedColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

            RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = format;
            rep.Mask.UseMaskAsDisplayFormat = true;

            if (sumGroup)
            {
                InitColumnSummary(bandedColumn, bandedColumn.FieldName, SummaryItemType.Sum, format);
            }

            bandedColumn.ColumnEdit = rep;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        private void InitColumnSummary(GridColumn column, string fieldName, SummaryItemType summaryType, string format)
        {
            if (column != null)
            {
                column.SummaryItem.FieldName = fieldName;
                column.SummaryItem.SummaryType = summaryType;
                column.SummaryItem.DisplayFormat = "{0:" + format + "}";
            }
        }

        private BandedGridColumn CreateNumericEditMaskColumn(GridColumn column, GridBand owner, bool allowEdit, string editMask)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.Width = 100;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = editMask;
            rep.Mask.UseMaskAsDisplayFormat = true;
            bandedColumn.ColumnEdit = rep;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        /// <summary>
        /// Convert a column to a banded column one
        /// </summary>
        /// <param name="gridColumn">Column of GridView</param>
        /// <param name="isAllowEdit">A variable indicates whether the column is editable</param>
        /// <returns>Banded grid column</returns>
        public BandedGridColumn ConvertToBandedGridColumn(GridColumn gridColumn, bool isAllowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = gridColumn.Name;
            bandedColumn.FieldName = gridColumn.FieldName;
            bandedColumn.Caption = gridColumn.Caption;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Visible = true;
            bandedColumn.Width = gridColumn.Width;
            return bandedColumn;
        }
    }
}
