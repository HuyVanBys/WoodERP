using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.BalanceAmountArising
{
    class BalanceAmountArisingEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACBalanceAmountArisingDetailsInfo> BalanceAmountArisingDetailsList { get; set; }
        public BOSList<ACBalanceAmountArisingObjectDetailsInfo> BalanceAmountArisingObjectDetailsList { get; set; }
        public BOSList<ACAccountDetailsInfo> AccountDetailsList { get; set; }

        #endregion

        #region Constructor
        public BalanceAmountArisingEntities()
            : base()
        {
            BalanceAmountArisingDetailsList = new BOSList<ACBalanceAmountArisingDetailsInfo>();
            BalanceAmountArisingObjectDetailsList = new BOSList<ACBalanceAmountArisingObjectDetailsInfo>();
            AccountDetailsList = new BOSList<ACAccountDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACBalanceAmountArisingsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ACBalanceAmountArisingDetails", new ACBalanceAmountArisingDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            BalanceAmountArisingDetailsList.InitBOSList(
                                            this,
                                            "ACBalanceAmountArisings",
                                            "ACBalanceAmountArisingDetails",
                                            BOSList<ACBalanceAmountArisingDetailsInfo>.cstRelationForeign);
            BalanceAmountArisingDetailsList.ItemTableForeignKey = "FK_ACBalanceAmountArisingID";

            BalanceAmountArisingObjectDetailsList.InitBOSList(
                                            this,
                                            "ACBalanceAmountArisings",
                                            "ACBalanceAmountArisingObjectDetails",
                                            BOSList<ACBalanceAmountArisingObjectDetailsInfo>.cstRelationForeign);
            BalanceAmountArisingObjectDetailsList.ItemTableForeignKey = "FK_ACBalanceAmountArisingID";

            AccountDetailsList.InitBOSList(
                                            this,
                                            "",
                                            "ACAccountDetails",
                                            BOSList<ACAccountDetailsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            BalanceAmountArisingDetailsList.InitBOSListGridControl();
            BalanceAmountArisingObjectDetailsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BalanceAmountArisingDetailsList.SetDefaultListAndRefreshGridControl();
                BalanceAmountArisingObjectDetailsList.SetDefaultListAndRefreshGridControl();
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
            BalanceAmountArisingDetailsList.Invalidate(iObjectID);
            ACBalanceAmountArisingObjectDetailsController objBalanceAmountArisingObjectDetailsController = new ACBalanceAmountArisingObjectDetailsController();
            List<ACBalanceAmountArisingObjectDetailsInfo> ObjectDetailsList = objBalanceAmountArisingObjectDetailsController.GetBalanceAmountArisingObjectDetailByParentID(iObjectID);
            BalanceAmountArisingObjectDetailsList.Invalidate(ObjectDetailsList);

        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ACBalanceAmountArisingObjectDetailsController objBalanceAmountArisingObjectDetailsController = new ACBalanceAmountArisingObjectDetailsController();
            ACBalanceAmountArisingDetailsController objBalanceAmountArisingDetailsController = new ACBalanceAmountArisingDetailsController();

            ACBalanceAmountArisingsInfo mainObject = (ACBalanceAmountArisingsInfo)MainObject;
            if (mainObject.ACBalanceAmountArisingID > 0)
            {
                objBalanceAmountArisingObjectDetailsController.DeleteByForeignColumn("FK_ACBalanceAmountArisingID", mainObject.ACBalanceAmountArisingID);
                objBalanceAmountArisingDetailsController.DeleteByForeignColumn("FK_ACBalanceAmountArisingID", mainObject.ACBalanceAmountArisingID);
            }
            BalanceAmountArisingDetailsList.SaveItemObjects();
            BalanceAmountArisingObjectDetailsList.SaveItemObjects();
        }
        #endregion

        public void SaveBalanceObject()
        {
            // Delete Old object balance
            ACAccountDetailsController objAccountDetailsController = new ACAccountDetailsController();
            List<string> accountID = AccountDetailsList.Select(o => o.FK_ACAccountID.ToString()).Distinct().ToList();
            ACBalanceAmountArisingsInfo mainObject = (ACBalanceAmountArisingsInfo)MainObject;
            if (accountID != null)
            {
                objAccountDetailsController.DeleteOldObjectBalanceByAcountIDAndDate(string.Join(",", accountID.ToArray()), mainObject.ACBalanceAmountArisingToDate.Date, mainObject.FK_BRBranchID);
            }
            AccountDetailsList.SaveItemObjects();
        }
    }
}
