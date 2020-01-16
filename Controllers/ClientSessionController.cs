using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.Clients;

namespace FinancialPlanner.Controllers
{
    public class ClientSessionController : ApiController
    {
        [Route("api/Sessions/GetAll")]
        [HttpGet]
        public Result<IList<Sessions>> GetAll(int clientId)
        {
            var result = new Result<IList<Sessions>>();
            SessionsService SessionsService = new SessionsService();
            result.Value = SessionsService.Get(clientId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Sessions/Add")]
        [HttpPost]
        public Result Add(IList<Sessions> Sessions)
        {
            var result = new Result();
            try
            {
                SessionsService SessionsService = new SessionsService();
                SessionsService.Add(Sessions);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Sessions/Delete")]
        [HttpDelete]
        public Result Delete(Sessions Sessions)
        {
            var result = new Result();
            try
            {
                SessionsService SessionsService = new SessionsService();
                SessionsService.Delete(Sessions);
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
