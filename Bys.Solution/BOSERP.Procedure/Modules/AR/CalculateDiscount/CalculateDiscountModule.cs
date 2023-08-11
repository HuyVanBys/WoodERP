using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculateDiscount
{
    public class CalculateDiscountModule : BaseTransactionModule
    {
        #region Constant
        public string CalDiscountTabControlName = "fld_tabcCalDiscount";
        #endregion

        #region Public properties
        public ARCalculateDiscountsInfo CurrentCalculateDiscount { get; set; }

        BOSTabControl TabControl;
        #endregion

        #region Constructor
        public CalculateDiscountModule()
        {
            Name = ModuleName.CalculateDiscount;
            CurrentModuleEntity = new CalculateDiscountEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            CurrentCalculateDiscount = new ARCalculateDiscountsInfo();
            TabControl = (BOSTabControl)Controls[CalDiscountTabControlName];
        }

        public void SearchDiscountProgram(string discountProgramNo
                                          , string discountProgramName
                                          , int customerDistributionChannelID
                                          , int acObjectID
                                          , string acObjectType
                                          , DateTime fromDate
                                          , DateTime toDate)
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            ARDiscountProgramsController objDiscountProgramsController = new ARDiscountProgramsController();
            List<ARDiscountProgramsInfo> discountProgramsList = objDiscountProgramsController.GetDiscountProgramForCalculate(discountProgramNo, discountProgramName, customerDistributionChannelID, acObjectID, acObjectType, fromDate, toDate);
            entity.DiscountProgramsList.Invalidate(discountProgramsList);
        }

        public void CreateNewTab(ARCalculateDiscountsInfo objCalculateDiscountsInfo)
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            entity.MainObject = objCalculateDiscountsInfo;
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)entity.MainObject;
            CurrentCalculateDiscount = mainobject;
            XtraTabPage carcassPage = null;
            int index = 0;
            foreach (XtraTabPage page in TabControl.TabPages)
            {
                if (page.Name == "fld_tabCalculateDiscounts")
                {
                    carcassPage = page;
                    break;
                }
                index++;
            }
            InvalidateCalculateDiscount(carcassPage, mainobject);
            entity.InvalidateCalculateDiscountItem(mainobject);
            InvalidateAccountingEntries();
            TabControl.SelectedTabPage = carcassPage;
        }

        protected override void InvalidateAccountingEntries()
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)entity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            entries = objDocumentEntrysController.GetAccountingEntries(this.Name, 0, mainobject.ARCalculateDiscountNo);
            entity.DocumentEntryList.Invalidate(entries);
            if (entity.DocumentEntryList.GridControl != null)
                entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public ARCalculateDiscountsInfo GetCalculateDiscountByDiscountProgram(ARDiscountProgramsInfo objDiscountProgramsInfo)
        {
            return new ARCalculateDiscountsInfo();
        }

        private void InvalidateCalculateDiscount(XtraTabPage calculateDiscounts, ARCalculateDiscountsInfo objCalculateDiscountsInfo)
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            calculateDiscounts.PageVisible = true;
            calculateDiscounts.Text = string.Join("-", new string[2] { objCalculateDiscountsInfo.ARDiscountProgramNo, objCalculateDiscountsInfo.ARDiscountProgramName });

            entity.UpdateMainObjectBindingSource();
        }

        public void LoadSales()
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)entity.MainObject;
            if (string.IsNullOrWhiteSpace(mainobject.ARCalculateDiscountType))
            {
                MessageBox.Show("Vui lòng chọn Chiết khấu kỳ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BOSProgressBar.Start(CalculateDiscountResources.LoadSaleProcessing);
            ARCalculateDiscountItemsController objCalculateDiscountItemsController = new ARCalculateDiscountItemsController();
            List<ARCalculateDiscountItemsInfo> calculateDiscountItemsList = objCalculateDiscountItemsController.GetSalesByDistributionChannel(CurrentCalculateDiscount.FK_ARDiscountProgramID
                                                                                                                                             , CurrentCalculateDiscount.ARCalculateDiscountType
                                                                                                                                             , CurrentCalculateDiscount.FK_ARCustomerDistributionChannelID
                                                                                                                                             , CurrentCalculateDiscount.FK_ACObjectID
                                                                                                                                             , CurrentCalculateDiscount.ARObjectType);
            calculateDiscountItemsList = calculateDiscountItemsList.GroupBy(o => new { o.FK_ACObjectID, o.ARObjectType, o.ACObjectAccessKey })
                                                                   .Select(o => o.First())
                                                                   .OrderByDescending(o => o.ARCalculateDiscountItemSalesAmount)
                                                                   .ToList();
            entity.CalculateDiscountItemsList.Invalidate(calculateDiscountItemsList);
            BOSProgressBar.Close();
        }

        public void UpdateSales()
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)entity.MainObject;
            if (string.IsNullOrWhiteSpace(mainobject.ARCalculateDiscountType))
            {
                MessageBox.Show("Vui lòng chọn Chiết khấu kỳ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ARCalculateDiscountItemsController objCalculateDiscountItemsController = new ARCalculateDiscountItemsController();
            List<ARCalculateDiscountItemsInfo> calculateDiscountItemsList = objCalculateDiscountItemsController.GetSalesByDistributionChannel(CurrentCalculateDiscount.FK_ARDiscountProgramID
                                                                                                                                             , CurrentCalculateDiscount.ARCalculateDiscountType
                                                                                                                                             , CurrentCalculateDiscount.FK_ARCustomerDistributionChannelID
                                                                                                                                             , CurrentCalculateDiscount.FK_ACObjectID
                                                                                                                                             , CurrentCalculateDiscount.ARObjectType);
            calculateDiscountItemsList = calculateDiscountItemsList.GroupBy(o => new { o.FK_ACObjectID, o.ARObjectType, o.ACObjectAccessKey })
                                                                   .Select(o => o.First())
                                                                   .OrderByDescending(o => o.ARCalculateDiscountItemSalesAmount)
                                                                   .ToList();
            entity.CalculateDiscountItemsList.ForEach(p =>
            {
                ARCalculateDiscountItemsInfo objCalculateDiscountItemsInfo = calculateDiscountItemsList.FirstOrDefault(o => o.FK_ACObjectID == p.FK_ACObjectID && o.ARObjectType == p.ARObjectType);
                if (objCalculateDiscountItemsInfo != null)
                {
                    p.ARCalculateDiscountItemTargetValue = objCalculateDiscountItemsInfo.ARCalculateDiscountItemTargetValue;
                    p.ARCalculateDiscountItemSalesAmount = objCalculateDiscountItemsInfo.ARCalculateDiscountItemSalesAmount;
                    p.ARCalculateDiscountItemTargetBonus01 = objCalculateDiscountItemsInfo.ARCalculateDiscountItemTargetBonus01;
                    p.ARCalculateDiscountItemTargetBonusAmount01 = objCalculateDiscountItemsInfo.ARCalculateDiscountItemTargetBonusAmount01;

                    calculateDiscountItemsList.Remove(objCalculateDiscountItemsInfo);
                }
            });

            if (calculateDiscountItemsList.Count() > 0)
                entity.CalculateDiscountItemsList.AddRange(calculateDiscountItemsList);

            entity.CalculateDiscountItemsList.GridControl.RefreshDataSource();
        }

        public void ApprovedCalculateDiscount()
        {
            Cursor.Current = Cursors.WaitCursor;
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)entity.MainObject;
            ARCalculateDiscountsController objCalculateDiscountsController = new ARCalculateDiscountsController();
            mainobject.ARCalculateDiscountStatus = CalculateDiscountStatus.Approved.ToString();
            int employeeApprovedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            entity.CalculateDiscountItemsList.ForEach(o =>
            {
                if (o.FK_HREmployeeApprovedID > 0)
                    return;

                o.FK_HREmployeeApprovedID = employeeApprovedID;
                o.ARCalculateDiscountItemApprovedDate = BOSApp.GetCurrentServerDate();
            });
            objCalculateDiscountsController.UpdateObject(mainobject);
            entity.SaveModuleObjects();
            entity.UpdateMainObjectBindingSource();
            entity.UpdateModuleObjectsBindingSource();
            if (entity.CalculateDiscountItemsList.GridControl != null)
            {
                entity.CalculateDiscountItemsList.GridControl.RefreshDataSource();
            }
            GLHelper.PostedTransactions(this.Name, mainobject.ARCalculateDiscountID, ModulePostingType.Accounting);
            InvalidateButtonAction();
            Cursor.Current = Cursors.Default;
        }

        public void SaveCalculateDiscount()
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)entity.MainObject;
            Cursor.Current = Cursors.WaitCursor;
            int iObjectID = 0;
            if (mainobject.ARCalculateDiscountID == 0)
                iObjectID = entity.CreateMainObject();
            else
                iObjectID = entity.UpdateMainObject();

            if (iObjectID > 0)
            {
                entity.CalculateDiscountItemsList.ForEach(o =>
                {
                    o.FK_ARCalculateDiscountID = iObjectID;
                });
                entity.SaveModuleObjects();
            }
            InvalidateButtonAction();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor.Current = Cursors.Default;
        }

        public void DeleteCalculateDiscountItem()
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            entity.CalculateDiscountItemsList.RemoveSelectedRowObjectFromList();
        }

        public void ShowCalculateDiscount(ARDiscountProgramsInfo objDiscountProgramsInfo)
        {
            ARDiscountProgramsController objDiscountProgramsController = new ARDiscountProgramsController();
            objDiscountProgramsInfo = (ARDiscountProgramsInfo)objDiscountProgramsController.GetObjectByID(objDiscountProgramsInfo.ARDiscountProgramID);
            if (objDiscountProgramsInfo == null)
                return;

            ARCalculateDiscountsController objCalculateDiscountsController = new ARCalculateDiscountsController();
            List<ARCalculateDiscountsInfo> calculateDiscountList = objCalculateDiscountsController.GetCalculateDiscountByDiscountProgramID(objDiscountProgramsInfo.ARDiscountProgramID);

            ARCalculateDiscountsInfo objCalculateDiscountsInfo = new ARCalculateDiscountsInfo();
            if (calculateDiscountList.Count() != 0)
            {
                guiCalculateDiscounts guiFind = new guiCalculateDiscounts(calculateDiscountList, objDiscountProgramsInfo);
                guiFind.Module = this;
                DialogResult rs = guiFind.ShowDialog();
                if (rs != DialogResult.OK)
                    return;

                objCalculateDiscountsInfo = guiFind.SelectedObjects.FirstOrDefault();
            }
            else
            {
                objCalculateDiscountsInfo = new ARCalculateDiscountsInfo()
                {
                    ARCalculateDiscountNo = CalculateDiscountEntities.cstNewObjectText,
                    ARCalculateDiscountDate = BOSApp.GetCurrentServerDate(),
                    ARDiscountProgramNo = objDiscountProgramsInfo.ARDiscountProgramNo,
                    ARDiscountProgramName = objDiscountProgramsInfo.ARDiscountProgramName,
                    ARCalculateDiscountStatus = BusinessObject.DefaultStatus,
                    FK_ARDiscountProgramID = objDiscountProgramsInfo.ARDiscountProgramID,
                    FK_ARCustomerDistributionChannelID = objDiscountProgramsInfo.FK_ARCustomerDistributionChannelID,
                    FK_ACObjectID = objDiscountProgramsInfo.FK_ACObjectID,
                    ARObjectType = objDiscountProgramsInfo.ARObjectType,
                    ACObjectAccessKey = string.Join(";", new string[2] { objDiscountProgramsInfo.FK_ACObjectID.ToString(), objDiscountProgramsInfo.ARObjectType }),
                    FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                    FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GECurrencyID,
                    ARCalculateDiscountExchangeRate = 1
                };
            }
            CreateNewTab(objCalculateDiscountsInfo);
            InvalidateButtonAction();
        }

        public string ChangeCalculateDiscountType(string calculateDiscountType)
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)CurrentModuleEntity;
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)entity.MainObject;
            string oldValue = mainobject.ARCalculateDiscountType;
            ARCalculateDiscountsController objCalculateDiscountsController = new ARCalculateDiscountsController();
            ARCalculateDiscountsInfo objCalculateDiscountsInfo = objCalculateDiscountsController.GetCalculateDiscountByDiscountProgramIDAndType(mainobject.FK_ARDiscountProgramID, calculateDiscountType);
            mainobject.ARCalculateDiscountType = calculateDiscountType;
            if (objCalculateDiscountsInfo != null)
            {
                MessageBox.Show("Kỳ chiếu khấu này đã tồn tại. Vui lòng kiểm tra lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainobject.ARCalculateDiscountType = oldValue;
            }
            return mainobject.ARCalculateDiscountType;
        }

        public void InvalidateButtonAction()
        {
            ARCalculateDiscountsInfo mainobject = (ARCalculateDiscountsInfo)CurrentModuleEntity.MainObject;
            bool isActionNew = mainobject.ARCalculateDiscountStatus == CalculateDiscountStatus.New.ToString() ? true : false;
            BOSButton buttonEdit = (BOSButton)Controls["fld_btnLoadSalesTarget"];
            if (buttonEdit != null)
            {
                buttonEdit.Enabled = false;
                if (mainobject.ARCalculateDiscountID == 0)
                    buttonEdit.Enabled = isActionNew;
            }
            buttonEdit = (BOSButton)Controls["fld_btnReLoadSales"];
            if (buttonEdit != null)
            {
                buttonEdit.Enabled = false;
                if (mainobject.ARCalculateDiscountID > 0)
                    buttonEdit.Enabled = isActionNew;
            }
            buttonEdit = (BOSButton)Controls["fld_btnSave"];
            if (buttonEdit != null)
            {
                buttonEdit.Enabled = isActionNew;
            }
            buttonEdit = (BOSButton)Controls["fld_btnApprove"];
            if (buttonEdit != null)
            {
                buttonEdit.Enabled = false;
                if (mainobject.ARCalculateDiscountID > 0)
                    buttonEdit.Enabled = isActionNew;
            }
        }

        #endregion
    }
}
