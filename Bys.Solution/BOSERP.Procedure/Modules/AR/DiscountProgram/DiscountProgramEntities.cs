using System;
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using BOSCommon;
using BOSLib;
using System.Linq;
using BOSCommon.Constants;

namespace BOSERP.Modules.DiscountProgram
{
    public class DiscountProgramEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSList<ARDiscountProgramItemsInfo> DiscountProgramItemList { get; set; }

        public BOSList<ARDiscountProgramItemTargetsInfo> DiscountProgramItemTargetList{ get; set; }
        #endregion

        #region Constructor
        public DiscountProgramEntities()
            : base()
        {
            DiscountProgramItemList = new BOSList<ARDiscountProgramItemsInfo>();
            DiscountProgramItemTargetList = new BOSList<ARDiscountProgramItemTargetsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new ARDiscountProgramsInfo();
            MainObject = new ARDiscountProgramsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARDiscountProgramItemsTableName, new ARDiscountProgramItemsInfo());
            ModuleObjects.Add(TableName.ARDiscountProgramItemTargetsTableName, new ARDiscountProgramItemTargetsInfo());
        }

        public override void InitModuleObjectList()
        {
            DiscountProgramItemList.InitBOSList(this,
                                            TableName.ARDiscountProgramsTableName,
                                            TableName.ARDiscountProgramItemsTableName,
                                            BOSList<ARDiscountProgramItemsInfo>.cstRelationForeign);
            DiscountProgramItemList.ItemTableForeignKey = "FK_ARDiscountProgramID";

            DiscountProgramItemTargetList.InitBOSList(this,
                                                      TableName.ARDiscountProgramsTableName,
                                                      TableName.ARDiscountProgramItemTargetsTableName,
                                                      BOSList<ARDiscountProgramItemTargetsInfo>.cstRelationForeign);
            DiscountProgramItemTargetList.ItemTableForeignKey = "FK_ARDiscountProgramID";
        }

        public override void InitGridControlInBOSList()
        {
            DiscountProgramItemList.InitBOSListGridControl("fld_dgcARDiscountProgramItems");
            DiscountProgramItemTargetList.InitBOSListGridControl("fld_dgcARDiscountProgramItemTargets");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DiscountProgramItemList.SetDefaultListAndRefreshGridControl();
                DiscountProgramItemTargetList.SetDefaultListAndRefreshGridControl();
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
            ARDiscountProgramsInfo mainobject = (ARDiscountProgramsInfo)MainObject;
            mainobject.ARDiscountProgramStatus = DiscountProgramStatus.New.ToString();
            mainobject.ARDiscountProgramDate = BOSApp.GetCurrentServerDate();
            mainobject.ARDiscountProgramBeginDate = BOSApp.GetCurrentServerDate();
            mainobject.ARDiscountProgramEndDate = BOSApp.GetCurrentServerDate().AddDays(7);
            mainobject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainobject.ARDiscountProgramMethodType = DiscountProgramMethodType.Direct.ToString();
            mainobject.ARDiscountProgramIsVoucher = false;
            mainobject.ARDiscountProgramType = DiscountProgramType.Promotion.ToString();
            mainobject.ARDiscountProgramApplyOn = DiscountProgramApplyOn.Percent.ToString();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            DiscountProgramItemList.Invalidate(iObjectID);
            DiscountProgramItemTargetList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            DiscountProgramItemList.SaveItemObjects();
            DiscountProgramItemTargetList.SaveItemObjects();
        }

        public override void DuplicateModuleObjectList()
        {
            DiscountProgramItemList.Duplicate();
            DiscountProgramItemTargetList.Duplicate();
        }
        #endregion
    }
}
