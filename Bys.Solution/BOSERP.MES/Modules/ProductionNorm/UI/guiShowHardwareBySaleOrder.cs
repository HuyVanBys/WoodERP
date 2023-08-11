using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;


namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class guiShowHardwareBySaleOrder<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<ARSaleOrderItemsInfo> SaleOrderItemList { get; set; }

        #endregion
        public guiShowHardwareBySaleOrder(List<ARSaleOrderItemsInfo> saleOrderItem)
        {
            InitializeComponent();
            SaleOrderItemList = new BOSList<ARSaleOrderItemsInfo>(TableName.ARSaleOrderItemsTableName);
            SaleOrderItemList.Invalidate(saleOrderItem);
        }

        private void guiShowCollectionComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcARSaleOrderItemGridControl.InvalidateDataSource(SaleOrderItemList);
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