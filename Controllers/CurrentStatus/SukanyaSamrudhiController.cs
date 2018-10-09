using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.CurrentStatus;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class SukanyaSamrudhiController : ApiController
    {
        [Route("api/SukanyaSamrudhi/GetAll")]
        [HttpGet]
        public Result<IList<SukanyaSamrudhi>> GetAll(int plannerId)
        {
            var result = new Result<IList<SukanyaSamrudhi>>();
            SukanyaSamrudhiService SukanyaSamrudhiService = new SukanyaSamrudhiService();
            result.Value = SukanyaSamrudhiService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SukanyaSamrudhi/Get")]
        [HttpGet]
        public Result<SukanyaSamrudhi> Get(int id)
        {
            var result = new Result<SukanyaSamrudhi>();
            SukanyaSamrudhiService SukanyaSamrudhiService = new SukanyaSamrudhiService();
            result.Value = SukanyaSamrudhiService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SukanyaSamrudhi/Add")]
        [HttpPost]
        public Result Add(SukanyaSamrudhi SukanyaSamrudhi)
        {
            var result = new Result();
            try
            {
                SukanyaSamrudhiService SukanyaSamrudhiService = new SukanyaSamrudhiService();
                SukanyaSamrudhiService.Add(SukanyaSamrudhi);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SukanyaSamrudhi/Update")]
        [HttpPost]
        public Result Update(SukanyaSamrudhi SukanyaSamrudhi)
        {
            var result = new Result();
            try
            {
                SukanyaSamrudhiService SukanyaSamrudhiService = new SukanyaSamrudhiService();
                SukanyaSamrudhiService.Update(SukanyaSamrudhi);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SukanyaSamrudhi/Delete")]
        [HttpPost]
        public Result Delete(SukanyaSamrudhi SukanyaSamrudhi)
        {
            var result = new Result();
            try
            {
                SukanyaSamrudhiService SukanyaSamrudhiService = new SukanyaSamrudhiService();
                SukanyaSamrudhiService.Delete(SukanyaSamrudhi);
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
