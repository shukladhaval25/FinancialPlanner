using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.RiskProfile;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.Plans;

namespace FinancialPlanner.Controllers
{
    public class RecommendedSchemesController : ApiController
    {
        [Route("api/RecommendedSchemes/GetAll")]
        [HttpGet]
        public Result<IList<RecommendedSchemes>> GetAll(int investmentsegmentid)
        {
            var result = new Result<IList<RecommendedSchemes>>();
            RecommendedSchemesService recommendedSchemesService = new RecommendedSchemesService();
            result.Value = recommendedSchemesService.GetAll(investmentsegmentid);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/RecommendedSchemes/Add")]
        [HttpPost]
        public Result Add(RecommendedSchemes RecommededSchemes)
        {
            var result = new Result();
            try
            {
                
                RecommendedSchemesService recommendedSchemesService = new RecommendedSchemesService();
                recommendedSchemesService.Add(RecommededSchemes);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RecommendedSchemes/Update")]
        [HttpPost]
        public Result Update(RecommendedSchemes RecommededSchemes)
        {
            var result = new Result();
            try
            {
                RecommendedSchemesService recommendedSchemesService = new RecommendedSchemesService();
                recommendedSchemesService.Update(RecommededSchemes);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RecommendedSchemes/Delete")]
        [HttpPost]
        public Result Delete(RecommendedSchemes RecommededSchemes)
        {
            var result = new Result();
            try
            {
                RecommendedSchemesService recommendedSchemesService = new RecommendedSchemesService();
                recommendedSchemesService.Delete(RecommededSchemes);
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
