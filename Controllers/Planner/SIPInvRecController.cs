using FinancialPlanner.BusinessLogic.PlanOption;
using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class SIPInvRecController : ApiController
    {
        [Route("api/SIPInvRecController/GetAll")]
        [HttpGet]
        public Result<IList<SIPTypeInvestmentRecomendation>> GetAll(int plannerId)
        {
            var result = new Result<IList<SIPTypeInvestmentRecomendation>>();
            SIPTypeInvestmentRecomendationService sIPTypeInvestmentRecomendationService = new SIPTypeInvestmentRecomendationService();
            result.Value = sIPTypeInvestmentRecomendationService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SIPInvRecController/Add")]
        [HttpPost]
        public Result Add(SIPTypeInvestmentRecomendation SIPInvestmentRecomendation)
        {
            var result = new Result();
            try
            {
                SIPTypeInvestmentRecomendationService SIPTypeInvestmentRecomendation = 
                    new SIPTypeInvestmentRecomendationService();
                SIPTypeInvestmentRecomendation.Add(SIPInvestmentRecomendation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SIPInvRecController/Delete")]
        [HttpPost]
        public Result Delete(SIPTypeInvestmentRecomendation SIPInvestmentRecomendation)
        {
            var result = new Result();
            try
            {
                SIPTypeInvestmentRecomendationService SIPTypeInvestmentRecomendation =
                   new SIPTypeInvestmentRecomendationService();
                SIPTypeInvestmentRecomendation.Delete(SIPInvestmentRecomendation);
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
