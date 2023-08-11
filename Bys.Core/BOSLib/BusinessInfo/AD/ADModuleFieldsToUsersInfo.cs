using System;
using System.Data;

namespace BOSLib
{
    public class ADModuleFieldsToUsersInfo : BusinessObject
    {
        #region Constructors
        public ADModuleFieldsToUsersInfo()
        {
            _aAStat = "Alive";
        }
        public ADModuleFieldsToUsersInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "ADModuleFieldsToUserID":
                            this.ADModuleFieldsToUserID = Convert.ToInt32(value);
                            break;
                        case "ADUserID":
                            this.ADUserID = Convert.ToInt32(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "ADModuleFieldsToUserScreenNumber":
                            this.ADModuleFieldsToUserScreenNumber = Convert.ToString(value);
                            break;
                        case "ADModuleFieldsToUserFieldName":
                            this.ADModuleFieldsToUserFieldName = Convert.ToString(value);
                            break;
                        case "ADModuleFieldsToUserFieldStatus":
                            this.ADModuleFieldsToUserFieldStatus = Convert.ToInt32(value);
                            break;
                        case "AAStat":
                            this.AAStat = Convert.ToString(value);
                            break;
                        case "AllowPropertyChangedEvent":
                            this.AllowPropertyChangedEvent = Convert.ToBoolean(value);
                            break;
                        case "Position":
                            this.Position = Convert.ToInt32(value);
                            break;
                        case "RelatedPosition":
                            this.RelatedPosition = Convert.ToInt32(value);
                            break;
                        case "Selected":
                            this.Selected = Convert.ToBoolean(value);
                            break;
                        case "TheNumberOfChild":
                            this.TheNumberOfChild = Convert.ToInt32(value);
                            break;
                        default:
                            break;
                    }

                }

            }
        }

        #endregion

        #region Variables
        int _aDModuleFieldsToUserID;
        int _aDUserID;
        int _sTModuleID;
        String _aDModuleFieldsToUserScreenNumber;
        String _aDModuleFieldsToUserFieldName;
        int _aDModuleFieldsToUserFieldStatus;
        String _aAStat;
        #endregion

        #region Public Properties
        public int ADModuleFieldsToUserID
        {
            get
            {
                return _aDModuleFieldsToUserID;
            }
            set
            {
                if (value != _aDModuleFieldsToUserID)
                {
                    _aDModuleFieldsToUserID = value;
                    NotifyChanged("ADModuleFieldsToUserID");
                }
            }
        }

        public int ADUserID
        {
            get
            {
                return _aDUserID;
            }
            set
            {
                if (value != _aDUserID)
                {
                    _aDUserID = value;
                    NotifyChanged("ADUserID");
                }
            }
        }

        public int STModuleID
        {
            get
            {
                return _sTModuleID;
            }
            set
            {
                if (value != _sTModuleID)
                {
                    _sTModuleID = value;
                    NotifyChanged("STModuleID");
                }
            }
        }

        public String ADModuleFieldsToUserScreenNumber
        {
            get
            {
                return _aDModuleFieldsToUserScreenNumber;
            }
            set
            {
                if (value != _aDModuleFieldsToUserScreenNumber)
                {
                    _aDModuleFieldsToUserScreenNumber = value;
                    NotifyChanged("ADModuleFieldsToUserScreenNumber");
                }
            }
        }

        public String ADModuleFieldsToUserFieldName
        {
            get
            {
                return _aDModuleFieldsToUserFieldName;
            }
            set
            {
                if (value != _aDModuleFieldsToUserFieldName)
                {
                    _aDModuleFieldsToUserFieldName = value;
                    NotifyChanged("ADModuleFieldsToUserFieldName");
                }
            }
        }

        public int ADModuleFieldsToUserFieldStatus
        {
            get
            {
                return _aDModuleFieldsToUserFieldStatus;
            }
            set
            {
                if (value != _aDModuleFieldsToUserFieldStatus)
                {
                    _aDModuleFieldsToUserFieldStatus = value;
                    NotifyChanged("ADModuleFieldsToUserFieldStatus");
                }
            }
        }

        public String AAStat
        {
            get
            {
                return _aAStat;
            }
            set
            {
                if (value != _aAStat)
                {
                    _aAStat = value;
                    NotifyChanged("AAStat");
                }
            }
        }
        #endregion
    }
}
