namespace NrlWebServiceWrapper.Integration.Contracts
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FixtureHeader
    {

        private System.DateTime lastGeneratedField;

        /// <remarks/>
        public System.DateTime LastGenerated
        {
            get
            {
                return this.lastGeneratedField;
            }
            set
            {
                this.lastGeneratedField = value;
            }
        }
    }
}