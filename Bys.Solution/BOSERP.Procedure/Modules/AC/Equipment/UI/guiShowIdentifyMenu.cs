using BOSComponent;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using BOSReport;
using System.Data;
using BOSLib;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;

namespace BOSERP
{

    public partial class guiShowIdentifyMenu : BOSERPScreen
    {
        public List<ICProductIdentifiedEquipmentsInfo> IdentifyMenuList;
        public BOSGridControl ShowIdentifyMenuGridControl
        {
            get { return fld_dgcIdentifyMenu; }
        }
        public guiShowIdentifyMenu()
        {
            InitializeComponent();
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
        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            foreach (ICProductIdentifiedEquipmentsInfo item in IdentifyMenuList)
            {
                if (item != null)
                {
                    ////Save ProductInfo
                    //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    //if (objProductsInfo != null)
                    //{
                    //    objProductsInfo.ICProductOriginalAmount = item.ICProductOriginalAmount;
                    //    objProductsInfo.ICProductDepreciatedAmount = item.ICProductDepreciatedAmount;
                    //    objProductsInfo.ICProductDepreciationMonths = item.ICProductDepreciationMonths;
                    //    objProductsInfo.ICProductDepreciationMethod = item.ICProductDepreciationMethod;
                    //    objProductsInfo.ICProductSupplierPrice = item.ICProductSupplierPrice;
                    //    objProductsInfo.FK_ACAccountID = item.FK_ACAccountID;
                    //    objProductsInfo.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    //    objProductsInfo.FK_ACDepreciationAccountID = item.FK_ACDepreciationAccountID;
                    //    objProductsController.UpdateObject(objProductsInfo);
                    //}
                    //Save ProductIdentifiedEquipments
                    objProductIdentifiedEquipmentsController.UpdateObject(item);
                }
            }
        }

        private void guiShowIdentifyMenu_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            InitDatasource();
        }

        private void fld_bedICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            ShowCategoryTree();

        }
        private int ProductGroupID = 0;
        public void ShowCategoryTree()
        {
            int departmentID = 0;
            departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedICProductGroupID.EditValue));
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.AllowMultipleSelect = true;
            guiProductGroupTree.Module = this.Module;
            guiProductGroupTree.ICDepartmentID = departmentID;

            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    fld_bedICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    ProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    fld_bedICProductGroupID.Text = String.Empty;
                    ProductGroupID = 0;
                }
            }
        }
        public void InitDatasource()
        {
            int departmentID = 0;
            if (fld_lkeFK_ICDepartmentID.EditValue != null)
            {
                departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            }
            string name = string.Empty;
            name = fld_txtCCDCName.Text;
            bool isInventory = false;
            if(fld_ckICProductIsInventory.EditValue != null)
            {
                isInventory = Convert.ToBoolean(fld_ckICProductIsInventory.EditValue);
            }

            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            //  List<ICProductIdentifiedEquipmentsInfo> IdentifyMenuList = (List<ICProductIdentifiedEquipmentsInfo>)objProductIdentifiedEquipmentsController.GetIdentifiedForShowIndentifyMenu();
            List<ICProductIdentifiedEquipmentsInfo> IdentifyMenuList = objProductIdentifiedEquipmentsController.GetIdentifiedForShowIndentifyMenuBySomeCondition(departmentID, ProductGroupID, name, isInventory);


            if (IdentifyMenuList != null)
            {
                fld_dgcIdentifyMenu.DataSource = IdentifyMenuList;
                if (this.IdentifyMenuList == null)
                {
                    this.IdentifyMenuList = new List<ICProductIdentifiedEquipmentsInfo>();
                }
                this.IdentifyMenuList = IdentifyMenuList;
            }
        }
        private void fld_btnView_Click(object sender, EventArgs e)
        {
            InitDatasource();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            RPEquipmentSummary report = new RPEquipmentSummary();

            XRLabel companyName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCompanyName"];
            if (companyName != null)
                companyName.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc.ToUpper();
            XRLabel companyAddressLine = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCompanyAddressLine1"];
            if (companyAddressLine != null)
                companyAddressLine.Text = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
           
            report.DataSource = fld_dgcIdentifyMenu.DataSource;
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }
    }
}
