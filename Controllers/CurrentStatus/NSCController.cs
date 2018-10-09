using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.CurrentStatus;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class NSCController : ApiController
    {
        [Route("api/NSC/GetAll")]
        [HttpGet]
        public Result<IList<NSC>> GetAll(int plannerId)
        {
            var result = new Result<IList<NSC>>();
            NSCService NSCService = new NSCService();
            result.Value = NSCService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/NSC/Get")]
        [HttpGet]
        public Result<NSC> Get(int id)
        {
            var result = new Result<NSC>();
            NSCService NSCService = new NSCService();
            result.Value = NSCService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/NSC/Add")]
        [HttpPost]
        public Result Add(NSC NSC)
        {
            var result = new Result();
            try
            {
                NSCService NSCService = new NSCService();
                NSCService.Add(NSC);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/NSC/Update")]
        [HttpPost]
        public Result Update(NSC NSC)
        {
            var result = new Result();
            try
            {
                NSCService NSCService = new NSCService();
                NSCService.Update(NSC);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/NSC/Delete")]
        [HttpPost]
        public Result Delete(NSC NSC)
        {
            var result = new Result();
            try
            {
                NSCService NSCService = new NSCService();
                NSCService.Delete(NSC);
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
