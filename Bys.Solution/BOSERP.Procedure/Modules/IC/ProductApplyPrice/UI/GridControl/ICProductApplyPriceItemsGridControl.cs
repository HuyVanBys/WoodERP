using BOSCommon;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductApplyPrice
{
    public class ICProductApplyPriceItemsGridControl : ItemGridControl
    {
        private List<ICProductAttributesInfo> ProductAttributesList { get; set; }
        public override void InitGridControlDataSource()
        {
            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductApplyPriceItemList;
            this.DataSource = bds;
            ProductAttributesList = new List<ICProductAttributesInfo>();
        }

        public enum ProductApplyPriceItemsColumnName
        {
            ICProductApplyPriceItemQty,
            ICProductApplyPriceItemPrice,
            FK_ICProductAttributeWoodTypeID,
            ICProductApplyPriceItemProductLength,
            ICProductApplyPriceItemProductWidth,
            ICProductApplyPriceItemProductHeight,
            FK_ICProductAttributeColorID,
            ICProductApplyPriceItemProductColorAttribute,
            ICProductApplyPriceItemProductWoodTypeAttribute,
            FK_ICProductFormulaPriceConfigID,
            ICProductApplyPriceItemCommand,
            ICProductApplyPriceItemTotalAmount,
            ICProductApplyPriceItemSubTotalAmount,
            ICProductApplyPriceItemDiscountPercent,
            ICProductApplyPriceItemDiscountAmount,
            ICProductApplyPriceItemTaxPercent,
            ICProductApplyPriceItemTaxAmount
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns[ProductApplyPriceItemsColumnName.FK_ICProductAttributeWoodTypeID.ToString()];
            if (column != null)
            {
                //ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                column.OptionsColumn.AllowEdit = false;
                //RepositoryItemGridLookUpEdit rpProductAttributeWoodTypeID = new RepositoryItemGridLookUpEdit();
                //rpProductAttributeWoodTypeID.DataSource = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.WoodType.ToString());
                //rpProductAttributeWoodTypeID.DisplayMember = "ICProductAttributeValue";
                //rpProductAttributeWoodTypeID.ValueMember = "ICProductAttributeID";
                //rpProductAttributeWoodTypeID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //rpProductAttributeWoodTypeID.NullText = string.Empty;
                //rpProductAttributeWoodTypeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpProductAttributeWoodTypeID_QueryPopUp);
                //column.ColumnEdit = rpProductAttributeWoodTypeID;
            }

            GridColumn column2 = gridView.Columns[ProductApplyPriceItemsColumnName.FK_ICProductAttributeColorID.ToString()];
            if (column2 != null)
            {
                column2.OptionsColumn.AllowEdit = true;
                //column2.Caption = "Màu sơn";
                //RepositoryItemGridLookUpEdit rpProductAttributeWoodTypeID = new RepositoryItemGridLookUpEdit();
                //rpProductAttributeWoodTypeID.DisplayMember = "ICProductAttributeValue";
                //rpProductAttributeWoodTypeID.ValueMember = "ICProductAttributeID";
                //rpProductAttributeWoodTypeID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //rpProductAttributeWoodTypeID.PopupFilterMode = PopupFilterMode.Contains;
                //rpProductAttributeWoodTypeID.NullText = string.Empty;
                //rpProductAttributeWoodTypeID.DataSource = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                //rpProductAttributeWoodTypeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpProductAttributeColor_QueryPopUp);
                //column2.ColumnEdit = rpProductAttributeWoodTypeID;
            }

            GridColumn column3 = gridView.Columns[ProductApplyPriceItemsColumnName.ICProductApplyPriceItemProductWoodTypeAttribute.ToString()];
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

            GridColumn column4 = gridView.Columns[ProductApplyPriceItemsColumnName.ICProductApplyPriceItemProductColorAttribute.ToString()];
            if (column4 != null)
            {
                column4.OptionsColumn.AllowEdit = true;
                column4.Caption = "Màu sơn khác";
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

            GridColumn column5 = gridView.Columns[ProductApplyPriceItemsColumnName.ICProductApplyPriceItemTaxAmount.ToString()];
            if (column4 != null)
            {
                column4.OptionsColumn.AllowEdit = false;
            }

            GridColumn column6 = gridView.Columns[ProductApplyPriceItemsColumnName.ICProductApplyPriceItemDiscountAmount.ToString()];
            if (column5 != null)
            {
                column5.OptionsColumn.AllowEdit = false;
            }

            new ProductApplyPriceItemsColumnName[]
            {
                ProductApplyPriceItemsColumnName.FK_ICProductAttributeWoodTypeID,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemProductLength,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemProductWidth,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemProductHeight,
                ProductApplyPriceItemsColumnName.FK_ICProductAttributeColorID,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemProductColorAttribute,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemProductWoodTypeAttribute,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemCommand,
                ProductApplyPriceItemsColumnName.FK_ICProductFormulaPriceConfigID,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemDiscountPercent,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemTaxPercent,
                ProductApplyPriceItemsColumnName.ICProductApplyPriceItemPrice
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            return gridView;
        }

        private void rpProductAttributeWoodTypeAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductApplyPriceItemsInfo objICProductApplyPriceItemsInfo = (ICProductApplyPriceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                string[] arr = objICProductApplyPriceItemsInfo.ICProductApplyPriceItemProductWoodTypeAttribute.Split(',');
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
                ICProductApplyPriceItemsInfo objICProductApplyPriceItemsInfo = (ICProductApplyPriceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                string[] arr = objICProductApplyPriceItemsInfo.ICProductApplyPriceItemProductColorAttribute.Split(',');
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
                lookUpEdit.Properties.DataSource = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
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
                lookUpEdit.Properties.DataSource = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
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
                lookUpEdit.Properties.DataSource = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
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
                lookUpEdit.Properties.DataSource = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
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

            if (e.Column.FieldName == "ICProductApplyPriceItemProductWoodTypeAttribute")
            {
                if (e.Value != null)
                {
                    string[] arrProductAttributes = e.Value.ToString().Split(',');
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    List<ICProductAttributesInfo> productAtributesList = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                    if (productAtributesList != null)
                        e.DisplayText = string.Join(",", productAtributesList.Where(o => arrProductAttributes.Contains(o.ICProductAttributeID.ToString()))
                                                                             .Select(o => o.ICProductAttributeValue).ToArray());
                    else
                        e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "ICProductApplyPriceItemProductColorAttribute")
            {
                if (e.Value != null)
                {
                    string[] arrProductAttributes = e.Value.ToString().Split(',');
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    List<ICProductAttributesInfo> productAtributesList = ((ProductApplyPriceModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                    if (productAtributesList != null)
                        e.DisplayText = string.Join(",", productAtributesList.Where(o => arrProductAttributes.Contains(o.ICProductAttributeID.ToString()))
                                                                             .Select(o => o.ICProductAttributeValue).ToArray());
                    else
                        e.DisplayText = "";
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
            GridView gridview = (GridView)MainView;

            if (e.Column.FieldName == ProductApplyPriceItemsColumnName.ICProductApplyPriceItemPrice.ToString())
            {
                ICProductApplyPriceItemsInfo item = (ICProductApplyPriceItemsInfo)gridview.GetRow(gridview.FocusedRowHandle);
                ((ProductApplyPriceModule)Screen.Module).ChangeProductApplyPriceItemPrice(item);
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductApplyPriceModule)Screen.Module).DeleteItemFromProductApplyPriceItemList();
            }
        }

        void rpProductAttributeWoodTypeAttributeProperties_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductApplyPriceItemsInfo item = (ICProductApplyPriceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ICProductApplyPriceItemProductWoodTypeAttribute = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
                gridView.RefreshData();
            }
        }

        void rpProductAttributeWoodTypeAttributeView_RowClick(object sender, EventArgs e)
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

        void rpProductAttributeColorAttributeProperties_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductApplyPriceItemsInfo item = (ICProductApplyPriceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ICProductApplyPriceItemProductColorAttribute = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
                gridView.RefreshData();
            }
        }

        void rpProductAttributeColorAttributeView_RowClick(object sender, EventArgs e)
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
    }
}
