using BOSComponent;
using BOSERP.Modules.SaleOrder;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace BOSERP.Modules.BugManagement
{
    public class BugManagementModule : BaseTransactionModule
    {
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<BRBranchsInfo> BranchList;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        private string DocumentFileName = string.Empty;
        public const string ButtonHandleControlName = "fld_btnHandle";
        public const string BugManagementTemplateGridControlName = "fld_dgcHRBugManagementTemplates";
        private const string SubFolder = "BugManagement";
        private const int MaxTemplateQty = 5;
        public BOSButton ButtonHandle;
        private BOSGridControl BugManagementTemplateGridControl;

        public BugManagementModule()
        {
            Name = "BugManagement";
            CurrentModuleEntity = new BugManagementEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            BugManagementTemplateGridControl = (BOSGridControl)Controls[BugManagementModule.BugManagementTemplateGridControlName];
            ButtonHandle = (BOSButton)Controls[BugManagementModule.ButtonHandleControlName];
        }
        public override int ActionSave()
        {
            BugManagementEntities entity = (BugManagementEntities)CurrentModuleEntity;
            HRBugManagementsInfo mainObject = (HRBugManagementsInfo)entity.MainObject;
            if (mainObject.FK_HRErrorTypeID == 0)
            {
                MessageBox.Show("Vui lòng chọn loại lỗi!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return base.ActionSave();
        }
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            BugManagementEntities entity = (BugManagementEntities)CurrentModuleEntity;
            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ButtonHandle.Enabled = false;
            if (objBugManagementsInfo.HRBugManagementID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton("Edit", true);
                if (objBugManagementsInfo.HRBugManagementStatus == "New")
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                }
                else
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
            }
            if (objBugManagementsInfo.HRBugManagementStatus == "Approved")
            {
                ParentScreen.SetEnableOfToolbarButton("Edit", false);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ButtonHandle.Enabled = true;
            }
            if (objBugManagementsInfo.HRBugManagementStatus == "Processed")
            {
                ButtonHandle.Enabled = false;
            }

        }
        public void ApprovedBugManagement()
        {
            base.ActionComplete();
            InvalidateToolbar();
        }

        public void UpdateHandleWaitQty()
        {
            BugManagementEntities entity = (BugManagementEntities)CurrentModuleEntity;
            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)entity.MainObject;
            objBugManagementsInfo.HRBugManagementHandleWaitQty = objBugManagementsInfo.HRBugManagementDetailQty;
            entity.UpdateMainObjectBindingSource();
        }

        public void HandleBug()
        {
            BugManagementEntities entity = (BugManagementEntities)CurrentModuleEntity;
            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)entity.MainObject;

            bool result = false;
            if (objBugManagementsInfo.HRBugManagementHandleType == "LocalHandle")
            {
                result = HandleBugLocalHandle();
            }
            else if (objBugManagementsInfo.HRBugManagementHandleType == "Rollback")
            {
                result = HandleBugRollback();
            }
            else if (objBugManagementsInfo.HRBugManagementHandleType == "NhapBTPTD")
            {
                result = HandleBugUsedReceiptType();
            }
            if (result)
            {
                objBugManagementsInfo.HRBugManagementStatus = "Processed";
                HRBugManagementsController objBugManagementsController = new HRBugManagementsController();
                objBugManagementsController.UpdateObject(objBugManagementsInfo);
                entity.UpdateMainObjectBindingSource();
                InvalidateToolbar();
            }

        }
        public bool HandleBugUsedReceiptType()
        {
            bool result = false;
            //can clear lại giai pháp
            MessageBox.Show("Chờ clear lại giai pháp", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public bool HandleBugLocalHandle()
        {
            bool result = true;
            MessageBox.Show("Chờ clear lại giai pháp", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public bool HandleBugRollback()
        {
            bool result = false;
            MessageBox.Show("Chờ clear lại giai pháp", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public void BrowseFile()
        {
            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)CurrentModuleEntity.MainObject;
            if (objBugManagementsInfo.HRBugManagementID <= 0)
            {
                MessageBox.Show("Vui lòng lưu chứng từ trước khi tiếp tục!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "Picture files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp | All Files(*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[SaleOrderModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void DeleteFile()
        {
            GridView gridView = (GridView)BugManagementTemplateGridControl.MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (MessageBox.Show(SaleOrderLocalizedResources.ConfirmDeleteFile, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)CurrentModuleEntity.MainObject;
                    string objectID = objBugManagementsInfo.HRBugManagementID.ToString();
                    HRBugManagementTemplatesInfo objBugManagementTemplatesInfo = (HRBugManagementTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    string TemplateName = string.Empty;
                    TemplateName += objectID + "_" + objBugManagementTemplatesInfo.HRBugManagementTemplateName.ToString();
                    System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    BOSApp.DeleteFile(TemplateName, SubFolder);
                    BugManagementEntities entity = (BugManagementEntities)CurrentModuleEntity;
                    entity.BugManagementTemplatesList.Remove(objBugManagementTemplatesInfo);
                    entity.BugManagementTemplatesList.SaveItemObjects();
                    BugManagementTemplateGridControl.RefreshDataSource();
                }
            }
        }

        public void ViewFile()
        {
            try
            {
                GridView gridView = (GridView)BugManagementTemplateGridControl.MainView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)CurrentModuleEntity.MainObject;
                    string objectID = objBugManagementsInfo.HRBugManagementID.ToString();
                    HRBugManagementTemplatesInfo objBugManagementTemplatesInfo = (HRBugManagementTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    string proposalTemplateName = string.Empty;
                    proposalTemplateName += objectID + "_" + objBugManagementTemplatesInfo.HRBugManagementTemplateName.ToString();
                    System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string localPath = BOSApp.DownloadFileFTP(proposalTemplateName, SubFolder);
                    if (!string.IsNullOrEmpty(localPath))
                    {
                        System.Diagnostics.Process.Start(localPath);
                    }
                }
            }
            catch
            {
                MessageBox.Show(SaleOrderLocalizedResources.SelectTemplateToView, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void SaveBugManagementDocumentOnServer()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[SaleOrderModule.FilePathTextBoxName];
            if (!String.IsNullOrEmpty(filePathTextBox.Text))
            {
                bool flag = true;
                HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)CurrentModuleEntity.MainObject;
                if (objBugManagementsInfo.HRBugManagementID <= 0)
                {
                    MessageBox.Show("Vui lòng lưu chứng từ trước khi tiếp tục!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                HRBugManagementTemplatesController objBugManagementTemplatesController = new HRBugManagementTemplatesController();
                List<HRBugManagementTemplatesInfo> BugManagementTemplatesList = objBugManagementTemplatesController.GetBugManagementTemplatesListByBugManagementID(objBugManagementsInfo.HRBugManagementID);
                if (BugManagementTemplatesList.Count >= MaxTemplateQty)
                {
                    MessageBox.Show("Số lượng ảnh được tải lên hiện đang vượt quá số lượng cho phép! \n Tối đa " + MaxTemplateQty.ToString() + " ảnh cho mỗi chứng từ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string newFileNameDisplay = objBugManagementsInfo.HRBugManagementNo.ToString() + "_" + (BugManagementTemplatesList.Count + 1).ToString();
                string objectID = objBugManagementsInfo.HRBugManagementID.ToString();
                string newFileName = objBugManagementsInfo.HRBugManagementID.ToString() + "_" + DocumentFileName;
                foreach (HRBugManagementTemplatesInfo objBugManagementTemplatesInfo in ((BugManagementEntities)CurrentModuleEntity).BugManagementTemplatesList)
                {
                    if (objBugManagementTemplatesInfo.HRBugManagementTemplateName == DocumentFileName)
                    {

                        if (MessageBox.Show(SaleOrderLocalizedResources.ConfirmOverrideFile, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (BOSApp.UploadFileFTP(objBugManagementsInfo.HRBugManagementID.ToString(), filePathTextBox.Text.Trim(), SubFolder))
                            {
                                MessageBox.Show(SaleOrderLocalizedResources.UploadFileSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                InvalidateTemplateGridControl();
                            }
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    if (BOSApp.UploadFileFTP(objBugManagementsInfo.HRBugManagementID.ToString(), filePathTextBox.Text.Trim(), SubFolder))
                    {
                        BugManagementEntities entity = (BugManagementEntities)CurrentModuleEntity;
                        HRBugManagementTemplatesInfo objBugManagementTemplatesInfo = new HRBugManagementTemplatesInfo();
                        objBugManagementTemplatesInfo.FK_HREmployeeID = objBugManagementsInfo.FK_HREmployeeID;
                        objBugManagementTemplatesInfo.HRBugManagementTemplateName = newFileName;
                        objBugManagementTemplatesInfo.HRBugManagementTemplateNameDisplay = newFileNameDisplay;
                        entity.SaveTemplate(objBugManagementTemplatesInfo);
                        entity.BugManagementTemplatesList.SetDefaultListAndRefreshGridControl();
                        entity.BugManagementTemplatesList.GridControl.RefreshDataSource();
                        MessageBox.Show(SaleOrderLocalizedResources.UploadFileSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InvalidateTemplateGridControl();
                    }
                }
            }
        }

        public void InvalidateTemplateGridControl()
        {
            BugManagementEntities entity = (BugManagementEntities)CurrentModuleEntity;
            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)CurrentModuleEntity.MainObject;
            entity.BugManagementTemplatesList.Invalidate(objBugManagementsInfo.HRBugManagementID);
            foreach (HRBugManagementTemplatesInfo objBugManagementTemplatesInfo in entity.BugManagementTemplatesList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                string BugManagementID = objBugManagementTemplatesInfo.FK_HRBugManagementID.ToString();
                objBugManagementTemplatesInfo.HRBugManagementTemplateName = objBugManagementTemplatesInfo.HRBugManagementTemplateName.Replace(BugManagementID + "_", "");
            }
            BugManagementTemplateGridControl.RefreshDataSource();
        }
    }
}
