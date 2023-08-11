using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ACDocumentType
{
    public class ACDocumentTypesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACDocumentTypeList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ACDocumentTypeDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            GridView gridView = (GridView)sender;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = new ACDocumentTypesInfo();
            objDocumentTypesInfo = (ACDocumentTypesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objDocumentTypesInfo != null)
                ((ACDocumentTypeModule)Screen.Module).DocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
        }
    }
}
