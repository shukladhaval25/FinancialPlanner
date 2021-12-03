using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Planner
{
    public class ExistingInsuranceController : ApiController
    {
        [Route("api/ExistingInsurance/Get")]
        [HttpGet]
        public Result<ExistingInsurance> GetByPlannerId(int id)
        {
            var result = new Result<ExistingInsurance>();
            ExistingInsuranceService existingInsuranceService = new ExistingInsuranceService();

            //result = existingInsuranceService.GetExistingSumAssured(id);
            ExistingInsurance insuranceResult = existingInsuranceService.GetExistingSumAssured(id);
            result.Value = insuranceResult;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ExistingInsurance/Update")]
        [HttpPost]
        public Result Update(ExistingInsurance existingInsurance)
        {
            var result = new Result();
            try
            {
                ExistingInsuranceService existingInsuranceService = new ExistingInsuranceService();
                existingInsuranceService.Updatedata(existingInsurance);
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
