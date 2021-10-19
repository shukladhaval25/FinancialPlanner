using FinancialPlanner.BusinessLogic.PlanOption;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Planner
{
    public class InsuranceRecomendationController : ApiController
    {

        [Route("api/InsuranceRecomendation/GetAll")]
        [HttpGet]
        //Authorize]
        public Result<IList<InsuranceRecomendationTransaction>> GetAll(int planId)
        {
            var result = new Result<IList<InsuranceRecomendationTransaction>>();
            InsuranceRecomendationService insuranceRecomendationService = new InsuranceRecomendationService();
            result.Value = insuranceRecomendationService.GetInsuranceRecomendationByProjectId(planId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/InsuranceRecomendation/Add")]
        [HttpPost]
        public Result Add(InsuranceRecomendationTransaction insuranceRecomendationTransaction)
        {
            var result = new Result<int>();
            try
            {
                InsuranceRecomendationService insuranceRecomendationService = new InsuranceRecomendationService();
                insuranceRecomendationService.Add(insuranceRecomendationTransaction);
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