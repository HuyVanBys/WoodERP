using System;

namespace BOSCommon.Extensions.Helper
{
    public class EnumExtensions
    {
        public static TSource ParseEnum<TSource>(string value) where TSource : struct
        {
            TSource defaultValue = new TSource();
            try
            {
                defaultValue = (TSource)Enum.Parse(typeof(TSource), value, true);
            }
            catch (Exception e)
            {
                defaultValue = new TSource();
            }
            return defaultValue;
        }
    }
}
