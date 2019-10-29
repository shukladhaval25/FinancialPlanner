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
    public class InvestmentRecommendationController : ApiController
    {
        [Route("api/InvestmentRecommendationController/Get")]
        [HttpGet]
        public Result<InvestmentRecommendation> Get(int plannerId)
        {
            Result<InvestmentRecommendation> result = new Result<InvestmentRecommendation>();
            //CashFlowService cashFlowService = new CashFlowService();
            //result.Value = cashFlowService.Get(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/InvestmentRecommendationController/Add")]
        [HttpPost]
        public Result Add(InvestmentRecommendation InvestmentRecommendation)
        {

            var result = new Result();
            try
            {
                //CashFlowService cashFlowService = new CashFlowService();
                //cashFlowService.Add(InvestmentRecommendation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InvestmentRecommendationController/Update")]
        [HttpPost]
        public Result Update(InvestmentRecommendation InvestmentRecommendation)
        {
            var result = new Result();
            try
            {
                //CashFlowService cashFlowService = new CashFlowService();
                //cashFlowService.Update(InvestmentRecommendation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InvestmentRecommendationController/Delete")]
        [HttpPost]
        public Result Delete(InvestmentRecommendation cashFlow)
        {
            var result = new Result();
            try
            {
                //CashFlowService cashFlowService = new CashFlowService();
                //cashFlowService.Delete(cashFlow);
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
