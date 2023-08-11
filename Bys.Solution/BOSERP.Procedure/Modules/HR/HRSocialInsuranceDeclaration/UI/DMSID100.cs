using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRSocialInsuranceDeclaration.UI
{
    /// <summary>
    /// Summary description for DMSID100
    /// </summary>
    public partial class DMSID100 : BOSERPScreen
    {


        public DMSID100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HRSocialInsuranceDeclarationModule)Module).AddEmployeeToItem();
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcHRSocialInsuranceDeclarationItemIncreases.MainView;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = @"Tệp Excel (.xls)|*.xls|All files (.*)|*.*";
            saveDialog.FilterIndex = 2;
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridView.ExportToXlsx(saveDialog.FileName + ".xlsx");
            }
        }
    }
}
