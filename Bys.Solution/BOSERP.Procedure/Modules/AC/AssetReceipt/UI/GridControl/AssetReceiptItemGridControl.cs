using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetReceipt
{
    public partial class AssetReceiptItemGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AssetReceiptItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACAssetReceiptItemQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["ACAssetReceiptItemUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACAssetReceiptItemDiscountPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACAssetReceiptItemDiscountAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACAssetReceiptItemTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACAssetReceiptItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACAssetReceiptItemOriginalAmount"];
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
            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAssetID"];
            if (column != null)
            {
                column.Caption = "Mã TSCD";
            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
            }
            column = gridView.Columns["ACAssetReceiptItemProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
            }
            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACAssetReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
            }
            return gridView;
        }

        void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            GridView gridView = (GridView)sender;
            GridColumn column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                ACAssetReceiptItemsInfo assetReceiptItem = (ACAssetReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (assetReceiptItem != null)
                {
                    ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(assetReceiptItem.FK_ACUnfinishedConstructionCostID);
                    if (objUnfinishedConstructionCostsInfo != null && objUnfinishedConstructionCostsInfo.ACUnfinishedConstructionCostStatus == UnfinishedConstructionCostStatus.Complete.ToString())
                    {
                        column.OptionsColumn.AllowEdit = false;
                    }
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            BOSERP.Modules.AssetReceipt.AssetReceiptEntities entity = (BOSERP.Modules.AssetReceipt.AssetReceiptEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ACAssetReceiptItemsInfo item = (ACAssetReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    if (e.Column.FieldName == "FK_ACAssetID")
                    {

                        ACAssetsController objAssetController = new ACAssetsController();
                        ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetController.GetObjectByID(item.FK_ACAssetID);
                        if (objAssetsInfo != null)
                        {
                            item.FK_ACAccountID = objAssetsInfo.FK_ACAccountID;
                            item.FK_ACDepreciationAccountID = objAssetsInfo.FK_ACDepreciationAccountID;
                        }
                    }
                    else if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                    {
                        ACUnfinishedConstructionCostsController unfinishedCostController = new ACUnfinishedConstructionCostsController();
                        ACUnfinishedConstructionCostsInfo unfinishedCost = (ACUnfinishedConstructionCostsInfo)unfinishedCostController.GetObjectByID(item.FK_ACUnfinishedConstructionCostID);

                        if (unfinishedCost != null)
                        {
                            item.ACAssetReceiptItemUnitCost = unfinishedCost.ACUnfinishedConstructionCostValue;
                        }
                    }
                    else if (e.Column.FieldName == "ACAssetReceiptItemProductSerialNo")
                    {
                        if (objAssetReceiptsInfo.ACAssetReceiptType != AssetReceiptType.Receipt.ToString())
                        {
                            BOSApp.ShowMessage(AssetReceiptLocalizedResources.ErrorDataRecept);
                            GridView gridView1 = (GridView)MainView;
                            item.ACAssetReceiptItemProductSerialNo = gridView1.ActiveEditor.OldEditValue.ToString();
                            return;
                        }
                        ((AssetReceiptModule)Screen.Module).ChangeItemSerieNo(item);
                    }
                    else if (e.Column.FieldName == "FK_ICProductSerieID")
                    {
                        if (objAssetReceiptsInfo.ACAssetReceiptType != AssetReceiptType.Receipt.ToString())
                        {
                            BOSApp.ShowMessage(AssetReceiptLocalizedResources.ErrorDataRecept);
                            GridView gridView1 = (GridView)MainView;
                            item.FK_ICProductSerieID = Convert.ToInt32(gridView1.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        ((AssetReceiptModule)Screen.Module).ChangeItemSerieNo(item);
                    }
                    else if (e.Column.FieldName == "FK_ICStockID")
                    {
                        if (objAssetReceiptsInfo.ACAssetReceiptType != AssetReceiptType.Receipt.ToString())
                        {
                            BOSApp.ShowMessage(AssetReceiptLocalizedResources.ErrorDataRecept);
                            GridView gridView1 = (GridView)MainView;
                            item.FK_ICStockID = Convert.ToInt32(gridView1.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        ((AssetReceiptModule)Screen.Module).SelectSeriesNoDefault(item);
                        ((AssetReceiptModule)Screen.Module).ChangeItemSerieNo(item);
                    }
                    else if (e.Column.FieldName == "ACAssetReceiptItemTaxPercent")
                    {
                        if (objAssetReceiptsInfo.ACAssetReceiptType != AssetReceiptType.NewIncrease.ToString())
                        {
                            BOSApp.ShowMessage("Không được nhập % thuế!");
                            GridView gridView1 = (GridView)MainView;
                            item.ACAssetReceiptItemTaxPercent = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                    }
                    else if (e.Column.FieldName == "ACAssetReceiptItemTaxAmount")
                    {
                        if (objAssetReceiptsInfo.ACAssetReceiptType != AssetReceiptType.NewIncrease.ToString())
                        {
                            BOSApp.ShowMessage("Không được nhập tiền thuế!");
                            GridView gridView1 = (GridView)MainView;
                            item.ACAssetReceiptItemTaxAmount = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                    }
                    ((AssetReceiptModule)Screen.Module).ChangeItemFromList(item);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AssetReceiptModule)Screen.Module).RemoveSelectedItem();
            }
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

    }
}
