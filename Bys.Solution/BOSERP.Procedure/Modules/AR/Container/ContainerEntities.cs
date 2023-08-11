using BOSCommon.Constants;

namespace BOSERP.Modules.Container
{
    public class ContainerEntities : ERPModuleEntities
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets GEPaymentTermsInfo list
        /// </summary>
        public BOSList<GEContainersInfo> ContainersList { get; set; }
        #endregion

        #region Constructor
        public ContainerEntities()
            : base()
        {
            ContainersList = new BOSList<GEContainersInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new GEContainersInfo();
        }
        #endregion

        #region Module Objects functions

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.GEContainersTableName, new GEContainersInfo());
        }

        public override void InitModuleObjectList()
        {

            ContainersList.InitBOSList(this,
                                       TableName.GEContainersTableName,
                                       string.Empty,
                                       BOSList<GEContainersInfo>.cstRelationNone);

        }
        public override void New()
        {
            base.New();
        }

        //public override void SetDefaultMainObject()
        //{
        //    base.SetDefaultMainObject();

        //    GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)MainObject;
        //   // objPaymentTermsInfo.ICProductType = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.ProductType);
        //}

        //public override void SetDefaultModuleObjectsList()
        //{
        //    try
        //    {
        //        PaymentTermsList.SetDefaultListAndRefreshGridControl();
        //    }
        //    catch (Exception)
        //    {
        //        return;
        //    }
        //}
        #endregion
    }
}
