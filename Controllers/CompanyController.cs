using FinancialPlanner.BusinessLogic.Compnay;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class CompanyController : ApiController
    {
        [Route("api/Company/Get")]
        [HttpGet]
        public Result<Company> Get()
        {
            var result = new Result<Company>();
            CompanyService compService = new CompanyService();

            var comp = compService.Get();
            result.Value = comp;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Company/Add")]
        [HttpPost]
        public Result Add(Company company)
        {
            var result = new Result();
            try
            {
                CompanyService compService = new CompanyService();
                compService.Add(company);
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
