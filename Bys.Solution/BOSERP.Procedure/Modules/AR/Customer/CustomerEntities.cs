using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.Customer
{
    public class CustomerEntities : ERPModuleEntities
    {
        #region Declare Constant
        public readonly static String strARCustomersObjectName = "ARCustomers";

        public readonly static String strARCustomerContactsObjectName = "ARCustomerContacts";
        public const int LenPreFixContinent = 2;
        public const int LenPreFixCountry = 2;
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets history detail list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        public BOSList<ARInvoicesInfo> AROwingInvoicesList { get; set; }

        public BOSList<ARDocumentPaymentsInfo> ARDocumentPaymentsList { get; set; }

        /// <summary>
        /// Gets or sets list of customer contact
        /// </summary>
        public BOSList<ARCustomerContactsInfo> CustomerContactsList { get; set; }


        public BOSList<ARRemindsInfo> ARRemindsList { get; set; }
        /// <summary>
        /// Gets or sets location tree list control
        /// </summary>
        public BOSTreeList LocationTreeList { get; set; }
        public BOSList<ARCustomerInfoContactsInfo> ARCustomerInfoContactList { get; set; }
        #endregion

        #region Constructor
        public CustomerEntities()
            : base()
        {
            AROwingInvoicesList = new BOSList<ARInvoicesInfo>();
            ARDocumentPaymentsList = new BOSList<ARDocumentPaymentsInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();
            CustomerContactsList = new BOSList<ARCustomerContactsInfo>();
            ARRemindsList = new BOSList<ARRemindsInfo>();
            LocationTreeList = new BOSTreeList();
            ARCustomerInfoContactList = new BOSList<ARCustomerInfoContactsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARCustomersInfo();
            SearchObject = new ARCustomersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARCustomerContactsTableName, new ARCustomerContactsInfo());
            ModuleObjects.Add(TableName.GELocationsTableName, new GELocationsInfo());
            ModuleObjects.Add(TableName.ARRemindsTableName, new ARRemindsInfo());
            ModuleObjects.Add(TableName.ARCustomerInfoContactsTableName, new ARCustomerInfoContactsInfo());
        }

        public override void InitModuleObjectList()
        {
            AROwingInvoicesList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARInvoicesInfo)));
            ARDocumentPaymentsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARDocumentPaymentsInfo)));

            HistoryDetailList.InitBOSList(this,
                                           TableName.GEObjectHistoryTableName,
                                           TableName.GEHistoryDetailsTableName,
                                           BOSList<GEHistoryDetailsInfo>.cstRelationForeign);
            CustomerContactsList.InitBOSList(this,
                                                TableName.ARCustomersTableName,
                                                TableName.ARCustomerContactsTableName,
                                                BOSList<ARCustomerContactsInfo>.cstRelationForeign);
            CustomerContactsList.ItemTableForeignKey = "FK_ARCustomerID";

            LocationTreeList.InitBOSList(this,
                                    String.Empty,
                                    TableName.GELocationsTableName,
                                    BOSTreeList.cstRelationNone);

            ARRemindsList.InitBOSList(this,
                                        TableName.ARCustomersTableName,
                                        TableName.ARRemindsTableName,
                                        BOSList<ARRemindsInfo>.cstRelationForeign);
            ARRemindsList.ItemTableForeignKey = "FK_ARCustomerID";
            ARCustomerInfoContactList.InitBOSList(this,
                                                TableName.ARCustomersTableName,
                                                TableName.ARCustomerInfoContactsTableName,
                                                BOSList<ARCustomerInfoContactsInfo>.cstRelationForeign);
            ARCustomerInfoContactList.ItemTableForeignKey = "FK_ARCustomerID";
        }

        public override void InitGridControlInBOSList()
        {
            AROwingInvoicesList.InitBOSListGridControl(CustomerModule.OwingInvoiceGridControlName);
            ARDocumentPaymentsList.InitBOSListGridControl(CustomerModule.PaymentDetailsGridControlName);
            HistoryDetailList.InitBOSListGridControl();
            CustomerContactsList.InitBOSListGridControl(CustomerModule.CustomerContactsGridControlName);
            LocationTreeList.InitBOSTreeListControl();
            ARRemindsList.InitBOSListGridControl(CustomerModule.RemindGridControlName);
            ARCustomerInfoContactList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)MainObject;
            ARRemindsInfo objRemindsInfo = (ARRemindsInfo)ModuleObjects[TableName.ARRemindsTableName];
            objCustomersInfo.ARCustomerTypeCombo = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.CustomerType);
            ARPriceLevelsInfo objPriceLevelsInfo = (ARPriceLevelsInfo)BOSApp.GetFirstObjectFromLookupTable(TableName.ARPriceLevelsTableName);
            if (objPriceLevelsInfo != null)
            {
                objCustomersInfo.FK_ARPriceLevelID = objPriceLevelsInfo.ARPriceLevelID;
            }

            objCustomersInfo.ARPaymentMethodCombo = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.PaymentMethod);
            //objCustomersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objCustomersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCustomersInfo.ARCustomerStatus = CustomerStatus.Sightseeing.ToString();
            objRemindsInfo.ARRemindNo = "***NEW***";
        }

        public override void SetDefaultModuleObjects()
        {
            base.SetDefaultModuleObjects();
            ARRemindsInfo objRemindsInfo = (ARRemindsInfo)ModuleObjects[TableName.ARRemindsTableName];
            objRemindsInfo.ARRemindDate = BOSApp.GetCurrentServerDate();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CustomerContactsList.SetDefaultListAndRefreshGridControl();
                LocationTreeList.SetDefaultListAndRefreshTreeListControl();
                ARRemindsList.SetDefaultListAndRefreshGridControl();
                ARCustomerInfoContactList.SetDefaultListAndRefreshGridControl();
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

            SetPropertyChangeEventLock(false);
            ACObjectsController objectsController = new ACObjectsController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)MainObject;
            objCustomersInfo.ARCustomerOwing = objectsController.GetTotalOwing(objCustomersInfo.ARCustomerID, ObjectType.Customer.ToString());
            objCustomersInfo.ARCustomerAvailableCredit = objCustomersInfo.ARCustomerCreditLimit - objCustomersInfo.ARCustomerOwing;

            ////Get location name
            //GELocationsController objLocationsController = new GELocationsController();
            //objCustomersInfo.GELocationName = objLocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID);
            ////Get location name 1,2,3
            ////Get location name
            //objCustomersInfo.GELocationName1 = objLocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID1);
            //objCustomersInfo.GELocationName2 = objLocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID2);
            //objCustomersInfo.GELocationName3= objLocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID3);
            SetPropertyChangeEventLock(true);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            CustomerContactsList.Invalidate(iObjectID);
            ARRemindsList.Invalidate(iObjectID);
            ARCustomerInfoContactList.Invalidate(iObjectID);
            InvalidateLoacationNames();
            ARCustomerInfoContactList.ForEach(o1 => o1.ACObjectAccessKey = string.Format("{0};{1}", o1.FK_ACObjectID, o1.ARObjectType));
        }
        #endregion

        #region Save Module Objects functions      
        public override int SaveMainObject()
        {
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)MainObject;
            objCustomersInfo.ARCustomerContactAddressLine3 = BOSUtil.GenerateFullAddress(MainObject, AddressType.Contact.ToString());
            objCustomersInfo.ARCustomerInvoiceAddressLine3 = BOSUtil.GenerateFullAddress(MainObject, AddressType.Invoice.ToString());
            objCustomersInfo.ARCustomerDeliveryAddressLine3 = BOSUtil.GenerateFullAddress(MainObject, AddressType.Delivery.ToString());
            objCustomersInfo.ARCustomerPaymentAddressLine3 = BOSUtil.GenerateFullAddress(MainObject, AddressType.Payment.ToString());
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            APSuppliersController objSuppliersController = new APSuppliersController();
            int count = 0;
            foreach (ARCustomerContactsInfo item in CustomerContactsList)
            {
                if (item.ARCustomerContactDefaultAddress)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                MessageBox.Show(CustomerLocalizedResources.ErrorCustomerContactDefaultAddress, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CustomerContactsList.SaveItemObjects();
                ARCustomerInfoContactList.ForEach(a =>
                    {
                        if (a.FK_ACObjectID == 0)
                        {
                            APSuppliersInfo objSuppliersInfo = new APSuppliersInfo();
                            objSuppliersInfo.APSupplierContactAddressLine1 = a.ARCustomerInfoContactSupplierAddress;
                            objSuppliersInfo.APSupplierName = a.ARCustomerInfoContactSupplierName;
                            objSuppliersInfo.APSupplierContactPhone = a.ARCustomerInfoContactSupplierPhone;
                            objSuppliersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                            string supplierNo = string.Empty;
                            GENumberingController objNumberingController = new GENumberingController();
                            GENumberingInfo objNumberingInfo = objNumberingController.GetGENumberingByNameAndBranchID(ModuleName.Supplier, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            if (objNumberingInfo != null)
                            {
                                BOSDbUtil dbUtil = new BOSDbUtil();
                                DateTime currentDate = BOSApp.GetCurrentServerDate();
                                if (objNumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                                    objNumberingInfo.GENumberingStart = 1;
                                supplierNo = String.Format("{0}{1}.{2}",
                                                                objNumberingInfo.GENumberingPrefix,
                                                                currentDate.Year.ToString().Substring(2, 2),
                                                                objNumberingInfo.GENumberingStart.ToString().PadLeft(objNumberingInfo.GENumberingLength, '0'));
                                objNumberingInfo.GENumberingStart += 1;
                                objNumberingInfo.AAUpdatedDate = currentDate;
                                objNumberingController.UpdateObject(objNumberingInfo);
                            }
                            objSuppliersInfo.APSupplierNo = supplierNo;
                            a.FK_ACObjectID = objSuppliersController.CreateObject(objSuppliersInfo);
                            a.ARObjectType = ObjectType.Supplier.ToString();
                            a.ACObjectAccessKey = string.Format("{0};{1}", a.FK_ACObjectID, a.ARObjectType);
                        }
                    });
                ARCustomerInfoContactList.SaveItemObjects();
            }

            ARRemindsList.SaveItemObjects();
        }

        public override void AfterSaveTransaction()
        {
            base.AfterSaveTransaction();
            BOSApp.InitAccountingObjects();
        }
        #endregion

        public override void DuplicateModuleObjectList()
        {
            CustomerContactsList.Duplicate();
        }

        /// <summary>
        /// Take payment for all owing invoices
        /// </summary>
        public void TakePayment()
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    decimal totalPaymentAmount = 0;
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    foreach (ARInvoicesInfo objInvoicesInfo in AROwingInvoicesList)
                    {
                        if (objInvoicesInfo.ARInvoicePaymentAmount > 0)
                        {
                            if (objInvoicesInfo.ARInvoicePaymentAmount > objInvoicesInfo.ARInvoiceBalanceDue)
                            {
                                objInvoicesInfo.ARInvoicePaymentAmount = objInvoicesInfo.ARInvoiceBalanceDue;
                                totalPaymentAmount += objInvoicesInfo.ARInvoicePaymentAmount;
                            }
                            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
                            AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                            AROpenDocumentsInfo objOpenDocumentsInfo = objOpenDocumentsController.GetOpenDocumentByInvoiceID(objInvoicesInfo.ARInvoiceID);
                            CustomerPayment.CustomerPaymentModule.TakePayment(objOpenDocumentsInfo, objInvoicesInfo.ARInvoicePaymentAmount);

                            //Update invoice balance due
                            objInvoicesInfo.ARInvoiceDepositBalance += objInvoicesInfo.ARInvoicePaymentAmount;
                            objInvoicesInfo.ARInvoiceBalanceDue -= objInvoicesInfo.ARInvoicePaymentAmount;
                            objInvoicesController.UpdateObject(objInvoicesInfo);
                        }
                    }

                    //Update customer owing
                    if (totalPaymentAmount > 0)
                    {
                        ARCustomersController objCustomersController = new ARCustomersController();
                        ARCustomersInfo objCustomersInfo = (ARCustomersInfo)MainObject;
                        objCustomersInfo.ARCustomerOwing -= totalPaymentAmount;
                        objCustomersController.UpdateObject(objCustomersInfo);
                    }

                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }
        public void InvalidateLoacationNames()
        {
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)MainObject;
            GELocationsInfo objGELocationsInfo = new GELocationsInfo();
            GELocationsController objGELocationsController = new GELocationsController();
            objCustomersInfo.GELocationName = objGELocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID);
            objCustomersInfo.GELocationName1 = objGELocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID1);
            objCustomersInfo.GELocationName2 = objGELocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID2);
            objCustomersInfo.GELocationName3 = objGELocationsController.GetFullLocationNameByID(objCustomersInfo.FK_GELocationID3);
            UpdateMainObjectBindingSource();
        }
    }
}
