using System;
using System.Data;

namespace BOSLib
{
    #region STGridBandsInfo
    /// <summary>
    /// This object represents the properties and methods of a STGridBands.
    /// </summary>
    public class STGridBandsInfo : BusinessObject
    {

        protected int _sTGridBandID;
        protected string _sTGridBandName = DefaultString;
        protected string _sTGridBandCaption = DefaultString;
        protected int _sTGridBandWidth = DefaultNumber;
        protected int _sTGridViewID;

        public STGridBandsInfo()
        {
        }
        public STGridBandsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STGridBandID":
                            this.STGridBandID = Convert.ToInt32(value);
                            break;
                        case "STGridBandName":
                            this.STGridBandName = Convert.ToString(value);
                            break;
                        case "STGridBandCaption":
                            this.STGridBandCaption = Convert.ToString(value);
                            break;
                        case "STGridBandWidth":
                            this.STGridBandWidth = Convert.ToInt32(value);
                            break;
                        case "STGridViewID":
                            this.STGridViewID = Convert.ToInt32(value);
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


        public STGridBandsInfo(string strSTGridBandName, string strSTGridBandCaption, int iSTGridBandWidth, int iSTGridViewID)
        {
            STGridBandName = strSTGridBandName;
            STGridBandCaption = strSTGridBandCaption;
            STGridBandWidth = iSTGridBandWidth;
            STGridViewID = iSTGridViewID;
        }

        #region Public Properties
        public int STGridBandID
        {
            get { return _sTGridBandID; }
            set
            {
                if (value != this._sTGridBandID)
                {
                    _sTGridBandID = value;
                    NotifyChanged("STGridBandID");
                }
            }
        }

        public string STGridBandName
        {
            get { return _sTGridBandName; }
            set
            {
                if (value != this._sTGridBandName)
                {
                    _sTGridBandName = value;
                    NotifyChanged("STGridBandName");
                }
            }
        }

        public string STGridBandCaption
        {
            get { return _sTGridBandCaption; }
            set
            {
                if (value != this._sTGridBandCaption)
                {
                    _sTGridBandCaption = value;
                    NotifyChanged("STGridBandCaption");
                }
            }
        }

        public int STGridBandWidth
        {
            get { return _sTGridBandWidth; }
            set
            {
                if (value != this._sTGridBandWidth)
                {
                    _sTGridBandWidth = value;
                    NotifyChanged("STGridBandWidth");
                }
            }
        }

        public int STGridViewID
        {
            get { return _sTGridViewID; }
            set
            {
                if (value != this._sTGridViewID)
                {
                    _sTGridViewID = value;
                    NotifyChanged("STGridViewID");
                }
            }
        }
        #endregion
    }
    #endregion
}
