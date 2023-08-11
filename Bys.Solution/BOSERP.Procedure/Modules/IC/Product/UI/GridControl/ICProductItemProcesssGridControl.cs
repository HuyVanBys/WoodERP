using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ICProductItemProcesssGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PIProcessList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).DeleteItemFromProductItemProcesssList();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            //gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn col = gridview.Columns["ICProductItemProcessPeriod"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }

            //foreach (GridColumn col in gridview.Columns)
            //{
            //    col.OptionsColumn.AllowEdit = true;

            //}

            return gridview;
        }

        //void gridview_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        //{
        //    if (e.Value != null)
        //    {
        //        if (e.Column.FieldName == "FK_ICProductMaterialID")
        //        {
        //            int id = 0;
        //            int.TryParse(e.Value.ToString(), out id);
        //            ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == id);
        //            if (iProduct != null)
        //            {
        //                e.DisplayText = iProduct.ICProductName;
        //            }
        //            else
        //            {
        //                e.DisplayText = string.Empty;
        //            }
        //        }
        //    }
        //}


        //void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    lookUpEdit.Properties.DataSource = objProductsInfoList;
        //}


        //protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    base.GridView_CellValueChanged(sender, e);

        //    GridView view = (GridView )this.MainView;
        //    if(view!=null)
        //    {
        //        ICProductItemProcesssInfo item = (ICProductItemProcesssInfo)view.GetFocusedRow();
        //        if (item != null)
        //        {
        //            if (e.Column.FieldName == "FK_ICProductMaterialID")
        //            {
        //                ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductMaterialID);
        //                if (iProduct != null)
        //                {
        //                    item.ICProductItemMaterialHeigth = iProduct.ICProductHeight;
        //                }
        //            }

        //            if (e.Column.FieldName == "FK_ICProductMaterialID"
        //                || e.Column.FieldName == "ICProductItemMaterialLength"
        //                || e.Column.FieldName == "ICProductItemMaterialWidth"
        //                || e.Column.FieldName == "ICProductItemMaterialHeigth"
        //                || e.Column.FieldName == "ICProductItemMaterialWoodQty")
        //            {
        //                item.ICProductItemMaterialQty = (item.ICProductItemMaterialHeigth
        //                                                * item.ICProductItemMaterialLength
        //                                                * item.ICProductItemMaterialWidth) 
        //                                                * item.ICProductItemMaterialWoodQty / 1000000000;
        //            }

        //            this.RefreshDataSource();
        //        }

        //    }


        //}

    }
}
