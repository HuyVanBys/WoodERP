using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace BOSERP.Modules.HRAllowance.UI
{
    /// <summary>
    /// Summary description for DMHRAL100
    /// </summary>
    public partial class DMHRAL100 : BOSERPScreen
    {

        public DMHRAL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((HRAllowanceModule)Module).AddEmployee();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRAllowanceModule)Module).RemoveSelectedItemFromAllowancesList();
        }

        private void fld_lkeHRAllowanceType_Validated(object sender, EventArgs e)
        {
            ((HRAllowanceModule)Module).SetMaskForAllowanceValue();
        }

        private void fld_txtHRAllowanceValue_Validated(object sender, EventArgs e)
        {


        }

        private void bosTextBox1_Validated(object sender, EventArgs e)
        {
            ((HRAllowanceModule)Module).ChangeAllowanceValue();
        }

        private void fld_lkeHRAllowanceType_QueryPopUp(object sender, CancelEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> list = new List<ADConfigValuesInfo>();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("AllowanceType");
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    ds.Dispose();
                    if (objConfigValuesInfo != null)
                    {
                        if ((objConfigValuesInfo.ADConfigKeyValue == AllowanceType.NuoiCon.ToString())
                        || (objConfigValuesInfo.ADConfigKeyValue == AllowanceType.Other.ToString())
                        || (objConfigValuesInfo.ADConfigKeyValue == AllowanceType.TruyLanh.ToString()))
                        {
                            list.Add(objConfigValuesInfo);
                        }
                    }
                }
            }
            fld_lkeHRAllowanceType.Properties.DataSource = list;
            fld_lkeHRAllowanceType.Properties.DisplayMember = "ADConfigText";
            fld_lkeHRAllowanceType.Properties.ValueMember = "ADConfigKeyValue";
        }

        private void Fld_lkeHRAllowanceType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("AllowanceType");
            List<ADConfigValuesInfo> list = new List<ADConfigValuesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    list.Add(objConfigValuesInfo);
                }
            }
            fld_lkeHRAllowanceType.Properties.DataSource = list;
        }
    }
}
