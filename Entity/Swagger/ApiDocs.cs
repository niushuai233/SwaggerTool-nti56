using niushuai233.Base;
using System.Collections.Generic;

namespace SwaggerTool.Entity.Api
{
    public class ApiDocs
    {
        public string OpenApi { get; set; }

        public string Info { get; set; }

        public List<Path> Paths { get; set; }

        public List<Schema> Schemas { get; set; }

        public MapExt<string, Path> PathsMap()
        {
            MapExt<string, Path> map = new MapExt<string, Path>();
            foreach (Path path in Paths)
            {
                map.Put(path.Url, path);
            }
            return map;
        }

        public MapExt<string, Schema> SchemasMap()
        {
            MapExt<string, Schema> map = new MapExt<string, Schema>();
            foreach (Schema schema in Schemas)
            {
                map.Put(schema.Key, schema);
            }
            return map;
        }
    }
}