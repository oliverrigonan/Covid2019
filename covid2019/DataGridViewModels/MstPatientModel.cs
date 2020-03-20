using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid2019.DataGridViewModels
{
    public class MstPatientModel
    {
        public String ColumnButtonEdit { get; set; }
        public String ColumnButtonDelete { get; set; }
        public Int32 ColumnId { get; set; }
        public String ColumnPatientCode { get; set; }
        public String ColumnPatient { get; set; }
        public String ColumnDateEncoded { get; set; }
        public String ColumnDateOfArrival { get; set; }
        public String ColumnDateOfQuarantine { get; set; }
        public Int32 ColumnAge { get; set; }
        public String ColumnSex { get; set; }
        public String ColumnAddress { get; set; }
        public String ColumnContactNumber { get; set; }
        public Int32 ColumnBarangayId { get; set; }
        public String ColumnBarangay { get; set; }
        public Int32 ColumnCityId { get; set; }
        public String ColumnCity { get; set; }
        public Int32 ColumnProvinceId { get; set; }
        public String ColumnProvince { get; set; }
        public Int32 ColumnCountryId { get; set; }
        public String ColumnCountry { get; set; }
        public String ColumnCluster { get; set; }
        public String ColumnPassportNumber { get; set; }
        public String ColumnRemarks { get; set; }
        public String ColumnSpace { get; set; }
    }
}
