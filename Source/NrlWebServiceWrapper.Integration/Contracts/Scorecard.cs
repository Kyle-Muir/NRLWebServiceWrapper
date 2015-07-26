namespace NrlWebServiceWrapper.Integration.Contracts
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Scorecard
    {

        private ScorecardMatch matchField;

        /// <remarks/>
        public ScorecardMatch Match
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
    }
}