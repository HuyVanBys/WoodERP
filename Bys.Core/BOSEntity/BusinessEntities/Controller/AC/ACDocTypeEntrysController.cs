﻿using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP
{
    #region ACDocTypeEntrys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACDocTypeEntrysController
    //Created Date:Friday, June 03, 2011
    //-----------------------------------------------------------

    public class ACDocTypeEntrysController : BaseBusinessController
    {
        public ACDocTypeEntrysController()
        {
            dal = new DALBaseProvider("ACDocTypeEntrys", typeof(ACDocTypeEntrysInfo));
        }

        /// <summary>
        /// Get document entries by a document type
        /// </summary>
        /// <param name="documentType">Type of document</param>
        /// <returns>List of document entries</returns>
        public List<ACDocTypeEntrysInfo> GetEntriesByDocumentType(string documentType)
        {
            DataSet ds = dal.GetDataSet("ACDocTypeEntrys_GetDocTypeEntrysByDocumentType", documentType);
            List<ACDocTypeEntrysInfo> entries = new List<ACDocTypeEntrysInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACDocTypeEntrysInfo objDocTypeEntrysInfo = (ACDocTypeEntrysInfo)GetObjectFromDataRow(row);
                    entries.Add(objDocTypeEntrysInfo);
                }
            }
            return entries;
        }

        /// <summary>
        /// Get data by document type id
        /// </summary>
        /// <param name="documentTypeID">The document type id</param>
        /// <returns>Data of document type</returns>
        public DataSet GetDataByDocumentTypeID(int documentTypeID)
        {
            DataSet ds = dal.GetDataSet("ACDocTypeEntrys_GetDataByDocumentTypeID", documentTypeID);
            return ds;
        }
        /// <summary>
        /// Delete all doc type entry
        /// </summary>
        public void DeleteAllDocTypeEntry()
        {
            dal.ExecuteStoredProcedure("ACDocTypeEntrys_DeleteAllData");
        }

        /// <summary>
        /// Get doc type entry by document type id and entry type id
        /// </summary>
        /// <param name="documentTypeID">document type id</param>
        /// <param name="entryTypeID">entry type id</param>
        /// <returns>Info of the document type entry</returns>
        public ACDocTypeEntrysInfo GetDocTypeEntryByDocumentTypeIDAndEntryTypeID(int documentTypeID, int entryTypeID)
        {
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
            DataSet ds = dal.GetDataSet("ACDocTypeEntrys_GetDocTypeEntryByDocumentTypeIDAndEntryTypeID", documentTypeID, entryTypeID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                objDocTypeEntrysInfo = (ACDocTypeEntrysInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return objDocTypeEntrysInfo;
        }

        /// <summary>
        /// Get an entry of a document type by its name
        /// </summary>
        /// <param name="documentType">Document type</param>
        /// <param name="entryType">Entry type</param>
        /// <returns>Entry object</returns>
        public ACDocTypeEntrysInfo GetEntryByDocumentTypeAndEntryType(string documentType, string entryType)
        {
            List<ACDocTypeEntrysInfo> entries = GetEntriesByDocumentType(documentType);
            ACDocTypeEntrysInfo entry = entries.Where(e => e.ACEntryTypeName == entryType).FirstOrDefault();
            return entry;
        }
    }
    #endregion
}