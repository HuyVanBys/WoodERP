using System;
using System.Data;

namespace BOSLib
{
    #region STModuleFunctionsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleFunctions.
    /// </summary>
    public class STModuleFunctionsInfo : BusinessObject
    {

        protected int _sTModuleFunctionID;
        protected int _sTModuleID;
        protected string _sTModuleFunctionName = DefaultString;
        protected string _sTModuleFunctionFullName = DefaultString;
        protected string _sTModuleFunctionReturnType = DefaultString;
        protected string _sTModuleFunctionClass = DefaultString;
        protected string _sTModuleFunctionSummary = String.Empty;
        protected string _sTModuleFunctionType = String.Empty;

        public STModuleFunctionsInfo()
        {
        }
        public STModuleFunctionsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleFunctionID":
                            this.STModuleFunctionID = Convert.ToInt32(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "STModuleFunctionName":
                            this.STModuleFunctionName = Convert.ToString(value);
                            break;
                        case "STModuleFunctionFullName":
                            this.STModuleFunctionFullName = Convert.ToString(value);
                            break;
                        case "STModuleFunctionReturnType":
                            this.STModuleFunctionReturnType = Convert.ToString(value);
                            break;
                        case "STModuleFunctionClass":
                            this.STModuleFunctionClass = Convert.ToString(value);
                            break;
                        case "STModuleFunctionSummary":
                            this.STModuleFunctionSummary = Convert.ToString(value);
                            break;
                        case "STModuleFunctionType":
                            this.STModuleFunctionType = Convert.ToString(value);
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


        public STModuleFunctionsInfo(int iSTModuleID, string strSTModuleFunctionName, string strSTModuleFunctionFullName, string strSTModuleFunctionReturnType, string strSTModuleFunctionClass, string strSTModuleFunctionSummary, string strSTModuleFunctionType)
        {
            STModuleID = iSTModuleID;
            STModuleFunctionName = strSTModuleFunctionName;
            STModuleFunctionFullName = strSTModuleFunctionFullName;
            STModuleFunctionReturnType = strSTModuleFunctionReturnType;
            STModuleFunctionClass = strSTModuleFunctionClass;
            STModuleFunctionSummary = strSTModuleFunctionSummary;
            STModuleFunctionType = strSTModuleFunctionType;
        }

        #region Public Properties
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

        public string STModuleFunctionName
        {
            get { return _sTModuleFunctionName; }
            set
            {
                if (value != this._sTModuleFunctionName)
                {
                    _sTModuleFunctionName = value;
                    NotifyChanged("STModuleFunctionName");
                }
            }
        }

        public string STModuleFunctionFullName
        {
            get { return _sTModuleFunctionFullName; }
            set
            {
                if (value != this._sTModuleFunctionFullName)
                {
                    _sTModuleFunctionFullName = value;
                    NotifyChanged("STModuleFunctionFullName");
                }
            }
        }

        public string STModuleFunctionReturnType
        {
            get { return _sTModuleFunctionReturnType; }
            set
            {
                if (value != this._sTModuleFunctionReturnType)
                {
                    _sTModuleFunctionReturnType = value;
                    NotifyChanged("STModuleFunctionReturnType");
                }
            }
        }

        public string STModuleFunctionClass
        {
            get { return _sTModuleFunctionClass; }
            set
            {
                if (value != this._sTModuleFunctionClass)
                {
                    _sTModuleFunctionClass = value;
                    NotifyChanged("STModuleFunctionClass");
                }
            }
        }

        public string STModuleFunctionSummary
        {
            get { return _sTModuleFunctionSummary; }
            set
            {
                if (value != this._sTModuleFunctionSummary)
                {
                    _sTModuleFunctionSummary = value;
                    NotifyChanged("STModuleFunctionSummary");
                }
            }
        }

        public string STModuleFunctionType
        {
            get { return _sTModuleFunctionType; }
            set
            {
                if (value != this._sTModuleFunctionType)
                {
                    _sTModuleFunctionType = value;
                    NotifyChanged("STModuleFunctionType");
                }
            }
        }
        #endregion
    }
    #endregion
}
