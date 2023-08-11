﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region ADCompletePermissionConfigs
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ADCompletePermissionConfigsInfo
	//Created Date:03/03/2021 09:29:43
	//-----------------------------------------------------------

	public class ADCompletePermissionConfigsInfo : BusinessObject
	{
		public ADCompletePermissionConfigsInfo()
		{
		}
		#region Variables
		protected int _aDCompletePermissionConfigID;
		protected string _aAStatus = DefaultAAStatus;
		protected string _aACreatedUser = string.Empty;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected string _aAUpdatedUser = string.Empty;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected int _fK_STModuleID;
		protected int _fK_ADUserGroupID;
		protected string _aDCompletePermissionConfigSaleType = string.Empty;
		protected decimal _aDCompletePermissionConfigMaxValue;
		protected string _aDCompletePermissionConfigCriteriaOperator = string.Empty;
		protected string _aDCompletePermissionConfigSqlWhereClause = string.Empty;
		protected string _aDCompletePermissionConfigLinqWhereClause = string.Empty;
		#endregion

		#region Public properties
		public int ADCompletePermissionConfigID
		{
			get { return _aDCompletePermissionConfigID; }
			set
			{
				if (value != this._aDCompletePermissionConfigID)
				{
					_aDCompletePermissionConfigID = value;
					NotifyChanged("ADCompletePermissionConfigID");
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
		public int FK_STModuleID
		{
			get { return _fK_STModuleID; }
			set
			{
				if (value != this._fK_STModuleID)
				{
					_fK_STModuleID = value;
					NotifyChanged("FK_STModuleID");
				}
			}
		}
		public int FK_ADUserGroupID
		{
			get { return _fK_ADUserGroupID; }
			set
			{
				if (value != this._fK_ADUserGroupID)
				{
					_fK_ADUserGroupID = value;
					NotifyChanged("FK_ADUserGroupID");
				}
			}
		}
		public string ADCompletePermissionConfigSaleType
		{
			get { return _aDCompletePermissionConfigSaleType; }
			set
			{
				if (value != this._aDCompletePermissionConfigSaleType)
				{
					_aDCompletePermissionConfigSaleType = value;
					NotifyChanged("ADCompletePermissionConfigSaleType");
				}
			}
		}
		public decimal ADCompletePermissionConfigMaxValue
		{
			get { return _aDCompletePermissionConfigMaxValue; }
			set
			{
				if (value != this._aDCompletePermissionConfigMaxValue)
				{
					_aDCompletePermissionConfigMaxValue = value;
					NotifyChanged("ADCompletePermissionConfigMaxValue");
				}
			}
		}
		public string ADCompletePermissionConfigCriteriaOperator
		{
			get { return _aDCompletePermissionConfigCriteriaOperator; }
			set
			{
				if (value != this._aDCompletePermissionConfigCriteriaOperator)
				{
					_aDCompletePermissionConfigCriteriaOperator = value;
					NotifyChanged("ADCompletePermissionConfigCriteriaOperator");
				}
			}
		}
		public string ADCompletePermissionConfigSqlWhereClause
		{
			get { return _aDCompletePermissionConfigSqlWhereClause; }
			set
			{
				if (value != this._aDCompletePermissionConfigSqlWhereClause)
				{
					_aDCompletePermissionConfigSqlWhereClause = value;
					NotifyChanged("ADCompletePermissionConfigSqlWhereClause");
				}
			}
		}
		public string ADCompletePermissionConfigLinqWhereClause
		{
			get { return _aDCompletePermissionConfigLinqWhereClause; }
			set
			{
				if (value != this._aDCompletePermissionConfigLinqWhereClause)
				{
					_aDCompletePermissionConfigLinqWhereClause = value;
					NotifyChanged("ADCompletePermissionConfigLinqWhereClause");
				}
			}
		}
		#endregion

		public string STSchemaTableName { get; set; }
	}
	#endregion
}