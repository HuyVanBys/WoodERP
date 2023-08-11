﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region ADDirectoryPathConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADDirectoryPathConfigsController
    //Created Date:Tuesday, April 09, 2019
    //-----------------------------------------------------------

    public class ADDirectoryPathConfigsController : BaseBusinessController
    {
        public ADDirectoryPathConfigsController()
        {
            dal = new DALBaseProvider("ADDirectoryPathConfigs", typeof(ADDirectoryPathConfigsInfo));
        }
        public DataSet GetInvalidateDirectoryPathList()
        {
            return dal.GetDataSet("ADDirectoryPathConfigs_GetInvalidateDirectoryPathList");
        }
        public ADDirectoryPathConfigsInfo GetInfoByImageFolderType(string imageFolderType)
        {
            DataSet ds = dal.GetDataSet("ADDirectoryPathConfigs_GetInfoByImageFolderType", imageFolderType);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADDirectoryPathConfigsInfo objDirectoryPathConfigsInfo = (ADDirectoryPathConfigsInfo)GetObjectFromDataRow(row);
                    ds.Dispose();
                    return objDirectoryPathConfigsInfo;
                }
            }
            ds.Dispose();
            return null;
        }
    }
    #endregion
}