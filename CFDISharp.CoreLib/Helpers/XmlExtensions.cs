using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CFDISharp.CoreLib.Helpers
{
    public static class XmlExtensions
    {
        public static void XmlSerialize<T>(this T instance, string filename) where T : class, new()
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, instance);
            }
        }
        public static T XmlDeserialize<T>(this string filePath) where T : class, new()
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                stream.Position = 0;
                var serializer = new XmlSerializer(typeof(T));
                return serializer.Deserialize(stream) as T;
            }
        }
    }
}
