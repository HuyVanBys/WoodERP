using System;

namespace BOSERP.Modules.EndingAllocationDeclaration
{
    public class EndingAllocationDeclarationEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACEndingAllocationDeclarationItemsInfo> ACEndingAllocationDeclarationItemsList { get; set; }
        public BOSList<ACEndingAllocationDeclarationItemReceivesInfo> ACEndingAllocationDeclarationItemReceivesList { get; set; }
        #endregion

        #region Constructor
        public EndingAllocationDeclarationEntities()
            : base()
        {
            ACEndingAllocationDeclarationItemsList = new BOSList<ACEndingAllocationDeclarationItemsInfo>();
            ACEndingAllocationDeclarationItemReceivesList = new BOSList<ACEndingAllocationDeclarationItemReceivesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACEndingAllocationDeclarationsInfo();
            SearchObject = new ACEndingAllocationDeclarationsInfo();
        }

        public override void InitModuleObjectList()
        {
            ACEndingAllocationDeclarationItemsList.InitBOSList(
                                              this,
                                              "ACEndingAllocationDeclarations",
                                              "ACEndingAllocationDeclarationItems",
                                              BOSList<ACEndingAllocationDeclarationItemsInfo>.cstRelationForeign);
            ACEndingAllocationDeclarationItemsList.ItemTableForeignKey = "FK_ACEndingAllocationDeclarationID";


            ACEndingAllocationDeclarationItemReceivesList.InitBOSList(
                                              this,
                                              "ACEndingAllocationDeclarations",
                                              "ACEndingAllocationDeclarationItemReceives",
                                              BOSList<ACEndingAllocationDeclarationItemReceivesInfo>.cstRelationForeign);
            ACEndingAllocationDeclarationItemReceivesList.ItemTableForeignKey = "FK_ACEndingAllocationDeclarationID";

        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ACEndingAllocationDeclarationItemsList.InitBOSListGridControl();
            ACEndingAllocationDeclarationItemReceivesList.InitBOSListGridControl();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACEndingAllocationDeclarationItemsList.SetDefaultListAndRefreshGridControl();
                ACEndingAllocationDeclarationItemReceivesList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACEndingAllocationDeclarationItemsList.Invalidate(iObjectID);
            ACEndingAllocationDeclarationItemReceivesList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ACEndingAllocationDeclarationItemsList.SaveItemObjects();
            ACEndingAllocationDeclarationItemReceivesList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACEndingAllocationDeclarationsInfo EndingAllocationDeclarationsInfo = (ACEndingAllocationDeclarationsInfo)MainObject;

            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ACEndingAllocationDeclarationItems", new ACEndingAllocationDeclarationItemsInfo());
            ModuleObjects.Add("ACEndingAllocationDeclarationItemReceives", new ACEndingAllocationDeclarationItemReceivesInfo());
        }
    }
}
