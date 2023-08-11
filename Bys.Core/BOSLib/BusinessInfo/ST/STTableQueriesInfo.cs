using System;
using System.Data;

namespace BOSLib
{
    #region STTableQueriesInfo
    /// <summary>
    /// This object represents the properties and methods of a STTableQueries.
    /// </summary>
    public class STTableQueriesInfo : BusinessObject
    {

        protected int _sTTableQueryID;
        protected string _sTTableName = DefaultString;
        protected string _sTTableQueryKey = DefaultString;
        protected string _sTTableQueryCommand = DefaultString;

        public STTableQueriesInfo()
        {
        }
        public STTableQueriesInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STTableQueryID":
                            this.STTableQueryID = Convert.ToInt32(value);
                            break;
                        case "STTableName":
                            this.STTableName = Convert.ToString(value);
                            break;
                        case "STTableQueryKey":
                            this.STTableQueryKey = Convert.ToString(value);
                            break;
                        case "STTableQueryCommand":
                            this.STTableQueryCommand = Convert.ToString(value);
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


        public STTableQueriesInfo(string strSTTableName, string strSTTableQueryKey, string strSTTableQueryCommand)
        {
            STTableName = strSTTableName;
            STTableQueryKey = strSTTableQueryKey;
            STTableQueryCommand = strSTTableQueryCommand;
        }

        #region Public Properties
        public int STTableQueryID
        {
            get { return _sTTableQueryID; }
            set
            {
                if (value != this._sTTableQueryID)
                {
                    _sTTableQueryID = value;
                    NotifyChanged("STTableQueryID");
                }
            }
        }

        public string STTableName
        {
            get { return _sTTableName; }
            set
            {
                if (value != this._sTTableName)
                {
                    _sTTableName = value;
                    NotifyChanged("STTableName");
                }
            }
        }

        public string STTableQueryKey
        {
            get { return _sTTableQueryKey; }
            set
            {
                if (value != this._sTTableQueryKey)
                {
                    _sTTableQueryKey = value;
                    NotifyChanged("STTableQueryKey");
                }
            }
        }

        public string STTableQueryCommand
        {
            get { return _sTTableQueryCommand; }
            set
            {
                if (value != this._sTTableQueryCommand)
                {
                    _sTTableQueryCommand = value;
                    NotifyChanged("STTableQueryCommand");
                }
            }
        }
        #endregion
    }
    #endregion
}
