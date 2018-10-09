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
    public class ClientSpouseController : ApiController
    {
        [Route("api/ClientSpouse/GetById")]
        [HttpGet]
        public Result<ClientSpouse> GetById(int id)
        {
            var result = new Result<ClientSpouse>();
            ClientSpouseService clientSpouseService = new ClientSpouseService();

            var client = clientSpouseService.Get(id);
            result.Value = (ClientSpouse)client;
            result.IsSuccess = true;
            return result;
        }

        // POST: api/ClientSpouse
        public void Post([FromBody]string value)
        {
        }

        [HttpPost]
        [Route("api/ClientSpouse/Update")]
        public Result Update(ClientSpouse clientSpouse)
        {
            var result = new Result();
            try
            {
                ClientSpouseService clientSpouseService = new ClientSpouseService();
                clientSpouseService.Update(clientSpouse);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        // DELETE: api/ClientSpouse/5
        public void Delete(int id)
        {
        }
    }
}
