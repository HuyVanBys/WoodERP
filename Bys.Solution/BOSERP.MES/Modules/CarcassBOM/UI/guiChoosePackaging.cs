using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiChoosePackaging : BOSERPScreen
    {
        List<ICProductsInfo> objProductsInfoList;
        public string MessageStr = string.Empty;
        public ICProductsInfo Product;
        MMProductionNormItemsInfo ProductionNormItem;
        public decimal Factor = 0;
        public guiChoosePackaging(MMProductionNormItemsInfo pnItem)
        {
            InitializeComponent();

            ProductionNormItem = pnItem;
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

        public void SearchData()
        {
            decimal factor = 0;
            decimal.TryParse(fld_txtDiffFactor.Text, out factor);

            Factor = factor;

            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> productList = productController.GetProductMaterialForPackagingByDiffFactor(ProductionNormItem.FK_ICProdAttPackingMaterialSpecialityID
                                                                                               , ProductionNormItem.FK_ICProdAttPackingMaterialSizeID
                                                                                               , ProductionNormItem.FK_ICProdAttPackingMaterialWeightPerVolumeID
                                                                                               , ProductionNormItem.MMProductionNormItemProductInsideDimensionLength
                                                                                               , ProductionNormItem.MMProductionNormItemProductInsideDimensionWidth
                                                                                               , ProductionNormItem.MMProductionNormItemProductInsideDimensionHeight
                                                                                               , factor); // Dung sai

            string message = string.Empty;

            if (productList.Count == 0)
            {
                message = "Không tìm thấy Phụ liệu đóng phù hợp";
            }
            else
            {
                message = "Vui lòng chọn Phụ liệu đóng gói";
            }

            objProductsInfoList = productList;
            MessageStr = message;

            fld_dgcSemiProduct1.DataSource = objProductsInfoList;
            fld_txtMessage.Text = MessageStr;
        }

        private void guiChoosePackaging_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_txtName.Text = ProductionNormItem.MMProductionNormItemProductName;
            fld_txtWidth.Text = ProductionNormItem.MMProductionNormItemProductInsideDimensionWidth.ToString("N0");
            fld_txtHeight.Text = ProductionNormItem.MMProductionNormItemProductInsideDimensionHeight.ToString("N0");
            fld_txtLength.Text = ProductionNormItem.MMProductionNormItemProductInsideDimensionLength.ToString("N0");
            fld_lkeDL.EditValue = ProductionNormItem.FK_ICProdAttPackingMaterialWeightPerVolumeID;
            fld_lkeDT.EditValue = ProductionNormItem.FK_ICProdAttPackingMaterialSpecialityID;
            fld_lkeKMF.EditValue = ProductionNormItem.FK_ICProdAttPackingMaterialSizeID;
            fld_txtDiffFactor.Text = ProductionNormItem.MMProductionNormItemDiffFactor.ToString("N0");

            SearchData();




            GridView gridView = (GridView)fld_dgcSemiProduct1.MainView;
            if (gridView != null)
            {
                gridView.BestFitColumns();
            }
        }



        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            //CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
            //ICProductsInfo selectedItem = entity.ProductItemList.FirstOrDefault(item => item.Selected);
            //if (selectedItem == null)
            //    MessageBox.Show("Vui lòng chọn BTP con cho cụm được chọn.");
            //else
            //{
            this.DialogResult = DialogResult.OK;
            this.Close();
            // }
        }

        private void fld_btnSaveProductionNormItemMeterial_Click(object sender, EventArgs e)
        {
            //((CarcassBOMModule)Module).SaveProductMaterial(ProductID);
        }

        private void fld_btnChooseProcess_Click(object sender, EventArgs e)
        {
            //((CarcassBOMModule)Module).ChooseProcess(ProductID);
        }

        private void bosButton3_Click(object sender, EventArgs e)
        {
            //int operationID = 0;
            //if (fld_lkeMMOperationID.EditValue != null)
            //{
            //    int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
            //}
            //((CarcassBOMModule)Module).ChooseProcessOperation(ProductID, operationID);

        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            //((CarcassBOMModule)Module).SaveProductProcess(ProductID);
        }

        private void fld_lkeMMProcessID_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    int processID = 0;

            //    if (fld_lkeMMProcessID.EditValue != null)
            //    {
            //        int.TryParse(fld_lkeMMProcessID.EditValue.ToString(), out processID);
            //    }

            //    ((CarcassBOMModule)Module).ChooseProcess(ProductID, processID);
            //}
        }

        private void fld_lkeMMOperationID_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    int processID = 0;

            //    if (fld_lkeMMOperationID.EditValue != null)
            //    {
            //        int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out processID);
            //    }

            //    ((CarcassBOMModule)Module).ChooseProcessOperation(ProductID, processID);
            //}
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            ICProductsInfo product = objProductsInfoList.FirstOrDefault(t => t.Selected);
            if (product == null)
            {
                MessageBox.Show("Vui lòng chọn Phụ liệu đóng gói"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
            else
            {
                Product = product;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void fld_btnCreate_Click(object sender, EventArgs e)
        {
            if (DepartmentID == 0
                || ProductGroupID == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhóm hàng"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(fld_txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phụ liệu đóng gói"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
            else
            {
                MMOverallInsideDimensionConfigsController objOverallInsideDimensionConfigsController = new MMOverallInsideDimensionConfigsController();
                List<MMOverallInsideDimensionConfigsInfo> overallInsideDimensionConfigsList = new List<MMOverallInsideDimensionConfigsInfo>();
                MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo = new MMOverallInsideDimensionConfigsInfo();

                Product = new ICProductsInfo();
                Product.ICProductType = ProductType.IngredientPackaging.ToString();
                Product.FK_ICProductBasicUnitID = ProductionNormItem.FK_ICMeasureUnitID;
                Product.ICProductName = fld_txtName.Text;

                Product.ICProductInsideDimensionHeight = ProductionNormItem.MMProductionNormItemProductInsideDimensionHeight;
                Product.ICProductInsideDimensionWidth = ProductionNormItem.MMProductionNormItemProductInsideDimensionWidth;
                Product.ICProductInsideDimensionLength = ProductionNormItem.MMProductionNormItemProductInsideDimensionLength;

                overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(ProductionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Height.ToString(), ProductGroupID);
                objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                if (objOverallInsideDimensionConfigsInfo != null)
                {
                    ProductionNormItem.MMProductionNormItemProductOverallDimensionHeight = ((CarcassBOMModule)Module).CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                       ProductionNormItem.MMProductionNormItemProductInsideDimensionHeight);
                }
                else
                    ProductionNormItem.MMProductionNormItemProductOverallDimensionHeight = 0;

                overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(ProductionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Width.ToString(), ProductGroupID);
                objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                if (objOverallInsideDimensionConfigsInfo != null)
                {
                    ProductionNormItem.MMProductionNormItemProductOverallDimensionWidth = ((CarcassBOMModule)Module).CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                       ProductionNormItem.MMProductionNormItemProductInsideDimensionWidth);
                }
                else
                    ProductionNormItem.MMProductionNormItemProductOverallDimensionWidth = 0;

                overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(ProductionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Length.ToString(), ProductGroupID);
                objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                if (objOverallInsideDimensionConfigsInfo != null)
                {
                    ProductionNormItem.MMProductionNormItemProductOverallDimensionLength = ((CarcassBOMModule)Module).CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                       ProductionNormItem.MMProductionNormItemProductInsideDimensionLength);
                }
                else
                    ProductionNormItem.MMProductionNormItemProductOverallDimensionLength = 0;

                Product.ICProductOverallDimensionHeight = ProductionNormItem.MMProductionNormItemProductOverallDimensionHeight;
                Product.ICProductOverallDimensionWidth = ProductionNormItem.MMProductionNormItemProductOverallDimensionWidth;
                Product.ICProductOverallDimensionLength = ProductionNormItem.MMProductionNormItemProductOverallDimensionLength;

                Product.FK_ICProdAttPackingMaterialSizeID = ProductionNormItem.FK_ICProdAttPackingMaterialSizeID;
                Product.FK_ICProdAttPackingMaterialSpecialityID = ProductionNormItem.FK_ICProdAttPackingMaterialSpecialityID;
                Product.FK_ICProdAttPackingMaterialWeightPerVolumeID = ProductionNormItem.FK_ICProdAttPackingMaterialWeightPerVolumeID;

                SetDefaultProductDesc(Product);
                Product.FK_ICDepartmentID = DepartmentID;
                Product.FK_ICProductGroupID = ProductGroupID;
                ProductionNormItem.FK_ICProductGroupID = ProductGroupID;
                GeneratePackagingNo(Product);

                ICProductsController pController = new ICProductsController();
                pController.CreateObject(Product);

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        public void GeneratePackagingNo(ICProductsInfo product)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID("PackagingProduct", BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objGENumberingInfo != null)
            {
                ICProductsController pController = new ICProductsController();
                if (pController != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    strMainObjectNo = String.Format("{0}{1}",
                                                    objGENumberingInfo.GENumberingPrefix,
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    int numberingStart = objGENumberingInfo.GENumberingStart;
                    while (pController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = String.Format("{0}{1}",
                                                        objGENumberingInfo.GENumberingPrefix,
                                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }

                    objGENumberingInfo.GENumberingStart = numberingStart + 1;
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }


                ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(DepartmentID);
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(ProductGroupID);
                if (objProductGroupsInfo != null)
                {
                    objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                    strMainObjectNo = string.Format("{0}{1}", objProductGroupsInfo.ICProductGroupNo, strMainObjectNo);
                }
                if (objDepartmentsInfo != null)
                {
                    strMainObjectNo = string.Format("{0}{1}", objDepartmentsInfo.ICDepartmentNo, strMainObjectNo);
                }

                product.ICProductNo = strMainObjectNo;
            }
        }

        public void SetDefaultProductDesc(ICProductsInfo objProductsInfo)
        {
            objProductsInfo.ICProductDesc = objProductsInfo.ICProductName;
            if (objProductsInfo.ICProductInsideDimensionHeight > 0 || objProductsInfo.ICProductInsideDimensionWidth > 0 || objProductsInfo.ICProductInsideDimensionLength > 0)
            {
                objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : ", {0}", (int)objProductsInfo.ICProductInsideDimensionLength) + "x"
                                                                             + (int)objProductsInfo.ICProductInsideDimensionWidth + "x"
                                                                             + (int)objProductsInfo.ICProductInsideDimensionHeight;
            }
            if (objProductsInfo.ICProductOverallDimensionHeight > 0 || objProductsInfo.ICProductOverallDimensionWidth > 0 || objProductsInfo.ICProductOverallDimensionLength > 0)
            {
                objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : ", {0}", (int)objProductsInfo.ICProductOverallDimensionLength) + "x"
                                                                             + (int)objProductsInfo.ICProductOverallDimensionWidth + "x"
                                                                             + (int)objProductsInfo.ICProductOverallDimensionHeight;
            }
            if (objProductsInfo.ICProductSizeAndSpecifiCations != string.Empty)
            {
                objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : ", {0}", objProductsInfo.ICProductSizeAndSpecifiCations);
            }
            if (objProductsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
            {
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProdAttPackingMaterialSpecialityID);
                if (objProductAttributesInfo != null)
                {
                    objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : ", {0}", objProductAttributesInfo.ICProductAttributeValue);
                }
            }

        }

        int ProductGroupID = 0;
        int DepartmentID = 0;
        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.IngredientPackagingNo.ToString()));
            int departmentID = 1;
            if (objICDepartmentsInfo != null)
                departmentID = objICDepartmentsInfo.ICDepartmentID;

            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, ProductGroupID, ProductType.IngredientPackaging.ToString());
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    DepartmentID = guiProductGroupTree.ICDepartmentID;
                    ProductGroupID = objProductGroupsInfo.ICProductGroupID;

                    fld_bedFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    ProductGroupID = 0;
                    fld_bedFK_ICProductGroupID.Text = string.Empty;
                }

            }
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
