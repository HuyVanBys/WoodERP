﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARDeliveryPlanTruckPoints
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDeliveryPlanTruckPointsInfo
    //Created Date:Friday, March 23, 2018
    //-----------------------------------------------------------

    public class ARDeliveryPlanTruckPointsInfo : BusinessObject
    {
        public ARDeliveryPlanTruckPointsInfo()
        {
        }
        #region Variables
        protected int _aRDeliveryPlanTruckPointID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARDeliveryPlanID;
        protected int _fK_ARDeliveryPlanTruckID;
        protected String _aRDeliveryPlanTruckPointAddress = String.Empty;
        protected decimal _aRDeliveryPlanTruckPointLongitude;
        protected decimal _aRDeliveryPlanTruckPointLatitude;
        protected DateTime _aRDeliveryPlanTruckPointEstimateDate = DateTime.MaxValue;
        protected DateTime _aRDeliveryPlanTruckPointActualDate = DateTime.MaxValue;
        protected String _aRDeliveryPlanTruckPointStatus = DefaultStatus;
        protected String _aRDeliveryPlanTruckPointNo = String.Empty;
        protected String _aRDeliveryPlanTruckPointNote = String.Empty;
        protected decimal _aRDeliveryPlanTruckPointDriverLongitude;
        protected decimal _aRDeliveryPlanTruckPointDriverLatitude;
        protected DateTime _aRDeliveryPlanTruckPointDriverLastDate = DateTime.MaxValue;
        protected String _aRDeliveryPlanTruckPointStreet = String.Empty;
        protected String _aRDeliveryPlanTruckPointWard = String.Empty;
        protected int _fK_GEDeliveryDistrictID;
        protected int _fK_GEDeliveryStateProvinceID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARCustomerID;
        protected String _aRDeliveryPlanTruckPointDesc = String.Empty;
        protected int _fK_ICProductTruckID;
        protected DateTime _aRDeliveryPlanTruckPointEstimatedHour = DateTime.MaxValue;
        protected DateTime _aRDeliveryPlanTruckPointArrivalTime = DateTime.MaxValue;
        protected DateTime _aRDeliveryPlanTruckPointSubmitArrivalTime = DateTime.MaxValue;
        protected String _aRDeliveryPlanTruckPointArrivalDescription = String.Empty;
        protected DateTime _aRDeliveryPlanTruckPointStartedDeliveryTime = DateTime.MaxValue;
        protected int _fK_ICTransferID;
        protected int _fK_ARSaleReturnID;
        #endregion

        #region Public properties
        public int ARDeliveryPlanTruckPointID
        {
            get { return _aRDeliveryPlanTruckPointID; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointID)
                {
                    _aRDeliveryPlanTruckPointID = value;
                    NotifyChanged("ARDeliveryPlanTruckPointID");
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
        public int FK_ARDeliveryPlanID
        {
            get { return _fK_ARDeliveryPlanID; }
            set
            {
                if (value != this._fK_ARDeliveryPlanID)
                {
                    _fK_ARDeliveryPlanID = value;
                    NotifyChanged("FK_ARDeliveryPlanID");
                }
            }
        }
        public int FK_ARDeliveryPlanTruckID
        {
            get { return _fK_ARDeliveryPlanTruckID; }
            set
            {
                if (value != this._fK_ARDeliveryPlanTruckID)
                {
                    _fK_ARDeliveryPlanTruckID = value;
                    NotifyChanged("FK_ARDeliveryPlanTruckID");
                }
            }
        }
        public String ARDeliveryPlanTruckPointAddress
        {
            get { return _aRDeliveryPlanTruckPointAddress; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointAddress)
                {
                    _aRDeliveryPlanTruckPointAddress = value;
                    NotifyChanged("ARDeliveryPlanTruckPointAddress");
                }
            }
        }
        public decimal ARDeliveryPlanTruckPointLongitude
        {
            get { return _aRDeliveryPlanTruckPointLongitude; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointLongitude)
                {
                    _aRDeliveryPlanTruckPointLongitude = value;
                    NotifyChanged("ARDeliveryPlanTruckPointLongitude");
                }
            }
        }
        public decimal ARDeliveryPlanTruckPointLatitude
        {
            get { return _aRDeliveryPlanTruckPointLatitude; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointLatitude)
                {
                    _aRDeliveryPlanTruckPointLatitude = value;
                    NotifyChanged("ARDeliveryPlanTruckPointLatitude");
                }
            }
        }
        public DateTime ARDeliveryPlanTruckPointEstimateDate
        {
            get { return _aRDeliveryPlanTruckPointEstimateDate; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointEstimateDate)
                {
                    _aRDeliveryPlanTruckPointEstimateDate = value;
                    NotifyChanged("ARDeliveryPlanTruckPointEstimateDate");
                }
            }
        }
        public DateTime ARDeliveryPlanTruckPointActualDate
        {
            get { return _aRDeliveryPlanTruckPointActualDate; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointActualDate)
                {
                    _aRDeliveryPlanTruckPointActualDate = value;
                    NotifyChanged("ARDeliveryPlanTruckPointActualDate");
                }
            }
        }
        public String ARDeliveryPlanTruckPointStatus
        {
            get { return _aRDeliveryPlanTruckPointStatus; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointStatus)
                {
                    _aRDeliveryPlanTruckPointStatus = value;
                    NotifyChanged("ARDeliveryPlanTruckPointStatus");
                }
            }
        }
        public String ARDeliveryPlanTruckPointNo
        {
            get { return _aRDeliveryPlanTruckPointNo; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointNo)
                {
                    _aRDeliveryPlanTruckPointNo = value;
                    NotifyChanged("ARDeliveryPlanTruckPointNo");
                }
            }
        }
        public String ARDeliveryPlanTruckPointNote
        {
            get { return _aRDeliveryPlanTruckPointNote; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointNote)
                {
                    _aRDeliveryPlanTruckPointNote = value;
                    NotifyChanged("ARDeliveryPlanTruckPointNote");
                }
            }
        }
        public decimal ARDeliveryPlanTruckPointDriverLongitude
        {
            get { return _aRDeliveryPlanTruckPointDriverLongitude; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointDriverLongitude)
                {
                    _aRDeliveryPlanTruckPointDriverLongitude = value;
                    NotifyChanged("ARDeliveryPlanTruckPointDriverLongitude");
                }
            }
        }
        public decimal ARDeliveryPlanTruckPointDriverLatitude
        {
            get { return _aRDeliveryPlanTruckPointDriverLatitude; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointDriverLatitude)
                {
                    _aRDeliveryPlanTruckPointDriverLatitude = value;
                    NotifyChanged("ARDeliveryPlanTruckPointDriverLatitude");
                }
            }
        }
        public DateTime ARDeliveryPlanTruckPointDriverLastDate
        {
            get { return _aRDeliveryPlanTruckPointDriverLastDate; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointDriverLastDate)
                {
                    _aRDeliveryPlanTruckPointDriverLastDate = value;
                    NotifyChanged("ARDeliveryPlanTruckPointDriverLastDate");
                }
            }
        }
        public String ARDeliveryPlanTruckPointStreet
        {
            get { return _aRDeliveryPlanTruckPointStreet; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointStreet)
                {
                    _aRDeliveryPlanTruckPointStreet = value;
                    NotifyChanged("ARDeliveryPlanTruckPointStreet");
                }
            }
        }
        public String ARDeliveryPlanTruckPointWard
        {
            get { return _aRDeliveryPlanTruckPointWard; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointWard)
                {
                    _aRDeliveryPlanTruckPointWard = value;
                    NotifyChanged("ARDeliveryPlanTruckPointWard");
                }
            }
        }
        public int FK_GEDeliveryDistrictID
        {
            get { return _fK_GEDeliveryDistrictID; }
            set
            {
                if (value != this._fK_GEDeliveryDistrictID)
                {
                    _fK_GEDeliveryDistrictID = value;
                    NotifyChanged("FK_GEDeliveryDistrictID");
                }
            }
        }
        public int FK_GEDeliveryStateProvinceID
        {
            get { return _fK_GEDeliveryStateProvinceID; }
            set
            {
                if (value != this._fK_GEDeliveryStateProvinceID)
                {
                    _fK_GEDeliveryStateProvinceID = value;
                    NotifyChanged("FK_GEDeliveryStateProvinceID");
                }
            }
        }
        public int FK_ARSaleOrderID
        {
            get { return _fK_ARSaleOrderID; }
            set
            {
                if (value != this._fK_ARSaleOrderID)
                {
                    _fK_ARSaleOrderID = value;
                    NotifyChanged("FK_ARSaleOrderID");
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
        public String ARDeliveryPlanTruckPointDesc
        {
            get { return _aRDeliveryPlanTruckPointDesc; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointDesc)
                {
                    _aRDeliveryPlanTruckPointDesc = value;
                    NotifyChanged("ARDeliveryPlanTruckPointDesc");
                }
            }
        }
        public int FK_ICProductTruckID
        {
            get { return _fK_ICProductTruckID; }
            set
            {
                if (value != this._fK_ICProductTruckID)
                {
                    _fK_ICProductTruckID = value;
                    NotifyChanged("FK_ICProductTruckID");
                }
            }
        }
        public DateTime ARDeliveryPlanTruckPointEstimatedHour
        {
            get { return _aRDeliveryPlanTruckPointEstimatedHour; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointEstimatedHour)
                {
                    _aRDeliveryPlanTruckPointEstimatedHour = value;
                    NotifyChanged("ARDeliveryPlanTruckPointEstimatedHour");
                }
            }
        }
        public DateTime ARDeliveryPlanTruckPointArrivalTime
        {
            get { return _aRDeliveryPlanTruckPointArrivalTime; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointArrivalTime)
                {
                    _aRDeliveryPlanTruckPointArrivalTime = value;
                    NotifyChanged("ARDeliveryPlanTruckPointArrivalTime");
                }
            }
        }
        public DateTime ARDeliveryPlanTruckPointSubmitArrivalTime
        {
            get { return _aRDeliveryPlanTruckPointSubmitArrivalTime; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointSubmitArrivalTime)
                {
                    _aRDeliveryPlanTruckPointSubmitArrivalTime = value;
                    NotifyChanged("ARDeliveryPlanTruckPointSubmitArrivalTime");
                }
            }
        }
        public String ARDeliveryPlanTruckPointArrivalDescription
        {
            get { return _aRDeliveryPlanTruckPointArrivalDescription; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointArrivalDescription)
                {
                    _aRDeliveryPlanTruckPointArrivalDescription = value;
                    NotifyChanged("ARDeliveryPlanTruckPointArrivalDescription");
                }
            }
        }
        public DateTime ARDeliveryPlanTruckPointStartedDeliveryTime
        {
            get { return _aRDeliveryPlanTruckPointStartedDeliveryTime; }
            set
            {
                if (value != this._aRDeliveryPlanTruckPointStartedDeliveryTime)
                {
                    _aRDeliveryPlanTruckPointStartedDeliveryTime = value;
                    NotifyChanged("ARDeliveryPlanTruckPointStartedDeliveryTime");
                }
            }
        }
        public int FK_ICTransferID
        {
            get { return _fK_ICTransferID; }
            set
            {
                if (value != this._fK_ICTransferID)
                {
                    _fK_ICTransferID = value;
                    NotifyChanged("FK_ICTransferID");
                }
            }
        }
        public int FK_ARSaleReturnID
        {
            get { return _fK_ARSaleReturnID; }
            set
            {
                if (value != this._fK_ARSaleReturnID)
                {
                    _fK_ARSaleReturnID = value;
                    NotifyChanged("FK_ARSaleReturnID");
                }
            }
        }
        #endregion

        #region Extra

        public String ARDeliveryPlanTruckPointDeliveryPlanNo { get; set; }

        public String ARDeliveryPlanTruckPointCustomerName { get; set; }

        public String ARDeliveryPlanTruckPointEmployeeDeliveryName { get; set; }

        public String ARDeliveryPlanTruckSource { get; set; }

        public String ARDeliveryPlanTruckName { get; set; }

        public String ARDeliveryPlanTruckNumber { get; set; }

        #endregion
    }
    #endregion
}