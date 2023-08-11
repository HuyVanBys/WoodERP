using System;
using System.Collections.Generic;
using System.Text;
using BOSLib;

namespace BOSERP.Modules.CompanyConfig
{
    public class CompanyConfigEntities : ERPModuleEntities
    {
        #region Constants
        public const string cstCSCompanysObjectName = "CSCompanys";
        #endregion

        #region Variables
        CSCompanysInfo CSCompanysObject;

        public BOSList<ADMatchCodesInfo> lstADMatchCodes;
        public BOSList<GENumberingInfo> lstGENumberings;
        public BOSList<ADConfigValuesInfo> lstADConfigValues;
        #endregion

        #region Public Properties
        public BOSList<ADMatchCodesInfo> ADMatchCodesList
        {
            get
            {
                return lstADMatchCodes;
            }
            set
            {
                lstADMatchCodes = value;
            }
        }

        public BOSList<GENumberingInfo> GENumberingsList
        {
            get
            {
                return lstGENumberings;
            }
            set
            {
                lstGENumberings = value;
            }
        }

        public BOSList<ADConfigValuesInfo> ADConfigValuesList
        {
            get
            {
                return lstADConfigValues;
            }
            set
            {
                lstADConfigValues = value;
            }
        }
        #endregion

        #region Constructor
        public CompanyConfigEntities()
            : base()
        {
            CSCompanysObject = (CSCompanysInfo)new CSCompanysController().GetFirstObject();
            if (CSCompanysObject == null)
                CSCompanysObject = new CSCompanysInfo();

            ADMatchCodesList = new BOSList<ADMatchCodesInfo>();
            GENumberingsList = new BOSList<GENumberingInfo>();
            ADConfigValuesList = new BOSList<ADConfigValuesInfo>();
        }
        #endregion

        public override void InitModuleEntity()
        {
            base.InitModuleEntity();

            UpdateModuleObjectBindingSource(cstCSCompanysObjectName);
        }
        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(BOSUtil.GetTableNameFromBusinessObjectType(typeof(CSCompanysInfo)), CSCompanysObject);
        }

        public override void InitModuleObjectList()
        {
            ADMatchCodesList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ADMatchCodesInfo)));
            GENumberingsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(GENumberingInfo)));
            ADConfigValuesList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ADConfigValuesInfo)));
        }

        public override void InitGridControlInBOSList()
        {
            ADMatchCodesList.InitBOSListGridControl();
            GENumberingsList.InitBOSListGridControl();
            ADConfigValuesList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ADMatchCodesList.SetDefaultListAndRefreshGridControl();
                GENumberingsList.SetDefaultListAndRefreshGridControl();
                ADConfigValuesList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {

        }

        #endregion
    }
}
