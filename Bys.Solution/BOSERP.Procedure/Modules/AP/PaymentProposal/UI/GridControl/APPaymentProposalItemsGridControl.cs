using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.PaymentProposal
{
    public partial class APPaymentProposalItemsGridControl : BOSGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach(GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            GridColumn col = gridView.Columns["APPaymentProposalItemApproveStatus"];
            if (col != null)
            {
                gridView.Columns.Remove(col);
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_APPurchaseOrderID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("APPurchaseOrders", "APPurchaseOrderID", int.Parse(e.Value.ToString()), "APPurchaseOrderNo");
                }
            }
        }
    }
}
