namespace BOSERP.Modules.Task
{
    public class TaskEntities : ERPModuleEntities
    {
        #region Constructor
        public TaskEntities()
            : base()
        {
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICTasksInfo();
            SearchObject = new ICTasksInfo();
        }
        #endregion
    }
}