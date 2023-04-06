﻿using Dapper;
using ISPTF.DataAccess.DbAccess;
using ISPTF.Models;
using ISPTF.Models.LoginRegis;
using ISPTF.Models.ExportBC;
using ISPTF.Models.ExportLC;
using ISPTF.Models.PEXPayment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
 
namespace ISPTF.API.Controllers.ExportLC
{
    [ApiController]
    [Route("api/[controller]")]
    public class EXLCCollectionRefundChargeController : ControllerBase
    {
        private readonly ISqlDataAccess _db;
        public EXLCCollectionRefundChargeController(ISqlDataAccess db)
        {
            _db = db;
        }

        [HttpGet("list")]
        public async Task<IEnumerable<Q_EXLCCollectionPaymentListPageRsp>> GetAllList(string? @ListType, string? CenterID, string? EXPORT_LC_NO, string? BENName, string? USER_ID, string? Page, string? PageSize)
        {
            DynamicParameters param = new();

            param.Add("@ListType", @ListType);
            param.Add("@CenterID", CenterID);
            param.Add("@EXPORT_LC_NO", EXPORT_LC_NO);
            param.Add("@BENName", BENName);
            param.Add("@USER_ID", USER_ID);
            param.Add("@Page", Page);
            param.Add("@PageSize", PageSize);

            if (EXPORT_LC_NO == null)
            {
                param.Add("@EXPORT_LC_NO", "");
            }
            if (BENName == null)
            {
                param.Add("@BENName", "");
            }

            var results = await _db.LoadData<Q_EXLCCollectionPaymentListPageRsp, dynamic>(
                        storedProcedure: "usp_q_EXLC_CollectRefundChargeListPage",
                        param);
            return results;
        }

        //[HttpGet("query")]
        //public async Task<IEnumerable<Q_EXBCPurchasePaymentQueryPageRsp>> GetAllQuery( string? CenterID, string? EXPORT_BC_NO, string? BENName, string? USER_ID, string? Page, string? PageSize)
        //{
        //    DynamicParameters param = new();

        //    //param.Add("@ListType", @ListType);
        //    param.Add("@CenterID", CenterID);
        //    param.Add("@EXPORT_BC_NO", EXPORT_BC_NO);
        //    param.Add("@BENName", BENName);
        //    param.Add("@USER_ID", USER_ID);
        //    param.Add("@Page", Page);
        //    param.Add("@PageSize", PageSize);

        //    if (EXPORT_BC_NO == null)
        //    {
        //        param.Add("@EXPORT_BC_NO", "");
        //    }
        //    if (BENName == null)
        //    {
        //        param.Add("@BENName", "");
        //    }

        //    var results = await _db.LoadData<Q_EXBCPurchasePaymentQueryPageRsp, dynamic>(
        //                storedProcedure: "usp_q_EXLC_PurchasePaymentQueryPage",
        //                param);
        //    return results;
        //}


        [HttpGet("select")]
        //public async Task<IEnumerable<PEXLCPPaymentRsp>> GetAllSelect(string? EXPORT_BC_NO , string? EVENT_NO, string? LFROM)
        public async Task<ActionResult<List<PEXLCPPaymentRsp>>> GetAllSelect(string? EXPORT_LC_NO, string? EVENT_NO, string? LFROM)
        {
            DynamicParameters param = new();

            param.Add("@EXPORT_LC_NO", EXPORT_LC_NO);
            param.Add("@EVENT_NO", EVENT_NO);
            param.Add("@LFROM", LFROM);

            param.Add("@PExLcRsp", dbType: DbType.Int32,
                       direction: System.Data.ParameterDirection.Output,
                       size: 12800);

            param.Add("@PEXLCPPaymentRsp", dbType: DbType.String,
                       direction: System.Data.ParameterDirection.Output,
                       size: 5215585);
            try
            {
                var results = await _db.LoadData<PEXLCPPaymentRsp, dynamic>(
                           storedProcedure: "usp_pEXLC_CollectRefundCharge_Select",
                           param);

                var PExLcRsp = param.Get<dynamic>("@PExLcRsp");
                var pexlcppaymenttrsp = param.Get<dynamic>("@PEXLCPPaymentRsp");

                if (PExLcRsp > 0)
                {
                    return Ok(pexlcppaymenttrsp);
                }
                else
                {

                    ReturnResponse response = new();
                    response.StatusCode = "400";
                    response.Message = "EXPORT L/C NO does not exit";
                    return BadRequest(response);
                }
               
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            //return results;
        }







    }
}
