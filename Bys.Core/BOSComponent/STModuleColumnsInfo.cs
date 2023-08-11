﻿using System;
namespace BOSLib
{
    #region STModuleColumns
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STModuleColumnsInfo
    //Created Date:Monday, November 18, 2013
    //-----------------------------------------------------------

    public class STModuleColumnsInfo : BusinessObject
    {
        public STModuleColumnsInfo()
        {
        }
        #region Variables
        protected int _sTModuleColumnID;
        protected int _sTModuleID;
        protected String _sTModuleTableName = String.Empty;
        protected String _sTModuleColumnName = String.Empty;
        protected bool _isActive = true;
        #endregion

        #region Public properties
        public int STModuleColumnID
        {
            get { return _sTModuleColumnID; }
            set
            {
                if (value != this._sTModuleColumnID)
                {
                    _sTModuleColumnID = value;
                    NotifyChanged("STModuleColumnID");
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
        public String STModuleTableName
        {
            get { return _sTModuleTableName; }
            set
            {
                if (value != this._sTModuleTableName)
                {
                    _sTModuleTableName = value;
                    NotifyChanged("STModuleTableName");
                }
            }
        }
        public String STModuleColumnName
        {
            get { return _sTModuleColumnName; }
            set
            {
                if (value != this._sTModuleColumnName)
                {
                    _sTModuleColumnName = value;
                    NotifyChanged("STModuleColumnName");
                }
            }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (value != this._isActive)
                {
                    _isActive = value;
                    NotifyChanged("IsActive");
                }
            }
        }
        #endregion
    }
    #endregion
}