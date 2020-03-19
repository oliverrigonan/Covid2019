using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid2019.Models
{
    public class MstCityModel
    {
        public Int32 Id { get; set; }
        public String City { get; set; }
        public Int32 ProvinceId { get; set; }
        public Int32 CityType { get; set; }
    }
}
