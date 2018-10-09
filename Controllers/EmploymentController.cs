using FinancialPlanner.BusinessLogic.Clients;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class EmploymentController : ApiController
    {

        [Route("api/Employment/Get")]
        [HttpGet]
        public Result<Employment> Get(int Id)
        {
            var result = new Result<Employment>();
            try
            {                
                EmploymentService employmentService = new EmploymentService();

                var client = employmentService.Get(Id);
                result.Value = (Employment)client;
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [HttpPost]
        [Route("api/Employment/Update")]
        public Result Update(Employment employment)
        {
            var result = new Result();
            try
            {
                EmploymentService employmentService = new EmploymentService();
                employmentService.Update(employment);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        // DELETE: api/Employment/5
        public void Delete(int id)
        {
        }
    }
}
