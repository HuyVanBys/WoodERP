using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICCommodityProductTypeMappingGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CommodityProductTypeMappingList;
            this.DataSource = bds;

        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ICCommodityType";
            column.Caption = "Loại hàng hoá";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.PurchaseOrderReceiptType + "Search"]);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn columnEdit in gridView.Columns)
            {
                columnEdit.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }

        //protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        //{

        //    e.ExceptionMode = ExceptionMode.DisplayError;

        //}

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedCommodityProductTypeMapping();
            }
        }


    }
}
