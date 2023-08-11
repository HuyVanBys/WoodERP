using BOSCommon;
using BOSERP.MES.Modules.CarcassBOM.ImportInfo;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiImportBOM : BOSERPScreen
    {
        public List<IPProductionItemsInfo> SemiProductsList { get; set; }

        public List<IPProductionItemsInfo> HardwardProductsList { get; set; }

        public List<IPProductionItemsInfo> IngredientPackagingsList { get; set; }

        public List<IPProductionItemsInfo> IngredientPaintsList { get; set; }

        public List<IPProductionItemsInfo> GeneralMaterialsList { get; set; }

        public List<IPProductItemMaterialsInfo> MaterialsList { get; set; }

        public List<IPProductItemProcessInfo> ProcessList { get; set; }

        public List<IPMappingsInfo> MappingsList { get; set; }

        List<MMProcesssInfo> ProcessDataList { get; set; }

        List<MMOperationsInfo> OperationsList { get; set; }

        List<MMFormulasInfo> FormulasList { get; set; }

        List<ICProductGroupsInfo> ProductGroupsList { get; set; }

        ICProductsInfo ProductCarcass { get; set; }
        public guiImportBOM(ICProductsInfo carras, List<IPMappingsInfo> mappingsList, List<IPProductionItemsInfo> productionItemsList, List<IPProductItemMaterialsInfo> materialsList, List<IPProductItemProcessInfo> processList)
        {
            InitializeComponent();
            ProductCarcass = carras;
            MappingsList = mappingsList;
            SemiProductsList = productionItemsList.Where(o => o.IPProductionItemGroup == ProductType.SemiProduct.ToString()).ToList();
            HardwardProductsList = productionItemsList.Where(o => o.IPProductionItemGroup == ProductType.Hardware.ToString()).ToList();
            IngredientPaintsList = productionItemsList.Where(o => o.IPProductionItemGroup == ProductType.IngredientPaint.ToString()).ToList();
            IngredientPackagingsList = productionItemsList.Where(o => o.IPProductionItemGroup == ProductType.IngredientPackaging.ToString()).ToList();
            GeneralMaterialsList = productionItemsList.Where(o => o.IPProductionItemGroup == ProductType.GeneralMaterial.ToString()).ToList();
            ProcessList = processList;
            MaterialsList = materialsList;
            MMProcesssController objProcesssController = new MMProcesssController();
            ProcessDataList = objProcesssController.GetAllAliveProcess();

            MMOperationsController objOperationsController = new MMOperationsController();
            OperationsList = objOperationsController.GetAllAliveOperation();

            MMFormulasController objFormulasController = new MMFormulasController();
            FormulasList = objFormulasController.GETALL_MMFormulas();

            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ProductGroupsList = objProductGroupsController.GetProductGroupByDepartmentID(BOSCommon.Constants.DepartmentID.SemiProduct);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiImportBOM_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcProductionItemsGridControl.InvalidateDataSource(SemiProductsList, OperationsList);
            fld_dgcProductionItemHardwaresGridControl.InvalidateDataSource(HardwardProductsList, OperationsList);
            fld_dgcProductionItemPackagingsGridControl.InvalidateDataSource(IngredientPackagingsList, OperationsList);
            fld_dgcProductionItemPaintsGridControl.InvalidateDataSource(IngredientPaintsList, OperationsList);
            fld_dgcProductionItemOtherGridControl.InvalidateDataSource(GeneralMaterialsList, OperationsList);
            fld_dgcProductItemMaterialsGridControl.InvalidateDataSource(MaterialsList, OperationsList);
            fld_dgcProductItemProcessGridControl.InvalidateDataSource(ProcessList, OperationsList, ProcessDataList);
            MappingsList.ForEach(o =>
            {
                switch (o.Group)
                {
                    case "SemiProduct":
                        fld_tabSemiProducts.PageVisible = true;
                        break;
                    case "Hardware":
                        fld_tabHardwares.PageVisible = true;
                        break;
                    case "IngredientPackaging":
                        fld_tabIngredientPackagings.PageVisible = true;
                        break;
                    case "IngredientPaint":
                        fld_tabIngredientPaints.PageVisible = true;
                        break;
                    case "Material":
                        fld_tabMaterials.PageVisible = true;
                        break;
                    case "GeneralMaterial":
                        fld_tabOtherMaterials.PageVisible = true;
                        break;
                    case "Process":
                        fld_tabProductItemProcess.PageVisible = true;
                        break;
                }
            });
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApproveImportBOM_Click(object sender, EventArgs e)
        {
            if (!IsValidSaveBOM())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private string CheckExistColor(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

            List<string> colorID = colorRef.Split(',').Select(o => o.Trim()).ToList();
            DataSet ds = BOSApp.GetLookupTableData("ICProductAttributes");
            if (ds != null && ds.Tables.Count > 0)
            {
                List<ICProductAttributesInfo> ColorData = (List<ICProductAttributesInfo>)(new ICProductAttributesController()).GetListFromDataSet(ds);
                string notExit = string.Join(", ", colorID.Where(c => !ColorData.Any(d => d.ICProductAttributeNo.ToLower().Trim() == c.ToLower() && d.ICProductAttributeGroup == ProductAttributeGroup.COLOR.ToString())).ToList());
                if (!string.IsNullOrEmpty(notExit))
                {
                    notExit = string.Join(", ", colorID.Where(c => !ColorData.Any(d => d.ICProductAttributeValue.ToLower().Trim() == c.ToLower() && d.ICProductAttributeGroup == ProductAttributeGroup.COLOR.ToString())).ToList());
                }
                if (!string.IsNullOrEmpty(notExit))
                    return notExit;
                else return string.Empty;
            }
            else return string.Empty;
        }
        private string GetColorIDList(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

            List<string> colorID = colorRef.Split(',').Select(o => o.Trim().ToLower()).ToList();
            DataSet ds = BOSApp.GetLookupTableData("ICProductAttributes");
            if (ds != null && ds.Tables.Count > 0)
            {
                List<ICProductAttributesInfo> ColorData = (List<ICProductAttributesInfo>)(new ICProductAttributesController()).GetListFromDataSet(ds);
                string notExit = string.Join(", ", ColorData.Where(o => colorID.Contains(o.ICProductAttributeValue.ToLower().Trim()) && o.ICProductAttributeGroup == ProductAttributeGroup.COLOR.ToString()).Select(o => o.ICProductAttributeID).ToArray());
                if (!string.IsNullOrEmpty(notExit))
                {
                    notExit = string.Join(", ", ColorData.Where(o => colorID.Contains(o.ICProductAttributeNo.ToLower().Trim()) && o.ICProductAttributeGroup == ProductAttributeGroup.COLOR.ToString()).Select(o => o.ICProductAttributeID).ToArray());
                }
                if (!string.IsNullOrEmpty(notExit))
                    return notExit;
                else return string.Empty;
            }
            else return string.Empty;
        }
        public bool IsValidSaveBOM()
        {
            ICProductsForViewInfo objProductsInfo = new ICProductsForViewInfo();
            string messageError = string.Empty;
            List<string> parentCode = SemiProductsList.Select(o => o.IPProductionItemCode).ToList();
            MMProcesssInfo objProcesssInfo = new MMProcesssInfo();
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            MMFormulasInfo objFormulasInfo = new MMFormulasInfo();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            ICProductAttributesInfo objSpecialityInfo = new ICProductAttributesInfo();
            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
            List<ICProductAttributesInfo> attributesList = new List<ICProductAttributesInfo>();
            if (BOSApp.LookupTables.Contains("ICProductAttributes"))
                attributesList = (List<ICProductAttributesInfo>)(new ICProductAttributesController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICProductAttributes"]);
            
            SemiProductsList.ForEach(o =>
            {
                objFormulasInfo = FormulasList.Where(f => f.MMFormulaNo == o.MMFormulaPaintANo).FirstOrDefault();
                o.FK_MMFormulaPaintAID = objFormulasInfo == null ? 0 : objFormulasInfo.MMFormulaID;

                objFormulasInfo = FormulasList.Where(f => f.MMFormulaNo == o.MMFormulaPaintBNo).FirstOrDefault();
                o.FK_MMFormulaPaintBID = objFormulasInfo == null ? 0 : objFormulasInfo.MMFormulaID;

                objFormulasInfo = FormulasList.Where(f => f.MMFormulaNo == o.MMFormulaPaintCNo).FirstOrDefault();
                o.FK_MMFormulaPaintCID = objFormulasInfo == null ? 0 : objFormulasInfo.MMFormulaID;

                objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationNo).FirstOrDefault();
                o.FK_MMOperationID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;

                objProductAttributesInfo = attributesList.Where(a => a.ICProductAttributeGroup == ProductAttributeGroup.COLOR.ToString()
                                                                && a.ICProductAttributeNo == o.ICProductAttributeColorNo).FirstOrDefault();
                o.FK_ICProductAttributeColorID = objProductAttributesInfo == null ? 0 : objProductAttributesInfo.ICProductAttributeID;
                if (!string.IsNullOrWhiteSpace(o.ICProductAttributeOtherColor))
                    o.ICProductAttributeOtherColorID = GetColorIDList(o.ICProductAttributeOtherColor);

                objSpecialityInfo = attributesList.Where(a => a.ICProductAttributeGroup == ProductAttributeGroup.Speciality.ToString()
                                                                && (a.ICProductAttributeNo == o.IPProductAttributeSemiProductSpecialityNo ||
                                                                a.ICProductAttributeValue == o.IPProductAttributeSemiProductSpecialityNo)).FirstOrDefault();
                o.FK_ICProductAttributeSemiProductSpecialityID = objSpecialityInfo == null ? 0 : objSpecialityInfo.ICProductAttributeID;

                objProductGroupsInfo = ProductGroupsList.Where(pg => pg.ICProductGroupNo == o.ICProductGroupNo).FirstOrDefault();
                o.FK_ICProductGroupID = objProductGroupsInfo?.ICProductGroupID ?? 0;
                
                if (!string.IsNullOrWhiteSpace(o.ICProductNo))
                {
                    objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == o.ICProductNo).FirstOrDefault();
                    if (objProductsInfo == null)
                    {
                        messageError += string.Format("Mã bán thành phẩm [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                        messageError += Environment.NewLine;
                    }
                    else if (objProductsInfo.ICProductName.Trim() != o.ICProductName)
                    {
                        messageError += string.Format("Bán thành phẩm [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.ICProductNo);
                        messageError += Environment.NewLine;
                    }
                } 

                if (!string.IsNullOrWhiteSpace(o.IPProductionItemParentCode) && !parentCode.Contains(o.IPProductionItemParentCode))
                {
                    messageError += string.Format("Thuộc BTP [{0}] không tồn tại.", o.IPProductionItemParentCode);
                    messageError += Environment.NewLine;
                }

                if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMOperationNo))
                {
                    messageError += string.Format("Công đoạn [{0}] không tồn tại trong hệ thống.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objOperationsInfo != null && o.MMOperationName != objOperationsInfo.MMOperationName.Trim())
                {
                    messageError += string.Format("Công đoạn [{0}] có tên khác với dữ liệu nguồn.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }

                if (objProductAttributesInfo == null && !string.IsNullOrWhiteSpace(o.ICProductAttributeColorNo))
                {
                    messageError += string.Format("Màu sơn [{0}] không tồn tại trong hệ thống.", o.ICProductAttributeColorNo);
                    messageError += Environment.NewLine;
                    return;
                }

                if (!string.IsNullOrWhiteSpace(o.ICProductAttributeOtherColor))
                {
                    string mess = CheckExistColor(o.ICProductAttributeOtherColor);
                    if (!string.IsNullOrEmpty(mess))
                    {
                        messageError += string.Format("Màu sơn [{0}] không tồn tại trong hệ thống.", mess);
                        messageError += Environment.NewLine;
                        return;
                    }
                }

                if (objSpecialityInfo == null && !string.IsNullOrWhiteSpace(o.IPProductAttributeSemiProductSpecialityNo))
                {
                    messageError += string.Format("Đặc tính [{0}] không tồn tại trong hệ thống.", o.IPProductAttributeSemiProductSpecialityNo);
                    messageError += Environment.NewLine;
                    return;
                }
                if (objProductGroupsInfo == null && !string.IsNullOrWhiteSpace(o.ICProductGroupNo))
                {
                    messageError += string.Format("Nhóm hàng [{0}] không tồn tại trong hệ thống.", o.ICProductGroupNo);
                    messageError += Environment.NewLine;
                    return;
                }
            });
            MaterialsList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.ICProductNo))
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == o.ICProductNo).FirstOrDefault();
                if (objProductsInfo == null)
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objProductsInfo.ICProductName.Trim() != o.ICProductName)
                {
                    messageError += string.Format("Nguyên liệu [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                }
                if (!string.IsNullOrWhiteSpace(o.IPProductionItemParentCode) && !parentCode.Contains(o.IPProductionItemParentCode))
                {
                    messageError += string.Format("Mã chi tiết cha [{0}] không tồn tại.", o.IPProductionItemParentCode);
                    messageError += Environment.NewLine;
                }
                objFormulasInfo = FormulasList.Where(f => f.MMFormulaNo == o.MMFormulaNo).FirstOrDefault();
                o.FK_MMFormulaID = objFormulasInfo == null ? 0 : objFormulasInfo.MMFormulaID;

                objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationNo).FirstOrDefault();
                o.FK_MMOperationID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;
                if (objOperationsInfo == null && string.IsNullOrWhiteSpace(o.MMOperationNo))
                    return;
                else if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMOperationNo))
                {
                    messageError += string.Format("Công đoạn [{0}] không tồn tại trong hệ thống.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objOperationsInfo != null && o.MMOperationName != objOperationsInfo.MMOperationName)
                {
                    messageError += string.Format("Công đoạn [{0}] có tên khác với dữ liệu nguồn.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
            });
            HardwardProductsList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.ICProductNo))
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == o.ICProductNo).FirstOrDefault();
                if (objProductsInfo == null)
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objProductsInfo.ICProductName.Trim() != o.ICProductName)
                {
                    messageError += string.Format("Nguyên liệu [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                }
                if (!string.IsNullOrWhiteSpace(o.IPProductionItemParentCode) && !parentCode.Contains(o.IPProductionItemParentCode))
                {
                    messageError += string.Format("Mã chi tiết cha [{0}] không tồn tại.", o.IPProductionItemParentCode);
                    messageError += Environment.NewLine;
                }

                objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationNo).FirstOrDefault();
                o.FK_MMOperationID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;
                if (objOperationsInfo == null && string.IsNullOrWhiteSpace(o.MMOperationNo))
                    return;
                else if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMOperationNo))
                {
                    messageError += string.Format("Công đoạn [{0}] không tồn tại trong hệ thống.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objOperationsInfo != null && o.MMOperationName != objOperationsInfo.MMOperationName.Trim())
                {
                    messageError += string.Format("Công đoạn [{0}] có tên khác với dữ liệu nguồn.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
            });
            IngredientPackagingsList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.ICProductNo))
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == o.ICProductNo).FirstOrDefault();
                if (objProductsInfo == null)
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objProductsInfo.ICProductName.Trim() != o.ICProductName)
                {
                    messageError += string.Format("Nguyên liệu [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                }
                if (!string.IsNullOrWhiteSpace(o.IPProductionItemParentCode) && !parentCode.Contains(o.IPProductionItemParentCode))
                {
                    messageError += string.Format("Mã chi tiết cha [{0}] không tồn tại.", o.IPProductionItemParentCode);
                    messageError += Environment.NewLine;
                }

                objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationNo).FirstOrDefault();
                o.FK_MMOperationID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;
                if (objOperationsInfo == null && string.IsNullOrWhiteSpace(o.MMOperationNo))
                    return;
                else if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMOperationNo))
                {
                    messageError += string.Format("Công đoạn [{0}] không tồn tại trong hệ thống.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objOperationsInfo != null && o.MMOperationName != objOperationsInfo.MMOperationName.Trim())
                {
                    messageError += string.Format("Công đoạn [{0}] có tên khác với dữ liệu nguồn.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
            });
            MMPaintProcessessController objPaintProcessessController = new MMPaintProcessessController();
            MMPaintProcessessInfo objPaintProcessessInfo;
            IngredientPaintsList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.ICProductNo) && string.IsNullOrWhiteSpace(o.IPProductionItemPaintProcessNo))
                {
                    messageError += string.Format("Dữ liệu đầu vào không đúng định dạng");
                    messageError += Environment.NewLine;
                    return;
                }
                if (!string.IsNullOrWhiteSpace(o.IPProductionItemPaintProcessNo))
                {
                    objPaintProcessessInfo = (MMPaintProcessessInfo)objPaintProcessessController.GetObjectByNo(o.IPProductionItemPaintProcessNo);
                    o.FK_MMPaintProcessID = objPaintProcessessInfo == null ? 0 : objPaintProcessessInfo.MMPaintProcessesID;
                    if (objPaintProcessessInfo == null && !string.IsNullOrWhiteSpace(o.IPProductionItemPaintProcessNo))
                    {
                        messageError += string.Format("Quy trình sơn [{0}] không tồn tại trong hệ thống.", o.IPProductionItemPaintProcessNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                    else if (objPaintProcessessInfo != null && o.IPProductionItemPaintProcessDesc != objPaintProcessessInfo.MMPaintProcessesDesc.Trim())
                    {
                        messageError += string.Format("Quy trình sơn [{0}] có mô tả khác với dữ liệu nguồn.", o.IPProductionItemPaintProcessNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                    //else if (objPaintProcessessInfo != null)
                    //{
                    //    if (objPaintProcessessInfo.FK_ICProductAttributeColorID == ProductCarcass.FK_ICProductAttributeColorID)
                    //        return;

                    //    messageError += string.Format("Quy trình sơn [{0}] không đúng với màu của thành phẩm", o.IPProductionItemPaintProcessNo);
                    //    messageError += Environment.NewLine;
                    //    return;
                    //}
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(o.ICProductNo))
                    {
                        messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                    objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == o.ICProductNo).FirstOrDefault();
                    if (objProductsInfo == null)
                    {
                        messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                    else if (objProductsInfo.ICProductName.Trim() != o.ICProductName)
                    {
                        messageError += string.Format("Nguyên liệu [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.ICProductNo);
                        messageError += Environment.NewLine;
                    }
                    if (!string.IsNullOrWhiteSpace(o.IPProductionItemParentCode) && !parentCode.Contains(o.IPProductionItemParentCode))
                    {
                        messageError += string.Format("Mã chi tiết cha [{0}] không tồn tại.", o.IPProductionItemParentCode);
                        messageError += Environment.NewLine;
                    }

                    objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationNo).FirstOrDefault();
                    o.FK_MMOperationID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;
                    if (objOperationsInfo == null && string.IsNullOrWhiteSpace(o.MMOperationNo))
                        return;
                    else if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMOperationNo))
                    {
                        messageError += string.Format("Công đoạn [{0}] không tồn tại trong hệ thống.", o.MMOperationNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                    else if (objOperationsInfo != null && o.MMOperationName != objOperationsInfo.MMOperationName.Trim())
                    {
                        messageError += string.Format("Công đoạn [{0}] có tên khác với dữ liệu nguồn.", o.MMOperationNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                }
            });
            int count = IngredientPaintsList.Where(o => o.FK_MMPaintProcessID != 0).Select(o => o.FK_MMPaintProcessID).Count();
            int countAny = IngredientPaintsList.Where(o => o.FK_MMPaintProcessID != 0).Select(o => o.FK_MMPaintProcessID).Distinct().Count();
            if (count != countAny)
            {
                messageError += string.Format("File có chưa nhiều hơn một quy trình sơn giống nhau.");
                messageError += Environment.NewLine;
            }
            GeneralMaterialsList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.ICProductNo))
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == o.ICProductNo).FirstOrDefault();
                if (objProductsInfo == null)
                {
                    messageError += string.Format("Mã nguyên liệu [{0}] không tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objProductsInfo.ICProductName.Trim() != o.ICProductName)
                {
                    messageError += string.Format("Nguyên liệu [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.ICProductNo);
                    messageError += Environment.NewLine;
                }
                if (!string.IsNullOrWhiteSpace(o.IPProductionItemParentCode) && !parentCode.Contains(o.IPProductionItemParentCode))
                {
                    messageError += string.Format("Mã chi tiết cha [{0}] không tồn tại.", o.IPProductionItemParentCode);
                    messageError += Environment.NewLine;
                }

                objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationNo).FirstOrDefault();
                o.FK_MMOperationID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;
                if (objOperationsInfo == null && string.IsNullOrWhiteSpace(o.MMOperationNo))
                    return;
                else if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMOperationNo))
                {
                    messageError += string.Format("Công đoạn [{0}] không tồn tại trong hệ thống.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
                else if (objOperationsInfo != null && o.MMOperationName != objOperationsInfo.MMOperationName.Trim())
                {
                    messageError += string.Format("Công đoạn [{0}] có tên khác với dữ liệu nguồn.", o.MMOperationNo);
                    messageError += Environment.NewLine;
                    return;
                }
            });
            ProcessList.ForEach(o =>
            {
                o.IPProductionItemParentCode = o.IPProductionItemParentCode ?? string.Empty;
                if (string.IsNullOrWhiteSpace(o.MMProcessNo) && string.IsNullOrWhiteSpace(o.MMOperationNo))
                {
                    messageError += string.Format("Dữ liệu đầu vào không đúng định dạng");
                    messageError += Environment.NewLine;
                    return;
                }
                if (!string.IsNullOrWhiteSpace(o.MMProcessNo))
                {
                    objProcesssInfo = ProcessDataList.Where(p => p.MMProcessNo == o.MMProcessNo).FirstOrDefault();
                    o.FK_MMProcessID = objProcesssInfo == null ? 0 : objProcesssInfo.MMProcessID;
                    if (objProcesssInfo == null && !string.IsNullOrWhiteSpace(o.MMProcessNo))
                    {
                        messageError += string.Format("Quy trình sản xuất [{0}] không tồn tại trong hệ thống.", o.MMProcessNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                    else if (objProcesssInfo != null && o.MMProcessName != objProcesssInfo.MMProcessName.Trim())
                    {
                        messageError += string.Format("Quy trình sản xuất [{0}] có tên khác với dữ liệu nguồn.", o.MMOperationNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                }
                else
                {
                    objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationNo).FirstOrDefault();
                    o.FK_MMOperationID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;
                    if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMProcessNo))
                        return;
                    else if (objOperationsInfo == null)
                    {
                        messageError += string.Format("Công đoạn [{0}] không tồn tại trong hệ thống.", o.MMOperationNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                    objOperationsInfo = OperationsList.Where(p => p.MMOperationNo == o.MMOperationSynNo).FirstOrDefault();
                    o.FK_MMOperationSynID = objOperationsInfo == null ? 0 : objOperationsInfo.MMOperationID;
                    if (objOperationsInfo == null && !string.IsNullOrWhiteSpace(o.MMOperationSynNo))
                    {
                        messageError += string.Format("Công đoạn đồng bộ [{0}] không tồn tại trong hệ thống.", o.MMOperationSynNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                }
            });
            Dictionary<string, int> checkList = ProcessList.GroupBy(o => o.IPProductionItemParentCode).ToDictionary(o => o.Key, o => o.Where(c => c.ICProductItemProcessForParentSyncCheck).Count());
            foreach (var item in checkList)
            {
                if (item.Value > 1)
                {
                    messageError += string.Format("Bán thành phẩm [{0}] có hơn một công đoạn sử dụng để kiểm tra đồng bộ chi tiết cha!", item.Key);
                    messageError += Environment.NewLine;
                }
            }
            if (string.IsNullOrWhiteSpace(messageError))
                return true;

            messageError += "Vui lòng kiểm tra lại!";
            messageError += Environment.NewLine;
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}