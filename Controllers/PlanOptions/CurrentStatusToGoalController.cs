using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.PlanOptions;
using FinancialPlanner.BusinessLogic.PlanOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.PlanOptions
{
    public class CurrentStatusToGoalController : ApiController
    {
        [Route("api/CurrentStatusToGoal/Get")]
        [HttpGet]
        public Result<IList<CurrentStatusToGoal>> Get(int optionId)
        {
            Result<IList<CurrentStatusToGoal>> result = new Result<IList<CurrentStatusToGoal>>();
            CurrentStatusToGoalService currentStatusToGoalService = new CurrentStatusToGoalService();
            result.Value = currentStatusToGoalService.Get(optionId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/CurrentStatusToGoal/Add")]
        [HttpPost]
        public Result Add(CurrentStatusToGoal CurrentStatusToGoal)
        {

            var result = new Result();
            try
            {
                CurrentStatusToGoalService CurrentStatusToGoalService = new CurrentStatusToGoalService();
                CurrentStatusToGoalService.Add(CurrentStatusToGoal);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/CurrentStatusToGoal/Update")]
        [HttpPost]
        public Result Update(CurrentStatusToGoal CurrentStatusToGoal)
        {
            var result = new Result();
            try
            {
                CurrentStatusToGoalService CurrentStatusToGoalService = new CurrentStatusToGoalService();
                CurrentStatusToGoalService.Update(CurrentStatusToGoal);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/CurrentStatusToGoal/Delete")]
        [HttpPost]
        public Result Delete(CurrentStatusToGoal CurrentStatusToGoal)
        {
            var result = new Result();
            try
            {
                CurrentStatusToGoalService CurrentStatusToGoalService = new CurrentStatusToGoalService();
                CurrentStatusToGoalService.Delete(CurrentStatusToGoal);
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
