using System;
using System.Data;

namespace BOSLib
{
    #region STModuleToolbarsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleToolbars.
    /// </summary>
    public class STModuleToolbarsInfo : BusinessObject
    {

        protected int _sTModuleToolbarID;
        protected int _sTModuleID;
        protected string _sTModuleToolbarName = DefaultString;
        protected string _sTModuleToolbarDesc = String.Empty;

        public STModuleToolbarsInfo()
        {
        }
        public STModuleToolbarsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleToolbarID":
                            this.STModuleToolbarID = Convert.ToInt32(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "STModuleToolbarName":
                            this.STModuleToolbarName = Convert.ToString(value);
                            break;
                        case "STModuleToolbarDesc":
                            this.STModuleToolbarDesc = Convert.ToString(value);
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


        public STModuleToolbarsInfo(int iSTModuleID, string strSTModuleToolbarName, string strSTModuleToolbarDesc)
        {
            STModuleID = iSTModuleID;
            STModuleToolbarName = strSTModuleToolbarName;
            STModuleToolbarDesc = strSTModuleToolbarDesc;
        }

        #region Public Properties
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

        public string STModuleToolbarName
        {
            get { return _sTModuleToolbarName; }
            set
            {
                if (value != this._sTModuleToolbarName)
                {
                    _sTModuleToolbarName = value;
                    NotifyChanged("STModuleToolbarName");
                }
            }
        }

        public string STModuleToolbarDesc
        {
            get { return _sTModuleToolbarDesc; }
            set
            {
                if (value != this._sTModuleToolbarDesc)
                {
                    _sTModuleToolbarDesc = value;
                    NotifyChanged("STModuleToolbarDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}
