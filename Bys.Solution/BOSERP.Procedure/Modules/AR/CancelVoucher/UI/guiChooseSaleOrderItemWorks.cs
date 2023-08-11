using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelVoucher
{
    public partial class guiChooseSaleOrderItemWorks : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public List<ARSaleOrderItemWorksInfo> SaleOrderItemWorkList { get; set; }

        public List<ARSaleOrderItemWorksInfo> SelectedObjects { get; set; }

        public guiChooseSaleOrderItemWorks(List<ARSaleOrderItemWorksInfo> saleOrderItemWorkList)
        {
            InitializeComponent();
            SaleOrderItemWorkList = saleOrderItemWorkList;
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

        private void guiChooseSaleOrderItemWorks_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcSaleOrderItemWorksGridControl.InvalidateDataSource(SaleOrderItemWorkList);
            GridView gridView = (GridView)fld_dgcSaleOrderItemWorksGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = gridControlHelper.Selection.OfType<ARSaleOrderItemWorksInfo>().ToList();
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
            String keyWord = String.Empty;
            //if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
            keyWord = fld_txtFind.Text;
            SearchData(keyWord);
        }

        private void SearchData(String keyWord)
        {
            fld_dgcSaleOrderItemWorksGridControl.DataSource = SaleOrderItemWorkList;
            fld_dgcSaleOrderItemWorksGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcSaleOrderItemWorksGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemWorkProductName"]);
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemWorkProductNo"]);
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemWorkProductDesc"]);
            List<ARSaleOrderItemWorksInfo> bindingList = new List<ARSaleOrderItemWorksInfo>();

            for (int i = 0; i < SaleOrderItemWorkList.Count; i++)
            {
                ARSaleOrderItemWorksInfo obj = SaleOrderItemWorkList[i];
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
            fld_dgcSaleOrderItemWorksGridControl.DataSource = bindingList;
            fld_dgcSaleOrderItemWorksGridControl.RefreshDataSource();
            gridView.ExpandAllGroups();
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
