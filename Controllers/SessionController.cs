using FinancialPlanner.BusinessLogic.Users;
using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Security;
using static System.Collections.Specialized.NameObjectCollectionBase;

namespace FinancialPlanner.Controllers
{
    public class SessionController : ApiController
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            //base.Initialize(controllerContext);
        //    if (!IsValidSessionAvailable())
        //    {
        //        ClearSession();
        //    }
        //    else
        //    {
        //        //ObjectContext objContext = new ObjectContext(WebApiApplication.WindowsAuthenticationEnabled, _currentUser);
        //        IPrincipal principal = new GenericPrincipal(new GenericIdentity("Admin"), new string[] { "admin" });
        //        Thread.CurrentPrincipal = principal;
        //        HttpContext.Current.User = principal;
        //    }
        }

        private bool IsValidSessionAvailable()
        {
            var httpContextWrapper = GetHttpContextWrapper();

            if (httpContextWrapper == null ||
                httpContextWrapper.Request == null ||
                httpContextWrapper.Request.Cookies == null)
                return false;
            if (valideClientToken(httpContextWrapper.Request.Cookies,
                httpContextWrapper.Request.UserHostName))
                return true;
            else
                return false;
        }

        // TODO : Add code to read cookies data from database and compare. If cookies match update last access time.
        private bool valideClientToken(HttpCookieCollection cookies, string userHostName)
        {
            try
            {
                Logger.LogInfo("Validate client token process start.");
                UserSession userSession = new UserSession();
                bool isValidSession = false;
                UserSessionService userSessionService = new UserSessionService();
                if (cookies != null)
                {

                    for (int i = 0; i <= cookies.Keys.Count - 1; i++)
                    {
                        var cookieKey = cookies.Keys.Get(i);
                        if (cookieKey == WebApiApplication.USERNAME)
                        {
                            userSession = userSessionService.Get(int.Parse(cookies[i].Value));                           
                        }
                        if (cookieKey == WebApiApplication.CLIENT_Token &&
                            cookies[i].Value == userSession.UserToken && 
                            DateTime.Now < userSession.ExpireOn)
                        {                           
                            userSession.LastPingTime = DateTime.Now;
                            userSession.MachineName = userHostName;
                            isValidSession = true;
                        }
                    }                 
                }
                if (isValidSession)
                {                   
                    userSessionService.UpdateSession(userSession);
                }
                else
                {
                    Logger.LogInfo("Invalid client token.");
                }
                Logger.LogInfo("Validate client token process completed.");
                return isValidSession;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return false;
            }
        }

        private void LogDebug(string methodName, Exception ex)
        {
            DebuggerLogInfo debuggerInfo = new DebuggerLogInfo();
            debuggerInfo.ClassName = this.GetType().Name;
            debuggerInfo.Method = methodName;
            debuggerInfo.ExceptionInfo = ex;
            Logger.LogDebug(debuggerInfo);
        }

        protected HttpContextWrapper GetHttpContextWrapper()
        {
            HttpContextWrapper httpContextWrapper = null;

            if (HttpContext.Current != null)
            {
                httpContextWrapper = new HttpContextWrapper(HttpContext.Current);
            }
            else if (Request.Properties.ContainsKey("MS_HttpContext"))
            {
                httpContextWrapper = (HttpContextWrapper)Request.Properties["MS_HttpContext"];
            }
            return httpContextWrapper;
        }
        protected void SetSession(int userId)
        {
            var httpContextWrapper = GetHttpContextWrapper();
            //var newAuthToken = Guid.NewGuid().ToString();
            //SessionDataProvider.SetUserDetail(user);
            SetUserInSession(userId);
            SetCLIENTTokenInSession(userId);

            FormsAuthentication.SetAuthCookie(Guid.NewGuid().ToString(), false);
            //StoreSessionCookieInCache(httpContextWrapper);
            //ObjectContext objContext = new ObjectContext(WebApiApplication.WindowsAuthenticationEnabled, GetUser());
        }

        private void SetUserInSession(int userId)
        {
            HttpCookie userNameCookie = new HttpCookie(WebApiApplication.USERNAME, userId.ToString());            
            HttpContext.Current.Response.Cookies.Add(userNameCookie);
        }

        private void SetCLIENTTokenInSession(int userId)
        {
            string clientTokenValue;            
            //SessionCacheData sessionCacheData = WebApiApplication.SessionCacheService.Get(userName);
            //if (sessionCacheData != null && !string.IsNullOrWhiteSpace(sessionCacheData.XCSRFTokenValue))
            //{
            //    clientTokenValue = sessionCacheData.XCSRFTokenValue;
            //}
            //else
            //{
            clientTokenValue = Guid.NewGuid().ToString();
            //}
            //SessionDataProvider.SetXCSRFToken(xcsrfTokenValue);
            var httpContextWrapper = GetHttpContextWrapper();


            HttpCookie clientToken = new HttpCookie(WebApiApplication.CLIENT_Token, clientTokenValue);
            HttpContext.Current.Response.Cookies.Add(clientToken);
            UserSession userSession = new UserSession();
            userSession.UserId = userId;
            userSession.UserToken = clientTokenValue;
            userSession.LastPingTime = DateTime.Now;
            userSession.MachineName = httpContextWrapper.Request.UserHostName;
            UserSessionService userSessionService = new UserSessionService();
            userSessionService.AddSession(userSession);
            
            //HttpContext.Current.Session.Contents.Add(WebApiApplication.CLIENT_Token, clientTokenValue);
            //HttpContext.Current.Session.Add(WebApiApplication.CLIENT_Token, clientTokenValue);
        }
        protected void ClearSession()
        {
            //LogMessage("1. Clear Session Started");
            var httpContextWrapper = GetHttpContextWrapper();
            //LogMessage("2. Get HttpContext Wrapper");
            //httpContextWrapper.Session.Abandon();
            //LogMessage("3. Abondoned Session");
            httpContextWrapper.Request.Cookies.Clear();
            //LogMessage("4. Flushed all request cookies");
            FormsAuthentication.SignOut();
            //LogMessage("5. Signedout Finally");
        }
    }
}
