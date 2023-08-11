using System;
using BOSLib;
using BOSCommon;
using System.Linq;
using BOSCommon.Constants;
using System.Collections.Generic;

namespace BOSERP.Modules.PaymentProposal
{
    public class PaymentProposalEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSList<APPaymentProposalItemsInfo> PaymentProposalItemsList { get; set; }
        public BOSList<APFileAttachmentsInfo> PaymentProposalTemplateList { get; set; }
        public Dictionary<int, string> PaymentProposalTemplateURLDic { get; set; }
        #endregion

        #region Constructor
        public PaymentProposalEntities() : base()
        {
            PaymentProposalItemsList = new BOSList<APPaymentProposalItemsInfo>();
            PaymentProposalTemplateList = new BOSList<APFileAttachmentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APPaymentProposalsInfo();
            SearchObject = new APPaymentProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APPaymentProposalItemsTableName, new APPaymentProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            PaymentProposalItemsList.InitBOSList(this,
                                                TableName.APPaymentProposalsTableName,
                                                TableName.APPaymentProposalItemsTableName,
                                                BOSList<APInvoiceInItemsInfo>.cstRelationForeign);
            PaymentProposalItemsList.ItemTableForeignKey = "FK_APPaymentProposalID";

            PaymentProposalTemplateList.InitBOSList(this,
                                                    TableName.APPaymentProposalsTableName,
                                                    TableName.APFileAttachmentsTableName,
                                                    BOSList<APFileAttachmentsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            PaymentProposalItemsList.InitBOSListGridControl();
            PaymentProposalTemplateList.InitBOSListGridControl(PaymentProposalModule.PaymentProposalTemplateGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PaymentProposalItemsList.SetDefaultListAndRefreshGridControl();
                PaymentProposalTemplateList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Module Objects functions
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HREmployeesController objEmployeesController = new HREmployeesController();

            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)MainObject;
            mainObject.APPaymentProposalDate = BOSApp.GetCurrentServerDate();
            mainObject.APPaymentProposalPayDate = BOSApp.GetCurrentServerDate();
            mainObject.APPaymentProposalTotalAmount = 0;
            mainObject.APPaymentProposalApproveStatus = ApproveStatus.NeedApprove;
            mainObject.APPaymentProposalStatusCombo = PaymentProposalStatus.New.ToString();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;

            if (BOSApp.CurrentUsersInfo.FK_HREmployeeID > 0)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    mainObject.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                    mainObject.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                }
            }
        }
        #endregion

        #region Invalidate MainObject and ModuleObjects Functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)MainObject;
            APPaymentProposalItemsController objPaymentProposalItemsController = new APPaymentProposalItemsController();
            List<APPaymentProposalItemsInfo> listPaymentProposalItemsInfo = objPaymentProposalItemsController.GetPaymentProposalItemFromTransactionByPaymentProposalID(iObjectID);
            PaymentProposalItemsList.Invalidate(listPaymentProposalItemsInfo);

            APFileAttachmentsController objFileAttachmentsController = new APFileAttachmentsController();
            List<APFileAttachmentsInfo> fileAttachmentList = objFileAttachmentsController.GetFileAttachmentByModuleAndObjectRef(this.Module.Name, BOSUtil.GetTableNameFromBusinessObject(mainObject), mainObject.APPaymentProposalID, 0);
            PaymentProposalTemplateList.Invalidate(fileAttachmentList);
        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            PaymentProposalItemsList.SaveItemObjects();
            PaymentProposalTemplateList.SaveItemObjects();
            PaymentProposalTemplateURLDic = PaymentProposalTemplateList.ToDictionary(o => o.APFileAttachmentID, o => o.FullPathFile);
        }
        #endregion

        #region Complete - CancelComplete
        public override bool CompleteTransaction()
        {
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)MainObject;
            if (objPaymentProposalsInfo.APPaymentProposalStatusCombo == PaymentProposalStatus.New.ToString())
            {
                objPaymentProposalsInfo.APPaymentProposalStatusCombo = PaymentProposalStatus.Confirmed.ToString();
            }
            UpdateMainObject();

            return true;
        }

        public override bool CancelCompleteTransaction()
        {
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)MainObject;
            objPaymentProposalsInfo.APPaymentProposalStatusCombo = PaymentProposalStatus.New.ToString();
            objPaymentProposalsInfo.APPaymentProposalApproveStatus = ApproveStatus.NeedApprove;
            SaveMainObject();
            return true;
        }
        #endregion

        public void UpdateTotalAmount()
        {
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)MainObject;
            decimal totalAmount = 0, paidAmount = 0, remainAmount = 0, taxAmount = 0;
            foreach (APPaymentProposalItemsInfo item in PaymentProposalItemsList)
            {
                totalAmount += item.APPaymentProposalItemProposalAmount;
                taxAmount += item.APPaymentProposalItemTaxAmount;
                paidAmount += item.APPaymentProposalItemPaidAmount;
                remainAmount += item.APPaymentProposalItemRemainAmount;
                BOSApp.RoundByCurrency(item, "APPaymentProposalItemDiscountFix", mainObject.FK_GECurrencyID);
            }
            mainObject.APPaymentProposalTotalAmount = totalAmount;
            mainObject.APPaymentProposalPaidAmount = paidAmount;
            mainObject.APPaymentProposalRemainAmount = remainAmount;
            BOSApp.RoundByCurrency(mainObject, mainObject.FK_GECurrencyID);
            mainObject.APPaymentProposalDiscountFix = totalAmount - taxAmount != 0 ? mainObject.APPaymentProposalDiscountPercent * (totalAmount - taxAmount) / 100 : 0;
            BOSApp.RoundByCurrency(mainObject, "APPaymentProposalDiscountFix", mainObject.FK_GECurrencyID);

            //tính chênh lệch tiền chiết khấu thanh toán giữa chiết khấu tổng và item
            if(PaymentProposalItemsList != null && PaymentProposalItemsList.Count > 0)
            {
                decimal chenhlech = mainObject.APPaymentProposalDiscountFix - PaymentProposalItemsList.Sum(o => o.APPaymentProposalItemDiscountFix);
                if(chenhlech != 0)
                {
                    decimal gtriPhanbo = 0;
                    PaymentProposalItemsList.ForEach(item =>
                    {
                        if (item.APPaymentProposalItemDiscountFix >= Math.Abs(chenhlech) && chenhlech !=0)
                        {
                            gtriPhanbo = Math.Min(item.APPaymentProposalItemDiscountFix, Math.Abs(chenhlech));
                            item.APPaymentProposalItemDiscountFix += chenhlech;
                            chenhlech = gtriPhanbo - Math.Abs(chenhlech);
                        }
                    });
                    PaymentProposalItemsList.GridControl?.RefreshDataSource();
                }    
            }

            mainObject.APPaymentProposalTotalPaymentAmount = mainObject.APPaymentProposalTotalAmount - mainObject.APPaymentProposalDiscountFix;
            BOSApp.RoundByCurrency(mainObject, "APPaymentProposalTotalPaymentAmount", mainObject.FK_GECurrencyID);
            BOSApp.RoundByCurrency(mainObject, mainObject.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }    
    }
}
