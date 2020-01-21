using FinancialPlanner.BusinessLogic.LifeInsurance;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class LifeInsuranceController : ApiController
    {
        [Route("api/LifeInsurance/GetAll")]
        [HttpGet]
        public Result<IList<LifeInsurance>> GetAll(int plannerId)
        {
            var result = new Result<IList<LifeInsurance>>();
            LifeInsuranceService lifeInsuranceService = new LifeInsuranceService();
            result.Value = lifeInsuranceService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }
        [Route("api/LifeInsurance/GetById")]
        [HttpGet]
        public Result<LifeInsurance> GetById(int id, int plannerId)
        {
            var result = new Result<LifeInsurance>();
            LifeInsuranceService lifeInsuranceService = new LifeInsuranceService();
            result.Value = lifeInsuranceService.GetById(id, plannerId);
            result.IsSuccess = true;
            return result;
        }

        

        [Route("api/LifeInsurance/Add")]
        [HttpPost]
        public Result Add(LifeInsurance lifeInsurance)
        {
            var result = new Result();
            try
            {
                LifeInsuranceService lifeInsuranceService = new LifeInsuranceService();
                lifeInsuranceService.Add(lifeInsurance);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/LifeInsurance/Update")]
        [HttpPost]
        public Result Update(LifeInsurance lifeInsurance)
        {
            var result = new Result();
            try
            {
                LifeInsuranceService lifeInsuranceService = new LifeInsuranceService();
                lifeInsuranceService.Update(lifeInsurance);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/LifeInsurance/Delet")]
        [HttpPost]
        public Result Delete(LifeInsurance lifeInsurance)
        {
            var result = new Result();
            try
            {
                LifeInsuranceService lifeInsuranceService = new LifeInsuranceService();
                lifeInsuranceService.Delete(lifeInsurance);
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
