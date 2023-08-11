using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.PrintRouting.UI
{
    /// <summary>
    /// Summary description for SMNTS100
    /// </summary>
    public partial class DMPRT100 : BOSERPScreen
    {

        public DMPRT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_btnLuu_Click(object sender, EventArgs e)
        {
            ((PrintRoutingModule)Module).SaveItemList();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            //((PrintRoutingModule)Module).objProductInfo.ICProductQuality = soluong;
            ((PrintRoutingModule)Module).SeachData();
            fld_chkChecked.Checked = false;
        }

        private void fld_btnPRint_Click(object sender, EventArgs e)
        {
            ((PrintRoutingModule)Module).PrintRouting();
        }

        private void fld_lkeFK_MMBatchProductID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            ((PrintRoutingModule)Module).BatchProductID = Convert.ToInt32(lke.EditValue);
        }

        private void fld_lkeFK_MMOperationID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            ((PrintRoutingModule)Module).OperationID = Convert.ToInt32(lke.EditValue);
        }

        private void fld_chkChecked_CheckedChanged(object sender, EventArgs e)
        {
            //PrintRoutingEntities entity = (PrintRoutingEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            //entity.PrintRoutingList.ForEach(i => i.Selected = fld_chkChecked.Checked);
            //entity.PrintRoutingList.GridControl.RefreshDataSource();
            //((PrintRoutingModule)Module).CheckedAllByFilterCondition(fld_chkChecked.Checked, fld_dgcMMPrintRoutings);
            GridView gridView = (GridView)fld_dgcMMPrintRoutings.MainView;
            List<MMPrintRoutingsInfo> listView = new List<MMPrintRoutingsInfo>();

            List<MMPrintRoutingsInfo> objects = new List<MMPrintRoutingsInfo>();
            //(List<MMPrintRoutingsInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMPrintRoutingsInfo objDataViewPermissionsInfo = (MMPrintRoutingsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMPrintRoutingsInfo objDataViewPermissionsInfo = (MMPrintRoutingsInfo)gridView.GetRow(j);
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
                            objects[i].Selected = fld_chkChecked.Checked;
                        }
                    }

                }
            }
            fld_dgcMMPrintRoutings?.RefreshDataSource();
        }

        private void fld_cbbType_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (fld_cbbType.EditValue != null)
                ((PrintRoutingModule)Module).TypeFilter = fld_cbbType.EditValue.ToString();
        }

        private void fld_lkeProductCarcass_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductsController obj = new ICProductsController();
            List<ICProductsInfo> fillterList = obj.GetListProductAndCarcassByBatchProductID(Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue));
            fillterList.Insert(0, new ICProductsInfo());
            fld_lkeProductCarcass.Properties.DataSource = fillterList;
        }

        private void fld_lkeProductCarcass_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            int productID = Convert.ToInt32(fld_lkeProductCarcass.EditValue);
            // ((PrintRoutingModule)Module).ProductCarcassID = productID;
            List<ICProductsInfo> fillterList = (List<ICProductsInfo>)fld_lkeProductCarcass.Properties.DataSource;
            ((PrintRoutingModule)Module).objProductInfo = fillterList.Where(i => i.ICProductID == productID).FirstOrDefault();
            if (((PrintRoutingModule)Module).objProductInfo != null)
                fld_txtSoluong.Text = ((PrintRoutingModule)Module).objProductInfo.ICProductQuality.ToString("n2");

        }

        private void fld_txtUpdateQuanlity_Click(object sender, EventArgs e)
        {
            decimal soluong = 0;
            decimal soluongSP = 0;
            decimal.TryParse(fld_txtSoluong.Text, out soluong);
            if (((PrintRoutingModule)Module).objProductInfo.ICProductQuality != null)
                soluongSP = ((PrintRoutingModule)Module).objProductInfo.ICProductQuality;
            if (soluong > soluongSP)
            {
                MessageBox.Show("Số lượng không được lớn hơn số lượng hiện có của thành phẩm/ carcass: " + soluongSP.ToString("n0")
                    + ((PrintRoutingModule)Module).objProductInfo.ICProductQuality.ToString("n2"), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ((PrintRoutingModule)Module).UpdateQualityForItems(soluong);
        }


    }
}
