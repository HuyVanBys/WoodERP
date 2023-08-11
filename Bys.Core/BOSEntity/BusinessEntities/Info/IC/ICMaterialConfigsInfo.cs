﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICMaterialConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICMaterialConfigsInfo
    //Created Date:Friday, January 18, 2019
    //-----------------------------------------------------------

    public class ICMaterialConfigsInfo : BusinessObject
    {
        public ICMaterialConfigsInfo()
        {
        }
        #region Variables
        protected int _iCMaterialConfigID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _iCMaterialConfigName = String.Empty;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected int _fK_ICProductID;
        protected decimal _iCMaterialConfigQty;
        protected bool _isActive = true;
        protected int _fK_ICProductAttributeSpecialityID;
        protected int _fK_ICMeasureUnitID;
        protected bool _iCMaterialConfigCalByQty = true;
        protected int _fK_ICProductAttHTType;
        protected int _fK_ICProductAttPackingMaterialSpeciality;
        protected String _iCMaterialConfigCalByType = String.Empty;
        protected String _iCMaterialConfigType = String.Empty;
        #endregion

        #region Public properties
        public int ICMaterialConfigID
        {
            get { return _iCMaterialConfigID; }
            set
            {
                if (value != this._iCMaterialConfigID)
                {
                    _iCMaterialConfigID = value;
                    NotifyChanged("ICMaterialConfigID");
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
        public String ICMaterialConfigName
        {
            get { return _iCMaterialConfigName; }
            set
            {
                if (value != this._iCMaterialConfigName)
                {
                    _iCMaterialConfigName = value;
                    NotifyChanged("ICMaterialConfigName");
                }
            }
        }
        public int FK_ICProductAttributeWoodTypeID
        {
            get { return _fK_ICProductAttributeWoodTypeID; }
            set
            {
                if (value != this._fK_ICProductAttributeWoodTypeID)
                {
                    _fK_ICProductAttributeWoodTypeID = value;
                    NotifyChanged("FK_ICProductAttributeWoodTypeID");
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public decimal ICMaterialConfigQty
        {
            get { return _iCMaterialConfigQty; }
            set
            {
                if (value != this._iCMaterialConfigQty)
                {
                    _iCMaterialConfigQty = value;
                    NotifyChanged("ICMaterialConfigQty");
                }
            }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (value != this._isActive)
                {
                    _isActive = value;
                    NotifyChanged("IsActive");
                }
            }
        }
        public int FK_ICProductAttributeSpecialityID
        {
            get { return _fK_ICProductAttributeSpecialityID; }
            set
            {
                if (value != this._fK_ICProductAttributeSpecialityID)
                {
                    _fK_ICProductAttributeSpecialityID = value;
                    NotifyChanged("FK_ICProductAttributeSpecialityID");
                }
            }
        }
        public int FK_ICMeasureUnitID
        {
            get { return _fK_ICMeasureUnitID; }
            set
            {
                if (value != this._fK_ICMeasureUnitID)
                {
                    _fK_ICMeasureUnitID = value;
                    NotifyChanged("FK_ICMeasureUnitID");
                }
            }
        }
        public bool ICMaterialConfigCalByQty
        {
            get { return _iCMaterialConfigCalByQty; }
            set
            {
                if (value != this._iCMaterialConfigCalByQty)
                {
                    _iCMaterialConfigCalByQty = value;
                    NotifyChanged("ICMaterialConfigCalByQty");
                }
            }
        }
        public int FK_ICProductAttHTType
        {
            get { return _fK_ICProductAttHTType; }
            set
            {
                if (value != this._fK_ICProductAttHTType)
                {
                    _fK_ICProductAttHTType = value;
                    NotifyChanged("FK_ICProductAttHTType");
                }
            }
        }
        public int FK_ICProductAttPackingMaterialSpeciality
        {
            get { return _fK_ICProductAttPackingMaterialSpeciality; }
            set
            {
                if (value != this._fK_ICProductAttPackingMaterialSpeciality)
                {
                    _fK_ICProductAttPackingMaterialSpeciality = value;
                    NotifyChanged("FK_ICProductAttPackingMaterialSpeciality");
                }
            }
        }
        public String ICMaterialConfigCalByType
        {
            get { return _iCMaterialConfigCalByType; }
            set
            {
                if (value != this._iCMaterialConfigCalByType)
                {
                    _iCMaterialConfigCalByType = value;
                    NotifyChanged("ICMaterialConfigCalByType");
                }
            }
        }
        public String ICMaterialConfigType
        {
            get { return _iCMaterialConfigType; }
            set
            {
                if (value != this._iCMaterialConfigType)
                {
                    _iCMaterialConfigType = value;
                    NotifyChanged("ICMaterialConfigType");
                }
            }
        }
        #endregion

        #region Extra Property
        public string MMProductionNormItemProductWoodType { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public int FK_ICDepartmentID { get; set; }
        public string ICMaterialConfigProductName { get; set; }
        public string ICMaterialConfigProductNo { get; set; }
        public string ICMeasureUnitName { get; set; }
        public string ICProductSupplierNumber { get; set; }
        public string ICProductSizeAndSpecifiCations { get; set; }
        public string ICMaterialConfigProductDesc { get; set; }
        #endregion

    }
    #endregion
}