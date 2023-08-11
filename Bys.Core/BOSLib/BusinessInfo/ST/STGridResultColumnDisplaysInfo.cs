using System;
using System.Data;
namespace BOSLib
{
    #region STGridResultColumnDisplays
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STGridResultColumnDisplaysInfo
    //Created Date:Sonntag, 13. Mai 2007
    //-----------------------------------------------------------

    public class STGridResultColumnDisplaysInfo : BusinessObject
    {
        public STGridResultColumnDisplaysInfo()
        {
        }
        public STGridResultColumnDisplaysInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STGridResultColumnDisplayID":
                            this.STGridResultColumnDisplayID = Convert.ToInt32(value);
                            break;
                        case "STGridResultColumnName":
                            this.STGridResultColumnName = Convert.ToString(value);
                            break;
                        case "STGridResultColumnFieldName":
                            this.STGridResultColumnFieldName = Convert.ToString(value);
                            break;
                        case "STGridResultColumnCaption":
                            this.STGridResultColumnCaption = Convert.ToString(value);
                            break;
                        case "STGridResultColumnWidth":
                            this.STGridResultColumnWidth = Convert.ToInt32(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "STGridResultSortOrder":
                            this.STGridResultSortOrder = Convert.ToInt32(value);
                            break;
                        case "STGridByName":
                            this.STGridByName = Convert.ToString(value);
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

        #region Variables
        protected int _sTGridResultColumnDisplayID;
        protected String _sTGridResultColumnName = String.Empty;
        protected String _sTGridResultColumnFieldName = String.Empty;
        protected String _sTGridResultColumnCaption = String.Empty;
        protected int _sTGridResultColumnWidth;
        protected int _sTModuleID;
        protected int _sTGridResultSortOrder;
        protected String _sTName = String.Empty;
        #endregion

        #region Public properties
        public int STGridResultColumnDisplayID
        {
            get { return _sTGridResultColumnDisplayID; }
            set
            {
                if (value != this._sTGridResultColumnDisplayID)
                {
                    _sTGridResultColumnDisplayID = value;
                    NotifyChanged("STGridResultColumnDisplayID");
                }
            }
        }
        public String STGridResultColumnName
        {
            get { return _sTGridResultColumnName; }
            set
            {
                if (value != this._sTGridResultColumnName)
                {
                    _sTGridResultColumnName = value;
                    NotifyChanged("STGridResultColumnName");
                }
            }
        }
        public String STGridResultColumnFieldName
        {
            get { return _sTGridResultColumnFieldName; }
            set
            {
                if (value != this._sTGridResultColumnFieldName)
                {
                    _sTGridResultColumnFieldName = value;
                    NotifyChanged("STGridResultColumnFieldName");
                }
            }
        }
        public String STGridResultColumnCaption
        {
            get { return _sTGridResultColumnCaption; }
            set
            {
                if (value != this._sTGridResultColumnCaption)
                {
                    _sTGridResultColumnCaption = value;
                    NotifyChanged("STGridResultColumnCaption");
                }
            }
        }
        public int STGridResultColumnWidth
        {
            get { return _sTGridResultColumnWidth; }
            set
            {
                if (value != this._sTGridResultColumnWidth)
                {
                    _sTGridResultColumnWidth = value;
                    NotifyChanged("STGridResultColumnWidth");
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
        public int STGridResultSortOrder
        {
            get { return _sTGridResultSortOrder; }
            set
            {
                if (value != this._sTGridResultSortOrder)
                {
                    _sTGridResultSortOrder = value;
                    NotifyChanged("STGridResultSortOrder");
                }
            }
        }
        public String STGridByName
        {
            get { return _sTName; }
            set
            {
                if (value != this._sTName)
                {
                    _sTName = value;
                    NotifyChanged("STGridByName");
                }
            }
        }

        #endregion
    }
    #endregion
}