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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderItemsGridControl : ItemGridControl
    {
        private DataTable ARSaleOrderItemGrantedFromDataTable { get; set; }
        private List<ICProductAttributesInfo> ProductAttributesList { get; set; }

        public bool ShowMessage;
        private enum SaleOrderItemColumnName
        {
            ARSaleOrderItemHeight,
            ARSaleOrderItemWidth,
            ARSaleOrderItemLength,
            FK_ICProductAttributeColorID,
            FK_ICProductAttributeWoodTypeID,
            ARSaleOrderItemProductColorAttribute,
            ARSaleOrderItemWoodTypeText,
            ARSaleOrderItemRemark,
        }

        private string[] SetProductDescColums = new string[]
        {
            SaleOrderItemColumnName.ARSaleOrderItemHeight.ToString(),
            SaleOrderItemColumnName.ARSaleOrderItemWidth.ToString(),
            SaleOrderItemColumnName.ARSaleOrderItemLength.ToString(),
            SaleOrderItemColumnName.FK_ICProductAttributeColorID.ToString(),
            SaleOrderItemColumnName.FK_ICProductAttributeWoodTypeID.ToString(),
            SaleOrderItemColumnName.ARSaleOrderItemProductColorAttribute.ToString(),
        };


        public override void InitGridControlDataSource()
        {
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.SOItemComponent;
            column.FieldName = "ARSOItemComponent";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = SaleOrderLocalizedResources.ItemComponentList;
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.ItemCopyNewRow;
            column.FieldName = "ARSOItemCopyItem";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemAddNewRow = new RepositoryItemHyperLinkEdit();
            rpItemAddNewRow.NullText = SaleOrderLocalizedResources.ItemCopyNewRow;
            rpItemAddNewRow.Click += new EventHandler(rpItemAddNewRow_Click);
            column.ColumnEdit = rpItemAddNewRow;
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
            column.Caption = "SL tồn kho";
            column.FieldName = "ICInventoryStockQty";
            STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARSaleOrderItems", "ARSaleOrderItemProductQty", this.Screen.Module.ModuleID);
            if (formatsInfo != null)
            {
                column.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(formatsInfo.STFieldFormatGroupFormatType);
                column.DisplayFormat.FormatString = formatsInfo.STFieldFormatGroupFormatString;
            }
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SL có thể bán";
            column.FieldName = "ICInventorySaleOderStockQty";
            if (formatsInfo != null)
            {
                column.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(formatsInfo.STFieldFormatGroupFormatType);
                column.DisplayFormat.FormatString = formatsInfo.STFieldFormatGroupFormatString;
            }
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đơn giá sau CK";
            column.FieldName = "ARSaleOrderItemProductGroupDiscount";
            column.OptionsColumn.AllowEdit = false;
            STFieldFormatGroupsInfo priceFormatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARSaleOrderItems", "ARSaleOrderItemProductUnitPrice", this.Screen.Module.ModuleID);
            if (priceFormatsInfo != null)
            {
                column.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(priceFormatsInfo.STFieldFormatGroupFormatType);
                column.DisplayFormat.FormatString = priceFormatsInfo.STFieldFormatGroupFormatString;
            }
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thành tiền sau CK";
            column.FieldName = "ARSaleOrderItemTotalGroupDiscount";
            column.OptionsColumn.AllowEdit = false;
            priceFormatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARSaleOrderItems", "ARSaleOrderItemProductUnitPrice", this.Screen.Module.ModuleID);
            if (priceFormatsInfo != null)
            {
                column.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(priceFormatsInfo.STFieldFormatGroupFormatType);
                column.DisplayFormat.FormatString = priceFormatsInfo.STFieldFormatGroupFormatString;
            }
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SL thùng";
            column.FieldName = "ARSaleOrderItemProductQtyInBox";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "N2";
            gridView.Columns.Add(column);
        }

        private void RepoItemBtnEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ((SaleOrderModule)Screen.Module).ShowTemplateItemTree();
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Screen.Module).ShowItemComponent();
        }

        private void rpItemAddNewRow_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Screen.Module).CopyItemToNewRow();
        }

        private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (gridview.FocusedRowHandle >= 0)
            {
                SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridview.GetRow(gridview.FocusedRowHandle);
                if (item != null && item.ARSaleOrderItemInvalidInventoryStock)
                {
                    e.Appearance.BackColor = ColorTranslator.FromHtml("#ffff00");
                    e.Appearance.BackColor2 = ColorTranslator.FromHtml("#ffff33");
                    e.HighPriority = true;
                }
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            if (gridView.Columns["ARSaleOrderItemDiscountAmount2"] != null)
            {
                //SetFormat("ARSaleOrderItemDiscountAmount2", "n2", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemShippedQty"] != null)
            {
                //SetFormat("ARSaleOrderItemShippedQty", "n3", gridView);
            }
            if (gridView.Columns["ARSaleOrderItemCanceledQty"] != null)
            {
                //SetFormat("ARSaleOrderItemCanceledQty", "n3", gridView);
            }
            GridColumn column = gridView.Columns["FK_ICProductAttributeQualityID"];
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
            column = gridView.Columns["ARSaleOrderItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ARSaleOrderItemProductUnitPrice2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                //SetFormat("ARSaleOrderItemProductUnitPrice2", "n2", gridView);
            }
            column = gridView.Columns["ARSaleOrderItemProductExchangeQty"];
            if (column != null)
            {
                SetFormat("FK_ICProductEquipmentID", "n5", gridView);
            }
            if (gridView.Columns["FK_ACAssetID"] != null)
            {
                SetFormat("FK_ICProductEquipmentID", "n3", gridView);
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
            }

            LookUpColumnInfo columnInfo;
            ARSaleOrderItemGrantedFromDataTable = new DataTable();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("SaleOrderItemGrantedFrom");
            if (ds != null)
                ARSaleOrderItemGrantedFromDataTable = ds.Tables[0];

            if (gridView.Columns["ARSaleOrderItemGrantedFrom"] != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                gridView.Columns["ARSaleOrderItemGrantedFrom"].MinWidth = 100;
                gridView.Columns["ARSaleOrderItemGrantedFrom"].OptionsColumn.AllowEdit = true;
                repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)ARSaleOrderItemGrantedFromDataTable;
                repositoryItemLookUpEdit.ValueMember = "Value";
                repositoryItemLookUpEdit.DisplayMember = "Text";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.NullText = String.Empty;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "Text";
                columnInfo.Width = 100;
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                gridView.Columns["ARSaleOrderItemGrantedFrom"].ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            GridColumn column3 = gridView.Columns["ARSaleOrderItemWoodTypeID"];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = true;
                RepositoryItemGridLookUpEdit rpProductAttributeWoodTypeAttribute = new RepositoryItemGridLookUpEdit();
                rpProductAttributeWoodTypeAttribute.DisplayMember = "ICProductAttributeValue";
                rpProductAttributeWoodTypeAttribute.ValueMember = "ICProductAttributeID";
                rpProductAttributeWoodTypeAttribute.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rpProductAttributeWoodTypeAttribute.PopupFilterMode = PopupFilterMode.Contains;
                rpProductAttributeWoodTypeAttribute.NullText = string.Empty;
                rpProductAttributeWoodTypeAttribute.View.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                rpProductAttributeWoodTypeAttribute.PopupFormSize = new System.Drawing.Size(100, 70);
                rpProductAttributeWoodTypeAttribute.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpProductAttributeWoodTypeAttribute_QueryPopUp);
                rpProductAttributeWoodTypeAttribute.View.RowClick += new RowClickEventHandler(rpProductAttributeWoodTypeAttributeView_RowClick);
                rpProductAttributeWoodTypeAttribute.CloseUp += new CloseUpEventHandler(rpProductAttributeWoodTypeAttributeProperties_CloseUp);
                column3.ColumnEdit = rpProductAttributeWoodTypeAttribute;
            }

            GridColumn column4 = gridView.Columns["ARSaleOrderItemColorID"];
            if (column4 != null)
            {
                column4.OptionsColumn.AllowEdit = true;
                RepositoryItemGridLookUpEdit rpProductAttributeColor = new RepositoryItemGridLookUpEdit();
                rpProductAttributeColor.DisplayMember = "ICProductAttributeValue";
                rpProductAttributeColor.ValueMember = "ICProductAttributeID";
                rpProductAttributeColor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rpProductAttributeColor.PopupFilterMode = PopupFilterMode.Contains;
                rpProductAttributeColor.NullText = string.Empty;
                rpProductAttributeColor.PopupFormSize = new System.Drawing.Size(100, 70);
                rpProductAttributeColor.View.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                rpProductAttributeColor.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpProductAttributeColorAttribute_QueryPopUp);
                rpProductAttributeColor.View.RowClick += new RowClickEventHandler(rpProductAttributeColorAttributeView_RowClick);
                rpProductAttributeColor.CloseUp += new CloseUpEventHandler(rpProductAttributeColorAttributeProperties_CloseUp);
                column4.ColumnEdit = rpProductAttributeColor;
            }

            if (gridView.Columns["FK_ACCostCenterID"] != null)
            {
                GridColumn column5 = gridView.Columns["FK_ACCostCenterID"];
                column5.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemCostCenterLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemCostCenterLookUpEdit.DataSource = GetAllCostCenter();
                repositoryItemCostCenterLookUpEdit.ValueMember = "ACCostCenterID";
                repositoryItemCostCenterLookUpEdit.DisplayMember = "ACCostCenterName";
                repositoryItemCostCenterLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemCostCenterLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemCostCenterLookUpEdit.NullText = string.Empty;
                repositoryItemCostCenterLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostCenterName", "TT Chi phí"));
                repositoryItemCostCenterLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                repositoryItemCostCenterLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpCostCenter_QueryPopUp);
                column5.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemCostCenterLookUpEdit;
            }

            column = gridView.Columns["FK_ICSectionProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpSectionProduct = new RepositoryItemLookUpEdit();
                rpSectionProduct.DataSource = GetAllSectionAndWorkForLookUp();
                rpSectionProduct.DisplayMember = "ICProductName";
                rpSectionProduct.ValueMember = "ICProductID";
                rpSectionProduct.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rpSectionProduct.NullText = string.Empty;
                rpSectionProduct.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã hạng mục"));
                rpSectionProduct.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên hạng mục"));
                rpSectionProduct.PopupFormSize = new System.Drawing.Size(100, 70);
                rpSectionProduct.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpSectionProduct_QueryPopUp);
                column.ColumnEdit = rpSectionProduct;
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
            gridView.CellValueChanging += GridView_CellValueChanging;
            SetDefaultAllowEditPropertyOfColumns(gridView);
            return gridView;
        }

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "IsInlandItemProductName")
            {
                {
                    SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ((SaleOrderModule)Screen.Module).ChangeForeignItemProductName(item, bool.Parse(e.Value.ToString()));
                }
            }
        }

        private void rpProductWoodTypeAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                CheckedComboBoxEdit lookUpEdit = (CheckedComboBoxEdit)sender;
                lookUpEdit.Properties.DataSource = ((SaleOrderModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
            }
        }

        private void rpProductWoodTypeAttribute_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                CheckedComboBoxEdit lookUpEdit = (CheckedComboBoxEdit)sender;
                if (lookUpEdit.EditValue != e.Value)
                {
                    ((SaleOrderModule)Screen.Module).ChangeMoreWoodType(e.Value.ToString());
                }
            }
        }

        public void LoadGridView(string saleOrderType)
        {
            GridView gridView = (GridView)MainView;
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;

            if (saleOrderType == SaleOrderType.AnnexContract.ToString())
            {
                new SaleOrderItemColumnName[]
                {
                    SaleOrderItemColumnName.FK_ICProductAttributeWoodTypeID,
                    SaleOrderItemColumnName.ARSaleOrderItemWoodTypeText,
                    SaleOrderItemColumnName.ARSaleOrderItemRemark,
                    SaleOrderItemColumnName.ARSaleOrderItemHeight,
                    SaleOrderItemColumnName.ARSaleOrderItemWidth,
                    SaleOrderItemColumnName.ARSaleOrderItemLength,
                }
                .Select(o => gridView.Columns[o.ToString()])
                .Where(o => o != null)
                .ToList()
                .ForEach(o => o.OptionsColumn.AllowEdit = true);
            }
            else
            {
                new SaleOrderItemColumnName[]
                {
                    SaleOrderItemColumnName.FK_ICProductAttributeWoodTypeID,
                    SaleOrderItemColumnName.ARSaleOrderItemWoodTypeText,
                    SaleOrderItemColumnName.ARSaleOrderItemRemark,
                    SaleOrderItemColumnName.ARSaleOrderItemHeight,
                    SaleOrderItemColumnName.ARSaleOrderItemWidth,
                    SaleOrderItemColumnName.ARSaleOrderItemLength,
                }
                .Select(o => gridView.Columns[o.ToString()])
                .Where(o => o != null)
                .ToList()
                .ForEach(o => o.OptionsColumn.AllowEdit = false);
            }
        }

        private void rpProductAttributeColorID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                lookUpEdit.Properties.DataSource = ((SaleOrderModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
            }
        }

        private void rpProductAttributeColor_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                lookUpEdit.Properties.DataSource = ((SaleOrderModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                lookUpEdit.Properties.ImmediatePopup = true;
                lookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(50, 70);
                foreach (GridColumn column in lookUpEdit.Properties.View.Columns)
                {
                    if (column.FieldName != "ICProductAttributeValue")
                        column.Visible = false;
                    else
                        column.Caption = "Màu sơn";
                }
                lookUpEdit.Properties.View.OptionsView.ShowIndicator = false;
            }
        }

        private void rpProductAttributeWoodTypeID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                lookUpEdit.Properties.DataSource = ((SaleOrderModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                lookUpEdit.Properties.ImmediatePopup = true;
                lookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(50, 70);
                foreach (GridColumn column in lookUpEdit.Properties.View.Columns)
                {
                    if (column.FieldName != "ICProductAttributeValue")
                        column.Visible = false;
                    else
                        column.Caption = "Loại gỗ";
                }
                lookUpEdit.Properties.View.OptionsView.ShowIndicator = false;
            }
        }

        private void rpProductAttributeColor_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                CheckedComboBoxEdit lookUpEdit = (CheckedComboBoxEdit)sender;
                if (lookUpEdit.EditValue != e.Value)
                {
                    ((SaleOrderModule)Screen.Module).ChangeMoreColor(e.Value.ToString());
                }
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)entity.MainObject;

            if (entity.ARSaleOrderItemsList.CurrentIndex >= 0)
            {
                ARSaleOrderItemsInfo item = entity.ARSaleOrderItemsList[entity.ARSaleOrderItemsList.CurrentIndex];

                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                int count = 0;
                count = objInvoiceItemsController.GetCountInvoiceBySaleOrderID(mainObject.ARSaleOrderID);

                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (mainObject.STToolbarActionName == "Manual")
                    {
                        entity.ARSaleOrderItemsList.Where(o => o.FK_ICProductID == item.FK_ICProductID && o.FK_ICMeasureUnitID == item.FK_ICMeasureUnitID).ToList().ForEach(o =>
                        {
                            if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.Product.ToString())
                            {
                                o.ARSaleOrderItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo,
                                                                                            o.ARSaleOrderItemProductUnitPrice,
                                                                                            entity.ARSaleOrderItemsList.Where(p => o.FK_ICProductID == p.FK_ICProductID && o.FK_ICMeasureUnitID == p.FK_ICMeasureUnitID).Sum(p => p.ARSaleOrderItemProductQty),
                                                                                            o.FK_ICMeasureUnitID,
                                                                                            objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                            mainObject.ARSaleOrderDate,
                                                                                            mainObject.FK_GECurrencyID);
                                o.ICProductUnitPrice = o.ARSaleOrderItemProductUnitPrice;
                                BOSApp.RoundByCurrency(o, mainObject.FK_GECurrencyID);
                                o.ARSaleOrderItemProductUnitPrice2 = mainObject.ARSaleOrderExchangeRate2 > 0 ? o.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2 : 0;
                            }
                            entity.SetProductPriceByProductUnitPrice(o);
                        });
                    }
                    (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                }
                if (SetProductDescColums.Contains(e.Column.FieldName))
                {
                    ((SaleOrderModule)entity.Module).SetDefaultSaleOrderItemProductDesc();
                }
                if (e.Column.FieldName == "ARSaleOrderItemProductQty")
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    string projectBKV = BOSApp.GetDisplayTextFromConfigValue("ProjectBKV", "true");
                    bool isProjectBKV = bool.Parse(string.IsNullOrWhiteSpace(projectBKV) ? "false" : projectBKV);
                    if (mainObject.STToolbarActionName == "Manual")
                    {
                        if (isProjectBKV)
                        {
                            if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.Product.ToString())
                            {
                                item.ARSaleOrderItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo,
                                                                                        item.ARSaleOrderItemProductUnitPrice,
                                                                                        item.ARSaleOrderItemProductQty,
                                                                                        item.FK_ICMeasureUnitID,
                                                                                        objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                        mainObject.ARSaleOrderDate,
                                                                                        mainObject.FK_GECurrencyID);
                                item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
                                item.ARSaleOrderItemProductUnitPrice2 = mainObject.ARSaleOrderExchangeRate2 > 0 ? item.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2 : 0;
                            }
                        }    
                        entity.ARSaleOrderItemsList.Where(o => o.FK_ICProductID == item.FK_ICProductID && o.FK_ICMeasureUnitID == item.FK_ICMeasureUnitID).ToList().ForEach(o =>
                        {
                            if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.Product.ToString())
                            {
                                o.ARSaleOrderItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo,
                                                                                        o.ARSaleOrderItemProductUnitPrice,
                                                                                        entity.ARSaleOrderItemsList.Where(p => o.FK_ICProductID == p.FK_ICProductID && o.FK_ICMeasureUnitID == p.FK_ICMeasureUnitID).Sum(p => p.ARSaleOrderItemProductQty),
                                                                                        o.FK_ICMeasureUnitID,
                                                                                        objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                        mainObject.ARSaleOrderDate,
                                                                                        mainObject.FK_GECurrencyID);
                                o.ICProductUnitPrice = o.ARSaleOrderItemProductUnitPrice;
                                BOSApp.RoundByCurrency(o, mainObject.FK_GECurrencyID);
                                o.ARSaleOrderItemProductUnitPrice2 = mainObject.ARSaleOrderExchangeRate2 > 0 ? o.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2 : 0;
                            }
                            entity.SetProductPriceByProductUnitPrice(o);
                        });
                        //((SaleOrderModule)Screen.Module).UpdatePriceForSaleType(item);
                    }
                    ((SaleOrderModule)Screen.Module).ChangeComponentItemQty();
                    ((SaleOrderModule)Screen.Module).AllocationQtyCont();
                }
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((SaleOrderModule)Screen.Module).ChangeStock();
                }
                if (e.Column.FieldName == "ARSaleOrderItemGrantedFrom")
                {
                    ((SaleOrderModule)Screen.Module).ChangeGrantedFrom();
                }
                if (e.Column.FieldName == "ARSaleOrderItemOriginOfProduct")
                {
                    ((SaleOrderModule)Screen.Module).ChangeOriginOfProduct();
                }
                if (e.Column.FieldName == "ARSaleOrderItemProductDiscount")
                {
                    if (mainObject.FK_ARPriceLevelID > 0)
                    {
                        DialogResult dr =
                            MessageBox.Show(SaleOrderLocalizedResources.ThePriceLevelIsReadyDoYouWantToContinue,
                                CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                            ((SaleOrderModule)entity.Module).ChangeProposalItemDiscountFix();
                    }
                }
                if (e.Column.FieldName == "ARSaleOrderItemDiscountAmount")
                {
                    ((SaleOrderModule)entity.Module).ChangeProposalItemDiscountAmount();
                }
                if (e.Column.FieldName == "ARSaleOrderItemWoodQty")
                {
                    ((SaleOrderModule)Screen.Module).CalculatedTotalProductQtyByPackageVolumnConfig(item);
                    (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                }
                //if (e.Column.FieldName == "ARSaleOrderItemIsPromotionProduct")
                //{
                //    ((SaleOrderModule)entity.Module).UpdatePriceWithPromotionProduct();
                //}
                //TKChinh [Add] [07/07/2016]

                if (count == 0 && mainObject.ARSaleOrderStatus == SaleOrderStatus.Confirmed.ToString())
                {
                    if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice2")
                    {
                        if (mainObject.ARSaleOrderSaleType == SaleType.National.ToString())
                        {
                            entity.RoundByCurrency(item);
                            item.ARSaleOrderItemProductUnitPrice = (mainObject.ARSaleOrderExchangeRate > 0 ? item.ARSaleOrderItemProductUnitPrice2 * mainObject.ARSaleOrderExchangeRate2 / mainObject.ARSaleOrderExchangeRate : 0);
                            item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                            item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
                            entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                            entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                            (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                            ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                        }
                        else
                        {
                            if (ShowMessage)
                            {
                                if (MessageBox.Show(ProposalLocalizedResources.ChangeItemProductUnitPrice2,
                                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (mainObject.ARSaleOrderExchangeRate > 0)
                                    {
                                        ShowMessage = false;
                                        entity.RoundByCurrency(item);
                                        item.ARSaleOrderItemProductUnitPrice = item.ARSaleOrderItemProductUnitPrice2 * mainObject.ARSaleOrderExchangeRate2 / mainObject.ARSaleOrderExchangeRate;
                                        item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                        item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
                                        entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                        entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                    }
                                }
                                else
                                {
                                    item.ARSaleOrderItemProductUnitPrice2 = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                                }
                            }
                            else
                            {
                                if (mainObject.ARSaleOrderExchangeRate > 0)
                                {
                                    entity.RoundByCurrency(item);
                                    item.ARSaleOrderItemProductUnitPrice = item.ARSaleOrderItemProductUnitPrice2 * mainObject.ARSaleOrderExchangeRate2 / mainObject.ARSaleOrderExchangeRate;
                                    item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                    item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
                                    entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                    entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                }
                            }
                        }
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice")
                    {
                        if (mainObject.ARSaleOrderSaleType == SaleType.International.ToString())
                        {
                            entity.RoundByCurrency(item);
                            item.ARSaleOrderItemProductUnitPrice2 = (mainObject.ARSaleOrderExchangeRate2 > 0 ? item.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2 : 0);
                            entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                            entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                            (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                            ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                        }
                        else
                        {
                            if (ShowMessage)
                            {
                                if (MessageBox.Show(ProposalLocalizedResources.ChangeItemProductUnitPrice,
                                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (mainObject.ARSaleOrderExchangeRate2 > 0)
                                    {
                                        ShowMessage = false;
                                        entity.RoundByCurrency(item);
                                        item.ARSaleOrderItemProductUnitPrice2 = item.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2;
                                        entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                        entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                    }
                                }
                                else
                                {
                                    item.ARSaleOrderItemProductUnitPrice = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                                    item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                }
                            }
                            else
                            {
                                if (mainObject.ARSaleOrderExchangeRate2 > 0)
                                {
                                    entity.RoundByCurrency(item);
                                    item.ARSaleOrderItemProductUnitPrice2 = item.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2;
                                    entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                    entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                }
                            }
                        }
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemProductQty")
                    {
                        ARCustomersController objCustomersController = new ARCustomersController();
                        ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                        ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                        ((SaleOrderModule)Screen.Module).AllocationQtyCont();
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemProductDiscount" || e.Column.FieldName == "ARSaleOrderItemProductTaxPercent")
                    {
                        (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                        ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemDiscountAmount")
                    {
                        (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                        ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                    }

                    //entity.ModuleObjects[TableName.ARSaleOrderItemsTableName] = (ARSaleOrderItemsInfo)item.Clone();

                    //((SaleOrderModule)Screen.Module).CheckPaymentTimeAmount();
                }
                //TKChinh End
                else
                {
                    if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice2")
                    {
                        if (mainObject.ARSaleOrderSaleType == SaleType.National.ToString())
                        {
                            entity.RoundByCurrency(item);
                            item.ARSaleOrderItemProductUnitPrice = item.ARSaleOrderItemProductUnitPrice2 * mainObject.ARSaleOrderExchangeRate2 / mainObject.ARSaleOrderExchangeRate;
                            item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                            item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
                            entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                            entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                        }
                        else
                        {
                            if (ShowMessage)
                            {
                                if (MessageBox.Show(ProposalLocalizedResources.ChangeItemProductUnitPrice2,
                                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (mainObject.ARSaleOrderExchangeRate > 0)
                                    {
                                        ShowMessage = false;
                                        entity.RoundByCurrency(item);
                                        item.ARSaleOrderItemProductUnitPrice = item.ARSaleOrderItemProductUnitPrice2 * mainObject.ARSaleOrderExchangeRate2 / mainObject.ARSaleOrderExchangeRate;
                                        item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                        item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
                                        entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                        entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                    }
                                }
                                else
                                {
                                    item.ARSaleOrderItemProductUnitPrice2 = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                                }
                            }
                            else
                            {
                                if (mainObject.ARSaleOrderExchangeRate > 0)
                                {
                                    entity.RoundByCurrency(item);
                                    item.ARSaleOrderItemProductUnitPrice = item.ARSaleOrderItemProductUnitPrice2 * mainObject.ARSaleOrderExchangeRate2 / mainObject.ARSaleOrderExchangeRate;
                                    item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                    item.ARSaleOrderItemTotalAmount2 = item.ARSaleOrderItemProductUnitPrice2 * item.ARSaleOrderItemProductQty;
                                    entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                    entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                }
                            }
                        }
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemProductUnitPrice")
                    {
                        if (mainObject.ARSaleOrderSaleType == SaleType.International.ToString())
                        {
                            ((SaleOrderModule)Screen.Module).UpdatePriceForSaleType();
                        }
                        else
                        {
                            if (ShowMessage)
                            {
                                if (MessageBox.Show(ProposalLocalizedResources.ChangeItemProductUnitPrice,
                                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (mainObject.ARSaleOrderExchangeRate2 > 0)
                                    {
                                        ShowMessage = false;
                                        entity.RoundByCurrency(item);
                                        item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                        item.ARSaleOrderItemProductUnitPrice2 = item.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2;
                                        entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                        entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                    }
                                }
                                else
                                {
                                    item.ARSaleOrderItemProductUnitPrice = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                                    item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                }
                            }
                            else
                            {
                                if (mainObject.ARSaleOrderExchangeRate2 > 0)
                                {
                                    entity.RoundByCurrency(item);
                                    item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                                    item.ARSaleOrderItemProductUnitPrice2 = item.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2;
                                    entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                                    entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                                }
                            }
                        }
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemProductQty")
                    {
                        (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                        ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                        ((SaleOrderModule)Screen.Module).AllocationQtyCont();
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemProductDiscount")
                    {
                        (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                        ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                    }
                    if (e.Column.FieldName == "ARSaleOrderItemDiscountAmount" || e.Column.FieldName == "ARSaleOrderItemProductTaxPercent")
                    {
                        (entity.Module as SaleOrderModule).ChangeItemFromSaleOrderItemsList();
                        ((SaleOrderModule)Screen.Module).UpdatePaymentTime();
                    }
                    //entity.ModuleObjects[TableName.ARSaleOrderItemsTableName] = (ARSaleOrderItemsInfo)item.Clone();
                }

                if (e.Column.FieldName == "ARSaleOrderItemIsPromotionProduct")
                {
                    ((SaleOrderModule)Screen.Module).CheckPromotionItem();
                }

                if (e.Column.FieldName == "ARSaleOrderItemProductSerialNo")
                {
                    ((SaleOrderModule)Screen.Module).UpdateLotNoItem(item);
                    gridView.RefreshData();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
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

            if (e.Column.FieldName == "FK_ICProductAttributeColorID"
                || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID"
                || e.Column.FieldName == "FK_ICProductAttributeQualityID"
                || e.Column.FieldName == "FK_ICProductAttributeTTMTID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    if (matchCodeID > 0)
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", matchCodeID, "ICProductAttributeValue");
                    else
                        e.DisplayText = "";
                }
            }


            if (e.Column.FieldName == "ARSaleOrderItemColorID" || e.Column.FieldName == "ARSaleOrderItemWoodTypeID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((SaleOrderModule)Screen.Module).GetAttributeText(e.Value.ToString());
                }
            }

        }

        public void LoadGridViewSourceSellingPrice(bool IsEditPrice)
        {
            GridView gridView = (GridView)MainView;
            SetDefaultAllowEditPropertyOfColumns(gridView);
            GridColumn column = gridView.Columns["ARSaleOrderItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = IsEditPrice;
            }
            column = gridView.Columns["ARSaleOrderItemProductUnitPrice2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = IsEditPrice;
            }
        }

        public void LoadGridViewEditAfterPayment()
        {
            GridView gridView = (GridView)MainView;
            foreach (GridColumn columnedit in gridView.Columns)
            {
                columnedit.OptionsColumn.AllowEdit = false;
            }

            GridColumn column = gridView.Columns["ARSaleOrderItemGrantedFrom"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleOrderItemDeliveryDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleOrderItemDeliveryTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleOrderItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICProductAttributeColorID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleOrderItemColorID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
        }

        #region OtherColor

        private void rpProductAttributeColorAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((SaleOrderModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                string[] arr = objSaleOrderItemsInfo.ARSaleOrderItemColorID.Split(',');
                ProductAttributesList.ForEach(o =>
                {
                    if (arr.Contains(o.ICProductAttributeID.ToString()))
                        o.Selected = true;
                });
                lookUpEdit.Properties.DataSource = ProductAttributesList;
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                lookUpEdit.Properties.ImmediatePopup = true;
                lookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(100, 70);
                lookUpEdit.Properties.View.OptionsSelection.MultiSelect = true;
                lookUpEdit.Properties.View.OptionsSelection.EnableAppearanceHideSelection = true;
                lookUpEdit.Properties.View.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                lookUpEdit.Properties.View.OptionsSelection.UseIndicatorForSelection = true;
                lookUpEdit.Properties.View.OptionsSelection.EnableAppearanceFocusedRow = true;
                lookUpEdit.Properties.View.OptionsView.ShowIndicator = false;
                foreach (GridColumn column in lookUpEdit.Properties.View.Columns)
                {
                    if (column.FieldName != "ICProductAttributeValue" && column.FieldName != "Selected")
                        column.Visible = false;
                }
                GridColumn columItem = lookUpEdit.Properties.View.Columns["Selected"];
                if (columItem != null)
                {
                    columItem.OptionsColumn.AllowEdit = true;
                    columItem.Caption = "Chọn";
                    columItem.VisibleIndex = 0;
                    columItem.MinWidth = 65;
                    columItem.Width = 65;
                    columItem.MaxWidth = 65;
                }
                columItem = lookUpEdit.Properties.View.Columns["ICProductAttributeValue"];
                if (columItem != null)
                {
                    columItem.VisibleIndex = 1;
                    columItem.Caption = "Màu sơn";
                    columItem.MinWidth = 100;
                }
            }
        }

        private void rpProductAttributeColorAttributeProperties_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ARSaleOrderItemColorID = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
                item.ARSaleOrderItemColorText = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeValue.ToString()).ToArray());
                ((SaleOrderModule)Screen.Module).SetDefaultSaleOrderItemProductDesc();
                gridView.RefreshData();
            }
        }

        private void rpProductAttributeColorAttributeView_RowClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductAttributesInfo item = (ICProductAttributesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item == null || item.ICProductAttributeID == 0)
                    return;
                item.Selected = !item.Selected;
                gridView.RefreshData();
            }
        }
        #endregion

        #region OtherWoodType
        private void rpProductAttributeWoodTypeAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((SaleOrderModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                string[] arr = objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID.Split(',');
                ProductAttributesList.ForEach(o =>
                {
                    if (arr.Contains(o.ICProductAttributeID.ToString()))
                        o.Selected = true;
                });
                lookUpEdit.Properties.DataSource = ProductAttributesList;
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                lookUpEdit.Properties.ImmediatePopup = true;
                lookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(100, 70);
                lookUpEdit.Properties.View.OptionsSelection.MultiSelect = true;
                lookUpEdit.Properties.View.OptionsSelection.EnableAppearanceHideSelection = true;
                lookUpEdit.Properties.View.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                lookUpEdit.Properties.View.OptionsSelection.UseIndicatorForSelection = true;
                lookUpEdit.Properties.View.OptionsSelection.EnableAppearanceFocusedRow = true;
                lookUpEdit.Properties.View.OptionsView.ShowIndicator = false;
                foreach (GridColumn column in lookUpEdit.Properties.View.Columns)
                {
                    if (column.FieldName != "ICProductAttributeValue" && column.FieldName != "Selected")
                        column.Visible = false;
                }
                GridColumn columItem = lookUpEdit.Properties.View.Columns["Selected"];
                if (columItem != null)
                {
                    columItem.OptionsColumn.AllowEdit = true;
                    columItem.Caption = "Chọn";
                    columItem.VisibleIndex = 0;
                    columItem.MinWidth = 65;
                    columItem.Width = 65;
                    columItem.MaxWidth = 65;
                }
                columItem = lookUpEdit.Properties.View.Columns["ICProductAttributeValue"];
                if (columItem != null)
                {
                    columItem.VisibleIndex = 1;
                    columItem.Caption = "Loại gỗ";
                    columItem.MinWidth = 100;
                }
            }
        }

        private void rpProductAttributeWoodTypeAttributeView_RowClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductAttributesInfo item = (ICProductAttributesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item == null || item.ICProductAttributeID == 0)
                    return;
                item.Selected = !item.Selected;
                gridView.RefreshData();
            }
        }

        private void rpProductAttributeWoodTypeAttributeProperties_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ARSaleOrderItemWoodTypeID = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
                item.ARSaleOrderItemWoodTypeText = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeValue).ToArray());
                gridView.RefreshData();
            }
        }

        public List<ACCostCentersInfo> GetAllCostCenter()
        {
            ACCostCentersController objCostCentersController = new ACCostCentersController();
            List<ACCostCentersInfo> costCenterList = objCostCentersController.GetAllAliveAndActiveCostCenter();
            return costCenterList;
        }

        private void rpCostCenter_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                lookUpEdit.Properties.DataSource = GetAllCostCenter();
            }
        }
        #endregion

        private void rpSectionProduct_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                if (lookUpEdit != null)
                    lookUpEdit.Properties.DataSource = lookUpEdit.Properties.DataSource = ((SaleOrderModule)Screen.Module).GetAllSectionProductForLookUp();
                gridView.RefreshData();
            }
        }

        public List<ICProductsForViewInfo> GetAllSectionAndWorkForLookUp()
        {
            return BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Work.ToString()
                                                        || o.ICProductType == ProductType.Section.ToString())
                                             .ToList();

        }

        public void LoadGridViewAccordingToToolbarActionNew(string actionNew)
        {
            GridView gridView = (GridView)MainView;

            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;

            GridColumn column = new GridColumn();
            if (actionNew.Equals("NewFromWood"))
            {
                column = gridView.Columns["ARSaleOrderItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng";
                }
                column = gridView.Columns["FK_ICProductGroupID"];
                if (column != null)
                {
                    column.Visible = true;
                }
                column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
                if (column != null)
                {
                    column.Visible = true;
                }
                column = gridView.Columns["ARSaleOrderItemWoodTypeID"];
                if (column != null)
                {
                    column.Visible = true;
                }
                column = gridView.Columns["FK_ICLengthGroupID"];
                if (column != null)
                {
                    column.Visible = true;
                }
                column = gridView.Columns["ARSaleOrderItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                column = gridView.Columns["ARSaleOrderItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng";
                }
                column = gridView.Columns["FK_ICProductGroupID"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
                if (column != null)
                {
                    column.Visible = true;
                }

                column = gridView.Columns["FK_ICLengthGroupID"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["ARSaleOrderItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
        }

        private void rpMeasureUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                GeneralHelper.ChangeSaleItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
            ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ARSaleOrderItemProductFactor")
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

        public void SetDefaultAllowEditPropertyOfColumns(GridView gridView)
        {
            List<string> allowEditColumns = new List<string>()
            {
                "ARSOItemComponent",
                "ARSOItemCopyItem",
                "ARProposalTemplateItemProductName",
                "ARSaleOrderItemProductQty",
                "ARSaleOrderItemWidth",
                "ARSaleOrderItemLength",
                "ARSaleOrderItemHeight",
                "ARSaleOrderItemDiscountAmount",
                "ARSaleOrderItemProductDiscount",
                "ARSaleOrderItemTaxAmount",
                "ARSaleOrderItemDeliveryDate",
                "ARSaleOrderItemDeliveryTime",
                "ARSaleOrderItemProductTaxPercent",
                "FK_ICStockID",
                "FK_ICProductAttributeQualityID",
                "ARSaleOrderItemIsPromotionProduct",
                "ARSaleOrderItemIsDeliveryPlan",
                "ARSaleOrderItemIsSaleOrderShipment",
                "IsInlandItemProductName",
                "ARSaleOrderItemIsVehicleAllocation",
                "ARSaleOrderItemIsInvoiceAndShipment",
                "ARSaleOrderItemProductSerialNo",
                "ARSaleOrderItemLotNo",
                "ARSaleOrderItemOriginOfProduct",
                "ARSaleOrderItemRemark",
                "FK_ACAssetID",
                "FK_ICProductEquipmentID",
                "ARSaleOrderItemGrantedFrom",
                "ARSaleOrderItemIsAcceptance",
                "FK_ICProductAttributeWoodTypeID",
                "FK_ICProductAttributeColorID",
                "ARSaleOrderItemWoodTypeID",
                "ARSaleOrderItemColorID",
                "ARSaleOrderItemOneLevelArea",
                "ARSaleOrderItemTwoLevelArea",
                "ARSaleOrderItemThreeLevelArea",
                "FK_ACCostCenterID",
                "FK_ICSectionProductID",
                "FK_ICProductAttributeTTMTID",
                "FK_ICMeasureUnitID",
                //"ARSaleOrderItemProductFactor",
                "ARSaleOrderItemQuantityOfBox",
                "ARSaleOrderItemWoodQty"
            };

            List<string> notAllowEditColumns = new List<string>()
            {

            };
            GridColumn column;
            allowEditColumns.ForEach(o1 =>
            {
                column = gridView.Columns[o1];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            });
            notAllowEditColumns.ForEach(o1 =>
            {
                column = gridView.Columns[o1];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            });
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ARSaleOrderItemsList.CurrentIndex >= 0)
            {
                ((SaleOrderModule)Screen.Module).InitProductPictureImage(entity.ARSaleOrderItemsList[entity.ARSaleOrderItemsList.CurrentIndex].FK_ICProductID);
            }
        }
        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
                return;

            ARSaleOrderItemsInfo item = (ARSaleOrderItemsInfo)gridView.GetRow(e.RowHandle);
            if (e.Column.FieldName == "ICInventoryStockQty" && e.CellValue != null)
            {
                if (item.IsCheckInventory)
                {
                    if (item.ARSaleOrderItemProductQty > item.ICInventoryStockQty)
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
            else if (e.Column.FieldName == "ICInventorySaleOderStockQty" && e.CellValue != null)
            {
                if (item.IsCheckInventory)
                {
                    if (item.ARSaleOrderItemProductQty > item.ICInventorySaleOderStockQty)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.BackColor2 = Color.Green;
                    }
                }
            }
        }
    }
}
