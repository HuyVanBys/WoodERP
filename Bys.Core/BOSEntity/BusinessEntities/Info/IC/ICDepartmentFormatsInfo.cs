﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region ICDepartmentFormats
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ICDepartmentFormatsInfo
	//Created Date:02/12/2022 16:22:32
	//-----------------------------------------------------------

	public class ICDepartmentFormatsInfo : BusinessObject
	{
		public ICDepartmentFormatsInfo()
		{
		}
		#region Variables
		protected int _iCDepartmentFormatID;
		protected string _aAStatus = DefaultAAStatus;
		protected string _iCProductType = string.Empty;
		protected int _iCDepartmentFormatDecimalNumber;
		protected int _fK_STFieldFormatGroupID;
		#endregion

		#region Public properties
		public int ICDepartmentFormatID
		{
			get { return _iCDepartmentFormatID; }
			set
			{
				if (value != this._iCDepartmentFormatID)
				{
					_iCDepartmentFormatID = value;
					NotifyChanged("ICDepartmentFormatID");
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
		public string ICProductType
		{
			get { return _iCProductType; }
			set
			{
				if (value != this._iCProductType)
				{
					_iCProductType = value;
					NotifyChanged("ICProductType");
				}
			}
		}
		public int ICDepartmentFormatDecimalNumber
		{
			get { return _iCDepartmentFormatDecimalNumber; }
			set
			{
				if (value != this._iCDepartmentFormatDecimalNumber)
				{
					_iCDepartmentFormatDecimalNumber = value;
					NotifyChanged("ICDepartmentFormatDecimalNumber");
				}
			}
		}
		public int FK_STFieldFormatGroupID
		{
			get { return _fK_STFieldFormatGroupID; }
			set
			{
				if (value != this._fK_STFieldFormatGroupID)
				{
					_fK_STFieldFormatGroupID = value;
					NotifyChanged("FK_STFieldFormatGroupID");
				}
			}
		}
		#endregion
		#region Extra Properties
		public string STFieldFormatGroupFormatString { get; set; }
		public string STFieldFormatGroupMaskEdit { get; set; }
		#endregion
	}
	#endregion
}