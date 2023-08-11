using BOSCommon.Constants;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.LoanReceipt
{
    public partial class LoanReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LoanReceiptItemList;
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
                ((LoanReceiptModule)Screen.Module).DeleteItemFromLoanReceiptItemsList();
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

        public void FormatNumbering()
        {
            LoanReceiptEntities entiy = (LoanReceiptEntities)(Screen.Module as LoanReceiptModule).CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)(entiy.MainObject);
            if (objLoanReceiptsInfo.FK_GECurrencyID != null && objLoanReceiptsInfo.FK_GECurrencyID != 0 && objLoanReceiptsInfo.FK_GECurrencyID != GECurrencyID.VND)
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
            GridColumn totalAmountColumn = gridView.Columns["ACLoanReceiptItemTotalAmount"];
            if (totalAmountColumn != null)
            {
                FormatNumbericColumn(totalAmountColumn, formatString);
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Screen.Module).ShowLoanReceiptItemReffModule();
        }
    }
}
