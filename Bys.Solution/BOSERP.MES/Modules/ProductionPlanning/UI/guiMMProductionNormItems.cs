using BOSCommon.Constants;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.ProductionPlanning
{
    public partial class guiMMProductionNormItems : BOSERPScreen
    {
        public guiMMProductionNormItems()
        {
            InitializeComponent();
        }
        private void guiMMProductionNormItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ProductionPlanningEntities entity = (ProductionPlanningEntities)((ProductionPlanningModule)this.Module).CurrentModuleEntity;
            ARProductionPlanningsInfo mainObject = (ARProductionPlanningsInfo)entity.MainObject;
            MMProductionNormItemsController objController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> objMMProductionNormItemsList = new List<MMProductionNormItemsInfo>();
            objMMProductionNormItemsList = objController.GetMMProductionNormItemsByBatchProduct(mainObject.ARProductionPlanningID, "Hardware");

            fld_dgcMMProductionNormItems.DataSource = objMMProductionNormItemsList;
            GridView gridView = (GridView)fld_dgcMMProductionNormItems.MainView;
            gridView.BestFitColumns();

        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bosCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            List<MMProductionNormItemsInfo> objMMProductionNormItemsList = new List<MMProductionNormItemsInfo>();
            objMMProductionNormItemsList = (List<MMProductionNormItemsInfo>)fld_dgcMMProductionNormItems.DataSource;
            objMMProductionNormItemsList.ForEach(i => i.Selected = bosCheckEdit1.Checked);
            fld_dgcMMProductionNormItems.DataSource = objMMProductionNormItemsList;
            fld_dgcMMProductionNormItems.RefreshDataSource();
        }

        private void fld_BtnShowTonKho_Click(object sender, EventArgs e)
        {

            string listproduct = string.Empty;
            List<MMProductionNormItemsInfo> objMMProductionNormItemsList = (List<MMProductionNormItemsInfo>)fld_dgcMMProductionNormItems.DataSource;
            objMMProductionNormItemsList = objMMProductionNormItemsList.Where(i => i.Selected == true).ToList();
            if (objMMProductionNormItemsList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật tư", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < objMMProductionNormItemsList.Count; i++)
            {
                if (listproduct.Contains(objMMProductionNormItemsList[i].FK_ICProductID.ToString()) == false)
                {
                    listproduct += objMMProductionNormItemsList[i].FK_ICProductID.ToString();
                    if (i < objMMProductionNormItemsList.Count - 1)
                        listproduct += ",";
                }
            }
            if (listproduct[listproduct.Length - 1].ToString() == ",")
                listproduct = listproduct.Substring(0, listproduct.Length - 1);
            guiInventoryStock gui = new guiInventoryStock();
            gui.Module = this.Module;
            gui.ListProduct = listproduct;
            gui.ShowDialog();
        }

        private void fld_btnLamDeNghi_Click(object sender, EventArgs e)
        {
            ProductionPlanningEntities entity = (ProductionPlanningEntities)((ProductionPlanningModule)this.Module).CurrentModuleEntity;
            ARProductionPlanningsInfo mainObject = (ARProductionPlanningsInfo)entity.MainObject;
            List<MMProductionNormItemsInfo> objMMProductionNormItemsList = (List<MMProductionNormItemsInfo>)fld_dgcMMProductionNormItems.DataSource;
            objMMProductionNormItemsList = objMMProductionNormItemsList.Where(i => i.Selected == true).ToList();
            mainObject.FK_ARCustomerID = entity.ProductionPlanningItemList[0].FK_ARCustomerID;
            if (objMMProductionNormItemsList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật tư!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mess = string.Empty;
            List<MMProductionNormItemsInfo> listItem = new List<MMProductionNormItemsInfo>();
            foreach (MMProductionNormItemsInfo item in objMMProductionNormItemsList)
            {
                if (item.MMProductionNormItemQuantity <= 0)
                    continue;
                listItem.Add(item);
                mess += item.MMProductionNormItemProductDesc + ", số lượng: " + item.MMProductionNormItemQuantity + Environment.NewLine;
            }
            if (mess == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn số lượng đặt mua cho sản phẩm!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn muốn làm đề nghị mua hàng cho những sản phẩm này:" + Environment.NewLine + mess, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                BaseModuleERP PurchaseProposalModule = BaseModuleFactory.GetModule(ModuleName.PurchaseProposal);
                if (PurchaseProposalModule != null)
                {
                    PurchaseProposalModule = BOSApp.ShowModule(ModuleName.PurchaseProposal);
                    MethodInfo method = PurchaseProposalModule.GetMethodInfoByMethodFullNameAndMethodClass("ActionNewFromProductSpecific",
                                                                                        "Void void ActionNewFromProductSpecific()",
                                                                                        "BOSERP.Modules.AllocationProposal.AllocationProposalModule");
                    //Invoke method                                
                    method.Invoke(Module, Module.GetMethodParameterValues(method.GetParameters(), sender, "ItemClick", listItem, mainObject));
                }
                //BOSERP.Modules.PurchaseProposal.PurchaseProposalModule PurchaseProposalModule = (BOSERP.Modules.PurchaseProposal.PurchaseProposalModule)BOSApp.ShowModule(ModuleName.PurchaseProposal);
                //PurchaseProposalModule.ActionNewFromProductSpecific(listItem, mainObject);
            }
            Close();
        }


    }
}
