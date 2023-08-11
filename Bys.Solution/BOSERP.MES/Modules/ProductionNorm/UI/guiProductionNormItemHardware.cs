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


namespace BOSERP.Modules.ProductionNorm
{
    public partial class guiProductionNormItemHardware : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwareList { get; set; }
        public BOSList<MMProductionNormItemHardwaresInfo> RemoveProductionNormItemHardwareList { get; set; }
        public MMProductionNormItemsInfo objProductionNormItemsInfo { get; set; }
        public decimal totalQty { get; set; }
        #endregion
        public bool IsView = false;
        public guiProductionNormItemHardware(List<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwaresInfoList, bool isView)
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

            IsView = isView;
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
                if (!IsView)
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
                    MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveProductionNormItemHardwaresInfo(MMProductionNormItemHardwaresInfo objProductionNormItemHardwaresInfo)
        {
            if (!IsView)
            {
                RemoveProductionNormItemHardwareList.Remove(objProductionNormItemHardwaresInfo);
            }
        }
    }
}
