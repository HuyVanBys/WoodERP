using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.RetailVAT
{
    public partial class guiChoosePOSItems : BOSERPScreen
    {
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public List<ARInvoiceItemsInfo> POSItemList { get; set; }

        public List<ARInvoiceItemsInfo> SelectedObjects { get; set; }

        public guiChoosePOSItems(List<ARInvoiceItemsInfo> posItemList)
        {
            InitializeComponent();
            POSItemList = new List<ARInvoiceItemsInfo>();
            POSItemList = posItemList;
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

        private void fld_dgcARDeliveryPlanItemsGridControl_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcARInvoiceItemsGridControl.InvalidateDataSource(POSItemList);
            GridView gridView = (GridView)fld_dgcARInvoiceItemsGridControl.MainView;
            SelectedObjects = new List<ARInvoiceItemsInfo>();
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            if (fld_txtFind.Text != "Nhập từ khóa")
            {
                keyWord = fld_txtFind.Text;
            }
            SearchData(keyWord);
        }

        public void SearchData(String keyWord)
        {
            fld_dgcARInvoiceItemsGridControl.DataSource = POSItemList;
            fld_dgcARInvoiceItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcARInvoiceItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["ARInvoiceNo"]);
            lstColVisible.Add(gridView.Columns["ARInvoiceDate"]);
            lstColVisible.Add(gridView.Columns["ACObjectName"]);
            lstColVisible.Add(gridView.Columns["ARSellerName"]);
            lstColVisible.Add(gridView.Columns["ARInvoiceItemProductNo"]);
            List<ARInvoiceItemsInfo> bindingList = new List<ARInvoiceItemsInfo>();

            for (int i = 0; i < POSItemList.Count; i++)
            {
                ARInvoiceItemsInfo obj = POSItemList[i];
                bool isExist = false;
                foreach (GridColumn column in lstColVisible)
                {
                    int rowHandle = gridView.GetRowHandle(i);
                    string value = gridView.GetRowCellDisplayText(rowHandle, column);
                    isExist = IsExistKeyWord(value, keyWord);
                    if (isExist)
                        break;
                }
                if (isExist)
                {
                    bindingList.Add(obj);
                }
            }
            fld_dgcARInvoiceItemsGridControl.DataSource = bindingList;
            fld_dgcARInvoiceItemsGridControl.RefreshDataSource();
            gridView.ExpandAllGroups();
        }

        public bool IsExistKeyWord(String value, String keyWord)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = gridControlHelper.Selection.OfType<ARInvoiceItemsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Select(o => o.ARInvoiceItemProductTaxPercent).Distinct().Count() > 1)
            {
                MessageBox.Show("Các sản phẩm được chọn phải cùng 1 mức thuế!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Select(o => o.ARInvoiceItemProductDiscount).Distinct().Count() > 1)
            {
                MessageBox.Show("Các sản phẩm được chọn phải cùng 1 mức chiết khấu!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Select(o => o.ACObjectName).Distinct().Count() > 1)
            {
                MessageBox.Show("Các sản phẩm được chọn phải cùng Đối tượng!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_txtFind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fld_txtFind.Text))
            {
                fld_txtFind.Text = "Nhập từ khóa";
            }
        }

        private void fld_txtFind_Enter(object sender, EventArgs e)
        {
            if (fld_txtFind.Text == "Nhập từ khóa")
            {
                fld_txtFind.Text = string.Empty;
            }
        }
    }
}