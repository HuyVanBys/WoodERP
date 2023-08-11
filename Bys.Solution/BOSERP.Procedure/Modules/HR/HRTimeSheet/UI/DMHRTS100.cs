using BOSComponent;
using BOSLib;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTimeSheet.UI
{
    /// <summary>
    /// Summary description for DMHRTS100
    /// </summary>
    public partial class DMHRTS100 : BOSERPScreen
    {

        public DMHRTS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HRTimeSheetModule)Module).AddEmployeeToTimeSheet();
        }

        private void fld_dteHRTimeSheetDate1_Validated(object sender, EventArgs e)
        {
            ((HRTimeSheetModule)Module).isCustomDrawCell = false;
            ((HRTimeSheetModule)Module).ChangeTimeSheetTime();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRTimeSheetModule)Module).RemoveEmployeeFromTimeSheetList();
        }

        private void fld_lkeHRTimeSheetType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((HRTimeSheetModule)Module).ChangeTimeSheetType(e.Value.ToString());
            }
        }

        private void fld_btnAddFromFile_Click(object sender, EventArgs e)
        {
            ((HRTimeSheetModule)Module).AddEmployeesFromTimeKeeper();
        }

        private void bosDateEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime dt = (DateTime)e.NewValue;
            int n1 = fld_dteHRTimeSheetDate1.DateTime.Year;
            int n2 = fld_dteHRTimeSheetDate1.DateTime.Month;
            if (dt.Date > ((DateTime)bosDateEdit2.EditValue).Date) bosDateEdit2.DateTime = dt.Date;
            ((HRTimeSheetModule)Module).isCustomDrawCell = false;
        }

        private void bosDateEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime dt = (DateTime)e.NewValue;
            if (dt.Date < ((DateTime)bosDateEdit1.EditValue).Date) bosDateEdit1.DateTime = dt.Date;
            ((HRTimeSheetModule)Module).isCustomDrawCell = false;

        }

        private void fld_dteHRTimeSheetDate1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void fld_dteHRTimeSheetDate1_Validated_1(object sender, EventArgs e)
        {
            int n1 = fld_dteHRTimeSheetDate1.DateTime.Year;
            int n2 = fld_dteHRTimeSheetDate1.DateTime.Month;
            DateTime date = new DateTime(n1, n2, 1);
            DateTime dateEndMonth = BOSUtil.GetMonthEndDate(date);

            bosDateEdit2.DateTime = dateEndMonth;
            bosDateEdit1.DateTime = date;
            ((HRTimeSheetModule)Module).isCustomDrawCell = false;
            ((HRTimeSheetModule)Module).ChangeTimeSheetTime();
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView = (DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)fld_dgcHREmployeeTimeSheets.MainView;
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
