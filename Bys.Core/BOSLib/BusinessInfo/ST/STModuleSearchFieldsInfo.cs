using System;
using System.Data;

namespace BOSLib
{
    #region STModuleSearchFieldsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleSearchFields.
    /// </summary>
    public class STModuleSearchFieldsInfo : BusinessObject
    {

        protected int _sTModuleSearchFieldID;
        protected int _sTModuleStatusID;
        protected string _sTModuleSearchFieldName = DefaultString;
        protected string _sTModuleSearchFieldValue = String.Empty;

        public STModuleSearchFieldsInfo()
        {
        }
        public STModuleSearchFieldsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleSearchFieldID":
                            this.STModuleSearchFieldID = Convert.ToInt32(value);
                            break;
                        case "STModuleStatusID":
                            this.STModuleStatusID = Convert.ToInt32(value);
                            break;
                        case "STModuleSearchFieldName":
                            this.STModuleSearchFieldName = Convert.ToString(value);
                            break;
                        case "STModuleSearchFieldValue":
                            this.STModuleSearchFieldValue = Convert.ToString(value);
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


        public STModuleSearchFieldsInfo(int iSTModuleStatusID, string strSTModuleSearchFieldName, string strSTModuleSearchFieldValue)
        {
            STModuleStatusID = iSTModuleStatusID;
            STModuleSearchFieldName = strSTModuleSearchFieldName;
            STModuleSearchFieldValue = strSTModuleSearchFieldValue;
        }

        #region Public Properties
        public int STModuleSearchFieldID
        {
            get { return _sTModuleSearchFieldID; }
            set
            {
                if (value != this._sTModuleSearchFieldID)
                {
                    _sTModuleSearchFieldID = value;
                    NotifyChanged("STModuleSearchFieldID");
                }
            }
        }

        public int STModuleStatusID
        {
            get { return _sTModuleStatusID; }
            set
            {
                if (value != this._sTModuleStatusID)
                {
                    _sTModuleStatusID = value;
                    NotifyChanged("STModuleStatusID");
                }
            }
        }

        public string STModuleSearchFieldName
        {
            get { return _sTModuleSearchFieldName; }
            set
            {
                if (value != this._sTModuleSearchFieldName)
                {
                    _sTModuleSearchFieldName = value;
                    NotifyChanged("STModuleSearchFieldName");
                }
            }
        }

        public string STModuleSearchFieldValue
        {
            get { return _sTModuleSearchFieldValue; }
            set
            {
                if (value != this._sTModuleSearchFieldValue)
                {
                    _sTModuleSearchFieldValue = value;
                    NotifyChanged("STModuleSearchFieldValue");
                }
            }
        }
        #endregion
    }
    #endregion
}
