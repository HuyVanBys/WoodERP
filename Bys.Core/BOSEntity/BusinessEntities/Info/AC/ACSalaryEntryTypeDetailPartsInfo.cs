﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACSalaryEntryTypeDetailParts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACSalaryEntryTypeDetailPartsInfo
    //Created Date:Thứ Năm, Tháng Năm 9, 2019
    //-----------------------------------------------------------

    public class ACSalaryEntryTypeDetailPartsInfo : BusinessObject
    {
        public ACSalaryEntryTypeDetailPartsInfo()
        {
        }
        #region Variables
        protected int _aCSalaryEntryTypeDetailPartID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ACSalaryEntryTypeID;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_HRLevelID;
        #endregion

        #region Public properties
        public int ACSalaryEntryTypeDetailPartID
        {
            get { return _aCSalaryEntryTypeDetailPartID; }
            set
            {
                if (value != this._aCSalaryEntryTypeDetailPartID)
                {
                    _aCSalaryEntryTypeDetailPartID = value;
                    NotifyChanged("ACSalaryEntryTypeDetailPartID");
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
        public int FK_ACSalaryEntryTypeID
        {
            get { return _fK_ACSalaryEntryTypeID; }
            set
            {
                if (value != this._fK_ACSalaryEntryTypeID)
                {
                    _fK_ACSalaryEntryTypeID = value;
                    NotifyChanged("FK_ACSalaryEntryTypeID");
                }
            }
        }
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public int FK_HRDepartmentRoomID
        {
            get { return _fK_HRDepartmentRoomID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomID)
                {
                    _fK_HRDepartmentRoomID = value;
                    NotifyChanged("FK_HRDepartmentRoomID");
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