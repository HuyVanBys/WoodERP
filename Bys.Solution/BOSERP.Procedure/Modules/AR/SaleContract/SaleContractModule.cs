using BOSCommon;
using BOSComponent;
using BOSERP.Utilities;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleContract
{
    public class SaleContractModule : BaseModuleERP
    {
        #region extra Properties
        public const string FilePathTextBoxName = "fld_txtFilePath";
        private string DocumentFileName = string.Empty;

        public const string ARSaleOrderGridControlName = "fld_dgcARSaleOrders";
        #endregion

        public SaleContractModule()
        {
            Name = "SaleContract";
            CurrentModuleEntity = new SaleContractEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();


        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARSaleContractsController objSaleContractsController = new ARSaleContractsController();
            ARSaleContractsInfo searchObject = (ARSaleContractsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = new DataSet();
            ds = objSaleContractsController.GetSaleContractList(
                                                         searchObject.ARSaleContractNo,
                                                        searchObject.ACObjectAccessKey,
                                                        searchObject.FK_HREmployeeID,
                                                        searchObject.ARSaleContractType,
                                                        searchObject.SaleContractDateFrom,
                                                        searchObject.SaleContractDateTo,
                                                        searchObject.FK_BRBranchID);
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public void UpdateTotalAmout()
        {
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            ARSaleContractsInfo mainObject = (ARSaleContractsInfo)entity.MainObject;
            if (mainObject.ARSaleContractSubTotalAmount == 0)
                return;
            mainObject.ARSaleContractDiscountAmount = mainObject.ARSaleContractSubTotalAmount * mainObject.ARSaleContractDiscountPercent / 100;
            mainObject.ARSaleContractTotalAmount = mainObject.ARSaleContractSubTotalAmount + mainObject.ARSaleContractDiscountAmount;
            mainObject.ARSaleContractGuaranteeAmount = mainObject.ARSaleContractTotalAmount * mainObject.ARSaleContractGuaranteePercent / 100;
            mainObject.ARSaleContractAnswerableAmount = mainObject.ARSaleContractTotalAmount * mainObject.ARSaleContractAnswerablePercent / 100;
            entity.UpdateMainObjectBindingSource();
        }

        public void UpdateDiscountPercent()
        {
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            ARSaleContractsInfo mainObject = (ARSaleContractsInfo)entity.MainObject;
            if (mainObject.ARSaleContractSubTotalAmount == 0)
                return;
            mainObject.ARSaleContractDiscountPercent = mainObject.ARSaleContractDiscountAmount / mainObject.ARSaleContractSubTotalAmount * 100;
            UpdateTotalAmout();
            entity.UpdateMainObjectBindingSource();
        }

        public void UpdateGuaranteeAndAnswerablePercent()
        {
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            ARSaleContractsInfo mainObject = (ARSaleContractsInfo)entity.MainObject;
            if (mainObject.ARSaleContractTotalAmount == 0)
                return;
            mainObject.ARSaleContractGuaranteePercent = mainObject.ARSaleContractGuaranteeAmount / mainObject.ARSaleContractTotalAmount * 100;
            mainObject.ARSaleContractAnswerablePercent = mainObject.ARSaleContractAnswerableAmount / mainObject.ARSaleContractTotalAmount * 100;
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeObject(string objectAccessKey)
        {
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            ARSaleContractsInfo mainObject = (ARSaleContractsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                mainObject.ARObjectType = objObjectsInfo.ACObjectType;
                mainObject.ARObjectName = objObjectsInfo.ACObjectName;
            }

            entity.UpdateMainObjectBindingSource();
        }

        public override int ActionSave()
        {
            int saleContractID = 0;
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            ARSaleContractsInfo mainObject = (ARSaleContractsInfo)entity.MainObject;
            if (mainObject.ARSaleContractType == SaleContractType.ContractAddendum.ToString())
                if (mainObject.ARSaleContractParentID == 0)
                {
                    MessageBox.Show(SaleContractLocalizedResources.SaleContractOriginalIsNull, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            saleContractID = base.ActionSave();
            if (saleContractID > 0)
                SaveSaleContractFile();
            return saleContractID;
        }

        public void DownloadDocument()
        {
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            ARSaleContractTemplatesInfo objSaleContractTemplatesInfo = entity.SaleContractTemplatesList[entity.SaleContractTemplatesList.CurrentIndex];
            if (objSaleContractTemplatesInfo == null)
                return;

            if (string.IsNullOrEmpty(objSaleContractTemplatesInfo.ARSaleContractTemplateFileGUID))
            {
                MessageBox.Show(SaleOrderLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objSaleContractTemplatesInfo.ARSaleContractTemplateFileGUID, objSaleContractTemplatesInfo.ARSaleContractTemplateName);
        }

        public void RemoveSaleContractTemplateList()
        {
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            entity.SaleContractTemplatesList.RemoveSelectedRowObjectFromList();
            entity.SaleContractTemplatesList.GridControl.RefreshDataSource();
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
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[SaleContractModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddSaleContractTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[SaleContractModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            ARSaleContractsInfo objSaleContractsInfo = (ARSaleContractsInfo)entity.MainObject;
            if (entity.SaleContractTemplatesList.Exists(o => o.ARSaleContractTemplateName.Equals(DocumentFileName)))
            {
                MessageBox.Show(SaleOrderLocalizedResources.DuplicateFileName,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            ARSaleContractTemplatesInfo objSaleContractTemplatesInfo = new ARSaleContractTemplatesInfo();
            objSaleContractTemplatesInfo.ARSaleContractTemplateName = DocumentFileName;
            objSaleContractTemplatesInfo.FK_ARSaleContractID = objSaleContractsInfo.ARSaleContractID;
            objSaleContractTemplatesInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objSaleContractTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
            objSaleContractTemplatesInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objSaleContractTemplatesInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.SaleContractTemplatesList.Add(objSaleContractTemplatesInfo);
            entity.SaleContractTemplatesList.GridControl.RefreshDataSource();
        }

        public void SaveSaleContractFile()
        {
            SaleContractEntities entity = (SaleContractEntities)CurrentModuleEntity;
            List<ARSaleContractTemplatesInfo> SaleContractTemplatesList = entity.SaleContractTemplatesList.ToList();

            ARSaleContractTemplatesController objSaleContractTemplatesController = new ARSaleContractTemplatesController();
            ARSaleContractTemplatesInfo objSaleContractTemplatesInfo = new ARSaleContractTemplatesInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            SaleContractTemplatesList.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.ARSaleContractTemplateFileGUID))
                    return;

                entity.SaleContractTemplateURLDic.TryGetValue(o.ARSaleContractTemplateID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.ARSaleContractTemplateFileGUID = ApiClientHelper.UpdateFile(value);
                objSaleContractTemplatesController.UpdateObject(o);
            });
            entity.SaleContractTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.SaleContractTemplatesList.GridControl.RefreshDataSource();
        }
    }
}
