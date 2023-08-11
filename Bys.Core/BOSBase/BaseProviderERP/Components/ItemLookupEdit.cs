using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Linq;

namespace BOSERP
{
    public partial class ItemLookupEdit : BOSComponent.BOSLookupEdit
    {
        public ItemLookupEdit()
        {
            InitializeComponent();
        }

        public ItemLookupEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public override void InitializeControl()
        {
            base.InitializeControl();

            Properties.ValueMember = "ICProductID";
            Properties.DisplayMember = "ICProductDesc";
            Properties.BestFitMode = BestFitMode.None;
        }

        public override void InitLookupEditColumns()
        {
            this.Properties.Columns.Clear();
            this.Properties.PopupWidth = 0;
            //AddLookupEditColumn(TableName.ICProductsTableName, "ICProductActiveCheckText",10);
            AddLookupEditColumn(TableName.ICProductsTableName, "ICProductBarCode", 120);
            AddLookupEditColumn(TableName.ICProductsTableName, "ICProductNo", 120);
            AddLookupEditColumn(TableName.ICProductsTableName, "ICProductNoOfOldSys", 100);
            AddLookupEditColumn(TableName.ICProductsTableName, "ICProductCustomerNumber", 270);
            AddLookupEditColumn(TableName.ICProductsTableName, "ICProductSupplierNumber", 120);
            AddLookupEditColumn(TableName.ICProductsTableName, "ICProductName", 270);
            AddLookupEditColumn(TableName.ICProductsTableName, "ICProductDesc", 270);
            AddLookupEditColumn(TableName.ICProductsTableName, "ARCustomerName", 270);
            AddLookupEditColumn(TableName.ICProductsTableName, "ARCustomerNo", 150);

            LookUpColumnInfo column = AddLookupEditColumn(TableName.ICProductsTableName, "ICProductPrice01", 60);
            column.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.FormatString = "n0";
        }

        /// <summary>
        /// Add a column to the lookup edit
        /// </summary>
        /// <param name="tableName">Table name of data source is used to get the column caption</param>
        /// <param name="columnName">Column name of data source is used to get the column caption</param>
        /// <returns>Added lookup column</returns>
        private LookUpColumnInfo AddLookupEditColumn(String tableName, String columnName, int width)
        {
            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            AAColumnAliasInfo objColumnAliasInfo = BOSApp.LstColumnAlias.Where(a => a.AAColumnAliasName == columnName && a.AATableName == tableName).FirstOrDefault();
            if (objColumnAliasInfo != null)
            {
                LookUpColumnInfo column = new LookUpColumnInfo();
                column.Caption = objColumnAliasInfo.AAColumnAliasCaption;
                column.FieldName = objColumnAliasInfo.AAColumnAliasName;
                column.Width = width;
                this.Properties.PopupWidth += column.Width;
                this.Properties.Columns.Add(column);
                return column;
            }
            return null;
        }
    }
}
