using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public class ARInvoiceCommissionsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InvoiceEntities entity = (InvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceCommissionsList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InvoiceModule)Screen.Module).DeleteItemFromSaleCommissions();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);

            GridColumn column1 = gridView.Columns["ARInvoiceCommissionPercent"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            InvoiceEntities entity = (InvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.InvoiceCommissionsList.CurrentIndex >= 0)
            {
                ARInvoiceCommissionsInfo item = entity.InvoiceCommissionsList[entity.InvoiceCommissionsList.CurrentIndex];

                if (e.Column.FieldName == "ARInvoiceCommissionPercent")
                {
                    ((InvoiceModule)Screen.Module).ChangeItemCommissionPercent(item);
                }
            }
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            InvoiceEntities entity = (InvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            ARInvoiceCommissionsInfo item = entity.InvoiceCommissionsList[entity.InvoiceCommissionsList.CurrentIndex];

            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ARInvoiceCommissionPercent")
                {
                    decimal commissionPercent = Convert.ToDecimal(e.Value);
                    decimal sumTotalCommission = entity.InvoiceCommissionsList
                        .Where(p => string.Format("{0};{1}", p.FK_ACObjectID, p.ARObjectType) != string.Format("{0};{1}", item.FK_ACObjectID, item.ARObjectType))
                        .Sum(o => o.ARInvoiceCommissionAmount)
                        + mainObject.ARInvoiceCommissionAmount * commissionPercent / 100;
                    if (sumTotalCommission > mainObject.ARInvoiceCommissionAmount)
                    {
                        e.ErrorText = SaleOrderLocalizedResources.CommissionTotalAmountInvalid;
                        e.Valid = false;
                    }
                }
            }
        }
    }
}
