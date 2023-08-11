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

namespace BOSERP.Modules.ConfigSalesFormulaPayroll
{
    public class HRConfigSalesFormulaPayrollItemGridControl : BOSComponent.BOSGridControl
    {
        public int RowHandle { get; set; }

        public override void InitGridControlDataSource()
        {
            ConfigSalesFormulaPayrollEntities entity = (ConfigSalesFormulaPayrollEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ConfigSalesFormulaPayrollItemList;
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
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
                gridBand1,
                gridBand2,
                gridBand3,
                gridBand4,
                gridBand5,
                gridBand6});
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            //GridBand1
            gridBand1.Name = "gridBand1";
            gridBand2.Name = "gridBand2";
            gridBand3.Name = "gridBand3";

            gridBand4.Caption = "Điều kiện thưởng";
            gridBand4.Name = "gridBand4";
            gridBand5.Name = "gridBand5";
            gridBand6.Caption = "Mức DS phụ thuộc";
            gridBand6.Name = "gridBand4";
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds;
            foreach (GridColumn column in gridView.Columns)
            {
                if (column != null && ((column.FieldName == "HRConfigSalesFormulaPayrollItemSalesFrom")
                    || (column.FieldName == "HRConfigSalesFormulaPayrollItemSalesTo")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand4;
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.Width = 80;
                }
                if (column != null && ((column.FieldName == "HRConfigSalesFormulaPayrollItemDependenceSalesFrom")
                    || (column.FieldName == "HRConfigSalesFormulaPayrollItemDependenceSalesTo")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand6;
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "HRConfigSalesFormulaPayrollItemRewardAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand3;
                    InitColumnRepositoryText(bandedColumn, "n3");
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "HRConfigSalesFormulaPayrollItemRewardPercent"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand2;
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "HRConfigSalesFormulaPayrollItemDependenceType"))
                {
                    ds = objConfigValuesController.GetADConfigValuesByGroup("ConfigSalesFormulaPayrollItemDependenceType");
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepository(bandedColumn, ds);
                    bandedColumn.OwnerBand = gridBand5;
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "HRCircumstancesRewardType"))
                {
                    ds = objConfigValuesController.GetADConfigValuesByGroup("CircumstancesRewardType");
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepository(bandedColumn, ds);
                    bandedColumn.OwnerBand = gridBand1;
                    bandedColumn.Width = 80;
                }
            }

            bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            return bandedView;
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

        }

        //protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);

        //    GridColumn column = new GridColumn();

        //    for (int i = 1; i <= numDays; i++)
        //    {
        //        GridColumn columnDays = new GridColumn();
        //        columnDays.Caption = i.ToString();
        //        columnDays.FieldName = String.Format("{0}{1}", "HRLeaveDayDate", i.ToString());
        //        gridView.Columns.Add(columnDays);
        //    }

        //    column = new GridColumn();
        //    column.Caption = LeaveDayLocalizedResources.TotalLeaveDays;
        //    column.FieldName = "TotalLeaveDays";
        //    gridView.Columns.Add(column);
        //}

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
    }
}
