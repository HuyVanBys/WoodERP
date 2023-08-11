using System;

namespace BOSERP.Modules.PaymentVoucher.UI
{
    /// <summary>
    /// Summary description for SMPMVC100
    /// </summary>
    public partial class SMPMVC100 : BOSERPScreen
    {

        public SMPMVC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        public void AddColumnToGridView()
        {
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Người tạo";
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            this.fld_dgvAPPaymentVoucher.Columns.Add(column);
        }

        private void fld_dgcAPPaymentVoucher_Load(object sender, EventArgs e)
        {
            AddColumnToGridView();
        }
    }
}
