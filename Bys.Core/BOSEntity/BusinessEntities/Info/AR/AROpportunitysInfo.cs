﻿using BOSLib;
using System;
namespace BOSERP
{
    #region AROpportunitys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:AROpportunitysInfo
    //Created Date:21 Tháng Mười Một 2018
    //-----------------------------------------------------------

    public class AROpportunitysInfo : BusinessObject
    {
        public AROpportunitysInfo()
        {
        }
        #region Variables
        protected int _aROpportunityID;
        protected decimal _aROpportunityAmount;
        protected String _aROpportunityAssignedTo = String.Empty;
        protected String _aROpportunityClassify = String.Empty;
        protected DateTime _aROpportunityCompletionDate = DateTime.MaxValue;
        protected String _aROpportunityContactName = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected int _createdUserID;
        protected String _aROpportunityCustomerName = String.Empty;
        protected String _aROpportunityDescription = String.Empty;
        protected int _fK_HRGroupID;
        protected int _fK_HREmployeeID;
        protected decimal _aROpportunityExpectedValue;
        protected String _aROpportunityName = String.Empty;
        protected String _aROpportunityPotentialSources = String.Empty;
        protected decimal _aROpportunityProbability;
        protected int _rEV;
        protected int _rEVTYPE;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aROpportunityStep = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _updatedUserID;
        protected int _fK_BRBranchID;
        protected int _aRCampaignID;
        protected int _fK_ARCustomerID;
        protected bool _isShare = true;
        protected int _fK_ARCustomerResourceID;
        protected int _fK_ARProspectCustomerID;
        #endregion

        #region Public properties
        public int AROpportunityID
        {
            get { return _aROpportunityID; }
            set
            {
                if (value != this._aROpportunityID)
                {
                    _aROpportunityID = value;
                    NotifyChanged("AROpportunityID");
                }
            }
        }
        public decimal AROpportunityAmount
        {
            get { return _aROpportunityAmount; }
            set
            {
                if (value != this._aROpportunityAmount)
                {
                    _aROpportunityAmount = value;
                    NotifyChanged("AROpportunityAmount");
                }
            }
        }
        public String AROpportunityAssignedTo
        {
            get { return _aROpportunityAssignedTo; }
            set
            {
                if (value != this._aROpportunityAssignedTo)
                {
                    _aROpportunityAssignedTo = value;
                    NotifyChanged("AROpportunityAssignedTo");
                }
            }
        }
        public String AROpportunityClassify
        {
            get { return _aROpportunityClassify; }
            set
            {
                if (value != this._aROpportunityClassify)
                {
                    _aROpportunityClassify = value;
                    NotifyChanged("AROpportunityClassify");
                }
            }
        }
        public DateTime AROpportunityCompletionDate
        {
            get { return _aROpportunityCompletionDate; }
            set
            {
                if (value != this._aROpportunityCompletionDate)
                {
                    _aROpportunityCompletionDate = value;
                    NotifyChanged("AROpportunityCompletionDate");
                }
            }
        }
        public String AROpportunityContactName
        {
            get { return _aROpportunityContactName; }
            set
            {
                if (value != this._aROpportunityContactName)
                {
                    _aROpportunityContactName = value;
                    NotifyChanged("AROpportunityContactName");
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
        public int CreatedUserID
        {
            get { return _createdUserID; }
            set
            {
                if (value != this._createdUserID)
                {
                    _createdUserID = value;
                    NotifyChanged("CreatedUserID");
                }
            }
        }
        public String AROpportunityCustomerName
        {
            get { return _aROpportunityCustomerName; }
            set
            {
                if (value != this._aROpportunityCustomerName)
                {
                    _aROpportunityCustomerName = value;
                    NotifyChanged("AROpportunityCustomerName");
                }
            }
        }
        public String AROpportunityDescription
        {
            get { return _aROpportunityDescription; }
            set
            {
                if (value != this._aROpportunityDescription)
                {
                    _aROpportunityDescription = value;
                    NotifyChanged("AROpportunityDescription");
                }
            }
        }
        public int FK_HRGroupID
        {
            get { return _fK_HRGroupID; }
            set
            {
                if (value != this._fK_HRGroupID)
                {
                    _fK_HRGroupID = value;
                    NotifyChanged("FK_HRGroupID");
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public decimal AROpportunityExpectedValue
        {
            get { return _aROpportunityExpectedValue; }
            set
            {
                if (value != this._aROpportunityExpectedValue)
                {
                    _aROpportunityExpectedValue = value;
                    NotifyChanged("AROpportunityExpectedValue");
                }
            }
        }
        public String AROpportunityName
        {
            get { return _aROpportunityName; }
            set
            {
                if (value != this._aROpportunityName)
                {
                    _aROpportunityName = value;
                    NotifyChanged("AROpportunityName");
                }
            }
        }
        public String AROpportunityPotentialSources
        {
            get { return _aROpportunityPotentialSources; }
            set
            {
                if (value != this._aROpportunityPotentialSources)
                {
                    _aROpportunityPotentialSources = value;
                    NotifyChanged("AROpportunityPotentialSources");
                }
            }
        }
        public decimal AROpportunityProbability
        {
            get { return _aROpportunityProbability; }
            set
            {
                if (value != this._aROpportunityProbability)
                {
                    _aROpportunityProbability = value;
                    NotifyChanged("AROpportunityProbability");
                }
            }
        }
        public int REV
        {
            get { return _rEV; }
            set
            {
                if (value != this._rEV)
                {
                    _rEV = value;
                    NotifyChanged("REV");
                }
            }
        }
        public int REVTYPE
        {
            get { return _rEVTYPE; }
            set
            {
                if (value != this._rEVTYPE)
                {
                    _rEVTYPE = value;
                    NotifyChanged("REVTYPE");
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
        public String AROpportunityStep
        {
            get { return _aROpportunityStep; }
            set
            {
                if (value != this._aROpportunityStep)
                {
                    _aROpportunityStep = value;
                    NotifyChanged("AROpportunityStep");
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
        public int UpdatedUserID
        {
            get { return _updatedUserID; }
            set
            {
                if (value != this._updatedUserID)
                {
                    _updatedUserID = value;
                    NotifyChanged("UpdatedUserID");
                }
            }
        }
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
                }
            }
        }
        public int ARCampaignID
        {
            get { return _aRCampaignID; }
            set
            {
                if (value != this._aRCampaignID)
                {
                    _aRCampaignID = value;
                    NotifyChanged("ARCampaignID");
                }
            }
        }
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
                }
            }
        }
        public bool IsShare
        {
            get { return _isShare; }
            set
            {
                if (value != this._isShare)
                {
                    _isShare = value;
                    NotifyChanged("IsShare");
                }
            }
        }
        public int FK_ARCustomerResourceID
        {
            get { return _fK_ARCustomerResourceID; }
            set
            {
                if (value != this._fK_ARCustomerResourceID)
                {
                    _fK_ARCustomerResourceID = value;
                    NotifyChanged("FK_ARCustomerResourceID");
                }
            }
        }
        public int FK_ARProspectCustomerID
        {
            get { return _fK_ARProspectCustomerID; }
            set
            {
                if (value != this._fK_ARProspectCustomerID)
                {
                    _fK_ARProspectCustomerID = value;
                    NotifyChanged("FK_ARProspectCustomerID");
                }
            }
        }
        #endregion
    }
    #endregion
}