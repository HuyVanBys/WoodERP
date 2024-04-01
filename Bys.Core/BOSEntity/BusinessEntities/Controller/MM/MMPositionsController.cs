﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region MMPositions
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:MMPositionsController
	//Created Date:20/12/2023 12:00:00 AM
	//-----------------------------------------------------------

	public class MMPositionsController : BaseBusinessController
	{
		public MMPositionsController()
		{
			dal = new DALBaseProvider("MMPositions", typeof(MMPositionsInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<MMPositionsInfo> items = new List<MMPositionsInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					MMPositionsInfo item = (MMPositionsInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}
        public DataSet GetDataSetOfBranch(string positionNo
                                        , string positionName
                                        , string positionSymbol
                                        , int? positionLevel
                                        , string positionGELocationName
                                        , string positionType
                                        , int branchID)
        {
            return dal.GetDataSet("MMPositions_GetDataSetOfBranch", positionNo
                                                              , positionName
                                                              , positionSymbol
                                                              , positionLevel
                                                              , positionGELocationName
                                                              , positionType
                                                              , branchID);
        }

        public DataSet GetDataSetOfBranchList(string positionNo
                                        , string positionName
                                        , string positionSymbol
                                        , int? positionLevel
                                        , string positionGELocationName
                                        , string positionType
                                        , List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetDataSetOfBranch(positionNo
                                                , positionName
                                                , positionSymbol
                                                , positionLevel
                                                , positionGELocationName
                                                , positionType
                                                , ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }
            return rtn;
        }
        public List<MMPositionsInfo> GetAllPositionList()
        {
            DataSet ds = dal.GetAllObject();
            List<MMPositionsInfo> positions = new List<MMPositionsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMPositionsInfo objPositionsInfo = (MMPositionsInfo)GetObjectFromDataRow(row);
                    positions.Add(objPositionsInfo);
                }
            }
            return positions;
        }
    }
	#endregion
}