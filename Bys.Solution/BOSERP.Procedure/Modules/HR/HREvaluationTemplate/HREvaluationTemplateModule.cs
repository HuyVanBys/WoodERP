using BOSReport;
using DevExpress.XtraReports.UI;
using System.Data;

namespace BOSERP.Modules.HREvaluationTemplate
{
    public class HREvaluationTemplateModule : BaseModuleERP
    {
        #region Declare Constant
        public const string StandardQuestionGridControlName = "fld_dgcHRStandardQuestions";
        public const string HRTemplateStandardGridControlName = "fld_dgcHRTemplateStandards";
        #endregion

        public HREvaluationTemplateModule()
        {
            Name = "HREvaluationTemplate";
            CurrentModuleEntity = new HREvaluationTemplateEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        #region override
        public override void ActionNew()
        {
            base.ActionNew();
            HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)CurrentModuleEntity;
            HREvaluationRanksController objEvaluationRanksController = new HREvaluationRanksController();
            HREvaluationRanksInfo objEvaluationRanksInfo = new HREvaluationRanksInfo();
            DataSet ds = objEvaluationRanksController.GetAllObjects();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                HRTemplateRanksInfo objTemplateRanksInfo = new HRTemplateRanksInfo();
                objEvaluationRanksInfo = (HREvaluationRanksInfo)objEvaluationRanksController.GetObjectFromDataRow(row);
                objTemplateRanksInfo.FK_HREvaluationRankID = objEvaluationRanksInfo.HREvaluationRankID;
                objTemplateRanksInfo.HRTemplateRankFromValue = objEvaluationRanksInfo.HREvaluationRankFromValue;
                objTemplateRanksInfo.HRTemplateRankToValue = objEvaluationRanksInfo.HREvaluationRankToValue;
                entity.HRTemplateRankList.Add(objTemplateRanksInfo);
            }
        }

        public override void ActionPrint()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)CurrentModuleEntity;
                HREvaluationTemplatesInfo objEvaluationTemplatesInfo = (HREvaluationTemplatesInfo)entity.MainObject;
                ADReportsController objReportsController = new ADReportsController();
                RPEvaluationTemplate report = new RPEvaluationTemplate();
                //report.LoadLayout(BOSCommon.Constants.Report.DevEvaluationTemplateReportPath);

                //Set current branch
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (branchAddressLine3 != null)
                    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
                XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (branchPhone != null)
                    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
                XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (branchFax != null)
                    branchFax.Text = objBranchsInfo.BRBranchContactFax;

                report.DataSource = objReportsController.GetStandardQuestionByEvaluationTemplateID(objEvaluationTemplatesInfo.HREvaluationTemplateID);
                report.DataMember = BOSCommon.Constants.Report.DevEvaluationTemplateReportName;
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevEvaluationTemplateReportPath, true);
                reviewer.Show();
            }
        }

        #endregion

        #region local
        /// <summary>
        /// Add the selected template standard to list
        /// </summary>
        public void AddItemToTemplateStandardList()
        {
            HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)CurrentModuleEntity;
            HREvaluationStandardsInfo objEvaluationStandardsInfo = (HREvaluationStandardsInfo)entity.HREvaluationStandardTreeList.CurrentObject;
            AddItemToTemplateStandardList(objEvaluationStandardsInfo);
        }

        /// <summary>
        /// Add a standard to the standard list of the current template
        /// </summary>
        /// <param name="objEvaluationStandardsInfo">Standard</param>
        public void AddItemToTemplateStandardList(HREvaluationStandardsInfo objEvaluationStandardsInfo)
        {
            if (objEvaluationStandardsInfo != null)
            {
                if (!objEvaluationStandardsInfo.HasChildren())
                {
                    HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)CurrentModuleEntity;
                    HRTemplateStandardsInfo objTemplateStandardsInfo = new HRTemplateStandardsInfo();
                    objTemplateStandardsInfo.FK_HREvaluationStandardID = objEvaluationStandardsInfo.HREvaluationStandardID;
                    if (!objEvaluationStandardsInfo.HasChildren())
                    {
                        if (!entity.HRTemplateStandardList.Exists("FK_HREvaluationStandardID", objTemplateStandardsInfo.FK_HREvaluationStandardID))
                        {
                            entity.HRTemplateStandardList.Add(objTemplateStandardsInfo);
                            HRTemplateStandardsGridControl templateStandardsGridControl = (HRTemplateStandardsGridControl)Controls[HREvaluationTemplateModule.HRTemplateStandardGridControlName];
                            templateStandardsGridControl.InitGridControlDataSource();
                        }
                    }
                }
                else
                {
                    foreach (HREvaluationStandardsInfo objChildStandardsInfo in objEvaluationStandardsInfo.SubList)
                    {
                        AddItemToTemplateStandardList(objChildStandardsInfo);
                    }
                }
            }
        }

        /// <summary>
        /// Remove template standard from list
        /// </summary>
        public void RemoveItemFromTemplateStandardList()
        {
            HREvaluationTemplateEntities entity = (HREvaluationTemplateEntities)CurrentModuleEntity;
            entity.HRTemplateStandardList.RemoveSelectedRowObjectFromList();
        }
        #endregion
    }
}
