using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn
{
    public partial class APInvoiceInItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceInItemsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = "Dày(mm)";
            column.FieldName = "APInvoiceInItemProductHeight";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng(mm)";
            column.FieldName = "APInvoiceInItemProductWidth";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = InvoiceInLocalizedResources.ItemCopyNewRow;
            column.FieldName = "APInvoiceInItemCopyItem";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemAddNewRow = new RepositoryItemHyperLinkEdit(); ;
            rpItemAddNewRow.NullText = InvoiceInLocalizedResources.ItemCopyNewRow;
            rpItemAddNewRow.Click += new EventHandler(rpItemAddNewRow_Click);
            column.ColumnEdit = rpItemAddNewRow;
            gridView.Columns.Add(column);
        }

        private void rpItemAddNewRow_Click(object sender, EventArgs e)
        {
            ((InvoiceInModule)Screen.Module).CopyItemToNewRow();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CellValueChanging += GridView_CellValueChanging;
            if (gridView.Columns["APInvoiceInItemProductQty"] != null)
                gridView.Columns["APInvoiceInItemProductQty"].OptionsColumn.AllowEdit = true;
            GridColumn column = gridView.Columns["APInvoiceInItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemButtonEdit buttonEdit = new RepositoryItemButtonEdit();
                buttonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(RepositoryUnitCostButtonEdit_ButtonClick);
                column.ColumnEdit = buttonEdit;
                InitColumnRepositoryFormat(column, TableName.APInvoiceInItemsTableName, "APInvoiceInItemProductUnitCost");
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APInvoiceInItemWoodQty"] != null)
            {
                gridView.Columns["APInvoiceInItemWoodQty"].OptionsColumn.AllowEdit = true;
                gridView.Columns["APInvoiceInItemWoodQty"].Visible = true;
            }

            if (gridView.Columns["APInvoiceInItemProductDiscount"] != null)
                gridView.Columns["APInvoiceInItemProductDiscount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APInvoiceInItemProductTaxPercent"] != null)
                gridView.Columns["APInvoiceInItemProductTaxPercent"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APInvoiceInItemComment"] != null)
                gridView.Columns["APInvoiceInItemComment"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APInvoiceInItemContainerNo"] != null)
                gridView.Columns["APInvoiceInItemContainerNo"].OptionsColumn.AllowEdit = true;

            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryAttributeWood = new RepositoryItemLookUpEdit();
                repositoryAttributeWood.DisplayMember = "ICProductAttributeValue";
                repositoryAttributeWood.ValueMember = "ICProductAttributeID";
                repositoryAttributeWood.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryAttributeWood.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                List<ICProductAttributesInfo> list = (new ICProductAttributesController()).GetProductAttributeValueByWoodType();
                repositoryAttributeWood.DataSource = list;
                repositoryAttributeWood.NullText = string.Empty;
                repositoryAttributeWood.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại gỗ"));
                repositoryAttributeWood.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryAttributeWood_QueryPopUp);
                column.ColumnEdit = repositoryAttributeWood;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;

            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

            }

            column = gridView.Columns["FK_ICModelID"];
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
            column = gridView.Columns["APInvoiceInItemProductUnitCostTam"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }
            column = gridView.Columns["APInvoiceInItemTotalCostTam"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACUnfinishedConstructionCostName";
                repositoryItemLookUpEdit.ValueMember = "ACUnfinishedConstructionCostID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ACUnfinishedConstructionCostsTableName] as DataSet;
                if (ds == null)
                {
                    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
                    repositoryItemLookUpEdit.DataSource = objUnfinishedConstructionCostsController.GetAllObjects();
                }
                else
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chi phí"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chi phí"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditUnfinishedConstructionCost_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["APInvoiceInItemHasProductPackage"];
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
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ICMeasureUnitsTableName);
                    BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] = ds;
                }
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;

            }

            column = gridView.Columns["APInvoiceInItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            //gridView.KeyDown += new KeyEventHandler(GridView_KeyDown);
            column = gridView.Columns["FK_VMVehicleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APInvoiceInItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APInvoiceInItemLotNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        private void repositoryAttributeWood_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> list = (new ICProductAttributesController()).GetProductAttributeValueByWoodType();
            lookUpEdit.Properties.DataSource = list;
        }

        protected void repositoryItemLookUpEditUnfinishedConstructionCost_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
            List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataForLookupEditControl();
            List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
            coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
            coListFinal.AddRange(coList);
            lookUpEdit.Properties.DataSource = coListFinal;
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            InvoiceInEntities entity = (InvoiceInEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APInvoiceInItemsInfo item = (APInvoiceInItemsInfo)entity.InvoiceInItemsList[entity.InvoiceInItemsList.CurrentIndex];
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

        public void LoadGridViewForRoundWood(bool isWoodType)
        {
            if (isWoodType)
            {
                foreach (GridColumn column in Columns)
                {
                    if (column.FieldName == "FK_ICProductID")//Mã sản phẩm
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 0;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductDesc")// Mô tả
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 1;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_ICMeasureUnitID")// Đơn vị tính
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 2;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductQty")// Khối lượng
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.Caption = "Khối lượng";
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n5}";
                        column.VisibleIndex = 3;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemWoodQty")// Số thanh (tấm)
                    {
                        column.Caption = CommonLocalizedResources.WoodQtyText;
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 4;
                        column.Visible = true;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n5}";
                    }
                    else if (column.FieldName == "APInvoiceInItemProductUnitCost")// Đơn giá
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 5;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemExtCost")// Tổng giá mua
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 6;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemExchangeExtCost")// Tiền hàng VND
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 7;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductDiscount")// %CK
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 8;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemDiscountAmount")// Tiền chiết khấu
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 9;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_GECountryID")// Xuất xứ
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 10;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_ICProductAttributeTTMTID")// Tình trạng môi trường
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 11;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_ICProductAttributeQualityID")// Chất lượng
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 12;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemReceiptedQty")// Khối lượng đã nhận
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n5}";
                        column.Caption = "Khối lượng đã nhận";
                        column.VisibleIndex = 13;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemQty1")// Số lượng đã nhận
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n5}";
                        column.VisibleIndex = 14;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_ACUnfinishedConstructionCostID")// CPXD cơ bản dở dang
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 15;
                        column.Visible = true;
                    }
                    else
                    {
                        column.Visible = false;
                    }
                }
            }
            else
            {
                foreach (GridColumn column in Columns)
                {
                    if (column.FieldName == "FK_ICProductID")//Mã sản phẩm
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 0;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductDesc")// Mô tả
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 1;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_ICMeasureUnitID")// Đơn vị tính
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 2;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductQty")// Số lượng
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.Caption = "Số lượng";
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n4}";
                        column.VisibleIndex = 3;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductUnitCost")// Đơn giá
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 4;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemExtCost")// Tổng giá mua
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 5;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemExchangeExtCost")// Tiền hàng VND
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 6;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductDiscount")// %CK
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 7;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemDiscountAmount")// Tiền chiết khấu
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 8;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemProductTaxPercent")// %thuế
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 9;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemTaxAmount")// Tiền thuế
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 10;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemExchangeTaxAmount")// Tiền thuế VND
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 11;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemTotalCost")// Thành tiền
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 12;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemExchangeTotalCost")// Tổng tiền VND
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 13;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_GECountryID")// Xuất xứ
                    {
                        column.OptionsColumn.AllowEdit = true;
                        column.VisibleIndex = 14;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "APInvoiceInItemReceiptedQty")// Số lượng đã nhận
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.Caption = "Số lượng đã nhận";
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n4}";
                        column.VisibleIndex = 15;
                        column.Visible = true;
                    }
                    else if (column.FieldName == "FK_ACUnfinishedConstructionCostID")// CPXD cơ bản dở dang
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.VisibleIndex = 16;
                        column.Visible = true;
                    }
                    else
                    {
                        column.Visible = false;
                    }
                }
            }
            GridView view = this.MainView as GridView;
            view.BestFitColumns();
        }

        private void RepositoryUnitCostButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((InvoiceInModule)Screen.Module).CompareUnitCost();
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            InvoiceInEntities entity = (InvoiceInEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.InvoiceInItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.APInvoiceInItemsTableName] = (APInvoiceInItemsInfo)entity.InvoiceInItemsList[entity.InvoiceInItemsList.CurrentIndex];
                APInvoiceInItemsInfo item = (APInvoiceInItemsInfo)entity.InvoiceInItemsList[entity.InvoiceInItemsList.CurrentIndex];
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((InvoiceInModule)Screen.Module).ResetModelDetail(item);
                }
                if (gridView.FocusedRowHandle >= 0)
                {
                    APInvoiceInItemsInfo items = (APInvoiceInItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    APInvoiceInsInfo info = (APInvoiceInsInfo)entity.MainObject;
                    if (e.Column.FieldName == "APInvoiceInItemProductUnitCostTam" || e.Column.FieldName == "APInvoiceInItemWoodQty")
                    {
                        items.APInvoiceInItemTotalCostTam = items.APInvoiceInItemProductUnitCostTam * items.APInvoiceInItemWoodQty;
                    }
                    if (e.Column.FieldName == "APInvoiceInItemProductQtySter")
                    {
                        items.APInvoiceInItemProductQty = items.APInvoiceInItemProductQtySter * Convert.ToDecimal(0.8);
                        items.APInvoiceInItemTotalCostSter = items.APInvoiceInItemProductQtySter * items.APInvoiceInItemProductUnitCostSter;
                    }
                    if (e.Column.FieldName == "APInvoiceInItemProductUnitCostSter")
                    {
                        items.APInvoiceInItemProductUnitCost = items.APInvoiceInItemProductUnitCostSter / Convert.ToDecimal(0.8);
                        items.APInvoiceInItemTotalCostSter = items.APInvoiceInItemProductQtySter * items.APInvoiceInItemProductUnitCostSter;
                    }
                    if (e.Column.FieldName == "FK_ICMeasureUnitID")
                    {
                        ((InvoiceInModule)Screen.Module).ChangeItemMeasureUnit(item);
                    }
                }
                (entity.Module as InvoiceInModule).ChangeItemFromInvoiceInItemsList();
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                ((InvoiceInModule)Screen.Module).DeleteItemFromInvoiceInItemsList();
            }
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

        //public void repositoryItemUnfinishedLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;

        //    ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
        //    List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataNewStatusForLookupEditControl();
        //    List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
        //    coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
        //    coListFinal.AddRange(coList);

        //    lookUpEdit.Properties.DataSource = coListFinal;

        //    lookUpEdit.Properties.DisplayMember = "ACUnfinishedConstructionCostName";
        //    lookUpEdit.Properties.ValueMember = "ACUnfinishedConstructionCostID";
        //}

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            APInvoiceInItemsInfo item = (APInvoiceInItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
            APInvoiceInItemsInfo item = (APInvoiceInItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "APInvoiceInItemProductFactor")
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

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                {
                    InvoiceInEntities entity = (InvoiceInEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    APInvoiceInItemsInfo item = (APInvoiceInItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                    GeneralHelper.ChangePurchaseItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                }
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            InvoiceInEntities entity = (InvoiceInEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.InvoiceInItemsList.CurrentIndex >= 0)
            {
                ((InvoiceInModule)Screen.Module).InitProductPictureImage(entity.InvoiceInItemsList[entity.InvoiceInItemsList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}
