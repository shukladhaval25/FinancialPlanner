using FinancialPlanner.BusinessLogic.PlanOption;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class SwitchInvRecController : ApiController
    {
        [Route("api/SwitchInvRecController/GetAll")]
        [HttpGet]
        public Result<IList<SwitchTypeInvestmentRecommendation>> GetAll(int plannerId)
        {
            var result = new Result<IList<SwitchTypeInvestmentRecommendation>>();
            SwitchInvestmentRecommendationService switchInvestmentRecomendationService = new SwitchInvestmentRecommendationService();
            result.Value = switchInvestmentRecomendationService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SwitchInvRecController/Add")]
        [HttpPost]
        public Result Add(SwitchTypeInvestmentRecommendation switchTypeInvestmentRecommendation)
        {
            var result = new Result();
            try
            {
                SwitchInvestmentRecommendationService switchInvestmentRecomendationService = new SwitchInvestmentRecommendationService();
                switchInvestmentRecomendationService.Add(switchTypeInvestmentRecommendation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SwitchInvRecController/Delete")]
        [HttpPost]
        public Result Delete(SwitchTypeInvestmentRecommendation lumsumInvestmentRecomendation)
        {
            var result = new Result();
            try
            {
                SwitchInvestmentRecommendationService switchInvestmentRecomendationService = new SwitchInvestmentRecommendationService();
                switchInvestmentRecomendationService.Delete(lumsumInvestmentRecomendation);
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
