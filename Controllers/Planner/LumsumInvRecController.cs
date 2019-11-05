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
    public class LumsumInvRecController : ApiController
    {
        [Route("api/LumsumInvRecController/GetAll")]
        [HttpGet]
        public Result<IList<LumsumInvestmentRecomendation>> GetAll(int plannerId)
        {
            var result = new Result<IList<LumsumInvestmentRecomendation>>();
            LumsumInvestmentRecomendationService lumsumInvestmentRecomendationService = new LumsumInvestmentRecomendationService();
            result.Value = lumsumInvestmentRecomendationService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/LumsumInvRecController/Add")]
        [HttpPost]
        public Result Add(LumsumInvestmentRecomendation lumsumInvestmentRecomendation)
        {
            var result = new Result();
            try
            {
                LumsumInvestmentRecomendationService lumsumInvestmentRecomendationService = 
                    new LumsumInvestmentRecomendationService();
                lumsumInvestmentRecomendationService.Add(lumsumInvestmentRecomendation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/LumsumInvRecController/Delete")]
        [HttpPost]
        public Result Delete(LumsumInvestmentRecomendation lumsumInvestmentRecomendation)
        {
            var result = new Result();
            try
            {
                LumsumInvestmentRecomendationService lumsumInvestmentRecomendationService =
                     new LumsumInvestmentRecomendationService();
                lumsumInvestmentRecomendationService.Delete(lumsumInvestmentRecomendation);
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
