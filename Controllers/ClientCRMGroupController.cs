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
    public class ClientCRMGroupController : ApiController
    {
        [Route("api/ClientCRMGroup/GetAll")]
        [HttpGet]
        public Result<IList<ClientCRMGroup>> GetAll(int clientId)
        {
            var result = new Result<IList<ClientCRMGroup>>();
            ClienCRMGroupService ClientCRMGroupervice = new ClienCRMGroupService();

            var lstClient = ClientCRMGroupervice.Get(clientId);
            result.Value = (IList<ClientCRMGroup>)lstClient;
            result.IsSuccess = true;
            return result;
        }


        [Route("api/ClientCRMGroup/Add")]
        [HttpPost]
        public Result Add(IList<ClientCRMGroup> ClientCRMGroup)
        {
            var result = new Result();
            try
            {
                ClienCRMGroupService ClientCRMGroupervice = new ClienCRMGroupService();
                ClientCRMGroupervice.Add(ClientCRMGroup);
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
