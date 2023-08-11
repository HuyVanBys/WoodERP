using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetTransfer
{
    public partial class AssetTransferItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AssetTransferEntities entity = (AssetTransferEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AssetTransferItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = AssetTransferLocalizedResources.ACAssetNo;
            column.FieldName = "ACAssetNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AssetTransferLocalizedResources.ACAssetName;
            column.FieldName = "ACAssetName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AssetTransferLocalizedResources.ACAssetOriginalAmount;
            column.FieldName = "ACAssetOriginalAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AssetTransferLocalizedResources.ACAssetRemainedAmount;
            column.FieldName = "ACAssetRemainedAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ACAssetTransferItemQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRFromRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRToRoomID"];
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
            column = gridView.Columns["FK_HRToDepartmentRoomGroupItemID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMToLineID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMToWorkShopID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HREmployeeUserID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRToDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.Visible = false;
            }
            column = gridView.Columns["FK_ACDepreciationCostAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnLookupEdit(TableName.ACAccountsTableName, AssetTransferLocalizedResources.ACAccountNo, column.FieldName);
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ACAssetTransferItemsInfo item = (ACAssetTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "FK_HRFromRoomID")
                {
                    ((AssetTransferModule)Screen.Module).ChangeAssetRoom(item);
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ACAssetTransferItemsInfo item = (ACAssetTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (gridView.FocusedColumn.FieldName == "ACAssetTransferItemQty")
                {
                    decimal qty = Convert.ToDecimal(e.Value);
                    string msg = ((AssetTransferModule)Screen.Module).CheckForValidShippedQty(item, qty);
                    if (!string.IsNullOrEmpty(msg))
                    {
                        e.Valid = false;
                        e.ErrorText = msg;
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AssetTransferModule)Screen.Module).RemoveSelectedItem();
            }
        }

    }
}
