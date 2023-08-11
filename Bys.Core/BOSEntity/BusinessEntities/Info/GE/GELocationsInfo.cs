﻿using BOSLib;
using System;
namespace BOSERP
{
    #region GELocations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GELocationsInfo
    //Created Date:Monday, September 05, 2011
    //-----------------------------------------------------------

    public class GELocationsInfo : BOSTreeListObject
    {
        public GELocationsInfo()
        {
        }

        public GELocationsInfo(String locationName)
        {
            this.GELocationName = locationName;
        }
        #region Variables
        protected int _gELocationID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _gELocationName = String.Empty;
        protected String _gELocationDesc = String.Empty;
        protected String _gELocationType = String.Empty;
        protected String _gELocationCode = String.Empty;
        protected int _gELocationParentID;
        protected int _fK_GEObjectID;
        protected String _gELocationAbbreviation = String.Empty;
        #endregion

        #region Public properties
        public int GELocationID
        {
            get { return _gELocationID; }
            set
            {
                if (value != this._gELocationID)
                {
                    _gELocationID = value;
                    NotifyChanged("GELocationID");
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
        public DateTime AACreatedDate
        {
            get { return _aACreatedDate; }
            set
            {
                if (value != this._aACreatedDate)
                {
                    _aACreatedDate = value;
                    NotifyChanged("AACreatedDate");
                }
            }
        }
        public String AACreatedUser
        {
            get { return _aACreatedUser; }
            set
            {
                if (value != this._aACreatedUser)
                {
                    _aACreatedUser = value;
                    NotifyChanged("AACreatedUser");
                }
            }
        }
        public DateTime AAUpdatedDate
        {
            get { return _aAUpdatedDate; }
            set
            {
                if (value != this._aAUpdatedDate)
                {
                    _aAUpdatedDate = value;
                    NotifyChanged("AAUpdatedDate");
                }
            }
        }
        public String AAUpdatedUser
        {
            get { return _aAUpdatedUser; }
            set
            {
                if (value != this._aAUpdatedUser)
                {
                    _aAUpdatedUser = value;
                    NotifyChanged("AAUpdatedUser");
                }
            }
        }
        public String GELocationName
        {
            get { return _gELocationName; }
            set
            {
                if (value != this._gELocationName)
                {
                    _gELocationName = value;
                    NotifyChanged("GELocationName");
                }
            }
        }
        public String GELocationDesc
        {
            get { return _gELocationDesc; }
            set
            {
                if (value != this._gELocationDesc)
                {
                    _gELocationDesc = value;
                    NotifyChanged("GELocationDesc");
                }
            }
        }
        public String GELocationType
        {
            get { return _gELocationType; }
            set
            {
                if (value != this._gELocationType)
                {
                    _gELocationType = value;
                    NotifyChanged("GELocationType");
                }
            }
        }
        public int GELocationParentID
        {
            get { return _gELocationParentID; }
            set
            {
                if (value != this._gELocationParentID)
                {
                    _gELocationParentID = value;
                    NotifyChanged("GELocationParentID");
                }
            }
        }
        public int FK_GEObjectID
        {
            get { return _fK_GEObjectID; }
            set
            {
                if (value != this._fK_GEObjectID)
                {
                    _fK_GEObjectID = value;
                    NotifyChanged("FK_GEObjectID");
                }
            }
        }
        public String GELocationCode
        {
            get { return _gELocationCode; }
            set
            {
                if (value != this._gELocationCode)
                {
                    _gELocationCode = value;
                    NotifyChanged("GELocationCode");
                }
            }
        }
        public string GELocationAbbreviation
        {
            get { return _gELocationAbbreviation; }
            set
            {
                if (value != this._gELocationAbbreviation)
                {
                    _gELocationAbbreviation = value;
                    NotifyChanged("GELocationAbbreviation");
                }
            }
        }
        #endregion
    }
    #endregion
}