﻿using System;
using System.Text;
using System.Collections.Generic;
using BOSLib;
namespace BOSERP
{
	#region ICConversionProposals
	//-----------------------------------------------------------
	//Generated By: BOS Studio
	//Class:ICConversionProposalsInfo
	//Created Date:23/03/2022 18:09:41
	//-----------------------------------------------------------

	public class ICConversionProposalsInfo : BusinessObject
	{
		public ICConversionProposalsInfo()
		{
		}
		#region Variables
		protected int _iCConversionProposalID;
		protected DateTime _aACreatedDate = DateTime.MaxValue;
		protected string _aACreatedUser = string.Empty;
		protected DateTime _aAUpdatedDate = DateTime.MaxValue;
		protected string _aAUpdatedUser = string.Empty;
		protected string _aAStatus = DefaultAAStatus;
		protected int _fK_ICStockID;
		protected int _fK_BRBranchID;
		protected int _fK_HREmployeeID;
		protected string _iCConversionProposalNo = string.Empty;
		protected string _iCConversionProposalName = string.Empty;
		protected string _iCConversionProposalDesc = string.Empty;
		protected DateTime _iCConversionProposalDate = DateTime.MaxValue;
		protected string _iCConversionProposalStatus = DefaultAAStatus;
		protected string _iCConversionProposalEmployeeRecever = string.Empty;
		protected int _fK_MMWorkShopID;
		protected int _fK_MMLineID;
		protected int _fK_HRDepartmentRoomGroupItemID;
		protected int _fK_MMOperationID;

		#endregion

		#region Public properties
		public int ICConversionProposalID
		{
			get { return _iCConversionProposalID; }
			set
			{
				if (value != this._iCConversionProposalID)
				{
					_iCConversionProposalID = value;
					NotifyChanged("ICConversionProposalID");
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
		public int FK_BRBranchID
		{
			get { return _fK_BRBranchID; }
			set
			{
				if (value != this._fK_BRBranchID)
				{
					_fK_BRBranchID = value;
					NotifyChanged("FK_BRBranchID");
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
		public string ICConversionProposalNo
		{
			get { return _iCConversionProposalNo; }
			set
			{
				if (value != this._iCConversionProposalNo)
				{
					_iCConversionProposalNo = value;
					NotifyChanged("ICConversionProposalNo");
				}
			}
		}
		public string ICConversionProposalName
		{
			get { return _iCConversionProposalName; }
			set
			{
				if (value != this._iCConversionProposalName)
				{
					_iCConversionProposalName = value;
					NotifyChanged("ICConversionProposalName");
				}
			}
		}
		public string ICConversionProposalDesc
		{
			get { return _iCConversionProposalDesc; }
			set
			{
				if (value != this._iCConversionProposalDesc)
				{
					_iCConversionProposalDesc = value;
					NotifyChanged("ICConversionProposalDesc");
				}
			}
		}
		public DateTime ICConversionProposalDate
		{
			get { return _iCConversionProposalDate; }
			set
			{
				if (value != this._iCConversionProposalDate)
				{
					_iCConversionProposalDate = value;
					NotifyChanged("ICConversionProposalDate");
				}
			}
		}
		public string ICConversionProposalStatus
		{
			get { return _iCConversionProposalStatus; }
			set
			{
				if (value != this._iCConversionProposalStatus)
				{
					_iCConversionProposalStatus = value;
					NotifyChanged("ICConversionProposalStatus");
				}
			}
		}
		public string ICConversionProposalEmployeeRecever
		{
			get { return _iCConversionProposalEmployeeRecever; }
			set
			{
				if (value != this._iCConversionProposalEmployeeRecever)
				{
					_iCConversionProposalEmployeeRecever = value;
					NotifyChanged("ICConversionProposalEmployeeRecever");
				}
			}
		}
		public int FK_MMWorkShopID
		{
			get { return _fK_MMWorkShopID; }
			set
			{
				if (value != this._fK_MMWorkShopID)
				{
					_fK_MMWorkShopID = value;
					NotifyChanged("FK_MMWorkShopID");
				}
			}
		}
		public int FK_MMLineID
		{
			get { return _fK_MMLineID; }
			set
			{
				if (value != this._fK_MMLineID)
				{
					_fK_MMLineID = value;
					NotifyChanged("FK_MMLineID");
				}
			}
		}
		public int FK_HRDepartmentRoomGroupItemID
		{
			get { return _fK_HRDepartmentRoomGroupItemID; }
			set
			{
				if (value != this._fK_HRDepartmentRoomGroupItemID)
				{
					_fK_HRDepartmentRoomGroupItemID = value;
					NotifyChanged("FK_HRDepartmentRoomGroupItemID");
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

		#region Extra Properties
		public byte[] ICConversionProposalEmployeePicture { get; set; }

		public DateTime ICConversionProposalDateFrom { get; set; }

		public DateTime ICConversionProposalDateTo { get; set; }
		#endregion
	}
	#endregion
}