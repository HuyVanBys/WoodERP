using BOSCommon.Constants;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ReturnShipping
{
    public partial class ReceiptItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ReturnShippingEntities entity = (ReturnShippingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ReturnShippingLocalizedResources.ReturnShippingProductQty;
            column.FieldName = "ICReceiptItemQty1";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Đơn giá";
            column.FieldName = "ICReceiptItemProductUnitPrice";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tổng tiền";
            column.FieldName = "ICReceiptItemTotalAmount";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CommonLocalizedResources.WoodQtyText;
            column.FieldName = "ICReceiptItemWoodQty";
            column.OptionsColumn.AllowEdit = true;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n5}";
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                gridView.Columns["ICReceiptItemProductQty"].Caption = ReturnShippingLocalizedResources.ReturnShippingProductQtyReturn;
                gridView.Columns["ICReceiptItemProductQty"].OptionsColumn.AllowEdit = true;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatString = "{0:n3}";
            }

            if (gridView.Columns["ICReceiptItemProductSerialNo"] != null)
                gridView.Columns["ICReceiptItemProductSerialNo"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemQty1"] != null)
            {
                gridView.Columns["ICReceiptItemQty1"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemQty1"].DisplayFormat.FormatString = "{0:n3}";
            }

            if (gridView.Columns["ICReceiptItemQty2"] != null)
            {
                gridView.Columns["ICReceiptItemQty2"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemQty2"].DisplayFormat.FormatString = "{0:n0}";
            }
            GridColumn column = gridView.Columns["FK_ICProductSerieID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit productSerie = new RepositoryItemLookUpEdit();
                productSerie.DisplayMember = "ICProductSerieNo";
                productSerie.ValueMember = "ICProductSerieID";
                productSerie.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                productSerie.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                productSerie.NullText = string.Empty;
                productSerie.Columns.Add(new LookUpColumnInfo("ICProductSerieNo"));
                productSerie.ShowHeader = false;
                productSerie.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductSerie_QueryPopUp);
                column.ColumnEdit = productSerie;
                column.Caption = ReturnShippingLocalizedResources.ProductSerialCaption;
            }
            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;

            column = gridView.Columns["ICReceiptItemIsAverageCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;

            }

            column = gridView.Columns["ICReceiptItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemReturnShippingType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICReplaceProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICSectionProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpSectionProductLookUpEdit = new RepositoryItemLookUpEdit();
                rpSectionProductLookUpEdit.DisplayMember = "ICProductName";
                rpSectionProductLookUpEdit.ValueMember = "ICProductID";
                rpSectionProductLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                rpSectionProductLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                rpSectionProductLookUpEdit.NullText = string.Empty;
                rpSectionProductLookUpEdit.DataSource = GetAllSectionProduct();
                rpSectionProductLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã hạng mục"));
                rpSectionProductLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên hạng mục"));
                rpSectionProductLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpSectionProduct_QueryPopUp);
                column.ColumnEdit = rpSectionProductLookUpEdit;
            }

            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = GetAllCostCenter();
                repositoryItemLookUpEdit.ValueMember = "ACCostCenterID";
                repositoryItemLookUpEdit.DisplayMember = "ACCostCenterName";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostCenterName", "TT Chi phí"));
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpCostCenter_QueryPopUp);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
            }
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);

            column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ICReceiptItemTotalCost"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }

            return gridView;
        }

        void ProductSerie_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (lookUpEdit == null)
                return;

            GridView gridview = MainView as GridView;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (item == null)
                return;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductSeriesInfo> productSeriesList = objProductSeriesController.GetSeriesByProductIDAndStockID(item.FK_ICProductID, item.FK_ICStockID, item.ICReceiptItemProductDesc, objReceiptsInfo.ICReceiptDate);
            productSeriesList.Insert(0, new ICProductSeriesInfo());
            lookUpEdit.Properties.DataSource = productSeriesList;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ACObjectAccessKey")
            {
                if (e.Value != null)
                {
                    string objectAccessKey = e.Value.ToString();
                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
                    objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                    if (objObjectsInfo != null)
                        e.DisplayText = objObjectsInfo.ACObjectName;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "FK_ICProductSerieID")
            {
                if (e.Value != null)
                {
                    int objectID = 0;
                    Int32.TryParse(e.Value.ToString(), out objectID);
                    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                    e.DisplayText = objProductSeriesController.GetObjectNoByID(objectID);
                }
                else
                    e.DisplayText = "";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ReturnShippingEntities entity = (ReturnShippingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];

                if (e.Column.FieldName == "ICReceiptItemProductQty")
                {
                    ((ReturnShippingModule)Screen.Module).CheckReturnShippingItemProductQtyReturn(item);
                }

                if (e.Column.FieldName == "FK_ICProductSerieID")
                {
                    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                    item.ICReceiptItemProductSerialNo = objProductSeriesController.GetObjectNoByID(item.FK_ICProductSerieID);
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((ReturnShippingModule)Screen.Module).ChangeItemMeasureUnit(item);
                }
                if (e.Column.FieldName == "ICReceiptItemProductSerialNo")
                {
                    ((ReturnShippingModule)Screen.Module).ChangeProductSerialNo(item);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ReturnShippingModule)Screen.Module).DeleteItemFromReturnShippingItemsList();
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICReceiptItemProductFactor")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
                        ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                        if (measureUnit != null && measureUnit.ICProductMeasureUnitIsEdit)
                            return;
                        e.ErrorText = "Hệ số không được phép thay đổi.";
                        e.Valid = false;
                    }
                }
            }
        }

        public List<ICProductsInfo> GetAllSectionProduct()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetAllSectionProduct();
            return productList;
        }

        private void rpSectionProduct_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                lookUpEdit.Properties.DataSource = GetAllSectionProduct();
            }
        }

        public List<ACCostCentersInfo> GetAllCostCenter()
        {
            ACCostCentersController objCostCentersController = new ACCostCentersController();
            List<ACCostCentersInfo> costCenterList = objCostCentersController.GetAllAliveAndActiveCostCenter();
            return costCenterList;
        }

        private void rpCostCenter_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                lookUpEdit.Properties.DataSource = GetAllCostCenter();
            }
        }
    }
}
