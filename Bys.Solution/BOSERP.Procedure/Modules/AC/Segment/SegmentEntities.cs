using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.Segment
{
    public class SegmentEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACSegmentObjectControlsInfo> ACSegmentObjectControlsList { get; set; }
        public BOSList<ACSegmentDocumentControlsInfo> ACSegmentDocumentControlsList { get; set; }
        #endregion

        #region Constructor
        public SegmentEntities()
            : base()
        {
            ACSegmentObjectControlsList = new BOSList<ACSegmentObjectControlsInfo>();
            ACSegmentDocumentControlsList = new BOSList<ACSegmentDocumentControlsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACSegmentsInfo();
            SearchObject = new ACSegmentsInfo();
        }

        public override void InitModuleObjectList()
        {
            ACSegmentObjectControlsList.InitBOSList(
                                              this,
                                              TableName.ACSegmentsTableName,
                                              TableName.ACSegmentObjectControlsTableName,
                                              BOSList<ACSegmentObjectControlsInfo>.cstRelationForeign);
            ACSegmentObjectControlsList.ItemTableForeignKey = "FK_ACSegmentID";

            ACSegmentDocumentControlsList.InitBOSList(
                                             this,
                                             TableName.ACSegmentsTableName,
                                             TableName.ACSegmentDocumentControlsTableName,
                                             BOSList<ACSegmentDocumentControlsInfo>.cstRelationForeign);
            ACSegmentDocumentControlsList.ItemTableForeignKey = "FK_ACSegmentID";
        }

        public override void InitGridControlInBOSList()
        {
            ACSegmentObjectControlsList.InitBOSListGridControl();
            ACSegmentDocumentControlsList.InitBOSListGridControl();

        }
        #endregion

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACSegmentObjectControlsList.SetDefaultListAndRefreshGridControl();
                ACSegmentDocumentControlsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACSegmentObjectControlsList.Invalidate(iObjectID);
            ACSegmentDocumentControlsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ACSegmentObjectControlsList.SaveItemObjects();
            ACSegmentDocumentControlsList.SaveItemObjects();
        }
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACSegmentDocumentControlsTableName, new ACSegmentDocumentControlsInfo());
            ModuleObjects.Add(TableName.ACSegmentObjectControlsTableName, new ACSegmentObjectControlsInfo());
        }
    }
}
