using System;
using System.Collections.Generic;
using System.Data;



namespace BOSLib
{
    #region STFieldEventFunctionParametersController
    /// <summary>
    /// This object represents the properties and methods of a FieldEventFunctionParameter.
    /// </summary>
    public class STFieldEventFunctionParametersController : BaseBusinessController
    {
        #region SP Name
        //Select By Name Query

        /*Remove cause of not use
        private readonly string spGetSTFieldEventFunctionParametersByName = "STFieldEventFunctionParameters_SelectByName";*/

        //Select By ForeignKey Queries
        private readonly string spGetSTFieldEventFunctionParametersBySTFieldEventFunctionID = "STFieldEventFunctionParameters_SelectBySTFieldEventFunctionID";
        private readonly string spGetSTFieldEventFunctionParametersBySTFieldEventFunctionIDAndSTFieldEventFunctionParameterName =
                                "STFieldEventFunctionParameters_SelectBySTFieldEventFunctionIDAndSTFieldEventFunctionParameterName";


        //Delete by foreignkey Queries
        /*Remove cause of not use
        private readonly string spDeleteSTFieldEventFunctionParametersBySTFieldEventFunctionID =
                               "STFieldEventFunctionParameters_DeleteBySTFieldEventFunctionID";*/
        #endregion

        public STFieldEventFunctionParametersController()
        {
            dal = new DALBaseProvider("STFieldEventFunctionParameters", typeof(STFieldEventFunctionParametersInfo));
        }

        public DataSet GetFieldEventFunctionParameterByFieldEventFunctionID(int iFieldEventFunctionID)
        {
            return (DataSet)dal.GetDataSet(spGetSTFieldEventFunctionParametersBySTFieldEventFunctionID,
                                           iFieldEventFunctionID);
        }

        public STFieldEventFunctionParametersInfo GetFieldEventFunctionParameterByFieldEventIDAndFieldEventFunctionParameterName(int iFieldEventFunctionID, String strFieldEventFunctionParameterName)
        {
            return (STFieldEventFunctionParametersInfo)dal.GetDataObject(spGetSTFieldEventFunctionParametersBySTFieldEventFunctionIDAndSTFieldEventFunctionParameterName,
                                                                         iFieldEventFunctionID, strFieldEventFunctionParameterName);
        }
        public List<STFieldEventFunctionParametersInfo> GetListAllObjects()
        {
            DataSet ds = this.GetAllObjects();
            List<STFieldEventFunctionParametersInfo> fieldEventFuncParams = new List<STFieldEventFunctionParametersInfo>();
            if (ds.Tables.Count > 0)
            {
                fieldEventFuncParams = new List<STFieldEventFunctionParametersInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STFieldEventFunctionParametersInfo objFieldEventFuncsInfo = (STFieldEventFunctionParametersInfo)GetObjectFromDataRow(row);
                    fieldEventFuncParams.Add(objFieldEventFuncsInfo);
                }
            }
            return fieldEventFuncParams;
        }
    }
    #endregion
}
