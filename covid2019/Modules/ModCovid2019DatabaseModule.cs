using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace covid2019.Modules
{
    class ModCovid2019DatabaseModule
    {
        public static String GetConnectionString()
        {
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings/SysConnectionStringSettings.json");

            String json;
            using (StreamReader streamReader = new StreamReader(path)) { json = streamReader.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Models.SysConnectionStringModel sysConnectionString = javaScriptSerializer.Deserialize<Models.SysConnectionStringModel>(json);

            String connectionString = "Data Source=" + sysConnectionString.DataSource
                + ";Initial Catalog=" + sysConnectionString.InitialCatalog
                + ";Persist Security Info=True;User ID=" + sysConnectionString.UserId
                + ";Password=" + sysConnectionString.Password;

            return connectionString;
        }

        public static Database.covid2019dbDataContext GetCovid2019Database()
        {
            return new Database.covid2019dbDataContext(GetConnectionString());
        }
    }
}
