using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.Common.Model.CurrentStatus;
using FinancialPlanner.BusinessLogic.CurrentStatus;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class OthersController : ApiController
    {
        [Route("api/Others/GetAll")]
        [HttpGet]
        public Result<IList<Others>> GetAll(int plannerId)
        {
            var result = new Result<IList<Others>>();
            OthersService othersSrvice = new OthersService();
            result.Value = othersSrvice.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Others/Get")]
        [HttpGet]
        public Result<Others> Get(int id)
        {
            var result = new Result<Others>();
            OthersService othersSrvice = new OthersService();
            result.Value = othersSrvice.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Others/Add")]
        [HttpPost]
        public Result Add(Others Others)
        {
            var result = new Result();
            try
            {
                OthersService othersSrvice = new OthersService();
                othersSrvice.Add(Others);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Others/Update")]
        [HttpPost]
        public Result Update(Others Others)
        {
            var result = new Result();
            try
            {
                OthersService othersSrvice = new OthersService();
                othersSrvice.Update(Others);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Others/Delete")]
        [HttpPost]
        public Result Delete(Others Others)
        {
            var result = new Result();
            try
            {
                OthersService othersSrvice = new OthersService();
                othersSrvice.Delete(Others);
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
