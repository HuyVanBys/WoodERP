using System;
using System.Reflection;

namespace BOSERP
{
    public class ERPModuleEntitiesFactory
    {
        public static ERPModuleEntities GetModuleEntities(String strModuleName)
        {
            try
            {
                Type moduleEntitiesType = BOSApp.BOSERPAssembly.GetType("BOSERP.Modules." + strModuleName + "." + strModuleName + "Entities");
                return (ERPModuleEntities)moduleEntitiesType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
