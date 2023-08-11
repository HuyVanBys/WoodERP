using System;
using System.Data;

namespace BOSLib
{
    #region STFieldTabStops
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STFieldTabStopsInfo
    //Created Date:Saturday, March 08, 2008
    //-----------------------------------------------------------

    public class STFieldTabStopsInfo : BusinessObject
    {
        public STFieldTabStopsInfo()
        {
        }
        public STFieldTabStopsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STFieldTabStopID":
                            this.STFieldTabStopID = Convert.ToInt32(value);
                            break;
                        case "STFieldName":
                            this.STFieldName = Convert.ToString(value);
                            break;
                        case "STFieldType":
                            this.STFieldType = Convert.ToString(value);
                            break;
                        case "STFieldDataSource":
                            this.STFieldDataSource = Convert.ToString(value);
                            break;
                        case "STFieldDataMember":
                            this.STFieldDataMember = Convert.ToString(value);
                            break;
                        case "STFieldTabStopSortOrder":
                            this.STFieldTabStopSortOrder = Convert.ToInt32(value);
                            break;
                        case "STFieldTabStopAction":
                            this.STFieldTabStopAction = Convert.ToString(value);
                            break;
                        case "STFieldTabStopModuleName":
                            this.STFieldTabStopModuleName = Convert.ToString(value);
                            break;
                        case "STFieldTabStopGroupName":
                            this.STFieldTabStopGroupName = Convert.ToString(value);
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
        protected int _sTFieldTabStopID;
        protected String _sTFieldName = String.Empty;
        protected String _sTFieldType = String.Empty;
        protected String _sTFieldDataSource = String.Empty;
        protected String _sTFieldDataMember = String.Empty;
        protected int _sTFieldTabStopSortOrder;
        protected String _sTFieldTabStopAction = String.Empty;
        protected String _sTFieldTabStopModuleName = String.Empty;
        protected String _sTFieldTabStopGroupName = String.Empty;
        #endregion

        #region Public properties
        public int STFieldTabStopID
        {
            get { return _sTFieldTabStopID; }
            set
            {
                if (value != this._sTFieldTabStopID)
                {
                    _sTFieldTabStopID = value;
                    NotifyChanged("STFieldTabStopID");
                }
            }
        }
        public String STFieldName
        {
            get { return _sTFieldName; }
            set
            {
                if (value != this._sTFieldName)
                {
                    _sTFieldName = value;
                    NotifyChanged("STFieldName");
                }
            }
        }
        public String STFieldType
        {
            get { return _sTFieldType; }
            set
            {
                if (value != this._sTFieldType)
                {
                    _sTFieldType = value;
                    NotifyChanged("STFieldType");
                }
            }
        }
        public String STFieldDataSource
        {
            get { return _sTFieldDataSource; }
            set
            {
                if (value != this._sTFieldDataSource)
                {
                    _sTFieldDataSource = value;
                    NotifyChanged("STFieldDataSource");
                }
            }
        }
        public String STFieldDataMember
        {
            get { return _sTFieldDataMember; }
            set
            {
                if (value != this._sTFieldDataMember)
                {
                    _sTFieldDataMember = value;
                    NotifyChanged("STFieldDataMember");
                }
            }
        }
        public int STFieldTabStopSortOrder
        {
            get { return _sTFieldTabStopSortOrder; }
            set
            {
                if (value != this._sTFieldTabStopSortOrder)
                {
                    _sTFieldTabStopSortOrder = value;
                    NotifyChanged("STFieldTabStopSortOrder");
                }
            }
        }
        public String STFieldTabStopAction
        {
            get { return _sTFieldTabStopAction; }
            set
            {
                if (value != this._sTFieldTabStopAction)
                {
                    _sTFieldTabStopAction = value;
                    NotifyChanged("STFieldTabStopAction");
                }
            }
        }
        public String STFieldTabStopModuleName
        {
            get { return _sTFieldTabStopModuleName; }
            set
            {
                if (value != this._sTFieldTabStopModuleName)
                {
                    _sTFieldTabStopModuleName = value;
                    NotifyChanged("STFieldTabStopModuleName");
                }
            }
        }
        public String STFieldTabStopGroupName
        {
            get { return _sTFieldTabStopGroupName; }
            set
            {
                if (value != this._sTFieldTabStopGroupName)
                {
                    _sTFieldTabStopGroupName = value;
                    NotifyChanged("STFieldTabStopGroupName");
                }
            }
        }
        #endregion
    }
    #endregion
}