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
using System.Collections.Generic;

namespace BOSERP.Modules.ShipmentSaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSOSM101
    /// </summary>
    public partial class DMSOSM101 : BOSERPScreen
    {

        public DMSOSM101()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
           
        }
    }
}
