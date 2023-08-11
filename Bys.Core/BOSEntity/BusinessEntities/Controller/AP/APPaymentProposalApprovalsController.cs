﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region APPaymentProposalApprovals
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:APPaymentProposalApprovalsController
	//Created Date:05/03/2021 00:00:00
	//-----------------------------------------------------------

	public class APPaymentProposalApprovalsController : BaseBusinessController
	{
		public APPaymentProposalApprovalsController()
		{
			dal = new DALBaseProvider("APPaymentProposalApprovals", typeof(APPaymentProposalApprovalsInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<APPaymentProposalApprovalsInfo> items = new List<APPaymentProposalApprovalsInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					APPaymentProposalApprovalsInfo item = (APPaymentProposalApprovalsInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}

		public List<APPaymentProposalApprovalsInfo> GetItemByProposalID(int proposalId)
		{
			DataSet ds = dal.GetDataSet("APPaymentProposalApprovals_GetItemByProposalID", proposalId);
			return (List<APPaymentProposalApprovalsInfo>)GetListFromDataSet(ds);
		}
	}
	#endregion
}