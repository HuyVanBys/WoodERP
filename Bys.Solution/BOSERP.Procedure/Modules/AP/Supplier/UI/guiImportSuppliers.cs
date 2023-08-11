using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Supplier
{
    public partial class guiImportSuppliers : BOSERPScreen
    {
        public List<IPSuppliersInfo> SuppliersList { get; set; }

        public List<BRBranchsInfo> listBranchsInfo = new List<BRBranchsInfo>();
        public List<GECountrysInfo> listCountrysInfo = new List<GECountrysInfo>();
        public List<GEStateProvincesInfo> listStateProvincesInfo = new List<GEStateProvincesInfo>();
        public List<GEDistrictsInfo> listDistrictsInfo = new List<GEDistrictsInfo>();
        public List<APSupplierTypeAccountConfigsInfo> listSupplierTypeAccountConfigsInfo = new List<APSupplierTypeAccountConfigsInfo>();
        public List<ACAccountsInfo> listAccountsInfo = new List<ACAccountsInfo>();
        public List<GECurrenciesInfo> listCurrenciesInfo = new List<GECurrenciesInfo>();
        public List<GEPaymentTermsInfo> listPaymentTermsInfo = new List<GEPaymentTermsInfo>();
        public List<ADConfigValuesInfo> listConfigValuesInfo = new List<ADConfigValuesInfo>();
        //public List<IPDepartmentAttributesInfo> DepartmentAttributesList { get; set; }

        //private List<ICProductTypeAccountConfigsInfo> ListTypeAccountConfigs { get; set; }

        public guiImportSuppliers(List<IPSuppliersInfo> itemsList)
        {
            InitializeComponent();
            SuppliersList = itemsList;

            APSuppliersController objSuppliersController = new APSuppliersController();
            BRBranchsController objBranchsController = new BRBranchsController();
            GECountrysController objCountrysController = new GECountrysController();
            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            GEDistrictsController objDistrictsController = new GEDistrictsController();
            APSupplierTypeAccountConfigsController objSupplierTypeAccountConfigsController = new APSupplierTypeAccountConfigsController();
            ACAccountsController objAccountsController = new ACAccountsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

            listBranchsInfo = objBranchsController.GetAllBranches();
            listCountrysInfo = objCountrysController.GetAllCountryAlive();
            listStateProvincesInfo = objStateProvincesController.getAllAliveStateProvinces();
            listDistrictsInfo = objDistrictsController.GetAllDistricts();
            listSupplierTypeAccountConfigsInfo = objSupplierTypeAccountConfigsController.GetAllAliveSupplierTypeAccountConfig();
            listAccountsInfo = objAccountsController.GetAllAccountList();
            listCurrenciesInfo = objCurrenciesController.GetAllCurrencys();
            listPaymentTermsInfo = objPaymentTermsController.GetAllPaymentTerms();
            listConfigValuesInfo = objConfigValuesController.GetAllConfigValues();

            //DepartmentAttributesList = departmentAttributesList;

            //ListTypeAccountConfigs = new List<ICProductTypeAccountConfigsInfo>();
            //if (BOSApp.LookupTables.Contains("ICProductTypeAccountConfigs"))
            //{
            //    ListTypeAccountConfigs = (List<ICProductTypeAccountConfigsInfo>)(new ICProductTypeAccountConfigsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICProductTypeAccountConfigs"]);
            //}
            //else
            //{
            //    ListTypeAccountConfigs = (new ICProductTypeAccountConfigsController()).GetAllAliveProductTypeAccountConfig();
            //}
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

        private void guiImportSuppliers_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcIPSuppliers.InvalidateDataSource(SuppliersList);
            fld_dgcIPSuppliers.Visible = true;

            //fld_dgcIPDepartmentAttributes.InvalidateDataSource(DepartmentAttributesList);
            //fld_dgcIPDepartmentAttributes.Visible = true;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApproveImport_Click(object sender, EventArgs e)
        {
            if (!IsValidSaveSuppliers())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool IsValidSaveSuppliers()
        {
            
            SuppliersList.ForEach(item =>
            {
                ValidateSupplierImport(item);
            });
            //DepartmentAttributesList.ForEach(o =>
            //{
            //    ValidateDepartmentAttributeImport(o);
            //});
            fld_dgcIPSuppliers.RefreshDataSource();
            //fld_dgcIPDepartmentAttributes.RefreshDataSource();

            if (SuppliersList.FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.MessageError)) != null)
                //|| DepartmentAttributesList.FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.MessageError)) != null)
            {
                MessageBox.Show("Dữ liệu import chưa phù hợp. Vui lòng kiểm tra lại!"
                            , CommonLocalizedResources.MessageBoxDefaultCaption
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void ValidateSupplierImport(IPSuppliersInfo item)
        {
            //APSuppliersController objSuppliersController = new APSuppliersController();
            //BRBranchsController objBranchsController = new BRBranchsController();
            //GECountrysController objCountrysController = new GECountrysController();
            //GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            //GEDistrictsController objDistrictsController = new GEDistrictsController();
            //APSupplierTypeAccountConfigsController objSupplierTypeAccountConfigsController = new APSupplierTypeAccountConfigsController();
            //ACAccountsController objAccountsController = new ACAccountsController();
            //GECurrenciesController objCurrenciesController = new GECurrenciesController();
            //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
            //ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

            //List<BRBranchsInfo> listBranchsInfo = new List<BRBranchsInfo>();
            //List<GECountrysInfo> listCountrysInfo = new List<GECountrysInfo>();
            //List<GEStateProvincesInfo> listStateProvincesInfo = new List<GEStateProvincesInfo>();
            //List<GEDistrictsInfo> listDistrictsInfo = new List<GEDistrictsInfo>();
            //List<APSupplierTypeAccountConfigsInfo> listSupplierTypeAccountConfigsInfo = new List<APSupplierTypeAccountConfigsInfo>();
            //List<ACAccountsInfo> listAccountsInfo = new List<ACAccountsInfo>();
            //List<GECurrenciesInfo> listCurrenciesInfo = new List<GECurrenciesInfo>();
            //List<GEPaymentTermsInfo> listPaymentTermsInfo = new List<GEPaymentTermsInfo>();
            //List<ADConfigValuesInfo> listConfigValuesInfo = new List<ADConfigValuesInfo>();

            IPSuppliersInfo objSuppliersInfo = new IPSuppliersInfo();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            BRBranchsInfo objBranchsInfo = new BRBranchsInfo();
            GECountrysInfo objCountrysInfo = new GECountrysInfo();
            GEStateProvincesInfo objStateProvincesInfo = new GEStateProvincesInfo();
            GEDistrictsInfo objDistrictsInfo = new GEDistrictsInfo();
            APSupplierTypeAccountConfigsInfo objSupplierTypeAccountConfigsInfo = new APSupplierTypeAccountConfigsInfo();
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            GECurrenciesInfo objCurrenciesInfo = new GECurrenciesInfo();
            GEPaymentTermsInfo objPaymentTermsInfo = new GEPaymentTermsInfo();

            item.MessageError = string.Empty;
            if (SuppliersList.Exists(o => string.IsNullOrWhiteSpace(o.IPSupplierNo)))
            {
                item.MessageError += Environment.NewLine + "Mã NCC không được để trống!";
            }
            if (SuppliersList.Exists(o => string.IsNullOrWhiteSpace(o.IPSupplierContactAddressLine1)))
            {
                //item.MessageError += Environment.NewLine + "Địa chỉ không được để trống!";
            }
            if (SuppliersList.Exists(o => string.IsNullOrWhiteSpace(o.FK_GECountryID)))
            {
                //item.MessageError += Environment.NewLine + "Quốc gia không được để trống!";
            }
            if (SuppliersList.Exists(o => string.IsNullOrWhiteSpace(o.FK_GEStateProvinceID)))
            {
                //item.MessageError += Environment.NewLine + "Tỉnh/TP không được để trống!";
            }
            if (SuppliersList.Exists(o => string.IsNullOrWhiteSpace(o.FK_APSupplierTypeAccountConfigID)))
            {
                item.MessageError += Environment.NewLine + "Nhóm tài khoản không được để trống!";
            }
            if (!string.IsNullOrWhiteSpace(item.IPSupplierOtherType))
            {
                //objConfigValuesInfo = listConfigValuesInfo.Where(x => x.ADConfigKeyGroup == ConfigValueGroup.SupplierOtherType.ToString() && x.ADConfigText == item.IPSupplierOtherType).FirstOrDefault();
                //if (objConfigValuesInfo == null)
                //{
                //    item.MessageError += Environment.NewLine + "Loại NCC không hợp lệ!";
                //}
                //else
                //{
                //    item.SupplierOtherType = objConfigValuesInfo.ADConfigKeyValue;
                //}
                item.SupplierOtherType = "Company";
            }
            if (!string.IsNullOrWhiteSpace(item.IPSupplierTypeCombo))
            {
                objConfigValuesInfo = listConfigValuesInfo.Where(x => x.ADConfigKeyGroup == ConfigValueGroup.SupplierType.ToString() && x.ADConfigText == item.IPSupplierTypeCombo).FirstOrDefault();
                if (objConfigValuesInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Loại không hợp lệ!";
                }
                else
                {
                    item.SupplierTypeCombo = objConfigValuesInfo.ADConfigKeyValue;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.APPaymentMethodCombo))
            {
                objConfigValuesInfo = listConfigValuesInfo.Where(x => x.ADConfigKeyGroup == ConfigValueGroup.PaymentMethod.ToString() && x.ADConfigText == item.APPaymentMethodCombo).FirstOrDefault();
                if (objConfigValuesInfo == null)
                {
                    //item.MessageError += Environment.NewLine + "Phương thức thanh toán không hợp lệ!";
                }
                else
                {
                    item.PaymentMethodCombo = objConfigValuesInfo.ADConfigKeyValue;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_BRBranchID))
            {
                objBranchsInfo = listBranchsInfo.Where(x => x.BRBranchName == item.FK_BRBranchID).FirstOrDefault();
                if (objBranchsInfo == null)
                {
                    //item.MessageError += Environment.NewLine + "Chi nhánh không hợp lệ!";
                    item.BRBranchID = 1;
                }
                else
                {
                    item.BRBranchID = objBranchsInfo.BRBranchID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_GECountryID))
            {
                objCountrysInfo = listCountrysInfo.Where(x => x.GECountryName == item.FK_GECountryID).FirstOrDefault();
                if (objCountrysInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Quốc gia không hợp lệ!";
                }
                else
                {
                    item.GECountryID = objCountrysInfo.GECountryID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_GEStateProvinceID))
            {
                objStateProvincesInfo = listStateProvincesInfo.Where(x => x.GEStateProvinceName == item.FK_GEStateProvinceID).FirstOrDefault();
                if (objStateProvincesInfo == null)
                {
                    //item.MessageError += Environment.NewLine + "Tỉnh/TP không hợp lệ!";
                }
                else
                {
                    item.GEStateProvinceID = objStateProvincesInfo.GEStateProvinceID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_GEDistrictID))
            {
                objDistrictsInfo = listDistrictsInfo.Where(x => x.GEDistrictName == item.FK_GEDistrictID).FirstOrDefault();
                if (objDistrictsInfo == null)
                {
                    //item.MessageError += Environment.NewLine + "Quận / Huyện không hợp lệ!";
                }
                else
                {
                    item.GEDistrictID = objDistrictsInfo.GEDistrictID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_APSupplierTypeAccountConfigID))
            {
                //objSupplierTypeAccountConfigsInfo = listSupplierTypeAccountConfigsInfo.Where(x => x.APSupplierTypeAccountConfigName == item.FK_APSupplierTypeAccountConfigID).FirstOrDefault();
                //if (objSupplierTypeAccountConfigsInfo == null)
                //{
                //    item.MessageError += Environment.NewLine + "Nhóm tài khoản không hợp lệ!";
                //}
                //else
                //{
                //    item.APSupplierTypeAccountConfigID = objSupplierTypeAccountConfigsInfo.APSupplierTypeAccountConfigID;
                //}
                if (item.FK_APSupplierTypeAccountConfigID == "Phải trả cho người bán - Nội địa")
                    item.APSupplierTypeAccountConfigID = 1;
                else if (item.FK_APSupplierTypeAccountConfigID == "Phải trả cho người bán - Nhập khẩu")
                    item.APSupplierTypeAccountConfigID = 2;
            }
            if (!string.IsNullOrWhiteSpace(item.FK_ACAccountID))
            {
                objAccountsInfo = listAccountsInfo.Where(x => x.ACAccountNo == item.FK_ACAccountID).FirstOrDefault();
                if (objAccountsInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Tài khoản không hợp lệ!";
                }
                else
                {
                    item.ACAccountID = objAccountsInfo.ACAccountID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_ACAccountSaleID))
            {
                objAccountsInfo = listAccountsInfo.Where(x => x.ACAccountNo == item.FK_ACAccountSaleID).FirstOrDefault();
                if (objAccountsInfo == null)
                {
                    item.MessageError += Environment.NewLine + "TK CN bán không hợp lệ!";
                }
                else
                {
                    item.ACAccountSaleID = objAccountsInfo.ACAccountID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_ACAccountPurchaseID))
            {
                objAccountsInfo = listAccountsInfo.Where(x => x.ACAccountNo == item.FK_ACAccountPurchaseID).FirstOrDefault();
                if (objAccountsInfo == null)
                {
                    item.MessageError += Environment.NewLine + "TK CN mua không hợp lệ!";
                }
                else
                {
                    item.ACAccountPurchaseID = objAccountsInfo.ACAccountID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_GECurrencyID))
            {
                objCurrenciesInfo = listCurrenciesInfo.Where(x => x.GECurrencyNo == item.FK_GECurrencyID).FirstOrDefault();
                if (objCurrenciesInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Loại tiền tệ không hợp lệ!";
                }
                else
                {
                    item.GECurrencyID = objCurrenciesInfo.GECurrencyID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.IPSupplierBankAccountCurrency1))
            {
                objCurrenciesInfo = listCurrenciesInfo.Where(x => x.GECurrencyNo == item.IPSupplierBankAccountCurrency1).FirstOrDefault();
                if (objCurrenciesInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Loại tiền tệ 1 không hợp lệ!";
                }
                else
                {
                    item.SupplierBankAccountCurrency1 = objCurrenciesInfo.GECurrencyID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.IPSupplierBankAccountCurrency2))
            {
                objCurrenciesInfo = listCurrenciesInfo.Where(x => x.GECurrencyNo == item.IPSupplierBankAccountCurrency2).FirstOrDefault();
                if (objCurrenciesInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Loại tiền tệ 1 không hợp lệ!";
                }
                else
                {
                    item.SupplierBankAccountCurrency2 = objCurrenciesInfo.GECurrencyID;
                }
            }
            if (!string.IsNullOrWhiteSpace(item.FK_GEPaymentTermID))
            {
                objPaymentTermsInfo = listPaymentTermsInfo.Where(x => x.GEPaymentTermNo == item.FK_GEPaymentTermID).FirstOrDefault();
                if (objCurrenciesInfo == null)
                {
                    //item.MessageError += Environment.NewLine + "Điều khoản thanh toán không hợp lệ!";
                }
                else
                {
                    item.GEPaymentTermID = objPaymentTermsInfo.GEPaymentTermID;
                }
            }

            if (item.MessageError.Length > 1)
            {
                item.MessageError = item.MessageError.TrimStart();
            }
        }

        //listImportSuppliersInfo.ForEach(o => {
                //o.BRBranchID = !String.IsNullOrWhiteSpace(o.FK_BRBranchID) && listBranchsInfo.Exists(x => x.BRBranchName == o.FK_BRBranchID) ? listBranchsInfo.Where(x => x.BRBranchName == o.FK_BRBranchID).FirstOrDefault().BRBranchID : 0;
                //o.GECountryID = !String.IsNullOrWhiteSpace(o.FK_GECountryID) && listCountrysInfo.Exists(x => x.GECountryName == o.FK_GECountryID) ? listCountrysInfo.Where(x => x.GECountryName == o.FK_GECountryID).FirstOrDefault().GECountryID : 0;
                //o.GEStateProvinceID = !String.IsNullOrWhiteSpace(o.FK_GEStateProvinceID) && listStateProvincesInfo.Exists(x => x.GEStateProvinceName == o.FK_GEStateProvinceID) ? listStateProvincesInfo.Where(x => x.GEStateProvinceName == o.FK_GEStateProvinceID).FirstOrDefault().GEStateProvinceID : 0;
                //o.GEDistrictID = !String.IsNullOrWhiteSpace(o.FK_GEDistrictID) && listDistrictsInfo.Exists(x => x.GEDistrictName == o.FK_GEDistrictID) ? listDistrictsInfo.Where(x => x.GEDistrictName == o.FK_GEDistrictID).FirstOrDefault().GEDistrictID : 0;
                //o.APSupplierTypeAccountConfigID = !String.IsNullOrWhiteSpace(o.FK_APSupplierTypeAccountConfigID) && listSupplierTypeAccountConfigsInfo.Exists(x => x.APSupplierTypeAccountConfigName == o.FK_APSupplierTypeAccountConfigID) ? listSupplierTypeAccountConfigsInfo.Where(x => x.APSupplierTypeAccountConfigName == o.FK_APSupplierTypeAccountConfigID).FirstOrDefault().APSupplierTypeAccountConfigID : 0;
                //o.ACAccountID = !String.IsNullOrWhiteSpace(o.FK_ACAccountID) && listAccountsInfo.Exists(x => x.ACAccountNo == o.FK_ACAccountID) ? listAccountsInfo.Where(x => x.ACAccountNo == o.FK_ACAccountID).FirstOrDefault().ACAccountID : 0;
                //o.GECurrencyID = !String.IsNullOrWhiteSpace(o.FK_GECurrencyID) && listCurrenciesInfo.Exists(x => x.GECurrencyNo == o.FK_GECurrencyID) ? listCurrenciesInfo.Where(x => x.GECurrencyNo == o.FK_GECurrencyID).FirstOrDefault().GECurrencyID : 0;
                //o.GEPaymentTermID = !String.IsNullOrWhiteSpace(o.FK_GEPaymentTermID) && listPaymentTermsInfo.Exists(x => x.GEPaymentTermName == o.FK_GEPaymentTermID) ? listPaymentTermsInfo.Where(x => x.GEPaymentTermName == o.FK_GEPaymentTermID).FirstOrDefault().GEPaymentTermID : 0;
                //o.ACAccountSaleID = !String.IsNullOrWhiteSpace(o.FK_ACAccountSaleID) && listAccountsInfo.Exists(x => x.ACAccountNo == o.FK_ACAccountSaleID) ? listAccountsInfo.Where(x => x.ACAccountNo == o.FK_ACAccountSaleID).FirstOrDefault().ACAccountID : 0;
                //o.ACAccountPurchaseID = !String.IsNullOrWhiteSpace(o.FK_ACAccountPurchaseID) && listAccountsInfo.Exists(x => x.ACAccountNo == o.FK_ACAccountPurchaseID) ? listAccountsInfo.Where(x => x.ACAccountNo == o.FK_ACAccountPurchaseID).FirstOrDefault().ACAccountID : 0;
                //o.SupplierBankAccountCurrency1 = !String.IsNullOrWhiteSpace(o.IPSupplierBankAccountCurrency1) && listCurrenciesInfo.Exists(x => x.GECurrencyNo == o.IPSupplierBankAccountCurrency1) ? listCurrenciesInfo.Where(x => x.GECurrencyNo == o.IPSupplierBankAccountCurrency1).FirstOrDefault().GECurrencyID : 0;
                //o.SupplierBankAccountCurrency2 = !String.IsNullOrWhiteSpace(o.IPSupplierBankAccountCurrency2) && listCurrenciesInfo.Exists(x => x.GECurrencyNo == o.IPSupplierBankAccountCurrency2) ? listCurrenciesInfo.Where(x => x.GECurrencyNo == o.IPSupplierBankAccountCurrency2).FirstOrDefault().GECurrencyID : 0;
                //o.SupplierOtherType = !String.IsNullOrWhiteSpace(o.IPSupplierOtherType) && listConfigValuesInfo.Exists(x => x.ADConfigKeyGroup == ConfigValueGroup.SupplierOtherType.ToString() && x.ADConfigText == o.IPSupplierOtherType) ? listConfigValuesInfo.Where(x => x.ADConfigKeyGroup == ConfigValueGroup.SupplierOtherType.ToString() && x.ADConfigText == o.IPSupplierOtherType).FirstOrDefault().ADConfigKeyValue : "";
                //o.SupplierTypeCombo = !String.IsNullOrWhiteSpace(o.IPSupplierTypeCombo) && listConfigValuesInfo.Exists(x => x.ADConfigKeyGroup == ConfigValueGroup.SupplierType.ToString() && x.ADConfigText == o.IPSupplierTypeCombo) ? listConfigValuesInfo.Where(x => x.ADConfigKeyGroup == ConfigValueGroup.SupplierType.ToString() && x.ADConfigText == o.IPSupplierTypeCombo).FirstOrDefault().ADConfigKeyValue : "";
                //o.PaymentMethodCombo = !String.IsNullOrWhiteSpace(o.APPaymentMethodCombo) && listConfigValuesInfo.Exists(x => x.ADConfigKeyGroup == ConfigValueGroup.PaymentMethod.ToString() && x.ADConfigText == o.APPaymentMethodCombo) ? listConfigValuesInfo.Where(x => x.ADConfigKeyGroup == ConfigValueGroup.PaymentMethod.ToString() && x.ADConfigText == o.APPaymentMethodCombo).FirstOrDefault().ADConfigKeyValue : "";
            //});

        //public void ValidateDepartmentAttributeImport(IPDepartmentAttributesInfo item)
        //{
        //    IPDepartmentAttributesInfo validateDepartmentAttributesInfo = new IPDepartmentAttributesInfo();

        //    item.MessageError = string.Empty;
            
        //    if (DepartmentAttributesList.Where(o => o.ICDepartmentAttributeName == item.ICDepartmentAttributeName
        //                                            && o.ICDepartmentAttributeValueNo == item.ICDepartmentAttributeValueNo).ToList().Count > 1)
        //    {
        //        item.MessageError += Environment.NewLine + "Trùng mã giá trị";
        //    }
        //    if (DepartmentAttributesList.Where(o => o.ICDepartmentAttributeName == item.ICDepartmentAttributeName
        //                                            && o.ICDepartmentAttributeValueValue == item.ICDepartmentAttributeValueValue).ToList().Count > 1)
        //    {
        //        item.MessageError += Environment.NewLine + "Trùng giá trị của thuộc tính ";
        //    }

        //    if (item.MessageError.Length > 1)
        //    {
        //        item.MessageError = item.MessageError.TrimStart();
        //    }
        //}
    }
}