using System;
using System.IO;
using System.Xml.Serialization;

namespace niushuai233.Util
{
    public class XmlUtil
    {
        /// <summary>
        /// 对象变xml
        /// </summary>
        /// <typeparam name="T">任意类型对象</typeparam>
        /// <param name="Obj">数据对象实体</param>
        public static void Obj2Xml<T>(string fileName, T Obj)
        {
            XmlSerializer xmlSerialzer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(fileName);

            // 序列化
            xmlSerialzer.Serialize(writer, Obj);
            // 扔到磁盘上
            writer.Close();
        }

        public static T Xml2Obj<T>(string path)
        {
            XmlSerializer xmlSerialzer = new XmlSerializer(typeof(T));
            xmlSerialzer.UnknownNode += new XmlNodeEventHandler(Serializer_UnknownNode);
            xmlSerialzer.UnknownAttribute += new XmlAttributeEventHandler(Serializer_UnknownAttribute);

            // 加载文件到流中
            FileStream fs = new FileStream(path, FileMode.Open);
            // 反序列化
            object v = xmlSerialzer.Deserialize(fs);
            fs.Close();
            return (T)v;
        }

        private static void Serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private static void Serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " + attr.Name + "='" + attr.Value + "'");
        }
    }
}