using FinancialPlanner.Common.Model;
using System;
using System.Web.Http;
using FinancialPlanner.BusinessLogic;

namespace FinancialPlanner.Controllers
{
    public class PlannerAssumptionController : ApiController
    {
        [Route("api/PlannerAssumption/GetAll")]
        [HttpGet]
        public Result<PlannerAssumption> GetAll(int plannerId)
        {
            var result = new Result<PlannerAssumption>();
            PlannerAssumptionService PlannerAssumptionService = new PlannerAssumptionService();
            result.Value = PlannerAssumptionService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }
      
        [Route("api/PlannerAssumption/Update")]
        [HttpPost]
        public Result Update(PlannerAssumption PlannerAssumption)
        {
            var result = new Result();
            try
            {
                PlannerAssumptionService PlannerAssumptionService = new PlannerAssumptionService();
                PlannerAssumptionService.Update(PlannerAssumption);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

     
    }
}
