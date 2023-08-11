using BOSCommon;
using BOSComponent;
using BOSLib;
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

namespace BOSERP.Modules.TransferProposal
{
    public partial class ICTransferProposaltemsGridControl : BOSGridControl
    {
        private List<ICProductAttributesInfo> ProductAttributesList { get; set; }

        public override void InitGridControlDataSource()
        {
            TransferProposalEntities entity = (TransferProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TransferProposalItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(GridView_FocusedColumnChanged);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            GridColumn column = new GridColumn();
            column = gridView.Columns["FK_ICFromStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICToStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICTransferProposalItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICTransferProposalItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemGridLookUpEdit rpProductAttributeWoodTypeID = new RepositoryItemGridLookUpEdit();
                //rpProductAttributeWoodTypeID.DisplayMember = "ICProductAttributeValue";
                //rpProductAttributeWoodTypeID.ValueMember = "ICProductAttributeID";
                //rpProductAttributeWoodTypeID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //rpProductAttributeWoodTypeID.PopupFilterMode = PopupFilterMode.Contains;
                //rpProductAttributeWoodTypeID.NullText = string.Empty;
                //rpProductAttributeWoodTypeID.DataSource = ((TransferProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                //rpProductAttributeWoodTypeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpProductAttributeWoodTypeID_QueryPopUp);
                //column.ColumnEdit = rpProductAttributeWoodTypeID;
            }

            column = gridView.Columns["FK_ICProductAttributeColorID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemGridLookUpEdit rpProductAttributeColorID = new RepositoryItemGridLookUpEdit();
                //rpProductAttributeColorID.DisplayMember = "ICProductAttributeValue";
                //rpProductAttributeColorID.ValueMember = "ICProductAttributeID";
                //rpProductAttributeColorID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //rpProductAttributeColorID.PopupFilterMode = PopupFilterMode.Contains;
                //rpProductAttributeColorID.NullText = string.Empty;
                //rpProductAttributeColorID.DataSource = ((TransferProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                //rpProductAttributeColorID.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpProductAttributeColorID_QueryPopUp);
                //column.ColumnEdit = rpProductAttributeColorID;
            }

            column = gridView.Columns["ICTransferProposalItemProductColorAttribute"];
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

            column = gridView.Columns["ICTransferProposalItemProductWoodAttribute"];
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

            column = gridView.Columns["ICTransferProposalItemProductHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICTransferProposalItemProductLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICTransferProposalItemProductWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICTransferProposalItemValidDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((TransferProposalModule)Screen.Module).DeleteItemFromProposalItemList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeColorID" || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int attributeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(attributeID);
                    if (objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "ICTransferProposalItemProductColorAttribute" || e.Column.FieldName == "ICTransferProposalItemProductWoodAttribute")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((TransferProposalModule)Screen.Module).GetAttributeText(e.Value.ToString());
                }
                else
                    e.DisplayText = string.Empty;
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            TransferProposalEntities entity = (TransferProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;
            if (entity.TransferProposalItemList.CurrentIndex < 0)
                return;

            if (gridView.FocusedRowHandle < 0)
                return;

            ICTransferProposalItemsInfo objTransferProposalItemsInfo = (ICTransferProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Column.FieldName == "FK_ICFromStockID")
            {
                ((TransferProposalModule)Screen.Module).InvalidateItemSerieNo(objTransferProposalItemsInfo);
                gridView.RefreshData();
            }

            if (e.Column.FieldName.Contains("ProductSerialNo"))
            {
                ((TransferProposalModule)Screen.Module).CheckValidateSerieNo(objTransferProposalItemsInfo);
            }
        }

        private void rpProductAttributeWoodTypeID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                lookUpEdit.Properties.DataSource = ((TransferProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
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
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                lookUpEdit.Properties.DataSource = ((TransferProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
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

        #region OtherColor

        private void rpProductAttributeColorAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICTransferProposalItemsInfo objICTransferProposalItemsInfo = (ICTransferProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((TransferProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                string[] arr = objICTransferProposalItemsInfo.ICTransferProposalItemProductColorAttribute.Split(',');
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
                ICTransferProposalItemsInfo item = (ICTransferProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ICTransferProposalItemProductColorAttribute = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
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

        #region Other Wood

        private void rpProductAttributeWoodTypeAttribute_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICTransferProposalItemsInfo objICTransferProposalItemsInfo = (ICTransferProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
                ProductAttributesList = ((TransferProposalModule)Screen.Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
                string[] arr = objICTransferProposalItemsInfo.ICTransferProposalItemProductWoodAttribute.Split(',');
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

        private void rpProductAttributeWoodTypeAttributeProperties_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICTransferProposalItemsInfo item = (ICTransferProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.ICTransferProposalItemProductWoodAttribute = string.Join(",", ProductAttributesList.Where(o => o.Selected).Select(o => o.ICProductAttributeID.ToString()).ToArray());
                gridView.RefreshData();
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
        #endregion

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

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
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        private void GridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn != null && gridView.FocusedColumn.FieldName.Contains("ProductSerialNo"))
            {
                string serieColumnName = gridView.FocusedColumn.FieldName;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICTransferProposalItemsInfo objTransferProposalItemsInfo = (ICTransferProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ((TransferProposalModule)Screen.Module).InvalidateSerieColumn(gridView.FocusedColumn, objTransferProposalItemsInfo);
                }
                else
                {
                    GridColumn column = gridView.Columns[serieColumnName];
                    if (column != null)
                    {
                        column.ColumnEdit = null;
                    }
                }
            }
        }

    }
}
