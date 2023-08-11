﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ADReportViewRefs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADReportViewRefsInfo
    //Created Date:Saturday, April 20, 2019
    //-----------------------------------------------------------

    public class ADReportViewRefsInfo : BusinessObject
    {
        public ADReportViewRefsInfo()
        {
        }
        #region Variables
        protected int _aDReportViewRefID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ADReportViewID;
        protected String _aDReportViewRefType = String.Empty;
        protected String _aDReportViewRefName = String.Empty;
        protected String _aDReportViewRefCol = String.Empty;
        protected String _aDReportViewRefDataSource = String.Empty;
        protected String _aDReportViewRefStoreProc = String.Empty;
        protected String _aDReportViewRefNo = String.Empty;
        protected bool _aDReportViewRefDrillDown = true;
        protected String _aDReportViewRefFieldModuleName = String.Empty;
        protected String _aDReportViewRefDrillDownValue = String.Empty;
        #endregion

        #region Public properties
        public int ADReportViewRefID
        {
            get { return _aDReportViewRefID; }
            set
            {
                if (value != this._aDReportViewRefID)
                {
                    _aDReportViewRefID = value;
                    NotifyChanged("ADReportViewRefID");
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if (value != this._aAStatus)
                {
                    _aAStatus = value;
                    NotifyChanged("AAStatus");
                }
            }
        }
        public int FK_ADReportViewID
        {
            get { return _fK_ADReportViewID; }
            set
            {
                if (value != this._fK_ADReportViewID)
                {
                    _fK_ADReportViewID = value;
                    NotifyChanged("FK_ADReportViewID");
                }
            }
        }
        public String ADReportViewRefType
        {
            get { return _aDReportViewRefType; }
            set
            {
                if (value != this._aDReportViewRefType)
                {
                    _aDReportViewRefType = value;
                    NotifyChanged("ADReportViewRefType");
                }
            }
        }
        public String ADReportViewRefName
        {
            get { return _aDReportViewRefName; }
            set
            {
                if (value != this._aDReportViewRefName)
                {
                    _aDReportViewRefName = value;
                    NotifyChanged("ADReportViewRefName");
                }
            }
        }
        public String ADReportViewRefCol
        {
            get { return _aDReportViewRefCol; }
            set
            {
                if (value != this._aDReportViewRefCol)
                {
                    _aDReportViewRefCol = value;
                    NotifyChanged("ADReportViewRefCol");
                }
            }
        }
        public String ADReportViewRefDataSource
        {
            get { return _aDReportViewRefDataSource; }
            set
            {
                if (value != this._aDReportViewRefDataSource)
                {
                    _aDReportViewRefDataSource = value;
                    NotifyChanged("ADReportViewRefDataSource");
                }
            }
        }
        public String ADReportViewRefStoreProc
        {
            get { return _aDReportViewRefStoreProc; }
            set
            {
                if (value != this._aDReportViewRefStoreProc)
                {
                    _aDReportViewRefStoreProc = value;
                    NotifyChanged("ADReportViewRefStoreProc");
                }
            }
        }
        public String ADReportViewRefNo
        {
            get { return _aDReportViewRefNo; }
            set
            {
                if (value != this._aDReportViewRefNo)
                {
                    _aDReportViewRefNo = value;
                    NotifyChanged("ADReportViewRefNo");
                }
            }
        }
        public bool ADReportViewRefDrillDown
        {
            get { return _aDReportViewRefDrillDown; }
            set
            {
                if (value != this._aDReportViewRefDrillDown)
                {
                    _aDReportViewRefDrillDown = value;
                    NotifyChanged("ADReportViewRefDrillDown");
                }
            }
        }
        public String ADReportViewRefFieldModuleName
        {
            get { return _aDReportViewRefFieldModuleName; }
            set
            {
                if (value != this._aDReportViewRefFieldModuleName)
                {
                    _aDReportViewRefFieldModuleName = value;
                    NotifyChanged("ADReportViewRefFieldModuleName");
                }
            }
        }
        public String ADReportViewRefDrillDownValue
        {
            get { return _aDReportViewRefDrillDownValue; }
            set
            {
                if (value != this._aDReportViewRefDrillDownValue)
                {
                    _aDReportViewRefDrillDownValue = value;
                    NotifyChanged("ADReportViewRefDrillDownValue");
                }
            }
        }
        #endregion
    }
    #endregion
}