using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class NPSController : ApiController
    {
        [Route("api/NPS/GetAll")]
        [HttpGet]
        public Result<IList<NPS>> GetAll(int plannerId)
        {
            var result = new Result<IList<NPS>>();
            NPSService NPSService = new NPSService();
            result.Value = NPSService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/NPS/Get")]
        [HttpGet]
        public Result<NPS> Get(int id)
        {
            var result = new Result<NPS>();
            NPSService NPSService = new NPSService();
            result.Value = NPSService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/NPS/Add")]
        [HttpPost]
        public Result Add(NPS mf)
        {
            var result = new Result();
            try
            {
                NPSService NPSService = new NPSService();
                NPSService.Add(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/NPS/Update")]
        [HttpPost]
        public Result Update(NPS mf)
        {
            var result = new Result();
            try
            {
                NPSService NPSService = new NPSService();
                NPSService.Update(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/NPS/Delete")]
        [HttpPost]
        public Result Delete(NPS mf)
        {
            var result = new Result();
            try
            {
                NPSService NPSService = new NPSService();
                NPSService.Delete(mf);
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
