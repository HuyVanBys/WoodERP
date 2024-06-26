using BOSCommon;
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
    public partial class LoanReceiptPaymentPlansGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LoanReceiptPaymentPlanList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((LoanReceiptModule)Screen.Module).DeleteItemFromLoanReceiptItemsList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ACLoanReceiptPaymentPlanRootPayment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACLoanReceiptPaymentPlanProfitsPayment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACLoanReceiptPaymentPlanDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACLoanReceiptPaymentPlanEndDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            LoanReceiptEntities entity = (LoanReceiptEntities)((LoanReceiptModule)Screen.Module).CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
            ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)gridView.GetRow(e.RowHandle);
            if (objLoanReceiptPaymentPlansInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ACLoanReceiptPaymentPlanEndDate")
                {
                    if (mainObject.ACLoanReceiptProfitMethod != LoanReceiptProfitMethod.OutstandingDebt.ToString())
                    {
                        ((LoanReceiptModule)Screen.Module).ChangeACLoanReceiptPaymentPlanEndDate(Convert.ToInt32(e.RowHandle));
                    }
                    else
                    {
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay = Convert.ToDecimal((objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate).Days + 1);
                    }
                    return;
                }
                if (gridView.FocusedColumn.FieldName == "ACLoanReceiptPaymentPlanRootPayment")
                {
                    if (mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OriginalPaypal.ToString()
                        || mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OutstandingDebtIncreasing.ToString())
                    {
                        decimal oldvalue = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        ((LoanReceiptModule)Screen.Module).ChangeACLoanReceiptPaymentPlansByRootPayment(oldvalue,
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment, Convert.ToInt32(e.RowHandle));
                        return;
                    }
                }
                if (gridView.FocusedColumn.FieldName == "ACLoanReceiptPaymentPlanProfitsPayment"
                    || gridView.FocusedColumn.FieldName == "ACLoanReceiptPaymentPlanRootPayment")
                {
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment + objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment;
                }
            }
            //(Screen.Module as LoanReceiptModule).UpdatePlant();

        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
            LoanReceiptEntities entity = (LoanReceiptEntities)((LoanReceiptModule)Screen.Module).CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
            GridView gridView = (GridView)sender;
            ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (gridView.FocusedColumn.FieldName == "ACLoanReceiptPaymentPlanRootPayment")
            {
                if (mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OriginalPaypal.ToString())
                {
                    if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment > 0)
                    {
                        e.ErrorText = "Không được thay đổi gốc vốn vì đã có nợ gốc đã trả";
                        e.Valid = false;
                    }
                }
                if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment < 0)
                {
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    e.ErrorText = "Bạn vui lòng nhập gốc vốn lớn hơn 0";
                    e.Valid = false;
                }
            }
        }

        public void FormatNumbering()
        {
            LoanReceiptEntities entiy = (LoanReceiptEntities)(Screen.Module as LoanReceiptModule).CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)(entiy.MainObject);
            if (objLoanReceiptsInfo.FK_GECurrencyID != null && objLoanReceiptsInfo.FK_GECurrencyID != 0 && objLoanReceiptsInfo.FK_GECurrencyID != GECurrencyID.VND)
            {
                GridColumnNumericFormat("n3");
            }
            else
            {
                GridColumnNumericFormat("n0");
            }
        }

        public void GridColumnNumericFormat(string formatString)
        {
            GridView gridView = base.InitializeGridView();
            GridColumn plantOpeningBalanceColumn = gridView.Columns["ACLoanReceiptPaymentPlanOpeningBalance"];
            if (plantOpeningBalanceColumn != null)
            {
                FormatNumbericColumn(plantOpeningBalanceColumn, formatString);
            }

            GridColumn rootPaymentColumn = gridView.Columns["ACLoanReceiptPaymentPlanRootPayment"];
            if (rootPaymentColumn != null)
            {
                FormatNumbericColumn(rootPaymentColumn, formatString);
                rootPaymentColumn.OptionsColumn.AllowEdit = true;
            }

            GridColumn profitPaymentColumn = gridView.Columns["ACLoanReceiptPaymentPlanOpeningBalance"];
            if (profitPaymentColumn != null)
            {
                FormatNumbericColumn(profitPaymentColumn, formatString);
            }

            GridColumn plantPaymentColumn = gridView.Columns["ACLoanReceiptPaymentPlanPayment"];
            if (plantPaymentColumn != null)
            {
                FormatNumbericColumn(plantPaymentColumn, formatString);
            }
            GridColumn actualRootPaymentColumn = gridView.Columns["ACLoanReceiptPaymentPlanActualRootPayment"];
            if (actualRootPaymentColumn != null)
            {
                FormatNumbericColumn(actualRootPaymentColumn, formatString);
            }
            GridColumn actualProfitPaymentColumn = gridView.Columns["ACLoanReceiptPaymentPlanActialProfitsPayment"];
            if (actualProfitPaymentColumn != null)
            {
                FormatNumbericColumn(actualProfitPaymentColumn, formatString);
            }
            GridColumn receiptPaymentPlanProfitPaymentColumn = gridView.Columns["ACLoanReceiptPaymentPlanProfitsPayment"];
            if (receiptPaymentPlanProfitPaymentColumn != null)
            {
                FormatNumbericColumn(receiptPaymentPlanProfitPaymentColumn, formatString);
                receiptPaymentPlanProfitPaymentColumn.OptionsColumn.AllowEdit = true;
            }

            GridColumn paymentPlanDate = gridView.Columns["ACLoanReceiptPaymentPlanDate"];
            if (paymentPlanDate != null)
            {
                paymentPlanDate.OptionsColumn.AllowEdit = true;
            }

            GridColumn paymentPlanEndDate = gridView.Columns["ACLoanReceiptPaymentPlanEndDate"];
            if (paymentPlanDate != null)
            {
                paymentPlanEndDate.OptionsColumn.AllowEdit = true;
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
            //column.OptionsColumn.AllowEdit = true;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
