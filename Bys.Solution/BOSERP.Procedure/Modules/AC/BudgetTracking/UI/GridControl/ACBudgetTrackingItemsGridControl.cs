using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.BudgetTracking
{
    public class ACBudgetTrackingItemsGridControl : BOSComponent.BOSGridControl
    {
        public int RowHandle { get; set; }

        public override void InitGridControlDataSource()
        {
            BudgetTrackingEntities entity = (BudgetTrackingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BudgetTrackingItemsList;
            this.DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();

            //Init banded view and make it the main view
            BandedGridView bandedView = InitializeBandedGridView((GridView)MainView);
            bandedView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            ShowOnlyPredefinedDetails = true;
            UseEmbeddedNavigator = false;
        }
        public GridBand FormatGridBand(GridBand gridBand1, string strName, string strCaption)
        {
            gridBand1.Name = strName;
            gridBand1.Caption = strCaption;
            gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            return gridBand1;
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            e.DisplayText = e.RowHandle.ToString();
        }
        private BandedGridView InitializeBandedGridView(GridView gridView)
        {
            int gridBandNumber = 0;
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
            GridBand gridBand14 = new GridBand();
            GridBand gridBand15 = new GridBand();
            GridBand gridBand16 = new GridBand();

            GridBand gridBand17 = new GridBand();
            GridBand gridBand18 = new GridBand();
            GridBand gridBand19 = new GridBand();
            GridBand gridBand20 = new GridBand();
            GridBand gridBand21 = new GridBand();
            GridBand gridBand22 = new GridBand();
            GridBand gridBand23 = new GridBand();
            GridBand gridBand24 = new GridBand();
            GridBand gridBand25 = new GridBand();

            GridBand gridBand26 = new GridBand();
            GridBand gridBand27 = new GridBand();
            GridBand gridBand28 = new GridBand();
            GridBand gridBand29 = new GridBand();
            GridBand gridBand30 = new GridBand();
            GridBand gridBand31 = new GridBand();
            GridBand gridBand32 = new GridBand();
            GridBand gridBand33 = new GridBand();
            GridBand gridBand34 = new GridBand();

            GridBand gridBand35 = new GridBand();
            GridBand gridBand36 = new GridBand();
            GridBand gridBand37 = new GridBand();
            GridBand gridBand38 = new GridBand();
            GridBand gridBand39 = new GridBand();
            GridBand gridBand40 = new GridBand();
            GridBand gridBand41 = new GridBand();
            GridBand gridBand42 = new GridBand();
            GridBand gridBand43 = new GridBand();

            GridBand gridBand44 = new GridBand();
            GridBand gridBand45 = new GridBand();
            GridBand gridBand46 = new GridBand();
            GridBand gridBand47 = new GridBand();
            GridBand gridBand48 = new GridBand();
            GridBand gridBand49 = new GridBand();
            GridBand gridBand50 = new GridBand();
            GridBand gridBand51 = new GridBand();
            GridBand gridBand52 = new GridBand();

            GridBand gridBand53 = new GridBand();
            GridBand gridBand54 = new GridBand();
            GridBand gridBand55 = new GridBand();
            GridBand gridBand56 = new GridBand();
            GridBand gridBand57 = new GridBand();
            GridBand gridBand58 = new GridBand();
            GridBand gridBand59 = new GridBand();
            GridBand gridBand60 = new GridBand();
            GridBand gridBand61 = new GridBand();

            GridBand gridBand62 = new GridBand();
            GridBand gridBand63 = new GridBand();
            GridBand gridBand64 = new GridBand();
            GridBand gridBand65 = new GridBand();
            GridBand gridBand66 = new GridBand();
            GridBand gridBand67 = new GridBand();
            GridBand gridBand68 = new GridBand();
            GridBand gridBand69 = new GridBand();
            GridBand gridBand70 = new GridBand();

            GridBand gridBand71 = new GridBand();
            GridBand gridBand72 = new GridBand();
            GridBand gridBand73 = new GridBand();
            GridBand gridBand74 = new GridBand();
            GridBand gridBand75 = new GridBand();
            GridBand gridBand76 = new GridBand();
            GridBand gridBand77 = new GridBand();
            GridBand gridBand78 = new GridBand();
            GridBand gridBand79 = new GridBand();

            GridBand gridBand80 = new GridBand();
            GridBand gridBand81 = new GridBand();
            GridBand gridBand82 = new GridBand();
            GridBand gridBand83 = new GridBand();
            GridBand gridBand84 = new GridBand();
            GridBand gridBand85 = new GridBand();
            GridBand gridBand86 = new GridBand();
            GridBand gridBand87 = new GridBand();
            GridBand gridBand88 = new GridBand();

            GridBand gridBand89 = new GridBand();
            GridBand gridBand90 = new GridBand();
            GridBand gridBand91 = new GridBand();
            GridBand gridBand92 = new GridBand();
            GridBand gridBand93 = new GridBand();
            GridBand gridBand94 = new GridBand();
            GridBand gridBand95 = new GridBand();
            GridBand gridBand96 = new GridBand();
            GridBand gridBand97 = new GridBand();

            GridBand gridBand98 = new GridBand();
            GridBand gridBand99 = new GridBand();
            GridBand gridBand100 = new GridBand();
            GridBand gridBand101 = new GridBand();
            GridBand gridBand102 = new GridBand();
            GridBand gridBand103 = new GridBand();
            GridBand gridBand104 = new GridBand();
            GridBand gridBand105 = new GridBand();
            GridBand gridBand106 = new GridBand();

            GridBand gridBand107 = new GridBand();
            GridBand gridBand108 = new GridBand();
            GridBand gridBand109 = new GridBand();
            GridBand gridBand110 = new GridBand();
            GridBand gridBand111 = new GridBand();
            GridBand gridBand112 = new GridBand();
            GridBand gridBand113 = new GridBand();
            GridBand gridBand114 = new GridBand();
            GridBand gridBand115 = new GridBand();

            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
                gridBand1,
                gridBand2,
                gridBand3,
                gridBand4,

                gridBand24,
                gridBand33,
                gridBand42,
                gridBand51,
                gridBand60,
                gridBand69,
                gridBand78,
                gridBand87,
                gridBand96,
                gridBand105,
                gridBand114,

                gridBand13,
                gridBand14,
                gridBand15,
                gridBand16
            });
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            //GridBand1
            gridBand1 = FormatGridBand(gridBand1, "gridBand1", "STT");
            gridBand2 = FormatGridBand(gridBand2, "gridBand2", "Mã chỉ tiêu");
            gridBand3 = FormatGridBand(gridBand3, "gridBand3", "Tên chỉ tiêu");

            gridBand4 = FormatGridBand(gridBand4, "gridBand4", "Tháng 1");
            gridBand5 = FormatGridBand(gridBand5, "gridBand5", "Ngân sách");
            gridBand6 = FormatGridBand(gridBand6, "gridBand6", "Ban đầu");
            gridBand7 = FormatGridBand(gridBand7, "gridBand7", "Bổ sung");
            gridBand8 = FormatGridBand(gridBand8, "gridBand8", "Điều chỉnh");
            gridBand9 = FormatGridBand(gridBand9, "gridBand9", "Tổng cộng");
            gridBand10 = FormatGridBand(gridBand10, "gridBand10", "Thực hiện");
            gridBand11 = FormatGridBand(gridBand11, "gridBand11", "%");
            gridBand12 = FormatGridBand(gridBand12, "gridBand12", "Tốt/Xấu");

            gridBandNumber = 16;
            CreateGridBandPerMonth(ref gridBandNumber, 2, ref gridBand17, ref gridBand18, ref gridBand19, ref gridBand20, ref gridBand21, ref gridBand22, ref gridBand23, ref gridBand24, ref gridBand25);

            gridBandNumber = 25;
            CreateGridBandPerMonth(ref gridBandNumber, 3, ref gridBand26, ref gridBand27, ref gridBand28, ref gridBand29, ref gridBand30, ref gridBand31, ref gridBand32, ref gridBand33, ref gridBand34);

            gridBandNumber = 34;
            CreateGridBandPerMonth(ref gridBandNumber, 4, ref gridBand35, ref gridBand36, ref gridBand37, ref gridBand38, ref gridBand39, ref gridBand40, ref gridBand41, ref gridBand42, ref gridBand43);

            gridBandNumber = 43;
            CreateGridBandPerMonth(ref gridBandNumber, 5, ref gridBand44, ref gridBand45, ref gridBand46, ref gridBand47, ref gridBand48, ref gridBand49, ref gridBand50, ref gridBand51, ref gridBand52);

            gridBandNumber = 52;
            CreateGridBandPerMonth(ref gridBandNumber, 6, ref gridBand53, ref gridBand54, ref gridBand55, ref gridBand56, ref gridBand57, ref gridBand58, ref gridBand59, ref gridBand60, ref gridBand61);

            gridBandNumber = 61;
            CreateGridBandPerMonth(ref gridBandNumber, 7, ref gridBand62, ref gridBand63, ref gridBand64, ref gridBand65, ref gridBand66, ref gridBand67, ref gridBand68, ref gridBand69, ref gridBand70);

            gridBandNumber = 70;
            CreateGridBandPerMonth(ref gridBandNumber, 8, ref gridBand71, ref gridBand72, ref gridBand73, ref gridBand74, ref gridBand75, ref gridBand76, ref gridBand77, ref gridBand78, ref gridBand79);

            gridBandNumber = 79;
            CreateGridBandPerMonth(ref gridBandNumber, 9, ref gridBand80, ref gridBand81, ref gridBand82, ref gridBand83, ref gridBand84, ref gridBand85, ref gridBand86, ref gridBand87, ref gridBand88);

            gridBandNumber = 88;
            CreateGridBandPerMonth(ref gridBandNumber, 10, ref gridBand89, ref gridBand90, ref gridBand91, ref gridBand92, ref gridBand93, ref gridBand94, ref gridBand95, ref gridBand96, ref gridBand97);

            gridBandNumber = 97;
            CreateGridBandPerMonth(ref gridBandNumber, 11, ref gridBand98, ref gridBand99, ref gridBand100, ref gridBand101, ref gridBand102, ref gridBand103, ref gridBand104, ref gridBand105, ref gridBand106);

            gridBandNumber = 106;
            CreateGridBandPerMonth(ref gridBandNumber, 12, ref gridBand107, ref gridBand108, ref gridBand109, ref gridBand110, ref gridBand111, ref gridBand112, ref gridBand113, ref gridBand114, ref gridBand115);

            gridBand13 = FormatGridBand(gridBand13, "gridBand13", "Tổng ngân sách năm");
            gridBand14 = FormatGridBand(gridBand14, "gridBand14", "Tổng thực hiện lũy kế");
            gridBand15 = FormatGridBand(gridBand15, "gridBand15", "Số còn thực hiện");
            gridBand16 = FormatGridBand(gridBand16, "gridBand16", "% còn thực hiện");

            gridBand4.Children.Add(gridBand5);
            gridBand5.Children.Add(gridBand6);
            gridBand5.Children.Add(gridBand7);
            gridBand5.Children.Add(gridBand8);
            gridBand5.Children.Add(gridBand9);
            gridBand4.Children.Add(gridBand10);
            gridBand4.Children.Add(gridBand11);
            gridBand4.Children.Add(gridBand12);

            gridBand24.Children.Add(gridBand25);
            gridBand25.Children.Add(gridBand17);
            gridBand25.Children.Add(gridBand18);
            gridBand25.Children.Add(gridBand19);
            gridBand25.Children.Add(gridBand20);
            gridBand24.Children.Add(gridBand21);
            gridBand24.Children.Add(gridBand22);
            gridBand24.Children.Add(gridBand23);

            gridBand33.Children.Add(gridBand34);
            gridBand34.Children.Add(gridBand26);
            gridBand34.Children.Add(gridBand27);
            gridBand34.Children.Add(gridBand28);
            gridBand34.Children.Add(gridBand29);
            gridBand33.Children.Add(gridBand30);
            gridBand33.Children.Add(gridBand31);
            gridBand33.Children.Add(gridBand32);

            gridBand42.Children.Add(gridBand43);
            gridBand43.Children.Add(gridBand35);
            gridBand43.Children.Add(gridBand36);
            gridBand43.Children.Add(gridBand37);
            gridBand43.Children.Add(gridBand38);
            gridBand42.Children.Add(gridBand39);
            gridBand42.Children.Add(gridBand40);
            gridBand42.Children.Add(gridBand41);

            gridBand51.Children.Add(gridBand52);
            gridBand52.Children.Add(gridBand44);
            gridBand52.Children.Add(gridBand45);
            gridBand52.Children.Add(gridBand46);
            gridBand52.Children.Add(gridBand47);
            gridBand51.Children.Add(gridBand48);
            gridBand51.Children.Add(gridBand49);
            gridBand51.Children.Add(gridBand50);

            gridBand60.Children.Add(gridBand61);
            gridBand61.Children.Add(gridBand53);
            gridBand61.Children.Add(gridBand54);
            gridBand61.Children.Add(gridBand55);
            gridBand61.Children.Add(gridBand56);
            gridBand60.Children.Add(gridBand57);
            gridBand60.Children.Add(gridBand58);
            gridBand60.Children.Add(gridBand59);

            gridBand69.Children.Add(gridBand70);
            gridBand70.Children.Add(gridBand62);
            gridBand70.Children.Add(gridBand63);
            gridBand70.Children.Add(gridBand64);
            gridBand70.Children.Add(gridBand65);
            gridBand69.Children.Add(gridBand66);
            gridBand69.Children.Add(gridBand67);
            gridBand69.Children.Add(gridBand68);

            gridBand78.Children.Add(gridBand79);
            gridBand79.Children.Add(gridBand71);
            gridBand79.Children.Add(gridBand72);
            gridBand79.Children.Add(gridBand73);
            gridBand79.Children.Add(gridBand74);
            gridBand78.Children.Add(gridBand75);
            gridBand78.Children.Add(gridBand76);
            gridBand78.Children.Add(gridBand77);

            gridBand87.Children.Add(gridBand88);
            gridBand88.Children.Add(gridBand80);
            gridBand88.Children.Add(gridBand81);
            gridBand88.Children.Add(gridBand82);
            gridBand88.Children.Add(gridBand83);
            gridBand87.Children.Add(gridBand84);
            gridBand87.Children.Add(gridBand85);
            gridBand87.Children.Add(gridBand86);

            gridBand96.Children.Add(gridBand97);
            gridBand97.Children.Add(gridBand89);
            gridBand97.Children.Add(gridBand90);
            gridBand97.Children.Add(gridBand91);
            gridBand97.Children.Add(gridBand92);
            gridBand96.Children.Add(gridBand93);
            gridBand96.Children.Add(gridBand94);
            gridBand96.Children.Add(gridBand95);

            gridBand105.Children.Add(gridBand106);
            gridBand106.Children.Add(gridBand98);
            gridBand106.Children.Add(gridBand99);
            gridBand106.Children.Add(gridBand100);
            gridBand106.Children.Add(gridBand101);
            gridBand105.Children.Add(gridBand102);
            gridBand105.Children.Add(gridBand103);
            gridBand105.Children.Add(gridBand104);

            gridBand114.Children.Add(gridBand115);
            gridBand115.Children.Add(gridBand107);
            gridBand115.Children.Add(gridBand108);
            gridBand115.Children.Add(gridBand109);
            gridBand115.Children.Add(gridBand110);
            gridBand114.Children.Add(gridBand111);
            gridBand114.Children.Add(gridBand112);
            gridBand114.Children.Add(gridBand113);

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds;
            foreach (GridColumn column in gridView.Columns)
            {
                if (column != null && (column.FieldName == "ACBudgetTrackingItemOrderNumber"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand1;
                    InitColumnRepositoryText(bandedColumn, "");
                    bandedColumn.Width = 40;
                }
                if (column != null && (column.FieldName == "ACBudgetTrackingItemNo"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand2;
                    InitColumnRepositoryTextForString(bandedColumn, "");
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "ACBudgetTrackingItemName"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand3;
                    InitColumnRepositoryTextForString(bandedColumn, "");
                    bandedColumn.Width = 140;
                }

                CreateColumnPerMonth(column, "1", "A1", gridBand6, gridBand7, gridBand8, gridBand9, gridBand10, gridBand11, gridBand12);
                CreateColumnPerMonth(column, "2", "A2", gridBand17, gridBand18, gridBand19, gridBand20, gridBand21, gridBand22, gridBand23);
                CreateColumnPerMonth(column, "3", "A3", gridBand26, gridBand27, gridBand28, gridBand29, gridBand30, gridBand31, gridBand32);
                CreateColumnPerMonth(column, "4", "A4", gridBand35, gridBand36, gridBand37, gridBand38, gridBand39, gridBand40, gridBand41);
                CreateColumnPerMonth(column, "5", "A5", gridBand44, gridBand45, gridBand46, gridBand47, gridBand48, gridBand49, gridBand50);
                CreateColumnPerMonth(column, "6", "A6", gridBand53, gridBand54, gridBand55, gridBand56, gridBand57, gridBand58, gridBand59);
                CreateColumnPerMonth(column, "7", "A7", gridBand62, gridBand63, gridBand64, gridBand65, gridBand66, gridBand67, gridBand68);
                CreateColumnPerMonth(column, "8", "A8", gridBand71, gridBand72, gridBand73, gridBand74, gridBand75, gridBand76, gridBand77);
                CreateColumnPerMonth(column, "9", "A9", gridBand80, gridBand81, gridBand82, gridBand83, gridBand84, gridBand85, gridBand86);
                CreateColumnPerMonth(column, "10", "AA", gridBand89, gridBand90, gridBand91, gridBand92, gridBand93, gridBand94, gridBand95);
                CreateColumnPerMonth(column, "11", "AB", gridBand98, gridBand99, gridBand100, gridBand101, gridBand102, gridBand103, gridBand104);
                CreateColumnPerMonth(column, "12", "AC", gridBand107, gridBand108, gridBand109, gridBand110, gridBand111, gridBand112, gridBand113);

                if (column != null && (column.FieldName == "ACBudgetTrackingItemTotalBudgetAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand13;
                    InitColumnRepositoryText(bandedColumn, "n3");
                    bandedColumn.Width = 120;
                }
                if (column != null && (column.FieldName == "ACBudgetTrackingItemGeneralAccumulationAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand14;
                    InitColumnRepositoryText(bandedColumn, "n0");
                    bandedColumn.Width = 120;
                }
                if (column != null && (column.FieldName == "ACBudgetTrackingItemImplementingAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand15;
                    InitColumnRepositoryText(bandedColumn, "n0");
                    bandedColumn.Width = 120;
                }
                if (column != null && (column.FieldName == "ACBudgetTrackingItemImplementingPercent"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand16;
                    InitColumnRepositoryText(bandedColumn, "n0");
                    bandedColumn.Width = 120;
                }
            }

            bandedView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView1_CustomColumnDisplayText);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            return bandedView;
        }

        public void CreateGridBandPerMonth(ref int intGridBandNumber, int intMonth, ref GridBand gridBand17, ref GridBand gridBand18, ref GridBand gridBand19, ref GridBand gridBand20, ref GridBand gridBand21, ref GridBand gridBand22, ref GridBand gridBand23, ref GridBand gridBand24, ref GridBand gridBand25)
        {
            gridBand17 = FormatGridBand(gridBand17, "gridBand" + (++intGridBandNumber).ToString(), "Ban đầu");
            gridBand18 = FormatGridBand(gridBand18, "gridBand" + (++intGridBandNumber).ToString(), "Bổ sung");
            gridBand19 = FormatGridBand(gridBand19, "gridBand" + (++intGridBandNumber).ToString(), "Điều chỉnh");
            gridBand20 = FormatGridBand(gridBand20, "gridBand" + (++intGridBandNumber).ToString(), "Tổng cộng");
            gridBand21 = FormatGridBand(gridBand21, "gridBand" + (++intGridBandNumber).ToString(), "Thực hiện");
            gridBand22 = FormatGridBand(gridBand22, "gridBand" + (++intGridBandNumber).ToString(), "%");
            gridBand23 = FormatGridBand(gridBand23, "gridBand" + (++intGridBandNumber).ToString(), "Tốt/Xấu");
            gridBand24 = FormatGridBand(gridBand24, "gridBand" + (++intGridBandNumber).ToString(), "Tháng " + intMonth.ToString());
            gridBand25 = FormatGridBand(gridBand25, "gridBand" + (++intGridBandNumber).ToString(), "Ngân sách");
        }

        public void CreateColumnPerMonth(GridColumn column, string strColumnMonth, string preConfigValue, GridBand g1, GridBand g2, GridBand g3, GridBand g4, GridBand g5, GridBand g6, GridBand g7)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds;
            if (column != null && ((column.FieldName == "ACBudgetTrackingItemMonthEntryAmount" + strColumnMonth)))
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                bandedColumn.OwnerBand = g1;
                InitColumnRepositoryText(bandedColumn, "n3");
                bandedColumn.Width = 100;
            }
            if (column != null && ((column.FieldName == "ACBudgetTrackingItemMonthAdditionAmount" + strColumnMonth)))
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                bandedColumn.OwnerBand = g2;
                InitColumnRepositoryText(bandedColumn, "n3");
                bandedColumn.Width = 100;
            }
            if (column != null && ((column.FieldName == "ACBudgetTrackingItemMonthAdjustAmount" + strColumnMonth)))
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                bandedColumn.OwnerBand = g3;
                InitColumnRepositoryText(bandedColumn, "n3");
                bandedColumn.Width = 100;
            }
            if (column != null && ((column.FieldName == "ACBudgetTrackingItemMonthTotalAmount" + strColumnMonth)))
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                bandedColumn.OwnerBand = g4;
                InitColumnRepositoryText(bandedColumn, "n3");
                bandedColumn.Width = 100;
            }

            if (column != null && ((column.FieldName == "ACBudgetTrackingItemMonthPerformAmount" + strColumnMonth)))
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                bandedColumn.OwnerBand = g5;
                InitColumnRepositoryText(bandedColumn, "n3");
                bandedColumn.Width = 100;
            }
            if (column != null && ((column.FieldName == "ACBudgetTrackingItemMonthPercent" + strColumnMonth)))
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                bandedColumn.OwnerBand = g6;
                InitColumnRepositoryText(bandedColumn, "n3");
                bandedColumn.Width = 40;
            }
            if (column != null && (column.FieldName == preConfigValue + "BudgetTrackingItemEvaluateType"))
            {
                ds = objConfigValuesController.GetADConfigValuesByGroup("BudgetTrackingItemEvaluateType");
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                InitColumnRepository(bandedColumn, ds);
                bandedColumn.OwnerBand = g7;
                bandedColumn.Width = 60;
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.VisibleIndex != 0) return;
            if (e.ListSourceRowIndex < 0)
                return;
            else
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }
        private void BandedView_RowClick(object sender, RowClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
            }
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;
            if (e.Column.VisibleIndex != 1) return;
            e.DisplayText = e.RowHandle.ToString();

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
            return bandedColumn;
        }

        /// <summary>
        /// Init the repository lookup edit for a banded column
        /// </summary>        
        /// <param name="column">Banded column</param>
        /// <param name="dataSource">Data source of repository</param>
        public void InitColumnRepository(BandedGridColumn column, DataSet ds)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    if (objConfigValuesInfo != null)
                        configValuesList.Add(objConfigValuesInfo);
                }
            }
            objConfigValuesInfo = new ADConfigValuesInfo();
            configValuesList.Insert(0, objConfigValuesInfo);
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.DataSource = configValuesList;
            rep.DisplayMember = "ADConfigText";
            rep.ValueMember = "ADConfigKeyValue";
            rep.ShowHeader = false;
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.NullText = string.Empty;
            LookUpColumnInfo lookupColumn = new LookUpColumnInfo();
            lookupColumn.FieldName = "ADConfigText";
            rep.Columns.Add(lookupColumn);
            column.ColumnEdit = rep;
        }
        public void InitColumnRepositoryText(BandedGridColumn column, string fomatType)
        {

            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = fomatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:" + fomatType + "}";
            column.OptionsColumn.AllowEdit = true;
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
        public void InitColumnRepositoryTextForString(BandedGridColumn column, string fomatType)
        {
            column.OptionsColumn.AllowEdit = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }
    }
}
