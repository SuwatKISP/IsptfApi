﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPTF.Models.ExportBC
{
    public class PEXBCDeleteReq
    {
        public string EXPORT_BC_NO { get; set; }
        //public string RECORD_TYPE { get; set; }
        //public string REC_STATUS { get; set; }
        //public string EVENT_NO { get; set; }
        public DateTime EVENT_DATE { get; set; }

    }
}
