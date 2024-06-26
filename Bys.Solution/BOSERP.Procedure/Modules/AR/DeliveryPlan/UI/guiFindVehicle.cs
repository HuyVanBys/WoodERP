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
    public partial class guiFindVehicle : BOSERPScreen
    {
        #region Variables
        public List<VMVehiclesInfo> SelectedObjects { get; set; }

        public List<VMVehiclesInfo> VehicleLists { get; set; }


        private string vehicleList = "";
        #endregion

        public guiFindVehicle(string vhcList)
        {
            InitializeComponent();
            vehicleList = vhcList;
        }

        private void SetDefault()
        {
            //fld_dteARSaleOrderDeliveryDateForm.EditValue = BOSApp.GetCurrentServerDate();
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
            SelectedObjects = VehicleLists.Where(o => o.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsExistKeyWord(String value, String keyWord)
        {
            value = value.ToLower();
            keyWord = keyWord.ToLower();
            String[] arrElement = keyWord.Split(new char[] { ' ' });
            bool isExist = false;
            foreach (String element in arrElement)
            {
                if (value.Contains(element))
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                value = BOSUtil.ConvertUnicodeStringToUnSign(value);
                foreach (String element in arrElement)
                {
                    if (value.Contains(element))
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }

        private void fld_chkSelectedAll_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            VehicleLists.ForEach(o => o.Selected = (bool)e.NewValue);
            fld_dgcVMVehicles.RefreshDataSource();
        }

        private void guiFindVehicle_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            VehicleLists = new List<VMVehiclesInfo>();
            VMVehiclesController objVehiclesController = new VMVehiclesController();
            VehicleLists = objVehiclesController.SelectALLNotInVMVehicleIDs(vehicleList);
            fld_dgcVMVehicles.InvalidateDataSource(VehicleLists);
            GridView gridView = (GridView)fld_dgcVMVehicles.MainView;
            //gridView.ExpandAllGroups();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}