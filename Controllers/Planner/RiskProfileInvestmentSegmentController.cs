using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.RiskProfile;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class RiskProfileInvestmentSegmentController : ApiController
    {
        [Route("api/RiskProfileInvestmentSegment/GetAll")]
        [HttpGet]
        public Result<IList<InvestmentSegment>> GetAll(int riskProfileId)
        {
            var result = new Result<IList<InvestmentSegment>>();
            InvestmentSegmentService invSegmentService = new InvestmentSegmentService();
            result.Value = invSegmentService.GetAll(riskProfileId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/RiskProfileInvestmentSegment/Add")]
        [HttpPost]
        public Result Add(InvestmentSegment investmentSegment)
        {
            var result = new Result();
            try
            {
                InvestmentSegmentService invSegmentService = new InvestmentSegmentService();
                invSegmentService.Add(investmentSegment);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RiskProfileInvestmentSegment/Update")]
        [HttpPost]
        public Result Update(InvestmentSegment investmentSegment)
        {
            var result = new Result();
            try
            {
                InvestmentSegmentService invSegmentService = new InvestmentSegmentService();
                invSegmentService.Update(investmentSegment);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RiskProfileInvestmentSegment/Delete")]
        [HttpPost]
        public Result Delete(InvestmentSegment investmentSegment)
        {
            var result = new Result();
            try
            {
                InvestmentSegmentService invSegmentService = new InvestmentSegmentService();
                invSegmentService.Delete(investmentSegment);
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
