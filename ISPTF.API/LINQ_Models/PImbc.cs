﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models.LINQ
{
    public partial class PImbc
    {
        public string Bcnumber { get; set; }
        public string RecType { get; set; }
        public int Bcseqno { get; set; }
        public string Bcstatus { get; set; }
        public string RecStatus { get; set; }
        public string EventMode { get; set; }
        public string Event { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventFlag { get; set; }
        public string Locode { get; set; }
        public string Aocode { get; set; }
        public string Bctype { get; set; }
        public double? Sgamt { get; set; }
        public double? Sgamt1 { get; set; }
        public string Sgnumber { get; set; }
        public string Sgnumber1 { get; set; }
        public string Sgnumber2 { get; set; }
        public string Sgnumber3 { get; set; }
        public string Sgnumber4 { get; set; }
        public string TransFrom { get; set; }
        public string TransBy { get; set; }
        public DateTime? OverdueDate { get; set; }
        public string BcoverDue { get; set; }
        public string AutoOverDue { get; set; }
        public string Blnumber { get; set; }
        public string Invnumber { get; set; }
        public string CustCode { get; set; }
        public string CustAddr { get; set; }
        public string DrawerName { get; set; }
        public string DrawerInfo { get; set; }
        public string DrawerCnty { get; set; }
        public string DrawerCity { get; set; }
        public string Bcccy { get; set; }
        public double? Bcamount { get; set; }
        public double? Bcbalance { get; set; }
        public string AmendFlag { get; set; }
        public double? AmendAmt { get; set; }
        public DateTime? DraftDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PrevDueDate { get; set; }
        public string TenorTerm { get; set; }
        public int? TenorDay { get; set; }
        public string AcceptFlag { get; set; }
        public DateTime? AcceptDate { get; set; }
        public string Mtno { get; set; }
        public double? Fbcharge { get; set; }
        public double? Fbinterest { get; set; }
        public double? DeductAmt { get; set; }
        public string Goods { get; set; }
        public string Document { get; set; }
        public string RemitFlag { get; set; }
        public DateTime? RemitDate { get; set; }
        public string Mtnego { get; set; }
        public string RemitBank { get; set; }
        public string RemitAddr { get; set; }
        public string RemitRefno { get; set; }
        public string RemitCity { get; set; }
        public string RemitCnty { get; set; }
        public string RemitChipUid { get; set; }
        public string ThirdBank { get; set; }
        public string ThirdAddr { get; set; }
        public string ThirdRefno { get; set; }
        public string ReimBank { get; set; }
        public string ChipReim { get; set; }
        public string ReimAddr { get; set; }
        public string IntermBank { get; set; }
        public string ChipInterm { get; set; }
        public string IntermAddr { get; set; }
        public string AcBank { get; set; }
        public string ChipAcBank { get; set; }
        public string AcAddr { get; set; }
        public double? IntBefore { get; set; }
        public double? ExchBefore { get; set; }
        public string IntRateCode { get; set; }
        public double? IntRate { get; set; }
        public double? IntSpread { get; set; }
        public string IntFlag { get; set; }
        public int? IntBaseDay { get; set; }
        public DateTime? IntStartDate { get; set; }
        public DateTime? LastIntDate { get; set; }
        public double? LastIntAmt { get; set; }
        public double? IntBalance { get; set; }
        public double? ExchRate { get; set; }
        public double? EngageRate { get; set; }
        public double? EngageComm { get; set; }
        public double? FbchargeThb { get; set; }
        public double? FbinterestThb { get; set; }
        public double? CommFcd { get; set; }
        public double? CableAmt { get; set; }
        public double? DutyAmt { get; set; }
        public double? PostageAmt { get; set; }
        public double? PayableAmt { get; set; }
        public double? CommOther { get; set; }
        public double? IbccomRate { get; set; }
        public double? Ibccomm { get; set; }
        public double? CommLieu { get; set; }
        public double? ProtestAmt { get; set; }
        public double? CommExch { get; set; }
        public string TaxRefund { get; set; }
        public double? TaxAmt { get; set; }
        public string PayFlag { get; set; }
        public string PayType { get; set; }
        public double? PayAmount { get; set; }
        public double? PayInterest { get; set; }
        public string PayMethod { get; set; }
        public string PayRemark { get; set; }
        public string Allocation { get; set; }
        public DateTime? DateLastPaid { get; set; }
        public string LastReceiptNo { get; set; }
        public string AppvNo { get; set; }
        public string FacNo { get; set; }
        public string FcyPayFlag { get; set; }
        public string FcyAcNo { get; set; }
        public string FcyReceiptNo { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UserCode { get; set; }
        public DateTime? AuthDate { get; set; }
        public string AuthCode { get; set; }
        public string GenAccFlag { get; set; }
        public string VoucherId { get; set; }
        public double? TotalAccruAmt { get; set; }
        public double? TotalAccruBht { get; set; }
        public double? AccruAmt { get; set; }
        public double? AccruBht { get; set; }
        public DateTime? DateLastAccru { get; set; }
        public string GoodsDesc { get; set; }
        public string Tx72 { get; set; }
        public string Tx79 { get; set; }
        public string Tx23E { get; set; }
        public string Tx71A { get; set; }
        public string Tx26 { get; set; }
        public string Tx59A { get; set; }
        public string Tx59D { get; set; }
        public string Tx70 { get; set; }
        public string Dms { get; set; }
        public string CenterId { get; set; }
        public string CcsAcct { get; set; }
        public string CcsLmType { get; set; }
        public string CcsCnum { get; set; }
        public string CcsCifref { get; set; }
        public string InUse { get; set; }
        public string ObjectType { get; set; }
        public string UnderlyName { get; set; }
        public string Bpoflag { get; set; }
        public string CampaignCode { get; set; }
        public DateTime? CampaignEffDate { get; set; }
        public string PurposeCode { get; set; }
    }
}
