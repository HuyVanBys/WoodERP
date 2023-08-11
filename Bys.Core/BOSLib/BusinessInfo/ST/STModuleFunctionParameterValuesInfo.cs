using System;
using System.Data;

namespace BOSLib
{
    #region STModuleFunctionParameterValuesInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleFunctionParameterValues.
    /// </summary>
    public class STModuleFunctionParameterValuesInfo : BusinessObject
    {

        protected int _sTModuleFunctionParameterValueID;
        protected int _sTModuleFunctionParameterID;
        protected int _sTUserGroupID;
        protected string _sTModuleFunctionParameterValue = DefaultString;

        public STModuleFunctionParameterValuesInfo()
        {
        }
        public STModuleFunctionParameterValuesInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleFunctionParameterValueID":
                            this.STModuleFunctionParameterValueID = Convert.ToInt32(value);
                            break;
                        case "STModuleFunctionParameterID":
                            this.STModuleFunctionParameterID = Convert.ToInt32(value);
                            break;
                        case "STUserGroupID":
                            this.STUserGroupID = Convert.ToInt32(value);
                            break;
                        case "STModuleFunctionParameterValue":
                            this.STModuleFunctionParameterValue = Convert.ToString(value);
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


        public STModuleFunctionParameterValuesInfo(int iSTModuleFunctionParameterID, int iSTUserGroupID, string strSTModuleFunctionParameterValue)
        {
            STModuleFunctionParameterID = iSTModuleFunctionParameterID;
            STUserGroupID = iSTUserGroupID;
            STModuleFunctionParameterValue = strSTModuleFunctionParameterValue;
        }

        #region Public Properties
        public int STModuleFunctionParameterValueID
        {
            get { return _sTModuleFunctionParameterValueID; }
            set
            {
                if (value != this._sTModuleFunctionParameterValueID)
                {
                    _sTModuleFunctionParameterValueID = value;
                    NotifyChanged("STModuleFunctionParameterValueID");
                }
            }
        }

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

        public int STUserGroupID
        {
            get { return _sTUserGroupID; }
            set
            {
                if (value != this._sTUserGroupID)
                {
                    _sTUserGroupID = value;
                    NotifyChanged("STUserGroupID");
                }
            }
        }

        public string STModuleFunctionParameterValue
        {
            get { return _sTModuleFunctionParameterValue; }
            set
            {
                if (value != this._sTModuleFunctionParameterValue)
                {
                    _sTModuleFunctionParameterValue = value;
                    NotifyChanged("STModuleFunctionParameterValue");
                }
            }
        }
        #endregion
    }
    #endregion
}
