using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationStandard
{
    public partial class HREvaluationStandardsTreeListControl : BOSTreeListControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.MouseClick += new MouseEventHandler(ShowContextMenu);
        }

        protected void ShowContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add(EvaluationStandardLocalizedResources.AddNewEvaluationStandardContextMenu, new System.EventHandler(AddNewEvaluationStandard_Click));
                contextMenu.MenuItems.Add(EvaluationStandardLocalizedResources.EditNewEvaluationStandardContextMenu, new System.EventHandler(EditNewEvaluationStandard_Click));
                contextMenu.MenuItems.Add(EvaluationStandardLocalizedResources.DeleteNewEvaluationStandardContextMenu, new System.EventHandler(DeleteNewEvaluationStandard_Click));
                contextMenu.Show(this, new Point(e.X, e.Y));
            }
        }

        protected void AddNewEvaluationStandard_Click(Object sender, System.EventArgs e)
        {
            ((HREvaluationStandardModule)Screen.Module).AddItemToEvaluationStandardList();
        }

        protected void EditNewEvaluationStandard_Click(Object sender, System.EventArgs e)
        {
            ((HREvaluationStandardModule)Screen.Module).EditItemToEvaluationStandardList();
        }

        protected void DeleteNewEvaluationStandard_Click(Object sender, System.EventArgs e)
        {
            ((HREvaluationStandardModule)Screen.Module).DeleteItemToEvaluationStandardList();
        }

        protected override void InitTreeListDataSource()
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource.Add(new HREvaluationStandardsInfo(EvaluationStandardLocalizedResources.EvaluationStandard));
            HREvaluationStandardsController objEvaluationStandardsController = new HREvaluationStandardsController();
            DataSet ds = objEvaluationStandardsController.GetAllRootEvaluationStandards();
            entity.HREvaluationStandardList.Invalidate(ds);
            dataSource[0].SubList = entity.HREvaluationStandardList;
            DataSource = dataSource;
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            TreeListColumn column = Columns["HREvaluationStandardName"];
            if (column != null)
            {
                column.VisibleIndex = 1;
                column.OptionsColumn.AllowEdit = false;
            }
        }

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = entity.HREvaluationStandardList.TreeListControl.GetSelectedNode();
            HRStandardQuestionsGridControl standardQuestionControl = (HRStandardQuestionsGridControl)Screen.Module.Controls[HREvaluationStandardModule.StandardQuestionGridControlName];
            if (node != null && node.Level > 0)
            {
                HREvaluationStandardsInfo objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.HREvaluationStandardList.CurrentObject;
                if (objEvaluationStandardsInfo != null)
                {
                    if (objEvaluationStandardsInfo.HRStandardQuestionList == null)
                    {
                        objEvaluationStandardsInfo.HRStandardQuestionList = new BOSList<HRStandardQuestionsInfo>();
                        objEvaluationStandardsInfo.HRStandardQuestionList.InitBOSList(
                                                                     entity,
                                                                     TableName.HREvaluationStandardsTableName,
                                                                     TableName.HRStandardQuestionsTableName,
                                                                     BOSList<HRStandardQuestionsInfo>.cstRelationForeign);
                        ((BOSList<HRStandardQuestionsInfo>)objEvaluationStandardsInfo.HRStandardQuestionList).GridControl = standardQuestionControl;
                        if (objEvaluationStandardsInfo.HREvaluationStandardID > 0)
                        {
                            objEvaluationStandardsInfo.HRStandardQuestionList.Invalidate(objEvaluationStandardsInfo.HREvaluationStandardID);
                        }
                    }
                    standardQuestionControl.InvalidateDataSource(objEvaluationStandardsInfo.HRStandardQuestionList);
                }
            }
        }
    }
}
