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
    public class PersonalAccidentInsuranceController : ApiController
    {
        [Route("api/PersonalAccidentInsurance/GetAll")]
        [HttpGet]
        public Result<IList<PersonalAccidentInsurance>> GetAll(int planId)
        {
            var result = new Result<IList<PersonalAccidentInsurance>>();
            PersonalAccidentInsuranceService personalAccidentInsuranceService = new PersonalAccidentInsuranceService();

            var lstPersonalAccidentInsurances = personalAccidentInsuranceService.GetAll(planId);
            result.Value = (IList<PersonalAccidentInsurance>)lstPersonalAccidentInsurances;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/PersonalAccidentInsurance/Add")]
        [HttpPost]
        public Result Add(PersonalAccidentInsurance PersonalAccidentInsurance)
        {
            var result = new Result();
            try
            {
                PersonalAccidentInsuranceService PersonalAccidentInsuranceService = new PersonalAccidentInsuranceService();
                PersonalAccidentInsuranceService.Add(PersonalAccidentInsurance);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/PersonalAccidentInsurance/Delete")]
        [HttpDelete]
        public Result Delete(PersonalAccidentInsurance PersonalAccidentInsurance)
        {
            var result = new Result();
            try
            {
                PersonalAccidentInsuranceService PersonalAccidentInsuranceService = new PersonalAccidentInsuranceService();
                PersonalAccidentInsuranceService.Delete(PersonalAccidentInsurance);
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
