using Localization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP
{
    public class BaseModuleFactory
    {
        public static BaseModuleERP GetModule(String strModuleName)
        {
            try
            {
                Type moduleType = null;
                List<string> libraryModule = BOSLib.BysGateway.LibraryModule;
                libraryModule.ForEach(libName =>
                {
                    if (moduleType != null)
                        return;

                    moduleType = Assembly.LoadFrom(Application.StartupPath + "\\" + libName).GetType("BOSERP.Modules." + strModuleName + "." + strModuleName + "Module");
                });
                return (BaseModuleERP)moduleType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
