namespace NrlWebServiceWrapper.Integration.Contracts
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ScorecardMatch
    {

        private string resultField;

        private string statusField;

        private ScorecardMatchTeam[] teamField;

        private string scoreEventField;

        private string leadChangeField;

        private string topMatchScoreField;

        private string commentaryField;

        private ScorecardMatchReferees refereesField;

        private byte seriesIdField;

        private byte roundIdField;

        private byte matchIdField;

        private System.DateTime dateTimeField;

        private bool hasMatchStatsField;

        private bool hasLeadChartField;

        private bool hasPlayChartField;

        private bool hasTeamStandingsField;

        private bool hasTeamStatsField;

        private bool hasPlayerStatsField;

        private bool hasFormGuideField;

        private System.DateTime lastUpdateField;

        private string seriesNameField;

        private string matchNameField;

        private string venueField;

        private byte venueIdField;

        private string statusIdField;

        private string currentStatusField;

        private byte matchDurationField;

        private System.DateTime startDateTimeUTCField;

        private string venueLocationField;

        private string venueShortNameField;

        /// <remarks/>
        public string Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Team")]
        public ScorecardMatchTeam[] Team
        {
            get
            {
                return this.teamField;
            }
            set
            {
                this.teamField = value;
            }
        }

        /// <remarks/>
        public string ScoreEvent
        {
            get
            {
                return this.scoreEventField;
            }
            set
            {
                this.scoreEventField = value;
            }
        }

        /// <remarks/>
        public string LeadChange
        {
            get
            {
                return this.leadChangeField;
            }
            set
            {
                this.leadChangeField = value;
            }
        }

        /// <remarks/>
        public string TopMatchScore
        {
            get
            {
                return this.topMatchScoreField;
            }
            set
            {
                this.topMatchScoreField = value;
            }
        }

        /// <remarks/>
        public string Commentary
        {
            get
            {
                return this.commentaryField;
            }
            set
            {
                this.commentaryField = value;
            }
        }

        /// <remarks/>
        public ScorecardMatchReferees Referees
        {
            get
            {
                return this.refereesField;
            }
            set
            {
                this.refereesField = value;
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
        public System.DateTime dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasMatchStats
        {
            get
            {
                return this.hasMatchStatsField;
            }
            set
            {
                this.hasMatchStatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasLeadChart
        {
            get
            {
                return this.hasLeadChartField;
            }
            set
            {
                this.hasLeadChartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasPlayChart
        {
            get
            {
                return this.hasPlayChartField;
            }
            set
            {
                this.hasPlayChartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasTeamStandings
        {
            get
            {
                return this.hasTeamStandingsField;
            }
            set
            {
                this.hasTeamStandingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasTeamStats
        {
            get
            {
                return this.hasTeamStatsField;
            }
            set
            {
                this.hasTeamStatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasPlayerStats
        {
            get
            {
                return this.hasPlayerStatsField;
            }
            set
            {
                this.hasPlayerStatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasFormGuide
        {
            get
            {
                return this.hasFormGuideField;
            }
            set
            {
                this.hasFormGuideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime lastUpdate
        {
            get
            {
                return this.lastUpdateField;
            }
            set
            {
                this.lastUpdateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string seriesName
        {
            get
            {
                return this.seriesNameField;
            }
            set
            {
                this.seriesNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string matchName
        {
            get
            {
                return this.matchNameField;
            }
            set
            {
                this.matchNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string venue
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currentStatus
        {
            get
            {
                return this.currentStatusField;
            }
            set
            {
                this.currentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte matchDuration
        {
            get
            {
                return this.matchDurationField;
            }
            set
            {
                this.matchDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime startDateTimeUTC
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
        public string venueLocation
        {
            get
            {
                return this.venueLocationField;
            }
            set
            {
                this.venueLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string venueShortName
        {
            get
            {
                return this.venueShortNameField;
            }
            set
            {
                this.venueShortNameField = value;
            }
        }
    }
}