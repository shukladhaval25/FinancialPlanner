using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Masters
{
    public class AssumptionMasterController : ApiController
    {
        [Route("api/AssumptionMaster/GetAll")]
        [HttpGet]
        public Result<AssumptionMaster> GetAll()
        {
            var result = new Result<AssumptionMaster>();
            AssumptionMasterService assumptionService = new AssumptionMasterService();
            result.Value = assumptionService.GetAll();
            result.IsSuccess = true;
            return result;
        }

        [Route("api/AssumptionMaster/Update")]
        [HttpPost]
        public Result Update(AssumptionMaster assumptionMaster)
        {
            var result = new Result();
            try
            {
                AssumptionMasterService assumptionService = new AssumptionMasterService();
                assumptionService.Update(assumptionMaster);
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
