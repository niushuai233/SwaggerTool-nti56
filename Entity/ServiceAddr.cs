using System.Collections.Generic;
using System.Xml.Serialization;

namespace SwaggerTool.Entity
{
    [XmlRootAttribute("ServiceAddr", IsNullable = false)]
    public class ServiceAddr
    {
        public List<string> ServerList { get; set; }
    }
}