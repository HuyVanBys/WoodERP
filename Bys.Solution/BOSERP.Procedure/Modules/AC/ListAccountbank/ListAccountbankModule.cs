using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ListAccountBank
{
    public class ListAccountBankModule : BaseTransactionModule
    {
        #region Constant
        #endregion

        #region Constructor
        public ListAccountBankModule()
        {
            Name = ModuleName.ListAccountBank;
            CurrentModuleEntity = new ListAccountBankEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        #endregion

        #region Action
        public override int ActionSave()
        {
            ListAccountBankEntities entity = (ListAccountBankEntities)CurrentModuleEntity;
            ACListAccountBanksInfo mainObject = (ACListAccountBanksInfo)entity.MainObject;
            if (mainObject.ACListAccountBankAccountHolderIDNumber == string.Empty && mainObject.ACListAccountBankAccount == string.Empty)
            {
                MessageBox.Show("CMND và số tài khoản, chỉ được phép bỏ trống 1 trong 2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainObject.ACListAccountBankAccount == string.Empty && mainObject.ACListAccountBankAccountHolderIDNumber.Length < 9)
            {
                MessageBox.Show("Số CMND không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainObject.ACListAccountBankName == string.Empty
                || mainObject.FK_ACObjectID == 0
                || mainObject.ACListAccountBankAccountHolder == string.Empty)
            {
                MessageBox.Show("Các thông tin: Ngân hàng, Đối tượng, người thụ hưởng không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return base.ActionSave();
        }

        public void ActionEditAfterCompleting()
        {
            ActionEdit();
            ParentScreen.SetEnableOfToolbarButton("EditAfterCompleting", false);
        }
        #endregion

        #region Invalidate
        public void ChangeObject(string objectAccessKey)
        {
            ListAccountBankEntities entity = (ListAccountBankEntities)CurrentModuleEntity;
            ACListAccountBanksInfo mainObject = (ACListAccountBanksInfo)entity.MainObject;
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                mainObject.ACObjectAccessKey = objectAccessKey;
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
                objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                if (objObjectsInfo != null)
                {
                    mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                    mainObject.ACObjectType = objObjectsInfo.ACObjectType;
                    mainObject.ACListAccountBankAccountHolder = objObjectsInfo.ACObjectName;
                    mainObject.ACListAccountBankObjectAddress = objObjectsInfo.ACObjectContactAddress;
                }
            }
            else
            {
                mainObject.FK_ACObjectID = 0;
                mainObject.ACObjectType = string.Empty;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ChangeBank()
        {
            ACListAccountBanksInfo mainObject = (ACListAccountBanksInfo)CurrentModuleEntity.MainObject;
            GEBanksController objBanksController = new GEBanksController();
            GEBanksInfo objBank = (GEBanksInfo)objBanksController.GetObjectByID(mainObject.FK_GEBankID);
            if (objBank != null)
            {
                mainObject.ACListAccountBankName = objBank.GEBankName;
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ACListAccountBanksInfo objACListAccountBanksInfo = (ACListAccountBanksInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if(objACListAccountBanksInfo.ACListAccountBankID > 0)
            {
                if (objACListAccountBanksInfo.ACListAccountBankStatus == ListAccountBankStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                }
                else if (objACListAccountBanksInfo.ACListAccountBankStatus == ListAccountBankStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACListAccountBanksController objListAccoutBanksController = new ACListAccountBanksController();
            DataSet ds = objListAccoutBanksController.GetListAcctountBanks();
            return ds;
        }
        #endregion

        #region Mở/ Xóa chứng từ
        public override bool ActionCancelComplete()
        {
            ACListAccountBanksInfo mainObject = (ACListAccountBanksInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ACListAccountBankID > 0)
            {
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                mainObject.ACListAccountBankStatus = ListAccountBankStatus.New.ToString();
                CurrentModuleEntity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                base.ActionCancelComplete();
                InvalidateToolbar();
            }
            return true;
        }

        public override void ActionDelete()
        {
            ACListAccountBanksInfo mainObject = (ACListAccountBanksInfo)CurrentModuleEntity.MainObject.Clone();
            if (mainObject.ACListAccountBankID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                base.ActionDelete();
            }
        }

        private bool CheckRelativeDocument()
        {
            ACListAccountBanksInfo mainObject = (ACListAccountBanksInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByListAccountBankID(mainObject.ACListAccountBankID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

    }
}
