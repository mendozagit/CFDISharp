using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Models
{
    public class AppSecret : IAppSecret
    {
        public string AppSecretName { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string InstanceName { get; set; }
        public string DbName { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string StandardSecurityConnectionString()
        {
            if (InstanceName.Equals(""))
                return "Server=" + Host + "," + Port + ";Database=" + DbName + ";User Id=" + User + ";Password=" + Password + ";";
            else
                return "Server=" + Host + "," + Port + @"\" + InstanceName + ";Database=" + DbName + ";User Id=" + User + ";Password=" + Password + ";";

        }

    }
}
