﻿//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPTF.Models.TradeCreditLimit

{
    public class PCustShare
    {
        public string? Cust_Code { get; set; }
        public string? Facility_No { get; set; }
        public int? Seqno { get; set; }
        public string? Share_Cust { get; set; }
        public string? Share_Imp { get; set; }
        public string? Share_Exp { get; set; }
        public string? Share_Dlc { get; set; }
        public string? Share_LG { get; set; }
        public string? Share_Limit { get; set; }
        public double? Share_Credit { get; set; }
        public double? Share_Used { get; set; }
        public string? Share_CCS { get; set; }
        public string? Share_Mode { get; set; }
        public string? Status { get; set; }

    }
}
