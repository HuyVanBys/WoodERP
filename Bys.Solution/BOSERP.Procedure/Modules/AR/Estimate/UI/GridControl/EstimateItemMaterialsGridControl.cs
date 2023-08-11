using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Estimate
{
    public class EstimateItemMaterialsGridControl : ItemGridControl
    {
        private DataTable EstimateItemTypeDataTable { get; set; }

        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            EstimateEntities entity = (EstimateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EstimateItemMaterialsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            EstimateItemTypeDataTable = new DataTable();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("EstimateItemType");
            if (ds != null)
                EstimateItemTypeDataTable = ds.Tables[0];
            GridColumn column = new GridColumn();
            column.Visible = true;
            column.FieldName = "AREstimateItemType";
            column.Caption = "Loại hình thực hiện";
            column.OptionsColumn.ReadOnly = false;
            column.OptionsColumn.AllowEdit = true;
            column.OptionsColumn.FixedWidth = false;
            column.MinWidth = 100;
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = (object)EstimateItemTypeDataTable;
            repositoryItemLookUpEdit.ValueMember = "Value";
            repositoryItemLookUpEdit.DisplayMember = "Text";
            repositoryItemLookUpEdit.ShowHeader = false;
            repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
            LookUpColumnInfo columnInfo = new LookUpColumnInfo();
            columnInfo.FieldName = "Text";
            columnInfo.Width = 100;
            repositoryItemLookUpEdit.Columns.Add(columnInfo);
            repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
            this.RepositoryItems.Add(repositoryItemLookUpEdit);
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["AREstimateItemProductQty"] != null)
            {
                gridView.Columns["AREstimateItemProductQty"].OptionsColumn.AllowEdit = true;
                SetFormat("AREstimateItemProductQty", "n2", gridView);
            }

            if (gridView.Columns["AREstimateItemProductUnitPrice"] != null)
            {
                gridView.Columns["AREstimateItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
                SetFormat("AREstimateItemProductUnitPrice", "n0", gridView);
            }

            if (gridView.Columns["AREstimateItemTotalAmount"] != null)
            {
                gridView.Columns["AREstimateItemTotalAmount"].OptionsColumn.AllowEdit = false;
                SetFormat("AREstimateItemTotalAmount", "n0", gridView);
            }

            if (gridView.Columns["AREstimateItemTotalCost"] != null)
            {
                gridView.Columns["AREstimateItemTotalCost"].OptionsColumn.AllowEdit = false;
                SetFormat("AREstimateItemTotalCost", "n0", gridView);
            }

            if (gridView.Columns["FK_APSupplierID"] != null)
            {
                gridView.Columns["FK_APSupplierID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_ICMeasureUnitID"] != null)
            {
                gridView.Columns["FK_ICMeasureUnitID"].OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            if (e.Column.FieldName == "AREstimateItemProductQty"
                || e.Column.FieldName == "AREstimateItemProductUnitPrice")
                ((EstimateModule)Screen.Module).ChangeEstimateItemMaterialQty();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            //if (e.KeyCode == Keys.Delete)
            //{
            //    ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
            //}
        }


        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "FK_ICProductEquipmentID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ICProductsController objProductsController = new ICProductsController();
            //        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(matchCodeID);
            //        if (objProductsInfo != null)
            //            e.DisplayText = objProductsInfo.ICProductDesc;
            //        else
            //            e.DisplayText = "";
            //    }
            //    else
            //        e.DisplayText = "";
            //}
            //if (e.Column.FieldName == "FK_ACAssetID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ACAssetsController objAssetsController = new ACAssetsController();
            //        ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(matchCodeID);
            //        if (objAssetsInfo != null)
            //            e.DisplayText = objAssetsInfo.ACAssetDesc;
            //        else
            //            e.DisplayText = "";
            //    }
            //    else
            //        e.DisplayText = "";
            //}
            //if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            //        ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
            //        if (objProductAttributesInfo != null)
            //            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
            //    }

            //}
        }
    }
}
