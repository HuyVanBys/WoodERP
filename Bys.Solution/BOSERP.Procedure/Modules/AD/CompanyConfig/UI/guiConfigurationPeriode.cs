using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIFASLib;

namespace WIFASERP.Modules.CompanyConfig
{
    public partial class guiConfigurationPeriode : WIFASERPScreen
    {
        List<ADPeriodesInfo> lstADPeriodesInfo = new List<ADPeriodesInfo>();
        DataSet dsPeriods = new DataSet();
        public guiConfigurationPeriode()
        {
            InitializeComponent();
        }

        private void guiConfigurationPeriode_Load(object sender, EventArgs e)
        {
            //InitPeriodeToList();     
            InitGridControl();
        }

        private void InitGridControl()
        {
            ADPeriodesController objADPeriodesController = new ADPeriodesController();
            dsPeriods = objADPeriodesController.GetAllObjects();
            //fld_dgcPeriode.DataSource = dsPeriods.Tables[0];
            foreach (DataRow rowPeriod in dsPeriods.Tables[0].Rows)
            {
                ADPeriodesInfo objADPeriodsInfo = (ADPeriodesInfo)new ADPeriodesController().GetObjectFromDataRow(rowPeriod);
                lstADPeriodesInfo.Add(objADPeriodsInfo);
            }

            fld_dgcPeriode.DataSource = lstADPeriodesInfo;
        }



    }
}