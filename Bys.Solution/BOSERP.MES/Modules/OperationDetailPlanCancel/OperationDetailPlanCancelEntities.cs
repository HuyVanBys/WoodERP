using BOSCommon;
using System;

namespace BOSERP.Modules.OperationDetailPlanCancel
{
    class OperationDetailPlanCancelEntities : ERPModuleEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the batch product item list
        /// </summary>
        public BOSList<MMOperationDetailPlanCancelItemsInfo> OperationDetailPlanCancelItemList { get; set; }



        #endregion
        #region Contructors
        public OperationDetailPlanCancelEntities()
            : base()
        {
            OperationDetailPlanCancelItemList = new BOSList<MMOperationDetailPlanCancelItemsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMOperationDetailPlanCancelsInfo();
            SearchObject = new MMOperationDetailPlanCancelsInfo();

        }



        public override void InitModuleObjects()
        {
            ModuleObjects.Add("MMOperationDetailPlanCancelItems", new MMOperationDetailPlanCancelItemsInfo());

        }

        public override void InitModuleObjectList()
        {
            OperationDetailPlanCancelItemList.InitBOSList(
                                        this,
                                        "MMOperationDetailPlanCancels",
                                        "MMOperationDetailPlanCancelItems",
                                        BOSList<MMOperationDetailPlanCancelItemsInfo>.cstRelationForeign);
            OperationDetailPlanCancelItemList.ItemTableForeignKey = "FK_MMOperationDetailPlanCancelID";

        }
        public override void InitGridControlInBOSList()
        {
            OperationDetailPlanCancelItemList.InitBOSListGridControl();

        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMOperationDetailPlanCancelsInfo objOperationDetailPlanCancelsInfo = (MMOperationDetailPlanCancelsInfo)MainObject;
            objOperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelDate = DateTime.Now;
            objOperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelStatus = OperationDetailPlanCancelStatus.New.ToString();
            objOperationDetailPlanCancelsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objOperationDetailPlanCancelsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override bool CompleteTransaction()
        {
            MMOperationDetailPlanCancelsInfo OperationDetailPlanCancelsInfo = (MMOperationDetailPlanCancelsInfo)MainObject;
            if (OperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelStatus == OperationDetailPlanCancelStatus.New.ToString())
            {
                OperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelStatus = OperationDetailPlanCancelStatus.Complete.ToString();
                OperationDetailPlanCancelsInfo.FK_HREmployeeIDApproved = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                OperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelApprovedDate = DateTime.Now;
                UpdateMainObject();
            }
            return true;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                OperationDetailPlanCancelItemList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Override BaseTransactionEntities


        public override void InvalidateModuleObjects(int iObjectID)
        {
            OperationDetailPlanCancelItemList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            OperationDetailPlanCancelItemList.SaveItemObjects();

        }


        #endregion

    }
}
