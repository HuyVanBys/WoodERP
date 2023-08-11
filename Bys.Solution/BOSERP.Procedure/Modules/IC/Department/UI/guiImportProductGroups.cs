using BOSCommon;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Department
{
    public partial class guiImportProductGroups : BOSERPScreen
    {
        public List<IPProductGroupsInfo> ProductGroupsList { get; set; }

        public List<IPDepartmentAttributesInfo> DepartmentAttributesList { get; set; }

        private List<ICProductTypeAccountConfigsInfo> ListTypeAccountConfigs { get; set; }

        public guiImportProductGroups(List<IPProductGroupsInfo> itemsList, List<IPDepartmentAttributesInfo> departmentAttributesList)
        {
            InitializeComponent();
            ProductGroupsList = itemsList;
            DepartmentAttributesList = departmentAttributesList;

            ListTypeAccountConfigs = new List<ICProductTypeAccountConfigsInfo>();
            if (BOSApp.LookupTables.Contains("ICProductTypeAccountConfigs"))
            {
                ListTypeAccountConfigs = (List<ICProductTypeAccountConfigsInfo>)(new ICProductTypeAccountConfigsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICProductTypeAccountConfigs"]);
            }
            else
            {
                ListTypeAccountConfigs = (new ICProductTypeAccountConfigsController()).GetAllAliveProductTypeAccountConfig();
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

        private void guiImportProductGroups_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcIPProductGroups.InvalidateDataSource(ProductGroupsList);
            fld_dgcIPProductGroups.Visible = true;

            fld_dgcIPDepartmentAttributes.InvalidateDataSource(DepartmentAttributesList);
            fld_dgcIPDepartmentAttributes.Visible = true;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApproveImport_Click(object sender, EventArgs e)
        {
            if (!IsValidSaveProductGroups())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool IsValidSaveProductGroups()
        {
            ProductGroupsList.ForEach(o =>
            {
                ValidateProductGroupImport(o);
            });
            DepartmentAttributesList.ForEach(o =>
            {
                ValidateDepartmentAttributeImport(o);
            });
            fld_dgcIPProductGroups.RefreshDataSource();
            fld_dgcIPDepartmentAttributes.RefreshDataSource();

            if (ProductGroupsList.FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.MessageError)) != null
                || DepartmentAttributesList.FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.MessageError)) != null)
            {
                MessageBox.Show("Dữ liệu import chưa phù hợp. Vui lòng kiểm tra lại!"
                            , CommonLocalizedResources.MessageBoxDefaultCaption
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void ValidateProductGroupImport(IPProductGroupsInfo item)
        {
            ICProductTypeAccountConfigsInfo objProductTypeAccountConfigsInfo = new ICProductTypeAccountConfigsInfo();
            IPProductGroupsInfo objProductGroupsInfo = new IPProductGroupsInfo();

            item.MessageError = string.Empty;
            if(ProductGroupsList.Where(o => o.IPProductGroupNo == item.IPProductGroupNo
                                        && o.IPProductGroupName == item.IPProductGroupName).ToList().Count > 1)
            {
                item.MessageError += Environment.NewLine + "Trùng nhóm hàng";
            }
            else if (ProductGroupsList.Where(o => o.IPProductGroupNo == item.IPProductGroupNo
                                         && o.IPProductGroupParentNo == item.IPProductGroupParentNo
                                         && o.IPProductGroupParentName == item.IPProductGroupParentName).ToList().Count > 1)
            {
                item.MessageError += Environment.NewLine + "Trùng Mã nhóm hàng";
            }

            if (!string.IsNullOrWhiteSpace(item.IPProductGroupParentNo))
            {
                objProductGroupsInfo = ProductGroupsList.FirstOrDefault(o => o.IPProductGroupNo == item.IPProductGroupParentNo
                                                                        && o.IPProductGroupName == item.IPProductGroupParentName);
                if (objProductGroupsInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Nhóm hàng cha không phù hợp";
                }
            }

            if (!string.IsNullOrWhiteSpace(item.IPProductTypeAccountConfigName))
            {
                objProductTypeAccountConfigsInfo = ListTypeAccountConfigs.Where(f => f.ICProductTypeAccountConfigName.Trim().ToLower() == item.IPProductTypeAccountConfigName.Trim().ToLower()).FirstOrDefault();
                if (objProductTypeAccountConfigsInfo == null)
                {
                    item.MessageError += Environment.NewLine + "Nhóm tài khoản không phù hợp";
                }
                else
                {
                    item.FK_ICProductTypeAccountConfigID = objProductTypeAccountConfigsInfo.ICProductTypeAccountConfigID;
                }
            }
            if(item.MessageError.Length > 1)
            {
                item.MessageError = item.MessageError.TrimStart();
            }    
        }

        public void ValidateDepartmentAttributeImport(IPDepartmentAttributesInfo item)
        {
            IPDepartmentAttributesInfo validateDepartmentAttributesInfo = new IPDepartmentAttributesInfo();

            item.MessageError = string.Empty;
            
            if (DepartmentAttributesList.Where(o => o.ICDepartmentAttributeName == item.ICDepartmentAttributeName
                                                    && o.ICDepartmentAttributeValueNo == item.ICDepartmentAttributeValueNo).ToList().Count > 1)
            {
                item.MessageError += Environment.NewLine + "Trùng mã giá trị";
            }
            if (DepartmentAttributesList.Where(o => o.ICDepartmentAttributeName == item.ICDepartmentAttributeName
                                                    && o.ICDepartmentAttributeValueValue == item.ICDepartmentAttributeValueValue).ToList().Count > 1)
            {
                item.MessageError += Environment.NewLine + "Trùng giá trị của thuộc tính ";
            }

            if (item.MessageError.Length > 1)
            {
                item.MessageError = item.MessageError.TrimStart();
            }
        }
    }
}