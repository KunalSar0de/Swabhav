namespace DOMCompositApp.Model
{
    class IndividualTag : ITags
    {
  
        private readonly string _fTag;
        private readonly string _sTag;

        public IndividualTag(string tag1) : this(tag1, "") { }
        public IndividualTag(string tag1, string tag2)
        {
            _fTag = tag1;
            _sTag = tag2;
        }

        public string Display(string htmlScript)
        {
            if (_fTag == "input")
            {
                return htmlScript + "<" + _fTag + " type=\"" + _sTag + "\">\n";
            }
            return htmlScript + " <" + _fTag + "/>";
        }
    }
}
