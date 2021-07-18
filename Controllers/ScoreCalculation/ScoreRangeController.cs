using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.ScoreCalculation;
using FinancialPlanner.BusinessLogic.ScoreRangeCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.ScoreRangeCalculation
{
    public class ScoreRangeRangeController : ApiController
    {
        [Route("api/ScoreRange/GetAll")]
        [HttpGet]
        public Result<IList<ScoreRange>> GetAll(int riskProfileId)
        {
            var result = new Result<IList<ScoreRange>>();
            ScoreRangeService ScoreRangeService = new ScoreRangeService();

            var lstClient = ScoreRangeService.Get(riskProfileId);
            result.Value = (IList<ScoreRange>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ScoreRange")]
        [HttpPost]
        public Result Add(List<ScoreRange> ScoreRanges)
        {
            var result = new Result();
            try
            {
                ScoreRangeService ScoreRangeService = new ScoreRangeService();
                ScoreRangeService.Add(ScoreRanges);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        //[Route("api/ScoreRange")]
        //[HttpPost]
        //public Result Update(ScoreRange ScoreRange)
        //{
        //    var result = new Result();
        //    try
        //    {
        //        ScoreRangeService ScoreRangeService = new ScoreRangeService();
        //        ScoreRangeService.Update(ScoreRange);
        //        result.IsSuccess = true;
        //    }
        //    catch (Exception exception)
        //    {
        //        result.IsSuccess = false;
        //        result.ExceptionInfo = exception;
        //    }
        //    return result;
        //}

        [Route("api/ScoreRange")]
        [HttpDelete]
        public Result Delete(ScoreRange ScoreRange)
        {
            var result = new Result();
            try
            {
                ScoreRangeService ScoreRangeService = new ScoreRangeService();
                ScoreRangeService.Delete(ScoreRange);
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
