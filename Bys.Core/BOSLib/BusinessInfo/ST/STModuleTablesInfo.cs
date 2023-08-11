using System;
using System.Data;

namespace BOSLib
{
    #region STModuleTablesInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleTables.
    /// </summary>
    public class STModuleTablesInfo : BusinessObject
    {

        protected int _sTModuleTableID;
        protected int _sTModuleID;
        protected string _sTModuleTableName = DefaultString;
        protected int _sTModuleTableType = DefaultNumber;
        protected int _sTModuleTableLevelIndex;

        public STModuleTablesInfo()
        {
        }
        public STModuleTablesInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleTableID":
                            this.STModuleTableID = Convert.ToInt32(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "STModuleTableName":
                            this.STModuleTableName = Convert.ToString(value);
                            break;
                        case "STModuleTableType":
                            this.STModuleTableType = Convert.ToInt32(value);
                            break;
                        case "STModuleTableLevelIndex":
                            this.STModuleTableLevelIndex = Convert.ToInt32(value);
                            break;
                        case "AllowPropertyChangedEvent":
                            this.AllowPropertyChangedEvent = Convert.ToBoolean(value);
                            break;
                        case "Position":
                            this.Position = Convert.ToInt32(value);
                            break;
                        case "RelatedPosition":
                            this.RelatedPosition = Convert.ToInt32(value);
                            break;
                        case "Selected":
                            this.Selected = Convert.ToBoolean(value);
                            break;
                        case "TheNumberOfChild":
                            this.TheNumberOfChild = Convert.ToInt32(value);
                            break;
                        default:
                            break;
                    }

                }

            }
        }


        public STModuleTablesInfo(int iSTModuleID, string strSTModuleTableName, int iSTModuleTableType, int iSTModuleTableLevelIndex)
        {
            STModuleID = iSTModuleID;
            STModuleTableName = strSTModuleTableName;
            STModuleTableType = iSTModuleTableType;
            STModuleTableLevelIndex = iSTModuleTableLevelIndex;
        }

        #region Public Properties
        public int STModuleTableID
        {
            get { return _sTModuleTableID; }
            set
            {
                if (value != this._sTModuleTableID)
                {
                    _sTModuleTableID = value;
                    NotifyChanged("STModuleTableID");
                }
            }
        }

        public int STModuleID
        {
            get { return _sTModuleID; }
            set
            {
                if (value != this._sTModuleID)
                {
                    _sTModuleID = value;
                    NotifyChanged("STModuleID");
                }
            }
        }

        public string STModuleTableName
        {
            get { return _sTModuleTableName; }
            set
            {
                if (value != this._sTModuleTableName)
                {
                    _sTModuleTableName = value;
                    NotifyChanged("STModuleTableName");
                }
            }
        }

        public int STModuleTableType
        {
            get { return _sTModuleTableType; }
            set
            {
                if (value != this._sTModuleTableType)
                {
                    _sTModuleTableType = value;
                    NotifyChanged("STModuleTableType");
                }
            }
        }

        public int STModuleTableLevelIndex
        {
            get { return _sTModuleTableLevelIndex; }
            set
            {
                if (value != this._sTModuleTableLevelIndex)
                {
                    _sTModuleTableLevelIndex = value;
                    NotifyChanged("STModuleTableLevelIndex");
                }
            }
        }
        #endregion
    }
    #endregion
}
