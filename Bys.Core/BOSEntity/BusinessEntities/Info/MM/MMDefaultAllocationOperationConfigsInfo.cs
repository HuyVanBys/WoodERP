﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region MMDefaultAllocationOperationConfigs
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:MMDefaultAllocationOperationConfigsInfo
	//Created Date:11/22/2022 10:40:57 AM
	//-----------------------------------------------------------

	public class MMDefaultAllocationOperationConfigsInfo : BusinessObject
	{
		public MMDefaultAllocationOperationConfigsInfo()
		{
		}
		#region Variables
		protected int _mMDefaultAllocationOperationConfigID;
		protected string _aAStatus = DefaultAAStatus;
		protected string _aACreatedUser = string.Empty;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected string _aAUpdatedUser = string.Empty;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected int _fK_ICDepartmentID;
		protected int _fK_ICProductGroupID;
		protected int _fK_MMOperationID;
		#endregion

		#region Public properties
		public int MMDefaultAllocationOperationConfigID
		{
			get { return _mMDefaultAllocationOperationConfigID; }
			set
			{
				if (value != this._mMDefaultAllocationOperationConfigID)
				{
					_mMDefaultAllocationOperationConfigID = value;
					NotifyChanged("MMDefaultAllocationOperationConfigID");
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
		public int FK_ICDepartmentID
		{
			get { return _fK_ICDepartmentID; }
			set
			{
				if (value != this._fK_ICDepartmentID)
				{
					_fK_ICDepartmentID = value;
					NotifyChanged("FK_ICDepartmentID");
				}
			}
		}
		public int FK_ICProductGroupID
		{
			get { return _fK_ICProductGroupID; }
			set
			{
				if (value != this._fK_ICProductGroupID)
				{
					_fK_ICProductGroupID = value;
					NotifyChanged("FK_ICProductGroupID");
				}
			}
		}
		public int FK_MMOperationID
		{
			get { return _fK_MMOperationID; }
			set
			{
				if (value != this._fK_MMOperationID)
				{
					_fK_MMOperationID = value;
					NotifyChanged("FK_MMOperationID");
				}
			}
		}
		#endregion
	}
	#endregion
}