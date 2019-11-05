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
    public class STPInvRecController : ApiController
    {
        [Route("api/STPInvRecController/GetAll")]
        [HttpGet]
        public Result<IList<STPTypeInvestmentRecomendation>> GetAll(int plannerId)
        {
            var result = new Result<IList<STPTypeInvestmentRecomendation>>();
            STPInvestmentRecomendationService stpInvestmentRecomendationService = new STPInvestmentRecomendationService();
            result.Value = stpInvestmentRecomendationService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/STPInvRecController/Add")]
        [HttpPost]
        public Result Add(STPTypeInvestmentRecomendation stpTypeInvestmentRecommendation)
        {
            var result = new Result();
            try
            {
                STPInvestmentRecomendationService sTPInvestmentRecomendationService =
                    new STPInvestmentRecomendationService();
                sTPInvestmentRecomendationService.Add(stpTypeInvestmentRecommendation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/STPInvRecController/Delete")]
        [HttpPost]
        public Result Delete(STPTypeInvestmentRecomendation lumsumInvestmentRecomendation)
        {
            var result = new Result();
            try
            {
                STPInvestmentRecomendationService sTPInvestmentRecomendationService =
                   new STPInvestmentRecomendationService();
                sTPInvestmentRecomendationService.Delete(lumsumInvestmentRecomendation);
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
