using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Asset
{
    public class AssetModule : BaseModuleERP
    {
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string ProductGroupsButtonEditName = "fld_bedFK_ICProductGroupID";



        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        private BOSButtonEdit ProductGroupsButtonEdit;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        private BOSLookupEdit ACUnfinishedConstructionCost;
        public AssetModule()
        {
            Name = ModuleName.Asset;
            CurrentModuleEntity = new AssetEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            ProductGroupsButtonEdit = (BOSButtonEdit)Controls[AssetModule.ProductGroupsButtonEditName];
            ACUnfinishedConstructionCost = (BOSLookupEdit)Controls["fld_lkeFK_ACUnfinishedConstructionCostID"];
            ACUnfinishedConstructionCost.QueryPopUp += new System.ComponentModel.CancelEventHandler(ACUnfinishedConstructionCost_QueryPopUp);
        }

        void ACUnfinishedConstructionCost_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ACUnfinishedConstructionCostsController objAssetsController = new ACUnfinishedConstructionCostsController();
            List<ACUnfinishedConstructionCostsInfo> objAssetsInfoList = objAssetsController.GetDataForLookupEditControl();
            if (objAssetsInfoList != null && objAssetsInfoList.Count > 0)
            {
                ACUnfinishedConstructionCost.Properties.DataSource = objAssetsInfoList;
            }
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            bool reset = false;
            if (!string.IsNullOrEmpty(searchQuery)) reset = true;
            base.GetSearchData(ref searchQuery);
            if (reset || (SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null &&
                (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")))
            {
                if (BranchList.Count == 0)
                {
                    searchQuery += string.Format(" and FK_BRBranchID = -1");
                }
                else
                {
                    string str = "";
                    foreach (var item in BranchList)
                    {
                        str += "," + item.BRBranchID.ToString();
                    }
                    searchQuery += string.Format(" and FK_BRBranchID in ({0})", str.Substring(1));
                }
            }
            else if (SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null)
            {
                searchQuery += string.Format(" and FK_BRBranchID = {0}", SearchBranchLookupEditControl.EditValue.ToString());
            }
            string mainObjectControllerName = BOSUtil.GetBusinessControllerNameFromBusinessObject(CurrentModuleEntity.MainObject);
            IBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(mainObjectControllerName);
            DataSet ds = objCurrentObjectController.GetDataSet(searchQuery);
            return ds;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        /// <summary>
        /// Called when the user changes the number of expiry months
        /// </summary>
        public void ChangeExpiryMonths()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ACAssetsInfo objAssetsInfo = (ACAssetsInfo)CurrentModuleEntity.MainObject;
                if (objAssetsInfo.ACAssetExpiryMonths > 0)
                {
                    objAssetsInfo.ACAssetDepreciationAmount = objAssetsInfo.ACAssetOriginalAmount / objAssetsInfo.ACAssetExpiryMonths;
                    //TNDLoc [ADD][27/09/2016][Round by currency],START
                    //GECurrenciesController currenciesController = new GECurrenciesController();
                    //GECurrenciesInfo vnCurrency = (GECurrenciesInfo)currenciesController.GetObjectByNo(CurrencyNo.VND.ToString());
                    //if (vnCurrency != null)
                    {
                        BOSApp.RoundByCurrency(objAssetsInfo, "ACAssetDepreciationAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    }
                    //TNDLoc [ADD][27/09/2016][Round by currency],END
                    if (objAssetsInfo.ACAssetOriginalAmount > 0)
                    {
                        objAssetsInfo.ACAssetDepreciationPercent = objAssetsInfo.ACAssetDepreciationAmount / objAssetsInfo.ACAssetOriginalAmount * 100;
                    }
                }
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Called when the user changes the depreciation percent
        /// </summary>
        public void ChangeDepreciationPercent()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ACAssetsInfo objAssetsInfo = (ACAssetsInfo)CurrentModuleEntity.MainObject;
                objAssetsInfo.ACAssetDepreciationAmount = objAssetsInfo.ACAssetOriginalAmount * objAssetsInfo.ACAssetDepreciationPercent / 100;
                //TNDLoc [ADD][27/09/2016][Round by currency],START
                //GECurrenciesController currenciesController = new GECurrenciesController();
                //GECurrenciesInfo vnCurrency = (GECurrenciesInfo)currenciesController.GetObjectByNo(CurrencyNo.VND.ToString());
                //if (vnCurrency != null)
                {
                    BOSApp.RoundByCurrency(objAssetsInfo, "ACAssetDepreciationAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
                //TNDLoc [ADD][27/09/2016][Round by currency],END
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Called when the user changes the asset room
        /// </summary>
        /// <param name="roomID">Target room id</param>
        public void ChangeRoom(int roomID)
        {
            ACAssetsInfo asset = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            asset.FK_HRInitRoomID = roomID;
        }

        /// <summary>
        /// Called when the user changes the depreciation amount
        /// </summary>
        public void ChangeDepreciationAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ACAssetsInfo objAssetsInfo = (ACAssetsInfo)CurrentModuleEntity.MainObject;
                if (objAssetsInfo.ACAssetOriginalAmount > 0)
                {
                    objAssetsInfo.ACAssetDepreciationPercent = objAssetsInfo.ACAssetDepreciationAmount / objAssetsInfo.ACAssetOriginalAmount * 100;

                    CurrentModuleEntity.UpdateMainObjectBindingSource();
                }
            }
        }

        public override int ActionSave()
        {
            //
            ACAssetsInfo asset = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            if (asset.FK_ICMeasureUnitID == 0)
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (asset.FK_ACAssetTypeAccountConfigID == 0)
            {
                MessageBox.Show("Vui lòng nhập nhóm tài khoản!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (asset.ACAssetExpiryMonths == 0)
            {
                MessageBox.Show("Vui lòng nhập số tháng khấu hao!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (!CheckDepreciation())
                return 0;
            UpdateDepreciationInfo();
            return base.ActionSave();
        }
        public bool CheckDepreciation()
        {
            bool result = true;
            ACAssetsInfo asset = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            ACAssetTypeDepreciationConfigsInfo ctac = new ACAssetTypeDepreciationConfigsInfo();
            ACAssetTypeDepreciationConfigsController ctacsController = new ACAssetTypeDepreciationConfigsController();
            string mess = string.Empty;
            if (asset != null)
            {
                ctac = (ACAssetTypeDepreciationConfigsInfo)ctacsController.GetDepreciationConfigByType(asset.ACAssetType);
                if (ctac != null)
                {
                    if (asset.ACAssetExpiryMonths < ctac.ACAssetTypeDepreciationConfigMin)
                    {
                        mess = "Số tháng khấu hao nhỏ hơn số tháng khấu hao tối thểu: " + ctac.ACAssetTypeDepreciationConfigMin + ". Bạn có muốn lưu không";
                        result = false;
                    }
                    if (asset.ACAssetExpiryMonths > ctac.ACAssetTypeDepreciationConfigMax)
                    {
                        mess = "Số tháng khấu hao lớn hơn số tháng khấu hao tối đa: " + ctac.ACAssetTypeDepreciationConfigMax + ". Bạn có muốn lưu không";
                        result = false;
                    }
                }
            }
            if (!result)
            {
                if (MessageBox.Show(mess,
                               CommonLocalizedResources.MessageBoxDefaultCaption,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    result = true;
                }
            }

            return result;
        }
        public override void ActionDuplicate()
        {
            base.ActionDuplicate();

            ACAssetsInfo asset = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            asset.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            asset.ACAssetStatus = AssetStatus.Purchased.ToString();
            asset.ACAssetDepreciatedAmount = 0;
            asset.ACAssetRemainedAmount = 0;
            asset.ACAssetCost = 0;
            asset.ACAssetOriginalAmount = 0;
            asset.ACAssetDepreciationAmount = 0;
            asset.FK_ACUnfinishedConstructionCostID = 0;
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Update depreciation info
        /// </summary>
        public void UpdateDepreciationInfo()
        {
            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            objAssetsInfo.ACAssetDepreciationAmount = objAssetsInfo.ACAssetOriginalAmount * objAssetsInfo.ACAssetDepreciationPercent / 100;
            objAssetsInfo.ACAssetRemainedAmount = objAssetsInfo.ACAssetOriginalAmount - objAssetsInfo.ACAssetDepreciatedAmount;
            if (string.IsNullOrEmpty(objAssetsInfo.ACAssetDesc))
            {
                objAssetsInfo.ACAssetDesc = objAssetsInfo.ACAssetName;
            }
            //TNDLoc [ADD][27/09/2016][Round by currency],START
            //GECurrenciesController currenciesController = new GECurrenciesController();
            //GECurrenciesInfo vnCurrency = (GECurrenciesInfo)currenciesController.GetObjectByNo(CurrencyNo.VND.ToString());
            //if (vnCurrency != null)
            {
                BOSApp.RoundByCurrency(objAssetsInfo, "ACAssetDepreciationAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objAssetsInfo, "ACAssetRemainedAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            }
            //TNDLoc [ADD][27/09/2016][Round by currency],END

            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }
        public void ShowCategoryTree()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            AssetEntities entity = (AssetEntities)CurrentModuleEntity;
            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)entity.MainObject;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(objAssetsInfo.FK_ICDepartmentID, objAssetsInfo.FK_ICProductGroupID);
            guiProductGroupTree.Module = this;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    objAssetsInfo.FK_ICDepartmentID = guiProductGroupTree.ICDepartmentID;
                    objAssetsInfo.FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    objAssetsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;
                    objAssetsInfo.ICProductGroupName = guiProductGroupTree.GetSelectedProductGroupName();
                    ProductGroupsButtonEdit.Text = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    objAssetsInfo.FK_ICProductGroupID = 0;
                    objAssetsInfo.ICProductGroupName = string.Empty;
                }
                entity.UpdateMainObjectBindingSource();
            }
        }
        public override void ActionNew()
        {
            base.ActionNew();
        }
        public override void Invalidate(int iObjectID)
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            ACAssetsInfo mainObject = (ACAssetsInfo)objAssetsController.GetObjectByID(iObjectID);
            if ((mainObject.ACAssetStatus == AssetStatus.Using.ToString()) && mainObject.ACAssetRemainedAmount == 0)
                mainObject.ACAssetStatus = AssetStatus.UsingWithoutDepreciation.ToString();
            if ((mainObject.ACAssetStatus == AssetStatus.UsingWithoutDepreciation.ToString()) && mainObject.ACAssetRemainedAmount > 0)
                mainObject.ACAssetStatus = AssetStatus.Using.ToString();
            objAssetsController.UpdateObject(mainObject);
            base.Invalidate(iObjectID);
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            AssetEntities entity = (AssetEntities)CurrentModuleEntity;
            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            if (objAssetsInfo.ACAssetStatus == "Purchased")
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            }
        }
        public void ChangeOriginalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ACAssetsInfo objAssetsInfo = (ACAssetsInfo)CurrentModuleEntity.MainObject;
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                if (objAssetsInfo.FK_ACUnfinishedConstructionCostID > 0)
                {
                    List<ACDocumentEntrysInfo> documentEntrys = objDocumentEntrysController.GetObjectByACUnfinishedConstructionCostID(objAssetsInfo.FK_ACUnfinishedConstructionCostID);

                    objAssetsInfo.ACAssetOriginalAmount = documentEntrys.Sum(o => o.ACDocumentEntryAmount);
                    CurrentModuleEntity.UpdateMainObjectBindingSource();
                }
            }

        }
        public void ChangeAssetTypeAccountConfig(int customerTypeAccountConfigID)
        {
            AssetEntities entity = (AssetEntities)CurrentModuleEntity;
            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)entity.MainObject;
            objAssetsInfo.FK_ACAssetTypeAccountConfigID = customerTypeAccountConfigID;

            ACAssetTypeAccountConfigsInfo ctac = new ACAssetTypeAccountConfigsInfo();
            ACAssetTypeAccountConfigsController ctacsController = new ACAssetTypeAccountConfigsController();
            if (customerTypeAccountConfigID > 0)
            {
                ctac = (ACAssetTypeAccountConfigsInfo)ctacsController.GetObjectByID(customerTypeAccountConfigID);
                if (ctac != null)
                {
                    objAssetsInfo.FK_ACAccountID = ctac.FK_ACAccountID;
                    objAssetsInfo.FK_ACDepreciationAccountID = ctac.FK_ACDepreciationAccountID;
                    objAssetsInfo.FK_ACDepreciationCostAccountID = ctac.FK_ACDepreciationCostAccountID;
                }
            }

            entity.UpdateMainObjectBindingSource();
        }
        public void ChangeAssetTypeDepreciationConfig(string assetType)
        {
            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            objAssetsInfo.ACAssetType = assetType;

            ACAssetTypeDepreciationConfigsInfo ctac = new ACAssetTypeDepreciationConfigsInfo();
            ACAssetTypeDepreciationConfigsController ctacsController = new ACAssetTypeDepreciationConfigsController();
            if (assetType != string.Empty)
            {
                ctac = (ACAssetTypeDepreciationConfigsInfo)ctacsController.GetDepreciationConfigByType(assetType);
                if (ctac != null)
                {
                    objAssetsInfo.ACAssetExpiryMonths = ctac.ACAssetTypeDepreciationConfigMin;
                }
            }

            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public List<HRDepartmentRoomsInfo> GetListDepartmentRoomsByDepartmentID()
        {
            ACAssetsInfo mainObject = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> listRoom = objDepartmentRoomsController.GetRoomList(mainObject.FK_HRDepartmentID);
            listRoom.Add(new HRDepartmentRoomsInfo());
            return listRoom.OrderBy(o => o.HRDepartmentRoomID).ToList();
        }
        
        public List<HRDepartmentRoomGroupItemsInfo> GetListDepartmentRoomGroupItemsByDepartmentRoomID()
        {
            ACAssetsInfo mainObject = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> listRoom = objDepartmentRoomGroupItemsController.GetDepartmentRoomGroupItemByDepartmentRoomID(mainObject.FK_HRDepartmentRoomID);
            listRoom.Add(new HRDepartmentRoomGroupItemsInfo());
            return listRoom.OrderBy(o => o.HRDepartmentRoomGroupItemID).ToList();
        }

        public List<MMLinesInfo> GetListLinesByWorkShopID()
        {
            ACAssetsInfo mainObject = (ACAssetsInfo)CurrentModuleEntity.MainObject;
            MMLinesController objLinesController = new MMLinesController();
            List<MMLinesInfo> listRoom = objLinesController.GetAllAliveAndActiveLine();
            listRoom.Select(o => o.FK_MMWorkShopID == mainObject.FK_MMWorkShopID).ToList();
            listRoom.Add(new MMLinesInfo());
            return listRoom.OrderBy(o => o.MMLineID).ToList();
        }
    }
}
