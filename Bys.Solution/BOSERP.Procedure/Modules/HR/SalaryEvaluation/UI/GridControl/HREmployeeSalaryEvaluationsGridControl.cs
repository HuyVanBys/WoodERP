using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SalaryEvaluation
{
    public partial class HREmployeeSalaryEvaluationsGridControl : BOSGridControl
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
            SalaryEvaluationEntities entity = (SalaryEvaluationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeSalaryEvaluationList;
            DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridViewMain = gridView;
            return gridView;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            ShowOnlyPredefinedDetails = true;
        }

        private BandedGridView InitializeBandedGridView(GridView gridView)
        {
            //Creat a banded grid view
            BandedGridView bandedView = new BandedGridView();
            GridBand gridBand1 = new GridBand();
            GridBand gridBand2 = new GridBand();
            GridBand gridBand3 = new GridBand();
            GridBand gridBand4 = new GridBand();
            GridBand gridBand5 = new GridBand();
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            gridBand1,
            gridBand2,
            gridBand3,
            gridBand4,
            gridBand5});

            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ShowAutoFilterRow = true;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsCustomization.AllowSort = true;
            bandedView.OptionsView.ShowChildrenInGroupPanel = false;
            bandedView.OptionsView.ShowDetailButtons = false;

            //GridBand1
            gridBand1.Caption = SalaryEvaluationLocalizedResources.EmployeesInfo;
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.Name = "gridBand1";

            //GridBand2
            gridBand2.Caption = SalaryEvaluationLocalizedResources.SalaryBefore;
            gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand2.Name = "gridBand2";

            //GridBand3
            gridBand3.Caption = SalaryEvaluationLocalizedResources.SalaryAfter;
            gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand3.Name = "gridBand3";

            //GridBand4
            gridBand4.Caption = SalaryEvaluationLocalizedResources.SalaryIncrease;
            gridBand4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand4.Name = "gridBand4";

            //GridBand5
            gridBand5.Caption = SalaryEvaluationLocalizedResources.SalaryPercent;
            gridBand5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand5.Name = "gridBand5";

            // Assigning columns to bands
            GridColumn column = gridView.Columns["HREmployeeNo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }
            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HREmployeeStartWorkingDate"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HREmployeeSeniorityYear"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationIncurredDate"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationSlrAmtBefore"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, false, "n0");
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationWorkingSlrAmtBefore"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand2, false, "n0");
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationSlrAmtAfter"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, true, "n0");
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationWorkingSlrAmtAfter"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand3, true, "n0");
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationSlrAmtIncrease"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, false, "n0");
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationWorkingSlrAmtIncrease"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, false, "n0");
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationSlrAmtPercent"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, false, "n2");
            }

            column = gridView.Columns["HREmployeeSalaryEvaluationWorkingSlrAmtPercent"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand5, false, "n2");
            }

            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            return bandedView;
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;
            if (!bandedView.IsValidRowHandle(e.RowHandle))
                return;
            int focusedRowHandle = e.RowHandle;
            if (focusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "HREmployeeSalaryEvaluationIncurredDate")
                {
                    HREmployeeSalaryEvaluationsInfo objEmployeeSalaryEvaluationsInfo = bandedView.GetRow(focusedRowHandle) as HREmployeeSalaryEvaluationsInfo;
                    if (objEmployeeSalaryEvaluationsInfo != null)
                    {
                        if (objEmployeeSalaryEvaluationsInfo.HREmployeeSalaryEvaluationIncurredDate.Date == DateTime.MaxValue.Date)
                        {
                            e.DisplayText = string.Empty;
                        }
                    }
                }
            }
        }

        private void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((SalaryEvaluationModule)Screen.Module).RemoveEmployeeFromTimeSheetList();
            }
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
                HREmployeeSalaryEvaluationsInfo objEmployeeSalaryEvaluationsInfo = (HREmployeeSalaryEvaluationsInfo)gridView.GetRow(e.RowHandle);
                //Update time sheet total quantity
                if ((e.Column.FieldName == "HREmployeeSalaryEvaluationSlrAmtAfter" || e.Column.FieldName == "HREmployeeSalaryEvaluationWorkingSlrAmtAfter")
                    && objEmployeeSalaryEvaluationsInfo != null)
                {
                    ((SalaryEvaluationModule)Screen.Module).ChangeEmployeeSalaryEvaluationAfter(objEmployeeSalaryEvaluationsInfo);

                }
            }
        }

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

        private BandedGridColumn CreateNewColumn(GridColumn column, GridBand owner, bool allowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            //bandedColumn.Width = column.Width;
            bandedColumn.Width = 100;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = SalaryEvaluationLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SalaryEvaluationLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SalaryEvaluationLocalizedResources.HREmployeeStartDate;
            column.FieldName = "HREmployeeStartWorkingDate";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SalaryEvaluationLocalizedResources.HREmployeeSeniorityYear;
            column.FieldName = "HREmployeeSeniorityYear";
            gridView.Columns.Add(column);
        }

        private BandedGridColumn CreateNumericColumn(GridColumn column, GridBand owner, bool allowEdit, string formatType)
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
            rep.Mask.EditMask = formatType.ToString();
            rep.Mask.UseMaskAsDisplayFormat = true;
            bandedColumn.ColumnEdit = rep;
            bandedColumn.OwnerBand = owner;

            return bandedColumn;
        }
    }
}
