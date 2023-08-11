using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public class ProjectTemplateRelationshipsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProjectEntities entity = (ProjectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProjectTemplateRelationships;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = new GridColumn();
            column.Caption = ProjectLocalizedResources.PMPhaseTypeNameCaption;
            column.FieldName = "PMPhaseTypeName";
            column.OptionsColumn.AllowEdit = false;
            column.Width = 210;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            if (gridView.Columns["PMProjectTemplateRelationshipIsApproved"] != null)
            {
                gridView.Columns["PMProjectTemplateRelationshipIsApproved"].OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //ShowInventory();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ((ProjectModule)Screen.Module).ShowProjectNormByPhaseType();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show(ProjectLocalizedResources.ProjectNormConfrimDeleteMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                ((ProjectModule)Screen.Module).RemoveSelectedItemFromProjectTemplateRelationshipsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            if (e.Column.FieldName == "PMProjectTemplateRelationshipIsApproved")
                ((ProjectModule)Screen.Module).ApprovedProjectTemplateRelationship();
        }
    }
}
