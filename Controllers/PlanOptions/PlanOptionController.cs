using FinancialPlanner.BusinessLogic.PlanOption;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.PlanOptions
{
    public class PlanOptionController : ApiController
    {
        [Route("api/PlanOption/GetAll")]
        [HttpGet]
        public Result<IList<PlanOption>> GetAll(int plannerId)
        {
            var result = new Result<IList<PlanOption>>();
            PlanOptionService planOptionService = new PlanOptionService();
            result.Value = planOptionService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/PlanOption/Add")]
        [HttpPost]
        public Result Add(PlanOption planOption)
        {
            var result = new Result();
            try
            {
                PlanOptionService planOptionService = new PlanOptionService();
                planOptionService.Add(planOption);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/PlanOption/Update")]
        [HttpPost]
        public Result Update(PlanOption planOption)
        {
            var result = new Result();
            try
            {
                PlanOptionService planOptionService = new PlanOptionService();
                planOptionService.Update(planOption);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/PlanOption/Delete")]
        [HttpPost]
        public Result Delete(PlanOption planOption)
        {
            var result = new Result();
            try
            {
                PlanOptionService planOptionService = new PlanOptionService();
                planOptionService.Delete(planOption);
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
