using System;

namespace BOSERP.Modules.ImportData.UI
{
    /// <summary>
    /// Summary description for DMID101
    /// </summary>
    public partial class DMID101 : BOSERPScreen
    {

        public DMID101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnCheckData_Click(object sender, EventArgs e)
        {
            if (fld_lkeCheckDataType.EditValue != null)
            {
                ((ImportDataModule)Module).CheckData(fld_lkeCheckDataType.EditValue.ToString(), fld_dteCheckFromDate.DateTime, fld_dteCheckToDate.DateTime, fld_medResultData);
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn loại dữ liệu cần kiểm tra!");
            }

        }
    }
}
