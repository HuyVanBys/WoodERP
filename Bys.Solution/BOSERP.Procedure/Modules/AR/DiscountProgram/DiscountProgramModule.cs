using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BOSLib;
using BOSCommon;
using BOSReport;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using BOSComponent;
using System.Drawing;
using DevExpress.XtraTab;
using BOSCommon.Constants;

namespace BOSERP.Modules.DiscountProgram
{
    public class DiscountProgramModule : BaseTransactionModule
    {
        #region Constant
        public const string DiscountProgramMethodTypeControlName = "fld_lkeARDiscountProgramMethodType";

        public const string DiscountProgramIsSaleControlName = "fld_lkeARDiscountProgramIsExhibit";

        public const string DiscountProgramApplyOnControlName = "fld_lkeARDiscountProgramApplyOn";

        public const string DiscountProgramCalMethodControlName = "fld_lkeARDiscountProgramCalMethod";

        public const string DiscountProgramSaleTargetControlName = "fld_txtARDiscountProgramSaleTarget";

        public const string DiscountProgramItemsGridControlName = "fld_dgcARDiscountProgramItems";

        public const string ConfigTabControlName = "fld_xtabConfig";

        public const string ChooseProductControlName = "fld_btnChooseProduct";
        #endregion

        #region Public properties
        BOSLookupEdit DiscountProgramMethodTypeControl;

        BOSLookupEdit DiscountProgramApplyOnControl;

        BOSLookupEdit DiscountProgramCalMethodControl;

        BOSTextBox DiscountProgramSaleTargetControl;

        ARDiscountProgramItemsGridControl DiscountProgramItemsGridControl;

        XtraTabControl ConfigTabControl;

        BOSButton ChooseProductControl;
        #endregion

        #region Constructor
        public DiscountProgramModule()
        {
            Name = ModuleName.DiscountProgram;
            CurrentModuleEntity = new DiscountProgramEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            DiscountProgramMethodTypeControl = (BOSLookupEdit)Controls[DiscountProgramMethodTypeControlName];
            DiscountProgramApplyOnControl = (BOSLookupEdit)Controls[DiscountProgramApplyOnControlName];
            DiscountProgramCalMethodControl = (BOSLookupEdit)Controls[DiscountProgramCalMethodControlName];
            DiscountProgramSaleTargetControl = (BOSTextBox)Controls[DiscountProgramSaleTargetControlName];
            DiscountProgramItemsGridControl = (ARDiscountProgramItemsGridControl)Controls[DiscountProgramItemsGridControlName];
            ChooseProductControl = (BOSButton)Controls[ChooseProductControlName];
            ConfigTabControl = (XtraTabControl)Controls[ConfigTabControlName];
        }
        #endregion

        //protected override DataSet GetSearchData(ref string searchQuery)
        //{
        //    return base.GetSearchData(ref searchQuery);
        //}

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo searchObject = (ARDiscountProgramsInfo)entity.SearchObject;
            ARDiscountProgramsController objDiscountProgramsController = new ARDiscountProgramsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds;
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objDiscountProgramsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objDiscountProgramsController.GetDataSetDiscountProgramListByListBranch(
                                                                            searchObject.ARDiscountProgramNo,
                                                                            objObjectsInfo.ACObjectID,
                                                                            objObjectsInfo.ACObjectType,
                                                                            searchObject.DiscountProgramFromDate,
                                                                            searchObject.DiscountProgramToDate,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objDiscountProgramsController.GetDataSetDiscountProgramListByBranchID(
                                                                        searchObject.ARDiscountProgramNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.DiscountProgramFromDate,
                                                                        searchObject.DiscountProgramToDate,
                                                                        searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public void ResetDiscountProgramTarget(bool isChecked)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            if (!isChecked)
            {
                mainobject.ARDiscountProgramSaleTarget = 0;
            }
            entity.UpdateMainObjectBindingSource();
            EnableControls(mainobject.ARDiscountProgramType, mainobject.ARDiscountProgramApplyType, mainobject.ARDiscountProgramIsSales);
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            EnableControls(mainobject.ARDiscountProgramType, mainobject.ARDiscountProgramApplyType, mainobject.ARDiscountProgramIsSales);
        }

        public void ApproveDiscountProgram()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainobject.ARDiscountProgramStatus = DiscountProgramStatus.Approved.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton("Approve", true);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, true);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (mainobject.ARDiscountProgramStatus == DiscountProgramStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
            }
            if (!Toolbar.IsNullOrNoneAction())
            {
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, false);
            }
            base.InvalidateToolbar();
        }

        public void ChangeDiscountProgramType(string programType)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            mainobject.ARDiscountProgramType = programType;
            if (programType == DiscountProgramType.BonusSales.ToString()
               || programType == DiscountProgramType.PaymentBonus.ToString())
            {
                mainobject.ARDiscountProgramMethodType = DiscountProgramMethodType.Postpaid.ToString();
            }
            entity.UpdateMainObjectBindingSource();
            EnableControls(mainobject.ARDiscountProgramType, mainobject.ARDiscountProgramApplyType, mainobject.ARDiscountProgramIsSales);
        }

        public void ChangeDiscountProgramApplyType(string applyType)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            mainobject.ARDiscountProgramApplyType = applyType;
            entity.UpdateMainObjectBindingSource();
            EnableControls(mainobject.ARDiscountProgramType, mainobject.ARDiscountProgramApplyType, mainobject.ARDiscountProgramIsSales);
        }

        public void ChangeDiscountProgramApplyOn(string programApplyOn)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            mainobject.ARDiscountProgramApplyOn = programApplyOn;
            if (entity.DiscountProgramItemList.Count() == 0)
                return;

            DialogResult rs = MessageBox.Show("Bạn có muốn thay đổi Áp dụng CK cho toàn bộ sản phẩm không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            entity.DiscountProgramItemList.ForEach(o =>
            {
                o.ARDiscountProgramItemApplyOn = programApplyOn;
                UpdateDiscountProgramItem(o);
            });
            entity.DiscountProgramItemList.GridControl?.RefreshDataSource();
        }

        public void EnableControls(string programType, string programApplyType, bool programIsSales, bool programIsExhibit = false)
        {
            if (programType == DiscountProgramType.BonusSales.ToString()
                || programType == DiscountProgramType.PaymentBonus.ToString())
            {
                ChangeLookupStylyeEnable(DiscountProgramMethodTypeControl, false);
            }
            else
            {
                ChangeLookupStylyeEnable(DiscountProgramMethodTypeControl, true);
            }
            if (programApplyType == DiscountProgramApplyType.SaleOrder.ToString())
            {
                ChangeButtonEditStyleEnable(ChooseProductControl, false);
            }
            else
            {
                ChangeButtonEditStyleEnable(ChooseProductControl, true);
            }    
            ChangeLookupStylyeEnable(DiscountProgramCalMethodControl, programIsSales);
            ChangeTextEditStylyeEnable(DiscountProgramSaleTargetControl, programIsSales);
            if (DiscountProgramItemsGridControl != null)
            {
                DiscountProgramItemsGridControl.LoadGridColumnByType(programType, programIsExhibit);
            }
            if (ConfigTabControl != null)
            {
                bool isEnableConfig = (programType == DiscountProgramType.BonusSales.ToString() ? true : false);
                foreach (XtraTabPage tab in ConfigTabControl.TabPages)
                {
                    if (tab.Name == "fld_tabProductDiscount")
                        tab.PageVisible = !isEnableConfig;
                    if (tab.Name == "fld_tabTargetConfig")
                        tab.PageVisible = isEnableConfig;
                }
            }
        }

        public void ChangeTextEditStylyeEnable(BOSTextBox control, bool isEnable)
        {
            if (control == null)
                return;

            control.Enabled = isEnable;
            control.Properties.ReadOnly = !isEnable;
            control.BackColor = isEnable ? Color.White : Color.WhiteSmoke;
        }

        public void ChangeButtonEditStyleEnable(BOSButton control, bool isEnable)
        {
            if (control == null)
                return;

            control.Enabled = isEnable;
            control.BackColor = isEnable ? Color.White : Color.WhiteSmoke;
        }

        public void ChangeLookupStylyeEnable(BOSLookupEdit control, bool isEnable)
        {
            if (control == null)
                return;

            control.Enabled = isEnable;
            control.Properties.ReadOnly = !isEnable;
            control.BackColor = isEnable ? Color.White : Color.WhiteSmoke;
        }

        public override int ActionSave()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            ARDiscountProgramsController objDiscountProgramsController = new ARDiscountProgramsController();
            entity.DiscountProgramItemList.GridControl.Focus();
            if (mainobject.ARDiscountProgramIsVoucher && string.IsNullOrWhiteSpace(mainobject.ARDiscountProgramCode))
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (string.IsNullOrWhiteSpace(mainobject.ARDiscountProgramApplyOn))
            {
                MessageBox.Show("Vui lòng chọn áp dụng KM!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (string.IsNullOrWhiteSpace(mainobject.ARDiscountProgramApplyType))
            {
                MessageBox.Show("Vui lòng chọn hình thức áp dụng", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (!string.IsNullOrWhiteSpace(mainobject.ARDiscountProgramCode))
            {
                ARDiscountProgramsInfo objDuplicate = objDiscountProgramsController.CheckDiscoutCodeExists(mainobject.ARDiscountProgramCode, mainobject.ARDiscountProgramBeginDate, mainobject.ARDiscountProgramEndDate);
                if (objDuplicate != null && objDuplicate.ARDiscountProgramID != mainobject.ARDiscountProgramID)
                {
                    MessageBox.Show("Mã giảm giá đã tồn tại, vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            if (mainobject.ARDiscountProgramApplyType == DiscountProgramApplyType.SaleOrder.ToString() && string.IsNullOrWhiteSpace(mainobject.ARDiscountProgramCode))
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainobject.ARDiscountProgramApplyType == DiscountProgramApplyType.SaleOrder.ToString() && mainobject.ARDiscountProgramValue == 0)
            {
                MessageBox.Show("Vui lòng nhập % CTKM!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainobject.ARDiscountProgramApplyType == DiscountProgramApplyType.Product.ToString() && entity.DiscountProgramItemList.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cho hình thức áp dụng trên sản phẩm!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }    
            List<ARDiscountProgramItemsInfo> listDuplicate = new List<ARDiscountProgramItemsInfo>();
            ARDiscountProgramItemsController objDiscountProgramItemsController = new ARDiscountProgramItemsController();
            entity.DiscountProgramItemList.ForEach(i => {
                if (objDiscountProgramItemsController.CheckDiscountItemExists(i.FK_ICProductID, mainobject.ARDiscountProgramBeginDate, mainobject.ARDiscountProgramEndDate, mainobject.ARDiscountProgramID))
                    listDuplicate.Add(i);
            });
            if (listDuplicate.Count > 0)
            {
                MessageBox.Show(string.Join(",", listDuplicate.Select(i => i.ARDiscountProgramItemProductName).ToList()) + "đang nằm trong chương trình khuyến mãi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
                

            return base.ActionSave();
        }

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            mainobject.ARDiscountProgramStatus = DiscountProgramStatus.New.ToString();
        }

        public override void ActionNew()
        {
            base.ActionNew();
        }

        public void ChooseProduct()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            guiAddProduct guiFind = new guiAddProduct();
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            List<ICProductsInfo> productList = guiFind.SelectedObjects;
            List<ARDiscountProgramItemsInfo> discountProgramItemList = ToDiscountProgramItemList(productList);
            //discountProgramItemList.ForEach(i => )
            List<ARDiscountProgramItemsInfo> listDuplicate = new List<ARDiscountProgramItemsInfo>();
            ARDiscountProgramItemsController objDiscountProgramItemsController = new ARDiscountProgramItemsController();
            discountProgramItemList.ForEach(i => {
                if (objDiscountProgramItemsController.CheckDiscountItemExists(i.FK_ICProductID, mainobject.ARDiscountProgramBeginDate, mainobject.ARDiscountProgramEndDate, mainobject.ARDiscountProgramID))
                    listDuplicate.Add(i);
            });
            if (listDuplicate.Count > 0)
                MessageBox.Show(string.Join(",", listDuplicate.Select(i => i.ARDiscountProgramItemProductName).ToList()) + "đang nằm trong chương trình khuyến mãi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            entity.DiscountProgramItemList.AddRange(discountProgramItemList.Except(listDuplicate));
            entity.DiscountProgramItemList.GridControl?.RefreshDataSource();
        }

        public List<ARDiscountProgramItemsInfo> ToDiscountProgramItemList(List<ICProductsInfo> productList)
        {
            List<ARDiscountProgramItemsInfo> discountProgramItemList = new List<ARDiscountProgramItemsInfo>();
            ARDiscountProgramItemsInfo objDiscountProgramItemsInfo = new ARDiscountProgramItemsInfo();
            productList.ForEach(o =>
            {
                objDiscountProgramItemsInfo = ToDiscountProgramItem(o);
                discountProgramItemList.Add(objDiscountProgramItemsInfo);
            });
            return discountProgramItemList;
        }

        public ARDiscountProgramItemsInfo ToDiscountProgramItem(ICProductsInfo objProductsInfo)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            ARDiscountProgramItemsInfo objDiscountProgramItemsInfo = new ARDiscountProgramItemsInfo();
            objDiscountProgramItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objDiscountProgramItemsInfo.ARDiscountProgramItemProductName = objProductsInfo.ICProductName;
            objDiscountProgramItemsInfo.ARDiscountProgramItemProductDesc = objProductsInfo.ICProductDesc;
            objDiscountProgramItemsInfo.ARDiscountProgramItemProductType = objProductsInfo.ICProductType;
            objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice = objProductsInfo.ICProductPrice01;
            objDiscountProgramItemsInfo.ARDiscountProgramItemApplyOn = mainobject.ARDiscountProgramApplyOn;
            objDiscountProgramItemsInfo.ARDiscountProgramItemValue = mainobject.ARDiscountProgramValue;
            objDiscountProgramItemsInfo.ARDiscountProgramItemIsExhibit = mainobject.ARDiscountProgramIsExhibit;
            objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = objProductsInfo.ICProductPrice01;
            objDiscountProgramItemsInfo.ARDiscountProgramItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
            objDiscountProgramItemsInfo.ARDiscountProgramItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
            if (objDiscountProgramItemsInfo.ARDiscountProgramItemApplyOn == DiscountProgramApplyOn.Percent.ToString())
            {
                objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice - objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice * objDiscountProgramItemsInfo.ARDiscountProgramItemValue / 100;
            }
            else
            {
                objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice - objDiscountProgramItemsInfo.ARDiscountProgramItemValue;
            }
            Math.Round(objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice, 2, MidpointRounding.AwayFromZero);
            return objDiscountProgramItemsInfo;
        }

        public void ChangeItemProductUnitPrice()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            ARDiscountProgramItemsInfo objDiscountProgramItemsInfo = entity.DiscountProgramItemList[entity.DiscountProgramItemList.CurrentIndex];
            decimal discountPercent = 0;
            if (objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice == 0)
            {
                discountPercent = 0;
            }
            else if (objDiscountProgramItemsInfo.ARDiscountProgramItemApplyOn == DiscountProgramApplyOn.Percent.ToString())
            {
                discountPercent = 100 * (objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice - objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice) / objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice;
            }
            else
            {
                discountPercent = objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice - objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice;
            }
            Math.Round(discountPercent, 2, MidpointRounding.AwayFromZero);
            objDiscountProgramItemsInfo.ARDiscountProgramItemValue = discountPercent;
            UpdateDiscountProgramItem(objDiscountProgramItemsInfo);
            entity.DiscountProgramItemList.GridControl?.RefreshDataSource();
        }

        public void ChangeDiscountProgramItem()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            ARDiscountProgramItemsInfo objDiscountProgramItemsInfo = entity.DiscountProgramItemList[entity.DiscountProgramItemList.CurrentIndex];
            UpdateDiscountProgramItem(objDiscountProgramItemsInfo);
            entity.DiscountProgramItemList.GridControl?.RefreshDataSource();
        }

        public void ChangeDistributionChannel(int distributionChannel)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            ARPriceSheetItemsController objPriceSheetItemsController = new ARPriceSheetItemsController();
            entity.DiscountProgramItemList.ForEach(o =>
            {
                o.ARDiscountProgramItemBasicPrice = objPriceSheetItemsController.GetUnitPriceByByDistributionChannelID(o.FK_ICProductID, mainobject.FK_ARCustomerDistributionChannelID, mainobject.ARDiscountProgramDate);
                UpdateDiscountProgramItem(o);
            });
            entity.DiscountProgramItemList.GridControl?.RefreshDataSource();
        }

        public void ChangeProgramItemValue()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;

            if (entity.DiscountProgramItemList.Count() == 0)
                return;

            DialogResult rs = MessageBox.Show("Bạn có muốn thay đổi Chiết khấu cho toàn bộ sản phẩm không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            entity.DiscountProgramItemList.ForEach(o =>
            {
                o.ARDiscountProgramItemValue = mainobject.ARDiscountProgramValue;
                UpdateDiscountProgramItem(o);
            });
            entity.DiscountProgramItemList.GridControl?.RefreshDataSource();
        }

        public void UpdateDiscountProgramItem(ARDiscountProgramItemsInfo objDiscountProgramItemsInfo)
        {
            if (objDiscountProgramItemsInfo.ARDiscountProgramItemApplyOn == DiscountProgramApplyOn.Percent.ToString())
            {
                decimal discountAmount = objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice * objDiscountProgramItemsInfo.ARDiscountProgramItemValue / 100;
                objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice - discountAmount;
                objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = Math.Round(objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = objDiscountProgramItemsInfo.ARDiscountProgramItemBasicPrice - objDiscountProgramItemsInfo.ARDiscountProgramItemValue;
                objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = Math.Round(objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice, 2, MidpointRounding.AwayFromZero);
            }
            if (objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice < 0)
            {
                objDiscountProgramItemsInfo.ARDiscountProgramItemProductUnitPrice = 0;
            }   
        }

        public bool ChangeDiscountProgramIsExhibit(bool isExhibit)
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            mainobject.ARDiscountProgramIsExhibit = isExhibit;
            EnableControls(mainobject.ARDiscountProgramType, mainobject.ARDiscountProgramApplyType, mainobject.ARDiscountProgramIsSales, mainobject.ARDiscountProgramIsExhibit);
            DialogResult rs = MessageBox.Show("Bạn có muốn thay đổi Áp dụng khuyến mãi cho toàn bộ sản phẩm không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return false;

            entity.DiscountProgramItemList.ForEach(o =>
            {
                o.ARDiscountProgramItemIsExhibit = isExhibit;
                UpdateDiscountProgramItem(o);
            });
            entity.DiscountProgramItemList.GridControl?.RefreshDataSource();
            return true;
        }

        public void DeleteDiscountProgramItem()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            entity.DiscountProgramItemList.RemoveSelectedRowObjectFromList();
        }

        public void DeleteDiscountProgramItemTarget()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            entity.DiscountProgramItemTargetList.RemoveSelectedRowObjectFromList();
        }

        public void CopyDiscountProgramItemTargetNewRow()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            if (entity.DiscountProgramItemTargetList.CurrentIndex >= 0)
            {
                ARDiscountProgramItemTargetsInfo item = entity.DiscountProgramItemTargetList[entity.DiscountProgramItemTargetList.CurrentIndex];
                ARDiscountProgramItemTargetsInfo objDiscountProgramItemTargetsInfo = (ARDiscountProgramItemTargetsInfo)item.Clone();
                objDiscountProgramItemTargetsInfo.ARDiscountProgramItemTargetID = 0;
                entity.DiscountProgramItemTargetList.Add(objDiscountProgramItemTargetsInfo);
                entity.DiscountProgramItemTargetList.GridControl?.RefreshDataSource();
            }
        }

        public void SetDefaultDiscountProgramItemTarget(ARDiscountProgramItemTargetsInfo item)
        {
            if (item == null)
                return;

            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            DateTime toDate = BOSApp.GetCurrentServerDate();
            item.ARDiscountProgramItemTargetValue = mainobject.ARDiscountProgramSaleTarget;
            if (item.ARDiscountProgramItemTargetType == DiscountProgramItemTargetType.Quarter1.ToString())
            {
                item.ARDiscountProgramItemTargetFromDate = new DateTime(toDate.Year, 1, 1, 0, 0, 0);
                item.ARDiscountProgramItemTargetToDate = new DateTime(toDate.Year, 3, 31, 0, 0, 0);
            }
            else if (item.ARDiscountProgramItemTargetType == DiscountProgramItemTargetType.Quarter2.ToString())
            {
                item.ARDiscountProgramItemTargetFromDate = new DateTime(toDate.Year, 4, 1, 0, 0, 0);
                item.ARDiscountProgramItemTargetToDate = new DateTime(toDate.Year, 6, 30, 0, 0, 0);
            }
            else if (item.ARDiscountProgramItemTargetType == DiscountProgramItemTargetType.Quarter3.ToString())
            {
                item.ARDiscountProgramItemTargetFromDate = new DateTime(toDate.Year, 7, 1, 0, 0, 0);
                item.ARDiscountProgramItemTargetToDate = new DateTime(toDate.Year, 9, 30, 0, 0, 0);
            }
            else if (item.ARDiscountProgramItemTargetType == DiscountProgramItemTargetType.Quarter4.ToString())
            {
                item.ARDiscountProgramItemTargetFromDate = new DateTime(toDate.Year, 10, 1, 0, 0, 0);
                item.ARDiscountProgramItemTargetToDate = new DateTime(toDate.Year, 12, 31, 0, 0, 0);
            }
            else if (item.ARDiscountProgramItemTargetType == DiscountProgramItemTargetType.Year.ToString())
            {
                item.ARDiscountProgramItemTargetFromDate = new DateTime(toDate.Year, 1, 1, 0, 0, 0);
                item.ARDiscountProgramItemTargetToDate = new DateTime(toDate.Year, 12, 31, 0, 0, 0);
            }
        }
        public override bool ActionCancelComplete()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)CurrentModuleEntity;
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)entity.MainObject;
            if (mainobject.ARDiscountProgramID > 0)
            {
                entity.SetPropertyChangeEventLock(false);
                mainobject.ARDiscountProgramStatus = DiscountProgramStatus.New.ToString();
                entity.UpdateMainObject();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
            base.ActionCancelComplete();
            return true;
        }
        public override void ActionDelete()
        {
            base.ActionDelete();
        }
    }
}
