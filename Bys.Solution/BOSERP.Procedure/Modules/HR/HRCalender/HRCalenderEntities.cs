using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HRCalender
{
    public class HRCalenderEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRCalendarEntrysInfo> HRCalendarEntryList { get; set; }
        #endregion

        #region Constructor
        public HRCalenderEntities()
            : base()
        {
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRCalendarsInfo();
            HRCalendarEntryList = new BOSList<HRCalendarEntrysInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRCalendarEntrysTable, new HRCalendarEntrysInfo());
        }

        public override void InitModuleObjectList()
        {
            HRCalendarEntryList.InitBOSList(
                                            this,
                                            TableName.HRCalendarsTableName,
                                            TableName.HRCalendarEntrysTable,
                                            BOSList<HRCalendarEntrysInfo>.cstRelationForeign);
            HRCalendarEntryList.ItemTableForeignKey = "FK_HRCalendarID";
        }

        public override void InitGridControlInBOSList()
        {
            HRCalendarEntryList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRCalendarsInfo objCalendarsInfo = (HRCalendarsInfo)MainObject;
            objCalendarsInfo.HRCalendarType = CalendarType.Holiday.ToString();
            objCalendarsInfo.HRCalendarYear = DateTime.Now.Year;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRCalendarEntryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRCalendarEntryList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HRCalendarsInfo objCalendarsInfo = (HRCalendarsInfo)MainObject;
            foreach (HRCalendarEntrysInfo objCalendarEntrysInfo in HRCalendarEntryList)
            {
                objCalendarEntrysInfo.HRCalendarEntryDate = Convert.ToDateTime(String.Format("{0}/{1}/{2}", objCalendarsInfo.HRCalendarYear, objCalendarEntrysInfo.HRCalendarEntryDate.Month, objCalendarEntrysInfo.HRCalendarEntryDate.Day));
            }
            HRCalendarEntryList.SaveItemObjects();
        }
        #endregion
    }
}
