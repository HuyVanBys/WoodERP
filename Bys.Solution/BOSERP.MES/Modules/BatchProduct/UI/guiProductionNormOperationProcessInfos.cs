using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct.UI
{
    public partial class guiProductionNormOperationProcessInfos : BOSERPScreen
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the component list of the current item
        /// </summary>
        public BOSList<MMBatchProductItemOperationInfosInfo> ProductionNormProcessInfoList { get; set; }
        public BOSList<MMBatchProductItemOperationInfosInfo> RemoteProductionNormProcessInfoList { get; set; }
        public List<MMBatchProductItemOperationInfosInfo> ItemOperationList { get; set; }
        public MMBatchProductItemOperationInfosInfo BatchProductItemOperationInfosInfo { get; set; }
        #endregion

        public guiProductionNormOperationProcessInfos(MMBatchProductItemOperationInfosInfo objBatchProductItemOperationInfosInfo, List<MMBatchProductItemOperationInfosInfo> OperationList)
        {
            InitializeComponent();
            BatchProductItemOperationInfosInfo = objBatchProductItemOperationInfosInfo;
            ItemOperationList = OperationList;
            MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();
            List<MMBatchProductItemOperationInfosInfo> BatchProductItemOperationInfosList = objBatchProductItemOperationInfosController.GetOperationProcesssByBatchProductProductionNormItem(BatchProductItemOperationInfosInfo.FK_MMBatchProductProductionNormItemID);
            ProductionNormProcessInfoList = new BOSList<MMBatchProductItemOperationInfosInfo>(TableName.MMBatchProductItemOperationInfosTableName);
            RemoteProductionNormProcessInfoList = new BOSList<MMBatchProductItemOperationInfosInfo>(TableName.MMBatchProductItemOperationInfosTableName);

            //validate chi tiet
            if (BatchProductItemOperationInfosList != null && BatchProductItemOperationInfosList.Count > 0)
            {
                foreach (MMBatchProductItemOperationInfosInfo item in BatchProductItemOperationInfosList)
                {
                    ProductionNormProcessInfoList.Add(item);
                }
            }
            fld_dgcBatchProductItemOperationInfos.InvalidateDataSource(ProductionNormProcessInfoList);
        }

        private void guiProductionNormOperationProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcBatchProductItemOperationInfos.InvalidateDataSource(ProductionNormProcessInfoList);
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
            Close();
        }



        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProductionNormProcessInfoList.ForEach(point =>
                {
                    if (point.FK_MMBatchProductProductionNormItemID == 0)
                    {
                        point.FK_MMProductionNormItemID = BatchProductItemOperationInfosInfo.FK_MMProductionNormItemID;
                        MMBatchProductItemOperationInfosInfo itemOperation = ItemOperationList.Where(x => x.FK_MMProductionNormItemID == BatchProductItemOperationInfosInfo.FK_MMProductionNormItemID
                                                                                                            && x.FK_MMOperationID == point.FK_MMOperationID).FirstOrDefault();
                        if (itemOperation != null)
                            point.FK_MMBatchProductProductionNormItemID = itemOperation.FK_MMBatchProductProductionNormItemID;

                    }
                    if (point.FK_MMBatchProductItemOperationID == 0)
                    {
                        point.FK_MMProductionNormItemID = BatchProductItemOperationInfosInfo.FK_MMProductionNormItemID;
                        MMBatchProductItemOperationInfosInfo itemOperation = ItemOperationList.Where(x => x.FK_MMProductionNormItemID == BatchProductItemOperationInfosInfo.FK_MMProductionNormItemID
                                                                                                            && x.FK_MMOperationID == point.FK_MMOperationID
                                                                                                            && x.FK_MMBatchProductProductionNormItemID == point.FK_MMBatchProductProductionNormItemID).FirstOrDefault();
                        if (itemOperation != null)
                            point.FK_MMBatchProductItemOperationID = itemOperation.FK_MMBatchProductItemOperationID;
                    }
                });

                ProductionNormProcessInfoList.SaveItemObjects();
                RemoteProductionNormProcessInfoList.DeleteItemObjects();
                MessageBox.Show(MESLocalizedResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MESLocalizedResources.SaveErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveProductionNormProcessInfo(int index)
        {
            MMBatchProductItemOperationInfosInfo objBatchProductItemOperationInfosInfo = new MMBatchProductItemOperationInfosInfo();
            objBatchProductItemOperationInfosInfo = ProductionNormProcessInfoList[index];
            RemoteProductionNormProcessInfoList.Add(objBatchProductItemOperationInfosInfo);
            ProductionNormProcessInfoList.RemoveAt(index);
            fld_dgcBatchProductItemOperationInfos.RefreshDataSource();
        }


    }
}
