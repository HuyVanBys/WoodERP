using BOSCommon.Constants;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferAdditional
{
    public class ICTransferItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            TransferAdditionalEntities entity = (TransferAdditionalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TransferItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            column = gridView.Columns["ICTransferItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICTransferItemProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICTransferItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICFromStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICToStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICTransferItemProductPakagingQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICTransferItemIsAverageCalculation"];
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

            column = gridView.Columns["ICTransferItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            return gridView;
        }

        private void ReposChoosePackage_Click(object sender, EventArgs e)
        {
            ((TransferAdditionalModule)Screen.Module).ShowTransferItemPackage();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((TransferAdditionalModule)Screen.Module).DeleteItemFromTransferItemsList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = TransferLocalizedResources.PackageColumn;
            column.FieldName = "PackageColumn";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit reposChoosePackage = new RepositoryItemHyperLinkEdit();
            reposChoosePackage.NullText = TransferLocalizedResources.IdentifyPackage;
            reposChoosePackage.Click += new EventHandler(ReposChoosePackage_Click);
            column.ColumnEdit = reposChoosePackage;

            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                TransferAdditionalEntities entity = (TransferAdditionalEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);

                if (e.Column.FieldName == "FK_ICFromStockID" || e.Column.FieldName == "FK_ICToStockID")
                {
                    ((TransferAdditionalModule)Screen.Module).ChangeItemStock(objTransferItemsInfo);
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((TransferAdditionalModule)Screen.Module).ChangeItemMeasureUnit(objTransferItemsInfo);
                }
                else if (e.Column.FieldName == "ICTransferItemProductSerialNo")
                {
                    ((TransferAdditionalModule)Screen.Module).ChangeItemSerieNo(objTransferItemsInfo);
                }
                else
                {
                    ((TransferAdditionalModule)Screen.Module).ChangeItemFromTransferItemsList();
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICTransferItemsInfo item = (ICTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (gridView.FocusedColumn.FieldName == "ICTransferItemProductQty")
                {
                    string errMsg = ((TransferAdditionalModule)Screen.Module).CheckForValidQty(item, Convert.ToDecimal(e.Value));
                    if (!string.IsNullOrEmpty(errMsg))
                    {
                        e.ErrorText = errMsg;
                        e.Valid = false;
                    }
                }
                if (gridView.FocusedColumn.FieldName == "ICTransferItemProductFactor")
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

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICTransferItemsInfo item = (ICTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
    }
}
