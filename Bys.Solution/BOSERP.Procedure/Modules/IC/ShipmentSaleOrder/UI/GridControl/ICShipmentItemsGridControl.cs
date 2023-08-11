using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Enums;
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
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public class ICShipmentItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);


            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.ItemCopyNewRow;
            column.FieldName = "ICShipmentItemCopyItem";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemAddNewRow = new RepositoryItemHyperLinkEdit();
            rpItemAddNewRow.NullText = SaleOrderLocalizedResources.ItemCopyNewRow;
            rpItemAddNewRow.Click += new EventHandler(rpItemAddNewRow_Click);
            column.ColumnEdit = rpItemAddNewRow;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hạng mục";
            column.FieldName = "ARProposalTemplateItemProductName";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemButtonEdit repoItemBtnEdit = new RepositoryItemButtonEdit();
            repoItemBtnEdit.AllowMouseWheel = false;
            repoItemBtnEdit.AutoHeight = false;
            repoItemBtnEdit.Name = "ARProposalTemplateItemProductName";
            repoItemBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repoItemBtnEdit.ButtonClick += RepoItemBtnEdit_ButtonClick;
            column.ColumnEdit = repoItemBtnEdit;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Nhập kiện";
            column.FieldName = "AddPackage";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "Nhập kiện";
            rpItemComponent.Click += new EventHandler(RpItemAddPackage_Click);
            column.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CommonLocalizedResources.WoodQtyText;
            column.FieldName = "ICShipmentItemWoodQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thành phần";
            column.FieldName = "ICShipmentItemComponents";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit repoItemHyperLinkEdit = new RepositoryItemHyperLinkEdit();
            repoItemHyperLinkEdit.Click += new System.EventHandler(RepoItemHyperLinkEdit_ButtonClick);
            repoItemHyperLinkEdit.NullText = "Xác định thành phần";
            column.ColumnEdit = repoItemHyperLinkEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số thùng";
            column.FieldName = "ICShipmentItemQuantityOfBox";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemSOName";
            column.Caption = "Mã đơn hàng nội bộ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemCode10Combo";
            column.Caption = "Lệnh sản xuất";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        private void RpItemAddPackage_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo obj = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                string mess = string.Empty;
                if (obj != null)
                {
                    obj.IsError = false;
                    ((ShipmentSaleOrderModule)Screen.Module).ShowGuiPackage(null, obj);
                }
            }

        }
        private void RepoItemBtnEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ((ShipmentSaleOrderModule)Screen.Module).ShowTemplateItemTree();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //column.DisplayFormat.FormatString = "{0:n3}";
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.Caption = CommonLocalizedResources.SerialNoText;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemLotNo"];
            if (column != null)
            {
                column.Caption = CommonLocalizedResources.LotNoText;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICShipmentItemHasProductPackage"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICShipmentItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();

                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                List<ICMeasureUnitsInfo> measureUnits = controller.GetAllAliveMeasureUnit();
                rpMeasureUnit.DataSource = measureUnits;
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;
            }

            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);

            if (gridView.Columns["ICShipmentItemOneLevelArea"] != null)
                gridView.Columns["ICShipmentItemOneLevelArea"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["ICShipmentItemTwoLevelArea"] != null)
                gridView.Columns["ICShipmentItemTwoLevelArea"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["ICShipmentItemThreeLevelArea"] != null)
                gridView.Columns["ICShipmentItemThreeLevelArea"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["FK_ICSectionProductID"] != null)
            {
                column = gridView.Columns["FK_ICSectionProductID"];
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = GetAllSectionProduct();
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã hạng mục"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên hạng mục"));
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpSectionProduct_QueryPopUp);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
            }
            column = gridView.Columns["ICShipmentItemContainerNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemContainerSealNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemTractorTrailerNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemShipNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemETDDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemTotalAmount"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }    
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                ICShipmentItemsInfo obj = (ICShipmentItemsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "AddPackage" && obj != null && obj.IsError)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
                }
            }
        }
        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ShipmentSaleOrderModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null) item.IsError = false;
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                if (e.Column.FieldName == "ICShipmentItemProductQty")
                {
                    entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductExchangeQty = entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductFactor * entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductQty;
                    decimal tolenrancePlus = 0;
                    ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
                    ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                    ICProductTolenrancesController objProductTolerancesController = new ICProductTolenrancesController();
                    ICProductTolenrancesInfo objProductTolenrancesInfo = objProductTolerancesController.GetProductTolenranceByIDAndType(item.FK_ICProductID, ProductTolenranceType.Sale.ToString());
                    int shipmentItemID = item.Id;
                    if(shipmentItemID == 0)
                    {
                        ICShipmentItemsInfo validateItem = entity.ShipmentItemList.Where(o => o.Id > 0 && o.FK_ARDeliveryPlanItemID == item.FK_ARDeliveryPlanItemID).FirstOrDefault();
                        if (validateItem != null)
                        {
                            shipmentItemID = validateItem.Id;
                        }    
                    }    
                    ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = objDeliveryPlanItemsController.GetRemainDeliveryPlanItemQtyByShipmentItemID(item.FK_ICShipmentID, item.FK_ARDeliveryPlanItemID);
                    if (objDeliveryPlanItemsInfo != null)
                    {
                        decimal productRemainQty = ((ShipmentSaleOrderModule)Screen.Module).GetShipmentQtyIsValidFromConfig(objDeliveryPlanItemsInfo);
                        decimal shipmentItemProductQty = entity.ShipmentItemList.Where(o => o.FK_ARDeliveryPlanItemID == item.FK_ARDeliveryPlanItemID).Sum(o => o.ICShipmentItemProductQty);

                        if (objProductTolenrancesInfo.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Percent.ToString())
                            tolenrancePlus = productRemainQty * objProductTolenrancesInfo.ICProductTolenrancePlus / 100;
                        else if (objProductTolenrancesInfo.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Quantity.ToString())
                            tolenrancePlus = objProductTolenrancesInfo.ICProductTolenrancePlus;
                        if (shipmentItemProductQty > productRemainQty + tolenrancePlus)
                        {
                            MessageBox.Show(String.Format(ShipmentSaleOrderLocalizedResources.QtyMax, (productRemainQty - (shipmentItemProductQty - item.ICShipmentItemProductQty) + tolenrancePlus).ToString("n3")),
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            try
                            {
                                entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductQty = Convert.ToDecimal(gridView.ActiveEditor.OldEditValue.ToString());
                                entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductExchangeQty = entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductFactor * entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductQty;
                                entity.SetProductCostByProductUnitCost(entity.ShipmentItemList[gridView.FocusedRowHandle]);
                            }
                            catch (Exception) { }
                        }
                        try
                        {
                            entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductBasicQty = Math.Min(objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemCancelQty + tolenrancePlus, item.ICShipmentItemProductQty);
                            entity.SetProductCostByProductUnitCost(entity.ShipmentItemList[gridView.FocusedRowHandle]);
                        }
                        catch (Exception) { }
                        entity.ShipmentItemList.GridControl.RefreshDataSource();
                    }
                    else
                    {
                        ARSaleOrderItemsInfo objSaleOrderItemsInfo = objSaleOrderItemsController.GetRemainSaleOrderItemQtyByShipmentItemID(item.FK_ICShipmentID, item.FK_ARSaleOrderItemID);
                        if(objSaleOrderItemsInfo != null)
                        {
                            if (objProductTolenrancesInfo.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Percent.ToString())
                                tolenrancePlus = objSaleOrderItemsInfo.ARSaleOrderItemProductQty * objProductTolenrancesInfo.ICProductTolenrancePlus / 100;
                            else if (objProductTolenrancesInfo.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Quantity.ToString())
                                tolenrancePlus = objProductTolenrancesInfo.ICProductTolenrancePlus;
                            if (item.ICShipmentItemProductQty  > objSaleOrderItemsInfo.ARSaleOrderItemProductQty + tolenrancePlus)
                            {
                                MessageBox.Show(String.Format("Số lượng xuất kho lớn hơn số lượng của đơn bán hàng, số lượng có thể xuất là {0}", (objSaleOrderItemsInfo.ARSaleOrderItemProductQty + tolenrancePlus).ToString("n3")),
                                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                try
                                {
                                    entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductQty = Convert.ToDecimal(gridView.ActiveEditor.OldEditValue.ToString());
                                    entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductExchangeQty = entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductFactor * entity.ShipmentItemList[gridView.FocusedRowHandle].ICShipmentItemProductQty;
                                    entity.SetProductCostByProductUnitCost(entity.ShipmentItemList[gridView.FocusedRowHandle]);
                                }
                                catch (Exception) { }
                            }
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }                     
                    }    
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeComponentItemQty();
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeItemExchangeQty(item);
                }
                else if (e.Column.FieldName == "ICShipmentItemProductSerialNo"
                            || e.Column.FieldName == "ICShipmentItemLotNo")
                {
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeItemSerieNo(item);
                    ((ShipmentSaleOrderModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeItemComponentStock(item);
                    ((ShipmentSaleOrderModule)Screen.Module).SelectSeriesNoDefault(item);
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeItemSerieNo(item);
                    ((ShipmentSaleOrderModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeItemMeasureUnit(item);
                }
                else if (e.Column.FieldName == "ICShipmentItemLength"
                    || e.Column.FieldName == "ICShipmentItemHeight"
                    || e.Column.FieldName == "ICShipmentItemWidth"
                    || e.Column.FieldName == "ICShipmentItemWoodQty")
                {
                    ((ShipmentSaleOrderModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                }
                else
                {
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeItemFromShipmentItemsList();
                }
                entity.UpdateTotalAmount();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICShipmentItemProductFactor")
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
                    ((ShipmentSaleOrderModule)Screen.Module).ChangeItemExchangeQty(item);
                }
            }
        }

        public void LoadGridViewByType(string type)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (type == ShipmentType.SaleShipment.ToString())
            {
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            //GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            else
            {
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    //column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    //column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICShipmentItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductFactor"];
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

                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;

            }
            column = gridView.Columns["ICShipmentItemTotalAmount"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }
            gridView.OptionsView.ShowFooter = true;
        }

        private void rpItemAddNewRow_Click(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Screen.Module).CopyItemToNewRow();
        }

        public List<ICProductsInfo> GetAllSectionProduct()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetAllSectionAndWorkProduct();
            return productList;
        }

        private void rpSectionProduct_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                if (lookUpEdit != null)
                    lookUpEdit.Properties.DataSource = ((ShipmentSaleOrderModule)Screen.Module).GetAllSectionProductForLookUp();
                gridView.RefreshData();
            }
        }
        private void RepoItemHyperLinkEdit_ButtonClick(object sender, System.EventArgs e)
        {
            ((ShipmentSaleOrderModule)Screen.Module).ShowItemComponent();
        }
    }
}
