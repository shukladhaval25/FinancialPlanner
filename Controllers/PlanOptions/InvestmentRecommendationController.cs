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
    public class InvestmentRecommendationController : ApiController
    {
        [Route("api/InvestmentRecommendationController/Get")]
        [HttpGet]
        public Result<InvestmentRecommendationRatio> Get(int plannerId)
        {
            var result = new Result<InvestmentRecommendationRatio>();
            InvestmentRecommendationService investmentRecommendationService = new InvestmentRecommendationService();
            result.Value = investmentRecommendationService.Get(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/InvestmentRecommendationController/AddRatio")]
        [HttpPost]
        public Result Add(InvestmentRecommendationRatio investmentRecommendationRatio)
        {

            var result = new Result();
            try
            {
                InvestmentRecommendationService investmentRecommendationService = new InvestmentRecommendationService();
                investmentRecommendationService.Add(investmentRecommendationRatio);           
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InvestmentRecommendationController/AddSendReport")]
        public Result AddSendReport(InvRecommendationSend invRecommendationSend)
        {
            var result = new Result();
            try
            {
                InvestmentRecommendationService investmentRecommendationService = new InvestmentRecommendationService();
                investmentRecommendationService.AddSendReport(invRecommendationSend);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InvestmentRecommendationController/GetSendReports")]
        [HttpGet]
        public Result<IList<InvRecommendationSend>> GetSendReports(int plannerId)
        {
            var result = new Result<IList<InvRecommendationSend>>();
            InvestmentRecommendationService investmentRecommendationService = new InvestmentRecommendationService();
            result.Value = investmentRecommendationService.GetSendReports(plannerId);
            result.IsSuccess = true;
            return result;
        }
    }
}
