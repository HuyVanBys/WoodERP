using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Acceptance
{
    public partial class guiChooseShipmentItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<ICShipmentItemsInfo> SelectedObjects { get; set; }

        private BOSList<ICShipmentItemsInfo> ShipmentItemList { get; set; }

        private int Count = 0;

        #endregion

        public guiChooseShipmentItems(List<ICShipmentItemsInfo> shipmentItemList)
        {
            InitializeComponent();
            ShipmentItemList = new BOSList<ICShipmentItemsInfo>(TableName.MMAllocationPlanItemsTableName);
            ShipmentItemList.Invalidate(shipmentItemList);
        }

        private void guiChooseShipmentItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcReceiptsGridControl.InvalidateDataSource(ShipmentItemList);
            SelectedObjects = new List<ICShipmentItemsInfo>();
            GridView gridView = (GridView)fld_dgcReceiptsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<ICShipmentItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Count = SelectedObjects.Select(o => o.FK_ARSaleOrderID).Distinct().Count();
            if (Count > 1)
            {
                MessageBox.Show(AcceptanceLocalizedResources.AcceptancelsHaveNotSameCustomerMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, ShipmentItemList);
        }

        public void SearchData(String keyWord, List<ICShipmentItemsInfo> shipmentItemList)
        {
            GridView gridView = (GridView)fld_dgcReceiptsGridControl.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                lstColVisible.Add(gridView.Columns["FK_ICProductID"]);
                lstColVisible.Add(gridView.Columns["FK_ICDepartmentID"]);
                lstColVisible.Add(gridView.Columns["FK_ICProductGroupID"]);
                lstColVisible.Add(gridView.Columns["FK_ARSaleOrderID"]);
                lstColVisible.Add(gridView.Columns["ICShipmentItemProductDesc"]);
                lstColVisible.Add(gridView.Columns["ICShipmentItemProductName"]);

                BOSDbUtil dbUtil = new BOSDbUtil();
                List<ICShipmentItemsInfo> bindingList = new List<ICShipmentItemsInfo>();

                fld_dgcReceiptsGridControl.DataSource = shipmentItemList;
                fld_dgcReceiptsGridControl.RefreshDataSource();

                for (int i = 0; i < ShipmentItemList.Count; i++)
                {
                    ICShipmentItemsInfo obj = shipmentItemList[i];
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
                fld_dgcReceiptsGridControl.DataSource = bindingList;
                fld_dgcReceiptsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcReceiptsGridControl.DataSource = ShipmentItemList;
                fld_dgcReceiptsGridControl.RefreshDataSource();
            }
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

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String keyWord = String.Empty;
                if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                    keyWord = fld_txtFind.Text;
                SearchData(keyWord, ShipmentItemList);
            }
        }
    }
}
