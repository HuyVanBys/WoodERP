using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class AttributesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AttributesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã thuộc tính";
            column.FieldName = "ICProductAttributeNo";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên thuộc tính";
            column.FieldName = "ICProductAttributeValue";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm hàng";
            column.FieldName = "FK_ICProductGroupID";
            column.OptionsColumn.AllowEdit = true;

            if (column != null)
            {
                RepositoryItemBOSLookupEdit repositoryItemWoodLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemWoodLookUpEdit.DisplayMember = "ICProductGroupName";
                repositoryItemWoodLookUpEdit.ValueMember = "ICProductGroupID";
                repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemWoodLookUpEdit.NullText = string.Empty;
                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", "Nhóm hàng"));
                repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(Group_QueryPopUp);
                column.ColumnEdit = repositoryItemWoodLookUpEdit;
                column.OptionsColumn.AllowEdit = false;
            }

            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ProductConstantLocalizedResources.AddOperation;
            column.FieldName = "AddOperation";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 3;

            RepositoryItemHyperLinkEdit AddOperation = new RepositoryItemHyperLinkEdit();
            AddOperation.NullText = ProductConstantLocalizedResources.AddOperation;
            AddOperation.Click += new EventHandler(AddOperation_Click);
            column.ColumnEdit = AddOperation;
            gridView.Columns.Add(column);
        }

        private void AddOperation_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Screen.Module).ShowItemOperation();
        }

        private void Group_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup == null)
                return;

            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            List<ICProductGroupsInfo> productGroupList = objProductGroupsController.GetProductGroupListByDepartmentNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.ProductNo.ToString()));
            lookup.Properties.DataSource = productGroupList;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductGroupID")
            {
                if (e.Value != null)
                {
                    ICProductGroupsController productGroupController = new ICProductGroupsController();
                    ICProductGroupsInfo productGroup = productGroupController.GetObjectByID(Convert.ToInt32(e.Value)) as ICProductGroupsInfo;
                    if (productGroup != null)
                    {
                        e.DisplayText = productGroup.ICProductGroupName;
                    }
                }
            }
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveAttributes();
            }
        }
    }
}
