using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSCommon;
using Localization;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using BOSComponent;

namespace BOSERP.Modules.ProductionNorm.UI
{
    public partial class guiNormTemplateItemInfos : BOSERPScreen
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the component list of the current item
        /// </summary>
        public BOSList<MMNormTemplateItemsInfo> NormTemplateItemList { get; set; }
        public BOSList<MMNormTemplateItemsInfo> RemoteNormTemplateItemList { get; set; }
        public List<MMProductionNormItemOperationsInfo> ItemOperationList { get; set; }
        public MMProductionNormItemOperationsInfo ProductionNormItemOperationsInfo { get; set; }
        public int FK_ICProductID { get; set; }
        public int IsError { get; set; }
        #endregion

        public guiNormTemplateItemInfos()
        {
            InitializeComponent();
        }

        private void guiNormTemplateItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            entity.NormTemplateItemList.GridControl = fld_dgcNormTemplateItems;
            entity.NormTemplateItemGroupList.GridControl = fld_dgcMMNormTemplateItemGroups;
            entity.NormTemplateItemSemiProductList.GridControl = fld_dgcMMNormTemplateItemSemiProducts;
            fld_btnSaveTemplate.Enabled = false;
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
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(MESLocalizedResources.SaveErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.Cancel;
            Close();
        }

        

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (fld_lkeTempICProductID.EditValue == null) return; 
                ((ProductionNormModule)Module).InsertNormItemWoods(int.Parse(fld_lkeTempICProductID.EditValue.ToString()));
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MESLocalizedResources.SaveErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveNormTemplateItem(int index)
        {
            MMNormTemplateItemsInfo objNormTemplateItemsInfo = new MMNormTemplateItemsInfo();
            objNormTemplateItemsInfo = NormTemplateItemList[index];
            RemoteNormTemplateItemList.Add(objNormTemplateItemsInfo);
            NormTemplateItemList.RemoveAt(index);
            fld_dgcNormTemplateItems.RefreshDataSource();
        }
        private void fld_lkeTempICProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
             bool result = ((ProductionNormModule)Module).ChangeTempProduct(int.Parse(e.Value.ToString()));
             if (result)
             {
                 FK_ICProductID = int.Parse(e.Value.ToString());
                 GridView gridView = fld_dgcNormTemplateItems.MainView as GridView;
                 ((ProductionNormModule)Module).GeneralSourceData(gridView);

                 GridView gridViewGroup = fld_dgcMMNormTemplateItemGroups.MainView as GridView;
                 ((ProductionNormModule)Module).GeneralSourceGroupData(gridViewGroup);

                 GridView gridViewSemi = fld_dgcMMNormTemplateItemSemiProducts.MainView as GridView;
                 ((ProductionNormModule)Module).GeneralSourceSemiProductData(gridViewSemi);
                 fld_btnImportExcel.Enabled = false;
             }
             else
                 fld_btnImportExcel.Enabled = true;
            }
        }

        private void fld_btnAddToTemplate_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).AddGroupToNormTemplateItem(null);
        }

        private void fld_btnViewAll_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).ChangeSourceSemiProductByGroup(null);
        }

        private void fld_btnChooseAll_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).ChooseAllTemplate();
        }

        private void fld_btnImportExcel_Click(object sender, EventArgs e)
        {
          bool result = ((ProductionNormModule)Module).ImportTemplate();
          if (result)
          {
              ((ProductionNormModule)Module).ChangeTempProduct(0);
              GridView gridView = fld_dgcNormTemplateItems.MainView as GridView;
              ((ProductionNormModule)Module).GeneralSourceData(gridView);

              GridView gridViewGroup = fld_dgcNormTemplateItems.MainView as GridView;
              ((ProductionNormModule)Module).GeneralSourceGroupData(gridViewGroup);

              GridView gridViewSemi = fld_dgcNormTemplateItems.MainView as GridView;
              ((ProductionNormModule)Module).GeneralSourceSemiProductData(gridViewSemi);
              fld_btnSaveTemplate.Enabled = true;
          }
        }

        private void fld_btnSaveTemplate_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(fld_lkeTempICProductID.EditValue.ToString());

            bool result = ((ProductionNormModule)Module).SaveTemplate(productID);
            if (result) fld_btnSaveTemplate.Enabled = false;
        }

        private void fld_btnTemplate_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).GetTemplateExcel();
        }
    }
}
