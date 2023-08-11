using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.SaleOrder
{
    public partial class guiShowSaleOrderByActualDeliveryDate<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<ARSaleOrdersInfo> SaleOrderList { get; set; }

        #endregion
        public guiShowSaleOrderByActualDeliveryDate(List<ARSaleOrdersInfo> saleOrder)
        {
            InitializeComponent();
            SaleOrderList = new BOSList<ARSaleOrdersInfo>(TableName.ARSaleOrdersTableName);
            SaleOrderList.Invalidate(saleOrder);
        }

        private void guiShowCollectionComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcARSaleOrderGridControl.InvalidateDataSource(SaleOrderList);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
    }
}