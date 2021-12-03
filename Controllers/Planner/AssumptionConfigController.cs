using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Planner
{
    public class AssumptionConfigController : ApiController
    {
        [Route("api/AssumptionConfig/GetAll")]
        [HttpGet]
        public Result<AssumptionConfig> GetAll(int plannerId)
        {
            var result = new Result<AssumptionConfig>();
            AssumptionConfigService assumptionConfigService = new AssumptionConfigService();
            result.Value = assumptionConfigService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/AssumptionConfig/Update")]
        [HttpPost]
        public Result Update(AssumptionConfig assumptionConfig)
        {
            var result = new Result();
            try
            {
                AssumptionConfigService PlannerAssumptionService = new AssumptionConfigService();
                PlannerAssumptionService.Update(assumptionConfig);
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
