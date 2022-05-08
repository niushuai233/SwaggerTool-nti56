using System.Collections.Generic;

namespace SwaggerTool.Entity.ApiPostE
{
    public class ApiPostQuery
    {
        public List<ApiPostParameter> parameter;

        public ApiPostQuery(List<ApiPostParameter> headerParameterList)
        {
            this.parameter = headerParameterList;
        }
    }
}