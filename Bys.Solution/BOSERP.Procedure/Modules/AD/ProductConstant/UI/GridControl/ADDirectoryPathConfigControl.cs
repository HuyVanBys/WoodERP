using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class ADDirectoryPathConfigControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DirectoryPathList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
                if (item.FieldName == "ADDirectoryPathConfigAddress"
                    || item.FieldName == "ADDirectoryPathConfigUserName")
                {
                    item.OptionsColumn.AllowEdit = true;
                }
                if (item.FieldName == "ADDirectoryPathConfigPassword")
                {
                    item.OptionsColumn.AllowEdit = true;
                }
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            //gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;            
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ADDirectoryPathConfigPassword")
            {
                e.DisplayText = new string('*', e.DisplayText.Length); ;
            }
        }


        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((ProductConstantModule)Screen.Module).RemoveSelectDirectoryPath();              
            }
        }

        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                //ICModelsInfo objModelsInfo = (ICModelsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                //((ProductConstantModule)Screen.Module).InvalidateModelDetailConfigs(objModelsInfo);
            }
        }
    }
}
