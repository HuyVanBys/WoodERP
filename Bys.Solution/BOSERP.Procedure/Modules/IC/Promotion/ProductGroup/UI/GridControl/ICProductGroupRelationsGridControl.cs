using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.ProductGroup
{
    public class ICProductGroupRelationsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductGroupEntities entity = (ProductGroupEntities)((BaseModuleERP)(Screen.Module)).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductGroupRelationsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            //Set all column is enable
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
            int iParentProductGroupID = ((BaseModuleERP)Screen.Module).Toolbar.CurrentObjectID;
            
            if (iParentProductGroupID > 0)
                gridView.SetRowCellValue(e.RowHandle, "FK_ICProductGroupRelationParentID", iParentProductGroupID);
        }

        protected override void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            base.GridView_ValidateRow(sender, e);

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;

            ProductGroupEntities entity = (ProductGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            int iParentProductGroupID = ((ICProductGroupsInfo)entity.MainObject).ICProductGroupID;
            int iChildProductGroupID = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "FK_ICProductGroupRelationChildID"));

            if (iChildProductGroupID == 0)
            {
                MessageBox.Show("You must choose product group.", "#Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Valid = false;
            }
            else
                if (iParentProductGroupID == iChildProductGroupID)
                {
                    MessageBox.Show("Child product group can not be identical to parent product group.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Valid = false;
                }
                else
                    if (Exists(iParentProductGroupID, iChildProductGroupID))
                    {
                        MessageBox.Show("Child product group already exists in list.", "#Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Valid = false;
                    }
                    else
                        entity.ICProductGroupRelationsList[entity.ICProductGroupRelationsList.Count - 1].FK_ICProductGroupRelationParentID = iParentProductGroupID;
        }
        
        public bool Exists(int iParentProductGroupID, int iChildProductGroupID)
        {
            ProductGroupEntities entity = (ProductGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            for (int i = 0; i < entity.ICProductGroupRelationsList.Count - 1; i++)
            {
                ICProductGroupRelationsInfo item = entity.ICProductGroupRelationsList[i];
                if (item.FK_ICProductGroupRelationParentID == iParentProductGroupID &&
                    item.FK_ICProductGroupRelationChildID == iChildProductGroupID)
                    return true;
            }
            return false;
        }

        protected override void GridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            base.GridView_InvalidRowException(sender, e);

            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
        }
    }
}
