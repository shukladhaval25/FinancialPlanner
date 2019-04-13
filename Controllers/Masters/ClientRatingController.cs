using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.ApplicationMaster;

namespace FinancialPlanner.Controllers.Masters
{
    public class ClientRatingController : ApiController
    {
        [Route("api/ClientRating/GetAll")]
        [HttpGet]
        public Result<IList<ClientRating>> GetAll()
        {
            var result = new Result<IList<ClientRating>>();
            ClientRatingService ClientRatingService = new ClientRatingService();

            var lstClient = ClientRatingService.Get();
            result.Value = (IList<ClientRating>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ClientRating/Add")]
        [HttpPost]
        public Result Add(ClientRating ClientRating)
        {
            var result = new Result();
            try
            {
                ClientRatingService ClientRatingService = new ClientRatingService();
                ClientRatingService.Add(ClientRating);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ClientRating/Delete")]
        [HttpDelete]
        public Result Delete(ClientRating ClientRating)
        {
            var result = new Result();
            try
            {
                ClientRatingService ClientRatingService = new ClientRatingService();
                ClientRatingService.Delete(ClientRating);
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
