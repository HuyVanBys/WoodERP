using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AR.SaleCost.Localization;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleCost
{
    public partial class ARFeePaymentCommissionsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleCostEntities entity = (SaleCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentCommissionList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleCostModule)Screen.Module).RemoveSelectedPaymentCommission();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "ARFeePaymentCommissionAmount")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = SaleCostLocalizedResources.FK_GECurrencyID;
            column.FieldName = "FK_GECurrencyID";
            column.OptionsColumn.AllowEdit = false;
            RepositoryItemLookUpEdit rpCurrency = new RepositoryItemLookUpEdit();
            rpCurrency.DisplayMember = "GECurrencyName";
            rpCurrency.ValueMember = "GECurrencyID";
            rpCurrency.NullText = string.Empty;
            DataSet ds = BOSApp.LookupTables[TableName.GECurrenyTableName] as DataSet;
            if (ds == null)
            {
                //BOSApp.RefreshChangeLookupData();
                if (!BOSApp.LookupTables.ContainsKey(TableName.GECurrenyTableName))
                {
                    ds = BOSApp.GetLookupTableData(TableName.GECurrenyTableName);
                    GELookupTablesInfo lookupTable = LookupTableList.Where(t => t.GELookupTableName == TableName.GECurrenyTableName).FirstOrDefault();

                    if (lookupTable != null)
                    {
                        LookupTables.Add(TableName.GECurrenyTableName, ds);
                        LookupTablesUpdatedDate.Add(TableName.GECurrenyTableName, BOSApp.MainScreen.ServerDate.AddSeconds(BOSApp.MainScreen.tickTimer));
                        LookupTableObjects.Add(TableName.GECurrenyTableName, lookupTable);
                    }
                }
                ds = BOSApp.LookupTables[TableName.GECurrenyTableName] as DataSet;
            }
            if (ds != null)
            {
                rpCurrency.DataSource = ds.Tables[0];
            }
            column.ColumnEdit = rpCurrency;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleCostLocalizedResources.CommissionName;
            column.FieldName = "ACObjectAccessKey";
            column.OptionsColumn.AllowEdit = false;
            ACObjectsController objObjectsController = new ACObjectsController();
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
            repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                SaleCostEntities entity = (SaleCostEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARFeePaymentCommissionsInfo item = (ARFeePaymentCommissionsInfo)gridView.GetRow(e.RowHandle);
                if (item != null)
                {
                    if (e.Column.FieldName == "ARFeePaymentCommissionAmount")
                    {
                        decimal commissionTotalAmount = item.ARFeePaymentCommissionInvoiceTotalAmount * item.ARFeePaymentCommissionValue / 100;
                        if (item.ARFeePaymentCommissionAmount > commissionTotalAmount)
                        {
                            MessageBox.Show(string.Format(SaleCostLocalizedResources.CommissionAmount, commissionTotalAmount.ToString("n2")),
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            item.ARFeePaymentCommissionAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                        ((SaleCostModule)Screen.Module).UpdateTotalAmount();
                    }

                }
            }
        }
    }
}
