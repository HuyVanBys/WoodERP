using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiPacking : BOSERPScreen
    {
        MMProductionNormItemsInfo PackagingItem;

        public guiPacking(MMProductionNormItemsInfo packagingItem)
        {
            InitializeComponent();
            PackagingItem = packagingItem;
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
            if (((CarcassBOMModule)Module).PackageList == null) ((CarcassBOMModule)Module).PackageList = new List<ICProductPackagesInfo>();
            if (PackagingItem == null)
            {
                fld_bolNormPackage.Visible = false;
                fld_pnlPackageInfo.Visible = false;
                fld_pnlPackageDetail.Location = new Point(fld_pnlPackageDetail.Location.X, fld_pnlPackageInfo.Location.Y);
                fld_pnlPackageDetail.Dock = DockStyle.Fill;
                PackagingItem = new MMProductionNormItemsInfo();
            }
        }

        private void guiPacking_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
            MMProductionNormsInfo pn = (MMProductionNormsInfo)entity.MainObject;

            if (pn != null)
            {
                fld_btnSave.Enabled = (pn.MMProductionNormPackingMaterialStatus != Status.Approved.ToString());
            }

            entity.ProductionNormItemPackingList.Clear();
            entity.ProductionNormItemPackingList.InitBOSListGridControl(fld_dgcMMProductionNormItemPackings);

            int carcassPNID = ((CarcassBOMModule)Module).GetCarcassProductionNormID();
            MMProductionNormItemPackingsController packingCtrl = new MMProductionNormItemPackingsController();
            List<MMProductionNormItemPackingsInfo> packingList = packingCtrl.GetForDefinePacking(PackagingItem.MMProductionNormItemID
                                                                                                 , carcassPNID
                                                                                                 , PackagingItem.FK_MMProductionNormID);

            entity.ProductionNormItemPackingList.AddRange(packingList);
            entity.ProductionNormItemPackingList.GridControl?.RefreshDataSource();

            List<MMProductionNormItemsInfo> productionNormPackagingList = new List<MMProductionNormItemsInfo>();
            productionNormPackagingList.Add(PackagingItem);

            fld_dgcMMProductionNormItemsPackaging.DataSource = productionNormPackagingList;
            BestFitColumn(fld_dgcMMProductionNormItemsPackaging);
            BestFitColumn(fld_dgcMMProductionNormItemPackings);
            fld_dgcICProductPackages.InvalidateDataSource(((CarcassBOMModule)Module).PackageList);
            fld_dgcICProductPackages?.RefreshDataSource();
        }

        private void BestFitColumn(BOSGridControl gridcontrol)
        {
            GridView view = (GridView)gridcontrol.MainView;
            if (view != null)
            {
                view.BestFitColumns();
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
            ICProductPackagesInfo package = new ICProductPackagesInfo();
            ICProductPackagesController pacCtrl = new ICProductPackagesController();
            List<string> packageID = entity.ProductionNormItemPackingList.Where(o => o.FK_ICProductPackageID > 0).Select(o => o.FK_ICProductPackageID.ToString()).ToList();
            ((CarcassBOMModule)Module).SavePackingInfo(package);
            if (packageID != null && packageID.Count > 0)
                (new ICProductPackagesController()).SaveDetailByPackageNormItem(string.Join(",", packageID.ToArray()), BOSApp.CurrentUsersInfo.ADUserName);

            ((CarcassBOMModule)Module).PackageList.ForEach(o =>
            {
                if (o.ICProductPackageID > 0) pacCtrl.UpdateObject(o);
                else pacCtrl.CreateObject(o);
            });

            BOSApp.ShowMessage("Lưu thành công");
        }

    }
}
