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
    public partial class guiChangeHardware : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMProductionNormItemsInfo> ProductionNormItemHardwareList { get; set; }
        #endregion

        public guiChangeHardware(List<MMProductionNormItemsInfo> prnItemHardwaresInfoList)
        {
            InitializeComponent();
            ProductionNormItemHardwareList = new BOSList<MMProductionNormItemsInfo>();
            ProductionNormItemHardwareList.Invalidate(prnItemHardwaresInfoList);
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcProductionNormItem.InvalidateDataSource(ProductionNormItemHardwareList);
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
                MMProductionNormItemsController objNormItemsController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> updateList = ProductionNormItemHardwareList.Where( h => h.Selected).ToList();
                if (updateList != null && updateList.Count > 0)
                {
                    bool isError = false;
                    ProductionNormItemHardwareList.ForEach(h => { if (h.Selected && h.FK_ICProductAlternativeID == 0) { h.IsError = true; isError = true; } });
                    if (isError)
                    {
                        MessageBox.Show(ProductionNormLocalizeResources.ChooseAlternativeErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show(ProductionNormLocalizeResources.ChooseAlternativeThisBOMMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ProductionNormItemHardwareList.ForEach(h =>
                        {
                            if (h.Selected && h.FK_ICProductAlternativeID > 0)
                            {
                                objNormItemsController.UpdateAlternativeHardware(h.MMProductionNormItemID, h.FK_ICProductID, h.FK_ICProductAlternativeID, BOSApp.CurrentUsersInfo.ADUserName);
                            }
                        });
                    }
                }
                else
                {
                    MessageBox.Show(ProductionNormLocalizeResources.ChooseNoneErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fld_btnApplyAllBom_Click(object sender, EventArgs e)
        {
            try
            {
                MMProductionNormItemsController objNormItemsController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> updateList = ProductionNormItemHardwareList.Where(h => h.Selected).ToList();
                if (updateList != null && updateList.Count > 0)
                {
                    bool isError = false;
                    ProductionNormItemHardwareList.ForEach(h => { if (h.Selected && h.FK_ICProductAlternativeID == 0) { h.IsError = true; isError = true; } });
                    if (isError)
                    {
                        MessageBox.Show(ProductionNormLocalizeResources.ChooseAlternativeErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show(ProductionNormLocalizeResources.ChooseAlternativeAllBOMMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ProductionNormItemHardwareList.ForEach(h =>
                        {
                            if (h.Selected && h.FK_ICProductAlternativeID > 0)
                            {
                                objNormItemsController.UpdateAlternativeHardware(null, h.FK_ICProductID, h.FK_ICProductAlternativeID, BOSApp.CurrentUsersInfo.ADUserName);
                            }
                        });
                    }
                }
                else
                {
                    MessageBox.Show(ProductionNormLocalizeResources.ChooseNoneErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
