using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.CurrentStatus;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class SCSSController : ApiController
    {
        [Route("api/SCSS/GetAll")]
        [HttpGet]
        public Result<IList<SCSS>> GetAll(int plannerId)
        {
            var result = new Result<IList<SCSS>>();
            SCSSService SCSSService = new SCSSService();
            result.Value = SCSSService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SCSS/Get")]
        [HttpGet]
        public Result<SCSS> Get(int id)
        {
            var result = new Result<SCSS>();
            SCSSService SCSSService = new SCSSService();
            result.Value = SCSSService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SCSS/Add")]
        [HttpPost]
        public Result Add(SCSS SCSS)
        {
            var result = new Result();
            try
            {
                SCSSService SCSSService = new SCSSService();
                SCSSService.Add(SCSS);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SCSS/Update")]
        [HttpPost]
        public Result Update(SCSS SCSS)
        {
            var result = new Result();
            try
            {
                SCSSService SCSSService = new SCSSService();
                SCSSService.Update(SCSS);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SCSS/Delete")]
        [HttpPost]
        public Result Delete(SCSS SCSS)
        {
            var result = new Result();
            try
            {
                SCSSService SCSSService = new SCSSService();
                SCSSService.Delete(SCSS);
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
