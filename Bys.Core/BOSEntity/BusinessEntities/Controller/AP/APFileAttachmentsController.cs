﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APFileAttachments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APFileAttachmentsController
    //Created Date:Monday, June 3, 2019
    //-----------------------------------------------------------

    public class APFileAttachmentsController : BaseBusinessController
    {
        public APFileAttachmentsController()
        {
            dal = new DALBaseProvider("APFileAttachments", typeof(APFileAttachmentsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APFileAttachmentsInfo> invoices = new List<APFileAttachmentsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APFileAttachmentsInfo objFileAttachmentsInfo = (APFileAttachmentsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objFileAttachmentsInfo);
                }
            }
            ds.Dispose();
            return invoices;
        }

        public List<APFileAttachmentsInfo> GetFileAttachmentByModuleAndObjectRef(string moduleName, string tableName, int objectRefID, int objectItemRefID)
        {
            DataSet ds = dal.GetDataSet("APFileAttachments_GetFileAttachmentByModuleAndObjectRef", moduleName, tableName, objectRefID, objectItemRefID);
            return (List<APFileAttachmentsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}