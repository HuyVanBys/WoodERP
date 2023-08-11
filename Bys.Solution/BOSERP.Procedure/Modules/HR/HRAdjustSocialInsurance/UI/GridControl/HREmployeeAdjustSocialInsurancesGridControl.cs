using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.HRAdjustSocialInsurance
{
    public partial class HREmployeeAdjustSocialInsurancesGridControl : BOSGridControl
    {
        public GridView GridViewMain { get; set; }

        public override void InitGridControlDataSource()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeAdjustSocialInsurancesList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
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
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

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
            col = bandedView.Columns["HREmployeeSocialInsuranceType"];
            col.Width = 120;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceNo"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceLedger"];
            col.Width = 70;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceBirthday"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceGender"];
            col.OptionsColumn.AllowEdit = false;
            col.Width = 60;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["FK_HRLevelID"];
            col.Width = 80;
            col.OptionsColumn.AllowEdit = false;
            gridBand1.Columns.Add(col);

            gridBand1 = new GridBand();
            gridBand1.Caption = "Mức đóng cũ";
            bandedView.Bands.Add(gridBand1);
            gridBand2 = new GridBand();
            gridBand2.Caption = "";
            col = bandedView.Columns["HREmployeeSocialInsuranceOldSalaryAmount"];
            col.Width = 100;
            gridBand2.Columns.Add(col);
            gridBand1.Children.Add(gridBand2);
            gridBand2 = new GridBand();
            gridBand2.Caption = "Phụ cấp";
            col = bandedView.Columns["HREmployeeSocialInsuranceOldAllowance"];
            col.Width = 100;
            gridBand2.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceOldTNVK"];
            col.Width = 80;
            gridBand2.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceOldTNNghe"];
            col.Width = 80;
            gridBand2.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceOldTNKhac"];
            col.Width = 80;
            gridBand2.Columns.Add(col);
            gridBand1.Children.Add(gridBand2);

            gridBand1 = new GridBand();
            gridBand1.Caption = "Mức đóng mới";
            bandedView.Bands.Add(gridBand1);
            gridBand2 = new GridBand();
            gridBand2.Caption = "";
            col = bandedView.Columns["HREmployeeSocialInsuranceNewSalaryAmount"];
            col.Width = 100;
            gridBand2.Columns.Add(col);
            gridBand1.Children.Add(gridBand2);
            gridBand2 = new GridBand();
            gridBand2.Caption = "Phụ cấp";
            col = bandedView.Columns["HREmployeeSocialInsuranceNewAllowance"];
            col.Width = 100;
            gridBand2.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceNewTNVK"];
            col.Width = 80;
            gridBand2.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceNewTNNghe"];
            col.Width = 80;
            gridBand2.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceNewTNKhac"];
            col.Width = 80;
            gridBand2.Columns.Add(col);
            gridBand1.Children.Add(gridBand2);

            gridBand1 = new GridBand();
            gridBand1.Caption = "";
            bandedView.Bands.Add(gridBand1);
            col = bandedView.Columns["FK_HRLevelIDNew"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeAdjustSocialInsuranceFromDate"];
            col.Width = 80;
            RepositoryItemDateEdit date = (RepositoryItemDateEdit)col.ColumnEdit;
            date.Mask.EditMask = "MM/yyyy";
            date.Mask.UseMaskAsDisplayFormat = true;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeAdjustSocialInsuranceToDate"];
            col.Width = 80;
            date = (RepositoryItemDateEdit)col.ColumnEdit;
            date.Mask.EditMask = "MM/yyyy";
            date.Mask.UseMaskAsDisplayFormat = true;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsurancePercent"];
            col.Width = 80;
            gridBand1.Columns.Add(col);
            col = bandedView.Columns["HREmployeeSocialInsuranceRemark"];
            col.Width = 200;
            gridBand1.Columns.Add(col);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            return bandedView;
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
                ((HRAdjustSocialInsuranceModule)Screen.Module).RemoveSelectedItem();
            }
        }
    }
}
