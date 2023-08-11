using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.NormTemplate
{
    class NormTemplateModule : BaseTransactionModule
    {
        #region Constants
        public const string ToolbarButtonEditAfterCompleting = "EditAfterCompleting";
        #endregion Constants
        #region Private variable
        private Microsoft.Office.Interop.Excel.Application App;
        private Workbook WorkBook;
        private Worksheet WorkSheet;
        #endregion
        #region Private Properties
        BOSButton ButtonImportExcel;
        BOSButton ButtonGetTemp;
        BOSButton ButtonSave;
        NormTemplateItemsGridControl gridItem;
        #endregion Private Properties
        #region Public methods
        private bool IsEditAfterCompleting = false;
        public NormTemplateModule()
        {
            Name = "NormTemplate";
            CurrentModuleEntity = new NormTemplateEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ButtonImportExcel = (BOSButton)Controls["fld_btnImportTemplate"];
            ButtonGetTemp = (BOSButton)Controls["fld_btnGetTemplate"];
            ButtonSave = (BOSButton)Controls["fld_btnSave"];
            gridItem = (NormTemplateItemsGridControl)Controls["fld_dgcMMNormTemplateItems"];
            InvalidateToolbar();

        }

        public override int ActionSave()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            MMNormTemplatesInfo objNormTemplateInfo = (MMNormTemplatesInfo)CurrentModuleEntity.MainObject;
            bool isStruct = false;
            entity.NormTemplateItemList.ForEach(o => { if (o.MMNormTemplateItemProductParentName.Trim() != string.Empty) isStruct = true; });
            objNormTemplateInfo.MMNormTemplateIsStruct = isStruct;
            int result = 0;
            if (!ValidateTemplateInfo()) return result;
            if (IsEditAfterCompleting)
            {
                result = base.ActionSave();
                ApproveNormTemplate();
            }
            else
            {
                result = base.ActionSave();
            }

            if (result > 0)
                EnableToolbar();
            return result;
        }
        public bool ValidateTemplateInfo()
        {
            bool result = true;
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            MMExchangeRateConfigsController objExchangeRateConfigsController = new MMExchangeRateConfigsController();
            List<MMExchangeRateConfigsInfo> objExchangeRateConfigList = (List<MMExchangeRateConfigsInfo>)objExchangeRateConfigsController.GetListFromDataSet(objExchangeRateConfigsController.GetAllObjects());
            List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);

            string mess = string.Empty;
            if (objExchangeRateConfigList != null)
            {
                entity.NormTemplateItemList.ForEach(o =>
                {
                    if (o.MMNormTemplateItemProductHeight > 0
                         && !objExchangeRateConfigList.Exists(e => e.MMExchangeRateConfigThickValue == o.MMNormTemplateItemProductHeight))
                    {
                        o.IsHeightError = true;
                        result = false;
                        mess = "Cấu hình độ dày chi tiết không tồn tại.";
                    }
                });
            }
            if (productAttributeList != null)
            {
                entity.NormTemplateItemList.ForEach(o =>
                {
                    if (o.MMNormTemplateItemProductSpeciality != string.Empty
                         && !productAttributeList.Exists(e => e.ICProductAttributeValue.Trim().ToLower() == o.MMNormTemplateItemProductSpeciality.Trim().ToLower()))
                    {
                        o.IsError = true;
                        result = false;
                        mess = "Cấu hình đặc tính phôi không tồn tại.";
                    }
                });
            }
            if (!result)
                MessageBox.Show(mess, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public bool CheckTemplateInfo(MMNormTemplateItemsInfo objTemp, string fieldName)
        {
            bool result = true;
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            MMExchangeRateConfigsController objExchangeRateConfigsController = new MMExchangeRateConfigsController();
            string mess = string.Empty;
            if (fieldName == "MMNormTemplateItemProductHeight")
            {
                List<MMExchangeRateConfigsInfo> objExchangeRateConfigList = (List<MMExchangeRateConfigsInfo>)objExchangeRateConfigsController.GetListFromDataSet(objExchangeRateConfigsController.GetAllObjects());
                if (objExchangeRateConfigList != null)
                {
                    if (objTemp.MMNormTemplateItemProductHeight > 0
                             && !objExchangeRateConfigList.Exists(e => e.MMExchangeRateConfigThickValue == objTemp.MMNormTemplateItemProductHeight))
                    {
                        objTemp.IsHeightError = true;
                        result = false;
                        mess = "Cấu hình độ dày chi tiết không tồn tại.";
                    }
                }
            }
            else if (fieldName == "MMNormTemplateItemProductSpeciality")
            {
                List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
                if (productAttributeList != null)
                {
                    if (objTemp.MMNormTemplateItemProductSpeciality != string.Empty
                              && !productAttributeList.Exists(e => e.ICProductAttributeValue.Trim().ToLower() == objTemp.MMNormTemplateItemProductSpeciality.Trim().ToLower()))
                    {
                        objTemp.IsError = true;
                        result = false;
                        mess = "Cấu hình đặc tính phôi không tồn tại.";
                    }
                }
            }
            if (!result)
                MessageBox.Show(mess, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        /// <summary>
        /// Called when user changes the invoice after completing it
        /// </summary>
        public void ActionEditAfterCompleting()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                IsEditAfterCompleting = true;

                base.ActionEdit();

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            ButtonSave.Enabled = false;
            EnableToolbar();

        }
        public static bool ProductionNormSaveTemplate(List<MMNormTemplateItemsInfo> NormTemplateItemList, int productID, bool isStruct)
        {
            bool result = false;
            try
            {
                MMNormTemplatesController objNormTemplateController = new MMNormTemplatesController();
                GENumberingController objGENumberingController = new GENumberingController();
                MMNormTemplateItemsController objNormTemplateItemsController = new MMNormTemplateItemsController();
                MMNormTemplateProductsController objNormTemplateProductsController = new MMNormTemplateProductsController();
                //Create main object
                MMNormTemplatesInfo objNormTemplateInfo = new MMNormTemplatesInfo();
                objNormTemplateInfo.MMNormTemplateStatus = BatchProductPlanStatus.New.ToString();
                objNormTemplateInfo.MMNormTemplateDate = DateTime.Now;
                objNormTemplateInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                // Create template product
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                BOSList<MMNormTemplateProductsInfo> NormTemplateProductList = new BOSList<MMNormTemplateProductsInfo>();
                if (objProductsInfo == null)
                    return false;
                else
                {
                    MMNormTemplateProductsInfo objNormTemplateProductsInfo = new MMNormTemplateProductsInfo();
                    objNormTemplateProductsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                    objNormTemplateProductsInfo.MMNormTemplateProductDesc = objProductsInfo.ICProductDesc;
                    if (objProductsInfo.FK_ICProductGroupID == 0)
                    {
                        if (MessageBox.Show("Mã hàng chưa xác định nhóm hàng."
                              + Environment.NewLine + "Mẫu sẽ sữ dụng cho mã hàng: " + objProductsInfo.ICProductName
                              + Environment.NewLine + "Bạn muốn lưu không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return false;
                        else
                        {
                            objNormTemplateProductsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                        }
                    }
                    NormTemplateProductList.Add(objNormTemplateProductsInfo);
                }

                int numberingStart = 0;

                if (objNormTemplateInfo.MMNormTemplateNo != string.Empty)
                {
                    String strMainObjectNo = String.Empty;
                    GENumberingInfo objGENumberingInfo;
                    objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID("NormTemplate", BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                    if (objGENumberingInfo != null)
                    {
                        BOSDbUtil dbUtil = new BOSDbUtil();
                        strMainObjectNo = String.Format("{0}{1}",
                                                        objGENumberingInfo.GENumberingPrefix,
                                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                        numberingStart = objGENumberingInfo.GENumberingStart;
                        while (objNormTemplateController.IsExist(strMainObjectNo))
                        {
                            objGENumberingInfo.GENumberingStart++;
                            strMainObjectNo = String.Format("{0}{1}",
                                                            objGENumberingInfo.GENumberingPrefix,
                                                            objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                            numberingStart = objGENumberingInfo.GENumberingStart;
                        }
                    }
                    objNormTemplateInfo.MMNormTemplateNo = strMainObjectNo;
                    objNormTemplateInfo.MMNormTemplateIsStruct = isStruct;
                    objNormTemplateController.CreateObject(objNormTemplateInfo);
                    objGENumberingInfo.GENumberingStart = numberingStart + 1;
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
                if (objNormTemplateInfo.MMNormTemplateID > 0)
                {
                    BOSList<MMNormTemplateItemsInfo> templateItemList = new BOSList<MMNormTemplateItemsInfo>();
                    NormTemplateItemList.ForEach(o =>
                        {
                            o.FK_MMNormTemplateID = objNormTemplateInfo.MMNormTemplateID;
                            objNormTemplateItemsController.CreateObject(o);
                        }
                    );
                    NormTemplateProductList.ForEach(o =>
                    {
                        o.FK_MMNormTemplateID = objNormTemplateInfo.MMNormTemplateID;
                        objNormTemplateProductsController.CreateObject(o);
                    });
                    result = true;
                }
                else
                {
                    MessageBox.Show("Lỗi xãy ra trong quá trình lưu dữ liệu, vui lòng thử lại", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xãy ra trong quá trình lưu dữ liệu:" + ex.Message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static String GetNormTemplateNo(ref int numberingStart)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID("NormTemplate", BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objGENumberingInfo != null)
            {
                MMNormTemplatesController objNormTemplateController = new MMNormTemplatesController();
                BOSDbUtil dbUtil = new BOSDbUtil();
                strMainObjectNo = String.Format("{0}{1}",
                                                objGENumberingInfo.GENumberingPrefix,
                                                objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                numberingStart = objGENumberingInfo.GENumberingStart;
                while (objNormTemplateController.IsExist(strMainObjectNo))
                {
                    objGENumberingInfo.GENumberingStart++;
                    strMainObjectNo = String.Format("{0}{1}",
                                                    objGENumberingInfo.GENumberingPrefix,
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                }
            }
            return strMainObjectNo;
        }
        #endregion Public methods       

        public override void ActionNew()
        {
            base.ActionNew();
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            MMNormTemplatesInfo objNormTemplateInfo = (MMNormTemplatesInfo)CurrentModuleEntity.MainObject;
            objNormTemplateInfo.MMNormTemplateStatus = BatchProductPlanStatus.New.ToString();
            objNormTemplateInfo.MMNormTemplateDate = DateTime.Now;
            objNormTemplateInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ButtonImportExcel.Enabled = true;
            ButtonSave.Enabled = false;
        }

        public void DeleteItemFromList()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            entity.NormTemplateItemList.RemoveSelectedRowObjectFromList();

        }
        public void DeleteItemFromNormTemplateProductList()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            entity.NormTemplateProductList.RemoveSelectedRowObjectFromList();

        }
        /// <summary>
        /// Approve all items of the BatchProductPlan
        /// </summary>
        public void ApproveNormTemplate()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            entity.ApproveNormTemplate();
            IsEditAfterCompleting = false;
            EnableToolbar();
        }
        public void EnableToolbar()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            MMNormTemplatesInfo objNormTemplateInfo = (MMNormTemplatesInfo)entity.MainObject;
            string status = objNormTemplateInfo.MMNormTemplateStatus;
            ButtonImportExcel.Enabled = true;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ButtonSave.Enabled = false;
            //New
            if (status == MMProposalItemStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            }
            //Approved
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtonEditAfterCompleting, false);
            if (status == MMProposalItemStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtonEditAfterCompleting, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ButtonImportExcel.Enabled = false;
                ButtonSave.Enabled = true;
            }
        }
        public void ChangeItemFromProcessItemList()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            entity.NormTemplateItemList.ChangeObjectFromList();
        }
        public void ImportDataFromExcel()
        {
            try
            {
                NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
                MMNormTemplatesInfo mainObject = (MMNormTemplatesInfo)entity.MainObject;
                List<Range> ranges = InitializeDataImport();
                if (ranges == null)
                    return;
                BOSProgressBar.Start(MESLocalizedResources.ProgressBarMessage);

                Range range = ranges[0];

                #region Process data
                MMNormTemplateItemsInfo objNormTemplateItemsInfo;
                for (int row = 2; row <= range.Rows.Count; row++)
                {
                    bool toAdd = false;
                    objNormTemplateItemsInfo = new MMNormTemplateItemsInfo();
                    objNormTemplateItemsInfo.MMNormTemplateItemParentName = (range.Cells[row, 1] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemParentName != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductName = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductName != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductHeight = GetDecimalFromString((range.Cells[row, 3] as Range).Value2);
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductHeight > 0) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductJoinery = GetDecimalFromString((range.Cells[row, 4] as Range).Value2);
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductJoinery > 0) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductJoineryDesc = (range.Cells[row, 5] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductJoineryDesc != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductSpeciality = (range.Cells[row, 6] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductSpeciality != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemAttributeQuality = (range.Cells[row, 7] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemAttributeQuality != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductAttribute = (range.Cells[row, 9] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductAttribute != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemOperation = (range.Cells[row, 10] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemOperation != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemPackagingName = (range.Cells[row, 11] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemPackagingName != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemPackagingType = (range.Cells[row, 12] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemPackagingType != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemUnit = (range.Cells[row, 13] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemUnit != string.Empty) toAdd = true;

                    if (toAdd)
                        entity.NormTemplateItemList.Add(objNormTemplateItemsInfo);
                    else break;
                }
                entity.NormTemplateItemList.GridControl?.RefreshDataSource();
                #endregion
                if (gridItem.MainView != null)
                    ResetDataColumn(gridItem.MainView as GridView, "MMNormTemplateItemProductParentName");
                BOSProgressBar.Close();
                ReleaseDataImport();
            }
            catch (Exception ex)
            {
                ReleaseDataImport();
                MessageBox.Show("Có lổi xãy ra:" + ex.Message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                BOSProgressBar.Close();
                return;
            }
        }
        public decimal GetDecimalFromString(object range)
        {
            decimal result = 0;
            if (range != null)
            {
                decimal.TryParse(range.ToString(), out result);
            }
            return result;
        }
        public void GetTemplateExcel()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string filePath = System.Windows.Forms.Application.StartupPath + @"\Template\TEMPBOM.xlsx";
                //App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = @"Tệp Excel (*.xls)|*.xls|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = @"TEMPBOM.xls";
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
                                            , MESLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
            }
        }
        public void ReleaseDataImport()
        {
            if (WorkBook == null) return;
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
        public void ShowProducts()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            MMNormTemplatesInfo mainObject = (MMNormTemplatesInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> listItem = objProductsController.GetListProductByListProductType();
            guiFind<ICProductsInfo> guiProduct = new guiFind<ICProductsInfo>(TableName.ICProductsTableName, listItem, this, true, true);
            guiProduct.ShowDialog();
            if (guiProduct.DialogResult == DialogResult.OK)
            {
                List<ICProductsInfo> listSelectedItem = guiProduct.SelectedObjects.Where(x => x.Selected).ToList();
                if (listSelectedItem != null && listSelectedItem.Count > 0)
                {
                    listSelectedItem.ForEach(p =>
                    {
                        if (!entity.NormTemplateProductList.Exists("FK_ICProductID", p.ICProductID))
                        {
                            MMNormTemplateProductsInfo obj = new MMNormTemplateProductsInfo();
                            obj.FK_ICProductID = p.ICProductID;
                            obj.FK_ICProductGroupID = p.FK_ICProductGroupID;
                            obj.MMNormTemplateProductDesc = p.ICProductDesc;
                            obj.FK_MMNormTemplateID = mainObject.MMNormTemplateID;
                            entity.NormTemplateProductList.Add(obj);
                        }
                    });
                    entity.NormTemplateProductList.GridControl?.RefreshDataSource();
                }
            }
        }

        public void SaveNormTemplateProduct()
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            MMNormTemplatesInfo mainObject = (MMNormTemplatesInfo)entity.MainObject;
            if (mainObject.MMNormTemplateID > 0)
            {
                entity.SaveNormTemplateProduct();
                MessageBox.Show(MESLocalizedResources.SaveSuccessful, Localization.MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ResetDataColumn(GridView gridView, string colName)
        {
            NormTemplateEntities entity = (NormTemplateEntities)CurrentModuleEntity;
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == colName)
                {
                    List<string> dataList = new List<string>();
                    dataList = entity.NormTemplateItemList.Where(o => o.MMNormTemplateItemParentName != string.Empty).Select(n => n.MMNormTemplateItemParentName.Trim()).Distinct().ToList();
                    RepositoryItemMRUEdit repMruEdit = new RepositoryItemMRUEdit();
                    repMruEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repMruEdit.NullText = string.Empty;
                    repMruEdit.Items.Clear();
                    repMruEdit.Items.AddRange(dataList);
                    column.ColumnEdit = repMruEdit;
                }
            }
        }
        public void GeneralSourceData(GridView gridView)
        {
            foreach (GridColumn column in gridView.Columns)
            {
                List<object> dataList = new List<object>();
                if (column.FieldName == "MMNormTemplateItemParentName")
                {
                    string tableName = TableName.ICProductsTableName;
                    string fieldName = "ICProductName";
                    string getTypeField1 = "ICProductType";
                    string getValue1 = "SemiProduct";
                    string getTypeField2 = "HasComponent";
                    bool getValue2 = true;
                    string DisplayColumn = "ICProductName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);

                }
                if (column.FieldName == "MMNormTemplateItemProductName")
                {
                    string tableName = TableName.ICProductsTableName;
                    string fieldName = "ICProductName";
                    string getTypeField1 = "ICProductType";
                    string getValue1 = "SemiProduct";
                    string getTypeField2 = "HasComponent";
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }
                if (column.FieldName == "MMNormTemplateItemProductParentName")
                {
                    string tableName = TableName.ICProductsTableName;
                    string fieldName = "ICProductName";
                    string getTypeField1 = "ICProductType";
                    string getValue1 = "SemiProduct";
                    string getTypeField2 = "HasComponent";
                    bool getValue2 = true;
                    string DisplayColumn = "ICProductName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);

                }

                if (column.FieldName == "MMNormTemplateItemProductHeight")
                {
                    string tableName = TableName.ICProductsTableName;
                    string fieldName = "ICProductHeight";
                    string getTypeField1 = "ICProductType";
                    string getValue1 = "SemiProduct";
                    string getTypeField2 = "HasComponent";
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                    column.DisplayFormat.FormatString = "{0:#,##0}";
                }
                if (column.FieldName == "MMNormTemplateItemProductJoineryDesc")
                {
                    string tableName = TableName.ICProductsTableName;
                    string fieldName = "ICProductJoinery";
                    string getTypeField1 = "ICProductType";
                    string getValue1 = "SemiProduct";
                    string getTypeField2 = "HasComponent";
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }
                if (column.FieldName == "MMNormTemplateItemAttributeQuality")
                {
                    string tableName = TableName.ICProductattributesTableName;
                    string fieldName = "ICProductAttributeValue";
                    string getTypeField1 = "ICProductAttributeGroup";
                    string getValue1 = "Quality";
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductAttributeValue";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }
                if (column.FieldName == "MMNormTemplateItemProductSpeciality")
                {
                    string tableName = TableName.ICProductattributesTableName;
                    string fieldName = "ICProductAttributeValue";
                    string getTypeField1 = "ICProductAttributeGroup";
                    string getValue1 = "Speciality";
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductAttributeValue";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }
                if (column.FieldName == "MMNormTemplateItemProductAttribute")
                {
                    string tableName = TableName.ICDepartmentAttributeValuesTableName;
                    string fieldName = "ICDepartmentAttributeValueValue";
                    string getTypeField1 = string.Empty;
                    string getValue1 = string.Empty;
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "ICDepartmentAttributeValueValue";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }

                if (column.FieldName == "MMNormTemplateItemProductWoodType")
                {
                    string tableName = TableName.ICProductattributesTableName;
                    string fieldName = "ICProductAttributeValue";
                    string getTypeField1 = "ICProductAttributeGroup";
                    string getValue1 = "WoodType";
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductAttributeValue";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }

                if (column.FieldName == "MMNormTemplateItemOperation")
                {
                    string tableName = TableName.MMOperationsTableName;
                    string fieldName = "MMOperationName";
                    string getTypeField1 = "MMOperationGroup";
                    string getValue1 = "Product";
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "MMOperationName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }
                if (column.FieldName == "MMNormTemplateItemPackagingName")
                {
                    string tableName = TableName.ICProductsTableName;
                    string fieldName = "ICProductName";
                    string getTypeField1 = "ICProductType";
                    string getValue1 = "IngredientPackaging";
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }
                if (column.FieldName == "MMNormTemplateItemPackagingType")
                {
                    string tableName = TableName.ICProductattributesTableName;
                    string fieldName = "ICProductAttributeValue";
                    string getTypeField1 = "ICProductAttributeGroup";
                    string getValue1 = "PackingMaterialSpeciality";
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "ICProductAttributeValue";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }

                if (column.FieldName == "MMNormTemplateItemUnit")
                {
                    string tableName = TableName.ICMeasureUnitsTableName;
                    string fieldName = "ICMeasureUnitName";
                    string getTypeField1 = string.Empty;
                    string getValue1 = string.Empty;
                    string getTypeField2 = string.Empty;
                    bool getValue2 = false;
                    string DisplayColumn = "ICMeasureUnitName";
                    dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                    GenerateSearchChiTiet(column, dataList);
                }
            }
        }
        public List<object> GetDataFromLookupTable(string tableName, string colName, string getTypeField1
                                        , object objPropertyValue1, string getTypeField2, object objPropertyValue2, string DisplayColumn)
        {
            List<object> dataList = new List<object>();
            DataSet ds = null;
            if (!BOSApp.LookupTables.ContainsKey(tableName))
            {
                ds = GetLookupTableData(tableName);
                GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == tableName).FirstOrDefault();
                if (lookupTable == null)
                {
                    lookupTable = new GELookupTablesInfo();
                    lookupTable.GELookupTableName = tableName;
                    lookupTable.GELookupTableDisplayColumn = DisplayColumn;
                }
                if (lookupTable != null)
                {
                    BOSApp.LookupTables.Add(tableName, ds);
                    BOSApp.LookupTablesUpdatedDate.Add(tableName, DateTime.Now);
                    BOSApp.LookupTableObjects.Add(tableName, lookupTable);
                }
            }
            else
                ds = BOSApp.LookupTables[tableName] as DataSet;

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                IBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(tableName + "Controller");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    object obj = objItemsController.GetObjectFromDataRow(row);
                    if (obj != null)
                    {
                        object objValue1 = dbUtil.GetPropertyValue(obj, getTypeField1);
                        object objResult = dbUtil.GetPropertyValue(obj, colName);
                        if (getTypeField1 == string.Empty)
                        {
                            if (!(dataList.IndexOf(objResult) > 0))
                                dataList.Add(objResult);
                        }
                        else
                        {
                            if (objPropertyValue1.Equals(objValue1))
                            {
                                if (getTypeField2 != string.Empty)
                                {
                                    object objValue2 = dbUtil.GetPropertyValue(obj, getTypeField2);
                                    if (objPropertyValue2.Equals(objValue2))
                                    {
                                        if (!(dataList.IndexOf(objResult) > 0))
                                            dataList.Add(objResult);
                                    }
                                }
                                else
                                    if (!(dataList.IndexOf(objResult) > 0))
                                    dataList.Add(objResult);
                            }

                        }
                    }
                }
            }

            ds.Dispose();
            return dataList;
        }

        public void GenerateSearchChiTiet(GridColumn column, List<object> dataList)
        {
            RepositoryItemMRUEdit repMruEdit = new RepositoryItemMRUEdit();
            repMruEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repMruEdit.NullText = string.Empty;
            repMruEdit.Items.Clear();
            repMruEdit.Items.AddRange(dataList);
            column.ColumnEdit = repMruEdit;
        }

        public List<Range> InitializeDataImport()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = MESLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
                filePath = dialog.FileName;
            if (!String.IsNullOrEmpty(filePath))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                //App = new Microsoft.Office.Interop.Excel.ApplicationClass();
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

    }
}
