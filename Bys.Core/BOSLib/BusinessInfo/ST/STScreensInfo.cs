using System;
using System.Data;
namespace BOSLib
{
    #region STScreens
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STScreensInfo
    //Created Date:Sunday, October 31, 2010
    //-----------------------------------------------------------

    public class STScreensInfo : BusinessObject
    {
        public STScreensInfo()
        {
        }
        public STScreensInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STScreenID":
                            this.STScreenID = Convert.ToInt32(value);
                            break;
                        case "STScreenNumber":
                            this.STScreenNumber = Convert.ToString(value);
                            break;
                        case "STScreenText":
                            this.STScreenText = Convert.ToString(value);
                            break;
                        case "STScreenName":
                            this.STScreenName = Convert.ToString(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "STUserGroupID":
                            this.STUserGroupID = Convert.ToInt32(value);
                            break;
                        case "STScreenBackColor":
                            this.STScreenBackColor = Convert.ToInt32(value);
                            break;
                        case "STScreenForeColor":
                            this.STScreenForeColor = Convert.ToInt32(value);
                            break;
                        case "STScreenFontName":
                            this.STScreenFontName = Convert.ToString(value);
                            break;
                        case "STScreenFontSize":
                            this.STScreenFontSize = Convert.ToDouble(value);
                            break;
                        case "STScreenFontStyle":
                            this.STScreenFontStyle = Convert.ToString(value);
                            break;
                        case "STScreenTag":
                            this.STScreenTag = Convert.ToString(value);
                            break;
                        case "STScreenSizeWidth":
                            this.STScreenSizeWidth = Convert.ToInt32(value);
                            break;
                        case "STScreenSizeHeight":
                            this.STScreenSizeHeight = Convert.ToInt32(value);
                            break;
                        case "STScreenLocationX":
                            this.STScreenLocationX = Convert.ToInt32(value);
                            break;
                        case "STScreenLocationY":
                            this.STScreenLocationY = Convert.ToInt32(value);
                            break;
                        case "STScreenShowModal":
                            this.STScreenShowModal = Convert.ToBoolean(value);
                            break;
                        case "STScreenTopMost":
                            this.STScreenTopMost = Convert.ToBoolean(value);
                            break;
                        case "STScreenMatchCode01":
                            this.STScreenMatchCode01 = Convert.ToString(value);
                            break;
                        case "STScreenShowInfoPanel":
                            this.STScreenShowInfoPanel = Convert.ToBoolean(value);
                            break;
                        case "STScreenSortOrder":
                            this.STScreenSortOrder = Convert.ToInt32(value);
                            break;
                        case "STScreenPrivilege":
                            this.STScreenPrivilege = Convert.ToString(value);
                            break;
                        case "STScreenVisible":
                            this.STScreenVisible = Convert.ToBoolean(value);
                            break;
                        case "STScreenPermissionType":
                            this.STScreenPermissionType = (Byte)value;
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
                        case "STModuleName":
                            this.STModuleName = Convert.ToString(value);
                            break;
                        case "FK_ADUserGroupID":
                            this.FK_ADUserGroupID = Convert.ToInt32(value);
                            break;
                        default:
                            break;
                    }

                }

            }
        }

        #region Variables
        protected int _sTScreenID;
        protected String _sTScreenNumber = String.Empty;
        protected String _sTScreenText = String.Empty;
        protected String _sTScreenName = String.Empty;
        protected int _sTModuleID;
        protected int _sTUserGroupID;
        protected int _sTScreenBackColor;
        protected int _sTScreenForeColor;
        protected String _sTScreenFontName = String.Empty;
        protected double _sTScreenFontSize;
        protected String _sTScreenFontStyle = String.Empty;
        protected String _sTScreenTag = String.Empty;
        protected int _sTScreenSizeWidth;
        protected int _sTScreenSizeHeight;
        protected int _sTScreenLocationX;
        protected int _sTScreenLocationY;
        protected bool _sTScreenShowModal = true;
        protected bool _sTScreenTopMost = true;
        protected String _sTScreenMatchCode01 = String.Empty;
        protected bool _sTScreenShowInfoPanel = true;
        protected int _sTScreenSortOrder;
        protected String _sTScreenPrivilege = String.Empty;
        protected bool _sTScreenVisible = true;
        #endregion

        #region Public properties
        public int STScreenID
        {
            get { return _sTScreenID; }
            set
            {
                if (value != this._sTScreenID)
                {
                    _sTScreenID = value;
                    NotifyChanged("STScreenID");
                }
            }
        }
        public String STScreenNumber
        {
            get { return _sTScreenNumber; }
            set
            {
                if (value != this._sTScreenNumber)
                {
                    _sTScreenNumber = value;
                    NotifyChanged("STScreenNumber");
                }
            }
        }
        public String STScreenText
        {
            get { return _sTScreenText; }
            set
            {
                if (value != this._sTScreenText)
                {
                    _sTScreenText = value;
                    NotifyChanged("STScreenText");
                }
            }
        }
        public String STScreenName
        {
            get { return _sTScreenName; }
            set
            {
                if (value != this._sTScreenName)
                {
                    _sTScreenName = value;
                    NotifyChanged("STScreenName");
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
        public int STScreenBackColor
        {
            get { return _sTScreenBackColor; }
            set
            {
                if (value != this._sTScreenBackColor)
                {
                    _sTScreenBackColor = value;
                    NotifyChanged("STScreenBackColor");
                }
            }
        }
        public int STScreenForeColor
        {
            get { return _sTScreenForeColor; }
            set
            {
                if (value != this._sTScreenForeColor)
                {
                    _sTScreenForeColor = value;
                    NotifyChanged("STScreenForeColor");
                }
            }
        }
        public String STScreenFontName
        {
            get { return _sTScreenFontName; }
            set
            {
                if (value != this._sTScreenFontName)
                {
                    _sTScreenFontName = value;
                    NotifyChanged("STScreenFontName");
                }
            }
        }
        public double STScreenFontSize
        {
            get { return _sTScreenFontSize; }
            set
            {
                if (value != this._sTScreenFontSize)
                {
                    _sTScreenFontSize = value;
                    NotifyChanged("STScreenFontSize");
                }
            }
        }
        public String STScreenFontStyle
        {
            get { return _sTScreenFontStyle; }
            set
            {
                if (value != this._sTScreenFontStyle)
                {
                    _sTScreenFontStyle = value;
                    NotifyChanged("STScreenFontStyle");
                }
            }
        }
        public String STScreenTag
        {
            get { return _sTScreenTag; }
            set
            {
                if (value != this._sTScreenTag)
                {
                    _sTScreenTag = value;
                    NotifyChanged("STScreenTag");
                }
            }
        }
        public int STScreenSizeWidth
        {
            get { return _sTScreenSizeWidth; }
            set
            {
                if (value != this._sTScreenSizeWidth)
                {
                    _sTScreenSizeWidth = value;
                    NotifyChanged("STScreenSizeWidth");
                }
            }
        }
        public int STScreenSizeHeight
        {
            get { return _sTScreenSizeHeight; }
            set
            {
                if (value != this._sTScreenSizeHeight)
                {
                    _sTScreenSizeHeight = value;
                    NotifyChanged("STScreenSizeHeight");
                }
            }
        }
        public int STScreenLocationX
        {
            get { return _sTScreenLocationX; }
            set
            {
                if (value != this._sTScreenLocationX)
                {
                    _sTScreenLocationX = value;
                    NotifyChanged("STScreenLocationX");
                }
            }
        }
        public int STScreenLocationY
        {
            get { return _sTScreenLocationY; }
            set
            {
                if (value != this._sTScreenLocationY)
                {
                    _sTScreenLocationY = value;
                    NotifyChanged("STScreenLocationY");
                }
            }
        }
        public bool STScreenShowModal
        {
            get { return _sTScreenShowModal; }
            set
            {
                if (value != this._sTScreenShowModal)
                {
                    _sTScreenShowModal = value;
                    NotifyChanged("STScreenShowModal");
                }
            }
        }
        public bool STScreenTopMost
        {
            get { return _sTScreenTopMost; }
            set
            {
                if (value != this._sTScreenTopMost)
                {
                    _sTScreenTopMost = value;
                    NotifyChanged("STScreenTopMost");
                }
            }
        }
        public String STScreenMatchCode01
        {
            get { return _sTScreenMatchCode01; }
            set
            {
                if (value != this._sTScreenMatchCode01)
                {
                    _sTScreenMatchCode01 = value;
                    NotifyChanged("STScreenMatchCode01");
                }
            }
        }
        public bool STScreenShowInfoPanel
        {
            get { return _sTScreenShowInfoPanel; }
            set
            {
                if (value != this._sTScreenShowInfoPanel)
                {
                    _sTScreenShowInfoPanel = value;
                    NotifyChanged("STScreenShowInfoPanel");
                }
            }
        }
        public int STScreenSortOrder
        {
            get { return _sTScreenSortOrder; }
            set
            {
                if (value != this._sTScreenSortOrder)
                {
                    _sTScreenSortOrder = value;
                    NotifyChanged("STScreenSortOrder");
                }
            }
        }
        public String STScreenPrivilege
        {
            get { return _sTScreenPrivilege; }
            set
            {
                if (value != this._sTScreenPrivilege)
                {
                    _sTScreenPrivilege = value;
                    NotifyChanged("STScreenPrivilege");
                }
            }
        }
        public bool STScreenVisible
        {
            get { return _sTScreenVisible; }
            set
            {
                if (value != this._sTScreenVisible)
                {
                    _sTScreenVisible = value;
                    NotifyChanged("STScreenVisible");
                }
            }
        }
        #endregion

        #region Extra Properties
        public byte STScreenPermissionType { get; set; }
        public string STModuleName { get; set; }
        public int FK_ADUserGroupID { get; set; }
        #endregion
    }
    #endregion
}