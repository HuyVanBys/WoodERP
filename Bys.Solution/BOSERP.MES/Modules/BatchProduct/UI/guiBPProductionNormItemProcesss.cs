using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.BatchProduct
{
    public partial class guiBPProductionNormItemProcesss : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMBatchProductProductionNormItemProcesssInfo> batchProductProductionNormItemProcessList { get; set; }
        public BOSList<MMBatchProductProductionNormItemsInfo> batchProductProductionNormItemList { get; set; }
        #endregion

        public guiBPProductionNormItemProcesss(List<MMBatchProductProductionNormItemProcesssInfo> batchProductProductionNormItemProcesssInfoList
                    , List<MMBatchProductProductionNormItemsInfo> batchProductProductionNormItemsInfoList)
        {
            InitializeComponent();
            batchProductProductionNormItemProcessList = new BOSList<MMBatchProductProductionNormItemProcesssInfo>("MMBatchProductProductionNormItemProcesss");
            if (batchProductProductionNormItemProcesssInfoList != null && batchProductProductionNormItemProcesssInfoList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemProcesssInfo objBatchProductProductionNormItemProcesssInfo in batchProductProductionNormItemProcesssInfoList)
                {
                    batchProductProductionNormItemProcessList.Add(objBatchProductProductionNormItemProcesssInfo);
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

        private void guiBPProductionNormItemProcesss_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcBatchProductProductionNormItemProcesss.InvalidateDataSource(batchProductProductionNormItemProcessList);
            fld_dgcMMBatchProductProductionNormItemsMaterial.InvalidateDataSource(batchProductProductionNormItemList);
        }
    }
}
