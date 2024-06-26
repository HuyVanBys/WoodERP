﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region MMConfigMaterialShipmentUtilitys
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:MMConfigMaterialShipmentUtilitysInfo
	//Created Date:14/06/2022 15:11:58
	//-----------------------------------------------------------

	public class MMConfigMaterialShipmentUtilitysInfo : BusinessObject
	{
		public MMConfigMaterialShipmentUtilitysInfo()
		{
		}
		#region Variables
		protected int _mMConfigMaterialShipmentUtilityID;
		protected string _aAStatus = DefaultAAStatus;
		protected string _aACreatedUser = string.Empty;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected string _aAUpdatedUser = string.Empty;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected string _mMConfigMaterialShipmentUtilityType = string.Empty;
		#endregion

		#region Public properties
		public int MMConfigMaterialShipmentUtilityID
		{
			get { return _mMConfigMaterialShipmentUtilityID; }
			set
			{
				if (value != this._mMConfigMaterialShipmentUtilityID)
				{
					_mMConfigMaterialShipmentUtilityID = value;
					NotifyChanged("MMConfigMaterialShipmentUtilityID");
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
		public string MMConfigMaterialShipmentUtilityType
		{
			get { return _mMConfigMaterialShipmentUtilityType; }
			set
			{
				if (value != this._mMConfigMaterialShipmentUtilityType)
				{
					_mMConfigMaterialShipmentUtilityType = value;
					NotifyChanged("MMConfigMaterialShipmentUtilityType");
				}
			}
		}
		#endregion
	}
	#endregion
}