using BOSCommon;
using BOSCommon.Constants;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ReturnSupplier
{
    public partial class APReturnSupplierItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ReturnSupplierEntities entity = (ReturnSupplierEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReturnSupplierItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CellValueChanging += GridView_CellValueChanging;
            if (gridView.Columns["APReturnSupplierItemProductQty"] != null)
                gridView.Columns["APReturnSupplierItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APReturnSupplierItemProductUnitCost"] != null)
                gridView.Columns["APReturnSupplierItemProductUnitCost"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APReturnSupplierItemProductTaxPercent"] != null)
            {
                gridView.Columns["APReturnSupplierItemProductTaxPercent"].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns["APReturnSupplierItemProductTaxPercent"].DisplayFormat.FormatString = "{0:n3}";
            }
            if (gridView.Columns["FK_ICStockID"] != null)
            {
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APReturnSupplierItemProductSerialNo"] != null)
            {
                gridView.Columns["APReturnSupplierItemProductSerialNo"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APReturnSupplierItemProductTaxPercent"] != null)
            {
                gridView.Columns["APReturnSupplierItemProductTaxPercent"].OptionsColumn.AllowEdit = true;
            }
            GridColumn column = gridView.Columns["FK_ICMeasureUnitID"];
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

            column = gridView.Columns["APReturnSupplierItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_PMProjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APReturnSupplierItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APReturnSupplierItemWoodQty"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n3");
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    int id = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ICMeasureUnitsTableName, "ICMeasureUnitID", id, "ICMeasureUnitName");
                }
                else
                    e.DisplayText = "";
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = MainView as GridView;
            ReturnSupplierEntities entity = (ReturnSupplierEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APReturnSupplierItemsInfo objReturnSupplierItemsInfo = gridView.GetRow(gridView.FocusedRowHandle) as APReturnSupplierItemsInfo;

            if (objReturnSupplierItemsInfo == null)
                return;

            //if (e.Column.FieldName == "APReturnSupplierItemProductQty")
            //{
            //    decimal remainProductQty = ((ReturnSupplierModule)Screen.Module).GetRemainProductQty(objReturnSupplierItemsInfo);
            //    if (objReturnSupplierItemsInfo.APReturnSupplierItemProductQty > remainProductQty)
            //    {
            //        MessageBox.Show(ReturnSupplierLocalizedResources.ProductQtyErrorMessage,
            //                        CommonLocalizedResources.MessageBoxDefaultCaption,
            //                        MessageBoxButtons.OK,
            //                        MessageBoxIcon.Error);
            //        try
            //        {
            //            entity.APReturnSupplierItemsList[gridView.FocusedRowHandle].APReturnSupplierItemProductQty = Convert.ToDecimal(gridView.ActiveEditor.OldEditValue.ToString());
            //        }
            //        catch (Exception) { }
            //    }
            //}
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                ((ReturnSupplierModule)Screen.Module).ChangeItemMeasureUnit(objReturnSupplierItemsInfo);
            }
            if (e.Column.FieldName == "APReturnSupplierItemProductSerialNo")
            {
                ((ReturnSupplierModule)Screen.Module).UpdateLotNoItem(objReturnSupplierItemsInfo);
                ((ReturnSupplierModule)Screen.Module).ChangeItemProductUnitCost(objReturnSupplierItemsInfo);
                gridView.RefreshData();
            }
            entity.ModuleObjects[TableName.APReturnSupplierItemsTableName] = (APReturnSupplierItemsInfo)entity.ReturnSupplierItemsList[entity.ReturnSupplierItemsList.CurrentIndex].Clone();
            (entity.Module as ReturnSupplierModule).ChangeItemFromReturnSupplierItemsList();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ReturnSupplierModule)Screen.Module).DeleteItemFromReturnSupplierItemsList();
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            APReturnSupplierItemsInfo item = (APReturnSupplierItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
            APReturnSupplierItemsInfo item = (APReturnSupplierItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "APReturnSupplierItemProductFactor")
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
                if (gridView.FocusedColumn.FieldName == "APReturnSupplierItemProductQty")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        ICTransactionsController controller = new ICTransactionsController();
                        decimal qty = controller.GetInventoryQtyByProductIDAndStockID(item.FK_ICProductID, item.FK_ICStockID, BOSApp.CurrentUsersInfo.ADUserGroupID);
                        if (Convert.ToDecimal(e.Value) > qty)
                        {
                            e.ErrorText = "Số lượng không được vượt quá số lượng sản phẩm tồn kho hiện có. Vui lòng kiểm tra lại!.";
                            e.Valid = false;
                        }
                    }
                }
            }
        }
        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                {
                    ReturnSupplierEntities entity = (ReturnSupplierEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    APReturnSupplierItemsInfo item = (APReturnSupplierItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                    GeneralHelper.ChangePurchaseItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                }
            }
        }

        public void LoadGridViewByProductType(APReturnSuppliersInfo mainObject)
        {
            GridView gridView = (GridView)MainView;
            string productType = mainObject.APReturnSupplierReceiptType;

            if (productType == ReturnSupplierReceiptType.Roundwood.ToString() || productType == ReturnSupplierReceiptType.Lumber.ToString()
                        || productType == "FreshLumber" || productType == ReturnSupplierReceiptType.ArtificialBoard.ToString() || productType == ReturnSupplierReceiptType.Verneer.ToString())
            {
                GridColumn column = gridView.Columns["APReturnSupplierItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng";
                }

                column = gridView.Columns["APReturnSupplierItemProductExchangeQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng quy đổi";
                }
            }
            else
            {
                GridColumn column = gridView.Columns["APReturnSupplierItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng";
                }

                column = gridView.Columns["APReturnSupplierItemProductExchangeQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng quy đổi";
                }
            }
            gridView.BestFitColumns();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.FieldName = "APReturnSupplierItemLotNo";
            gridView.Columns.Add(newColumn);
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            ReturnSupplierEntities entity = (ReturnSupplierEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ReturnSupplierItemsList.CurrentIndex >= 0)
            {
                ((ReturnSupplierModule)Screen.Module).InitProductPictureImage(entity.ReturnSupplierItemsList[entity.ReturnSupplierItemsList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}
