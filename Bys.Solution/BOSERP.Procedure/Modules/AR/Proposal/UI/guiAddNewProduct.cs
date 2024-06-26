using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public partial class guiAddNewProduct<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public ICProductsInfo ProductsInfo { get; set; }

        public string ProductType { get; set; }

        public string ModuleName { get; set; }

        #endregion

        public guiAddNewProduct(string productType)
        {
            InitializeComponent();
            ProductsInfo = new ICProductsInfo();
            ProductType = productType;
        }

        private void guiAddNewProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lkeICProductType.EditValue = ProductType;
            fld_txtICProductNo.Text = "***NEW***";
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ProductsInfo.ICProductName = fld_txtICProductName.Text;
            ProductsInfo.ICProductDesc = fld_medICProductDesc.Text;
            ProductsInfo.ICProductGroupName = fld_bedFK_ICProductGroupID.Text;
            ProductsInfo.FK_APSupplierID = (int)fld_lkeFK_APSupplierID.EditValue;
            ProductsInfo.ICProductBarCode = fld_txtICProductBarCode.Text;
            ProductsInfo.FK_ACAccountID = (int)fld_lkeFK_ACAccountID.EditValue;
            ProductsInfo.ICProductWorkType = (string)fld_lkeICProductWorkType.EditValue;
            ProductsInfo.FK_ICProductWorkGroupID = (int)fld_lkeFK_ICProductWorkGroupID.EditValue;
            ProductsInfo.ICProductPrice01 = Decimal.Parse(fld_txtICProductPrice01.Text);
            ProductsInfo.ICProductSupplierPrice = Decimal.Parse(fld_txtICProductSupplierPrice.Text);
            ProductsInfo.FK_GEVATID = (int)fld_lkeFK_GEVATID.EditValue;
            ProductsInfo.FK_ICProductBasicUnitID = (int)fld_lkeFK_ICProductBasicUnitID.EditValue;
            ProductsInfo.ICProductActiveCheck = fld_chkICProductActiveCheck.Checked;
            ProductsInfo.ICProductType = ProductType;
            ProductsInfo.AACreatedUser = BOSApp.CurrentUser;
            ProductsInfo.ICProductNo = GetProductNo(ProductsInfo);

            if (String.IsNullOrEmpty(ProductsInfo.ICProductName))
                return;

            ICProductsController objProductsController = new ICProductsController();
            objProductsController.CreateObject(ProductsInfo);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string department = String.Empty;
            if (ProductType == BOSCommon.ProductType.Section.ToString())
            {
                department = BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.SectionNo.ToString());
                ModuleName = "SectionProduct";
            }
            else if (ProductType == BOSCommon.ProductType.Work.ToString())
            {
                department = BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.WorkNo.ToString());
                ModuleName = "WorkProduct";
            }
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(department);
            int departmentID = 1;
            int productGroupID = 0;
            if (objICDepartmentsInfo != null)
                departmentID = objICDepartmentsInfo.ICDepartmentID;

            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, productGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    ProductsInfo.FK_ICDepartmentID = guiProductGroupTree.ICDepartmentID;
                    ProductsInfo.FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                }
                else
                {
                    ProductsInfo.FK_ICProductGroupID = 0;
                }
                fld_bedFK_ICProductGroupID.Text = objProductGroupsInfo.ICProductGroupName;
            }
        }

        private string GetProductNo(ICProductsInfo objProductsInfo)
        {
            String productNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(ModuleName, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo != null)
            {
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(TableName.ICProductsTableName + "Controller");
                if (objMainObjectController != null)
                {
                    productNo = String.Format("{0}{1}",
                                                    objGENumberingInfo.GENumberingPrefix,
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    objGENumberingInfo.GENumberingStart++;
                    while (objMainObjectController.IsExist(productNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        productNo = String.Format("{0}{1}",
                                                        objGENumberingInfo.GENumberingPrefix,
                                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    }

                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
            }
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objProductsInfo.FK_ICDepartmentID);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
            if (objProductGroupsInfo != null)
            {
                objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                productNo = string.Format("{0}{1}", objProductGroupsInfo.ICProductGroupNo, productNo);
            }
            if (objDepartmentsInfo != null)
            {
                productNo = string.Format("{0}{1}", objDepartmentsInfo.ICDepartmentNo, productNo);
            }
            return productNo;
        }
    }
}