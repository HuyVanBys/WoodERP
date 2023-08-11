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
using BOSERP.MES.Modules.MM.ProductionNorm.Localization;

namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class guiProductionNormItemPaint : BOSERPScreen
    {
        #region Public Properties
        public IBOSList<MMProductionNormItemPaintsInfo> ProductionNormItemPaintList { get; set; }
        public BOSList<MMProductionNormItemPaintsInfo> RemoveProductionNormItemPaintList { get; set; }
        public decimal TotalAcreage { get; set; }
        public string ProductDesc { get; set; }
        public decimal totalQty { get; set; }
        public int MMProductionNormItemID { get; set; }
        private int MMProductionNormID { get; set; }
        #endregion

        public guiProductionNormItemPaint(IBOSList<MMProductionNormItemPaintsInfo> productionNormItemPaintList, int productionNormID, int productionNormItemID)
        {
            InitializeComponent();
            ProductionNormItemPaintList = productionNormItemPaintList;
            MMProductionNormID = productionNormID;
            MMProductionNormItemID = productionNormItemID;
            RemoveProductionNormItemPaintList = new BOSList<MMProductionNormItemPaintsInfo>();
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            totalQty = 0;
            fld_dgcProductionNormItemPaint.InvalidateDataSource(ProductionNormItemPaintList, TotalAcreage);
            fld_txtMMProductionNormItemAcreage.EditValue = TotalAcreage;
            lblProductDesc.Text = ProductDesc;
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
                fld_dgcProductionNormItemPaint.MainView.EndDataUpdate();
                totalQty = ProductionNormItemPaintList.Sum(x => x.MMProductionNormItemPaintQty);
                if (totalQty > TotalAcreage)
                {
                    MessageBox.Show(ProductionNormLocalizeResources.SavePaintDetailUnSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
                if (!CheckExitPaintColor()) return;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckExitPaintColor()
        {
            bool result = true;
            
            foreach (MMProductionNormItemPaintsInfo item in ProductionNormItemPaintList)
            {
                List<MMProductionNormItemPaintsInfo> PaintCountList = ProductionNormItemPaintList.Where(x => x.FK_ICProductAttributeID == item.FK_ICProductAttributeID).ToList();
                if (PaintCountList != null && PaintCountList.Count > 1)
                {
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(item.FK_ICProductAttributeID);
                    if (objProductAttributesInfo != null)
                    {
                        MessageBox.Show(string.Format(ProductionNormLocalizeResources.PaintColorMultiExitsinListMessageError,
                            objProductAttributesInfo.ICProductAttributeValue), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                        return false;
                    }
                }
            }
            return result;
        }

        public void RemoveProductionNormItemPaints(MMProductionNormItemPaintsInfo objProductionNormItemPaintsInfo)
        {
            RemoveProductionNormItemPaintList.Add(objProductionNormItemPaintsInfo);
        }
    }
}
