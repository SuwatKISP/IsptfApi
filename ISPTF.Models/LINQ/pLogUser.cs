﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models
{
    public partial class pLogUser
    {
        public DateTime LogDate { get; set; }
        public string LogTime { get; set; }
        public int SeqNo { get; set; }
        public string UserCode { get; set; }
        public string ComName { get; set; }
        public string Status { get; set; }
        public string CenterID { get; set; }
    }
}
