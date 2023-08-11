using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public partial class guiFindShipmentSaleOrder : BOSERPScreen
    {
        #region Variables
        public List<ICShipmentsInfo> SelectedObjects { get; set; }

        public List<ICShipmentsInfo> ShipmentLists { get; set; }

        public GridControlHelper gridControlHelper;
        #endregion

        public guiFindShipmentSaleOrder(List<ICShipmentsInfo> shipmentsList)
        {
            InitializeComponent();
            GridView gridView = (GridView)fld_dgcICShipmentsGridControl.MainView;
            gridView.ExpandAllGroups();
            ShipmentLists = shipmentsList;
            fld_dgcICShipmentsGridControl.InvalidateDataSource(ShipmentLists);
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ICShipmentsInfo>();
            GridView gridView = (GridView)fld_dgcICShipmentsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
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
            SelectedObjects = gridControlHelper.Selection.OfType<ICShipmentsInfo>().ToList();

            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ICShipmentsInfo objShipmentsInfo = SelectedObjects.FirstOrDefault(o => o.FK_GECurrencyID != SelectedObjects[0].FK_GECurrencyID);
            if (objShipmentsInfo != null)
            {
                MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                return;
            }

            objShipmentsInfo = SelectedObjects.FirstOrDefault(o => o.FK_ACObjectID != SelectedObjects[0].FK_ACObjectID || o.ICObjectType != SelectedObjects[0].ICObjectType);
            if (objShipmentsInfo != null)
            {
                MessageBox.Show(ReceiptVoucherLocalizedResources.ErrorObject,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                return;
            }

            objShipmentsInfo = SelectedObjects.FirstOrDefault(o => o.FK_ARSaleOrderID != SelectedObjects[0].FK_ARSaleOrderID);
            if (objShipmentsInfo != null)
            {
                MessageBox.Show("Vui lòng chọn các chứng từ có cùng Đơn bán hàng!",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
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
    }
}