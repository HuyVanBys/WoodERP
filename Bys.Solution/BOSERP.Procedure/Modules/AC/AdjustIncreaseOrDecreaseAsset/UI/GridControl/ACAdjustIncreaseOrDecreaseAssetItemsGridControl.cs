using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.AdjustIncreaseOrDecreaseAsset
{
    public partial class ACAdjustIncreaseOrDecreaseAssetItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdjustIncreaseOrDecreaseAssetEntities entity = (AdjustIncreaseOrDecreaseAssetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AdjustIncreaseOrDecreaseAssetItemsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemBeginDate"] != null)
                gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemBeginDate"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemAmount"] != null)
                gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemTaxPercent"] != null)
                gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemTaxPercent"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemRemainDepreciation"] != null)
                gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemRemainDepreciation"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemTaxAmount"] != null)
                gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemTaxAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemDesc"] != null)
                gridView.Columns["ACAdjustIncreaseOrDecreaseAssetItemDesc"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACInvoiceInSupplierNo"] != null)
                gridView.Columns["ACInvoiceInSupplierNo"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACInvoiceInVATSymbol"] != null)
                gridView.Columns["ACInvoiceInVATSymbol"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ACInvoiceInVATDate"] != null)
                gridView.Columns["ACInvoiceInVATDate"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ACInputVATDocumentType"];
            if (column != null)
            {
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = GetListFromDataSet(objConfigValuesController.GetADConfigValuesByGroup("InputVATDocumentType"));
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigValueID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại hóa đơn"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditVATDocumentType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["ACInputVATStatus"];
            if (column != null)
            {
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = GetListFromDataSet(objConfigValuesController.GetADConfigValuesByGroup("InputVATStatus"));
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigValueID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại hóa đơn"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditVATDocumentStatus_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            return gridView;
        }

        public void repositoryItemLookUpEditVATDocumentType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValueList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("InputVATDocumentType");
            configValueList = GetListFromDataSet(ds);
            if (ds != null)
            {
                configValueList.Insert(0, objConfigValuesInfo);
                lookUpEdit.Properties.DataSource = configValueList;
            }
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigValueID";
        }

        public void repositoryItemLookUpEditVATDocumentStatus_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValueList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("InputVATStatus");
            configValueList = GetListFromDataSet(ds);
            if (ds != null)
            {
                configValueList.Insert(0, objConfigValuesInfo);
                lookUpEdit.Properties.DataSource = configValueList;
            }
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigValueID";
        }

        public List<ADConfigValuesInfo> GetListFromDataSet(DataSet ds)
        {
            List<ADConfigValuesInfo> configValue = new List<ADConfigValuesInfo>();
            if (ds.Tables.Count > 0)
            {
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    configValue.Add(objConfigValuesInfo);
                }
            }
            return configValue;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AdjustIncreaseOrDecreaseAssetEntities entity = (AdjustIncreaseOrDecreaseAssetEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ACAdjustIncreaseOrDecreaseAssetsInfo mainObject = (ACAdjustIncreaseOrDecreaseAssetsInfo)entity.MainObject;
            if (entity.AdjustIncreaseOrDecreaseAssetItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.ACAdjustIncreaseOrDecreaseAssetItemsTableName] = (ACAdjustIncreaseOrDecreaseAssetItemsInfo)entity.AdjustIncreaseOrDecreaseAssetItemsList[entity.AdjustIncreaseOrDecreaseAssetItemsList.CurrentIndex];
                if (gridView.FocusedRowHandle >= 0)
                {
                    ACAdjustIncreaseOrDecreaseAssetItemsInfo items = (ACAdjustIncreaseOrDecreaseAssetItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (e.Column.FieldName == "ACAdjustIncreaseOrDecreaseAssetItemTaxPercent")
                    {
                        items.ACAdjustIncreaseOrDecreaseAssetItemTaxAmount = items.ACAdjustIncreaseOrDecreaseAssetItemTaxPercent * items.ACAdjustIncreaseOrDecreaseAssetItemAmount / 100;
                        items.ACAdjustIncreaseOrDecreaseAssetItemTotalAmount = (items.ACAdjustIncreaseOrDecreaseAssetItemTaxAmount + items.ACAdjustIncreaseOrDecreaseAssetItemAmount) * mainObject.ACAdjustIncreaseOrDecreaseAssetExchangeRate;
                        ((AdjustIncreaseOrDecreaseAssetModule)Screen.Module).UpdateDocumentEntriesCost();
                    }
                    if (e.Column.FieldName == "ACAdjustIncreaseOrDecreaseAssetItemTaxAmount")
                    {
                        items.ACAdjustIncreaseOrDecreaseAssetItemTaxPercent = items.ACAdjustIncreaseOrDecreaseAssetItemTaxAmount / items.ACAdjustIncreaseOrDecreaseAssetItemAmount * 100;
                        items.ACAdjustIncreaseOrDecreaseAssetItemTotalAmount = (items.ACAdjustIncreaseOrDecreaseAssetItemTaxAmount + items.ACAdjustIncreaseOrDecreaseAssetItemAmount) * mainObject.ACAdjustIncreaseOrDecreaseAssetExchangeRate;
                        ((AdjustIncreaseOrDecreaseAssetModule)Screen.Module).UpdateDocumentEntriesCost();
                    }
                    if (e.Column.FieldName == "ACAdjustIncreaseOrDecreaseAssetItemAmount")
                    {
                        items.ACAdjustIncreaseOrDecreaseAssetItemTaxAmount = items.ACAdjustIncreaseOrDecreaseAssetItemTaxPercent * items.ACAdjustIncreaseOrDecreaseAssetItemAmount / 100;
                        items.ACAdjustIncreaseOrDecreaseAssetItemTotalAmount = (items.ACAdjustIncreaseOrDecreaseAssetItemTaxAmount + items.ACAdjustIncreaseOrDecreaseAssetItemAmount) * mainObject.ACAdjustIncreaseOrDecreaseAssetExchangeRate;
                        ((AdjustIncreaseOrDecreaseAssetModule)Screen.Module).UpdateDocumentEntriesCost();
                    }
                }
                entity.AdjustIncreaseOrDecreaseAssetItemsList.GridControl.RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AdjustIncreaseOrDecreaseAssetModule)Screen.Module).DeleteItemFromAIODAItemsList();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            AdjustIncreaseOrDecreaseAssetEntities entity = (AdjustIncreaseOrDecreaseAssetEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ACAdjustIncreaseOrDecreaseAssetsInfo mainObject = (ACAdjustIncreaseOrDecreaseAssetsInfo)entity.MainObject;
            ACAdjustIncreaseOrDecreaseAssetItemsInfo item = (ACAdjustIncreaseOrDecreaseAssetItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ACAdjustIncreaseOrDecreaseAssetItemTaxPercent")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        if (mainObject.ACAdjustIncreaseOrDecreaseAssetType == AdjustIncreaseOrDecreaseAssetType.Decrease.ToString())
                        {
                            e.ErrorText = "Không cho phép thay đổi % thuế";
                            e.Valid = false;
                        }
                    }
                }
            }
        }
    }
}
