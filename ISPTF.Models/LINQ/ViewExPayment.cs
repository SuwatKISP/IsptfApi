﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISPTF.Models
{
    public partial class ViewExPayment
    {
        public string RECORD_TYPE { get; set; }
        public string REC_STATUS { get; set; }
        public int? EVENT_NO { get; set; }
        public string DOCNUMBER { get; set; }
        public string EVENT_TYPE { get; set; }
        public int? TENOR_OF_COLL { get; set; }
        public int? TENOR_TYPE { get; set; }
        public string DRAFT_CCY { get; set; }
        public double? DRAFT_AMT { get; set; }
        public double? SIGHT_AMT { get; set; }
        public double? TERM_AMT { get; set; }
        public int? CLAIM_TYPE { get; set; }
        public string BENE_ID { get; set; }
        public string ISSUE_BANK_ID { get; set; }
        public int? COLLECT_AGENT { get; set; }
        public string AGENT_BANK_ID { get; set; }
        public double? NEGO_COMM { get; set; }
        public double? TELEX_SWIFT { get; set; }
        public double? COURIER_POSTAGE { get; set; }
        public double? STAMP_FEE { get; set; }
        public double? BE_STAMP { get; set; }
        public double? COMM_OTHER { get; set; }
        public double? HANDING_FEE { get; set; }
        public double? DRAFTCOMM { get; set; }
        public int? PAY_TYPE { get; set; }
        public DateTime? PAYMENT_DATE { get; set; }
        public double? NEGO_AMT { get; set; }
        public double? LESS_AGENT { get; set; }
        public double? TOT_NEGO_AMOUNT { get; set; }
        public double? BANK_CHARGE_AMT { get; set; }
        public double? NET_PROCEED_CLAIM { get; set; }
        public int? PAY_BY { get; set; }
        public int? AGENT_PAY_BY { get; set; }
        public int? SETTLEMENT_CREDIT { get; set; }
        public double? RECEIVE_PAY_AMT { get; set; }
        public int? PARTIAL_FULL_RATE { get; set; }
        public double? SIGHT_PAID_AMT { get; set; }
        public double? SIGHT_PAID_RATE { get; set; }
        public double? SIGHT_PAID_THB { get; set; }
        public string SIGHT_FORWARD { get; set; }
        public double? TERM_PAID_AMT { get; set; }
        public double? TERM_PAID_RATE { get; set; }
        public double? TERM_PAID_THB { get; set; }
        public string TERM_FORWARD { get; set; }
        public double? TOT_PRINC_PAID { get; set; }
        public double? PARTIAL_AMT1 { get; set; }
        public double? PARTIAL_AMT2 { get; set; }
        public double? PARTIAL_AMT3 { get; set; }
        public double? PARTIAL_AMT4 { get; set; }
        public double? PARTIAL_AMT5 { get; set; }
        public double? PARTIAL_AMT6 { get; set; }
        public double? PARTIAL_RATE1 { get; set; }
        public double? PARTIAL_RATE2 { get; set; }
        public double? PARTIAL_RATE3 { get; set; }
        public double? PARTIAL_RATE4 { get; set; }
        public double? PARTIAL_RATE5 { get; set; }
        public double? PARTIAL_RATE6 { get; set; }
        public double? PARTIAL_AMT1_THB { get; set; }
        public double? PARTIAL_AMT2_THB { get; set; }
        public double? PARTIAL_AMT3_THB { get; set; }
        public double? PARTIAL_AMT4_THB { get; set; }
        public double? PARTIAL_AMT5_THB { get; set; }
        public double? PARTIAL_AMT6_THB { get; set; }
        public string FORWARD_CONRACT_NO1 { get; set; }
        public string FORWARD_CONRACT_NO2 { get; set; }
        public string FORWARD_CONRACT_NO3 { get; set; }
        public string FORWARD_CONRACT_NO4 { get; set; }
        public string FORWARD_CONRACT_NO5 { get; set; }
        public string FORWARD_CONRACT_NO6 { get; set; }
        public int? BASE_DAY { get; set; }
        public double? CURRENT_DIS_RATE { get; set; }
        public double? CURRENT_INT_RATE { get; set; }
        public double? Com_Lieu { get; set; }
        public string fb_ccy { get; set; }
        public double? fb_amt { get; set; }
        public double? fb_rate { get; set; }
        public double? fb_amt_thb { get; set; }
        public double? Agent_amt { get; set; }
        public double? Agent_rate { get; set; }
        public double? Agent_thb { get; set; }
        public double? over_paid_amt { get; set; }
        public double? over_paid_rate { get; set; }
        public double? over_paid_thb { get; set; }
        public int? int_day { get; set; }
        public double? int_paid_amt { get; set; }
        public double? int_paid_rate { get; set; }
        public double? int_paid_thb { get; set; }
        public double? TOTAL_NEGO_BALANCE { get; set; }
        public double? TOTAL_NEGO_BAL_THB { get; set; }
        public double? Charge_Ccy { get; set; }
        public double? Charge_Rate { get; set; }
        public double? Charge_Thb { get; set; }
        public double? Total_Charge { get; set; }
        public double? TOTAL_DUE_TO_CUS { get; set; }
        public string PAYMENT_INSTRU { get; set; }
        public string Method { get; set; }
        public double? FcdAmt { get; set; }
        public string FcdAcc { get; set; }
        public double? BahtNet { get; set; }
        public string AcBahtnet { get; set; }
        public double? MTAmt { get; set; }
        public string Debit_credit_flag { get; set; }
        public string PaymentType { get; set; }
        public double? Expr1 { get; set; }
        public int? REFUND_TAX_YN { get; set; }
        public double? REFUND_TAX_AMT { get; set; }
        public string ALLOCATION { get; set; }
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
        public DateTime? EVENT_DATE { get; set; }
        public DateTime? PURCH_DISC_DATE { get; set; }
        public string RECEIVED_NO { get; set; }
        public double? PURCHASE_RATE { get; set; }
        public double? PURCHASE_AMT { get; set; }
        public double? TOT_NEGO_AMT { get; set; }
        public double? Expr2 { get; set; }
        public double? prn_paid_thb { get; set; }
        public double? DISCOUNT_AMT { get; set; }
        public double? DISCRATE { get; set; }
        public double? DISCOUNT_CCY { get; set; }
        public double? ComLieuRate { get; set; }
        public double? parAmt { get; set; }
        public double? parAmtTHB { get; set; }
    }
}
