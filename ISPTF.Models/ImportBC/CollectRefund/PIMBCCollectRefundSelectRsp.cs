﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPTF.Models.PPayment;

namespace ISPTF.Models.ImportBC
{
    public class PIMBCCollectRefundSelectRsp : PPaymentRsp
    {

        public string BCNumber { get; set; }
        public string? RecType { get; set; }
        public int BCSeqno { get; set; }
        public string? BCStatus { get; set; }
        public string? RecStatus { get; set; }
        public string? EventMode { get; set; }
        public string? Event { get; set; }
        public DateTime? EventDate { get; set; }
        public string? EventFlag { get; set; }
        public string? LOCode { get; set; }
        public string? AOCode { get; set; }
        public string? BCType { get; set; }
        public double? SGAmt { get; set; }
        public double? SGAmt1 { get; set; }
        public string? SGNumber { get; set; }
        public string? SGNumber1 { get; set; }
        public string? SGNumber2 { get; set; }
        public string? SGNumber3 { get; set; }
        public string? SGNumber4 { get; set; }
        public string? TransFrom { get; set; }
        public string? TransBy { get; set; }
        public DateTime? OverdueDate { get; set; }
        public string? BCOverDue { get; set; }
        public string? AutoOverDue { get; set; }
        public string? BLNumber { get; set; }
        public string? INVNumber { get; set; }
        public string? CustCode { get; set; }
        public string? CustAddr { get; set; }
        public string? DrawerName { get; set; }
        public string? DrawerInfo { get; set; }
        public string? DrawerCnty { get; set; }
        public string? DrawerCity { get; set; }
        public string? BCCcy { get; set; }
        public double? BCAmount { get; set; }
        public double? BCBalance { get; set; }
        public string? AmendFlag { get; set; }
        public double? AmendAmt { get; set; }
        public DateTime? DraftDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PrevDueDate { get; set; }
        public string? TenorTerm { get; set; }
        public int? TenorDay { get; set; }
        public string? AcceptFlag { get; set; }
        public DateTime? AcceptDate { get; set; }
        public string? MTNo { get; set; }
        public double? FBCharge { get; set; }
        public double? FBInterest { get; set; }
        public double? DeductAmt { get; set; }
        public string? Goods { get; set; }
        public string? Document { get; set; }
        public string? RemitFlag { get; set; }
        public DateTime? RemitDate { get; set; }
        public string? MTNego { get; set; }
        public string? RemitBank { get; set; }
        public string? RemitAddr { get; set; }
        public string? RemitRefno { get; set; }
        public string? RemitCity { get; set; }
        public string? RemitCnty { get; set; }
        public string? RemitChipUID { get; set; }
        public string? ThirdBank { get; set; }
        public string? ThirdAddr { get; set; }
        public string? ThirdRefno { get; set; }
        public string? ReimBank { get; set; }
        public string? ChipReim { get; set; }
        public string? ReimAddr { get; set; }
        public string? IntermBank { get; set; }
        public string? ChipInterm { get; set; }
        public string? IntermAddr { get; set; }
        public string? AcBank { get; set; }
        public string? ChipAcBank { get; set; }
        public string? AcAddr { get; set; }
        public double? IntBefore { get; set; }
        public double? ExchBefore { get; set; }
        public string? IntRateCode { get; set; }
        public double? IntRate { get; set; }
        public double? IntSpread { get; set; }
        public string? IntFlag { get; set; }
        public int? IntBaseDay { get; set; }
        public DateTime? IntStartDate { get; set; }
        public DateTime? LastIntDate { get; set; }
        public double? LastIntAmt { get; set; }
        public double? IntBalance { get; set; }
        public double? ExchRate { get; set; }
        public double? EngageRate { get; set; }
        public double? EngageComm { get; set; }
        public double? FBChargeTHB { get; set; }
        public double? FBInterestTHB { get; set; }
        public double? CommFCD { get; set; }
        public double? CableAmt { get; set; }
        public double? DutyAmt { get; set; }
        public double? PostageAmt { get; set; }
        public double? PayableAmt { get; set; }
        public double? CommOther { get; set; }
        public double? IBCComRate { get; set; }
        public double? IBCComm { get; set; }
        public double? CommLieu { get; set; }
        public double? ProtestAmt { get; set; }
        public double? CommExch { get; set; }
        public string? TaxRefund { get; set; }
        public double? TaxAmt { get; set; }
        public string? PayFlag { get; set; }
        public string? PayType { get; set; }
        public double? PayAmount { get; set; }
        public double? PayInterest { get; set; }
        public string? PayMethod { get; set; }
        public string? PayRemark { get; set; }
        public string? Allocation { get; set; }
        public DateTime? DateLastPaid { get; set; }
        public string? LastReceiptNo { get; set; }
        public string? AppvNo { get; set; }
        public string? FacNo { get; set; }
        public string? FCyPayFlag { get; set; }
        public string? FCyAcNo { get; set; }
        public string? FCyReceiptNo { get; set; }

        //public DateTime? UpdateDate { get; set; }
        public string? UserCode { get; set; }

        //public DateTime? AuthDate { get; set; }
        public string? AuthCode { get; set; }
        public string? GenAccFlag { get; set; }
        public string? VoucherID { get; set; }
        public double? TotalAccruAmt { get; set; }
        public double? TotalAccruBht { get; set; }
        public double? AccruAmt { get; set; }
        public double? AccruBht { get; set; }
        public DateTime? DateLastAccru { get; set; }
        public string? GoodsDesc { get; set; }
        public string? Tx72 { get; set; }
        public string? Tx79 { get; set; }
        public string? Tx23E { get; set; }
        public string? Tx71A { get; set; }
        public string? Tx26 { get; set; }
        public string? Tx59A { get; set; }
        public string? Tx59D { get; set; }
        public string? Tx70 { get; set; }
        public string? DMS { get; set; }
        public string? CenterID { get; set; }
        public string? CCS_ACCT { get; set; }
        public string? CCS_LmType { get; set; }
        public string? CCS_CNUM { get; set; }
        public string? CCS_CIFRef { get; set; }
        public string? InUse { get; set; }
        public string? ObjectType { get; set; }
        public string? UnderlyName { get; set; }
        public string? BPOFlag { get; set; }
        public string? Campaign_Code { get; set; }
        public DateTime? Campaign_EffDate { get; set; }
        public string? PurposeCode { get; set; }

    }
}
