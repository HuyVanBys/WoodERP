using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.PaintProcessConfig
{
    class PaintProcessConfigEntities : BaseTransactionEntities
    {
        #region Public Properties

        ///// <summary>
        ///// Gets or sets the Process item list
        ///// </summary>
        public BOSList<MMPaintProcessConfigItemsInfo> PaintProcessConfigItemsList { get; set; }

        #endregion

        #region Contructors
        public PaintProcessConfigEntities()
            : base()
        {
            PaintProcessConfigItemsList = new BOSList<MMPaintProcessConfigItemsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMPaintProcessConfigsInfo();
            SearchObject = new MMPaintProcessConfigsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMPaintProcessConfigsTableName, new MMPaintProcessConfigsInfo());
        }

        public override void InitModuleObjectList()
        {
            PaintProcessConfigItemsList.InitBOSList(
                                        this,
                                        TableName.MMPaintProcessConfigsTableName,
                                        TableName.MMPaintProcessConfigItemsTableName,
                                        BOSList<MMProcessProductsInfo>.cstRelationForeign);
            PaintProcessConfigItemsList.ItemTableForeignKey = "FK_MMPaintProcessConfigID";
        }

        public override void InitGridControlInBOSList()
        {
            PaintProcessConfigItemsList.InitBOSListGridControl("fld_dgcMMPaintProcessConfigItems");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMPaintProcessConfigsInfo objProcesssInfo = (MMPaintProcessConfigsInfo)MainObject;
            objProcesssInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objProcesssInfo.MMPaintProcessConfigDate = BOSApp.GetCurrentServerDate();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PaintProcessConfigItemsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities

        public override void InvalidateModuleObjects(int iObjectID)
        {
            PaintProcessConfigItemsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            PaintProcessConfigItemsList.SaveItemObjects();
        }
        public void ApproveProcess()
        {
            SetPropertyChangeEventLock(false);
            //Update the this's status
            MMPaintProcessConfigsInfo objProcesssInfo = (MMPaintProcessConfigsInfo)MainObject;
            objProcesssInfo.MMPaintProcessConfigStatus = BatchProductPlanStatus.Approved.ToString();
            UpdateMainObject();
        }

        #endregion Override BaseTransactionEntities
    }
}
