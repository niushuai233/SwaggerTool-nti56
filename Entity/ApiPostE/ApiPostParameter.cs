namespace SwaggerTool.Entity.ApiPostE
{
    public class ApiPostParameter
    {
        public int is_checked { get; set; }
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        public int not_null { get; set; }
        public string description { get; set; }
        public string field_type { get; set; }

        /// <summary>
        /// UUID
        /// </summary>
        public string __DATAKEY__ { get; set; }
    }
}