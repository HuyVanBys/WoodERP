using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraTab;
using BOSCommon;
using Localization;
using BOSLib;
using BOSComponent;

namespace BOSERP.Modules.ShipmentSaleOrder.UI
{
	/// <summary>
	/// Summary description for DMSOSM102
	/// </summary>
	public partial class DMSOSM102 : BOSERPScreen
	{

		public DMSOSM102()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ((ShipmentSaleOrderModule)Module).InvalidateReportList();
        }
	}
}
