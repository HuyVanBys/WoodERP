using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class OverallInsideDimensionConfigGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMOverallInsideDimensionConfigsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "FK_ICProductAttributePackingMaterialSpecialityID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                    repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                    ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                    List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialSpeciality.ToString());
                    repositoryItemLookUpEdit.DataSource = list;
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }


            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductConstantModule)Screen.Module).RemoveOveralInsideDimensionConfig();
                }
            }
        }
    }
}
