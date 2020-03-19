using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid2019.Models
{
    public class MstProvinceModel
    {
        public Int32 Id { get; set; }
        public String Province { get; set; }
        public Int32 CountryId { get; set; }
    }
}
