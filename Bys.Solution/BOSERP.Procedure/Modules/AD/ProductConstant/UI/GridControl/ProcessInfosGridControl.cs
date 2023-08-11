using BOSCommon;
using BOSComponent;
using BOSERP.Modules.ProductConstant.UI;
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
    public partial class ProcessInfosGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public void InvalidateDataSource(BOSList<MMProcessInfosInfo> dataSource)
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
                    ((guiProcessInfos)Screen).RemoveProcessInfo(index);
                }
            }
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();


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
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductID == int.Parse(e.Value.ToString())).FirstOrDefault();
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
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(t => t.ICProductType == ProductType.MMTB.ToString()).ToList();
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
