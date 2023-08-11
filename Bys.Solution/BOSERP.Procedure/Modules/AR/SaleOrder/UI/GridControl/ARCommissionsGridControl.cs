using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARCommissionsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleCommissionsList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteItemFromSaleCommissions();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);

            GridColumn column1 = gridView.Columns["ARCommissionPercent"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }
            column1 = gridView.Columns["ARCommissionType"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }
            column1 = gridView.Columns["ARCommissionDesc"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.SaleCommissionsList.CurrentIndex >= 0)
            {
                ARCommissionsInfo item = entity.SaleCommissionsList[entity.SaleCommissionsList.CurrentIndex];

                if (e.Column.FieldName == "ARCommissionPercent")
                {
                    ((SaleOrderModule)Screen.Module).ChangeItemCommissionPercent(item);
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
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)entity.MainObject;
            ARCommissionsInfo item = entity.SaleCommissionsList[entity.SaleCommissionsList.CurrentIndex];

            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ARCommissionPercent")
                {
                    decimal commissionPercent = Convert.ToDecimal(e.Value);
                    decimal sumTotalCommission = entity.SaleCommissionsList
                        .Where(p => string.Format("{0};{1}", p.FK_ACObjectID, p.ARObjectType) != string.Format("{0};{1}", item.FK_ACObjectID, item.ARObjectType))
                        .Sum(o => o.ARCommissionAmount)
                        + mainObject.ARSaleOrderSOCommissionAmount * commissionPercent / 100;
                    if (sumTotalCommission > mainObject.ARSaleOrderSOCommissionAmount)
                    {
                        e.ErrorText = SaleOrderLocalizedResources.CommissionTotalAmountInvalid;
                        e.Valid = false;
                    }
                }
            }
        }
    }
}
