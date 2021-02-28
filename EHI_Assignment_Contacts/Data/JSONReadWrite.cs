using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EHI_Assignment_Contacts.Data
{
    public class JSONReadWrite
    {
        public JSONReadWrite() { }

        /// <summary>
        /// Read json file from root
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <param name="location">path</param>
        /// <returns>son content</returns>
        public string Read(string fileName, string location)
        {
            string root = "wwwroot";
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                root,
                location,
                fileName);

            string jsonResult;

            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }

            return jsonResult;
        }

        /// <summary>
        /// Write json file from root
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <param name="location">path</param>
        /// <param name="jSONString">son content</param>
        public void Write(string fileName, string location, string jSONString)
        {
            string root = "wwwroot";
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                root,
                location,
                fileName);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
        }
    }
}
