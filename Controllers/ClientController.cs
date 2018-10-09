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
    public class ClientController : ApiController
    {
        [Route("api/Client/Get")]
        [HttpGet]
        public Result<IList<Client>> Get()
        {
            var result = new Result<IList<Client>>();
            ClientService clientService = new ClientService();

            var lstClient = clientService.Get();
            result.Value = (IList<Client>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Client/GetById")]
        [HttpGet]
        public Result<Client> GetById(int id)
        {
            var result = new Result<Client>();
            ClientService clientService = new ClientService();

            var client = clientService.Get(id);
            result.Value = (Client)client;
            result.IsSuccess = true;
            return result;
        }

        [HttpPost]
        [Route("api/Client/Add")]
        public Result Add(Client client)
        {
            var result = new Result();
            try
            {
                ClientService clientService = new ClientService();
                clientService.Add(client);
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
        [Route("api/Client/Update")]
        public Result Update(Client client)
        {
            var result = new Result();
            try
            {
                ClientService clientService = new ClientService();
                clientService.Update(client);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
