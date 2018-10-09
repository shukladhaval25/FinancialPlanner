using FinancialPlanner.BusinessLogic.PlanOption;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.PlanOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.PlanOptions
{
    public class CashFlowController : ApiController
    {
        [Route("api/CashFlow/Get")]
        [HttpGet]
        public Result<CashFlow> Get(int optionId)
        {
            Result<CashFlow> result = new Result<CashFlow>();
            CashFlowService cashFlowService = new CashFlowService();
            result.Value = cashFlowService.Get(optionId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/CashFlow/Add")]
        [HttpPost]
        public Result Add(CashFlow cashFlow)
        {

            var result = new Result();
            try
            {
                CashFlowService cashFlowService = new CashFlowService();
                cashFlowService.Add(cashFlow);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;                       
        }

        [Route("api/CashFlow/Update")]
        [HttpPost]
        public Result Update(CashFlow cashFlow)
        {
            var result = new Result();
            try
            {
                CashFlowService cashFlowService = new CashFlowService();
                cashFlowService.Update(cashFlow);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/CashFlow/Delete")]
        [HttpPost]
        public Result Delete(CashFlow cashFlow)
        {
            var result = new Result();
            try
            {
                CashFlowService cashFlowService = new CashFlowService();
                cashFlowService.Delete(cashFlow);
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
