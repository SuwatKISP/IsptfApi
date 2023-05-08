﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISPTF.Models;

namespace ISPTF.Models.ExportAdvLC
{
    public class PEXADResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public pExad Data { get; set; }
        public int Page { get; set; }
        public int Total { get; set; }
        public int TotalPage { get; set; }
    }
}
