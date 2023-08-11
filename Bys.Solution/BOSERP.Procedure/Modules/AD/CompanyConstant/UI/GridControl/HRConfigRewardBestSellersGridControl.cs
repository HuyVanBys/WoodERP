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

namespace BOSERP.Modules.CompanyConstant
{
    public partial class HRConfigRewardBestSellersGridControl : BOSGridControl
    {
        public int RowHandle { get; set; }
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ConfigRewardBestSellersList;
            this.DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView((GridView)MainView);
            bandedView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            ShowOnlyPredefinedDetails = true;
            UseEmbeddedNavigator = false;
            bandedView.KeyUp += new KeyEventHandler(GridView_KeyUp);
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

            gridBand3.Caption = "Doanh Số từ";
            gridBand3.Name = "gridBand4";
            gridBand5.Caption = "Mức phụ thuộc DS đạt";
            gridBand5.Name = "gridBand4";
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds;
            foreach (GridColumn column in gridView.Columns)
            {
                if (column != null && (column.FieldName == "HRBestSellerType"))
                {
                    ds = objConfigValuesController.GetADConfigValuesByGroup("BestSellerType");
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepository(bandedColumn, ds);
                    bandedColumn.OwnerBand = gridBand1;
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "HRConfigRewardBestSellerAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand2;
                    InitColumnRepositoryText(bandedColumn, "n3");
                    bandedColumn.Width = 80;
                }
                if (column != null && ((column.FieldName == "HRConfigRewardBestSellerSalesFrom")
                    || (column.FieldName == "HRConfigRewardBestSellerSalesTo")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand3;
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "HRConfigRewardBestSellerDependenceType"))
                {
                    ds = objConfigValuesController.GetADConfigValuesByGroup("ConfigRewardBestSellerDependenceType");
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepository(bandedColumn, ds);
                    bandedColumn.OwnerBand = gridBand4;
                    bandedColumn.Width = 80;
                }
                if (column != null && ((column.FieldName == "HRConfigRewardBestSellerDependenceSalesFrom")
                    || (column.FieldName == "HRConfigRewardBestSellerDependenceSalesTo")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand5;
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.Width = 80;
                }
                if (column != null && (column.FieldName == "HRConfigRewardBestSellerType"))
                {
                    ds = objConfigValuesController.GetADConfigValuesByGroup("ConfigRewardBestSellerType");
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepository(bandedColumn, ds);
                    bandedColumn.OwnerBand = gridBand6;
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
        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveConfigRewardBestSellers();
            }
        }
    }
}
