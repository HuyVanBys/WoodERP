using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AdvanceRequest
{
    public class AdvanceRequestEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRAdvanceRequestItemsInfo> AdvanceRequestItemList { get; set; }
        public BOSList<HRAdvanceRequestItemLoanDetailsInfo> HRAdvanceRequestItemLoanDetailsList { get; set; }
        public BOSList<HRAdvanceRequestItemLoanDetailsInfo> BackupAdvanceRequestItemLoanDetailsList { get; set; }
        #endregion

        #region Constructor
        public AdvanceRequestEntities()
            : base()
        {
            AdvanceRequestItemList = new BOSList<HRAdvanceRequestItemsInfo>();
            HRAdvanceRequestItemLoanDetailsList = new BOSList<HRAdvanceRequestItemLoanDetailsInfo>();
            BackupAdvanceRequestItemLoanDetailsList = new BOSList<HRAdvanceRequestItemLoanDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRAdvanceRequestsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRAdvanceRequestItemsTableName, new HRAdvanceRequestItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AdvanceRequestItemList.InitBOSList(
                                            this,
                                            TableName.HRAdvanceRequestsTableName,
                                            TableName.HRAdvanceRequestItemsTableName,
                                            BOSList<HRAdvanceRequestItemsInfo>.cstRelationForeign);
            AdvanceRequestItemList.ItemTableForeignKey = "FK_HRAdvanceRequestID";
            HRAdvanceRequestItemLoanDetailsList.InitBOSList(this,
                                               string.Empty,
                                               TableName.HRAdvanceRequestItemLoanDetailsTableName,
                                               BOSList<HRAdvanceRequestItemLoanDetailsInfo>.cstRelationNone);
            BackupAdvanceRequestItemLoanDetailsList.InitBOSList(this,
                                               string.Empty,
                                               TableName.HRAdvanceRequestItemLoanDetailsTableName,
                                               BOSList<HRAdvanceRequestItemLoanDetailsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            AdvanceRequestItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRAdvanceRequestsInfo advanceRequests = (HRAdvanceRequestsInfo)MainObject;
            advanceRequests.HRAdvanceRequestDate = DateTime.Now;
            advanceRequests.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            advanceRequests.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GECurrencyID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AdvanceRequestItemList.SetDefaultListAndRefreshGridControl();
                HRAdvanceRequestItemLoanDetailsList.SetDefaultListAndRefreshGridControl();
                BackupAdvanceRequestItemLoanDetailsList.SetDefaultListAndRefreshGridControl();
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
            AdvanceRequestItemList.Invalidate(iObjectID);
            HRAdvanceRequestsInfo advanceRequests = (HRAdvanceRequestsInfo)MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            foreach (var item in AdvanceRequestItemList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                    item.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                ADConfigValuesInfo typeDesc = objConfigValuesController.GetObjectByGroupAndValue("AdvanceRequestType", advanceRequests.HRAdvanceRequestType);
                if (typeDesc != null)
                    item.HRAdvanceRequestTypeName = typeDesc.ADConfigText;
            }
            BackupAdvanceRequestItemLoanDetailsList.Clear();
            //Invalidate load detail
            foreach (HRAdvanceRequestItemsInfo item in AdvanceRequestItemList)
            {
                if (item.AdvanceRequestItemLoanDetailsList == null)
                {
                    item.AdvanceRequestItemLoanDetailsList = new BOSList<HRAdvanceRequestItemLoanDetailsInfo>();
                    item.AdvanceRequestItemLoanDetailsList.InitBOSList(
                                                        this,
                                                        TableName.HRAdvanceRequestItemsTableName,
                                                        TableName.HRAdvanceRequestItemLoanDetailsTableName,
                                                        BOSList<HRAdvanceRequestItemLoanDetailsInfo>.cstRelationForeign);
                    item.AdvanceRequestItemLoanDetailsList.ItemTableForeignKey = "FK_HRAdvanceRequestItemID";
                    item.AdvanceRequestItemLoanDetailsList.Invalidate(item.HRAdvanceRequestItemID);
                }
                if (item.AdvanceRequestItemLoanDetailsList != null)
                {
                    foreach (HRAdvanceRequestItemLoanDetailsInfo detail in item.AdvanceRequestItemLoanDetailsList)
                    {
                        BackupAdvanceRequestItemLoanDetailsList.Add((HRAdvanceRequestItemLoanDetailsInfo)detail.Clone());
                    }
                }
            }
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            AdvanceRequestItemList.SaveItemObjects();
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)MainObject;
            HRAdvanceRequestItemLoanDetailsController objARILDsController = new HRAdvanceRequestItemLoanDetailsController();
            List<HRAdvanceRequestItemLoanDetailsInfo> currentItemLoanDetails = new List<HRAdvanceRequestItemLoanDetailsInfo>();
            AdvanceRequestItemList.ForEach(o =>
            {
                if (mainObject.HRAdvanceRequestType != AdvanceRequestType.Loan.ToString())
                {
                    if (o.AdvanceRequestItemLoanDetailsList != null)
                    {
                        o.AdvanceRequestItemLoanDetailsList.Clear();
                    }
                }
                if (o.AdvanceRequestItemLoanDetailsList != null)
                {
                    o.AdvanceRequestItemLoanDetailsList.All(s =>
                    {
                        s.FK_HRAdvanceRequestItemID = o.HRAdvanceRequestItemID;
                        currentItemLoanDetails.Add((HRAdvanceRequestItemLoanDetailsInfo)s.Clone());
                        return true;
                    });
                    o.AdvanceRequestItemLoanDetailsList.SaveItemObjects();
                }
            });

            foreach (HRAdvanceRequestItemLoanDetailsInfo detail in BackupAdvanceRequestItemLoanDetailsList)
            {
                HRAdvanceRequestItemLoanDetailsInfo refDetail = currentItemLoanDetails.FirstOrDefault(s => detail.HRAdvanceRequestItemLoanDetailID > 0 && s.HRAdvanceRequestItemLoanDetailID == detail.HRAdvanceRequestItemLoanDetailID);
                if (refDetail == null)
                    objARILDsController.DeleteObject(detail.HRAdvanceRequestItemLoanDetailID);
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                AdvanceRequestItemList.DeleteItemObjects();
                HRAdvanceRequestItemLoanDetailsList.DeleteItemObjects();
            }
        }

        public void SaveSingleLoanDetail(HRAdvanceRequestItemsInfo objAdvanceRequestItemsInfo)
        {
            HRAdvanceRequestItemsController objAdvanceRequestItemsController = new HRAdvanceRequestItemsController();
            objAdvanceRequestItemsController.UpdateObject(objAdvanceRequestItemsInfo);

            objAdvanceRequestItemsInfo.AdvanceRequestItemLoanDetailsList.All(s =>
            {
                s.FK_HRAdvanceRequestItemID = objAdvanceRequestItemsInfo.HRAdvanceRequestItemID;
                return true;
            });
            objAdvanceRequestItemsInfo.AdvanceRequestItemLoanDetailsList.SaveItemObjects();
            HRAdvanceRequestItemLoanDetailsController objARILDsController = new HRAdvanceRequestItemLoanDetailsController();
            List<HRAdvanceRequestItemLoanDetailsInfo> currentItemLoanDetails = new List<HRAdvanceRequestItemLoanDetailsInfo>();
            AdvanceRequestItemList.ForEach(o =>
            {
                if (o.AdvanceRequestItemLoanDetailsList != null)
                {
                    o.AdvanceRequestItemLoanDetailsList.All(s =>
                    {
                        currentItemLoanDetails.Add((HRAdvanceRequestItemLoanDetailsInfo)s.Clone());
                        return true;
                    });
                }
            });

            foreach (HRAdvanceRequestItemLoanDetailsInfo detail in BackupAdvanceRequestItemLoanDetailsList)
            {
                HRAdvanceRequestItemLoanDetailsInfo refDetail = currentItemLoanDetails.FirstOrDefault(s => detail.HRAdvanceRequestItemLoanDetailID > 0 && s.HRAdvanceRequestItemLoanDetailID == detail.HRAdvanceRequestItemLoanDetailID);
                if (refDetail == null)
                    objARILDsController.DeleteObject(detail.HRAdvanceRequestItemLoanDetailID);
            }
        }
    }
}
