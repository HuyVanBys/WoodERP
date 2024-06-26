using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
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
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionPlanning
{
    public class ARProductionPlanningItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {

            ProductionPlanningEntities entity = (ProductionPlanningEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionPlanningItemList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ProductionPlanningEntities entity = (ProductionPlanningEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARProductionPlanningsInfo mainObject = (ARProductionPlanningsInfo)entity.MainObject;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARProductionPlanningItemsInfo items = (ARProductionPlanningItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (items != null)
                {
                    items.IsError = false;
                    if ((e.Column.FieldName == "ARProductionPlanningItemProductBasicQty"))
                    {

                        if (!((ProductionPlanningModule)Screen.Module).ValidadteProductPlainningQty(items))
                            items.ARProductionPlanningItemProductQty = items.ARProductionPlanningItemProductBasicQty;
                        if (((ProductionPlanningModule)Screen.Module).IsEditAfterCompleting)
                            ((ProductionPlanningModule)Screen.Module).ValidateLoadContQty(items, false);
                    }
                    else if ((e.Column.FieldName == "ARProductionPlanningItemProductQty"))
                    {
                        if (((ProductionPlanningModule)Screen.Module).IsEditAfterCompleting)
                            ((ProductionPlanningModule)Screen.Module).ValidateBatchProductQty(items, false);
                    }
                    else if (e.Column.FieldName == "FK_ICProductID")
                    {
                        if (gridView.ActiveEditor.OldEditValue != null)
                        {
                            if (items.FK_ARSaleOrderItemID > 0)
                            {
                                ARSaleOrderItemsInfo soi = (ARSaleOrderItemsInfo)(new ARSaleOrderItemsController()).GetObjectByID(items.FK_ARSaleOrderItemID);
                                if (soi != null && soi.FK_ICProductID > 0)
                                {
                                    ICProductsInfo productsInfo = BOSApp.GetProductFromCurrentProductList(soi.FK_ICProductID);
                                    if (productsInfo != null && !productsInfo.ICProductCheckCarcass)
                                    {
                                        MessageBox.Show("Sản phẩm gốc (ĐBH) không phải hàng mẫu nên không thể thay đổi", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        items.FK_ICProductID = int.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    ((ProductionPlanningModule)Screen.Module).ChangeQtyFromProductionPlanningItemList(items);
                    entity.ProductionPlanningItemList.GridControl?.RefreshDataSource();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ARProductionPlanningItemsInfo items = (ARProductionPlanningItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (items != null)
                    {
                        if (((ProductionPlanningModule)Screen.Module).IsEditAfterCompleting)
                        {
                            if (!((ProductionPlanningModule)Screen.Module).ValidateLoadContQty(items, true)) return;
                        }

                        if (((ProductionPlanningModule)Screen.Module).IsEditAfterCompleting)
                        {
                            if (!((ProductionPlanningModule)Screen.Module).ValidateBatchProductQty(items, true)) return;
                        }
                    }
                }
                     ((ProductionPlanningModule)Screen.Module).DeleteItemFromProductionPlanningItemList();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            STFieldFormatGroupsInfo formatsInfo = new STFieldFormatGroupsInfo();
            GridColumn column = gridView.Columns["ARProductionPlanningItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARProductionPlanningItems", "ARProductionPlanningItemProductQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }                
            }
            column = gridView.Columns["ARProductionPlanningItemProductBasicQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARProductionPlanningItems", "ARProductionPlanningItemProductBasicQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["ARProductionPlanningItemProductQtyOld"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARProductionPlanningItems", "ARProductionPlanningItemProductQtyOld", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["ARProductionPlanningItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARProductionPlanningItems", "ARProductionPlanningItemWoodQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["ARProductionPlanningItemProductCBM"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARProductionPlanningItems", "ARProductionPlanningItemProductCBM", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["ARProductionPlanningItemOSSDeliveryDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemDateEdit repositoryItemTextEdit = new RepositoryItemDateEdit()
                {
                    Mask =
                    {
                        MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime,
                        EditMask = "dd/MM/yyyy hh:mm tt",
                        UseMaskAsDisplayFormat = true
                    }
                };
                repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.DateTime;
                repositoryItemTextEdit.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
                column.ColumnEdit = repositoryItemTextEdit;
            }
            column = gridView.Columns["ARProductionPlanningItemDeliveryDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ARCustomerID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemLoadContNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemSources"];
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
                DataSet ds1 = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds1.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                rpMeasureUnit.CloseUp += new CloseUpEventHandler(rpMeasureUnit_CloseUp);
                column.ColumnEdit = rpMeasureUnit;
            }
            column = gridView.Columns["ARProductionPlanningItemProductionPriority"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repAlternative = new RepositoryItemBOSLookupEdit();
                repAlternative.DisplayMember = "ICProductNo";
                repAlternative.ValueMember = "ICProductID";
                repAlternative.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repAlternative.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repAlternative.NullText = string.Empty;
                repAlternative.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã"));
                repAlternative.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên"));
                repAlternative.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repAlternative.QueryPopUp += new System.ComponentModel.CancelEventHandler(repAlternative_QueryPopUp);
                column.ColumnEdit = repAlternative;
            }
            column = gridView.Columns["ARProductionPlanningItemIsNewProduct"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsJoinComponent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsLabelCorlor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsProductCard"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsProductFSCCard"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsProductLabel"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsProductHDLR"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsProductHDSD"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsProductBarcode"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemIsProductWarranty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemHardwareRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemSemiProductRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemProductRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemWoodRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemPackagingRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemPaintRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemGeneralMaterialRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemPackagingRequimentType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProductionPlanningItemRemark"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }    

            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ICProductsTableName, "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
            }
            else if (e.Column.FieldName == "ARProductionPlanningItemStatus")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromConfigValue("ProductionPlanningItemStatus", e.Value.ToString());
                }
            }
        }
        private void rpMeasureUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ProductionPlanningEntities entity = (ProductionPlanningEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARProductionPlanningItemsInfo item = (ARProductionPlanningItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();
                ICProductMeasureUnitsInfo objProductMeasureUnitsInfo = objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                if (objProductsInfo != null && objProductsInfo.FK_ICProductBasicUnitID == item.FK_ICMeasureUnitID)
                    item.ARProductionPlanningItemProductFactor = (decimal)1;
                else
                    item.ARProductionPlanningItemProductFactor = objProductMeasureUnitsInfo != null ? objProductMeasureUnitsInfo.ICProductMeasureUnitFactor : 1;
                item.ARProductionPlanningItemProductExchangeQty = item.ARProductionPlanningItemProductQty * item.ARProductionPlanningItemProductFactor;
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARProductionPlanningItemsInfo item = (ARProductionPlanningItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = BaseLocalizedResources.AddNewRow;
            column.FieldName = "AddNewRow";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            AddNewRow.NullText = BaseLocalizedResources.AddNewRow;
            AddNewRow.Click += new EventHandler(AddNewRow_Click);
            column.ColumnEdit = AddNewRow;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "ARProductionPlanningItemSaleOrderName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        private void AddNewRow_Click(object sender, EventArgs e)
        {
            ProductionPlanningEntities entity = (ProductionPlanningEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ProductionPlanningItemList.CurrentIndex >= 0)
            {
                ARProductionPlanningItemsInfo items = (ARProductionPlanningItemsInfo)entity.ProductionPlanningItemList[entity.ProductionPlanningItemList.CurrentIndex].Clone();
                if (items != null)
                    ((ProductionPlanningModule)Screen.Module).AddNewProductionPlanningItem(items, entity.ProductionPlanningItemList.CurrentIndex);
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
                return;

            if (e.Column.FieldName == "ARProductionPlanningItemProductBasicQty")
            {
                if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                {
                    ARProductionPlanningItemsInfo item = (ARProductionPlanningItemsInfo)gridView.GetRow(e.RowHandle);
                    if (item.IsError)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }
                }
            }
        }

        public void repAlternative_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARProductionPlanningItemsInfo item = (ARProductionPlanningItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item == null)
                    return;
                int productID = item.FK_ICProductID;
                if (item.FK_ARSaleOrderItemID > 0)
                {
                    ARSaleOrderItemsInfo soItem = (ARSaleOrderItemsInfo)(new ARSaleOrderItemsController()).GetObjectByID(item.FK_ARSaleOrderItemID);
                    if (soItem != null) productID = soItem.FK_ICProductID;
                }
                ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == productID).FirstOrDefault();
                if (objProductsInfo == null || (objProductsInfo != null && !objProductsInfo.ICProductCheckCarcass))
                    return;

                List<ICProductsInfo> productsList = new List<ICProductsInfo>();
                List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(o => (o.FK_ICProductCarcassID == productID && o.ICProductType == ProductType.Product.ToString())
                                                                                    || o.ICProductID == productID).ToList();
                if (productViewList.Count() > 0) productViewList.ForEach(o =>
                {
                    ICProductsInfo newObj = new ICProductsInfo();
                    BOSUtil.CopyViewObject(o, newObj);
                    productsList.Add(newObj);
                });
                lookUpEdit.Properties.DataSource = productsList;
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            ProductionPlanningEntities entity = (ProductionPlanningEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ARProductionPlanningItemsInfo objProductionPlanningItemsInfo = entity.ProductionPlanningItemList[entity.ProductionPlanningItemList.CurrentIndex];

            if (gridView.FocusedColumn.FieldName == "FK_ARCustomerID")
            {
                if (objProductionPlanningItemsInfo.FK_ARSaleOrderID > 0
                    || objProductionPlanningItemsInfo.FK_ARSaleOrderItemID > 0)
                {
                    e.ErrorText = "Bạn không được chọn lại Tên khách hàng cho sp này!";
                    e.Valid = false;
                }
            }
        }
        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            ProductionPlanningEntities entity = (ProductionPlanningEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ProductionPlanningItemList.CurrentIndex >= 0)
            {
                ((ProductionPlanningModule)Screen.Module).InitProductPictureImage(entity.ProductionPlanningItemList[entity.ProductionPlanningItemList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}
