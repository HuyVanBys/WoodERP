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
        #endregion

        #region Constructor
        public FalseConditionalEntities()
            : base()
        {
            FalseConditionalItemList = new BOSList<MMFalseConditionalItemsInfo>();
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
            foreach (MMFalseConditionalItemsInfo objFalseConditionalItemsInfo in FalseConditionalItemList)
            {
                objFalseConditionalItemsInfo.MMFalseConditionalDetailList = new BOSList<MMFalseConditionalDetailsInfo>();
                objFalseConditionalItemsInfo.MMFalseConditionalDetailList.InitBOSList(this,
                                                                                        TableName.MMFalseConditionalItemsTableName,
                                                                                        TableName.MMFalseConditionalDetailsTableName,
                                                                                        BOSList<ARClearingDetailsInfo>.cstRelationNone);
                objFalseConditionalItemsInfo.MMFalseConditionalDetailList.ItemTableForeignKey = "FK_MMFalseConditionalItemID";

                MMFalseConditionalDetailsController objFalseConditionalDetailsController = new MMFalseConditionalDetailsController();
                List<MMFalseConditionalDetailsInfo> listFalseConditionalDetail = objFalseConditionalDetailsController.GetDetailByFalseConditionalItemID(objFalseConditionalItemsInfo.MMFalseConditionalItemID);
                objFalseConditionalItemsInfo.MMFalseConditionalDetailList.Invalidate(listFalseConditionalDetail);
            }
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            FalseConditionalItemList.SaveItemObjects();
            SaveFalseConditionalDetail(FalseConditionalItemList);
        }
        public override bool CompleteTransaction()
        {
            MMFalseConditionalsInfo mainObject = (MMFalseConditionalsInfo)MainObject;
            //Update the this's status
            mainObject.MMFalseConditionalStatus = UpdatePositionStatus.Approved.ToString();
            UpdateMainObject();
            return true;
        }
        public void SaveFalseConditionalDetail(BOSList<MMFalseConditionalItemsInfo> falseConditionalItemList)
        {
            MMFalseConditionalDetailsController objFalseConditionalDetailsController = new MMFalseConditionalDetailsController();
            if (falseConditionalItemList != null)
            {
                foreach (MMFalseConditionalItemsInfo itemEntity in falseConditionalItemList)
                {
                    if (itemEntity.MMFalseConditionalDetailList != null)
                    {
                        foreach (MMFalseConditionalDetailsInfo objFalseConditionalDetailsInfo in itemEntity.MMFalseConditionalDetailList)
                        {
                            objFalseConditionalDetailsInfo.FK_MMFalseConditionalItemID = itemEntity.MMFalseConditionalItemID;
                            objFalseConditionalDetailsInfo.FK_MMFalseConditionalID = itemEntity.FK_MMFalseConditionalID;
                        }
                        itemEntity.MMFalseConditionalDetailList.SaveItemObjects();
                    }
                }
            }
        }
        #endregion
    }
}
