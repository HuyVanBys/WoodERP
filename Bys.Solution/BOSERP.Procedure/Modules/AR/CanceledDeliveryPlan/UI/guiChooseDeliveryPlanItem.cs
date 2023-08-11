using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CanceledDeliveryPlan
{
    public partial class guiChooseDeliveryPlanItems : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public List<ARDeliveryPlanItemsInfo> DeliveryPlanItemList { get; set; }

        public List<ARDeliveryPlanItemsInfo> SelectedObjects { get; set; }

        public guiChooseDeliveryPlanItems(List<ARDeliveryPlanItemsInfo> deliveryPlanItemList)
        {
            InitializeComponent();
            DeliveryPlanItemList = new List<ARDeliveryPlanItemsInfo>();
            DeliveryPlanItemList = deliveryPlanItemList;
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

        private void guiChooseDeliveryPlanItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcDeliveryPlanItemsGridControl.InvalidateDataSource(DeliveryPlanItemList);
            GridView gridView = (GridView)fld_dgcDeliveryPlanItemsGridControl.MainView;
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Count = 1;
            GridView gridView = (GridView)fld_dgcDeliveryPlanItemsGridControl.MainView;
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = (ARDeliveryPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = gridControlHelper.Selection.OfType<ARDeliveryPlanItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Any(o => o.FK_ARDeliveryPlanID != SelectedObjects[0].FK_ARDeliveryPlanID))
            {
                MessageBox.Show(CanceledDeliveryPlanLocalizedResources.CheckARDeliveryPlanID, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            keyWord = fld_txtFind.Text;
            SearchData(keyWord);
        }
        public void SearchData(String keyWord)
        {
            GridView gridView = (GridView)fld_dgcDeliveryPlanItemsGridControl.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                    {
                        lstColVisible.Add(gridView.Columns[i]);
                    }
                }
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<ARDeliveryPlanItemsInfo> bindingList = new List<ARDeliveryPlanItemsInfo>();

                fld_dgcDeliveryPlanItemsGridControl.DataSource = DeliveryPlanItemList;
                fld_dgcDeliveryPlanItemsGridControl.RefreshDataSource();

                for (int i = 0; i < DeliveryPlanItemList.Count; i++)
                {
                    ARDeliveryPlanItemsInfo obj = DeliveryPlanItemList[i];
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
                fld_dgcDeliveryPlanItemsGridControl.DataSource = bindingList;
                fld_dgcDeliveryPlanItemsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcDeliveryPlanItemsGridControl.DataSource = DeliveryPlanItemList;
                fld_dgcDeliveryPlanItemsGridControl.RefreshDataSource();
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
                keyWord = fld_txtFind.Text;
                SearchData(keyWord);
            }
        }
    }
}
