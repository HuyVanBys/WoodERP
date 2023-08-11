using BOSCommon.Constants;
using BOSComponent;
using Localization;
using System;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationStandard
{
    public class HREvaluationStandardModule : BaseModuleERP
    {
        #region Declare Constant
        public const string StandardQuestionGridControlName = "fld_dgcHRStandardQuestions";
        public const string EvaluationQuestionLookupEditName = "fld_lkeFK_HREvaluationQuestionID";
        #endregion

        #region Declare Variables
        private BOSLookupEdit EvaluationQuestionLookupEdit;
        private HRStandardQuestionsGridControl StandardQuestionGridControl;
        #endregion

        public HREvaluationStandardModule()
        {
            Name = "HREvaluationStandard";
            CurrentModuleEntity = new HREvaluationStandardEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            EvaluationQuestionLookupEdit = (BOSLookupEdit)Controls[HREvaluationStandardModule.EvaluationQuestionLookupEditName];
            StandardQuestionGridControl = (HRStandardQuestionsGridControl)Controls[HREvaluationStandardModule.StandardQuestionGridControlName];
        }

        #region Local
        /// <summary>
        /// Add evaluation standard to list
        /// </summary>
        public void AddItemToEvaluationStandardList()
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            HREvaluationStandardsInfo objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.HREvaluationStandardList.CurrentObject;
            int evaluationStandardParentID = objEvaluationStandardsInfo.HREvaluationStandardID;
            entity.SetDefaultModuleObject(TableName.HREvaluationStandardsTableName);
            guiAddEvaluationStandard guiAddItem = new guiAddEvaluationStandard();
            guiAddItem.Module = this;
            if (guiAddItem.ShowDialog() == DialogResult.OK)
            {
                objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.ModuleObjects[TableName.HREvaluationStandardsTableName];
                objEvaluationStandardsInfo.HREvaluationStandardParentID = evaluationStandardParentID;
                // Save the current evaluation to database
                if (!string.IsNullOrEmpty(objEvaluationStandardsInfo.HREvaluationStandardName))
                {
                    objEvaluationStandardsInfo.HREvaluationStandardID = entity.SaveEvaluationStandard(objEvaluationStandardsInfo);
                    if (entity.HREvaluationStandardList.CurrentObject.SubList == null)
                        entity.HREvaluationStandardList.CurrentObject.SubList = new BOSTreeList();
                    entity.HREvaluationStandardList.CurrentObject.SubList.Add(objEvaluationStandardsInfo);
                    entity.HREvaluationStandardList.TreeListControl.RefreshDataSource();
                }
                else
                    MessageBox.Show(EvaluationStandardLocalizedResources.EvaluationStandardNameIsNullErrorMessage
                                                            , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit current evaluation standard from tree list
        /// </summary>
        public void EditItemToEvaluationStandardList()
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            HREvaluationStandardsInfo objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.ModuleObjects[TableName.HREvaluationStandardsTableName];
            guiAddEvaluationStandard guiAddItem = new guiAddEvaluationStandard();
            guiAddItem.Module = this;
            if (guiAddItem.ShowDialog() == DialogResult.OK)
            {
                entity.HREvaluationStandardList.ChangeObjectFromList();
                entity.SaveEvaluationStandard(objEvaluationStandardsInfo);
            }
        }

        /// <summary>
        /// Delete current evaluation stardard from tree list
        /// </summary>
        public void DeleteItemToEvaluationStandardList()
        {
            if (MessageBox.Show(LocationLocalizedResources.ConfirmDeleteLocation, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
                HREvaluationStandardsInfo objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.ModuleObjects[TableName.HREvaluationStandardsTableName];
                entity.HREvaluationStandardList.RemoveSelectedRowObjectFromList();
                entity.DeleteSelectedItemFromTreeListControl(objEvaluationStandardsInfo);
            }
        }

        /// <summary>
        /// Add standard question to list
        /// </summary>
        public void AddItemToStandardQuestionList()
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            HREvaluationStandardsInfo objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.ModuleObjects[TableName.HREvaluationStandardsTableName];
            if (objEvaluationStandardsInfo.HRStandardQuestionList != null)
            {
                objEvaluationStandardsInfo.HRStandardQuestionList.AddObjectToList();
            }
        }

        /// <summary>
        /// Show form to allow to create a new evaluation question 
        /// </summary>
        public void CreateNewEvaluationQuestion()
        {
            guiCreateEvaluationQuestion guiCreateNew = new guiCreateEvaluationQuestion();
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            guiCreateNew.Module = this;
            if (guiCreateNew.ShowDialog() == DialogResult.OK)
            {
                //Create a new question
                int evaluationQuestionId = SaveEvaluationQuestion(0, String.Empty, guiCreateNew.HREvaluationQuestionDesc);
                //Invalidate data source of question lookup edit to include new question
                EvaluationQuestionLookupEdit.InvalidateDataSourceToLookupEdit();
                //Update module object and get the lookup edit to focus on new question
                HRStandardQuestionsInfo objStandardQuestionsInfo = (HRStandardQuestionsInfo)entity.ModuleObjects[TableName.HRStandardQuestionsTableName];
                objStandardQuestionsInfo.FK_HREvaluationQuestionID = evaluationQuestionId;
                entity.UpdateModuleObjectBindingSource(TableName.HRStandardQuestionsTableName);
                //Add new question to the question list of the current standard
                AddItemToStandardQuestionList();
            }
        }

        /// <summary>
        /// Show form to allow update the evaluation question
        /// </summary>
        /// <param name="evaluationQuestionID">ID of evaluation question</param>
        /// <param name="evaluationQuestionDesc">Description of evaluation question</param>
        public void EditEvaluationQuestion(int evaluationQuestionID, string evaluationQuestionDesc)
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            guiCreateEvaluationQuestion guiCreateNew = new guiCreateEvaluationQuestion(evaluationQuestionID, evaluationQuestionDesc);
            guiCreateNew.Module = this;
            if (guiCreateNew.ShowDialog() == DialogResult.OK)
            {
                SaveEvaluationQuestion(evaluationQuestionID, evaluationQuestionDesc, guiCreateNew.HREvaluationQuestionDesc);
            }
        }

        /// <summary>
        /// Save evaluation question to database
        /// </summary>
        /// <param name="evaluationQuestionID">ID of evaluation question</param>
        /// <param name="oldEvaluationQuestionDesc">Old description of evaluation question</param>
        /// <param name="newEvaluationQuestionDesc">New description of evaluation question</param>
        /// <returns>Question's id</returns>
        public int SaveEvaluationQuestion(int evaluationQuestionID, string oldEvaluationQuestionDesc, string newEvaluationQuestionDesc)
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            HREvaluationQuestionsController objEvaluationQuestionsController = new HREvaluationQuestionsController();
            int evaluationQuestionId = entity.SaveEvaluationQuestion(evaluationQuestionID, oldEvaluationQuestionDesc, newEvaluationQuestionDesc);
            StandardQuestionGridControl.InvalidateLookupEditColumns();
            return evaluationQuestionId;
        }

        /// <summary>
        /// Remove the selected question from the question list of a standard
        /// </summary>
        public void RemoveSelectedQuestion()
        {
            BOSGridControl standardQuestionGridControl = (BOSGridControl)Controls[HREvaluationStandardModule.StandardQuestionGridControlName];
            BOSList<HRStandardQuestionsInfo> standardQuestionList = (BOSList<HRStandardQuestionsInfo>)((BindingSource)standardQuestionGridControl.DataSource).DataSource;
            standardQuestionList.RemoveSelectedRowObjectFromList();
        }

        public override int ActionSave()
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    CurrentModuleEntity.SaveModuleObjects();
                    scope.Complete();
                    MessageBox.Show(EvaluationStandardLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
                return 0;
            }
        }
        #endregion

        /// <summary>
        /// Save evaluation ranks
        /// </summary>
        public void SaveEvaluationRanks()
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            entity.SaveEvaluationRanks();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Save standard question list of current evaluation standard
        /// </summary>
        public void SaveStandardQuestion()
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)CurrentModuleEntity;
            HREvaluationStandardsInfo objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.ModuleObjects[TableName.HREvaluationStandardsTableName];
            entity.SaveStandardQuestion(objEvaluationStandardsInfo);
        }
    }
}
