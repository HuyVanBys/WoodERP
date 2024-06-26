using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductCriteria
{
    public class ICProductCriteriaItemsGridControl : ItemGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductCriteriaEntities entity = (ProductCriteriaEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductCriteriaItemList;
            this.DataSource = bds;
        }

        public enum ProductCriteriaItemsColumnName
        {
            ICProductCriteriaItemPercent,
            ICProductCriteriaItemUnitPrice,
            ICProductCriteriaItemType,
            ICProductCriteriaItemIsIncrease,
            ICProductCriteriaItemsDiscountAmount
        }

        public enum ConfigValuesColumName
        {
            ADConfigKeyValue,
            ADConfigText
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ProductCriteriaItemType");
            if (ds != null)
                ConfigValueDataTable = ds.Tables[0];
            if (gridView.Columns[ProductCriteriaItemsColumnName.ICProductCriteriaItemType.ToString()] != null)
            {
                GridColumn column = gridView.Columns[ProductCriteriaItemsColumnName.ICProductCriteriaItemType.ToString()];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)ConfigValueDataTable;
                repositoryItemLookUpEdit.ValueMember = ConfigValuesColumName.ADConfigKeyValue.ToString();
                repositoryItemLookUpEdit.DisplayMember = ConfigValuesColumName.ADConfigText.ToString();
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = ConfigValuesColumName.ADConfigText.ToString();
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICProductCriteriaItemsDiscountAmount"] != null)
            {
                gridView.Columns["ICProductCriteriaItemsDiscountAmount"].OptionsColumn.AllowEdit = true;
            }
            new ProductCriteriaItemsColumnName[]
            {
                ProductCriteriaItemsColumnName.ICProductCriteriaItemPercent,
                ProductCriteriaItemsColumnName.ICProductCriteriaItemUnitPrice,
                ProductCriteriaItemsColumnName.ICProductCriteriaItemType,
                ProductCriteriaItemsColumnName.ICProductCriteriaItemIsIncrease,
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductCriteriaModule)Screen.Module).DeleteItemProductCriteriaItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            if (e.Column.FieldName == ProductCriteriaItemsColumnName.ICProductCriteriaItemPercent.ToString())
                ((ProductCriteriaModule)Screen.Module).ChangeCriteriaItemPercent();
            if (e.Column.FieldName == ProductCriteriaItemsColumnName.ICProductCriteriaItemIsIncrease.ToString())
                ((ProductCriteriaModule)Screen.Module).ChangeCriteriaItemIsIncrease();
            if (e.Column.FieldName == ProductCriteriaItemsColumnName.ICProductCriteriaItemUnitPrice.ToString())
                ((ProductCriteriaModule)Screen.Module).ChangeCriteriaItemUnitPrice();
            if (e.Column.FieldName == ProductCriteriaItemsColumnName.ICProductCriteriaItemsDiscountAmount.ToString())
                ((ProductCriteriaModule)Screen.Module).ChangeCriteriaItemDiscountAmount();
        }
    }
}
