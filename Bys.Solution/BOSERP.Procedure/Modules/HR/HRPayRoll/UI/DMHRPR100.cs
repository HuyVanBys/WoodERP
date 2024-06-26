using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRoll.UI
{
    /// <summary>
    /// Summary description for DMHRPR100
    /// </summary>
    public partial class DMHRPR100 : BOSERPScreen
    {

        public DMHRPR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HRPayRollModule)Module).AddEmployeeToPayRoll();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRPayRollModule)Module).RemoveEmployeeFromPayRollList();
        }

        private void fld_lkeHRPayRollType1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((HRPayRollModule)Module).ChangePayRollType(e.Value.ToString());
            }
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView = (DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)fld_dgcHREmployeePayRolls.MainView;
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
