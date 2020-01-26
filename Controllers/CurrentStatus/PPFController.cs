using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.CurrentStatus;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class PPFController : ApiController
    {
        [Route("api/PPF/GetAll")]
        [HttpGet]
        public Result<IList<PPF>> GetAll(int plannerId)
        {
            var result = new Result<IList<PPF>>();
            PPFService PPFService = new PPFService();
            result.Value = PPFService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/PPF/GetMaturity")]
        [HttpGet]
        public Result<IList<PPFMaturity>> GetMaturity(DateTime from,DateTime to)
        {
            var result = new Result<IList<PPFMaturity>>();
            PPFService PPFService = new PPFService();
            result.Value = PPFService.GetPPFMaturity(from, to);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/PPF/Get")]
        [HttpGet]
        public Result<PPF> Get(int id)
        {
            var result = new Result<PPF>();
            PPFService PPFService = new PPFService();
            result.Value = PPFService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/PPF/Add")]
        [HttpPost]
        public Result Add(PPF PPF)
        {
            var result = new Result();
            try
            {
                PPFService PPFService = new PPFService();
                PPFService.Add(PPF);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/PPF/Update")]
        [HttpPost]
        public Result Update(PPF PPF)
        {
            var result = new Result();
            try
            {
                PPFService PPFService = new PPFService();
                PPFService.Update(PPF);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/PPF/Delete")]
        [HttpPost]
        public Result Delete(PPF PPF)
        {
            var result = new Result();
            try
            {
                PPFService PPFService = new PPFService();
                PPFService.Delete(PPF);
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
