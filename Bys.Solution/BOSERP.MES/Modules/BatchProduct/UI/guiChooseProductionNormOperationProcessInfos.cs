using BOSCommon.Constants;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct.UI
{
    public partial class guiChooseProductionNormOperationProcessInfos : BOSERPScreen
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the component list of the current item
        /// </summary>
        public BOSList<MMBatchProductItemOperationInfosInfo> ProductionNormProcessInfoList { get; set; }
        public List<MMBatchProductItemOperationInfosInfo> ProductionNormProcessInfoListSelected { get; set; }

        #endregion

        public guiChooseProductionNormOperationProcessInfos(List<MMBatchProductItemOperationInfosInfo> listToPrint)
        {
            InitializeComponent();
            MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();
            ProductionNormProcessInfoList = new BOSList<MMBatchProductItemOperationInfosInfo>(TableName.MMBatchProductItemOperationInfosTableName);
            ProductionNormProcessInfoListSelected = new List<MMBatchProductItemOperationInfosInfo>();
            //validate chi tiet
            if (listToPrint != null && listToPrint.Count > 0)
            {
                foreach (MMBatchProductItemOperationInfosInfo item in listToPrint)
                {
                    ProductionNormProcessInfoList.Add(item);
                }
            }
            fld_dgcBatchProductItemOperationInfos.InvalidateDataSource(ProductionNormProcessInfoList);
        }

        private void guiChooseProductionNormOperationProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcBatchProductItemOperationInfos.InvalidateDataSource(ProductionNormProcessInfoList);
            GridView gridView = (GridView)fld_dgcBatchProductItemOperationInfos.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
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

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkSelectAll.Checked);
            fld_dgcBatchProductItemOperationInfos.RefreshDataSource();

        }
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcBatchProductItemOperationInfos.MainView;
            List<MMBatchProductItemOperationInfosInfo> listView = new List<MMBatchProductItemOperationInfosInfo>();

            List<MMBatchProductItemOperationInfosInfo> objects = new List<MMBatchProductItemOperationInfosInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductItemOperationInfosInfo objDataViewPermissionsInfo = (MMBatchProductItemOperationInfosInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMBatchProductItemOperationInfosInfo objDataViewPermissionsInfo = (MMBatchProductItemOperationInfosInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }

                }
            }
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            foreach (MMBatchProductItemOperationInfosInfo item in ProductionNormProcessInfoList)
            {
                if (item.Selected == true)
                    ProductionNormProcessInfoListSelected.Add(item);
            }


            if (ProductionNormProcessInfoListSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
