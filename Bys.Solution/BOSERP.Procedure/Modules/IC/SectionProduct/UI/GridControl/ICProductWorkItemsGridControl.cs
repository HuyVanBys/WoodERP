using System.Windows.Forms;

namespace BOSERP.Modules.WorkProduct
{
    public class ICProductWorkItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            WorkProductEntities entity = (WorkProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductWorkItemMaterialList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = SaleOrderLocalizedResources.ARSaleOrderItemRemainedQty;
            //column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //column.DisplayFormat.FormatString = "{0:n3}";
            //column.FieldName = "ARSaleOrderItemRemainedQty";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column); 

            //column = new GridColumn();
            //column.Caption = SaleOrderLocalizedResources.SOItemComponent;
            //column.FieldName = "ARSOItemComponent";
            //column.OptionsColumn.AllowEdit = true;

            //RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            //rpItemComponent.NullText = SaleOrderLocalizedResources.ItemComponentList;
            //rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            //column.ColumnEdit = rpItemComponent;

            //gridView.Columns.Add(column);
        }

        //private void RpItemComponent_Click(object sender, EventArgs e)
        //{
        //    ((SaleOrderModule)Screen.Module).ShowItemComponent();
        //}

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            //if (gridView.Columns["ARSaleOrderItemProductQty"] != null)
            //{
            //    gridView.Columns["ARSaleOrderItemProductQty"].OptionsColumn.AllowEdit = true;
            //    SetFormat("ARSaleOrderItemProductQty", "n3", gridView);
            //}
            //if (gridView.Columns["ARSaleOrderItemProductUnitPrice"] != null)
            //    gridView.Columns["ARSaleOrderItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ARSaleOrderItemDiscountAmount"] != null)
            //    gridView.Columns["ARSaleOrderItemDiscountAmount"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ARSaleOrderItemProductDiscount"] != null)
            //    gridView.Columns["ARSaleOrderItemProductDiscount"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ARSaleOrderItemProductDesc"] != null)
            //    gridView.Columns["ARSaleOrderItemProductDesc"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ARSaleOrderItemTaxAmount"] != null)
            //    gridView.Columns["ARSaleOrderItemTaxAmount"].OptionsColumn.AllowEdit = true;            
            //if (gridView.Columns["ARSaleOrderItemDeliveryDate"] != null)
            //    gridView.Columns["ARSaleOrderItemDeliveryDate"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ARSaleOrderItemDeliveryTime"] != null)
            //    gridView.Columns["ARSaleOrderItemDeliveryTime"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ARSaleOrderItemProductTaxPercent"] != null)
            //    gridView.Columns["ARSaleOrderItemProductTaxPercent"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ARSaleOrderItemProductUnitPrice2"] != null)
            //{
            //    gridView.Columns["ARSaleOrderItemProductUnitPrice2"].OptionsColumn.AllowEdit = true;
            //    SetFormat("ARSaleOrderItemProductQty", "n2", gridView);
            //}
            //if (gridView.Columns["ARSaleOrderItemDiscountAmount2"] != null)
            //{
            //    gridView.Columns["ARSaleOrderItemDiscountAmount2"].OptionsColumn.AllowEdit = false;
            //    SetFormat("ARSaleOrderItemProductQty", "n2", gridView);
            //}
            //if (gridView.Columns["FK_ICStockID"] != null)
            //{
            //    gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            //}
            //if (gridView.Columns["ARSaleOrderItemShippedQty"] != null)
            //{
            //    gridView.Columns["ARSaleOrderItemShippedQty"].OptionsColumn.AllowEdit = false;
            //    SetFormat("ARSaleOrderItemShippedQty", "n3", gridView);
            //}
            //if (gridView.Columns["ARSaleOrderItemCanceledQty"] != null)
            //{
            //    gridView.Columns["ARSaleOrderItemCanceledQty"].OptionsColumn.AllowEdit = false;
            //    SetFormat("ARSaleOrderItemCanceledQty", "n3", gridView);
            //}
            //GridColumn column = gridView.Columns["FK_ICProductAttributeQualityID"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    RepositoryItemLookUpEdit AttributeQualityIDLookUpEdit = new RepositoryItemLookUpEdit();
            //    AttributeQualityIDLookUpEdit.DisplayMember = "ICProductAttributeValue";
            //    AttributeQualityIDLookUpEdit.ValueMember = "ICProductAttributeID";
            //    AttributeQualityIDLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    AttributeQualityIDLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //    AttributeQualityIDLookUpEdit.NullText = string.Empty;
            //    AttributeQualityIDLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

            //    AttributeQualityIDLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(AttributeQualityIDLookUpEdit_QueryPopUp);
            //    column.ColumnEdit = AttributeQualityIDLookUpEdit;
            //}
            //column = gridView.Columns["ARSaleOrderItemProductSerialNo"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}

            //column = gridView.Columns["ARSaleOrderItemRemark"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
            //if (gridView.Columns["FK_ACAssetID"] != null)
            //{
            //    SetFormat("FK_ICProductEquipmentID", "n3", gridView);
            //}
            //column = gridView.Columns["FK_ACAssetID"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            //    repositoryItemLookUpEdit.DisplayMember = "ACAssetDesc";
            //    repositoryItemLookUpEdit.ValueMember = "ACAssetID";
            //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //    repositoryItemLookUpEdit.NullText = string.Empty;
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAssetNo", "Mã TS"));
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAssetDesc", "Mô tả"));
            //    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit1_QueryPopUp);
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.Caption = "TSCĐ";
            //    column.Visible = true;
            //}
            //column = gridView.Columns["FK_ICProductEquipmentID"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            //    repositoryItemLookUpEdit.DisplayMember = "ICProductDesc";
            //    repositoryItemLookUpEdit.ValueMember = "ICProductID";
            //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //    repositoryItemLookUpEdit.NullText = string.Empty;
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh"));
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
            //    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.Caption = "CCDC";
            //    column.Visible = true;
            //}
            return gridView;
        }
        //private void SetFormat(string col, string f, GridView gridView)
        //{
        //    if (gridView.Columns[col] != null)
        //    {
        //        gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
        //        gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
        //    }
        //}

        //protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    base.GridView_CellValueChanged(sender, e);

        //    SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
        //    ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)entity.MainObject;
        //    if (entity.ARSaleOrderItemsList.CurrentIndex >= 0)
        //    {
        //        ARSaleOrderItemsInfo item = entity.ARSaleOrderItemsList[entity.ARSaleOrderItemsList.CurrentIndex];

        //        ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
        //        int count = 0;
        //        count = objInvoiceItemsController.GetCountInvoiceBySaleOrderID(mainObject.ARSaleOrderID);
        //        if (e.Column.FieldName == "ARSaleOrderItemProductQty")
        //        {
        //            ((SaleOrderModule)Screen.Module).ChangeComponentItemQty();

        //        }

        //        //TKChinh [Add] [07/07/2016]

        //        if (count == 0 && mainObject.ARSaleOrderStatus == SaleOrderStatus.Confirmed.ToString())
        //        {
        //            if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice2")
        //            {
        //                entity.RoundByCurrency(item);
        //                item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
        //                entity.RoundByCurrency(item);
        //                if (mainObject.ARSaleOrderSaleType == SaleType.National.ToString())
        //                {
        //                    ((SaleOrderModule)Screen.Module).UpdatePriceForSaleType(mainObject.ARSaleOrderSaleType, item);
        //                    //((SaleOrderModule)Screen.Module).CheckPaymentTimeAmount();
        //                }
        //            }
        //            if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice")
        //            {
        //                ((SaleOrderModule)Screen.Module).CheckPaymentTimeAmount();

        //                if (mainObject.ARSaleOrderSaleType == SaleType.International.ToString())
        //                {
        //                    ((SaleOrderModule)Screen.Module).UpdatePriceForSaleType(mainObject.ARSaleOrderSaleType, item);
        //                    //((SaleOrderModule)Screen.Module).CheckPaymentTimeAmount();
        //                }
        //            }
        //            entity.ModuleObjects[TableName.ARSaleOrderItemsTableName] = (ARSaleOrderItemsInfo)item.Clone();
        //            (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
        //            //((SaleOrderModule)Screen.Module).CheckPaymentTimeAmount();
        //        }
        //        //TKChinh End
        //        else
        //        {
        //            if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice2")
        //            {
        //                entity.RoundByCurrency(item);
        //                item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;

        //                if (mainObject.ARSaleOrderSaleType == SaleType.National.ToString())
        //                {
        //                    ((SaleOrderModule)Screen.Module).UpdatePriceForSaleType(mainObject.ARSaleOrderSaleType);
        //                }
        //            }
        //            if (mainObject.ARSaleOrderSaleType == SaleType.International.ToString())
        //            {
        //                if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice")
        //                {
        //                    ((SaleOrderModule)Screen.Module).UpdatePriceForSaleType(mainObject.ARSaleOrderSaleType);
        //                }
        //            }
        //            entity.ModuleObjects[TableName.ARSaleOrderItemsTableName] = (ARSaleOrderItemsInfo)item.Clone();
        //            (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
        //            ((SaleOrderModule)Screen.Module).CheckPaymentTimeAmount();
        //        }
        //    }
        //}

        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
        //    }
        //}
        //void repositoryItemLookUpEdit1_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ACAssetsController objAssetsController = new ACAssetsController();
        //    List<ACAssetsInfo> objAssetsInfoList = objAssetsController.GetAssetsForLookupEditControl();
        //    if (objAssetsInfoList != null && objAssetsInfoList.Count > 0)
        //    {

        //        lookUpEdit.Properties.DataSource = objAssetsInfoList;

        //    }
        //}
        //void AttributeQualityIDLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());
        //    if (productAttributesList.Count > 0)
        //    {
        //        lookUpEdit.Properties.DataSource = productAttributesList;
        //    }
        //}
        //void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductsController objProductsController = new ICProductsController();
        //    List<ICProductsInfo> objProductsInfoList = objProductsController.GetEquipmentByProductType(ProductType.Equipment.ToString());
        //    if (objProductsInfoList != null && objProductsInfoList.Count > 0)
        //    {

        //        lookUpEdit.Properties.DataSource = objProductsInfoList;

        //    }
        //}
        //private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        //{
        //    if (e.Column.FieldName == "FK_ICProductEquipmentID")
        //    {
        //        if (e.Value != null)
        //        {
        //            int matchCodeID = int.Parse(e.Value.ToString());
        //            ICProductsController objProductsController = new ICProductsController();
        //            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(matchCodeID);
        //            if (objProductsInfo != null)
        //                e.DisplayText = objProductsInfo.ICProductDesc;
        //            else
        //                e.DisplayText = "";
        //        }
        //        else
        //            e.DisplayText = "";
        //    }
        //    if (e.Column.FieldName == "FK_ACAssetID")
        //    {
        //        if (e.Value != null)
        //        {
        //            int matchCodeID = int.Parse(e.Value.ToString());
        //            ACAssetsController objAssetsController = new ACAssetsController();
        //            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(matchCodeID);
        //            if (objAssetsInfo != null)
        //                e.DisplayText = objAssetsInfo.ACAssetDesc;
        //            else
        //                e.DisplayText = "";
        //        }
        //        else
        //            e.DisplayText = "";
        //    }
        //    if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
        //    {
        //        if (e.Value != null)
        //        {
        //            int matchCodeID = int.Parse(e.Value.ToString());
        //            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
        //            if (objProductAttributesInfo != null)
        //                e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
        //        }

        //    }
        //}

        //public void LoadGridViewEditPrice(bool IsEditPrice)
        //{
        //    GridView gridView = (GridView)MainView;
        //    if (IsEditPrice == true)
        //    {
        //        foreach (GridColumn columnedit in gridView.Columns)
        //        {
        //            columnedit.OptionsColumn.AllowEdit = false;
        //        }
        //        GridColumn column = gridView.Columns["ARSaleOrderItemProductUnitPrice"];
        //        if (column != null)
        //        {
        //            column.OptionsColumn.AllowEdit = true;
        //        }
        //        column = gridView.Columns["ARSaleOrderItemProductUnitPrice2"];
        //        if (column != null)
        //        {
        //            column.OptionsColumn.AllowEdit = true;
        //        }
        //    }
        //    else
        //    {
        //        if (gridView.Columns["ARSaleOrderItemProductQty"] != null)
        //        {
        //            gridView.Columns["ARSaleOrderItemProductQty"].OptionsColumn.AllowEdit = true;
        //            SetFormat("ARSaleOrderItemProductQty", "n3", gridView);
        //        }
        //        if (gridView.Columns["ARSaleOrderItemProductUnitPrice"] != null)
        //            gridView.Columns["ARSaleOrderItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemDiscountAmount"] != null)
        //            gridView.Columns["ARSaleOrderItemDiscountAmount"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemProductDiscount"] != null)
        //            gridView.Columns["ARSaleOrderItemProductDiscount"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemProductDesc"] != null)
        //            gridView.Columns["ARSaleOrderItemProductDesc"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemTaxAmount"] != null)
        //            gridView.Columns["ARSaleOrderItemTaxAmount"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemDeliveryDate"] != null)
        //            gridView.Columns["ARSaleOrderItemDeliveryDate"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemDeliveryTime"] != null)
        //            gridView.Columns["ARSaleOrderItemDeliveryTime"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemProductTaxPercent"] != null)
        //            gridView.Columns["ARSaleOrderItemProductTaxPercent"].OptionsColumn.AllowEdit = true;
        //        if (gridView.Columns["ARSaleOrderItemProductUnitPrice2"] != null)
        //        {
        //            gridView.Columns["ARSaleOrderItemProductUnitPrice2"].OptionsColumn.AllowEdit = true;
        //            SetFormat("ARSaleOrderItemProductQty", "n2", gridView);
        //        }
        //        if (gridView.Columns["ARSaleOrderItemDiscountAmount2"] != null)
        //        {
        //            gridView.Columns["ARSaleOrderItemDiscountAmount2"].OptionsColumn.AllowEdit = false;
        //            SetFormat("ARSaleOrderItemProductQty", "n2", gridView);
        //        }
        //        if (gridView.Columns["FK_ICStockID"] != null)
        //        {
        //            gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
        //        }
        //        if (gridView.Columns["ARSaleOrderItemShippedQty"] != null)
        //        {
        //            gridView.Columns["ARSaleOrderItemShippedQty"].OptionsColumn.AllowEdit = false;
        //            SetFormat("ARSaleOrderItemShippedQty", "n3", gridView);
        //        }
        //        if (gridView.Columns["ARSaleOrderItemCanceledQty"] != null)
        //        {
        //            gridView.Columns["ARSaleOrderItemCanceledQty"].OptionsColumn.AllowEdit = false;
        //            SetFormat("ARSaleOrderItemCanceledQty", "n3", gridView);
        //        }
        //        GridColumn column = gridView.Columns["FK_ICProductAttributeQualityID"];
        //        if (column != null)
        //        {
        //            column.OptionsColumn.AllowEdit = true;
        //        }
        //        column = gridView.Columns["ARSaleOrderItemProductSerialNo"];
        //        if (column != null)
        //        {
        //            column.OptionsColumn.AllowEdit = true;
        //        }

        //        column = gridView.Columns["ARSaleOrderItemRemark"];
        //        if (column != null)
        //        {
        //            column.OptionsColumn.AllowEdit = true;
        //        }
        //        if (gridView.Columns["FK_ACAssetID"] != null)
        //        {
        //            SetFormat("FK_ICProductEquipmentID", "n3", gridView);
        //        }
        //        column = gridView.Columns["FK_ACAssetID"];
        //        if (column != null)
        //        {
        //            column.OptionsColumn.AllowEdit = true;
        //        }
        //        column = gridView.Columns["FK_ICProductEquipmentID"];
        //        if (column != null)
        //        {
        //            column.OptionsColumn.AllowEdit = true;
        //        }
        //    }
        //}
    }
}
