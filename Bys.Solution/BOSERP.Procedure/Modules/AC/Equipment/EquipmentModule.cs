using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Equipment
{
    public class EquipmentModule : BaseModuleERP
    {
        public const string ProductGroupsButtonEditName = "fld_bedFK_ICProductGroupID";
        private BOSButtonEdit ProductGroupsButtonEdit;

        public EquipmentModule()
        {
            Name = ModuleName.Equipment;
            CurrentModuleEntity = new EquipmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductGroupsButtonEdit = (BOSButtonEdit)Controls[EquipmentModule.ProductGroupsButtonEditName];
        }


        void ProductSerieLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductSeriesInfo> productSerieList = objProductSeriesController.GetProductSerieByProductID(objProductsInfo.ICProductID);

            lookup.Properties.DataSource = productSerieList;
        }


        public override void ActionDuplicate()
        {
            base.ActionDuplicate();

            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            entity.ProductIdentifiedEquipmentList.Clear();
            entity.ProductIdentifiedEquipmentList.GridControl.RefreshDataSource();
        }

        public void DeleteItemFromIdentifiedList()
        {
            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            bool isValid = true;
            ICProductIdentifiedEquipmentsInfo item = entity.ProductIdentifiedEquipmentList[entity.ProductIdentifiedEquipmentList.CurrentIndex];
            if (item != null)
            {
                ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                List<ICShipmentItemsInfo> objShipmentItemList = objShipmentItemsController.GetItemByProductIdentifiedEquipmentID(item.ICProductIdentifiedEquipmentID);
                if (objShipmentItemList != null && objShipmentItemList.Count > 0)
                {
                    isValid = false;
                }
                if (isValid)
                {
                    ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
                    List<ACEquipmentTransferItemsInfo> objTransferList = objEquipmentTransferItemsController.GetItemByProductIdentifiedEquipmentID(item.ICProductIdentifiedEquipmentID);
                    if (objTransferList != null && objTransferList.Count > 0)
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    entity.ProductIdentifiedEquipmentList.RemoveSelectedRowObjectFromList();
                }
                else
                {
                    MessageBox.Show("Mã định danh đang được sử dụng. Không thể xóa!", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool CheckValidIdentifiedNo(string no, int focusIndex)
        {
            bool isValid = true;
            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            for (int i = 0; i < entity.ProductIdentifiedEquipmentList.Count; i++)
            {
                if (i != focusIndex)
                {
                    if (no == entity.ProductIdentifiedEquipmentList[i].ICProductIdentifiedEquipmentNo)
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (isValid)
            {
                if (focusIndex < 0)
                {
                    ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
                    ICProductIdentifiedEquipmentsInfo objPIEsInfo = (ICProductIdentifiedEquipmentsInfo)objProductIdentifiedEquipmentsController.GetObjectByNo(no);
                    if (objPIEsInfo != null)
                    {

                        isValid = false;


                    }
                }
                else
                {
                    ICProductIdentifiedEquipmentsInfo objProductIdentifiedEquipmentsInfo = (ICProductIdentifiedEquipmentsInfo)entity.ProductIdentifiedEquipmentList[focusIndex];
                    if (objProductIdentifiedEquipmentsInfo != null)
                    {
                        ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
                        ICProductIdentifiedEquipmentsInfo objPIEsInfo = (ICProductIdentifiedEquipmentsInfo)objProductIdentifiedEquipmentsController.GetObjectByNo(no);
                        if (objPIEsInfo != null)
                        {
                            if (objPIEsInfo.ICProductIdentifiedEquipmentID != objProductIdentifiedEquipmentsInfo.ICProductIdentifiedEquipmentID)
                            {
                                isValid = false;

                            }
                        }
                    }
                }
            }
            if (!isValid)
            {
                MessageBox.Show("Mã định danh " + no + " đã tồn tại", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isValid;
        }
        public void ShowCategoryTree()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(objProductsInfo.FK_ICDepartmentID, objProductsInfo.FK_ICProductGroupID);
            guiProductGroupTree.Module = this;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    objProductsInfo.FK_ICDepartmentID = guiProductGroupTree.ICDepartmentID;
                    objProductsInfo.FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    objProductsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;
                    objProductsInfo.ICProductGroupName = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    objProductsInfo.FK_ICProductGroupID = 0;
                    objProductsInfo.ICProductGroupName = string.Empty;
                }
                entity.UpdateMainObjectBindingSource();
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            if (objProductsInfo.FK_ICProductGroupID != 0)
            {
                objProductsInfo.ICProductGroupName = objProductGroupsController.GetObjectNameByID(objProductsInfo.FK_ICProductGroupID);
                ProductGroupsButtonEdit.Text = objProductsInfo.ICProductGroupName;
            }
        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo searchObject = (ICProductsInfo)CurrentModuleEntity.SearchObject;


            DataSet ds;

            ds = objProductsController.GetProductListByDepreciationMonthAndIdentifiedEquipments(
                                                                        searchObject.MaDinhDanh,
                                                                        searchObject.ICProductNo,
                                                                        searchObject.ICProductName
                                                                       );


            return ds;
        }
        public void ShowIndentifyMenu()
        {
            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            guiShowIdentifyMenu guiShowIdentifyMenu = new guiShowIdentifyMenu();
            guiShowIdentifyMenu.Module = this;
            guiShowIdentifyMenu.Show();
        }

        public override int ActionSave()
        {
            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            if (objProductsInfo.FK_ACEquipmentTypeAccountConfigID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn nhóm tài khoản!");
                return 0;
            }
            if (objProductsInfo.ICProductDepreciationMonths <= 0)
            {
                BOSApp.ShowMessage("Vui lòng nhập số tháng phân bổ!");
                return 0;
            }
            else
            {
                ACEquipmentTypeAccountConfigsController objemControler = new ACEquipmentTypeAccountConfigsController();
                ACEquipmentTypeAccountConfigsInfo objEquipmentTypeAccountConfigsInfo = (ACEquipmentTypeAccountConfigsInfo)objemControler.GetObjectByID(objProductsInfo.FK_ACEquipmentTypeAccountConfigID);
                if (objEquipmentTypeAccountConfigsInfo != null)
                {
                    if ((objProductsInfo.ICProductDepreciationMonths > objEquipmentTypeAccountConfigsInfo.ACEquipmentTypeAccountConfigAllocationMonthMax && objEquipmentTypeAccountConfigsInfo.ACEquipmentTypeAccountConfigAllocationMonthMax > 0)
                       || objProductsInfo.ICProductDepreciationMonths < objEquipmentTypeAccountConfigsInfo.ACEquipmentTypeAccountConfigAllocationMonthMin)
                    {
                       if( BOSApp.ShowMessageYesNo(string.Format("Số tháng phân bổ không thuộc khoảng cho phép MIN: {0}, MAX: {1} , bạn có chắc chắn không?"
                           , objEquipmentTypeAccountConfigsInfo.ACEquipmentTypeAccountConfigAllocationMonthMin
                           , objEquipmentTypeAccountConfigsInfo.ACEquipmentTypeAccountConfigAllocationMonthMax)) == DialogResult.No)
                            return 0;
                    }

                }
            }
            int id = base.ActionSave();
            if (!BOSApp.CurrentProductList.Any(o => o.ICProductID == objProductsInfo.ICProductID))
            {
                ICProductsForViewInfo newObj = new ICProductsForViewInfo();
                BOSUtil.CopyViewObject(objProductsInfo, newObj);
                BOSApp.CurrentProductList.Add(newObj);
            }

            return id;
        }
        public void ChangeEquipmentTypeAccountConfig(int configID)
        {
            EquipmentEntities entity = (EquipmentEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ACEquipmentTypeAccountConfigsController objemControler = new ACEquipmentTypeAccountConfigsController();
            ACEquipmentTypeAccountConfigsInfo objEquipmentTypeAccountConfigsInfo = (ACEquipmentTypeAccountConfigsInfo)objemControler.GetObjectByID(configID);
            if (objEquipmentTypeAccountConfigsInfo != null)
            {
                objProductsInfo.FK_ACAccountID = objEquipmentTypeAccountConfigsInfo.FK_ACAccountID;
                objProductsInfo.FK_ACDepreciationAccountID = objEquipmentTypeAccountConfigsInfo.FK_ACDepreciationAccountID;
                objProductsInfo.FK_ACDepreciationCostAccountID = objEquipmentTypeAccountConfigsInfo.FK_ACDepreciationCostAccountID;
                objProductsInfo.ICProductDepreciationMonths = objEquipmentTypeAccountConfigsInfo.ACEquipmentTypeAccountConfigAllocationMonthMin;
            }
            entity.UpdateMainObjectBindingSource();
        }
    }
}
