using BOSCommon;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.LeaveApplication.UI
{
    /// <summary>
    /// Summary description for DMLA100
    /// </summary>
    public partial class DMLA100 : BOSERPScreen
    {

        public DMLA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HRTimeSheetParamID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> timeSheetParams = null;
            timeSheetParams = objTimeSheetParamsController.GetTimeSheetParamsList();
            timeSheetParams = timeSheetParams.Where(o => o.HRTimeSheetParamType != TimeSheetParamType.Common.ToString() && o.HRTimeSheetParamType != TimeSheetParamType.BonusTime.ToString() && o.HRTimeSheetParamType != TimeSheetParamType.TC.ToString() && o.HRTimeSheetParamType != TimeSheetParamType.Hour.ToString() && o.HRTimeSheetParamType != TimeSheetParamType.Day.ToString()).ToList();
            fld_lkeFK_HRTimeSheetParamID.Properties.DataSource = timeSheetParams;
            fld_lkeFK_HRTimeSheetParamID.EditValue = 0;
        }
    }
}
