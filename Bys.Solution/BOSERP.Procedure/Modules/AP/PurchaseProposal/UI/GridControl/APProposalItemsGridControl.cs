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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class APProposalItemsGridControl : BOSGridControl
    {
        private List<MMOperationsInfo> OperationDataSource = new List<MMOperationsInfo>();

        public override void InitGridControlDataSource()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PurchaseProposalItemList;
            this.DataSource = bds;

            MMOperationsController objOperationsController = new MMOperationsController();
            DataSet ds = BOSApp.LookupTables[TableName.MMOperationsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.MMOperationsTableName);
                if (BOSApp.LookupTables.ContainsKey(TableName.MMOperationsTableName))
                    BOSApp.LookupTables[TableName.MMOperationsTableName] = ds;
                BOSApp.LookupTables.Add(TableName.MMOperationsTableName, ds);
            }
            OperationDataSource = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = PurchaseProposalLocalizedResources.DiscardItem;
            column.FieldName = "DiscardItem";
            RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = PurchaseProposalLocalizedResources.Discard;
            rep.LinkColor = Color.Blue;
            rep.Click += new EventHandler(ItemHyperLinkEdit_Click);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PurchaseProposalLocalizedResources.ApproveItem;
            column.FieldName = "ApproveItem";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = PurchaseProposalLocalizedResources.Approved;
            rep1.LinkColor = Color.Blue;
            rep1.Click += new EventHandler(ItemHyperLinkEdit1_Click);
            column.ColumnEdit = rep1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SL tồn kho";
            column.FieldName = "ICInventoryStockQty";
            STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("APProposalItems", "APProposalItemProductQty", this.Screen.Module.ModuleID);
            if (formatsInfo != null)
            {
                column.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(formatsInfo.STFieldFormatGroupFormatType);
                column.DisplayFormat.FormatString = formatsInfo.STFieldFormatGroupFormatString;
            }
            gridView.Columns.Add(column);

            GridColumn gridColumn = new GridColumn();
            gridColumn.Caption = "Mã KHSD";
            gridColumn.FieldName = "MMAllocationPlanNo";
            gridView.Columns.Add(gridColumn);

            gridView.Columns.Add(column);

            gridColumn = new GridColumn();
            gridColumn.Caption = BaseLocalizedResources.SaleOrderName;
            gridColumn.FieldName = "MMBatchProductSOName";
            gridView.Columns.Add(gridColumn);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.CellValueChanging += GridView_CellValueChanging;
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            GridColumn column = gridView.Columns["APPurchaseProposalItemReasonUnapproved"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                SetFormat("APProposalItemProductQty", "n5", gridView);
            }
            column = gridView.Columns["APPurchaseProposalItemType"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.PurchaseProposalType + "Search"]);
                column.ColumnEdit = rep;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemInsideDemensionWitdh"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemInsideDemensionLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemInsideDemensionHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemOverallDemensionWitdh"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemOverallDemensionLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemOverallDemensionHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemProductSizeAndPacking"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProdAttPackingMaterialSpecialityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProdAttPackingMaterialSizeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_APSupplierID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APProposalItemProductionNormItemTotalPaint"];
            if (column != null)
            {
                column.Visible = false;
            }
            column = gridView.Columns["APProposalItemProductionNormItemTotalBlocks"];
            if (column != null)
            {
                column.Visible = false;
            }
            column = gridView.Columns["FK_MMFromOperationID"];
            if (column != null)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMToOperationID"];
            if (column != null)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemNeedTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemNeedToTime"];
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
            column = gridView.Columns["APProposalItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APProposalItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemOperation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckedComboBoxEdit operationRepositoryItem = new RepositoryItemCheckedComboBoxEdit();
                operationRepositoryItem.DisplayMember = "MMOperationName";
                operationRepositoryItem.ValueMember = "MMOperationID";
                operationRepositoryItem.NullText = string.Empty;
                operationRepositoryItem.DataSource = OperationDataSource;
                operationRepositoryItem.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpOperationName_QueryPopUp);
                column.ColumnEdit = operationRepositoryItem;
            }
            column = gridView.Columns["APPurchaseOrderItemServiceFromDate"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["APPurchaseOrderItemServiceToDate"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["APProposalItemProductExchangeQty"];
            if (column != null)
            {
                SetFormat("APProposalItemProductExchangeQty", "n5", gridView);
            }
            column = gridView.Columns["APProposalItemNormQty"];
            if (column != null)
            {
                SetFormat("APProposalItemNormQty", "n5", gridView);
            }
            column = gridView.Columns["APProposalItemPurchaseOrderQty"];
            if (column != null)
            {
                SetFormat("APProposalItemPurchaseOrderQty", "n5", gridView);
            }
            column = gridView.Columns["APProposalItemCanceledQty"];
            if (column != null)
            {
                SetFormat("APProposalItemCanceledQty", "n5", gridView);
            }

            return gridView;
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName == "APProposalItemOperation")
            {
                if (e.Value != null)
                {
                    e.DisplayText = GetOperationDisplayText(e.Value.ToString());
                }
            }
        }

        private string GetOperationDisplayText(string operationRef)
        {
            if (string.IsNullOrWhiteSpace(operationRef))
                return string.Empty;

            List<int> operation = operationRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            return string.Join(", ", OperationDataSource.Where(o => operation.Contains(o.MMOperationID)).Select(o => o.MMOperationName).ToArray());
        }

        private void rpOperationName_QueryPopUp(object sender, CancelEventArgs e)
        {
            CheckedComboBoxEdit lke = (CheckedComboBoxEdit)sender;
            if (lke == null)
                return;

            GridView gridView = (GridView)MainView;
            APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                item = new APProposalItemsInfo();

            lke.Properties.DataSource = ((PurchaseProposalModule)Screen.Module).GetOperationDataSourceOfSemiProduct(item.FK_MMBatchProductItemOutSourcingID);
            lke.Properties.DisplayMember = "MMOperationName";
            lke.Properties.ValueMember = "MMOperationID";
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((PurchaseProposalModule)Screen.Module).DeleteItemFromProposalItemList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                {
                    PurchaseProposalEntities entity = (PurchaseProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                    GeneralHelper.ChangePurchaseItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            PurchaseProposalEntities entity = (PurchaseProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (gridView.FocusedRowHandle < 0)
                return;

            APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "APProposalItemOperation"
                || e.Column.FieldName == "APProposalItemProductQty"
                || e.Column.FieldName == "APProposalItemProductFactor"
                || e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                //if (!((PurchaseProposalModule)Screen.Module).IsValidProposalQty(item, e.Column.FieldName))
                //{
                //    dbUtil.SetPropertyValue(item, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                //    gridView.ActiveEditor.EditValue = gridView.ActiveEditor.OldEditValue;
                //    gridView.RefreshData();
                //}
                if (objProposalsInfo.APProposalAPTypeCombo == ProposalAPType.IngredientPaint.ToString())
                {
                    item.APProposalItemProductExchangeQty = item.APProposalItemProductQty * item.APProposalItemProductFactor;
                    item.APProposalItemProductExchangeQty = Math.Round(item.APProposalItemProductExchangeQty, 5, MidpointRounding.AwayFromZero);
                }
                else
                {
                    item.APProposalItemProductExchangeQty = item.APProposalItemProductQty * item.APProposalItemProductFactor;
                    item.APProposalItemProductExchangeQty = Math.Round(item.APProposalItemProductExchangeQty, 3, MidpointRounding.AwayFromZero);
                }

                gridView.RefreshData();
            }
            ((PurchaseProposalModule)entity.Module).ChangeProposalItem(item);
        }

        private void ItemHyperLinkEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ((PurchaseProposalModule)Screen.Module).DiscardProposalItem(item);
            }
        }

        private void ItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ((PurchaseProposalModule)Screen.Module).ApproveProposalItem(item);
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                //dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductDesc);
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        public void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        public virtual void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }

        public void FormatQuantity(string type)
        {
            GridView gridView = (GridView)MainView;
            PurchaseProposalEntities entity = (PurchaseProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            if (gridView.Columns["APProposalItemPurchaseOrderQty"] != null)
            {
                SetFormat("APProposalItemPurchaseOrderQty", "n5", gridView);
            }
            if (gridView.Columns["APProposalItemProductQty"] != null)
            {
                SetFormat("APProposalItemProductQty", "n5", gridView);
            }
            if (objProposalsInfo.APProposalAPTypeCombo == ProposalAPType.IngredientPaint.ToString())
            {
                if (gridView.Columns["APProposalItemProductExchangeQty"] != null)
                {
                    SetFormat("APProposalItemProductExchangeQty", "n5", gridView);
                }
                if (gridView.Columns["APProposalItemPurchaseOrderQty"] != null)
                {
                    SetFormat("APProposalItemPurchaseOrderQty", "n5", gridView);
                }
                if (gridView.Columns["ICInventoryStockQty"] != null)
                {
                    SetFormat("ICInventoryStockQty", "n5", gridView);
                }
            }
        }


        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
            APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "APProposalItemProductFactor")
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
                if (gridView.FocusedColumn.FieldName == "APProposalItemProductQty")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        ICProductsController objProductscontroller = new ICProductsController();
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductscontroller.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo.ICProductPurchaseType == "Minmax")
                        {
                            decimal proposalQty = Convert.ToDecimal(e.Value) * item.APProposalItemProductFactor;
                            if (objProductsInfo.ICProductStockMin > proposalQty || proposalQty > objProductsInfo.ICProductStockMax)
                            {
                                e.ErrorText = "Số lượng không thể vượt quá tồn kho max hoặc thấp hơn tồn kho min của sản phẩm";
                                e.Valid = false;
                            }
                        }
                    }
                }
            }
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
                return;

            APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(e.RowHandle);
            if (e.Column.FieldName == "ICInventoryStockQty" && e.CellValue != null)
            {
                if (item.IsCheckInventory)
                {
                    if (item.APProposalItemProductQty > item.ICInventoryStockQty)
                    {
                        e.Appearance.BackColor = Color.DarkOrange;
                        e.Appearance.BackColor2 = Color.DarkOrange;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.BackColor2 = Color.Green;
                    }
                }
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            PurchaseProposalEntities entity = (PurchaseProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.PurchaseProposalItemList.CurrentIndex >= 0)
            {
                ((PurchaseProposalModule)Screen.Module).InitProductPictureImage(entity.PurchaseProposalItemList[entity.PurchaseProposalItemList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}
