using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class MMExecuteTimeConfigGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ConfigExecuteTimeList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }

        protected override void RepositoryItemLookupEdit_QueryPopup(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            string a = this.GetFieldColumnInLookupEditCtrl(lke);
            if (a == "FK_ICMeasureUnitID")
            {
                ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                List<ICMeasureUnitsInfo> list = new List<ICMeasureUnitsInfo>();
                ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
                list.Add(objMeasureUnitsInfo);
                List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetM3AndSLInMeasureUnit();
                if (measureUnitList != null && measureUnitList.Count > 0)
                    list.AddRange(measureUnitList);
                lke.Properties.DataSource = list;
            }
            else if (a == "FK_ICProductID")
            {
                ICProductsController objProductsController = new ICProductsController();
                List<ICProductsInfo> list = new List<ICProductsInfo>();
                ICProductsInfo info = new ICProductsInfo();
                list.Add(info);
                List<ICProductsInfo> productList = objProductsController.GetLookupEditProductByProductType(ProductType.Product.ToString());
                if (productList != null && productList.Count > 0)
                    list.AddRange(productList);
                lke.Properties.DataSource = list;
            }
            else
                base.RepositoryItemLookupEdit_QueryPopup(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedConfigExecuteTimeList();
            }
        }

        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            //GridView gridView = (GridView)sender;
            //if (gridView.FocusedRowHandle >= 0)
            //{
            //    ICModelsInfo objModelsInfo = (ICModelsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            //    ((ProductConstantModule)Screen.Module).InvalidateModelDetailConfigs(objModelsInfo);
            //}
        }
    }
}
