using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSCommon;
using BOSComponent;
using BOSReport;
using DevExpress.XtraReports.UI;
using BOSLib;
using System.Data;
using Localization;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Configuration;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using BOSERP.Modules.SaleOrder;

namespace BOSERP.Modules.DeviceConfig
{
    public class DeviceConfigModule : BaseModuleERP
    {
        public BOSLookupEdit ACDeviceIdentifierNo;
        List<ACDevicesInfo> ListACDeviceIdentifier;
        ItemLookupEdit ProductLookupEdit;
        List<ICProductsInfo> ProductList = new List<ICProductsInfo>();

        ItemLookupEdit MaterialPlanLookupEdit;

        public DeviceConfigModule()
        {
            Name = ModuleName.DeviceConfig;
            CurrentModuleEntity = new DeviceConfigEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ACDeviceIdentifierNo = (BOSLookupEdit)Controls["fld_lkeACDeviceIdentifierNo"];
            GetDatasourceACDeviceIdentifierNo();
            ACDeviceIdentifierNo.QueryPopUp += new System.ComponentModel.CancelEventHandler(ACDeviceIdentifierNo_QueryPopUp);
            ACDeviceIdentifierNo.Closed += new ClosedEventHandler(ACDeviceIdentifierNo_Closed);
            GetCurrentModuleDataViewPermission();
            ProductLookupEdit = (ItemLookupEdit)Controls["fld_lkeICProductID"];
            GetDataForProductLookupEdit();

            MaterialPlanLookupEdit = (ItemLookupEdit)Controls["fld_lkeMaterialPlan"];
            GetDataForMaterialLookupEdit();
        }

        void GetDataForMaterialLookupEdit()
        {
            if (MaterialPlanLookupEdit != null)
            {
                ICProductsController objPDController = new ICProductsController();
                List<ICProductsInfo> mList = objPDController.GetMaterialListForDeviceTemplate();
                MaterialPlanLookupEdit.Properties.DataSource = mList;
            }
        }

        void GetDataForProductLookupEdit()
        {
            ICProductsController objPDController = new ICProductsController();
            ProductList = objPDController.GetListByEquipmentAndAsset();
            ProductLookupEdit.Properties.DataSource = ProductList;
        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACDevicesInfo searchObject = (ACDevicesInfo)CurrentModuleEntity.SearchObject;
            ACDevicesController objDeviceController = new ACDevicesController();
            string listbranch=string.Empty;
            BranchList.ForEach(i=>listbranch+=i.BRBranchID.ToString()+",");
            DataSet ds = objDeviceController.GetACDevicesList(
                                                                   searchObject.ACDeviceIdentifierNo,
                                                                   listbranch,
                                                                   searchObject.FK_HREmployeeID,
                                                                   searchObject.ACDeviceName,
                                                                   searchObject.ACDeviceIdentifierType,
                                                                   searchObject.ACDeviceDateFrom,
                                                                   searchObject.ACDeviceDateTo
                                                                   );
            return ds;
        }
        void ACDeviceIdentifierNo_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ACDevicesInfo mainObject = (ACDevicesInfo)CurrentModuleEntity.MainObject;
            ACDeviceIdentifierNo.Properties.DataSource = ListACDeviceIdentifier.Where(i =>i.FK_ICProductID != 0 && i.FK_ICProductID == mainObject.FK_ICProductID ).ToList();
        }
        void ACDeviceIdentifierNo_Closed(object sender, ClosedEventArgs e)
        {
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            ACDevicesInfo mainObject = (ACDevicesInfo)entity.MainObject;
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            ACDevicesInfo objDeviceInfo = (ACDevicesInfo)lke.GetSelectedDataRow();
            if (objDeviceInfo != null)
            {
                mainObject.ACDeviceNo = objDeviceInfo.ACDeviceIdentifierNo;
                mainObject.ACDeviceName = objDeviceInfo.ACDeviceIdentifierName;
                mainObject.ACDeviceIdentifierType = objDeviceInfo.ACDeviceIdentifierType;
                mainObject.ACDeviceIdentifierNo = objDeviceInfo.ACDeviceIdentifierNo;
            }
        }

        void GetDatasourceACDeviceIdentifierNo()
        {
            ACDevicesController objDController = new ACDevicesController();
            ListACDeviceIdentifier = objDController.GetDataByTSCDCDDC(string.Empty);
            ACDeviceIdentifierNo.Properties.DataSource = ListACDeviceIdentifier;
        }

        public void RemoveSelectedItemsList()
        {
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            entity.ACDeviceItemsList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedItemPlansList()
        {
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            entity.ACDeviceItemPlansList.RemoveSelectedRowObjectFromList();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            ACDevicesInfo mainObject = (ACDevicesInfo)entity.MainObject;
            ACDeviceIdentifierNo.Properties.DataSource = ListACDeviceIdentifier.Where(i => i.ACDeviceIdentifierType == mainObject.ACDeviceIdentifierType
                                                                                        && i.ACDeviceIdentifierID==mainObject.ACDeviceIdentifierID).ToList();
            
        }
        public void AddItemToDeviceItemPlansList()
        {
           
            ICProductsController objProductsController = new ICProductsController();
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            ACDevicesInfo mainObject = (ACDevicesInfo)entity.MainObject;
            ACDeviceItemPlansInfo item = (ACDeviceItemPlansInfo)entity.ModuleObjects[TableName.ACDeviceItemPlansTableName];
            if (item.FK_ICProductID > 0)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if(objProductsInfo!=null)
                {
                    item.FK_ICMeasureUnitID=objProductsInfo.FK_ICProductBasicUnitID;
                    item.ACDeviceItemPlanProductName=objProductsInfo.ICProductDesc;
                    item.ACDeviceItemPlanProductQty = 1;
                    item.FK_ACDeviceItemID = 0;
                    entity.ACDeviceItemPlansList.AddObjectToList();
                    entity.ACDeviceItemPlansList.GridControl.RefreshDataSource();
                }
            }
        }


        public override int ActionSave()
        {
            
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            ACDevicesInfo mainObject = (ACDevicesInfo)entity.MainObject;
            if (mainObject.ACDeviceIdentifierID == 0)
            {
                MessageBox.Show("Mã định danh không được bỏ trống !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainObject.FK_HREmployeeID == 0)
            {
                MessageBox.Show("Người lập không được bỏ trống !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainObject.ACDeviceEffectDate.Date == DateTime.MaxValue.Date || mainObject.ACDeviceEffectDate.Date == DateTime.MinValue.Date)
            {
                MessageBox.Show("Ngày hiệu lực không được bỏ trống!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            entity.ACDeviceItemsList.ForEach(i => i.ACDeviceEffectDate = mainObject.ACDeviceEffectDate);
            ACDevicesController deviceController = new ACDevicesController();
            List<ACDevicesInfo> device = deviceController.GetDeviceByIdentifyNoAndTypeExceptID(mainObject.ACDeviceNo, mainObject.ACDeviceIdentifierType, mainObject.ACDeviceID);

            if (device != null && device.Any())
            {
                BOSApp.ShowMessage("Mã định danh này đã sử dụng");
                return 0;
            }
            return base.ActionSave();
        }
        public void GenerateItemAndMaterial()
        {
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            ACDevicesInfo mainObject = (ACDevicesInfo)CurrentModuleEntity.MainObject;

            entity.ACDeviceItemsList.Clear();

            ACDeviceTemplateItemsController objDTIController = new ACDeviceTemplateItemsController();
            List<ACDeviceTemplateItemsInfo> ACDeviceTemplateItemsList = objDTIController.GetListByProductID(mainObject.FK_ICProductID);
            foreach (ACDeviceTemplateItemsInfo item in ACDeviceTemplateItemsList)
            {
                ACDeviceItemsInfo objDIInfo = new ACDeviceItemsInfo();
                BOSUtil.CopyObject(item, objDIInfo);
                objDIInfo.FK_ACDeviceTemPlateItemID = item.ACDeviceTemplateItemID;
                entity.ACDeviceItemsList.Add(objDIInfo);
            }


            entity.ACDeviceItemPlansList.Clear();
            
            ACDeviceTemplateItemPlansController objDTIPCOntroller = new ACDeviceTemplateItemPlansController();
            List<ACDeviceTemplateItemPlansInfo> ACDeviceTemplateItemPlansList = objDTIPCOntroller.GetListByProductID(mainObject.FK_ICProductID);
            foreach (ACDeviceTemplateItemPlansInfo item in ACDeviceTemplateItemPlansList)
            {
                ACDeviceItemPlansInfo objDIInfo = new ACDeviceItemPlansInfo();
                BOSUtil.CopyObject(item, objDIInfo);
                objDIInfo.FK_ACDeviceTemPlateItemID = item.FK_ACDeviceTemplateItemID;
                entity.ACDeviceItemPlansList.Add(objDIInfo);
            }
            entity.ACDeviceItemsList.GridControl.RefreshDataSource();
            entity.ACDeviceItemPlansList.GridControl.RefreshDataSource();
        }

        public void ChangeProduct(int productID)
        {
            DeviceConfigEntities entity = (DeviceConfigEntities)CurrentModuleEntity;
            ACDevicesInfo mainObject = (ACDevicesInfo)CurrentModuleEntity.MainObject;

            mainObject.FK_ICProductID = productID;
            mainObject.ACDeviceIdentifierNo = string.Empty;
            mainObject.ACDeviceIdentifierID = 0;
            mainObject.ACDeviceIdentifierName = string.Empty;
            mainObject.ACDeviceIdentifierType = string.Empty;
            mainObject.ACDeviceName = string.Empty;
            entity.ACDeviceItemsList.Clear();
            entity.ACDeviceItemPlansList.Clear();

            entity.ACDeviceItemsList.GridControl.RefreshDataSource();
            entity.ACDeviceItemPlansList.GridControl.RefreshDataSource();
        }

        public void ChangeItemMaintainGroup(ACDeviceItemsInfo item)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ACMaintainGroupConfigsController mCtrl = new ACMaintainGroupConfigsController();
                ACMaintainGroupConfigsInfo maintain = (ACMaintainGroupConfigsInfo)mCtrl.GetObjectByID(item.FK_ACMaintainGroupConfigID);

                if (maintain != null)
                {
                    item.ACMaintainGroupConfigType = maintain.ACMaintainGroupConfigType;
                    item.ACDeviceItemGuaranteeNumber = (int)maintain.ACMaintainGroupConfigDayRequired;
                    item.ACDeviceItemGuaranteeDate = maintain.ACMaintainGroupConfigDayRecurringDate;
                }

            }
        }
    }
}
