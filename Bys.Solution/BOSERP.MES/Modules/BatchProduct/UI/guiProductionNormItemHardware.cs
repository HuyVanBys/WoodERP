using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.BatchProduct
{
    public partial class guiProductionNormItemHardware : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMBatchProductProductionNormItemHardwaresInfo> BatchProductProductionNormItemHardwareList { get; set; }
        public BOSList<MMBatchProductProductionNormItemHardwaresInfo> RemoveBatchProductProductionNormItemHardwareList { get; set; }
        public decimal totalQty { get; set; }
        #endregion

        public guiProductionNormItemHardware(List<MMBatchProductProductionNormItemHardwaresInfo> BatchProductProductionNormItemHardwaresInfoList)
        {
            InitializeComponent();
            BatchProductProductionNormItemHardwareList = new BOSList<MMBatchProductProductionNormItemHardwaresInfo>(TableName.MMBatchProductProductionNormItemHardwaresTableName);
            RemoveBatchProductProductionNormItemHardwareList = new BOSList<MMBatchProductProductionNormItemHardwaresInfo>(TableName.MMBatchProductProductionNormItemHardwaresTableName);
            if (BatchProductProductionNormItemHardwaresInfoList != null && BatchProductProductionNormItemHardwaresInfoList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemHardwaresInfo objBatchProductProductionNormItemHardwaresInfo in BatchProductProductionNormItemHardwaresInfoList)
                {
                    BatchProductProductionNormItemHardwareList.Add(objBatchProductProductionNormItemHardwaresInfo);
                }
            }
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            totalQty = 0;
            fld_dgcBatchProductProductionNormItemHardware.InvalidateDataSource(BatchProductProductionNormItemHardwareList);
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

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            totalQty = 0;
            Close();
        }

        public void RemoveBatchProductProductionNormItemHardwaresInfo(MMBatchProductProductionNormItemHardwaresInfo objBatchProductProductionNormItemHardwaresInfo)
        {
            RemoveBatchProductProductionNormItemHardwareList.Add(objBatchProductProductionNormItemHardwaresInfo);
        }
    }
}
