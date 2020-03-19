using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid2019.Models
{
    public class SysConnectionStringModel
    {
        public String DataSource { get; set; }
        public String InitialCatalog { get; set; }
        public String UserId { get; set; }
        public String Password { get; set; }
    }
}
