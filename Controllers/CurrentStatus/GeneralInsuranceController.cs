using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.LifeInsurance;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class GeneralInsuranceController : ApiController
    {
        [Route("api/GeneralInsurance/GetAll")]
        [HttpGet]
        public Result<IList<GeneralInsurance>> GetAll(int plannerId)
        {
            var result = new Result<IList<GeneralInsurance>>();
            GeneralInsuranceService GeneralInsuranceService = new GeneralInsuranceService();
            result.Value = GeneralInsuranceService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }
        [Route("api/GeneralInsurance/GetById")]
        [HttpGet]
        public Result<GeneralInsurance> GetById(int id, int plannerId)
        {
            var result = new Result<GeneralInsurance>();
            GeneralInsuranceService GeneralInsuranceService = new GeneralInsuranceService();
            result.Value = GeneralInsuranceService.GetById(id, plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/GeneralInsurance/Add")]
        [HttpPost]
        public Result Add(GeneralInsurance GeneralInsurance)
        {
            var result = new Result();
            try
            {
                GeneralInsuranceService GeneralInsuranceService = new GeneralInsuranceService();
                GeneralInsuranceService.Add(GeneralInsurance);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/GeneralInsurance/Update")]
        [HttpPost]
        public Result Update(GeneralInsurance GeneralInsurance)
        {
            var result = new Result();
            try
            {
                GeneralInsuranceService GeneralInsuranceService = new GeneralInsuranceService();
                GeneralInsuranceService.Update(GeneralInsurance);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/GeneralInsurance/Delete")]
        [HttpPost]
        public Result Delete(GeneralInsurance GeneralInsurance)
        {
            var result = new Result();
            try
            {
                GeneralInsuranceService GeneralInsuranceService = new GeneralInsuranceService();
                GeneralInsuranceService.Delete(GeneralInsurance);
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
