﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models
{
    public partial class ViewBankLimit
    {
        public string Bank_Code { get; set; }
        public string Facility_No { get; set; }
        public string Seq_No { get; set; }
        public string CCS_No { get; set; }
        public string Limit_Code { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Facility_Type { get; set; }
        public string Revol_Flag { get; set; }
        public string Credit_Ccy { get; set; }
        public double? Credit_Amount { get; set; }
        public double? Susp_Amount { get; set; }
        public string Remark { get; set; }
        public string Block_Code { get; set; }
        public DateTime? BlockDate { get; set; }
        public string Block_Note { get; set; }
        public string RecStatus { get; set; }
        public string RecCode { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? AuthDate { get; set; }
        public string UserCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string AuthCode { get; set; }
        public string UsingRec { get; set; }
        public double? Hold_Amount { get; set; }
        public string Condition { get; set; }
        public string AutoRec { get; set; }
        public double? Origin_Amount { get; set; }
        public double? Available_Amt { get; set; }
        public double Liab_Amt { get; set; }
        public double Pending_Amt { get; set; }
    }
}
