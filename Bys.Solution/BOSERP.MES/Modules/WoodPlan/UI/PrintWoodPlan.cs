using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPlan.UI
{
    public partial class PrintWoodPlan : BOSERPScreen
    {

        public PrintWoodPlan()
        {
            InitializeComponent();


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

        private void PrintWoodPlan_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            WoodPlanEntities entity = (WoodPlanEntities)((WoodPlanModule)Module).CurrentModuleEntity;
            entity.BatchProductProductionNormItemList.TreeListControl = fld_trlMMBatchProductProductionNormItems;
            entity.InvalidateBatchProductProductionNorm();


        }

        private void fld_btnUpdateWood_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog1.FileName;
                    fld_trlMMBatchProductProductionNormItems.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(MESLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(MESLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fld_trlMMBatchProductProductionNormItems_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null && (objProductionNormItemsInfo.ItemType == "Group" || objProductionNormItemsInfo.ItemType == "Product"))
                {

                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }


    }
}
