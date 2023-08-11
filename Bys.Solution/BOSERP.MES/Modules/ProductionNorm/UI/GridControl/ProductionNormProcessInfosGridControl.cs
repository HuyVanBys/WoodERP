using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using BOSComponent;
using BOSCommon;
using DevExpress.XtraEditors;
using System.Linq;
using BOSERP.Modules.ProductionNorm.UI;
using BOSLib;

namespace BOSERP
{
    public partial class ProductionNormProcessInfosGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public void InvalidateDataSource(BOSList<MMProductionNormProcessInfosInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    int index = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
                    ((guiProductionNormProcessInfos)Screen).RemoveProductionNormProcessInfo(index);
                }
            }
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                RepositoryItemGridLookUpEdit repositoryItemLookUpEdit = new RepositoryItemGridLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductDesc";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;

                repositoryItemLookUpEdit.NullText = string.Empty;
                GetLookupDataSource(repositoryItemLookUpEdit);
                repositoryItemLookUpEdit.ImmediatePopup = true;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                RepositoryItemGridLookUpEdit repositoryItemLookUpEdit = new RepositoryItemGridLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;

                repositoryItemLookUpEdit.NullText = string.Empty;
                GetOperationLookupDataSource(repositoryItemLookUpEdit);
                repositoryItemLookUpEdit.ImmediatePopup = true;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            
            return gridView;
        }
        public void GetLookupDataSource(RepositoryItemGridLookUpEdit lookUpEdit)
        {
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(x => x.ICProductType == ProductType.MMTB.ToString()).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                productList.Add(newObj);
            });
            DevExpress.XtraGrid.Columns.GridColumn col1 = lookUpEdit.View.Columns["ICProductNo"];
            DevExpress.XtraGrid.Columns.GridColumn col2 = lookUpEdit.View.Columns["ICProductDesc"];
            if (col1 == null)
                col1 = lookUpEdit.View.Columns.AddField("ICProductNo");
            if (col2 == null)
                col2 = lookUpEdit.View.Columns.AddField("ICProductDesc");
            col1.Caption = "Mã máy";
            col1.VisibleIndex = 0;
            col2.Caption = "Tên";
            col2.VisibleIndex = 1;
            lookUpEdit.DataSource = productList;
        }

        public void GetOperationLookupDataSource(RepositoryItemGridLookUpEdit lookUpEdit)
        {
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationList = objOperationsController.GetAliveOperationAndSortOrder();
            DevExpress.XtraGrid.Columns.GridColumn col1 = lookUpEdit.View.Columns["MMOperationNo"];
            DevExpress.XtraGrid.Columns.GridColumn col2 = lookUpEdit.View.Columns["MMOperationName"];
            if (col1 == null)
                col1 = lookUpEdit.View.Columns.AddField("MMOperationNo");
            if (col2 == null)
                col2 = lookUpEdit.View.Columns.AddField("MMOperationName");
            col1.Caption = "Mã";
            col1.VisibleIndex = 0;
            col2.Caption = "Tên";
            col2.VisibleIndex = 1;
            lookUpEdit.DataSource = operationList;
        }


        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductID == int.Parse(e.Value.ToString()) ).FirstOrDefault();
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductDesc;
                    }
                }
            }
        }

        void repositoryItemWoodLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(x => x.ICProductType == ProductType.MMTB.ToString()).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                productList.Add(newObj);
            });
            lookup.Properties.DataSource = productList;
            lookup.Properties.DisplayMember = "ICProductDesc";
            lookup.Properties.ValueMember = "ICProductID";
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
