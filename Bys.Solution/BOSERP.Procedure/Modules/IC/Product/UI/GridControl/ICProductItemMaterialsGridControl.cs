using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ICProductItemMaterialsGridControl : BOSGridControl
    {
        List<ICProductsInfo> objProductsInfoList;
        public int ProductID = 0;
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PNIMList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).DeleteItemFromProductItemMaterialsList();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            objProductsInfoList = ((ProductModule)Screen.Module).GetWoodIngredient();

            foreach (GridColumn col in gridview.Columns)
            {
                col.OptionsColumn.AllowEdit = true;

                if (col.FieldName == "FK_ICProductMaterialID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                    repositoryItemLookUpEdit.ValueMember = "ICProductID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                    col.ColumnEdit = repositoryItemLookUpEdit;
                }
                else if (col.FieldName == "ICProductItemMaterialQty")
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }

            gridview.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridview_CustomColumnDisplayText);
            return gridview;
        }

        void gridview_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.FieldName == "FK_ICProductMaterialID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == id);
                    if (iProduct != null)
                    {
                        e.DisplayText = iProduct.ICProductName;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
        }


        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = objProductsInfoList;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView view = (GridView)this.MainView;
            if (view != null)
            {
                ICProductItemMaterialsInfo item = (ICProductItemMaterialsInfo)view.GetFocusedRow();
                if (item != null)
                {
                    if (e.Column.FieldName == "FK_ICProductMaterialID")
                    {
                        ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductMaterialID);
                        if (iProduct != null)
                        {
                            ChangeIngredient(item, iProduct);
                        }
                    }

                    if (e.Column.FieldName == "FK_ICProductMaterialID"
                        || e.Column.FieldName == "ICProductItemMaterialLength"
                        || e.Column.FieldName == "ICProductItemMaterialWidth"
                        || e.Column.FieldName == "ICProductItemMaterialHeigth"
                        || e.Column.FieldName == "ICProductItemMaterialWoodQty")
                    {
                        item.ICProductItemMaterialQty = (item.ICProductItemMaterialHeigth
                                                        * item.ICProductItemMaterialLength
                                                        * item.ICProductItemMaterialWidth)
                                                        * item.ICProductItemMaterialWoodQty / 1000000000;
                    }


                }

            }
        }

        public void ChangeIngredient(ICProductItemMaterialsInfo item, ICProductsInfo iProduct)
        {
            item.ICProductItemMaterialHeigth = iProduct.ICProductHeight;

            if (ProductID > 0)
            {
                ICProductsController pController = new ICProductsController();
                ICProductsInfo p = (ICProductsInfo)pController.GetObjectByID(ProductID);

                MMExchangeRateConfigsController ercCtrl = new MMExchangeRateConfigsController();
                MMExchangeRateConfigsInfo erc = ercCtrl.GetByWoodTypeAndSpeciality(iProduct.FK_ICProductAttributeWoodTypeID, p.FK_ICProductAttributeSemiProductSpecialityID);

                if (erc != null)
                {
                    item.ICProductItemMaterialLength = p.ICProductLength + erc.MMExchangeRateConfigLengthBonus;
                    item.ICProductItemMaterialWidth = p.ICProductWidth + erc.MMExchangeRateConfigWidthBonus;
                }
            }

        }
    }
}
