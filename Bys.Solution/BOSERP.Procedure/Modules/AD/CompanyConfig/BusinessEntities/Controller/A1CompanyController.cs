using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using BOSLib;


namespace BOSERP
{
	#region A1Company
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:A1CompanyController
	//Created Date:Friday, April 13, 2007
	//-----------------------------------------------------------
	
	public class A1CompanyController:BaseBusinessController
	{
		public A1CompanyController()
		{
			dal= new DALBaseProvider("A1Company",typeof(A1CompanyInfo));
		}
	}
	#endregion
}