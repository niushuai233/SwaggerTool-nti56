namespace SwaggerTool.Entity.ApiPostE
{
    public class ApiPostInstance
    {
        public string target_id { get; set; }

        public string parent_id { get; set; }
        public string project_id { get; set; }
        public string mark { get; set; }
        public string target_type { get; set; }
        public string name { get; set; }
        public string method { get; set; }
        public string url { get; set; }
        public int sort { get; set; }
        public string type_sort { get; set; }
        public ApiPostRequest request { get; set; }
        public ApiPostResponse response { get; set; }
        public string mock { get; set; }
        public string mock_url { get; set; }
        public int version { get; set; }
        public int is_changed { get; set; }
        public int is_save { get; set; }
        public int is_force { get; set; }
    }
}