﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models
{
    public partial class pCLogLimit
    {
        public string LRecType { get; set; }
        public int LLogSeq { get; set; }
        public string LCust_Code { get; set; }
        public string LFacility_No { get; set; }
        public string LCCS_No { get; set; }
        public string LLimit_Code { get; set; }
        public int? LUpdNo { get; set; }
        public string LStatus { get; set; }
        public DateTime? LStartDate { get; set; }
        public DateTime? LExpiryDate { get; set; }
        public string LFacility_Type { get; set; }
        public string LRevol_Flag { get; set; }
        public string LShare_Flag { get; set; }
        public string LShare_Type { get; set; }
        public string LCredit_Ccy { get; set; }
        public double? LCredit_Amount { get; set; }
        public double? LCredit_Share { get; set; }
        public string LRemark { get; set; }
        public string LBlock_Code { get; set; }
        public DateTime? LBlockDate { get; set; }
        public string LBlock_Note { get; set; }
        public double? LHold_Amount { get; set; }
        public double? LEar_Amount { get; set; }
        public string RecStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UserCode { get; set; }
        public DateTime? AuthDate { get; set; }
        public string AuthCode { get; set; }
        public string LParent_Id { get; set; }
        public int? LSseqno { get; set; }
        public string LCondition { get; set; }
        public double? LOrigin_Amount { get; set; }
        public string LCFRRate { get; set; }
        public double? LCFRSpread { get; set; }
        public double? LCFRAmount { get; set; }
        public string LCampaign_Code { get; set; }
        public DateTime? LCampaign_EffDate { get; set; }
    }
}
