namespace BOSLib.Entities
{
    public class BysTableConstraint
    {
        public string ForeignSchemaName { get; set; }

        public string ForeignTableName { get; set; }

        public string ForeignColumnName { get; set; }

        public string PrimarySchemaName { get; set; }

        public string PrimaryTableName { get; set; }

        public string PrimaryColumnName { get; set; }

        public string ConstraintName { get; set; }
    }
}
