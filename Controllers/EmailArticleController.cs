using FinancialPlanner.BusinessLogic;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class EmailArticleController : ApiController
    {
        // GET: api/EmailArticle
        [HttpGet]
        [Route("api/EmailArticle/Get")]
        public Result<IList<EmailArticle>> Get()
        {
            var result = new Result<IList<EmailArticle>>();
            EmailArticleService emailArticleService = new EmailArticleService();

            var lstEmailArticle = emailArticleService.Get();
            result.Value = (IList<EmailArticle>)lstEmailArticle;
            result.IsSuccess = true;
            return result;
        }


        [HttpPost]
        [Route("api/EmailArticle/Add")]
        public Result Add(EmailArticle emailArticle)
        {
            var result = new Result();
            try
            {                
                EmailArticleService emailArticleService = new EmailArticleService();
                emailArticleService.Add(emailArticle);
                result.IsSuccess = true;               
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = ex;
            }
            return result;
        }

        [HttpPost]
        [Route("api/EmailArticle/Update")]
        public Result Update(EmailArticle emailArticle)
        {
            var result = new Result();
            try
            {
                EmailArticleService emailArticleService = new EmailArticleService();
                emailArticleService.Update(emailArticle);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = ex;
            }
            return result;
        }

        [HttpPost]
        [Route("api/EmailArticle/Delete")]
        public Result Delete(EmailArticle emailArticle)
        {
            var result = new Result();
            try
            {
                EmailArticleService emailArticleService = new EmailArticleService();
                emailArticleService.Delete(emailArticle);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = ex;
            }
            return result;
        }
    }
}
