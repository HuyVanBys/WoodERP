using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssemblyReceipt
{
    public partial class guiChooseShipmentItem : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ICShipmentItemsInfo> SelectedObjects { get; set; }

        public List<ICShipmentItemsInfo> ShipmentItemList { get; set; }

        #endregion

        public guiChooseShipmentItem(List<ICShipmentItemsInfo> shipmentItemList)
        {
            InitializeComponent();
            ShipmentItemList = shipmentItemList;
        }

        private void guiChooseShipmentItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ICShipmentItemsInfo>();
            fld_dgcShipmentItemsGridControl.InvalidateDataSource(ShipmentItemList);
            GridView gridView = (GridView)fld_dgcShipmentItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsMenu.EnableFooterMenu = false;
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
            GridColumn gridColumn = gridView.Columns["FK_ICShipmentID"];
            if (gridColumn != null)
            {
                gridColumn.Group();
            }
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
            SelectedObjects = GridControlHelper.Selection.OfType<ICShipmentItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int count = SelectedObjects.Select(o => o.FK_ICShipmentID).Distinct().Count();
            if (count > 1)
            {
                MessageBox.Show(AssemblyReceiptLocalizedResources.MultiShipmentErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcShipmentItemsGridControl.MainView;
            gridView.ExpandAllGroups();
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
            fld_dgcShipmentItemsGridControl.DataSource = ShipmentItemList;
            fld_dgcShipmentItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcShipmentItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["FK_ICProductID"]);
            lstColVisible.Add(gridView.Columns["ICShipmentItemProductDesc"]);
            lstColVisible.Add(gridView.Columns["ICShipmentItemProductName"]);
            List<ICShipmentItemsInfo> bindingList = new List<ICShipmentItemsInfo>();

            for (int i = 0; i < ShipmentItemList.Count; i++)
            {
                ICShipmentItemsInfo obj = ShipmentItemList[i];
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
            fld_dgcShipmentItemsGridControl.DataSource = bindingList;
            fld_dgcShipmentItemsGridControl.RefreshDataSource();
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