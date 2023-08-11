using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.ReceptionEquipment
{
    public class ReceptionEquipmentEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ARReceptionItemsInfo> ReceptionItemsList { get; set; }

        #endregion

        #region Constructor
        public ReceptionEquipmentEntities()
            : base()
        {
            ReceptionItemsList = new BOSList<ARReceptionItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARReceptionsInfo();
            SearchObject = new ARReceptionsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARReceptionItemsTableName, new ARReceptionItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ReceptionItemsList.InitBOSList(this,
                                            TableName.ARReceptionsTableName,
                                            TableName.ARReceptionItemsTableName,
                                            BOSList<ARReceptionItemsInfo>.cstRelationForeign);
            ReceptionItemsList.ItemTableForeignKey = "FK_ARReceptionID";
        }

        public override void InitGridControlInBOSList()
        {
            ReceptionItemsList.InitBOSListGridControl(ReceptionEquipmentModule.ARReceptionItemsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceptionItemsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARReceptionsInfo objReceptionsInfo = (ARReceptionsInfo)MainObject;
            objReceptionsInfo.ARReceptionDate = BOSApp.GetCurrentServerDate();
            objReceptionsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReceptionItemsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ReceptionItemsList.SaveItemObjects();
        }

        public void GenerateEntitiesFromAllocationItems(List<ARAllocationItemsInfo> allocationItems)
        {
            ARAllocationsController objAllocationsController = new ARAllocationsController();
            ARAllocationsInfo objAllocationsInfo = (ARAllocationsInfo)objAllocationsController.GetObjectByID(allocationItems[0].FK_ARAllocationID);
            ARReceptionsInfo objReceptionsInfo = (ARReceptionsInfo)MainObject;
            objReceptionsInfo.FK_ARDeliveryPlanID = objAllocationsInfo.FK_ARDeliveryPlanID;
            objReceptionsInfo.FK_HRDriverEmployeeID = objAllocationsInfo.FK_HRDriverEmployeeID;
            objReceptionsInfo.FK_HRReturnEmployeeID = objAllocationsInfo.FK_HRProposedEmployeeID;
            objReceptionsInfo.FK_ARAllocationID = objAllocationsInfo.ARAllocationID;
            UpdateMainObjectBindingSource();
            allocationItems.ForEach(o =>
                {
                    for (int i = 0; i < o.ARAllocationItemQty; i++)
                        ReceptionItemsList.Add(ToReceptionItem(o));
                });
        }

        public ARReceptionItemsInfo ToReceptionItem(ARAllocationItemsInfo objARAllocationItemsInfo)
        {
            return new ARReceptionItemsInfo()
            {
                ARReceptionItemNo = objARAllocationItemsInfo.ARAllocationItemNo,
                ARReceptionItemName = objARAllocationItemsInfo.ARAllocationItemName,
                ARReceptionItemDesc = objARAllocationItemsInfo.ARAllocationItemDesc,
                ARReceptionItemQty = objARAllocationItemsInfo.ARAllocationItemQty >= 1 ? 1 : 0,
                FK_ARSaleOrderID = objARAllocationItemsInfo.FK_ARSaleOrderID,
                FK_ICProductID = objARAllocationItemsInfo.FK_ICProductID,
                FK_ARAllocationItemID = objARAllocationItemsInfo.ARAllocationItemID,
                FK_ACAssetID = objARAllocationItemsInfo.FK_ACAssetID,
                FK_ICProductIdentifiedEquipmentID = objARAllocationItemsInfo.FK_ICProductIdentifiedEquipmentID,
                ARReceptionItemComment = objARAllocationItemsInfo.ARAllocationItemComment
            };
        }

        public override bool CompleteTransaction()
        {
            ARReceptionsInfo objReceptionsInfo = (ARReceptionsInfo)MainObject;
            objReceptionsInfo.ARReceptionStatus = ReceptionStatus.Complete.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }
    }
}
