using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class PlannerController : ApiController
    {
        [Route("api/Planner/GetByClientId")]
        [HttpGet]
        public Result<IList<Planner>> GetByClientId(int id)
        {
            var result = new Result<IList<Planner>>();
            PlannerService plannerService = new PlannerService();

            var lstPlanner = plannerService.GetByClientId(id);
            result.Value = (IList<Planner>)lstPlanner;
            result.IsSuccess = true;
            return result;
        }
       
        [Route("api/Planner/Add")]
        [HttpPost]
        public Result Add(Planner planner)
        {
            var result = new Result();
            try
            {
                PlannerService plannerService = new PlannerService();
                plannerService.Add(planner);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        // PUT: api/Planner/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Planner/5
        public void Delete(int id)
        {
        }
    }
}