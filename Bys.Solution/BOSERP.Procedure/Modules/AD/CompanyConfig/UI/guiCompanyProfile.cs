using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eMASLib;

namespace eMASERP.Modules.CompanyConfig
{
    public partial class guiCompanyProfile : eMASERPScreen
    {
        private CSCompanysInfo _companyInfo = new CSCompanysInfo();

        public guiCompanyProfile()
        {
            InitializeComponent();
            _companyInfo = (CSCompanysInfo)new CSCompanysController().GetFirstObject();
            if (_companyInfo == null)
                _companyInfo = new CSCompanysInfo();
            BindingDataControl(Controls);
        }
        
        private void BindingDataControl(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(DevExpress.XtraEditors.GroupControl))
                    BindingDataControl(ctrl.Controls);
                else
                    if (ctrl.Tag != null)
                    {
                        String strPropertyName = ctrl.Tag.ToString();
                        String strDataMember = ctrl.Name.Substring(7);
                        ctrl.DataBindings.Add(new Binding(strPropertyName, _companyInfo, strDataMember, true, DataSourceUpdateMode.OnPropertyChanged));
                        if (ctrl.GetType() == typeof(eMASLookupEdit))
                            InitObjectDataToLookupEdit(ctrl as eMASLookupEdit);
                    }
            }
        }

        public void InitObjectDataToLookupEdit(eMASLookupEdit lke)
        {
            eMASDbUtil dbUtil = new eMASDbUtil();
            String strTableName = "CSCompanys";
            String strColumnName = lke.Name.Substring(7);
            String strLookupTable = dbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
            BaseBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
            DataSet ds = objLookupTableController.GetAllObjects();

            if (ds.Tables.Count > 0)
            {
                BindingSource bds = new BindingSource();
                bds.DataSource = ds.Tables[0];
                lke.Properties.DataSource = bds;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CSCompanysController objCSCompanysController = new CSCompanysController();
            CSCompanysInfo objCSCompanysInfo = (CSCompanysInfo)objCSCompanysController.GetFirstObject();
            if (objCSCompanysInfo != null)
            {
                _companyInfo.CSCompanyID = objCSCompanysInfo.CSCompanyID;
                objCSCompanysController.UpdateObject(_companyInfo);
            }
            else
            {
                objCSCompanysController.CreateObject(_companyInfo);
            }
            MessageBox.Show("Finished", "#Message#");
        }
    }
}