using System;
using System.Collections.Generic;

namespace DOMCompositApp.Model
{
    class DivTag : ITags
    {
        private string _tag1;
        private string _tag2;
        private List<ITags> list = new List<ITags>();

        public DivTag(string tag1) : this(tag1, "") {
        
        }
        public DivTag(string tag1,string tag2)
        {
            _tag1 = tag1;
            _tag2 = tag2;
        }
        
        public void AddTag(ITags tags)
        {
            list.Add(tags);
        }
        public string Display(string htmlScript)
        {
            htmlScript+="<"+_tag1+">\n";
            if (_tag1 == "p") 
                htmlScript += _tag2;
            foreach (ITags tag in list)
            {
                htmlScript=tag.Display(htmlScript);      
            }
            htmlScript += "</" + _tag1 + ">\n";
            return htmlScript;
        }
    }
}
