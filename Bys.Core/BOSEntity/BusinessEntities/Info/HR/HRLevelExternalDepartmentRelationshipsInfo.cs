using BOSLib;
using System;
namespace BOSERP
{
    #region HRLevelExternalDepartmentRelationships
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRLevelExternalDepartmentRelationshipsInfo
    //Created Date:Thursday, July 19, 2018
    //-----------------------------------------------------------

    public class HRLevelExternalDepartmentRelationshipsInfo : BusinessObject
    {
        public HRLevelExternalDepartmentRelationshipsInfo()
        {
        }
        #region Variables
        protected int _hRLevelExternalDepartmentRelationshipID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hRLevelExternalDepartmentRelationshipObjectName = String.Empty;
        protected String _hRLevelExternalDepartmentRelationshipEssence = String.Empty;
        protected int _fK_HRLevelID;
        #endregion

        #region Public properties
        public int HRLevelExternalDepartmentRelationshipID
        {
            get { return _hRLevelExternalDepartmentRelationshipID; }
            set
            {
                if (value != this._hRLevelExternalDepartmentRelationshipID)
                {
                    _hRLevelExternalDepartmentRelationshipID = value;
                    NotifyChanged("HRLevelExternalDepartmentRelationshipID");
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
        public String HRLevelExternalDepartmentRelationshipObjectName
        {
            get { return _hRLevelExternalDepartmentRelationshipObjectName; }
            set
            {
                if (value != this._hRLevelExternalDepartmentRelationshipObjectName)
                {
                    _hRLevelExternalDepartmentRelationshipObjectName = value;
                    NotifyChanged("HRLevelExternalDepartmentRelationshipObjectName");
                }
            }
        }
        public String HRLevelExternalDepartmentRelationshipEssence
        {
            get { return _hRLevelExternalDepartmentRelationshipEssence; }
            set
            {
                if (value != this._hRLevelExternalDepartmentRelationshipEssence)
                {
                    _hRLevelExternalDepartmentRelationshipEssence = value;
                    NotifyChanged("HRLevelExternalDepartmentRelationshipEssence");
                }
            }
        }
        public int FK_HRLevelID
        {
            get { return _fK_HRLevelID; }
            set
            {
                if (value != this._fK_HRLevelID)
                {
                    _fK_HRLevelID = value;
                    NotifyChanged("FK_HRLevelID");
                }
            }
        }
        #endregion
    }
    #endregion
}