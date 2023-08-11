using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HRMailBox
{
    public class HRMailBoxEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets mail list
        /// </summary>
        public BOSList<HRMailsInfo> HRMailsList { get; set; }
        public BOSList<HRMailAttachmentsInfo> HRMailAttachmentsList { get; set; }
        #endregion

        #region Constructor
        public HRMailBoxEntities()
            : base()
        {
            HRMailsList = new BOSList<HRMailsInfo>();
            HRMailAttachmentsList = new BOSList<HRMailAttachmentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRMailsTableName, new HRMailsInfo());
            ModuleObjects.Add(TableName.HRMailAttachmentsTableName, new HRMailAttachmentsInfo());
        }

        public override void InitModuleObjectList()
        {

            HRMailsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRMailsTableName,
                                           BOSList<HRMailsInfo>.cstRelationNone);
            HRMailAttachmentsList.InitBOSList(this,
                                                TableName.HRMailsTableName,
                                                TableName.HRMailAttachmentsTableName,
                                                BOSList<HRMailAttachmentsInfo>.cstRelationForeign
                                                );
            HRMailAttachmentsList.ItemTableForeignKey = "FK_HRMailID";
        }

        public override void InitGridControlInBOSList()
        {
            HRMailsList.InitBOSListGridControl();
            HRMailAttachmentsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRMailsList.SetDefaultListAndRefreshGridControl();
                HRMailAttachmentsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {

        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {

        }
        #endregion

        /// <summary>
        /// Save Email to Database
        /// </summary>
        /// <returns></returns>
        public int SaveEmail()
        {
            HRMailsInfo objMailsInfo = (HRMailsInfo)ModuleObjects[TableName.HRMailsTableName];
            HRMailsList.AddObjectToList();
            HRMailsList.SaveItemObjects();
            objMailsInfo = HRMailsList[HRMailsList.Count - 1];
            return objMailsInfo.HRMailID;
        }

        /// <summary>
        /// Save attachment of mail into Database
        /// </summary>
        /// <returns></returns>
        public string SaveAttachment()
        {
            HRMailAttachmentsInfo objMailAttachmentsInfo = (HRMailAttachmentsInfo)ModuleObjects[TableName.HRMailAttachmentsTableName];
            HRMailAttachmentsList.AddObjectToList();
            HRMailAttachmentsList.SaveItemObjects();
            objMailAttachmentsInfo = HRMailAttachmentsList[HRMailAttachmentsList.Count - 1];
            return (objMailAttachmentsInfo.HRMailAttachmentID + objMailAttachmentsInfo.HRMailAttachmentName).ToString();
        }

    }
}
