using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BonusSales
{
    public partial class HRBonusSaleItemsGridControl : BOSGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }

        public override void InitGridControlDataSource()
        {
            BonusSalesEntities entity = (BonusSalesEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeBonusSaleList;
            DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            //Init banded view and make it the main view
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
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
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            gridBand1,
            gridBand2,
            gridBand3,
            gridBand4,
            gridBand5,
            gridBand6,
            gridBand7});
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedGridColumn(gridView.Columns[i], false)});
            }
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            //GridBand1
            gridBand1.Caption = "Thông tin nhân viên";
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.Name = "gridBand1";

            //GridBand2
            gridBand2.Caption = String.Empty;
            gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand2.Name = "gridBand2";

            //GridBand3
            gridBand3.Caption = "Phụ cấp";
            gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand3.Name = "gridBand3";

            //GridBand4
            gridBand4.Caption = String.Empty;
            gridBand4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand4.Name = "gridBand4";

            //GridBand5
            gridBand5.Caption = "Phân chia tiền thưởng , tập thể, cá nhân";
            gridBand5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand5.Name = "gridBand5";

            //GridBand6
            gridBand6.Caption = String.Empty;
            gridBand6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand6.Name = "gridBand6";

            //GridBand7
            gridBand7.Caption = String.Empty;
            gridBand7.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand7.Name = "gridBand7";

            // Assigning columns to bands
            GridColumn column;

            //Mã ID
            column = gridView.Columns["HRBonusSaleItemCardNumber"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            //Tên nhân viên
            //column = gridView.Columns["FK_HREmployeeID"];
            //if (column != null)
            //{
            //    CreateNewColumn(column, gridBand1, false);
            //}

            column = gridView.Columns["HREmployeeNo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            //column = gridView.Columns["HREmployeeName"];
            //if (column != null)
            //{
            //    BandedGridColumn bandedColumn = CreateNewColumn(column, gridBand1, false);
            //}

            //Ngày công
            column = gridView.Columns["HRBonusSaleItemWorkingQty"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand1, false);
            }

            //Mức Target
            column = gridView.Columns["HRBonusSaleItemTarget"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand1, false);
            }

            //DSBH chưa VAT
            column = gridView.Columns["HRBonusSaleItemDSBHNoVAT"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, false);
            }

            // Phát sinh chưa VAT
            column = gridView.Columns["HRBonusSaleItemVAT"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, false);
            }

            //Doanh số
            column = gridView.Columns["HRBonusSaleItemAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, false);
            }

            // TT
            column = gridView.Columns["HRBonusSaleItemAllowanceTT"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false);
            }

            //CN
            column = gridView.Columns["HRBonusSaleItemAllowanceCN"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, false);
            }

            //Tổng trả thưởng
            column = gridView.Columns["HRBonusSaleItemTotalAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, false);
            }

            //Mức thưởng
            column = gridView.Columns["HRBonusSaleItemLevelAllowance"];
            if (column != null)
            {
                CreateNumericColumnN2(column, gridBand4, false);
            }

            //Tiền thưởng doanh số
            column = gridView.Columns["HRBonusSaleItemAmountBonusSale"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, false);
            }

            //TT
            column = gridView.Columns["HRBonusSaleItemAmountBonusSaleTT"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, false);
            }

            //CN
            column = gridView.Columns["HRBonusSaleItemAmountBonusSaleCN"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, false);
            }

            // Phần trăm giữ lại
            column = gridView.Columns["HRBonusSaleItemPercentageRetained"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand6, true);
            }

            column = gridView.Columns["HRBonusSaleItemRetainedAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand6, true);
            }

            // Loại giữ lại
            //column = gridView.Columns["HRBonusSaleItemPercentageRetainedType"];
            //if (column != null)
            //{
            //    CreateNewColumn(column, gridBand6, true);
            //}

            //Doanh số tính QL
            column = gridView.Columns["HRBonusSaleItemManagementSalesAmount"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand7, false);
            }

            //Thưởng tháng
            //column = gridView.Columns["HRBonusSaleItemMonthlyBonus"];
            //if (column != null)
            //{
            //    CreateNumericColumn(column, gridBand7, false);
            //}

            // Thưởng đạt Target
            column = gridView.Columns["HRBonusSaleItemBonusReachTarget"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand7, true);
            }

            // Thưởng vượt Target
            column = gridView.Columns["HRBonusSaleItemBonusBeyondTarget"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand7, false);
            }

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
                    ((BonusSalesModule)Screen.Module).RemoveBonusSaleItemsList();
                }
            }
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

            BonusSalesEntities entity = (BonusSalesEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                HRBonusSaleItemsInfo objBonusSaleItemsInfo = (HRBonusSaleItemsInfo)bandedView.GetRow(bandedView.FocusedRowHandle);
                ((BonusSalesModule)Screen.Module).CalculatePayRollTotalAmounts(objBonusSaleItemsInfo);
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
        private BandedGridColumn CreateNumericColumn(GridColumn column, GridBand owner, bool allowEdit)
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
            rep.Mask.EditMask = "n0";
            rep.Mask.UseMaskAsDisplayFormat = true;
            bandedColumn.ColumnEdit = rep;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        private BandedGridColumn CreateNumericColumnN2(GridColumn column, GridBand owner, bool allowEdit)
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
            rep.Mask.EditMask = "n2";
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
