using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.ApplicationMaster;
using FinancialPlanner.Common.Model.TaskManagement.MFTransactions;

namespace FinancialPlanner.Controllers.Masters
{
    public class ARNController : ApiController
    {
        [Route("api/ARN/GetAll")]
        [HttpGet]
        public Result<IList<ARN>> GetAll()
        {
            var result = new Result<IList<ARN>>();
            ARNService ARNService = new ARNService();

            var lstClient = ARNService.Get();
            result.Value = (IList<ARN>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ARN/Add")]
        [HttpPost]
        public Result Add(ARN ARN)
        {
            var result = new Result();
            try
            {
                ARNService ARNService = new ARNService();
                ARNService.Add(ARN);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ARN/Update")]
        [HttpPost]
        public Result Update(ARN ARN)
        {
            var result = new Result();
            try
            {
                ARNService ARNService = new ARNService();
                ARNService.Update(ARN);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ARN/Delete")]
        [HttpDelete]
        public Result Delete(ARN ARN)
        {
            var result = new Result();
            try
            {
                ARNService ARNService = new ARNService();
                ARNService.Delete(ARN);
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
