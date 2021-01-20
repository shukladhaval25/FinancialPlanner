using FinancialPlanner.BusinessLogic.Clients;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class ClientContactController : ApiController
    {

        [Route("api/ClientContact/Get")]
        [HttpGet]
        public Result<ClientContact> Get(int id)
        {
            var result = new Result<ClientContact>();
            ClientContactService clientSpouseService = new ClientContactService();

            var client = clientSpouseService.Get(id);
            result.Value = (ClientContact)client;
            result.IsSuccess = true;
            return result;
        }

        [HttpPost]
        [Route("api/ClientContact/Update")]
        public Result Update(ClientContact clientContract)
        {
            var result = new Result();
            try
            {
                ClientContactService clientSpouseService = new ClientContactService();
                clientSpouseService.Update(clientContract);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ClientContact/ClientWithPrimaryContact")]
        [HttpGet]
        public Result<List<ClientPrimaryContact>> GetPrimaryContact()
        {
            var result = new Result<List<ClientPrimaryContact>>();
            ClientContactService clientContactService = new ClientContactService();

            var lstClientContacts = clientContactService.GetPrimaryContact();
            result.Value = (List<ClientPrimaryContact>)lstClientContacts;
            result.IsSuccess = true;
            return result;
        }

        // PUT: api/ClientContact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ClientContact/5
        public void Delete(int id)
        {
        }
    }
}
