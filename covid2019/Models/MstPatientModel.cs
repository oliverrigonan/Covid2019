using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid2019.Models
{
    public class MstPatientModel
    {
        public Int32 Id { get; set; }
        public String PatientCode { get; set; }
        public String Patient { get; set; }
        public DateTime DateEncoded { get; set; }
        public DateTime DateOfArrival { get; set; }
        public DateTime DateOfQuarantine { get; set; }
        public Int32 Age { get; set; }
        public String Sex { get; set; }
        public String Address { get; set; }
        public String ContactNumber { get; set; }
        public Int32 BarangayId { get; set; }
        public String Barangay { get; set; }
        public Int32 CityId { get; set; }
        public String City { get; set; }
        public Int32 ProvinceId { get; set; }
        public String Province { get; set; }
        public Int32 CountryId { get; set; }
        public String Country { get; set; }
        public String Cluster { get; set; }
        public String PassportNumber { get; set; }
        public String Remarks { get; set; }
    }
}
