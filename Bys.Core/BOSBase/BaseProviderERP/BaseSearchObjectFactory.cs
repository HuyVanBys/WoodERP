using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP
{
    public class BaseSearchObjectFactory
    {
        public static BaseSearchObject GetSearchObject(String strModuleName)
        {
            try
            {
                Type searchObjectType = null;
                List<string> libraryModule = BOSLib.BysGateway.LibraryModule;
                libraryModule.ForEach(libName =>
                {
                    if (searchObjectType != null)
                        return;

                    searchObjectType = Assembly.LoadFrom(Application.StartupPath + "\\" + libName).GetType("BOSERP.Modules." + strModuleName + "." + strModuleName + "SearchObject");
                });

                return (BaseSearchObject)searchObjectType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
            }
            catch (Exception e)
            {
                MessageBox.Show("BaseSearchObjectFactory.GetSearchObject:" + e.Message);
                return null;
            }
        }
    }
}
