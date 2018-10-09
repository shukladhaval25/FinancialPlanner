using FinancialPlanner.BusinessLogic;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class RiskProfileReturnController : ApiController
    {
        [Route("api/RiskProfileReturn/GetAll")]
        [HttpGet]
        public Result<IList<RiskProfiledReturnMaster>> GetAll()
        {
            var result = new Result<IList<RiskProfiledReturnMaster>>();
            RiskProfiledReturnService riskProfileService = new RiskProfiledReturnService();
            result.Value = riskProfileService.GetAll();
            result.IsSuccess = true;
            return result;
        }

        [Route("api/RiskProfileReturn/GetAllDetails")]
        [HttpGet]
        public Result<IList<RiskProfiledReturn>> GetAllDetails(int id)
        {
            var result = new Result<IList<RiskProfiledReturn>>();
            RiskProfiledReturnService riskProfileService = new RiskProfiledReturnService();
            result.Value = riskProfileService.GetAllDetails(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/RiskProfileReturn/Add")]
        [HttpPost]
        public Result Add(RiskProfiledReturnMaster riskProfileReturnMaster)
        {
            var result = new Result();
            try
            {
                RiskProfiledReturnService riskProfileService = new RiskProfiledReturnService();
                riskProfileService.Add(riskProfileReturnMaster);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RiskProfileReturn/Update")]
        [HttpPost]
        public Result Update(RiskProfiledReturnMaster riskProfileReturnMaster)
        {
            var result = new Result();
            try
            {
                RiskProfiledReturnService riskProfileService = new RiskProfiledReturnService();
                riskProfileService.Update(riskProfileReturnMaster);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RiskProfileReturn/Delete")]
        [HttpPost]
        public Result Delete(RiskProfiledReturnMaster riskProfileReturnMaster)
        {
            var result = new Result();
            try
            {
                RiskProfiledReturnService riskProfileService = new RiskProfiledReturnService();
                riskProfileService.Delete(riskProfileReturnMaster);
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
