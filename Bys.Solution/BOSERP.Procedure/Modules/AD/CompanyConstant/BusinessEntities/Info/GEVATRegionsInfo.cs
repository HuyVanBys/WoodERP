using BOSLib;
using System;
namespace BOSERP
{
    #region GEVATRegions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEVATRegionsInfo
    //Created Date:Saturday, April 07, 2007
    //-----------------------------------------------------------

    public class GEVATRegionsInfo : BusinessObject
    {
        public GEVATRegionsInfo()
        {
        }
        #region Variables
        protected int _gEVATRegionID;
        protected String _aANumberString = String.Empty;
        protected int _aANumberInt;
        protected String _aAStat = String.Empty;
        protected String _gEVATRegionName = DefaultString;
        protected String _gEVATRegionDesc = String.Empty;
        #endregion

        #region Public properties
        public int GEVATRegionID
        {
            get { return _gEVATRegionID; }
            set
            {
                if (value != this._gEVATRegionID)
                {
                    _gEVATRegionID = value;
                    NotifyChanged("GEVATRegionID");
                }
            }
        }
        public String AANumberString
        {
            get { return _aANumberString; }
            set
            {
                if (value != this._aANumberString)
                {
                    _aANumberString = value;
                    NotifyChanged("AANumberString");
                }
            }
        }
        public int AANumberInt
        {
            get { return _aANumberInt; }
            set
            {
                if (value != this._aANumberInt)
                {
                    _aANumberInt = value;
                    NotifyChanged("AANumberInt");
                }
            }
        }
        public String AAStat
        {
            get { return _aAStat; }
            set
            {
                if (value != this._aAStat)
                {
                    _aAStat = value;
                    NotifyChanged("AAStat");
                }
            }
        }
        public String GEVATRegionName
        {
            get { return _gEVATRegionName; }
            set
            {
                if (value != this._gEVATRegionName)
                {
                    _gEVATRegionName = value;
                    NotifyChanged("GEVATRegionName");
                }
            }
        }
        public String GEVATRegionDesc
        {
            get { return _gEVATRegionDesc; }
            set
            {
                if (value != this._gEVATRegionDesc)
                {
                    _gEVATRegionDesc = value;
                    NotifyChanged("GEVATRegionDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}