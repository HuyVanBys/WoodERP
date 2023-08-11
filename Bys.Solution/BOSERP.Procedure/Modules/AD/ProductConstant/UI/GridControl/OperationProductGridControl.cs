using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class OperationProductGridControl : BOSGridControl
    {

        public List<ICProductsInfo> ProductList;

        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OperationProductList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;

            }
            ProductList = new List<ICProductsInfo>();
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(t => t.ICProductType == ProductType.MMTB.ToString()).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                ProductList.Add(newObj);
            });

            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                RepositoryItemBOSLookupEdit repositoryItemWoodLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemWoodLookUpEdit.DisplayMember = "ICProductDesc";
                repositoryItemWoodLookUpEdit.ValueMember = "ICProductID";
                repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemWoodLookUpEdit.NullText = string.Empty;

                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã máy"));
                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Tên máy"));

                repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemWoodLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemWoodLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }

            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        void repositoryItemWoodLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            lookup.Properties.DataSource = ProductList;
            lookup.Properties.DisplayMember = "ICProductDesc";
            lookup.Properties.ValueMember = "ICProductID";
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductsInfo product = ProductList.FirstOrDefault(t => t.ICProductID == matchCodeID);
                    if (product != null)
                    {
                        e.DisplayText = product.ICProductDesc;
                    }
                }

            }

        }


        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductConstantModule)Screen.Module).RemoveSelectOperationProduct();
                }
            }
        }
    }
}
