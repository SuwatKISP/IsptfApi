﻿//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPTF.Models.PIMSBLC
{
    public class PEXPC_AmendAmount_Update_Req
    {
        public string? SBLCStatus { get; set; }
        public string? Event { get; set; }
        public DateTime? EventDate { get; set; }
        public string? RecStatus { get; set; }
        public int? AmendSeq { get; set; }
        public string? AmendNo { get; set; }
        public string? LGMode { get; set; }
        public string? LGType { get; set; }
        public DateTime? DateIssue { get; set; }
        public string? SBLCccy { get; set; }
        public double? SBLCAmt { get; set; }
        public double? SBLCbal { get; set; }
        public double? SBLCAvalbal { get; set; }
        public double? SBLCNet { get; set; }
        public double? LGTHBAmt { get; set; }
        public string? AmendFlag { get; set; }
        public double? AmendAmt { get; set; }
        public double? THBAmt { get; set; }
        public double? PrevSBLCNet { get; set; }
        public string? ChkExpiry { get; set; }
        public DateTime? PrevDateExpiry { get; set; }
        public DateTime? DateExpiry { get; set; }
        public DateTime? DateClaimBefore { get; set; }
        public DateTime? DateStartBond { get; set; }
        public int? sbLcDays { get; set; }
        public int? PrevSBLCDays { get; set; }
        public string? CustCode { get; set; }
        public string? CustAddr { get; set; }
        public string? benCode { get; set; }
        public string? beninfo { get; set; }
        public string? PrevBenCode { get; set; }
        public string? PrevBenInfo { get; set; }
        public int? TenorDay { get; set; }
        public string? TenorTerm { get; set; }
        public string? BankCode { get; set; }
        public string? BankName { get; set; }
        public string? bankDesc { get; set; }
        public string? Informations { get; set; }
        public string? InvoiceInfo { get; set; }
        public string? Commcollected { get; set; }
        public double? exchrate { get; set; }
        public double? CommLCRate { get; set; }
        public string? taxrefund { get; set; }
        public double? CommAmt { get; set; }
        public double? DutyStamp { get; set; }
        public double? TelexCharge { get; set; }
        public double? OthCharge { get; set; }
        public double? TaxAmt { get; set; }
        public string? PayFlag { get; set; }
        public string? paymethod { get; set; }
        public string? payremark { get; set; }
        public DateTime? DateLastPaid { get; set; }
        public string? LastReceiptNo { get; set; }
        public string? DMS { get; set; }
        public string? Allocation { get; set; }
        public string? CenterID { get; set; }

    }
}

//param.Add("@TenorTerm", pimsblcupdate.TenorTerm);
//param.Add("@BankCode", pimsblcupdate.BankCode);
//param.Add("@BankName", pimsblcupdate.BankName);
//param.Add("@bankDesc", pimsblcupdate.bankDesc);
//param.Add("@Informations", pimsblcupdate.Informations);
//param.Add("@InvoiceInfo", pimsblcupdate.InvoiceInfo);
//param.Add("@Commcollected", pimsblcupdate.Commcollected);
//param.Add("@exchrate", pimsblcupdate.exchrate);
//param.Add("@CommLCRate", pimsblcupdate.CommLCRate);
//param.Add("@taxrefund", pimsblcupdate.taxrefund);
//param.Add("@CommAmt", pimsblcupdate.CommAmt);
//param.Add("@DutyStamp", pimsblcupdate.DutyStamp);
//param.Add("@TelexCharge", pimsblcupdate.TelexCharge);
//param.Add("@OthCharge", pimsblcupdate.OthCharge);
//param.Add("@TaxAmt", pimsblcupdate.TaxAmt);
//param.Add("@PayFlag", pimsblcupdate.PayFlag);
//param.Add("@paymethod", pimsblcupdate.paymethod);
//param.Add("@payremark", pimsblcupdate.payremark);
//param.Add("@DateLastPaid", pimsblcupdate.DateLastPaid);
//param.Add("@LastReceiptNo", pimsblcupdate.LastReceiptNo);
//param.Add("@DMS", pimsblcupdate.DMS);
//param.Add("@Allocation", pimsblcupdate.Allocation);
//param.Add("@CenterID", pimsblcupdate.CenterID);
