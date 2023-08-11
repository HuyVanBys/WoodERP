using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
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

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class APProposalItemsGridControl : BOSGridControl
    {
        private List<MMOperationsInfo> OperationDataSource = new List<MMOperationsInfo>();

        public void InvalidateDataSource(List<APProposalItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();

            MMOperationsController objOperationsController = new MMOperationsController();
            DataSet ds = BOSApp.LookupTables[TableName.MMOperationsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.MMOperationsTableName);
            }
            OperationDataSource = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PurchaseOrderLocalizedResources.APProposalNo;
            column.FieldName = "APProposalNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Loại hàng hóa";
            column.FieldName = "APProposalAPTypeCombo";
            RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables["ProposalAPType"]);
            column.ColumnEdit = rep;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Người mua hàng";
            column.FieldName = "FK_APPurchasingStaffID";
            rep = new RepositoryItemLookUpEdit();
            rep.DataSource = (new HREmployeesController()).GetAllEmployees() as List<HREmployeesInfo>;
            rep.ValueMember = "HREmployeeID";
            rep.DisplayMember = "HREmployeeName";
            rep.NullText = "";
            column.ColumnEdit = rep;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "MMBatchProductSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["APPurchaseProposalItemType"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.PurchaseProposalType + "Search"]);
                column.ColumnEdit = rep;
                column.Group();
            }
            column = gridView.Columns["APProposalItemOperation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemCheckedComboBoxEdit operationRepositoryItem = new RepositoryItemCheckedComboBoxEdit();
                operationRepositoryItem.DisplayMember = "MMOperationName";
                operationRepositoryItem.ValueMember = "MMOperationID";
                operationRepositoryItem.NullText = string.Empty;
                operationRepositoryItem.DataSource = OperationDataSource;
                column.ColumnEdit = operationRepositoryItem;
            }
            column = gridView.Columns["APProposalNo"];
            if (column != null)
            {
                column.Group();
            }
            if (column.FieldName == "FK_GECountryID")
            {
                column.OptionsColumn.AllowEdit = false;
            }
            gridView.EndGrouping += GridView_EndGrouping;
            return gridView;
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName == "APProposalItemOperation")
            {
                if (e.Value != null)
                {
                    e.DisplayText = GetOperationDisplayText(e.Value.ToString());
                }
            }
        }

        private string GetOperationDisplayText(string operationRef)
        {
            if (string.IsNullOrWhiteSpace(operationRef))
                return string.Empty;

            List<int> operation = operationRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            return string.Join(", ", OperationDataSource.Where(o => operation.Contains(o.MMOperationID)).Select(o => o.MMOperationName).ToArray());
        }

        private void GridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            gridView.ExpandAllGroups();
        }
    }
}
