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
        //[CustomAuthorization]
        public Result<string> Get()
        {
            var result = new Result<string>();
            ClientService clientService = new ClientService();

            var lstClient = clientService.Get();
            result.Value = (string)lstClient;
            result.IsSuccess = true;
            return result;
        }       

        [Route("api/Client/GetById")]
        [HttpGet]
        //[CustomAuthorization]
        public Result<Client> GetById(int id)
        {
            var result = new Result<Client>();
            ClientService clientService = new ClientService();

            var client = clientService.Get(id);
            result.Value = (Client)client;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Client/GetByOtherValues")]
        [HttpGet]
        public Result<Client> GetByOtherValues(string name, string pancard)
        {
            var result = new Result<Client>();
            ClientService clientService = new ClientService();

            var client = clientService.GetByOtherValues(name,pancard);
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

        [Route("api/Client/Delete")]
        [HttpDelete]
        public Result Delete(Client client)
        {
            var result = new Result();
            try
            {
                ClientService clientService = new ClientService();
                clientService.Delete(client);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }
        #region "Client ARN Controller"

        [HttpPost]
        [Route("api/ClientARN/Add")]
        public Result Add(ClientARN client)
        {
            var result = new Result();
            try
            {
                ClientService clientService = new ClientService();
                clientService.InsertARN(client);
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
        [Route("api/ClientARN/Update")]
        public Result Update(ClientARN client)
        {
            var result = new Result();
            try
            {
                ClientService clientService = new ClientService();
                clientService.UpdateARN(client);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ClientARN/Delete")]
        [HttpDelete]
        public Result Delete(ClientARN client)
        {
            var result = new Result();
            try
            {
                ClientService clientService = new ClientService();
                clientService.DeleteARN(client);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ClientARN/GetARN")]
        [HttpGet]
        public Result<ClientARN> GetARN(int clientId)
        {
            var result = new Result<ClientARN>();
            ClientService clientService = new ClientService();

            var client = clientService.GetARN(clientId);
            result.Value = (ClientARN)client;
            result.IsSuccess = true;
            return result;
        }

        #endregion
    }
}
