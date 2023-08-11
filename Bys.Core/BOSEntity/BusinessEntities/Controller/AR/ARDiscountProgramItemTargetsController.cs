﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARDiscountProgramItemTargets
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDiscountProgramItemTargetsController
    //Created Date:Tuesday, July 23, 2019
    //-----------------------------------------------------------

    public class ARDiscountProgramItemTargetsController : BaseBusinessController
    {
        public ARDiscountProgramItemTargetsController()
        {
            dal = new DALBaseProvider("ARDiscountProgramItemTargets", typeof(ARDiscountProgramItemTargetsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARDiscountProgramItemTargetsInfo> discountProgramItemTargets = new List<ARDiscountProgramItemTargetsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARDiscountProgramItemTargetsInfo objDiscountProgramItemTargetsInfo = (ARDiscountProgramItemTargetsInfo)GetObjectFromDataRow(row);
                    discountProgramItemTargets.Add(objDiscountProgramItemTargetsInfo);
                }
            }
            ds.Dispose();
            return discountProgramItemTargets;
        }

        public List<ARDiscountProgramItemTargetsInfo> GetAllItemByDiscountProgramRef(string discountProgramRef)
        {
            DataSet ds = dal.GetDataSet("ARDiscountProgramItemTargets_GetAllItemByDiscountProgramRef", discountProgramRef);
            return (List<ARDiscountProgramItemTargetsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}