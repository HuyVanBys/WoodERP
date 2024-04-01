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
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        private List<ICLengthGroupsInfo> ListLengthGroupsInfo { get; set; }
        private List<ICWidthGroupsInfo> ListWidthGroupsInfo { get; set; }

        public override void InitGridControlDataSource()
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;

            ICLengthGroupsController objLengthGroupsController = new ICLengthGroupsController();
            ICWidthGroupsController objWidthGroupsController = new ICWidthGroupsController();
            ListLengthGroupsInfo = (List<ICLengthGroupsInfo>)objLengthGroupsController.GetListFromDataSet(objLengthGroupsController.GetAllObjects());
            ListWidthGroupsInfo = (List<ICWidthGroupsInfo>)objWidthGroupsController.GetListFromDataSet(objWidthGroupsController.GetAllObjects());
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

            column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = CommonLocalizedResources.SerialNoText;
            }
            column = gridView.Columns["ICReceiptItemLotNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = CommonLocalizedResources.LotNoText;
            }

            column = new GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.ICReceiptItemSOName;
            column.FieldName = "ICReceiptItemSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
            
            column = new GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_MMUpdatePositionItemID";
            column.Caption = "Vị trí";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit rep = new RepositoryItemLookUpEdit();
            rep.ValueMember = "MMUpdatePositionItemID";
            rep.DisplayMember = "MMUpdatePositionItemPositionName";
            rep.NullText = String.Empty;
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.SearchMode = SearchMode.AutoFilter;
            rep.Columns.Add(new LookUpColumnInfo("MMUpdatePositionItemPositionName", "Vị trí"));
            rep.QueryPopUp += new System.ComponentModel.CancelEventHandler(rep_QueryPopUp);
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Độ ẩm";
            column.FieldName = "ICReceiptItemCode01Combo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        private void rpItemAddNewRow_Click(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Screen.Module).CopyItemToNewRow();
        }

        private void SerialNo_Click(object sender, EventArgs e)
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            if (objICReceiptItemsInfo.ICReceiptItemProductQty > 0)
            {
                ((PurchaseReceiptModule)Screen.Module).ChangeQTyFromReceiptItemsList(objICReceiptItemsInfo.ICReceiptItemProductQty);
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                ((PurchaseReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((PurchaseReceiptModule)Screen.Module).ResetModelDetail(item);
                    ((PurchaseReceiptModule)Screen.Module).ClearSerialNo(item);
                }
                else if (e.Column.FieldName == "FK_ICModelDetailID")
                {
                    ((PurchaseReceiptModule)Screen.Module).ClearSerialNo(item);
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((PurchaseReceiptModule)Screen.Module).ChangStockItem(item);
                }
                else if (e.Column.FieldName == "ICReceiptItemHasProductPackage")
                {
                    ((PurchaseReceiptModule)Screen.Module).ChangeHasProductPackage();
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((PurchaseReceiptModule)Screen.Module).ChangeItemMeasureUnit(item);
                }
                else if (e.Column.FieldName == "FK_GETerminalID")
                {
                    item.FK_GEContainerID = 0;
                }
                else if (e.Column.FieldName == "ICReceiptItemProductUnitCost")
                {
                    ((PurchaseReceiptModule)Screen.Module).UpdateTotalCost();
                }
                else if (e.Column.FieldName == "ICReceiptItemProductQty")
                {
                    ((PurchaseReceiptModule)Screen.Module).CalculatedTotalWoodQtyByPackageVolumnConfig();
                    bool isSuccess;
                    ((PurchaseReceiptModule)Screen.Module).ChangeReceiptItemProductQty(item,out isSuccess);
                    ((PurchaseReceiptModule)Screen.Module).UpdateTotalCost();
                }
                if (e.Column.FieldName == "ICReceiptItemProductLength"
                   || e.Column.FieldName == "ICReceiptItemProductHeight"
                   || e.Column.FieldName == "ICReceiptItemProductWidth"
                   || e.Column.FieldName == "ICReceiptItemWoodQty")
                {
                    if(e.Column.FieldName == "ICReceiptItemProductLength")
                    {
                        ICProductsForViewInfo lumber = BOSApp.CurrentProductList.Where(m => m.ICProductID == item.FK_ICProductID).FirstOrDefault();
                        if(lumber != null && lumber.FK_ICLengthGroupID > 0)
                        {
                            ICLengthGroupsInfo objLengthGroupsInfo = ListLengthGroupsInfo.Where(m => m.ICLengthGroupID == lumber.FK_ICLengthGroupID).FirstOrDefault();
                            if(objLengthGroupsInfo != null
                                && (item.ICReceiptItemProductLength < objLengthGroupsInfo.ICLengthGroupMinValue
                                    || item.ICReceiptItemProductLength > objLengthGroupsInfo.ICLengthGroupMaxValue))
                            {
                                if(DialogResult.OK != (MessageBox.Show(PurchaseReceiptLocalizedResources.ErrorProductLength,
                                                                       CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OKCancel,
                                                                       MessageBoxIcon.Information)))
                                {
                                    item.ICReceiptItemProductLength = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                                }    
                            }    
                        }    
                    }   
                    else if (e.Column.FieldName == "ICReceiptItemProductWidth")
                    {
                        ICProductsForViewInfo lumber = BOSApp.CurrentProductList.Where(m => m.ICProductID == item.FK_ICProductID).FirstOrDefault();
                        if (lumber != null && lumber.FK_ICWidthGroupID > 0)
                        {
                            ICWidthGroupsInfo objWidthGroupsInfo = ListWidthGroupsInfo.Where(m => m.ICWidthGroupID == lumber.FK_ICWidthGroupID).FirstOrDefault();
                            if (objWidthGroupsInfo != null
                                && (item.ICReceiptItemProductWidth < objWidthGroupsInfo.ICWidthGroupMinValue
                                    || item.ICReceiptItemProductWidth > objWidthGroupsInfo.ICWidthGroupMaxValue))
                            {
                                if (DialogResult.OK != (MessageBox.Show(PurchaseReceiptLocalizedResources.ErrorProductWidth,
                                                                       CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OKCancel,
                                                                       MessageBoxIcon.Information)))
                                {
                                    item.ICReceiptItemProductWidth = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                                }
                            }
                        }
                    }    
                    ((PurchaseReceiptModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                    //((PurchaseReceiptModule)Screen.Module).ChangeReceiptItemProductQty(item);
                    bool isSuccess;
                    ((PurchaseReceiptModule)Screen.Module).ChangeReceiptItemProductQty(item, out isSuccess);
                    if (!isSuccess)
                    {
                        BOSDbUtil dbUtil = new BOSDbUtil();
                        dbUtil.SetPropertyValue(item, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                        gridView.ActiveEditor.EditValue = gridView.ActiveEditor.OldEditValue;
                        gridView.RefreshData();
                    }
                }
                ((PurchaseReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
                this.RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PurchaseReceiptModule)Screen.Module).DeleteItemFromReceiptItemsList();
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
            gridView.CellValueChanging += GridView_CellValueChanging;
            GridColumn column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.SummaryItem.FieldName = column.FieldName;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:n2}";
            }
            column = gridView.Columns["ICReceiptItemTotalCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.SummaryItem.FieldName = column.FieldName;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:n2}";
            }
            column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n5}";
            }
            column = gridView.Columns["ICReceiptItemProductExchangeQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n5}";
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
            column = gridView.Columns["ICReceiptItemHasProductPackage"];
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
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_PMProjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_GETerminalID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_GEContainerID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit containerRepo = new RepositoryItemLookUpEdit();
                containerRepo.DisplayMember = "GEContainerName";
                containerRepo.ValueMember = "GEContainerID";
                containerRepo.NullText = string.Empty;
                containerRepo.Columns.Add(new LookUpColumnInfo("GEContainerNo", "Mã "));
                containerRepo.Columns.Add(new LookUpColumnInfo("GEContainerName", "Loại cont"));
                containerRepo.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpContainer_QueryPopUp);
                column.ColumnEdit = containerRepo;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLenghtMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemWidthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLenghtMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemWidthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            return gridView;
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
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
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICModelDetails", "ICModelDetailID", matchCodeID, "ICModelDetailsName");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_GEContainerID")
            {
                if (e.Value != null)
                {
                    int containerID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("GEContainers", "GEContainerID", containerID, "GEContainerName");
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
                        column.SummaryItem.FieldName = column.FieldName;
                        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        column.SummaryItem.DisplayFormat = "{0:n4}";
                    }
                    else
                    {
                        column.Caption = PurchaseReceiptLocalizedResources.BLockCaptionMessage;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n5}";
                        column.OptionsColumn.AllowEdit = true;
                        column.SummaryItem.FieldName = column.FieldName;
                        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        column.SummaryItem.DisplayFormat = "{0:n5}";
                    }
                }
                //if (column.FieldName == "ICReceiptItemWoodQty")
                //{
                //    if (ICStockNo == "K-107" || ICStockNo == "K-106")
                //    {
                //        column.Visible = true;
                //        column.VisibleIndex = 9;
                //        column.DisplayFormat.FormatType = FormatType.Numeric;
                //        column.DisplayFormat.FormatString = "{0:n3}";
                //        column.OptionsColumn.AllowEdit = true;

                //    }
                //    else
                //    {
                //        column.Visible = false;
                //    }
                //}

            }
        }

        public void LoadGridViewByActionNewFromType(bool isManual, bool isWoodPurchase)
        {
            int countIndex = 1;
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = isManual;
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                List<ICMeasureUnitsInfo> measureUnits = controller.GetAllAliveMeasureUnit();
                rpMeasureUnit.DataSource = measureUnits;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemLotNo"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductExchangeQty"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemTotalCost"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                //column.VisibleIndex = countIndex++;
            }
            column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (isWoodPurchase)
                    column.Caption = "Khối lượng";
                else
                    column.Caption = "Số lượng";
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n5}";
                column.SummaryItem.FieldName = column.FieldName;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:n5}";
            }
            column = gridView.Columns["ICReceiptItemWoodQty"];
            if (column != null)
            {
                column.SummaryItem.FieldName = column.FieldName;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:n4}";
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.Visible = isWoodPurchase;
                //if (isWoodPurchase)
                //    column.VisibleIndex = countIndex++;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.Visible = isWoodPurchase;
                //if (isWoodPurchase)
                //    column.VisibleIndex = countIndex++;
            }
            //column = gridView.Columns["ICReceiptItemProductHeight"];
            //if (column != null)
            //{
            //    column.Visible = isWoodPurchase;
            //    if (isWoodPurchase)
            //        column.VisibleIndex = countIndex++;
            //}
            //column = gridView.Columns["ICReceiptItemProductWidth"];
            //if (column != null)
            //{
            //    column.Visible = isWoodPurchase;
            //    column.OptionsColumn.AllowEdit = isWoodPurchase;
            //    if (isWoodPurchase)
            //        column.VisibleIndex = countIndex++;
            //}
            //column = gridView.Columns["ICReceiptItemProductLength"];
            //if (column != null)
            //{
            //    column.Visible = isWoodPurchase;
            //    column.OptionsColumn.AllowEdit = isWoodPurchase;
            //    if (isWoodPurchase)
            //        column.VisibleIndex = countIndex++;
            //}
            gridView.BestFitColumns();
        }

        public void LoadGridViewByReceiptType(string productType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = new GridColumn();
            if (productType == ProductType.IngredientPaint.ToString())
            {
                column = (GridColumn)gridView.Columns["ICReceiptItemProductionDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.Caption = "Ngày sản xuất";
                    column.DisplayFormat.FormatType = FormatType.DateTime;
                    column.DisplayFormat.FormatString = "dd/MM/yyyy";
                }
                column = (GridColumn)gridView.Columns["ICReceiptItemExpiryDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.Caption = "Ngày hết hạn";
                    column.DisplayFormat.FormatType = FormatType.DateTime;
                    column.DisplayFormat.FormatString = "dd/MM/yyyy";
                }
            }
            else
            {
                column = (GridColumn)gridView.Columns["ICReceiptItemProductionDate"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = (GridColumn)gridView.Columns["ICReceiptItemProductionDate"];
                if (column != null)
                {
                    column.Visible = false;
                }
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

        //private void rpTerminal_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    GridView gridView = (GridView)MainView;
        //    ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    if (item != null)
        //    {
        //        GETerminalsController obj
        //        DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
        //        if (measureUnits != null)
        //        {
        //            lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
        //            lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
        //            lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
        //        }
        //        measureUnits.Dispose();
        //    }
        //}

        private void rpContainer_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                GEContainersController objContainersController = new GEContainersController();
                List<GEContainersInfo> containersList = objContainersController.GetContainersListByTerminalID(item.FK_GETerminalID);
                containersList.Insert(0, new GEContainersInfo());
                lookUpEdit.Properties.DataSource = containersList;
                lookUpEdit.Properties.DisplayMember = "GEContainerName";
                lookUpEdit.Properties.ValueMember = "GEContainerID";
            }
        }
        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptsInfo mainObject = (ICReceiptsInfo)entity.MainObject;
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
                        e.ErrorText = "Hệ số không được phép thay đổi";
                        e.Valid = false;
                    }
                }
                else if (gridView.FocusedColumn.FieldName == "ICReceiptItemProductUnitCost")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        if(mainObject.ICReceiptCreateFrom == "InvoiceIn")
                        {
                            e.ErrorText = "Đơn giá không được phép thay đổi";
                            e.Valid = false;
                        }
                        if (decimal.Parse(e.Value.ToString()) < 0)
                        {
                            e.ErrorText = "Đơn giá không được âm";
                            e.Valid = false;
                        }    
                    }
                }
            }
            else
            {
                e.ErrorText = "Đơn giá không được để trống";
                e.Valid = false;
            }
        }

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                {
                    PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                    GeneralHelper.ChangePurchaseItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                }
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                ((PurchaseReceiptModule)Screen.Module).InitProductPictureImage(entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].FK_ICProductID);
            }
        }
        private void rep_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICReceiptsInfo item = (ICReceiptsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                MMUpdatePositionItemsController controller = new MMUpdatePositionItemsController();
                List<MMUpdatePositionItemsInfo> updatePositionItems = controller.GetAllLocationNameByProduct(item.FK_ICProductID, item.FK_ICStockID, 0);
                if (updatePositionItems != null)
                {
                    lookUpEdit.Properties.DataSource = updatePositionItems;
                    lookUpEdit.Properties.DisplayMember = "MMUpdatePositionItemPositionName";
                    lookUpEdit.Properties.ValueMember = "MMUpdatePositionItemID";
                }
            }
        }
    }
}
