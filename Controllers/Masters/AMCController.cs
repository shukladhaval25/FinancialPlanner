using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.TaskManagement.MFTransactions;
using FinancialPlanner.BusinessLogic.ApplicationMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Masters
{
    public class AMCController : ApiController
    {
        [Route("api/AMC/GetAll")]
        [HttpGet]
        public Result<IList<AMC>> GetAll()
        {
            var result = new Result<IList<AMC>>();
            AMCService AMCService = new AMCService();

            var lstClient = AMCService.Get();
            result.Value = (IList<AMC>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/AMC/Add")]
        [HttpPost]
        public Result Add(AMC AMC)
        {
            var result = new Result();
            try
            {
                AMCService AMCService = new AMCService();
                AMCService.Add(AMC);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/AMC/Update")]
        [HttpPost]
        public Result Update(AMC AMC)
        {
            var result = new Result();
            try
            {
                AMCService AMCService = new AMCService();
                AMCService.Update(AMC);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/AMC/Delete")]
        [HttpDelete]
        public Result Delete(AMC AMC)
        {
            var result = new Result();
            try
            {
                AMCService AMCService = new AMCService();
                AMCService.Delete(AMC);
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
