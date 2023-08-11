﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region ICWidthGroups
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ICWidthGroupsInfo
	//Created Date:22/09/2022 15:15:17
	//-----------------------------------------------------------

	public class ICWidthGroupsInfo : BusinessObject
	{
		public ICWidthGroupsInfo()
		{
		}
		#region Variables
		protected int _iCWidthGroupID;
		protected string _aAStatus = DefaultAAStatus;
		protected string _aACreatedUser = string.Empty;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected string _aAUpdatedUser = string.Empty;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected string _iCWidthGroupName = string.Empty;
		protected decimal _iCWidthGroupMinValue;
		protected decimal _iCWidthGroupMaxValue;
		#endregion

		#region Public properties
		public int ICWidthGroupID
		{
			get { return _iCWidthGroupID; }
			set
			{
				if (value != this._iCWidthGroupID)
				{
					_iCWidthGroupID = value;
					NotifyChanged("ICWidthGroupID");
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
		public string ICWidthGroupName
		{
			get { return _iCWidthGroupName; }
			set
			{
				if (value != this._iCWidthGroupName)
				{
					_iCWidthGroupName = value;
					NotifyChanged("ICWidthGroupName");
				}
			}
		}
		public decimal ICWidthGroupMinValue
		{
			get { return _iCWidthGroupMinValue; }
			set
			{
				if (value != this._iCWidthGroupMinValue)
				{
					_iCWidthGroupMinValue = value;
					NotifyChanged("ICWidthGroupMinValue");
				}
			}
		}
		public decimal ICWidthGroupMaxValue
		{
			get { return _iCWidthGroupMaxValue; }
			set
			{
				if (value != this._iCWidthGroupMaxValue)
				{
					_iCWidthGroupMaxValue = value;
					NotifyChanged("ICWidthGroupMaxValue");
				}
			}
		}
		#endregion
	}
	#endregion
}