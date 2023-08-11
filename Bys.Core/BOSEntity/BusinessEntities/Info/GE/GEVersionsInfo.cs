﻿using BOSLib;
using System;
namespace BOSERP
{
    #region GEVersions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEVersionsInfo
    //Created Date:Saturday, November 09, 2013
    //-----------------------------------------------------------

    public class GEVersionsInfo : BusinessObject
    {
        public GEVersionsInfo()
        {
        }
        #region Variables
        protected int _gEVersionID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _gEVersionMajor;
        protected int _gEVersionMinor;
        protected int _gEVersionRevision;
        protected int _gEVersionSubRevision;
        protected DateTime _gEVersionDateMod = DateTime.MaxValue;
        protected bool _gEVersionActive = true;
        #endregion

        #region Public properties
        public int GEVersionID
        {
            get { return _gEVersionID; }
            set
            {
                if (value != this._gEVersionID)
                {
                    _gEVersionID = value;
                    NotifyChanged("GEVersionID");
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
        public int GEVersionMajor
        {
            get { return _gEVersionMajor; }
            set
            {
                if (value != this._gEVersionMajor)
                {
                    _gEVersionMajor = value;
                    NotifyChanged("GEVersionMajor");
                }
            }
        }
        public int GEVersionMinor
        {
            get { return _gEVersionMinor; }
            set
            {
                if (value != this._gEVersionMinor)
                {
                    _gEVersionMinor = value;
                    NotifyChanged("GEVersionMinor");
                }
            }
        }
        public int GEVersionRevision
        {
            get { return _gEVersionRevision; }
            set
            {
                if (value != this._gEVersionRevision)
                {
                    _gEVersionRevision = value;
                    NotifyChanged("GEVersionRevision");
                }
            }
        }
        public int GEVersionSubRevision
        {
            get { return _gEVersionSubRevision; }
            set
            {
                if (value != this._gEVersionSubRevision)
                {
                    _gEVersionSubRevision = value;
                    NotifyChanged("GEVersionSubRevision");
                }
            }
        }
        public DateTime GEVersionDateMod
        {
            get { return _gEVersionDateMod; }
            set
            {
                if (value != this._gEVersionDateMod)
                {
                    _gEVersionDateMod = value;
                    NotifyChanged("GEVersionDateMod");
                }
            }
        }
        public bool GEVersionActive
        {
            get { return _gEVersionActive; }
            set
            {
                if (value != this._gEVersionActive)
                {
                    _gEVersionActive = value;
                    NotifyChanged("GEVersionActive");
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}.{3}", GEVersionMajor, GEVersionMinor, GEVersionRevision, GEVersionSubRevision);
        }
    }
    #endregion
}