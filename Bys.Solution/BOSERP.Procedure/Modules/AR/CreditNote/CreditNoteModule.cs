using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Extensions.Helper;
using BOSComponent;
using BOSERP.Modules.AR.CreditNote.Localization;
using BOSLib;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CreditNote
{
    public class CreditNoteModule : BaseTransactionModule
    {
        #region Constant for CreditNote
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        private Workbook WorkBook;

        private Worksheet WorkSheet;

        private Microsoft.Office.Interop.Excel.Application App;

        public BOSButton ImportFromExcelButton;

        public CreditNoteModule()
        {
            Name = "CreditNote";
            CurrentModuleEntity = new CreditNoteEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            //Disable lookupedit if user is an employee
            ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)CurrentModuleEntity.MainObject;
            if (BOSApp.CurrentUsersInfo.FK_HREmployeeID > 0)
            {
                objCreditNotesInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                foreach (Control ctrl in Controls.Values)
                    if (!String.IsNullOrEmpty(ctrl.AccessibleName) && ctrl.AccessibleName.Contains("FK_HREmployeeID"))
                    {
                        (ctrl as BOSComponent.BOSLookupEdit).EditValue = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                        ctrl.Enabled = false;
                    }

                //Show picture
                HREmployeesInfo objHREmployeesInfo = (HREmployeesInfo)new HREmployeesController().GetObjectByID(Convert.ToInt32(BOSApp.CurrentUsersInfo.FK_HREmployeeID));
                if (objHREmployeesInfo != null)
                {
                    objCreditNotesInfo.ARCreditNoteEmployeePicture = objHREmployeesInfo.HREmployeePicture;
                    CurrentModuleEntity.UpdateMainObjectBindingSource();
                }
            }

            DisplayLabelText(objCreditNotesInfo);

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CreditNoteModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START       
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARCreditNotesController creditNoteController = new ARCreditNotesController();
            ARCreditNotesInfo searchObject = (ARCreditNotesInfo)CurrentModuleEntity.SearchObject;
            //NUThao [ADD] [08/04/2014] [DB centre]earchObject.ARInvoiceSOContactPhone);
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = creditNoteController.GetDataSetByID(-1);
                }
                else
                {
                    ds = creditNoteController.GetCreditNoteListByListOfBranchID(
                                                                        searchObject.ARCreditNoteNo,
                                                                        searchObject.FK_ACObjectID,
                                                                        searchObject.ARObjectType,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.ARCreditNoteType,
                                                                        searchObject.CreditNoteDateFrom,
                                                                        searchObject.CreditNoteDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = creditNoteController.GetCreditNoteList(searchObject.ARCreditNoteNo,
                                                            searchObject.FK_ACObjectID,
                                                            searchObject.ARObjectType,
                                                            searchObject.FK_HREmployeeID,
                                                            searchObject.ARCreditNoteType,
                                                            searchObject.CreditNoteDateFrom,
                                                            searchObject.CreditNoteDateTo,
                                                            searchObject.FK_BRBranchID);
            }

            return ds;

        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

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

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            CreditNoteEntities entity = (CreditNoteEntities)CurrentModuleEntity;
            ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)entity.MainObject;
            objCreditNotesInfo.ARCreditNoteRemainedAmount = objCreditNotesInfo.ARCreditNoteTotalAmount - objCreditNotesInfo.ARCreditNoteDueAmount;
            //set picture
            HREmployeesInfo objHREmployeesInfo = (HREmployeesInfo)new HREmployeesController().GetObjectByID(objCreditNotesInfo.FK_HREmployeeID);
            if (objHREmployeesInfo != null)
            {
                ((ARCreditNotesInfo)CurrentModuleEntity.MainObject).ARCreditNoteEmployeePicture = objHREmployeesInfo.HREmployeePicture;
            }
            DisplayLabelText(objCreditNotesInfo);
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ExportGiftVoucherTemplate()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string filePath = System.Windows.Forms.Application.StartupPath + @"\Template\GiftVouchers.xlsx";
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);
                // bind dữ liệu
                //ExportExcelInvoice(guiSearchInvoice.SelectedInvoiceItemList, worksheet, 1, "A", "AE");

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = @"Tệp Excel (*.xls)|*.xls|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = @"GiftVouchers.xls";
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fullFileName = saveDialog.FileName;

                    WorkBook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    WorkBook.Saved = true;

                }
                ReleaseDataImport();
                BOSProgressBar.Close();
            }
            catch (Exception ex)
            {
                ReleaseDataImport();
                BOSProgressBar.Close();
                MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReleaseDataImport()
        {
            WorkBook.Close(false, null, null);
            App.Quit();
            ReleaseObject(WorkSheet);
            ReleaseObject(WorkBook);
            ReleaseObject(App);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public void ImportGiftVoucher()
        {
            if (!Toolbar.IsNullOrNoneAction())
                return;

            List<Range> ranges = InitializeDataImport();
            if (ranges == null)
                return;

            if (ranges.Count() != 1)
            {
                MessageBox.Show(PriceSheetLocalizedResources.TeamplateMalformed, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(ImportDataLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);

            try
            {
                Range woods = ranges[0];
                ImportGiftVoucher(woods);
                BOSProgressBar.Close();
                MessageBox.Show(CreditNoteLocalizedResources.ImportSuccessMesage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                BOSProgressBar.Close();
                MessageBox.Show(CreditNoteLocalizedResources.ImportErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Range> InitializeDataImport()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ImportDataLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
                filePath = dialog.FileName;

            if (!String.IsNullOrEmpty(filePath))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                List<Range> result = new List<Range>();
                for (int i = 1; i <= WorkBook.Worksheets.Count; i++)
                {
                    WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(i);
                    Range range = WorkSheet.UsedRange;
                    result.Add(range);
                }
                return result;
            }
            return null;
        }

        private void ImportGiftVoucher(Range range)
        {
            if (range == null)
                return;

            List<ARCreditNoteImportsInfo> importInfoList = new List<ARCreditNoteImportsInfo>();
            ARCreditNoteImportsInfo objCreditNoteImportsInfo = new ARCreditNoteImportsInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            DateTime timeValue = BOSApp.GetCurrentServerDate();
            for (int row = 4; row <= range.Rows.Count; row++)
            {
                objCreditNoteImportsInfo = new ARCreditNoteImportsInfo();
                objCreditNoteImportsInfo.ARCreditNoteImportNo = (range.Cells[row, 2] as Range).Text.ToString().Trim();

                if (string.IsNullOrEmpty(objCreditNoteImportsInfo.ARCreditNoteImportNo))
                    continue;

                cellValue = (range.Cells[row, 3] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                DateTime.TryParse(cellValue, out timeValue);
                objCreditNoteImportsInfo.ARCreditNoteImportDate = timeValue;

                timeValue = BOSApp.GetCurrentServerDate();
                cellValue = (range.Cells[row, 4] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                DateTime.TryParse(cellValue, out timeValue);
                objCreditNoteImportsInfo.ARCreditNoteImportExpiryDate = timeValue;

                cellValue = (range.Cells[row, 5] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                if (value == 0)
                    continue;
                objCreditNoteImportsInfo.ARCreditNoteImportTotalAmount = value;

                cellValue = (range.Cells[row, 6] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                objCreditNoteImportsInfo.ARCreditNoteImportConditionAmount = value;

                cellValue = (range.Cells[row, 7] as Range).Text.ToString().Trim();
                objCreditNoteImportsInfo.ARCreditNoteImportType = CreditNoteType.CreditNote.ToString();
                if (StringHelper.ConvertUnicodeStringToUnSign(cellValue) != CreditNoteType.CreditNote.ToString())
                    objCreditNoteImportsInfo.ARCreditNoteImportType = CreditNoteType.GiftVoucher.ToString();

                objCreditNoteImportsInfo.ARCreditNoteImportDesc = (range.Cells[row, 8] as Range).Text.ToString().Trim();
                importInfoList.Add(objCreditNoteImportsInfo);
            }
            List<string> duplicateCreditNoteNoList = new List<string>();
            ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
            ARCreditNotesInfo objCreditNotesInfo = new ARCreditNotesInfo();
            List<ARCreditNotesInfo> creditNoteList = new List<ARCreditNotesInfo>();
            importInfoList.ForEach(o =>
            {
                objCreditNotesInfo = (ARCreditNotesInfo)objCreditNotesController.GetObjectByNo(o.ARCreditNoteImportNo);
                if (objCreditNotesInfo != null)
                {
                    duplicateCreditNoteNoList.Add(objCreditNotesInfo.ARCreditNoteNo);
                    return;
                }

                objCreditNotesInfo = new ARCreditNotesInfo();
                objCreditNotesInfo = ToCreditNoteFromImport(o);
                creditNoteList.Add(objCreditNotesInfo);
            });

            if (duplicateCreditNoteNoList.Count() > 0)
            {
                DialogResult rs = MessageBox.Show(string.Format(CreditNoteLocalizedResources.ImportErrorDuplicateNo, string.Join(", ", duplicateCreditNoteNoList.ToArray()))
                                                  , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.Yes)
                {
                    return;
                }
            }
            creditNoteList.ForEach(o =>
            {
                objCreditNotesController.CreateObject(o);
            });
            Search();
        }

        public ARCreditNotesInfo ToCreditNoteFromImport(ARCreditNoteImportsInfo objCreditNoteImportsInfo)
        {
            return new ARCreditNotesInfo()
            {
                ARCreditNoteNo = objCreditNoteImportsInfo.ARCreditNoteImportNo,
                AACreatedUser = BOSApp.CurrentUser,
                ARCreditNoteDate = objCreditNoteImportsInfo.ARCreditNoteImportDate,
                ARCreditNoteExpiryDate = objCreditNoteImportsInfo.ARCreditNoteImportExpiryDate,
                ARCreditNoteTotalAmount = objCreditNoteImportsInfo.ARCreditNoteImportTotalAmount,
                ARCreditNoteDesc = objCreditNoteImportsInfo.ARCreditNoteImportDesc,
                ARCreditNoteType = objCreditNoteImportsInfo.ARCreditNoteImportType,
                ARCreditNoteCondition = objCreditNoteImportsInfo.ARCreditNoteImportConditionAmount,
                FK_HREmployeeID = BOSApp.CurrentUsersInfo == null ? 0 : BOSApp.CurrentUsersInfo.FK_HREmployeeID,
                FK_BRBranchID = BOSApp.CurrentCompanyInfo == null ? 0 : BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                IsTransferred = false
            };
        }
    }
}
