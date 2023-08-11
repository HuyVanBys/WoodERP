﻿using BOSLib;
using System;


namespace BOSERP
{
    #region GECorrespondences
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GECorrespondencesController
    //Created Date:Monday, April 09, 2007
    //-----------------------------------------------------------

    public class SlimDatabaseController : BaseBusinessController
    {
        public SlimDatabaseController()
        {
            dal = new DALBaseProvider();
        }

        public bool DeleteDataByTableNameAndSomeCriteria(string tableName, string criteria)
        {
            bool isSuccess = true;
            try
            {
                dal.ExecuteStoredProcedure("usp_delete_cascade", tableName, criteria);
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            return isSuccess;
        }
    }
    #endregion
}