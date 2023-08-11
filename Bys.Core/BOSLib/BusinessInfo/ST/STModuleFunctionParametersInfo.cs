using System;
using System.Data;

namespace BOSLib
{
    #region STModuleFunctionParametersInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleFunctionParameters.
    /// </summary>
    public class STModuleFunctionParametersInfo : BusinessObject
    {

        protected int _sTModuleFunctionParameterID;
        protected int _sTModuleFunctionID;
        protected string _sTModuleFunctionParameterType = DefaultString;
        protected string _sTModuleFunctionParameterName = DefaultString;

        public STModuleFunctionParametersInfo()
        {
        }
        public STModuleFunctionParametersInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleFunctionParameterID":
                            this.STModuleFunctionParameterID = Convert.ToInt32(value);
                            break;
                        case "STModuleFunctionID":
                            this.STModuleFunctionID = Convert.ToInt32(value);
                            break;
                        case "STModuleFunctionParameterType":
                            this.STModuleFunctionParameterType = Convert.ToString(value);
                            break;
                        case "STModuleFunctionParameterName":
                            this.STModuleFunctionParameterName = Convert.ToString(value);
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


        public STModuleFunctionParametersInfo(int iSTModuleFunctionID, string strSTModuleFunctionParameterType, string strSTModuleFunctionParameterName)
        {
            STModuleFunctionID = iSTModuleFunctionID;
            STModuleFunctionParameterType = strSTModuleFunctionParameterType;
            STModuleFunctionParameterName = strSTModuleFunctionParameterName;
        }

        #region Public Properties
        public int STModuleFunctionParameterID
        {
            get { return _sTModuleFunctionParameterID; }
            set
            {
                if (value != this._sTModuleFunctionParameterID)
                {
                    _sTModuleFunctionParameterID = value;
                    NotifyChanged("STModuleFunctionParameterID");
                }
            }
        }

        public int STModuleFunctionID
        {
            get { return _sTModuleFunctionID; }
            set
            {
                if (value != this._sTModuleFunctionID)
                {
                    _sTModuleFunctionID = value;
                    NotifyChanged("STModuleFunctionID");
                }
            }
        }

        public string STModuleFunctionParameterType
        {
            get { return _sTModuleFunctionParameterType; }
            set
            {
                if (value != this._sTModuleFunctionParameterType)
                {
                    _sTModuleFunctionParameterType = value;
                    NotifyChanged("STModuleFunctionParameterType");
                }
            }
        }

        public string STModuleFunctionParameterName
        {
            get { return _sTModuleFunctionParameterName; }
            set
            {
                if (value != this._sTModuleFunctionParameterName)
                {
                    _sTModuleFunctionParameterName = value;
                    NotifyChanged("STModuleFunctionParameterName");
                }
            }
        }
        #endregion
    }
    #endregion
}
