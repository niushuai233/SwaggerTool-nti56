namespace SwaggerTool.Entity.ApiPostE
{
    public class ApiPostRequest
    {
        public string url { get; set; }
        public string description { get; set; }
        public niushuai233.Base.MapExt<string, object> auth { get; set; }
        public ApiPostHeader header { get; set; }
        public ApiPostQuery query { get; set; }
        public ApiPostBody body { get; set; }
    }
}