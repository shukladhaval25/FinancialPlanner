using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.PlannerProcess;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.ProcessesAction;
using FinancialPlanner.Common.Planning;
using FinancialPlanner.BusinessLogic.Process;

namespace FinancialPlanner.Controllers.Processes
{
    public class ProcessActionController : ApiController
    {
        [Route("api/ProcessAction/GetPrimarySteps")]
        [HttpGet]
        public Result<IList<PrimaryStep>> GetPrimarySteps()
        {
            var result = new Result<IList<PrimaryStep>>();
            ProcessService processService = new ProcessService();
            result.Value = processService.GetPrimarySteps();
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ProcessAction/GetLinkSubSteps")]
        [HttpGet]
        public Result<IList<LinkSubStep>> GetLinkSubSteps(int primaryStepId)
        {
            var result = new Result<IList<LinkSubStep>>();
            ProcessService processService = new ProcessService();
            result.Value = processService.GetLinkSubSteps(primaryStepId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ProcessAction/GetLinkSubStepsByRefTaskId")]
        [HttpGet]
        public Result<IList<LinkSubStep>> GetLinkSubStepsByRefTaskId(string refTaskId)
        {
            var result = new Result<IList<LinkSubStep>>();
            ProcessService processService = new ProcessService();
            result.Value = processService.GetLinkSubStepsByRefTaskId(refTaskId);
            result.IsSuccess = true;
            return result;
        }


        //[Route("api/ProcessAction/GetByID")]
        //[HttpGet]
        //public Result<ProcessAction> Get(int id)
        //{
        //    var result = new Result<ProcessAction>();
        //    ProcessActionService ProcessActionService = new ProcessActionService();
        //    result.Value = ProcessActionService.GetById(id);
        //    result.IsSuccess = true;
        //    return result;
        //}

        [Route("api/ProcessAction/UpdatePrimaryStep")]
        [HttpPost]
        public Result<PrimaryStep> Update(PrimaryStep primaryStep)
        {
            var result = new Result<PrimaryStep>();
            try
            {
                ProcessService processService = new ProcessService();
                result.Value =  processService.UpdatePrimaryStep(primaryStep);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ProcessAction/UpdateLinkSubStep")]
        [HttpPost]
        public Result<LinkSubStep> UpdateLinkSubStep(LinkSubStep linkSubStep)
        {
            var result = new Result<LinkSubStep>();
            try
            {
                ProcessService processService = new ProcessService();
                result.Value =  processService.UpdateLinkSubSteps(linkSubStep);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ProcessAction/DeletePrimaryStep")]
        [HttpDelete]
        public Result DeletePrimaryStep(int primaryStepId)
        {
            var result = new Result();
            try
            {
                ProcessService processService = new ProcessService();
                processService.DeletePrimaryStep(primaryStepId);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ProcessAction/DeleteLinkSubStep")]
        [HttpDelete]
        public Result DeleteLinkSubStep(int linkSubStepId)
        {
            var result = new Result();
            try
            {
                ProcessService processService = new ProcessService();
                processService.DeleteLinkSubStep(linkSubStepId);
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
