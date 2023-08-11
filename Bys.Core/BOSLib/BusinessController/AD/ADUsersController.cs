using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;


namespace BOSLib
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class ADUsersController : BaseBusinessController
    {

        #region SP Name        

        //Select By ForeignKey Stored Procedure
        private readonly string spGetADUsersByADUserGroupID = "ADUsers_SelectByADUserGroupID";

        /*Remove cause of not use
        private readonly string spGetADUsersByADContactID = "ADUsers_SelectByADContactID";*/

        //Select By all foreignkey Stored Procedure

        /*Remove cause of not use
        private readonly string spGetADUsersByADUserGroupIDAndADContactID = "ADUsers_SelectByADUserGroupIDAndADContactID";

        //Delete by foreignkey Stored Procedure
        private readonly string spDeleteADUsersByADUserGroupID = "ADUsers_DeleteByADUserGroupID";
        private readonly string spDeleteADUsersByADContactID = "ADUsers_DeleteByADContactID";*/

        #endregion

        public ADUsersController()
        {
            dal = new DALBaseProvider("ADUsers", typeof(ADUsersInfo));
        }
        public int CreateUser(ADUsersInfo objADUsersInfo)
        {
            byte[] passwordBytes = SHA1Managed.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(objADUsersInfo.ADPassword));
            objADUsersInfo.ADPassword = Convert.ToBase64String(passwordBytes);
            objADUsersInfo.ADUserID = dal.GetMaxID() + 1;
            return dal.CreateObject(objADUsersInfo);
        }

        public int UpdateUser(ADUsersInfo objADUsersInfo, bool bChange)
        {
            if (!string.IsNullOrEmpty(objADUsersInfo.ADPassword))
            {
                byte[] passwordBytes = SHA1Managed.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(objADUsersInfo.ADPassword));
                if (bChange)
                {
                    objADUsersInfo.ADPassword = Convert.ToBase64String(passwordBytes);
                }
            }
            else
            {
                ADUsersController objUsersController = new ADUsersController();
                ADUsersInfo existingUser = (ADUsersInfo)objUsersController.GetObjectByID(objADUsersInfo.ADUserID);
                if (existingUser != null)
                {
                    objADUsersInfo.ADPassword = existingUser.ADPassword;
                }
            }
            return dal.UpdateObject(objADUsersInfo);
        }

        public int GetUserGroupOfUser(int iADUserID)
        {
            ADUsersInfo objADUsersInfo = new ADUsersInfo();
            objADUsersInfo = (ADUsersInfo)GetObjectByID(iADUserID);
            return objADUsersInfo.ADUserGroupID;
        }

        public int GetUserGroupOfUser(String strUserName)
        {
            ADUsersInfo objADUsersInfo = new ADUsersInfo();
            objADUsersInfo = (ADUsersInfo)GetObjectByName(strUserName);
            if (objADUsersInfo != null)
                return objADUsersInfo.ADUserGroupID;
            return 0;
        }

        public DataSet GetAllUserByUserGroupID(int iADUserGroupID)
        {
            return (DataSet)dal.GetDataSet(spGetADUsersByADUserGroupID, iADUserGroupID);
        }

        public List<ADUsersInfo> GetUserListByUserGroupID(int iADUserGroupID)
        {
            DataSet ds = dal.GetDataSet("ADUsers_GetAllUserByUserGroupID", iADUserGroupID);
            List<ADUsersInfo> userList = new List<ADUsersInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADUsersInfo objUsersInfo = (ADUsersInfo)GetObjectFromDataRow(row);
                    userList.Add(objUsersInfo);
                }
            }

            return userList;
        }
    }
}
