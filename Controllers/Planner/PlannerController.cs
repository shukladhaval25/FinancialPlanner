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
        public Result<IList<FinancialPlanner.Common.Model.Planner>> GetByClientId(int id)
        {
            var result = new Result<IList<FinancialPlanner.Common.Model.Planner>>();
            PlannerService plannerService = new PlannerService();

            var lstPlanner = plannerService.GetByClientId(id);
            result.Value = (IList<FinancialPlanner.Common.Model.Planner>)lstPlanner;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Planner/GetByPlannerId")]
        [HttpGet]
        public Result<FinancialPlanner.Common.Model.Planner> GetByPlannerId(int id)
        {
            var result = new Result<FinancialPlanner.Common.Model.Planner>();
            PlannerService plannerService = new PlannerService();

            var planner = plannerService.GetByPlannerId(id);
            result.Value = planner;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Planner/Add")]
        [HttpPost]
        public Result Add(FinancialPlanner.Common.Model.Planner planner)
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

        [Route("api/Planner/Update")]
        [HttpPost]
        public Result Update(FinancialPlanner.Common.Model.Planner planner)
        {
            var result = new Result();
            try
            {
                PlannerService plannerService = new PlannerService();
                plannerService.Update(planner);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Planner/Delete")]
        [HttpPost]
        public Result Delete(FinancialPlanner.Common.Model.Planner planner)
        {
            var result = new Result();
            try
            {
                PlannerService plannerService = new PlannerService();
                plannerService.Delete(planner);
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