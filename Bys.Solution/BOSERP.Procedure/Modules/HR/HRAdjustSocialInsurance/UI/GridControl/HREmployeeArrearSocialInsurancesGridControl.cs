using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.HRAdjustSocialInsurance
{
    public partial class HREmployeeArrearSocialInsurancesGridControl : BOSGridControl
    {
        public GridView GridViewMain { get; set; }

        public override void InitGridControlDataSource()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeArrearSocialInsurancesList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        private string GetName(string name)
        {
            string re = "";
            List<int> list = new List<int>();
            for (int i = 0; i < name.Length; i++)
            {
                if ((Keys)name[i] == Keys.Space) list.Add(i);
            }
            if (list.Count >= 3)
            {
                re = name.Substring(0, list[list.Count / 2]).Trim() + Environment.NewLine + name.Substring(list[list.Count / 2]).Trim();
            }
            return re;
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
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedColumn(gridView.Columns[i], true)});
            }
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView2";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            bandedView.ColumnPanelRowHeight = 40;
            GridBand gridBand2 = new GridBand();
            BandedGridColumn col = null;
            GridBand gridBand1 = new GridBand();
            gridBand1.Caption = "Thông tin nhân viên";
            bandedView.Bands.Add(gridBand1);
            // Assigning columns to bands
            col = bandedView.Columns["FK_HREmployeeID"];
            col.Width = 150;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceNo"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceSalary"];
            col.Width = 100;
            gridBand1.Columns.Add(col);

            gridBand1 = new GridBand();
            gridBand1.Caption = "Thời gian truy thu";
            bandedView.Bands.Add(gridBand1);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceFromDate"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceToDate"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceTotalMonth"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);

            gridBand1 = new GridBand();
            gridBand1.Caption = "Tỷ lệ đóng";
            bandedView.Bands.Add(gridBand1);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceBHXHRate"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceBHTNRate"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceBHYTRate"];
            col.Width = 80;
            gridBand1.Columns.Add(col);

            gridBand1 = new GridBand();
            gridBand1.Caption = "Tiền lãi truy thu";
            bandedView.Bands.Add(gridBand1);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceNi"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceBHXHInterest"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceBHTNInterest"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceBHYTInterest"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceBHYTInterest"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceInterestTotal"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);


            gridBand1 = new GridBand();
            gridBand1.Caption = "";
            bandedView.Bands.Add(gridBand1);
            col = bandedView.Columns["HREmployeeArrearSocialInsuranceDesc"];
            col.Width = 200;
            gridBand1.Columns.Add(col);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            bandedView.ValidateRow += new ValidateRowEventHandler(bandedView_ValidateRow);
            return bandedView;
        }

        void bandedView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            HREmployeeArrearSocialInsurancesInfo obj = (HREmployeeArrearSocialInsurancesInfo)e.Row;
            ((HRAdjustSocialInsuranceModule)Screen.Module).CalcEmployeeArrearSocialInsurance(obj);
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

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            return gridView;
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
            bandedColumn.ColumnEdit = gridColumn.ColumnEdit;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Width = gridColumn.Width;
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

        protected void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRAdjustSocialInsuranceModule)Screen.Module).RemoveSelectedItemArrear();
            }
        }
    }
}
