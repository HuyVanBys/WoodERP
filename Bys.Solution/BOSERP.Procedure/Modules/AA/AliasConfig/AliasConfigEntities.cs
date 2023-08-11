using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.AliasConfig
{
    public class AliasConfigEntities : ERPModuleEntities
    {
        public BOSList<AAColumnAliasInfo> ColumnAliasList { get; set; }

        public BOSList<STFieldFormatsInfo> FieldFormatList { get; set; }
        public BOSList<GECurrenciesInfo> CurrencyList { get; set; }
        public BOSList<ICDepartmentFormatsInfo> DepartmentFormatList { get; set; }
        #region Constructor
        public AliasConfigEntities()
            : base()
        {
            ColumnAliasList = new BOSList<AAColumnAliasInfo>();
            FieldFormatList = new BOSList<STFieldFormatsInfo>();
            CurrencyList = new BOSList<GECurrenciesInfo>();
            DepartmentFormatList = new BOSList<ICDepartmentFormatsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add("AAColumnAlias", new AAColumnAliasInfo());
        }

        public override void InitModuleObjectList()
        {
            ColumnAliasList.InitBOSList(this,
                                           String.Empty,
                                           "AAColumnAlias",
                                           BOSList<AAColumnAliasInfo>.cstRelationNone);

            FieldFormatList.InitBOSList(this,
                                        String.Empty,
                                        TableName.STFieldFormatsTableName,
                                        BOSList<STFieldFormatsInfo>.cstRelationNone);
            CurrencyList.InitBOSList(this,
                                        String.Empty,
                                        TableName.GECurrenyTableName,
                                        BOSList<GECurrenciesInfo>.cstRelationNone); 
            DepartmentFormatList.InitBOSList(this,
                                        String.Empty,
                                        "ICDepartmentFormats",
                                        BOSList<ICDepartmentFormatsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ColumnAliasList.InitBOSListGridControl();
            FieldFormatList.InitBOSListGridControl(AliasConfigModule.FieldFormatsGridControlName);
            CurrencyList.InitBOSListGridControl("fld_dgcGECurrenciesGridControl");
            DepartmentFormatList.InitBOSListGridControl("fld_dgcICDepartmentFormatsGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ColumnAliasList.SetDefaultListAndRefreshGridControl();
                FieldFormatList.SetDefaultListAndRefreshGridControl();
                CurrencyList.SetDefaultListAndRefreshGridControl();
                DepartmentFormatList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
    }
}
