using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;

namespace BOSERP.Modules.RecruitmentPlan
{
    public class HRRecruitmentPlanItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            RecruitmentPlanEntities entity = (RecruitmentPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RecruitmentPlanItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["FK_HRLevelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRRecruitmentPlanItemQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRRecruitmentPlanItemNote"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRRecruitmentPlanItemDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((RecruitmentPlanModule)Screen.Module).DeleteItemFromRecruitmentPlanItemsList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            HRRecruitmentNeedsInfo objRecruitmentNeedsInfo = new HRRecruitmentNeedsInfo();
            HRRecruitmentNeedsController objRecruitmentNeedsController = new HRRecruitmentNeedsController();
            if (e.Column.FieldName == "FK_HRRecruitmentNeedID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objRecruitmentNeedsInfo = (HRRecruitmentNeedsInfo)objRecruitmentNeedsController.GetObjectByID(value);
                        if (objRecruitmentNeedsInfo != null)
                        {
                            e.DisplayText = objRecruitmentNeedsInfo.HRRecruitmentNeedNo;
                        }
                        else
                        {
                            e.DisplayText = "";
                        }
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
    }
}
