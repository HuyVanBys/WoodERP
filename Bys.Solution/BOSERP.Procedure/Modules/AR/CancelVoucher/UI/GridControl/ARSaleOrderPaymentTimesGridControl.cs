using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace BOSERP.Modules.CancelVoucher
{
    public class ARSaleOrderPaymentTimesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleOrderPaymentTimesList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
                if (column.FieldName == "ARSaleOrderPaymentTimeAmount")
                {
                    RepositoryItemCalcEdit repositoryItemCalcEdit = new RepositoryItemCalcEdit();
                    repositoryItemCalcEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    repositoryItemCalcEdit.NullText = "0";
                    repositoryItemCalcEdit.Mask.EditMask = "n2";
                    repositoryItemCalcEdit.Mask.UseMaskAsDisplayFormat = true;
                    column.ColumnEdit = repositoryItemCalcEdit;
                }
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARCustomerPaymentID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ARCustomerPayments", "ARCustomerPaymentID", int.Parse(e.Value.ToString()), "ARCustomerPaymentNo");
                }
            }
            else if (e.Column.FieldName == "FK_GEPaymentTermID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("GEPaymentTerms", "GEPaymentTermID", int.Parse(e.Value.ToString()), "GEPaymentTermName");
                }
            }
        }
    }
}