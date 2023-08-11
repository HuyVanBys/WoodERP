using System;
using System.Data;

namespace BOSLib
{
    #region STFieldEventParametersInfo
    /// <summary>
    /// This object represents the properties and methods of a STFieldEventParameters.
    /// </summary>
    public class STFieldEventParametersInfo : BusinessObject
    {

        protected int _sTFieldEventParameterID;
        protected int _sTFieldEventID;
        protected string _sTFieldEventParameterName = DefaultString;
        protected string _sTFieldEventParameterValue = DefaultString;

        public STFieldEventParametersInfo()
        {
        }
        public STFieldEventParametersInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STFieldEventParameterID":
                            this.STFieldEventParameterID = Convert.ToInt32(value);
                            break;
                        case "STFieldEventID":
                            this.STFieldEventID = Convert.ToInt32(value);
                            break;
                        case "STFieldEventParameterName":
                            this.STFieldEventParameterName = Convert.ToString(value);
                            break;
                        case "STFieldEventParameterValue":
                            this.STFieldEventParameterValue = Convert.ToString(value);
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


        public STFieldEventParametersInfo(int iSTFieldEventID, string strSTFieldEventParameterName, string strSTFieldEventParameterValue)
        {
            STFieldEventID = iSTFieldEventID;
            STFieldEventParameterName = strSTFieldEventParameterName;
            STFieldEventParameterValue = strSTFieldEventParameterValue;
        }

        #region Public Properties
        public int STFieldEventParameterID
        {
            get { return _sTFieldEventParameterID; }
            set
            {
                if (value != this._sTFieldEventParameterID)
                {
                    _sTFieldEventParameterID = value;
                    NotifyChanged("STFieldEventParameterID");
                }
            }
        }

        public int STFieldEventID
        {
            get { return _sTFieldEventID; }
            set
            {
                if (value != this._sTFieldEventID)
                {
                    _sTFieldEventID = value;
                    NotifyChanged("STFieldEventID");
                }
            }
        }

        public string STFieldEventParameterName
        {
            get { return _sTFieldEventParameterName; }
            set
            {
                if (value != this._sTFieldEventParameterName)
                {
                    _sTFieldEventParameterName = value;
                    NotifyChanged("STFieldEventParameterName");
                }
            }
        }

        public string STFieldEventParameterValue
        {
            get { return _sTFieldEventParameterValue; }
            set
            {
                if (value != this._sTFieldEventParameterValue)
                {
                    _sTFieldEventParameterValue = value;
                    NotifyChanged("STFieldEventParameterValue");
                }
            }
        }
        #endregion
    }
    #endregion
}
