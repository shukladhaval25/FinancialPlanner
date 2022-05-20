using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class BondsController : ApiController
    {
       [Route("api/Bonds/GetAll")]
       [HttpGet]
        public Result<IList<Bonds>> GetAll(int plannerId)
        {
            var result = new Result<IList<Bonds>>();
            BondsService BondsService = new BondsService();
            result.Value = BondsService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Bonds/Get")]
        [HttpGet]
        public Result<Bonds> Get(int id)
        {
            var result = new Result<Bonds>();
            BondsService BondsService = new BondsService();
            result.Value = BondsService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Bonds/GetMaturity")]
        [HttpGet]
        public Result<IList<Bonds>> GetMaturity(DateTime from, DateTime to)
        {
            var result = new Result<IList<Bonds>>();
            BondsService BondsService = new BondsService();
            result.Value = BondsService.GeMaturity(from, to);
            result.IsSuccess = true;
            return result;
        }



        [Route("api/Bonds/Add")]
        [HttpPost]
        public Result Add(Bonds bonds)
        {
            var result = new Result();
            try
            {
                BondsService BondsService = new BondsService();
                BondsService.Add(bonds);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Bonds/Update")]
        [HttpPost]
        public Result Update(Bonds bonds)
        {
            var result = new Result();
            try
            {
                BondsService BondsService = new BondsService();
                BondsService.Update(bonds);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Bonds/Delete")]
        [HttpPost]
        public Result Delete(Bonds bonds)
        {
            var result = new Result();
            try
            {
                BondsService BondsService = new BondsService();
                BondsService.Delete(bonds);
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
