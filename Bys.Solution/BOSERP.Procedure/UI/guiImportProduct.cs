using BOSCommon;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiImportProduct : BOSERPScreen
    {
        public List<IPImportProductsInfo> ProductsList { get; set; }

        private List<ICMeasureUnitsInfo> ListMeasureUnitsInfo { get; set; }

        private List<ACAccountsInfo> ListAccountsInfo { get; set; }

        private List<ICDepartmentsInfo> ListDepartmentsInfo { get; set; }

        private List<ICProductGroupsInfo> ListProductGroupsInfo { get; set; }

        private List<ARCustomersInfo> ListCustomersInfo { get; set; }

        private List<ICProductAttributesInfo> ListProductAttributesInfo { get; set; }

        public guiImportProduct(List<IPImportProductsInfo> productsList)
        {
            InitializeComponent();
            ProductsList = productsList;

            DataSet ds = new DataSet();
            ListMeasureUnitsInfo = new List<ICMeasureUnitsInfo>();
            if (BOSApp.LookupTables.Contains("ICMeasureUnits"))
            {
                ListMeasureUnitsInfo = (List<ICMeasureUnitsInfo>)(new ICMeasureUnitsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICMeasureUnits"]);
            }    
            else
            {
                ListMeasureUnitsInfo = (new ICMeasureUnitsController()).GetAllAliveMeasureUnit();
            }

            ListAccountsInfo = new List<ACAccountsInfo>();
            if (BOSApp.LookupTables.Contains("ACAccounts"))
            {
                ListAccountsInfo = (List<ACAccountsInfo>)(new ACAccountsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ACAccounts"]);
            }
            else
            {
                ListAccountsInfo = (new ACAccountsController()).GetAllAccountList();
            }

            ListDepartmentsInfo = new List<ICDepartmentsInfo>();
            if (BOSApp.LookupTables.Contains("ICDepartments"))
            {
                ListDepartmentsInfo = (List<ICDepartmentsInfo>)(new ICDepartmentsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICDepartments"]);
            }
            else
            {
                ListDepartmentsInfo = (new ICDepartmentsController()).GetallObjects();
            }

            ListProductGroupsInfo = new List<ICProductGroupsInfo>();
            if (BOSApp.LookupTables.Contains("ICProductGroups"))
            {
                ListProductGroupsInfo = (List<ICProductGroupsInfo>)(new ICProductGroupsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICProductGroups"]);
            }
            else
            {
                ListProductGroupsInfo = (new ICProductGroupsController()).GetAllObjectList();
            }

            ListCustomersInfo = new List<ARCustomersInfo>();
            if (BOSApp.LookupTables.Contains("ARCustomers"))
            {
                ListCustomersInfo = (List<ARCustomersInfo>)(new ARCustomersController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ARCustomers"]);
            }
            else
            {
                ListCustomersInfo = (new ARCustomersController()).GetAllCustomer();
            }

            ListProductAttributesInfo = new List<ICProductAttributesInfo>();
            if (BOSApp.LookupTables.Contains("ICProductAttributes"))
            {
                ListProductAttributesInfo = (List<ICProductAttributesInfo>)(new ICProductAttributesController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICProductAttributes"]);
            }
            else
            {
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                ds = objProductAttributesController.GetCatcheData();
                ListProductAttributesInfo = (List<ICProductAttributesInfo>)objProductAttributesController.GetListFromDataSet(ds);
            }
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

        private void guiImportProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcProductsGridControl.InvalidateDataSource(ProductsList, this.Module.Name);
            fld_dgcProductsGridControl.Visible = true;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApproveImportBOM_Click(object sender, EventArgs e)
        {
            if(this.Module.Name == "Product")
            {
                if (!IsValidSaveProduct())
                {
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool IsValidSaveProduct()
        {         
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            ICDepartmentsInfo objDepartmentsInfo = new ICDepartmentsInfo();
            ICProductGroupsInfo objProductGroupsInfo1 = new ICProductGroupsInfo();
            ICProductGroupsInfo objProductGroupsInfo2 = new ICProductGroupsInfo();
            ARCustomersInfo objCustomersInfo = new ARCustomersInfo();

            DateTime shipmentDate = BOSApp.GetCurrentServerDate();
            ICProductsForViewInfo checkProductsInfo = new ICProductsForViewInfo();
            ProductsList.ForEach(o =>
            {
                o.MessageError = string.Empty;
                checkProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(f => f.ICProductNo.Trim().ToLower() == o.ICProductNo.Trim().ToLower());
                if(checkProductsInfo != null)
                {
                    o.MessageError += "Mã sản phẩm đã tồn tại";
                    return;
                }
                
                if (!string.IsNullOrWhiteSpace(o.ICMeasureUnitName))
                {
                    objMeasureUnitsInfo = ListMeasureUnitsInfo.FirstOrDefault(f => f.ICMeasureUnitName.Trim().ToLower() == o.ICMeasureUnitName.Trim().ToLower());
                    if(objMeasureUnitsInfo != null)
                    {
                        o.FK_ICProductBasicUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
                        o.FK_ICProductPurchaseUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
                        o.FK_ICProductSaleUnitID =objMeasureUnitsInfo.ICMeasureUnitID;
                    }
                    else
                    {
                        o.MessageError += Environment.NewLine + "Đơn vị tính";
                    }    
                }

                if (!string.IsNullOrWhiteSpace(o.ICDepartmentNo))
                {
                    objDepartmentsInfo = ListDepartmentsInfo.FirstOrDefault(f => f.ICDepartmentNo.Trim().ToLower() == o.ICDepartmentNo.Trim().ToLower());
                    if (objDepartmentsInfo == null)
                    {
                        objDepartmentsInfo = ListDepartmentsInfo.FirstOrDefault(f => f.ICDepartmentName.Trim().ToLower() == o.ICDepartmentNo.Trim().ToLower());
                    }
                    if(objDepartmentsInfo != null)
                    {
                        o.FK_ICDepartmentID = objDepartmentsInfo.ICDepartmentID;
                        if (!string.IsNullOrWhiteSpace(o.ICProductGroup1No))
                        {
                            objProductGroupsInfo1 = ListProductGroupsInfo.FirstOrDefault(f => f.ICProductGroupNo.Trim().ToLower() == o.ICProductGroup1No.Trim().ToLower()
                                                                                            && f.FK_ICDepartmentID == objDepartmentsInfo.ICDepartmentID
                                                                                            && f.ICProductGroupParentID == 0);
                            if(objProductGroupsInfo1 != null)
                            {
                                if (!string.IsNullOrWhiteSpace(o.ICProductGroup2No))
                                {
                                    objProductGroupsInfo2 = ListProductGroupsInfo.FirstOrDefault(f => f.ICProductGroupNo.Trim().ToLower() == o.ICProductGroup2No.Trim().ToLower()
                                                                                            && f.FK_ICDepartmentID == objDepartmentsInfo.ICDepartmentID
                                                                                            && f.ICProductGroupParentID == objProductGroupsInfo1.ICProductGroupID);
                                    if (objProductGroupsInfo2 != null)
                                    {
                                        o.FK_ICProductGroupID = objProductGroupsInfo2.ICProductGroupID;
                                    }
                                    else
                                    {
                                        o.MessageError += Environment.NewLine + "Nhóm hàng 2";
                                    }
                                }   
                                else
                                {
                                    o.FK_ICProductGroupID = objProductGroupsInfo1.ICProductGroupID;
                                }    
                            }
                            else
                            {
                                o.MessageError += Environment.NewLine + "Nhóm hàng 1";
                            }
                        }
                    }
                    else
                    {
                        o.MessageError += Environment.NewLine + "Ngành hàng";
                    }
                }

                if(!string.IsNullOrWhiteSpace(o.ARCustomerName))
                {
                    objCustomersInfo = ListCustomersInfo.FirstOrDefault(f => f.ARCustomerName.Trim().ToLower() == o.ARCustomerName.Trim().ToLower());
                    if (objCustomersInfo == null)
                    {
                        objCustomersInfo = ListCustomersInfo.FirstOrDefault(f => f.ARCustomerNo.Trim().ToLower() == o.ARCustomerName.Trim().ToLower());
                    }
                    if (objCustomersInfo == null)
                    {
                        objCustomersInfo = ListCustomersInfo.FirstOrDefault(f => f.ARCustomerNoOfOldSys.Trim().ToLower() == o.ARCustomerName.Trim().ToLower());
                    }
                    if (objCustomersInfo != null)
                    {
                        o.FK_ARCustomerID = objCustomersInfo.ARCustomerID;
                    }
                    else
                    {
                        o.MessageError += Environment.NewLine + "Khách hàng";
                    }
                }


                o.MessageError = o.MessageError.TrimStart();
            });

            fld_dgcProductsGridControl?.RefreshDataSource();
            if (ProductsList.FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.MessageError)) != null)
            {
                MessageBox.Show("Dữ liệu import chưa khớp với Master Data"
                                + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}