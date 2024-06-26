using Localization;
using System;
using System.Windows.Forms;
namespace BOSERP.Modules.OperationPriceConfig.UI
{
    /// <summary>
    /// Summary description for DMOPC100
    /// </summary>
    public partial class DMOPC100 : BOSERPScreen
    {

        public DMOPC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((OperationPriceConfigModule)Module).ShowProducts();
        }
        private void fld_lkeICMeasureUnitID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value == null) return;
            int objectID = 0;
            int.TryParse(e.Value.ToString(), out objectID);
            if (objectID == 0) return;
            DialogResult dlgResult = MessageBox.Show("Bạn muốn cập nhật ĐVT vào chi tiết?"
                                      + Environment.NewLine + "Cancel: Chỉ cập nhật chi tiết chưa có ĐVT."
                                      + Environment.NewLine + "Yes: cập nhật tất cả chi tiết"
                                      + Environment.NewLine + "No: Thoát."
                                      , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No)
                return;
            else if (dlgResult == DialogResult.Cancel)
                ((OperationPriceConfigModule)Module).ApplyOperationOrMeasureUnitToList(objectID, false, true);
            else
                ((OperationPriceConfigModule)Module).ApplyOperationOrMeasureUnitToList(objectID, false, false);
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value == null) return;
            int objectID = 0;
            int.TryParse(e.Value.ToString(), out objectID);
            if (objectID == 0) return;

            DialogResult dlgResult = MessageBox.Show("Bạn muốn cập nhật công đoạn vào chi tiết?"
                                      + Environment.NewLine + "Cancel: Chỉ cập nhật chi tiết chưa có công đoạn."
                                      + Environment.NewLine + "Yes: cập nhật tất cả chi tiết"
                                      + Environment.NewLine + "No: Thoát."
                                      , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No)
                return;
            else if (dlgResult == DialogResult.Cancel)
                ((OperationPriceConfigModule)Module).ApplyOperationOrMeasureUnitToList(objectID, true, true);
            else
                ((OperationPriceConfigModule)Module).ApplyOperationOrMeasureUnitToList(objectID, true, false);
        }
    }
}
