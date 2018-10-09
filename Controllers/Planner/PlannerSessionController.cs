using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class PlannerSesion : ApiController
    {
        //[Route("api/PlannerSession/GetAll")]
        //[HttpGet]
        ////Authorize]
        //public Result<IList<PlannerSessions>> GetAll(int plannerId)
        //{
        //    var result = new Result<IList<PlannerSession>>();
        //    PlannerSessionService PlannerSessionService = new PlannerSessionService();
        //    result.Value = PlannerSessionService.GetAll(plannerId);
        //    result.IsSuccess = true;
        //    return result;
        //}

        
        //[Route("api/PlannerSession/Add")]
        //[HttpPost]
        //public Result Add(PlannerSessions PlannerSession)
        //{
        //    var result = new Result();
        //    try
        //    {
        //        PlannerSessionService PlannerSessionService = new PlannerSessionService();
        //        PlannerSessionService.Add(PlannerSession);
        //        result.IsSuccess = true;
        //    }
        //    catch (Exception exception)
        //    {
        //        result.IsSuccess = false;
        //        result.ExceptionInfo = exception;
        //    }
        //    return result;
        //}

        //[Route("api/PlannerSession/Update")]
        //[HttpPost]
        ////[Authorize]
        //public Result Update(PlannerSessions PlannerSession)
        //{
        //    var result = new Result();
        //    try
        //    {
        //        PlannerSessionService PlannerSessionService = new PlannerSessionService();
        //        PlannerSessionService.Update(PlannerSession);
        //        result.IsSuccess = true;
        //    }
        //    catch (Exception exception)
        //    {
        //        result.IsSuccess = false;
        //        result.ExceptionInfo = exception;
        //    }
        //    return result;
        //}

    }
}
