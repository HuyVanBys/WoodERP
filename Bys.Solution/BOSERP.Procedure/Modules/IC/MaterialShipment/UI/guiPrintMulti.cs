using BOSCommon.Constants;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialShipment
{
    public partial class guiPrintMulti : BOSERPScreen
    {
        #region Variables
        public BOSList<ICShipmentsInfo> ShipmentsList { get; set; }

        public IList<ICShipmentsInfo> SelectedObjects { get; set; }

        #endregion

        public guiPrintMulti()
        {
            InitializeComponent();
            ShipmentsList = new BOSList<ICShipmentsInfo>(TableName.ICShipmentsTableName);
        }

        private void guiPrintMulti_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.DateTime = BOSApp.GetCurrentServerDate().AddDays(-1);
            fld_dteSearchToDate.DateTime = BOSApp.GetCurrentServerDate();
            InitializeControls(Controls);
            GridView gridView = (GridView)fld_dgcPrintMultiMaterialShipmentsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            SelectedObjects = ShipmentsList.Where(s => s.Selected == true).ToList();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void GetDataSearch()
        {
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ShipmentsList.Invalidate(objShipmentsController.GetAllShipmentsForPrintMultiShipments(searchFromDate, searchToDate));
            fld_dgcPrintMultiMaterialShipmentsGridControl.DataSource = ShipmentsList;
            fld_dgcPrintMultiMaterialShipmentsGridControl.RefreshDataSource();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }
    }
}
