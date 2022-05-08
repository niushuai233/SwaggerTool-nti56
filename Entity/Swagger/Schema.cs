using System.Collections.Generic;

namespace SwaggerTool.Entity.Api
{
    public class Schema
    {
        public string Key { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string description { get; set; }

        public List<Field> Fields { get; set; }
    }
}