using System;
using System.Data;

namespace BOSLib
{
    #region PRReports
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:PRReportsInfo
    //Created Date:Friday, April 20, 2007
    //-----------------------------------------------------------

    public class PRReportsInfo : BusinessObject
    {
        public PRReportsInfo()
        {
        }
        public PRReportsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "PRReportID":
                            this.PRReportID = Convert.ToInt32(value);
                            break;
                        case "AANumberString":
                            this.AANumberString = Convert.ToString(value);
                            break;
                        case "AANumberInt":
                            this.AANumberInt = Convert.ToInt32(value);
                            break;
                        case "AAStat":
                            this.AAStat = Convert.ToString(value);
                            break;
                        case "PRReportName":
                            this.PRReportName = Convert.ToString(value);
                            break;
                        case "PRReportDeliveryMethod":
                            this.PRReportDeliveryMethod = Convert.ToInt32(value);
                            break;
                        case "PRReportPrinter":
                            this.PRReportPrinter = Convert.ToString(value);
                            break;
                        case "PRReportNumOfCopies":
                            this.PRReportNumOfCopies = Convert.ToInt32(value);
                            break;
                        case "PRReportEmailSubject":
                            this.PRReportEmailSubject = Convert.ToString(value);
                            break;
                        case "PRReportEmailBody":
                            this.PRReportEmailBody = Convert.ToString(value);
                            break;
                        case "PRReportNumber":
                            this.PRReportNumber = Convert.ToInt32(value);
                            break;
                        case "PRReportDesc":
                            this.PRReportDesc = Convert.ToString(value);
                            break;
                        case "PRReportModuleName":
                            this.PRReportModuleName = Convert.ToString(value);
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
        protected int _pRReportID;
        protected String _aANumberString = String.Empty;
        protected int _aANumberInt;
        protected String _aAStat = DefaultAAStatus;
        protected String _pRReportName = String.Empty;
        protected int _pRReportDeliveryMethod;
        protected String _pRReportPrinter = String.Empty;
        protected int _pRReportNumOfCopies;
        protected String _pRReportEmailSubject = String.Empty;
        protected String _pRReportEmailBody = String.Empty;
        protected int _pRReportNumber;
        protected String _pRReportDesc = String.Empty;
        protected String _pRReportModuleName = String.Empty;
        #endregion

        #region Public properties
        public int PRReportID
        {
            get { return _pRReportID; }
            set
            {
                if (value != this._pRReportID)
                {
                    _pRReportID = value;
                    NotifyChanged("PRReportID");
                }
            }
        }
        public String AANumberString
        {
            get { return _aANumberString; }
            set
            {
                if (value != this._aANumberString)
                {
                    _aANumberString = value;
                    NotifyChanged("AANumberString");
                }
            }
        }
        public int AANumberInt
        {
            get { return _aANumberInt; }
            set
            {
                if (value != this._aANumberInt)
                {
                    _aANumberInt = value;
                    NotifyChanged("AANumberInt");
                }
            }
        }
        public String AAStat
        {
            get { return _aAStat; }
            set
            {
                if (value != this._aAStat)
                {
                    _aAStat = value;
                    NotifyChanged("AAStat");
                }
            }
        }
        public String PRReportName
        {
            get { return _pRReportName; }
            set
            {
                if (value != this._pRReportName)
                {
                    _pRReportName = value;
                    NotifyChanged("PRReportName");
                }
            }
        }
        public int PRReportDeliveryMethod
        {
            get { return _pRReportDeliveryMethod; }
            set
            {
                if (value != this._pRReportDeliveryMethod)
                {
                    _pRReportDeliveryMethod = value;
                    NotifyChanged("PRReportDeliveryMethod");
                }
            }
        }
        public String PRReportPrinter
        {
            get { return _pRReportPrinter; }
            set
            {
                if (value != this._pRReportPrinter)
                {
                    _pRReportPrinter = value;
                    NotifyChanged("PRReportPrinter");
                }
            }
        }
        public int PRReportNumOfCopies
        {
            get { return _pRReportNumOfCopies; }
            set
            {
                if (value != this._pRReportNumOfCopies)
                {
                    _pRReportNumOfCopies = value;
                    NotifyChanged("PRReportNumOfCopies");
                }
            }
        }
        public String PRReportEmailSubject
        {
            get { return _pRReportEmailSubject; }
            set
            {
                if (value != this._pRReportEmailSubject)
                {
                    _pRReportEmailSubject = value;
                    NotifyChanged("PRReportEmailSubject");
                }
            }
        }
        public String PRReportEmailBody
        {
            get { return _pRReportEmailBody; }
            set
            {
                if (value != this._pRReportEmailBody)
                {
                    _pRReportEmailBody = value;
                    NotifyChanged("PRReportEmailBody");
                }
            }
        }
        public int PRReportNumber
        {
            get { return _pRReportNumber; }
            set
            {
                if (value != this._pRReportNumber)
                {
                    _pRReportNumber = value;
                    NotifyChanged("PRReportNumber");
                }
            }
        }
        public String PRReportDesc
        {
            get { return _pRReportDesc; }
            set
            {
                if (value != this._pRReportDesc)
                {
                    _pRReportDesc = value;
                    NotifyChanged("PRReportDesc");
                }
            }
        }
        public String PRReportModuleName
        {
            get { return _pRReportModuleName; }
            set
            {
                if (value != this._pRReportModuleName)
                {
                    _pRReportModuleName = value;
                    NotifyChanged("PRReportModuleName");
                }
            }
        }
        #endregion
    }
    #endregion
}