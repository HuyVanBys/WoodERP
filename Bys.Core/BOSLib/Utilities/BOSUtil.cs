using AutoMapper;
using BOSLib.Extensions;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BOSLib
{
    public class BOSUtil
    {
        public const String cstDummyTable = "CSDummy";

        public static String NewLine
        {
            get
            {
                return "\n";
            }
        }

        public static String Tab
        {
            get
            {
                return "\t";
            }
        }


        public static String GetFullTypeName(String strTypeName)
        {

            String strFullTypeName = strTypeName;
            switch (strTypeName)
            {
                case "Int32":
                    {
                        strFullTypeName = "System." + strTypeName;
                        break;
                    }
            }
            return strFullTypeName;
        }

        public static Type GetBOSType(String strFullTypeName, String strAssembly)
        {
            try
            {
                Assembly BOSAssembly = Assembly.Load(strAssembly);
                if (BOSAssembly != null)
                {
                    return BOSAssembly.GetType(strFullTypeName);
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static String GetTableNameFromBusinessObject(BusinessObject objInfo)
        {
            if (objInfo != null)
            {
                String strBusinessObjectName = objInfo.GetType().Name;
                String strTableName = strBusinessObjectName.Substring(0, strBusinessObjectName.Length - 4);
                return strTableName;
            }
            else
                return cstDummyTable;
        }

        public static String GetTableNameFromBusinessObjectType(Type tpBusinessObject)
        {
            String strBusinessObjectName = tpBusinessObject.Name;
            String strTableName = strBusinessObjectName.Substring(0, strBusinessObjectName.Length - 4);
            return strTableName;
        }

        public static String GetBusinessControllerNameFromBusinessObject(BusinessObject objInfo)
        {
            String strTableName = GetTableNameFromBusinessObject(objInfo);
            return strTableName + "Controller";
        }

        public static String GetModuleName(String strTableName)
        {
            String strModuleName = strTableName.Substring(2, strTableName.Length - 3);
            if (strModuleName.EndsWith("ie"))
                strModuleName = strModuleName.Substring(0, strModuleName.Length - 2) + "y";

            return strModuleName;
        }

        public static Type GetColumnDataType(String strTableName, String strColumnName)
        {
            BusinessObject obj = BusinessObjectFactory.GetBusinessObject(strTableName + "Info");
            if (obj != null)
            {
                PropertyInfo prop = obj.GetType().GetProperty(strColumnName);
                Type type = null;
                if (prop != null)
                    type = prop.PropertyType;
                return type;
            }
            else
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                String strColumnDataType = dbUtil.GetColumnDataType(strTableName, strColumnName);
                switch (strColumnDataType)
                {
                    case "varchar":
                        return typeof(String);
                    case "nvarchar":
                        return typeof(String);
                    case "text":
                        return typeof(String);
                    case "ntext":
                        return typeof(String);
                    case "int":
                        return typeof(int);
                    case "float":
                        return typeof(double);
                    case "real":
                        return typeof(double);
                    case "decimal":
                        return typeof(decimal);
                    case "datetime":
                        return typeof(DateTime);
                    case "bit":
                        return typeof(bool);
                    case "image":
                        return typeof(byte[]);
                    case "varbinary":
                        return typeof(byte[]);
                    default:
                        return typeof(String);
                }
            }
        }

        public static DateTime GetYearBeginDate()
        {
            return new DateTime(DateTime.Now.Year, 1, 1);
        }

        /// <summary>
        /// Get the begin date of the year of a given date
        /// </summary>
        /// <param name="date">Given date</param>
        /// <returns>Begin date of the year</returns>
        public static DateTime GetYearBeginDate(DateTime date)
        {
            return new DateTime(date.Year, 1, 1);
        }

        public static DateTime GetYearEndDate()
        {
            return new DateTime(DateTime.Now.Year, 12, 31);
        }

        /// <summary>
        /// Get the end date of the year of a given date
        /// </summary>
        /// <param name="date">Given date</param>
        /// <returns>End date of the year</returns>
        public static DateTime GetYearEndDate(DateTime date)
        {
            return new DateTime(date.Year, 12, 31);
        }

        public static DateTime GetMonthBeginDate()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        public static DateTime GetMonthBeginDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime GetMonthEndDate()
        {
            int day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);
        }

        /// <summary>
        /// Get the end date of the month of a given date
        /// </summary>
        /// <param name="date">Given date</param>
        /// <returns>Month end date</returns>
        public static DateTime GetMonthEndDate(DateTime date)
        {
            int day = DateTime.DaysInMonth(date.Year, date.Month);
            return new DateTime(date.Year, date.Month, day);
        }

        public static bool ObjectIsEditingByOtherUser(String strModuleName, int iObjectID)
        {
            if (iObjectID > 0)
            {
                GEUserAuditsController objGEUserAuditsController = new GEUserAuditsController();
                GEUserAuditsInfo objGEUserAuditsInfo = objGEUserAuditsController.GetGEUserAuditsByModuleNameAndParameterAndAction(
                                                                                    strModuleName,
                                                                                    iObjectID.ToString(),
                                                                                    BaseToolbar.ModusEdit);
                if (objGEUserAuditsInfo != null)
                {
                    return true;
                }
            }

            return false;
        }

        public static double RoundToThousand(double number)
        {
            double result = Math.Round(number, 0);
            double temp = result % 1000;
            if (temp >= 500)
            {
                result = Math.Floor(result / 1000) * 1000 + 1000;
            }
            else
            {
                result = Math.Floor(result / 1000) * 1000;
            }
            return result;
        }

        public static void CopyObject(BusinessObject objFromObjectsInfo, BusinessObject objToObjectsInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strToObjectTableName = BOSUtil.GetTableNameFromBusinessObject(objToObjectsInfo);
            String strFromObjectTableName = BOSUtil.GetTableNameFromBusinessObject(objFromObjectsInfo);

            if (objFromObjectsInfo.GetType().Name.EndsWith("ForViewInfo"))
                strFromObjectTableName = objFromObjectsInfo.GetType().Name.Replace("ForViewInfo", "");
            if (objFromObjectsInfo.GetType().Name.EndsWith("ForViewIMES"))
                strFromObjectTableName = objFromObjectsInfo.GetType().Name.Replace("ForViewIMES", "");

            PropertyInfo[] properties = objToObjectsInfo.GetObjectProperties();
            string toObjectTablePrimaryKey = dbUtil.GetTablePrimaryColumn(strToObjectTableName);
            string fromObjectTablePrimaryKey = dbUtil.GetTablePrimaryColumn(strFromObjectTableName);

            Dictionary<string, PropertyInfo> columnProps = objToObjectsInfo.GetColumnAttributes();
            PropertyInfo keyProp = null;
            columnProps.TryGetValue(toObjectTablePrimaryKey, out keyProp);
            foreach (PropertyInfo prop in properties)
            {
                if (strToObjectTableName != strFromObjectTableName && (prop.Name == toObjectTablePrimaryKey || (keyProp != null && keyProp.Name == prop.Name)))
                {
                    prop.SetValue(objToObjectsInfo, default, null);
                    continue;
                }
                if (prop.Name != toObjectTablePrimaryKey && prop.Name != "IsTransferred" && !prop.Name.Contains("TransferredDate"))
                {
                    String strFromObjectPropertyName = string.Empty;
                    if (prop.Name.StartsWith(strToObjectTableName.Substring(0, strToObjectTableName.Length - 1)))
                    {
                        strFromObjectPropertyName = strFromObjectTableName.Substring(0, strFromObjectTableName.Length - 1) + prop.Name.Substring(strToObjectTableName.Length - 1);
                    }
                    PropertyInfo propFromObjectProperty = objFromObjectsInfo.GetType().GetProperty(strFromObjectPropertyName);
                    if (propFromObjectProperty != null)
                    {
                        object objValue = propFromObjectProperty.GetValue(objFromObjectsInfo, null);
                        prop.SetValue(objToObjectsInfo, objValue, null);
                    }
                    else
                    {
                        strFromObjectPropertyName = strFromObjectTableName.Substring(0, 2) + prop.Name.Substring(2);
                        propFromObjectProperty = objFromObjectsInfo.GetType().GetProperty(strFromObjectPropertyName);
                        if (propFromObjectProperty != null)
                        {
                            object objValue = propFromObjectProperty.GetValue(objFromObjectsInfo, null);
                            prop.SetValue(objToObjectsInfo, objValue, null);
                        }
                        else
                        {
                            propFromObjectProperty = objFromObjectsInfo.GetType().GetProperty(prop.Name);
                            if (propFromObjectProperty != null)
                            {
                                try
                                {
                                    object objValue = propFromObjectProperty.GetValue(objFromObjectsInfo, null);
                                    prop.SetValue(objToObjectsInfo, objValue, null);
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static TDestination CopyObject<TSource, TDestination>(TSource entity)
        {
            return BysGateway.Mapper.Map<TSource, TDestination>(entity);
        }

        public static void CopyViewObject(BusinessObject objFromObjectsInfo, BusinessObject objToObjectsInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strToObjectTableName = BOSUtil.GetTableNameFromBusinessObject(objToObjectsInfo);
            String strFromObjectTableName = BOSUtil.GetTableNameFromBusinessObject(objFromObjectsInfo);
            if (objFromObjectsInfo.GetType().Name.Contains("ForView"))
            {
                strFromObjectTableName = objFromObjectsInfo.GetType().Name.Replace("ForView", "");
            }
            PropertyInfo[] properties = objToObjectsInfo.GetObjectProperties();
            string toObjectTablePrimaryKey = dbUtil.GetTablePrimaryColumn(strToObjectTableName);
            foreach (PropertyInfo prop in properties)
            {
                if (prop.Name != "IsTransferred" && !prop.Name.Contains("TransferredDate"))
                {
                    String strFromObjectPropertyName = string.Empty;
                    if (prop.Name.StartsWith(strToObjectTableName.Substring(0, strToObjectTableName.Length - 1)))
                    {
                        strFromObjectPropertyName = strFromObjectTableName.Substring(0, strFromObjectTableName.Length - 1) + prop.Name.Substring(strToObjectTableName.Length - 1);
                    }
                    PropertyInfo propFromObjectProperty = objFromObjectsInfo.GetType().GetProperty(strFromObjectPropertyName);
                    if (propFromObjectProperty != null)
                    {
                        object objValue = propFromObjectProperty.GetValue(objFromObjectsInfo, null);
                        prop.SetValue(objToObjectsInfo, objValue, null);
                    }
                    else
                    {
                        strFromObjectPropertyName = strFromObjectTableName.Substring(0, 2) + prop.Name.Substring(2);
                        propFromObjectProperty = objFromObjectsInfo.GetType().GetProperty(strFromObjectPropertyName);
                        if (propFromObjectProperty != null)
                        {
                            object objValue = propFromObjectProperty.GetValue(objFromObjectsInfo, null);
                            prop.SetValue(objToObjectsInfo, objValue, null);
                        }
                        else
                        {
                            propFromObjectProperty = objFromObjectsInfo.GetType().GetProperty(prop.Name);
                            if (propFromObjectProperty != null)
                            {
                                try
                                {
                                    object objValue = propFromObjectProperty.GetValue(objFromObjectsInfo, null);
                                    prop.SetValue(objToObjectsInfo, objValue, null);
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static DevExpress.XtraEditors.Mask.MaskType GetMaskTypeFromText(String strMaskType)
        {
            try
            {
                return (DevExpress.XtraEditors.Mask.MaskType)Enum.Parse(typeof(DevExpress.XtraEditors.Mask.MaskType), strMaskType);
            }
            catch (Exception)
            {
                return DevExpress.XtraEditors.Mask.MaskType.None;
            }
        }

        public static DevExpress.Utils.FormatType GetFormatTypeFromText(String strFormatType)
        {
            try
            {
                return (DevExpress.Utils.FormatType)Enum.Parse(typeof(DevExpress.Utils.FormatType), strFormatType);
            }
            catch (Exception)
            {
                return DevExpress.Utils.FormatType.None;
            }
        }

        public static DevExpress.XtraEditors.Repository.RepositoryItem GetRepositoryItemFromText(String strRepositoryItem)
        {
            switch (strRepositoryItem)
            {
                case "RepositoryItemTextEdit":
                    return new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
                case "RepositoryItemComboBox":
                    return new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
                case "RepositoryItemDateEdit":
                    return new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
                case "RepositoryItemTimeEdit":
                    return new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
                case "RepositoryItemLookupEdit":
                    return new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
                case "RepositoryItemGridLookUpEdit":
                    return new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
                case "RepositoryItemCheckEdit":
                    return new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                default:
                    return null;
            }
        }

        public static bool IsEditControl(Control ctrl)
        {
            if (ctrl.GetType().Name.Contains("Edit"))
                return true;
            else
                if (ctrl.GetType().BaseType.Name.Contains("Edit"))
                return true;
            return false;
        }

        public static bool IsEditRepository(DevExpress.XtraEditors.Repository.RepositoryItem rep)
        {
            bool isEditRepository = false;
            if (rep is RepositoryItemTextEdit)
            {
                isEditRepository = true;
            }
            if (rep is RepositoryItemComboBox)
            {
                isEditRepository = true;
            }
            if (rep is RepositoryItemDateEdit)
            {
                isEditRepository = true;
            }
            if (rep is RepositoryItemTimeEdit)
            {
                isEditRepository = true;
            }
            if (rep is RepositoryItemLookUpEdit)
            {
                isEditRepository = true;
            }
            if (rep is RepositoryItemButtonEdit)
            {
                isEditRepository = true;
            }
            if (rep is RepositoryItemGridLookUpEdit)
            {
                isEditRepository = true;
            }
            return isEditRepository;
        }

        /// <summary>
        /// Reverse string
        /// </summary>
        public static String ReverseString(String str)
        {
            String result = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
                result += str[i];
            return result;
        }

        /// <summary>
        /// Get displayed string of a number in the system format
        /// </summary>
        /// <param name="number">Given Number</param>
        /// <returns>Dipslayed string</returns>
        public static String GetNumberDisplayFormat(object number)
        {
            return GetNumberDisplayFormat(
                                        number,
                                        NumberFormatInfo.CurrentInfo.NumberDecimalDigits,
                                        NumberFormatInfo.CurrentInfo.NumberGroupSeparator,
                                        NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
        }

        /// <summary>
        /// Get displayed string of a number in a specified format
        /// </summary>
        /// <param name="number">Given number</param>
        /// <param name="formatGroup">Given format</param>
        /// <returns>Displayed string</returns>
        public static string GetNumberDisplayFormat(object number, string formatGroup)
        {
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = (STFieldFormatGroupsInfo)objFieldFormatGroupsController.GetObjectByName(formatGroup);
            string displayedString = string.Empty;
            if (objFieldFormatGroupsInfo != null)
            {
                displayedString = GetNumberDisplayFormat(
                                                        number,
                                                        objFieldFormatGroupsInfo.STFieldFormatGroupDecimalRound,
                                                        NumberFormatInfo.CurrentInfo.NumberGroupSeparator,
                                                        NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
            }
            else
            {
                displayedString = GetNumberDisplayFormat(
                                                        number,
                                                        NumberFormatInfo.CurrentInfo.NumberDecimalDigits,
                                                        NumberFormatInfo.CurrentInfo.NumberGroupSeparator,
                                                        NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
            }
            return displayedString;
        }

        /// <summary>
        /// Get displayed string of a number in a specified format
        /// </summary>
        /// <param name="number">Given number</param>
        /// <param name="numberDecimalDigits">Number of decimal digits</param>
        /// <param name="numberGroupSeperator">Digit group seperator</param>
        /// <param name="numberDecimalSeperator">Decimal seperator</param>
        /// <returns>Displayed string</returns>
        public static string GetNumberDisplayFormat(object number, int numberDecimalDigits, string numberGroupSeperator, string numberDecimalSeperator)
        {
            if (number.GetType() == typeof(double))
                number = Math.Round(Convert.ToDouble(number), numberDecimalDigits);
            else if (number.GetType() == typeof(decimal))
                number = Math.Round(Convert.ToDecimal(number), numberDecimalDigits);

            String str = number.ToString();
            String sign = String.Empty;
            if ((str.Length > 0) && str[0] == '-')
            {
                sign = "-";
                str = str.Remove(0, 1);
            }

            String left = String.Empty;
            String right = String.Empty;
            String[] arr = str.Split(new string[] { numberDecimalSeperator }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length > 0)
                left = arr[0];
            if (arr.Length > 1)
                right = arr[1];
            str = String.Empty;
            for (int i = 0; i < left.Length; i++)
            {
                if ((i + 1) % 3 == 0 && i < left.Length - 1)
                    str = numberGroupSeperator + left[left.Length - i - 1] + str;
                else
                    str = left[left.Length - i - 1] + str;
            }

            if (number.GetType() == typeof(double) || number.GetType() == typeof(decimal))
            {
                while (right.Length < numberDecimalDigits)
                    right += "0";
                if (right.Length > 0)
                {
                    str = String.Format("{0}{1}{2}{3}", sign, str, numberDecimalSeperator, right);
                }
                else
                {
                    str = String.Format("{0}{1}", sign, str);
                }
            }
            else if (number.GetType() == typeof(int))
                str = String.Format("{0}{1}", sign, str);
            return str;
        }

        /// <summary>
        /// Convert unicode string to un-sign string
        /// </summary>
        /// <param name="text">String is converted</param>
        /// <returns>String result after converting</returns>
        public static string ConvertUnicodeStringToUnSign(string text)
        {
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        /// <summary>
        /// Convert unicode string from un-sign to sign string for search
        /// </summary>
        /// <param name="value">String is converted</param>
        /// <returns>String result after converting</returns>
        public static string GetSearchString(string value)
        {
            string[] match = new string[] {"aáàảãạâấầẩẫậăắằẳẵặ",
                                            "eéèẻẽẹêếềểễệ",
                                            "oóòỏõọôốồổỗộơớờởỡợ",
                                            "uúùủũụưứừửữự",
                                            "iíìỉĩị",
                                            "yýỳỷỹỵ",
                                            "dđ",
                                            "AÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶ",
                                            "EÉÈẺẼẸÊẾỀỂỄỆ",
                                            "OÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢ",
                                            "UÚÙỦŨỤƯỨỪỬỮỰ",
                                            "IÍÌỈĨỊ",
                                            "YÝỲỶỸỴ",
                                            "DĐÐ"
                                            };
            string[] pattern = new string[] {   "[aáàảãạâấầẩẫậăắằẳẵặ]",
                                                "[eéèẻẽẹêếềểễệ]",
                                                "[oóòỏõọôốồổỗộơớờởỡợ]",
                                                "[uúùủũụưứừửữự]",
                                                "[iíìỉĩị]",
                                                "[yýỳỷỹỵ]",
                                                "[dđ]",
                                                "[AÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶ]",
                                                "[EÉÈẺẼẸÊẾỀỂỄỆ]",
                                                "[OÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢ]",
                                                "[UÚÙỦŨỤƯỨỪỬỮỰ]",
                                                "[IÍÌỈĨỊ]",
                                                "[YÝỲỶỸỴ]",
                                                "[DĐÐ]"
                                            };
            string search = value;
            value = string.Empty;
            foreach (char c in search)
            {
                int i = 0;
                for (i = 0; i < match.Length; i++)
                {
                    if (match[i].Contains(c.ToString()))
                    {
                        value += pattern[i];
                        break;
                    }
                }
                if (i == match.Length)
                {
                    value += c;
                }
            }
            return value;
        }

        /// <summary>
        /// Generate full address from some address fields
        /// </summary>
        /// <param name="obj">Object is  used to get address fields</param>
        /// <param name="addressType">Address type</param>
        /// <returns>Full address</returns>
        public static String GenerateFullAddress(BusinessObject obj, String addressType)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String tableName = BOSUtil.GetTableNameFromBusinessObject(obj);
            String tablePrefix = tableName.Substring(0, tableName.Length - 1);
            return BOSUtil.GenerateFullAddress(obj, tablePrefix, addressType);
        }

        /// <summary>
        /// Generate full address from some address fields
        /// </summary>
        /// <param name="obj">Object is  used to get address fields</param>
        /// <param name="prefix">Prefix to get address properties</param>
        /// <param name="addressType">Address type</param>
        /// <returns>Full address</returns>
        public static String GenerateFullAddress(BusinessObject obj, string prefix, String addressType)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String address = String.Empty;
            string addressLine1 = dbUtil.GetPropertyStringValue(obj, string.Format("{0}{1}AddressLine1", prefix, addressType));
            if (!string.IsNullOrEmpty(addressLine1))
            {
                address += string.Format(", {0}", addressLine1);
            }
            string addressLine2 = dbUtil.GetPropertyStringValue(obj, string.Format("{0}{1}AddressLine2", prefix, addressType));
            if (!string.IsNullOrEmpty(addressLine2))
            {
                address += string.Format(", {0}", addressLine2);
            }
            String addressCity = dbUtil.GetPropertyStringValue(obj, String.Format("{0}{1}AddressCity", prefix, addressType));
            if (!String.IsNullOrEmpty(addressCity))
                address += String.Format(", {0}", addressCity);
            String addressStateProvince = dbUtil.GetPropertyStringValue(obj, String.Format("{0}{1}AddressStateProvince", prefix, addressType));
            if (!String.IsNullOrEmpty(addressStateProvince))
                address += String.Format(", {0}", addressStateProvince);
            String addressCountry = dbUtil.GetPropertyStringValue(obj, String.Format("{0}{1}AddressCountry", prefix, addressType));
            if (!String.IsNullOrEmpty(addressCountry))
                address += String.Format(", {0}", addressCountry);
            if (address.Length > 0)
                address = address.Substring(2);
            return address;
        }

        /// <summary>
        /// Get format group the column is set to
        /// </summary>
        /// <param name="tableName">Name of the table the column belongs to</param>
        /// <param name="columnName">Name of the given column</param>
        /// <returns>Format group object</returns>
        public static STFieldFormatGroupsInfo GetColumnFormat(String tableName, String columnName)
        {
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = null;
            //Find property binding to this column then get its format group attribute
            FormatGroupAttribute formatGroupAttr = null;
            BusinessObject obj = BusinessObjectFactory.GetBusinessObject(tableName + "Info");
            if (obj != null)
            {
                PropertyInfo prop = obj.GetType().GetProperty(columnName);
                if (prop != null)
                {
                    object[] attrs = prop.GetCustomAttributes(typeof(FormatGroupAttribute), true);
                    if (attrs.Length > 0)
                        formatGroupAttr = (FormatGroupAttribute)attrs[0];
                }
            }
            if (formatGroupAttr != null)
            {
                objFieldFormatGroupsInfo = (STFieldFormatGroupsInfo)objFieldFormatGroupsController.GetObjectByName(formatGroupAttr.FormatGroup);
            }

            //Get format group directly from database based on table name and column name
            if (objFieldFormatGroupsInfo == null)
            {
                objFieldFormatGroupsInfo = objFieldFormatGroupsController.GetFieldFormatGroupByTableNameAndColumnName(tableName, columnName);
            }
            return objFieldFormatGroupsInfo;
        }

        /// <summary>
        /// Expand a string with a specified character
        /// </summary>
        /// <param name="str">Given string</param>
        /// <param name="chr">Specified character</param>
        /// <param name="length">Length of the string after expanding</param>
        /// <returns>Expanded string</returns>
        public static string ExpandString(string str, char chr, int length)
        {
            string result = (string)str.Clone();
            while (result.Length < length)
            {
                result = result + chr.ToString();
            }
            return result;
        }
    }
}
