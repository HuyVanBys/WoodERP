using BOSLib;
using System;
namespace BOSERP
{
	#region ARPriceSheetItems
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ARPriceSheetItemsInfo
	//Created Date:24 Tháng Bảy 2018
	//-----------------------------------------------------------

	public class ARPriceSheetItemsInfo : BusinessObject
	{
		public ARPriceSheetItemsInfo()
		{
			this.ARPriceSheetItemsGetDate = DateTime.Now;
		}

		public ARPriceSheetItemsInfo(int customerID, int productID, int measureUnitID, DateTime getDate)
		{
			this.FK_ACObjectID = customerID;
			this.FK_ICProductID = productID;
			this.FK_ICMeasureUnitID = measureUnitID;
			this.ARPriceSheetItemsGetDate = getDate;
		}

		#region Variables
		protected int _aRPriceSheetItemID;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected string _aACreatedUser = string.Empty;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected string _aAUpdatedUser = string.Empty;
		protected string _aAStatus = DefaultAAStatus;
		protected int _fK_ARPriceSheetID;
		protected int _fK_ICProductID;
		protected int _fK_ICMeasureUnitID;
		protected string _aRPriceSheetItemProductNo = string.Empty;
		protected string _aRPriceSheetItemProductName = string.Empty;
		protected string _aRPriceSheetItemProductDesc = string.Empty;
		protected decimal _aRPriceSheetItemProductLength;
		protected decimal _aRPriceSheetItemProductWidth;
		protected decimal _aRPriceSheetItemProductHeight;
		protected int _fK_ICProductParentID;
		protected string _aRPriceSheetItemCommand = string.Empty;
		protected decimal _aRPriceSheetItemQty;
		protected decimal _aRPriceSheetItemBasicPrice;
		protected decimal _aRPriceSheetItemDiscountPercent;
		protected decimal _aRPriceSheetItemDiscountAmount;
		protected decimal _aRPriceSheetItemTaxPercent;
		protected decimal _aRPriceSheetItemTaxAmount;
		protected decimal _aRPriceSheetItemPrice;
		protected decimal _aRPriceSheetItemTotalAmount;
		protected string _aRPriceSheetItemProductNoOfOldSys = string.Empty;
		protected string _aRPriceSheetItemProductCustomerNumber = string.Empty;
		protected decimal _aRPriceSheetItemNetPrice;
		protected decimal _aRPriceSheetItemCostingPrice;
		protected bool _aRPriceSheetItemSOQ = false;
		protected int _aRPriceSheetItemSortOrder;
		#endregion

		#region Public properties
		public int ARPriceSheetItemID
		{
			get { return _aRPriceSheetItemID; }
			set
			{
				if (value != this._aRPriceSheetItemID)
				{
					_aRPriceSheetItemID = value;
					NotifyChanged("ARPriceSheetItemID");
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
		public string AACreatedUser
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
		public string AAUpdatedUser
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
		public string AAStatus
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
		public int FK_ARPriceSheetID
		{
			get { return _fK_ARPriceSheetID; }
			set
			{
				if (value != this._fK_ARPriceSheetID)
				{
					_fK_ARPriceSheetID = value;
					NotifyChanged("FK_ARPriceSheetID");
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
		public string ARPriceSheetItemProductNo
		{
			get { return _aRPriceSheetItemProductNo; }
			set
			{
				if (value != this._aRPriceSheetItemProductNo)
				{
					_aRPriceSheetItemProductNo = value;
					NotifyChanged("ARPriceSheetItemProductNo");
				}
			}
		}
		public string ARPriceSheetItemProductName
		{
			get { return _aRPriceSheetItemProductName; }
			set
			{
				if (value != this._aRPriceSheetItemProductName)
				{
					_aRPriceSheetItemProductName = value;
					NotifyChanged("ARPriceSheetItemProductName");
				}
			}
		}
		public string ARPriceSheetItemProductDesc
		{
			get { return _aRPriceSheetItemProductDesc; }
			set
			{
				if (value != this._aRPriceSheetItemProductDesc)
				{
					_aRPriceSheetItemProductDesc = value;
					NotifyChanged("ARPriceSheetItemProductDesc");
				}
			}
		}
		public decimal ARPriceSheetItemProductLength
		{
			get { return _aRPriceSheetItemProductLength; }
			set
			{
				if (value != this._aRPriceSheetItemProductLength)
				{
					_aRPriceSheetItemProductLength = value;
					NotifyChanged("ARPriceSheetItemProductLength");
				}
			}
		}
		public decimal ARPriceSheetItemProductWidth
		{
			get { return _aRPriceSheetItemProductWidth; }
			set
			{
				if (value != this._aRPriceSheetItemProductWidth)
				{
					_aRPriceSheetItemProductWidth = value;
					NotifyChanged("ARPriceSheetItemProductWidth");
				}
			}
		}
		public decimal ARPriceSheetItemProductHeight
		{
			get { return _aRPriceSheetItemProductHeight; }
			set
			{
				if (value != this._aRPriceSheetItemProductHeight)
				{
					_aRPriceSheetItemProductHeight = value;
					NotifyChanged("ARPriceSheetItemProductHeight");
				}
			}
		}
		public int FK_ICProductParentID
		{
			get { return _fK_ICProductParentID; }
			set
			{
				if (value != this._fK_ICProductParentID)
				{
					_fK_ICProductParentID = value;
					NotifyChanged("FK_ICProductParentID");
				}
			}
		}
		public string ARPriceSheetItemCommand
		{
			get { return _aRPriceSheetItemCommand; }
			set
			{
				if (value != this._aRPriceSheetItemCommand)
				{
					_aRPriceSheetItemCommand = value;
					NotifyChanged("ARPriceSheetItemCommand");
				}
			}
		}
		public decimal ARPriceSheetItemQty
		{
			get { return _aRPriceSheetItemQty; }
			set
			{
				if (value != this._aRPriceSheetItemQty)
				{
					_aRPriceSheetItemQty = value;
					NotifyChanged("ARPriceSheetItemQty");
				}
			}
		}
		public decimal ARPriceSheetItemBasicPrice
		{
			get { return _aRPriceSheetItemBasicPrice; }
			set
			{
				if (value != this._aRPriceSheetItemBasicPrice)
				{
					_aRPriceSheetItemBasicPrice = value;
					NotifyChanged("ARPriceSheetItemBasicPrice");
				}
			}
		}
		public decimal ARPriceSheetItemDiscountPercent
		{
			get { return _aRPriceSheetItemDiscountPercent; }
			set
			{
				if (value != this._aRPriceSheetItemDiscountPercent)
				{
					_aRPriceSheetItemDiscountPercent = value;
					NotifyChanged("ARPriceSheetItemDiscountPercent");
				}
			}
		}
		public decimal ARPriceSheetItemDiscountAmount
		{
			get { return _aRPriceSheetItemDiscountAmount; }
			set
			{
				if (value != this._aRPriceSheetItemDiscountAmount)
				{
					_aRPriceSheetItemDiscountAmount = value;
					NotifyChanged("ARPriceSheetItemDiscountAmount");
				}
			}
		}
		public decimal ARPriceSheetItemTaxPercent
		{
			get { return _aRPriceSheetItemTaxPercent; }
			set
			{
				if (value != this._aRPriceSheetItemTaxPercent)
				{
					_aRPriceSheetItemTaxPercent = value;
					NotifyChanged("ARPriceSheetItemTaxPercent");
				}
			}
		}
		public decimal ARPriceSheetItemTaxAmount
		{
			get { return _aRPriceSheetItemTaxAmount; }
			set
			{
				if (value != this._aRPriceSheetItemTaxAmount)
				{
					_aRPriceSheetItemTaxAmount = value;
					NotifyChanged("ARPriceSheetItemTaxAmount");
				}
			}
		}
		public decimal ARPriceSheetItemPrice
		{
			get { return _aRPriceSheetItemPrice; }
			set
			{
				if (value != this._aRPriceSheetItemPrice)
				{
					_aRPriceSheetItemPrice = value;
					NotifyChanged("ARPriceSheetItemPrice");
				}
			}
		}
		public decimal ARPriceSheetItemTotalAmount
		{
			get { return _aRPriceSheetItemTotalAmount; }
			set
			{
				if (value != this._aRPriceSheetItemTotalAmount)
				{
					_aRPriceSheetItemTotalAmount = value;
					NotifyChanged("ARPriceSheetItemTotalAmount");
				}
			}
		}
		public string ARPriceSheetItemProductNoOfOldSys
		{
			get { return _aRPriceSheetItemProductNoOfOldSys; }
			set
			{
				if (value != this._aRPriceSheetItemProductNoOfOldSys)
				{
					_aRPriceSheetItemProductNoOfOldSys = value;
					NotifyChanged("ARPriceSheetItemProductNoOfOldSys");
				}
			}
		}
		public string ARPriceSheetItemProductCustomerNumber
		{
			get { return _aRPriceSheetItemProductCustomerNumber; }
			set
			{
				if (value != this._aRPriceSheetItemProductCustomerNumber)
				{
					_aRPriceSheetItemProductCustomerNumber = value;
					NotifyChanged("ARPriceSheetItemProductCustomerNumber");
				}
			}
		}
		public decimal ARPriceSheetItemNetPrice
		{
			get { return _aRPriceSheetItemNetPrice; }
			set
			{
				if (value != this._aRPriceSheetItemNetPrice)
				{
					_aRPriceSheetItemNetPrice = value;
					NotifyChanged("ARPriceSheetItemNetPrice");
				}
			}
		}
		public decimal ARPriceSheetItemCostingPrice
		{
			get { return _aRPriceSheetItemCostingPrice; }
			set
			{
				if (value != this._aRPriceSheetItemCostingPrice)
				{
					_aRPriceSheetItemCostingPrice = value;
					NotifyChanged("ARPriceSheetItemCostingPrice");
				}
			}
		}
		public bool ARPriceSheetItemSOQ
		{
			get { return _aRPriceSheetItemSOQ; }
			set
			{
				if (value != this._aRPriceSheetItemSOQ)
				{
					_aRPriceSheetItemSOQ = value;
					NotifyChanged("ARPriceSheetItemSOQ");
				}
			}
		}
		public int ARPriceSheetItemSortOrder
        {
			get { return _aRPriceSheetItemSortOrder; }
			set
            {
				if (value != this._aRPriceSheetItemSortOrder)
                {
					_aRPriceSheetItemSortOrder = value;
					NotifyChanged("ARPriceSheetItemSortOrder");
				}					
            }
        }
		#endregion

		#region Extra
		public string ACObjectAccessKey { get; set; }
		public IBOSList<ARPriceSheetItemsInfo> ARPriceSheetItemsList { get; set; }
		public int FK_ACObjectID { get; set; }
		public string ARObjectType { get; set; }
		public int FK_PMProjectID { get; set; }
		public string ARPriceSheetNo { get; set; }
		public string ARRowNumber { get; set; }
		public String ICMeasureUnitName { get; set; }
		public String ICDepartmentName { get; set; }
		public int GroupIndex { get; set; }
		public int ICDepartmentID { get; set; }
		public int FK_GECurrencyID { get; set; }
		public String ARPriceSheetName { get; set; }
		public DateTime ARPriceSheetItemsGetDate { get; set; }
		public DateTime ARPriceSheetStartDate { get; set; }
		public DateTime ARPriceSheetEndDate { get; set; }
		public string ARCustomerTypeName { get; set; }
		public string ARPriceSheetItemProductSupplierNumber { get; set; }
		public int FK_ARCustomerID { get; set; }
		public byte[] ARPriceSheetItemProductPicture { get; set; }
		#endregion
	}
    #endregion
}