﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPTF.Models.ExportBC;
using ISPTF.Models.PEXPayment;

namespace ISPTF.Models.PurchasePayment
{
    public class PEXBCPEXPaymentSaveReq
    {
        public PEXBCRsp PEXBC { get; set; }
        public PEXPaymentSaveReq PEXPayment{ get; set; }
    }
}
