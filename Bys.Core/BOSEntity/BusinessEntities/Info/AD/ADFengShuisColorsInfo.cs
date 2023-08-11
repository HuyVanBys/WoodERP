using BOSLib;
using System;
namespace BOSERP
{
    #region ADFengShuisColors
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADFengShuisColorsInfo
    //Created Date:Tuesday, July 10, 2018
    //-----------------------------------------------------------

    public class ADFengShuisColorsInfo : BusinessObject
    {
        public ADFengShuisColorsInfo()
        {
        }
        #region Variables
        protected int _aDFengShuisColorID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aDFengShuisColorLife = String.Empty;
        protected String _aDFengShuisColorMutual = String.Empty;
        protected String _aDFengShuisColorHarmony = String.Empty;
        protected String _aDFengShuisColorFightDown = String.Empty;
        protected String _aDFengShuisColorConflict = String.Empty;
        #endregion

        #region Public properties
        public int ADFengShuisColorID
        {
            get { return _aDFengShuisColorID; }
            set
            {
                if (value != this._aDFengShuisColorID)
                {
                    _aDFengShuisColorID = value;
                    NotifyChanged("ADFengShuisColorID");
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
        public String ADFengShuisColorLife
        {
            get { return _aDFengShuisColorLife; }
            set
            {
                if (value != this._aDFengShuisColorLife)
                {
                    _aDFengShuisColorLife = value;
                    NotifyChanged("ADFengShuisColorLife");
                }
            }
        }
        public String ADFengShuisColorMutual
        {
            get { return _aDFengShuisColorMutual; }
            set
            {
                if (value != this._aDFengShuisColorMutual)
                {
                    _aDFengShuisColorMutual = value;
                    NotifyChanged("ADFengShuisColorMutual");
                }
            }
        }
        public String ADFengShuisColorHarmony
        {
            get { return _aDFengShuisColorHarmony; }
            set
            {
                if (value != this._aDFengShuisColorHarmony)
                {
                    _aDFengShuisColorHarmony = value;
                    NotifyChanged("ADFengShuisColorHarmony");
                }
            }
        }
        public String ADFengShuisColorFightDown
        {
            get { return _aDFengShuisColorFightDown; }
            set
            {
                if (value != this._aDFengShuisColorFightDown)
                {
                    _aDFengShuisColorFightDown = value;
                    NotifyChanged("ADFengShuisColorFightDown");
                }
            }
        }
        public String ADFengShuisColorConflict
        {
            get { return _aDFengShuisColorConflict; }
            set
            {
                if (value != this._aDFengShuisColorConflict)
                {
                    _aDFengShuisColorConflict = value;
                    NotifyChanged("ADFengShuisColorConflict");
                }
            }
        }
        #endregion
    }
    #endregion
}