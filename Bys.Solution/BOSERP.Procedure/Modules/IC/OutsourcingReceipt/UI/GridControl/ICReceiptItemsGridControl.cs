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
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingReceipt
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.ICSerialNo;
            column.FieldName = "SerialNo";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit SerialNo = new RepositoryItemHyperLinkEdit();
            SerialNo.NullText = PurchaseReceiptLocalizedResources.ICSerialNo;
            SerialNo.Click += new EventHandler(SerialNo_Click);
            column.ColumnEdit = SerialNo;
            gridView.Columns.Add(column);

            GridColumn column2 = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column2 != null)
                column2.OptionsColumn.AllowEdit = true;


        }
        private void SerialNo_Click(object sender, EventArgs e)
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            if ((long)objICReceiptItemsInfo.ICReceiptItemProductQty > 0)
            {
                long receiptItemProductQty = (long)objICReceiptItemsInfo.ICReceiptItemProductQty;
                ((OutsourcingReceiptModule)Screen.Module).ChangeQTyFromReceiptItemsList(receiptItemProductQty);
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                ((OutsourcingReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((OutsourcingReceiptModule)Screen.Module).ResetModelDetail(item);
                    ((OutsourcingReceiptModule)Screen.Module).ClearSerialNo(item);
                }
                if (e.Column.FieldName == "FK_ICModelDetailID")
                {
                    ((OutsourcingReceiptModule)Screen.Module).ClearSerialNo(item);
                }
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((OutsourcingReceiptModule)Screen.Module).ChangStockItem(item);
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((OutsourcingReceiptModule)Screen.Module).ChangeItemMeasureUnit(item);
                }
                //if (e.Column.FieldName == "ICReceiptItemProductQty" && item.FK_APPurchaseOrderID!=0)
                //{

                //    if (!((OutsourcingReceiptModule)Screen.Module).IsValidCanceledQty(item,decimal.Parse(e.Value.ToString())))
                //    {
                //        MessageBox.Show(string.Format(PurchaseReceiptLocalizedResources.ReceiptQtyCannotBeGreaterThanOrderedQty), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].ICReceiptItemProductQty = int.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                //    }
                //}
                ((OutsourcingReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            //base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((OutsourcingReceiptModule)Screen.Module).DeleteItemFromReceiptItemsList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICShipmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
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

            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            //[NKVung]  [Fillter Model Detail By Model] [START]
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
                column.OptionsColumn.AllowEdit = false;
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

            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            return gridView;
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
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
        //[NKVung]  [Fillter Model Detail By Model] [END]
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICModelDetailID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
                    ICModelDetailsInfo objModelDetailsInfo = (ICModelDetailsInfo)objModelDetailsController.GetObjectByID(matchCodeID);
                    if (objModelDetailsInfo != null)
                        e.DisplayText = objModelDetailsInfo.ICModelDetailsName;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
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

        public void LoadGridViewForRoundWood(string ICStockNo)
        {
            foreach (GridColumn column in Columns)
            {
                if (column.FieldName == "ICReceiptItemProductQty")
                {
                    if (ICStockNo == "K-105" || ICStockNo == "K-106")
                    {
                        column.Caption = PurchaseReceiptLocalizedResources.ICProductQty;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n4}";
                        column.OptionsColumn.AllowEdit = true;
                    }
                    else
                    {
                        column.Caption = PurchaseReceiptLocalizedResources.BLockCaptionMessage;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n3}";
                        column.OptionsColumn.AllowEdit = true;
                    }
                }
                if (column.FieldName == "ICReceiptItemWoodQty")
                {
                    if (ICStockNo == "K-107" || ICStockNo == "K-106")
                    {
                        column.Visible = true;
                        column.VisibleIndex = 9;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n3}";
                        column.OptionsColumn.AllowEdit = true;

                    }
                    else
                    {
                        column.Visible = false;
                    }
                }

            }
        }

        public void LoadGridViewWhenValidated()
        {
            foreach (GridColumn column in Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
        }

        public void LoadGridViewActionNewManual()
        {
            //GridView gridView = base.InitializeGridView();
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
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

            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            //[NKVung]  [Fillter Model Detail By Model] [START]
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

            column = gridView.Columns["ICReceiptItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
        }

        public void LoadGridViewActionNewFrom()
        {
            //GridView gridView = base.InitializeGridView();
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
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

            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            //[NKVung]  [Fillter Model Detail By Model] [START]
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

            column = gridView.Columns["ICReceiptItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
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
    }
}
