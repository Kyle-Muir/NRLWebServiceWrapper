namespace NrlWebServiceWrapper.Integration.Contracts
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FixtureEvent
    {

        private string seriesField;

        private string roundField;

        private string matchField;

        private FixtureEventVenue venueField;

        private System.DateTime startDateTimeField;

        private string statusField;

        private System.DateTime startDateTimeUTCField;

        private byte seriesIdField;

        private byte matchIdField;

        private byte roundIdField;

        private byte venueIdField;

        private string statusIdField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Round
        {
            get
            {
                return this.roundField;
            }
            set
            {
                this.roundField = value;
            }
        }

        /// <remarks/>
        public string Match
        {
            get
            {
                return this.matchField;
            }
            set
            {
                this.matchField = value;
            }
        }

        /// <remarks/>
        public FixtureEventVenue Venue
        {
            get
            {
                return this.venueField;
            }
            set
            {
                this.venueField = value;
            }
        }

        /// <remarks/>
        public System.DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public System.DateTime StartDateTimeUTC
        {
            get
            {
                return this.startDateTimeUTCField;
            }
            set
            {
                this.startDateTimeUTCField = value;
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
        public byte matchId
        {
            get
            {
                return this.matchIdField;
            }
            set
            {
                this.matchIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte roundId
        {
            get
            {
                return this.roundIdField;
            }
            set
            {
                this.roundIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte venueId
        {
            get
            {
                return this.venueIdField;
            }
            set
            {
                this.venueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string statusId
        {
            get
            {
                return this.statusIdField;
            }
            set
            {
                this.statusIdField = value;
            }
        }
    }
}