using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class APRP031ProposalItemsGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                column.Group();
            }

            column = gridView.Columns["APPurchaseProposalItemType"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.PurchaseProposalType]);
                column.ColumnEdit = rep;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APProposalItemProductQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
            }
            column = gridView.Columns["APSupplierName"];
            if (column != null)
            {
                column.Caption = ReportLocalizedResources.ACObjectName;
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.APProposalNo;
            column.FieldName = "APProposalNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APProposalDate;
            column.FieldName = "APProposalDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
