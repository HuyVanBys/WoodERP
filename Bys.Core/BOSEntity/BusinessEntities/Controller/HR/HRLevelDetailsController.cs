﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRLevelDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRLevelDetailsController
    //Created Date:Wednesday, July 18, 2018
    //-----------------------------------------------------------

    public class HRLevelDetailsController : BaseBusinessController
    {
        public HRLevelDetailsController()
        {
            dal = new DALBaseProvider("HRLevelDetails", typeof(HRLevelDetailsInfo));
        }
        public List<HRLevelDetailsInfo> GetLevelDetailByLevelID(int levelID)
        {
            DataSet ds = dal.GetDataSet("HRLevelDetails_GetLevelDetailByLevelID", levelID);
            List<HRLevelDetailsInfo> itemDetails = new List<HRLevelDetailsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                HRLevelDetailsController objLevelDetailsController = new HRLevelDetailsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRLevelDetailsInfo objLevelDetailsInfo = (HRLevelDetailsInfo)objLevelDetailsController.GetObjectFromDataRow(row);
                    itemDetails.Add(objLevelDetailsInfo);
                }
            }
            return itemDetails;
        }
    }
    #endregion
}