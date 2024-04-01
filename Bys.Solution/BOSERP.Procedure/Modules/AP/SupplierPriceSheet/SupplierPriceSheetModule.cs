using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SupplierPriceSheet
{
    public class SupplierPriceSheetModule : BaseTransactionModule
    {
        #region Constants

        public const string APPriceSheetItemsGridControlName = "fld_dgcAPPriceSheetItemsGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ModuleName = "SupplierPriceSheet";

        public const string ImportFromExcelButtonName = "fld_btnImportFromExcel";
        #endregion

        #region Private properties

        private Workbook WorkBook;

        private Worksheet WorkSheet;

        private Microsoft.Office.Interop.Excel.Application App;

        public BOSButton ImportFromExcelButton;

        #endregion

        #region Public properties
        #endregion
        public SupplierPriceSheetModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new SupplierPriceSheetEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ImportFromExcelButton = (BOSButton)Controls[ImportFromExcelButtonName];
            GetCurrentModuleDataViewPermission();
        }

        public override int ActionSave()
        {
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)CurrentModuleEntity.MainObject;
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsController objPriceSheetsController = new APPriceSheetsController();

            if (entity.PriceSheetItemList.Where(o => o.FK_GECurrencyID == 0).Count() > 0)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ loại tiền tệ !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainObject.APPriceSheetType == PriceSheetType.PlanPriceSheet.ToString())
            {
                List<APPriceSheetsInfo> listPriceSheets = objPriceSheetsController.GetListPriceSheetIsValidated(mainObject.APPriceSheetDateFrom, mainObject.APPriceSheetDateTo, mainObject.APPriceSheetID);
                if (listPriceSheets != null && listPriceSheets.Count > 0)
                {
                    MessageBox.Show("Trong cùng 1 khoản thời gian hiệu lực chỉ có duy nhất một bảng giá kế hoạch", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }    
            }    
            return base.ActionSave();
        }

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

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            APPriceSheetsController objPriceSheetsController = new APPriceSheetsController();
            APPriceSheetsInfo searchObject = (APPriceSheetsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds;
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objPriceSheetsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objPriceSheetsController.GetPriceSheetListByListOfBranchID(searchObject.APPriceSheetNo,
                                                                                        searchObject.APPriceSheetName,
                                                                                        searchObject.FK_HREmployeeID,
                                                                                        searchObject.APPriceSheetDateFrom,
                                                                                        searchObject.APPriceSheetDateTo,
                                                                                        BranchList);
                }
            }
            else
            {
                ds = objPriceSheetsController.GetPriceSheetListByBranchID(searchObject.APPriceSheetNo,
                                                                            searchObject.APPriceSheetName,
                                                                                        searchObject.FK_HREmployeeID,
                                                                            searchObject.APPriceSheetDateFrom,
                                                                            searchObject.APPriceSheetDateTo,
                                                                            searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (mainObject.APPriceSheetID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                if (mainObject.APPriceSheetStatus == PriceSheetStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
                }
                ImportFromExcelButton.Enabled = true;
                if (mainObject.APPriceSheetStatus == PriceSheetStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ImportFromExcelButton.Enabled = false;
                }
            }
            else
            {
                ImportFromExcelButton.Enabled = false;
            }
            if(!Toolbar.IsNullOrNoneAction())
            {
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                if (mainObject.APPriceSheetStatus == PriceSheetStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }    
            }
            if (Toolbar.IsEditAction())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            }
        }

        public void ApprovePriceSheet()
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            entity.Approve();
            InvalidateToolbar();
        }

        public void DeleteItemFromPriceSheetItemList()
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            entity.PriceSheetItemList.RemoveSelectedRowObjectFromList();
        }

        public void AddProductToPriceSheetItemList()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)entity.MainObject;

            string defaultDepartmentNo = BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.ProductNo.ToString());
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(defaultDepartmentNo);
            if (objDepartmentsInfo == null)
                objDepartmentsInfo = new ICDepartmentsInfo();
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> products = objProductsController.GetProductByDepartmentID(objDepartmentsInfo.ICDepartmentID);
            products = products.Where(o => o.ICProductActiveCheck).ToList();
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(products, objDepartmentsInfo.ICDepartmentID);
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            List<ICProductsInfo> results = (List<ICProductsInfo>)guiAddProduct.SelectedObjects;

            entity.GenerateSupplierPriceSheetItems(results);
            entity.PriceSheetItemList.GridControl.RefreshDataSource();
        }

        public override void ActionPrint()
        {
            //base.ActionPrint();
        }

        private string ToString(decimal number)
        {
            if (number == 0)
                return "0";
            return number / Convert.ToInt32(number) != 1 ? number.ToString("N3") : number.ToString("N0");
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public void ChangeItemObject(string objectAccessKey)
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetItemsInfo objPriceSheetItemsInfo = entity.PriceSheetItemList[entity.PriceSheetItemList.CurrentIndex];
            if (objPriceSheetItemsInfo == null)
                return;

            objPriceSheetItemsInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController controller = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = controller.GetObjectByAccessKey(objectAccessKey);
            if (objObjectsInfo == null)
            {
                objPriceSheetItemsInfo.FK_ACObjectID = 0;
                objPriceSheetItemsInfo.APObjectType = string.Empty;
            }
            else
            {
                objPriceSheetItemsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objPriceSheetItemsInfo.APObjectType = objObjectsInfo.ACObjectType;
            }

            entity.PriceSheetItemList.GridControl.RefreshDataSource();
        }

        public void ChangeItemCurrency(int currencyID)
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetItemsInfo objPriceSheetItemsInfo = entity.PriceSheetItemList[entity.PriceSheetItemList.CurrentIndex];
            if (objPriceSheetItemsInfo == null)
                return;

            objPriceSheetItemsInfo.FK_GECurrencyID = currencyID;
            entity.PriceSheetItemList.GridControl.RefreshDataSource();
        }

        public void ChangeCurrency(int currencyID)
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencyID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.PriceSheetItemList.Count > 0)
                {
                    if (MessageBox.Show("Bạn có muốn thay đổi loại tiền tệ cho tất cả sản phẩm không?",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entity.PriceSheetItemList.ForEach(o1 => o1.FK_GECurrencyID = currencyID);
                        entity.PriceSheetItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        public void ChangeObject(string objectAccessKey)
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)entity.MainObject;
            mainObject.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                if (!Toolbar.IsNullOrNoneAction())
                {
                    mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                    mainObject.APObjectType = objObjectsInfo.ACObjectType;
                    if (entity.PriceSheetItemList.Count > 0)
                    {
                        if (MessageBox.Show("Bạn có muốn thay đổi đối tượng cho tất cả sản phẩm không?",
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            entity.PriceSheetItemList.ForEach(o1 =>
                            {
                                o1.FK_ACObjectID = objObjectsInfo.ACObjectID;
                                o1.APObjectType = objObjectsInfo.ACObjectType;
                                o1.ACObjectAccessKey = objectAccessKey;
                            });
                            entity.PriceSheetItemList.GridControl.RefreshDataSource();
                        }
                    }
                }
            }
        }

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();

            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)entity.MainObject;
            mainObject.APPriceSheetStatus = PriceSheetStatus.New.ToString();
            mainObject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainObject.FK_HRApprovedEmployeeID = 0;
            mainObject.APPriceSheetDate = BOSApp.GetCurrentServerDate();
            mainObject.APPriceSheetBeginDate = BOSApp.GetCurrentServerDate();
            mainObject.APPriceSheetEndDate = BOSApp.GetCurrentServerDate().AddMonths(1);
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            entity.UpdateMainObjectBindingSource();
        }

        public override bool ActionCancelComplete()
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)entity.MainObject;
            if (mainObject.APPriceSheetID > 0)
            {
                mainObject.APPriceSheetStatus = PriceSheetStatus.New.ToString();
                entity.UpdateMainObject();
                InvalidateToolbar();
            }
            return true;
        }

        #region Export Import Excel
        public void ExportSupplierPriceSheetTemplate()
        {
            try
            {
                SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
                APPriceSheetsInfo mainObject = (APPriceSheetsInfo)entity.MainObject;
                ACObjectsInfo objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == mainObject.FK_ACObjectID && o.ACObjectType == mainObject.APObjectType);

                guiExportSupplierPriceSheetProcess process = new guiExportSupplierPriceSheetProcess(entity.PriceSheetItemList, mainObject.APPriceSheetBeginDate, mainObject.APPriceSheetEndDate, objectsInfo != null ? objectsInfo.ACObjectName : string.Empty); ;
                process.ShowDialog();
                if (File.Exists(process.FilePath))
                {
                    Process.Start(process.FilePath);
                }
            }
            catch (Exception ex)
            {
                BOSProgressBar.Close();
                MessageBox.Show(ex.ToString()
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
        }

        public void ImportSupplierPriceSheet()
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsInfo mainobject = (APPriceSheetsInfo)entity.MainObject;

            if (!Toolbar.IsNullOrNoneAction() && mainobject.APPriceSheetID == 0)
                return;

            List<Range> ranges = InitializeDataImport();
            if (ranges == null)
                return;

            if (ranges.Count() <= 0)
            {
                MessageBox.Show(SupplierPriceSheetLocalizedResources.TeamplateMalformed, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(ImportDataLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);

            Range woods = ranges[0];

            ImportSupplierPriceSheetItem(woods);

            BOSProgressBar.Close();
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

        private void ImportSupplierPriceSheetItem(Range range)
        {
            if (range == null)
                return;

            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)CurrentModuleEntity;
            APPriceSheetsInfo mainobject = (APPriceSheetsInfo)entity.MainObject;



            List<APPriceSheetItemsImportInfo> importInfoList = new List<APPriceSheetItemsImportInfo>();
            APPriceSheetItemsImportInfo objSupplierPriceSheetItemsImportInfo = new APPriceSheetItemsImportInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            for (int row = 4; row <= range.Rows.Count; row++)
            {
                objSupplierPriceSheetItemsImportInfo = new APPriceSheetItemsImportInfo();
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportProductNo = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                if (string.IsNullOrEmpty(objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportProductNo))
                    continue;

                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportProductNoOfOldSys = (range.Cells[row, 3] as Range).Text.ToString().Trim();
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportProductSupplierNo = (range.Cells[row, 4] as Range).Text.ToString().Trim();
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportProductName = (range.Cells[row, 5] as Range).Text.ToString().Trim();
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportProductDesc = (range.Cells[row, 6] as Range).Text.ToString().Trim();
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportMeasureUnitName = (range.Cells[row, 9] as Range).Text.ToString().Trim();

                cellValue = (range.Cells[row, 10] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportUnitPrice = value;

                value = 0;
                cellValue = (range.Cells[row, 12] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemsImportPrice = value;

                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemImportSupplierNo = (range.Cells[row, 13] as Range).Text.ToString().Trim();
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemImportSupplierName = (range.Cells[row, 14] as Range).Text.ToString().Trim();
                objSupplierPriceSheetItemsImportInfo.APPriceSheetItemImportCurrencyName = (range.Cells[row, 15] as Range).Text.ToString().Trim();
                importInfoList.Add(objSupplierPriceSheetItemsImportInfo);
            }

            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();

            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objectList = objObjectsController.GetObjectViewPermissionByModule(this.Name);
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();

            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            List<GECurrenciesInfo> currencieList = objCurrenciesController.GetAllCurrencys();
            GECurrenciesInfo objCurrenciesInfo = new GECurrenciesInfo();


            APPriceSheetItemsController objSupplierPriceSheetItemsController = new APPriceSheetItemsController();
            List<APPriceSheetItemsInfo> PriceSheetItemList = new List<APPriceSheetItemsInfo>();
            APPriceSheetItemsInfo objSupplierPriceSheetItemsInfo = new APPriceSheetItemsInfo();

            importInfoList.ForEach(o =>
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByNo(o.APPriceSheetItemsImportProductNo);
                if (objProductsInfo == null)
                    return;
                objMeasureUnitsInfo = measureUnitList.Where(o1 => o1.ICMeasureUnitName == o.APPriceSheetItemsImportMeasureUnitName).FirstOrDefault();
                //if (objMeasureUnitsInfo == null)
                //    return;
                objObjectsInfo = objectList.Where(p => p.ACObjectNo == o.APPriceSheetItemImportSupplierNo).FirstOrDefault();
                if (objObjectsInfo == null)
                    return;
                objCurrenciesInfo = currencieList.Where(p => p.GECurrencyName == o.APPriceSheetItemImportCurrencyName).FirstOrDefault();
                if (objCurrenciesInfo == null)
                    return;

                objSupplierPriceSheetItemsInfo = new APPriceSheetItemsInfo()
                {
                    FK_ICProductID = objProductsInfo.ICProductID,
                    AACreatedUser = BOSApp.CurrentUser,
                    FK_APPriceSheetID = mainobject.APPriceSheetID,
                    APPriceSheetItemProductName = objProductsInfo.ICProductName,
                    APPriceSheetItemProductDesc = objProductsInfo.ICProductDesc,
                    APPriceSheetItemBasicPrice = o.APPriceSheetItemsImportUnitPrice,
                    APPriceSheetItemPrice = o.APPriceSheetItemsImportPrice,
                    APPriceSheetItemQty = 1,
                    FK_ICMeasureUnitID = objMeasureUnitsInfo != null ? objMeasureUnitsInfo.ICMeasureUnitID : 0,
                    FK_ACObjectID = objObjectsInfo.ACObjectID,
                    APObjectType = objObjectsInfo.ACObjectType,
                    ACObjectAccessKey = string.Format("{0};{1}", objObjectsInfo.ACObjectID.ToString(), objObjectsInfo.ACObjectType.ToString()),
                    FK_GECurrencyID = objCurrenciesInfo.GECurrencyID
                };
                objSupplierPriceSheetItemsController.CreateObject(objSupplierPriceSheetItemsInfo);
                PriceSheetItemList.Add(objSupplierPriceSheetItemsInfo);
            });

            entity.PriceSheetItemList.AddRange(PriceSheetItemList);
            entity.PriceSheetItemList.GridControl.RefreshDataSource();
        }
        #endregion
    }
}
