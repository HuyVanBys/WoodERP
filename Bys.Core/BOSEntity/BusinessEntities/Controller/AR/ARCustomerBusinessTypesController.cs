using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region ARCustomerBusinessTypes
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ARCustomerBusinessTypesController
	//Created Date:13/12/2021 00:00:00
	//-----------------------------------------------------------

	public class ARCustomerBusinessTypesController : BaseBusinessController
	{
		public ARCustomerBusinessTypesController()
		{
			dal = new DALBaseProvider("ARCustomerBusinessTypes", typeof(ARCustomerBusinessTypesInfo));
		}

		public override System.Collections.IList GetListFromDataSet(DataSet ds)
		{
			List<ARCustomerBusinessTypesInfo> items = new List<ARCustomerBusinessTypesInfo>();
			if (ds.Tables.Count > 0)
			{
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					ARCustomerBusinessTypesInfo item = (ARCustomerBusinessTypesInfo)GetObjectFromDataRow(row);
					items.Add(item);
				}
			}
			return items;
		}
	}
	#endregion
}