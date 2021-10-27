using FinancialPlanner.BusinessLogic.ApplicationMaster;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Masters
{
    public class InsuranceCompanyController : ApiController
    {
        [Route("api/InsuranceCompany/GetAll")]
        [HttpGet]
        public Result<IList<InsuranceCompany>> GetAll()
        {
            var result = new Result<IList<InsuranceCompany>>();
            InsuranceCompanyService bankService = new InsuranceCompanyService();

            var lstClient = bankService.Get();
            result.Value = (IList<InsuranceCompany>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/InsuranceCompany/Add")]
        [HttpPost]
        public Result Add(InsuranceCompany insuranceCompany)
        {
            var result = new Result();
            try
            {
                InsuranceCompanyService bankService = new InsuranceCompanyService();
                bankService.Add(insuranceCompany);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InsuranceCompany/Update")]
        [HttpPost]
        public Result Update(InsuranceCompany insuranceCompany)
        {
            var result = new Result();
            try
            {
                InsuranceCompanyService bankService = new InsuranceCompanyService();
                bankService.Update(insuranceCompany);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InsuranceCompany/Delete")]
        [HttpDelete]
        public Result Delete(InsuranceCompany insuranceCompany)
        {
            var result = new Result();
            try
            {
                InsuranceCompanyService bankService = new InsuranceCompanyService();
                bankService.Delete(insuranceCompany);
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
