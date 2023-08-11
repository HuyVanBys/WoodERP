using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiAddSaleOrderPaymentTimes<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<ARSaleOrderPaymentTimesInfo> CollectionList { get; set; }

        public IList<ARSaleOrderPaymentTimesInfo> SelectedObjects { get; set; }

        #endregion

        public guiAddSaleOrderPaymentTimes(List<ARSaleOrderPaymentTimesInfo> saleOrderPaymentTimes)
        {
            InitializeComponent();
            CollectionList = new BOSList<ARSaleOrderPaymentTimesInfo>(TableName.ARSaleOrderPaymentTimesTableName);
            CollectionList.Invalidate(saleOrderPaymentTimes);
        }

        private void guiAddSaleOrderPaymentTimes_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcSaleOrderPaymentTimes.InvalidateDataSource(CollectionList);
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
            SelectedObjects = CollectionList.Where(s => s.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SearchData(String keyWord)
        {
            fld_dgcSaleOrderPaymentTimes.DataSource = CollectionList;
            fld_dgcSaleOrderPaymentTimes.RefreshDataSource();

            if (string.IsNullOrEmpty(keyWord))
                return;

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcSaleOrderPaymentTimes.MainView;

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["ARPaymentMethodCombo"]);

            List<ARSaleOrderPaymentTimesInfo> bindingList = new List<ARSaleOrderPaymentTimesInfo>();

            for (int i = 0; i < CollectionList.Count; i++)
            {
                ARSaleOrderPaymentTimesInfo obj = CollectionList[i];
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
            fld_dgcSaleOrderPaymentTimes.DataSource = bindingList;
            fld_dgcSaleOrderPaymentTimes.RefreshDataSource();
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