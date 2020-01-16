using FinancialPlanner.BusinessLogic.PlanOption;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class QuarterlyReviewTemplateController : ApiController
    {
        [Route("api/QuarterlyReviewTemplate/GetAll")]
        [HttpGet]
        public Result<IList<QuarterlyReviewTemplate>> GetAll(int clientId)
        {
            var result = new Result<IList<QuarterlyReviewTemplate>>();
            QuarterlyReviewTemplateService quarterlyReviewTemplateService = new QuarterlyReviewTemplateService();

            result.Value = quarterlyReviewTemplateService.Get(clientId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/QuarterlyReviewTemplate/Add")]
        [HttpPost]
        public Result Add(IList<QuarterlyReviewTemplate> quarterlyReviewTemplates)
        {
            var result = new Result();
            try
            {
                QuarterlyReviewTemplateService quarterlyReviewTemplateService = new QuarterlyReviewTemplateService();
                quarterlyReviewTemplateService.Add(quarterlyReviewTemplates);
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
