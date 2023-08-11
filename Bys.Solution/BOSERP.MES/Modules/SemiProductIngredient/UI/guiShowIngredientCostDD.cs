using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductIngredient
{
    public partial class guiShowIngredientCostDD : BOSERPScreen
    {
        public List<MMSemiProductIngredientItemsInfo> ListSeries = new List<MMSemiProductIngredientItemsInfo>();
        public List<MMSemiProductIngredientItemsInfo> itemList = new List<MMSemiProductIngredientItemsInfo>();

        public int batchProduct = 0, operation = 0;
        public DateTime dateTime;
        public guiShowIngredientCostDD()
        {
            InitializeComponent();
        }

        public guiShowIngredientCostDD(int batchProductID, int operationID, DateTime dateTime)
        {
            InitializeComponent();
            this.batchProduct = batchProductID;
            this.operation = operationID;
            this.dateTime = dateTime;

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

        private void guiShowIngredientCostDD_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            //fld_dteICShipmentDate.DateTime = dateTime;
            //fld_dteICShipmentDate.EditValue = dateTime;
            //fld_dteICShipmentDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            //fld_dteICShipmentDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            //fld_dteICShipmentDate.Properties.EditFormat.FormatString = "MM/yyyy";
            //fld_dteICShipmentDate.Properties.EditMask = "MM/yyyy";
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> objOperationsList = objOperationsController.GetOperationListForProductionCost();
            fld_lkeFK_MMOperationID1.Properties.DataSource = objOperationsList;

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductList = objBatchProductsController.GetAllObject();
            fld_lkeMMBatchProductID1.Properties.DataSource = batchProductList;

            fld_dgcMMSemiProductIngredientItems1.DataSource = ListSeries;
            fld_dteMonth.DateTime = dateTime;
            fld_dteMonth.EditValue = dateTime;
            fld_dteMonth.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            fld_dteMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            fld_dteMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            fld_dteMonth.Properties.EditMask = "MM/yyyy";
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            if (fld_lkeMMBatchProductID1.EditValue != null)
            {
                int.TryParse(fld_lkeMMBatchProductID1.EditValue.ToString(), out batchProduct);
            }
            MMSemiProductIngredientItemsController objSemiProductIngredientItemsController = new MMSemiProductIngredientItemsController();
            if (fld_lkeFK_MMOperationID1.EditValue != null)
            {
                int.TryParse(fld_lkeFK_MMOperationID1.EditValue.ToString(), out operation);
            }
            dateTime = fld_dteMonth.DateTime;
            switch (operation)
            {
                case 3:
                    ListSeries = objSemiProductIngredientItemsController.GetDDPhoiForShipment(batchProduct, operation, dateTime);
                    break;
                case 4:
                    ListSeries = objSemiProductIngredientItemsController.GetDDSCForShipment(batchProduct, operation, dateTime);
                    break;
                case 5:
                    ListSeries = objSemiProductIngredientItemsController.GetDDTCForShipment(batchProduct, operation, dateTime);
                    break;
                case 84:
                    ListSeries = objSemiProductIngredientItemsController.GetDDLRForShipment(batchProduct, operation, dateTime);
                    break;
                case 6:
                    ListSeries = objSemiProductIngredientItemsController.GetDDSonForShipment(batchProduct, operation, dateTime);
                    break;
                case 7:
                    ListSeries = objSemiProductIngredientItemsController.GetDDDGForShipment(batchProduct, operation, dateTime);
                    break;
                default:
                    ListSeries = new List<MMSemiProductIngredientItemsInfo>();
                    break;
            }
            fld_dgcMMSemiProductIngredientItems1.DataSource = ListSeries;
            fld_dgcMMSemiProductIngredientItems1.RefreshDataSource();
            //GridView gridView = (GridView)fld_dgcMMSemiProductIngredientItems.MainView;
            //gridView.BestFitColumns();

        }

        private void fld_btnChosse_Click(object sender, EventArgs e)
        {
            if (ListSeries.Count > 0)
            {
                foreach (MMSemiProductIngredientItemsInfo item in ListSeries)
                {
                    if (item.Selected == true)
                    {
                        itemList.Add(item);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkSelectAll.Checked);
            fld_dgcMMSemiProductIngredientItems1.RefreshDataSource();
        }
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcMMSemiProductIngredientItems1.MainView;
            List<MMSemiProductIngredientItemsInfo> listView = new List<MMSemiProductIngredientItemsInfo>();
            List<MMSemiProductIngredientItemsInfo> objects = (List<MMSemiProductIngredientItemsInfo>)fld_dgcMMSemiProductIngredientItems1.DataSource;
            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMSemiProductIngredientItemsInfo objDataViewPermissionsInfo = (MMSemiProductIngredientItemsInfo)gridView.GetRow(j);
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

        private void fld_dteICShipmentDate_CloseUp(object sender, CloseUpEventArgs e)
        {
            fld_dteMonth.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            fld_dteMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            fld_dteMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            fld_dteMonth.Properties.EditMask = "MM/yyyy";
        }
    }
}
