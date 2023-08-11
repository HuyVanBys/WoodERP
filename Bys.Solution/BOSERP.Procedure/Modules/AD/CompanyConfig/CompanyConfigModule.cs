using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSLib;

namespace BOSERP.Modules.CompanyConfig
{
    public class CompanyConfigModule : BaseModuleERP
    {
        #region Constants
        public const string cstOptionalFieldsScreenNumber = "DMCF100";
        public const string cstOptionalFieldsLookupEditModulesControlName = "fld_lkeModules";
        public const string cstOptionalFieldsLookupEditOptionalFieldsControlName = "fld_lkeOptionalFields";
        #endregion
    
        public CompanyConfigModule()
        {
            Name = "CompanyConfig";
            CurrentModuleEntity = new CompanyConfigEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        #region Optional Fields Screen
        private void fld_btnSaveOptionalFields_Click(object sender, EventArgs e)
        {
            BOSERPScreen screen = (BOSERPScreen)GetScreenByScreenNumber(cstOptionalFieldsScreenNumber);
            if (screen != null)
            {
                CompanyConfigEntities entity = (CompanyConfigEntities)CurrentModuleEntity;
                ADMatchCodesController objADMatchCodesController = new ADMatchCodesController();
                String strMCodeColumn = (screen.Controls[cstOptionalFieldsLookupEditOptionalFieldsControlName] as DevExpress.XtraEditors.LookUpEdit).EditValue.ToString();

                BOSList<ADMatchCodesInfo> lstOldADMatchCodes = new BOSList<ADMatchCodesInfo>();
                lstOldADMatchCodes.InitBOSList(entity, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ADMatchCodesInfo)));
                lstOldADMatchCodes.SetDefaultListAndRefreshGridControl();
                DataSet ds = objADMatchCodesController.GetADMatchCodesByADMatchCodeColumnName(strMCodeColumn);
                lstOldADMatchCodes.Invalidate(ds);
                lstOldADMatchCodes.DeleteItemObjects();

                entity.ADMatchCodesList.SaveItemObjects(false);
                MessageBox.Show("Save successfully.", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Numbering Screen
        private void fld_btnSaveNumbering_Click(object sender, EventArgs e)
        {
            CompanyConfigEntities entity = (CompanyConfigEntities)CurrentModuleEntity;
            entity.GENumberingsList.SaveItemObjects(true);
            MessageBox.Show("Save successfully.", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Config Values Screen
        private void fld_btnSaveConfigValues_Click(object sender, EventArgs e)
        {
            CompanyConfigEntities entity = (CompanyConfigEntities)CurrentModuleEntity;
            entity.ADConfigValuesList.SaveItemObjects(true);
            MessageBox.Show("Save successfully.", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Company Profile Screen
        private void fld_btnSaveCompanyProfile_Click(object sender, EventArgs e)
        {
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCurrentCompanysInfo = (CSCompanysInfo)CurrentModuleEntity.ModuleObjects[CompanyConfigEntities.cstCSCompanysObjectName];
            if (objCurrentCompanysInfo != null)
            {
                if (objCompanysController.IsExist(objCurrentCompanysInfo.CSCompanyID))
                    objCompanysController.UpdateObject(objCurrentCompanysInfo);
                else
                    objCompanysController.CreateObject(objCurrentCompanysInfo);
                MessageBox.Show("Save successfully.", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
