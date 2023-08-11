using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.Acceptance
{
    public partial class AcceptanceItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            AcceptanceEntities entity = (AcceptanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AcceptanceItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
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

        private void RepoItemBtnEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ((AcceptanceModule)Screen.Module).ShowTemplateItemTree();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            if (gridView.Columns["ARAcceptanceItemProductQty"] != null)
                gridView.Columns["ARAcceptanceItemProductQty"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARAcceptanceItemDesc"] != null)
                gridView.Columns["ARAcceptanceItemDesc"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARAcceptanceItemLength"] != null)
                gridView.Columns["ARAcceptanceItemLength"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARAcceptanceItemWidth"] != null)
                gridView.Columns["ARAcceptanceItemWidth"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARAcceptanceItemHeight"] != null)
                gridView.Columns["ARAcceptanceItemHeight"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARAcceptanceItemProductUnitPrice"] != null)
                gridView.Columns["ARAcceptanceItemProductUnitPrice"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARAcceptanceItemOneLevelArea"] != null)
                gridView.Columns["ARAcceptanceItemOneLevelArea"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARAcceptanceItemTwoLevelArea"] != null)
                gridView.Columns["ARAcceptanceItemTwoLevelArea"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARAcceptanceItemThreeLevelArea"] != null)
                gridView.Columns["ARAcceptanceItemThreeLevelArea"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["FK_ACCostCenterID"] != null)
            {
                GridColumn column = gridView.Columns["FK_ACCostCenterID"];
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = GetAllCostCenter();
                repositoryItemLookUpEdit.ValueMember = "ACCostCenterID";
                repositoryItemLookUpEdit.DisplayMember = "ACCostCenterName";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostCenterName", "TT Chi phí"));
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpCostCenter_QueryPopUp);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
            }

            if (gridView.Columns["FK_ICSectionProductID"] != null)
            {
                GridColumn column = gridView.Columns["FK_ICSectionProductID"];
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

            return gridView;
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ARAcceptanceItemProductQty")
            {
                if (e.Value != null)
                {
                    ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);

                    decimal qty = Convert.ToDecimal(e.Value);
                    if (objAcceptanceItemsInfo.ARAcceptanceItemID > 0)
                        return;
                    if (objAcceptanceItemsInfo.FK_ICShipmentItemID > 0)
                        return;
                    if (qty > objAcceptanceItemsInfo.ARAcceptanceItemRemainedQty)
                    {
                        e.ErrorText = AcceptanceLocalizedResources.ErrorQty;
                        e.Valid = false;
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AcceptanceModule)Screen.Module).DeleteItemFromAcceptanceItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            AcceptanceEntities entity = (AcceptanceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.AcceptanceItemsList.CurrentIndex >= 0)
            {
                if (e.Column.FieldName == "ARAcceptanceItemProductQty"
                    || e.Column.FieldName == "ARAcceptanceItemProductUnitPrice")
                {
                    ((AcceptanceModule)Screen.Module).ChangeItemQty();
                }

                if (e.Column.FieldName == "ARAcceptanceItemLength"
                    || e.Column.FieldName == "ARAcceptanceItemWidth"
                    || e.Column.FieldName == "ARAcceptanceItemHeight")
                {
                    ((AcceptanceModule)Screen.Module).ChangeItemProductSize();
                }

            }
        }

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
                    lookUpEdit.Properties.DataSource = ((AcceptanceModule)Screen.Module).GetAllSectionProductForLookUp();
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

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACCostCenterID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ACCostCentersController objCostCentersController = new ACCostCentersController();
                    ACCostCentersInfo objCostCentersInfo = (ACCostCentersInfo)objCostCentersController.GetObjectByID(matchCodeID);
                    if (objCostCentersInfo != null)
                        e.DisplayText = objCostCentersInfo.ACCostCenterName;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (gridview.FocusedRowHandle >= 0)
            {
                AcceptanceEntities entity = (AcceptanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ARAcceptanceItemsInfo item = (ARAcceptanceItemsInfo)gridview.GetRow(gridview.FocusedRowHandle);

                if (item.ARAcceptanceItemColumnChangedNames.Contains(e.Column.FieldName))
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.Salmon);
                }
            }
        }
    }
}
