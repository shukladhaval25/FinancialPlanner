using FinancialPlanner.BusinessLogic.Users;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class AuthenticationController : ApiController
    {
        // GET: api/Authentication
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Authentication/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public Result<User> Authenticate(User user)
        {
            var result = new Result<User>();
            try
            {
                AuthenticationService authenticateService = new AuthenticationService();
                var validateUser = authenticateService.ValidateAuthentication(user);
                result.Value = validateUser;
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ResultMessage = exception.Message;
                result.ExceptionInfo = exception;
            }

            return result;
        }

        [Route("api/Authentication/AuthenticateClient")]
        [HttpPost]
        public Result<User> AutheticateClient(User user)
        {
            var result = new Result<User>();
            try
            {
                AuthenticationService authenticateService = new AuthenticationService();
                var validateUser = authenticateService.ValidateClientAuthentication(user);                
                //SetSession(validateUser.Id);
                result.Value = validateUser;
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ResultMessage = exception.Message;
                result.ExceptionInfo = exception;
            }

            return result;
        }
        // PUT: api/Authentication/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Authentication/5
        public void Delete(int id)
        {
        }
    }
}
