using BOSCommon;
using System;

namespace BOSERP.Modules.CreditNote
{
    public class CreditNoteEntities : BaseTransactionEntities
    {
        #region Declare Constant
        public readonly static String strARCreditNotesObjectName = "ARCreditNotes";
        #endregion

        #region Declare all entities variables
        private ARCreditNotesInfo _aRCreditNotesObject;
        #endregion

        #region Public Properties
        public ARCreditNotesInfo ARCreditNotesObject
        {
            get
            {
                return _aRCreditNotesObject;
            }
            set
            {
                _aRCreditNotesObject = value;
            }
        }
        #endregion

        #region Constructor
        public CreditNoteEntities()
            : base()
        {
            _aRCreditNotesObject = new ARCreditNotesInfo();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = ARCreditNotesObject;
            SearchObject = new ARCreditNotesInfo();
        }
        #endregion

        #region Delete Main Object, Module Objects, Module Item Relations
        public override void Delete(int iObjectID)
        {
            ARCreditNoteItemsController objCreditNoteItemsController = new ARCreditNoteItemsController();
            objCreditNoteItemsController.DeleteByForeignColumn("FK_ARCreditNoteID", iObjectID);

            base.Delete(iObjectID);
        }
        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)MainObject;
            objCreditNotesInfo.ARCreditNoteDate = BOSApp.GetCurrentServerDate();
            objCreditNotesInfo.ARCreditNoteType = CreditNoteType.GiftVoucher.ToString();
            objCreditNotesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

        }
    }
}
