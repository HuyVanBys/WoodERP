using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AP.PurchaseContract.Localization;
using BOSERP.Utilities;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseContract
{
    public class PurchaseContractModule : BaseTransactionModule
    {
        #region Constant

        public const string PurchaseContractParentControlName = "fld_lkeAPPurchaseContractParentID";

        public const string FilePathTextBoxName = "fld_txtFilePath";

        public BOSLookupEdit PurchaseContractParentControl;

        private string DocumentFileName = string.Empty;
        #endregion

        #region Constructor
        public PurchaseContractModule()
        {
            Name = ModuleName.PurchaseContract;
            CurrentModuleEntity = new PurchaseContractEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            PurchaseContractParentControl = (BOSLookupEdit)Controls[PurchaseContractParentControlName];
            PurchaseContractParentControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(PurchaseContractParentControl_QueryPopUp);
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ChangePurchaseContractType();
        }

        public void InitPurchaseContractDataSource()
        {
            if (PurchaseContractParentControl == null)
                return;

            APPurchaseContractsController controller = new APPurchaseContractsController();
            List<APPurchaseContractsInfo> purchaseContractList = controller.GetLookupDataSourceByType(PurchaseContractType.Appendix.ToString());
            purchaseContractList.Insert(0, new APPurchaseContractsInfo());
            PurchaseContractParentControl.Properties.DataSource = purchaseContractList;
        }

        private void PurchaseContractParentControl_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;

            APPurchaseContractsController controller = new APPurchaseContractsController();
            List<APPurchaseContractsInfo> purchaseContractList = controller.GetLookupDataSourceByType(PurchaseContractType.Root.ToString());
            purchaseContractList.Insert(0, new APPurchaseContractsInfo());
            PurchaseContractParentControl.Properties.DataSource = purchaseContractList;
        }

        public override int ActionSave()
        {
            APPurchaseContractsInfo mainObject = (APPurchaseContractsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.APPurchaseContractType == PurchaseContractType.Appendix.ToString() && mainObject.APPurchaseContractParentID == 0)
            {
                MessageBox.Show(SaleContractLocalizedResources.SaleContractOriginalIsNull, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            int objectID = base.ActionSave();
            if (objectID > 0)
            {
                SavePurchaseContractFile();
            }
            return objectID;
        }

        public void SavePurchaseContractFile()
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            List<APFileAttachmentsInfo> purchaseContractTemplate = entity.PurchaseContractTemplate.ToList();

            APFileAttachmentsController objFileAttachmentsController = new APFileAttachmentsController();
            APFileAttachmentsInfo objFileAttachmentsInfo = new APFileAttachmentsInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            purchaseContractTemplate.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.APFileAttachmentFileGUID))
                    return;

                entity.PurchaseContractTemplateURLDic.TryGetValue(o.APFileAttachmentID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.APFileAttachmentFileGUID = ApiClientHelper.UpdateFile(value);
                objFileAttachmentsController.UpdateObject(o);
            });
            entity.PurchaseContractTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.PurchaseContractTemplate.GridControl.RefreshDataSource();
        }

        public void ChangePurchaseContractType()
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)entity.MainObject;
            PurchaseContractParentControl.Properties.ReadOnly = false;
            PurchaseContractParentControl.Enabled = true;
            if (mainobject.APPurchaseContractType != PurchaseContractType.Appendix.ToString())
            {
                PurchaseContractParentControl.Properties.ReadOnly = true;
                PurchaseContractParentControl.Enabled = false;
            }
        }

        public void ChangeCurrency(int currencyID)
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)entity.MainObject;
            UpdateTotalAmount();
        }

        public void ChangeTaxAmount()
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)entity.MainObject;
            if (mainobject.APPurchaseContractTaxAmount == 0 || mainobject.APPurchaseContractSubTotalAmount - mainobject.APPurchaseContractDiscountAmount == 0)
            {
                mainobject.APPurchaseContractTaxPercent = 0;
            }
            else
            {
                mainobject.APPurchaseContractTaxPercent = 100 * mainobject.APPurchaseContractTaxAmount / (mainobject.APPurchaseContractSubTotalAmount - mainobject.APPurchaseContractDiscountAmount);
                mainobject.APPurchaseContractTaxPercent = Math.Round(mainobject.APPurchaseContractTaxPercent, 2, MidpointRounding.AwayFromZero);
            }
            UpdateTotalAmount();
        }

        public void ChangeTaxPercent()
        {
            UpdateTotalAmount();
        }

        public void ChangeExchangeRate(decimal value)
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)entity.MainObject;
            mainobject.APPurchaseContractSubTotalAmount = mainobject.APPurchaseContractSubTotalAmount * value;
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)entity.MainObject;
            mainobject.APPurchaseContractSubTotalAmount = Math.Round(mainobject.APPurchaseContractSubTotalAmount, 2, MidpointRounding.AwayFromZero);
            mainobject.APPurchaseContractDiscountAmount = mainobject.APPurchaseContractSubTotalAmount * mainobject.APPurchaseContractDiscountPercent / 100;
            mainobject.APPurchaseContractDiscountAmount = Math.Round(mainobject.APPurchaseContractDiscountAmount, 2, MidpointRounding.AwayFromZero);
            mainobject.APPurchaseContractTaxAmount = (mainobject.APPurchaseContractSubTotalAmount - mainobject.APPurchaseContractDiscountAmount) * mainobject.APPurchaseContractTaxPercent / 100;
            mainobject.APPurchaseContractTaxAmount = Math.Round(mainobject.APPurchaseContractTaxAmount, 2, MidpointRounding.AwayFromZero);
            mainobject.APPurchaseContractTotalAmount = mainobject.APPurchaseContractSubTotalAmount - mainobject.APPurchaseContractDiscountAmount + mainobject.APPurchaseContractTaxAmount;
            entity.UpdateMainObjectBindingSource();
        }

        public void BrowseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[PurchaseContractModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddPurchaseContractTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[PurchaseContractModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)CurrentModuleEntity.MainObject;

            if (entity.PurchaseContractTemplate.Exists(o => o.APFileAttachmentName.Equals(DocumentFileName)))
            {
                MessageBox.Show(PurchaseContractLocalizedResources.DuplicateFileName,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            APFileAttachmentsInfo objFileAttachmentsInfo = new APFileAttachmentsInfo();
            objFileAttachmentsInfo.APFileAttachmentName = DocumentFileName;
            objFileAttachmentsInfo.APFileAttachmentTableName = BOSUtil.GetTableNameFromBusinessObject(mainobject);
            objFileAttachmentsInfo.APFileAttachmentObjectID = mainobject.APPurchaseContractID;
            objFileAttachmentsInfo.APFileAttachmentObjectItemID = 0;
            objFileAttachmentsInfo.APFileAttachmentModuleName = ModuleName.PurchaseContract;
            objFileAttachmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objFileAttachmentsInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objFileAttachmentsInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.PurchaseContractTemplate.Add(objFileAttachmentsInfo);
            entity.PurchaseContractTemplate.GridControl.RefreshDataSource();
        }

        public void RemovePurchaseContractTemplateList()
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            entity.PurchaseContractTemplate.RemoveSelectedRowObjectFromList();
            entity.PurchaseContractTemplate.GridControl.RefreshDataSource();
        }

        public void DownloadDocument()
        {
            PurchaseContractEntities entity = (PurchaseContractEntities)CurrentModuleEntity;
            APFileAttachmentsInfo objFileAttachmentsInfo = entity.PurchaseContractTemplate[entity.PurchaseContractTemplate.CurrentIndex];
            if (objFileAttachmentsInfo == null)
                return;

            if (string.IsNullOrEmpty(objFileAttachmentsInfo.APFileAttachmentFileGUID))
            {
                MessageBox.Show(PurchaseContractLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objFileAttachmentsInfo.APFileAttachmentFileGUID, objFileAttachmentsInfo.APFileAttachmentName);
        }

        public override void InvalidateToolbar()
        {
            PurchaseContractEntities entity = CurrentModuleEntity as PurchaseContractEntities;
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)entity.MainObject;
            if (mainobject.APPurchaseContractID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Completed", true);
                if (mainobject.APPurchaseContractStatus == PurchaseContractStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Completed", false);
                }
            }
            base.InvalidateToolbar();
        }
        #endregion
    }
}
