using System.Collections.Generic;

namespace SwaggerTool.Entity.Api
{
    public class Path
    {
        public string MethodType { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public List<Parameter> Parameters { get; set; }

        public RequestBody Body { get; set; }
    }
}