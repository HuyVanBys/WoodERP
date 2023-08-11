﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region MMDefaultAllocationOperationConfigs
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:MMDefaultAllocationOperationConfigsController
	//Created Date:11/22/2022 12:00:00 AM
	//-----------------------------------------------------------

	public class MMDefaultAllocationOperationConfigsController : BaseBusinessController
	{
		public MMDefaultAllocationOperationConfigsController()
		{
			dal = new DALBaseProvider("MMDefaultAllocationOperationConfigs", typeof(MMDefaultAllocationOperationConfigsInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<MMDefaultAllocationOperationConfigsInfo> items = new List<MMDefaultAllocationOperationConfigsInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					MMDefaultAllocationOperationConfigsInfo item = (MMDefaultAllocationOperationConfigsInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}
		public DataSet GetDefaultAllocationOperationConfigList()
		{
			return dal.GetDataSet("MMDefaultAllocationOperationConfigs_GetDefaultAllocationOperationConfigList");
		}
		public MMDefaultAllocationOperationConfigsInfo GetOperationByDepartmentAndProductGroup(int departmentID, int productGroupID)
		{
			DataSet ds = dal.GetDataSet("MMDefaultAllocationOperationConfigs_GetOperationByDepartmentAndProductGroup", departmentID, productGroupID);
			if (ds != null && ds.Tables[0].Rows.Count > 0)
			{
				MMDefaultAllocationOperationConfigsInfo objDfOperationsInfo = (MMDefaultAllocationOperationConfigsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
				ds.Dispose();
				return objDfOperationsInfo;
			}
			ds.Dispose();
			return null;
		}
	}
	#endregion
}