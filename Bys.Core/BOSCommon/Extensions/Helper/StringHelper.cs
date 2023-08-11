using System.Text;
using System.Text.RegularExpressions;

namespace BOSCommon.Extensions.Helper
{
    public class StringHelper
    {
        public static string ConvertUnicodeStringToUnSign(string text)
        {
            for (int index = 33; index < 48; ++index)
                text = text.Replace(((char)index).ToString(), "_");
            for (int index = 58; index < 65; ++index)
                text = text.Replace(((char)index).ToString(), "_");
            for (int index = 91; index < 97; ++index)
                text = text.Replace(((char)index).ToString(), "_");
            for (int index = 123; index < (int)sbyte.MaxValue; ++index)
                text = text.Replace(((char)index).ToString(), "_");
            return new Regex("\\p{IsCombiningDiacriticalMarks}+").Replace(text.Normalize(NormalizationForm.FormD), string.Empty).Replace('đ', 'd').Replace('Đ', 'D').Replace(" ", string.Empty);
        }
    }
}
