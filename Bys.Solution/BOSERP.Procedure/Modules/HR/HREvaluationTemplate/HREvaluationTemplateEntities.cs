using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HREvaluationTemplate
{
    public class HREvaluationTemplateEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the evaluation standar list 
        /// </summary>
        public BOSTreeList HREvaluationStandardTreeList { get; set; }
        /// <summary>
        /// Gets or sets the standard question list
        /// </summary>
        public BOSList<HRStandardQuestionsInfo> HRStandardQuestionList { get; set; }
        /// <summary>
        /// Gets or set the template question list
        /// </summary>
        public BOSList<HRTemplateRanksInfo> HRTemplateRankList { get; set; }
        /// <summary>
        /// Gets or sets the template standard list
        /// </summary>
        public BOSList<HRTemplateStandardsInfo> HRTemplateStandardList { get; set; }
        #endregion

        #region Constructor
        public HREvaluationTemplateEntities()
            : base()
        {
            HREvaluationStandardTreeList = new BOSTreeList();
            HRStandardQuestionList = new BOSList<HRStandardQuestionsInfo>();
            HRTemplateRankList = new BOSList<HRTemplateRanksInfo>();
            HRTemplateStandardList = new BOSList<HRTemplateStandardsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HREvaluationTemplatesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRTemplateRanksTableName, new HRTemplateRanksInfo());
            ModuleObjects.Add(TableName.HRTemplateStandardsTableName, new HRTemplateStandardsInfo());
        }

        public override void InitModuleObjectList()
        {
            HREvaluationStandardTreeList.InitBOSList(this,
                                                 String.Empty,
                                                 TableName.HREvaluationStandardsTableName,
                                                 BOSTreeList.cstRelationNone);

            HRTemplateRankList.InitBOSList(this,
                                           TableName.HREvaluationTemplatesTableName,
                                           TableName.HRTemplateRanksTableName,
                                           BOSList<HRTemplateRanksInfo>.cstRelationForeign);
            HRTemplateRankList.ItemTableForeignKey = "FK_HREvaluationTemplateID";

            HRTemplateStandardList.InitBOSList(this,
                                           TableName.HREvaluationTemplatesTableName,
                                           TableName.HRTemplateStandardsTableName,
                                           BOSList<HRTemplateStandardsInfo>.cstRelationForeign);
            HRTemplateStandardList.ItemTableForeignKey = "FK_HREvaluationTemplateID";

            HRStandardQuestionList.InitBOSList(this,
                                               String.Empty,
                                               TableName.HRStandardQuestionsTableName,
                                               BOSList<HRTemplateRanksInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREvaluationStandardTreeList.InitBOSTreeListControl();
            HRTemplateRankList.InitBOSListGridControl();
            HRTemplateStandardList.InitBOSListGridControl();
            HRStandardQuestionList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRTemplateRankList.SetDefaultListAndRefreshGridControl();
                HRTemplateStandardList.SetDefaultListAndRefreshGridControl();
                HRStandardQuestionList.SetDefaultListAndRefreshGridControl();
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
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRTemplateRankList.Invalidate(iObjectID);
            HRTemplateStandardList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            HRTemplateRankList.SaveItemObjects();
            HRTemplateStandardList.SaveItemObjects();
        }
        #endregion
    }
}
