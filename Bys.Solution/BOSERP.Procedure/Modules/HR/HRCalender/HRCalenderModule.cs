namespace BOSERP.Modules.HRCalender
{
    public class HRCalenderModule : BaseModuleERP
    {
        public HRCalenderModule()
        {
            Name = "HRCalender";
            CurrentModuleEntity = new HRCalenderEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        /// <summary>
        /// Remove the selected date from the current calendar
        /// </summary>
        public void RemoveDateFromCalendar()
        {
            HRCalenderEntities entity = (HRCalenderEntities)CurrentModuleEntity;
            entity.HRCalendarEntryList.RemoveSelectedRowObjectFromList();
        }
    }
}
