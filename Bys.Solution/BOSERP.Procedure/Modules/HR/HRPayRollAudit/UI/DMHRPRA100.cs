using BOSComponent;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRollAudit.UI
{
    /// <summary>
    /// Summary description for DMHRPR100
    /// </summary>
    public partial class DMHRPRA100 : BOSERPScreen
    {

        public DMHRPRA100()
        {
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HRPayRollAuditModule)Module).AddEmployeeToPayRoll();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRPayRollAuditModule)Module).RemoveEmployeeFromPayRollList();
        }

        private void fld_lkeHRPayRollAuditType1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((HRPayRollAuditModule)Module).ChangePayRollType(e.Value.ToString());
            }
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            string[] columns = { "HREmployeePayRollAuditJobPerformanceAmt" };
            string[] columns2 = { "HREmployeePayRollAuditSoNguoiPhuThuoc", "HREmployeeWorkingSlrAmtFull", "HREmployeeContractSlrAmt",
                                  "HRLevelNo"};
            DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView = (DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)fld_dgcHREmployeePayRollAudits.MainView;
            for (int i = 0; i < columns.Count(); i++)
            {
                DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn column = gridView.Columns[columns[i]];
                if (column != null)
                {
                    column.OwnerBand.Visible = false;
                    break;
                }
            }
            for (int i = 0; i < columns2.Count(); i++)
            {
                DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn column = gridView.Columns[columns2[i]];
                if (column != null)
                {
                    column.Visible = false;
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = @"Tệp Excel (.xls)|*.xls|All files (.*)|*.*";
            saveDialog.FilterIndex = 2;
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridView.ExportToXlsx(saveDialog.FileName + ".xlsx");
            }

            for (int i = 0; i < columns.Count(); i++)
            {
                DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn column = gridView.Columns[columns[i]];
                if (column != null)
                {
                    column.OwnerBand.Visible = true;
                    break;
                }
            }
            for (int i = 0; i < columns2.Count(); i++)
            {
                DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn column = gridView.Columns[columns2[i]];
                if (column != null)
                {
                    column.Visible = true;
                }
            }
        }
    }
}
