using BOSLib;
using System;
namespace BOSERP
{
    #region HRTimesheetGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRTimesheetGroupsInfo
    //Created Date:Wednesday, October 09, 2013
    //-----------------------------------------------------------

    public class HRTimesheetGroupsInfo : BusinessObject
    {
        public HRTimesheetGroupsInfo()
        {
        }
        #region Variables
        protected int _hRTimesheetGroupID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hRTimesheetGroupName = String.Empty;
        protected String _hRTimesheetGroupRemarks = String.Empty;
        #endregion

        #region Public properties
        public int HRTimesheetGroupID
        {
            get { return _hRTimesheetGroupID; }
            set
            {
                if (value != this._hRTimesheetGroupID)
                {
                    _hRTimesheetGroupID = value;
                    NotifyChanged("HRTimesheetGroupID");
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
        public String HRTimesheetGroupName
        {
            get { return _hRTimesheetGroupName; }
            set
            {
                if (value != this._hRTimesheetGroupName)
                {
                    _hRTimesheetGroupName = value;
                    NotifyChanged("HRTimesheetGroupName");
                }
            }
        }
        public String HRTimesheetGroupRemarks
        {
            get { return _hRTimesheetGroupRemarks; }
            set
            {
                if (value != this._hRTimesheetGroupRemarks)
                {
                    _hRTimesheetGroupRemarks = value;
                    NotifyChanged("HRTimesheetGroupRemarks");
                }
            }
        }
        #endregion
    }
    #endregion
}