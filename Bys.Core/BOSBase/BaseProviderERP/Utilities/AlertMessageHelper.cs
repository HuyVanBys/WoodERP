using BOSERP;
using DevExpress.XtraBars.Alerter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSBase
{
    public class AlertMessageHelper
    {
        private System.Timers.Timer timer;

        private DateTime? UpdateLastDate { get; set; }

        private int HREmployeeID { get; set; }

        private ADRemindWorkingsController RemindWorkingsController { get; set; }

        private AlertControl control { get; set; }

        private AlertInfo alertInfo { get; set; }

        public Form ParentForm
        {
            get;
            private set;
        }

        public AlertMessageHelper(Form parentForm)
        {
            ParentForm = parentForm;
            UpdateLastDate = null;
            RemindWorkingsController = new ADRemindWorkingsController();
            timer = new System.Timers.Timer();
            timer.Interval = 3000;
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Elapsed);
        }


        private void Elapsed(object sender, EventArgs e)
        {
            Alert();
        }

        public void Alert()
        {
            System.Action action = () =>
            {
                if (BOSApp.CurrentUsersInfo.FK_HREmployeeID == 0)
                    return;

                ADRemindWorkingConfigsController objRemindWorkingConfigsController = new ADRemindWorkingConfigsController();
                ADRemindWorkingConfigsInfo objRemindWorkingConfigsInfo = objRemindWorkingConfigsController.GetRemindWorkingConfigByEmployeeID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
                if (objRemindWorkingConfigsInfo == null)
                {
                    objRemindWorkingConfigsInfo = new ADRemindWorkingConfigsInfo()
                    {
                        ADRemindWorkingConfigDate = 10,
                        ADRemindWorkingConfigTime = 15,
                        FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID,
                        ADRemindWorkingConfigType = "Second"
                    };
                    objRemindWorkingConfigsController.CreateObject(objRemindWorkingConfigsInfo);
                }

                List<ADRemindWorkingsInfo> remindWorkingList = RemindWorkingsController.GetNewRemindByEmployeeID(BOSApp.CurrentUsersInfo.FK_HREmployeeID, UpdateLastDate);
                if (remindWorkingList.Count() == 0)
                    return;

                control = new AlertControl();
                remindWorkingList.ForEach(o =>
                {
                    alertInfo = new AlertInfo(o.ADRemindWorkingTitle, o.ADRemindWorkingContent);
                    control.FormLocation = AlertFormLocation.BottomRight;
                    control.Show(ParentForm, alertInfo);
                });
                UpdateLastDate = BOSApp.GetCurrentServerDate();
            };
            ParentForm.Invoke(action);
        }
    }
}
