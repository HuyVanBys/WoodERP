using System;
using System.Data;

namespace BOSLib
{
    #region STFieldEventFunctionParametersInfo
    /// <summary>
    /// This object represents the properties and methods of a STFieldEventFunctionParameters.
    /// </summary>
    public class STFieldEventFunctionParametersInfo : BusinessObject
    {

        protected int _sTFieldEventFunctionParameterID;
        protected int _sTFieldEventFunctionID;
        protected string _sTFieldEventFunctionParameterName = DefaultString;
        protected string _sTFieldEventFunctionParameterValue = DefaultString;
        protected string _sTFieldEventFunctionParameterType = DefaultString;

        public STFieldEventFunctionParametersInfo()
        {
        }
        public STFieldEventFunctionParametersInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STFieldEventFunctionParameterID":
                            this.STFieldEventFunctionParameterID = Convert.ToInt32(value);
                            break;
                        case "STFieldEventFunctionID":
                            this.STFieldEventFunctionID = Convert.ToInt32(value);
                            break;
                        case "STFieldEventFunctionParameterName":
                            this.STFieldEventFunctionParameterName = Convert.ToString(value);
                            break;
                        case "STFieldEventFunctionParameterValue":
                            this.STFieldEventFunctionParameterValue = Convert.ToString(value);
                            break;
                        case "STFieldEventFunctionParameterType":
                            this.STFieldEventFunctionParameterType = Convert.ToString(value);
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


        public STFieldEventFunctionParametersInfo(int iSTFieldEventFunctionID, string strSTFieldEventFunctionParameterName, string strSTFieldEventFunctionParameterValue, string strSTFieldEventFunctionParameterType)
        {
            STFieldEventFunctionID = iSTFieldEventFunctionID;
            STFieldEventFunctionParameterName = strSTFieldEventFunctionParameterName;
            STFieldEventFunctionParameterValue = strSTFieldEventFunctionParameterValue;
            STFieldEventFunctionParameterType = strSTFieldEventFunctionParameterType;
        }

        #region Public Properties
        public int STFieldEventFunctionParameterID
        {
            get { return _sTFieldEventFunctionParameterID; }
            set
            {
                if (value != this._sTFieldEventFunctionParameterID)
                {
                    _sTFieldEventFunctionParameterID = value;
                    NotifyChanged("STFieldEventFunctionParameterID");
                }
            }
        }

        public int STFieldEventFunctionID
        {
            get { return _sTFieldEventFunctionID; }
            set
            {
                if (value != this._sTFieldEventFunctionID)
                {
                    _sTFieldEventFunctionID = value;
                    NotifyChanged("STFieldEventFunctionID");
                }
            }
        }

        public string STFieldEventFunctionParameterName
        {
            get { return _sTFieldEventFunctionParameterName; }
            set
            {
                if (value != this._sTFieldEventFunctionParameterName)
                {
                    _sTFieldEventFunctionParameterName = value;
                    NotifyChanged("STFieldEventFunctionParameterName");
                }
            }
        }

        public string STFieldEventFunctionParameterValue
        {
            get { return _sTFieldEventFunctionParameterValue; }
            set
            {
                if (value != this._sTFieldEventFunctionParameterValue)
                {
                    _sTFieldEventFunctionParameterValue = value;
                    NotifyChanged("STFieldEventFunctionParameterValue");
                }
            }
        }

        public string STFieldEventFunctionParameterType
        {
            get { return _sTFieldEventFunctionParameterType; }
            set
            {
                if (value != this._sTFieldEventFunctionParameterType)
                {
                    _sTFieldEventFunctionParameterType = value;
                    NotifyChanged("STFieldEventFunctionParameterType");
                }
            }
        }
        #endregion
    }
    #endregion
}
