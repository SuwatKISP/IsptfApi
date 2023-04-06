﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPTF.Models.LoginRegis;

namespace ISPTF.Models.ExportLC
{
    public class Q_EXLCCoveringLetterListPageRsp

    {
        public int RCount { get; set; }
        public string EXPORT_LC_NO { get; set; }
        public string CUST_NAME { get; set; }
        public string DRAFT_CCY { get; set; }
        public double? NEGO_AMT { get; set; }
        public string TENOR_TYPE { get; set; }
        public string INVOICE { get; set; }
        public string EVENT_TYPE { get; set; }
        public string RECORD_TYPE { get; set; }
        public string REC_STATUS { get; set; }
        public string USER_ID { get; set; }
        public string COLLECT_AGENT { get; set; }
        public string CLAIM_TYPE { get; set; }
        public string DMS { get; set; }
        public string EVENT_NO { get; set; }

    }
}
