﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region ICBarcodes
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ICBarcodesController
	//Created Date:07/07/2022 00:00:00
	//-----------------------------------------------------------

	public class ICBarcodesController : BaseBusinessController
	{
		public ICBarcodesController()
		{
			dal = new DALBaseProvider("ICBarcodes", typeof(ICBarcodesInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<ICBarcodesInfo> items = new List<ICBarcodesInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					ICBarcodesInfo item = (ICBarcodesInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}

		public DataSet GetBarcodeListBySomeConditions(
															string barcodeNo,
															string barcodeReference,
															int? employeeID,
															DateTime? fromDate,
															DateTime? toDate)
		{
			DataSet ds = dal.GetDataSet("ICBarcodes_GetBarcodeListBySomeConditions", barcodeNo, barcodeReference, employeeID, fromDate, toDate);
			return ds;
		}
	}
	#endregion
}