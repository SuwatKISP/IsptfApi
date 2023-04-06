﻿//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPTF.Models.PIMTRInvoice
{
    public class PIMTRInvoice
    {
        public string? CustCode { get; set; }
        public string? InvNumber { get; set; }
        public DateTime? InvDate { get; set; }
        public string? InvGroup { get; set; }
        public string? InvSupply { get; set; }
        public string? InvCcy { get; set; }
        public double? InvAmount { get; set; }
        public double? InvUse { get; set; }
        public double? InvBalance { get; set; }
        public string? InvStatus { get; set; }
        public DateTime? LastUpDate { get; set; }
        public string? UserCode { get; set; }
        public DateTime? UserDate { get; set; }
        public string? TRFlag { get; set; }

    }
}
