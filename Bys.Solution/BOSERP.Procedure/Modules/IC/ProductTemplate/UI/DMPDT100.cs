using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductTemplate.UI
{
    /// <summary>
    /// Summary description for DMPDT100
    /// </summary>
    public partial class DMPDT100 : BOSERPScreen
    {

        public DMPDT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnProductTemplateAddParent_Click(object sender, EventArgs e)
        {
            int configID = 0;
            if (int.TryParse(fld_lkeFK_ICProductTemplateConfigID.EditValue.ToString(), out configID))
            {
                ((ProductTemplateModule)Module).AddProductTemplateConfig(configID, true);
            }
        }

        private void fld_btnTemplateAddChild_Click(object sender, EventArgs e)
        {
            int configID = 0;
            if (int.TryParse(fld_lkeFK_ICProductTemplateConfigID.EditValue.ToString(), out configID))
            {
                ((ProductTemplateModule)Module).AddProductTemplateConfig(configID, false);
            }
        }
    }
}
