using BOSCommon;
using BOSCommon.Constants;
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
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrderForWood
{
    public partial class RoundWoodtemsGridControl : ItemGridControl
    {
        private string SerieColumnName = string.Empty;
        public override void InitGridControlDataSource()
        {
            SaleOrderForWoodEntities entity = (SaleOrderForWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RoundWoodList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = SaleOrderLocalizedResources.ARSaleOrderItemRemainedWQty;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "ARSaleOrderItemRemainedQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.SOItemComponent;
            column.FieldName = "ARSOItemComponent";
            column.OptionsColumn.AllowEdit = true;

            //RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            //rpItemComponent.NullText = SaleOrderLocalizedResources.ItemComponentList;
            //rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            //column.ColumnEdit = rpItemComponent;

            gridView.Columns.Add(column);


        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            SaleOrderForWoodEntities entity = (SaleOrderForWoodEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)entity.MainObject;
            if (entity.RoundWoodList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ARSaleOrderItemsInfo item = entity.RoundWoodList[entity.RoundWoodList.CurrentIndex];
                //entity.ModuleObjects[TableName.ARSaleOrderItemsTableName] = (ARSaleOrderItemsInfo)item.Clone();
                //(entity.Module as SaleOrderForWoodModule).ChangeItemFromSaleOrderItemsList();

                if (e.Column.FieldName == "ARSaleOrderItemProductQty")
                {
                    ((SaleOrderForWoodModule)Screen.Module).ChangeComponentItemQty();
                    if (item.ARSaleOrderItemProductQty > item.ARSaleOrderItemProductInventoryQty)
                    {
                        MessageBox.Show(SaleOrderLocalizedResources.InventoryQty, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        entity.RoundWoodList[entity.RoundWoodList.CurrentIndex].ARSaleOrderItemProductQty = Convert.ToDecimal(gridView.ActiveEditor.OldEditValue);
                    }
                }

                //Bị rào lại
                //if (e.Column.FieldName == "ARSaleOrderItemProductSerialNo")
                //{
                //    ((SaleOrderForWoodModule)Screen.Module).ChangeItemSerieNo(item);
                //}

                //TKChinh [Add] [07/07/2016]
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                int count = 0;
                count = objInvoiceItemsController.GetCountInvoiceBySaleOrderID(mainObject.ARSaleOrderID);

                if (count == 0 && mainObject.ARSaleOrderStatus == SaleOrderStatus.Confirmed.ToString())
                {

                    if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice2")
                    {
                        item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
                        entity.RoundByCurrency(item);
                    }
                }

                entity.ModuleObjects[TableName.ARSaleOrderItemsTableName] = (ARSaleOrderItemsInfo)item.Clone();
                (entity.Module as SaleOrderForWoodModule).ChangeItemFromSaleOrderItemsList();
                if (e.Column.FieldName == "ARSaleOrderItemProductSerialNo")
                {
                    ((SaleOrderForWoodModule)Screen.Module).ChangeItemSerieNo(item);
                }


                if (count == 0 && mainObject.ARSaleOrderStatus == SaleOrderStatus.Confirmed.ToString())
                {
                    if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice")
                    {
                        ((SaleOrderForWoodModule)Screen.Module).CheckPaymentTimeAmount();
                    }
                }
                if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice")
                {
                    ((SaleOrderForWoodModule)Screen.Module).UpdateTotalAmountByCurrency(mainObject.FK_GECurrencyID);
                }
                //TKChinh End
                ((SaleOrderForWoodModule)Screen.Module).CheckPaymentTimeAmount();
            }

        }




        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            foreach (GridColumn columnedit in gridView.Columns)
            {
                columnedit.OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_ICProductID"] != null)
            {

                gridView.Columns["FK_ICProductID"].OptionsColumn.AllowEdit = false;

            }
            if (gridView.Columns["ARSaleOrderItemProductSerialNo"] != null)
            {
                gridView.Columns["ARSaleOrderItemProductSerialNo"].Caption = SaleOrderLocalizedResources.ProductSerialNoRoundWood;


            }
            if (gridView.Columns["ARSaleOrderItemProductDesc"] != null)
            {

                gridView.Columns["ARSaleOrderItemProductDesc"].OptionsColumn.AllowEdit = false;
            }
            if (gridView.Columns["ARSaleOrderItemProductQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemProductQty"].Caption = SaleOrderLocalizedResources.ProductQty;
            }

            if (gridView.Columns["ARSaleOrderItemProductName"] != null)
            {

                gridView.Columns["ARSaleOrderItemProductName"].OptionsColumn.AllowEdit = false;
            }
            if (gridView.Columns["ARSaleOrderItemProductInventoryQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemProductInventoryQty"].OptionsColumn.AllowEdit = false;
            }
            if (gridView.Columns["FK_ARSaleOrderID"] != null)
                gridView.Columns["FK_ARSaleOrderID"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARSaleOrderItemRemainedQty"] != null)
                gridView.Columns["ARSaleOrderItemRemainedQty"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARSaleOrderItemShippedQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemShippedQty"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ARSaleOrderItemShippedQty"].Caption = SaleOrderLocalizedResources.ARSaleOrderItemShippedQty;
                SetFormat("ARSaleOrderItemShippedQty", "n4", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemCanceledQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemCanceledQty"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ARSaleOrderItemCanceledQty"].Caption = SaleOrderLocalizedResources.ARSaleOrderItemCanceledQty;
                SetFormat("ARSaleOrderItemCanceledQty", "n4", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemDiscountAmount2"] != null)
                gridView.Columns["ARSaleOrderItemDiscountAmount2"].OptionsColumn.AllowEdit = false;
            GridColumn column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit AttributeTTMTID = new RepositoryItemLookUpEdit();
                AttributeTTMTID.DisplayMember = "ICProductAttributeValue";
                AttributeTTMTID.ValueMember = "ICProductAttributeID";
                AttributeTTMTID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                AttributeTTMTID.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                AttributeTTMTID.NullText = string.Empty;
                AttributeTTMTID.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                AttributeTTMTID.QueryPopUp += new System.ComponentModel.CancelEventHandler(AttributeTTMTID_QueryPopUp);
                column.ColumnEdit = AttributeTTMTID;
            }


            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit AttributeQualityIDLookUpEdit = new RepositoryItemLookUpEdit();
                AttributeQualityIDLookUpEdit.DisplayMember = "ICProductAttributeValue";
                AttributeQualityIDLookUpEdit.ValueMember = "ICProductAttributeID";
                AttributeQualityIDLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                AttributeQualityIDLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                AttributeQualityIDLookUpEdit.NullText = string.Empty;
                AttributeQualityIDLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                AttributeQualityIDLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(AttributeQualityIDLookUpEdit_QueryPopUp);
                column.ColumnEdit = AttributeQualityIDLookUpEdit;
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
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            if (gridView.Columns["ARSaleOrderItemWoodQty"] != null)
            {
                SetFormat("ARSaleOrderItemWoodQty", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemProductQty"] != null)
            {
                SetFormat("ARSaleOrderItemProductQty", "n4", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemHeight"] != null)
            {
                SetFormat("ARSaleOrderItemHeight", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemWidth"] != null)
            {
                SetFormat("ARSaleOrderItemWidth", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemLength"] != null)
            {
                SetFormat("ARSaleOrderItemLength", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemPerimeter"] != null)
            {
                SetFormat("ARSaleOrderItemPerimeter", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemHeightMin"] != null)
            {
                SetFormat("ARSaleOrderItemHeightMin", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemWidthMin"] != null)
            {
                SetFormat("ARSaleOrderItemWidthMin", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemLengthMin"] != null)
            {
                SetFormat("ARSaleOrderItemLengthMin", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemPerimeterMin"] != null)
            {
                SetFormat("ARSaleOrderItemPerimeterMin", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemHeightMax"] != null)
            {
                SetFormat("ARSaleOrderItemHeightMax", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemWidthMax"] != null)
            {
                SetFormat("ARSaleOrderItemWidthMax", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemLentghMax"] != null)
            {
                SetFormat("ARSaleOrderItemLentghMax", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemPerimeterMax"] != null)
            {
                SetFormat("ARSaleOrderItemPerimeterMax", "n3", gridView);
            }




            return gridView;
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.WoodType.ToString());
            if (productAttributesList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttributesList;
            }
        }

        void AttributeQualityIDLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());
            if (productAttributesList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttributesList;
            }
        }

        void AttributeTTMTID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.TTMT.ToString());
            if (productAttributesList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttributesList;
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderForWoodModule)Screen.Module).DeleteItemRoundWoodList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }





        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //ShowInventory();
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

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }

        }

        public void LoadGridViewEditPrice(bool IsEditPrice)
        {
            GridView gridView = (GridView)MainView;
            if (IsEditPrice == true)
            {
                foreach (GridColumn columnedit in gridView.Columns)
                {
                    columnedit.OptionsColumn.AllowEdit = false;
                }
                GridColumn column = gridView.Columns["ARSaleOrderItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                column = gridView.Columns["ARSaleOrderItemProductUnitPrice2"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                foreach (GridColumn columnedit in gridView.Columns)
                {
                    columnedit.OptionsColumn.AllowEdit = true;
                }
                if (gridView.Columns["FK_ICProductID"] != null)
                {
                    gridView.Columns["FK_ICProductID"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARSaleOrderItemProductDesc"] != null)
                {
                    gridView.Columns["ARSaleOrderItemProductDesc"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARSaleOrderItemProductName"] != null)
                {
                    gridView.Columns["ARSaleOrderItemProductName"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["FK_ARSaleOrderID"] != null)
                    gridView.Columns["FK_ARSaleOrderID"].OptionsColumn.AllowEdit = false;

                if (gridView.Columns["ARSaleOrderItemRemainedQty"] != null)
                    gridView.Columns["ARSaleOrderItemRemainedQty"].OptionsColumn.AllowEdit = false;

                if (gridView.Columns["ARSaleOrderItemShippedQty"] != null)
                {
                    gridView.Columns["ARSaleOrderItemShippedQty"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARSaleOrderItemCanceledQty"] != null)
                {
                    gridView.Columns["ARSaleOrderItemCanceledQty"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARSaleOrderItemDiscountAmount2"] != null)
                    gridView.Columns["ARSaleOrderItemDiscountAmount2"].OptionsColumn.AllowEdit = false;
                GridColumn column = gridView.Columns["FK_ICProductAttributeQualityID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }

                column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                if (gridView.Columns["ARSaleOrderItemProductInventoryQty"] != null)
                {
                    gridView.Columns["ARSaleOrderItemProductInventoryQty"].OptionsColumn.AllowEdit = false;
                }
                column = gridView.Columns["ICProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Caption = SaleOrderLocalizedResources.ProductUnitPrice;
                }
            }
        }
    }
}

