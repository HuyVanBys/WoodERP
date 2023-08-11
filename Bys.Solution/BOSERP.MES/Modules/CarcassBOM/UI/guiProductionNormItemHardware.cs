using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class guiProductionNormItemHardware : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwareList { get; set; }
        public BOSList<MMProductionNormItemHardwaresInfo> RemoveProductionNormItemHardwareList { get; set; }
        public MMProductionNormItemsInfo objProductionNormItemsInfo { get; set; }
        public decimal totalQty { get; set; }
        #endregion

        public guiProductionNormItemHardware(List<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwaresInfoList)
        {
            InitializeComponent();
            ProductionNormItemHardwareList = new BOSList<MMProductionNormItemHardwaresInfo>(TableName.MMProductionNormItemHardwaresTableName);
            RemoveProductionNormItemHardwareList = new BOSList<MMProductionNormItemHardwaresInfo>(TableName.MMProductionNormItemHardwaresTableName);
            if (ProductionNormItemHardwaresInfoList != null && ProductionNormItemHardwaresInfoList.Count > 0)
            {
                foreach (MMProductionNormItemHardwaresInfo objProductionNormItemHardwaresInfo in ProductionNormItemHardwaresInfoList)
                {
                    ProductionNormItemHardwareList.Add(objProductionNormItemHardwaresInfo);
                }
            }
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            totalQty = 0;
            fld_lblHardwareQty.Text = (objProductionNormItemsInfo.MMProductionNormItemQuantity).ToString("N");
            fld_dgcProductionNormItemHardware.InvalidateDataSource(ProductionNormItemHardwareList);
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



        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (MMProductionNormItemHardwaresInfo item in ProductionNormItemHardwareList)
                {
                    if (item.MMProductionNormItemHardwareQty == 0)
                        RemoveProductionNormItemHardwareList.Add(item);
                    if (item.FK_MMProductionNormItemID == 0)
                        item.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                }
                ProductionNormItemHardwareList.SaveItemObjects();
                totalQty = ProductionNormItemHardwareList.Sum(x => x.MMProductionNormItemHardwareQty);
                if (RemoveProductionNormItemHardwareList != null && RemoveProductionNormItemHardwareList.Count > 0)
                {
                    RemoveProductionNormItemHardwareList.DeleteItemObjects();
                }

                MMProductionNormItemsController pniCtrl = new MMProductionNormItemsController();
                pniCtrl.UpdateObject(objProductionNormItemsInfo);

                MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveProductionNormItemHardwaresInfo(MMProductionNormItemHardwaresInfo objProductionNormItemHardwaresInfo)
        {
            RemoveProductionNormItemHardwareList.Remove(objProductionNormItemHardwaresInfo);
        }
    }
}
