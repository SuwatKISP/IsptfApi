﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models.LINQ
{
    public partial class ViewExPayment
    {
        public string RecordType { get; set; }
        public string RecStatus { get; set; }
        public int? EventNo { get; set; }
        public string Docnumber { get; set; }
        public string EventType { get; set; }
        public int? TenorOfColl { get; set; }
        public int? TenorType { get; set; }
        public string DraftCcy { get; set; }
        public double? DraftAmt { get; set; }
        public double? SightAmt { get; set; }
        public double? TermAmt { get; set; }
        public int? ClaimType { get; set; }
        public string BeneId { get; set; }
        public string IssueBankId { get; set; }
        public int? CollectAgent { get; set; }
        public string AgentBankId { get; set; }
        public double? NegoComm { get; set; }
        public double? TelexSwift { get; set; }
        public double? CourierPostage { get; set; }
        public double? StampFee { get; set; }
        public double? BeStamp { get; set; }
        public double? CommOther { get; set; }
        public double? HandingFee { get; set; }
        public double? Draftcomm { get; set; }
        public int? PayType { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? NegoAmt { get; set; }
        public double? LessAgent { get; set; }
        public double? TotNegoAmount { get; set; }
        public double? BankChargeAmt { get; set; }
        public double? NetProceedClaim { get; set; }
        public int? PayBy { get; set; }
        public int? AgentPayBy { get; set; }
        public int? SettlementCredit { get; set; }
        public double? ReceivePayAmt { get; set; }
        public int? PartialFullRate { get; set; }
        public double? SightPaidAmt { get; set; }
        public double? SightPaidRate { get; set; }
        public double? SightPaidThb { get; set; }
        public string SightForward { get; set; }
        public double? TermPaidAmt { get; set; }
        public double? TermPaidRate { get; set; }
        public double? TermPaidThb { get; set; }
        public string TermForward { get; set; }
        public double? TotPrincPaid { get; set; }
        public double? PartialAmt1 { get; set; }
        public double? PartialAmt2 { get; set; }
        public double? PartialAmt3 { get; set; }
        public double? PartialAmt4 { get; set; }
        public double? PartialAmt5 { get; set; }
        public double? PartialAmt6 { get; set; }
        public double? PartialRate1 { get; set; }
        public double? PartialRate2 { get; set; }
        public double? PartialRate3 { get; set; }
        public double? PartialRate4 { get; set; }
        public double? PartialRate5 { get; set; }
        public double? PartialRate6 { get; set; }
        public double? PartialAmt1Thb { get; set; }
        public double? PartialAmt2Thb { get; set; }
        public double? PartialAmt3Thb { get; set; }
        public double? PartialAmt4Thb { get; set; }
        public double? PartialAmt5Thb { get; set; }
        public double? PartialAmt6Thb { get; set; }
        public string ForwardConractNo1 { get; set; }
        public string ForwardConractNo2 { get; set; }
        public string ForwardConractNo3 { get; set; }
        public string ForwardConractNo4 { get; set; }
        public string ForwardConractNo5 { get; set; }
        public string ForwardConractNo6 { get; set; }
        public int? BaseDay { get; set; }
        public double? CurrentDisRate { get; set; }
        public double? CurrentIntRate { get; set; }
        public double? ComLieu { get; set; }
        public string FbCcy { get; set; }
        public double? FbAmt { get; set; }
        public double? FbRate { get; set; }
        public double? FbAmtThb { get; set; }
        public double? AgentAmt { get; set; }
        public double? AgentRate { get; set; }
        public double? AgentThb { get; set; }
        public double? OverPaidAmt { get; set; }
        public double? OverPaidRate { get; set; }
        public double? OverPaidThb { get; set; }
        public int? IntDay { get; set; }
        public double? IntPaidAmt { get; set; }
        public double? IntPaidRate { get; set; }
        public double? IntPaidThb { get; set; }
        public double? TotalNegoBalance { get; set; }
        public double? TotalNegoBalThb { get; set; }
        public double? ChargeCcy { get; set; }
        public double? ChargeRate { get; set; }
        public double? ChargeThb { get; set; }
        public double? TotalCharge { get; set; }
        public double? TotalDueToCus { get; set; }
        public string PaymentInstru { get; set; }
        public string Method { get; set; }
        public double? FcdAmt { get; set; }
        public string FcdAcc { get; set; }
        public double? BahtNet { get; set; }
        public string AcBahtnet { get; set; }
        public double? Mtamt { get; set; }
        public string DebitCreditFlag { get; set; }
        public string PaymentType { get; set; }
        public double? Expr1 { get; set; }
        public int? RefundTaxYn { get; set; }
        public double? RefundTaxAmt { get; set; }
        public string Allocation { get; set; }
        public string RpModule { get; set; }
        public string RpEvent { get; set; }
        public string RpDocNo { get; set; }
        public string RpCustCode { get; set; }
        public DateTime? RpPayDate { get; set; }
        public string RpPayBy { get; set; }
        public double? RpCashAmt { get; set; }
        public double? RpChqAmt { get; set; }
        public string RpChqNo { get; set; }
        public string RpChqBank { get; set; }
        public string RpChqBranch { get; set; }
        public string RpCustAc1 { get; set; }
        public double? RpCustAmt1 { get; set; }
        public string RpCustAc2 { get; set; }
        public double? RpCustAmt2 { get; set; }
        public string RpCustAc3 { get; set; }
        public double? RpCustAmt3 { get; set; }
        public DateTime? EventDate { get; set; }
        public DateTime? PurchDiscDate { get; set; }
        public string ReceivedNo { get; set; }
        public double? PurchaseRate { get; set; }
        public double? PurchaseAmt { get; set; }
        public double? TotNegoAmt { get; set; }
        public double? Expr2 { get; set; }
        public double? PrnPaidThb { get; set; }
        public double? DiscountAmt { get; set; }
        public double? Discrate { get; set; }
        public double? DiscountCcy { get; set; }
        public double? ComLieuRate { get; set; }
        public double? ParAmt { get; set; }
        public double? ParAmtThb { get; set; }
    }
}
