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
    public partial class guiProductionNormItemMeterials : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMProductionNormItemMeterialsInfo> ProductionNormItemMeterialList { get; set; }
        public BOSList<MMProductionNormItemMeterialsInfo> RemoveProductionNormItemMeterialList { get; set; }
        public MMProductionNormItemsInfo objProductionNormItemsInfo { get; set; }
        #endregion

        public guiProductionNormItemMeterials(List<MMProductionNormItemMeterialsInfo> productionNormItemMeterialsInfoList)
        {
            InitializeComponent();
            ProductionNormItemMeterialList = new BOSList<MMProductionNormItemMeterialsInfo>(TableName.MMProductionNormItemMeterialsTableName);
            RemoveProductionNormItemMeterialList = new BOSList<MMProductionNormItemMeterialsInfo>(TableName.MMProductionNormItemMeterialsTableName);
            if (productionNormItemMeterialsInfoList != null && productionNormItemMeterialsInfoList.Count > 0)
            {
                foreach (MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo in productionNormItemMeterialsInfoList)
                {
                    ProductionNormItemMeterialList.Add(objProductionNormItemMeterialsInfo);
                }
            }
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcProductionNormItemMeterial.InvalidateDataSource(ProductionNormItemMeterialList);
            if (objProductionNormItemsInfo.MMProductionNormItemID > 0)
            {
                fld_lblProductSize.Text = objProductionNormItemsInfo.MMProductionNormItemNo + ": Dày "
                    + (int)objProductionNormItemsInfo.MMProductionNormItemProductHeight + ", Rộng: "
                    + (int)objProductionNormItemsInfo.MMProductionNormItemProductWidth + ", Dài: "
                    + (int)objProductionNormItemsInfo.MMProductionNormItemProductLength + ", Loại NL: "
                    + objProductionNormItemsInfo.MMProductionNormItemProductWoodType + ", Tỉ lệ tiêu hao: "
                    + objProductionNormItemsInfo.MMProductionNormItemDepreciationRate.ToString("N2") + ", Khối lượng tiêu hao: "
                    + objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable.ToString("N4");
            }
            fld_btnSave.Enabled = !this.Module.Toolbar.IsNullOrNoneAction();
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
                ProductionNormItemMeterialList.ForEach(x => { if (x.FK_MMProductionNormItemID == 0) x.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID; });
                if (ProductionNormItemMeterialList != null && ProductionNormItemMeterialList.Count > 0)
                {
                    List<int> check = ProductionNormItemMeterialList.GroupBy(x => new { x.FK_ICProductID, x.MMProductionNormItemMeterialHeigth }).Select(x => x.Count()).ToList();
                    if (check.Any(p => p > 1))
                    {
                        MessageBox.Show("Nguyên liệu không được trùng. Vui lòng kiểm tra lại!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    List<MMProductionNormItemMeterialsInfo> list = ProductionNormItemMeterialList.Where(x => x.MMProductionNormItemMeterialHeigth <= 0).ToList();
                    if (list != null && list.Count > 0)
                    {
                        MessageBox.Show("Dày cấp của nguyên liệu phải lớn hơn 0. Vui lòng kiểm tra lại!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    decimal totalBlock = ProductionNormItemMeterialList.Sum(x => x.MMProductionNormItemMeterialWoodBlocks);
                    if (totalBlock > objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable)
                    {
                      if(  MessageBox.Show("Tổng khối lượng cấp đang lớn hơn khối lượng theo tỉ lệ tiêu hao, bạn có lưu không?",
                          MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    }
                }
                ProductionNormItemMeterialList.SaveItemObjects();
                RemoveProductionNormItemMeterialList.DeleteItemObjects();
                MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                DialogResult = DialogResult.OK;
				Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveProductionNormItemMeterialsInfo(MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo)
        {
            RemoveProductionNormItemMeterialList.Add(objProductionNormItemMeterialsInfo);
        }
    }
}
