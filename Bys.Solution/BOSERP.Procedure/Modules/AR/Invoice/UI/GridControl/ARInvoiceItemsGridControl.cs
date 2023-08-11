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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public class ARInvoiceItemsGridControl : ItemGridControl
    {
        /// <summary>
        /// A variable to store the hit info calculated by mouse down in the grid control
        /// </summary>
        private GridHitInfo DownHitInfo = null;

        public override void InitializeControl()
        {
            base.InitializeControl();
            //AllowDrop = true;
            //this.DragOver += new DragEventHandler(GridControl_DragOver);
            //this.DragDrop += new DragEventHandler(GridControl_DragDrop);
        }

        public override void InitGridControlDataSource()
        {
            InvoiceEntities entity = (InvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "Package";
            column.Caption = InvoiceLocalizedResources.Package;
            RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = InvoiceLocalizedResources.ChoosePackage;
            rep.Click += new EventHandler(RepositoryItemHyperLinkEdit_Click);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = InvoiceLocalizedResources.InvoiceItemComponent;
            column.FieldName = "InvoiceItemComponent";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpChooseItemComponent = new RepositoryItemHyperLinkEdit();
            rpChooseItemComponent.NullText = InvoiceLocalizedResources.InvoiceItemComponentList;
            rpChooseItemComponent.Click += new EventHandler(ChooseItemComponent_Click);
            column.ColumnEdit = rpChooseItemComponent;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "CopyLine";
            column.Caption = "Thêm dòng";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Thêm dòng";
            rep1.Click += new EventHandler(rep_Click);
            column.ColumnEdit = rep1;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Hạng mục";
            column.FieldName = "ARProposalTemplateItemProductName";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemButtonEdit repoItemBtnEdit = new RepositoryItemButtonEdit();
            repoItemBtnEdit.AllowMouseWheel = false;
            repoItemBtnEdit.AutoHeight = false;
            repoItemBtnEdit.Name = "ARProposalTemplateItemProductName";
            repoItemBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repoItemBtnEdit.ButtonClick += RepoItemBtnEdit_ButtonClick;
            column.ColumnEdit = repoItemBtnEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceItemSortOrder";
            column.Caption = "STT";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        private void RepoItemBtnEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ((InvoiceModule)Screen.Module).ShowTemplateItemTree();
        }

        void rep_Click(object sender, EventArgs e)
        {
            if (!((InvoiceModule)Screen.Module).Toolbar.IsNullOrNoneAction())
            {
                ((InvoiceModule)Screen.Module).CopyLine();
            }
        }

        private void ChooseItemComponent_Click(object sender, EventArgs e)
        {
            ((InvoiceModule)Screen.Module).ShowItemComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.MouseDown += new MouseEventHandler(GridView_MouseDown);
            gridView.MouseMove += new MouseEventHandler(GridView_MouseMove);

            if (gridView.Columns["ARInvoiceItemProductQty"] != null)
                gridView.Columns["ARInvoiceItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARInvoiceItemProductUnitPrice"] != null)
                gridView.Columns["ARInvoiceItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARInvoiceItemProductDiscount"] != null)
            {
                gridView.Columns["ARInvoiceItemProductDiscount"].OptionsColumn.AllowEdit = true;
            }

            GridColumn column = gridView.Columns["ARInvoiceItemDiscountAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARInvoiceItemProductTaxPercent"] != null)
            {
                gridView.Columns["ARInvoiceItemProductTaxPercent"].OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARInvoiceItemProductSerialNo"] != null)
            {
                gridView.Columns["ARInvoiceItemProductSerialNo"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARInvoiceItemLotNo"] != null)
            {
                gridView.Columns["ARInvoiceItemLotNo"].OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ARInvoiceItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["FK_ICProductAttributeTTMTID"] != null)
                gridView.Columns["FK_ICProductAttributeTTMTID"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["FK_ICProductAttributeWoodTypeID"] != null)
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_GECountryID"] != null)
                gridView.Columns["FK_GECountryID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICProductAttributeQualityID"] != null)
                gridView.Columns["FK_ICProductAttributeQualityID"].OptionsColumn.AllowEdit = true;

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
                column.OptionsColumn.AllowEdit = false;
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
            column = gridView.Columns["FK_ACAccountID"];
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
            if (gridView.Columns["FK_ICSectionProductID"] != null)
            {
                column = gridView.Columns["FK_ICSectionProductID"];
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = GetAllSectionProduct();
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã hạng mục"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên hạng mục"));
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpSectionProduct_QueryPopUp);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACCostCenterID"];
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
                DataSet ds1 = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds1.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                rpMeasureUnit.CloseUp += new CloseUpEventHandler(rpMeasureUnit_CloseUp);
                column.ColumnEdit = rpMeasureUnit;
            }
            column = gridView.Columns["ARInvoiceItemContainerNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARInvoiceItemContainerSealNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARInvoiceItemTractorTrailerNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARInvoiceItemShipNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARInvoiceItemETDDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARInvoiceItemProductName2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            InvoiceEntities entity = (InvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARInvoiceItemsInfo item = (ARInvoiceItemsInfo)entity.InvoiceItemsList[entity.InvoiceItemsList.CurrentIndex];
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
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            InvoiceEntities entity = (InvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
            if (entity.InvoiceItemsList.CurrentIndex >= 0)
            {
                ARInvoiceItemsInfo item = entity.InvoiceItemsList[entity.InvoiceItemsList.CurrentIndex];
                if (e.Column.FieldName == "ARInvoiceItemProductSerialNo"
                    || e.Column.FieldName == "ARInvoiceItemLotNo")
                {
                    ((InvoiceModule)Screen.Module).UpdateLotNoItem(item);
                }
                else if (e.Column.FieldName == "ARInvoiceItemProductQty")
                {
                    if (objInvoicesInfo.ActionNewFrom == "Manual")
                    {
                        ARCustomersController objCustomersController = new ARCustomersController();
                        ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objInvoicesInfo.FK_ARCustomerID);
                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo product = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (product != null)
                        {
                            item.ARInvoiceItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(product,
                                                                                        item.ARInvoiceItemProductUnitPrice,
                                                                                        item.ARInvoiceItemProductQty,
                                                                                        item.FK_ICMeasureUnitID,
                                                                                        objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                        objInvoicesInfo.ARInvoiceDate,
                                                                                        objInvoicesInfo.FK_GECurrencyID);
                        }
                    }
                    ((InvoiceModule)Screen.Module).ChangeComponentItemQty();
                }
                else if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((InvoiceModule)Screen.Module).ResetModelDetail(item);
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    if (objInvoicesInfo.ActionNewFrom == "Manual")
                    {
                        ARCustomersController objCustomersController = new ARCustomersController();
                        ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objInvoicesInfo.FK_ARCustomerID);
                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo product = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (product != null)
                        {
                            item.ARInvoiceItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(product,
                                                                                        item.ARInvoiceItemProductUnitPrice,
                                                                                        item.ARInvoiceItemProductQty,
                                                                                        item.FK_ICMeasureUnitID,
                                                                                        objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                        objInvoicesInfo.ARInvoiceDate,
                                                                                        objInvoicesInfo.FK_GECurrencyID);
                        }
                    }
                    ((InvoiceModule)Screen.Module).ChangeItemMeasureUnit();
                }
                if (e.Column.FieldName == "ARInvoiceItemProductSerialNo")
                {
                    ((InvoiceModule)Screen.Module).ChangeItemSerieNo(item);
                    ((InvoiceModule)Screen.Module).ChangeItemProductUnitCost(item);
                    gridView.RefreshData();
                }
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((InvoiceModule)Screen.Module).ChangeItemComponentStock(item);
                }
                entity.ModuleObjects[TableName.ARInvoiceItemsTableName] = (ARInvoiceItemsInfo)item.Clone();
                (entity.Module as InvoiceModule).ChangeItemFromInvoiceItemsList();
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
        public void LoadGridViewByProductType(string productType)
        {
            GridView gridView = (GridView)MainView;

            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 0;
            }
            column = gridView.Columns["FK_ACAccountRevenueID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                //column.VisibleIndex = 0;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 3;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 1;
                }
                else
                {
                    column.VisibleIndex = 1;
                }
            }
            column = gridView.Columns["ARInvoiceItemLotNo"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 5;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 2;
                }
                else
                {
                    column.VisibleIndex = 2;
                }
            }
            column = gridView.Columns["ARInvoiceItemProductName"];
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
                    column.VisibleIndex = 3;
                }
            }
            column = gridView.Columns["ARInvoiceItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
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
                    column.VisibleIndex = 4;
                }
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
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
            //column = gridView.Columns["ARInvoiceItemProductSerialNo"];
            //if (column != null)
            //{
            //    column.Visible = true;
            //    column.OptionsColumn.AllowEdit = true;
            //    if (productType == ProductType.Roundwood.ToString())
            //    {
            //        column.VisibleIndex = 4;
            //        column.Caption = "Mã đầu lóng";
            //        column.OptionsColumn.AllowEdit = false;
            //    }
            //    else if (productType == ProductType.Lumber.ToString())
            //    {
            //        column.VisibleIndex = 6;
            //        column.Caption = "Mã kiện";
            //        column.OptionsColumn.AllowEdit = false;
            //    }
            //    else
            //    {
            //        column.VisibleIndex = 5;
            //        column.Caption = "Mã Lô hàng";
            //    }
            //}
            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 6;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 7;
                }
                else
                {
                    column.VisibleIndex = 6;
                }
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 2;
                    column.OptionsColumn.AllowEdit = false;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 8;
                    column.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowEdit = false;
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
            column = gridView.Columns["ARInvoiceItemHeight"];
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
            column = gridView.Columns["ARInvoiceItemWidth"];
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
            column = gridView.Columns["ARInvoiceItemWidthMin"];
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
            column = gridView.Columns["ARInvoiceItemLength"];
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
            column = gridView.Columns["ARInvoiceItemLengthMin"];
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
            column = gridView.Columns["ARInvoiceItemWoodQty"];
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
            column = gridView.Columns["ARInvoiceItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = this.Screen.Module.GetColumnFormat(this.BOSDataSource, column.FieldName, this.Screen.Module.ModuleID);
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Caption = "Khối lượng (m3)";
                    column.VisibleIndex = 11;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = objFieldFormatGroupsInfo != null && string.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFormatString) ? objFieldFormatGroupsInfo.STFieldFormatGroupFormatString:"{0:n4}" ;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.Caption = "Khối lượng (m3)";
                    column.VisibleIndex = 16;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = objFieldFormatGroupsInfo != null && string.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFormatString) ? objFieldFormatGroupsInfo.STFieldFormatGroupFormatString: "{0:n4}" ;
                }
                else
                {
                    column.VisibleIndex = 6;
                    column.Caption = "Số lượng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["ARInvoiceItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 12;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 17;
                }
                else
                {
                    column.VisibleIndex = 7;
                }
            }
            column = gridView.Columns["ARInvoiceItemNetAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 13;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 18;
                }
                else
                {
                    column.VisibleIndex = 8;
                }
            }
            column = gridView.Columns["ARInvoiceItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 14;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 19;
                }
                else
                {
                    column.VisibleIndex = 9;
                }
            }
            column = gridView.Columns["ARInvoiceItemDiscountAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 15;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 20;
                }
                else
                {
                    column.VisibleIndex = 10;
                }
            }
            column = gridView.Columns["ARInvoiceItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 16;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 21;
                }
                else
                {
                    column.VisibleIndex = 11;
                }
            }
            column = gridView.Columns["ARInvoiceItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 17;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 22;
                }
                else
                {
                    column.VisibleIndex = 12;
                }
            }
            column = gridView.Columns["ARInvoiceItemTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 18;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 23;
                }
                else
                {
                    column.VisibleIndex = 13;
                }
            }
            column = gridView.Columns["ICProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 19;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 24;
                }
                else
                {
                    column.VisibleIndex = 14;
                }
            }
            column = gridView.Columns["ARInvoiceItemDeliveryDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 20;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 25;
                }
                else
                {
                    column.VisibleIndex = 15;
                }
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.VisibleIndex = 12;
                }
                else if (productType == ProductType.Lumber.ToString())
                {
                    column.VisibleIndex = 17;
                }
                else
                {
                    column.VisibleIndex = 4;
                }
            }
            column = gridView.Columns["ARInvoiceItemPerimeter"];
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

            gridView.BestFitColumns();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InvoiceModule)Screen.Module).DeleteItemFromInvoiceItemsList();
            }
        }

        private void RepositoryItemHyperLinkEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARInvoiceItemsInfo item = (ARInvoiceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ((InvoiceModule)Screen.Module).ChoosePackage(item);
            }
        }

        #region Drag & Drop
        private void GridView_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo downHitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Button == MouseButtons.Left && downHitInfo.InRow)
                {
                    DownHitInfo = downHitInfo;
                }
            }
        }

        private void GridView_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && DownHitInfo != null)
            {
                view.GridControl.DoDragDrop(DownHitInfo, DragDropEffects.All);
                DownHitInfo = null;
            }
        }

        private void GridControl_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            if (downHitInfo != null)
            {
                BOSGridControl grid = sender as BOSGridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle)
                    e.Effect = DragDropEffects.Move;
            }

        }

        private void GridControl_DragDrop(object sender, DragEventArgs e)
        {
            BOSGridControl grid = sender as BOSGridControl;
            GridView view = grid.MainView as GridView;
            GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            int sourceRow = srcHitInfo.RowHandle;
            int targetRow = hitInfo.RowHandle;
            CloneInvoiceItem(sourceRow, targetRow);
        }

        /// <summary>
        /// Clone an invoice item
        /// </summary>
        /// <param name="sourceRowHandle">Row handle of source item</param>
        /// <param name="targetRowHandle">Row handle of target item</param>
        private void CloneInvoiceItem(int sourceRowHandle, int targetRowHandle)
        {
            ((InvoiceModule)Screen.Module).CloneInvoiceItem((GridView)MainView, sourceRowHandle, targetRowHandle);
        }
        #endregion

        public List<ICProductsInfo> GetAllSectionProduct()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetAllSectionAndWorkProduct();
            return productList;
        }

        private void rpSectionProduct_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                if (lookUpEdit != null)
                    lookUpEdit.Properties.DataSource = ((InvoiceModule)Screen.Module).GetAllSectionProductForLookUp();
                gridView.RefreshData();
            }
        }

        private void rpMeasureUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                InvoiceEntities entity = (InvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARInvoiceItemsInfo item = (ARInvoiceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                GeneralHelper.ChangeSaleItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARInvoiceItemsInfo item = (ARInvoiceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        public void LoadGridViewByProductType(int iObjectID)
        {
            GridView gridView = (GridView)MainView;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            InvoiceEntities entity = (InvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;

            if (mainObject.ActionNewFrom == "FromInvoiceAndShipment" && iObjectID > 0)
                mainObject = (ARInvoicesInfo)objInvoicesController.GetObjectByID(iObjectID);
            string productType = mainObject.ARInvoiceProductType;

            if (productType == InvoiceProductType.Roundwood.ToString() || productType == InvoiceProductType.FreshLumber.ToString()
                        || productType == ReturnSupplierReceiptType.ArtificialBoard.ToString() || productType == ReturnSupplierReceiptType.Verneer.ToString())
            {
                GridColumn column = gridView.Columns["ARInvoiceItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng";
                }
            }
            else
            {
                GridColumn column = gridView.Columns["ARInvoiceItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng";
                }
            }
            gridView.BestFitColumns();
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            InvoiceEntities entity = (InvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.InvoiceItemsList.CurrentIndex >= 0)
            {
                ((InvoiceModule)Screen.Module).InitProductPictureImage(entity.InvoiceItemsList[entity.InvoiceItemsList.CurrentIndex].FK_ICProductID);
            }
        }
        public void LoadGridViewSourceSellingPrice(bool IsEditPrice)
        {
            GridView gridView = (GridView)MainView;
            // tạm
            IsEditPrice = true;
            if (!IsEditPrice)
            {
                GridColumn column = gridView.Columns["ARInvoiceItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                //column = gridView.Columns["ARInvoiceItemProductUnitPrice2"];
                //if (column != null)
                //{
                //    column.OptionsColumn.AllowEdit = false;
                //}
            }
            else
            {
                GridColumn column = gridView.Columns["ARInvoiceItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }    
        }
    }
}
