using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.DeviceProduct
{
    public class ICProductImagesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            DeviceProductEntities entity = (DeviceProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductFilesList;
            this.DataSource = bds;
        }

        public enum ICProductFilesColumnName
        {
            ICProductFileImage,
            ICProductFileLargeSizeUrlImage
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = ICProductFilesColumnName.ICProductFileImage.ToString();
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;
            RepositoryItemPictureEdit repositoryItemPictureEdit = new RepositoryItemPictureEdit();
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit)repositoryItemPictureEdit;
            this.RepositoryItems.Add(repositoryItemPictureEdit);

            column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = ICProductFilesColumnName.ICProductFileLargeSizeUrlImage.ToString();
            gridView.Columns.Insert(1, column);
            column.VisibleIndex = 0;
            RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit = new RepositoryItemHyperLinkEdit();
            repositoryItemHyperLinkEdit.SingleClick = true;
            repositoryItemHyperLinkEdit.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            repositoryItemHyperLinkEdit.NullText = String.Empty;
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit)repositoryItemHyperLinkEdit;
            this.RepositoryItems.Add(repositoryItemHyperLinkEdit);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.RowHeight = 100;
            return gridView;
        }
    }
}
