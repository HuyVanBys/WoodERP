using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiPackagingComponent : BOSERPScreen
    {
        MMProductionNormItemsInfo PackagingItem;
        public guiPackagingComponent(MMProductionNormItemsInfo packagingItem)
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
        }

        private void guiPackagingComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);


            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
            MMProductionNormsInfo pn = (MMProductionNormsInfo)entity.MainObject;

            if (pn != null)
            {
                fld_btnSave.Enabled = (pn.MMProductionNormPackingMaterialStatus != Status.Approved.ToString());
            }

            entity.PackagingNormItemList.Clear();
            foreach (MMProductionNormItemsInfo packaging in entity.ProductionNormItemPackagingList)
            {
                if (packaging.MMProductionNormItemID != PackagingItem.MMProductionNormItemID)
                {
                    MMProductionNormItemsInfo addP = (MMProductionNormItemsInfo)packaging.Clone();
                    if (addP.FK_MMProductionNormItemRefID == PackagingItem.MMProductionNormItemID)
                    {
                        addP.Selected = true;
                    }
                    entity.PackagingNormItemList.Add(addP);
                }
            }

            entity.PackagingNormItemList.InitBOSListGridControl(fld_dgcICPackagingNormItems);
            fld_dgcICPackagingNormItems.DataSource = entity.PackagingNormItemList;
            fld_dgcICPackagingNormItems?.RefreshDataSource();


            List<MMProductionNormItemsInfo> productionNormPackagingList = new List<MMProductionNormItemsInfo>();
            productionNormPackagingList.Add(PackagingItem);

            fld_dgcMMProductionNormItemsPackaging.DataSource = productionNormPackagingList;
            BestFitColumn(fld_dgcMMProductionNormItemsPackaging);
            BestFitColumn(fld_dgcICPackagingNormItems);
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

            ((CarcassBOMModule)Module).SavePackingComponentInfo(PackagingItem);

            BOSApp.ShowMessage("Lưu thành công");
        }



    }
}
