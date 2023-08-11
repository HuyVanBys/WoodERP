using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiChooseAccount : BOSERPScreen
    {

        /// <summary>
        /// Gets or sets account list
        /// </summary>
        public List<ACDocTypeEntryAccountsInfo> DocTypeEntryAccountList { get; set; }

        /// <summary>
        /// Gets or sets account no
        /// </summary>
        public String ACAccountNo { get; set; }

        public guiChooseAccount()
        {
            InitializeComponent();
        }

        public guiChooseAccount(List<ACDocTypeEntryAccountsInfo> docTypeEntryAccountList)
        {
            InitializeComponent();
            DocTypeEntryAccountList = docTypeEntryAccountList;
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

        private void guiChooseAccount_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcACDocTypeEntryAccounts.DataSource = DocTypeEntryAccountList;
            GridView gridView = (GridView)fld_dgcACDocTypeEntryAccounts.MainView;
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ChooseAccount();
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChooseAccount();
            }
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            ChooseAccount();
        }

        /// <summary>
        /// Choose an account
        /// </summary>
        private void ChooseAccount()
        {
            DialogResult = DialogResult.OK;
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcACDocTypeEntryAccounts.MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ACDocTypeEntryAccountsInfo objDocTypeEntryAccountsInfo = (ACDocTypeEntryAccountsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ACAccountNo = objDocTypeEntryAccountsInfo.ACAccountNo;
            }
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
