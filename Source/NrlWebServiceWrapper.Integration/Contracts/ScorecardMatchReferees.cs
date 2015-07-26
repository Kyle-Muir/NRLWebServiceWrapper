namespace NrlWebServiceWrapper.Integration.Contracts
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ScorecardMatchReferees
    {

        private string refereeField;

        private string firstTouchJudgeField;

        private string secondTouchJudgeField;

        private string referee2Field;

        private byte refereeIdField;

        private byte firstTouchJudgeIdField;

        private byte secondTouchJudgeIdField;

        private byte refereeId2Field;

        /// <remarks/>
        public string Referee
        {
            get
            {
                return this.refereeField;
            }
            set
            {
                this.refereeField = value;
            }
        }

        /// <remarks/>
        public string FirstTouchJudge
        {
            get
            {
                return this.firstTouchJudgeField;
            }
            set
            {
                this.firstTouchJudgeField = value;
            }
        }

        /// <remarks/>
        public string SecondTouchJudge
        {
            get
            {
                return this.secondTouchJudgeField;
            }
            set
            {
                this.secondTouchJudgeField = value;
            }
        }

        /// <remarks/>
        public string Referee2
        {
            get
            {
                return this.referee2Field;
            }
            set
            {
                this.referee2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte refereeId
        {
            get
            {
                return this.refereeIdField;
            }
            set
            {
                this.refereeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte firstTouchJudgeId
        {
            get
            {
                return this.firstTouchJudgeIdField;
            }
            set
            {
                this.firstTouchJudgeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte secondTouchJudgeId
        {
            get
            {
                return this.secondTouchJudgeIdField;
            }
            set
            {
                this.secondTouchJudgeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte refereeId2
        {
            get
            {
                return this.refereeId2Field;
            }
            set
            {
                this.refereeId2Field = value;
            }
        }
    }
}