using BOSCommon;
using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Processs.UI
{
    public partial class guiProcessInfos : BOSERPScreen
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the component list of the current item
        /// </summary>
        public BOSList<MMProcessInfosInfo> ProcessInfoList { get; set; }
        public BOSList<MMProcessInfosInfo> RemoteProcessInfoList { get; set; }

        public ICProductAttributeItemsInfo ProductAttributeItemsInfo { get; set; }
        string ProcessStatus = string.Empty;
        #endregion

        public guiProcessInfos(ICProductAttributeItemsInfo objProductAttributeItemsInfo, string Status)
        {
            InitializeComponent();
            ProductAttributeItemsInfo = objProductAttributeItemsInfo;
            ProcessStatus = Status;
            MMProcessInfosController objProcessInfosController = new MMProcessInfosController();
            List<MMProcessInfosInfo> ProcessInfosList = (List<MMProcessInfosInfo>)objProcessInfosController.GetListFromDataSet(
                objProcessInfosController.GetAllDataByForeignColumn("FK_ICProductAttributeItemID", ProductAttributeItemsInfo.ICProductAttributeItemID));
            ProcessInfoList = new BOSList<MMProcessInfosInfo>(TableName.MMProcessInfosTableName);
            RemoteProcessInfoList = new BOSList<MMProcessInfosInfo>(TableName.MMProcessInfosTableName);
            foreach (MMProcessInfosInfo item in ProcessInfosList)
            {
                ProcessInfoList.Add(item);
            }
        }

        private void guiProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            if (ProcessStatus == BatchProductPlanStatus.Approved.ToString())
                fld_btnSave.Enabled = false;
            else
                fld_btnSave.Enabled = true;
            fld_dgcProcessInfos.InvalidateDataSource(ProcessInfoList);
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

                ProcessInfoList.ForEach(point =>
                {
                    if (point.FK_MMOperationID == 0)
                    {
                        point.FK_MMOperationID = ProductAttributeItemsInfo.FK_MMOperationID;
                        point.FK_ICProductAttributeItemID = ProductAttributeItemsInfo.ICProductAttributeItemID;
                    }
                });

                ProcessInfoList.SaveItemObjects();
                RemoteProcessInfoList.DeleteItemObjects();
                MessageBox.Show(MESLocalizedResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MESLocalizedResources.SaveErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveProcessInfo(int index)
        {
            MMProcessInfosInfo objProcessInfosInfo = new MMProcessInfosInfo();
            objProcessInfosInfo = ProcessInfoList[index];
            RemoteProcessInfoList.Add(objProcessInfosInfo);
            ProcessInfoList.RemoveAt(index);
            fld_dgcProcessInfos.RefreshDataSource();
        }

    }
}
