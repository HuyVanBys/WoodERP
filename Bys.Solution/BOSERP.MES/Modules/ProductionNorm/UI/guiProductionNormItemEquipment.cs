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
    public partial class guiProductionNormItemEquipment : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMProductionNormItemEquipmentsInfo> ProductionNormItemEquipmentList { get; set; }
        public BOSList<MMProductionNormItemEquipmentsInfo> RemoveProductionNormItemEquipmentList { get; set; }
        public decimal totalQty { get; set; }
        #endregion

        public guiProductionNormItemEquipment(List<MMProductionNormItemEquipmentsInfo> ProductionNormItemEquipmentsInfoList)
        {
            InitializeComponent();
            ProductionNormItemEquipmentList = new BOSList<MMProductionNormItemEquipmentsInfo>(TableName.MMProductionNormItemEquipmentsTableName);
            RemoveProductionNormItemEquipmentList = new BOSList<MMProductionNormItemEquipmentsInfo>(TableName.MMProductionNormItemEquipmentsTableName);
            if (ProductionNormItemEquipmentsInfoList != null && ProductionNormItemEquipmentsInfoList.Count > 0)
            {
                foreach (MMProductionNormItemEquipmentsInfo objProductionNormItemEquipmentsInfo in ProductionNormItemEquipmentsInfoList)
                {
                    ProductionNormItemEquipmentList.Add(objProductionNormItemEquipmentsInfo);
                }
            }
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            totalQty = 0;
            fld_dgcProductionNormItemEquipmentGridControl.InvalidateDataSource(ProductionNormItemEquipmentList);
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
                ProductionNormItemEquipmentList.SaveItemObjects();
                totalQty = ProductionNormItemEquipmentList.Sum(x => x.MMProductionNormItemEquipmentQty);
                if (RemoveProductionNormItemEquipmentList != null && RemoveProductionNormItemEquipmentList.Count > 0)
                {
                    RemoveProductionNormItemEquipmentList.DeleteItemObjects();
                }
                MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveProductionNormItemEquipmentsInfo(MMProductionNormItemEquipmentsInfo objProductionNormItemEquipmentsInfo)
        {
            RemoveProductionNormItemEquipmentList.Add(objProductionNormItemEquipmentsInfo);
        }
    }
}
