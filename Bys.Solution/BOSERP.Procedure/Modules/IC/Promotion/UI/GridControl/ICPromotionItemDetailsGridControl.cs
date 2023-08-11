using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Promotion
{
    public class ICPromotionItemDetailsGridControl : BOSComponent.BOSGridControl 
    {
        public override void InitGridControlDataSource()
        {
            PromotionEntities entity = (PromotionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICPromotionItemDetailsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            //Set all column is enable
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
            int iPromotionItemID = ((ICPromotionItemsInfo)((BaseModuleERP)Screen.Module).CurrentModuleEntity.ModuleObjects["ICPromotionItems"]).ICPromotionItemID;

            gridView.SetRowCellValue(e.RowHandle, "FK_ICPromotionItemID", iPromotionItemID);
            gridView.SetRowCellValue(e.RowHandle, "ICPromotionItemDetailQty", 1);
            int iProductID = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "FK_ICProductID"));
            if (iProductID > 0)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)new ICProductsController().GetObjectByID(iProductID);
                if (objProductsInfo != null)
                    gridView.SetRowCellValue(e.RowHandle, "ICPromotionItemDetailUnitPrice", objProductsInfo.ICProductPrice02);
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
            if (e.Column.FieldName == "FK_ICProductID")
            {
                int iProductID = Convert.ToInt32(e.Value);
                if (iProductID > 0)
                {
                    ICProductsInfo objProductsInfo = (ICProductsInfo)new ICProductsController().GetObjectByID(iProductID);
                    if (objProductsInfo != null)
                        gridView.SetRowCellValue(e.RowHandle, "ICPromotionItemDetailUnitPrice", objProductsInfo.ICProductPrice02);
                }
            }
        }
    }
}
