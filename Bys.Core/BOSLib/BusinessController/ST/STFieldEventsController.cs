using System;
using System.Collections.Generic;
using System.Data;



namespace BOSLib
{
    #region STFieldEventsController
    /// <summary>
    /// This object represents the properties and methods of a FieldEvent.
    /// </summary>
    public class STFieldEventsController : BaseBusinessController
    {
        #region SP Name        
        //Select By ForeignKey Queries
        private readonly string spGetSTFieldEventsBySTFieldID = "STFieldEvents_SelectBySTFieldID";
        private readonly string spGetSTFieldEventBySTFieldIDAndSTFieldEventName =
                               "STFieldEvents_SelectBySTFieldIDAndSTFieldEventName";


        //Delete by foreignkey Queries
        /*Remove cause of not use
        private readonly string spDeleteSTFieldEventsBySTFieldID = "STFieldEvents_DeleteBySTFieldID";*/

        #endregion
        public STFieldEventsController()
        {
            //dal = new STFieldEventsDAL();
            dal = new DALBaseProvider("STFieldEvents", typeof(STFieldEventsInfo));
        }

        public DataSet GetFieldEventByFieldID(int iFieldID)
        {
            return (DataSet)dal.GetDataSet(spGetSTFieldEventsBySTFieldID, iFieldID);
        }

        public STFieldEventsInfo GetFieldEventByFieldIDAndEventName(int iFieldID, String strEventName)
        {
            return (STFieldEventsInfo)dal.GetDataObject(spGetSTFieldEventBySTFieldIDAndSTFieldEventName, iFieldID, strEventName);
        }
        public List<STFieldEventsInfo> GetFieldEventBySTFieldID(int? iFieldID)
        {
            DataSet ds = dal.GetDataSet("STFieldEvents_GetFieldEventBySTFieldID", iFieldID);
            List<STFieldEventsInfo> fieldEvents = new List<STFieldEventsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STFieldEventsInfo objFieldEventsInfo = (STFieldEventsInfo)GetObjectFromDataRow(row);
                    fieldEvents.Add(objFieldEventsInfo);
                }
            }
            ds.Dispose();
            return fieldEvents;
        }
    }
    #endregion
}
