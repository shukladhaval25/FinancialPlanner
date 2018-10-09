using FinancialPlanner.Common.Model;
using FinancialPlanner.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class GoalsController : ApiController
    {
        [Route("api/Goals/GetAll")]
        [HttpGet]
        //Authorize]
        public Result<IList<Goals>> GetAll(int plannerId)
        {
            var result = new Result<IList<Goals>>();
            GoalsService GoalsService = new GoalsService();
            result.Value = GoalsService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Goals/GetByID")]
        [HttpGet]
        public Result<Goals> Get(int id, int plannerId)
        {
            var result = new Result<Goals>();
            GoalsService GoalsService = new GoalsService();
            result.Value = GoalsService.GetById(id, plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Goals/Add")]
        [HttpPost]
        public Result Add(Goals Goals)
        {
            var result = new Result();
            try
            {
                GoalsService GoalsService = new GoalsService();
                GoalsService.Add(Goals);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Goals/Update")]
        [HttpPost]
        //[Authorize]
        public Result Update(Goals Goals)
        {
            var result = new Result();
            try
            {
                GoalsService GoalsService = new GoalsService();
                GoalsService.Update(Goals);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Goals/Delete")]
        [HttpPost]
        public Result Delete(Goals Goals)
        {
            var result = new Result();
            try
            {
                GoalsService GoalsService = new GoalsService();
                GoalsService.Delete(Goals);
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
