using System;
using System.Data;
namespace BOSLib
{
    #region STToolbarFunctions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STToolbarFunctionsInfo
    //Created Date:Thursday, March 29, 2007
    //-----------------------------------------------------------

    public class STToolbarFunctionsInfo : BusinessObject
    {
        public STToolbarFunctionsInfo()
        {
        }
        public STToolbarFunctionsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STToolbarFunctionID":
                            this.STToolbarFunctionID = Convert.ToInt32(value);
                            break;
                        case "STToolbarFunctionIDString":
                            this.STToolbarFunctionIDString = Convert.ToString(value);
                            break;
                        case "STToolbarID":
                            this.STToolbarID = Convert.ToInt32(value);
                            break;
                        case "STToolbarFunctionName":
                            this.STToolbarFunctionName = Convert.ToString(value);
                            break;
                        case "STToolbarFunctionFullName":
                            this.STToolbarFunctionFullName = Convert.ToString(value);
                            break;
                        case "STToolbarFunctionClass":
                            this.STToolbarFunctionClass = Convert.ToString(value);
                            break;
                        case "STToolbarFunctionSortOrder":
                            this.STToolbarFunctionSortOrder = Convert.ToInt32(value);
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

        #region Variables
        protected int _sTToolbarFunctionID;
        protected String _sTToolbarFunctionIDString = "0";
        protected int _sTToolbarID;
        protected String _sTToolbarFunctionName = DefaultString;
        protected String _sTToolbarFunctionFullName = DefaultString;
        protected String _sTToolbarFunctionClass = DefaultString;
        protected int _sTToolbarFunctionSortOrder;
        #endregion

        #region Public properties
        public int STToolbarFunctionID
        {
            get { return _sTToolbarFunctionID; }
            set
            {
                if (value != this._sTToolbarFunctionID)
                {
                    _sTToolbarFunctionID = value;
                    NotifyChanged("STToolbarFunctionID");
                }
            }
        }
        public String STToolbarFunctionIDString
        {
            get { return _sTToolbarFunctionIDString; }
            set
            {
                if (value != this._sTToolbarFunctionIDString)
                {
                    _sTToolbarFunctionIDString = value;
                    NotifyChanged("STToolbarFunctionIDString");
                }
            }
        }
        public int STToolbarID
        {
            get { return _sTToolbarID; }
            set
            {
                if (value != this._sTToolbarID)
                {
                    _sTToolbarID = value;
                    NotifyChanged("STToolbarID");
                }
            }
        }
        public String STToolbarFunctionName
        {
            get { return _sTToolbarFunctionName; }
            set
            {
                if (value != this._sTToolbarFunctionName)
                {
                    _sTToolbarFunctionName = value;
                    NotifyChanged("STToolbarFunctionName");
                }
            }
        }
        public String STToolbarFunctionFullName
        {
            get { return _sTToolbarFunctionFullName; }
            set
            {
                if (value != this._sTToolbarFunctionFullName)
                {
                    _sTToolbarFunctionFullName = value;
                    NotifyChanged("STToolbarFunctionFullName");
                }
            }
        }
        public String STToolbarFunctionClass
        {
            get { return _sTToolbarFunctionClass; }
            set
            {
                if (value != this._sTToolbarFunctionClass)
                {
                    _sTToolbarFunctionClass = value;
                    NotifyChanged("STToolbarFunctionClass");
                }
            }
        }
        public int STToolbarFunctionSortOrder
        {
            get { return _sTToolbarFunctionSortOrder; }
            set
            {
                if (value != this._sTToolbarFunctionSortOrder)
                {
                    _sTToolbarFunctionSortOrder = value;
                    NotifyChanged("STToolbarFunctionSortOrder");
                }
            }
        }
        #endregion
    }
    #endregion
}