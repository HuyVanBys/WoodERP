using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HREvaluationStandard
{
    public class HREvaluationStandardEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the evaluation standar list 
        /// </summary>
        public BOSTreeList HREvaluationStandardList { get; set; }
        /// <summary>
        /// Gets or sets the evaluation question list
        /// </summary>
        public BOSList<HREvaluationQuestionsInfo> HREvaluationQuestionList { get; set; }
        /// <summary>
        /// Gets or sets the evaluation rank list
        /// </summary>
        public BOSList<HREvaluationRanksInfo> HREvaluationRankList { get; set; }
        #endregion

        #region Constructor
        public HREvaluationStandardEntities()
            : base()
        {
            HREvaluationStandardList = new BOSTreeList();
            HREvaluationQuestionList = new BOSList<HREvaluationQuestionsInfo>();
            HREvaluationRankList = new BOSList<HREvaluationRanksInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREvaluationStandardsTableName, new HREvaluationStandardsInfo());
            ModuleObjects.Add(TableName.HREvaluationQuestionsTableName, new HREvaluationQuestionsInfo());
            ModuleObjects.Add(TableName.HRStandardQuestionsTableName, new HRStandardQuestionsInfo());
            ModuleObjects.Add(TableName.HREvaluationRanksTableName, new HREvaluationRanksInfo());
        }

        public override void InitModuleObjectList()
        {
            HREvaluationStandardList.InitBOSList(this,
                                                 String.Empty,
                                                 TableName.HREvaluationStandardsTableName,
                                                 BOSTreeList.cstRelationNone);

            HREvaluationQuestionList.InitBOSList(this,
                                                 String.Empty,
                                                 TableName.HREvaluationQuestionsTableName,
                                                 BOSList<HREvaluationQuestionsInfo>.cstRelationNone);

            HREvaluationRankList.InitBOSList(this,
                                             String.Empty,
                                             TableName.HREvaluationRanksTableName,
                                             BOSList<HREvaluationRanksInfo>.cstRelationNone);

        }

        public override void InitGridControlInBOSList()
        {
            HREvaluationStandardList.InitBOSTreeListControl();
            HREvaluationRankList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREvaluationStandardList.SetDefaultListAndRefreshTreeListControl();
                HREvaluationRankList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HREvaluationStandardList.InvalidateTreeList(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {

        }

        /// <summary>
        /// Save current evaluation standard
        /// </summary>
        /// <param name="objEvaluationStandardsInfo">The current evaluation standard</param>
        /// <returns>ID of evaluation standard is saved</returns>
        public int SaveEvaluationStandard(HREvaluationStandardsInfo objEvaluationStandardsInfo)
        {
            HREvaluationStandardsController objEvaluationStandardsController = new HREvaluationStandardsController();
            int evaluationStandardID = 0;
            if (objEvaluationStandardsInfo.HREvaluationStandardID == 0)
                evaluationStandardID = objEvaluationStandardsController.CreateObject(objEvaluationStandardsInfo);
            else
                evaluationStandardID = objEvaluationStandardsController.UpdateObject(objEvaluationStandardsInfo);
            return evaluationStandardID;
        }

        /// <summary>
        /// Save all standard question to database
        /// </summary>
        /// <param name="evaluationStandardList">Evaluation standard list</param>
        public void SaveStandardQuestion(HREvaluationStandardsInfo objEvaluationStandardsInfo)
        {
            if (objEvaluationStandardsInfo.HRStandardQuestionList != null)
            {
                foreach (HRStandardQuestionsInfo objStandardQuestionsInfo in objEvaluationStandardsInfo.HRStandardQuestionList)
                {
                    objStandardQuestionsInfo.FK_HREvaluationStandardID = objEvaluationStandardsInfo.HREvaluationStandardID;
                }
                objEvaluationStandardsInfo.HRStandardQuestionList.SaveItemObjects();
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
            HREvaluationQuestionsController objEvaluationQuestionsController = new HREvaluationQuestionsController();
            HREvaluationQuestionsInfo objEvaluationQuestionsInfo = new HREvaluationQuestionsInfo();
            if (evaluationQuestionID != 0)
            {
                objEvaluationQuestionsInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objEvaluationQuestionsInfo.AAUpdatedDate = DateTime.Now;
                objEvaluationQuestionsInfo.HREvaluationQuestionID = evaluationQuestionID;
                objEvaluationQuestionsInfo.HREvaluationQuestionDesc = newEvaluationQuestionDesc;
                objEvaluationQuestionsController.UpdateObject(objEvaluationQuestionsInfo);
            }
            else
            {
                objEvaluationQuestionsInfo.AACreatedUser = BOSApp.CurrentUser;
                objEvaluationQuestionsInfo.AACreatedDate = DateTime.Now;
                objEvaluationQuestionsInfo.HREvaluationQuestionDesc = newEvaluationQuestionDesc;
                objEvaluationQuestionsController.CreateObject(objEvaluationQuestionsInfo);
            }
            return objEvaluationQuestionsInfo.HREvaluationQuestionID;
        }

        /// <summary>
        /// Save evaluation rank list
        /// </summary>
        public void SaveEvaluationRanks()
        {
            HREvaluationRankList.SaveItemObjects();
        }
        #endregion

        /// <summary>
        /// Delete selected item from evaluation standard tree list control
        /// </summary>
        /// <param name="objEvaluationStandardsInfo">The current evaluation standard</param>
        public void DeleteSelectedItemFromTreeListControl(HREvaluationStandardsInfo objEvaluationStandardsInfo)
        {
            HREvaluationStandardsController objEvaluationStandardsController = new HREvaluationStandardsController();
            objEvaluationStandardsController.DeleteObject(objEvaluationStandardsInfo.HREvaluationStandardID);
        }
    }
}
