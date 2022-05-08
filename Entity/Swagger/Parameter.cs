namespace SwaggerTool.Entity.Api
{
    public class Parameter
    {
        public string Name { get; set; }

        public bool Required { get; set; }

        public string SchemaKey { get; set; }

        public string SchemaType { get; set; }

        public string SchemaFormat { get; set; }

        public string SchemaDefault { get; set; }
    }
}