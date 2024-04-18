using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.FalseConditional
{
    public partial class guiShowFalseConditionalDetail : BOSERPScreen
    {
        public MMFalseConditionalItemsInfo FalseConditionalItem { get; set; }
        public BOSList<MMFalseConditionalDetailsInfo> EditDataList { get; set; }
        public guiShowFalseConditionalDetail(IList<MMFalseConditionalDetailsInfo> details, MMFalseConditionalItemsInfo falseConditionalItem)
        {
            InitializeComponent();
            EditDataList = new BOSList<MMFalseConditionalDetailsInfo>(TableName.MMFalseConditionalDetailsTableName);
            FalseConditionalItem = falseConditionalItem;
            foreach (MMFalseConditionalDetailsInfo item in details)
            {
                MMFalseConditionalDetailsInfo objFalseConditionalDetailsInfo = new MMFalseConditionalDetailsInfo();
                BOSUtil.CopyObject(item, objFalseConditionalDetailsInfo);
                objFalseConditionalDetailsInfo.MMFalseConditionalItemInventoryQty = FalseConditionalItem.MMFalseConditionalItemInventoryWoodQty;
                EditDataList.Add(objFalseConditionalDetailsInfo);
            }
        }

        private void guiChooseSupplier_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            FalseConditionalEntities entity = (FalseConditionalEntities)((FalseConditionalModule)this.Module).CurrentModuleEntity;
            MMFalseConditionalsInfo mainObject = (MMFalseConditionalsInfo)entity.MainObject;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objQualityAtrributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(FalseConditionalItem.FK_ICProductAttributeQualityID);
            fld_txtFalseConditionalItemSerialNo.Text = FalseConditionalItem.MMFalseConditionalItemProductSerialNo;
            fld_txtMMFalseConditionalItemAttributeQuality.Text = objQualityAtrributesInfo != null ? objQualityAtrributesInfo.ICProductAttributeValue : String.Empty;
            fld_txtMMFalseConditionalItemHumidity.Text = FalseConditionalItem.MMFalseConditionalItemHumidity.ToString();
            fld_txtMMFalseConditionalItemWoodQty.Text = FalseConditionalItem.MMFalseConditionalItemWoodQty.ToString("N2");
            fld_txtMMFalseConditionalItemInventoryWoodQty.Text = FalseConditionalItem.MMFalseConditionalItemInventoryWoodQty.ToString("N2");
            fld_txtMMFalseConditionalItemProductHeight.Text = FalseConditionalItem.MMFalseConditionalItemProductHeight.ToString("N0");
            fld_txtMMFalseConditionalItemProductWidth.Text = FalseConditionalItem.MMFalseConditionalItemProductWidth.ToString("N0");
            fld_txtMMFalseConditionalItemProductLength.Text = FalseConditionalItem.MMFalseConditionalItemProductLength.ToString("N0");
            decimal totalFault = EditDataList.Sum(o => o.MMFalseConditionalDetailPercent);
            fld_txtMMFalseConditionalItemAveragePercent.Text = totalFault.ToString("N2");
            fld_txtMMFalseConditionalItemGoodPercent.Text = (100 - totalFault).ToString("N2");
            fld_txtMMFalseConditionalItemResult.Text = totalFault > mainObject.MMFalseConditionalPercentNorm ? "Loại" : "Đạt";
            fld_dgcMMFalseConditionalDetails.InvalidateDataSource(EditDataList);
            fld_dgcMMFalseConditionalDetails.RefreshDataSource();
            //Bind grid control to their list
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
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        //private void ShowData()
        //{
        //    FalseConditionalEntities entity = (FalseConditionalEntities)((FalseConditionalModule)this.Module).CurrentModuleEntity;
        //    MMFalseConditionalDetailsController objFalseConditionalDetailsController = new MMFalseConditionalDetailsController();
        //    List<MMFalseConditionalDetailsInfo> listFalseConditionalDetail = objFalseConditionalDetailsController.GetDetailByFalseConditionalItemID(FalseConditionalItem.MMFalseConditionalItemID);
        //    listFalseConditionalDetail.ForEach(o => o.MMFalseConditionalItemInventoryQty = FalseConditionalItem.MMFalseConditionalItemInventoryWoodQty);
        //    entity.FalseConditionalDetailsList.InitBOSList(entity,
        //                                                TableName.MMFalseConditionalsTableName,
        //                                                TableName.MMFalseConditionalDetailsTableName,
        //                                                BOSList<ARClearingDetailsInfo>.cstRelationNone);
        //    entity.FalseConditionalDetailsList.InitBOSListGridControl(fld_dgcMMFalseConditionalDetails);
        //    entity.FalseConditionalDetailsList.Invalidate(listFalseConditionalDetail);
        //    entity.FalseConditionalDetailsList.GridControl.RefreshDataSource();
        //}

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
