using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
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

namespace BOSERP.Modules.WoodPurchaseReceipt
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.ICSerialNo;
            column.FieldName = "SerialNo";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit SerialNo = new RepositoryItemHyperLinkEdit();
            SerialNo.NullText = WoodPurchaseReceiptLocalizedResources.ICSerialNo;
            SerialNo.Click += new EventHandler(SerialNo_Click);
            column.ColumnEdit = SerialNo;
            gridView.Columns.Add(column);

            GridColumn column2 = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column2 != null)
                column2.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["ICReceiptItemProductLength"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["ICReceiptItemProductPerimeter"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;

            column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.ProductWidth;
            column.FieldName = "ICReceiptItemProductWidth";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.ProductHeigh;
            column.FieldName = "ICReceiptItemProductHeight";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.LotNoCaption;
            column.FieldName = "ICReceiptItemLotNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            //TKChinh [Add] 21/06/2016
            column = new GridColumn();
            column.Caption = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            column.FieldName = "AddNewRow";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            AddNewRow.NullText = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            AddNewRow.Click += new EventHandler(AddNewRow_Click);
            column.ColumnEdit = AddNewRow;

            gridView.Columns.Add(column);
            //TKChinh [End]

            /*column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.WoodQty;
            column.FieldName = "ICReceiptItemWoodQty";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.ProductQty;
            column.FieldName = "ICReceiptItemProductQty";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;*/
        }
        //TKChinh [Add] 21/06/2016
        private void AddNewRow_Click(object sender, EventArgs e)
        {
            if (!(this.Screen.Module as WoodPurchaseReceiptModule).Toolbar.IsNullOrNoneAction())
            {
                WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)(this.Screen.Module as WoodPurchaseReceiptModule).CurrentModuleEntity;
                ICReceiptsInfo receiptsInfo = (ICReceiptsInfo)entity.MainObject;
                ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                objReceiptItemsInfo.Id = 0;
                entity.ReceiptItemsList.Add(objReceiptItemsInfo);
                entity.ReceiptItemsList.GridControl.RefreshDataSource();
            }
        }
        //TKChinh [End]

        private void SerialNo_Click(object sender, EventArgs e)
        {
            WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            if ((long)objICReceiptItemsInfo.ICReceiptItemWoodQty > 0)
            {
                long receiptItemWoodQty = (long)objICReceiptItemsInfo.ICReceiptItemWoodQty;
                ((WoodPurchaseReceiptModule)Screen.Module).ChangeQTyFromReceiptItemsList(receiptItemWoodQty);
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                ((WoodPurchaseReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
            }

        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = objICReceiptItemsInfo;

                //entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];

                //ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                //ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);

                if (e.Column.FieldName == "ICReceiptItemProductSerialNo")
                {
                    ((WoodPurchaseReceiptModule)Screen.Module).CheckExistSerialNo(objICReceiptItemsInfo);
                }
                if (e.Column.FieldName == "ICReceiptItemProductPerimeter" || e.Column.FieldName == "ICReceiptItemProductLength"
                    || e.Column.FieldName == "ICReceiptItemProductWidth" || e.Column.FieldName == "ICReceiptItemWidthMax"
                    || e.Column.FieldName == "ICReceiptItemProductHeight" || e.Column.FieldName == "ICReceiptItemLenghtMax"
                    || e.Column.FieldName == "ICReceiptItemExceptedBlock")
                {

                    if (objICReceiptItemsInfo != null)
                    {
                        ((WoodPurchaseReceiptModule)Screen.Module).ResetItemQuantity(objICReceiptItemsInfo);
                        ((WoodPurchaseReceiptModule)Screen.Module).UpdateReceiptItemProductDesc(objICReceiptItemsInfo);
                    }
                }
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    //ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                    ((WoodPurchaseReceiptModule)Screen.Module).ChangeStockInItemList(objICReceiptItemsInfo);
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((WoodPurchaseReceiptModule)Screen.Module).ChangeItemMeasureUnit(objICReceiptItemsInfo);
                }
                //if (gridView.FocusedRowHandle >= 0)
                //{

                if ((e.Column.FieldName == "ICReceiptItemWoodQty" || e.Column.FieldName == "ICReceiptItemProductLength" || e.Column.FieldName == "ICReceiptItemProductWidth")
                        && objReceiptsInfo.ICReceiptReceiptType == ReceiptReceiptType.Verneer.ToString())
                {
                    objICReceiptItemsInfo.ICReceiptItemProductQty = objICReceiptItemsInfo.ICReceiptItemWoodQty * objICReceiptItemsInfo.ICReceiptItemProductLength * objICReceiptItemsInfo.ICReceiptItemProductWidth * Convert.ToDecimal(Math.Pow(10, -6));
                    objICReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(objICReceiptItemsInfo.ICReceiptItemProductQty, 4, MidpointRounding.AwayFromZero);
                }
                //}
                ((WoodPurchaseReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();

                entity.ReceiptItemsList.GridControl.RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((WoodPurchaseReceiptModule)Screen.Module).DeleteItemFromReceiptItemsList();
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

            GridColumn column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemNotJetExceptBlock"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICReceiptItemContainerNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
            column = gridView.Columns["ICReceiptItemWidthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLenghtMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", WoodPurchaseReceiptLocalizedResources.APInvoiceInItemProductWoodTypeNoCaption));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", WoodPurchaseReceiptLocalizedResources.APInvoiceInItemProductWoodTypeValueCaption));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", WoodPurchaseReceiptLocalizedResources.APInvoiceInItemProductTTMTCaption));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditTTMT_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", WoodPurchaseReceiptLocalizedResources.APInvoiceInItemProductQualityNoCaption));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", WoodPurchaseReceiptLocalizedResources.APInvoiceInItemProductQualityValueCaption));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditQuality_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["ICReceiptItemProductAttribute"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["ICReceiptItemProductQtySter"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICReceiptItemProductUnitCostSter"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICReceiptItemTotalCostSter"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
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
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            return gridView;
        }
        public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        public void repositoryItemLookUpEditTTMT_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeTTMTColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        public void repositoryItemLookUpEditQuality_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeQualityColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        //public void repositoryItemLookUpEditOrigin_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    GECountrysController objCountrysController = new GECountrysController();
        //    List<GECountrysInfo> countryList = new List<GECountrysInfo>();
        //    GECountrysInfo objCountrysInfo = new GECountrysInfo();
        //    objCountrysInfo.GECountryID = 0;
        //    countryList = objCountrysController.GetAllCountry();
        //    if (countryList != null)
        //    {
        //        countryList.Insert(0, objCountrysInfo);
        //        lookUpEdit.Properties.DataSource = countryList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "GECountryName";
        //    lookUpEdit.Properties.ValueMember = "GECountryID";
        //}
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
                WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string woodType = dbUtil.GetPropertyStringValue(objReceiptsInfo, "ICReceiptICReceiptType");
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

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
                    if (objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "FK_ICProductAttributeTTMTID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
                    if (objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
                    if (objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }


            //if (e.Column.FieldName == "FK_GECountryID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        GECountrysController objCountrysController = new GECountrysController();
            //        GECountrysInfo objCountrysInfo = (GECountrysInfo)objCountrysController.GetObjectByID(matchCodeID);
            //        if (objCountrysInfo != null)
            //            e.DisplayText = objCountrysInfo.GECountryName;
            //        else
            //            e.DisplayText = "";
            //    }
            //    else
            //        e.DisplayText = "";
            //}
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
