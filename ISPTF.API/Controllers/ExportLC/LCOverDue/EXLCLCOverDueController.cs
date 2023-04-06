﻿using Dapper;
using ISPTF.DataAccess.DbAccess;
using ISPTF.Models;
using ISPTF.Models.LoginRegis;
using ISPTF.Models.ExportBC;
using ISPTF.Models.ExportLC;
using ISPTF.Models.PurchasePayment;
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
    public class EXLCLCOverDueController : ControllerBase
    {
        private readonly ISqlDataAccess _db;
        public EXLCLCOverDueController(ISqlDataAccess db)
        {
            _db = db;
        }

        [HttpGet("list")]
        public async Task<IEnumerable<Q_EXLCEditFlagListPageRsp>> GetAllList(string? @ListType, string? CenterID, string? EXPORT_LC_NO, string? BENName, string? USER_ID, string? Page, string? PageSize)
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

            var results = await _db.LoadData<Q_EXLCEditFlagListPageRsp, dynamic>(
                        storedProcedure: "usp_q_EXLC_LCOverDueListPage",
                        param);
            return results;
        }

        [HttpGet("select")]
        public async Task<ActionResult<PEXLCRecordRsp>> GetAllSelect(string? EXPORT_LC_NO, int? EVENT_NO, string? LFROM)
        {
            DynamicParameters param = new();

            param.Add("@EXPORT_LC_NO", EXPORT_LC_NO);
            param.Add("@EVENT_NO", EVENT_NO);
            //param.Add("@RECORD_TYPE", RECORD_TYPE);
            //param.Add("@REC_STATUS", REC_STATUS);
            param.Add("@LFROM", LFROM);

            //var results = await _db.LoadData<PEXLCRsp, dynamic>(
            //            storedProcedure: "usp_pEXLC_LCOverDue_Select",
            //            param);
            //return results;
            param.Add("@PEXLCRsp", dbType: DbType.Int32,
               direction: System.Data.ParameterDirection.Output,
               size: 12800);
            param.Add("@PEXLCRecordRsp", dbType: DbType.String,
               direction: System.Data.ParameterDirection.Output,
               size: 5215585);

            try
            {
                var results = await _db.LoadData<PEXLCRecordRsp, dynamic>(
                           storedProcedure: "usp_pEXLC_LCOverDue_Select",
                           param);

                var PEXLCRsp = param.Get<dynamic>("@PEXLCRsp");
                var pexlrecordrsp = param.Get<dynamic>("@PEXLCRecordRsp");

                if (PEXLCRsp > 0)
                {
                    return Ok(pexlrecordrsp);
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
        }









    }
}
