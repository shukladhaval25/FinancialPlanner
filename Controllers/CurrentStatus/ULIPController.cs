using FinancialPlanner.BusinessLogic.CurrentStatus;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class ULIPController : ApiController
    {
        [Route("api/ULIP/GetAll")]
        [HttpGet]
        public Result<IList<ULIP>> GetAll(int plannerId)
        {
            var result = new Result<IList<ULIP>>();
            ULIPService ULIPService = new ULIPService();
            result.Value = ULIPService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ULIP/Get")]
        [HttpGet]
        public Result<ULIP> Get(int id)
        {
            var result = new Result<ULIP>();
            ULIPService ULIPService = new ULIPService();
            result.Value = ULIPService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ULIP/Add")]
        [HttpPost]
        public Result Add(ULIP ulip)
        {
            var result = new Result();
            try
            {
                ULIPService ULIPService = new ULIPService();
                ULIPService.Add(ulip);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ULIP/Update")]
        [HttpPost]
        public Result Update(ULIP ulip)
        {
            var result = new Result();
            try
            {
                ULIPService ULIPService = new ULIPService();
                ULIPService.Update(ulip);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ULIP/Delete")]
        [HttpPost]
        public Result Delete(ULIP ulip)
        {
            var result = new Result();
            try
            {
                ULIPService ULIPService = new ULIPService();
                ULIPService.Delete(ulip);
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
