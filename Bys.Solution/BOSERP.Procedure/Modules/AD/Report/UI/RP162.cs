using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP162 : ReportForm
    {
        public List<ICShipmentItemsInfo> ReportDataSource { get; set; }

        public List<ICShipmentItemsInfo> ShipmentDetails { get; set; }

        public RP162()
        {
            InitializeComponent();
            ReportDataSource = new List<ICShipmentItemsInfo>();
            ShipmentDetails = new List<ICShipmentItemsInfo>();
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            GridView gridView = (GridView)fld_dgcRP125ICShipments.MainView;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            var woodList = ShipmentDetails.Where(o => item.IsWood
                                                      && o.FK_MMBatchProductID == item.FK_MMBatchProductID
                                                      && o.ICShipmentItemHeight == item.ICShipmentItemHeight
                                                      && o.ICShipmentItemExchangeUnitCost == item.ICShipmentItemExchangeUnitCost
                                                      && o.DepreciationRatePerBatchProduct == item.DepreciationRatePerBatchProduct
                                                      && o.FK_ICProductID == item.FK_ICProductID).ToList();
            fld_dgcRP125ICShipmentItemgo.DataSource = woodList;
            var plankList = ShipmentDetails.Where(o => !item.IsWood && o.FK_MMBatchProductID == item.FK_MMBatchProductID && o.FK_ICProductID == item.FK_ICProductID).ToList();
            fld_dgcRP125ICShipmentItemVan.DataSource = plankList;
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


        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    fld_dgcRP125ICShipments.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            string accessKey = fld_lkeACObjectAccessKey.EditValue == null ? string.Empty : fld_lkeACObjectAccessKey.EditValue.ToString();
            ACObjectsInfo objObjectsInfo = (new ACObjectsController()).GetObjectByAccessKey(accessKey);
            int batchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);

            ReportDataSource.Clear();
            ShipmentDetails.Clear();
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            DataSet ds = objReportsController.GetICShipmentItemForReport162(batchProductID, objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, searchFromDate, searchToDate);
            ICShipmentItemsController controller = new ICShipmentItemsController();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)controller.GetObjectFromDataRow(row);
                    ReportDataSource.Add(objShipmentItemsInfo);
                }
            }
            if (ds.Tables.Count > 1)
            {
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)controller.GetObjectFromDataRow(row);
                    ShipmentDetails.Add(objShipmentItemsInfo);
                }
            }
            fld_dgcRP125ICShipments.DataSource = ReportDataSource;
            fld_dgcRP125ICShipments.RefreshDataSource();

            BOSProgressBar.Close();
        }

        internal void GetAllData(int batchProductID, decimal shipmentItemHeight, int woodTypeID)
        {
            ADReportsController objReportsController = new ADReportsController();
            List<ICShipmentItemsInfo> ShipmentItemListDetailvan = objReportsController.GetICShipmentItemForReportDetailvan(batchProductID, shipmentItemHeight, woodTypeID);
            fld_dgcRP125ICShipmentItemVan.DataSource = ShipmentItemListDetailvan;
            List<ICShipmentItemsInfo> ShipmentItemListDetailgo = objReportsController.GetICShipmentItemForReportDetailgo(batchProductID, shipmentItemHeight, woodTypeID);
            fld_dgcRP125ICShipmentItemgo.DataSource = ShipmentItemListDetailgo;
        }
    }
}
