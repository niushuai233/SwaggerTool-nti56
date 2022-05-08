using System.Collections.Generic;

namespace SwaggerTool.Entity.ApiPostE
{
    public class ApiPostHeader
    {
        public List<ApiPostParameter> parameter;

        public ApiPostHeader(List<ApiPostParameter> headerParameter)
        {
            this.parameter = headerParameter;
        }
    }
}