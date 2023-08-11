namespace BOSERP.Modules.Alternative
{
    public class AlternativeEntities : ERPModuleEntities
    {
        #region Declare all entities variables


        #endregion

        #region Public Properties

        public BOSList<ICProductAlternativesInfo> ProductAlternativeList { get; set; }
        public BOSList<ICProductAlternativesInfo> MaterialAlternativeList { get; set; }
        public BOSList<ICProductsInfo> ProductList { get; set; }
        public BOSList<ICProductsInfo> MaterialList { get; set; }

        #endregion

        #region Constructor
        public AlternativeEntities()
            : base()
        {
            ProductAlternativeList = new BOSList<ICProductAlternativesInfo>();
            MaterialAlternativeList = new BOSList<ICProductAlternativesInfo>();
            ProductList = new BOSList<ICProductsInfo>();
            MaterialList = new BOSList<ICProductsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ICProductAlternatives", new ICProductAlternativesInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductAlternativeList.InitBOSList(
                                             this,
                                             null,
                                             "ICProductAlternatives",
                                             BOSList<ICProductAlternativesInfo>.cstRelationNone);
            MaterialAlternativeList.InitBOSList(
                                             this,
                                             null,
                                             "ICProductAlternatives",
                                             BOSList<ICProductAlternativesInfo>.cstRelationNone);
            ProductList.InitBOSList(
                                             this,
                                             null,
                                             "ICProducts",
                                             BOSList<ICProductsInfo>.cstRelationNone);
            MaterialList.InitBOSList(
                                            this,
                                            null,
                                            "ICProducts",
                                            BOSList<ICProductsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ProductList.InitBOSListGridControl("fld_dgcICProductSemi");
            MaterialList.InitBOSListGridControl("fld_dgcICProductMaterial");
            ProductAlternativeList.InitBOSListGridControl("fld_dgcICProductAlternatives");
            MaterialAlternativeList.InitBOSListGridControl("fld_dgcICProductAlternatives");
        }

        public override void SetDefaultModuleObjectsList()
        {
            ProductList.SetDefaultListAndRefreshGridControl();
            ProductAlternativeList.SetDefaultListAndRefreshGridControl();
            MaterialAlternativeList.SetDefaultListAndRefreshGridControl();
            MaterialList.SetDefaultListAndRefreshGridControl();

        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {

        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            //Save categories
            ProductAlternativeList.SaveItemObjects();
        }
        #endregion
    }
}
