namespace NrlWebServiceWrapper.Integration.Contracts
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SeriesListSeries
    {

        private string nameField;

        private string shortNameField;

        private string startdateField;

        private string enddateField;

        private byte seriesIdField;

        private byte currentRoundIdField;

        private string seriesStatusField;

        private byte leagueIdField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        /// <remarks/>
        public string Startdate
        {
            get
            {
                return this.startdateField;
            }
            set
            {
                this.startdateField = value;
            }
        }

        /// <remarks/>
        public string Enddate
        {
            get
            {
                return this.enddateField;
            }
            set
            {
                this.enddateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte seriesId
        {
            get
            {
                return this.seriesIdField;
            }
            set
            {
                this.seriesIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte currentRoundId
        {
            get
            {
                return this.currentRoundIdField;
            }
            set
            {
                this.currentRoundIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string seriesStatus
        {
            get
            {
                return this.seriesStatusField;
            }
            set
            {
                this.seriesStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte leagueId
        {
            get
            {
                return this.leagueIdField;
            }
            set
            {
                this.leagueIdField = value;
            }
        }
    }
}