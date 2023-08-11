using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public partial class guiPrintMultiDeliveryPlan : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ARDeliveryPlansInfo> SelectedObjects { get; set; }

        public List<ARDeliveryPlansInfo> DeliveryPlanList { get; set; }

        public DateTime? DeliveryPlanFromDate { get; set; }

        public DateTime? DeliveryPlanToDate { get; set; }

        public string StrDeliveryPlanType { get; set; }
        #endregion

        public guiPrintMultiDeliveryPlan()
        {
            InitializeComponent();
            InitBindingDatasource();
            DeliveryPlanList = new List<ARDeliveryPlansInfo>();
        }

        private void guiChooseMaterials_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ARDeliveryPlansInfo>();
            fld_dgcDeliveryPlansGridControl.InvalidateDataSource(DeliveryPlanList);
            GridView gridView = (GridView)fld_dgcDeliveryPlansGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsMenu.EnableFooterMenu = false;
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
            fld_dteDeliveryPlanDateFrom.EditValue = DeliveryPlanFromDate;
            fld_dteDeliveryPlanDateTo.EditValue = DeliveryPlanToDate;
            fld_lkeARDeliveryPlanType.EditValue = StrDeliveryPlanType;
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<ARDeliveryPlansInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            DataSet deliveryPlans = objDeliveryPlansController.GetAllObjects();
            fld_lkeFK_ARDeliveryPlanID.Properties.DataSource = deliveryPlans.Tables[0];

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("DeliveryPlanType");
            fld_lkeARDeliveryPlanType.Properties.DataSource = ds.Tables[0];
            fld_lkeARDeliveryPlanType.Properties.ValueMember = "Value";
            fld_lkeARDeliveryPlanType.Properties.DisplayMember = "Text";

            GridView gridView = (GridView)fld_dgcDeliveryPlansGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            int deliveryPlanID = fld_lkeFK_ARDeliveryPlanID.EditValue == null ? 0 : (int)fld_lkeFK_ARDeliveryPlanID.EditValue;
            string deliveryPlanType = fld_lkeARDeliveryPlanType.EditValue == null ? string.Empty : fld_lkeARDeliveryPlanType.EditValue.ToString();
            StrDeliveryPlanType = deliveryPlanType;
            DeliveryPlanFromDate = (DateTime?)fld_dteDeliveryPlanDateFrom.EditValue;
            DeliveryPlanToDate = (DateTime?)fld_dteDeliveryPlanDateTo.EditValue;

            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            List<ARDeliveryPlansInfo> deliveryPlanList = objDeliveryPlansController.GetDeliveryPlanForMultiSummaryRP(deliveryPlanID
                                                                                                                     , deliveryPlanType
                                                                                                                     , DeliveryPlanFromDate
                                                                                                                     , DeliveryPlanToDate);
            DeliveryPlanList = deliveryPlanList;
            fld_dgcDeliveryPlansGridControl.InvalidateDataSource(deliveryPlanList);
        }

        private void fld_lkeARDeliveryPlanType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            if (lke.EditValue == null || (lke != null && lke.OldEditValue == e.Value))
                return;
            StrDeliveryPlanType = lke.EditValue.ToString();
        }

        private void fld_dteDeliveryPlanDateFrom_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = sender as BOSDateEdit;
            if (lke == null)
                return;
            DeliveryPlanFromDate = (fld_dteDeliveryPlanDateFrom.EditValue as DateTime?) ?? DateTime.MaxValue;
        }

        private void fld_dteDeliveryPlanDateTo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = sender as BOSDateEdit;
            if (lke == null)
                return;
            DeliveryPlanToDate = (fld_dteDeliveryPlanDateTo.EditValue as DateTime?) ?? DateTime.MaxValue;
        }
    }
}