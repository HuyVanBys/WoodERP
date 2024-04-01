using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP
{
    public class ACObjectsController : BaseBusinessController
    {
        public ACObjectsController()
        {
            dal = new DALBaseProvider("ACObjects", typeof(ACObjectsInfo));
        }

        /// <summary>
        /// Get object list based on some criteria
        /// </summary>
        /// <param name="objectNo">Object no</param>
        /// <param name="objectType">Object type</param>
        /// <returns>List of objects</returns>
        public List<ACObjectsInfo> GetObjectList(string objectNo, string objectType)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetObjectList", objectNo, objectType);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }

        /// <summary>
        /// Get all objects including customer, supplier, employee
        /// </summary>
        /// <returns>List of objects</returns>
        public new List<ACObjectsInfo> GetAllObjects()
        {
            return GetObjectList(null, null);
        }

        /// <summary>
        /// Get objects by a specified type
        /// </summary>
        /// <param name="objectType">Given type</param>
        /// <returns>List of objects</returns>
        public List<ACObjectsInfo> GetObjectsByType(string objectType)
        {
            return GetObjectList(null, objectType);
        }

        /// <summary>
        /// Get an object by its id and type
        /// </summary>
        /// <param name="objectID">Object id</param>
        /// <param name="type">Object type</param>
        /// <returns></returns>
        public ACObjectsInfo GetObjectByIDAndType(int objectID, string type)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetObjectByIDAndType", objectID, type);
            ACObjectsInfo objObjectsInfo = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                objObjectsInfo = (ACObjectsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return objObjectsInfo;
        }

        /// <summary>
        /// Get an object by its no and type
        /// </summary>
        /// <param name="objectNo">Object no</param>
        /// <param name="type">Object type</param>
        /// <returns>Object</returns>
        public ACObjectsInfo GetObjectByNoAndType(string objectNo, string type)
        {
            List<ACObjectsInfo> objects = GetObjectList(objectNo, type);
            if (objects.Count > 0)
            {
                return objects[0];
            }
            return null;
        }


        /// <summary>
        /// Get an object by its access key
        /// </summary>
        /// <param name="accessKey">Access key</param>
        /// <returns>Object</returns>
        public ACObjectsInfo GetObjectByAccessKey(string accessKey)
        {
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            if (!string.IsNullOrEmpty(accessKey))
            {
                string[] keys = accessKey.Split(new char[] { ';' });
                if (keys != null && keys.Count() == 2)
                {
                    objObjectsInfo.ACObjectID = Convert.ToInt32(keys[0]);
                    objObjectsInfo.ACObjectType = keys[1];
                }
            }
            return objObjectsInfo;
        }

        public ACObjectsInfo GetObjectByAccessKey(string accessKey, List<ACObjectsInfo> objects)
        {
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            if (!string.IsNullOrEmpty(accessKey))
            {
                string[] keys = accessKey.Split(new char[] { ';' });
                if (keys != null && keys.Count() == 2)
                {
                    objObjectsInfo.ACObjectID = Convert.ToInt32(keys[0]);
                    objObjectsInfo.ACObjectType = keys[1];
                }
                objObjectsInfo = objects.FirstOrDefault(t => t.ACObjectID == objObjectsInfo.ACObjectID
                                                            && t.ACObjectType == objObjectsInfo.ACObjectType);
            }
            return objObjectsInfo;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectFromDataRow(dr);
                    objects.Add(objObjectsInfo);
                }
            }
            ds.Dispose();
            return objects;
        }

        /// <summary>
        /// Get objects that remain owing relating to an account
        /// </summary>
        /// <param name="accountNo">Account no</param>
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <param name="objectID">Object id</param>
        /// <param name="objectType">Object type</param>            
        /// <param name="locationID">Id of location the object belongs to</param>
        /// <param name="branchID">Id of branch the object belongs to</param>
        /// <param name="hasOwing">A value indicates whether the result should contain only owing objects</param>
        /// <returns>List of owing objects</returns>        
        public List<ACObjectsInfo> GetOwingObjects(
                                                string accountNo,
                                                DateTime fromDate,
                                                DateTime toDate,
                                                int? objectID,
                                                string objectType,
                                                int? locationID,
                                                int? branchID,
                                                bool hasOwing)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetOwingObjects", accountNo, fromDate, toDate, objectID, objectType, locationID, branchID, hasOwing);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }

        /// <summary>
        /// Get objects that remain owing relating to an account
        /// </summary>
        /// <param name="accountNo">Account no</param>
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <param name="objectType">Object type</param>            
        /// <param name="locationID">Id of location the object belongs to</param>
        /// <param name="branchID">Id of branch the object belongs to</param>
        /// <param name="hasOwing">A value indicates whether the result should contain only owing objects</param>
        /// <returns>List of owing objects</returns>        
        public List<ACObjectsInfo> GetOwingObjects(string accountNo, DateTime fromDate, DateTime toDate, string objectType, int? locationID, int? branchID, bool hasOwing)
        {
            return GetOwingObjects(accountNo, fromDate, toDate, null, objectType, locationID, branchID, hasOwing);
        }

        /// <summary>
        /// Get objects that remain owing relating to an account
        /// </summary>
        /// <param name="accountNo">Account no</param>
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <param name="objectType">Object type</param>            
        /// <param name="locationID">Id of location the object belongs to</param>
        /// <param name="branchID">Id of branch the object belongs to</param>
        /// <param name="hasOwing">A value indicates whether the result should contain only owing objects</param>
        /// <returns>List of owing objects</returns>        
        public List<ACObjectsInfo> GetOwingObjectsBySomeCriteria(string accountNo, DateTime fromDate, DateTime toDate, int? objectID, string objectType, int? locationID, int? branchID, bool hasOwing)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetOwingObjectsBySomeCriteria", accountNo, fromDate, toDate, objectID, objectType, locationID, branchID, hasOwing);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }

        public List<ACObjectsInfo> GetDistinctOjbectListInDocumentEntry(string accountNo, DateTime? fromDate, DateTime? toDate, string branchNos)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetDistinctOjbectListInDocumentEntry", accountNo, fromDate, toDate, branchNos);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }

        public List<ACObjectsInfo> GetDistinctOjbectListInAccountDetail(string accountNo)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetDistinctOjbectListInAccountDetail", accountNo);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }

        public List<ACObjectsInfo> GetObjectByIDAndTypeGeneral(int objectID, string objectType)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetObjectByIDAndTypeGeneral", objectID, objectType);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }

        public bool CheckForChangesOfReferenceData(string objectType, DateTime dtLastCreatedDate, DateTime dtLastUpdatedDate)
        {
            return (bool)dal.GetSingleValue("ACObjects_CheckForChangesOfReferenceData", objectType, dtLastCreatedDate, dtLastUpdatedDate);
        }

        public List<ACObjectsInfo> GetAllObjectByType(string objectType)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetAllObjectByType", objectType);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }

        public List<ACObjectsInfo> GetObjectViewPermissionByModule(string moduleName)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetObjectViewPermissionByModule", moduleName);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }
        public List<ACObjectsInfo> GetObjectViewPermissionByUse(int userID)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetObjectViewPermissionByUser", userID);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }
        public List<ACObjectsInfo> GetObjectViewPermissionByUseIDAndModule(int userID, string moduleName)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetObjectViewPermissionByUseIDAndModule", userID, moduleName);
            return (List<ACObjectsInfo>)GetListFromDataSet(ds);
        }
        public bool CheckObjectChangeFromDatabase(DateTime lastedUpdate, string moduleName)
        {
            return (bool)dal.GetSingleValue("ACObjects_CheckObjectChangeFromDatabase", lastedUpdate, moduleName);
        }

        public decimal GetTotalOwing(int objectID, string objectType)
        {
            DataSet ds = dal.GetDataSet("ACObjects_GetTotalOwing", objectID, objectType);
            decimal owing = 0;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    owing = Convert.ToDecimal(ds.Tables[0].Rows[0][0]);
                }
            }
            return owing;
        }
    }
}
