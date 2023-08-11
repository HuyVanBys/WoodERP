using System;
using System.Data;

namespace BOSLib
{
    #region STModuleToolbarToUserGroupsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleToolbarToUserGroups.
    /// </summary>
    public class STModuleToolbarToUserGroupsInfo : BusinessObject
    {

        protected int _sTModuleToolbarToUserGroupID;
        protected int _sTModuleToolbarID;
        protected int _sTUserGroupID;
        protected bool _sTModuleToolbarToUserGroupStatus;

        public STModuleToolbarToUserGroupsInfo()
        {
        }
        public STModuleToolbarToUserGroupsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleToolbarToUserGroupID":
                            this.STModuleToolbarToUserGroupID = Convert.ToInt32(value);
                            break;
                        case "STModuleToolbarID":
                            this.STModuleToolbarID = Convert.ToInt32(value);
                            break;
                        case "STUserGroupID":
                            this.STUserGroupID = Convert.ToInt32(value);
                            break;
                        case "STModuleToolbarToUserGroupStatus":
                            this.STModuleToolbarToUserGroupStatus = Convert.ToBoolean(value);
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


        public STModuleToolbarToUserGroupsInfo(int iSTModuleToolbarID, int iSTUserGroupID, bool bSTModuleToolbarToUserGroupStatus)
        {
            STModuleToolbarID = iSTModuleToolbarID;
            STUserGroupID = iSTUserGroupID;
            STModuleToolbarToUserGroupStatus = bSTModuleToolbarToUserGroupStatus;
        }

        #region Public Properties
        public int STModuleToolbarToUserGroupID
        {
            get { return _sTModuleToolbarToUserGroupID; }
            set
            {
                if (value != this._sTModuleToolbarToUserGroupID)
                {
                    _sTModuleToolbarToUserGroupID = value;
                    NotifyChanged("STModuleToolbarToUserGroupID");
                }
            }
        }

        public int STModuleToolbarID
        {
            get { return _sTModuleToolbarID; }
            set
            {
                if (value != this._sTModuleToolbarID)
                {
                    _sTModuleToolbarID = value;
                    NotifyChanged("STModuleToolbarID");
                }
            }
        }

        public int STUserGroupID
        {
            get { return _sTUserGroupID; }
            set
            {
                if (value != this._sTUserGroupID)
                {
                    _sTUserGroupID = value;
                    NotifyChanged("STUserGroupID");
                }
            }
        }

        public bool STModuleToolbarToUserGroupStatus
        {
            get { return _sTModuleToolbarToUserGroupStatus; }
            set
            {
                if (value != this._sTModuleToolbarToUserGroupStatus)
                {
                    _sTModuleToolbarToUserGroupStatus = value;
                    NotifyChanged("STModuleToolbarToUserGroupStatus");
                }
            }
        }
        #endregion
    }
    #endregion
}
