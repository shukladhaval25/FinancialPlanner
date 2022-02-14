using FinancialPlanner.BusinessLogic.Process;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Processes
{
    public class ClientProcessController : ApiController
    {
        [Route("api/ClientProcess/GetAll")]
        [HttpGet]
        public Result<IList<CurrentClientProcess>> GetAll()
        {
            var result = new Result<IList<CurrentClientProcess>>();
            ClientProcessService processService = new ClientProcessService();
            result.Value = processService.GetAll();
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ClientProcess/GetClientProcess")]
        [HttpGet]
        public Result<IList<CurrentClientProcess>> GetClientProcess(int clientId,int? plannerId)
        {
            var result = new Result<IList<CurrentClientProcess>>();
            ClientProcessService processService = new ClientProcessService();
            result.Value = processService.GetClientProcess(clientId,plannerId);
            result.IsSuccess = true;
            return result;
        }
    }
}
