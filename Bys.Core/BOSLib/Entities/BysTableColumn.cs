using System;

namespace BOSLib.Entities
{
    public class BysTableColumn
    {
        public string Database { get; set; }

        public string Owner { get; set; }

        public string TableName { get; set; }

        public string ColumnName { get; set; }

        public int OrdinalPosition { get; set; }

        public string DefaultSetting { get; set; }

        public string DataType { get; set; }

        public int? MaxLength { get; set; }

        public int? DatePrecision { get; set; }

        public int? NumberPrecision { get; set; }

        public int? NumberScale { get; set; }

        public bool IsNullable { get; set; }

        public bool IsIdentity { get; set; }

        public bool IsComputed { get; set; }

        public bool IsPrimaryKey { get; set; }

        public string DbType => GetDbType();

        public string CSharpDataType => GetCSharpDataType();

        public string DefaultValueDateType => GetDefaultValueDataType();

        public Type AssemblyType => GetAssemblyDbType();

        private string GetDbType()
        {
            if ((MaxLength ?? 0) > 0 && (DataType?.ToLower() == "nvarchar" || DataType?.ToLower() == "varchar"))
                return string.Format("{0}({1})", DataType, MaxLength);
            else if (DataType?.ToLower() == "decimal")
                return string.Format("{0}({1},{2})", DataType, NumberPrecision ?? 18, NumberScale ?? 0);

            return DataType;
        }

        private string GetCSharpDataType()
        {
            switch (DataType)
            {
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                case "nchar":
                    return "string";

                case "int":
                case "smallint":
                    return "int";

                case "tinyint":
                    return "byte";

                case "float":
                case "real":
                    return "double";

                case "money":
                case "numeric":
                case "decimal":
                    return "decimal";

                case "datetime2":
                case "datetime":
                    return "DateTime";

                case "bit":
                    return "bool";

                case "image":
                case "varbinary":
                    return "byte[]";

                case "uniqueidentifier":
                    return "Guid";

                case "bigint":
                    return "long";

                default:
                    return "_UNKNOWN_";
            }
        }

        public object Clone()
        {
            try
            {
                return this.MemberwiseClone();
            }
            catch (Exception ex)
            {
                GC.SuppressFinalize(this);
                throw ex;
            }
        }

        private string GetDefaultValueDataType()
        {
            switch (DataType)
            {
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                case "nchar":
                    return "''";

                case "int":
                case "smallint":
                case "tinyint":
                case "bigint":
                case "bit":
                    return "0";

                case "float":
                case "real":
                case "money":
                case "numeric":
                case "decimal":
                    return "0.0";

                case "datetime2":
                case "datetime":
                    if (!IsNullable)
                        return "'9999/12/31'";
                    return "NULL";

                case "image":
                case "varbinary":
                    return "0x";

                case "uniqueidentifier":
                    return new Guid().ToString();

                default:
                    return "NULL";
            }
        }

        public Type GetAssemblyDbType()
        {
            switch (DataType)
            {
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                case "nchar":
                    return typeof(string);

                case "int":
                case "smallint":
              
                    return typeof(int);
                case "bigint":
                    return typeof(long);

                case "bit":
                    return typeof(bool);

                case "real":
                case "float":
                    return typeof(float);
             
                case "money":
                case "numeric":
                case "decimal":
                    return typeof(decimal);

                case "datetime2":
                case "datetime":
                    return typeof(DateTime);

                case "image":
                case "varbinary":
                case "tinyint":
                    return typeof(byte[]);

                case "uniqueidentifier":
                    return typeof(Guid);
                default:
                    return null;
            }
        }
    }
}
