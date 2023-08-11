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
    public partial class guiFindInvoiceAndShipment : BOSERPScreen
    {
        #region Variables
        public List<ARSaleOrderItemsInfo> SelectedObjects { get; set; }

        public List<ARSaleOrderItemsInfo> SaleOrderItemLists { get; set; }

        public GridControlHelper gridControlHelper;
        #endregion

        public guiFindInvoiceAndShipment(List<ARSaleOrderItemsInfo> saleOrderItemsList, string strActionNewFrom)
        {
            InitializeComponent();
            GridView gridView = (GridView)fld_dgcARSaleOrderItemsGridControl.MainView;
            gridView.ExpandAllGroups();
            if (strActionNewFrom == "FromInvoiceAndShipment")
            {
                SaleOrderItemLists = saleOrderItemsList.Where(o => o.FK_ARDeliveryPlanItemID > 0).ToList();
            }
            else
            {
                SaleOrderItemLists = saleOrderItemsList;
            }
            fld_dgcARSaleOrderItemsGridControl.InvalidateDataSource(SaleOrderItemLists, strActionNewFrom);
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ARSaleOrderItemsInfo>();
            GridView gridView = (GridView)fld_dgcARSaleOrderItemsGridControl.MainView;
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
            SelectedObjects = gridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();

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
    }
}