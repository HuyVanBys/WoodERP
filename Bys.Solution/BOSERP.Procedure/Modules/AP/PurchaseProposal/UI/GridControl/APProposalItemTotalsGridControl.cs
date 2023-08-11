using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class APProposalItemTotalsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PurchaseProposalItemTotalList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            foreach (GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = false;
            }

            gridView.ExpandAllGroups();
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
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
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
            {
                string value = "";
                if (e.Value != null)
                    value = e.Value.ToString();
                ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                ICProductAttributesInfo objProductsInfo = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(int.Parse(value));
                if (value != string.Empty && objProductsInfo != null)
                    e.DisplayText = objProductsInfo.ICProductAttributeValue;
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialSizeID")
            {
                string value = "";
                if (e.Value != null)
                    value = e.Value.ToString();
                ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                ICProductAttributesInfo objProductsInfo = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(int.Parse(value));
                if (value != string.Empty && objProductsInfo != null)
                    e.DisplayText = objProductsInfo.ICProductAttributeValue;
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                string value = "";
                if (e.Value != null)
                    value = e.Value.ToString();
                ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                ICProductAttributesInfo objProductsInfo = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(int.Parse(value));
                if (value != string.Empty && objProductsInfo != null)
                    e.DisplayText = objProductsInfo.ICProductAttributeValue;
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ICProductEquipmentID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(matchCodeID);
                    if (objProductsInfo != null)
                        e.DisplayText = objProductsInfo.ICProductDesc;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ACAssetID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ACAssetsController objAssetsController = new ACAssetsController();
                    ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(matchCodeID);
                    if (objAssetsInfo != null)
                        e.DisplayText = objAssetsInfo.ACAssetDesc;
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
        public void LoadGridViewForRoundWood(string productType)
        {
            GridView gridView = (GridView)MainView;

            GridColumn column = gridView.Columns["APProposalItemTotalProductQty"];
            if (column != null)
            {

                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.ArtificialBoard.ToString() || productType == ProductType.Verneer.ToString())
                {
                    if (productType == ProductType.Verneer.ToString())
                    {
                        column.Caption = PurchaseProposalLocalizedResources.VerneerM2;
                    }
                    else
                    {
                        column.Caption = PurchaseProposalLocalizedResources.BlockQuanlity;
                    }
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else if (productType == ProductType.IngredientPaint.ToString())
                {
                    column.Caption = PurchaseProposalLocalizedResources.Quanlity;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
                else
                {
                    column.Caption = PurchaseProposalLocalizedResources.Quanlity;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
            }
            column = gridView.Columns["APProposalItemTotalWoodQty"];
            {
                if (column != null)
                {
                    if (productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                    {
                        column.Caption = PurchaseProposalLocalizedResources.Quanlity;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n3}";
                        column.OptionsColumn.AllowEdit = false;
                        column.Visible = true;
                        column.VisibleIndex = 6;
                    }
                    else
                    {
                        column.Visible = false;
                    }
                }
            }

            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }
                else
                {
                    column.Visible = true;
                }
            }
            column = gridView.Columns["APProposalItemTotalProductHeight"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemTotalProductWidth"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemTotalProductWidthMax"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 9;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemTotalProductLenght"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 10;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemTotalProductLenghtMax"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemTotalProductPerimeter"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemTotalComment"];
            if (column != null)
            {
                //if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                //{
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 12;
                //}
                //else
                //{
                //    column.Visible = false;
                //}
            }
            column = gridView.Columns["APProposalItemTotalNeedTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 4;
            }
            column = gridView.Columns["APProposalItemTotalNeedToTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 5;
            }
            column = gridView.Columns["APProposalItemTotalPurchaseOrderQty"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Caption = PurchaseProposalLocalizedResources.APProposalItemTotalPurchaseOrderQty;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.IngredientPaint.ToString())
                {
                    column.Caption = PurchaseProposalLocalizedResources.APProposalItemTotalPurchaseOrderQty1;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else
                {
                    column.Caption = PurchaseProposalLocalizedResources.APProposalItemTotalPurchaseOrderQty1;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }

            column = gridView.Columns["APProposalItemTotalProductQtySter"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;

                }
            }
            column = gridView.Columns["APProposalItemTotalProductUnitCostSter"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;

                }
            }

            column = gridView.Columns["APProposalItemTotalTotalCostSter"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;

                }
            }

            column = gridView.Columns["APProposalItemTotalProductionNormItemTotalPaint"];
            if (column != null)
            {
                column.Visible = false;
            }

            column = gridView.Columns["APProposalItemTotalProductionNormItemTotalBlocks"];
            if (column != null)
            {
                column.Visible = false;
            }
            column = gridView.Columns["FK_MMFromOperationID"];
            if (column != null)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_MMToOperationID"];
            if (column != null)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
            }
            if (productType == ProductType.AlloyCover.ToString() || productType == ProductType.Rent.ToString()
                || productType == ProductType.WoodMDFOutSourcing.ToString() || productType == ProductType.MechanicOutSourcing.ToString()
                || productType == ProductType.Repair.ToString() || productType == ProductType.Other.ToString())
            {
                column = gridView.Columns["FK_ICProductEquipmentID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductDesc";
                    repositoryItemLookUpEdit.ValueMember = "ICProductID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit2_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.Caption = "CCDC";
                    column.Visible = true;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceToDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Caption = "Đến ngày";
                    column.Visible = true;
                }

                column = gridView.Columns["FK_ACAssetID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ACAssetDesc";
                    repositoryItemLookUpEdit.ValueMember = "ACAssetID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAssetNo", "Mã TS"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAssetDesc", "Mô tả"));
                    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit1_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.Caption = "TSCĐ";
                    column.Visible = true;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceFromDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Caption = "Từ ngày";
                    column.Visible = true;
                }
            }
            else
            {
                column = gridView.Columns["FK_ICProductEquipmentID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceToDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }

                column = gridView.Columns["FK_ACAssetID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceFromDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }
            }
            gridView.BestFitColumns();
        }

        void repositoryItemLookUpEdit2_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsInfoList = objProductsController.GetEquipmentByProductType(ProductType.Equipment.ToString());
            if (objProductsInfoList != null && objProductsInfoList.Count > 0)
            {

                lookUpEdit.Properties.DataSource = objProductsInfoList;

            }
        }

        void repositoryItemLookUpEdit1_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAssetsController objAssetsController = new ACAssetsController();
            List<ACAssetsInfo> objAssetsInfoList = objAssetsController.GetAssetsForLookupEditControl();
            if (objAssetsInfoList != null && objAssetsInfoList.Count > 0)
            {

                lookUpEdit.Properties.DataSource = objAssetsInfoList;

            }
        }
        public void LoadGridViewForPurchasePlanOutSourcing()
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["APProposalItemTotalProductionNormItemTotalPaint"];
            if (column != null && column.FieldName == "APProposalItemTotalProductionNormItemTotalPaint")
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APProposalItemTotalProductionNormItemTotalBlocks"];
            if (column != null && column.FieldName == "APProposalItemTotalProductionNormItemTotalBlocks")
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_MMFromOperationID"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_MMToOperationID"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APProposalItemTotalProductQty"];
            if (column != null)
            {
                column.Caption = PurchaseProposalLocalizedResources.Quanlity;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
            }
            column = gridView.Columns["APProposalItemTotalPurchaseOrderQty"];
            if (column != null)
            {
                column.Caption = PurchaseProposalLocalizedResources.APProposalItemTotalPurchaseOrderQty1;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }

            gridView.BestFitColumns();
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }


        public void FormatQuantity(string type)
        {
            GridView gridView = (GridView)MainView;
            PurchaseProposalEntities entity = (PurchaseProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (type == ProductType.IngredientPaint.ToString() ||
                type == ProductType.Roundwood.ToString() || type == ProductType.Lumber.ToString()
                    || type == ProductType.Verneer.ToString() || type == ProductType.ArtificialBoard.ToString())
            {
                if (gridView.Columns["APProposalItemTotalPurchaseOrderQty"] != null)
                {
                    SetFormat("APProposalItemTotalPurchaseOrderQty", "n4", gridView);
                }
                if (gridView.Columns["APProposalItemTotalProductQty"] != null)
                {
                    SetFormat("APProposalItemTotalProductQty", "n4", gridView);
                }

            }
            else
            {
                if (gridView.Columns["APProposalItemTotalPurchaseOrderQty"] != null)
                {
                    SetFormat("APProposalItemTotalPurchaseOrderQty", "n2", gridView);
                }
                if (gridView.Columns["APProposalItemTotalProductQty"] != null)
                {
                    SetFormat("APProposalItemTotalProductQty", "n2", gridView);
                }

            }
        }

    }
}
