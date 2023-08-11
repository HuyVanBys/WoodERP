using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP127 : ReportForm
    {


        public RP127()
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

        private void RP126_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductSeriesInfo> ListObject = new List<ICProductSeriesInfo>();
            ListObject = objProductSeriesController.GetListObjectForLookupReport127();
            fld_lkeFK_ICProductSerieID.Properties.DataSource = ListObject;
            fld_dteSearchFromDate.EditValue = DateTime.Now;
            fld_dteSearchToDate.EditValue = DateTime.Now;
        }



        private void fld_btnPrint_Click(object sender, EventArgs e)
        {


            int suplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            int seriesID = Convert.ToInt32(fld_lkeFK_ICProductSerieID.EditValue);
            DateTime Fromdate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            int AttributeID = Convert.ToInt32(fld_lkeICProductAttributeID.EditValue);
            List<ICProductSeriesInfo> resultList = new List<ICProductSeriesInfo>();
            resultList.Clear();
            fld_dgcRP127GridControls.RefreshDataSource();

            //int.TryParse((fld_txtProductHeight.Text.ToString()), out height);
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            resultList = objProductSeriesController.GetItemForReport127(suplierID, seriesID, Fromdate, ToDate, AttributeID);
            if (suplierID != 0)
            {
                resultList = resultList.Where(x => x.APSupplierID == suplierID).ToList();
            }
            fld_dgcRP127GridControls.DataSource = resultList;

        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
