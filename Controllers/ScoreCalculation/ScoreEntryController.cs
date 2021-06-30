using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.ScoreCalculation;
using FinancialPlanner.BusinessLogic.ScoreCalculation;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.ScoreEntryCalculation
{
    public class ScoreEntryEntryController : ApiController
    {
        [Route("api/ScoreEntry")]
        [HttpGet]
        public Result<IList<ScoreEntry>> GetAll()
        {
            var result = new Result<IList<ScoreEntry>>();
            ScoreEntryService ScoreEntryService = new ScoreEntryService();

            var lstClient = ScoreEntryService.Get();
            result.Value = (IList<ScoreEntry>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ScoreEntry/{0}")]
        [HttpGet]
        public Result<IList<ScoreEntry>> GetAll(DateTime entryDate)
        {
            var result = new Result<IList<ScoreEntry>>();
            ScoreEntryService ScoreEntryService = new ScoreEntryService();

            var lstClient = ScoreEntryService.Get(entryDate);
            result.Value = (IList<ScoreEntry>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ScoreEntry")]
        [HttpPost]
        public Result Add(List<ScoreEntry> ScoreEntrys)
        {
            var result = new Result();
            try
            {
                ScoreEntryService ScoreEntryService = new ScoreEntryService();
                ScoreEntryService.Add(ScoreEntrys);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ScoreEntry")]
        [HttpPut]
        public Result Update(List<ScoreEntry> ScoreEntrys)
        {
            var result = new Result();
            try
            {
                ScoreEntryService ScoreEntryService = new ScoreEntryService();
                ScoreEntryService.Update(ScoreEntrys);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/ScoreEntry")]
        [HttpDelete]
        public Result Delete(ScoreEntry ScoreEntry)
        {
            var result = new Result();
            try
            {
                ScoreEntryService ScoreEntryService = new ScoreEntryService();
                ScoreEntryService.Delete(ScoreEntry);
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
