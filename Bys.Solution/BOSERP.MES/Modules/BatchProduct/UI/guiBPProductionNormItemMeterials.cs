using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.BatchProduct
{
    public partial class guiBPProductionNormItemMeterials : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMBatchProductProductionNormItemMeterialsInfo> batchProductProductionNormItemMeterialList { get; set; }
        public BOSList<MMBatchProductProductionNormItemsInfo> batchProductProductionNormItemList { get; set; }
        #endregion

        public guiBPProductionNormItemMeterials(List<MMBatchProductProductionNormItemMeterialsInfo> batchProductProductionNormItemMeterialsInfoList
                                            , List<MMBatchProductProductionNormItemsInfo> batchProductProductionNormItemsInfoList)
        {
            InitializeComponent();
            batchProductProductionNormItemMeterialList = new BOSList<MMBatchProductProductionNormItemMeterialsInfo>(TableName.MMBatchProductProductionNormItemMeterialsTableName);
            if (batchProductProductionNormItemMeterialsInfoList != null && batchProductProductionNormItemMeterialsInfoList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemMeterialsInfo objBatchProductProductionNormItemMeterialsInfo in batchProductProductionNormItemMeterialsInfoList)
                {
                    batchProductProductionNormItemMeterialList.Add(objBatchProductProductionNormItemMeterialsInfo);
                }
            }

            batchProductProductionNormItemList = new BOSList<MMBatchProductProductionNormItemsInfo>("MMBatchProductProductionNormItems");
            if (batchProductProductionNormItemsInfoList != null && batchProductProductionNormItemsInfoList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo in batchProductProductionNormItemsInfoList)
                {
                    batchProductProductionNormItemList.Add(objBatchProductProductionNormItemsInfo);
                }
            }
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

        private void guiBPProductionNormItemMeterials_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcBatchProductProductionNormItemMeterials.InvalidateDataSource(batchProductProductionNormItemMeterialList);
            fld_dgcMMBatchProductProductionNormItemsMaterial.InvalidateDataSource(batchProductProductionNormItemList);
        }
    }
}
