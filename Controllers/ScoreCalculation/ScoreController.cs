using FinancialPlanner.BusinessLogic.ScoreCalculation;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.ScoreCalculation;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.ScoreCalculation
{
    public class ScoreController : ApiController
    {
        [Route("api/Score")]
        [HttpGet]
        public Result<IList<Score>> GetAll()
        {
            var result = new Result<IList<Score>>();
            ScoreService ScoreService = new ScoreService();

            var lstClient = ScoreService.Get();
            result.Value = (IList<Score>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Score")]
        [HttpPost]
        public Result Add(List<Score> Scores)
        {
            var result = new Result();
            try
            {
                ScoreService ScoreService = new ScoreService();
                ScoreService.Add(Scores);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        //[Route("api/Score")]
        //[HttpPost]
        //public Result Update(Score Score)
        //{
        //    var result = new Result();
        //    try
        //    {
        //        ScoreService ScoreService = new ScoreService();
        //        ScoreService.Update(Score);
        //        result.IsSuccess = true;
        //    }
        //    catch (Exception exception)
        //    {
        //        result.IsSuccess = false;
        //        result.ExceptionInfo = exception;
        //    }
        //    return result;
        //}

        [Route("api/Score")]
        [HttpDelete]
        public Result Delete(Score Score)
        {
            var result = new Result();
            try
            {
                ScoreService ScoreService = new ScoreService();
                ScoreService.Delete(Score);
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
