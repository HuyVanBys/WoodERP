using BOSCommon.Constants;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleForecast
{
    public partial class guiViewHistorySF : BOSERPScreen
    {
        public DateTime fromdate;
        public DateTime todate;
        public int customerID;
        public int productGroupID;
        public List<ARSaleForecastItemsInfo> ProductList = new List<ARSaleForecastItemsInfo>();
        public guiViewHistorySF()
        {
            InitializeComponent();
        }
        public guiViewHistorySF(int customerid)
        {
            InitializeComponent();
            ARCustomersController objCustomersController = new ARCustomersController();
            List<ARCustomersInfo> lstCustomers = objCustomersController.GetAllCustomer();
            fld_lkeFK_ARCustomerID1.Properties.DataSource = lstCustomers;
            fld_lkeFK_ARCustomerID1.EditValue = customerid;
            customerID = customerid;
        }
        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                InitializeFieldFormat(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }

        }
        private void guiViewHistorySF_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
            fld_txtARSaleForecastPercentQty.EditValue = 0;
            fld_lkeFK_ARCustomerID1.EditValue = customerID;
            //Add collumn for gridView
            GridView gridView = (GridView)fld_dgcHistorySaleForecast.MainView;
            GridColumn collumn = new GridColumn();
            collumn = new GridColumn();
            collumn.FieldName = "Selected";
            collumn.Caption = "Chọn";
            collumn.Visible = true;
            collumn.VisibleIndex = 0;
            gridView.Columns.Insert(0, collumn);
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void fld_btnSearch_Click(object sender, EventArgs e)
        {

            fromdate = fld_dteFromDate.DateTime;
            todate = fld_dteToDate.DateTime;
            customerID = 0;
            if (fld_lkeFK_ARCustomerID1.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_ARCustomerID1.EditValue.ToString(), out customerID);
            }
            productGroupID = 0;
            if (fld_lkeICProductGroupID.EditValue != null)
            {
                Int32.TryParse(fld_lkeICProductGroupID.EditValue.ToString(), out productGroupID);
            }
            if (customerID == 0)
            {
                MessageBox.Show("Khách hàng không được để trống", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ARSaleForecastItemsController soiController = new ARSaleForecastItemsController();
            ProductList = soiController.GetItemByViewHitorySF(fromdate, todate, customerID, productGroupID);
            fld_dgcHistorySaleForecast.DataSource = ProductList;
        }
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            decimal SaleForecastPercentQty = 0;
            decimal.TryParse(fld_txtARSaleForecastPercentQty.EditValue.ToString(), out SaleForecastPercentQty);
            SaleForecastEntities entity = (SaleForecastEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            ARSaleForecastsInfo mainObject = (ARSaleForecastsInfo)entity.MainObject;

            List<ARSaleForecastItemsInfo> selectedList = (List<ARSaleForecastItemsInfo>)fld_dgcHistorySaleForecast.DataSource;
            if (selectedList != null && selectedList.Any())
                selectedList = selectedList.Where(i => i.Selected).ToList();
            if (selectedList != null && selectedList.Any())
            {
                mainObject.FK_ARCustomerID = selectedList[0].FK_ARCustomerID;
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                if (objCustomersInfo != null)
                {
                    mainObject.FK_GECurrencyID = objCustomersInfo.FK_GECurrencyID;
                    mainObject.ARSaleForecastExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(objCustomersInfo.FK_GECurrencyID, mainObject.ARSaleForecastDate);
                }
                foreach (ARSaleForecastItemsInfo item in selectedList)
                {
                    //Tinh % tang giam SL
                    if (SaleForecastPercentQty < 0)
                        item.ARSaleForecastItemProductQty = Math.Round((item.ARSaleForecastItemProductQty - (item.ARSaleForecastItemProductQty * Math.Abs(SaleForecastPercentQty)) / 100), 0);
                    else if (SaleForecastPercentQty > 0)
                        item.ARSaleForecastItemProductQty = Math.Round((item.ARSaleForecastItemProductQty + (item.ARSaleForecastItemProductQty * Math.Abs(SaleForecastPercentQty)) / 100), 0);
                    //

                    ARSaleForecastItemsInfo objSaleForecastItemsInfo = (ARSaleForecastItemsInfo)entity.ModuleObjects[TableName.ARSaleForecastItemsTableName];
                    entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                    objSaleForecastItemsInfo.ARSaleForecastItemProductQty = item.ARSaleForecastItemProductQty;
                    objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty = objSaleForecastItemsInfo.ARSaleForecastItemProductQty;
                    entity.SetProductPriceByProductUnitPrice(objSaleForecastItemsInfo);
                    entity.ARSaleForecastItemsList.AddObjectToList();
                }
                entity.UpdateTotalAmount();
                entity.ARSaleForecastItemsList.GridControl.RefreshDataSource();
            }
            Close();
        }
        private void bosCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            ProductList.ForEach(i => i.Selected = fld_chkChecked.Checked);
            fld_dgcHistorySaleForecast.DataSource = ProductList;
            fld_dgcHistorySaleForecast.RefreshDataSource();
        }


    }
}
