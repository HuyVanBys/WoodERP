using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HRShowSocialInsuranceDeclaration
{
    public class HRShowSocialInsuranceDeclarationEntities : ERPModuleEntities
    {
        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the leave day list corresponding with the currrent
        /// search criteria
        /// </summary>
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        public BOSList<HRSocialInsuranceDeclarationsInfo> SocialInsuranceDeclarationList { get; set; }
        #endregion

        #region Constructor
        public HRShowSocialInsuranceDeclarationEntities()
            : base()
        {
            EmployeeList = new BOSList<HREmployeesInfo>(this, string.Empty, TableName.HREmployeesTableName);
            SocialInsuranceDeclarationList = new BOSList<HRSocialInsuranceDeclarationsInfo>(this, string.Empty, TableName.HRSocialInsuranceDeclarationsTableName);
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
        }

        public override void InitModuleObjects()
        {
        }

        public override void InitModuleObjectList()
        {

        }

        public override void InitGridControlInBOSList()
        {
            EmployeeList.InitBOSListGridControl("fld_dgcHREmployees");
            SocialInsuranceDeclarationList.InitBOSListGridControl("fld_dgcHRSocialInsuranceDeclarations");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {

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
            EmployeeList.Invalidate(iObjectID);
            SocialInsuranceDeclarationList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {

        }
        #endregion                
    }
}
