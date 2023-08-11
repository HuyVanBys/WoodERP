using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelVoucher
{
    public class ARCancelVoucherItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CancelVoucherItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            if (gridView.Columns["ARCancelVoucherItemProductQty"] != null)
                gridView.Columns["ARCancelVoucherItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARCancelVoucherItemProductUnitPrice"] != null)
                gridView.Columns["ARCancelVoucherItemProductUnitPrice"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARCancelVoucherItemProductDiscount"] != null)
                gridView.Columns["ARCancelVoucherItemProductDiscount"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["ARCancelVoucherItemDiscountAmount"] != null)
                gridView.Columns["ARCancelVoucherItemDiscountAmount"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARCancelVoucherItemProductTaxPercent"] != null)
                gridView.Columns["ARCancelVoucherItemProductTaxPercent"].OptionsColumn.AllowEdit = false;

            GridColumn column = gridView.Columns["ARCancelVoucherItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_ICDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit departmentLookUpEdit = new RepositoryItemLookUpEdit();
                departmentLookUpEdit.DisplayMember = "ICDepartmentName";
                departmentLookUpEdit.ValueMember = "ICDepartmentID";
                departmentLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                departmentLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                departmentLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ICDepartmentsTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ICDepartmentsTableName);
                    BOSApp.LookupTables[TableName.ICDepartmentsTableName] = ds;
                }
                departmentLookUpEdit.DataSource = ds.Tables[0];
                column.ColumnEdit = departmentLookUpEdit;
            }

            column = gridView.Columns["FK_ICProductGroupID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit productGroupLookUpEdit = new RepositoryItemLookUpEdit();
                productGroupLookUpEdit.DisplayMember = "ICProductGroupName";
                productGroupLookUpEdit.ValueMember = "ICProductGroupID";
                productGroupLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                productGroupLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                productGroupLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ICProductGroupsTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ICProductGroupsTableName);
                    BOSApp.LookupTables[TableName.ICProductGroupsTableName] = ds;
                }
                productGroupLookUpEdit.DataSource = ds.Tables[0];
                column.ColumnEdit = productGroupLookUpEdit;
            }

            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit productLookUpEdit = new RepositoryItemLookUpEdit();
                productLookUpEdit.DisplayMember = "ICProductNo";
                productLookUpEdit.ValueMember = "ICProductID";
                productLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                productLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                productLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ICProductsTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ICProductsTableName);
                    BOSApp.LookupTables[TableName.ICProductsTableName] = ds;
                }
                productLookUpEdit.DataSource = ds.Tables[0];
                column.ColumnEdit = productLookUpEdit;
            }

            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit measureUnitLookUpEdit = new RepositoryItemLookUpEdit();
                measureUnitLookUpEdit.DisplayMember = "ICMeasureUnitName";
                measureUnitLookUpEdit.ValueMember = "ICMeasureUnitID";
                measureUnitLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                measureUnitLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                measureUnitLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ICMeasureUnitsTableName);
                    BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] = ds;
                }
                measureUnitLookUpEdit.DataSource = ds.Tables[0];
                column.ColumnEdit = measureUnitLookUpEdit;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            CancelVoucherEntities entity = (CancelVoucherEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.CancelVoucherItemList.CurrentIndex >= 0)
            {
                GridView gridView = sender as GridView;
                bool isValid = true;
                if (e.Column.FieldName == "ARCancelVoucherItemProductQty")
                {
                    isValid = (entity.Module as CancelVoucherModule).CheckValidQty(entity.CancelVoucherItemList.CurrentIndex, decimal.Parse(e.Value.ToString()));
                    if (!isValid)
                    {
                        entity.CancelVoucherItemList[entity.CancelVoucherItemList.CurrentIndex].ARCancelVoucherItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }

                if (isValid)
                {
                    entity.ModuleObjects[TableName.ARCancelVoucherItemsTableName] = (ARCancelVoucherItemsInfo)entity.CancelVoucherItemList[entity.CancelVoucherItemList.CurrentIndex];
                    (entity.Module as CancelVoucherModule).ChangeItemFromCancelVoucherItemList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CancelVoucherModule)Screen.Module).DeleteItemFromCancelVoucherItemList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "ARCancelVoucherItemProductQty")
                {
                    if (!((CancelVoucherModule)Screen.Module).IsValidCanceledQty(Convert.ToDecimal(e.Value)))
                    {
                        e.ErrorText = CancelVoucherLocalizedResources.CanceledQtyCannotBeGreaterThanOrderedQty;
                        e.Valid = false;
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

        public void LoadGridViewByProductType(int iObjectID)
        {
            GridView gridView = (GridView)MainView;
            ARCancelVouchersController objCancelVouchersController = new ARCancelVouchersController();
            CancelVoucherEntities entity = (CancelVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)entity.MainObject;

            if (iObjectID > 0)
                mainObject = (ARCancelVouchersInfo)objCancelVouchersController.GetObjectByID(iObjectID);
            string productType = mainObject.ARCancelVoucherType;

            if (productType == CancelVoucherType.Roundwood.ToString() || productType == CancelVoucherType.FreshLumber.ToString()
                        || productType == CancelVoucherType.ArtificialBoard.ToString() || productType == CancelVoucherType.Verneer.ToString() || productType == CancelVoucherType.DryLumber.ToString())
            {
                GridColumn column = gridView.Columns["ARCancelVoucherItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng hủy";
                    SetColumnFormat(column, "n5");
                }
                column = gridView.Columns["ARCancelVoucherItemOrderedQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng đặt";
                    SetColumnFormat(column, "n5");
                }
                column = gridView.Columns["ARCancelVoucherItemTotalQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng đã hủy";
                    SetColumnFormat(column, "n5");
                }
            }
            else
            {
                GridColumn column = gridView.Columns["ARCancelVoucherItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng hủy";
                    SetColumnFormat(column, "n3");
                }
                column = gridView.Columns["ARCancelVoucherItemOrderedQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng đặt";
                    SetColumnFormat(column, "n3");
                }
                column = gridView.Columns["ARCancelVoucherItemTotalQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng đã hủy";
                    SetColumnFormat(column, "n3");
                }
            }
            gridView.BestFitColumns();
        }
        public void SetColumnFormat(GridColumn column, string formatType)
        {
            DevExpress.XtraEditors.Repository.RepositoryItem rep = column.ColumnEdit;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText = (DevExpress.XtraEditors.Repository.RepositoryItemTextEdit)rep;

            repText.Mask.EditMask = formatType;
            repText.Mask.UseMaskAsDisplayFormat = true;

            repText.DisplayFormat.FormatString = formatType;
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            CancelVoucherEntities entity = (CancelVoucherEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.CancelVoucherItemList.CurrentIndex >= 0)
            {
                ((CancelVoucherModule)Screen.Module).InitProductPictureImage(entity.CancelVoucherItemList[entity.CancelVoucherItemList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}
