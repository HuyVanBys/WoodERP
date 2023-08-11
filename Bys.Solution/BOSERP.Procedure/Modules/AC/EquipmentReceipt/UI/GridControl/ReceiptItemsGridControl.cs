using BOSCommon.Constants;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentReceipt
{
    public class ReceiptItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                ICReceiptItemsInfo item = entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((EquipmentReceiptModule)Screen.Module).ResetModelDetail(item);
                    ((EquipmentReceiptModule)Screen.Module).ClearSerialNo(item);
                }

                if (e.Column.FieldName == "FK_ICModelDetailID")
                {
                    ((EquipmentReceiptModule)Screen.Module).ClearSerialNo(item);
                }

                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                if (e.Column.FieldName == "ICReceiptItemTotalCost")
                {
                    ((EquipmentReceiptModule)Screen.Module).ChangeItemFromReceiptItemListCost();
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((EquipmentReceiptModule)Screen.Module).ChangeItemMeasureUnit(item);
                }
                else
                {
                    ((EquipmentReceiptModule)Screen.Module).ChangeItemFromReceiptItemList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EquipmentReceiptModule)Screen.Module).DeleteItemFromReceiptItemList();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }

            column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemTotalCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemDiscountAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentRoomGroupItemID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMLineID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMWorkShopID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HREmployeeUserID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICModelDetailID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICModelDetailsName";
                repositoryItemLookUpEdit.ValueMember = "ICModelDetailID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICModelDetailsName", PurchaseOrderLocalizedResources.ICModelDetailsName));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditModelDetail_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
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

            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit rpProduct = new RepositoryItemLookUpEdit();
                rpProduct.DisplayMember = "ICProductNo";
                rpProduct.ValueMember = "ICProductID";
                rpProduct.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ICProductsTableName] as DataSet;
                rpProduct.DataSource = ds.Tables[0];
                column.ColumnEdit = rpProduct;
            }

            column = gridView.Columns["ICReceiptItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            return gridView;
        }
        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            List<ICModelDetailsInfo> ModelDetailsList = new List<ICModelDetailsInfo>();
            ICModelDetailsInfo objModelDetailsInfo = new ICModelDetailsInfo();
            objModelDetailsInfo.ICModelDetailID = 0;
            if (item != null)
            {
                ModelDetailsList = objModelDetailsController.GetModelDetailByModelID(item.FK_ICModelID);
            }
            if (ModelDetailsList != null)
            {
                if (ModelDetailsList.Count > 0)
                {
                    ModelDetailsList.Insert(0, objModelDetailsInfo);
                }
                lookUpEdit.Properties.DataSource = ModelDetailsList;
            }
            lookUpEdit.Properties.DisplayMember = "ICModelDetailsName";
            lookUpEdit.Properties.ValueMember = "ICModelDetailID";
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
    }
}
