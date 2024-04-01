using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;

namespace BOSERP.Modules.FalseConditional
{
    public class FalseConditionalEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<MMFalseConditionalItemsInfo> FalseConditionalItemList { get; set; }
        public BOSList<MMFalseConditionalDetailsInfo> FalseConditionalDetailsList { get; set; }
        #endregion

        #region Constructor
        public FalseConditionalEntities()
            : base()
        {
            FalseConditionalItemList = new BOSList<MMFalseConditionalItemsInfo>();
            FalseConditionalDetailsList = new BOSList<MMFalseConditionalDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMFalseConditionalsInfo();
            SearchObject = new MMFalseConditionalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMFalseConditionalsTableName, new MMFalseConditionalsInfo());
            ModuleObjects.Add(TableName.MMFalseConditionalItemsTableName, new MMFalseConditionalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            FalseConditionalItemList.InitBOSList(this,
                                                TableName.MMFalseConditionalsTableName,
                                                TableName.MMFalseConditionalItemsTableName,
                                                BOSList<MMUpdatePositionItemsInfo>.cstRelationForeign);
            FalseConditionalItemList.ItemTableForeignKey = "FK_MMFalseConditionalID";
        }

        public override void InitGridControlInBOSList()
        {
            FalseConditionalItemList.InitBOSListGridControl("fld_dgcMMFalseConditionalItems");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMFalseConditionalsInfo objFalseConditionalsInfo = (MMFalseConditionalsInfo)MainObject;
            objFalseConditionalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objFalseConditionalsInfo.MMFalseConditionalStatus = UpdatePositionStatus.New.ToString();
            objFalseConditionalsInfo.MMFalseConditionalDate = DateTime.Now;
            objFalseConditionalsInfo.MMFalseConditionalPercentNorm = 30M;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                FalseConditionalItemList.SetDefaultListAndRefreshGridControl();
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
            MMFalseConditionalItemsController objFalseConditionalItemsController = new MMFalseConditionalItemsController();
            DataSet ds = (DataSet)objFalseConditionalItemsController.GetItemByFalseConditionalID(iObjectID);
            FalseConditionalItemList.Invalidate(ds);
            FalseConditionalItemList.GridControl?.RefreshDataSource();
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            FalseConditionalItemList.SaveItemObjects();
        }
        public override bool CompleteTransaction()
        {
            MMFalseConditionalsInfo mainObject = (MMFalseConditionalsInfo)MainObject;
            //Update the this's status
            mainObject.MMFalseConditionalStatus = UpdatePositionStatus.Approved.ToString();
            UpdateMainObject();
            return true;
        }
            #endregion
        }
}
