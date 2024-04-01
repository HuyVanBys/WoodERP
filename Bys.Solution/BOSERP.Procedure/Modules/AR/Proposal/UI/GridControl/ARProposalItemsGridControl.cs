using BOSCommon;
using BOSCommon.Constants;
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
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public partial class ARProposalItemsGridControl : BOSComponent.BOSGridControl
    {
        private List<ICProductAttributesInfo> ProductAttributesList { get; set; }
        private enum ProposalItemColumnName
        {
            ARProposalItemHeight,
            ARProposalItemWidth,
            ARProposalItemLength,
            FK_ICProductAttributeColorID,
            FK_ICProductAttributeWoodTypeID,
            ARProposalItemProductColorAttribute,
            ARProposalItemProductWoodTypeAttribute,
            ARProposalItemProductAttribute,
        }

        private string[] SetProductDescColums = new string[]
        {
            ProposalItemColumnName.ARProposalItemHeight.ToString(),
            ProposalItemColumnName.ARProposalItemWidth.ToString(),
            ProposalItemColumnName.ARProposalItemLength.ToString(),
            ProposalItemColumnName.FK_ICProductAttributeColorID.ToString(),
            ProposalItemColumnName.FK_ICProductAttributeWoodTypeID.ToString(),
            ProposalItemColumnName.ARProposalItemProductColorAttribute.ToString(),
            ProposalItemColumnName.ARProposalItemProductWoodTypeAttribute.ToString(),
            ProposalItemColumnName.ARProposalItemProductAttribute.ToString(),
        };

        public override void InitGridControlDataSource()
        {
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARProposalItemsList;
            this.DataSource = bds;
            ProductAttributesList = new List<ICProductAttributesInfo>();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProposalLocalizedResources.ARProposalItemProductQtyRemained;
            column.FieldName = "ARProposalItemProductQtyRemained";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ProposalLocalizedResources.ARPriceSheetNo;
            column.FieldName = "ARPriceSheetNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Thành phần";
            column.FieldName = "ARSOItemComponent";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "Xác định thành phần";
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
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
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["ARProposalItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemDiscountFix"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeColorID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsInlandItemProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARProposalItemDeliveryDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemProductWoodTypeAttribute"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
                column.ColumnEdit = rpProductAttributeWoodTypeAttribute;
            }
            column = gridView.Columns["ARProposalItemProductColorAttribute"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
                column.ColumnEdit = rpProductAttributeColor;
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
            column = gridView.Columns["ARProposalItemOneLevelArea"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemTwoLevelArea"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemThreeLevelArea"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARProposalItemProductUnitPrice2"];
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
            gridView.CellValueChanging += GridView_CellValueChanging;
            return gridView;
        }

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "IsInlandItemProductName")
            {
                {
                    ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    ARProposalItemsInfo item = (ARProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ((ProposalModule)Screen.Module).ChangeForeignItemProductName(item, bool.Parse(e.Value.ToString()));
                }
            }
        }

        private void rpMeasureUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARProposalItemsInfo item = (ARProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();
                ICProductMeasureUnitsInfo objProductMeasureUnitsInfo = objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                if (objProductsInfo != null && objProductsInfo.FK_ICProductBasicUnitID == item.FK_ICMeasureUnitID)
                    item.ARProposalItemProductSellFactor = (decimal)1;
                else
                    item.ARProposalItemProductSellFactor = objProductMeasureUnitsInfo != null ? objProductMeasureUnitsInfo.ICProductMeasureUnitFactor : 1;
                item.ARProposalItemProductExchangeQty = item.ARProposalItemProductQty * item.ARProposalItemProductSellFactor;
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARProposalItemsInfo item = (ARProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        private void RepoItemBtnEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ((ProposalModule)Screen.Module).ShowTemplateItemTree();
        }

        private void rpProductAttributeWoodTypeAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARProposalItemsInfo objARProposalItemsInfo = (ARProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                string[] arr = objARProposalItemsInfo.ARProposalItemProductWoodTypeAttribute.Split(',');
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

        private void rpProductAttributeColorAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARProposalItemsInfo objARProposalItemsInfo = (ARProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                string[] arr = objARProposalItemsInfo.ARProposalItemProductColorAttribute.Split(',');
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

        private void rpProductAttributeWoodTypeID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                lookUpEdit.Properties.DataSource = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                lookUpEdit.Properties.ImmediatePopup = true;
                lookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(100, 70);
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

        private void rpProductAttributeColorID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                lookUpEdit.Properties.DataSource = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
            }
        }

        private void rpProductWoodTypeAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                CheckedComboBoxEdit lookUpEdit = (CheckedComboBoxEdit)sender;
                lookUpEdit.Properties.DataSource = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
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
                lookUpEdit.Properties.DataSource = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                lookUpEdit.Properties.ImmediatePopup = true;
                lookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(100, 70);
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

        private void rpProductAttributeColor_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                CheckedComboBoxEdit lookUpEdit = (CheckedComboBoxEdit)sender;
                if (lookUpEdit.EditValue != e.Value)
                {
                    ((ProposalModule)Screen.Module).ChangeMoreColor(e.Value.ToString());
                }
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
                    ((ProposalModule)Screen.Module).ChangeMoreWoodType(e.Value.ToString());
                }
            }
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((ProposalModule)Screen.Module).ShowItemComponent();
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARProposalsInfo mainObject = (ARProposalsInfo)entity.MainObject;
            if (entity.ARProposalItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.ARProposalItemsTableName] = (ARProposalItemsInfo)entity.ARProposalItemsList[entity.ARProposalItemsList.CurrentIndex];
                ARProposalItemsInfo item = entity.ARProposalItemsList[entity.ARProposalItemsList.CurrentIndex];

                if (SetProductDescColums.Contains(e.Column.FieldName))
                {
                    ((ProposalModule)entity.Module).SetDefaultProposalItemProductDesc();
                }
                if (e.Column.FieldName == "ARProposalItemDiscountAmount")
                {
                    ((ProposalModule)entity.Module).ChangeProposalItemDiscountAmount();
                }
                if (e.Column.FieldName == "ARProposalItemProductTaxPercent")
                {
                    ((ProposalModule)Screen.Module).ChangeTaxPercent(item);
                }
                if (e.Column.FieldName == "ARProposalItemProductUnitPrice2")
                {
                    entity.RoundByCurrency(item);
                    item.ARProposalItemTotalAmount2 = item.ARProposalItemProductUnitPrice2 * item.ARProposalItemProductQty;
                    entity.RoundByCurrency(item);
                    if (mainObject.ARProposalSaleType == SaleType.National.ToString())
                    {
                        entity.RoundByCurrency(item);
                        item.ARProposalItemProductUnitPrice = item.ARProposalItemProductUnitPrice2 * mainObject.ARProposalExchangeRate2 / mainObject.ARProposalExchangeRate;
                        entity.SetProductPriceByProductUnitPrice(item);
                    }
                    else
                    {
                        if (MessageBox.Show(ProposalLocalizedResources.ChangeItemProductUnitPrice2,
                            CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (mainObject.ARProposalExchangeRate > 0)
                            {
                                entity.RoundByCurrency(item);
                                item.ARProposalItemProductUnitPrice = item.ARProposalItemProductUnitPrice2 * mainObject.ARProposalExchangeRate2 / mainObject.ARProposalExchangeRate;
                                entity.SetProductPriceByProductUnitPrice(item);
                            }
                        }
                        else
                        {
                            item.ARProposalItemProductUnitPrice2 = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                }

                if (e.Column.FieldName == "ARProposalItemProductUnitPrice")
                {
                    if (mainObject.ARProposalSaleType == SaleType.International.ToString())
                    {
                        ((ProposalModule)Screen.Module).UpdatePriceForSaleType(mainObject.ARProposalSaleType, item);
                    }
                    else
                    {
                        if (MessageBox.Show(ProposalLocalizedResources.ChangeItemProductUnitPrice,
                            CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (mainObject.ARProposalExchangeRate2 > 0)
                            {
                                entity.RoundByCurrency(item);
                                item.ARProposalItemProductUnitPrice2 = item.ARProposalItemProductUnitPrice * mainObject.ARProposalExchangeRate / mainObject.ARProposalExchangeRate2;
                                entity.SetProductPriceByProductUnitPrice(item);
                            }
                        }
                        else
                        {
                            item.ARProposalItemProductUnitPrice = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                }
                if (e.Column.FieldName == "ARProposalItemProductQty")
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo product = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (product != null && mainObject.ARProposalSourceSellingPriceMethod == SourceSellingPriceMethod.Config.ToString())
                    {
                        item.ARProposalItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(product,
                                                                                    item.ARProposalItemProductUnitPrice,
                                                                                    item.ARProposalItemProductQty,
                                                                                    item.FK_ICMeasureUnitID,
                                                                                    objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                    mainObject.ARProposalDate,
                                                                                    mainObject.FK_GECurrencyID);
                        item.ARProposalItemProductUnitPrice2 = mainObject.ARProposalExchangeRate2 > 0 ? item.ARProposalItemProductUnitPrice * mainObject.ARProposalExchangeRate / mainObject.ARProposalExchangeRate2 : 0;
                        entity.SetProductPriceByProductUnitPrice(item);
                    }
                }
                (entity.Module as ProposalModule).ChangeItemFromProposalItemsList();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProposalModule)Screen.Module).DeleteItemFromProposalItemsList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeColorID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAtributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
                    if (objProductAtributesInfo != null)
                        e.DisplayText = objProductAtributesInfo.ICProductAttributeValue;
                    else
                        e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int productID = int.Parse(e.Value.ToString());
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                    if (objProductsInfo != null)
                        e.DisplayText = objProductsInfo.ICProductNo;
                    else
                        e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAtributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
                    if (objProductAtributesInfo != null)
                        e.DisplayText = objProductAtributesInfo.ICProductAttributeValue;
                    else
                        e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "ARProposalItemProductWoodTypeAttribute")
            {
                if (e.Value != null)
                {
                    string[] arrProductAttributes = e.Value.ToString().Split(',');
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    List<ICProductAttributesInfo> productAtributesList = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                    if (productAtributesList != null)
                        e.DisplayText = string.Join(",", productAtributesList.Where(o => arrProductAttributes.Contains(o.ICProductAttributeID.ToString()))
                                                                             .Select(o => o.ICProductAttributeValue).ToArray());
                    else
                        e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "ARProposalItemProductColorAttribute")
            {
                if (e.Value != null)
                {
                    string[] arrProductAttributes = e.Value.ToString().Split(',');
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    List<ICProductAttributesInfo> productAtributesList = ((ProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                    if (productAtributesList != null)
                        e.DisplayText = string.Join(",", productAtributesList.Where(o => arrProductAttributes.Contains(o.ICProductAttributeID.ToString()))
                                                                             .Select(o => o.ICProductAttributeValue).ToArray());
                    else
                        e.DisplayText = "";
                }
            }
            if (e.Column.FieldName == "FK_ICProductFormulaPriceConfigID")
            {
                if (e.Value != null)
                {
                    int objectID = 0;
                    Int32.TryParse(e.Value.ToString(), out objectID);
                    ICProductFormulaPriceConfigsController objProductFormulaPriceConfigsController = new ICProductFormulaPriceConfigsController();
                    ICProductFormulaPriceConfigsInfo objProductFormulaPriceConfigsInfo = (ICProductFormulaPriceConfigsInfo)objProductFormulaPriceConfigsController.GetObjectByID(objectID);
                    if (objProductFormulaPriceConfigsInfo != null)
                        e.DisplayText = objProductFormulaPriceConfigsInfo.ICProductFormulaPriceConfigName;
                    else
                        e.DisplayText = string.Empty;
                }
            }
            if (e.Column.FieldName == "FK_ICDepartmentID")
            {
                if (e.Value != null)
                {
                    int objectID = 0;
                    Int32.TryParse(e.Value.ToString(), out objectID);
                    ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                    ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objectID);
                    if (objDepartmentsInfo != null)
                        e.DisplayText = objDepartmentsInfo.ICDepartmentName;
                    else
                        e.DisplayText = string.Empty;
                }
            }
        }

        private void RpItemProductWoodTypeAttribute_ButtonClick(object sender, EventArgs e)
        {
            ((ProposalModule)Screen.Module).ShowProductWoodTypeAttribute();
        }

        private void RpItemProductColorAttribute_ButtonClick(object sender, EventArgs e)
        {
            ((ProposalModule)Screen.Module).ShowProductColorAttribute();
        }

        private void rpProductAttributeWoodTypeAttributeProperties_CloseUp(object sender, CloseUpEventArgs e)
        {
            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARProposalItemsInfo item = (ARProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ARProposalItemProductWoodTypeAttribute = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
                gridView.RefreshData();
                ((ProposalModule)entity.Module).SetDefaultProposalItemProductDesc();
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

        private void rpProductAttributeColorAttributeProperties_CloseUp(object sender, CloseUpEventArgs e)
        {
            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARProposalItemsInfo item = (ARProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ARProposalItemProductColorAttribute = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
                gridView.RefreshData();
                ((ProposalModule)entity.Module).SetDefaultProposalItemProductDesc();
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

        private void rpSectionProduct_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                if (lookUpEdit != null)
                    lookUpEdit.Properties.DataSource = ((ProposalModule)Screen.Module).GetAllSectionProductForLookUp();
                gridView.RefreshData();
            }
        }

        public List<ICProductsForViewInfo> GetAllSectionAndWorkForLookUp()
        {
            return BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Work.ToString()
                                                        || o.ICProductType == ProductType.Section.ToString())
                                             .ToList();

        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ARProposalItemsList.CurrentIndex >= 0)
            {
                ((ProposalModule)Screen.Module).InitProductPictureImage(entity.ARProposalItemsList[entity.ARProposalItemsList.CurrentIndex].FK_ICProductID);
            }
        }
        public void LoadGridViewBySourceSelling(string sourceSellingType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = new GridColumn();
            if (sourceSellingType == SourceSellingPriceMethod.Typing.ToString())
            {
                column = gridView.Columns["ARProposalItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                column = gridView.Columns["ARProposalItemProductUnitPrice2"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                column = gridView.Columns["ARProposalItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                column = gridView.Columns["ARProposalItemProductUnitPrice2"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
        }
    }
}
