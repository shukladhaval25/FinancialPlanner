using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using System.Collections.Generic;
using System.Web.Http;
using System;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class SharesController : ApiController
    {
       [Route("api/Shares/GetAll")]
       [HttpGet]
       public Result<IList<Shares>> GetAll(int plannerId)
        {
            var result = new Result<IList<Shares>>();
            ShareService shareService = new ShareService();
            result.Value = shareService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Shares/Add")]
        [HttpPost]
        public Result Add(Shares mf)
        {
            var result = new Result();
            try
            {
                ShareService SharesService = new ShareService();
                SharesService.Add(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Shares/Update")]
        [HttpPost]
        public Result Update(Shares mf)
        {
            var result = new Result();
            try
            {
                ShareService SharesService = new ShareService();
                SharesService.Update(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Shares/Delete")]
        [HttpPost]
        public Result Delete(Shares mf)
        {
            var result = new Result();
            try
            {
                ShareService SharesService = new ShareService();
                SharesService.Delete(mf);
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