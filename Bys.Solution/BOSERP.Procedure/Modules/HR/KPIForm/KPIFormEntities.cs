using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.KPIForm
{
    public class KPIFormEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSItemsEntityList<HRKPIFormItemsInfo> KPIFormItemsList { get; set; }
        #endregion

        #region Constructor
        public KPIFormEntities()
            : base()
        {
            KPIFormItemsList = new BOSItemsEntityList<HRKPIFormItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new HRKPIFormsInfo();
            MainObject = new HRKPIFormsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRKPIFormItemsTableName, new HRKPIFormItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            KPIFormItemsList.InitBOSList(this,
                                            TableName.HRKPIFormsTableName,
                                            TableName.HRKPIFormItemsTableName,
                                            BOSList<HRKPIFormItemsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            KPIFormItemsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                KPIFormItemsList.SetDefaultListAndRefreshGridControl();
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

            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)MainObject;
            objKPIFormsInfo.HRKPIFormDate = BOSApp.GetCurrentServerDate();
            objKPIFormsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objKPIFormsInfo.HRKPIFormStatus = KPIFormStatus.New.ToString();

            UpdateMainObjectBindingSource();
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            KPIFormItemsList.Invalidate(iObjectID);
        }

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            KPIFormItemsList.SaveItemObjects();
        }
        #endregion 
    }
}
