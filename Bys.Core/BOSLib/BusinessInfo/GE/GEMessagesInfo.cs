using System;
using System.Data;
namespace BOSLib
{
    #region GEMessages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEMessagesInfo
    //Created Date:Sunday, April 13, 2008
    //-----------------------------------------------------------

    public class GEMessagesInfo : BusinessObject
    {
        public GEMessagesInfo()
        {
        }
        public GEMessagesInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "GEMessagesID":
                            this.GEMessagesID = Convert.ToInt32(value);
                            break;
                        case "AAStatus":
                            this.AAStatus = Convert.ToString(value);
                            break;
                        case "GEMessagesNo":
                            this.GEMessagesNo = Convert.ToString(value);
                            break;
                        case "GEMessagesDefault":
                            this.GEMessagesDefault = Convert.ToString(value);
                            break;
                        case "GEMessagesContentEN":
                            this.GEMessagesContentEN = Convert.ToString(value);
                            break;
                        case "GEMessagesContentVN":
                            this.GEMessagesContentVN = Convert.ToString(value);
                            break;
                        case "GEMessagesContentFR":
                            this.GEMessagesContentFR = Convert.ToString(value);
                            break;
                        case "GEMessagesContentGE":
                            this.GEMessagesContentGE = Convert.ToString(value);
                            break;
                        case "GEMessagesTitleEN":
                            this.GEMessagesTitleEN = Convert.ToString(value);
                            break;
                        case "GEMessagesTitleVN":
                            this.GEMessagesTitleVN = Convert.ToString(value);
                            break;
                        case "GEMessagesTitleFR":
                            this.GEMessagesTitleFR = Convert.ToString(value);
                            break;
                        case "GEMessagesTitleGE":
                            this.GEMessagesTitleGE = Convert.ToString(value);
                            break;
                        case "GEMessagesType":
                            this.GEMessagesType = Convert.ToInt32(value);
                            break;
                        case "GEMessagesHiddenMaxCount":
                            this.GEMessagesHiddenMaxCount = Convert.ToInt32(value);
                            break;
                        case "GEMessagesButtonsType":
                            this.GEMessagesButtonsType = Convert.ToInt32(value);
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
        protected int _gEMessagesID;
        protected String _aAStatus = DefaultStatus;
        protected String _gEMessagesNo;
        protected String _gEMessagesDefault = String.Empty;
        protected String _gEMessagesContentEN = String.Empty;
        protected String _gEMessagesContentVN = String.Empty;
        protected String _gEMessagesContentFR = String.Empty;
        protected String _gEMessagesContentGE = String.Empty;
        protected String _gEMessagesTitleEN = String.Empty;
        protected String _gEMessagesTitleVN = String.Empty;
        protected String _gEMessagesTitleFR = String.Empty;
        protected String _gEMessagesTitleGE = String.Empty;
        protected int _gEMessagesType;
        protected int _gEMessagesHiddenMaxCount;
        protected int _gEMessagesButtonsType;


        #endregion

        #region Public properties
        public int GEMessagesID
        {
            get { return _gEMessagesID; }
            set
            {
                if (value != this._gEMessagesID)
                {
                    _gEMessagesID = value;
                    NotifyChanged("GEMessagesID");
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
        public String GEMessagesNo
        {
            get { return _gEMessagesNo; }
            set
            {
                if (value != this._gEMessagesNo)
                {
                    _gEMessagesNo = value;
                    NotifyChanged("GEMessagesNo");
                }
            }
        }
        public String GEMessagesDefault
        {
            get { return _gEMessagesDefault; }
            set
            {
                if (value != this._gEMessagesDefault)
                {
                    _gEMessagesDefault = value;
                    NotifyChanged("GEMessagesDefault");
                }
            }
        }
        public String GEMessagesContentEN
        {
            get { return _gEMessagesContentEN; }
            set
            {
                if (value != this._gEMessagesContentEN)
                {
                    _gEMessagesContentEN = value;
                    NotifyChanged("GEMessagesContentEN");
                }
            }
        }
        public String GEMessagesContentVN
        {
            get { return _gEMessagesContentVN; }
            set
            {
                if (value != this._gEMessagesContentVN)
                {
                    _gEMessagesContentVN = value;
                    NotifyChanged("GEMessagesContentVN");
                }
            }
        }
        public String GEMessagesContentFR
        {
            get { return _gEMessagesContentFR; }
            set
            {
                if (value != this._gEMessagesContentFR)
                {
                    _gEMessagesContentFR = value;
                    NotifyChanged("GEMessagesContentFR");
                }
            }
        }
        public String GEMessagesContentGE
        {
            get { return _gEMessagesContentGE; }
            set
            {
                if (value != this._gEMessagesContentGE)
                {
                    _gEMessagesContentGE = value;
                    NotifyChanged("GEMessagesContentGE");
                }
            }
        }
        public String GEMessagesTitleEN
        {
            get { return _gEMessagesTitleEN; }
            set
            {
                if (value != this._gEMessagesTitleEN)
                {
                    _gEMessagesTitleEN = value;
                    NotifyChanged("GEMessagesTitleEN");
                }
            }
        }
        public String GEMessagesTitleVN
        {
            get { return _gEMessagesTitleVN; }
            set
            {
                if (value != this._gEMessagesTitleVN)
                {
                    _gEMessagesTitleVN = value;
                    NotifyChanged("GEMessagesTitleVN");
                }
            }
        }
        public String GEMessagesTitleFR
        {
            get { return _gEMessagesTitleFR; }
            set
            {
                if (value != this._gEMessagesTitleFR)
                {
                    _gEMessagesTitleFR = value;
                    NotifyChanged("GEMessagesTitleFR");
                }
            }
        }
        public String GEMessagesTitleGE
        {
            get { return _gEMessagesTitleGE; }
            set
            {
                if (value != this._gEMessagesTitleGE)
                {
                    _gEMessagesTitleGE = value;
                    NotifyChanged("GEMessagesTitleGE");
                }
            }
        }
        public int GEMessagesType
        {
            get { return _gEMessagesType; }
            set
            {
                if (value != this._gEMessagesType)
                {
                    _gEMessagesType = value;
                    NotifyChanged("GEMessagesType");
                }
            }
        }

        public int GEMessagesHiddenMaxCount
        {
            get { return _gEMessagesHiddenMaxCount; }
            set
            {
                if (value != this._gEMessagesHiddenMaxCount)
                {
                    _gEMessagesHiddenMaxCount = value;
                    NotifyChanged("GEMessagesHiddenMaxCount");
                }
            }
        }

        public int GEMessagesButtonsType
        {

            get { return _gEMessagesButtonsType; }
            set
            {
                if (value != this._gEMessagesButtonsType)
                {
                    _gEMessagesButtonsType = value;
                    NotifyChanged("GEMessagesButtonsType");
                }
            }
        }

        #endregion
    }
    #endregion
}