using FinancialPlanner.BusinessLogic.PlanOption;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Planner
{
    public class InsuranceRecomendationController : ApiController
    {

        [Route("api/InsuranceRecomendation/GetAll")]
        [HttpGet]
        //Authorize]
        public Result<IList<InsuranceRecomendationTransaction>> GetAll(int planId)
        {
            var result = new Result<IList<InsuranceRecomendationTransaction>>();
            InsuranceRecomendationService insuranceRecomendationService = new InsuranceRecomendationService();
            result.Value = insuranceRecomendationService.GetInsuranceRecomendationByProjectId(planId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/InsuranceRecomendation/Add")]
        [HttpPost]
        public Result Add(InsuranceRecomendationTransaction insuranceRecomendationTransaction)
        {
            var result = new Result<int>();
            try
            {
                InsuranceRecomendationService insuranceRecomendationService = new InsuranceRecomendationService();
                insuranceRecomendationService.Add(insuranceRecomendationTransaction);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InsuranceRecomendation/Update")]
        [HttpPost]
        public Result Update(InsuranceRecomendationTransaction transaction)
        {
            var result = new Result();
            try
            {
                InsuranceRecomendationService insuranceRecomendationService = new InsuranceRecomendationService();
                insuranceRecomendationService.Update(transaction);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InsuranceRecomendation/Delete")]
        [HttpDelete]
        public Result Delete(int Id)
        {
            var result = new Result();
            try
            {
                InsuranceRecomendationService insuranceRecomendationService = new InsuranceRecomendationService();
                insuranceRecomendationService.DeleteInsuranceRecomendation(Id);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/InsuranceRecomendationDetail/Delete")]
        [HttpDelete]
        public Result DeleteMOM(string companyName, int Id)
        {
            var result = new Result();
            try
            {
                InsuranceRecomendationService insuranceRecomendationService = new InsuranceRecomendationService();
                insuranceRecomendationService.DeleteInsuranceRecDetail(companyName,Id);
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