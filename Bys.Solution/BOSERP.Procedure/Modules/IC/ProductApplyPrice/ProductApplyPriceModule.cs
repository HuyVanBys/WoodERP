using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductApplyPrice
{
    public class ProductApplyPriceModule : BaseTransactionModule
    {
        #region Constants

        public const string ICProductApplyPriceItemsGridControlName = "fld_dgcICProductApplyPriceItemsGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ModuleName = "ProductApplyPrice";

        public const string ImportFromExcelButtonName = "fld_btnImportFromExcel";
        #endregion

        #region Private properties

        private Workbook WorkBook;

        private Worksheet WorkSheet;

        private Microsoft.Office.Interop.Excel.Application App;

        public BOSButton ImportFromExcelButton;

        #endregion

        #region Public properties

        public BOSLookupEdit SearchBranchLookupEditControl;

        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;

        public List<BRBranchsInfo> BranchList;

        public bool IsEditAfterCompleting = false;

        #endregion
        public ProductApplyPriceModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new ProductApplyPriceEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[ProductApplyPriceModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            ImportFromExcelButton = (BOSButton)Controls[ProductApplyPriceModule.ImportFromExcelButtonName];
        }

        public override int ActionSave()
        {
            int id = base.ActionSave();
            if (IsEditAfterCompleting)
                ActionApprove();
            IsEditAfterCompleting = false;
            return id;
        }

        public override void ActionCancel()
        {
            base.ActionCancel();
            IsEditAfterCompleting = false;
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

        public override void InvalidateToolbar()
        {
            ICProductApplyPricesInfo mainObject = (ICProductApplyPricesInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("ValidateProductApplyPrice", false);
            ParentScreen.SetEnableOfToolbarButton("ApproveProductApplyPrice", false);
            ImportFromExcelButton.Enabled = false;
            if (mainObject.ICProductApplyPriceID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("ValidateProductApplyPrice", true);
                ParentScreen.SetEnableOfToolbarButton("ApproveProductApplyPrice", true);
                ImportFromExcelButton.Enabled = false;
                if (mainObject.ICProductApplyPriceStatus == ProductApplyPriceStatus.Verified.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("ValidateProductApplyPrice", false);
                }
                else if (mainObject.ICProductApplyPriceStatus == ProductApplyPriceStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("ValidateProductApplyPrice", false);
                    ParentScreen.SetEnableOfToolbarButton("ApproveProductApplyPrice", false);
                }
            }
            base.InvalidateToolbar();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ImportFromExcelButton.Enabled = false;
        }

        public override bool ActionComplete()
        {
            bool isComplete = base.ActionComplete();
            return isComplete;
        }

        public void DeleteItemFromProductApplyPriceItemList()
        {
            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
            entity.ProductApplyPriceItemList.RemoveSelectedRowObjectFromList();
        }

        public void AddProductToProductApplyPriceItemList()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
            ICProductApplyPricesInfo mainObject = (ICProductApplyPricesInfo)entity.MainObject;

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

            entity.GenerateProductApplyPriceItems(results);
            entity.ProductApplyPriceItemList.GridControl.RefreshDataSource();
        }

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
                bool isApproved = entity.Approve();
                if (isApproved)
                    InvalidateToolbar();
            }
        }

        public void ActionValidate()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
                bool isValidated = entity.Validate();
                if (isValidated)
                    InvalidateToolbar();
            }
        }

        public List<ICProductAttributesInfo> GetProductAttributeDatasource(string group)
        {
            List<ICProductAttributesInfo> woodTypeList = new List<ICProductAttributesInfo>();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            woodTypeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(group);
            ICProductAttributesInfo objProductAttributesDummyInfo = new ICProductAttributesInfo();
            woodTypeList.Insert(0, objProductAttributesDummyInfo);
            return woodTypeList;
        }

        public void ChangeProductApplyPriceItemPrice(ICProductApplyPriceItemsInfo item)
        {
            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
            item.ICProductApplyPriceItemReductionRate = 0;
            if (item.ICProductApplyPriceItemBasicPrice == 0)
                item.ICProductApplyPriceItemReductionRate = 0;
            else
                item.ICProductApplyPriceItemReductionRate = ((item.ICProductApplyPriceItemBasicPrice - item.ICProductApplyPriceItemPrice) / item.ICProductApplyPriceItemBasicPrice) * 100;
            entity.ProductApplyPriceItemList.GridControl.RefreshDataSource();
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
            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
            ICProductApplyPricesInfo mainobject = (ICProductApplyPricesInfo)entity.MainObject;

            ImportFromExcelButton.Enabled = true;
            if (!Toolbar.IsNullOrNoneAction())
            {
                ImportFromExcelButton.Enabled = false;
            }
        }

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();
            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
            ICProductApplyPricesInfo objProductApplyPricesInfo = (ICProductApplyPricesInfo)entity.MainObject;
            objProductApplyPricesInfo.ICProductApplyPriceStatus = ProductApplyPriceStatus.New.ToString();
            objProductApplyPricesInfo.ICProductApplyPriceDate = BOSApp.GetCurrentServerDate();
        }

        public void ImportProductApplyPrice()
        {
            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
            ICProductApplyPricesInfo mainobject = (ICProductApplyPricesInfo)entity.MainObject;

            if (!Toolbar.IsNullOrNoneAction() && mainobject.ICProductApplyPriceID == 0)
                return;

            List<Range> ranges = InitializeDataImport();
            if (ranges == null)
                return;

            if (ranges.Count() != 1)
            {
                MessageBox.Show(ProductApplyPriceLocalizedResources.TeamplateMalformed, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(ImportDataLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);

            Range woods = ranges[0];

            ImportProductApplyPriceItem(woods);

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

        private void ImportProductApplyPriceItem(Range range)
        {
            if (range == null)
                return;

            ProductApplyPriceEntities entity = (ProductApplyPriceEntities)CurrentModuleEntity;
            ICProductApplyPricesInfo mainobject = (ICProductApplyPricesInfo)entity.MainObject;

            List<ICProductApplyPriceItemImportInfo> importInfoList = new List<ICProductApplyPriceItemImportInfo>();
            ICProductApplyPriceItemImportInfo objProductApplyPriceItemsImportInfo = new ICProductApplyPriceItemImportInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            for (int row = 5; row <= range.Rows.Count; row++)
            {
                objProductApplyPriceItemsImportInfo = new ICProductApplyPriceItemImportInfo();
                objProductApplyPriceItemsImportInfo.ICProductApplyPriceItemImportProductNo = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                if (string.IsNullOrEmpty(objProductApplyPriceItemsImportInfo.ICProductApplyPriceItemImportProductNo))
                    continue;

                objProductApplyPriceItemsImportInfo.ICProductApplyPriceItemImportMeasureUnitName = (range.Cells[row, 7] as Range).Text.ToString().Trim();

                cellValue = (range.Cells[row, 8] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                objProductApplyPriceItemsImportInfo.ICProductApplyPriceItemImportUnitPrice = value;

                value = 0;
                cellValue = (range.Cells[row, 9] as Range).Text.ToString().Replace(",", string.Empty).Trim();
                cellValue = cellValue.Replace(" ", string.Empty).Trim();
                decimal.TryParse(cellValue, out value);
                value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                objProductApplyPriceItemsImportInfo.ICProductApplyPriceItemImportPrice = value;
                importInfoList.Add(objProductApplyPriceItemsImportInfo);
            }

            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();

            ICProductApplyPriceItemsController objProductApplyPriceItemsController = new ICProductApplyPriceItemsController();
            List<ICProductApplyPriceItemsInfo> ProductApplyPriceItemList = new List<ICProductApplyPriceItemsInfo>();
            ICProductApplyPriceItemsInfo objProductApplyPriceItemsInfo = new ICProductApplyPriceItemsInfo();

            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();

            importInfoList.ForEach(o =>
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByNo(o.ICProductApplyPriceItemImportProductNo);
                if (objProductsInfo == null)
                    return;
                objMeasureUnitsInfo = measureUnitList.Where(o1 => o1.ICMeasureUnitName == o.ICProductApplyPriceItemImportMeasureUnitName).FirstOrDefault();

                objProductApplyPriceItemsInfo = new ICProductApplyPriceItemsInfo()
                {
                    FK_ICProductID = objProductsInfo.ICProductID,
                    AACreatedUser = BOSApp.CurrentUser,
                    FK_ICProductApplyPriceID = mainobject.ICProductApplyPriceID,
                    ICProductApplyPriceItemProductNo = objProductsInfo.ICProductNo,
                    ICProductApplyPriceItemProductName = objProductsInfo.ICProductName,
                    ICProductApplyPriceItemProductDesc = objProductsInfo.ICProductDesc,
                    ICProductApplyPriceItemProductHeight = objProductsInfo.ICProductHeight,
                    ICProductApplyPriceItemProductWidth = objProductsInfo.ICProductWidth,
                    ICProductApplyPriceItemProductLength = objProductsInfo.ICProductLength,
                    FK_ICProductAttributeColorID = objProductsInfo.FK_ICProductAttributeColorID,
                    FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeColorID,
                    ICProductApplyPriceItemBasicPrice = o.ICProductApplyPriceItemImportUnitPrice,
                    ICProductApplyPriceItemPrice = o.ICProductApplyPriceItemImportPrice,
                    ICProductApplyPriceItemQty = 1,
                    ICProductApplyPriceItemTotalAmount = o.ICProductApplyPriceItemImportUnitPrice,
                    FK_ICMeasureUnitID = objMeasureUnitsInfo == null ? objProductsInfo.FK_ICProductBasicUnitID : objMeasureUnitsInfo.ICMeasureUnitID,
                };

                if (objProductApplyPriceItemsInfo.ICProductApplyPriceItemBasicPrice == 0)
                    objProductApplyPriceItemsInfo.ICProductApplyPriceItemReductionRate = 0;
                else
                    objProductApplyPriceItemsInfo.ICProductApplyPriceItemReductionRate = ((objProductApplyPriceItemsInfo.ICProductApplyPriceItemBasicPrice - objProductApplyPriceItemsInfo.ICProductApplyPriceItemPrice) / objProductApplyPriceItemsInfo.ICProductApplyPriceItemBasicPrice) * 100;
                objProductApplyPriceItemsInfo.ICProductApplyPriceItemReductionRate = Math.Round(objProductApplyPriceItemsInfo.ICProductApplyPriceItemReductionRate, 2, MidpointRounding.AwayFromZero);
                objProductApplyPriceItemsController.CreateObject(objProductApplyPriceItemsInfo);
                ProductApplyPriceItemList.Add(objProductApplyPriceItemsInfo);
            });

            entity.ProductApplyPriceItemList.AddRange(ProductApplyPriceItemList);
            entity.ProductApplyPriceItemList.GridControl.RefreshDataSource();
        }

        public void ExportPriceSheetTemplate()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string filePath = System.Windows.Forms.Application.StartupPath + @"\Template\ProductApplyPrice.xlsx";//BOSApp.DownloadFileFTP("hoa_don_ban_hang180424.xls", "KAROT_TEMPLATE").Replace("\\\\", "\\");
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);
                // bind dữ liệu
                //ExportExcelInvoice(guiSearchInvoice.SelectedInvoiceItemList, worksheet, 1, "A", "AE");

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = @"Tệp Excel (*.xls)|*.xls|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = @"ProductApplyPrice.xls";
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
                MessageBox.Show(ex.ToString()
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
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
    }
}
