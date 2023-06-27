﻿using System.Collections.Generic;

namespace ISPTF.Models.Remittance
{
    public class DraftMiscellaneousListPageResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public List<Q_DraftMiscellaneousListPageRsp> Data { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int TotalPage { get; set; }
    }
}
