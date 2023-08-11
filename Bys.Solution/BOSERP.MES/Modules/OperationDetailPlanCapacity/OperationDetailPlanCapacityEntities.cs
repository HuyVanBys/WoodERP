using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    public class OperationDetailPlanCapacityEntities : ERPModuleEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList { get; set; }
        public BOSList<MMOperationDetailPlanCapacityItemsInfo> OperationDetailPlanCapacityItemsList { get; set; }

        #endregion
        #region Contructors
        public OperationDetailPlanCapacityEntities()
            : base()
        {
            OperationDetailPlanCapacityItemsList = new BOSList<MMOperationDetailPlanCapacityItemsInfo>();

            OperationDetailPlanItemChildsList = new BOSList<MMOperationDetailPlanItemChildsInfo>();

        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMOperationDetailPlanCapacitysInfo();
            //SearchObject = new MMOperationDetailPlanCapacitysInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMOperationDetailPlanItemsTableName, new MMOperationDetailPlanCapacityItemsInfo());
            ModuleObjects.Add(TableName.MMOperationDetailPlanCapacityItemsTableName, new MMOperationDetailPlanCapacityItemsInfo());

        }

        public override void InitModuleObjectList()
        {
            OperationDetailPlanCapacityItemsList.InitBOSList(this,
                                                    String.Empty,
                                                    TableName.MMOperationDetailPlanCapacityItemsTableName,
                                                    BOSList<MMOperationDetailPlanCapacityItemsInfo>.cstRelationNone);


            OperationDetailPlanItemChildsList.InitBOSList(
                                            this,
                                            null,
                                            TableName.MMOperationDetailPlanItemChildsTableName,
                                            BOSList<MMOperationDetailPlanItemChildsInfo>.cstRelationNone);


        }

        public override void InitGridControlInBOSList()
        {
            OperationDetailPlanCapacityItemsList.InitBOSListGridControl(OperationDetailPlanCapacityModule.MMOperationDetailPlanCapacityItemsGridControlName);
            OperationDetailPlanItemChildsList.InitBOSListGridControl("fld_dgcMMOperationDetailPlanItemChildsGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                OperationDetailPlanCapacityItemsList.SetDefaultListAndRefreshGridControl();
                OperationDetailPlanItemChildsList.SetDefaultListAndRefreshGridControl();
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
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            MMOperationDetailPlanCapacityItemsController objCapacityItemsController = new MMOperationDetailPlanCapacityItemsController();
            List<MMOperationDetailPlanCapacityItemsInfo> ListItemCapacity = objCapacityItemsController.GetOperationDetailPlanCapacityItemBySomeCriteria(
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                fromDate,
                toDate,
                null);

            OperationDetailPlanCapacityItemsList.Invalidate(ListItemCapacity);
        }
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            MMOperationDetailPlanCapacitysInfo objOperationDetailPlanCapacitysInfo = (MMOperationDetailPlanCapacitysInfo)MainObject;
            OperationDetailPlanCapacityItemsList.SaveItemObjects();
        }
        #endregion Override BaseTransactionEntities

        #region Public methods
        #endregion Public methods
    }
}
