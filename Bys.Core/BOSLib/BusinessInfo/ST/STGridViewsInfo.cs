using System;
using System.Data;

namespace BOSLib
{
    #region STGridViewsInfo
    /// <summary>
    /// This object represents the properties and methods of a STGridViews.
    /// </summary>
    public class STGridViewsInfo : BusinessObject
    {

        protected int _sTGridViewID;
        protected string _sTGridViewType = DefaultString;
        protected string _sTGridViewName = DefaultString;
        protected int _sTFieldID;
        protected bool _sTMainView;
        protected bool _sTGridViewEditable;
        protected string _sTGridViewNewItemRowPosition = DefaultString;
        protected bool _sTGridViewColumnAutoWidth;

        public STGridViewsInfo()
        {
        }
        public STGridViewsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STGridViewID":
                            this.STGridViewID = Convert.ToInt32(value);
                            break;
                        case "STGridViewType":
                            this.STGridViewType = Convert.ToString(value);
                            break;
                        case "STGridViewName":
                            this.STGridViewName = Convert.ToString(value);
                            break;
                        case "STFieldID":
                            this.STFieldID = Convert.ToInt32(value);
                            break;
                        case "STMainView":
                            this.STMainView = Convert.ToBoolean(value);
                            break;
                        case "STGridViewEditable":
                            this.STGridViewEditable = Convert.ToBoolean(value);
                            break;
                        case "STGridViewNewItemRowPosition":
                            this.STGridViewNewItemRowPosition = Convert.ToString(value);
                            break;
                        case "STGridViewColumnAutoWidth":
                            this.STGridViewColumnAutoWidth = Convert.ToBoolean(value);
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


        public STGridViewsInfo(string strSTGridViewType, string strSTGridViewName, int iSTFieldID, bool bSTMainView, bool bSTGridViewEditable, string strSTGridViewNewItemRowPosition, bool bSTGridViewColumnAutoWidth)
        {
            STGridViewType = strSTGridViewType;
            STGridViewName = strSTGridViewName;
            STFieldID = iSTFieldID;
            STMainView = bSTMainView;
            STGridViewEditable = bSTGridViewEditable;
            STGridViewNewItemRowPosition = strSTGridViewNewItemRowPosition;
            STGridViewColumnAutoWidth = bSTGridViewColumnAutoWidth;
        }

        #region Public Properties
        public int STGridViewID
        {
            get { return _sTGridViewID; }
            set
            {
                if (value != this._sTGridViewID)
                {
                    _sTGridViewID = value;
                    NotifyChanged("STGridViewID");
                }
            }
        }

        public string STGridViewType
        {
            get { return _sTGridViewType; }
            set
            {
                if (value != this._sTGridViewType)
                {
                    _sTGridViewType = value;
                    NotifyChanged("STGridViewType");
                }
            }
        }

        public string STGridViewName
        {
            get { return _sTGridViewName; }
            set
            {
                if (value != this._sTGridViewName)
                {
                    _sTGridViewName = value;
                    NotifyChanged("STGridViewName");
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

        public bool STMainView
        {
            get { return _sTMainView; }
            set
            {
                if (value != this._sTMainView)
                {
                    _sTMainView = value;
                    NotifyChanged("STMainView");
                }
            }
        }

        public bool STGridViewEditable
        {
            get { return _sTGridViewEditable; }
            set
            {
                if (value != this._sTGridViewEditable)
                {
                    _sTGridViewEditable = value;
                    NotifyChanged("STGridViewEditable");
                }
            }
        }

        public string STGridViewNewItemRowPosition
        {
            get { return _sTGridViewNewItemRowPosition; }
            set
            {
                if (value != this._sTGridViewNewItemRowPosition)
                {
                    _sTGridViewNewItemRowPosition = value;
                    NotifyChanged("STGridViewNewItemRowPosition");
                }
            }
        }

        public bool STGridViewColumnAutoWidth
        {
            get { return _sTGridViewColumnAutoWidth; }
            set
            {
                if (value != this._sTGridViewColumnAutoWidth)
                {
                    _sTGridViewColumnAutoWidth = value;
                    NotifyChanged("STGridViewColumnAutoWidth");
                }
            }
        }
        #endregion
    }
    #endregion
}
