using BOSCommon;
using BOSCommon.Constants;
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
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentProposal
{
    public class ICShipmentProposalItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentProposalItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "CopyLine";
            column.Caption = "Thêm dòng";
            RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = "Thêm dòng";
            rep.Click += new EventHandler(rep_Click);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);

        }

        void rep_Click(object sender, EventArgs e)
        {
            if (!((ShipmentProposalModule)Screen.Module).Toolbar.IsNullOrNoneAction())
            {
                ((ShipmentProposalModule)Screen.Module).CopyLine();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            if (gridView.Columns["ICShipmentProposalItemProductQty"] != null)
                gridView.Columns["ICShipmentProposalItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICPriority"] != null)
                gridView.Columns["ICPriority"].OptionsColumn.AllowEdit = true;
            //[NKVung] [START]
            if (gridView.Columns["ICShipmentProposalItemProductSerialNo"] != null)
                gridView.Columns["ICShipmentProposalItemProductSerialNo"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICProductAttributeTTMTID"] != null)
                gridView.Columns["FK_ICProductAttributeTTMTID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICProductAttributeID"] != null)
                gridView.Columns["FK_ICProductAttributeID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_GECountryID"] != null)
                gridView.Columns["FK_GECountryID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICProductAttributeQualityID"] != null)
                gridView.Columns["FK_ICProductAttributeQualityID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemWoodQty"] != null)
                gridView.Columns["ICShipmentProposalItemWoodQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemHeight"] != null)
                gridView.Columns["ICShipmentProposalItemHeight"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemWidth"] != null)
                gridView.Columns["ICShipmentProposalItemWidth"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemLength"] != null)
                gridView.Columns["ICShipmentProposalItemLength"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemPerimeter"] != null)
                gridView.Columns["ICShipmentProposalItemPerimeter"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemHeightMin"] != null)
                gridView.Columns["ICShipmentProposalItemHeightMin"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemWidthMin"] != null)
                gridView.Columns["ICShipmentProposalItemWidthMin"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemLengthMin"] != null)
                gridView.Columns["ICShipmentProposalItemLengthMin"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemPerimeterMin"] != null)
                gridView.Columns["ICShipmentProposalItemPerimeterMin"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemHeightMax"] != null)
                gridView.Columns["ICShipmentProposalItemHeightMax"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemWidthMax"] != null)
                gridView.Columns["ICShipmentProposalItemWidthMax"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemLentghMax"] != null)
                gridView.Columns["ICShipmentProposalItemLentghMax"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemPerimeterMax"] != null)
                gridView.Columns["ICShipmentProposalItemPerimeterMax"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICShipmentProposalItemLotNo"] != null)
                gridView.Columns["ICShipmentProposalItemLotNo"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
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
            column = gridView.Columns["FK_ACAssetID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
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
            column = gridView.Columns["FK_ICProductEquipmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductDesc";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "CCDC";
                column.Visible = true;
            }
            //[NKVung] [END]
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
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

            if (gridView.Columns["ICShipmentProposalItemProductDesc"] != null)
                gridView.Columns["ICShipmentProposalItemProductDesc"].OptionsColumn.AllowEdit = true;

            return gridView;
        }
        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICShipmentProposalItemsInfo item = (ICShipmentProposalItemsInfo)entity.ShipmentProposalItemList[entity.ShipmentProposalItemList.CurrentIndex];
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ShipmentProposalEntities entity = (ShipmentProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ShipmentProposalItemList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICShipmentProposalItemsInfo item = (ICShipmentProposalItemsInfo)entity.ShipmentProposalItemList[entity.ShipmentProposalItemList.CurrentIndex];
                if (e.Column.FieldName == "ICShipmentProposalItemProductSerialNo")
                {
                    ((ShipmentProposalModule)Screen.Module).ChangeItemSerieNo(item);
                    ((ShipmentProposalModule)Screen.Module).ShipmentProposalItem(item);
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    //((ShipmentProposalModule)Screen.Module).SelectSeriesNoDefault();
                    //((ShipmentProposalModule)Screen.Module).ChangeItemSerieNo(item);
                }
                if (e.Column.FieldName == "ICShipmentProposalItemProductQty")
                {
                    ((ShipmentProposalModule)Screen.Module).ShipmentProposalItem(item);
                }
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((ShipmentProposalModule)Screen.Module).ResetModelDetail(item);
                }
            }
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
        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsInfoList = objProductsController.GetEquipmentByProductType(ProductType.Equipment.ToString());
            if (objProductsInfoList != null && objProductsInfoList.Count > 0)
            {

                lookUpEdit.Properties.DataSource = objProductsInfoList;

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
        //[NKVung] [Load GridView By Product Type] [START]
        public void LoadGridViewByProductType(string productType)
        {
            GridView gridView = (GridView)MainView;

            /* Thêm dòng , START */
            GridColumn column = gridView.Columns["CopyLine"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                column.VisibleIndex = 0;
            }
            /* Thêm dòng , END */


            column = gridView.Columns["FK_ICProductID"];

            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 0;
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 1;
                }
                else
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemLotNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 2;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = false;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }
                else
                {
                    column.Visible = true;
                    column.VisibleIndex = 1;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 1;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }
                else
                {
                    column.Visible = true;
                    column.VisibleIndex = 2;
                }
            }
            column = gridView.Columns["FK_ICProductAttributeID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemProductSerialNo"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 4;
                    column.OptionsColumn.AllowEdit = false;
                    column.Caption = "Mã đầu lóng";
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 6;
                    column.OptionsColumn.AllowEdit = false;
                    column.Caption = "Mã kiện";
                }
                else
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 6;
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 7;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 2;
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 8;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 7;
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 9;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemHeight"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = false;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 10;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemWidth"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = false;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 11;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemWidthMin"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = false;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 12;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemLength"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 9;
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 13;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemLengthMin"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = false;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 14;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 8;
                    column.Visible = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 15;
                    column.Visible = true;
                }
                else
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Caption = "Khối lượng (m3)";
                    column.VisibleIndex = 11;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Caption = "Khối lượng (m3)";
                    column.VisibleIndex = 16;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else
                {
                    column.VisibleIndex = 3;
                    column.Caption = "Số lượng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 12;
                    column.Visible = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 17;
                    column.Visible = true;
                }
                else
                {
                    column.VisibleIndex = 4;
                    column.Visible = true;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemPerimeter"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 10;
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = false;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICShipmentProposalItemProductShippedQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Caption = "Khối lượng đã xuất";
                    column.VisibleIndex = 13;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Caption = "Khối lượng đã xuất";
                    column.VisibleIndex = 18;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else
                {
                    column.VisibleIndex = 5;
                    column.Caption = "Số lượng đã xuất";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["ICShipmentProposalItemProductRemainQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Caption = "Khối lượng còn lại";
                    column.VisibleIndex = 14;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Caption = "Khối lượng còn lại";
                    column.VisibleIndex = 19;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else
                {
                    column.VisibleIndex = 6;
                    column.Caption = "Số lượng còn lại";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["ICShipmentProposalItemProductCanceledQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Caption = "Khối lượng hủy(m3)";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Caption = "Khối lượng hủy(m3)";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else
                {
                    column.Caption = "Số lượng hủy";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }

            gridView.BestFitColumns();
        }
        //[NKVung]  [Load GridView By Product Type] [END]
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ShipmentProposalModule)Screen.Module).DeleteItemFromShipmentItemsList();
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
