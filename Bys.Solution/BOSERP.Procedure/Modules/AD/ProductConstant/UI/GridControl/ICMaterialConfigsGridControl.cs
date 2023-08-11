using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class ICMaterialConfigsGridControl : BOSGridControl
    {
        public List<ICProductAttributesInfo> DataList;

        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICMaterialConfigsList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                RepositoryItemGridLookUpEdit repositoryItemLookUpEdit = new RepositoryItemGridLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                repositoryItemLookUpEdit.NullText = string.Empty;
                DevExpress.XtraGrid.Columns.GridColumn col = new GridColumn();
                col.FieldName = "ICProductNo";
                col.Caption = "Mã sản phẩm";
                col.VisibleIndex = 0;
                repositoryItemLookUpEdit.View.Columns.Add(col);
                col = new GridColumn();
                col.FieldName = "ICProductDesc";
                col.Caption = "Mô tả";
                col.VisibleIndex = 1;
                repositoryItemLookUpEdit.View.Columns.Add(col);
                col = new GridColumn();
                col.FieldName = "ICProductNoOfOldSys";
                col.Caption = "Mã hệ thống cũ";
                col.VisibleIndex = 2;
                repositoryItemLookUpEdit.View.Columns.Add(col);
                col = new GridColumn();
                col.FieldName = "ICProductAttribute";
                col.Caption = "Đặc tính";
                col.VisibleIndex = 3;
                repositoryItemLookUpEdit.View.Columns.Add(col);

                ICProductsController objPDController = new ICProductsController();
                List<ICProductsInfo> dataList = new List<ICProductsInfo>();
                dataList.Insert(0, new ICProductsInfo());
                List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(p => p.ICProductType != ProductType.Product.ToString() && p.ICProductType != ProductType.SemiProduct.ToString()).ToList();
                if (productViewList.Count() > 0) productViewList.ForEach(o =>
                {
                    ICProductsInfo newObj = new ICProductsInfo();
                    BOSUtil.CopyViewObject(o, newObj);
                    dataList.Add(newObj);
                });

                repositoryItemLookUpEdit.DataSource = dataList;

                column.ColumnEdit = repositoryItemLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICProductAttributeSpecialityID"];
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
                //repositoryItemAttributeLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                //repositoryItemAttributeLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeLookupEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemAttributeLookUpEdit;
                //gridView.Columns.Add(column);
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", " "));

                //ICProductAttributesController objPGController = new ICProductAttributesController();
                //DataList = objPGController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.WoodType.ToString());
                //DataList.Insert(0, new ICProductAttributesInfo());

                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICProductAttHTType"];
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
                //repositoryItemAttributeLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Hoàn thiện"));

                //repositoryItemAttributeLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemAttributeLookUpEdit;

            }

            column = gridView.Columns["FK_ICProductAttPackingMaterialSpeciality"];
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

            column = gridView.Columns["ICMaterialConfigCalByQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICMaterialConfigCalByType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }


        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = DataList;
        }


        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICProductID" && e.Value != null)
            {
                int productID = 0;
                if (int.TryParse(e.Value.ToString(), out productID) && productID > 0)
                {
                    ICMaterialConfigsInfo objMaterialConfigsInfo = (ICMaterialConfigsInfo)gridView.GetFocusedRow();

                    ((ProductConstantModule)Screen.Module).ChangeMaterialProduct(objMaterialConfigsInfo, productID);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedICMaterialConfigs();
            }
        }

        #region old code
        //public void repositoryItemAttributeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> ProductAttributesList = new List<ICProductAttributesInfo>();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    objProductAttributesInfo.ICProductAttributeID = 0;
        //    ProductAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup("Speciality");
        //    if (ProductAttributesList != null)
        //    {
        //        ProductAttributesList.Insert(0, objProductAttributesInfo);
        //        lookUpEdit.Properties.DataSource = ProductAttributesList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ICProductAttributeName";
        //    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        //}
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

        //void repositoryItemAttributeLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> ProductAttributesList = new List<ICProductAttributesInfo>();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    objProductAttributesInfo.ICProductAttributeID = 0;
        //    ProductAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup("HTType");
        //    if (ProductAttributesList != null)
        //    {
        //        ProductAttributesList.Insert(0, objProductAttributesInfo);
        //        lookUpEdit.Properties.DataSource = ProductAttributesList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
        //    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        //}
        //void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        //{
        //    if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID")
        //    {
        //        if (e.Value != null)
        //        {
        //            e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
        //        }
        //    }
        //}
        #endregion

    }
}
