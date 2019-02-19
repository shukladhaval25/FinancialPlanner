using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.PlannerProcess;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.ProcessesAction;

namespace FinancialPlanner.Controllers.Processes
{
    public class ProcessActionController : ApiController
    {
        [Route("api/ProcessAction/GetAll")]
        [HttpGet]
        public Result<IList<ProcessAction>> GetAll()
        {
            var result = new Result<IList<ProcessAction>>();
            ProcessActionService ProcessActionService = new ProcessActionService();
            result.Value = ProcessActionService.GetAll();
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ProcessAction/GetByID")]
        [HttpGet]
        public Result<ProcessAction> Get(int id)
        {
            var result = new Result<ProcessAction>();
            ProcessActionService ProcessActionService = new ProcessActionService();
            result.Value = ProcessActionService.GetById(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ProcessAction/Add")]
        [HttpPost]
        public Result Add(ProcessAction ProcessAction)
        {
            var result = new Result();
            try
            {
                ProcessActionService ProcessActionService = new ProcessActionService();
                ProcessActionService.Add(ProcessAction);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ProcessAction/Update")]
        [HttpPost]
        public Result Update(ProcessAction ProcessAction)
        {
            var result = new Result();
            try
            {
                ProcessActionService ProcessActionService = new ProcessActionService();
                ProcessActionService.Update(ProcessAction);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ProcessAction/Delete")]
        [HttpDelete]
        public Result Delete(ProcessAction ProcessAction)
        {
            var result = new Result();
            try
            {
                ProcessActionService ProcessActionService = new ProcessActionService();
                ProcessActionService.Delete(ProcessAction);
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
