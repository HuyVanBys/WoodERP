using System;
using System.Data;

namespace BOSLib
{
    #region STFieldEventsInfo
    /// <summary>
    /// This object represents the properties and methods of a STFieldEvents.
    /// </summary>
    public class STFieldEventsInfo : BusinessObject
    {

        protected int _sTFieldEventID;
        protected int _sTFieldID;
        protected string _sTFieldEventName = DefaultString;
        protected string _sTFieldEventDelegateFunctionName = DefaultString;
        protected string _sTFieldEventDelegateFunctionFullName = DefaultString;
        protected string _sTFieldEventDelegateFunctionClass = DefaultString;

        public STFieldEventsInfo()
        {
        }
        public STFieldEventsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STFieldEventID":
                            this.STFieldEventID = Convert.ToInt32(value);
                            break;
                        case "STFieldID":
                            this.STFieldID = Convert.ToInt32(value);
                            break;
                        case "STFieldEventName":
                            this.STFieldEventName = Convert.ToString(value);
                            break;
                        case "STFieldEventDelegateFunctionName":
                            this.STFieldEventDelegateFunctionName = Convert.ToString(value);
                            break;
                        case "STFieldEventDelegateFunctionFullName":
                            this.STFieldEventDelegateFunctionFullName = Convert.ToString(value);
                            break;
                        case "STFieldEventDelegateFunctionClass":
                            this.STFieldEventDelegateFunctionClass = Convert.ToString(value);
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


        public STFieldEventsInfo(int iSTFieldID, string strSTFieldEventName, string strSTFieldEventDelegateFunctionName, string strSTFieldEventDelegateFunctionFullName, string strSTFieldEventDelegateFunctionClass)
        {
            STFieldID = iSTFieldID;
            STFieldEventName = strSTFieldEventName;
            STFieldEventDelegateFunctionName = strSTFieldEventDelegateFunctionName;
            STFieldEventDelegateFunctionFullName = strSTFieldEventDelegateFunctionFullName;
            STFieldEventDelegateFunctionClass = strSTFieldEventDelegateFunctionClass;
        }

        #region Public Properties
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

        public int STFieldID
        {
            get { return _sTFieldID; }
            set
            {
                if (value != this._sTFieldID)
                {
                    _sTFieldID = value;
                    NotifyChanged("STFieldID");
                }
            }
        }

        public string STFieldEventName
        {
            get { return _sTFieldEventName; }
            set
            {
                if (value != this._sTFieldEventName)
                {
                    _sTFieldEventName = value;
                    NotifyChanged("STFieldEventName");
                }
            }
        }

        public string STFieldEventDelegateFunctionName
        {
            get { return _sTFieldEventDelegateFunctionName; }
            set
            {
                if (value != this._sTFieldEventDelegateFunctionName)
                {
                    _sTFieldEventDelegateFunctionName = value;
                    NotifyChanged("STFieldEventDelegateFunctionName");
                }
            }
        }

        public string STFieldEventDelegateFunctionFullName
        {
            get { return _sTFieldEventDelegateFunctionFullName; }
            set
            {
                if (value != this._sTFieldEventDelegateFunctionFullName)
                {
                    _sTFieldEventDelegateFunctionFullName = value;
                    NotifyChanged("STFieldEventDelegateFunctionFullName");
                }
            }
        }

        public string STFieldEventDelegateFunctionClass
        {
            get { return _sTFieldEventDelegateFunctionClass; }
            set
            {
                if (value != this._sTFieldEventDelegateFunctionClass)
                {
                    _sTFieldEventDelegateFunctionClass = value;
                    NotifyChanged("STFieldEventDelegateFunctionClass");
                }
            }
        }
        #endregion
    }
    #endregion
}
