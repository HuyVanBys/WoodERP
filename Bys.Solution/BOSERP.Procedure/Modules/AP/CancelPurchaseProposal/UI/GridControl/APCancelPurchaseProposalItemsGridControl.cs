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
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseProposal
{
    public partial class APCancelPurchaseProposalItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CancelPurchaseProposalItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "MMBatchProductSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            if (gridView.Columns["APCancelPurchaseProposalItemProductQty"] != null)
                gridView.Columns["APCancelPurchaseProposalItemProductQty"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["APCancelPurchaseProposalItemType"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.CancelPurchaseProposalItemType + "Search"]);
                column.ColumnEdit = rep;
                column.OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["APCancelPurchaseProposalItemInsideDemensionWitdh"] != null)
            {
                gridView.Columns["APCancelPurchaseProposalItemInsideDemensionWitdh"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APCancelPurchaseProposalItemInsideDemensionLength"] != null)
            {
                gridView.Columns["APCancelPurchaseProposalItemInsideDemensionLength"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APCancelPurchaseProposalItemInsideDemensionHeight"] != null)
            {
                gridView.Columns["APCancelPurchaseProposalItemInsideDemensionHeight"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APCancelPurchaseProposalItemOverallDemensionWitdh"] != null)
            {
                gridView.Columns["APCancelPurchaseProposalItemOverallDemensionWitdh"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APCancelPurchaseProposalItemOverallDemensionLength"] != null)
            {
                gridView.Columns["APCancelPurchaseProposalItemOverallDemensionLength"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APCancelPurchaseProposalItemOverallDemensionHeight"] != null)
            {
                gridView.Columns["APCancelPurchaseProposalItemOverallDemensionHeight"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["APCancelPurchaseProposalItemProductSizeAndPacking"] != null)
            {
                gridView.Columns["APCancelPurchaseProposalItemProductSizeAndPacking"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["FK_ICProdAttPackingMaterialSpecialityID"] != null)
            {
                gridView.Columns["FK_ICProdAttPackingMaterialSpecialityID"].OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditA_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                gridView.Columns["FK_ICProdAttPackingMaterialSpecialityID"].ColumnEdit = repositoryItemLookUpEdit;
                gridView.Columns["FK_ICProdAttPackingMaterialSpecialityID"].MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (gridView.Columns["FK_ICProdAttPackingMaterialSizeID"] != null)
            {
                gridView.Columns["FK_ICProdAttPackingMaterialSizeID"].OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Khổ màng foam"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditQ_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                gridView.Columns["FK_ICProdAttPackingMaterialSizeID"].ColumnEdit = repositoryItemLookUpEdit;
                gridView.Columns["FK_ICProdAttPackingMaterialSizeID"].MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"] != null)
            {
                gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"].OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Định lượng"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"].ColumnEdit = repositoryItemLookUpEdit;
                gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"].MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            column = gridView.Columns["FK_APSupplierID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APCancelPurchaseProposalItemProductionNormItemTotalPaint"];
            if (column != null)
            {
                column.Visible = false;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductionNormItemTotalBlocks"];
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

            return gridView;
        }
        void repositoryItemLookUpEditA_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialSpeciality.ToString());
            list.Insert(0, objProductAttributesInfo);
            lookUpEdit.Properties.DataSource = list;
        }
        void repositoryItemLookUpEditQ_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialSize.ToString());
            list.Insert(0, objProductAttributesInfo);
            lookUpEdit.Properties.DataSource = list;
        }
        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialWeightPerVolume.ToString());
            list.Insert(0, objProductAttributesInfo);
            lookUpEdit.Properties.DataSource = list;
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

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CancelPurchaseProposalModule)Screen.Module).DeleteItemFromProposalItemList();
            }
            else if (e.KeyCode == Keys.F1)
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)entity.MainObject;
            if (entity.CancelPurchaseProposalItemList.CurrentIndex >= 0)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    APCancelPurchaseProposalItemsInfo item = (APCancelPurchaseProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);

                    if (e.Column.FieldName == "APCancelPurchaseProposalItemProductQty" && item != null && item.APCancelPurchaseProposalItemType == ProductType.OutSourcing.ToString())
                    {
                        item.APCancelPurchaseProposalItemProductionNormItemTotalBlocks = item.APCancelPurchaseProposalItemProductQty * item.APCancelPurchaseProposalItemProductionNormItemBlocks;
                        item.APCancelPurchaseProposalItemProductionNormItemTotalPaint = item.APCancelPurchaseProposalItemProductQty * item.APCancelPurchaseProposalItemProductionNormItemPaint;
                        item.APCancelPurchaseProposalItemProductionNormItemTotalBlocks = Math.Round(item.APCancelPurchaseProposalItemProductionNormItemTotalBlocks, 4, MidpointRounding.AwayFromZero);
                        item.APCancelPurchaseProposalItemProductionNormItemTotalPaint = Math.Round(item.APCancelPurchaseProposalItemProductionNormItemTotalPaint, 4, MidpointRounding.AwayFromZero);
                    }
                    if ((e.Column.FieldName == "APCancelPurchaseProposalItemWoodQty" || e.Column.FieldName == "APCancelPurchaseProposalItemProductLenght" || e.Column.FieldName == "APCancelPurchaseProposalItemProductWidth")
                        && objCancelPurchaseProposalsInfo.APCancelPurchaseProposalAPTypeCombo == ProposalAPType.Verneer.ToString())
                    {
                        item.APCancelPurchaseProposalItemProductQty = item.APCancelPurchaseProposalItemWoodQty * item.APCancelPurchaseProposalItemProductLenght * item.APCancelPurchaseProposalItemProductWidth * Convert.ToDecimal(Math.Pow(10, -6));
                        item.APCancelPurchaseProposalItemProductQty = Math.Round(item.APCancelPurchaseProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                    }
                    if (e.Column.FieldName == "APCancelPurchaseProposalItemProductQty")
                    {
                        item.APCancelPurchaseProposalItemProductExchangeQty = item.APCancelPurchaseProposalItemProductQty * item.APCancelPurchaseProposalItemProductFactor;
                    }
                }
                (entity.Module as CancelPurchaseProposalModule).CalculateProductionNormItemPackaging();
                entity.ModuleObjects[TableName.APCancelPurchaseProposalItemsTableName] = (APCancelPurchaseProposalItemsInfo)entity.CancelPurchaseProposalItemList[entity.CancelPurchaseProposalItemList.CurrentIndex].Clone();
                (entity.Module as CancelPurchaseProposalModule).ChangeItemFromProposalItemList();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            APCancelPurchaseProposalItemsInfo item = (APCancelPurchaseProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "APCancelPurchaseProposalItemProductQty")
                {
                    decimal newValue = 0M;
                    if (!string.IsNullOrEmpty(e.Value.ToString()) && decimal.TryParse(e.Value.ToString(), out newValue))
                    {
                        if (newValue > item.APCancelPurchaseProposalItemProductQtyOld)
                        {
                            e.ErrorText = "Vượt quá số lượng có thể hủy.";
                            e.Valid = false;
                        }
                    }
                }
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

            GridColumn column = gridView.Columns["APCancelPurchaseProposalItemProductQty"];
            if (column != null)
            {

                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.ArtificialBoard.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.WoodMDFOutSourcing.ToString())
                {
                    if (productType == ProductType.Verneer.ToString())
                    {
                        column.Caption = CancelPurchaseProposalLocalizedResources.VerneerM2;
                    }
                    else
                    {
                        column.Caption = "Khối lượng hủy (m3)";
                    }
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else
                {
                    column.Caption = "Số lượng hủy";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductQtyOld"];
            if (column != null)
            {

                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.ArtificialBoard.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.WoodMDFOutSourcing.ToString())
                {

                    column.Caption = "Khối lượng đặt";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else
                {
                    column.Caption = "Số lượng đặt";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemWoodQty"];
            {
                if (column != null)
                {
                    if (productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                    {
                        column.Caption = CancelPurchaseProposalLocalizedResources.Quanlity;
                        column.DisplayFormat.FormatType = FormatType.Numeric;
                        column.DisplayFormat.FormatString = "{0:n5}";
                        column.OptionsColumn.AllowEdit = true;
                        column.Visible = true;
                        column.VisibleIndex = 6;
                    }
                    else
                    {
                        column.Visible = false;
                    }
                }
            }
            //column = gridView.Columns["FK_MMPurchasePlanID"];
            //if (column.FieldName == "FK_MMPurchasePlanID")
            //{
            //    column.OptionsColumn.AllowEdit = false;
            //    column.Visible = true;
            //    column.VisibleIndex = 13;
            //}
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
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
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }
                else
                {
                    column.Visible = true;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductHeight"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductWidth"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductWidthMax"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 9;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductLenght"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 10;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductLenghtMax"];
            if (column != null)
            {
                if (productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductPerimeter"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemComment"];
            if (column != null)
            {
                //if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                //{
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                column.VisibleIndex = 12;
                //}
                //else
                //{
                //    column.Visible = false;
                //}
            }
            column = gridView.Columns["APCancelPurchaseProposalItemNeedTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                column.VisibleIndex = 4;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemPurchaseOrderQty"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Caption = CancelPurchaseProposalLocalizedResources.APCancelPurchaseProposalItemPurchaseOrderQty;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                }
                else
                {
                    column.Caption = CancelPurchaseProposalLocalizedResources.APCancelPurchaseProposalItemPurchaseOrderQty1;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                }
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductionNormItemTotalPaint"];
            if (column != null)
            {
                column.Visible = false;
            }

            column = gridView.Columns["APCancelPurchaseProposalItemProductionNormItemTotalBlocks"];
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
            //column = gridView.Columns["APCancelPurchaseProposalItemLumberTypeCombo"];
            //if (column != null)
            //{
            //    if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
            //    {
            //        column.OptionsColumn.AllowEdit = true;
            //        column.Visible = true;
            //        column.VisibleIndex = 13;
            //    }
            //    else
            //    {
            //        column.Visible = false;
            //    }
            //}

            if (productType == ProductType.AlloyCover.ToString() || productType == ProductType.Rent.ToString()
                || productType == ProductType.WoodMDFOutSourcing.ToString() || productType == ProductType.MechanicOutSourcing.ToString()
                || productType == ProductType.Repair.ToString() || productType == ProductType.Other.ToString())
            {
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
                    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit2_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.Caption = "CCDC";
                    column.Visible = true;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceToDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Caption = "Đến ngày";
                    column.Visible = true;
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

                column = gridView.Columns["APPurchaseOrderItemServiceFromDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
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
            GridColumn column = gridView.Columns["APCancelPurchaseProposalItemProductionNormItemTotalPaint"];
            if (column != null && column.FieldName == "APCancelPurchaseProposalItemProductionNormItemTotalPaint")
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductionNormItemTotalBlocks"];
            if (column != null && column.FieldName == "APCancelPurchaseProposalItemProductionNormItemTotalBlocks")
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_MMFromOperationID"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMToOperationID"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductQty"];
            if (column != null)
            {
                column.Caption = CancelPurchaseProposalLocalizedResources.Quanlity;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemPurchaseOrderQty"];
            if (column != null)
            {
                column.Caption = CancelPurchaseProposalLocalizedResources.APCancelPurchaseProposalItemPurchaseOrderQty1;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }

            gridView.BestFitColumns();
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.CancelPurchaseProposalItemList.CurrentIndex >= 0)
            {
                ((CancelPurchaseProposalModule)Screen.Module).InitProductPictureImage(entity.CancelPurchaseProposalItemList[entity.CancelPurchaseProposalItemList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}
