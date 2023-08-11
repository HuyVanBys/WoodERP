using BOSCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.MergeBOMChange.UI
{
    /// <summary>
    /// Summary description for DMMBC100
    /// </summary>
    public partial class DMMBC100 : BOSERPScreen
    {

        public DMMBC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeMMBatchProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int bpID = 0;
                if (fld_lkeMMBatchProductID.EditValue != null)
                {
                    int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out bpID);
                }

                if (bpID > 0)
                {
                    ((MergeBOMChangeModule)Module).AddBatchProductToItemList(bpID);
                }
            }
        }

        private void fld_lkeFK_MMProductionNormID_EditValueChanged(object sender, EventArgs e)
        {
            ClearBatchProduct();
        }

        private void fld_lkeMMMergeBOMChangeType_EditValueChanged(object sender, EventArgs e)
        {
            ClearBatchProduct();
            ChangeTabVisible();
            string type = string.Empty;
            if (fld_lkeMMMergeBOMChangeType.EditValue != null)
            {
                type = fld_lkeMMMergeBOMChangeType.EditValue.ToString();
            }
             ((MergeBOMChangeModule)Module).InitGridColumnByType(type);
        }

        private void ClearBatchProduct()
        {
            fld_lkeMMBatchProductID.Properties.DataSource = null;
            fld_lkeMMBatchProductID.EditValue = null;
        }

        private void ChangeTabVisible()
        {
            string type = string.Empty;
            if (fld_lkeMMMergeBOMChangeType.EditValue != null)
            {
                type = fld_lkeMMMergeBOMChangeType.EditValue.ToString();

                Dictionary<MergeBOMChangeType, List<string>> tabPageDic = GetTabPageDic();

                foreach (MergeBOMChangeType t in tabPageDic.Keys)
                {
                    if (t.ToString() == type)
                    {
                        foreach (XtraTabPage page in fld_tcChangeInfomation.TabPages)
                        {
                            page.PageVisible = (tabPageDic[t].Contains(page.Name));
                        }

                        break;
                    }
                }
            }
        }

        private Dictionary<MergeBOMChangeType, List<string>> GetTabPageDic()
        {
            Dictionary<MergeBOMChangeType, List<string>> tabPageDic
                    = new Dictionary<MergeBOMChangeType, List<string>>();

            tabPageDic.Add(MergeBOMChangeType.WoodStatus, new List<string>() { "fld_tpItem", "fld_tpMaterial" });
            tabPageDic.Add(MergeBOMChangeType.HardwareStatus, new List<string>() { "fld_tpItem" });
            tabPageDic.Add(MergeBOMChangeType.PaintStatus, new List<string>() { "fld_tpItem" });
            tabPageDic.Add(MergeBOMChangeType.PackingMaterialStatus, new List<string>() { "fld_tpItem" });
            tabPageDic.Add(MergeBOMChangeType.GeneralMaterialStatus, new List<string>() { "fld_tpItem" });
            tabPageDic.Add(MergeBOMChangeType.CarcassProccessStatus, new List<string>() { "fld_tpProcess" });
            tabPageDic.Add(MergeBOMChangeType.ColorProccessStatus, new List<string>() { "fld_tpProcess" });

            return tabPageDic;
        }

        private void fld_lkeFK_MMProductionNormID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            if (lke.OldEditValue != e.Value)
            {
                ((MergeBOMChangeModule)Module).ClearItem(true);
            }
        }

        private void fld_lkeMMMergeBOMChangeType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            if (lke.OldEditValue != e.Value)
            {
                ((MergeBOMChangeModule)Module).ClearItem(true);
            }
        }

        private void fld_btnLoadChange_Click(object sender, EventArgs e)
        {
            ((MergeBOMChangeModule)Module).LoadChange();
        }

        private void fld_lkeFK_MMProductionNormApproveLogID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            if (lke.OldEditValue != e.Value && e.Value != null)
            {
                ((MergeBOMChangeModule)Module).ClearItem(false);
                ((MergeBOMChangeModule)Module).ChangeApproveLog((int)e.Value);
            }
        }
    }
}
