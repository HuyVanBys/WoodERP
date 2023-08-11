using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSCommon;
using Localization;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.ProductionNorm.UI
{
    public partial class guiProductionNormProcessInfos : BOSERPScreen
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the component list of the current item
        /// </summary>
        public BOSList<MMProductionNormProcessInfosInfo> ProductionNormProcessInfoList { get; set; }
        public BOSList<MMProductionNormProcessInfosInfo> RemoteProductionNormProcessInfoList { get; set; }
        public List<MMProductionNormItemOperationsInfo> ItemOperationList { get; set; }
        public MMProductionNormItemOperationsInfo ProductionNormItemOperationsInfo { get; set; }
        public int IsError { get; set; }
        #endregion

        public guiProductionNormProcessInfos(MMProductionNormItemOperationsInfo objProductionNormItemOperationsInfo, List<MMProductionNormItemOperationsInfo> OperationList)
        {
            InitializeComponent();
            fld_btnAllowcateFromConfig.Enabled = true;
            ProductionNormItemOperationsInfo = objProductionNormItemOperationsInfo;
            ItemOperationList = OperationList;
            MMProductionNormProcessInfosController objProductionNormProcessInfosController = new MMProductionNormProcessInfosController();
           
            List<MMProductionNormProcessInfosInfo> ProductionNormProcessInfosList = 
                objProductionNormProcessInfosController.GetProductionNormProcessByProductionNorm(ProductionNormItemOperationsInfo.FK_MMProductionNormID, ProductionNormItemOperationsInfo.FK_MMProductionNormItemID);

            ProductionNormProcessInfoList = new BOSList<MMProductionNormProcessInfosInfo>(TableName.MMProductionNormProcessInfosTableName);
            RemoteProductionNormProcessInfoList = new BOSList<MMProductionNormProcessInfosInfo>(TableName.MMProductionNormProcessInfosTableName);
           
            //validate chi tiet
            if (ProductionNormProcessInfosList != null && ProductionNormProcessInfosList.Count > 0)
            {
                foreach (MMProductionNormProcessInfosInfo item in ProductionNormProcessInfosList)
                {
                    ProductionNormProcessInfoList.Add(item);
                }
                fld_btnAllowcateFromConfig.Enabled = false;
            }
            else // Truong hop tao moi: Lấy công đoạn theo danh sách công đoạn đã chọn
            {
                DialogResult dlgResult = MessageBox.Show("Không tìm thấy cấu hình."
                                          + Environment.NewLine + "Hệ thống sẽ mặc định thứ tự sản xuất theo công đoạn đã chọn."
                                          + Environment.NewLine + "Yes: Mặc định "
                                          + Environment.NewLine + "No: Không, tôi sẽ làm."
                                          , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {

                    int order = 1;
                    foreach (MMProductionNormItemOperationsInfo item in ItemOperationList)
                    {
                        MMProductionNormProcessInfosInfo processItem = new MMProductionNormProcessInfosInfo();
                        processItem.FK_MMOperationID = item.FK_MMOperationID;
                        processItem.FK_MMProductionNormID = item.FK_MMProductionNormID;
                        processItem.FK_MMProductionNormItemID = item.FK_MMProductionNormItemID;
                        processItem.MMProductionNormProcessInfoPeriod = order;
                        order++;
                        ProductionNormProcessInfoList.Add(processItem);
                    }
                }
            }
            fld_dgcProductionNormProcessInfos.InvalidateDataSource(ProductionNormProcessInfoList);
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcProductionNormProcessInfos.InvalidateDataSource(ProductionNormProcessInfoList);
            IsError = 0;
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
            try
            {
                bool notSave = false;
                ProductionNormProcessInfoList.ForEach(point =>
                {
                    if (point.MMProductionNormProcessInfoID == 0)
                    {
                        notSave = true;
                    }
                });
                if (notSave)
                {
                    DialogResult dlgResult = MessageBox.Show("Cấu hình của bạn chưa lưu, bạn có muốn lưu không?"
                                          , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlgResult == DialogResult.Yes)
                    {
                        ProductionNormProcessInfoList.SaveItemObjects();
                        RemoteProductionNormProcessInfoList.DeleteItemObjects();
                        MessageBox.Show(MESLocalizedResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Close();
                    }
                }
                if (ProductionNormProcessInfoList.GroupBy(n => n.MMProductionNormProcessInfoPeriod).Any(c => c.Count() > 1))
                {
                    IsError = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MESLocalizedResources.SaveErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.Cancel;
            Close();
        }

        

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProductionNormProcessInfoList.ForEach(point =>
                {
                    if (point.FK_MMProductionNormItemOperationID == 0)
                    {
                        point.FK_MMProductionNormItemID = ProductionNormItemOperationsInfo.FK_MMProductionNormItemID;
                        MMProductionNormItemOperationsInfo itemOperation = ItemOperationList.Where(x => x.FK_MMProductionNormItemID == ProductionNormItemOperationsInfo.FK_MMProductionNormItemID
                                                                                                            && x.FK_MMOperationID == point.FK_MMOperationID).FirstOrDefault();
                        if (itemOperation != null)
                            point.FK_MMProductionNormItemOperationID = itemOperation.MMProductionNormItemOperationID;

                    }
                });

                if (ProductionNormProcessInfoList.GroupBy(n => n.MMProductionNormProcessInfoPeriod).Any(c => c.Count() > 1))
                {
                    MessageBox.Show("Tồn tại chi tiết: công đoạn có thứ tự sản xuất trùng nhau."
                                    , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = 1;
                    return;
                }
                List<MMProductionNormProcessInfosInfo> listZeroProcess = ProductionNormProcessInfoList.Where(x => x.MMProductionNormProcessInfoPeriod == 0).ToList();
                if (listZeroProcess != null && listZeroProcess.Count > 0)
                {
                    MessageBox.Show("Tồn tại chi tiết có thứ tự sản xuất bằng 0"
                                            , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = 1;
                    return;
                }
                IsError = 0;
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
            MMProductionNormProcessInfosInfo objProductionNormProcessInfosInfo = new MMProductionNormProcessInfosInfo();
            objProductionNormProcessInfosInfo = ProductionNormProcessInfoList[index];
            RemoteProductionNormProcessInfoList.Add(objProductionNormProcessInfosInfo);
            ProductionNormProcessInfoList.RemoveAt(index);
            fld_dgcProductionNormProcessInfos.RefreshDataSource();
        }

        private void fld_btnAllowcateFromConfig_Click(object sender, EventArgs e)
        {
            int ProductionNormItemID = ProductionNormItemOperationsInfo.FK_MMProductionNormItemID;
            int ProductAttributeSpecialityID = ProductionNormItemOperationsInfo.FK_ICProductAttributeSpecialityID;

            MMProductionNormProcessInfosController objProductionNormProcessInfosController = new MMProductionNormProcessInfosController();
            List<MMProductionNormProcessInfosInfo> configProcessList = objProductionNormProcessInfosController.GetConfigByProductAttribute(ProductionNormItemID, ProductAttributeSpecialityID);
            if (configProcessList != null)
            {
                foreach (MMProductionNormProcessInfosInfo item in ProductionNormProcessInfoList)
                {
                    MMProductionNormProcessInfosInfo configItemProcessList = configProcessList.Where(x => x.FK_MMOperationID == item.FK_MMOperationID).FirstOrDefault();
                    if (configItemProcessList != null && configItemProcessList.FK_MMOperationID > 0)
                    {
                        item.MMProductionNormProcessInfoPeriod = configItemProcessList.MMProductionNormProcessInfoPeriod;
                        item.FK_ICProductID = configItemProcessList.FK_ICProductID;
                        item.MMProductionNormProcessInfoSetupTime = configItemProcessList.MMProductionNormProcessInfoSetupTime;
                        item.MMProductionNormProcessInfoProcessTime = configItemProcessList.MMProductionNormProcessInfoProcessTime;
                        item.MMProductionNormProcessInfoLeadTime = configItemProcessList.MMProductionNormProcessInfoLeadTime;
                        item.MMProductionNormProcessInfoDesc = configItemProcessList.MMProductionNormProcessInfoDesc;
                    }
                }
            }
            fld_dgcProductionNormProcessInfos.RefreshDataSource();

        }
    }
}
