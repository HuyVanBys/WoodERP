using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ICProductPackingDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductPackingDetailsList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;



            GridColumn column = gridView.Columns["FK_ICProductAttributeSpecialityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

                //RepositoryItemBOSLookupEdit repositoryItemAttributeLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemAttributeLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemAttributeLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemAttributeLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemAttributeLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemAttributeLookUpEdit.NullText = string.Empty;
                //repositoryItemAttributeLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
                //repositoryItemAttributeLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính thùng"));

                //repositoryItemAttributeLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeLookUpEdit_QueryPopUp1);
                //column.ColumnEdit = repositoryItemAttributeLookUpEdit;

            }
            column = gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        //void repositoryItemAttributeLookUpEdit_QueryPopUp1(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> ProductAttributesList = new List<ICProductAttributesInfo>();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    objProductAttributesInfo.ICProductAttributeID = 0;
        //    ProductAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup("PackingMaterialSpeciality");
        //    if (ProductAttributesList != null)
        //    {
        //        ProductAttributesList.Insert(0, objProductAttributesInfo);
        //        lookUpEdit.Properties.DataSource = ProductAttributesList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
        //    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        //}



        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).RemoveSelectedICProductPackingDetails();
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView view = (GridView)this.MainView;
            if (view != null)
            {
                ICProductPackingDetailsInfo item = (ICProductPackingDetailsInfo)view.GetFocusedRow();
                if (item != null)
                {
                    if (e.Column.FieldName == "ICProductPackingDetailHeight"
                        || e.Column.FieldName == "ICProductPackingDetailLength"
                        || e.Column.FieldName == "ICProductPackingDetailWidth"
                        || e.Column.FieldName == "ICProductPackingDetailQty")
                    {
                        item.ICProductPackingDetailVolume = (item.ICProductPackingDetailHeight
                                                        * item.ICProductPackingDetailLength
                                                        * item.ICProductPackingDetailWidth)
                                                        * item.ICProductPackingDetailQty / 1000000000;
                    }


                }

            }
        }
    }
}
