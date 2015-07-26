namespace NrlWebServiceWrapper.Integration.Contracts
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ScorecardMatchTeam
    {

        private string topScorerField;

        private byte triesField;

        private string conversionKickField;

        private string penaltyGoalField;

        private string fieldGoalField;

        private byte pointsField;

        private byte firstHalfField;

        private byte secondHalfField;

        private object cardsField;

        private byte bonusTriesField;

        private string typeField;

        private byte teamIdField;

        private string longNameField;

        private string shortNameField;

        private string nickNameField;

        private ushort topScorerIdField;

        /// <remarks/>
        public string TopScorer
        {
            get
            {
                return this.topScorerField;
            }
            set
            {
                this.topScorerField = value;
            }
        }

        /// <remarks/>
        public byte Tries
        {
            get
            {
                return this.triesField;
            }
            set
            {
                this.triesField = value;
            }
        }

        /// <remarks/>
        public string ConversionKick
        {
            get
            {
                return this.conversionKickField;
            }
            set
            {
                this.conversionKickField = value;
            }
        }

        /// <remarks/>
        public string PenaltyGoal
        {
            get
            {
                return this.penaltyGoalField;
            }
            set
            {
                this.penaltyGoalField = value;
            }
        }

        /// <remarks/>
        public string FieldGoal
        {
            get
            {
                return this.fieldGoalField;
            }
            set
            {
                this.fieldGoalField = value;
            }
        }

        /// <remarks/>
        public byte Points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }

        /// <remarks/>
        public byte FirstHalf
        {
            get
            {
                return this.firstHalfField;
            }
            set
            {
                this.firstHalfField = value;
            }
        }

        /// <remarks/>
        public byte SecondHalf
        {
            get
            {
                return this.secondHalfField;
            }
            set
            {
                this.secondHalfField = value;
            }
        }

        /// <remarks/>
        public object Cards
        {
            get
            {
                return this.cardsField;
            }
            set
            {
                this.cardsField = value;
            }
        }

        /// <remarks/>
        public byte BonusTries
        {
            get
            {
                return this.bonusTriesField;
            }
            set
            {
                this.bonusTriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte teamId
        {
            get
            {
                return this.teamIdField;
            }
            set
            {
                this.teamIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string longName
        {
            get
            {
                return this.longNameField;
            }
            set
            {
                this.longNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shortName
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nickName
        {
            get
            {
                return this.nickNameField;
            }
            set
            {
                this.nickNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort topScorerId
        {
            get
            {
                return this.topScorerIdField;
            }
            set
            {
                this.topScorerIdField = value;
            }
        }
    }
}