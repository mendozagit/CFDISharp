using CFDISharp.Winforms.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CFDISharp.Winforms.Helpers
{
    public static class AppServices
    {

        #region Properties

        public static AppSecret AppSecret { get; set; }
        public static AppSetting AppSetting { get; set; }

        #endregion


        #region Collections



        public static List<AppSecret> AppSecrets { get; set; } = new List<AppSecret>();
        public static List<AppSetting> AppSettings { get; set; } = new List<AppSetting>();



        #endregion



        #region Methods
        public static string SerializeToJsonFile<T>(T t, string jsonPanth)
        {

            File.WriteAllText(jsonPanth, JsonConvert.SerializeObject(t));
            return File.ReadAllText(jsonPanth);
        }

        public static T DeserializeFromJsonFile<T>(string jsonPanth)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(jsonPanth));
        }

        public static AppSetting GetAppSettingByKey(string key)
        {
            return AppSettings.FirstOrDefault(x => x.Key.ToUpper().Equals(key.ToUpper()));
        }
        public static string GetAppSettingValueByKey(string key)
        {
            return AppSettings.FirstOrDefault(x => x.Key.ToUpper().Equals(key.ToUpper()))?.Value;
        }

        #endregion


    }
}
