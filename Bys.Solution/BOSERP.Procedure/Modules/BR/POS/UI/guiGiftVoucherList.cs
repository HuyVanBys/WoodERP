using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.POS
{
    public partial class guiGiftVoucherList : BOSERPScreen
    {
        public guiGiftVoucherList()
        {
            InitializeComponent();
        }

        private void guiGiftVoucherList_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            POSEntities entity = (POSEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            fld_dgcCreditNotes.DataSource = entity.CreditNoteList;
            entity.CreditNoteList.InitBOSListGridControl(fld_dgcCreditNotes);

            fld_dteFromDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetYearEndDate();

            GridView gridView = (GridView)fld_dgcCreditNotes.MainView;
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            SearchGiftVouchers();
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

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ((POSModule)Module).ViewGiftVoucher(objCreditNotesInfo);
            }
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            SearchGiftVouchers();
        }

        /// <summary>
        /// Search gift vouchers and display the result based on some criteria
        /// </summary>
        private void SearchGiftVouchers()
        {
            ((POSModule)Module).SearchGiftVouchers(fld_txtARCreditNoteNo.Text,
                                                Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue),
                                                fld_dteFromDate.DateTime,
                                                fld_dteToDate.DateTime);
        }
    }
}
