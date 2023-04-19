﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models.LINQ
{
    public partial class PLogSwiftInDetail
    {
        public string FileName { get; set; }
        public string SwiftInId { get; set; }
        public string SwiftInType { get; set; }
        public int RunLineNo { get; set; }
        public string Description { get; set; }
        public string FieldNo { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
