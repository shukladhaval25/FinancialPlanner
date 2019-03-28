using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class EPFController : ApiController
    {
        [Route("api/EPF/GetAll")]
        [HttpGet]
        public Result<IList<EPF>> GetAll(int plannerId)
        {
            var result = new Result<IList<EPF>>();
            EPFService EPFService = new EPFService();
            result.Value = EPFService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/EPF/Get")]
        [HttpGet]
        public Result<EPF> Get(int id)
        {
            var result = new Result<EPF>();
            EPFService EPFService = new EPFService();
            result.Value = EPFService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/EPF/Add")]
        [HttpPost]
        public Result Add(EPF EPF)
        {
            var result = new Result();
            try
            {
                EPFService EPFService = new EPFService();
                EPFService.Add(EPF);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/EPF/Update")]
        [HttpPost]
        public Result Update(EPF EPF)
        {
            var result = new Result();
            try
            {
                EPFService EPFService = new EPFService();
                EPFService.Update(EPF);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/EPF/Delete")]
        [HttpPost]
        public Result Delete(EPF EPF)
        {
            var result = new Result();
            try
            {
                EPFService EPFService = new EPFService();
                EPFService.Delete(EPF);
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
