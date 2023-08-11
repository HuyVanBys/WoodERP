namespace BOSLib
{
    #region ADUserGroupsController

    public class ADUserGroupsController : BaseBusinessController
    {

        public ADUserGroupsController()
        {
            //dal = new ADUserGroupsDAL();
            dal = new DALBaseProvider("ADUserGroups", typeof(ADUserGroupsInfo));
        }
        public void DeleteUserGroupAndReference(int UserGroupID)
        {
            dal.ExecuteStoredProcedure("ADUserGroups_DeleteUserGroupAndReference", UserGroupID);
        }
    }
    #endregion
}
