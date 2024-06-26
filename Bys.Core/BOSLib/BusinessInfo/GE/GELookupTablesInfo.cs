using System;
using System.Data;

namespace BOSLib
{
    #region GELookupTables
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GELookupTablesInfo
    //Created Date:Thursday, May 27, 2010
    //-----------------------------------------------------------

    public class GELookupTablesInfo : BusinessObject
    {
        public GELookupTablesInfo()
        {
        }
        public GELookupTablesInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "GELookupTableID":
                            this.GELookupTableID = Convert.ToInt32(value);
                            break;
                        case "AAStatus":
                            this.AAStatus = Convert.ToString(value);
                            break;
                        case "GELookupTableName":
                            this.GELookupTableName = Convert.ToString(value);
                            break;
                        case "GELookupTableDesc":
                            this.GELookupTableDesc = Convert.ToString(value);
                            break;
                        case "GELookupTableDisplayColumn":
                            this.GELookupTableDisplayColumn = Convert.ToString(value);
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
        protected int _gELookupTableID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _gELookupTableName = String.Empty;
        protected String _gELookupTableDesc = String.Empty;
        protected String _gELookupTableDisplayColumn = String.Empty;
        #endregion

        #region Public properties
        public int GELookupTableID
        {
            get { return _gELookupTableID; }
            set
            {
                if (value != this._gELookupTableID)
                {
                    _gELookupTableID = value;
                    NotifyChanged("GELookupTableID");
                }
            }
        }
        public String AAStatus
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
        public String GELookupTableName
        {
            get { return _gELookupTableName; }
            set
            {
                if (value != this._gELookupTableName)
                {
                    _gELookupTableName = value;
                    NotifyChanged("GELookupTableName");
                }
            }
        }
        public String GELookupTableDesc
        {
            get { return _gELookupTableDesc; }
            set
            {
                if (value != this._gELookupTableDesc)
                {
                    _gELookupTableDesc = value;
                    NotifyChanged("GELookupTableDesc");
                }
            }
        }
        public String GELookupTableDisplayColumn
        {
            get { return _gELookupTableDisplayColumn; }
            set
            {
                if (value != this._gELookupTableDisplayColumn)
                {
                    _gELookupTableDisplayColumn = value;
                    NotifyChanged("GELookupTableDisplayColumn");
                }
            }
        }
        #endregion
    }
    #endregion
}