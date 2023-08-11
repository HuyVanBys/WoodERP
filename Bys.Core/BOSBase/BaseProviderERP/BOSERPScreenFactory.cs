using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP
{
    public class BOSERPScreenFactory
    {
        public static BOSERPScreen GetScreen(String strScreenNumber, String strModuleName)
        {
            try
            {
                List<string> libraryModule = BOSLib.BysGateway.LibraryModule;
                Type screenType = null;
                libraryModule.ForEach(libName =>
                {
                    if (screenType != null)
                        return;

                    screenType = Assembly.LoadFrom(Application.StartupPath + "\\" + libName).GetType(String.Format("BOSERP.Modules.{0}.UI.{1}", strModuleName, strScreenNumber));
                });

                if (screenType == null)
                    return new BOSERPScreen();

                return (BOSERPScreen)screenType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
            }
            catch (Exception)
            {
                return new BOSERPScreen();
            }

        }
    }
}
