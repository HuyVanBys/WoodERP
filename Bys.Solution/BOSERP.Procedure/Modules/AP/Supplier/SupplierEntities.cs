using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Transactions;

namespace BOSERP.Modules.Supplier
{
    public class SupplierEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<APInvoiceInsInfo> OwingInvoiceList { get; set; }

        public BOSList<APDocumentPaymentsInfo> DocumentPaymentList { get; set; }

        /// <summary>
        /// Gets or sets list of supplier contact
        /// </summary>
        public BOSList<APSupplierContactsInfo> SupplierContactsList { get; set; }

        //NHAnh
        public BOSList<APSupplierDepartmentsInfo> SupplierDepartmentList { get; set; }

        #endregion

        #region Constructor
        public SupplierEntities()
            : base()
        {
            OwingInvoiceList = new BOSList<APInvoiceInsInfo>();
            DocumentPaymentList = new BOSList<APDocumentPaymentsInfo>();
            SupplierContactsList = new BOSList<APSupplierContactsInfo>();
            SupplierDepartmentList = new BOSList<APSupplierDepartmentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APSuppliersInfo();
            SearchObject = new APSuppliersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APSupplierContactsTableName, new APSupplierContactsInfo());
            ModuleObjects.Add(TableName.APSupplierDepartmentTableName, new APSupplierDepartmentsInfo());
        }

        public override void InitModuleObjectList()
        {
            OwingInvoiceList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(APInvoiceInsInfo)));
            DocumentPaymentList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(APDocumentPaymentsInfo)));
            SupplierContactsList.InitBOSList(this,
                                                TableName.APSuppliersTableName,
                                                TableName.APSupplierContactsTableName,
                                                BOSList<APSupplierContactsInfo>.cstRelationForeign);
            SupplierDepartmentList.InitBOSList(this,
                                                TableName.APSuppliersTableName,
                                                TableName.APSupplierDepartmentTableName,
                                                BOSList<APSupplierDepartmentsInfo>.cstRelationForeign);
            SupplierDepartmentList.ItemTableForeignKey = "FK_APSupplierID";

        }

        public override void InitGridControlInBOSList()
        {
            OwingInvoiceList.InitBOSListGridControl(SupplierModule.cstOwingInvoiceGridControlName);
            DocumentPaymentList.InitBOSListGridControl(SupplierModule.cstPaymentDetailsGridControlName);
            SupplierContactsList.InitBOSListGridControl(SupplierModule.SupplierContactsGridControlName);
            SupplierDepartmentList.InitBOSListGridControl(SupplierModule.SupplierDepartmentControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                SupplierContactsList.SetDefaultListAndRefreshGridControl();
                OwingInvoiceList.SetDefaultListAndRefreshGridControl();
                DocumentPaymentList.SetDefaultListAndRefreshGridControl();
                SupplierContactsList.SetDefaultListAndRefreshGridControl();
                SupplierDepartmentList.SetDefaultListAndRefreshGridControl();
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
            SupplierContactsList.Invalidate(iObjectID);
            SupplierDepartmentList.Invalidate(iObjectID);
            //SupplierDepartmentList.GridControl.RefreshDataSource();
        }


        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APSuppliersInfo supplier = (APSuppliersInfo)MainObject;
            supplier.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            GECountrysController objCountrysController = new GECountrysController();
            GECountrysInfo objCountrysInfo = (GECountrysInfo)objCountrysController.GetDefaultCountry();
            supplier.FK_GECountryID = objCountrysInfo != null ? objCountrysInfo.GECountryID : 1;
            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            GEStateProvincesInfo objGEStateProvinceAddnewInfo = new GEStateProvincesInfo();
            DataSet dsStateProvince;
            dsStateProvince = objGEStateProvincesController.GetAllDataByForeignColumn("FK_GECountryID", supplier.FK_GECountryID);
            List<GEStateProvincesInfo> provincesList = (List<GEStateProvincesInfo>)objGEStateProvincesController.GetListFromDataSet(dsStateProvince);
            if (provincesList.Count > 0)
            {
                supplier.FK_GEStateProvinceID = provincesList[0].GEStateProvinceID;
            }
        }

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)MainObject;
            objSuppliersInfo.APSupplierContactAddressLine3 = BOSUtil.GenerateFullAddress(objSuppliersInfo, AddressType.Contact.ToString());
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            SupplierContactsList.SaveItemObjects();
            SupplierDepartmentList.SaveItemObjects();
        }

        public override void AfterSaveTransaction()
        {
            base.AfterSaveTransaction();
            BOSApp.InitAccountingObjects();
        }
        #endregion

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
                    APInvoiceInsController objInvoicesController = new APInvoiceInsController();
                    foreach (APInvoiceInsInfo objInvoicesInfo in OwingInvoiceList)
                    {
                        if (objInvoicesInfo.APInvoiceInPaymentAmount > 0)
                        {
                            if (objInvoicesInfo.APInvoiceInPaymentAmount > objInvoicesInfo.APInvoiceInBalanceDue)
                            {
                                objInvoicesInfo.APInvoiceInPaymentAmount = objInvoicesInfo.APInvoiceInBalanceDue;
                                totalPaymentAmount += objInvoicesInfo.APInvoiceInPaymentAmount;
                            }
                            APDocumentPaymentsController objDocumentPaymentsController = new APDocumentPaymentsController();
                            APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
                            APOpenDocumentsInfo objOpenDocumentsInfo = objOpenDocumentsController.GetOpenDocumentByInvoiceInID(objInvoicesInfo.APInvoiceInID);
                            SupplierPayment.SupplierPaymentModule.TakePayment(objOpenDocumentsInfo, objInvoicesInfo.APInvoiceInPaymentAmount);

                            //Update invoice balance due
                            objInvoicesInfo.APInvoiceInDepositBalance += objInvoicesInfo.APInvoiceInPaymentAmount;
                            objInvoicesInfo.APInvoiceInBalanceDue -= objInvoicesInfo.APInvoiceInPaymentAmount;
                            objInvoicesController.UpdateObject(objInvoicesInfo);
                        }
                    }

                    //Update supplier owing
                    if (totalPaymentAmount > 0)
                    {
                        APSuppliersController objSuppliersController = new APSuppliersController();
                        APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)MainObject;
                        objSuppliersInfo.APSupplierOwing -= totalPaymentAmount;
                        objSuppliersController.UpdateObject(objSuppliersInfo);
                    }

                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }
    }
}
