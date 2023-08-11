using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelVoucher
{
    public partial class guiChooseSaleOrderItems : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public List<ARSaleOrderItemsInfo> SaleOrderItemList { get; set; }

        public List<ARSaleOrderItemsInfo> SelectedObjects { get; set; }

        public guiChooseSaleOrderItems()
        {
            InitializeComponent();
            SaleOrderItemList = new List<ARSaleOrderItemsInfo>();
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSApp.GetCurrentServerDate();
            InitializeLookupDatasource();
        }

        public void InitializeLookupDatasource()
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrderList = objSaleOrdersController.GetSaleOrderForCancelVoucher();
            fld_lkeFK_ARSaleOrderID.Properties.DataSource = saleOrderList;

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> listObjectFillter = new List<ADConfigValuesInfo>();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("SaleOrderProductType");
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    if(objConfigValuesInfo != null)
                    {
                        listObjectFillter.Add(objConfigValuesInfo);
                    }
                }
            }
            listObjectFillter.Insert(0, new ADConfigValuesInfo());
            fld_lkeARSaleOrderProductType.Properties.DataSource = listObjectFillter;
            fld_lkeARSaleOrderProductType.Properties.ValueMember = "ADConfigKeyValue";
            fld_lkeARSaleOrderProductType.Properties.DisplayMember = "ADConfigText";            
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

        private void guiChooseSaleOrderItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcSaleOrderItemsGridControl.InvalidateDataSource(SaleOrderItemList);
            GridView gridView = (GridView)fld_dgcSaleOrderItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
            fld_lkeARSaleOrderProductType.EditValue = SaleOrderProductType.Product.ToString();
            fld_lkeARSaleOrderProductType.RefreshEditValue();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = gridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int count = SelectedObjects.Select(o => o.FK_ARSaleOrderID).Distinct().Count();
            if (count > 1)
            {
                MessageBox.Show(CancelVoucherLocalizedResources.DuplicateErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            string strEditValue = string.Empty;
            int saleOrderID = 0;
            strEditValue = fld_lkeFK_ARSaleOrderID.EditValue == null ? "0" : fld_lkeFK_ARSaleOrderID.EditValue.ToString();
            Int32.TryParse(strEditValue, out saleOrderID);
            strEditValue = fld_lkeACObjectAccessKey.EditValue == null ? string.Empty : fld_lkeACObjectAccessKey.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(strEditValue);
            string saleOrderProductType = fld_lkeARSaleOrderProductType.EditValue == null ? string.Empty : fld_lkeARSaleOrderProductType.EditValue.ToString();
            string saleOrderSaleAgreement = fld_txtARSaleOrderSaleAgreement.EditValue == null ? string.Empty : fld_txtARSaleOrderSaleAgreement.EditValue.ToString();

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            SaleOrderItemList = objSaleOrderItemsController.GetSaleOrderItemsForCancelingByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                                    ModuleName.SaleOrder,
                                                                                                                    ADDataViewPermissionType.Module,
                                                                                                                    saleOrderID,
                                                                                                                    objObjectsInfo.ACObjectID,
                                                                                                                    objObjectsInfo.ACObjectType,
                                                                                                                    saleOrderProductType,
                                                                                                                    saleOrderSaleAgreement,
                                                                                                                    (DateTime?)fld_dteSearchFromDate.EditValue,
                                                                                                                    (DateTime?)fld_dteSearchToDate.EditValue);
            fld_dgcSaleOrderItemsGridControl.InvalidateDataSource(SaleOrderItemList);
        }
    }
}
