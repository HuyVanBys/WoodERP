using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using WIFASLib;


namespace WIFASERP
{
	#region ADPeriodes
	//-----------------------------------------------------------
	//Generated By: WIFAS Studio
	//Class:ADPeriodesController
	//Created Date:Montag, 23. April 2007
	//-----------------------------------------------------------
	
	public class ADPeriodesController:BaseBusinessController
	{
		public ADPeriodesController()
		{
			dal= new DALBaseProvider("ADPeriodes",typeof(ADPeriodesInfo));
		}
	}
	#endregion
}