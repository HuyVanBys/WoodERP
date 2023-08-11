using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.CustomerPaymentProposal
{
    public class CustomerPaymentProposalEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion
        #region Declare all entities variables
        #endregion
        #region Public Properties
        public BOSList<ARPaymentProposalItemsInfo> PaymentProposalItemsList { get; set; }

        public BOSList<ARSaleOrderPaymentTimeTemplatesInfo> SaleOrderPaymentTimeTemplateList { get; set; }
        #endregion
        #region Constructor
        public CustomerPaymentProposalEntities()
            : base()
        {
            PaymentProposalItemsList = new BOSList<ARPaymentProposalItemsInfo>();
            SaleOrderPaymentTimeTemplateList = new BOSList<ARSaleOrderPaymentTimeTemplatesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARPaymentProposalsInfo();
            SearchObject = new ARPaymentProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APPaymentProposalItemsTableName, new ARPaymentProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            PaymentProposalItemsList.InitBOSList(this,
                                             TableName.ARPaymentProposalsTableName,
                                             TableName.ARPaymentProposalItemsTableName,
                                             BOSList<ARInvoiceItemsInfo>.cstRelationForeign);
            PaymentProposalItemsList.ItemTableForeignKey = "FK_ARPaymentProposalID";

            SaleOrderPaymentTimeTemplateList.InitBOSList(this,
                                                         null,
                                                         TableName.ARSaleOrderPaymentTimeTemplatesTableName,
                                                         BOSList<ARSaleOrderPaymentTimeTemplatesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            PaymentProposalItemsList.InitBOSListGridControl();
            SaleOrderPaymentTimeTemplateList.InitBOSListGridControl("fld_dgcSaleOrderPaymentTimeTemplatesGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PaymentProposalItemsList.SetDefaultListAndRefreshGridControl();
                SaleOrderPaymentTimeTemplateList.SetDefaultListAndRefreshGridControl();
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

            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)MainObject;
            objPaymentProposalsInfo.ARPaymentProposalDate = BOSApp.GetCurrentServerDate();
            objPaymentProposalsInfo.ARPaymentProposalPayDate = BOSApp.GetCurrentServerDate();
            objPaymentProposalsInfo.ARPaymentProposalTotalAmount = 0;
            objPaymentProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objPaymentProposalsInfo.ARPaymentProposalDesc = "Thu tiền {0} {1}";
            //objPaymentProposalsInfo.ARPaymentProposalStatusCombo = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.PaymentProposalStatus);
            //objPaymentProposalsInfo.ARPaymentProposalTypeCombo = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.PaymentProposalType);
            //objPaymentProposalsInfo.ARPriority = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.Priority);
            //objPaymentProposalsInfo.ARPaymentProposalPaymentMethodCombo = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.PaymentProposalPaymentMethod);
            objPaymentProposalsInfo.FK_HREmployeeReceipt = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objPaymentProposalsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;

            if (BOSApp.CurrentUsersInfo.FK_HREmployeeID > 0)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    objPaymentProposalsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                    objPaymentProposalsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
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
            PaymentProposalItemsList.Invalidate(iObjectID);
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            if (PaymentProposalItemsList.Count > 0)
            {
                foreach (ARPaymentProposalItemsInfo item in PaymentProposalItemsList)
                {
                    if (item.ARPaymentProposalItemType == PaymentProposalItemType.InvoiceIn.ToString())
                    {
                        ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(item.FK_ARInvoiceID);
                        if (objInvoicesInfo != null)
                        {
                            //                            item.ARInvoiceSupplierNo = objInvoicesInfo.ARInvoiceInSupplierNo;
                            item.ARSaleOrderPaymentTimeDueDate = objInvoicesInfo.ARInvoiceValidateDate;
                        }
                    }
                    else
                    {
                        ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();
                        ARSaleOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo = (ARSaleOrderPaymentTimesInfo)objSaleOrderPaymentTimesController.GetObjectByID(item.FK_ARSaleOrderPaymentTimeID);
                        if (objPurchaseOrderPaymentTimesInfo != null)
                        {
                            item.ARSaleOrderPaymentTimeDueDate = objPurchaseOrderPaymentTimesInfo.ARSaleOrderPaymentTimeDueDate;

                        }
                    }
                }
            }
            ARSaleOrderPaymentTimeTemplatesController objSaleOrderPaymentTimeTemplatesController = new ARSaleOrderPaymentTimeTemplatesController();
            List<ARSaleOrderPaymentTimeTemplatesInfo> soPaymentTimeList = objSaleOrderPaymentTimeTemplatesController.GetSOPaymentTimeTemplateByPaymentProposalID(iObjectID);
            SaleOrderPaymentTimeTemplateList.Invalidate(soPaymentTimeList);
        }

        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            PaymentProposalItemsList.SaveItemObjects();
        }
        #endregion


        public override bool CompleteTransaction()
        {
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)MainObject;
            if (objPaymentProposalsInfo.ARPaymentProposalStatusCombo == PaymentProposalStatus.New.ToString())
            {
                objPaymentProposalsInfo.ARPaymentProposalStatusCombo = PaymentProposalStatus.Confirmed.ToString();
            }
            UpdateMainObject();

            return true;
        }

        public void GenerateCustomerFromProspectCustomer(ARProspectCustomersInfo objProspectCustomersInfo)
        {
            ARCustomersInfo objCustomersInfo = new ARCustomersInfo();
            List<string> item = new List<string>();
            objCustomersInfo.ARCustomerContactFirstName = objProspectCustomersInfo.ARProspectCustomerFirstName;
            objCustomersInfo.ARCustomerContactLastName = objProspectCustomersInfo.ARProspectCustomerLastName;
            objCustomersInfo.ARCustomerActiveCheck = true;
            objCustomersInfo.IsBuyingLocked = false;
            objCustomersInfo.ARCustomerContactCellPhone = objProspectCustomersInfo.ARProspectCustomerCellPhone;
            objCustomersInfo.ARCustomerWebsite = objProspectCustomersInfo.ARProspectCustomerWebsite;
            objCustomersInfo.ARCustomerCRMType = CustomerCRMType.Customer.ToString();
            objCustomersInfo.ARCustomerContactPhone = objProspectCustomersInfo.ARProspectCustomerTel;
            if (!string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerLastName) && !string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerFirstName))
            {
                objCustomersInfo.ARCustomerName = string.Format("{0}{1}{2}", objProspectCustomersInfo.ARProspectCustomerLastName, " ",
                                                                                    objProspectCustomersInfo.ARProspectCustomerFirstName);
            }
            else if (!string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerCompany))
            {
                objCustomersInfo.ARCustomerName = objProspectCustomersInfo.ARProspectCustomerCompany;
            }
            objCustomersInfo.FK_BRBranchID = objProspectCustomersInfo.FK_BRBranchID;
            if (objProspectCustomersInfo.ARProspectCustomerAddress != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddress);
            }
            if (objProspectCustomersInfo.ARProspectCustomerAddressDistrict != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddressDistrict);
            }
            if (objProspectCustomersInfo.ARProspectCustomerAddressCity != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddressCity);
            }
            if (objProspectCustomersInfo.ARProspectCustomerAddressCountry != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddressCountry);
            }
            objCustomersInfo.ARCustomerPaymentAddressLine1 = string.Join(", ", item.Where(o => !string.IsNullOrEmpty(o)).ToArray());
            objCustomersInfo.ARCustomerInvoiceAddressLine1 = objCustomersInfo.ARCustomerPaymentAddressLine1;
            objCustomersInfo.ARCustomerDeliveryAddressLine1 = objCustomersInfo.ARCustomerPaymentAddressLine1;
            objCustomersInfo.ARCustomerContactAddressLine1 = objCustomersInfo.ARCustomerPaymentAddressLine1;
            objCustomersInfo.ARCustomerBusiness = objProspectCustomersInfo.ARProspectCustomerBusiness;
            objCustomersInfo.FK_ARProspectCustomerID = objProspectCustomersInfo.ARProspectCustomerID;
            objCustomersInfo.ARCustomerLunarBirthday = objProspectCustomersInfo.ARProspectCustomerLunarBirthday;
            objCustomersInfo.ARCustomerContactBirthday = objProspectCustomersInfo.ARProspectCustomerBirthday;
            objCustomersInfo.ARCustomerContactEmail1 = objProspectCustomersInfo.ARProspectCustomerEmail;
            objCustomersInfo.ARCustomerSex = objProspectCustomersInfo.ARProspectCustomerGender;
            objCustomersInfo.ARCustomerContactAddressDistrict = objProspectCustomersInfo.ARProspectCustomerAddressDistrict;
            objCustomersInfo.ARCustomerContactAddressCity = objProspectCustomersInfo.ARProspectCustomerAddressCity;
            objCustomersInfo.ARCustomerContactAddressCountry = objProspectCustomersInfo.ARProspectCustomerAddressCountry;
            objCustomersInfo.ARGender = objProspectCustomersInfo.ARProspectCustomerGender;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)MainObject;
            objPaymentProposalsInfo.CustomersInfo = objCustomersInfo;
        }
    }
}
