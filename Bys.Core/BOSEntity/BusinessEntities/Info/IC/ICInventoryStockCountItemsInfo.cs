﻿using BOSLib;
using BOSLib.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
namespace BOSERP
{
    #region ICInventoryStockCountItemsInfo
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICInventoryStockCountItemsInfo
    //Created Date:Monday, March 11, 2013
    //-----------------------------------------------------------

    [Table("ICInventoryStockCountItems")]
    public class ICInventoryStockCountItemsInfo : BusinessObject, IEntity
    {
        public ICInventoryStockCountItemsInfo()
        {
        }
        #region Variables
        [Key]
        [Column("ICInventoryStockCountItemID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICInventoryStockCountID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected decimal _iCInventoryStockCountItemQuantity;
        protected decimal _iCInventoryStockCountItemActualQuantity;
        protected String _iCInventoryStockCountItemICProductSupplierNumber = String.Empty;
        protected String _iCInventoryStockCountItemICProductDesc = String.Empty;
        protected int _fK_ICStockSlotID;
        protected int _fK_ICProductSerieID;
        protected String _iCInventoryStockCountItemProductSerialNo = String.Empty;
        protected decimal _iCInventoryStockActualUnitCost;
        protected String _iCInventoryStockCountItemPackageBarcode = String.Empty;
        protected decimal _iCInventoryStockCountItemPackageQty;
        protected String _iCInventoryStockCountItemDesc = String.Empty;
        protected decimal _iCInventoryStockCountItemProductQty;
        protected int _fK_ICProductPackageItemID;
        protected int _fK_ICProductPackageID;
        protected String _iCInventoryStockCountItemProductNo = String.Empty;
        protected bool _iCInventoryStockCountItemIsSpecificCalculation = true;
        protected bool _iCInventoryStockCountItemIsAverageCalculation = true;
        protected decimal _iCInventoryStockUnitCostAVG;
        protected decimal _iCInventoryStockActualTotalCost;
        #endregion

        #region Public properties
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
        public int FK_ICInventoryStockCountID
        {
            get { return _fK_ICInventoryStockCountID; }
            set
            {
                if (value != this._fK_ICInventoryStockCountID)
                {
                    _fK_ICInventoryStockCountID = value;
                    NotifyChanged("FK_ICInventoryStockCountID");
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
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                    NotifyChanged("FK_ICStockID");
                }
            }
        }
        public decimal ICInventoryStockCountItemQuantity
        {
            get { return _iCInventoryStockCountItemQuantity; }
            set
            {
                if (value != this._iCInventoryStockCountItemQuantity)
                {
                    _iCInventoryStockCountItemQuantity = value;
                    NotifyChanged("ICInventoryStockCountItemQuantity");
                }
            }
        }
        public decimal ICInventoryStockCountItemActualQuantity
        {
            get { return _iCInventoryStockCountItemActualQuantity; }
            set
            {
                if (value != this._iCInventoryStockCountItemActualQuantity)
                {
                    _iCInventoryStockCountItemActualQuantity = value;
                    NotifyChanged("ICInventoryStockCountItemActualQuantity");
                }
            }
        }
        public String ICInventoryStockCountItemICProductSupplierNumber
        {
            get { return _iCInventoryStockCountItemICProductSupplierNumber; }
            set
            {
                if (value != this._iCInventoryStockCountItemICProductSupplierNumber)
                {
                    _iCInventoryStockCountItemICProductSupplierNumber = value;
                    NotifyChanged("ICInventoryStockCountItemICProductSupplierNumber");
                }
            }
        }
        public String ICInventoryStockCountItemICProductDesc
        {
            get { return _iCInventoryStockCountItemICProductDesc; }
            set
            {
                if (value != this._iCInventoryStockCountItemICProductDesc)
                {
                    _iCInventoryStockCountItemICProductDesc = value;
                    NotifyChanged("ICInventoryStockCountItemICProductDesc");
                }
            }
        }
        public int FK_ICStockSlotID
        {
            get { return _fK_ICStockSlotID; }
            set
            {
                if (value != this._fK_ICStockSlotID)
                {
                    _fK_ICStockSlotID = value;
                    NotifyChanged("FK_ICStockSlotID");
                }
            }
        }
        public int FK_ICProductSerieID
        {
            get { return _fK_ICProductSerieID; }
            set
            {
                if (value != this._fK_ICProductSerieID)
                {
                    _fK_ICProductSerieID = value;
                    NotifyChanged("FK_ICProductSerieID");
                }
            }
        }
        public String ICInventoryStockCountItemProductSerialNo
        {
            get { return _iCInventoryStockCountItemProductSerialNo; }
            set
            {
                if (value != this._iCInventoryStockCountItemProductSerialNo)
                {
                    _iCInventoryStockCountItemProductSerialNo = value;
                    NotifyChanged("ICInventoryStockCountItemProductSerialNo");
                }
            }
        }
        public decimal ICInventoryStockActualUnitCost
        {
            get { return _iCInventoryStockActualUnitCost; }
            set
            {
                if (value != this._iCInventoryStockActualUnitCost)
                {
                    _iCInventoryStockActualUnitCost = value;
                    NotifyChanged("ICInventoryStockActualUnitCost");
                }
            }
        }
        public String ICInventoryStockCountItemPackageBarcode
        {
            get { return _iCInventoryStockCountItemPackageBarcode; }
            set
            {
                if (value != this._iCInventoryStockCountItemPackageBarcode)
                {
                    _iCInventoryStockCountItemPackageBarcode = value;
                    NotifyChanged("ICInventoryStockCountItemPackageBarcode");
                }
            }
        }
        public decimal ICInventoryStockCountItemPackageQty
        {
            get { return _iCInventoryStockCountItemPackageQty; }
            set
            {
                if (value != this._iCInventoryStockCountItemPackageQty)
                {
                    _iCInventoryStockCountItemPackageQty = value;
                    NotifyChanged("ICInventoryStockCountItemPackageQty");
                }
            }
        }
        public String ICInventoryStockCountItemDesc
        {
            get { return _iCInventoryStockCountItemDesc; }
            set
            {
                if (value != this._iCInventoryStockCountItemDesc)
                {
                    _iCInventoryStockCountItemDesc = value;
                    NotifyChanged("ICInventoryStockCountItemDesc");
                }
            }
        }
        public decimal ICInventoryStockCountItemProductQty
        {
            get { return _iCInventoryStockCountItemProductQty; }
            set
            {
                if (value != this._iCInventoryStockCountItemProductQty)
                {
                    _iCInventoryStockCountItemProductQty = value;
                    NotifyChanged("ICInventoryStockCountItemProductQty");
                }
            }
        }
        public int FK_ICProductPackageItemID
        {
            get { return _fK_ICProductPackageItemID; }
            set
            {
                if (value != this._fK_ICProductPackageItemID)
                {
                    _fK_ICProductPackageItemID = value;
                    NotifyChanged("FK_ICProductPackageItemID");
                }
            }
        }
        public int FK_ICProductPackageID
        {
            get { return _fK_ICProductPackageID; }
            set
            {
                if (value != this._fK_ICProductPackageID)
                {
                    _fK_ICProductPackageID = value;
                    NotifyChanged("FK_ICProductPackageID");
                }
            }
        }
        public String ICInventoryStockCountItemProductNo
        {
            get { return _iCInventoryStockCountItemProductNo; }
            set
            {
                if (value != this._iCInventoryStockCountItemProductNo)
                {
                    _iCInventoryStockCountItemProductNo = value;
                    NotifyChanged("ICInventoryStockCountItemProductNo");
                }
            }
        }
        public bool ICInventoryStockCountItemIsSpecificCalculation
        {
            get { return _iCInventoryStockCountItemIsSpecificCalculation; }
            set
            {
                if (value != this._iCInventoryStockCountItemIsSpecificCalculation)
                {
                    _iCInventoryStockCountItemIsSpecificCalculation = value;
                    NotifyChanged("ICInventoryStockCountItemIsSpecificCalculation");
                }
            }
        }
        public bool ICInventoryStockCountItemIsAverageCalculation
        {
            get { return _iCInventoryStockCountItemIsAverageCalculation; }
            set
            {
                if (value != this._iCInventoryStockCountItemIsAverageCalculation)
                {
                    _iCInventoryStockCountItemIsAverageCalculation = value;
                    NotifyChanged("ICInventoryStockCountItemIsAverageCalculation");
                }
            }
        }
        public decimal ICInventoryStockUnitCostAVG
        {
            get { return _iCInventoryStockUnitCostAVG; }
            set
            {
                if (value != this._iCInventoryStockUnitCostAVG)
                {
                    _iCInventoryStockUnitCostAVG = value;
                    NotifyChanged("ICInventoryStockUnitCostAVG");
                }
            }
        }
        public decimal ICInventoryStockActualTotalCost
        {
            get { return _iCInventoryStockActualTotalCost; }
            set
            {
                if (value != this._iCInventoryStockActualTotalCost)
                {
                    _iCInventoryStockActualTotalCost = value;
                    NotifyChanged("ICInventoryStockActualTotalCost");
                }
            }
        }
        #endregion

        #region Extra Properties
        public string ICProductBarCode { get; set; }

        public string ICProductNo { get; set; }

        public string ICProductName { get; set; }

        public string ICProductNoOfOldSys { get; set; }

        public int RecordNumber { get; set; }

        public string ICMeasureUnitName { get; set; }

        public decimal ICInventoryStockCountItemQuantityVariance { get; set; }

        public decimal ICInventoryStockCountItemProductPrice { get; set; }

        public decimal ICInventoryStockCountItemNegativeValue { get; set; }

        public decimal ICInventoryStockCountItemNegativeQty { get; set; }

        public decimal ICInventoryStockCountItemPositiveQty { get; set; }

        public decimal ICInventoryStockCountItemPositiveValue { get; set; }

        public int FK_ICDepartmentID { get; set; }

        public string ICDepartmentName { get; set; }

        public string ICDepartmentNo { get; set; }

        public string ICProductSerieNo { get; set; }

        public decimal ICInventoryStockCountItemPrintQty { get; set; }

        public string ICProductPackageItemNo { get; set; }

        public string ICProductPackageItemName { get; set; }

        public Image BarcodeImage { get; set; }

        public string ICProductGroupName { get; set; }

        public bool IsError { get; set; }

        #endregion
    }
    #endregion
}