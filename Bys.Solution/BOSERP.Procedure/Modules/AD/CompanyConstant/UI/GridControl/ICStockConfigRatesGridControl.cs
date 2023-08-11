using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICStockConfigRatesGridControl : BOSGridControl
    {
        private DataTable ProductTypeValueConfig { get; set; }

        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.StockConfigRateList;
            this.DataSource = bds;
        }

        private DataTable GetDataSourceProductType()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("ProductType");
            return ds.Tables[0];
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);

            foreach (GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;

            GridColumn column1 = gridView.Columns["ICStockConfigRateNo"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = false;
            }
            column1 = gridView.Columns["ICStockConfigRateProductType"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "Text";
                repositoryItemLookUpEdit.ValueMember = "Value";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("Text"));
                if (ProductTypeValueConfig == null)
                    ProductTypeValueConfig = GetDataSourceProductType();
                repositoryItemLookUpEdit.DataSource = ProductTypeValueConfig;
                repositoryItemLookUpEdit.CloseUp += new CloseUpEventHandler(repositoryItemLookUpEdit_CloseUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void repositoryItemLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            if (lke == null && lke.OldEditValue != e.Value)
                return;
            GridView gridView = MainView as GridView;
            ICStockConfigRatesInfo item = (ICStockConfigRatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;
            item.ICStockConfigRateProductType = e.Value == null ? string.Empty : e.Value.ToString();
            gridView.RefreshData();
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = MainView as GridView;
            CompanyConstantEntities entity = (CompanyConstantEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            ICStockConfigRatesInfo item = (ICStockConfigRatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;
            if (e.Column.FieldName == "FK_ICProductID")
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo == null)
                    objProductsInfo = new ICProductsInfo();
                item.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                item.ICStockConfigRateProductType = objProductsInfo.ICProductType;
                item.ICStockConfigRateProductDesc = objProductsInfo.ICProductDesc;
            }
            gridView.RefreshData();
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedStockConfigRates();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }
    }
}
