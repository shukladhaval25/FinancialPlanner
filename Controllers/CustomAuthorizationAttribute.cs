using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace FinancialPlanner.Controllers
{
    internal class CustomAuthorizationAttribute : ActionFilterAttribute
    {
        //public Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        //{
        //    //throw new NotImplementedException();
        //    actionContext.Request.
        //}
        //Task<HttpResponseMessage> IAuthorizationFilter.ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        //{
        //    throw new NotImplementedException();
        //}
        bool isAuthorized = false;
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} executing at {1}", actionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString()), "Web API Logs");
            if (actionContext.Request.Headers.Contains("Token"))
            {
                System.Collections.Generic.IEnumerable<string> tokenValue = actionContext.Request.Headers.GetValues("Token");
                if (!((string[])tokenValue)[0].Equals("1234567890"))
                {
                    //actionContext.Response.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                    //throw new System.UnauthorizedAccessException("Invalid user token.");
                    //return actionContext.Response.StatusCode;
                    //actionExecutedContext.Response.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                    isAuthorized = false;
                }
                else
                {
                    isAuthorized = true;
                }
            }
            else
            {
                isAuthorized = false;
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} executed at {1}", actionExecutedContext.ActionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString()), "Web API Logs");
            if (!isAuthorized)
            {
                actionExecutedContext.Response.Content = null;
                actionExecutedContext.Response.StatusCode = System.Net.HttpStatusCode.Unauthorized;
            }
        }
    }
}