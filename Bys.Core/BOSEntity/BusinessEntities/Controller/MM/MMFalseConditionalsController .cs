﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region MMFalseConditionals
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:MMFalseConditionalsController
	//Created Date:21/02/2024 12:00:00 AM
	//-----------------------------------------------------------

	public class MMFalseConditionalsController : BaseBusinessController
	{
		public MMFalseConditionalsController()
		{
			dal = new DALBaseProvider("MMFalseConditionals", typeof(MMFalseConditionalsInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<MMFalseConditionalsInfo> items = new List<MMFalseConditionalsInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					MMFalseConditionalsInfo item = (MMFalseConditionalsInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}
		public DataSet GetDataSetOfBranch(string falseConditionalNo
										, int objectID
										, string objectType
										, string falseConditionalPONo
										, string falseConditionalStatus
										, DateTime? falseConditionalDateFrom
										, DateTime? falseConditionalDateTo
										, int branchID)
		{
			return dal.GetDataSet("MMFalseConditionals_GetDataSetOfBranch", falseConditionalNo
															  , objectID
															  , objectType
															  , falseConditionalPONo
															  , falseConditionalStatus
															  , falseConditionalDateFrom
															  , falseConditionalDateTo
															  , branchID);
		}

		public DataSet GetDataSetOfBranchList(string MMFalseConditionalNo
										, int objectID
										, string objectType
										, string falseConditionalPONo
										, string falseConditionalStatus
										, DateTime? falseConditionalDateFrom
										, DateTime? falseConditionalDateTo
										, List<BRBranchsInfo> branchList)
		{
			DataSet rtn = new DataSet();
			foreach (BRBranchsInfo ojbBranchsInfo in branchList)
			{
				DataSet ds = GetDataSetOfBranch(MMFalseConditionalNo
												, objectID
												, objectType
												, falseConditionalPONo
												, falseConditionalStatus
												, falseConditionalDateFrom
												, falseConditionalDateTo
												, ojbBranchsInfo.BRBranchID);
				rtn.Merge(ds);
			}
			return rtn;
		}
		public MMFalseConditionalsInfo GetCurrentObject(int iObjectID)
        {
			DataSet ds = dal.GetDataSet("MMFalseConditionals_GetCurrentObject", iObjectID);
			MMFalseConditionalsInfo item = new MMFalseConditionalsInfo();
			if (ds.Tables[0].Rows.Count > 0 && ds != null)
            {
				item = (MMFalseConditionalsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
			}
			return item;
        }
	}
	#endregion
}