using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;

namespace BOSERP.Modules.ConversionProposal
{
    public class ConversionProposalEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSList<ICConversionProposalItemsInfo> ConversionProposalItemList { get; set; }
        public BOSList<ICConversionProposalItemVMsInfo> TotalConversionProposalItemList { get; set; }
        #endregion

        #region Constructor
        public ConversionProposalEntities() : base()
        {
            ConversionProposalItemList = new BOSList<ICConversionProposalItemsInfo>();
            TotalConversionProposalItemList = new BOSList<ICConversionProposalItemVMsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICConversionProposalsInfo();
            SearchObject = new ICConversionProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICConversionProposalItemsTableName, new ICConversionProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ConversionProposalItemList.InitBOSList(this,
                                                    TableName.ICConversionProposalsTableName,
                                                    TableName.ICConversionProposalItemsTableName,
                                                    BOSList<ICConversionProposalItemsInfo>.cstRelationForeign);
            ConversionProposalItemList.ItemTableForeignKey = "FK_ICConversionProposalID";
            TotalConversionProposalItemList.InitBOSList(this,
                                                    TableName.ICConversionProposalsTableName,
                                                    TableName.ICConversionProposalItemsTableName,
                                                    BOSList<ICConversionProposalItemsInfo>.cstRelationForeign);
            TotalConversionProposalItemList.ItemTableForeignKey = "FK_ICConversionProposalID";
        }

        public override void InitGridControlInBOSList()
        {
            ConversionProposalItemList.InitBOSListGridControl(ConversionProposalModule.ConversionProposalItemsGridControlName);
            TotalConversionProposalItemList.InitBOSListGridControl(ConversionProposalModule.ConversionProposalItemsGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICConversionProposalsInfo mainObject = (ICConversionProposalsInfo)MainObject;
            mainObject.ICConversionProposalStatus = ConversionProposalStatus.New.ToString();
            mainObject.ICConversionProposalDate = BOSApp.GetCurrentServerDate();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ConversionProposalItemList.SetDefaultListAndRefreshGridControl();
                TotalConversionProposalItemList.SetDefaultListAndRefreshGridControl();
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
            ICConversionProposalItemsController objConversionProposalItemsController = new ICConversionProposalItemsController();
            List<ICConversionProposalItemsInfo> listConversionProposalItemsInfo = objConversionProposalItemsController.GetListConversionProposalItemByConversionProposalID(iObjectID);
            ConversionProposalItemList.Invalidate(listConversionProposalItemsInfo);
            List<ICConversionProposalItemVMsInfo> totalConversionProposalItemsList = GenerateTotalConversionProposals(listConversionProposalItemsInfo);
            TotalConversionProposalItemList.Invalidate(totalConversionProposalItemsList);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ConversionProposalItemList.SaveItemObjects();
        }
        #endregion

        #region Complete - CancelComplete
        public override bool CompleteTransaction()
        {
            bool result = base.CompleteTransaction();
            if (result)
            {
                ICConversionProposalsInfo mainObject = (ICConversionProposalsInfo)MainObject;
                mainObject.ICConversionProposalStatus = ConversionProposalStatus.Completed.ToString();
                UpdateMainObject();
            }
            return result;
        }

        public override bool CancelCompleteTransaction()
        {
            ICConversionProposalsInfo mainObject = (ICConversionProposalsInfo)MainObject;
            mainObject.ICConversionProposalStatus = ConversionProposalStatus.New.ToString();
            UpdateMainObject();
            return true;
        }
        #endregion
        public List<ICConversionProposalItemVMsInfo> GenerateTotalConversionProposals (IList<ICConversionProposalItemsInfo> conversionProposalList)
        {
            ICConversionProposalsInfo mainObject = (ICConversionProposalsInfo)MainObject;
            List<ICConversionProposalItemVMsInfo> totalList = new List<ICConversionProposalItemVMsInfo>();
            totalList = conversionProposalList.GroupBy(o => new
            {
                o.FK_ICProductID,
                o.FK_ICStockID,
                o.FK_ICMeasureUnitID,
                o.FK_ICProductSerieID,
                o.ICConversionProposalItemProductName,
                o.ICConversionProposalItemProductDesc,
                o.ICConversionProposalItemProductSerialNo,
                o.ICConversionProposalItemProductLotNo,
                o.ICConversionProposalItemProductLength,
                o.ICConversionProposalItemProductWidth,
                o.ICConversionProposalItemProductHeight,
                o.ICConversionProposalItemComment,
                IsBelongPlan = o.FK_MMAllocationPlanItemID > 0 ? true : false,
            }).Select(o => new ICConversionProposalItemVMsInfo()
            {
                FK_ICProductID = o.Key.FK_ICProductID,
                FK_ICStockID = o.Key.FK_ICStockID,
                FK_ICMeasureUnitID = o.Key.FK_ICMeasureUnitID,
                FK_ICProductSerieID = o.Key.FK_ICProductSerieID,
                ICConversionProposalItemProductName = o.Key.ICConversionProposalItemProductName,
                ICConversionProposalItemProductDesc = o.Key.ICConversionProposalItemProductDesc,
                ICConversionProposalItemProductSerialNo = o.Key.ICConversionProposalItemProductSerialNo,
                ICConversionProposalItemProductLotNo = o.Key.ICConversionProposalItemProductLotNo,
                ICConversionProposalItemProductLength = o.Key.ICConversionProposalItemProductLength,
                ICConversionProposalItemProductWidth = o.Key.ICConversionProposalItemProductWidth,
                ICConversionProposalItemProductHeight = o.Key.ICConversionProposalItemProductHeight,
                ICConversionProposalItemComment = o.Key.ICConversionProposalItemComment,
                ICConversionProposalItemProductQty = o.Sum(p => p.ICConversionProposalItemProductQty),
                ICConversionProposalItemWoodQty = o.Sum(p => p.ICConversionProposalItemWoodQty),
                ICConversionProposalItemRef = string.Join(",", o.Where(item => item.ICConversionProposalItemID > 0).Select(item => item.ICConversionProposalItemID.ToString()).ToArray()),
                MMAllocationPlanItemRef = o.Key.IsBelongPlan ? string.Join(",", o.Where(item => item.FK_MMAllocationPlanItemID > 0).Select(item => item.FK_MMAllocationPlanItemID.ToString()).ToArray()) : string.Empty
            }).ToList();
            return totalList;
        }
    }
}


