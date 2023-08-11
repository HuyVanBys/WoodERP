using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSReport;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Document
{
    public class DocumentModule : BaseTransactionModule
    {
        #region Constants
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion
        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion
        // bool clearingDebts = false;
        #region Constructor
        public DocumentModule()
        {
            Name = "Document";
            CurrentModuleEntity = new DocumentEntities();
            CurrentModuleEntity.Module = this;

            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        }
        #endregion
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //DataSet ds = objDocumentsController.GetDocumentList(searchObject.ACDocumentNo,
            //                                                    AccDocumentType.NghiepVuKhac.ToString(),
            //                                                    objObjectsInfo.ACObjectID,
            //                                                    objObjectsInfo.ACObjectType,
            //                                                    searchObject.FK_HREmployeeID,
            //                                                    searchObject.DocumentDateFrom,
            //                                                    searchObject.DocumentDateTo);
            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDocumentsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objDocumentsController.GetDocumentListByListOfBranchID1(searchObject.ACDocumentNo,
                                                                searchObject.FK_ACDocumentTypeID,
                                                                objObjectsInfo.ACObjectID,
                                                                objObjectsInfo.ACObjectType,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.DocumentDateFrom,
                                                                searchObject.DocumentDateTo,
                                                                searchObject.FK_BRBranchID,
                                                                BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetDocumentListByBranchID1(searchObject.ACDocumentNo,
                                                                searchObject.FK_ACDocumentTypeID,
                                                                objObjectsInfo.ACObjectID,
                                                                objObjectsInfo.ACObjectType,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.DocumentDateFrom,
                                                                searchObject.DocumentDateTo,
                                                                searchObject.FK_BRBranchID);
            }
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END


            return ds;
        }

        public override int GetDocumentTypeID()
        {
            DocumentEntities entity = (DocumentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            int documentTypeID;
            if (mainObject.ACDocumentID == 0)
            {
                ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.NghiepVuKhac.ToString());
            }
            else
                documentTypeID = mainObject.FK_ACDocumentTypeID;
            return documentTypeID;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintDocument(Toolbar.CurrentObjectID);
            }
        }

        /// <summary>
        /// Print the report of a common document
        /// </summary>
        /// <param name="documentID">Document id</param>
        public static void PrintDocument(int documentID)
        {
            RPDocument report = new RPDocument();
            InitDocumentReport(report, documentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        public static void PrintDocumentA5(int documentID)
        {
            RPDocumentA5 report = new RPDocumentA5();
            InitDocumentReportA5(report, documentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        /// <summary>
        /// Init a report of common accounting document
        /// </summary>
        /// <param name="report">Given report</param>
        /// <param name="documentID">Document id</param>
        private static void InitDocumentReport(RPDocument report, int documentID)
        {
            //Set current branch info
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            List<ACDocumentEntrysInfo> entries = objReportsController.GetEntriesByDocumentID(documentID);
            report.DataSource = entries;
        }

        private static void InitDocumentReportA5(RPDocumentA5 report, int documentID)
        {
            //Set current branch info
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            List<ACDocumentEntrysInfo> entries = objReportsController.GetEntriesByDocumentID(documentID);
            /*for (int i = 0; i < entries.Count; i++ )
            {
                ACDocumentEntrysInfo entry = entries[i];
                if (Convert.ToInt32(entry.ACDocumentEntryAmount) == 0)
                {
                    entries.RemoveAt(i);
                }
            }*/
            report.DataSource = entries;

            //Set employee name
            XRLabel employeeNameLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblEmployeeName"];
            HREmployeesController objEmployessController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployessController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                employeeNameLabel.Text = objEmployeesInfo.HREmployeeName;
            }
            ACDocumentsInfo objDocumentsInfo = new ACDocumentsInfo();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetObjectByID(documentID);

            //XRLabel xr_lblTotalAmount = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrTableCell19"];
            if (objDocumentsInfo != null)
            {
                XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblReadAmount"];
                if (amountWordTop != null)
                    amountWordTop.Text = ConvertAmountToWord.ReadAmount(objDocumentsInfo.ACDocumentTotalAmount.ToString(), objDocumentsInfo.FK_GECurrencyID);
            }
        }

        public void ChangeFK_ACObjectID(string FK_ACObjectID)
        {
            DocumentEntities entity = (DocumentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            ACObjectsController objObjectsController = new ACObjectsController();
            objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(FK_ACObjectID);
            if (objObjectsInfo != null)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                mainObject.ACDocumentObjectTaxNumber = objDocumentsController.GetTaxNumber(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                //entity.UpdateMainObject();
                entity.UpdateMainObjectBindingSource();
            }
        }
        public void ChangeCurrency(int currencyID)
        {
            DocumentEntities entity = (DocumentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;

            mainObject.FK_GECurrencyID = currencyID;
            mainObject.ACDocumentExchangeAmount = 0;
            mainObject.ACDocumentTotalAmount = 0;
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", currencyID);

                mainObject.ACDocumentExchangeAmount += entry.ACDocumentEntryExchangeAmount;
                mainObject.ACDocumentTotalAmount += entry.ACDocumentEntryAmount;
            }

            BOSApp.RoundByCurrency(mainObject, "ACDocumentExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(mainObject, "ACDocumentTotalAmount", currencyID);

            entity.DocumentEntryList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();

        }

        public override int ActionSave()
        {
            DocumentEntities entity = (DocumentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (string.IsNullOrEmpty(mainObject.ACObjectAccessKey))
            {
                MessageBox.Show("Vui lòng chọn đối tượng.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            bool allowSave = true;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByID(mainObject.FK_ACDocumentTypeID);
            if (objDocumentTypesInfo != null)
            {
                if (objDocumentTypesInfo.ACDocumentTypeName != DocumentTypeName.BuTroCongNo.ToString())
                {
                    foreach (ACDocumentEntrysInfo item in entity.DocumentEntryList)
                    {
                        ACAccountsController objAccountsController = new ACAccountsController();
                        List<ACAccountsInfo> accountsList = (List<ACAccountsInfo>)objAccountsController.IsAccountOrChildOfAccount(item.FK_ACDebitAccountID, AccAccount.Acc331.ToString());
                        if (accountsList != null && accountsList.Count > 0)
                        {
                            allowSave = false;
                        }
                    }
                    //if (allowSave == false)
                    //{
                    //    MessageBox.Show("Không được phép chọn tài khoản 331.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return 0;
                    //}

                    foreach (ACDocumentEntrysInfo item in entity.DocumentEntryList)
                    {
                        ACAccountsController objAccountsController = new ACAccountsController();
                        List<ACAccountsInfo> accountsList = (List<ACAccountsInfo>)objAccountsController.IsAccountOrChildOfAccount(item.FK_ACCreditAccountID, AccAccount.Acc131.ToString());
                        if (accountsList != null && accountsList.Count > 0)
                        {
                            allowSave = false;
                        }
                    }
                    //if (allowSave == false)
                    //{
                    //    MessageBox.Show("Không được phép chọn tài khoản 131.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return 0;
                    //}
                }
            }

            int documentID = base.ActionSave();

            //Update ngay lai cho tat ca cac chung tu lien quan
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            objDocumentsController.UpdateReferenceFromDocument(mainObject.ACDocumentNo, mainObject.ACDocumentDate);


            return documentID;

        }
        public void ActionNewClearingDebts()
        {
            base.ActionNew();
            DocumentEntities entity = (DocumentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = objDocumentTypesController.GetDocumentTypeByDocumentTypeName(DocumentTypeName.BuTroCongNo.ToString());
            if (objDocumentTypesInfo != null)
            {
                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
            }
            //clearingDebts = true;
        }

        public void UpdateAccountDebitDocumentEntrys(ACDocumentEntrysInfo objDocumentEntrysInfo)
        {
            DocumentEntities entity = (DocumentEntities)CurrentModuleEntity;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(objDocumentEntrysInfo.FK_ACUnfinishedConstructionCostID);
            objDocumentEntrysInfo.FK_ACDebitAccountID = objUnfinishedConstructionCostsInfo.FK_ACAccountID;
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
    }
}
