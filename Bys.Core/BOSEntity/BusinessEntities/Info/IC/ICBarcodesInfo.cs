﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region ICBarcodes
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ICBarcodesInfo
	//Created Date:07/07/2022 10:37:53
	//-----------------------------------------------------------

	public class ICBarcodesInfo : BusinessObject
	{
		public ICBarcodesInfo()
		{
		}
		#region Variables
		protected int _iCBarcodeID;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected string _aACreatedUser = string.Empty;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected string _aAUpdatedUser = string.Empty;
		protected string _aAStatus = DefaultAAStatus;
		protected string _iCBarcodeNo = string.Empty;
		protected DateTime _iCBarcodeDate = DateTime.MaxValue;
		protected string _iCBarcodeDesc = string.Empty;
		protected string _iCBarcodeReference = string.Empty;
		protected string _iCBarcodeStatus = DefaultAAStatus;
		protected int _fK_HREmployeeID;
		#endregion

		#region Public properties
		public int ICBarcodeID
		{
			get { return _iCBarcodeID; }
			set
			{
				if (value != this._iCBarcodeID)
				{
					_iCBarcodeID = value;
					NotifyChanged("ICBarcodeID");
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
		public string ICBarcodeNo
		{
			get { return _iCBarcodeNo; }
			set
			{
				if (value != this._iCBarcodeNo)
				{
					_iCBarcodeNo = value;
					NotifyChanged("ICBarcodeNo");
				}
			}
		}
		public DateTime ICBarcodeDate
		{
			get { return _iCBarcodeDate; }
			set
			{
				if (value != this._iCBarcodeDate)
				{
					_iCBarcodeDate = value;
					NotifyChanged("ICBarcodeDate");
				}
			}
		}
		public string ICBarcodeDesc
		{
			get { return _iCBarcodeDesc; }
			set
			{
				if (value != this._iCBarcodeDesc)
				{
					_iCBarcodeDesc = value;
					NotifyChanged("ICBarcodeDesc");
				}
			}
		}
		public string ICBarcodeReference
		{
			get { return _iCBarcodeReference; }
			set
			{
				if (value != this._iCBarcodeReference)
				{
					_iCBarcodeReference = value;
					NotifyChanged("ICBarcodeReference");
				}
			}
		}
		public string ICBarcodeStatus
		{
			get { return _iCBarcodeStatus; }
			set
			{
				if (value != this._iCBarcodeStatus)
				{
					_iCBarcodeStatus = value;
					NotifyChanged("ICBarcodeStatus");
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
		#endregion

		#region Extra Properties
		public int ICBarcodeNumber { get; set; }
		public DateTime BarcodeDateFrom { get; set; }
		public DateTime BarcodeDateTo { get; set; }
		#endregion
	}
	#endregion
}