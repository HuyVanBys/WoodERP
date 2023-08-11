﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region ARSaleOrderSaleTypeConfigs
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ARSaleOrderSaleTypeConfigsController
	//Created Date:11/04/2023 12:00:00 AM
	//-----------------------------------------------------------

	public class ARSaleOrderSaleTypeConfigsController : BaseBusinessController
	{
		public ARSaleOrderSaleTypeConfigsController()
		{
			dal = new DALBaseProvider("ARSaleOrderSaleTypeConfigs", typeof(ARSaleOrderSaleTypeConfigsInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<ARSaleOrderSaleTypeConfigsInfo> items = new List<ARSaleOrderSaleTypeConfigsInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					ARSaleOrderSaleTypeConfigsInfo item = (ARSaleOrderSaleTypeConfigsInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}
		public ARSaleOrderSaleTypeConfigsInfo GetConfigBySaleType(string saleType)
        {
			DataSet ds = dal.GetDataSet("ARSaleOrderSaleTypeConfigs_GetConfigBySaleType", saleType);
			if (ds.Tables[0].Rows.Count > 0)
			{
				ARSaleOrderSaleTypeConfigsInfo objSaleOrderSaleTypeConfigsInfo = (ARSaleOrderSaleTypeConfigsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
				return objSaleOrderSaleTypeConfigsInfo;
			}
			return null;
		}
	}
	#endregion
}