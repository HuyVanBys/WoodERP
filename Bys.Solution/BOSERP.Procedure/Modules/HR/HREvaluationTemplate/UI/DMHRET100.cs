using System;

namespace BOSERP.Modules.HREvaluationTemplate.UI
{
    /// <summary>
    /// Summary description for DMHRET100
    /// </summary>
    public partial class DMHRET100 : BOSERPScreen
    {

        public DMHRET100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddNode_Click(object sender, EventArgs e)
        {
            ((HREvaluationTemplateModule)Module).AddItemToTemplateStandardList();
        }

        private void fld_btnRemoveNode_Click(object sender, EventArgs e)
        {
            ((HREvaluationTemplateModule)Module).RemoveItemFromTemplateStandardList();
        }
    }
}
