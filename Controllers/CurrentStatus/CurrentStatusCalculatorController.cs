using FinancialPlanner.Common.Model.CurrentStatus;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinancialPlanner.Common.Model;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class CurrentStatusCalculatorController : ApiController
    {
        [Route("api/CurrentStatusCalculator/Get")]
        [HttpGet]
        public Result<CurrentStatusCalculation> Get(int plannerId,int goalId = 0)
        {
            var result = new Result<CurrentStatusCalculation>();
            CurrentStatusService csService = new CurrentStatusService();
            result.Value = csService.Get(plannerId,goalId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/CurrentStatusCalculator/GetAll")]
        [HttpGet]
        public Result<CurrentStatusCalculation> GetAll(int plannerId, int goalId = 0)
        {
            var result = new Result<CurrentStatusCalculation>();
            CurrentStatusService csService = new CurrentStatusService();
            result.Value = csService.GetAllCurrentStatusAmount(plannerId);
            result.IsSuccess = true;
            return result;
        }


    }
}
