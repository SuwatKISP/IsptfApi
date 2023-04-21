﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models
{
    public partial class mAccount
    {
        public string Acc_Code { get; set; }
        public string Acc_Name { get; set; }
        public string Acc_Map { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UserCode { get; set; }
        public string Acc_GFMS { get; set; }
        public string Acc_GFMS_Sub { get; set; }
        public string GFMS_Map { get; set; }
        public string GFMS_Prod { get; set; }
        public string GFMS_Bran { get; set; }
        public string GFMS_SBU { get; set; }
        public string Acc_Flag { get; set; }
    }
}
