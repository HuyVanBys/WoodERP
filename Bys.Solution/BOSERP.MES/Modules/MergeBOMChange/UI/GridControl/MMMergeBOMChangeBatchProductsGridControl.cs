using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.MergeBOMChange
{
    public class MMMergeBOMChangeBatchProductsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MergeBOMChangeEntities entity = (MergeBOMChangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BatchProductList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["Approve"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                rep1.NullText = "Duyệt";
                rep1.Click += new EventHandler(rep1_Click);
                column.ColumnEdit = rep1;
            }

            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.OptionsView.ShowAutoFilterRow = false;
            gridView.OptionsView.ShowFooter = false;
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Approve")
            {
                GridView gridView = (GridView)MainView;
                MMMergeBOMChangeBatchProductsInfo bp = (MMMergeBOMChangeBatchProductsInfo)gridView.GetFocusedRow();
                if (bp != null)
                {
                    if (bp.MMMergeBOMChangeBatchProductStatus == Status.Approved.ToString())
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
            else if (e.Column.FieldName == "MMMergeBOMChangeBatchProductApproveDate")
            {
                if (e.Value != null)
                {
                    DateTime approveDate = DateTime.Now;
                    DateTime.TryParse(e.Value.ToString(), out approveDate);
                    if (BOSApp.IsUnChoosenDate(approveDate))
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
        }



        void rep1_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMMergeBOMChangeBatchProductsInfo bp = (MMMergeBOMChangeBatchProductsInfo)gridView.GetFocusedRow();
            if (bp != null)
            {
                ((MergeBOMChangeModule)Screen.Module).ApproveBPChange(bp);
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((MergeBOMChangeModule)Screen.Module).RemoveBatchProduct();
            }
        }

    }
}
