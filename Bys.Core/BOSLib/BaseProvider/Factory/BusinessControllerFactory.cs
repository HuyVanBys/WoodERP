using BOSLib.Interfaces;
using System;
using System.Collections.Concurrent;

namespace BOSLib
{
    public class BusinessControllerFactory
    {
        private static ConcurrentDictionary<string, IBusinessController> Controllers { get; set; }

        static BusinessControllerFactory()
        {
            Controllers = new ConcurrentDictionary<string, IBusinessController>();
        }

        public static IBusinessController GetBusinessController(String strBusinessControllerName)
        {
            IBusinessController controller;
            if (Controllers.ContainsKey(strBusinessControllerName))
            {
                return Controllers[strBusinessControllerName];
            }
            controller = (IBusinessController)BaseClassFactory.GetClass("BOSERP." + strBusinessControllerName);
            if (controller == null)
                controller = (IBusinessController)BaseClassFactory.GetClass("BOSLib." + strBusinessControllerName);

            Controllers.TryAdd(strBusinessControllerName, controller);
            return controller;
        }

        public static Type GetBusinessControllerType(String strBusinessControllerName)
        {
            IBusinessController objController = GetBusinessController(strBusinessControllerName);
            if (objController != null)
                return objController.GetType();
            return null;
        }
    }

}
