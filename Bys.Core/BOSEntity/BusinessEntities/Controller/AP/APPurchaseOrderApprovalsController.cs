﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region APPurchaseOrderApprovals
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:APPurchaseOrderApprovalsController
	//Created Date:27/01/2021 00:00:00
	//-----------------------------------------------------------

	public class APPurchaseOrderApprovalsController : BaseBusinessController
	{
		public APPurchaseOrderApprovalsController()
		{
			dal = new DALBaseProvider("APPurchaseOrderApprovals", typeof(APPurchaseOrderApprovalsInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<APPurchaseOrderApprovalsInfo> items = new List<APPurchaseOrderApprovalsInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					APPurchaseOrderApprovalsInfo item = (APPurchaseOrderApprovalsInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}

		public List<APPurchaseOrderApprovalsInfo> GetItemByPurchaserOrderId(int purchaserOrderId)
		{
			DataSet ds = dal.GetDataSet("APPurchaseOrderApprovals_GetItemByPurchaserOrderId", purchaserOrderId);
			return (List<APPurchaseOrderApprovalsInfo>)GetListFromDataSet(ds);
		}
	}
	#endregion
}