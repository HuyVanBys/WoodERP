﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region ARCustomerSaleOrderTypeConfigs
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ARCustomerSaleOrderTypeConfigsInfo
	//Created Date:28/06/2022 2:44:28 PM
	//-----------------------------------------------------------

	public class ARCustomerSaleOrderTypeConfigsInfo : BusinessObject
	{
		public ARCustomerSaleOrderTypeConfigsInfo()
		{
		}
		#region Variables
		protected int _aRCustomerSaleOrderTypeConfigID;
		protected string _aAStatus = DefaultAAStatus;
		protected string _aACreatedUser = string.Empty;
		protected string _aAUpdatedUser = string.Empty;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected string _aRCustomerType = string.Empty;
		protected string _aRSaleOrderType = string.Empty;
		#endregion

		#region Public properties
		public int ARCustomerSaleOrderTypeConfigID
		{
			get { return _aRCustomerSaleOrderTypeConfigID; }
			set
			{
				if (value != this._aRCustomerSaleOrderTypeConfigID)
				{
					_aRCustomerSaleOrderTypeConfigID = value;
					NotifyChanged("ARCustomerSaleOrderTypeConfigID");
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
		public string ARCustomerType
		{
			get { return _aRCustomerType; }
			set
			{
				if (value != this._aRCustomerType)
				{
					_aRCustomerType = value;
					NotifyChanged("ARCustomerType");
				}
			}
		}
		public string ARSaleOrderType
		{
			get { return _aRSaleOrderType; }
			set
			{
				if (value != this._aRSaleOrderType)
				{
					_aRSaleOrderType = value;
					NotifyChanged("ARSaleOrderType");
				}
			}
		}
		#endregion
	}
	#endregion
}