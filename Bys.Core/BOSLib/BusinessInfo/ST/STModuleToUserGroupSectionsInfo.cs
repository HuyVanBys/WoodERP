using System;
using System.Data;

namespace BOSLib
{
    #region STModuleToUserGroupSectionsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleToUserGroupSections.
    /// </summary>
    public class STModuleToUserGroupSectionsInfo : BusinessObject
    {

        protected int _sTModuleToUserGroupSectionID;
        protected int _sTUserGroupSectionID;
        protected int _sTModuleID;
        protected int _sTModuleToUserGroupSectionSortOrder = DefaultNumber;

        public STModuleToUserGroupSectionsInfo()
        {
        }
        public STModuleToUserGroupSectionsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleToUserGroupSectionID":
                            this.STModuleToUserGroupSectionID = Convert.ToInt32(value);
                            break;
                        case "STUserGroupSectionID":
                            this.STUserGroupSectionID = Convert.ToInt32(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "STModuleToUserGroupSectionSortOrder":
                            this.STModuleToUserGroupSectionSortOrder = Convert.ToInt32(value);
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


        public STModuleToUserGroupSectionsInfo(int iSTUserGroupSectionID, int iSTModuleID, int iSTModuleToUserGroupSectionSortOrder)
        {
            STUserGroupSectionID = iSTUserGroupSectionID;
            STModuleID = iSTModuleID;
            STModuleToUserGroupSectionSortOrder = iSTModuleToUserGroupSectionSortOrder;
        }

        #region Public Properties
        public int STModuleToUserGroupSectionID
        {
            get { return _sTModuleToUserGroupSectionID; }
            set
            {
                if (value != this._sTModuleToUserGroupSectionID)
                {
                    _sTModuleToUserGroupSectionID = value;
                    NotifyChanged("STModuleToUserGroupSectionID");
                }
            }
        }

        public int STUserGroupSectionID
        {
            get { return _sTUserGroupSectionID; }
            set
            {
                if (value != this._sTUserGroupSectionID)
                {
                    _sTUserGroupSectionID = value;
                    NotifyChanged("STUserGroupSectionID");
                }
            }
        }

        public int STModuleID
        {
            get { return _sTModuleID; }
            set
            {
                if (value != this._sTModuleID)
                {
                    _sTModuleID = value;
                    NotifyChanged("STModuleID");
                }
            }
        }

        public int STModuleToUserGroupSectionSortOrder
        {
            get { return _sTModuleToUserGroupSectionSortOrder; }
            set
            {
                if (value != this._sTModuleToUserGroupSectionSortOrder)
                {
                    _sTModuleToUserGroupSectionSortOrder = value;
                    NotifyChanged("STModuleToUserGroupSectionSortOrder");
                }
            }
        }
        #endregion
    }
    #endregion
}
