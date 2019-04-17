using FinancialPlanner.BusinessLogic.CurrentStatus;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class CurrentStatusInstrumentController : ApiController
    {
        [Route("api/CurrentStatusInstrument/Get")]
        [HttpGet]
        public Result<IList<CurrentStatusInstrument>> Get(int plannerId, int goalId = 0)
        {
            var result = new Result<IList<CurrentStatusInstrument>>();
            CurrentStatusInstrumentService csService = new CurrentStatusInstrumentService();
            result.Value = csService.GetMappedInstrumentWithGoal(plannerId, goalId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/CurrentStatusInstrument/GetAll")]
        [HttpGet]
        public Result<IList<CurrentStatusInstrument>> GetAll(int plannerId)
        {
            var result = new Result<IList<CurrentStatusInstrument>>();
            try
            {                
                CurrentStatusInstrumentService csService = new CurrentStatusInstrumentService();
                result.Value = csService.GetAllCurrentStatusAmount(plannerId);
                result.IsSuccess = true;
                return result;
            }
            catch(Exception ex)
            {
                result.Value = null;
                result.IsSuccess = false;
                return result;
            }
        }
    }
}
