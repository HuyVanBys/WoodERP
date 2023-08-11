using System;
using System.Data;

namespace BOSLib
{
    #region STModuleDescriptionsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleDescriptions.
    /// </summary>
    public class STModuleDescriptionsInfo : BusinessObject
    {

        protected int _sTModuleDescriptionID;
        protected int _sTModuleID;
        protected int _sTLanguageID;
        protected string _sTModuleDescriptionDescription = DefaultString;

        public STModuleDescriptionsInfo()
        {
        }
        public STModuleDescriptionsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleDescriptionID":
                            this.STModuleDescriptionID = Convert.ToInt32(value);
                            break;
                        case "STModuleID":
                            this.STModuleID = Convert.ToInt32(value);
                            break;
                        case "STLanguageID":
                            this.STLanguageID = Convert.ToInt32(value);
                            break;
                        case "STModuleDescriptionDescription":
                            this.STModuleDescriptionDescription = Convert.ToString(value);
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
                        case "STModuleName":
                            this.STModuleName = Convert.ToString(value);
                            break;
                        case "GELanguageName":
                            this.GELanguageName = Convert.ToString(value);
                            break;
                        default:
                            break;
                    }

                }

            }
        }


        public STModuleDescriptionsInfo(int iSTModuleID, int iSTLanguageID, string strSTModuleDescriptionDescription)
        {
            STModuleID = iSTModuleID;
            STLanguageID = iSTLanguageID;
            STModuleDescriptionDescription = strSTModuleDescriptionDescription;
        }

        #region Public Properties
        public int STModuleDescriptionID
        {
            get { return _sTModuleDescriptionID; }
            set
            {
                if (value != this._sTModuleDescriptionID)
                {
                    _sTModuleDescriptionID = value;
                    NotifyChanged("STModuleDescriptionID");
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

        public int STLanguageID
        {
            get { return _sTLanguageID; }
            set
            {
                if (value != this._sTLanguageID)
                {
                    _sTLanguageID = value;
                    NotifyChanged("STLanguageID");
                }
            }
        }

        public string STModuleDescriptionDescription
        {
            get { return _sTModuleDescriptionDescription; }
            set
            {
                if (value != this._sTModuleDescriptionDescription)
                {
                    _sTModuleDescriptionDescription = value;
                    NotifyChanged("STModuleDescriptionDescription");
                }
            }
        }
        #endregion

        #region Extra Property
        public string STModuleName { get; set; }
        public string GELanguageName { get; set; }
        #endregion
    }
    #endregion
}
