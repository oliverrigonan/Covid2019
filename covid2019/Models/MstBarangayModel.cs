﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid2019.Models
{
    public class MstBarangayModel
    {
        public Int32 Id { get; set; }
        public String Barangay { get; set; }
        public Int32 CityId { get; set; }
    }
}
