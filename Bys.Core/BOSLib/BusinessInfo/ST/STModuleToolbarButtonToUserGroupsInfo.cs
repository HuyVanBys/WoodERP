using System;
using System.Data;

namespace BOSLib
{
    #region STModuleToolbarButtonToUserGroupsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleToolbarButtonToUserGroups.
    /// </summary>
    public class STModuleToolbarButtonToUserGroupsInfo : BusinessObject
    {

        protected int _sTModuleToolbarButtonToUserGroupID;
        protected int _sTModuleToolbarButtonID;
        protected int _sTUserGroupID;
        protected bool _sTModuleToolbarButtonToUserGroupStatus;

        public STModuleToolbarButtonToUserGroupsInfo()
        {
        }
        public STModuleToolbarButtonToUserGroupsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleToolbarButtonToUserGroupID":
                            this.STModuleToolbarButtonToUserGroupID = Convert.ToInt32(value);
                            break;
                        case "STModuleToolbarButtonID":
                            this.STModuleToolbarButtonID = Convert.ToInt32(value);
                            break;
                        case "STUserGroupID":
                            this.STUserGroupID = Convert.ToInt32(value);
                            break;
                        case "STModuleToolbarButtonToUserGroupStatus":
                            this.STModuleToolbarButtonToUserGroupStatus = Convert.ToBoolean(value);
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


        public STModuleToolbarButtonToUserGroupsInfo(int iSTModuleToolbarButtonID, int iSTUserGroupID, bool bSTModuleToolbarButtonToUserGroupStatus)
        {
            STModuleToolbarButtonID = iSTModuleToolbarButtonID;
            STUserGroupID = iSTUserGroupID;
            STModuleToolbarButtonToUserGroupStatus = bSTModuleToolbarButtonToUserGroupStatus;
        }

        #region Public Properties
        public int STModuleToolbarButtonToUserGroupID
        {
            get { return _sTModuleToolbarButtonToUserGroupID; }
            set
            {
                if (value != this._sTModuleToolbarButtonToUserGroupID)
                {
                    _sTModuleToolbarButtonToUserGroupID = value;
                    NotifyChanged("STModuleToolbarButtonToUserGroupID");
                }
            }
        }

        public int STModuleToolbarButtonID
        {
            get { return _sTModuleToolbarButtonID; }
            set
            {
                if (value != this._sTModuleToolbarButtonID)
                {
                    _sTModuleToolbarButtonID = value;
                    NotifyChanged("STModuleToolbarButtonID");
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

        public bool STModuleToolbarButtonToUserGroupStatus
        {
            get { return _sTModuleToolbarButtonToUserGroupStatus; }
            set
            {
                if (value != this._sTModuleToolbarButtonToUserGroupStatus)
                {
                    _sTModuleToolbarButtonToUserGroupStatus = value;
                    NotifyChanged("STModuleToolbarButtonToUserGroupStatus");
                }
            }
        }
        #endregion
    }
    #endregion
}
