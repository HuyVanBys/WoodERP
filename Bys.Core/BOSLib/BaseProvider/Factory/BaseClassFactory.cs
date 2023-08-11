using System;
using System.Reflection;
using System.Windows.Forms;

namespace BOSLib
{
    public class BaseClassFactory
    {
        public static object GetClass(String strClassName)
        {
            Type type = GetClassType(strClassName);
            if (type != null)
            {
                object obj = type.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                return obj;
            }
            return null;
        }

        public static Type GetClassType(String strClassName)
        {
            Type type = null;
            BOSLib.BysGateway.LibraryModule.ForEach(libName =>
            {
                if (type != null)
                    return;

                type = GetClassTypeFromAssembly(libName, strClassName);
            });
            return type;
        }


        private static Type GetClassTypeFromAssembly(String assemblyName, String className)
        {
            Type type = null;
            try
            {
                Assembly BOSERP = Assembly.LoadFrom(Application.StartupPath + "\\" + assemblyName);
                type = BOSERP.GetType(className);
            }
            catch (Exception)
            {

            }
            return type;
        }
    }
}
