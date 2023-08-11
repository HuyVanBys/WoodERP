using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn.UI
{
    public partial class guiCheckColumnValue : BOSERPScreen
    {

        DataTable ColumnErrorTable;
        public guiCheckColumnValue(DataTable columnError)
        {
            InitializeComponent();
            ColumnErrorTable = columnError;
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

        private void guiCheckColumnValue_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            GridView gridView = (GridView)fld_dgcErrorList.MainView;

            if (gridView != null)
            {
                GridColumn columnError = new GridColumn();
                columnError.FieldName = "ErrorColumn";
                columnError.Visible = true;
                columnError.VisibleIndex = 0;
                columnError.MinWidth = 500;
                gridView.Columns.Add(columnError);
                foreach (GridColumn column in gridView.Columns)
                {
                    column.OptionsColumn.ShowCaption = false;
                }
            }
            fld_dgcErrorList.DataSource = ColumnErrorTable;
            fld_dgcErrorList.RefreshDataSource();
        }


        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
