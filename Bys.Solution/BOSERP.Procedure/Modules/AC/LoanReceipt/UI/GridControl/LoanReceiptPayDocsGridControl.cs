using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.LoanReceipt
{
    public partial class LoanReceiptPayDocsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LoanReceiptPayDocList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((LoanReceiptModule)Screen.Module).DeleteItemFromLoanReceiptPayDocsList();
            }
        }
        public void FormatNumering()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)((Screen.Module as LoanReceiptModule).CurrentModuleEntity);
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            if (objLoanReceiptsInfo.FK_GECurrencyID != null && objLoanReceiptsInfo.FK_GECurrencyID != 0 && objLoanReceiptsInfo.FK_GECurrencyID != 100000)
            {
                GridColumnNumericFormat("n2");
            }
            else
            {
                GridColumnNumericFormat("n0");
            }

        }
        public void GridColumnNumericFormat(string formatString)
        {
            GridView gridView = base.InitializeGridView();
            GridColumn docTotalColumn = gridView.Columns["ACLoanReceiptPayDocTotalAmount"];
            if (docTotalColumn != null)
            {
                FormatNumbericColumn(docTotalColumn, formatString);
            }

            GridColumn rootPaidColumn = gridView.Columns["ACLoanReceiptPayDocsDebtRootPaid"];
            if (rootPaidColumn != null)
            {
                FormatNumbericColumn(rootPaidColumn, formatString);
            }
            GridColumn interestPaidColumn = gridView.Columns["ACLoanReceiptPayDocsInterestPaid"];
            if (interestPaidColumn != null)
            {
                FormatNumbericColumn(interestPaidColumn, formatString);
            }
            GridColumn penaltyPaid = gridView.Columns["ACLoanReceiptPayDocsPenaltyPaid"];
            if (penaltyPaid != null)
            {
                FormatNumbericColumn(penaltyPaid, formatString);
            }
        }
        private void FormatNumbericColumn(GridColumn column, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = "{0:" + formatType + "}";
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Screen.Module).ShowLoanReceiptPayDocReffModule();
        }
    }
}
