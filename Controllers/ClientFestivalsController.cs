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
    public class ClientFestivalsController : ApiController
    {
        [Route("api/ClientFestivals/GetAll")]
        [HttpGet]
        public Result<IList<ClientFestivals>> GetAll(int clientId)
        {
            var result = new Result<IList<ClientFestivals>>();
            ClientClientFestivalservice clientFestivalService = new ClientClientFestivalservice();

            var lstClient = clientFestivalService.Get(clientId);
            result.Value = (IList<ClientFestivals>)lstClient;
            result.IsSuccess = true;
            return result;
        }


        [Route("api/ClientFestivals/Add")]
        [HttpPost]
        public Result Add(IList<ClientFestivals> clientFestivals)
        {
            var result = new Result();
            try
            {
                ClientClientFestivalservice clientFestivalService = new ClientClientFestivalservice();
                clientFestivalService.Add(clientFestivals);
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
