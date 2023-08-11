﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region ICShipmentItemComponents
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ICShipmentItemComponentsController
	//Created Date:06/04/2021 12:00:00 AM
	//-----------------------------------------------------------

	public class ICShipmentItemComponentsController : BaseBusinessController
	{
		public ICShipmentItemComponentsController()
		{
			dal = new DALBaseProvider("ICShipmentItemComponents", typeof(ICShipmentItemComponentsInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<ICShipmentItemComponentsInfo> items = new List<ICShipmentItemComponentsInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					ICShipmentItemComponentsInfo item = (ICShipmentItemComponentsInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}
		public List<ICShipmentItemComponentsInfo> GetShipmentItemComponentListByShipmentItemID(int shipmentItemID)
		{
			DataSet ds = dal.GetDataSet("ICShipmentItemComponents_GetShipmentItemComponentListByShipmentItemID", shipmentItemID);
			return (List<ICShipmentItemComponentsInfo>)GetListFromDataSet(ds);
		}
	}
	#endregion
}